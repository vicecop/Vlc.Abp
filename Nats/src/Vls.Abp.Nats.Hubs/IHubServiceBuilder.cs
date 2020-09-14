﻿using Microsoft.Extensions.DependencyInjection;
using NATS.Client;
using System;

namespace Vls.Abp.Nats.Hubs
{
    public interface IHubServiceBuilder
    {
        HubServiceBuilder Configure(Action<HubServiceOptions> options);
        HubServiceBuilder AddMsgEventHandler(EventHandler<MsgHandlerEventArgs> eventHandler);
        HubServiceBuilder AddContractHandler<TContract, TImplementation>(Func<IServiceProvider, ObjectFactory> factory = null)
            where TContract : class
            where TImplementation : class, TContract;
        HubServiceBuilder AddContractHandler<TContract, TImplementation>(INatsSerializer serializer, Func<IServiceProvider, ObjectFactory> factory = null)
            where TContract : class
            where TImplementation : class, TContract;
    }
}

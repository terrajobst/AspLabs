// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Grpc.HttpApi;
using Grpc.AspNetCore.Server.Model;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for the gRPC HTTP API services.
    /// </summary>
    public static class GrpcSwaggerServiceExtensions
    {
        /// <summary>
        /// Adds gRPC HTTP API services to the specified <see cref="IServiceCollection" />.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> for adding services.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IServiceCollection AddGrpcSwagger(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddGrpcHttpApi();
            services.TryAddSingleton<IApiDescriptionGroupCollectionProvider, GrpcHttpApiDescriptionProvider>();

            return services;
        }
    }
}

﻿using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Extensions).Assembly));
            services.AddAutoMapper(typeof(Extensions));

            return services;
        }

        /// <summary>
        /// Validates if the string is a 24-character hexadecimal ID.
        /// </summary>
        /// <param name="id">The string to check.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidHex24Id(this string id)
        {
            return id.Length == 24 &&
                   id.All(c => (c >= '0' && c <= '9') ||
                               (c >= 'a' && c <= 'f') ||
                               (c >= 'A' && c <= 'F'));
        }
    }
}

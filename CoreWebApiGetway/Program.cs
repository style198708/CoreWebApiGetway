using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreWebApiGetway
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // IWebHostBuilder builder = new WebHostBuilder();
           // builder.ConfigureServices(s =>
           // {
           //     s.AddSingleton(builder);
           // });
           // builder.UseKestrel()
           //.UseUrls("http://localhost:5000")
           //.UseContentRoot(Directory.GetCurrentDirectory())
           //.UseIISIntegration()
           //.UseStartup<Startup>()
           //.UseApplicationInsights();
           // var host = builder.Build();
           // host.Run();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder builder = new WebHostBuilder();
            return builder.ConfigureServices(s =>
                    {
                         s.AddSingleton(builder);
                    })
                  .UseKestrel()
                  .UseUrls("http://localhost:5000")
                  .UseContentRoot(Directory.GetCurrentDirectory())
                  .UseIISIntegration()
                  .UseStartup<Startup>()
                  .UseApplicationInsights()
                  .Build();
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DGNuGetTestWA.Startup))]
namespace DGNuGetTestWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

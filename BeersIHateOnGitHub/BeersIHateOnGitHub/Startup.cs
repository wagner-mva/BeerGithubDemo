using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeersIHateOnGitHub.Startup))]
namespace BeersIHateOnGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

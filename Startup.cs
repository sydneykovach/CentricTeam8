using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricTeam8.Startup))]
namespace CentricTeam8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

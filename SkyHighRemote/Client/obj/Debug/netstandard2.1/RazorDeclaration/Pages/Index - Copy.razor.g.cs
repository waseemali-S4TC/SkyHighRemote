#pragma checksum "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\Pages\Index - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f49a30a2246e53e073c1b71172c3a3be6a68341"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SkyHighRemote.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using SkyHighRemote.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using SkyHighRemote.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\_Imports.razor"
using SkyHighRemote.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Source\Repos\Automation\SkyHighRemote\SkyHighRemote\Client\Pages\Index - Copy.razor"
       

    protected override void OnInitialized()
    {
        Console.WriteLine($"Hosting Environment : {HostEnvironment.Environment}");
    }

    //private SkyHDBox[] boxes;

    private async Task SendCommand(string command)
    {
        HttpResponseMessage response = await Http.PostAsync($"skyremote/sendcommand/192.168.1.67/{command}", null);

        if (HostEnvironment.IsDevelopment())
        {
            Console.WriteLine(response);
        }
    }

    /// <summary>
    /// Throws up a popup when a button isn't implemented
    /// </summary>
    /// <param name="button">The name of the button</param>
    /// <returns></returns>
    private async Task NotImplemented(string button)
    {
        await JsRuntime.InvokeVoidAsync("alert", $"Button '{button}' is not implemented.");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebAssemblyHostEnvironment HostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
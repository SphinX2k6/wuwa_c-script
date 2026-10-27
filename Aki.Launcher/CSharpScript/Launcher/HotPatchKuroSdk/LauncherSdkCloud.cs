using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001DE RID: 478
	public class LauncherSdkCloud : LauncherSdkBase
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x0004DB70 File Offset: 0x0004BD70
		[NullableContext(1)]
		public override void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			string data = JsonSerializer.Serialize<Dictionary<string, object>>(new Dictionary<string, object>
			{
				{
					"title",
					title
				},
				{
					"url",
					url
				},
				{
					"transparent",
					transparent
				},
				{
					"webAccelerated",
					webAccelerated
				},
				{
					"isLandscape",
					isLandscape
				},
				{
					"identifier",
					identifier
				}
			}, null);
			UKuroCloudGameWrapper.SendDataToPipeBinaryWithKey("OpenWebView", data);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E3 RID: 483
	public class LauncherSdkCloud : LauncherSdkBase
	{
		// Token: 0x06000D00 RID: 3328 RVA: 0x000505D4 File Offset: 0x0004E7D4
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

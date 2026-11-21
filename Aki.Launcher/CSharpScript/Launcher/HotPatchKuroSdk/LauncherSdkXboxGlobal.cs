using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EA RID: 490
	public class LauncherSdkXboxGlobal : LauncherSdkBase
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x00050D50 File Offset: 0x0004EF50
		[NullableContext(1)]
		public override void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			bool flag = false;
			if (transparent)
			{
				flag = true;
			}
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
					"titleBar",
					flag
				},
				{
					"webAccelerated",
					webAccelerated
				},
				{
					"identifier",
					identifier
				},
				{
					"innerbrowser",
					true
				}
			}, null);
			UKuroSDKManager.OpenWebView(url, title, isLandscape, transparent, webAccelerated, identifier, data);
		}
	}
}

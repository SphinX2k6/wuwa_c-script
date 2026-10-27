using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001DF RID: 479
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkAndroid : LauncherSdkBase
	{
		// Token: 0x06000CC2 RID: 3266 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
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
				},
				{
					"refreshButtonShowed",
					true
				},
				{
					"transparentCloseButtonAlwaysShowed",
					false
				},
				{
					"showInDialog",
					true
				}
			}, null);
			UKuroSDKManager.OpenWebView(url, title, isLandscape, transparent, webAccelerated, identifier, data);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0004DCB0 File Offset: 0x0004BEB0
		protected override string GetPlatformFontStr()
		{
			string deviceFontAsset = base.GetDeviceFontAsset();
			return JsonSerializer.Serialize<Dictionary<string, string>>(new Dictionary<string, string>
			{
				{
					"fontType",
					"1"
				},
				{
					"fontPath",
					deviceFontAsset
				}
			}, null);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0004DCEC File Offset: 0x0004BEEC
		public override string GetChannelId()
		{
			string[] array = UKuroSDKManager.GetSdkParams("").Split(',', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split('=', StringSplitOptions.None);
				if (array2.Length == 2 && array2[0] == "channelId")
				{
					return array2[1];
				}
			}
			return "";
		}
	}
}

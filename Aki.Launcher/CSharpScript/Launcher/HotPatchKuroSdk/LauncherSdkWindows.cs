using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E2 RID: 482
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkWindows : LauncherSdkBase
	{
		// Token: 0x06000CCE RID: 3278 RVA: 0x0004DE20 File Offset: 0x0004C020
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
					"innerbrowser",
					true
				},
				{
					"identifier",
					identifier
				}
			}, null);
			UKuroSDKManager.OpenWebView(url, title, isLandscape, transparent, webAccelerated, identifier, data);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0004DEA4 File Offset: 0x0004C0A4
		protected override string GetPlatformFontStr()
		{
			string currentFontName = base.GetCurrentFontName();
			string value = UBlueprintPathsLibrary.RootDir() + "Client/Binaries/Win64/ThirdParty/KrPcSdk_Mainland/" + base.GetDeviceFontAsset();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("name", currentFontName);
			dictionary.Add("path", value);
			JsonSerializerOptions options = new JsonSerializerOptions
			{
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			};
			return JsonSerializer.Serialize<Dictionary<string, string>>(dictionary, options);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0004DF04 File Offset: 0x0004C104
		public override string GetChannelId()
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			if (!base.IsValidJsonStr(sdkParams))
			{
				return "";
			}
			UserInfo userInfo = JsonSerializer.Deserialize<UserInfo>(sdkParams, null);
			return ((userInfo != null) ? userInfo.channelId : null) ?? "";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E3 RID: 483
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkWindowsGlobal : LauncherSdkBase
	{
		// Token: 0x06000CD2 RID: 3282 RVA: 0x0004DF50 File Offset: 0x0004C150
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

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0004DFEC File Offset: 0x0004C1EC
		protected override string GetPlatformFontStr()
		{
			string currentFontName = base.GetCurrentFontName();
			string value = UBlueprintPathsLibrary.RootDir() + "Client/Binaries/Win64/ThirdParty/KrPcSdk_Global/" + base.GetDeviceFontAsset();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("name", currentFontName);
			dictionary.Add("path", value);
			JsonSerializerOptions options = new JsonSerializerOptions
			{
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			};
			return JsonSerializer.Serialize<Dictionary<string, string>>(dictionary, options);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0004E04C File Offset: 0x0004C24C
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

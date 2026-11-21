using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E7 RID: 487
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkWindows : LauncherSdkBase
	{
		// Token: 0x06000D0E RID: 3342 RVA: 0x0005089C File Offset: 0x0004EA9C
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

		// Token: 0x06000D0F RID: 3343 RVA: 0x00050920 File Offset: 0x0004EB20
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

		// Token: 0x06000D10 RID: 3344 RVA: 0x00050980 File Offset: 0x0004EB80
		public override string GetChannelId()
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			if (!base.IsValidJsonStr(sdkParams))
			{
				return "";
			}
			UserInfo userInfo = JsonSerializer.Deserialize<UserInfo>(sdkParams, new JsonSerializerOptions
			{
				IncludeFields = true
			});
			return ((userInfo != null) ? userInfo.channelId : null) ?? "";
		}
	}
}

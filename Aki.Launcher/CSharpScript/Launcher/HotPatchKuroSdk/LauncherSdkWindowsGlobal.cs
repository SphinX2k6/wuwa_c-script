using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E8 RID: 488
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkWindowsGlobal : LauncherSdkBase
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x000509D8 File Offset: 0x0004EBD8
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

		// Token: 0x06000D13 RID: 3347 RVA: 0x00050A74 File Offset: 0x0004EC74
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

		// Token: 0x06000D14 RID: 3348 RVA: 0x00050AD4 File Offset: 0x0004ECD4
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

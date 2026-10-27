using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E4 RID: 484
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkOpenHarmony : LauncherSdkBase
	{
		// Token: 0x06000CD6 RID: 3286 RVA: 0x0004E098 File Offset: 0x0004C298
		public override void CloseWebView(string reason)
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				base.CloseWebView(reason);
				return;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "LauncherSdkOpenHarmony CloseWebView";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (LauncherSdk.canUseSdk())
			{
				UKuroSDKManager.CloseWebView(JsonSerializer.Serialize<Dictionary<string, string>>(new Dictionary<string, string>
				{
					{
						"identifier",
						"Default"
					}
				}, null));
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0004E104 File Offset: 0x0004C304
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

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0004E1BC File Offset: 0x0004C3BC
		protected override string GetPlatformFontStr()
		{
			string value = "Font/" + base.GetDeviceFontAsset();
			string currentFontName = base.GetCurrentFontName();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("fontPath", value);
			dictionary.Add("fontName", currentFontName);
			JsonSerializerOptions options = new JsonSerializerOptions
			{
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			};
			return JsonSerializer.Serialize<Dictionary<string, string>>(dictionary, options);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0004E218 File Offset: 0x0004C418
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

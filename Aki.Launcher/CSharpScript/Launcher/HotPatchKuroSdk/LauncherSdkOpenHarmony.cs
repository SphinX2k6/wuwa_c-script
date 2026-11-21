using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E9 RID: 489
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkOpenHarmony : LauncherSdkBase
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x00050B2C File Offset: 0x0004ED2C
		[return: Nullable(2)]
		protected override string ParseGameWindowStateStatusJson(string result)
		{
			OpenHarmonyGameWindowStateData openHarmonyGameWindowStateData = JsonSerializer.Deserialize<OpenHarmonyGameWindowStateData>(result, new JsonSerializerOptions
			{
				IncludeFields = true,
				NumberHandling = JsonNumberHandling.AllowReadingFromString
			});
			if (openHarmonyGameWindowStateData == null)
			{
				return null;
			}
			if (openHarmonyGameWindowStateData.status == null)
			{
				return null;
			}
			return openHarmonyGameWindowStateData.status.GetValueOrDefault().ToString();
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00050B78 File Offset: 0x0004ED78
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

		// Token: 0x06000D18 RID: 3352 RVA: 0x00050BE4 File Offset: 0x0004EDE4
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

		// Token: 0x06000D19 RID: 3353 RVA: 0x00050C9C File Offset: 0x0004EE9C
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

		// Token: 0x06000D1A RID: 3354 RVA: 0x00050CF8 File Offset: 0x0004EEF8
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

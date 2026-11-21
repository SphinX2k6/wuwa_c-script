using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E5 RID: 485
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkIosGlobal : LauncherSdkBase
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x000507B0 File Offset: 0x0004E9B0
		public override void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, "");
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000507C5 File Offset: 0x0004E9C5
		protected override string GetPlatformFontStr()
		{
			return base.GetDeviceFontAsset();
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000507D0 File Offset: 0x0004E9D0
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

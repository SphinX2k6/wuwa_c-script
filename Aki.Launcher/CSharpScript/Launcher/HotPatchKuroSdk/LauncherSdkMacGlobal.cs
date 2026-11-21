using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E6 RID: 486
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkMacGlobal : LauncherSdkBase
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x00050826 File Offset: 0x0004EA26
		public override void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, "");
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0005083B File Offset: 0x0004EA3B
		protected override string GetPlatformFontStr()
		{
			return base.GetDeviceFontAsset();
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00050844 File Offset: 0x0004EA44
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

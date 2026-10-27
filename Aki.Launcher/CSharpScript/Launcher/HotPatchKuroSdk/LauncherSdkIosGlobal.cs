using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E0 RID: 480
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkIosGlobal : LauncherSdkBase
	{
		// Token: 0x06000CC6 RID: 3270 RVA: 0x0004DD4C File Offset: 0x0004BF4C
		public override void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, "");
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0004DD61 File Offset: 0x0004BF61
		protected override string GetPlatformFontStr()
		{
			return base.GetDeviceFontAsset();
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0004DD6C File Offset: 0x0004BF6C
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

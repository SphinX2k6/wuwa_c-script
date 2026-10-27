using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E1 RID: 481
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkMacGlobal : LauncherSdkBase
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x0004DDB7 File Offset: 0x0004BFB7
		public override void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, "");
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		protected override string GetPlatformFontStr()
		{
			return base.GetDeviceFontAsset();
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0004DDD4 File Offset: 0x0004BFD4
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

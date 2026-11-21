using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Notice
{
	// Token: 0x020001AB RID: 427
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNoticeUtils : Singleton
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x0004BC70 File Offset: 0x00049E70
		[NullableContext(2)]
		public void OpenNotice(string logMsg = null)
		{
			if (Platform.Instance.IsCloudGame() && CloudGameManagerLauncher.Instance.IsPreLaunch)
			{
				return;
			}
			if (Platform.Instance.IsXboxPlatform() || Platform.Instance.IsPs5Platform())
			{
				return;
			}
			if (this.HasNoticeAutoOpened)
			{
				return;
			}
			if (logMsg != null)
			{
				LauncherLog.Instance.Info("热更公告日志: " + logMsg, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.OpenNoticeImp();
			this.HasNoticeAutoOpened = true;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0004BCE6 File Offset: 0x00049EE6
		public void CloseNotice(string reason)
		{
			LauncherSdk.Get().CloseWebView(reason);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0004BCF3 File Offset: 0x00049EF3
		public void OpenNoticeByUser()
		{
			this.OpenNoticeImp();
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0004BCFC File Offset: 0x00049EFC
		public bool CheckGrayBoxHit()
		{
			return true;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0004BD0C File Offset: 0x00049F0C
		private void OpenNoticeImp()
		{
			if (!this.CheckGrayBoxHit())
			{
				return;
			}
			string noticeUrl = this.GetNoticeUrl();
			if (this.CanUseSdk())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "热更阶段打开公告 - sdk旧";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Url", noticeUrl);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SdkOpenNotice(noticeUrl);
				return;
			}
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "热更阶段打开公告 - sdk新";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Url", noticeUrl);
				instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenWebView(noticeUrl, null);
				return;
			}
			LauncherLog instance3 = LauncherLog.Instance;
			string message3 = "热更阶段打开公告 - 无sdk";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Url", noticeUrl);
			instance3.Info(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenExternalUrl(noticeUrl);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0004BDD0 File Offset: 0x00049FD0
		private void SdkOpenNotice(string url)
		{
			LauncherSdkBase launcherSdkBase = LauncherSdk.Get();
			launcherSdkBase.SetFont();
			launcherSdkBase.OpenUrl("", url, true, true, true, "Default");
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0004BDF0 File Offset: 0x00049FF0
		public string GetNoticeUrl()
		{
			string noticePreUrl = this.GetNoticePreUrl();
			string serverId = this.GetServerId();
			string value = LauncherLanguageLib.Instance.PackageLanguage ?? "";
			string deviceId = this.GetDeviceId();
			string value2 = "1000000000";
			string value3 = this.IsGlobalSdk() ? "global" : "cn";
			string gameId = this.GetGameId();
			string channelId = this.GetChannelId();
			string platformStr = this.GetPlatformStr();
			string value4 = "before_login";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 10);
			defaultInterpolatedStringHandler.AppendFormatted(noticePreUrl);
			defaultInterpolatedStringHandler.AppendLiteral("?server_id=");
			defaultInterpolatedStringHandler.AppendFormatted(serverId);
			defaultInterpolatedStringHandler.AppendLiteral("&role_id=");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("&user_id=");
			defaultInterpolatedStringHandler.AppendFormatted(value4);
			defaultInterpolatedStringHandler.AppendLiteral("&game_id=");
			defaultInterpolatedStringHandler.AppendFormatted(gameId);
			defaultInterpolatedStringHandler.AppendLiteral("&svr_area=");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral("&did=");
			defaultInterpolatedStringHandler.AppendFormatted(deviceId);
			defaultInterpolatedStringHandler.AppendLiteral("&channel=");
			defaultInterpolatedStringHandler.AppendFormatted(channelId);
			defaultInterpolatedStringHandler.AppendLiteral("&platform=");
			defaultInterpolatedStringHandler.AppendFormatted(platformStr);
			defaultInterpolatedStringHandler.AppendLiteral("&lang=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0004BF36 File Offset: 0x0004A136
		private bool CanUseSdk()
		{
			return !PlatformSdkManagerNew.Instance.IsSdkOn && UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004BF6B File Offset: 0x0004A16B
		private bool IsGlobalSdk()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0004BF86 File Offset: 0x0004A186
		private string GetDefaultServerId()
		{
			if (!this.IsGlobalSdk())
			{
				return "76402e5b20be2c39f095a152090afddc";
			}
			return "86d52186155b148b5c138ceb41be9650";
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0004BF9C File Offset: 0x0004A19C
		private string GetServerId()
		{
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			List<ILoginServersData> list = (cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.LoginServers : null;
			if (list == null || list.Count == 0)
			{
				return this.GetDefaultServerId();
			}
			return list[0].id ?? this.GetDefaultServerId();
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		private string GetGameId()
		{
			if (!this.IsGlobalSdk())
			{
				return "G152";
			}
			return "G153";
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0004BFFD File Offset: 0x0004A1FD
		private string GetNoticePreUrl()
		{
			if (!this.IsGlobalSdk())
			{
				return "https://aki-gm-resources.aki-game.com/aki/announcement/index.html";
			}
			return "https://aki-gm-resources-oversea.aki-game.net/aki/announcement/index.html";
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0004C012 File Offset: 0x0004A212
		private string GetDeviceId()
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetDeviceId();
			}
			if (this.CanUseSdk())
			{
				return UKuroSDKManager.GetBasicInfo().DeviceId ?? "";
			}
			return "";
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0004C051 File Offset: 0x0004A251
		private string GetChannelId()
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetChannelId();
			}
			if (this.CanUseSdk())
			{
				return LauncherSdk.Get().GetChannelId();
			}
			return "";
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0004C088 File Offset: 0x0004A288
		private string GetPlatformStr()
		{
			if (Platform.Instance.IsAndroidPlatform())
			{
				return "Android";
			}
			if (Platform.Instance.IsIOSPlatform())
			{
				return "iOS";
			}
			if (Platform.Instance.IsMacPlatform())
			{
				return "Mac";
			}
			if (Platform.Instance.IsPs5Platform())
			{
				return "PS5";
			}
			if (Platform.Instance.IsXSXPlatform())
			{
				return "XSX";
			}
			if (Platform.Instance.IsWinGDKPlatform())
			{
				return "WinGDK";
			}
			if (Platform.Instance.IsOpenHarmonyPlatform())
			{
				return "OpenHarmony";
			}
			return "PC";
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0004C118 File Offset: 0x0004A318
		public static LauncherNoticeUtils Instance
		{
			get
			{
				if (LauncherNoticeUtils._instance == null)
				{
					LauncherNoticeUtils._instance = new LauncherNoticeUtils();
					LauncherNoticeUtils._instance.OnInit();
				}
				return LauncherNoticeUtils._instance;
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0004C13B File Offset: 0x0004A33B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0004C13D File Offset: 0x0004A33D
		public static void ResetStaticDefaultValue()
		{
			LauncherNoticeUtils instance = LauncherNoticeUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherNoticeUtils._instance = null;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0004C156 File Offset: 0x0004A356
		static LauncherNoticeUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherNoticeUtils.CreateStaticDefaultValue), new Action(LauncherNoticeUtils.ResetStaticDefaultValue));
		}

		// Token: 0x04000787 RID: 1927
		public bool HasNoticeAutoOpened;

		// Token: 0x04000788 RID: 1928
		public int NoticeOpenDownloadSizeThreshold = 500;

		// Token: 0x04000789 RID: 1929
		[Nullable(2)]
		private static LauncherNoticeUtils _instance;
	}
}

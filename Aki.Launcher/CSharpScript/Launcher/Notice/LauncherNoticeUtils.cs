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
	// Token: 0x020001A7 RID: 423
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNoticeUtils : Singleton
	{
		// Token: 0x06000BA0 RID: 2976 RVA: 0x00049480 File Offset: 0x00047680
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

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000494F6 File Offset: 0x000476F6
		public void CloseNotice(string reason)
		{
			LauncherSdk.Get().CloseWebView(reason);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00049503 File Offset: 0x00047703
		public void OpenNoticeByUser()
		{
			this.OpenNoticeImp();
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0004950C File Offset: 0x0004770C
		public bool CheckGrayBoxHit()
		{
			return true;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0004951C File Offset: 0x0004771C
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

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000495E0 File Offset: 0x000477E0
		private void SdkOpenNotice(string url)
		{
			LauncherSdkBase launcherSdkBase = LauncherSdk.Get();
			launcherSdkBase.SetFont();
			launcherSdkBase.OpenUrl("", url, true, true, true, "Default");
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00049600 File Offset: 0x00047800
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

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00049746 File Offset: 0x00047946
		private bool CanUseSdk()
		{
			return !PlatformSdkManagerNew.Instance.IsSdkOn && UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0004977B File Offset: 0x0004797B
		private bool IsGlobalSdk()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00049796 File Offset: 0x00047996
		private string GetDefaultServerId()
		{
			if (!this.IsGlobalSdk())
			{
				return "76402e5b20be2c39f095a152090afddc";
			}
			return "86d52186155b148b5c138ceb41be9650";
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000497AC File Offset: 0x000479AC
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

		// Token: 0x06000BAB RID: 2987 RVA: 0x000497F8 File Offset: 0x000479F8
		private string GetGameId()
		{
			if (!this.IsGlobalSdk())
			{
				return "G152";
			}
			return "G153";
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0004980D File Offset: 0x00047A0D
		private string GetNoticePreUrl()
		{
			if (!this.IsGlobalSdk())
			{
				return "https://aki-gm-resources.aki-game.com/aki/announcement/index.html";
			}
			return "https://aki-gm-resources-oversea.aki-game.net/aki/announcement/index.html";
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00049822 File Offset: 0x00047A22
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

		// Token: 0x06000BAE RID: 2990 RVA: 0x00049861 File Offset: 0x00047A61
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

		// Token: 0x06000BAF RID: 2991 RVA: 0x00049898 File Offset: 0x00047A98
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00049928 File Offset: 0x00047B28
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

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004994B File Offset: 0x00047B4B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0004994D File Offset: 0x00047B4D
		public static void ResetStaticDefaultValue()
		{
			LauncherNoticeUtils instance = LauncherNoticeUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherNoticeUtils._instance = null;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00049966 File Offset: 0x00047B66
		static LauncherNoticeUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherNoticeUtils.CreateStaticDefaultValue), new Action(LauncherNoticeUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0400074A RID: 1866
		public bool HasNoticeAutoOpened;

		// Token: 0x0400074B RID: 1867
		public int NoticeOpenDownloadSizeThreshold = 500;

		// Token: 0x0400074C RID: 1868
		[Nullable(2)]
		private static LauncherNoticeUtils _instance;
	}
}

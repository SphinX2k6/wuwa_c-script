using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E2 RID: 482
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkBase
	{
		// Token: 0x06000CD8 RID: 3288 RVA: 0x0004FA8C File Offset: 0x0004DC8C
		public unsafe void Init()
		{
			LauncherLog.Instance.Info("LauncherSdkBase Init", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (LauncherSdk.canUseSdk())
			{
				this.BindSdkLoginCallback();
				this.BindSdkFocusCallback();
				this.BindSdkExitCallback();
				this.BindSdkLogoutCallback();
				this.BindSdkKickCallback();
			}
			this.ifGlobalSdk = LauncherSdk.IsGlobalSdk();
			if (Platform.Instance.IsAndroidPlatform() || Platform.Instance.IsOpenHarmonyPlatform())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "LauncherSdkBase Init FoldState";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isFoldable", this.IsFoldableScreen());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isFolded", this.IsScreenFolded());
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.BindNativeFoldStateChangeCallback();
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0004FB64 File Offset: 0x0004DD64
		private void RefreshCursor()
		{
			string str = "Aki/Cursor";
			string cursor = UBlueprintPathsLibrary.ProjectContentDir() + "/" + str + "/CursorNor.png";
			this.SetCursor(cursor);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0004FB94 File Offset: 0x0004DD94
		public bool GetSdkFocusState()
		{
			return this.SdkFocusState;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0004FB9C File Offset: 0x0004DD9C
		public bool IsFoldableScreen()
		{
			if (Platform.Instance.IsAndroidPlatform())
			{
				return UKuroStaticAndroidLibrary.IsFoldableScreen();
			}
			return Platform.Instance.IsOpenHarmonyPlatform() && UKuroOpenHarmonyLibrary.IsFoldableScreen();
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0004FBC3 File Offset: 0x0004DDC3
		public bool IsScreenFolded()
		{
			if (Platform.Instance.IsAndroidPlatform())
			{
				return UKuroStaticAndroidLibrary.IsScreenFolded();
			}
			return Platform.Instance.IsOpenHarmonyPlatform() && UKuroOpenHarmonyLibrary.IsScreenFolded();
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0004FBEA File Offset: 0x0004DDEA
		public void BindFoldStateChangeCallback(Action<bool> callback)
		{
			this.FoldStateChangeCallback = callback;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0004FBF3 File Offset: 0x0004DDF3
		public void UnbindFoldStateChangeCallback(Action<bool> callback)
		{
			if (this.FoldStateChangeCallback == callback)
			{
				this.FoldStateChangeCallback = null;
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0004FC0C File Offset: 0x0004DE0C
		private void BindNativeFoldStateChangeCallback()
		{
			this.ClearFoldStateChangeCallback();
			Action<bool> action = new Action<bool>(this.OnFoldStateChanged);
			this.NativeFoldStateChangeCallback = action;
			if (Platform.Instance.IsAndroidPlatform())
			{
				FAndroidFoldStateChangeHandler fandroidFoldStateChangeHandler = DelegateUtils.ToManualReleaseDelegate<FAndroidFoldStateChangeHandler>(action);
				UKuroStaticAndroidLibrary.AddAndroidFoldStateChangeDelegate(fandroidFoldStateChangeHandler);
				return;
			}
			if (Platform.Instance.IsOpenHarmonyPlatform())
			{
				FOpenHarmonyFoldStateChangeHandler fopenHarmonyFoldStateChangeHandler = DelegateUtils.ToManualReleaseDelegate<FOpenHarmonyFoldStateChangeHandler>(action);
				UKuroOpenHarmonyLibrary.AddFoldStateChangeDelegate(fopenHarmonyFoldStateChangeHandler);
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0004FC68 File Offset: 0x0004DE68
		public void ClearFoldStateChangeCallback()
		{
			if (Platform.Instance.IsAndroidPlatform())
			{
				UKuroStaticAndroidLibrary.ClearAndroidFoldStateChangeDelegate();
			}
			else if (Platform.Instance.IsOpenHarmonyPlatform())
			{
				UKuroOpenHarmonyLibrary.ClearFoldStateChangeDelegate();
			}
			if (this.NativeFoldStateChangeCallback != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.NativeFoldStateChangeCallback);
				this.NativeFoldStateChangeCallback = null;
			}
			this.FoldStateChangeCallback = null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0004FCBC File Offset: 0x0004DEBC
		private void OnFoldStateChanged(bool isFolded)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "LauncherSdkBase OnFoldStateChanged";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isFolded", isFolded);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action<bool> foldStateChangeCallback = this.FoldStateChangeCallback;
			if (foldStateChangeCallback == null)
			{
				return;
			}
			foldStateChangeCallback(isFolded);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0004FD02 File Offset: 0x0004DF02
		private void BindSdkFocusCallback()
		{
			UKuroSDKManager.Get().GameStateChangeCallBack.Clear();
			UKuroSDKManager.Get().GameStateChangeCallBack.Add(delegate(string result)
			{
				string a = this.ParseGameWindowStateStatus(result);
				bool flag = false;
				if (a == "0")
				{
					flag = true;
				}
				this.SdkFocusState = flag;
				LauncherLog instance = LauncherLog.Instance;
				string message = "LauncherSdkBase BindSdkFocusCallback";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkGetFocus", flag);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			});
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0004FD30 File Offset: 0x0004DF30
		[return: Nullable(2)]
		private string ParseGameWindowStateStatus(string result)
		{
			if (string.IsNullOrWhiteSpace(result))
			{
				return null;
			}
			result = result.Trim();
			if (result.StartsWith('{') || result.StartsWith('['))
			{
				try
				{
					return this.ParseGameWindowStateStatusJson(result);
				}
				catch (JsonException)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "GameWindowState JSON解析失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
					instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
			}
			string[] array = result.Split(',', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split('=', StringSplitOptions.None);
				if (array2.Length == 2 && array2[0] == "status")
				{
					return array2[1];
				}
			}
			return null;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0004FDEC File Offset: 0x0004DFEC
		[return: Nullable(2)]
		protected virtual string ParseGameWindowStateStatusJson(string result)
		{
			GameWindowStateData gameWindowStateData = JsonSerializer.Deserialize<GameWindowStateData>(result, new JsonSerializerOptions
			{
				IncludeFields = true
			});
			if (gameWindowStateData == null)
			{
				return null;
			}
			return gameWindowStateData.status;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0004FE0B File Offset: 0x0004E00B
		private void BindSdkExitCallback()
		{
			UKuroSDKManager.Get().ExitDelegate.Clear();
			UKuroSDKManager.Get().ExitDelegate.Add(delegate()
			{
				LauncherLog.Instance.Info("LauncherSdkBase BindSdkExitCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				KuroApplication.ExitWithReason(false, "SDK");
			});
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0004FE4A File Offset: 0x0004E04A
		private void BindSdkKickCallback()
		{
			UKuroSDKManager.Get().KickDelegate.Clear();
			UKuroSDKManager.Get().KickDelegate.Add(delegate()
			{
				LauncherLog.Instance.Info("LauncherSdkBase BindSdkKickCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearCacheLoginData();
			});
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0004FE76 File Offset: 0x0004E076
		private void BindSdkLogoutCallback()
		{
			UKuroSDKManager.Get().LogoutDelegate.Clear();
			UKuroSDKManager.Get().LogoutDelegate.Add(delegate()
			{
				LauncherLog.Instance.Info("LauncherSdkBase BindSdkLogoutCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearCacheLoginData();
			});
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0004FEA2 File Offset: 0x0004E0A2
		private unsafe void BindSdkLoginCallback()
		{
			UKuroSDKManager.Get().LoginDelegate.Clear();
			UKuroSDKManager.Get().LoginDelegate.Add(delegate(FLoginStruct loginInfo)
			{
				if (loginInfo != null)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "收到登录回调";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", loginInfo.LoginCode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("name", loginInfo.UserName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("uid", loginInfo.Uid);
					instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					this.CacheLoginData = loginInfo;
					if (loginInfo.LoginCode >= 1)
					{
						HotPatchLogReport.Instance.StartupUserId = loginInfo.Uid;
						HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.SdkLoginSuccess, null);
					}
					Action<FLoginStruct> loginCallback = this.LoginCallback;
					if (loginCallback == null)
					{
						return;
					}
					loginCallback(loginInfo);
				}
			});
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0004FED0 File Offset: 0x0004E0D0
		public void Login(Action<FLoginStruct> callback)
		{
			this.RefreshCursor();
			if (string.IsNullOrEmpty(this.LauncherTraceId))
			{
				this.LauncherTraceId = Launch.StartupTraceId;
			}
			this.LoginCallback = callback;
			if (LauncherSdk.canUseSdk())
			{
				this.SetFont();
				HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.SdkLoginStart, null);
				UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogin;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0004FF29 File Offset: 0x0004E129
		public void SetCursor(string path)
		{
			UKuroSDKManager.SetCursor(path);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0004FF34 File Offset: 0x0004E134
		public void Logout()
		{
			if (LauncherSdk.canUseSdk())
			{
				LauncherLog.Instance.Info("HotFixView SDKLogOut", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearCacheLoginData();
				UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogout;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0004FF74 File Offset: 0x0004E174
		public void ClearCacheLoginData()
		{
			LauncherLog.Instance.Info("LauncherSdkBase ClearCacheLoginData", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CacheLoginData = null;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
		public virtual string GetChannelId()
		{
			return "";
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0004FFA8 File Offset: 0x0004E1A8
		public virtual void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			if (LauncherSdk.canUseSdk())
			{
				string sdkOpenUrlWndInfo = this.GetSdkOpenUrlWndInfo(title, url);
				UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenSdkUrlWnd;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, sdkOpenUrlWndInfo ?? "");
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0004FFD9 File Offset: 0x0004E1D9
		protected virtual string GetPlatformFontStr()
		{
			return "";
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0004FFE0 File Offset: 0x0004E1E0
		public void SetFont()
		{
			if (!LauncherSdk.canUseSdk())
			{
				return;
			}
			string platformFontStr = this.GetPlatformFontStr();
			if (platformFontStr != "")
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "LauncherSdkBase SetFont";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fontStr", platformFontStr);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UKuroSDKManager.SetFont(platformFontStr);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00050034 File Offset: 0x0004E234
		private string GetFontAsset()
		{
			string text = LauncherLanguageLib.Instance.GetPackageLanguage() ?? "";
			if (text != null)
			{
				int length = text.Length;
				if (length == 2)
				{
					switch (text[1])
					{
					case 'a':
						if (text == "ja")
						{
							return "MotoyaAporoStdW5.otf";
						}
						break;
					case 'd':
						if (text == "id")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 'e':
						if (text == "de")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 'h':
						if (text == "th")
						{
							return "Kanit-Medium.ttf";
						}
						break;
					case 'i':
						if (text == "vi")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 'n':
						if (text == "en")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 'o':
						if (text == "ko")
						{
							return "SUITE-Bold.otf";
						}
						break;
					case 'r':
						if (text == "fr")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 's':
						if (text == "es")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 't':
						if (text == "pt")
						{
							return "LaguSansBold.otf";
						}
						break;
					case 'u':
						if (text == "ru")
						{
							return "LaguSansBold.otf";
						}
						break;
					}
				}
			}
			return "H7GBKHeavy.TTF";
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000501E0 File Offset: 0x0004E3E0
		public string GetCurrentFontName()
		{
			string fontAsset = this.GetFontAsset();
			if (fontAsset == "LaguSansBold.otf")
			{
				return "Lagu Sans";
			}
			if (fontAsset == "H7GBKHeavy.TTF")
			{
				return "文鼎方新书H7GBK_H";
			}
			if (fontAsset == "MotoyaAporoStdW5.otf")
			{
				return "Motoya Aporo Std W5";
			}
			if (fontAsset == "SUITE-Bold.otf")
			{
				return "SUITE";
			}
			if (!(fontAsset == "Kanit-Medium.ttf"))
			{
				return "文鼎方新书H7GBK_H";
			}
			return "Kanit Medium";
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0005025C File Offset: 0x0004E45C
		public string GetDeviceFontAsset()
		{
			string fontAsset = this.GetFontAsset();
			return this.GetFontPlatformName(fontAsset);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00050278 File Offset: 0x0004E478
		private string GetFontPlatformName(string source)
		{
			if (!Platform.Instance.IsIOSPlatform() && !Platform.Instance.IsMacPlatform())
			{
				return source;
			}
			if (source == "LaguSansBold.otf")
			{
				return "LaguSans-Bold.otf";
			}
			if (source == "H7GBKHeavy.TTF")
			{
				return "ARFangXinShuH7GBK-Heavy.TTF";
			}
			if (source == "MotoyaAporoStdW5.otf")
			{
				return "MotoyaAporoStd-W5.otf";
			}
			if (source == "SUITE-Bold.otf")
			{
				return "SUITE-Bold.otf";
			}
			if (source == "Kanit-Medium.ttf")
			{
				return "Kanit-Medium.ttf";
			}
			return source;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00050300 File Offset: 0x0004E500
		public virtual void CloseWebView(string reason)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "LauncherSdkBase CloseWebView";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				PlatformSdkManagerNew.Instance.GetPlatformSdk().CloseWebView();
				return;
			}
			if (LauncherSdk.canUseSdk())
			{
				UKuroSDKManager.CloseWebView("Default");
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0005035D File Offset: 0x0004E55D
		[return: Nullable(2)]
		protected string GetSdkOpenUrlWndInfo(string title, string url)
		{
			return JsonSerializer.Serialize<Dictionary<string, string>>(new Dictionary<string, string>
			{
				{
					"title",
					title
				},
				{
					"url",
					url
				}
			}, null);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00050384 File Offset: 0x0004E584
		protected bool IsValidJsonStr(string jsonStr)
		{
			bool result;
			try
			{
				JsonDocument.Parse(jsonStr, default(JsonDocumentOptions));
				result = true;
			}
			catch
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "待解析的字符串不合法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", jsonStr);
				instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				result = false;
			}
			return result;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000503E0 File Offset: 0x0004E5E0
		public void ReportChannelEvent(HotPatchLog eventData)
		{
			if (LauncherSdk.canUseSdk())
			{
				UKuroSDKManager.UpdateChannelEvent(JsonSerializer.Serialize<HotPatchLog>(eventData, new JsonSerializerOptions
				{
					IncludeFields = true,
					DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
				}));
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00050407 File Offset: 0x0004E607
		public void ReportMarketingEvent(SdkReportData eventData)
		{
			if (LauncherSdk.canUseSdk())
			{
				UKuroSDKManager.LogMarketingEvent(eventData.GetReportString());
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0005041B File Offset: 0x0004E61B
		public void AdditionReportForSdk(HotPatchLog hotPatchLog, SdkReportData sdkReportData)
		{
			if (Platform.Instance.IsMacPlatform())
			{
				return;
			}
			this.ReportChannelEvent(hotPatchLog);
			if (this.ifGlobalSdk)
			{
				this.ReportMarketingEvent(sdkReportData);
			}
		}

		// Token: 0x04000829 RID: 2089
		private bool SdkFocusState;

		// Token: 0x0400082A RID: 2090
		[Nullable(2)]
		private Action<bool> FoldStateChangeCallback;

		// Token: 0x0400082B RID: 2091
		[Nullable(2)]
		private Action<bool> NativeFoldStateChangeCallback;

		// Token: 0x0400082C RID: 2092
		[Nullable(2)]
		public FLoginStruct CacheLoginData;

		// Token: 0x0400082D RID: 2093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<FLoginStruct> LoginCallback;

		// Token: 0x0400082E RID: 2094
		public string LauncherTraceId = "";

		// Token: 0x0400082F RID: 2095
		private bool ifGlobalSdk;

		// Token: 0x04000830 RID: 2096
		private const string LAGUSANSBOLD = "LaguSansBold.otf";

		// Token: 0x04000831 RID: 2097
		private const string MOTOYTA = "MotoyaAporoStdW5.otf";

		// Token: 0x04000832 RID: 2098
		private const string SUITEBOLD = "SUITE-Bold.otf";

		// Token: 0x04000833 RID: 2099
		private const string H7GBKHEAVY = "H7GBKHeavy.TTF";

		// Token: 0x04000834 RID: 2100
		private const string KANIT = "Kanit-Medium.ttf";
	}
}

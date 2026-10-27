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
	// Token: 0x020001DD RID: 477
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherSdkBase
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004D260 File Offset: 0x0004B460
		public void Init()
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
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
		private void RefreshCursor()
		{
			string str = "Aki/Cursor";
			string cursor = UBlueprintPathsLibrary.ProjectContentDir() + "/" + str + "/CursorNor.png";
			this.SetCursor(cursor);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0004D2E8 File Offset: 0x0004B4E8
		public bool GetSdkFocusState()
		{
			return this.SdkFocusState;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
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

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0004D31C File Offset: 0x0004B51C
		[return: Nullable(2)]
		private string ParseGameWindowStateStatus(string result)
		{
			if (string.IsNullOrEmpty(result))
			{
				return null;
			}
			if (result.StartsWith('{') || result.StartsWith('['))
			{
				try
				{
					GameWindowStateData gameWindowStateData = JsonSerializer.Deserialize<GameWindowStateData>(result, null);
					return (gameWindowStateData != null) ? gameWindowStateData.status : null;
				}
				catch
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

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0004D3DC File Offset: 0x0004B5DC
		private void BindSdkExitCallback()
		{
			UKuroSDKManager.Get().ExitDelegate.Clear();
			UKuroSDKManager.Get().ExitDelegate.Add(delegate()
			{
				LauncherLog.Instance.Info("LauncherSdkBase BindSdkExitCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				KuroApplication.ExitWithReason(false, "SDK");
			});
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0004D41B File Offset: 0x0004B61B
		private void BindSdkKickCallback()
		{
			UKuroSDKManager.Get().KickDelegate.Clear();
			UKuroSDKManager.Get().KickDelegate.Add(delegate()
			{
				LauncherLog.Instance.Info("LauncherSdkBase BindSdkKickCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearCacheLoginData();
			});
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0004D447 File Offset: 0x0004B647
		private void BindSdkLogoutCallback()
		{
			UKuroSDKManager.Get().LogoutDelegate.Clear();
			UKuroSDKManager.Get().LogoutDelegate.Add(delegate()
			{
				LauncherLog.Instance.Info("LauncherSdkBase BindSdkLogoutCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearCacheLoginData();
			});
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0004D473 File Offset: 0x0004B673
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
					Action<FLoginStruct> loginCallback = this.LoginCallback;
					if (loginCallback == null)
					{
						return;
					}
					loginCallback(loginInfo);
				}
			});
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0004D4A0 File Offset: 0x0004B6A0
		public void Login(Action<FLoginStruct> callback)
		{
			this.RefreshCursor();
			this.LauncherTraceId = UKismetGuidLibrary.NewGuid().ToString();
			this.LoginCallback = callback;
			if (LauncherSdk.canUseSdk())
			{
				this.SetFont();
				UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogin;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0004D4EE File Offset: 0x0004B6EE
		public void SetCursor(string path)
		{
			UKuroSDKManager.SetCursor(path);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
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

		// Token: 0x06000CAC RID: 3244 RVA: 0x0004D538 File Offset: 0x0004B738
		public void ClearCacheLoginData()
		{
			LauncherLog.Instance.Info("LauncherSdkBase ClearCacheLoginData", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CacheLoginData = null;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0004D564 File Offset: 0x0004B764
		public virtual string GetChannelId()
		{
			return "";
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0004D56C File Offset: 0x0004B76C
		public virtual void OpenUrl(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier = "Default")
		{
			if (LauncherSdk.canUseSdk())
			{
				string sdkOpenUrlWndInfo = this.GetSdkOpenUrlWndInfo(title, url);
				UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenSdkUrlWnd;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, sdkOpenUrlWndInfo ?? "");
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0004D59D File Offset: 0x0004B79D
		protected virtual string GetPlatformFontStr()
		{
			return "";
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0004D5A4 File Offset: 0x0004B7A4
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

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0004D5F8 File Offset: 0x0004B7F8
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

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0004D7A4 File Offset: 0x0004B9A4
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

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0004D820 File Offset: 0x0004BA20
		public string GetDeviceFontAsset()
		{
			string fontAsset = this.GetFontAsset();
			return this.GetFontPlatformName(fontAsset);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0004D83C File Offset: 0x0004BA3C
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

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
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

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0004D921 File Offset: 0x0004BB21
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

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0004D948 File Offset: 0x0004BB48
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

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0004D9A4 File Offset: 0x0004BBA4
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

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0004D9CB File Offset: 0x0004BBCB
		public void ReportMarketingEvent(SdkReportData eventData)
		{
			if (LauncherSdk.canUseSdk())
			{
				UKuroSDKManager.LogMarketingEvent(eventData.GetReportString());
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0004D9DF File Offset: 0x0004BBDF
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

		// Token: 0x040007EB RID: 2027
		private bool SdkFocusState;

		// Token: 0x040007EC RID: 2028
		[Nullable(2)]
		public FLoginStruct CacheLoginData;

		// Token: 0x040007ED RID: 2029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<FLoginStruct> LoginCallback;

		// Token: 0x040007EE RID: 2030
		public string LauncherTraceId = "";

		// Token: 0x040007EF RID: 2031
		private bool ifGlobalSdk;

		// Token: 0x040007F0 RID: 2032
		private const string LAGUSANSBOLD = "LaguSansBold.otf";

		// Token: 0x040007F1 RID: 2033
		private const string MOTOYTA = "MotoyaAporoStdW5.otf";

		// Token: 0x040007F2 RID: 2034
		private const string SUITEBOLD = "SUITE-Bold.otf";

		// Token: 0x040007F3 RID: 2035
		private const string H7GBKHEAVY = "H7GBKHeavy.TTF";

		// Token: 0x040007F4 RID: 2036
		private const string KANIT = "Kanit-Medium.ttf";
	}
}

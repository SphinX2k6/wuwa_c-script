using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000302 RID: 770
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkBase
{
	// Token: 0x06002BC7 RID: 11207 RVA: 0x00106BF8 File Offset: 0x00104DF8
	public virtual void Init()
	{
		this.KuroOnLogBindFunction();
		this.BindProtocolListener();
		this.BindShareResultListener();
		this.KuroSdkExitBindFunction();
		this.KuroSdkBindRedPointFunction(new Action<int>(this.RedPointCallBack));
		this.KuroSdkQueryProductBindFunction();
		this.KuroDeepLinkBindFunction();
		this.KuroGameWinStateBindFunction();
		this.BindSpecialEvent();
		this.BindExternalEvent();
		if (KuroSdkController.Instance.CanUseSdk())
		{
			this.StartInitProgress();
		}
		this.SetGamePadMode(Info.Instance.IsInGamepad());
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
	}

	// Token: 0x06002BC8 RID: 11208 RVA: 0x00106C80 File Offset: 0x00104E80
	private void StartInitProgress()
	{
		if (!UKuroLauncherLibrary.IsFirstIntoLauncher())
		{
			UKuroSDKManager.Get().LogoutDelegate.Clear();
			if (LauncherSdk.Get().CacheLoginData == null && !LoginModel.Instance.HasBackToGameData())
			{
				this.SdkLogout();
			}
			EventSystem.Instance.Emit(EEventName.SdkInitDone);
			return;
		}
		UKuroSDKManager.SetIfGlobalSdk(KuroSdkController.Instance.GetIfGlobalSdk());
		this.SetFont();
		this.CheckIfHasInitTimer = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.CheckIfInitSuccess();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06002BC9 RID: 11209 RVA: 0x00106D13 File Offset: 0x00104F13
	public virtual void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated)
	{
	}

	// Token: 0x06002BCA RID: 11210 RVA: 0x00106D18 File Offset: 0x00104F18
	private void CheckIfInitSuccess()
	{
		if (UKuroSDKManager.GetSdkInitState())
		{
			UKuroSDKManager.SetWindowsMode(false);
			this.SdkSplashScreenEndSuccess();
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KuroNotiLanguage);
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROINITIALIZEPOSTWEBVIEW);
			if (Platform.Instance.IsWindowsOnlyPlatform() && KuroSdkController.Instance.GetIfGlobalSdk())
			{
				this.CheckPostWebViewInitTimer = TimerSystem.Instance.Forever(delegate(float _)
				{
					this.CheckIfInitPostWebView();
				}, 1000f, 1f, null, null, true);
			}
			if (this.CheckIfHasInitTimer != null)
			{
				TimerSystem.Instance.Remove(this.CheckIfHasInitTimer);
				this.CheckIfHasInitTimer = null;
			}
			EventSystem.Instance.Emit(EEventName.SdkInitDone);
		}
	}

	// Token: 0x06002BCB RID: 11211 RVA: 0x00106DC1 File Offset: 0x00104FC1
	protected virtual void OnInit()
	{
	}

	// Token: 0x06002BCC RID: 11212 RVA: 0x00106DC4 File Offset: 0x00104FC4
	public virtual void ShowExternalLogin()
	{
		if (KuroSdkController.Instance.CanUseSdk() && Platform.Instance.IsIOSPlatform())
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "ShowExternalLoginUI", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroSDKManager.ShowExternalLogin();
		}
	}

	// Token: 0x06002BCD RID: 11213 RVA: 0x00106E0A File Offset: 0x0010500A
	private void SdkSplashScreenEndSuccess()
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKManager.PostSplashScreenEndSuccess();
		}
	}

	// Token: 0x06002BCE RID: 11214 RVA: 0x00106E20 File Offset: 0x00105020
	protected void SdkDoInit()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroDoInit;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x06002BCF RID: 11215 RVA: 0x00106E3C File Offset: 0x0010503C
	private void CheckIfInitPostWebView()
	{
		if (UKuroSDKManager.GetPostWebViewInitState())
		{
			if (this.CheckPostWebViewInitTimer != null)
			{
				TimerSystem.Instance.Remove(this.CheckPostWebViewInitTimer);
				this.CheckPostWebViewInitTimer = null;
				return;
			}
		}
		else
		{
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROINITIALIZEPOSTWEBVIEW);
		}
	}

	// Token: 0x06002BD0 RID: 11216 RVA: 0x00106E74 File Offset: 0x00105074
	public virtual void SdkLogout()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "游戏注销", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogout;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		}
	}

	// Token: 0x06002BD1 RID: 11217 RVA: 0x00106EB8 File Offset: 0x001050B8
	private void RedPointCallBack(int result)
	{
		bool postWebViewRedPointState = result == 1;
		KuroSdkController.Instance.SetPostWebViewRedPointState(postWebViewRedPointState);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x00106EE8 File Offset: 0x001050E8
	public virtual void SdkLogin()
	{
		if (!this.GetProtocolState())
		{
			return;
		}
		if (!UKuroSDKManager.GetSdkInitState())
		{
			return;
		}
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "开始进行Sdk登录!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.SdkLoginStart, null);
			if (Platform.Instance.IsWindowsOnlyPlatform())
			{
				UKuroSDKEventType ukuroSDKEventType;
				if (UKuroLauncherLibrary.IsFirstIntoLauncher())
				{
					ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogin;
					UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
					return;
				}
				ukuroSDKEventType = UKuroSDKEventType.KuroSDKOpenLoginWnd;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
				return;
			}
			else
			{
				UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogin;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
			}
		}
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x00106F7C File Offset: 0x0010517C
	public virtual void SdkKick()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "响应Sdk踢人完成!!!，返回sdk", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKKick;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
			KuroSdkController.Instance.IsKick = true;
			EventSystem.Instance.Emit(EEventName.SdkKick);
		}
	}

	// Token: 0x06002BD4 RID: 11220 RVA: 0x00106FDC File Offset: 0x001051DC
	public virtual void SdkSelectRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "上报选择角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = KuroSdkControllerTool.GetRoleInfo();
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKSelectedRole;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, roleInfo);
		}
	}

	// Token: 0x06002BD5 RID: 11221 RVA: 0x00107024 File Offset: 0x00105224
	public virtual void SdkCreateRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "上报创建新角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string createRoleInfo = KuroSdkControllerTool.GetCreateRoleInfo();
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKCreateRole;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, createRoleInfo);
		}
	}

	// Token: 0x06002BD6 RID: 11222 RVA: 0x0010706C File Offset: 0x0010526C
	public virtual void SdkLevelUpRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "上报角色升级", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = KuroSdkControllerTool.GetRoleInfo();
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKUpgradeRole;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, roleInfo);
		}
	}

	// Token: 0x06002BD7 RID: 11223 RVA: 0x001070B4 File Offset: 0x001052B4
	public virtual void SdkExit()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "游戏退出", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (GlobalData.IsPlayInEditor)
		{
			UKismetSystemLibrary.QuitGame(GlobalData.World, null, EQuitPreference.Quit, false);
			return;
		}
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			KuroApplication.ExitWithReason(false, "SDK");
			return;
		}
		EventSystem.Instance.Emit(EEventName.ExitGamePush);
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			KuroApplication.ExitWithReason(false, "SDK");
			return;
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS || (Info.Instance.PlatformType == ESourcePlatformType.Android && KuroSdkController.Instance.GetIfGlobalSdk()))
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "直接退出", default(ReadOnlySpan<ValueTuple<string, object>>));
			KuroApplication.ExitWithReason(false, "SDK");
			return;
		}
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKExit;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x06002BD8 RID: 11224 RVA: 0x00107190 File Offset: 0x00105390
	public virtual void SdkOpenLoginWnd()
	{
		if (!this.GetProtocolState())
		{
			return;
		}
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "主动打开sdk登录界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.SdkLoginStart, null);
			UKuroSDKEventType ukuroSDKEventType;
			if (Info.Instance.PlatformType == ESourcePlatformType.IOS && KuroSdkController.Instance.GetIfGlobalSdk())
			{
				ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogin;
				UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
				return;
			}
			ukuroSDKEventType = UKuroSDKEventType.KuroSDKOpenLoginWnd;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		}
	}

	// Token: 0x06002BD9 RID: 11225 RVA: 0x00107210 File Offset: 0x00105410
	public virtual SdkAgreementLinkData[] GetAgreement()
	{
		List<SdkAgreementLinkData> list = new List<SdkAgreementLinkData>();
		string agreementUrl = UKuroSDKManager.GetAgreementUrl();
		if (!KuroSdkController.Instance.GetIfGlobalSdk())
		{
			if (Platform.Instance.IsAndroidPlatform())
			{
				AndroidSdkAgreementData androidSdkAgreementData = Json.Decode<AndroidSdkAgreementData>(agreementUrl, null);
				if (((androidSdkAgreementData != null) ? androidSdkAgreementData.gameInit : null) != null)
				{
					foreach (SdkAgreementLinkData item in androidSdkAgreementData.gameInit)
					{
						list.Add(item);
					}
				}
			}
			else if (Platform.Instance.IsWindowsOnlyPlatform())
			{
				SdkAgreementLinkData[] array = Json.Decode<SdkAgreementLinkData[]>(agreementUrl, null);
				if (array != null)
				{
					list.AddRange(array);
				}
			}
			else if (Platform.Instance.IsIOSPlatform() || Platform.Instance.IsMacPlatform())
			{
				string[] array2 = agreementUrl.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array2.Length; i++)
				{
					string[] array3 = array2[i].Replace("{", "").Replace("}", "").Split(';', StringSplitOptions.None);
					if (array3.Length >= 2)
					{
						string[] array4 = array3[0].Split('=', StringSplitOptions.None);
						SdkAgreementLinkData sdkAgreementLinkData = new SdkAgreementLinkData();
						sdkAgreementLinkData.link = array4[1];
						sdkAgreementLinkData.link = sdkAgreementLinkData.link.Trim();
						sdkAgreementLinkData.link = sdkAgreementLinkData.link.Replace("\"", "");
						string[] array5 = array3[1].Split('=', StringSplitOptions.None);
						sdkAgreementLinkData.title = array5[1];
						sdkAgreementLinkData.title = sdkAgreementLinkData.title.Trim();
						sdkAgreementLinkData.title = sdkAgreementLinkData.title.Replace("\"", "");
						sdkAgreementLinkData.title = sdkAgreementLinkData.title.ToLower();
						sdkAgreementLinkData.title = Uri.UnescapeDataString(sdkAgreementLinkData.title);
						list.Add(sdkAgreementLinkData);
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06002BDA RID: 11226 RVA: 0x001073F5 File Offset: 0x001055F5
	public virtual void QueryProduct(string[] productList, string channelId)
	{
		CustomPromise<bool> queryPromise = KuroSdkModel.Instance.QueryPromise;
		if (queryPromise == null)
		{
			return;
		}
		queryPromise.SetResult(true);
	}

	// Token: 0x06002BDB RID: 11227 RVA: 0x0010740C File Offset: 0x0010560C
	public virtual void ShareByteData(ShareData shareData, TArray<byte> data)
	{
		string sKuroSDKEventParameter = JsonSerializer.Serialize<ShareData>(shareData, null);
		UKuroSDKManager.Share(data, sKuroSDKEventParameter);
	}

	// Token: 0x06002BDC RID: 11228 RVA: 0x00107429 File Offset: 0x00105629
	public virtual void Share(ShareData shareData, string imagePath)
	{
	}

	// Token: 0x06002BDD RID: 11229 RVA: 0x0010742B File Offset: 0x0010562B
	public virtual void ShareTexture(ShareData shareData, string texturePath)
	{
	}

	// Token: 0x06002BDE RID: 11230 RVA: 0x00107430 File Offset: 0x00105630
	public virtual void SdkPay(ISDKPayment paymentInfo)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			ISDKPayRole sdkPayRoleInfo = KuroSdkControllerTool.GetSdkPayRoleInfo();
			string paymentInfo2 = KuroSdkControllerTool.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
		}
	}

	// Token: 0x06002BDF RID: 11231 RVA: 0x00107464 File Offset: 0x00105664
	public virtual string GetCurrentSelectServerId()
	{
		if (LoginServerModel.Instance.GetLoginServersByClientRegion() == null)
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "没有登录服务器信息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "0";
		}
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		if (currentLoginServerId == "0")
		{
			Log.Instance.Warn(ELogModule.KuroSdk, ELogAuthor.YZY, "海外选服没有服务器", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "当前服务器Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("serverId", currentLoginServerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return currentLoginServerId;
	}

	// Token: 0x06002BE0 RID: 11232 RVA: 0x001074FC File Offset: 0x001056FC
	public virtual void InitializePostWebView()
	{
		string currentSelectServerId = this.GetCurrentSelectServerId();
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "serverId", default(ReadOnlySpan<ValueTuple<string, object>>));
		InitializePostWebViewParam initializePostWebViewParam = new InitializePostWebViewParam();
		initializePostWebViewParam.language = LanguageSystem.Instance.PackageLanguage;
		initializePostWebViewParam.serverId = currentSelectServerId;
		if (Platform.Instance.IsWindowsOnlyPlatform() || Platform.Instance.IsAndroidPlatform())
		{
			initializePostWebViewParam.cdn = new string[]
			{
				PublicUtil.Instance.GetNoticeBaseUrl() + "/gamenotice/" + PublicUtil.Instance.GetGameId()
			};
		}
		else
		{
			initializePostWebViewParam.cdn = new string[]
			{
				PublicUtil.Instance.GetNoticeBaseUrl() + "/gamenotice/" + PublicUtil.Instance.GetGameId() + "/"
			};
		}
		string text = JsonSerializer.Serialize<InitializePostWebViewParam>(initializePostWebViewParam, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "初始化公告";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroInitializePostWebView;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, text);
	}

	// Token: 0x06002BE1 RID: 11233 RVA: 0x00107600 File Offset: 0x00105800
	[return: Nullable(2)]
	public virtual string GetSdkOpenUrlWndInfo(string title, string url)
	{
		OpenSdkUrlWndParam openSdkUrlWndParam = new OpenSdkUrlWndParam();
		openSdkUrlWndParam.title = title;
		openSdkUrlWndParam.wndUrl = url;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string text = JsonSerializer.Serialize<OpenSdkUrlWndParam>(openSdkUrlWndParam, options);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SdkJson";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text ?? "");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return text;
	}

	// Token: 0x06002BE2 RID: 11234 RVA: 0x00107670 File Offset: 0x00105870
	public virtual void OpenUserCenter()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenUserCenter;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x06002BE3 RID: 11235 RVA: 0x0010768C File Offset: 0x0010588C
	public virtual void ShowAgreement()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroShowAgreement;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		KuroSdkReport.Instance.Report(new SdkReportOpenPrivacy(null));
	}

	// Token: 0x06002BE4 RID: 11236 RVA: 0x001076B8 File Offset: 0x001058B8
	public virtual void KuroOpenPrivacyClauseWnd()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenPrivacyClauseWnd;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		KuroSdkReport.Instance.Report(new SdkReportOpenPrivacy(null));
	}

	// Token: 0x06002BE5 RID: 11237 RVA: 0x001076E4 File Offset: 0x001058E4
	public virtual void ReadProductInfo()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroReadProductInfo;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x06002BE6 RID: 11238 RVA: 0x00107700 File Offset: 0x00105900
	public virtual void NotifyLanguage()
	{
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroNotiLanguage;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, packageLanguage);
		this.SetFont();
	}

	// Token: 0x06002BE7 RID: 11239 RVA: 0x0010772C File Offset: 0x0010592C
	public virtual void OpenPostWebView()
	{
		if (this.LastOpenPostViewTime != 0.0 && Time.Instance.Now - this.LastOpenPostViewTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenPostViewTime = Time.Instance.Now;
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "打开公告", default(ReadOnlySpan<ValueTuple<string, object>>));
		FunctionModel instance = FunctionModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		string type = KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn";
		OpenPostWebViewParam openPostWebViewParam = new OpenPostWebViewParam();
		openPostWebViewParam.playerId = ((instance2.GetId() == null) ? "0" : instance2.GetId().ToString());
		int? playerLevel = instance.GetPlayerLevel();
		openPostWebViewParam.playerLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		openPostWebViewParam.language = LanguageSystem.Instance.PackageLanguage;
		openPostWebViewParam.extend = "extend";
		openPostWebViewParam.gameOrientation = "2";
		openPostWebViewParam.type = type;
		string sKuroSDKEventParameter = JsonSerializer.Serialize<OpenPostWebViewParam>(openPostWebViewParam, null);
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenPostWebView;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, sKuroSDKEventParameter);
	}

	// Token: 0x06002BE8 RID: 11240 RVA: 0x0010787D File Offset: 0x00105A7D
	public virtual string GetChannelId()
	{
		return "";
	}

	// Token: 0x06002BE9 RID: 11241 RVA: 0x00107884 File Offset: 0x00105A84
	public virtual string GetGameId()
	{
		return "";
	}

	// Token: 0x06002BEA RID: 11242 RVA: 0x0010788B File Offset: 0x00105A8B
	public virtual string GetChannelName()
	{
		return "";
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x00107892 File Offset: 0x00105A92
	public virtual string GetAppChannelId()
	{
		return "";
	}

	// Token: 0x06002BEC RID: 11244 RVA: 0x00107899 File Offset: 0x00105A99
	public virtual string GetDid()
	{
		return "";
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x001078A0 File Offset: 0x00105AA0
	public virtual string GetOaid()
	{
		return "";
	}

	// Token: 0x06002BEE RID: 11246 RVA: 0x001078A7 File Offset: 0x00105AA7
	public virtual string GetJyDid()
	{
		return "";
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x001078AE File Offset: 0x00105AAE
	public virtual string GetAccessToken()
	{
		return "";
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x001078B5 File Offset: 0x00105AB5
	public virtual string GetPackageId()
	{
		return UKuroSDKManager.GetPackageId();
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x001078BC File Offset: 0x00105ABC
	public virtual bool GetIsQRCodeLogin()
	{
		return UKuroSDKManager.GetSdkIsQRScan();
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x001078C3 File Offset: 0x00105AC3
	public virtual void QRCodeLogin()
	{
		UKuroSDKManager.OpenSdkQRScan();
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x001078CA File Offset: 0x00105ACA
	public virtual bool GetIsUserCenterEnable()
	{
		return true;
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x001078CD File Offset: 0x00105ACD
	public virtual void SetFont()
	{
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x001078CF File Offset: 0x00105ACF
	public virtual bool IsCustomerServiceEnable()
	{
		return true;
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x001078D2 File Offset: 0x00105AD2
	public virtual void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x001078D4 File Offset: 0x00105AD4
	public virtual void OpenFeedback()
	{
		IFeedBackData feedBackUrl = BaseConfigController.Instance.GetFeedBackUrl();
		if (feedBackUrl == null)
		{
			return;
		}
		string feedBackOpenUrl = this.GetFeedBackOpenUrl();
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			UKismetSystemLibrary.LaunchURL(feedBackOpenUrl);
			return;
		}
		KuroSdkController.Instance.SdkOpenUrlWnd(feedBackUrl.title, feedBackOpenUrl, true, true, true);
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x00107920 File Offset: 0x00105B20
	protected virtual string GetFeedBackOpenUrl()
	{
		string url = BaseConfigController.Instance.GetFeedBackUrl().url;
		LoginModel instance = LoginModel.Instance;
		FunctionModel instance2 = FunctionModel.Instance;
		string text;
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			text = "0";
		}
		else
		{
			SdkLoginConfig sdkLoginConfig = instance.GetSdkLoginConfig();
			text = (((sdkLoginConfig != null) ? sdkLoginConfig.Token : null) ?? "0");
		}
		string text2 = text;
		string text3;
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			text3 = "0";
		}
		else
		{
			SdkLoginConfig sdkLoginConfig2 = instance.GetSdkLoginConfig();
			text3 = (((sdkLoginConfig2 != null) ? sdkLoginConfig2.Uid : null) ?? "0");
		}
		string text4 = text3;
		SdkLoginConfig sdkLoginConfig3 = instance.GetSdkLoginConfig();
		string text5;
		if (((sdkLoginConfig3 != null) ? sdkLoginConfig3.UserName : null) == null)
		{
			text5 = "";
		}
		else
		{
			SdkLoginConfig sdkLoginConfig4 = instance.GetSdkLoginConfig();
			text5 = (((sdkLoginConfig4 != null) ? sdkLoginConfig4.UserName : null) ?? "");
		}
		string text6 = text5;
		string feedBackSt = this.FeedBackSt;
		string[] array = new string[8];
		array[0] = url;
		array[1] = text2;
		int num = 2;
		string serverId = instance.GetServerId();
		array[num] = (((serverId != null) ? serverId.ToString() : null) ?? "");
		array[3] = text4;
		array[4] = text6;
		int num2 = 5;
		string playerName = instance2.GetPlayerName();
		array[num2] = (((playerName != null) ? playerName.ToString() : null) ?? "");
		array[6] = FunctionModel.Instance.PlayerId.ToString();
		array[7] = LanguageSystem.Instance.PackageAudio;
		return StringUtils.Format(feedBackSt, array);
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x00107A64 File Offset: 0x00105C64
	public virtual void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
			{
				GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
				return;
			}
			this.LastOpenTime = Time.Instance.Now;
			string sdkOpenUrlWndInfo = this.GetSdkOpenUrlWndInfo(title, url);
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenSdkUrlWnd;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, sdkOpenUrlWndInfo ?? "");
		}
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x00107AEC File Offset: 0x00105CEC
	public virtual void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, "");
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x00107B04 File Offset: 0x00105D04
	public void KuroSdkLoginBindFunction(Action<FLoginStruct> loginFunction)
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "绑定登录回调", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKuroSDKManager.Get().LoginDelegate.Clear();
		UKuroSDKManager.Get().LoginDelegate.Add(delegate(FLoginStruct loginInfo)
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "登录成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (loginInfo != null)
			{
				if (loginInfo.LoginCode >= 1)
				{
					HotPatchLogReport.Instance.StartupUserId = loginInfo.Uid;
					HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.SdkLoginSuccess, null);
				}
				loginFunction(loginInfo);
			}
		});
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x00107B64 File Offset: 0x00105D64
	public void KuroSdkLoginBindFunction(Action<ILoginInfo> loginFunction)
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "绑定登录回调", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKuroSDKManager ukuroSDKManager = UKuroSDKManager.Get();
		if (ukuroSDKManager != null)
		{
			ukuroSDKManager.LoginDelegate.Clear();
		}
		UKuroSDKManager ukuroSDKManager2 = UKuroSDKManager.Get();
		if (ukuroSDKManager2 == null)
		{
			return;
		}
		ukuroSDKManager2.LoginDelegate.Add(delegate(FLoginStruct loginInfo)
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "登录成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (loginInfo.LoginCode >= 1)
			{
				HotPatchLogReport.Instance.StartupUserId = loginInfo.Uid;
				HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.SdkLoginSuccess, null);
			}
			loginFunction(new LoginInfo
			{
				LoginCode = (int)loginInfo.LoginCode,
				Uid = loginInfo.Uid,
				UserName = loginInfo.UserName,
				Token = loginInfo.Token
			});
		});
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x00107BCF File Offset: 0x00105DCF
	public virtual void KuroSdkKickBindFunction()
	{
		UKuroSDKManager.Get().KickDelegate.Clear();
		UKuroSDKManager.Get().KickDelegate.Add(delegate()
		{
			this.SdkLogout();
			LauncherSdk.Get().ClearCacheLoginData();
		});
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x00107BFC File Offset: 0x00105DFC
	public virtual void KuroSdkLogoutBindFunction(Action callback)
	{
		UKuroSDKManager.Get().LogoutDelegate.Clear();
		UKuroSDKManager.Get().LogoutDelegate.Add(delegate()
		{
			callback();
			LauncherSdk.Get().ClearCacheLoginData();
		});
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x00107C40 File Offset: 0x00105E40
	protected virtual void BindSpecialEvent()
	{
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x00107C42 File Offset: 0x00105E42
	protected virtual void BindExternalEvent()
	{
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x00107C44 File Offset: 0x00105E44
	protected void KuroBindExternalAchievementQueryResult()
	{
		UKuroSDKManager.Get().ExternalQueryAchievementsDelegate.Clear();
		UKuroSDKManager.Get().ExternalQueryAchievementsDelegate.Add(delegate(bool success, TArray<FAchievementStruct> achievementList)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "CacheExternalAchievement";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", success);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.AchievementMap.Clear();
			if (success && achievementList != null)
			{
				foreach (FAchievementStruct fachievementStruct in achievementList)
				{
					SdkAchievementContentData sdkAchievementContentData = new SdkAchievementContentData();
					sdkAchievementContentData.AchievementId = fachievementStruct.AchievementId;
					sdkAchievementContentData.Progress = (int)fachievementStruct.Progress;
					if (!string.IsNullOrEmpty(sdkAchievementContentData.AchievementId))
					{
						this.AchievementMap[sdkAchievementContentData.AchievementId] = sdkAchievementContentData;
					}
				}
			}
		});
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x00107C70 File Offset: 0x00105E70
	public void KuroBindExternalAchievementWriteResult()
	{
		UKuroSDKManager.Get().ExternalWriteAchievementsDelegate.Clear();
		UKuroSDKManager.Get().ExternalWriteAchievementsDelegate.Add(delegate(bool success, TArray<string> resultList)
		{
			if (resultList == null)
			{
				return;
			}
			foreach (string text in resultList)
			{
			}
		});
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x00107CAF File Offset: 0x00105EAF
	public void QueryExternalAchievement()
	{
		UKuroSDKManager.QueryExternalAchievements();
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x00107CB6 File Offset: 0x00105EB6
	public virtual void UnlockSdkTrophy(string id)
	{
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x00107CB8 File Offset: 0x00105EB8
	public virtual void RecordEvents(List<SdkEventData> events)
	{
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x00107CBA File Offset: 0x00105EBA
	public virtual void KuroDeepLinkBindFunction()
	{
		UKuroSDKManager.Get().DeepLinkDelegate.Clear();
		UKuroSDKManager.Get().DeepLinkDelegate.Add(delegate(string result)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = " KuroSDKManager.Get()!.DeepLinkDelegate";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("deepLink", result);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		});
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x00107CF9 File Offset: 0x00105EF9
	public virtual void KuroGameWinStateBindFunction()
	{
		UKuroSDKManager.Get().GameStateChangeCallBack.Clear();
		UKuroSDKManager.Get().GameStateChangeCallBack.Add(delegate(string result)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = " KuroGameWinStateBindFunction";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", result);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			string a = this.ParseGameWindowStateStatus(result);
			bool sdkGetFocusState = false;
			if (a == "0")
			{
				sdkGetFocusState = true;
			}
			KuroSdkModel.Instance.OnSdkFocusChange(sdkGetFocusState);
		});
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x00107D28 File Offset: 0x00105F28
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
				Log instance = Log.Instance;
				ELogModule module = ELogModule.KuroSdk;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "GameWindowState JSON解析失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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

	// Token: 0x06002C09 RID: 11273 RVA: 0x00107DE8 File Offset: 0x00105FE8
	[return: Nullable(2)]
	protected virtual string ParseGameWindowStateStatusJson(string result)
	{
		global::GameWindowStateData gameWindowStateData = JsonSerializer.Deserialize<global::GameWindowStateData>(result, new JsonSerializerOptions
		{
			IncludeFields = true
		});
		if (gameWindowStateData == null)
		{
			return null;
		}
		return gameWindowStateData.status;
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x00107E07 File Offset: 0x00106007
	private void KuroOnLogBindFunction()
	{
		UKuroSDKManager.Get().LogDelegate.Clear();
		UKuroSDKManager.Get().LogDelegate.Add(delegate(string logResult)
		{
			string[] array = logResult.Split(',', StringSplitOptions.None);
			int num = array.Length;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					string[] array2 = array[i].Split('=', StringSplitOptions.None);
					if (array2.Length == 2 && array2[0] == "level")
					{
						int num2 = int.Parse(array2[1]);
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.KuroSdk;
								ELogAuthor author = ELogAuthor.YZY;
								string message = "sdklog";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Info", logResult);
								instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							}
							else if (num2 == 2)
							{
								Log instance2 = Log.Instance;
								ELogModule module2 = ELogModule.KuroSdk;
								ELogAuthor author2 = ELogAuthor.YZY;
								string message2 = "sdklog";
								ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Warn", logResult);
								instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
							}
							else
							{
								Log instance3 = Log.Instance;
								ELogModule module3 = ELogModule.KuroSdk;
								ELogAuthor author3 = ELogAuthor.YZY;
								string message3 = "sdklog";
								ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Error", logResult);
								instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
							}
						}
					}
				}
			}
		});
	}

	// Token: 0x06002C0B RID: 11275 RVA: 0x00107E46 File Offset: 0x00106046
	public virtual void KuroSdkExitBindFunction()
	{
		UKuroSDKManager.Get().ExitDelegate.Clear();
		UKuroSDKManager.Get().ExitDelegate.Add(delegate()
		{
			if (GlobalData.World != null)
			{
				KuroApplication.ExitWithReason(false, "KuroSdkExitBindFunction");
			}
		});
	}

	// Token: 0x06002C0C RID: 11276 RVA: 0x00107E85 File Offset: 0x00106085
	public virtual void BindProtocolListener()
	{
		UKuroSDKManager.Get().ProtocolCallBack.Clear();
		UKuroSDKManager.Get().ProtocolCallBack.Add(delegate(bool _)
		{
			this.CurrentProtocolState = true;
		});
	}

	// Token: 0x06002C0D RID: 11277 RVA: 0x00107EB1 File Offset: 0x001060B1
	public virtual void BindShareResultListener()
	{
		UKuroSDKManager.Get().ShareResultDelegate.Clear();
		UKuroSDKManager.Get().ShareResultDelegate.Add(delegate(int code, string platform, string msg)
		{
			this.OnShareResult(code, platform, msg);
		});
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x00107EDD File Offset: 0x001060DD
	protected virtual void OnShareResult(int code, string platform, string msg)
	{
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x00107EDF File Offset: 0x001060DF
	public virtual void KuroSdkQueryProductBindFunction()
	{
		UKuroSDKManager.Get().PostProductDelegate.Clear();
		UKuroSDKManager.Get().PostProductDelegate.Add(delegate(string result)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "sdk:查询商品 queryProduct";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			QueryProductSt[] data = this.OnQueryProduct(result);
			KuroSdkModel.Instance.OnQueryProductInfo(data);
		});
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x00107F0B File Offset: 0x0010610B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected virtual QueryProductSt[] OnQueryProduct(string str)
	{
		return null;
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x00107F0E File Offset: 0x0010610E
	public virtual void GetSharePlatform(Action<SharePlatformSt[]> callback)
	{
		this.GetSharePlatformCallBackList.Add(callback);
		if (!this.GetSharePlatformState)
		{
			this.GetSharePlatformState = true;
			UKuroSDKManager.GetSharePlatform();
		}
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x00107F30 File Offset: 0x00106130
	protected virtual void OnGetSharePlatform(string str)
	{
		this.GetSharePlatformState = false;
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x00107F3C File Offset: 0x0010613C
	public virtual void KuroSdkPaymentBindFunction(Action<bool, string> paymentFunction)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKManager.Get().PaymentDelegate.Clear();
			UKuroSDKManager.Get().PaymentDelegate.Add(delegate(FPaymentStruct payment, string str)
			{
				this.OnPaymentCallBack(payment, str, paymentFunction);
				if (payment.PaymentType == EPaymentType.Success)
				{
					SuccessSdkPayEvent successSdkPayEvent = new SuccessSdkPayEvent();
					successSdkPayEvent.s_sdk_pay_order = KuroSdkModel.Instance.CurrentPayingOrderId;
					LogReportController.Instance.LogReport(successSdkPayEvent);
				}
				else
				{
					FailSdkPayEvent failSdkPayEvent = new FailSdkPayEvent();
					failSdkPayEvent.s_sdk_pay_order = KuroSdkModel.Instance.CurrentPayingOrderId;
					failSdkPayEvent.s_reason = ((payment.PaymentType == EPaymentType.Cancel) ? "cancel" : "fail");
					LogReportController.Instance.LogReport(failSdkPayEvent);
				}
				KuroSdkReport.Instance.OnSdkPay();
			});
		}
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x00107F93 File Offset: 0x00106193
	protected virtual void OnPaymentCallBack(FPaymentStruct payment, string strResult, Action<bool, string> paymentFunction)
	{
		paymentFunction(payment.PaymentType == EPaymentType.Success, strResult);
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x00107FA8 File Offset: 0x001061A8
	public virtual void KuroSdkBindRedPointFunction(Action<int> callBack)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKManager.Get().PostRedPointDelegate.Clear();
			UKuroSDKManager.Get().PostRedPointDelegate.Add(delegate(byte result)
			{
				callBack((int)result);
			});
		}
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x00107FF8 File Offset: 0x001061F8
	public virtual string GetDeviceDid()
	{
		return this.CurrentDid;
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x00108000 File Offset: 0x00106200
	public virtual void ResetCustomServerRedDot()
	{
		this.CurrentCustomerShowState = false;
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x00108019 File Offset: 0x00106219
	public virtual bool GetProtocolState()
	{
		return this.CurrentProtocolState || UKuroSDKManager.GetIsAgreeProtocol();
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x0010802F File Offset: 0x0010622F
	public virtual void SetCustomerServiceShowState(bool state)
	{
		this.CurrentCustomerShowState = state;
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x00108038 File Offset: 0x00106238
	public virtual bool GetCustomerServiceShowState()
	{
		return this.CurrentCustomerShowState;
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x00108040 File Offset: 0x00106240
	public virtual bool CheckPhotoPermission()
	{
		return UKuroSDKManager.CheckPhotoPermission();
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x00108047 File Offset: 0x00106247
	public virtual void RequestPhotoPermission(Action<bool> callBack)
	{
		UKuroSDKManager.Get().RequestPhotoPermissionDelegate.Clear();
		UKuroSDKManager.Get().RequestPhotoPermissionDelegate.Add(callBack);
		UKuroSDKManager.RequestPhotoPermission();
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x00108070 File Offset: 0x00106270
	public unsafe virtual void OpenReview(int reviewId)
	{
		bool flag = this.CheckIfCanReview();
		if (flag)
		{
			UKuroSDKManager.RequestReviewApp("");
			this.ReportReview(reviewId);
			this.SaveCurrentReviewTime();
			return;
		}
		double[] item = LocalStorage.GetGlobal<double[]>(ELocalStorageGlobalKey.OpenReviewTimeList, null) ?? Array.Empty<double>();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "OpenReview Fail";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", flag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reviewTimeList", item);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x0010810C File Offset: 0x0010630C
	protected virtual void ReportReview(int id)
	{
		if (Info.Instance.IsMobilePlatform())
		{
			if ((Info.Instance.PlatformType == ESourcePlatformType.Android && !KuroSdkController.Instance.GetIfGlobalSdk()) || Info.Instance.PlatformType == ESourcePlatformType.OpenHarmony)
			{
				return;
			}
			SdkStartReview sdkStartReview = new SdkStartReview();
			sdkStartReview.s_channel = ((Info.Instance.PlatformType == ESourcePlatformType.IOS) ? "iOS" : "GP");
			sdkStartReview.i_id = id;
			LogReportController.Instance.LogReport(sdkStartReview);
		}
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x00108184 File Offset: 0x00106384
	protected virtual int CurrentPlatformYearReviewTime()
	{
		return 0;
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x00108188 File Offset: 0x00106388
	protected virtual void SaveCurrentReviewTime()
	{
		IEnumerable<double> collection = LocalStorage.GetGlobal<double[]>(ELocalStorageGlobalKey.OpenReviewTimeList, null) ?? Array.Empty<double>();
		double serverTime = TimeUtil.Instance.GetServerTime();
		int num = this.CurrentPlatformYearReviewTime();
		List<double> list = new List<double>(collection);
		if (list.Count < num)
		{
			list.Add(serverTime);
		}
		else
		{
			list.RemoveAt(0);
			list.Add(serverTime);
		}
		LocalStorage.SetGlobal<double[]>(ELocalStorageGlobalKey.OpenReviewTimeList, list.ToArray());
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x001081EC File Offset: 0x001063EC
	protected virtual bool CheckIfCanReview()
	{
		double[] array = LocalStorage.GetGlobal<double[]>(ELocalStorageGlobalKey.OpenReviewTimeList, null) ?? Array.Empty<double>();
		double serverTime = TimeUtil.Instance.GetServerTime();
		int num = this.CurrentPlatformYearReviewTime();
		bool result = false;
		if (array.Length < num)
		{
			result = true;
		}
		else
		{
			double num2 = array[0];
			if (serverTime - num2 >= 31536000.0)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x00108240 File Offset: 0x00106440
	public virtual void SetCursor(string path)
	{
		UKuroSDKManager.SetCursor(path);
	}

	// Token: 0x06002C23 RID: 11299 RVA: 0x00108248 File Offset: 0x00106448
	public virtual void SetGamePadMode(bool ifGamePad)
	{
		UKuroSDKManager.SetGamePadMode(ifGamePad);
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x00108250 File Offset: 0x00106450
	public virtual void BindWebViewCloseDelegate(Action callBack)
	{
		UKuroSDKManager ukuroSDKManager = UKuroSDKManager.Get();
		if (ukuroSDKManager != null)
		{
			ukuroSDKManager.WebViewCloseDelegate.Clear();
		}
		UKuroSDKManager ukuroSDKManager2 = UKuroSDKManager.Get();
		if (ukuroSDKManager2 == null)
		{
			return;
		}
		ukuroSDKManager2.WebViewCloseDelegate.Add(callBack);
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x0010827C File Offset: 0x0010647C
	protected virtual string GetRoleId()
	{
		if (PlayerInfoModel.Instance.GetId() != null)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int num = 0;
			if (!(id.GetValueOrDefault() == num & id != null))
			{
				return PlayerInfoModel.Instance.GetId().ToString();
			}
		}
		if (LoginModel.Instance.GetCreatePlayerId() != 0)
		{
			return LoginModel.Instance.GetCreatePlayerId().ToString();
		}
		return "";
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x001082FB File Offset: 0x001064FB
	protected virtual string GetCustomServerRoleId()
	{
		return StringUtils.Format("{0}", new string[]
		{
			this.GetRoleId()
		});
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x00108318 File Offset: 0x00106518
	protected virtual string GetCustomServerExtendsInfo()
	{
		return Json.Stringify(new OpenCustomerServiceExtendsInfo
		{
			data = new OpenCustomerServiceExtendsInfoData[]
			{
				new OpenCustomerServiceExtendsInfoData
				{
					key = "version",
					label = "version",
					value = BaseConfigController.Instance.GetPatchVersion() + "_" + BaseConfigController.Instance.GetP4Version()
				},
				new OpenCustomerServiceExtendsInfoData
				{
					key = "custom_info",
					label = "custom_info",
					value = this.GetCustomServerCustomInfo()
				}
			}
		}, null) ?? "";
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x001083B8 File Offset: 0x001065B8
	protected virtual string GetCustomServerCustomInfo()
	{
		OpenCustomerServiceCustomInfo openCustomerServiceCustomInfo = new OpenCustomerServiceCustomInfo();
		openCustomerServiceCustomInfo.custom_info = "customer_info/";
		openCustomerServiceCustomInfo.login_info = UKuroStaticLibrary.Base64Encode(PublicUtil.Instance.GetPublicInfo());
		string overridePackageId = PublicUtil.Instance.OverridePackageId;
		openCustomerServiceCustomInfo.packageId = ((!string.IsNullOrEmpty(overridePackageId)) ? overridePackageId : (KuroSdkController.Instance.GetPackageId() ?? ""));
		openCustomerServiceCustomInfo.channelId = KuroSdkController.Instance.GetChannelId();
		openCustomerServiceCustomInfo.platform = KuroSdkModel.Instance.GetPlatformStr();
		openCustomerServiceCustomInfo.lang = LanguageSystem.Instance.PackageLanguage;
		openCustomerServiceCustomInfo.entryType = "game";
		openCustomerServiceCustomInfo.svr_area = (KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn");
		openCustomerServiceCustomInfo.version = BaseConfigController.Instance.GetP4Version();
		return Json.Stringify(openCustomerServiceCustomInfo, null) ?? "";
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x00108491 File Offset: 0x00106691
	public virtual void OpenExternalUrl(string url)
	{
		UKismetSystemLibrary.LaunchURL(url);
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x00108499 File Offset: 0x00106699
	public virtual void CloseWebView(string identifier)
	{
		UKuroSDKManager.CloseWebView(identifier);
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x001084A1 File Offset: 0x001066A1
	public virtual string GetThirdUserId()
	{
		return "";
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x001084A8 File Offset: 0x001066A8
	public virtual string GetOnlineId()
	{
		return "";
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x001084AF File Offset: 0x001066AF
	public virtual void OpenProfileCard(string uid)
	{
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x001084B4 File Offset: 0x001066B4
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public virtual UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
	{
		PlatformSdkBase.<GetSdkBlockingUser>d__121 <GetSdkBlockingUser>d__;
		<GetSdkBlockingUser>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
		<GetSdkBlockingUser>d__.<>1__state = -1;
		<GetSdkBlockingUser>d__.<>t__builder.Start<PlatformSdkBase.<GetSdkBlockingUser>d__121>(ref <GetSdkBlockingUser>d__);
		return <GetSdkBlockingUser>d__.<>t__builder.Task;
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x001084EF File Offset: 0x001066EF
	public virtual void SetPlayOnly(bool state)
	{
		this.PlayOnlyState = state;
	}

	// Token: 0x06002C30 RID: 11312 RVA: 0x001084F8 File Offset: 0x001066F8
	public virtual bool NeedCheckPlayOnly()
	{
		return false;
	}

	// Token: 0x06002C31 RID: 11313 RVA: 0x001084FB File Offset: 0x001066FB
	public virtual bool PlayOnly()
	{
		return this.NeedCheckPlayOnly() && this.PlayOnlyState;
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x0010850D File Offset: 0x0010670D
	public virtual bool GetSdkFriendOnlyState()
	{
		return false;
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x00108510 File Offset: 0x00106710
	public virtual void SaveSdkFriendOnlyState(bool state)
	{
	}

	// Token: 0x06002C34 RID: 11316 RVA: 0x00108512 File Offset: 0x00106712
	public virtual bool SupportSwitchFriendShowType()
	{
		return false;
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x00108515 File Offset: 0x00106715
	public virtual bool NeedShowThirdPartyId()
	{
		return false;
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x00108518 File Offset: 0x00106718
	public virtual string CreatePlayerSession(string id)
	{
		return "-1";
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x0010851F File Offset: 0x0010671F
	public virtual void SetMultiPlayerActivity(int currentPlayerCount, int maxPlayerCount, string playerSession, EXboxMultiplayerActivityJoinRestriction restriction)
	{
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x00108521 File Offset: 0x00106721
	public virtual bool CheckPrivilege(ESdkPrivilege privilege)
	{
		return true;
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x00108524 File Offset: 0x00106724
	public virtual bool ResolvePrivilege(ESdkPrivilege privilege)
	{
		return true;
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x00108527 File Offset: 0x00106727
	public virtual string GetSessionId(string playerSession)
	{
		return "-1";
	}

	// Token: 0x06002C3B RID: 11323 RVA: 0x0010852E File Offset: 0x0010672E
	public virtual bool SupportSwitchFriendSearchByThirdPartyId()
	{
		return false;
	}

	// Token: 0x06002C3C RID: 11324 RVA: 0x00108531 File Offset: 0x00106731
	public virtual void LeaveMultiPlayerActivity()
	{
	}

	// Token: 0x06002C3D RID: 11325 RVA: 0x00108533 File Offset: 0x00106733
	public virtual void JoinSessionBindFunction(Action<string, string> callback)
	{
	}

	// Token: 0x06002C3E RID: 11326 RVA: 0x00108535 File Offset: 0x00106735
	public virtual void UpdateRecentPlayer(string[] ids)
	{
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x00108537 File Offset: 0x00106737
	public virtual bool CheckIfSingleServerAfterSelect()
	{
		return false;
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x0010853C File Offset: 0x0010673C
	[return: Nullable(0)]
	public virtual UniTask<bool> SaveSingleServerRegion(int loginType, string region, string userId, string userName, string token)
	{
		PlatformSdkBase.<SaveSingleServerRegion>d__140 <SaveSingleServerRegion>d__;
		<SaveSingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveSingleServerRegion>d__.<>1__state = -1;
		<SaveSingleServerRegion>d__.<>t__builder.Start<PlatformSdkBase.<SaveSingleServerRegion>d__140>(ref <SaveSingleServerRegion>d__);
		return <SaveSingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x00108578 File Offset: 0x00106778
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public virtual UniTask<string> GetOnlyRegionInfo(ILoginInfo result)
	{
		PlatformSdkBase.<GetOnlyRegionInfo>d__141 <GetOnlyRegionInfo>d__;
		<GetOnlyRegionInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetOnlyRegionInfo>d__.<>1__state = -1;
		<GetOnlyRegionInfo>d__.<>t__builder.Start<PlatformSdkBase.<GetOnlyRegionInfo>d__141>(ref <GetOnlyRegionInfo>d__);
		return <GetOnlyRegionInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x001085B3 File Offset: 0x001067B3
	public virtual void CheckPermission(string id, ESdkPermission permission, Action<bool> callback)
	{
		callback(true);
	}

	// Token: 0x06002C43 RID: 11331 RVA: 0x001085BC File Offset: 0x001067BC
	public virtual string GetExternalToken()
	{
		return "";
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x001085C4 File Offset: 0x001067C4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public virtual UniTask<string> GetExternalCollectionId()
	{
		PlatformSdkBase.<GetExternalCollectionId>d__144 <GetExternalCollectionId>d__;
		<GetExternalCollectionId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetExternalCollectionId>d__.<>1__state = -1;
		<GetExternalCollectionId>d__.<>t__builder.Start<PlatformSdkBase.<GetExternalCollectionId>d__144>(ref <GetExternalCollectionId>d__);
		return <GetExternalCollectionId>d__.<>t__builder.Task;
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x001085FF File Offset: 0x001067FF
	public virtual void OnClear()
	{
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x00108601 File Offset: 0x00106801
	public virtual void RecoverSdkData()
	{
	}

	// Token: 0x0400292A RID: 10538
	private const int TIMEGAP = 1000;

	// Token: 0x0400292B RID: 10539
	private const int WEBVIEWCD = 5000;

	// Token: 0x0400292C RID: 10540
	private const int ONEYEARTIME = 31536000;

	// Token: 0x0400292D RID: 10541
	private const string CUSTOMINFOKEY = "custom_info";

	// Token: 0x0400292E RID: 10542
	private const string CUSTOMINFOROUTE = "customer_info/";

	// Token: 0x0400292F RID: 10543
	[Nullable(2)]
	private TimerHandle CheckPostWebViewInitTimer;

	// Token: 0x04002930 RID: 10544
	[Nullable(2)]
	private TimerHandle CheckIfHasInitTimer;

	// Token: 0x04002931 RID: 10545
	protected double LastOpenTime;

	// Token: 0x04002932 RID: 10546
	protected double LastOpenPostViewTime;

	// Token: 0x04002933 RID: 10547
	protected readonly string FeedBackSt = "{0}?token={1}&svr_id={2}&uid={3}&user_name={4}&role_name={5}&role_id={6}&lang={7}";

	// Token: 0x04002934 RID: 10548
	protected string CurrentDid = "";

	// Token: 0x04002935 RID: 10549
	protected List<Action<SharePlatformSt[]>> GetSharePlatformCallBackList = new List<Action<SharePlatformSt[]>>();

	// Token: 0x04002936 RID: 10550
	private bool GetSharePlatformState;

	// Token: 0x04002937 RID: 10551
	private bool CurrentProtocolState;

	// Token: 0x04002938 RID: 10552
	protected bool CurrentCustomerShowState;

	// Token: 0x04002939 RID: 10553
	protected bool ExternalLoginState;

	// Token: 0x0400293A RID: 10554
	protected Dictionary<string, SdkAchievementContentData> AchievementMap = new Dictionary<string, SdkAchievementContentData>();

	// Token: 0x0400293B RID: 10555
	private bool PlayOnlyState;

	// Token: 0x02006650 RID: 26192
	[NullableContext(0)]
	private enum ESdkLogLevel
	{
		// Token: 0x04021E5A RID: 138842
		Debug,
		// Token: 0x04021E5B RID: 138843
		Info,
		// Token: 0x04021E5C RID: 138844
		Warn,
		// Token: 0x04021E5D RID: 138845
		Error
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E4D RID: 3661
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkBase
{
	// Token: 0x06005835 RID: 22581 RVA: 0x000FF0EC File Offset: 0x000FD2EC
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

	// Token: 0x06005836 RID: 22582 RVA: 0x000FF174 File Offset: 0x000FD374
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

	// Token: 0x06005837 RID: 22583 RVA: 0x000FF207 File Offset: 0x000FD407
	public virtual void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated)
	{
	}

	// Token: 0x06005838 RID: 22584 RVA: 0x000FF20C File Offset: 0x000FD40C
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

	// Token: 0x06005839 RID: 22585 RVA: 0x000FF2B5 File Offset: 0x000FD4B5
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600583A RID: 22586 RVA: 0x000FF2B8 File Offset: 0x000FD4B8
	public virtual void ShowExternalLogin()
	{
		if (KuroSdkController.Instance.CanUseSdk() && Platform.Instance.IsIOSPlatform())
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "ShowExternalLoginUI", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroSDKManager.ShowExternalLogin();
		}
	}

	// Token: 0x0600583B RID: 22587 RVA: 0x000FF2FE File Offset: 0x000FD4FE
	private void SdkSplashScreenEndSuccess()
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKManager.PostSplashScreenEndSuccess();
		}
	}

	// Token: 0x0600583C RID: 22588 RVA: 0x000FF314 File Offset: 0x000FD514
	protected void SdkDoInit()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroDoInit;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x0600583D RID: 22589 RVA: 0x000FF330 File Offset: 0x000FD530
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

	// Token: 0x0600583E RID: 22590 RVA: 0x000FF368 File Offset: 0x000FD568
	public virtual void SdkLogout()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "游戏注销", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKLogout;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		}
	}

	// Token: 0x0600583F RID: 22591 RVA: 0x000FF3AC File Offset: 0x000FD5AC
	private void RedPointCallBack(int result)
	{
		bool postWebViewRedPointState = result == 1;
		KuroSdkController.Instance.SetPostWebViewRedPointState(postWebViewRedPointState);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06005840 RID: 22592 RVA: 0x000FF3DC File Offset: 0x000FD5DC
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

	// Token: 0x06005841 RID: 22593 RVA: 0x000FF464 File Offset: 0x000FD664
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

	// Token: 0x06005842 RID: 22594 RVA: 0x000FF4C4 File Offset: 0x000FD6C4
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

	// Token: 0x06005843 RID: 22595 RVA: 0x000FF50C File Offset: 0x000FD70C
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

	// Token: 0x06005844 RID: 22596 RVA: 0x000FF554 File Offset: 0x000FD754
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

	// Token: 0x06005845 RID: 22597 RVA: 0x000FF59C File Offset: 0x000FD79C
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

	// Token: 0x06005846 RID: 22598 RVA: 0x000FF678 File Offset: 0x000FD878
	public virtual void SdkOpenLoginWnd()
	{
		if (!this.GetProtocolState())
		{
			return;
		}
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "主动打开sdk登录界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
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

	// Token: 0x06005847 RID: 22599 RVA: 0x000FF6EC File Offset: 0x000FD8EC
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

	// Token: 0x06005848 RID: 22600 RVA: 0x000FF8D1 File Offset: 0x000FDAD1
	public virtual void QueryProduct(string[] productList, string channelId)
	{
		CustomPromise<bool> queryPromise = KuroSdkModel.Instance.QueryPromise;
		if (queryPromise == null)
		{
			return;
		}
		queryPromise.SetResult(true);
	}

	// Token: 0x06005849 RID: 22601 RVA: 0x000FF8E8 File Offset: 0x000FDAE8
	public virtual void ShareByteData(ShareData shareData, TArray<byte> data)
	{
		string sKuroSDKEventParameter = JsonSerializer.Serialize<ShareData>(shareData, null);
		UKuroSDKManager.Share(data, sKuroSDKEventParameter);
	}

	// Token: 0x0600584A RID: 22602 RVA: 0x000FF905 File Offset: 0x000FDB05
	public virtual void Share(ShareData shareData, string imagePath)
	{
	}

	// Token: 0x0600584B RID: 22603 RVA: 0x000FF907 File Offset: 0x000FDB07
	public virtual void ShareTexture(ShareData shareData, string texturePath)
	{
	}

	// Token: 0x0600584C RID: 22604 RVA: 0x000FF90C File Offset: 0x000FDB0C
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

	// Token: 0x0600584D RID: 22605 RVA: 0x000FF940 File Offset: 0x000FDB40
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

	// Token: 0x0600584E RID: 22606 RVA: 0x000FF9D8 File Offset: 0x000FDBD8
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

	// Token: 0x0600584F RID: 22607 RVA: 0x000FFADC File Offset: 0x000FDCDC
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

	// Token: 0x06005850 RID: 22608 RVA: 0x000FFB4C File Offset: 0x000FDD4C
	public virtual void OpenUserCenter()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenUserCenter;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x06005851 RID: 22609 RVA: 0x000FFB68 File Offset: 0x000FDD68
	public virtual void ShowAgreement()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroShowAgreement;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		KuroSdkReport.Instance.Report(new SdkReportOpenPrivacy(null));
	}

	// Token: 0x06005852 RID: 22610 RVA: 0x000FFB94 File Offset: 0x000FDD94
	public virtual void KuroOpenPrivacyClauseWnd()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroOpenPrivacyClauseWnd;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		KuroSdkReport.Instance.Report(new SdkReportOpenPrivacy(null));
	}

	// Token: 0x06005853 RID: 22611 RVA: 0x000FFBC0 File Offset: 0x000FDDC0
	public virtual void ReadProductInfo()
	{
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroReadProductInfo;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
	}

	// Token: 0x06005854 RID: 22612 RVA: 0x000FFBDC File Offset: 0x000FDDDC
	public virtual void NotifyLanguage()
	{
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroNotiLanguage;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, packageLanguage);
		this.SetFont();
	}

	// Token: 0x06005855 RID: 22613 RVA: 0x000FFC08 File Offset: 0x000FDE08
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

	// Token: 0x06005856 RID: 22614 RVA: 0x000FFD59 File Offset: 0x000FDF59
	public virtual string GetChannelId()
	{
		return "";
	}

	// Token: 0x06005857 RID: 22615 RVA: 0x000FFD60 File Offset: 0x000FDF60
	public virtual string GetGameId()
	{
		return "";
	}

	// Token: 0x06005858 RID: 22616 RVA: 0x000FFD67 File Offset: 0x000FDF67
	public virtual string GetChannelName()
	{
		return "";
	}

	// Token: 0x06005859 RID: 22617 RVA: 0x000FFD6E File Offset: 0x000FDF6E
	public virtual string GetAppChannelId()
	{
		return "";
	}

	// Token: 0x0600585A RID: 22618 RVA: 0x000FFD75 File Offset: 0x000FDF75
	public virtual string GetDid()
	{
		return "";
	}

	// Token: 0x0600585B RID: 22619 RVA: 0x000FFD7C File Offset: 0x000FDF7C
	public virtual string GetOaid()
	{
		return "";
	}

	// Token: 0x0600585C RID: 22620 RVA: 0x000FFD83 File Offset: 0x000FDF83
	public virtual string GetJyDid()
	{
		return "";
	}

	// Token: 0x0600585D RID: 22621 RVA: 0x000FFD8A File Offset: 0x000FDF8A
	public virtual string GetAccessToken()
	{
		return "";
	}

	// Token: 0x0600585E RID: 22622 RVA: 0x000FFD91 File Offset: 0x000FDF91
	public virtual string GetPackageId()
	{
		return UKuroSDKManager.GetPackageId();
	}

	// Token: 0x0600585F RID: 22623 RVA: 0x000FFD98 File Offset: 0x000FDF98
	public virtual bool GetIsQRCodeLogin()
	{
		return UKuroSDKManager.GetSdkIsQRScan();
	}

	// Token: 0x06005860 RID: 22624 RVA: 0x000FFD9F File Offset: 0x000FDF9F
	public virtual void QRCodeLogin()
	{
		UKuroSDKManager.OpenSdkQRScan();
	}

	// Token: 0x06005861 RID: 22625 RVA: 0x000FFDA6 File Offset: 0x000FDFA6
	public virtual bool GetIsUserCenterEnable()
	{
		return true;
	}

	// Token: 0x06005862 RID: 22626 RVA: 0x000FFDA9 File Offset: 0x000FDFA9
	public virtual void SetFont()
	{
	}

	// Token: 0x06005863 RID: 22627 RVA: 0x000FFDAB File Offset: 0x000FDFAB
	public virtual bool IsCustomerServiceEnable()
	{
		return true;
	}

	// Token: 0x06005864 RID: 22628 RVA: 0x000FFDAE File Offset: 0x000FDFAE
	public virtual void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
	}

	// Token: 0x06005865 RID: 22629 RVA: 0x000FFDB0 File Offset: 0x000FDFB0
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

	// Token: 0x06005866 RID: 22630 RVA: 0x000FFDFC File Offset: 0x000FDFFC
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

	// Token: 0x06005867 RID: 22631 RVA: 0x000FFF40 File Offset: 0x000FE140
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

	// Token: 0x06005868 RID: 22632 RVA: 0x000FFFC8 File Offset: 0x000FE1C8
	public virtual void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, "");
	}

	// Token: 0x06005869 RID: 22633 RVA: 0x000FFFE0 File Offset: 0x000FE1E0
	public void KuroSdkLoginBindFunction(Action<FLoginStruct> loginFunction)
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "绑定登录回调", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKuroSDKManager.Get().LoginDelegate.Clear();
		UKuroSDKManager.Get().LoginDelegate.Add(delegate(FLoginStruct loginInfo)
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "登录成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (loginInfo != null)
			{
				loginFunction(loginInfo);
			}
		});
	}

	// Token: 0x0600586A RID: 22634 RVA: 0x00100040 File Offset: 0x000FE240
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
			loginFunction(new LoginInfo
			{
				LoginCode = (int)loginInfo.LoginCode,
				Uid = loginInfo.Uid,
				UserName = loginInfo.UserName,
				Token = loginInfo.Token
			});
		});
	}

	// Token: 0x0600586B RID: 22635 RVA: 0x001000AB File Offset: 0x000FE2AB
	public virtual void KuroSdkKickBindFunction()
	{
		UKuroSDKManager.Get().KickDelegate.Clear();
		UKuroSDKManager.Get().KickDelegate.Add(delegate()
		{
			this.SdkLogout();
			LauncherSdk.Get().ClearCacheLoginData();
		});
	}

	// Token: 0x0600586C RID: 22636 RVA: 0x001000D8 File Offset: 0x000FE2D8
	public virtual void KuroSdkLogoutBindFunction(Action callback)
	{
		UKuroSDKManager.Get().LogoutDelegate.Clear();
		UKuroSDKManager.Get().LogoutDelegate.Add(delegate()
		{
			callback();
			LauncherSdk.Get().ClearCacheLoginData();
		});
	}

	// Token: 0x0600586D RID: 22637 RVA: 0x0010011C File Offset: 0x000FE31C
	protected virtual void BindSpecialEvent()
	{
	}

	// Token: 0x0600586E RID: 22638 RVA: 0x0010011E File Offset: 0x000FE31E
	protected virtual void BindExternalEvent()
	{
	}

	// Token: 0x0600586F RID: 22639 RVA: 0x00100120 File Offset: 0x000FE320
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

	// Token: 0x06005870 RID: 22640 RVA: 0x0010014C File Offset: 0x000FE34C
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

	// Token: 0x06005871 RID: 22641 RVA: 0x0010018B File Offset: 0x000FE38B
	public void QueryExternalAchievement()
	{
		UKuroSDKManager.QueryExternalAchievements();
	}

	// Token: 0x06005872 RID: 22642 RVA: 0x00100192 File Offset: 0x000FE392
	public virtual void UnlockSdkTrophy(string id)
	{
	}

	// Token: 0x06005873 RID: 22643 RVA: 0x00100194 File Offset: 0x000FE394
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

	// Token: 0x06005874 RID: 22644 RVA: 0x001001D3 File Offset: 0x000FE3D3
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

	// Token: 0x06005875 RID: 22645 RVA: 0x00100200 File Offset: 0x000FE400
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
				global::GameWindowStateData gameWindowStateData = Json.Decode<global::GameWindowStateData>(result, null);
				return (gameWindowStateData != null) ? gameWindowStateData.status : null;
			}
			catch
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

	// Token: 0x06005876 RID: 22646 RVA: 0x001002C4 File Offset: 0x000FE4C4
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

	// Token: 0x06005877 RID: 22647 RVA: 0x00100303 File Offset: 0x000FE503
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

	// Token: 0x06005878 RID: 22648 RVA: 0x00100342 File Offset: 0x000FE542
	public virtual void BindProtocolListener()
	{
		UKuroSDKManager.Get().ProtocolCallBack.Clear();
		UKuroSDKManager.Get().ProtocolCallBack.Add(delegate(bool _)
		{
			this.CurrentProtocolState = true;
		});
	}

	// Token: 0x06005879 RID: 22649 RVA: 0x0010036E File Offset: 0x000FE56E
	public virtual void BindShareResultListener()
	{
		UKuroSDKManager.Get().ShareResultDelegate.Clear();
		UKuroSDKManager.Get().ShareResultDelegate.Add(delegate(int code, string platform, string msg)
		{
			this.OnShareResult(code, platform, msg);
		});
	}

	// Token: 0x0600587A RID: 22650 RVA: 0x0010039A File Offset: 0x000FE59A
	protected virtual void OnShareResult(int code, string platform, string msg)
	{
	}

	// Token: 0x0600587B RID: 22651 RVA: 0x0010039C File Offset: 0x000FE59C
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

	// Token: 0x0600587C RID: 22652 RVA: 0x001003C8 File Offset: 0x000FE5C8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected virtual QueryProductSt[] OnQueryProduct(string str)
	{
		return null;
	}

	// Token: 0x0600587D RID: 22653 RVA: 0x001003CB File Offset: 0x000FE5CB
	public virtual void GetSharePlatform(Action<SharePlatformSt[]> callback)
	{
		this.GetSharePlatformCallBackList.Add(callback);
		if (!this.GetSharePlatformState)
		{
			this.GetSharePlatformState = true;
			UKuroSDKManager.GetSharePlatform();
		}
	}

	// Token: 0x0600587E RID: 22654 RVA: 0x001003ED File Offset: 0x000FE5ED
	protected virtual void OnGetSharePlatform(string str)
	{
		this.GetSharePlatformState = false;
	}

	// Token: 0x0600587F RID: 22655 RVA: 0x001003F8 File Offset: 0x000FE5F8
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

	// Token: 0x06005880 RID: 22656 RVA: 0x0010044F File Offset: 0x000FE64F
	protected virtual void OnPaymentCallBack(FPaymentStruct payment, string strResult, Action<bool, string> paymentFunction)
	{
		paymentFunction(payment.PaymentType == EPaymentType.Success, strResult);
	}

	// Token: 0x06005881 RID: 22657 RVA: 0x00100464 File Offset: 0x000FE664
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

	// Token: 0x06005882 RID: 22658 RVA: 0x001004B4 File Offset: 0x000FE6B4
	public virtual string GetDeviceDid()
	{
		return this.CurrentDid;
	}

	// Token: 0x06005883 RID: 22659 RVA: 0x001004BC File Offset: 0x000FE6BC
	public virtual void ResetCustomServerRedDot()
	{
		this.CurrentCustomerShowState = false;
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06005884 RID: 22660 RVA: 0x001004D5 File Offset: 0x000FE6D5
	public virtual bool GetProtocolState()
	{
		return this.CurrentProtocolState || UKuroSDKManager.GetIsAgreeProtocol();
	}

	// Token: 0x06005885 RID: 22661 RVA: 0x001004EB File Offset: 0x000FE6EB
	public virtual bool GetCustomerServiceShowState()
	{
		return this.CurrentCustomerShowState;
	}

	// Token: 0x06005886 RID: 22662 RVA: 0x001004F3 File Offset: 0x000FE6F3
	public virtual bool CheckPhotoPermission()
	{
		return UKuroSDKManager.CheckPhotoPermission();
	}

	// Token: 0x06005887 RID: 22663 RVA: 0x001004FA File Offset: 0x000FE6FA
	public virtual void RequestPhotoPermission(Action<bool> callBack)
	{
		UKuroSDKManager.Get().RequestPhotoPermissionDelegate.Clear();
		UKuroSDKManager.Get().RequestPhotoPermissionDelegate.Add(callBack);
		UKuroSDKManager.RequestPhotoPermission();
	}

	// Token: 0x06005888 RID: 22664 RVA: 0x00100520 File Offset: 0x000FE720
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

	// Token: 0x06005889 RID: 22665 RVA: 0x001005BC File Offset: 0x000FE7BC
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

	// Token: 0x0600588A RID: 22666 RVA: 0x00100634 File Offset: 0x000FE834
	protected virtual int CurrentPlatformYearReviewTime()
	{
		return 0;
	}

	// Token: 0x0600588B RID: 22667 RVA: 0x00100638 File Offset: 0x000FE838
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

	// Token: 0x0600588C RID: 22668 RVA: 0x0010069C File Offset: 0x000FE89C
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

	// Token: 0x0600588D RID: 22669 RVA: 0x001006F0 File Offset: 0x000FE8F0
	public virtual void SetCursor(string path)
	{
		UKuroSDKManager.SetCursor(path);
	}

	// Token: 0x0600588E RID: 22670 RVA: 0x001006F8 File Offset: 0x000FE8F8
	public virtual void SetGamePadMode(bool ifGamePad)
	{
		UKuroSDKManager.SetGamePadMode(ifGamePad);
	}

	// Token: 0x0600588F RID: 22671 RVA: 0x00100700 File Offset: 0x000FE900
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

	// Token: 0x06005890 RID: 22672 RVA: 0x0010072C File Offset: 0x000FE92C
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

	// Token: 0x06005891 RID: 22673 RVA: 0x001007AB File Offset: 0x000FE9AB
	protected virtual string GetCustomServerRoleId()
	{
		return StringUtils.Format("{0}", new string[]
		{
			this.GetRoleId()
		});
	}

	// Token: 0x06005892 RID: 22674 RVA: 0x001007C8 File Offset: 0x000FE9C8
	protected virtual string GetCustomServerExtendsInfo()
	{
		return Json.Stringify<OpenCustomerServiceExtendsInfo>(new OpenCustomerServiceExtendsInfo
		{
			data = new OpenCustomerServiceExtendsInfoData[]
			{
				new OpenCustomerServiceExtendsInfoData
				{
					key = "version",
					label = "version",
					value = BaseConfigController.Instance.GetP4Version()
				}
			}
		}, null) ?? "";
	}

	// Token: 0x06005893 RID: 22675 RVA: 0x00100827 File Offset: 0x000FEA27
	public virtual void OpenExternalUrl(string url)
	{
		UKismetSystemLibrary.LaunchURL(url);
	}

	// Token: 0x06005894 RID: 22676 RVA: 0x0010082F File Offset: 0x000FEA2F
	public virtual void CloseWebView(string identifier)
	{
		UKuroSDKManager.CloseWebView(identifier);
	}

	// Token: 0x06005895 RID: 22677 RVA: 0x00100837 File Offset: 0x000FEA37
	public virtual string GetThirdUserId()
	{
		return "";
	}

	// Token: 0x06005896 RID: 22678 RVA: 0x0010083E File Offset: 0x000FEA3E
	public virtual string GetOnlineId()
	{
		return "";
	}

	// Token: 0x06005897 RID: 22679 RVA: 0x00100845 File Offset: 0x000FEA45
	public virtual void OpenProfileCard(string uid)
	{
	}

	// Token: 0x06005898 RID: 22680 RVA: 0x00100848 File Offset: 0x000FEA48
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public virtual UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
	{
		PlatformSdkBase.<GetSdkBlockingUser>d__115 <GetSdkBlockingUser>d__;
		<GetSdkBlockingUser>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
		<GetSdkBlockingUser>d__.<>1__state = -1;
		<GetSdkBlockingUser>d__.<>t__builder.Start<PlatformSdkBase.<GetSdkBlockingUser>d__115>(ref <GetSdkBlockingUser>d__);
		return <GetSdkBlockingUser>d__.<>t__builder.Task;
	}

	// Token: 0x06005899 RID: 22681 RVA: 0x00100883 File Offset: 0x000FEA83
	public virtual void SetPlayOnly(bool state)
	{
		this.PlayOnlyState = state;
	}

	// Token: 0x0600589A RID: 22682 RVA: 0x0010088C File Offset: 0x000FEA8C
	public virtual bool NeedCheckPlayOnly()
	{
		return false;
	}

	// Token: 0x0600589B RID: 22683 RVA: 0x0010088F File Offset: 0x000FEA8F
	public virtual bool PlayOnly()
	{
		return this.NeedCheckPlayOnly() && this.PlayOnlyState;
	}

	// Token: 0x0600589C RID: 22684 RVA: 0x001008A1 File Offset: 0x000FEAA1
	public virtual bool GetSdkFriendOnlyState()
	{
		return false;
	}

	// Token: 0x0600589D RID: 22685 RVA: 0x001008A4 File Offset: 0x000FEAA4
	public virtual void SaveSdkFriendOnlyState(bool state)
	{
	}

	// Token: 0x0600589E RID: 22686 RVA: 0x001008A6 File Offset: 0x000FEAA6
	public virtual bool SupportSwitchFriendShowType()
	{
		return false;
	}

	// Token: 0x0600589F RID: 22687 RVA: 0x001008A9 File Offset: 0x000FEAA9
	public virtual bool NeedShowThirdPartyId()
	{
		return false;
	}

	// Token: 0x060058A0 RID: 22688 RVA: 0x001008AC File Offset: 0x000FEAAC
	public virtual string CreatePlayerSession(string id)
	{
		return "-1";
	}

	// Token: 0x060058A1 RID: 22689 RVA: 0x001008B3 File Offset: 0x000FEAB3
	public virtual void SetMultiPlayerActivity(int currentPlayerCount, int maxPlayerCount, string playerSession, EXboxMultiplayerActivityJoinRestriction restriction)
	{
	}

	// Token: 0x060058A2 RID: 22690 RVA: 0x001008B5 File Offset: 0x000FEAB5
	public virtual bool CheckPrivilege(ESdkPrivilege privilege)
	{
		return true;
	}

	// Token: 0x060058A3 RID: 22691 RVA: 0x001008B8 File Offset: 0x000FEAB8
	public virtual bool ResolvePrivilege(ESdkPrivilege privilege)
	{
		return true;
	}

	// Token: 0x060058A4 RID: 22692 RVA: 0x001008BB File Offset: 0x000FEABB
	public virtual string GetSessionId(string playerSession)
	{
		return "-1";
	}

	// Token: 0x060058A5 RID: 22693 RVA: 0x001008C2 File Offset: 0x000FEAC2
	public virtual bool SupportSwitchFriendSearchByThirdPartyId()
	{
		return false;
	}

	// Token: 0x060058A6 RID: 22694 RVA: 0x001008C5 File Offset: 0x000FEAC5
	public virtual void LeaveMultiPlayerActivity()
	{
	}

	// Token: 0x060058A7 RID: 22695 RVA: 0x001008C7 File Offset: 0x000FEAC7
	public virtual void JoinSessionBindFunction(Action<string, string> callback)
	{
	}

	// Token: 0x060058A8 RID: 22696 RVA: 0x001008C9 File Offset: 0x000FEAC9
	public virtual void UpdateRecentPlayer(string[] ids)
	{
	}

	// Token: 0x060058A9 RID: 22697 RVA: 0x001008CB File Offset: 0x000FEACB
	public virtual bool CheckIfSingleServerAfterSelect()
	{
		return false;
	}

	// Token: 0x060058AA RID: 22698 RVA: 0x001008D0 File Offset: 0x000FEAD0
	[return: Nullable(0)]
	public virtual UniTask<bool> SaveSingleServerRegion(int loginType, string region, string userId, string userName, string token)
	{
		PlatformSdkBase.<SaveSingleServerRegion>d__134 <SaveSingleServerRegion>d__;
		<SaveSingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveSingleServerRegion>d__.<>1__state = -1;
		<SaveSingleServerRegion>d__.<>t__builder.Start<PlatformSdkBase.<SaveSingleServerRegion>d__134>(ref <SaveSingleServerRegion>d__);
		return <SaveSingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x060058AB RID: 22699 RVA: 0x0010090C File Offset: 0x000FEB0C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public virtual UniTask<string> GetOnlyRegionInfo(ILoginInfo result)
	{
		PlatformSdkBase.<GetOnlyRegionInfo>d__135 <GetOnlyRegionInfo>d__;
		<GetOnlyRegionInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetOnlyRegionInfo>d__.<>1__state = -1;
		<GetOnlyRegionInfo>d__.<>t__builder.Start<PlatformSdkBase.<GetOnlyRegionInfo>d__135>(ref <GetOnlyRegionInfo>d__);
		return <GetOnlyRegionInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060058AC RID: 22700 RVA: 0x00100947 File Offset: 0x000FEB47
	public virtual void CheckPermission(string id, ESdkPermission permission, Action<bool> callback)
	{
		callback(true);
	}

	// Token: 0x060058AD RID: 22701 RVA: 0x00100950 File Offset: 0x000FEB50
	public virtual string GetExternalToken()
	{
		return "";
	}

	// Token: 0x060058AE RID: 22702 RVA: 0x00100958 File Offset: 0x000FEB58
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public virtual UniTask<string> GetExternalCollectionId()
	{
		PlatformSdkBase.<GetExternalCollectionId>d__138 <GetExternalCollectionId>d__;
		<GetExternalCollectionId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetExternalCollectionId>d__.<>1__state = -1;
		<GetExternalCollectionId>d__.<>t__builder.Start<PlatformSdkBase.<GetExternalCollectionId>d__138>(ref <GetExternalCollectionId>d__);
		return <GetExternalCollectionId>d__.<>t__builder.Task;
	}

	// Token: 0x060058AF RID: 22703 RVA: 0x00100993 File Offset: 0x000FEB93
	public virtual void OnClear()
	{
	}

	// Token: 0x060058B0 RID: 22704 RVA: 0x00100995 File Offset: 0x000FEB95
	public virtual void RecoverSdkData()
	{
	}

	// Token: 0x04002891 RID: 10385
	private const int TIMEGAP = 1000;

	// Token: 0x04002892 RID: 10386
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002893 RID: 10387
	private const int ONEYEARTIME = 31536000;

	// Token: 0x04002894 RID: 10388
	[Nullable(2)]
	private TimerHandle CheckPostWebViewInitTimer;

	// Token: 0x04002895 RID: 10389
	[Nullable(2)]
	private TimerHandle CheckIfHasInitTimer;

	// Token: 0x04002896 RID: 10390
	protected double LastOpenTime;

	// Token: 0x04002897 RID: 10391
	protected double LastOpenPostViewTime;

	// Token: 0x04002898 RID: 10392
	protected readonly string FeedBackSt = "{0}?token={1}&svr_id={2}&uid={3}&user_name={4}&role_name={5}&role_id={6}&lang={7}";

	// Token: 0x04002899 RID: 10393
	protected string CurrentDid = "";

	// Token: 0x0400289A RID: 10394
	protected List<Action<SharePlatformSt[]>> GetSharePlatformCallBackList = new List<Action<SharePlatformSt[]>>();

	// Token: 0x0400289B RID: 10395
	private bool GetSharePlatformState;

	// Token: 0x0400289C RID: 10396
	private bool CurrentProtocolState;

	// Token: 0x0400289D RID: 10397
	protected bool CurrentCustomerShowState;

	// Token: 0x0400289E RID: 10398
	protected bool ExternalLoginState;

	// Token: 0x0400289F RID: 10399
	protected Dictionary<string, SdkAchievementContentData> AchievementMap = new Dictionary<string, SdkAchievementContentData>();

	// Token: 0x040028A0 RID: 10400
	private bool PlayOnlyState;

	// Token: 0x020074BC RID: 29884
	[NullableContext(0)]
	private enum ESdkLogLevel
	{
		// Token: 0x04026B15 RID: 158485
		Debug,
		// Token: 0x04026B16 RID: 158486
		Info,
		// Token: 0x04026B17 RID: 158487
		Warn,
		// Token: 0x04026B18 RID: 158488
		Error
	}
}

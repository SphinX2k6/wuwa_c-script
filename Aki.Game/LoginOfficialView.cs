using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200157E RID: 5502
[NullableContext(1)]
[Nullable(0)]
public class LoginOfficialView : UiTickViewBase
{
	// Token: 0x0600DC55 RID: 56405 RVA: 0x00413C44 File Offset: 0x00411E44
	public LoginOfficialView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DC56 RID: 56406 RVA: 0x00413D5C File Offset: 0x00411F5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 27;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 14;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.LoginBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.LogoutBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, this.RepairBtnClick);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.LoginBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ShowAgeTipBtnClickCallBack));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.AgreeAgreement));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, this.UserButtonClick);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, this.SecretButtonClick);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, this.ChildPrivacyButtonClick);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, this.OnClickNoticeBtn);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, this.OnExitGameClick);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickServerBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickQRCodeLoginBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.OnClickMenuBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DC57 RID: 56407 RVA: 0x004142F8 File Offset: 0x004124F8
	protected override UniTask OnBeforeStartAsync()
	{
		LoginOfficialView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LoginOfficialView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC58 RID: 56408 RVA: 0x0041433C File Offset: 0x0041253C
	protected override void OnStart()
	{
		ResourceManagerController.Instance.ChangeHttpTickFrequency();
		LoginController.Instance.LogLoginProcessLink(LoginDefine.ELoginStatus.LoginViewOpen, Aki.Protocol.ErrorCode.Success);
		LoginModel.Instance.FixLoginFailInfo();
		base.GetButton(14).RootUIComp.Get().SetUIActive(false);
		this.RefreshLoginState(false);
		this.InitAgreement();
		this.InitLoginText();
		bool uiactive = Info.Instance.IsPcOrGamepadPlatform();
		base.GetButton(12).RootUIComp.Get().SetUIActive(uiactive);
		base.GetItem(13).SetUIActive(false);
		this.RefreshPostViewRedPoint();
		this.RefreshAgeBtn();
		this.RefreshChildBtn();
		this.RefreshCopyRightItem();
		this.RefreshVersionText();
		this.RefreshLogo();
		this.RefreshExitButton();
		this.RefreshAccountButton(false);
		this.RefreshQRCodeLoginBtn(false);
		this.RefreshDownLoadState();
		PreDownloadButtonItemA preDownloadItem = this.PreDownloadItem;
		if (preDownloadItem != null)
		{
			preDownloadItem.Refresh(false);
		}
		if (!UiManager.Instance.IsViewShow(EUiViewName.LoginOfficialStatusView))
		{
			UiManager.Instance.OpenView(EUiViewName.LoginOfficialStatusView, null, null);
		}
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC59 RID: 56409 RVA: 0x00414443 File Offset: 0x00412643
	protected override void OnBeforeDestroy()
	{
		ResourceManagerController.Instance.RestoreHttpTickFrequency();
	}

	// Token: 0x0600DC5A RID: 56410 RVA: 0x00414450 File Offset: 0x00412650
	private void RefreshExitButton()
	{
		if (CloudGameManager.Instance.IsCloudGame)
		{
			base.GetButton(12).RootUIComp.Get().SetUIActive(false);
			return;
		}
		if (!LoginController.Instance.IsSdkLoginMode())
		{
			base.GetButton(12).RootUIComp.Get().SetUIActive(true);
			return;
		}
		string value = PlatformSdkManagerNew.Instance.IsSdkOn ? PlatformSdkManagerNew.Instance.GetPlatformSdk().GetProductId() : UKuroSDKManager.GetPackageId();
		bool uiactive = Array.IndexOf<string>(LoginConfig.Instance.GetLoginViewNoExitButtonPackageIdList(), value) < 0;
		base.GetButton(12).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600DC5B RID: 56411 RVA: 0x00414500 File Offset: 0x00412700
	private void RefreshAccountButton(bool sdkLoginState = false)
	{
		if (CloudGameManager.Instance.IsCloudGame)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			return;
		}
		if (!LoginController.Instance.IsSdkLoginMode())
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(true);
			return;
		}
		string value = PlatformSdkManagerNew.Instance.IsSdkOn ? PlatformSdkManagerNew.Instance.GetPlatformSdk().GetProductId() : UKuroSDKManager.GetPackageId();
		string[] loginViewNoAccountButtonPackageIdList = LoginConfig.Instance.GetLoginViewNoAccountButtonPackageIdList();
		bool uiactive = sdkLoginState && Array.IndexOf<string>(loginViewNoAccountButtonPackageIdList, value) < 0;
		base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600DC5C RID: 56412 RVA: 0x004145B4 File Offset: 0x004127B4
	protected void RefreshQRCodeLoginBtn(bool sdkLoginState = false)
	{
		if (CloudGameManager.Instance.IsCloudGame)
		{
			base.GetButton(20).RootUIComp.Get().SetUIActive(false);
			return;
		}
		if (!LoginController.Instance.IsSdkLoginMode())
		{
			base.GetButton(20).RootUIComp.Get().SetUIActive(false);
			return;
		}
		bool flag = Info.Instance.IsMobilePlatform();
		bool ifGlobalSdk = KuroSdkController.Instance.GetIfGlobalSdk();
		bool ifCanQRCodeLogin = KuroSdkController.Instance.GetIfCanQRCodeLogin();
		bool uiactive = sdkLoginState && flag && !ifGlobalSdk && ifCanQRCodeLogin;
		base.GetButton(20).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600DC5D RID: 56413 RVA: 0x00414660 File Offset: 0x00412860
	protected void OnClickQRCodeLoginBtn()
	{
		if (!KuroSdkController.Instance.GetIfCanQRCodeLogin())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "扫码登录未开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KuroSdkController.Instance.DoQRCodeLogin();
	}

	// Token: 0x0600DC5E RID: 56414 RVA: 0x004146A0 File Offset: 0x004128A0
	private void OnClickMenuBtn()
	{
		if (!this.IsLoginStableState())
		{
			return;
		}
		if (this.IsMenuViewOpenRequested)
		{
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.MenuViewPopView))
		{
			return;
		}
		this.IsMenuViewOpenRequested = true;
		MenuViewOpenParam param = new MenuViewOpenParam
		{
			OpenScene = new EMenuViewOpenScene?(EMenuViewOpenScene.Login)
		};
		UiManager.Instance.OpenView(EUiViewName.MenuViewPopView, param, delegate(bool _, int __)
		{
			this.IsMenuViewOpenRequested = false;
		});
	}

	// Token: 0x0600DC5F RID: 56415 RVA: 0x00414708 File Offset: 0x00412908
	private bool IsLoginStableState()
	{
		LoginModel instance = LoginModel.Instance;
		bool flag = this.IsSdkLoginInFlight || this.IsBindRegionPending || this.IsPostSdkLoginPending || this.IsCharacterLoginInFlight || this.NeedTickDownLoad;
		bool flag2 = instance == null || !instance.IsLoginStatus(LoginDefine.ELoginStatus.Init) || instance.IsSdkLoggingIn();
		return !flag && !flag2;
	}

	// Token: 0x0600DC60 RID: 56416 RVA: 0x00414764 File Offset: 0x00412964
	private void RefreshMenuBtnState()
	{
		UUIButtonComponent button = base.GetButton(27);
		if (button == null)
		{
			return;
		}
		bool flag = this.IsLoginStableState();
		this.MenuBtnEnableApplied = flag;
		button.SetSelfInteractive(flag);
		button.RootUIComp.Get().SetAlpha(flag ? 1f : 0.5f);
	}

	// Token: 0x0600DC61 RID: 56417 RVA: 0x004147B5 File Offset: 0x004129B5
	private void InitAgreement()
	{
		this.IsAgree = true;
		base.GetExtendToggle(5).SetToggleState(this.IsAgree ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600DC62 RID: 56418 RVA: 0x004147DA File Offset: 0x004129DA
	private void InitLoginText()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(10), "ClickEnterGame", Array.Empty<object>());
	}

	// Token: 0x0600DC63 RID: 56419 RVA: 0x004147F8 File Offset: 0x004129F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.LoginRequestResult, new Action<bool>(this.CreateCharacterResult));
		EventSystem.Instance.Add(EEventName.SdkPostWebViewRedPointRefresh, new Action(this.OnSdkPostWebViewRedPointRefresh));
		EventSystem.Instance.Add(EEventName.SdkLoginResult, new Action(this.OnSdkLoginResult));
		EventSystem.Instance.Add(EEventName.OnGetLoginPlayerInfo, this.OnGetLoginPlayerInfo);
		EventSystem.Instance.Add(EEventName.OnConfirmServerItem, new Action(this.OnConfirmServerItem));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add(EEventName.PlayStationJoinSessionEvent, new Action(this.PlayStationJoinSessionEvent));
		EventSystem.Instance.Add(EEventName.OnPreDownloadAvailableUpdate, new Action(this.OnPreDownloadUpdate));
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.OnRefreshSubPackageDownLoadByPriority));
	}

	// Token: 0x0600DC64 RID: 56420 RVA: 0x004148EC File Offset: 0x00412AEC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LoginRequestResult, new Action<bool>(this.CreateCharacterResult));
		EventSystem.Instance.Remove(EEventName.SdkPostWebViewRedPointRefresh, new Action(this.OnSdkPostWebViewRedPointRefresh));
		EventSystem.Instance.Remove(EEventName.SdkLoginResult, new Action(this.OnSdkLoginResult));
		EventSystem.Instance.Remove(EEventName.OnGetLoginPlayerInfo, this.OnGetLoginPlayerInfo);
		EventSystem.Instance.Remove(EEventName.OnConfirmServerItem, new Action(this.OnConfirmServerItem));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove(EEventName.PlayStationJoinSessionEvent, new Action(this.PlayStationJoinSessionEvent));
		EventSystem.Instance.Remove(EEventName.OnPreDownloadAvailableUpdate, new Action(this.OnPreDownloadUpdate));
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.OnRefreshSubPackageDownLoadByPriority));
	}

	// Token: 0x0600DC65 RID: 56421 RVA: 0x004149E0 File Offset: 0x00412BE0
	protected override void OnBeforeShow()
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "LoginProcedure-SdkLogin-界面打开检测sdk状态设置表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnSdkLoginResult();
		}
	}

	// Token: 0x0600DC66 RID: 56422 RVA: 0x00414A1C File Offset: 0x00412C1C
	protected override void OnAfterShow()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			this.IsSdkLoginInFlight = true;
		}
		this.OnAfterShowStartSdkLogin().Forget();
		if (CloudGameManager.Instance.IsCloudGame)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "LoginProcedure-SdkLoginNew-云游戏登录", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (CloudGameManagerLauncher.Instance.IsPreLaunch)
			{
				this.IsSdkLoginInFlight = true;
				LoginController.Instance.OnSdkLogin(CloudGameManager.Instance.GetCloudGameLoginInfo());
				this.TryLogin(false).Forget();
			}
		}
		PreDownloadButtonItemA preDownloadItem = this.PreDownloadItem;
		if (preDownloadItem != null)
		{
			preDownloadItem.RefreshDot();
		}
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC67 RID: 56423 RVA: 0x00414ABC File Offset: 0x00412CBC
	private UniTask OnAfterShowStartSdkLogin()
	{
		LoginOfficialView.<OnAfterShowStartSdkLogin>d__29 <OnAfterShowStartSdkLogin>d__;
		<OnAfterShowStartSdkLogin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAfterShowStartSdkLogin>d__.<>4__this = this;
		<OnAfterShowStartSdkLogin>d__.<>1__state = -1;
		<OnAfterShowStartSdkLogin>d__.<>t__builder.Start<LoginOfficialView.<OnAfterShowStartSdkLogin>d__29>(ref <OnAfterShowStartSdkLogin>d__);
		return <OnAfterShowStartSdkLogin>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC68 RID: 56424 RVA: 0x00414B00 File Offset: 0x00412D00
	[NullableContext(0)]
	private UniTask<bool> BindAccountWithRegion()
	{
		LoginOfficialView.<BindAccountWithRegion>d__30 <BindAccountWithRegion>d__;
		<BindAccountWithRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<BindAccountWithRegion>d__.<>1__state = -1;
		<BindAccountWithRegion>d__.<>t__builder.Start<LoginOfficialView.<BindAccountWithRegion>d__30>(ref <BindAccountWithRegion>d__);
		return <BindAccountWithRegion>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC69 RID: 56425 RVA: 0x00414B3B File Offset: 0x00412D3B
	private void LoginBtnClick()
	{
		if (this.IsMenuViewOpenRequested)
		{
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.MenuViewPopView))
		{
			return;
		}
		this.TryLogin(true).Forget();
	}

	// Token: 0x0600DC6A RID: 56426 RVA: 0x00414B64 File Offset: 0x00412D64
	private UniTask TryLogin(bool isFromClick)
	{
		LoginOfficialView.<TryLogin>d__32 <TryLogin>d__;
		<TryLogin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLogin>d__.<>4__this = this;
		<TryLogin>d__.isFromClick = isFromClick;
		<TryLogin>d__.<>1__state = -1;
		<TryLogin>d__.<>t__builder.Start<LoginOfficialView.<TryLogin>d__32>(ref <TryLogin>d__);
		return <TryLogin>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC6B RID: 56427 RVA: 0x00414BB0 File Offset: 0x00412DB0
	private void LogoutBtnClick()
	{
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.ZJC, "正在登录中, 无法退出！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LogoutAccount);
		confirmBoxDataNew.FunctionMap[2] = new Action(this.LogoutAccount);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		KuroSdkReport.Instance.Report(new SdkReportChangeAccount(null));
	}

	// Token: 0x0600DC6C RID: 56428 RVA: 0x00414C22 File Offset: 0x00412E22
	private void OnClickServerBtn()
	{
		if (!this.IsLoginStableState())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.LoginServerView, null, null);
	}

	// Token: 0x0600DC6D RID: 56429 RVA: 0x00414C3E File Offset: 0x00412E3E
	private void OnSdkPostWebViewRedPointRefresh()
	{
		this.RefreshPostViewRedPoint();
	}

	// Token: 0x0600DC6E RID: 56430 RVA: 0x00414C48 File Offset: 0x00412E48
	private void CreateCharacterResult(bool result)
	{
		this.IsCharacterLoginInFlight = false;
		if (!result)
		{
			this.RefreshMenuBtnState();
			return;
		}
		base.CloseMe(null);
		int? playerSex = LoginModel.Instance.GetPlayerSex();
		if (playerSex == null)
		{
			Log.Instance.Error(ELogModule.Login, ELogAuthor.XXJ, "性别获取为空,账号走的直接登录,性别设置异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		LoginModel.Instance.CreateLoginPromise();
		IReadOnlyList<int> initialRoles = CreateCharacterConfig.Instance.GetInitialRoles();
		UiLoginSceneManager.Instance.PlayRoleMontage(initialRoles[playerSex.Value], EPerformanceRoleState.CreateRole_Login);
		Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "登录请求成功", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiLoginSceneManager.Instance.LoadSequenceAsync(this.GetLoginSequenceName((LoginDefine.ELoginSex)playerSex.Value), delegate
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "登录请求成功,进入游戏", default(ReadOnlySpan<ValueTuple<string, object>>));
			LoginModel.Instance.FinishLoginPromise();
			BlackScreenController.Instance.AddBlackScreen("None", "LoginFinish", "Black", "Default");
		}, false, null);
	}

	// Token: 0x0600DC6F RID: 56431 RVA: 0x00414D20 File Offset: 0x00412F20
	private void OnSdkLoginResult()
	{
		if (KuroSdkController.Instance.CheckIfSingleServerAfterSelect() && !LoginServerModel.Instance.GetIfSetOnlyRegion())
		{
			return;
		}
		this.IsSdkLoginInFlight = false;
		if (LoginModel.Instance.IsSdkLoggedIn())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "LoginProcedure-SdkLogin-登录成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RefreshLoginState(true);
			if (!Platform.Instance.IsWindowsPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DepthOfFieldQuality 1", null);
			}
			this.OnSdkLoginFinish();
			if (KuroSdkController.Instance.CanUseSdk() && !this.IfAutoShowLoginServerView())
			{
				this.OnSdkLoginSuccess().ContinueWith(delegate()
				{
					if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit() && !SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish())
					{
						Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "SdkLogin登录成功-需要下载核心包，自动开始下载", default(ReadOnlySpan<ValueTuple<string, object>>));
						SubPackageController.Instance.AutoDownLoadKeySubPackage();
						this.RefreshDownLoadState();
						return;
					}
					this.AfterDownLoad();
				}).Forget();
			}
			else
			{
				this.AfterDownLoad();
			}
		}
		else
		{
			this.RefreshLoginState(false);
			if (Info.Instance.IsPs5Platform())
			{
				LoginModel.Instance.ThirdGameAutoLoginId = "-1";
			}
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "LoginProcedure-SdkLogin-登录失败, 重新打开SDK登录界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC70 RID: 56432 RVA: 0x00414E1C File Offset: 0x0041301C
	private UniTask OnSdkLoginSuccess()
	{
		LoginOfficialView.<OnSdkLoginSuccess>d__44 <OnSdkLoginSuccess>d__;
		<OnSdkLoginSuccess>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnSdkLoginSuccess>d__.<>4__this = this;
		<OnSdkLoginSuccess>d__.<>1__state = -1;
		<OnSdkLoginSuccess>d__.<>t__builder.Start<LoginOfficialView.<OnSdkLoginSuccess>d__44>(ref <OnSdkLoginSuccess>d__);
		return <OnSdkLoginSuccess>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC71 RID: 56433 RVA: 0x00414E60 File Offset: 0x00413060
	private void OnSdkLoginFinish()
	{
		if (base.IsShow)
		{
			this.UiViewSequence.PlaySequence("Show", false, null);
		}
		KuroSdkController.Instance.ShowExternalLogin();
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			LoginServerModel instance = LoginServerModel.Instance;
			SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
			instance.InitSuggestData(((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "", delegate(ILoginServersData data)
			{
				LoginModel.Instance.SetServerName(data.name);
				LoginModel.Instance.SetServerId(data.id);
			});
			if (this.IfAutoShowLoginServerView())
			{
				UiManager.Instance.OpenView(EUiViewName.LoginServerView, null, delegate(bool isSuccess, int _)
				{
					if (isSuccess)
					{
						HotPatchLogReport.Instance.ReportStartupTiming(EStartupTimingStep.ServerSelectionViewShown, null);
					}
				});
				LoginModel.Instance.ThirdGameAutoLoginId = "-1";
			}
			base.GetButton(14).RootUIComp.Get().SetUIActive(true);
			this.RefreshServerName();
		}
		else
		{
			base.GetButton(14).RootUIComp.Get().SetUIActive(false);
		}
		if (LoginModel.Instance.ThirdGameAutoLoginId != "-1")
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 直接启动 - 模拟点击登录按钮2", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.TryLogin(false).Forget();
		}
	}

	// Token: 0x0600DC72 RID: 56434 RVA: 0x00414FB4 File Offset: 0x004131B4
	private void AfterDownLoad()
	{
		Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "SdkLogin登录成功-最后刷新登录成功表现", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.GetItem(22).SetUIActive(false);
		base.GetItem(18).SetUIActive(true);
		base.GetButton(4).RootUIComp.Get().SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
		base.GetButton(0).RootUIComp.Get().SetUIActive(true);
		base.GetButton(2).SetSelfInteractive(true);
		base.GetButton(1).SetSelfInteractive(true);
		base.GetButton(27).SetSelfInteractive(true);
		base.GetButton(2).RootUIComp.Get().SetAlpha(1f);
		base.GetButton(1).RootUIComp.Get().SetAlpha(1f);
		base.GetButton(27).RootUIComp.Get().SetAlpha(1f);
		base.GetButton(14).RootUIComp.Get().SetUIActive(LoginController.Instance.IsGlobalSdkLoginMode());
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC73 RID: 56435 RVA: 0x004150E8 File Offset: 0x004132E8
	private void DisableDownLoadAbout()
	{
		Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "LoginOfficialView-DisableDownLoadAbout", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.GetItem(18).SetUIActive(false);
		base.GetButton(0).RootUIComp.Get().SetUIActive(false);
		base.GetButton(2).SetSelfInteractive(false);
		base.GetButton(1).SetSelfInteractive(false);
		base.GetButton(27).SetSelfInteractive(false);
		base.GetButton(14).RootUIComp.Get().SetUIActive(false);
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC74 RID: 56436 RVA: 0x00415184 File Offset: 0x00413384
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.MenuViewPopView)
		{
			this.IsMenuViewOpenRequested = false;
			return;
		}
		if (viewName != EUiViewName.LoginServerView)
		{
			return;
		}
		if (KuroSdkController.Instance.CanUseSdk())
		{
			this.DisableDownLoadAbout();
			this.OnSdkLoginSuccess().ContinueWith(delegate()
			{
				if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit() && !SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish())
				{
					Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "SdkLogin-选服后 -需要下载核心包，自动开始下载", default(ReadOnlySpan<ValueTuple<string, object>>));
					SubPackageController.Instance.AutoDownLoadKeySubPackage();
					this.RefreshDownLoadState();
					return;
				}
				this.AfterDownLoad();
			}).Forget();
			return;
		}
		this.AfterDownLoad();
	}

	// Token: 0x0600DC75 RID: 56437 RVA: 0x004151E9 File Offset: 0x004133E9
	private void OnRefreshSubPackageDownLoadByPriority()
	{
		this.RefreshDownLoadState();
	}

	// Token: 0x0600DC76 RID: 56438 RVA: 0x004151F4 File Offset: 0x004133F4
	protected virtual void RefreshDownLoadState()
	{
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return;
		}
		bool flag = !SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish();
		this.NeedTickDownLoad = (flag && this.CurLoginState);
		base.GetItem(22).SetUIActive(this.NeedTickDownLoad);
		base.GetItem(18).SetUIActive(!this.NeedTickDownLoad);
		base.GetButton(0).RootUIComp.Get().SetUIActive(!this.NeedTickDownLoad);
		base.GetButton(4).RootUIComp.Get().SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode() && !this.NeedTickDownLoad);
		base.GetButton(2).SetSelfInteractive(!this.NeedTickDownLoad);
		base.GetButton(1).SetSelfInteractive(!this.NeedTickDownLoad);
		base.GetButton(27).SetSelfInteractive(!this.NeedTickDownLoad);
		if (this.NeedTickDownLoad)
		{
			base.GetButton(2).RootUIComp.Get().SetAlpha(0.5f);
			base.GetButton(1).RootUIComp.Get().SetAlpha(0.5f);
			base.GetButton(27).RootUIComp.Get().SetAlpha(0.5f);
		}
		base.GetButton(14).RootUIComp.Get().SetUIActive(LoginController.Instance.IsGlobalSdkLoginMode() && !this.NeedTickDownLoad);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "SdkLogin-刷新下载状态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NeedTickDownLoad", this.NeedTickDownLoad);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!this.NeedTickDownLoad)
		{
			this.AfterDownLoad();
		}
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC77 RID: 56439 RVA: 0x004153C4 File Offset: 0x004135C4
	protected override void OnTick(float delta)
	{
		if (this.CurLoginState && this.PreDownloadItem != null && !this.PreDownloadItem.GetActive() && this.PreDownloadItem.CanShow(this.CurLoginState))
		{
			this.PreDownloadItem.Refresh(this.CurLoginState);
			this.PreDownloadItem.RefreshDot();
		}
		if (this.IsLoginStableState() != this.MenuBtnEnableApplied)
		{
			this.RefreshMenuBtnState();
		}
		if (!this.NeedTickDownLoad)
		{
			return;
		}
		float num = (float)SubPackageDownLoadModel.Instance.GetSubPackageCurrentHaveDownLoadSpace(1);
		float num2 = (float)SubPackageDownLoadModel.Instance.GetSubPackageCurrentTotalSpace(1);
		float num3 = (num2 > 0f) ? (num / num2) : 0f;
		base.GetSprite(23).SetFillAmount(num3);
		base.GetText(25).SetText(SubPackageDownLoadModel.Instance.ByteConverter(SubPackageDownLoadModel.Instance.GetSubPackageDownLoadSpeed()) + "/s", true);
		base.GetText(26).SetText(SubPackageDownLoadModel.Instance.GetKeyPackageDownLoadingFileName(), true);
		base.GetText(24).SetText(((int)(num3 * 100f)).ToString() + "%", true);
	}

	// Token: 0x0600DC78 RID: 56440 RVA: 0x004154E1 File Offset: 0x004136E1
	private void OnConfirmServerItem()
	{
		this.RefreshServerName();
	}

	// Token: 0x0600DC79 RID: 56441 RVA: 0x004154EC File Offset: 0x004136EC
	private void PlayStationJoinSessionEvent()
	{
		Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 直接启动 - 模拟点击登录按钮 事件触发", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryLogin(false).Forget();
	}

	// Token: 0x0600DC7A RID: 56442 RVA: 0x00415520 File Offset: 0x00413720
	private bool IfAutoShowLoginServerView()
	{
		LoginServerModel instance = LoginServerModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			LoginServerModel loginServerModel = instance;
			SdkLoginConfig sdkLoginConfig = instance2.GetSdkLoginConfig();
			if (loginServerModel.IsFirstLogin(((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? ""))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600DC7B RID: 56443 RVA: 0x0041556B File Offset: 0x0041376B
	protected string GetLoginSequenceName(LoginDefine.ELoginSex sex)
	{
		if (sex != LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_LoginFemale";
		}
		return "LevelSequence_LoginMale";
	}

	// Token: 0x0600DC7C RID: 56444 RVA: 0x0041557C File Offset: 0x0041377C
	private void LogoutAccount()
	{
		ThirdPartySdkManager.Instance.Logout();
		if (KuroSdkController.Instance.CanUseSdk())
		{
			this.RefreshLoginState(false);
			this.UiViewSequence.PlaySequence("Show", false, null);
			UiLayer.Instance.SetShowNormalMaskLayer(false, "");
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROSDKLOGOUT);
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.LoginView, delegate(bool success)
		{
			if (success)
			{
				UiManager.Instance.OpenView(EUiViewName.LoginDebugView, null, null);
			}
		});
	}

	// Token: 0x0600DC7D RID: 56445 RVA: 0x0041560A File Offset: 0x0041380A
	private void AgreeAgreement(EToggleState state)
	{
		this.IsAgree = (state == EToggleState.ETT_Checked);
	}

	// Token: 0x0600DC7E RID: 56446 RVA: 0x00415618 File Offset: 0x00413818
	private void RefreshChildBtn()
	{
		base.GetButton(8).RootUIComp.Get().SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
	}

	// Token: 0x0600DC7F RID: 56447 RVA: 0x0041564C File Offset: 0x0041384C
	private void RefreshAgeBtn()
	{
		base.GetButton(4).RootUIComp.Get().SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
	}

	// Token: 0x0600DC80 RID: 56448 RVA: 0x0041567F File Offset: 0x0041387F
	private void RefreshCopyRightItem()
	{
		base.GetItem(16).SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
	}

	// Token: 0x0600DC81 RID: 56449 RVA: 0x0041569C File Offset: 0x0041389C
	private void RefreshVersionText()
	{
		string text = UCSharpBlueprintFunctionLibrary.HasCSharpEnvironmentInitialized() ? (BaseConfigController.Instance.GetVersionString() + " *") : (BaseConfigController.Instance.GetVersionString() ?? "");
		if (HotFixManager.IsTierEnabled())
		{
			string localResourceQualityTierLabel = HotFixManager.GetLocalResourceQualityTierLabel();
			if (!string.IsNullOrEmpty(localResourceQualityTierLabel))
			{
				text = text + " " + localResourceQualityTierLabel;
			}
		}
		base.GetText(9).SetText(text, true);
	}

	// Token: 0x0600DC82 RID: 56450 RVA: 0x0041570C File Offset: 0x0041390C
	private void RefreshLogo()
	{
		string logoPathByLanguage = UiResourceConfig.Instance.GetLogoPathByLanguage("LoginLogo");
		base.SetTextureByPath(logoPathByLanguage, base.GetTexture(17), null, null);
	}

	// Token: 0x0600DC83 RID: 56451 RVA: 0x00415744 File Offset: 0x00413944
	private void RefreshServerName()
	{
		string currentSelectServerName = LoginServerModel.Instance.GetCurrentSelectServerName();
		base.GetText(15).SetText(currentSelectServerName, true);
	}

	// Token: 0x0600DC84 RID: 56452 RVA: 0x0041576B File Offset: 0x0041396B
	private void RefreshPostViewRedPoint()
	{
	}

	// Token: 0x0600DC85 RID: 56453 RVA: 0x00415770 File Offset: 0x00413970
	private void RefreshNoticeItemState()
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(LoginController.Instance.IsSdkLoginMode() && LoginModel.Instance.IsSdkLoggedIn());
	}

	// Token: 0x0600DC86 RID: 56454 RVA: 0x004157B0 File Offset: 0x004139B0
	private void RefreshLoginState(bool value)
	{
		UUIButtonComponent button = base.GetButton(2);
		UUIButtonComponent button2 = base.GetButton(3);
		bool flag = BaseConfigController.Instance.GetIosAuditFirstDownloadTip() || BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip();
		if (LoginController.Instance.IsSdkLoginMode())
		{
			button.RootUIComp.Get().SetUIActive(value && !CloudGameManager.Instance.IsCloudGame && !flag);
			button2.RootUIComp.Get().SetUIActive(!value);
			if (!value)
			{
				base.GetItem(18).SetUIActive(value);
			}
		}
		else
		{
			button.RootUIComp.Get().SetUIActive(!CloudGameManager.Instance.IsCloudGame && !flag);
			button2.RootUIComp.Get().SetUIActive(false);
		}
		if (!value && LoginController.Instance.IsGlobalSdkLoginMode())
		{
			base.GetButton(14).RootUIComp.Get().SetUIActive(false);
		}
		this.RefreshAccountButton(value);
		this.RefreshQRCodeLoginBtn(value);
		this.RefreshNoticeItemState();
		PreDownloadButtonItemA preDownloadItem = this.PreDownloadItem;
		if (preDownloadItem != null)
		{
			preDownloadItem.Refresh(value);
		}
		this.CurLoginState = value;
		this.RefreshMenuBtnState();
	}

	// Token: 0x0600DC87 RID: 56455 RVA: 0x004158DD File Offset: 0x00413ADD
	private void ShowAgeTipBtnClickCallBack()
	{
		UiManager.Instance.OpenView(EUiViewName.LoginAgeTipView, LoginAgeTipView.ELoginShowType.AgeTip, null);
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
	}

	// Token: 0x0600DC88 RID: 56456 RVA: 0x00415905 File Offset: 0x00413B05
	private void OnPreDownloadUpdate()
	{
		PreDownloadButtonItemA preDownloadItem = this.PreDownloadItem;
		if (preDownloadItem == null)
		{
			return;
		}
		preDownloadItem.Refresh(this.CurLoginState);
	}

	// Token: 0x04007AFC RID: 31484
	private bool IsAgree;

	// Token: 0x04007AFD RID: 31485
	private PreDownloadButtonItemA PreDownloadItem;

	// Token: 0x04007AFE RID: 31486
	private bool CurLoginState;

	// Token: 0x04007AFF RID: 31487
	private bool NeedTickDownLoad;

	// Token: 0x04007B00 RID: 31488
	private bool IsSdkLoginInFlight;

	// Token: 0x04007B01 RID: 31489
	private bool IsBindRegionPending;

	// Token: 0x04007B02 RID: 31490
	private bool IsPostSdkLoginPending;

	// Token: 0x04007B03 RID: 31491
	private bool IsCharacterLoginInFlight;

	// Token: 0x04007B04 RID: 31492
	private bool IsMenuViewOpenRequested;

	// Token: 0x04007B05 RID: 31493
	private bool MenuBtnEnableApplied;

	// Token: 0x04007B06 RID: 31494
	private readonly Action RepairBtnClick = delegate()
	{
		UiManager.Instance.OpenView(EUiViewName.ToolWindowView, null, null);
	};

	// Token: 0x04007B07 RID: 31495
	private readonly Action UserButtonClick = delegate()
	{
		bool flag = false;
		if (KuroSdkController.Instance.CanUseSdk())
		{
			SdkAgreementLinkData[] agreement = KuroSdkController.Instance.GetAgreement();
			for (int i = 0; i < agreement.Length; i++)
			{
				if (agreement[i].link.Contains("agreement_public"))
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("UserTitle"), null);
					KuroSdkController.Instance.SdkOpenUrlWnd(localTextNew, agreement[i].link, true, false, true);
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "打开用户协议", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.OpenView(EUiViewName.LoginAgeTipView, LoginAgeTipView.ELoginShowType.UserAgreement, null);
			UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		}
	};

	// Token: 0x04007B08 RID: 31496
	private readonly Action SecretButtonClick = delegate()
	{
		bool flag = false;
		if (KuroSdkController.Instance.CanUseSdk())
		{
			SdkAgreementLinkData[] agreement = KuroSdkController.Instance.GetAgreement();
			for (int i = 0; i < agreement.Length; i++)
			{
				if (agreement[i].link.Contains("personal_privacy"))
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("PrivacyTitle"), null);
					KuroSdkController.Instance.SdkOpenUrlWnd(localTextNew, agreement[i].link, true, false, true);
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "打开隐私政策", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.OpenView(EUiViewName.LoginAgeTipView, LoginAgeTipView.ELoginShowType.PrivacyAgreement, null);
			UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		}
	};

	// Token: 0x04007B09 RID: 31497
	private readonly Action ChildPrivacyButtonClick = delegate()
	{
		bool flag = false;
		if (KuroSdkController.Instance.CanUseSdk())
		{
			SdkAgreementLinkData[] agreement = KuroSdkController.Instance.GetAgreement();
			for (int i = 0; i < agreement.Length; i++)
			{
				if (agreement[i].link.Contains("child_privacy"))
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("ChildPrivacyTitle"), null);
					KuroSdkController.Instance.SdkOpenUrlWnd(localTextNew, agreement[i].link, true, false, true);
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "打开儿童隐私政策", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.OpenView(EUiViewName.LoginAgeTipView, LoginAgeTipView.ELoginShowType.ChildPrivacyAgreement, null);
			UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		}
	};

	// Token: 0x04007B0A RID: 31498
	private readonly Action OnClickNoticeBtn = delegate()
	{
		KuroSdkController.Instance.OpenNotice(EOpenNoticeStage.BeforeLogin);
	};

	// Token: 0x04007B0B RID: 31499
	private readonly Action OnExitGameClick = delegate()
	{
		ConfirmBoxController.Instance.ShowExitGameConfirmBox();
	};

	// Token: 0x04007B0C RID: 31500
	private readonly Action OnGetLoginPlayerInfo = delegate()
	{
	};

	// Token: 0x0200782C RID: 30764
	[NullableContext(0)]
	private enum ELoginOfficialChildCom
	{
		// Token: 0x04026FE3 RID: 159715
		FullLoginBtn,
		// Token: 0x04026FE4 RID: 159716
		LogoutBtn,
		// Token: 0x04026FE5 RID: 159717
		RepairBtn,
		// Token: 0x04026FE6 RID: 159718
		LoginBtn,
		// Token: 0x04026FE7 RID: 159719
		AgeTipButton,
		// Token: 0x04026FE8 RID: 159720
		LockExtendToggle,
		// Token: 0x04026FE9 RID: 159721
		UserButton,
		// Token: 0x04026FEA RID: 159722
		SecretButton,
		// Token: 0x04026FEB RID: 159723
		ChildPrivacyButton,
		// Token: 0x04026FEC RID: 159724
		VersionText,
		// Token: 0x04026FED RID: 159725
		LoginText,
		// Token: 0x04026FEE RID: 159726
		NoticeBtn,
		// Token: 0x04026FEF RID: 159727
		ExitGameButton,
		// Token: 0x04026FF0 RID: 159728
		NoticeRedPoint,
		// Token: 0x04026FF1 RID: 159729
		ServerBtn,
		// Token: 0x04026FF2 RID: 159730
		ServerName,
		// Token: 0x04026FF3 RID: 159731
		CopyRightItem,
		// Token: 0x04026FF4 RID: 159732
		LoginLogo,
		// Token: 0x04026FF5 RID: 159733
		EnterGameItem,
		// Token: 0x04026FF6 RID: 159734
		MobilePreDownloadBtn,
		// Token: 0x04026FF7 RID: 159735
		QRCodeLoginBtn,
		// Token: 0x04026FF8 RID: 159736
		DownLoadBtn,
		// Token: 0x04026FF9 RID: 159737
		DownLoadItem,
		// Token: 0x04026FFA RID: 159738
		DownLoadBarSprite,
		// Token: 0x04026FFB RID: 159739
		DownLoadProgressText,
		// Token: 0x04026FFC RID: 159740
		DownLoadSpeedText,
		// Token: 0x04026FFD RID: 159741
		PatchText,
		// Token: 0x04026FFE RID: 159742
		MenuBtn
	}
}

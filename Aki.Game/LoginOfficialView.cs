using System;
using System.Collections.Generic;
using System.Linq;
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
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020A7 RID: 8359
[NullableContext(1)]
[Nullable(0)]
public class LoginOfficialView : UiTickViewBase
{
	// Token: 0x060107E6 RID: 67558 RVA: 0x004075A4 File Offset: 0x004057A4
	public LoginOfficialView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060107E7 RID: 67559 RVA: 0x004076E0 File Offset: 0x004058E0
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
		*span2[num] = new ValueTuple<int, Delegate>(14, this.OnClickServerBtn);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickQRCodeLoginBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.OnClickMenuBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060107E8 RID: 67560 RVA: 0x00407C78 File Offset: 0x00405E78
	protected override UniTask OnBeforeStartAsync()
	{
		LoginOfficialView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LoginOfficialView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107E9 RID: 67561 RVA: 0x00407CBC File Offset: 0x00405EBC
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

	// Token: 0x060107EA RID: 67562 RVA: 0x00407DC3 File Offset: 0x00405FC3
	protected override void OnBeforeDestroy()
	{
		ResourceManagerController.Instance.RestoreHttpTickFrequency();
	}

	// Token: 0x060107EB RID: 67563 RVA: 0x00407DD0 File Offset: 0x00405FD0
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
		bool uiactive = !LoginConfig.Instance.GetLoginViewNoExitButtonPackageIdList().Contains(value);
		base.GetButton(12).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060107EC RID: 67564 RVA: 0x00407E80 File Offset: 0x00406080
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
		bool uiactive = sdkLoginState && !loginViewNoAccountButtonPackageIdList.Contains(value);
		base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060107ED RID: 67565 RVA: 0x00407F34 File Offset: 0x00406134
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

	// Token: 0x060107EE RID: 67566 RVA: 0x00407FE0 File Offset: 0x004061E0
	protected void OnClickQRCodeLoginBtn()
	{
		if (!KuroSdkController.Instance.GetIfCanQRCodeLogin())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "扫码登录未开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KuroSdkController.Instance.DoQRCodeLogin();
	}

	// Token: 0x060107EF RID: 67567 RVA: 0x00408020 File Offset: 0x00406220
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

	// Token: 0x060107F0 RID: 67568 RVA: 0x00408088 File Offset: 0x00406288
	private bool IsLoginStableState()
	{
		LoginModel instance = LoginModel.Instance;
		bool flag = this.IsSdkLoginInFlight || this.IsBindRegionPending || this.IsPostSdkLoginPending || this.IsCharacterLoginInFlight || this.NeedTickDownLoad;
		bool flag2 = instance == null || !instance.IsLoginStatus(LoginDefine.ELoginStatus.Init) || instance.IsSdkLoggingIn();
		return !flag && !flag2;
	}

	// Token: 0x060107F1 RID: 67569 RVA: 0x004080E4 File Offset: 0x004062E4
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

	// Token: 0x060107F2 RID: 67570 RVA: 0x00408135 File Offset: 0x00406335
	private void InitAgreement()
	{
		this.IsAgree = true;
		base.GetExtendToggle(5).SetToggleState(this.IsAgree ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060107F3 RID: 67571 RVA: 0x0040815A File Offset: 0x0040635A
	private void InitLoginText()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(10), "ClickEnterGame", Array.Empty<object>());
	}

	// Token: 0x060107F4 RID: 67572 RVA: 0x00408178 File Offset: 0x00406378
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

	// Token: 0x060107F5 RID: 67573 RVA: 0x0040826C File Offset: 0x0040646C
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

	// Token: 0x060107F6 RID: 67574 RVA: 0x00408360 File Offset: 0x00406560
	protected override void OnBeforeShow()
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.TL, "LoginProcedure-SdkLogin-界面打开检测sdk状态设置表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnSdkLoginResult();
		}
	}

	// Token: 0x060107F7 RID: 67575 RVA: 0x0040839C File Offset: 0x0040659C
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

	// Token: 0x060107F8 RID: 67576 RVA: 0x0040843C File Offset: 0x0040663C
	private UniTask OnAfterShowStartSdkLogin()
	{
		LoginOfficialView.<OnAfterShowStartSdkLogin>d__29 <OnAfterShowStartSdkLogin>d__;
		<OnAfterShowStartSdkLogin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAfterShowStartSdkLogin>d__.<>4__this = this;
		<OnAfterShowStartSdkLogin>d__.<>1__state = -1;
		<OnAfterShowStartSdkLogin>d__.<>t__builder.Start<LoginOfficialView.<OnAfterShowStartSdkLogin>d__29>(ref <OnAfterShowStartSdkLogin>d__);
		return <OnAfterShowStartSdkLogin>d__.<>t__builder.Task;
	}

	// Token: 0x060107F9 RID: 67577 RVA: 0x00408480 File Offset: 0x00406680
	[NullableContext(0)]
	private UniTask<bool> BindAccountWithRegion()
	{
		LoginOfficialView.<BindAccountWithRegion>d__30 <BindAccountWithRegion>d__;
		<BindAccountWithRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<BindAccountWithRegion>d__.<>1__state = -1;
		<BindAccountWithRegion>d__.<>t__builder.Start<LoginOfficialView.<BindAccountWithRegion>d__30>(ref <BindAccountWithRegion>d__);
		return <BindAccountWithRegion>d__.<>t__builder.Task;
	}

	// Token: 0x060107FA RID: 67578 RVA: 0x004084BB File Offset: 0x004066BB
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

	// Token: 0x060107FB RID: 67579 RVA: 0x004084E4 File Offset: 0x004066E4
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

	// Token: 0x060107FC RID: 67580 RVA: 0x00408530 File Offset: 0x00406730
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

	// Token: 0x060107FD RID: 67581 RVA: 0x004085A2 File Offset: 0x004067A2
	private void OnSdkPostWebViewRedPointRefresh()
	{
		this.RefreshPostViewRedPoint();
	}

	// Token: 0x060107FE RID: 67582 RVA: 0x004085AC File Offset: 0x004067AC
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

	// Token: 0x060107FF RID: 67583 RVA: 0x00408684 File Offset: 0x00406884
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

	// Token: 0x06010800 RID: 67584 RVA: 0x00408780 File Offset: 0x00406980
	private UniTask OnSdkLoginSuccess()
	{
		LoginOfficialView.<OnSdkLoginSuccess>d__44 <OnSdkLoginSuccess>d__;
		<OnSdkLoginSuccess>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnSdkLoginSuccess>d__.<>4__this = this;
		<OnSdkLoginSuccess>d__.<>1__state = -1;
		<OnSdkLoginSuccess>d__.<>t__builder.Start<LoginOfficialView.<OnSdkLoginSuccess>d__44>(ref <OnSdkLoginSuccess>d__);
		return <OnSdkLoginSuccess>d__.<>t__builder.Task;
	}

	// Token: 0x06010801 RID: 67585 RVA: 0x004087C4 File Offset: 0x004069C4
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
				UiManager.Instance.OpenView(EUiViewName.LoginServerView, null, null);
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

	// Token: 0x06010802 RID: 67586 RVA: 0x004088F8 File Offset: 0x00406AF8
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

	// Token: 0x06010803 RID: 67587 RVA: 0x00408A2C File Offset: 0x00406C2C
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

	// Token: 0x06010804 RID: 67588 RVA: 0x00408AC8 File Offset: 0x00406CC8
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

	// Token: 0x06010805 RID: 67589 RVA: 0x00408B2D File Offset: 0x00406D2D
	private void OnRefreshSubPackageDownLoadByPriority()
	{
		this.RefreshDownLoadState();
	}

	// Token: 0x06010806 RID: 67590 RVA: 0x00408B38 File Offset: 0x00406D38
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

	// Token: 0x06010807 RID: 67591 RVA: 0x00408D08 File Offset: 0x00406F08
	protected override void OnTick(float delta)
	{
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

	// Token: 0x06010808 RID: 67592 RVA: 0x00408DD9 File Offset: 0x00406FD9
	private void OnConfirmServerItem()
	{
		this.RefreshServerName();
	}

	// Token: 0x06010809 RID: 67593 RVA: 0x00408DE4 File Offset: 0x00406FE4
	private void PlayStationJoinSessionEvent()
	{
		Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 直接启动 - 模拟点击登录按钮 事件触发", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryLogin(false).Forget();
	}

	// Token: 0x0601080A RID: 67594 RVA: 0x00408E18 File Offset: 0x00407018
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

	// Token: 0x0601080B RID: 67595 RVA: 0x00408E63 File Offset: 0x00407063
	protected string GetLoginSequenceName(LoginDefine.ELoginSex sex)
	{
		if (sex != LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_LoginFemale";
		}
		return "LevelSequence_LoginMale";
	}

	// Token: 0x0601080C RID: 67596 RVA: 0x00408E74 File Offset: 0x00407074
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

	// Token: 0x0601080D RID: 67597 RVA: 0x00408F02 File Offset: 0x00407102
	private void AgreeAgreement(EToggleState state)
	{
		this.IsAgree = (state == EToggleState.ETT_Checked);
	}

	// Token: 0x0601080E RID: 67598 RVA: 0x00408F10 File Offset: 0x00407110
	private void RefreshChildBtn()
	{
		base.GetButton(8).RootUIComp.Get().SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
	}

	// Token: 0x0601080F RID: 67599 RVA: 0x00408F44 File Offset: 0x00407144
	private void RefreshAgeBtn()
	{
		base.GetButton(4).RootUIComp.Get().SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
	}

	// Token: 0x06010810 RID: 67600 RVA: 0x00408F77 File Offset: 0x00407177
	private void RefreshCopyRightItem()
	{
		base.GetItem(16).SetUIActive(!LoginController.Instance.IsGlobalSdkLoginMode());
	}

	// Token: 0x06010811 RID: 67601 RVA: 0x00408F94 File Offset: 0x00407194
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

	// Token: 0x06010812 RID: 67602 RVA: 0x00409004 File Offset: 0x00407204
	private void RefreshLogo()
	{
		string logoPathByLanguage = UiResourceConfig.Instance.GetLogoPathByLanguage("LoginLogo");
		base.SetTextureByPath(logoPathByLanguage, base.GetTexture(17), null, null);
	}

	// Token: 0x06010813 RID: 67603 RVA: 0x0040903C File Offset: 0x0040723C
	private void RefreshServerName()
	{
		string currentSelectServerName = LoginServerModel.Instance.GetCurrentSelectServerName();
		base.GetText(15).SetText(currentSelectServerName, true);
	}

	// Token: 0x06010814 RID: 67604 RVA: 0x00409063 File Offset: 0x00407263
	private void RefreshPostViewRedPoint()
	{
	}

	// Token: 0x06010815 RID: 67605 RVA: 0x00409068 File Offset: 0x00407268
	private void RefreshNoticeItemState()
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(LoginController.Instance.IsSdkLoginMode() && LoginModel.Instance.IsSdkLoggedIn());
	}

	// Token: 0x06010816 RID: 67606 RVA: 0x004090A8 File Offset: 0x004072A8
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

	// Token: 0x06010817 RID: 67607 RVA: 0x004091D5 File Offset: 0x004073D5
	private void ShowAgeTipBtnClickCallBack()
	{
		UiManager.Instance.OpenView(EUiViewName.LoginAgeTipView, LoginAgeTipView.ELoginShowType.AgeTip, null);
		UiLayer.Instance.SetShowNormalMaskLayer(true, "");
	}

	// Token: 0x06010818 RID: 67608 RVA: 0x004091FD File Offset: 0x004073FD
	private void OnPreDownloadUpdate()
	{
		PreDownloadButtonItemA preDownloadItem = this.PreDownloadItem;
		if (preDownloadItem == null)
		{
			return;
		}
		preDownloadItem.Refresh(this.CurLoginState);
	}

	// Token: 0x040079FD RID: 31229
	private bool IsAgree;

	// Token: 0x040079FE RID: 31230
	private PreDownloadButtonItemA PreDownloadItem;

	// Token: 0x040079FF RID: 31231
	private bool CurLoginState;

	// Token: 0x04007A00 RID: 31232
	private bool NeedTickDownLoad;

	// Token: 0x04007A01 RID: 31233
	private bool IsSdkLoginInFlight;

	// Token: 0x04007A02 RID: 31234
	private bool IsBindRegionPending;

	// Token: 0x04007A03 RID: 31235
	private bool IsPostSdkLoginPending;

	// Token: 0x04007A04 RID: 31236
	private bool IsCharacterLoginInFlight;

	// Token: 0x04007A05 RID: 31237
	private bool IsMenuViewOpenRequested;

	// Token: 0x04007A06 RID: 31238
	private bool MenuBtnEnableApplied;

	// Token: 0x04007A07 RID: 31239
	private readonly Action RepairBtnClick = delegate()
	{
		UiManager.Instance.OpenView(EUiViewName.ToolWindowView, null, null);
	};

	// Token: 0x04007A08 RID: 31240
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

	// Token: 0x04007A09 RID: 31241
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

	// Token: 0x04007A0A RID: 31242
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

	// Token: 0x04007A0B RID: 31243
	private readonly Action OnClickNoticeBtn = delegate()
	{
		KuroSdkController.Instance.OpenNotice(EOpenNoticeStage.BeforeLogin);
	};

	// Token: 0x04007A0C RID: 31244
	private readonly Action OnExitGameClick = delegate()
	{
		ConfirmBoxController.Instance.ShowExitGameConfirmBox();
	};

	// Token: 0x04007A0D RID: 31245
	private readonly Action OnClickServerBtn = delegate()
	{
		UiManager.Instance.OpenView(EUiViewName.LoginServerView, null, null);
	};

	// Token: 0x04007A0E RID: 31246
	private readonly Action OnGetLoginPlayerInfo = delegate()
	{
	};

	// Token: 0x020086A1 RID: 34465
	[NullableContext(0)]
	private enum ELoginOfficialChildCom
	{
		// Token: 0x0402BCC2 RID: 179394
		FullLoginBtn,
		// Token: 0x0402BCC3 RID: 179395
		LogoutBtn,
		// Token: 0x0402BCC4 RID: 179396
		RepairBtn,
		// Token: 0x0402BCC5 RID: 179397
		LoginBtn,
		// Token: 0x0402BCC6 RID: 179398
		AgeTipButton,
		// Token: 0x0402BCC7 RID: 179399
		LockExtendToggle,
		// Token: 0x0402BCC8 RID: 179400
		UserButton,
		// Token: 0x0402BCC9 RID: 179401
		SecretButton,
		// Token: 0x0402BCCA RID: 179402
		ChildPrivacyButton,
		// Token: 0x0402BCCB RID: 179403
		VersionText,
		// Token: 0x0402BCCC RID: 179404
		LoginText,
		// Token: 0x0402BCCD RID: 179405
		NoticeBtn,
		// Token: 0x0402BCCE RID: 179406
		ExitGameButton,
		// Token: 0x0402BCCF RID: 179407
		NoticeRedPoint,
		// Token: 0x0402BCD0 RID: 179408
		ServerBtn,
		// Token: 0x0402BCD1 RID: 179409
		ServerName,
		// Token: 0x0402BCD2 RID: 179410
		CopyRightItem,
		// Token: 0x0402BCD3 RID: 179411
		LoginLogo,
		// Token: 0x0402BCD4 RID: 179412
		EnterGameItem,
		// Token: 0x0402BCD5 RID: 179413
		MobilePreDownloadBtn,
		// Token: 0x0402BCD6 RID: 179414
		QRCodeLoginBtn,
		// Token: 0x0402BCD7 RID: 179415
		DownLoadBtn,
		// Token: 0x0402BCD8 RID: 179416
		DownLoadItem,
		// Token: 0x0402BCD9 RID: 179417
		DownLoadBarSprite,
		// Token: 0x0402BCDA RID: 179418
		DownLoadProgressText,
		// Token: 0x0402BCDB RID: 179419
		DownLoadSpeedText,
		// Token: 0x0402BCDC RID: 179420
		PatchText,
		// Token: 0x0402BCDD RID: 179421
		MenuBtn
	}
}

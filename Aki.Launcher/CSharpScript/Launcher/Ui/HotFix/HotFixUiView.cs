using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Launcher.Action;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.PlayerInput;
using CSharpScript.Launcher.Ui.SdkView;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EC RID: 236
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixUiView : LaunchComponentsAction
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x0003DAE8 File Offset: 0x0003BCE8
		public UniTask InitAsync(UObject worldContext)
		{
			HotFixUiView.<InitAsync>d__12 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.worldContext = worldContext;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<HotFixUiView.<InitAsync>d__12>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0003DB33 File Offset: 0x0003BD33
		public void SetProtocolViewViewState(bool state)
		{
			SdkProtocolView protocolView = this.ProtocolView;
			if (protocolView == null)
			{
				return;
			}
			protocolView.SetActive(state);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0003DB48 File Offset: 0x0003BD48
		public UniTask ShowProtocolView(SdkProtocolViewData data)
		{
			HotFixUiView.<ShowProtocolView>d__14 <ShowProtocolView>d__;
			<ShowProtocolView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowProtocolView>d__.<>4__this = this;
			<ShowProtocolView>d__.data = data;
			<ShowProtocolView>d__.<>1__state = -1;
			<ShowProtocolView>d__.<>t__builder.Start<HotFixUiView.<ShowProtocolView>d__14>(ref <ShowProtocolView>d__);
			return <ShowProtocolView>d__.<>t__builder.Task;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0003DB94 File Offset: 0x0003BD94
		protected UniTask LoadResourceAsync(UObject worldContext)
		{
			HotFixUiView.<LoadResourceAsync>d__15 <LoadResourceAsync>d__;
			<LoadResourceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadResourceAsync>d__.<>4__this = this;
			<LoadResourceAsync>d__.worldContext = worldContext;
			<LoadResourceAsync>d__.<>1__state = -1;
			<LoadResourceAsync>d__.<>t__builder.Start<HotFixUiView.<LoadResourceAsync>d__15>(ref <LoadResourceAsync>d__);
			return <LoadResourceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003DBDF File Offset: 0x0003BDDF
		private void SetChangeTierPopActive(bool value)
		{
			base.GetElement<HotFixChangeTierPopupView>(105).SetActive(value);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0003DBF0 File Offset: 0x0003BDF0
		private UniTask LoadHotFixLogo()
		{
			HotFixUiView.<LoadHotFixLogo>d__17 <LoadHotFixLogo>d__;
			<LoadHotFixLogo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadHotFixLogo>d__.<>4__this = this;
			<LoadHotFixLogo>d__.<>1__state = -1;
			<LoadHotFixLogo>d__.<>t__builder.Start<HotFixUiView.<LoadHotFixLogo>d__17>(ref <LoadHotFixLogo>d__);
			return <LoadHotFixLogo>d__.<>t__builder.Task;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0003DC34 File Offset: 0x0003BE34
		protected override void OnStart()
		{
			base.GetButton(12).OnClickCallBack.Bind(new Action(this.OnBtnNoticeClick));
			base.GetButton(18).OnClickCallBack.Bind(new Action(this.OnBtnLoginClick));
			base.GetButton(14).OnClickCallBack.Bind(new Action(this.OnBtnExitClick));
			base.GetButton(16).OnClickCallBack.Bind(new Action(this.OnBtnLogOutClick));
			this.SetLogOutButtonActive(false);
			this.SetExitButtonActive(false);
			this.SetLoginInButtonActive(false);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0003DCD0 File Offset: 0x0003BED0
		protected override void OnBeforeDestroy()
		{
			if (this.TickManager != null)
			{
				this.TickManager = null;
			}
			if (this.ProgressText != null)
			{
				this.ProgressText.RemoveGamepadChange();
				this.ProgressText = null;
			}
			if (this.PatchText != null)
			{
				this.PatchText = null;
			}
			if (this.SpeedText != null)
			{
				this.SpeedText = null;
			}
			if (this.ProgressBar != null)
			{
				this.ProgressBar = null;
			}
			base.GetButton(12).OnClickCallBack.Unbind();
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0003DD45 File Offset: 0x0003BF45
		private void OnUiRootLoadCallback(AActor actor)
		{
			this.UiRoot = actor;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0003DD4E File Offset: 0x0003BF4E
		private void OnViewLoadCallback(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
			this.SetContainerItemActive(false);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0003DD60 File Offset: 0x0003BF60
		protected override void OnShow()
		{
			if (this.ProgressText == null)
			{
				Dictionary<string, ValueTuple<string, actionMappings>> dictionary = new Dictionary<string, ValueTuple<string, actionMappings>>();
				dictionary["DownloadContinue"] = new ValueTuple<string, actionMappings>("Ps5_Cilck_Continue", actionMappings.手柄右边下键);
				Dictionary<string, ValueTuple<string, actionMappings>> gamepadDataMap = dictionary;
				this.ProgressText = new HotFixListenDeviceSwitchText(base.GetText(4), gamepadDataMap);
				this.ProgressText.AddGamepadChange();
			}
			this.PatchText = base.GetText(8);
			this.SpeedText = base.GetText(7);
			this.ProgressBar = base.GetTexture(3);
			this.ShowAppInfoText(this.WorldContext);
			this.SetRepairButtonText("PatchClearbutton");
			this.SetRepairButtonEnable(false);
			this.SetRepairButtonCallBack(delegate
			{
				this.SetToolWindowActive(true);
			});
			HotFixManager.SetLocalText(base.GetText(13), "Notice_Btn_Text", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(15), "Exit_Btn_Text", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(17), "Exchange_Btn_Text", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(19), "SignIn_Btn_Text", Array.Empty<string>());
			this.SetNoticeBtnActive(!Platform.Instance.IsAndroidPlatform());
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0003DE78 File Offset: 0x0003C078
		public void SetContainerItemActive(bool value)
		{
			UUIItem item = base.GetItem(0);
			if (value && value != item.IsUIActiveSelf())
			{
				this.SequencePlayer.PlaySequence("Start", null);
			}
			base.GetItem(0).SetUIActive(value);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		public void UpdateProgressRate(float rate)
		{
			this.SetProgressActive(true);
			this.ProgressBar.SetFillAmount(rate);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0003DECD File Offset: 0x0003C0CD
		public void SetProgressActive(bool value)
		{
			base.GetTexture(2).SetUIActive(value);
			this.ProgressBar.SetUIActive(value);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0003DEE8 File Offset: 0x0003C0E8
		public void SetConfirmationItemActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetActive(value);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0003DEF8 File Offset: 0x0003C0F8
		public void SetToolWindowActive(bool value)
		{
			base.GetElement<HotFixToolWindowView>(101).SetActive(value);
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetToolWindowActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0003DF3C File Offset: 0x0003C13C
		public void SetDownLoadActive(bool value)
		{
			base.GetElement<HotFixDownLoadView>(102).SetActive(value);
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetDownLoadActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003DF80 File Offset: 0x0003C180
		public void SetFreeSpaceTipsPopActive(bool value)
		{
			base.GetElement<HotFixDownLoadFreeSpaceTipsView>(103).SetActive(value);
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetHotFixDownLoadFreeSpaceTipsViewActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003DFC4 File Offset: 0x0003C1C4
		[NullableContext(2)]
		private void SetClearSubPackagePopActive(bool value, Action onCloseCallBack = null)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "HotFixDownSubPackageDownLoadMobileClearPopView";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			HotFixDownSubPackageDownLoadMobileClearPopView element = base.GetElement<HotFixDownSubPackageDownLoadMobileClearPopView>(104);
			if (value && onCloseCallBack != null)
			{
				ETier? clearResourceQualityTier = base.GetElement<HotFixDownLoadView>(102).GetClearResourceQualityTier();
				if (clearResourceQualityTier != null)
				{
					ETier restoreTier = HotFixManager.LocalResourceQualityTier;
					ResourceDiffUpdaterManager.Instance.SwitchResTier(clearResourceQualityTier);
					element.OnCloseCallBack = delegate()
					{
						ResourceDiffUpdaterManager.Instance.SwitchResTier(new ETier?(restoreTier));
						onCloseCallBack();
					};
				}
				else
				{
					element.OnCloseCallBack = onCloseCallBack;
				}
			}
			element.SetActive(value);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0003E070 File Offset: 0x0003C270
		private void ShowClearSubPackagePopConfirmBox(Action onConfirmBox)
		{
			LauncherLog.Instance.Info("ShowClearSubPackagePopConfirmBox", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetConfirmationItemActive(true);
			this.SetConfirmationTitle("HotFixTipsTitle");
			this.SetConfirmationContent("HotFixSubPackageClearConfirmContent", Array.Empty<string>());
			this.SetConfirmationLeftButtonActive(true);
			this.SetConfirmationLeftButtonText("HotFixCancel");
			this.SetConfirmationLeftButtonCallBack(delegate
			{
				this.SetConfirmationItemActive(false);
				this.SetClearSubPackagePopActive(true, null);
			});
			this.SetConfirmationMiddleButtonActive(false);
			this.SetConfirmationRightButtonActive(true);
			this.SetConfirmationRightButtonText("ConfirmText");
			this.SetConfirmationRightButtonCallBack(delegate
			{
				this.SetConfirmationItemActive(false);
				onConfirmBox();
			});
			this.SetConfirmationCloseButtonActive(true);
			this.SetConfirmationCloseButtonCallBack(delegate
			{
				this.SetConfirmationItemActive(false);
				this.SetClearSubPackagePopActive(true, null);
			});
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0003E134 File Offset: 0x0003C334
		public void SetNoticeBtnActive(bool value)
		{
			base.GetText(13).SetUIActive(value);
			base.GetButton(12).SetSelfInteractive(value);
			base.GetButton(12).RootUIComp.Get().SetUIActive(value);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0003E178 File Offset: 0x0003C378
		public void SetProgressLeftTips(string tableId, params string[] args)
		{
			this.ProgressText.SetLocalText(tableId, args);
			this.PatchText.SetText("", true);
			this.SpeedText.SetText("", true);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0003E1A9 File Offset: 0x0003C3A9
		public void SetProgressLeftTipsEmpty()
		{
			this.ProgressText.SetEmptyText();
			this.PatchText.SetText("", true);
			this.SpeedText.SetText("", true);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
		public void SetProgressText(string tableId, params string[] args)
		{
			this.ProgressText.SetLocalText(tableId, args);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0003E1E7 File Offset: 0x0003C3E7
		public void SetPatchText(string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(this.PatchText, tableId, args);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0003E1F6 File Offset: 0x0003C3F6
		public void SetSpeedText(string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(this.SpeedText, tableId, args);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0003E205 File Offset: 0x0003C405
		public void SetProgressLeftActive(bool value)
		{
			this.ProgressText.SetUiActive(value);
			this.PatchText.SetUIActive(value);
			this.SpeedText.SetUIActive(value);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0003E22B File Offset: 0x0003C42B
		public void SetProgressRightTips(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(5), tableId, Array.Empty<string>());
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0003E23F File Offset: 0x0003C43F
		public void SetProgressRightActive(bool value)
		{
			base.GetText(5).SetUIActive(value);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0003E24E File Offset: 0x0003C44E
		public void SetConfirmationTitle(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationTitle(tableId);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0003E25E File Offset: 0x0003C45E
		public void SetConfirmationContent(string tableId, params string[] args)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationContent(tableId, args);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0003E26F File Offset: 0x0003C46F
		public void SetConfirmationLeftButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationLeftButtonCallBack(callback);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0003E27F File Offset: 0x0003C47F
		public void SetConfirmationRightButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationRightButtonCallBack(callback);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0003E28F File Offset: 0x0003C48F
		[NullableContext(2)]
		public void SetConfirmationLeftButtonText(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationLeftButtonText(tableId);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0003E29F File Offset: 0x0003C49F
		[NullableContext(2)]
		public void SetConfirmationRightButtonText(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationRightButtonText(tableId);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0003E2AF File Offset: 0x0003C4AF
		public void SetConfirmationLeftButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationLeftButtonActive(value);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0003E2BF File Offset: 0x0003C4BF
		public void SetConfirmationRightButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationRightButtonActive(value);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0003E2CF File Offset: 0x0003C4CF
		public void SetConfirmationMiddleButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationMiddleButtonCallBack(callback);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0003E2DF File Offset: 0x0003C4DF
		[NullableContext(2)]
		public void SetConfirmationMiddleButtonText(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationMiddleButtonText(tableId);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0003E2EF File Offset: 0x0003C4EF
		public void SetConfirmationMiddleButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationMiddleButtonActive(value);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0003E2FF File Offset: 0x0003C4FF
		public void SetConfirmationCloseButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationCloseButtonCallBack(callback);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0003E30F File Offset: 0x0003C50F
		public void SetConfirmationCloseButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationCloseButtonActive(value);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0003E31F File Offset: 0x0003C51F
		public void SetMaskButtonCallBack(Action callback)
		{
			base.GetButton(10).OnClickCallBack.Unbind();
			base.GetButton(10).OnClickCallBack.Bind(callback);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0003E346 File Offset: 0x0003C546
		public void SetRepairButtonText(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(11), tableId, Array.Empty<string>());
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0003E35B File Offset: 0x0003C55B
		public void SetRepairButtonEnable(bool bEnable)
		{
			base.GetButton(9).SetSelfInteractive(bEnable);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0003E36C File Offset: 0x0003C56C
		public void SetLoginInButtonActive(bool bEnable)
		{
			base.GetButton(18).RootUIComp.Get().SetUIActive(bEnable);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0003E394 File Offset: 0x0003C594
		public void SetExitButtonActive(bool bEnable)
		{
			base.GetButton(14).RootUIComp.Get().SetUIActive(bEnable);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0003E3BC File Offset: 0x0003C5BC
		public void SetLogOutButtonActive(bool bEnable)
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(bEnable);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
		public void SetRepairButtonCallBack(Action callback)
		{
			base.GetButton(9).OnClickCallBack.Unbind();
			base.GetButton(9).OnClickCallBack.Bind(callback);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0003E40C File Offset: 0x0003C60C
		public bool GetLoginButtonActive()
		{
			return base.GetButton(18).RootUIComp.Get().IsUIActiveSelf();
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0003E433 File Offset: 0x0003C633
		public void ShowAppInfoText(UObject worldContext)
		{
			base.GetText(1).SetText(UCSharpBlueprintFunctionLibrary.HasCSharpEnvironmentInitialized() ? (BaseConfigController.Instance.GetVersionString() + " *") : (BaseConfigController.Instance.GetVersionString() ?? ""), true);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0003E474 File Offset: 0x0003C674
		public UniTask Hide()
		{
			HotFixUiView.<Hide>d__63 <Hide>d__;
			<Hide>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Hide>d__.<>4__this = this;
			<Hide>d__.<>1__state = -1;
			<Hide>d__.<>t__builder.Start<HotFixUiView.<Hide>d__63>(ref <Hide>d__);
			return <Hide>d__.<>t__builder.Task;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0003E4B8 File Offset: 0x0003C6B8
		public override void Destroy()
		{
			base.Destroy();
			if (this.UiRoot != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.UiRoot, true);
				this.UiRoot = null;
			}
			HotPatchInputManager.Instance.Destroy();
			HotPatchEventSystem.Instance.Destroy();
			if (this.WorldContext != null)
			{
				this.WorldContext = null;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0003E509 File Offset: 0x0003C709
		public void RefreshLoginStateOnLoginSuccess()
		{
			this.ShowSdkLogInState();
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0003E511 File Offset: 0x0003C711
		public void RefreshLoginStateBeforeLogin()
		{
			this.ShowSdkLogOutState();
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0003E519 File Offset: 0x0003C719
		private void OnBtnNoticeClick()
		{
			HotFixManager.ShowNoticeWindowByUser();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0003E520 File Offset: 0x0003C720
		public void OnBtnLoginClick()
		{
			LauncherLog.Instance.Info("HotFixView OnBtnLoginClick", default(ReadOnlySpan<ValueTuple<string, object>>));
			HotFixManager.SdkLogin(new Action(this.RefreshLoginStateOnLoginSuccess), true);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0003E558 File Offset: 0x0003C758
		private void OnBtnExitClick()
		{
			LauncherLog.Instance.Info("HotFixView OnBtnExitClick", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKExit;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0003E58C File Offset: 0x0003C78C
		private void OnBtnLogOutClick()
		{
			LauncherLog.Instance.Warn("HotFixView OnBtnLogOutClick,不应该触发", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0003E5B4 File Offset: 0x0003C7B4
		private void ShowSdkLogOutState()
		{
			LauncherLog.Instance.Info("HotFixView ShowSdkLogOutState", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (LauncherSdk.canUseSdk() && !Platform.Instance.IsCloudGame())
			{
				this.SetLoginInButtonActive(true);
			}
			this.SetExitButtonActive(false);
			this.SetLogOutButtonActive(false);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0003E604 File Offset: 0x0003C804
		private void ShowSdkLogInState()
		{
			LauncherLog.Instance.Info("HotFixView ShowSdkLogInState", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetLoginInButtonActive(false);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0003E630 File Offset: 0x0003C830
		public void SetUploadLogToggleActive(bool active)
		{
			HotFixPopupUiView hotFixPopupView = this.HotFixPopupView;
			if (hotFixPopupView == null)
			{
				return;
			}
			hotFixPopupView.SetUploadLogToggleActive(active);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0003E643 File Offset: 0x0003C843
		public bool GetUploadLogToggleOn()
		{
			HotFixPopupUiView hotFixPopupView = this.HotFixPopupView;
			return hotFixPopupView != null && hotFixPopupView.GetUploadLogToggleOn();
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0003E656 File Offset: 0x0003C856
		public void SetLogUploadProgressActive(bool value)
		{
			LauncherLogUploadView logUploadProgressView = this.LogUploadProgressView;
			if (logUploadProgressView == null)
			{
				return;
			}
			logUploadProgressView.SetActive(value);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0003E669 File Offset: 0x0003C869
		[NullableContext(2)]
		public LauncherLogUploadView GetLogUploadProgressView()
		{
			return this.LogUploadProgressView;
		}

		// Token: 0x040004BD RID: 1213
		[Nullable(2)]
		protected AActor UiRoot;

		// Token: 0x040004BE RID: 1214
		[Nullable(2)]
		protected UObject WorldContext;

		// Token: 0x040004BF RID: 1215
		[Nullable(2)]
		private HotFixListenDeviceSwitchText ProgressText;

		// Token: 0x040004C0 RID: 1216
		[Nullable(2)]
		private UUIText PatchText;

		// Token: 0x040004C1 RID: 1217
		[Nullable(2)]
		private UUIText SpeedText;

		// Token: 0x040004C2 RID: 1218
		[Nullable(2)]
		private UUITexture ProgressBar;

		// Token: 0x040004C3 RID: 1219
		[Nullable(2)]
		private UKuroTickManager TickManager;

		// Token: 0x040004C4 RID: 1220
		[Nullable(2)]
		private SdkProtocolView ProtocolView;

		// Token: 0x040004C5 RID: 1221
		[Nullable(2)]
		private HotFixPopupUiView HotFixPopupView;

		// Token: 0x040004C6 RID: 1222
		[Nullable(2)]
		private LauncherLogUploadView LogUploadProgressView;

		// Token: 0x040004C7 RID: 1223
		private const string LogoName = "WutheringWave_";

		// Token: 0x0200038D RID: 909
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0400126A RID: 4714
			public const int ContainerItem = 0;

			// Token: 0x0400126B RID: 4715
			public const int VersionText = 1;

			// Token: 0x0400126C RID: 4716
			public const int ProgressBarBg = 2;

			// Token: 0x0400126D RID: 4717
			public const int ProgressBar = 3;

			// Token: 0x0400126E RID: 4718
			public const int ProgressText = 4;

			// Token: 0x0400126F RID: 4719
			public const int BottomText = 5;

			// Token: 0x04001270 RID: 4720
			public const int Logo = 6;

			// Token: 0x04001271 RID: 4721
			public const int SpeedText = 7;

			// Token: 0x04001272 RID: 4722
			public const int PatchText = 8;

			// Token: 0x04001273 RID: 4723
			public const int ButtonRepair = 9;

			// Token: 0x04001274 RID: 4724
			public const int ButtonMask = 10;

			// Token: 0x04001275 RID: 4725
			public const int RepairText = 11;

			// Token: 0x04001276 RID: 4726
			public const int ButtonNotice = 12;

			// Token: 0x04001277 RID: 4727
			public const int NoticeText = 13;

			// Token: 0x04001278 RID: 4728
			public const int ButtonExit = 14;

			// Token: 0x04001279 RID: 4729
			public const int ExitText = 15;

			// Token: 0x0400127A RID: 4730
			public const int ButtonLogOut = 16;

			// Token: 0x0400127B RID: 4731
			public const int LogOutText = 17;

			// Token: 0x0400127C RID: 4732
			public const int ButtonLoginIn = 18;

			// Token: 0x0400127D RID: 4733
			public const int LoginInText = 19;

			// Token: 0x0400127E RID: 4734
			public const int PopUi = 100;

			// Token: 0x0400127F RID: 4735
			public const int ToolPop = 101;

			// Token: 0x04001280 RID: 4736
			public const int DownLoadPop = 102;

			// Token: 0x04001281 RID: 4737
			public const int FreeSpaceTipsPop = 103;

			// Token: 0x04001282 RID: 4738
			public const int ClearSubPackagePop = 104;

			// Token: 0x04001283 RID: 4739
			public const int ChangeTierPop = 105;

			// Token: 0x04001284 RID: 4740
			public const int LogUploadProgress = 106;
		}
	}
}

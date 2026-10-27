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
	// Token: 0x020000E9 RID: 233
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixUiView : LaunchComponentsAction
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0003BEFC File Offset: 0x0003A0FC
		public UniTask InitAsync(UObject worldContext)
		{
			HotFixUiView.<InitAsync>d__11 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.worldContext = worldContext;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<HotFixUiView.<InitAsync>d__11>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0003BF47 File Offset: 0x0003A147
		public void SetProtocolViewViewState(bool state)
		{
			SdkProtocolView protocolView = this.ProtocolView;
			if (protocolView == null)
			{
				return;
			}
			protocolView.SetActive(state);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0003BF5C File Offset: 0x0003A15C
		public UniTask ShowProtocolView(SdkProtocolViewData data)
		{
			HotFixUiView.<ShowProtocolView>d__13 <ShowProtocolView>d__;
			<ShowProtocolView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowProtocolView>d__.<>4__this = this;
			<ShowProtocolView>d__.data = data;
			<ShowProtocolView>d__.<>1__state = -1;
			<ShowProtocolView>d__.<>t__builder.Start<HotFixUiView.<ShowProtocolView>d__13>(ref <ShowProtocolView>d__);
			return <ShowProtocolView>d__.<>t__builder.Task;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
		protected UniTask LoadResourceAsync(UObject worldContext)
		{
			HotFixUiView.<LoadResourceAsync>d__14 <LoadResourceAsync>d__;
			<LoadResourceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadResourceAsync>d__.<>4__this = this;
			<LoadResourceAsync>d__.worldContext = worldContext;
			<LoadResourceAsync>d__.<>1__state = -1;
			<LoadResourceAsync>d__.<>t__builder.Start<HotFixUiView.<LoadResourceAsync>d__14>(ref <LoadResourceAsync>d__);
			return <LoadResourceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0003BFF3 File Offset: 0x0003A1F3
		private void SetChangeTierPopActive(bool value)
		{
			base.GetElement<HotFixChangeTierPopupView>(105).SetActive(value);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0003C004 File Offset: 0x0003A204
		private UniTask LoadHotFixLogo()
		{
			HotFixUiView.<LoadHotFixLogo>d__16 <LoadHotFixLogo>d__;
			<LoadHotFixLogo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadHotFixLogo>d__.<>4__this = this;
			<LoadHotFixLogo>d__.<>1__state = -1;
			<LoadHotFixLogo>d__.<>t__builder.Start<HotFixUiView.<LoadHotFixLogo>d__16>(ref <LoadHotFixLogo>d__);
			return <LoadHotFixLogo>d__.<>t__builder.Task;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0003C048 File Offset: 0x0003A248
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

		// Token: 0x0600079D RID: 1949 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
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

		// Token: 0x0600079E RID: 1950 RVA: 0x0003C159 File Offset: 0x0003A359
		private void OnUiRootLoadCallback(AActor actor)
		{
			this.UiRoot = actor;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0003C162 File Offset: 0x0003A362
		private void OnViewLoadCallback(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
			this.SetContainerItemActive(false);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0003C174 File Offset: 0x0003A374
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

		// Token: 0x060007A1 RID: 1953 RVA: 0x0003C28C File Offset: 0x0003A48C
		public void SetContainerItemActive(bool value)
		{
			UUIItem item = base.GetItem(0);
			if (value && value != item.IsUIActiveSelf())
			{
				this.SequencePlayer.PlaySequence("Start", null);
			}
			base.GetItem(0).SetUIActive(value);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0003C2CC File Offset: 0x0003A4CC
		public void UpdateProgressRate(float rate)
		{
			this.SetProgressActive(true);
			this.ProgressBar.SetFillAmount(rate);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0003C2E1 File Offset: 0x0003A4E1
		public void SetProgressActive(bool value)
		{
			base.GetTexture(2).SetUIActive(value);
			this.ProgressBar.SetUIActive(value);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		public void SetConfirmationItemActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetActive(value);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0003C30C File Offset: 0x0003A50C
		public void SetToolWindowActive(bool value)
		{
			base.GetElement<HotFixToolWindowView>(101).SetActive(value);
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetToolWindowActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0003C350 File Offset: 0x0003A550
		public void SetDownLoadActive(bool value)
		{
			base.GetElement<HotFixDownLoadView>(102).SetActive(value);
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetDownLoadActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0003C394 File Offset: 0x0003A594
		public void SetFreeSpaceTipsPopActive(bool value)
		{
			base.GetElement<HotFixDownLoadFreeSpaceTipsView>(103).SetActive(value);
			LauncherLog instance = LauncherLog.Instance;
			string message = "SetHotFixDownLoadFreeSpaceTipsViewActive";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
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

		// Token: 0x060007A9 RID: 1961 RVA: 0x0003C484 File Offset: 0x0003A684
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

		// Token: 0x060007AA RID: 1962 RVA: 0x0003C548 File Offset: 0x0003A748
		public void SetNoticeBtnActive(bool value)
		{
			base.GetText(13).SetUIActive(value);
			base.GetButton(12).SetSelfInteractive(value);
			base.GetButton(12).RootUIComp.Get().SetUIActive(value);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0003C58C File Offset: 0x0003A78C
		public void SetProgressLeftTips(string tableId, params string[] args)
		{
			this.ProgressText.SetLocalText(tableId, args);
			this.PatchText.SetText("", true);
			this.SpeedText.SetText("", true);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0003C5BD File Offset: 0x0003A7BD
		public void SetProgressLeftTipsEmpty()
		{
			this.ProgressText.SetEmptyText();
			this.PatchText.SetText("", true);
			this.SpeedText.SetText("", true);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0003C5EC File Offset: 0x0003A7EC
		public void SetProgressText(string tableId, params string[] args)
		{
			this.ProgressText.SetLocalText(tableId, args);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0003C5FB File Offset: 0x0003A7FB
		public void SetPatchText(string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(this.PatchText, tableId, args);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0003C60A File Offset: 0x0003A80A
		public void SetSpeedText(string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(this.SpeedText, tableId, args);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0003C619 File Offset: 0x0003A819
		public void SetProgressLeftActive(bool value)
		{
			this.ProgressText.SetUiActive(value);
			this.PatchText.SetUIActive(value);
			this.SpeedText.SetUIActive(value);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0003C63F File Offset: 0x0003A83F
		public void SetProgressRightTips(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(5), tableId, Array.Empty<string>());
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0003C653 File Offset: 0x0003A853
		public void SetProgressRightActive(bool value)
		{
			base.GetText(5).SetUIActive(value);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0003C662 File Offset: 0x0003A862
		public void SetConfirmationTitle(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationTitle(tableId);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0003C672 File Offset: 0x0003A872
		public void SetConfirmationContent(string tableId, params string[] args)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationContent(tableId, args);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0003C683 File Offset: 0x0003A883
		public void SetConfirmationLeftButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationLeftButtonCallBack(callback);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0003C693 File Offset: 0x0003A893
		public void SetConfirmationRightButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationRightButtonCallBack(callback);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003C6A3 File Offset: 0x0003A8A3
		[NullableContext(2)]
		public void SetConfirmationLeftButtonText(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationLeftButtonText(tableId);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0003C6B3 File Offset: 0x0003A8B3
		[NullableContext(2)]
		public void SetConfirmationRightButtonText(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationRightButtonText(tableId);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0003C6C3 File Offset: 0x0003A8C3
		public void SetConfirmationLeftButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationLeftButtonActive(value);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0003C6D3 File Offset: 0x0003A8D3
		public void SetConfirmationRightButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationRightButtonActive(value);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0003C6E3 File Offset: 0x0003A8E3
		public void SetConfirmationMiddleButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationMiddleButtonCallBack(callback);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0003C6F3 File Offset: 0x0003A8F3
		[NullableContext(2)]
		public void SetConfirmationMiddleButtonText(string tableId)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationMiddleButtonText(tableId);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0003C703 File Offset: 0x0003A903
		public void SetConfirmationMiddleButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationMiddleButtonActive(value);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0003C713 File Offset: 0x0003A913
		public void SetConfirmationCloseButtonCallBack(Action callback)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationCloseButtonCallBack(callback);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0003C723 File Offset: 0x0003A923
		public void SetConfirmationCloseButtonActive(bool value)
		{
			base.GetElement<HotFixPopupUiView>(100).SetConfirmationCloseButtonActive(value);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0003C733 File Offset: 0x0003A933
		public void SetMaskButtonCallBack(Action callback)
		{
			base.GetButton(10).OnClickCallBack.Unbind();
			base.GetButton(10).OnClickCallBack.Bind(callback);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0003C75A File Offset: 0x0003A95A
		public void SetRepairButtonText(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(11), tableId, Array.Empty<string>());
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0003C76F File Offset: 0x0003A96F
		public void SetRepairButtonEnable(bool bEnable)
		{
			base.GetButton(9).SetSelfInteractive(bEnable);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0003C780 File Offset: 0x0003A980
		public void SetLoginInButtonActive(bool bEnable)
		{
			base.GetButton(18).RootUIComp.Get().SetUIActive(bEnable);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003C7A8 File Offset: 0x0003A9A8
		public void SetExitButtonActive(bool bEnable)
		{
			base.GetButton(14).RootUIComp.Get().SetUIActive(bEnable);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003C7D0 File Offset: 0x0003A9D0
		public void SetLogOutButtonActive(bool bEnable)
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(bEnable);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0003C7F8 File Offset: 0x0003A9F8
		public void SetRepairButtonCallBack(Action callback)
		{
			base.GetButton(9).OnClickCallBack.Unbind();
			base.GetButton(9).OnClickCallBack.Bind(callback);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0003C820 File Offset: 0x0003AA20
		public bool GetLoginButtonActive()
		{
			return base.GetButton(18).RootUIComp.Get().IsUIActiveSelf();
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0003C847 File Offset: 0x0003AA47
		public void ShowAppInfoText(UObject worldContext)
		{
			base.GetText(1).SetText(UCSharpBlueprintFunctionLibrary.HasCSharpEnvironmentInitialized() ? (BaseConfigController.Instance.GetVersionString() + " *") : (BaseConfigController.Instance.GetVersionString() ?? ""), true);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0003C888 File Offset: 0x0003AA88
		public UniTask Hide()
		{
			HotFixUiView.<Hide>d__62 <Hide>d__;
			<Hide>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Hide>d__.<>4__this = this;
			<Hide>d__.<>1__state = -1;
			<Hide>d__.<>t__builder.Start<HotFixUiView.<Hide>d__62>(ref <Hide>d__);
			return <Hide>d__.<>t__builder.Task;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0003C8CC File Offset: 0x0003AACC
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

		// Token: 0x060007CB RID: 1995 RVA: 0x0003C91D File Offset: 0x0003AB1D
		public void RefreshLoginStateOnLoginSuccess()
		{
			this.ShowSdkLogInState();
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0003C925 File Offset: 0x0003AB25
		public void RefreshLoginStateBeforeLogin()
		{
			this.ShowSdkLogOutState();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0003C92D File Offset: 0x0003AB2D
		private void OnBtnNoticeClick()
		{
			HotFixManager.ShowNoticeWindowByUser();
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0003C934 File Offset: 0x0003AB34
		public void OnBtnLoginClick()
		{
			LauncherLog.Instance.Info("HotFixView OnBtnLoginClick", default(ReadOnlySpan<ValueTuple<string, object>>));
			HotFixManager.SdkLogin(new Action(this.RefreshLoginStateOnLoginSuccess), true);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0003C96C File Offset: 0x0003AB6C
		private void OnBtnExitClick()
		{
			LauncherLog.Instance.Info("HotFixView OnBtnExitClick", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKExit;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, "");
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0003C9A0 File Offset: 0x0003ABA0
		private void OnBtnLogOutClick()
		{
			LauncherLog.Instance.Warn("HotFixView OnBtnLogOutClick,不应该触发", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x0003CA18 File Offset: 0x0003AC18
		private void ShowSdkLogInState()
		{
			LauncherLog.Instance.Info("HotFixView ShowSdkLogInState", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetProgressActive(true);
			this.SetLoginInButtonActive(false);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0003CA4B File Offset: 0x0003AC4B
		public void SetUploadLogToggleActive(bool active)
		{
			HotFixPopupUiView hotFixPopupView = this.HotFixPopupView;
			if (hotFixPopupView == null)
			{
				return;
			}
			hotFixPopupView.SetUploadLogToggleActive(active);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0003CA5E File Offset: 0x0003AC5E
		public bool GetUploadLogToggleOn()
		{
			HotFixPopupUiView hotFixPopupView = this.HotFixPopupView;
			return hotFixPopupView != null && hotFixPopupView.GetUploadLogToggleOn();
		}

		// Token: 0x0400048E RID: 1166
		[Nullable(2)]
		protected AActor UiRoot;

		// Token: 0x0400048F RID: 1167
		[Nullable(2)]
		protected UObject WorldContext;

		// Token: 0x04000490 RID: 1168
		[Nullable(2)]
		private HotFixListenDeviceSwitchText ProgressText;

		// Token: 0x04000491 RID: 1169
		[Nullable(2)]
		private UUIText PatchText;

		// Token: 0x04000492 RID: 1170
		[Nullable(2)]
		private UUIText SpeedText;

		// Token: 0x04000493 RID: 1171
		[Nullable(2)]
		private UUITexture ProgressBar;

		// Token: 0x04000494 RID: 1172
		[Nullable(2)]
		private UKuroTickManager TickManager;

		// Token: 0x04000495 RID: 1173
		[Nullable(2)]
		private SdkProtocolView ProtocolView;

		// Token: 0x04000496 RID: 1174
		[Nullable(2)]
		private HotFixPopupUiView HotFixPopupView;

		// Token: 0x04000497 RID: 1175
		private const string LogoName = "WutheringWave_";

		// Token: 0x02000382 RID: 898
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04001205 RID: 4613
			public const int ContainerItem = 0;

			// Token: 0x04001206 RID: 4614
			public const int VersionText = 1;

			// Token: 0x04001207 RID: 4615
			public const int ProgressBarBg = 2;

			// Token: 0x04001208 RID: 4616
			public const int ProgressBar = 3;

			// Token: 0x04001209 RID: 4617
			public const int ProgressText = 4;

			// Token: 0x0400120A RID: 4618
			public const int BottomText = 5;

			// Token: 0x0400120B RID: 4619
			public const int Logo = 6;

			// Token: 0x0400120C RID: 4620
			public const int SpeedText = 7;

			// Token: 0x0400120D RID: 4621
			public const int PatchText = 8;

			// Token: 0x0400120E RID: 4622
			public const int ButtonRepair = 9;

			// Token: 0x0400120F RID: 4623
			public const int ButtonMask = 10;

			// Token: 0x04001210 RID: 4624
			public const int RepairText = 11;

			// Token: 0x04001211 RID: 4625
			public const int ButtonNotice = 12;

			// Token: 0x04001212 RID: 4626
			public const int NoticeText = 13;

			// Token: 0x04001213 RID: 4627
			public const int ButtonExit = 14;

			// Token: 0x04001214 RID: 4628
			public const int ExitText = 15;

			// Token: 0x04001215 RID: 4629
			public const int ButtonLogOut = 16;

			// Token: 0x04001216 RID: 4630
			public const int LogOutText = 17;

			// Token: 0x04001217 RID: 4631
			public const int ButtonLoginIn = 18;

			// Token: 0x04001218 RID: 4632
			public const int LoginInText = 19;

			// Token: 0x04001219 RID: 4633
			public const int PopUi = 100;

			// Token: 0x0400121A RID: 4634
			public const int ToolPop = 101;

			// Token: 0x0400121B RID: 4635
			public const int DownLoadPop = 102;

			// Token: 0x0400121C RID: 4636
			public const int FreeSpaceTipsPop = 103;

			// Token: 0x0400121D RID: 4637
			public const int ClearSubPackagePop = 104;

			// Token: 0x0400121E RID: 4638
			public const int ChangeTierPop = 105;
		}
	}
}

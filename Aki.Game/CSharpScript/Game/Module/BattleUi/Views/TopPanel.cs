using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.AlertArea;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.PhoneMessage.View;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.RecallQuest.Views;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB0 RID: 19632
	[NullableContext(2)]
	[Nullable(0)]
	public class TopPanel : BattleChildViewPanel
	{
		// Token: 0x060310B7 RID: 200887 RVA: 0x00DB1734 File Offset: 0x00DAF934
		protected unsafe override void OnRegisterComponent()
		{
			int num = 38;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(41, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(42, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(43, typeof(UUIItem)));
			}
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action<EToggleState>(this.OnClickIosVoiceToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060310B8 RID: 200888 RVA: 0x00DB1D00 File Offset: 0x00DAFF00
		public override UniTask InitializeAsync()
		{
			TopPanel.<InitializeAsync>d__48 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<TopPanel.<InitializeAsync>d__48>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060310B9 RID: 200889 RVA: 0x00DB1D43 File Offset: 0x00DAFF43
		public override void OnSeamlessTravelFinish()
		{
			this.MiniMapView.RefreshMiniMap();
			this.RefreshAllButtonVisible();
			RewardListView rewardListView = this.RewardListView;
			if (rewardListView == null)
			{
				return;
			}
			rewardListView.CollapseToDefault();
		}

		// Token: 0x060310BA RID: 200890 RVA: 0x00DB1D68 File Offset: 0x00DAFF68
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Default, TopPanel.BattleUiChildren, true, true, 0);
			this.MiniMapView.ShowBattleVisibleChildView(false);
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.ShowBattleVisibleChildView(false);
			}
			this.SilentAreaView.ShowBattleVisibleChildView(false);
			this.TowerGuideButton.ShowBattleVisibleChildView(false);
			this.ShipTowerBuffView.ShowBattleVisibleChildView(false);
			this.MoraleBuffView.ShowBattleVisibleChildView(false);
			this.MowingRiskView.ShowBattleVisibleChildView(false);
			this.BabelTowerBattleTopPanel.ShowBattleVisibleChildView(false);
			this.ResDownLoadItemTopPanel.ShowBattleVisibleChildView(false);
			this.AlertAreaInfoView.ShowBattleVisibleChildView(false);
			RewardListView rewardListView = this.RewardListView;
			if (rewardListView != null)
			{
				rewardListView.ShowBattleVisibleChildView(false);
			}
			this.WavePlateTip.ShowBattleVisibleChildView(false);
			this.FishingView.ShowBattleVisibleChildView(false);
			this.MoraleExpView.ShowBattleVisibleChildView(false);
			FlagChallengeExpView flagChallengeExpView = this.FlagChallengeExpView;
			if (flagChallengeExpView != null)
			{
				flagChallengeExpView.ShowBattleVisibleChildView(false);
			}
			BattleHonamiStoryMapLevelView honamiStoryMapLevelView = this.HonamiStoryMapLevelView;
			if (honamiStoryMapLevelView != null)
			{
				honamiStoryMapLevelView.ShowBattleVisibleChildView(false);
			}
			BattleHonamiStoryPlayerStateView honamiStoryPlayerStateView = this.HonamiStoryPlayerStateView;
			if (honamiStoryPlayerStateView != null)
			{
				honamiStoryPlayerStateView.ShowBattleVisibleChildView(false);
			}
			BossPilingTopItem bossPilingTopItem = this.BossPilingTopItem;
			if (bossPilingTopItem != null)
			{
				bossPilingTopItem.ShowBattleVisibleChildView(false);
			}
			RecallTopPanel recallTopPanel = this.RecallTopPanel;
			if (recallTopPanel != null)
			{
				recallTopPanel.ShowBattleVisibleChildView(false);
			}
			if (this.IsGamepad && !this.OnlineButton.GetActive())
			{
				this.OnlineButton.RefreshButtonState();
			}
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter == null)
			{
				return;
			}
			uiHookCenter.OnShow(this);
		}

		// Token: 0x060310BB RID: 200891 RVA: 0x00DB1F00 File Offset: 0x00DB0100
		protected override void OnHideBattleChildViewPanel()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Default, TopPanel.BattleUiChildren, false, true, 0);
			this.MiniMapView.HideBattleVisibleChildView();
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.HideBattleVisibleChildView();
			}
			this.SilentAreaView.HideBattleVisibleChildView();
			this.ShipTowerBuffView.HideBattleVisibleChildView();
			this.MoraleBuffView.HideBattleVisibleChildView();
			this.MowingRiskView.HideBattleVisibleChildView();
			this.BabelTowerBattleTopPanel.HideBattleVisibleChildView();
			this.ResDownLoadItemTopPanel.HideBattleVisibleChildView();
			this.WavePlateTip.HideBattleVisibleChildView();
			this.AlertAreaInfoView.HideBattleVisibleChildView();
			RewardListView rewardListView = this.RewardListView;
			if (rewardListView != null)
			{
				rewardListView.HideBattleVisibleChildView();
			}
			this.FishingView.HideBattleVisibleChildView();
			this.MoraleExpView.HideBattleVisibleChildView();
			FlagChallengeExpView flagChallengeExpView = this.FlagChallengeExpView;
			if (flagChallengeExpView != null)
			{
				flagChallengeExpView.HideBattleVisibleChildView();
			}
			BattleHonamiStoryMapLevelView honamiStoryMapLevelView = this.HonamiStoryMapLevelView;
			if (honamiStoryMapLevelView != null)
			{
				honamiStoryMapLevelView.HideBattleVisibleChildView();
			}
			BattleHonamiStoryPlayerStateView honamiStoryPlayerStateView = this.HonamiStoryPlayerStateView;
			if (honamiStoryPlayerStateView != null)
			{
				honamiStoryPlayerStateView.HideBattleVisibleChildView();
			}
			BossPilingTopItem bossPilingTopItem = this.BossPilingTopItem;
			if (bossPilingTopItem != null)
			{
				bossPilingTopItem.HideBattleVisibleChildView();
			}
			RecallTopPanel recallTopPanel = this.RecallTopPanel;
			if (recallTopPanel != null)
			{
				recallTopPanel.HideBattleVisibleChildView();
			}
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter == null)
			{
				return;
			}
			uiHookCenter.OnHide(this);
		}

		// Token: 0x060310BC RID: 200892 RVA: 0x00DB2058 File Offset: 0x00DB0258
		private void RefreshAllButtonVisible()
		{
			this.IsGamepad = Info.Instance.IsInGamepad();
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetGamepadHide(this.IsGamepad);
			}
			this.RefreshExitButtonVisibleState();
			this.RefreshActivityVisibleState();
			this.RefreshDirectTrainProState();
			this.RefreshTowerGuideVisibleState();
			this.RefreshShipTowerBuffVisibleState();
			this.RefreshMoraleBuffVisibleState();
			this.RefreshBabelTowerTopPanelState();
			this.RefreshShipTowerTopPanelState();
			this.RefreshRoleTowerTopPanelState();
			this.RefreshResDownLoadTopPanelState();
			this.RefreshMowingRiskVisibleState();
			this.RefreshBattleLinkVisibleState();
			this.DungeonChange();
			this.RefreshSilentAreaViewVisibleState();
			this.RefreshAreaAlertUiVisibleState(0, false);
			this.RefreshMoraleUiVisibleState();
			this.RefreshFlagChallengeUiVisibleState();
			this.RefreshActivityDungeonState();
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter != null)
			{
				uiHookCenter.OnRefresh(this);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "IOS 审核音乐Toggle";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BaseConfigController.GetIosAuditFirstDownloadTip()", BaseConfigController.Instance.GetIosAuditFirstDownloadTip());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (Info.Instance.PlatformType == ESourcePlatformType.IOS && BaseConfigController.Instance.GetIosAuditFirstDownloadTip())
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(18);
				if (extendToggle != null)
				{
					extendToggle.RootUIComp.Get().SetUIActive(true);
				}
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(18);
				if (extendToggle2 != null)
				{
					extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				Log.Instance.Info(ELogModule.BattleUiSet, ELogAuthor.YZY, "初始化IOS 背景播放按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (this.IsGamepad)
			{
				base.GetItem(41).SetUIActive(false);
				this.RefreshGamepad();
				return;
			}
			if (!Info.Instance.IsInTouch())
			{
				base.GetItem(41).SetUIActive(true);
			}
		}

		// Token: 0x060310BD RID: 200893 RVA: 0x00DB2220 File Offset: 0x00DB0420
		public override void Reset()
		{
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter != null)
			{
				uiHookCenter.OnReset(this);
			}
			this.MiniMapView.Reset();
			this.MiniMapView = null;
			this.ButtonList = null;
			base.Reset();
		}

		// Token: 0x060310BE RID: 200894 RVA: 0x00DB2254 File Offset: 0x00DB0454
		public override void OnTickBattleChildViewPanel(float delta)
		{
			this.MiniMapView.RefreshShow();
			AlertAreaInfoView alertAreaInfoView = this.AlertAreaInfoView;
			if (alertAreaInfoView != null)
			{
				alertAreaInfoView.Tick(delta);
			}
			MoraleExpView moraleExpView = this.MoraleExpView;
			if (moraleExpView != null)
			{
				moraleExpView.Tick(delta);
			}
			FlagChallengeExpView flagChallengeExpView = this.FlagChallengeExpView;
			if (flagChallengeExpView == null)
			{
				return;
			}
			flagChallengeExpView.Tick(delta);
		}

		// Token: 0x060310BF RID: 200895 RVA: 0x00DB22A4 File Offset: 0x00DB04A4
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
			EventSystem.Instance.Add(EEventName.DungeonGuideChange, new Action(this.DungeonChange));
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add(EEventName.GmOnlyShowMiniMap, new Action<bool>(this.OnGmOnlyShowMiniMap));
			EventSystem.Instance.Add<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeStartShowTrackText, new Action<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(this.OnBehaviorTreeStartShow));
			EventSystem.Instance.Add<long, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeEndShowTrackText, new Action<long, ETreeTextExpressReason, bool>(this.OnBehaviorTreeEndShow));
			EventSystem.Instance.Add(EEventName.OnShowTowerGuideButton, new Action(this.OnShowTowerGuideButton));
			EventSystem.Instance.Add(EEventName.MowingRiskInBattleViewSetActive, new Action<bool>(this.MowingRiskInBattleView));
			EventSystem.Instance.Add<int, bool>(EEventName.OnUpdateAreaAlertUiVisible, new Action<int, bool>(this.RefreshAreaAlertUiVisibleState));
			EventSystem.Instance.Add(EEventName.DriveFishingShipStateChanged, new Action<bool>(this.OnDriveFishingShipStateChanged));
			EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
			EventSystem.Instance.Add(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.ResDownLoadStateRefresh));
			EventSystem.Instance.Add(EEventName.OnMoraleActiveChanged, new Action<bool>(this.OnMoraleActiveChanged));
			EventSystem.Instance.Add(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.OnCharOnBuffAddShowMoraleBuffTips));
			EventSystem.Instance.Add(EEventName.OnActivityDirectTrainProSetActive, new Action<bool>(this.OnActivityDirectTrainProSetActive));
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter == null)
			{
				return;
			}
			uiHookCenter.OnAddEventListener(this);
		}

		// Token: 0x060310C0 RID: 200896 RVA: 0x00DB24BC File Offset: 0x00DB06BC
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
			EventSystem.Instance.Remove(EEventName.DungeonGuideChange, new Action(this.DungeonChange));
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove(EEventName.GmOnlyShowMiniMap, new Action<bool>(this.OnGmOnlyShowMiniMap));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeStartShowTrackText, new Action<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(this.OnBehaviorTreeStartShow));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeEndShowTrackText, new Action<long, ETreeTextExpressReason, bool>(this.OnBehaviorTreeEndShow));
			EventSystem.Instance.Remove(EEventName.OnShowTowerGuideButton, new Action(this.OnShowTowerGuideButton));
			EventSystem.Instance.Remove(EEventName.MowingRiskInBattleViewSetActive, new Action<bool>(this.MowingRiskInBattleView));
			EventSystem.Instance.Remove(EEventName.OnUpdateAreaAlertUiVisible, new <>f__AnonymousDelegate4<int, bool>(this.RefreshAreaAlertUiVisibleState));
			EventSystem.Instance.Remove(EEventName.DriveFishingShipStateChanged, new Action<bool>(this.OnDriveFishingShipStateChanged));
			EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
			EventSystem.Instance.Remove(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.ResDownLoadStateRefresh));
			EventSystem.Instance.Remove(EEventName.OnMoraleActiveChanged, new Action<bool>(this.OnMoraleActiveChanged));
			EventSystem.Instance.Remove(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.OnCharOnBuffAddShowMoraleBuffTips));
			EventSystem.Instance.Remove(EEventName.OnActivityDirectTrainProSetActive, new Action<bool>(this.OnActivityDirectTrainProSetActive));
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter == null)
			{
				return;
			}
			uiHookCenter.OnRemoveEventListener(this);
		}

		// Token: 0x060310C1 RID: 200897 RVA: 0x00DB26D4 File Offset: 0x00DB08D4
		[NullableContext(1)]
		private void OnBehaviorTreeStartShow(BehaviorTreeViewShowData showBridge, ETreeTextExpressReason eTreeTextExpressReason, bool arg3)
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(showBridge.Id), false);
			if (behaviorTree == null)
			{
				return;
			}
			if (behaviorTree.GetSilentAreaShowInfo() == null)
			{
				return;
			}
			this.SilentAreaView.StartShow(showBridge.Id, behaviorTree);
			RewardListView rewardListView = this.RewardListView;
			if (rewardListView == null)
			{
				return;
			}
			rewardListView.SetSilentAreaHide(true);
		}

		// Token: 0x060310C2 RID: 200898 RVA: 0x00DB2728 File Offset: 0x00DB0928
		private void OnBehaviorTreeEndShow(long treeIncId, ETreeTextExpressReason _1, bool _2)
		{
			SilentAreaView silentAreaView = this.SilentAreaView;
			if (silentAreaView == null || silentAreaView.Id != treeIncId)
			{
				return;
			}
			this.SilentAreaView.EndShow();
			RewardListView rewardListView = this.RewardListView;
			if (rewardListView == null)
			{
				return;
			}
			rewardListView.SetSilentAreaHide(false);
		}

		// Token: 0x060310C3 RID: 200899 RVA: 0x00DB2764 File Offset: 0x00DB0964
		private void RefreshSilentAreaViewVisibleState()
		{
			BaseBehaviorTree treeHandle = BattleUiModel.Instance.TreeHandle;
			long? treeIncIdHandle = BattleUiModel.Instance.TreeIncIdHandle;
			if (treeHandle == null || treeIncIdHandle == null)
			{
				this.SilentAreaView.EndShow();
				RewardListView rewardListView = this.RewardListView;
				if (rewardListView == null)
				{
					return;
				}
				rewardListView.SetSilentAreaHide(false);
				return;
			}
			else
			{
				this.SilentAreaView.StartShow(treeIncIdHandle.Value, treeHandle);
				RewardListView rewardListView2 = this.RewardListView;
				if (rewardListView2 == null)
				{
					return;
				}
				rewardListView2.SetSilentAreaHide(true);
				return;
			}
		}

		// Token: 0x060310C4 RID: 200900 RVA: 0x00DB27D4 File Offset: 0x00DB09D4
		private void OnShowTowerGuideButton()
		{
			BattleTowerButton towerGuideButton = this.TowerGuideButton;
			if (towerGuideButton != null)
			{
				towerGuideButton.SetOtherHide(false);
			}
			this.SilentAreaView.EndShow();
			RewardListView rewardListView = this.RewardListView;
			if (rewardListView == null)
			{
				return;
			}
			rewardListView.SetSilentAreaHide(false);
		}

		// Token: 0x060310C5 RID: 200901 RVA: 0x00DB2804 File Offset: 0x00DB0A04
		private void MowingRiskInBattleView(bool active)
		{
			MowingRiskInBattleView mowingRiskView = this.MowingRiskView;
			if (mowingRiskView != null)
			{
				mowingRiskView.CustomSetActive(active);
			}
			if (active)
			{
				IMowingRiskInBattleRootData data = MowingRiskModel.Instance.BuildInBattleRootData();
				MowingRiskInBattleView mowingRiskView2 = this.MowingRiskView;
				if (mowingRiskView2 == null)
				{
					return;
				}
				mowingRiskView2.RefreshByCustomData(data);
			}
		}

		// Token: 0x060310C6 RID: 200902 RVA: 0x00DB2844 File Offset: 0x00DB0A44
		private void OnGmOnlyShowMiniMap(bool bVisible)
		{
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetGmHide(!bVisible);
			}
			this.ExitButton.SetGmHide(!bVisible);
			this.ActivityButton.SetGmHide(!bVisible);
		}

		// Token: 0x060310C7 RID: 200903 RVA: 0x00DB28B8 File Offset: 0x00DB0AB8
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.IsGamepad = Info.Instance.IsInGamepad();
			if (this.MiniMapView != null)
			{
				this.MiniMapView.RefreshOnPlatformChanged();
			}
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetGamepadHide(this.IsGamepad);
			}
			this.OnlineButton.RefreshButtonState();
			if (this.IsGamepad)
			{
				base.GetItem(41).SetUIActive(false);
				this.RefreshGamepad();
				return;
			}
			if (!Info.Instance.IsInTouch())
			{
				base.GetItem(41).SetUIActive(true);
			}
		}

		// Token: 0x060310C8 RID: 200904 RVA: 0x00DB2974 File Offset: 0x00DB0B74
		private void RefreshGamepad()
		{
			this.EnsureGamepadPanelCreatedAsync().ContinueWith(delegate()
			{
				if (base.IsDestroyOrDestroying)
				{
					return;
				}
				GamepadTopPanel gamepadTopPanel = this.GamepadTopPanel;
				if (gamepadTopPanel != null)
				{
					gamepadTopPanel.ShowBattleVisibleChildView(false);
				}
				TopPanelWavePlateTip wavePlateTipGamePad = this.WavePlateTipGamePad;
				if (wavePlateTipGamePad == null)
				{
					return;
				}
				wavePlateTipGamePad.ShowBattleVisibleChildView(false);
			}).Forget();
		}

		// Token: 0x060310C9 RID: 200905 RVA: 0x00DB2994 File Offset: 0x00DB0B94
		private UniTask CreateGamepadPanel()
		{
			TopPanel.<CreateGamepadPanel>d__65 <CreateGamepadPanel>d__;
			<CreateGamepadPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanel>d__.<>4__this = this;
			<CreateGamepadPanel>d__.<>1__state = -1;
			<CreateGamepadPanel>d__.<>t__builder.Start<TopPanel.<CreateGamepadPanel>d__65>(ref <CreateGamepadPanel>d__);
			return <CreateGamepadPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060310CA RID: 200906 RVA: 0x00DB29D8 File Offset: 0x00DB0BD8
		private UniTask CreateGamepadPanelInner()
		{
			TopPanel.<CreateGamepadPanelInner>d__66 <CreateGamepadPanelInner>d__;
			<CreateGamepadPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanelInner>d__.<>4__this = this;
			<CreateGamepadPanelInner>d__.<>1__state = -1;
			<CreateGamepadPanelInner>d__.<>t__builder.Start<TopPanel.<CreateGamepadPanelInner>d__66>(ref <CreateGamepadPanelInner>d__);
			return <CreateGamepadPanelInner>d__.<>t__builder.Task;
		}

		// Token: 0x060310CB RID: 200907 RVA: 0x00DB2A1C File Offset: 0x00DB0C1C
		private UniTask EnsureGamepadPanelCreatedAsync()
		{
			TopPanel.<EnsureGamepadPanelCreatedAsync>d__67 <EnsureGamepadPanelCreatedAsync>d__;
			<EnsureGamepadPanelCreatedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureGamepadPanelCreatedAsync>d__.<>4__this = this;
			<EnsureGamepadPanelCreatedAsync>d__.<>1__state = -1;
			<EnsureGamepadPanelCreatedAsync>d__.<>t__builder.Start<TopPanel.<EnsureGamepadPanelCreatedAsync>d__67>(ref <EnsureGamepadPanelCreatedAsync>d__);
			return <EnsureGamepadPanelCreatedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060310CC RID: 200908 RVA: 0x00DB2A60 File Offset: 0x00DB0C60
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UUIItem> GetEntitySequenceButtonRootAsync()
		{
			TopPanel.<GetEntitySequenceButtonRootAsync>d__68 <GetEntitySequenceButtonRootAsync>d__;
			<GetEntitySequenceButtonRootAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUIItem>.Create();
			<GetEntitySequenceButtonRootAsync>d__.<>4__this = this;
			<GetEntitySequenceButtonRootAsync>d__.<>1__state = -1;
			<GetEntitySequenceButtonRootAsync>d__.<>t__builder.Start<TopPanel.<GetEntitySequenceButtonRootAsync>d__68>(ref <GetEntitySequenceButtonRootAsync>d__);
			return <GetEntitySequenceButtonRootAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060310CD RID: 200909 RVA: 0x00DB2AA3 File Offset: 0x00DB0CA3
		private void OnActivityUpdate()
		{
			this.RefreshActivityVisibleState();
			this.RefreshActivityDungeonState();
		}

		// Token: 0x060310CE RID: 200910 RVA: 0x00DB2AB1 File Offset: 0x00DB0CB1
		private bool CheckIsInRogue()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue() || MapRogueController.Instance.CheckInMapRogueInstance();
		}

		// Token: 0x060310CF RID: 200911 RVA: 0x00DB2AD8 File Offset: 0x00DB0CD8
		private bool CheckIsBossPiling()
		{
			InstanceDungeon? instanceDungeon;
			return ((GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().InstSubType : -1) == 55;
		}

		// Token: 0x060310D0 RID: 200912 RVA: 0x00DB2B10 File Offset: 0x00DB0D10
		private void DungeonChange()
		{
			bool haveGuide = InstanceDungeonGuideModel.Instance.GetHaveGuide();
			if (haveGuide)
			{
				this.QuestButton.SetOtherHide(true);
				this.DungeonGuideButton.SetOtherHide(false);
			}
			else
			{
				this.QuestButton.SetOtherHide(false);
				this.DungeonGuideButton.SetOtherHide(true);
			}
			bool flag = this.CheckIsInRogue();
			if (flag)
			{
				this.QuestButton.SetOtherHide(true);
				this.DungeonGuideButton.SetOtherHide(true);
			}
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				this.QuestButton.SetOtherHide(true);
			}
			if (ShipTowerModel.Instance.CheckInBattleShipTower())
			{
				this.QuestButton.SetOtherHide(true);
			}
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				this.QuestButton.SetOtherHide(true);
			}
			if (this.CheckIsBossPiling())
			{
				this.QuestButton.SetOtherHide(true);
				this.DungeonGuideButton.SetOtherHide(true);
			}
			BattleUiModel.Instance.EnvironmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.DungeonGuide, haveGuide && !flag);
		}

		// Token: 0x060310D1 RID: 200913 RVA: 0x00DB2C01 File Offset: 0x00DB0E01
		private void OnChangeRole(int i, int i1)
		{
			this.OnlineButton.RefreshButtonState();
		}

		// Token: 0x060310D2 RID: 200914 RVA: 0x00DB2C10 File Offset: 0x00DB0E10
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetFunctionOpen(functionType, isOpen);
			}
		}

		// Token: 0x060310D3 RID: 200915 RVA: 0x00DB2C64 File Offset: 0x00DB0E64
		private void RefreshExitButtonVisibleState()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				this.ExitButton.SetOtherHide(true);
				return;
			}
			this.ExitButton.SetOtherHide(false);
		}

		// Token: 0x060310D4 RID: 200916 RVA: 0x00DB2C8C File Offset: 0x00DB0E8C
		private void RefreshActivityVisibleState()
		{
			if (this.CheckIsInRogue())
			{
				this.ActivityButton.SetOtherHide(true);
				return;
			}
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				this.ActivityButton.SetOtherHide(true);
				return;
			}
			this.ActivityButton.SetOtherHide(this.GetActivityOtherHide());
		}

		// Token: 0x060310D5 RID: 200917 RVA: 0x00DB2CD8 File Offset: 0x00DB0ED8
		private void RefreshDirectTrainProState()
		{
			BattleEntranceButton directTrainProButton = this.DirectTrainProButton;
			if (directTrainProButton == null)
			{
				return;
			}
			directTrainProButton.SetOtherHide(!ActivityDirectTrainHelper.IsProOpen || !ActivityDirectTrainHelper.IsInValidInstance);
		}

		// Token: 0x060310D6 RID: 200918 RVA: 0x00DB2CFC File Offset: 0x00DB0EFC
		private void RefreshTowerGuideVisibleState()
		{
			this.TowerGuideButton.SetOtherHide(!TowerModel.Instance.CheckInTower());
		}

		// Token: 0x060310D7 RID: 200919 RVA: 0x00DB2D18 File Offset: 0x00DB0F18
		private void RefreshShipTowerBuffVisibleState()
		{
			bool flag = ShipTowerModel.Instance.CheckInBattleShipTower();
			bool flag2 = ShipTowerModel.Instance.CheckIsScoreBattle();
			if (flag && !flag2)
			{
				ShipTowerBuffBattleView shipTowerBuffView = this.ShipTowerBuffView;
				if (shipTowerBuffView == null)
				{
					return;
				}
				shipTowerBuffView.StartShow();
				return;
			}
			else
			{
				ShipTowerBuffBattleView shipTowerBuffView2 = this.ShipTowerBuffView;
				if (shipTowerBuffView2 == null)
				{
					return;
				}
				shipTowerBuffView2.EndShow();
				return;
			}
		}

		// Token: 0x060310D8 RID: 200920 RVA: 0x00DB2D60 File Offset: 0x00DB0F60
		private void RefreshMoraleBuffVisibleState()
		{
			if (MoraleModel.Instance.GetBattleIsShowBuff())
			{
				MoraleBuffBattleView moraleBuffView = this.MoraleBuffView;
				if (moraleBuffView == null)
				{
					return;
				}
				moraleBuffView.StartShow();
				return;
			}
			else
			{
				MoraleBuffBattleView moraleBuffView2 = this.MoraleBuffView;
				if (moraleBuffView2 == null)
				{
					return;
				}
				moraleBuffView2.EndShow();
				return;
			}
		}

		// Token: 0x060310D9 RID: 200921 RVA: 0x00DB2D8F File Offset: 0x00DB0F8F
		private void RefreshBabelTowerTopPanelState()
		{
			if (BabelTowerModel.Instance.CheckInBattleBabelTower())
			{
				BabelTowerBattleTopPanel babelTowerBattleTopPanel = this.BabelTowerBattleTopPanel;
				if (babelTowerBattleTopPanel == null)
				{
					return;
				}
				babelTowerBattleTopPanel.StartShow();
				return;
			}
			else
			{
				BabelTowerBattleTopPanel babelTowerBattleTopPanel2 = this.BabelTowerBattleTopPanel;
				if (babelTowerBattleTopPanel2 == null)
				{
					return;
				}
				babelTowerBattleTopPanel2.EndShow();
				return;
			}
		}

		// Token: 0x060310DA RID: 200922 RVA: 0x00DB2DC0 File Offset: 0x00DB0FC0
		private void RefreshShipTowerTopPanelState()
		{
			bool flag = ShipTowerModel.Instance.CheckInBattleShipTower();
			bool flag2 = ShipTowerModel.Instance.CheckIsScoreBattle();
			bool shipTowerVisible = !flag || !flag2;
			this.MiniMapView.SetShipTowerVisible(shipTowerVisible);
		}

		// Token: 0x060310DB RID: 200923 RVA: 0x00DB2DF8 File Offset: 0x00DB0FF8
		private void RefreshRoleTowerTopPanelState()
		{
			bool flag = RoleTowerModel.Instance.IsInRoleTowerDungeon();
			this.MiniMapView.SetRoleTowerVisible(!flag);
			UUIItem item = base.GetItem(36);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			GamepadTopPanel gamepadTopPanel = this.GamepadTopPanel;
			if (gamepadTopPanel != null)
			{
				gamepadTopPanel.RefreshRoleTowerVisible();
			}
			if (flag)
			{
				this.ButtonList.ForEach(delegate(BattleEntranceButton button)
				{
					button.SetOtherHide(true);
				});
			}
		}

		// Token: 0x060310DC RID: 200924 RVA: 0x00DB2E74 File Offset: 0x00DB1074
		private void RefreshResDownLoadTopPanelState()
		{
			if (SubPackageDownLoadModel.Instance.NeedShowBattleViewButton())
			{
				ResDownLoadTopPanel resDownLoadItemTopPanel = this.ResDownLoadItemTopPanel;
				if (resDownLoadItemTopPanel == null)
				{
					return;
				}
				resDownLoadItemTopPanel.StartShow();
				return;
			}
			else
			{
				ResDownLoadTopPanel resDownLoadItemTopPanel2 = this.ResDownLoadItemTopPanel;
				if (resDownLoadItemTopPanel2 == null)
				{
					return;
				}
				resDownLoadItemTopPanel2.EndShow();
				return;
			}
		}

		// Token: 0x060310DD RID: 200925 RVA: 0x00DB2EA4 File Offset: 0x00DB10A4
		private void RefreshMowingRiskVisibleState()
		{
			bool active = ActivityMowingRiskController.Instance.CheckInInstanceDungeon();
			this.MowingRiskInBattleView(active);
		}

		// Token: 0x060310DE RID: 200926 RVA: 0x00DB2EC4 File Offset: 0x00DB10C4
		private void RefreshBattleLinkVisibleState()
		{
			bool flag = BattleLinkModel.Instance.CheckInDreamLink();
			if (flag)
			{
				this.ButtonList.ForEach(delegate(BattleEntranceButton button)
				{
					button.SetOtherHide(true);
				});
				this.ExitButton.SetOtherHide(false);
			}
			this.MiniMapView.SetBattleLinkVisible(!flag);
		}

		// Token: 0x060310DF RID: 200927 RVA: 0x00DB2F24 File Offset: 0x00DB1124
		private void RefreshActivityDungeonState()
		{
			bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
			bool isInFlagChallengeDungeon = FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
			if (flag)
			{
				this.RefreshHonamiStoryButtonVisibleState();
			}
			else if (isInFlagChallengeDungeon)
			{
				this.RefreshFlagChallengeButtonVisibleState();
			}
			else if (this.CheckIsBossPiling())
			{
				this.RefreshBossPilingTopState();
			}
			else if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				this.RefreshRecallQuestButtonVisibleState();
			}
			else
			{
				this.RefreshRogueInfoButtonVisibleState();
			}
			BattleTopPanelHookCenter uiHookCenter = this.UiHookCenter;
			if (uiHookCenter == null)
			{
				return;
			}
			uiHookCenter.OnRefresh(this);
		}

		// Token: 0x060310E0 RID: 200928 RVA: 0x00DB2F94 File Offset: 0x00DB1194
		private void RefreshHonamiStoryButtonVisibleState()
		{
			this.ButtonList.ForEach(delegate(BattleEntranceButton button)
			{
				button.SetOtherHide(true);
			});
			CommonTopButtonPanel honamiStoryBagButton = this.HonamiStoryBagButton;
			if (honamiStoryBagButton != null)
			{
				honamiStoryBagButton.SetOtherHide(false);
			}
			this.SettingButton.SetOtherHide(false);
			this.QuestButton.SetOtherHide(false);
			if (HonamiStoryUtil.CheckInHonamiStoryMainDungeon())
			{
				this.ExitButton.SetOtherHide(false);
				return;
			}
			BattleHonamiStoryLeaveButton honamiStoryLeaveButton = this.HonamiStoryLeaveButton;
			if (honamiStoryLeaveButton != null)
			{
				honamiStoryLeaveButton.SetOtherHide(false);
			}
			ResDownLoadTopPanel resDownLoadItemTopPanel = this.ResDownLoadItemTopPanel;
			if (resDownLoadItemTopPanel != null)
			{
				resDownLoadItemTopPanel.EndShow();
			}
			ResDownLoadTopPanel resDownLoadItemTopPanel2 = this.ResDownLoadItemTopPanel;
			if (resDownLoadItemTopPanel2 == null)
			{
				return;
			}
			resDownLoadItemTopPanel2.SetOtherHide(true);
		}

		// Token: 0x060310E1 RID: 200929 RVA: 0x00DB3040 File Offset: 0x00DB1240
		private void RefreshFlagChallengeButtonVisibleState()
		{
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetOtherHide(true);
			}
			this.QuestButton.SetOtherHide(true);
			CommonTopButtonPanel flagChallengeLevelButton = this.FlagChallengeLevelButton;
			if (flagChallengeLevelButton != null)
			{
				flagChallengeLevelButton.SetOtherHide(false);
			}
			CommonTopButtonPanel flagChallengeBuffButton = this.FlagChallengeBuffButton;
			if (flagChallengeBuffButton != null)
			{
				flagChallengeBuffButton.SetOtherHide(false);
			}
			CommonTopButtonPanel flagChallengePauseButton = this.FlagChallengePauseButton;
			if (flagChallengePauseButton == null)
			{
				return;
			}
			flagChallengePauseButton.SetOtherHide(false);
		}

		// Token: 0x060310E2 RID: 200930 RVA: 0x00DB30D4 File Offset: 0x00DB12D4
		private void RefreshRogueInfoButtonVisibleState()
		{
			bool flag = this.CheckIsInRogue();
			bool flag2 = flag || BabelTowerModel.Instance.CheckInBattleBabelTower();
			if (flag2)
			{
				this.ButtonList.ForEach(delegate(BattleEntranceButton button)
				{
					button.SetOtherHide(true);
				});
				this.ExitButton.SetOtherHide(false);
			}
			this.MiniMapView.SetRoguelikeVisible(!flag2);
			this.RogueInfoButton.SetOtherHide(!flag);
			this.SettingButton.SetOtherHide(!flag);
		}

		// Token: 0x060310E3 RID: 200931 RVA: 0x00DB3160 File Offset: 0x00DB1360
		private void RefreshRecallQuestButtonVisibleState()
		{
			this.ButtonList.ForEach(delegate(BattleEntranceButton button)
			{
				button.SetOtherHide(true);
			});
			BattleEntranceButton exitButton = this.ExitButton;
			if (exitButton != null)
			{
				exitButton.SetOtherHide(false);
			}
			BattleEntranceButton homeButton = this.HomeButton;
			if (homeButton != null)
			{
				homeButton.SetOtherHide(false);
			}
			BattleFormationButton fightTeamButton = this.FightTeamButton;
			if (fightTeamButton != null)
			{
				fightTeamButton.SetOtherHide(false);
			}
			BattleQuestButton questButton = this.QuestButton;
			if (questButton != null)
			{
				questButton.SetOtherHide(false);
			}
			BattleEntranceButton inventoryButton = this.InventoryButton;
			if (inventoryButton != null)
			{
				inventoryButton.SetOtherHide(false);
			}
			RecallTopPanel recallTopPanel = this.RecallTopPanel;
			if (recallTopPanel != null)
			{
				recallTopPanel.SetVisible(0, true);
			}
			RecallTopPanel recallTopPanel2 = this.RecallTopPanel;
			if (recallTopPanel2 == null)
			{
				return;
			}
			recallTopPanel2.ShowBattleVisibleChildView(true);
		}

		// Token: 0x060310E4 RID: 200932 RVA: 0x00DB3218 File Offset: 0x00DB1418
		private void RefreshAreaAlertUiVisibleState(int _1 = 0, bool _2 = false)
		{
			int? alertUiVisibleAreaId = AlertAreaModel.Instance.GetAlertUiVisibleAreaId();
			if (alertUiVisibleAreaId == null)
			{
				AlertAreaInfoView alertAreaInfoView = this.AlertAreaInfoView;
				if (alertAreaInfoView == null)
				{
					return;
				}
				alertAreaInfoView.EndShow(null);
				return;
			}
			else
			{
				AlertAreaInfoView alertAreaInfoView2 = this.AlertAreaInfoView;
				if (alertAreaInfoView2 == null)
				{
					return;
				}
				alertAreaInfoView2.StartShow(alertUiVisibleAreaId.Value);
				return;
			}
		}

		// Token: 0x060310E5 RID: 200933 RVA: 0x00DB326A File Offset: 0x00DB146A
		private void RefreshMoraleUiVisibleState()
		{
			if (MoraleBattleModel.Instance.IsMoraleActive())
			{
				MoraleExpView moraleExpView = this.MoraleExpView;
				if (moraleExpView == null)
				{
					return;
				}
				moraleExpView.StartShow();
				return;
			}
			else
			{
				MoraleExpView moraleExpView2 = this.MoraleExpView;
				if (moraleExpView2 == null)
				{
					return;
				}
				moraleExpView2.EndShow();
				return;
			}
		}

		// Token: 0x060310E6 RID: 200934 RVA: 0x00DB3299 File Offset: 0x00DB1499
		private void OnMoraleActiveChanged(bool active)
		{
			this.RefreshMoraleUiVisibleState();
			this.RefreshMoraleBuffVisibleState();
			BattleEntranceButton moraleBuffSumButton = this.MoraleBuffSumButton;
			if (moraleBuffSumButton != null)
			{
				moraleBuffSumButton.SetOtherHide(!active);
			}
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.MoraleAreaSum, active);
		}

		// Token: 0x060310E7 RID: 200935 RVA: 0x00DB32D4 File Offset: 0x00DB14D4
		private void OnCharOnBuffAddShowMoraleBuffTips(int entityId, GameplayCue cue, bool isAdd, int handleId)
		{
			if (cue.Parameters(0) == "1")
			{
				int num = int.Parse(cue.Parameters(1));
				if (MoraleModel.Instance.GamePlayFinishTeamBuffId == num)
				{
					this.RefreshMoraleBuffVisibleState();
				}
			}
		}

		// Token: 0x060310E8 RID: 200936 RVA: 0x00DB3318 File Offset: 0x00DB1518
		private UniTask NewHomeButton()
		{
			TopPanel.<NewHomeButton>d__96 <NewHomeButton>d__;
			<NewHomeButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHomeButton>d__.<>4__this = this;
			<NewHomeButton>d__.<>1__state = -1;
			<NewHomeButton>d__.<>t__builder.Start<TopPanel.<NewHomeButton>d__96>(ref <NewHomeButton>d__);
			return <NewHomeButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310E9 RID: 200937 RVA: 0x00DB335B File Offset: 0x00DB155B
		private void OnClickedHomeButton()
		{
			if (!RecallQuestModel.Instance.IsInRecallInstance())
			{
				UiManager.Instance.OpenView(EUiViewName.FunctionView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RecallFunctionView, null, null);
		}

		// Token: 0x060310EA RID: 200938 RVA: 0x00DB338C File Offset: 0x00DB158C
		private UniTask NewGachaButton()
		{
			TopPanel.<NewGachaButton>d__98 <NewGachaButton>d__;
			<NewGachaButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewGachaButton>d__.<>4__this = this;
			<NewGachaButton>d__.<>1__state = -1;
			<NewGachaButton>d__.<>t__builder.Start<TopPanel.<NewGachaButton>d__98>(ref <NewGachaButton>d__);
			return <NewGachaButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310EB RID: 200939 RVA: 0x00DB33CF File Offset: 0x00DB15CF
		private void OnClickedGachaButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Gacha);
		}

		// Token: 0x060310EC RID: 200940 RVA: 0x00DB33E0 File Offset: 0x00DB15E0
		private UniTask NewExitButton()
		{
			TopPanel.<NewExitButton>d__100 <NewExitButton>d__;
			<NewExitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExitButton>d__.<>4__this = this;
			<NewExitButton>d__.<>1__state = -1;
			<NewExitButton>d__.<>t__builder.Start<TopPanel.<NewExitButton>d__100>(ref <NewExitButton>d__);
			return <NewExitButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310ED RID: 200941 RVA: 0x00DB3424 File Offset: 0x00DB1624
		private UniTask NewActivityButton()
		{
			TopPanel.<NewActivityButton>d__101 <NewActivityButton>d__;
			<NewActivityButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewActivityButton>d__.<>4__this = this;
			<NewActivityButton>d__.<>1__state = -1;
			<NewActivityButton>d__.<>t__builder.Start<TopPanel.<NewActivityButton>d__101>(ref <NewActivityButton>d__);
			return <NewActivityButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310EE RID: 200942 RVA: 0x00DB3467 File Offset: 0x00DB1667
		private bool GetActivityOtherHide()
		{
			return RoleTowerModel.Instance.IsInRoleTowerDungeon() || !ActivityModel.Instance.GetIfShowActivity();
		}

		// Token: 0x060310EF RID: 200943 RVA: 0x00DB3484 File Offset: 0x00DB1684
		private void OnClickedExitButton()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
		}

		// Token: 0x060310F0 RID: 200944 RVA: 0x00DB3494 File Offset: 0x00DB1694
		private UniTask NewOnlineButton()
		{
			TopPanel.<NewOnlineButton>d__104 <NewOnlineButton>d__;
			<NewOnlineButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewOnlineButton>d__.<>4__this = this;
			<NewOnlineButton>d__.<>1__state = -1;
			<NewOnlineButton>d__.<>t__builder.Start<TopPanel.<NewOnlineButton>d__104>(ref <NewOnlineButton>d__);
			return <NewOnlineButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310F1 RID: 200945 RVA: 0x00DB34D8 File Offset: 0x00DB16D8
		private static void OnClickedOnlineButton()
		{
			int isMulti = GameModeModel.Instance.IsMulti ? 1 : 0;
			bool flag = OnlineModel.Instance.IsOnlineDisabled();
			if (isMulti == 0 && flag)
			{
				OnlineController.Instance.ShowTipsWhenOnlineDisabled(null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.OnlineWorldHallView, null, null);
		}

		// Token: 0x060310F2 RID: 200946 RVA: 0x00DB3520 File Offset: 0x00DB1720
		private UniTask NewInventoryButton()
		{
			TopPanel.<NewInventoryButton>d__106 <NewInventoryButton>d__;
			<NewInventoryButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewInventoryButton>d__.<>4__this = this;
			<NewInventoryButton>d__.<>1__state = -1;
			<NewInventoryButton>d__.<>t__builder.Start<TopPanel.<NewInventoryButton>d__106>(ref <NewInventoryButton>d__);
			return <NewInventoryButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310F3 RID: 200947 RVA: 0x00DB3563 File Offset: 0x00DB1763
		private void OnClickedInventoryButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Bag);
		}

		// Token: 0x060310F4 RID: 200948 RVA: 0x00DB3574 File Offset: 0x00DB1774
		private UniTask NewPhoneMagButton()
		{
			TopPanel.<NewPhoneMagButton>d__108 <NewPhoneMagButton>d__;
			<NewPhoneMagButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewPhoneMagButton>d__.<>4__this = this;
			<NewPhoneMagButton>d__.<>1__state = -1;
			<NewPhoneMagButton>d__.<>t__builder.Start<TopPanel.<NewPhoneMagButton>d__108>(ref <NewPhoneMagButton>d__);
			return <NewPhoneMagButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310F5 RID: 200949 RVA: 0x00DB35B7 File Offset: 0x00DB17B7
		private static void OnClickedPhoneMsgButton()
		{
			PhoneMsgController.Instance.OpenAndJumpShowTipShortMessage(EPhoneMsgOpenWay.HUD, EPhoneMsgViewType.Big);
		}

		// Token: 0x060310F6 RID: 200950 RVA: 0x00DB35C8 File Offset: 0x00DB17C8
		private UniTask NewShopButton()
		{
			TopPanel.<NewShopButton>d__110 <NewShopButton>d__;
			<NewShopButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewShopButton>d__.<>4__this = this;
			<NewShopButton>d__.<>1__state = -1;
			<NewShopButton>d__.<>t__builder.Start<TopPanel.<NewShopButton>d__110>(ref <NewShopButton>d__);
			return <NewShopButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310F7 RID: 200951 RVA: 0x00DB360B File Offset: 0x00DB180B
		private void OnClickedShopButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Shop);
		}

		// Token: 0x060310F8 RID: 200952 RVA: 0x00DB361C File Offset: 0x00DB181C
		private UniTask NewPassCheckButton()
		{
			TopPanel.<NewPassCheckButton>d__112 <NewPassCheckButton>d__;
			<NewPassCheckButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewPassCheckButton>d__.<>4__this = this;
			<NewPassCheckButton>d__.<>1__state = -1;
			<NewPassCheckButton>d__.<>t__builder.Start<TopPanel.<NewPassCheckButton>d__112>(ref <NewPassCheckButton>d__);
			return <NewPassCheckButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310F9 RID: 200953 RVA: 0x00DB365F File Offset: 0x00DB185F
		private void OnClickedPassCheckButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.BattlePass);
		}

		// Token: 0x060310FA RID: 200954 RVA: 0x00DB3670 File Offset: 0x00DB1870
		private void OnClickedActivityButton()
		{
			ActivityController.Instance.OpenActivityById(0, EActivityViewOpenType.BattleView, null, null);
		}

		// Token: 0x060310FB RID: 200955 RVA: 0x00DB3684 File Offset: 0x00DB1884
		private UniTask NewResonanceButton()
		{
			TopPanel.<NewResonanceButton>d__115 <NewResonanceButton>d__;
			<NewResonanceButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewResonanceButton>d__.<>4__this = this;
			<NewResonanceButton>d__.<>1__state = -1;
			<NewResonanceButton>d__.<>t__builder.Start<TopPanel.<NewResonanceButton>d__115>(ref <NewResonanceButton>d__);
			return <NewResonanceButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310FC RID: 200956 RVA: 0x00DB36C7 File Offset: 0x00DB18C7
		private void OnClickedRoleButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Role);
		}

		// Token: 0x060310FD RID: 200957 RVA: 0x00DB36D8 File Offset: 0x00DB18D8
		private UniTask NewHelpButton()
		{
			TopPanel.<NewHelpButton>d__117 <NewHelpButton>d__;
			<NewHelpButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHelpButton>d__.<>4__this = this;
			<NewHelpButton>d__.<>1__state = -1;
			<NewHelpButton>d__.<>t__builder.Start<TopPanel.<NewHelpButton>d__117>(ref <NewHelpButton>d__);
			return <NewHelpButton>d__.<>t__builder.Task;
		}

		// Token: 0x060310FE RID: 200958 RVA: 0x00DB371B File Offset: 0x00DB191B
		private void OnClickedHelpButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.AdventureGuide);
		}

		// Token: 0x060310FF RID: 200959 RVA: 0x00DB372C File Offset: 0x00DB192C
		private UniTask NewMiniMapView()
		{
			TopPanel.<NewMiniMapView>d__119 <NewMiniMapView>d__;
			<NewMiniMapView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMiniMapView>d__.<>4__this = this;
			<NewMiniMapView>d__.<>1__state = -1;
			<NewMiniMapView>d__.<>t__builder.Start<TopPanel.<NewMiniMapView>d__119>(ref <NewMiniMapView>d__);
			return <NewMiniMapView>d__.<>t__builder.Task;
		}

		// Token: 0x06031100 RID: 200960 RVA: 0x00DB3770 File Offset: 0x00DB1970
		private UniTask NewSilentAreaInfo()
		{
			TopPanel.<NewSilentAreaInfo>d__120 <NewSilentAreaInfo>d__;
			<NewSilentAreaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSilentAreaInfo>d__.<>4__this = this;
			<NewSilentAreaInfo>d__.<>1__state = -1;
			<NewSilentAreaInfo>d__.<>t__builder.Start<TopPanel.<NewSilentAreaInfo>d__120>(ref <NewSilentAreaInfo>d__);
			return <NewSilentAreaInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06031101 RID: 200961 RVA: 0x00DB37B4 File Offset: 0x00DB19B4
		private UniTask NewShipTowerBuffInfo()
		{
			TopPanel.<NewShipTowerBuffInfo>d__121 <NewShipTowerBuffInfo>d__;
			<NewShipTowerBuffInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewShipTowerBuffInfo>d__.<>4__this = this;
			<NewShipTowerBuffInfo>d__.<>1__state = -1;
			<NewShipTowerBuffInfo>d__.<>t__builder.Start<TopPanel.<NewShipTowerBuffInfo>d__121>(ref <NewShipTowerBuffInfo>d__);
			return <NewShipTowerBuffInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06031102 RID: 200962 RVA: 0x00DB37F8 File Offset: 0x00DB19F8
		private UniTask NewMoraleBuffInfo()
		{
			TopPanel.<NewMoraleBuffInfo>d__122 <NewMoraleBuffInfo>d__;
			<NewMoraleBuffInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleBuffInfo>d__.<>4__this = this;
			<NewMoraleBuffInfo>d__.<>1__state = -1;
			<NewMoraleBuffInfo>d__.<>t__builder.Start<TopPanel.<NewMoraleBuffInfo>d__122>(ref <NewMoraleBuffInfo>d__);
			return <NewMoraleBuffInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06031103 RID: 200963 RVA: 0x00DB383C File Offset: 0x00DB1A3C
		private UniTask NewBabelTowerBattleTopPanel()
		{
			TopPanel.<NewBabelTowerBattleTopPanel>d__123 <NewBabelTowerBattleTopPanel>d__;
			<NewBabelTowerBattleTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBabelTowerBattleTopPanel>d__.<>4__this = this;
			<NewBabelTowerBattleTopPanel>d__.<>1__state = -1;
			<NewBabelTowerBattleTopPanel>d__.<>t__builder.Start<TopPanel.<NewBabelTowerBattleTopPanel>d__123>(ref <NewBabelTowerBattleTopPanel>d__);
			return <NewBabelTowerBattleTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06031104 RID: 200964 RVA: 0x00DB3880 File Offset: 0x00DB1A80
		private UniTask NewResDownLoadItemTopPanel()
		{
			TopPanel.<NewResDownLoadItemTopPanel>d__124 <NewResDownLoadItemTopPanel>d__;
			<NewResDownLoadItemTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewResDownLoadItemTopPanel>d__.<>4__this = this;
			<NewResDownLoadItemTopPanel>d__.<>1__state = -1;
			<NewResDownLoadItemTopPanel>d__.<>t__builder.Start<TopPanel.<NewResDownLoadItemTopPanel>d__124>(ref <NewResDownLoadItemTopPanel>d__);
			return <NewResDownLoadItemTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06031105 RID: 200965 RVA: 0x00DB38C4 File Offset: 0x00DB1AC4
		private UniTask NewMowingRiskInfo()
		{
			TopPanel.<NewMowingRiskInfo>d__125 <NewMowingRiskInfo>d__;
			<NewMowingRiskInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMowingRiskInfo>d__.<>4__this = this;
			<NewMowingRiskInfo>d__.<>1__state = -1;
			<NewMowingRiskInfo>d__.<>t__builder.Start<TopPanel.<NewMowingRiskInfo>d__125>(ref <NewMowingRiskInfo>d__);
			return <NewMowingRiskInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06031106 RID: 200966 RVA: 0x00DB3908 File Offset: 0x00DB1B08
		private UniTask NewTowerGuideButton()
		{
			TopPanel.<NewTowerGuideButton>d__126 <NewTowerGuideButton>d__;
			<NewTowerGuideButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewTowerGuideButton>d__.<>4__this = this;
			<NewTowerGuideButton>d__.<>1__state = -1;
			<NewTowerGuideButton>d__.<>t__builder.Start<TopPanel.<NewTowerGuideButton>d__126>(ref <NewTowerGuideButton>d__);
			return <NewTowerGuideButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031107 RID: 200967 RVA: 0x00DB394C File Offset: 0x00DB1B4C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleEntranceRoleButton> NewEntranceRoleButton(UUIItem uiItem, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			TopPanel.<NewEntranceRoleButton>d__127 <NewEntranceRoleButton>d__;
			<NewEntranceRoleButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleEntranceRoleButton>.Create();
			<NewEntranceRoleButton>d__.<>4__this = this;
			<NewEntranceRoleButton>d__.uiItem = uiItem;
			<NewEntranceRoleButton>d__.redDotName = redDotName;
			<NewEntranceRoleButton>d__.functionType = functionType;
			<NewEntranceRoleButton>d__.hideInGamepad = hideInGamepad;
			<NewEntranceRoleButton>d__.hideByRoleConfig = hideByRoleConfig;
			<NewEntranceRoleButton>d__.childType = childType;
			<NewEntranceRoleButton>d__.<>1__state = -1;
			<NewEntranceRoleButton>d__.<>t__builder.Start<TopPanel.<NewEntranceRoleButton>d__127>(ref <NewEntranceRoleButton>d__);
			return <NewEntranceRoleButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031108 RID: 200968 RVA: 0x00DB39C4 File Offset: 0x00DB1BC4
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleEntranceButton> NewBattleEntranceButton(UUIItem uiItem, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			TopPanel.<NewBattleEntranceButton>d__128 <NewBattleEntranceButton>d__;
			<NewBattleEntranceButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleEntranceButton>.Create();
			<NewBattleEntranceButton>d__.<>4__this = this;
			<NewBattleEntranceButton>d__.uiItem = uiItem;
			<NewBattleEntranceButton>d__.redDotName = redDotName;
			<NewBattleEntranceButton>d__.functionType = functionType;
			<NewBattleEntranceButton>d__.hideInGamepad = hideInGamepad;
			<NewBattleEntranceButton>d__.hideByRoleConfig = hideByRoleConfig;
			<NewBattleEntranceButton>d__.childType = childType;
			<NewBattleEntranceButton>d__.<>1__state = -1;
			<NewBattleEntranceButton>d__.<>t__builder.Start<TopPanel.<NewBattleEntranceButton>d__128>(ref <NewBattleEntranceButton>d__);
			return <NewBattleEntranceButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031109 RID: 200969 RVA: 0x00DB3A3C File Offset: 0x00DB1C3C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<CommonTopButtonPanel> NewCommonTopButton(UUIItem parent, [Nullable(2)] string iconPath = null, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			TopPanel.<NewCommonTopButton>d__129 <NewCommonTopButton>d__;
			<NewCommonTopButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<CommonTopButtonPanel>.Create();
			<NewCommonTopButton>d__.<>4__this = this;
			<NewCommonTopButton>d__.parent = parent;
			<NewCommonTopButton>d__.iconPath = iconPath;
			<NewCommonTopButton>d__.redDotName = redDotName;
			<NewCommonTopButton>d__.functionType = functionType;
			<NewCommonTopButton>d__.hideInGamepad = hideInGamepad;
			<NewCommonTopButton>d__.hideByRoleConfig = hideByRoleConfig;
			<NewCommonTopButton>d__.childType = childType;
			<NewCommonTopButton>d__.<>1__state = -1;
			<NewCommonTopButton>d__.<>t__builder.Start<TopPanel.<NewCommonTopButton>d__129>(ref <NewCommonTopButton>d__);
			return <NewCommonTopButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603110A RID: 200970 RVA: 0x00DB3ABC File Offset: 0x00DB1CBC
		private UniTask NewQuestButton()
		{
			TopPanel.<NewQuestButton>d__130 <NewQuestButton>d__;
			<NewQuestButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewQuestButton>d__.<>4__this = this;
			<NewQuestButton>d__.<>1__state = -1;
			<NewQuestButton>d__.<>t__builder.Start<TopPanel.<NewQuestButton>d__130>(ref <NewQuestButton>d__);
			return <NewQuestButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603110B RID: 200971 RVA: 0x00DB3AFF File Offset: 0x00DB1CFF
		private void OnClickedQuestButton()
		{
			if (HonamiStoryUtil.CheckInHonamiStoryAreaDungeon())
			{
				UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, null, null);
		}

		// Token: 0x0603110C RID: 200972 RVA: 0x00DB3B2C File Offset: 0x00DB1D2C
		private UniTask NewDungeonGuideButton()
		{
			TopPanel.<NewDungeonGuideButton>d__132 <NewDungeonGuideButton>d__;
			<NewDungeonGuideButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDungeonGuideButton>d__.<>4__this = this;
			<NewDungeonGuideButton>d__.<>1__state = -1;
			<NewDungeonGuideButton>d__.<>t__builder.Start<TopPanel.<NewDungeonGuideButton>d__132>(ref <NewDungeonGuideButton>d__);
			return <NewDungeonGuideButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603110D RID: 200973 RVA: 0x00DB3B6F File Offset: 0x00DB1D6F
		private static void OnClickedDungeonGuideButton()
		{
			InstanceDungeonGuideController.StartReplayGuide();
		}

		// Token: 0x0603110E RID: 200974 RVA: 0x00DB3B76 File Offset: 0x00DB1D76
		private static void OnClickedTowerGuideButton()
		{
			TowerController.Instance.OpenTowerGuide();
		}

		// Token: 0x0603110F RID: 200975 RVA: 0x00DB3B84 File Offset: 0x00DB1D84
		private UniTask NewRogueInfoButton()
		{
			TopPanel.<NewRogueInfoButton>d__135 <NewRogueInfoButton>d__;
			<NewRogueInfoButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRogueInfoButton>d__.<>4__this = this;
			<NewRogueInfoButton>d__.<>1__state = -1;
			<NewRogueInfoButton>d__.<>t__builder.Start<TopPanel.<NewRogueInfoButton>d__135>(ref <NewRogueInfoButton>d__);
			return <NewRogueInfoButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031110 RID: 200976 RVA: 0x00DB3BC8 File Offset: 0x00DB1DC8
		private void OnClickedRogueInfoButton()
		{
			if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
				return;
			}
			if (MapRogueController.Instance.CheckInMapRogueInstance())
			{
				UiManager.Instance.OpenView(EUiViewName.RogueBattleSummary, null, null);
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
		}

		// Token: 0x06031111 RID: 200977 RVA: 0x00DB3C1F File Offset: 0x00DB1E1F
		private bool RogueInfoButtonVisible()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x06031112 RID: 200978 RVA: 0x00DB3C3C File Offset: 0x00DB1E3C
		private UniTask NewSettingButton()
		{
			TopPanel.<NewSettingButton>d__138 <NewSettingButton>d__;
			<NewSettingButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSettingButton>d__.<>4__this = this;
			<NewSettingButton>d__.<>1__state = -1;
			<NewSettingButton>d__.<>t__builder.Start<TopPanel.<NewSettingButton>d__138>(ref <NewSettingButton>d__);
			return <NewSettingButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031113 RID: 200979 RVA: 0x00DB3C7F File Offset: 0x00DB1E7F
		private void OnClickSettingButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Menu);
		}

		// Token: 0x06031114 RID: 200980 RVA: 0x00DB3C90 File Offset: 0x00DB1E90
		private UniTask NewIosSettingButton()
		{
			TopPanel.<NewIosSettingButton>d__140 <NewIosSettingButton>d__;
			<NewIosSettingButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewIosSettingButton>d__.<>4__this = this;
			<NewIosSettingButton>d__.<>1__state = -1;
			<NewIosSettingButton>d__.<>t__builder.Start<TopPanel.<NewIosSettingButton>d__140>(ref <NewIosSettingButton>d__);
			return <NewIosSettingButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031115 RID: 200981 RVA: 0x00DB3CD3 File Offset: 0x00DB1ED3
		private bool SettingButtonVisible()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() && !WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x06031116 RID: 200982 RVA: 0x00DB3CF0 File Offset: 0x00DB1EF0
		private UniTask NewFightTeamButton()
		{
			TopPanel.<NewFightTeamButton>d__142 <NewFightTeamButton>d__;
			<NewFightTeamButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFightTeamButton>d__.<>4__this = this;
			<NewFightTeamButton>d__.<>1__state = -1;
			<NewFightTeamButton>d__.<>t__builder.Start<TopPanel.<NewFightTeamButton>d__142>(ref <NewFightTeamButton>d__);
			return <NewFightTeamButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031117 RID: 200983 RVA: 0x00DB3D33 File Offset: 0x00DB1F33
		private void OnClickedFightTeamButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.FormatTeam);
		}

		// Token: 0x06031118 RID: 200984 RVA: 0x00DB3D44 File Offset: 0x00DB1F44
		private void OnClickIosVoiceToggle(EToggleState _)
		{
			EToggleState toggleState = base.GetExtendToggle(18).ToggleState;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "当前背景播放音乐按钮 ToggleState";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("currentToggleState", toggleState);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (toggleState == EToggleState.ETT_UnChecked)
			{
				Log.Instance.Info(ELogModule.BattleUiSet, ELogAuthor.YZY, "停止背景音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
				UKuroBgPlayerStatic.Stop();
				return;
			}
			if (toggleState == EToggleState.ETT_Checked)
			{
				Log.Instance.Info(ELogModule.BattleUiSet, ELogAuthor.YZY, "背景播放音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
				UKuroBgPlayerStatic.Play();
			}
		}

		// Token: 0x06031119 RID: 200985 RVA: 0x00DB3DE0 File Offset: 0x00DB1FE0
		private UniTask NewDirectTrainProButton()
		{
			TopPanel.<NewDirectTrainProButton>d__145 <NewDirectTrainProButton>d__;
			<NewDirectTrainProButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDirectTrainProButton>d__.<>4__this = this;
			<NewDirectTrainProButton>d__.<>1__state = -1;
			<NewDirectTrainProButton>d__.<>t__builder.Start<TopPanel.<NewDirectTrainProButton>d__145>(ref <NewDirectTrainProButton>d__);
			return <NewDirectTrainProButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603111A RID: 200986 RVA: 0x00DB3E23 File Offset: 0x00DB2023
		private void OnClickedDirectTrainProButton()
		{
			ActivityDirectTrainHelper.TryOpenPro(false).Forget();
		}

		// Token: 0x0603111B RID: 200987 RVA: 0x00DB3E30 File Offset: 0x00DB2030
		private bool DirectTrainProButtonHide()
		{
			return !ActivityDirectTrainHelper.IsProOpen || !ActivityDirectTrainHelper.IsInValidInstance;
		}

		// Token: 0x0603111C RID: 200988 RVA: 0x00DB3E43 File Offset: 0x00DB2043
		private void OnActivityDirectTrainProSetActive(bool active)
		{
			BattleEntranceButton directTrainProButton = this.DirectTrainProButton;
			if (directTrainProButton == null)
			{
				return;
			}
			directTrainProButton.SetOtherHide(!active);
		}

		// Token: 0x0603111D RID: 200989 RVA: 0x00DB3E5C File Offset: 0x00DB205C
		private UniTask NewMoraleSumButton()
		{
			TopPanel.<NewMoraleSumButton>d__149 <NewMoraleSumButton>d__;
			<NewMoraleSumButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleSumButton>d__.<>4__this = this;
			<NewMoraleSumButton>d__.<>1__state = -1;
			<NewMoraleSumButton>d__.<>t__builder.Start<TopPanel.<NewMoraleSumButton>d__149>(ref <NewMoraleSumButton>d__);
			return <NewMoraleSumButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603111E RID: 200990 RVA: 0x00DB3E9F File Offset: 0x00DB209F
		private void OnClickedMoraleSumButton()
		{
			if (MoraleModel.Instance.IsInitData)
			{
				UiManager.Instance.OpenView(EUiViewName.MoraleAreaSumView, null, null);
			}
		}

		// Token: 0x0603111F RID: 200991 RVA: 0x00DB3EBE File Offset: 0x00DB20BE
		private bool MoraleSumButtonHide()
		{
			return !MoraleBattleModel.Instance.IsMoraleActive();
		}

		// Token: 0x06031120 RID: 200992 RVA: 0x00DB3ED0 File Offset: 0x00DB20D0
		private UniTask NewWavePlateTip()
		{
			TopPanel.<NewWavePlateTip>d__152 <NewWavePlateTip>d__;
			<NewWavePlateTip>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewWavePlateTip>d__.<>4__this = this;
			<NewWavePlateTip>d__.<>1__state = -1;
			<NewWavePlateTip>d__.<>t__builder.Start<TopPanel.<NewWavePlateTip>d__152>(ref <NewWavePlateTip>d__);
			return <NewWavePlateTip>d__.<>t__builder.Task;
		}

		// Token: 0x06031121 RID: 200993 RVA: 0x00DB3F14 File Offset: 0x00DB2114
		private UniTask NewWavePlateTipGamepad()
		{
			TopPanel.<NewWavePlateTipGamepad>d__153 <NewWavePlateTipGamepad>d__;
			<NewWavePlateTipGamepad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewWavePlateTipGamepad>d__.<>4__this = this;
			<NewWavePlateTipGamepad>d__.<>1__state = -1;
			<NewWavePlateTipGamepad>d__.<>t__builder.Start<TopPanel.<NewWavePlateTipGamepad>d__153>(ref <NewWavePlateTipGamepad>d__);
			return <NewWavePlateTipGamepad>d__.<>t__builder.Task;
		}

		// Token: 0x06031122 RID: 200994 RVA: 0x00DB3F58 File Offset: 0x00DB2158
		private UniTask NewAlertAreaInfo()
		{
			TopPanel.<NewAlertAreaInfo>d__154 <NewAlertAreaInfo>d__;
			<NewAlertAreaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAlertAreaInfo>d__.<>4__this = this;
			<NewAlertAreaInfo>d__.<>1__state = -1;
			<NewAlertAreaInfo>d__.<>t__builder.Start<TopPanel.<NewAlertAreaInfo>d__154>(ref <NewAlertAreaInfo>d__);
			return <NewAlertAreaInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06031123 RID: 200995 RVA: 0x00DB3F9C File Offset: 0x00DB219C
		private UniTask NewRewardList()
		{
			TopPanel.<NewRewardList>d__155 <NewRewardList>d__;
			<NewRewardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRewardList>d__.<>4__this = this;
			<NewRewardList>d__.<>1__state = -1;
			<NewRewardList>d__.<>t__builder.Start<TopPanel.<NewRewardList>d__155>(ref <NewRewardList>d__);
			return <NewRewardList>d__.<>t__builder.Task;
		}

		// Token: 0x06031124 RID: 200996 RVA: 0x00DB3FE0 File Offset: 0x00DB21E0
		private UniTask NewGamepadTopPanel()
		{
			TopPanel.<NewGamepadTopPanel>d__156 <NewGamepadTopPanel>d__;
			<NewGamepadTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewGamepadTopPanel>d__.<>4__this = this;
			<NewGamepadTopPanel>d__.<>1__state = -1;
			<NewGamepadTopPanel>d__.<>t__builder.Start<TopPanel.<NewGamepadTopPanel>d__156>(ref <NewGamepadTopPanel>d__);
			return <NewGamepadTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06031125 RID: 200997 RVA: 0x00DB4024 File Offset: 0x00DB2224
		private UniTask NewFishingView()
		{
			TopPanel.<NewFishingView>d__157 <NewFishingView>d__;
			<NewFishingView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFishingView>d__.<>4__this = this;
			<NewFishingView>d__.<>1__state = -1;
			<NewFishingView>d__.<>t__builder.Start<TopPanel.<NewFishingView>d__157>(ref <NewFishingView>d__);
			return <NewFishingView>d__.<>t__builder.Task;
		}

		// Token: 0x06031126 RID: 200998 RVA: 0x00DB4068 File Offset: 0x00DB2268
		private UniTask NewMoraleExpView()
		{
			TopPanel.<NewMoraleExpView>d__158 <NewMoraleExpView>d__;
			<NewMoraleExpView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleExpView>d__.<>4__this = this;
			<NewMoraleExpView>d__.<>1__state = -1;
			<NewMoraleExpView>d__.<>t__builder.Start<TopPanel.<NewMoraleExpView>d__158>(ref <NewMoraleExpView>d__);
			return <NewMoraleExpView>d__.<>t__builder.Task;
		}

		// Token: 0x06031127 RID: 200999 RVA: 0x00DB40AC File Offset: 0x00DB22AC
		private void OnDriveFishingShipStateChanged(bool isDriving)
		{
			BattleFishingView fishingView = this.FishingView;
			if (fishingView != null)
			{
				fishingView.SetDriveFishingShipVisible(isDriving);
			}
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.Formation, !isDriving, true, 0);
			}
			BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
			if (childViewData2 == null)
			{
				return;
			}
			childViewData2.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.GamepadFormation, !isDriving, true, 0);
		}

		// Token: 0x06031128 RID: 201000 RVA: 0x00DB4106 File Offset: 0x00DB2306
		private void ResDownLoadStateRefresh()
		{
			this.RefreshResDownLoadTopPanelState();
		}

		// Token: 0x06031129 RID: 201001 RVA: 0x00DB4110 File Offset: 0x00DB2310
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "MoraleExp")
			{
				MoraleExpView moraleExpView = this.MoraleExpView;
				UUIItem uuiitem = (moraleExpView != null) ? moraleExpView.GetGuideUiItem("0") : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			else if (a == "HonamiStoryPlayerLevel")
			{
				BattleHonamiStoryPlayerStateView honamiStoryPlayerStateView = this.HonamiStoryPlayerStateView;
				UUIItem uuiitem2 = (honamiStoryPlayerStateView != null) ? honamiStoryPlayerStateView.GetGuideUiItem("0") : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			else if (a == "HonamiStoryMapLevel")
			{
				BattleHonamiStoryMapLevelView honamiStoryMapLevelView = this.HonamiStoryMapLevelView;
				UUIItem uuiitem3 = (honamiStoryMapLevelView != null) ? honamiStoryMapLevelView.GetGuideUiItem("0") : null;
				UUIItem rootItem = this.HonamiStoryMapLevelView.GetRootItem();
				if (uuiitem3 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					rootItem,
					uuiitem3
				};
			}
			else if (a == "HonamiStoryLeaveBtn")
			{
				BattleHonamiStoryLeaveButton honamiStoryLeaveButton = this.HonamiStoryLeaveButton;
				UUIItem uuiitem4 = (honamiStoryLeaveButton != null) ? honamiStoryLeaveButton.GetGuideUiItem("0") : null;
				if (uuiitem4 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem4,
					uuiitem4
				};
			}
			else if (a == "FlagChallengeBuff")
			{
				CommonTopButtonPanel flagChallengeBuffButton = this.FlagChallengeBuffButton;
				UUIItem uuiitem5 = (flagChallengeBuffButton != null) ? flagChallengeBuffButton.GetRootItem() : null;
				if (uuiitem5 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem5,
					uuiitem5
				};
			}
			else if (a == "FlagChallengePause")
			{
				CommonTopButtonPanel flagChallengeLevelButton = this.FlagChallengeLevelButton;
				UUIItem uuiitem6 = (flagChallengeLevelButton != null) ? flagChallengeLevelButton.GetRootItem() : null;
				if (uuiitem6 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem6,
					uuiitem6
				};
			}
			else if (a == "FlagChallengeMapBar")
			{
				FlagChallengeExpView flagChallengeExpView = this.FlagChallengeExpView;
				UUIItem uuiitem7 = (flagChallengeExpView != null) ? flagChallengeExpView.GetLevelBgTextureItem() : null;
				if (uuiitem7 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem7,
					uuiitem7
				};
			}
			else if (a == "ResDownLoadBtn")
			{
				ResDownLoadTopPanel resDownLoadItemTopPanel = this.ResDownLoadItemTopPanel;
				UUIItem uuiitem8 = (resDownLoadItemTopPanel != null) ? resDownLoadItemTopPanel.GetRootItem() : null;
				if (uuiitem8 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem8,
					uuiitem8
				};
			}
			else
			{
				BattleFishingView fishingView = this.FishingView;
				if (fishingView == null)
				{
					return null;
				}
				return fishingView.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x0603112A RID: 201002 RVA: 0x00DB4314 File Offset: 0x00DB2514
		private UniTask NewHonamiStoryItems()
		{
			TopPanel.<NewHonamiStoryItems>d__162 <NewHonamiStoryItems>d__;
			<NewHonamiStoryItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHonamiStoryItems>d__.<>4__this = this;
			<NewHonamiStoryItems>d__.<>1__state = -1;
			<NewHonamiStoryItems>d__.<>t__builder.Start<TopPanel.<NewHonamiStoryItems>d__162>(ref <NewHonamiStoryItems>d__);
			return <NewHonamiStoryItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603112B RID: 201003 RVA: 0x00DB4357 File Offset: 0x00DB2557
		private void OnClickHonamiStoryBag()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.HonamiStoryBackpack);
		}

		// Token: 0x0603112C RID: 201004 RVA: 0x00DB4368 File Offset: 0x00DB2568
		private bool HonamiStoryBagHide()
		{
			return !HonamiStoryUtil.CheckInHonamiStoryDungeon();
		}

		// Token: 0x0603112D RID: 201005 RVA: 0x00DB4374 File Offset: 0x00DB2574
		private UniTask NewFlagChallengeItems()
		{
			TopPanel.<NewFlagChallengeItems>d__165 <NewFlagChallengeItems>d__;
			<NewFlagChallengeItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFlagChallengeItems>d__.<>4__this = this;
			<NewFlagChallengeItems>d__.<>1__state = -1;
			<NewFlagChallengeItems>d__.<>t__builder.Start<TopPanel.<NewFlagChallengeItems>d__165>(ref <NewFlagChallengeItems>d__);
			return <NewFlagChallengeItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603112E RID: 201006 RVA: 0x00DB43B8 File Offset: 0x00DB25B8
		private UniTask NewFlagChallengePauseButton()
		{
			TopPanel.<NewFlagChallengePauseButton>d__166 <NewFlagChallengePauseButton>d__;
			<NewFlagChallengePauseButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFlagChallengePauseButton>d__.<>4__this = this;
			<NewFlagChallengePauseButton>d__.<>1__state = -1;
			<NewFlagChallengePauseButton>d__.<>t__builder.Start<TopPanel.<NewFlagChallengePauseButton>d__166>(ref <NewFlagChallengePauseButton>d__);
			return <NewFlagChallengePauseButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603112F RID: 201007 RVA: 0x00DB43FC File Offset: 0x00DB25FC
		private void OnClickedFlagChallengeLevelButton()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int levelId = FlagChallengeBattleModel.Instance.LevelId;
			int areaId = FlagChallengeBattleModel.Instance.AreaId;
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
			int levelRecommendStrongholdId = FlagChallengeModel.Instance.GetLevelRecommendStrongholdId(activityId, levelId, new int[]
			{
				areaId
			});
			FlagChallengeStrongholdData strongholdData = flagChallengeData.GetStrongholdData(levelRecommendStrongholdId);
			FlagChallengeController.Instance.OpenFlagChallengeAreaDetailView(activityId, levelId, strongholdData.StrongholdConfig.AreaId, new int?(levelRecommendStrongholdId));
		}

		// Token: 0x06031130 RID: 201008 RVA: 0x00DB4478 File Offset: 0x00DB2678
		private void OnClickedFlagChallengeBuffButton()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(FlagChallengeBattleModel.Instance.ActivityId, null);
		}

		// Token: 0x06031131 RID: 201009 RVA: 0x00DB44A2 File Offset: 0x00DB26A2
		private void OnClickedFlagChallengePauseButton()
		{
			FlagChallengeBattleController.Instance.OpenPauseView();
		}

		// Token: 0x06031132 RID: 201010 RVA: 0x00DB44AE File Offset: 0x00DB26AE
		private bool FlagChallengeButtonHide()
		{
			return !FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
		}

		// Token: 0x06031133 RID: 201011 RVA: 0x00DB44BD File Offset: 0x00DB26BD
		private void RefreshFlagChallengeUiVisibleState()
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				FlagChallengeExpView flagChallengeExpView = this.FlagChallengeExpView;
				if (flagChallengeExpView == null)
				{
					return;
				}
				flagChallengeExpView.StartShow();
				return;
			}
			else
			{
				FlagChallengeExpView flagChallengeExpView2 = this.FlagChallengeExpView;
				if (flagChallengeExpView2 == null)
				{
					return;
				}
				flagChallengeExpView2.EndShow();
				return;
			}
		}

		// Token: 0x06031134 RID: 201012 RVA: 0x00DB44EC File Offset: 0x00DB26EC
		private UniTask NewRecallQuestItems()
		{
			TopPanel.<NewRecallQuestItems>d__172 <NewRecallQuestItems>d__;
			<NewRecallQuestItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRecallQuestItems>d__.<>4__this = this;
			<NewRecallQuestItems>d__.<>1__state = -1;
			<NewRecallQuestItems>d__.<>t__builder.Start<TopPanel.<NewRecallQuestItems>d__172>(ref <NewRecallQuestItems>d__);
			return <NewRecallQuestItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031135 RID: 201013 RVA: 0x00DB4530 File Offset: 0x00DB2730
		private UniTask NewBossPilingTopPanel()
		{
			TopPanel.<NewBossPilingTopPanel>d__173 <NewBossPilingTopPanel>d__;
			<NewBossPilingTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBossPilingTopPanel>d__.<>4__this = this;
			<NewBossPilingTopPanel>d__.<>1__state = -1;
			<NewBossPilingTopPanel>d__.<>t__builder.Start<TopPanel.<NewBossPilingTopPanel>d__173>(ref <NewBossPilingTopPanel>d__);
			return <NewBossPilingTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06031136 RID: 201014 RVA: 0x00DB4574 File Offset: 0x00DB2774
		private void RefreshBossPilingTopState()
		{
			if (this.BossPilingTopItem == null)
			{
				return;
			}
			bool flag = this.CheckIsBossPiling();
			this.MiniMapView.SetRoguelikeVisible(!flag);
			if (flag)
			{
				this.ButtonList.ForEach(delegate(BattleEntranceButton button)
				{
					button.SetOtherHide(true);
				});
				this.ExitButton.SetOtherHide(false);
				BossPilingTopItem bossPilingTopItem = this.BossPilingTopItem;
				if (bossPilingTopItem == null)
				{
					return;
				}
				bossPilingTopItem.StartShow();
				return;
			}
			else
			{
				BossPilingTopItem bossPilingTopItem2 = this.BossPilingTopItem;
				if (bossPilingTopItem2 == null)
				{
					return;
				}
				bossPilingTopItem2.EndShow();
				return;
			}
		}

		// Token: 0x06031137 RID: 201015 RVA: 0x00DB45FC File Offset: 0x00DB27FC
		[NullableContext(1)]
		[return: Nullable(2)]
		public UUIItem GetPanelItem(string item)
		{
			if (!(item == "PhoneMsgButton"))
			{
				if (!(item == "EntitySequenceButtonRoot"))
				{
					return null;
				}
				if (!Info.Instance.IsInGamepad())
				{
					return base.GetItem(39);
				}
				GamepadTopPanel gamepadTopPanel = this.GamepadTopPanel;
				if (gamepadTopPanel == null)
				{
					return null;
				}
				return gamepadTopPanel.GetPanelItem(item);
			}
			else
			{
				if (!Info.Instance.IsInGamepad())
				{
					return base.GetItem(38);
				}
				GamepadTopPanel gamepadTopPanel2 = this.GamepadTopPanel;
				if (gamepadTopPanel2 == null)
				{
					return null;
				}
				return gamepadTopPanel2.GetPanelItem(item);
			}
		}

		// Token: 0x06031138 RID: 201016 RVA: 0x00DB4676 File Offset: 0x00DB2876
		public IPhoneMessageButtonImplement GetPhoneMsgButton()
		{
			if (Info.Instance.IsInGamepad())
			{
				return this.GamepadTopPanel.GetPhoneMsgButton();
			}
			return this.PhoneMsgButton;
		}

		// Token: 0x0401A015 RID: 106517
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]TopPanelTick", "", "");

		// Token: 0x0401A016 RID: 106518
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly EBattleUiChild[] BattleUiChildren = new EBattleUiChild[]
		{
			EBattleUiChild.MiniMap,
			EBattleUiChild.TopButton,
			EBattleUiChild.HomeButton,
			EBattleUiChild.ExitButton
		};

		// Token: 0x0401A017 RID: 106519
		private MiniMapView MiniMapView;

		// Token: 0x0401A018 RID: 106520
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BattleEntranceButton> ButtonList;

		// Token: 0x0401A019 RID: 106521
		private BattleEntranceButton ExitButton;

		// Token: 0x0401A01A RID: 106522
		private BattleEntranceButton HomeButton;

		// Token: 0x0401A01B RID: 106523
		private BattleEntranceButton ActivityButton;

		// Token: 0x0401A01C RID: 106524
		private BattleEntranceButton DirectTrainProButton;

		// Token: 0x0401A01D RID: 106525
		private BattleEntranceButton MoraleBuffSumButton;

		// Token: 0x0401A01E RID: 106526
		private BattleOnlineButton OnlineButton;

		// Token: 0x0401A01F RID: 106527
		private BattlePhoneMessageButton PhoneMsgButton;

		// Token: 0x0401A020 RID: 106528
		private BattleQuestButton QuestButton;

		// Token: 0x0401A021 RID: 106529
		private BattleDungeonGuideButton DungeonGuideButton;

		// Token: 0x0401A022 RID: 106530
		private BattleEntranceButton RogueInfoButton;

		// Token: 0x0401A023 RID: 106531
		private BattleFormationButton FightTeamButton;

		// Token: 0x0401A024 RID: 106532
		private SilentAreaView SilentAreaView;

		// Token: 0x0401A025 RID: 106533
		private ShipTowerBuffBattleView ShipTowerBuffView;

		// Token: 0x0401A026 RID: 106534
		private MoraleBuffBattleView MoraleBuffView;

		// Token: 0x0401A027 RID: 106535
		private MowingRiskInBattleView MowingRiskView;

		// Token: 0x0401A028 RID: 106536
		private BabelTowerBattleTopPanel BabelTowerBattleTopPanel;

		// Token: 0x0401A029 RID: 106537
		private ResDownLoadTopPanel ResDownLoadItemTopPanel;

		// Token: 0x0401A02A RID: 106538
		private BattleTowerButton TowerGuideButton;

		// Token: 0x0401A02B RID: 106539
		private BattleEntranceButton SettingButton;

		// Token: 0x0401A02C RID: 106540
		private TopPanelWavePlateTip WavePlateTip;

		// Token: 0x0401A02D RID: 106541
		private TopPanelWavePlateTip WavePlateTipGamePad;

		// Token: 0x0401A02E RID: 106542
		private AlertAreaInfoView AlertAreaInfoView;

		// Token: 0x0401A02F RID: 106543
		private RewardListView RewardListView;

		// Token: 0x0401A030 RID: 106544
		private GamepadTopPanel GamepadTopPanel;

		// Token: 0x0401A031 RID: 106545
		private CommonTopButtonPanel HonamiStoryBagButton;

		// Token: 0x0401A032 RID: 106546
		private BattleHonamiStoryLeaveButton HonamiStoryLeaveButton;

		// Token: 0x0401A033 RID: 106547
		private BattleHonamiStoryMapLevelView HonamiStoryMapLevelView;

		// Token: 0x0401A034 RID: 106548
		private BattleHonamiStoryPlayerStateView HonamiStoryPlayerStateView;

		// Token: 0x0401A035 RID: 106549
		private BattleFishingView FishingView;

		// Token: 0x0401A036 RID: 106550
		private MoraleExpView MoraleExpView;

		// Token: 0x0401A037 RID: 106551
		private FlagChallengeExpView FlagChallengeExpView;

		// Token: 0x0401A038 RID: 106552
		private CommonTopButtonPanel FlagChallengeLevelButton;

		// Token: 0x0401A039 RID: 106553
		private CommonTopButtonPanel FlagChallengeBuffButton;

		// Token: 0x0401A03A RID: 106554
		private CommonTopButtonPanel FlagChallengePauseButton;

		// Token: 0x0401A03B RID: 106555
		private BossPilingTopItem BossPilingTopItem;

		// Token: 0x0401A03C RID: 106556
		private RecallTopPanel RecallTopPanel;

		// Token: 0x0401A03D RID: 106557
		private BattleEntranceButton InventoryButton;

		// Token: 0x0401A03E RID: 106558
		private BattleTopPanelHookCenter UiHookCenter;

		// Token: 0x0401A03F RID: 106559
		private bool IsGamepad;

		// Token: 0x0401A040 RID: 106560
		private bool IsGamepadPanelCreated;

		// Token: 0x0401A041 RID: 106561
		private UniTaskCompletionSource GamepadPanelCreatePromise;

		// Token: 0x0200A8F1 RID: 43249
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034315 RID: 213781
			MiniMapItem,
			// Token: 0x04034316 RID: 213782
			HomeButtonItem,
			// Token: 0x04034317 RID: 213783
			ExitButtonItem,
			// Token: 0x04034318 RID: 213784
			GachaButtonItem,
			// Token: 0x04034319 RID: 213785
			OnlineButtonItem,
			// Token: 0x0403431A RID: 213786
			ShopButtonItem,
			// Token: 0x0403431B RID: 213787
			InventoryButtonItem,
			// Token: 0x0403431C RID: 213788
			PassCheckButtonItem,
			// Token: 0x0403431D RID: 213789
			RoleButtonItem,
			// Token: 0x0403431E RID: 213790
			HelpButtonItem,
			// Token: 0x0403431F RID: 213791
			ActivityItem,
			// Token: 0x04034320 RID: 213792
			QuestButton,
			// Token: 0x04034321 RID: 213793
			DungeonGuideButton,
			// Token: 0x04034322 RID: 213794
			RogueInfoButton,
			// Token: 0x04034323 RID: 213795
			SilentInfoItem = 15,
			// Token: 0x04034324 RID: 213796
			TowerGuideButton,
			// Token: 0x04034325 RID: 213797
			FightTeamButton,
			// Token: 0x04034326 RID: 213798
			VoiceToggle,
			// Token: 0x04034327 RID: 213799
			SettingButton,
			// Token: 0x04034328 RID: 213800
			TowerDefenseItem,
			// Token: 0x04034329 RID: 213801
			MowingRiskItem,
			// Token: 0x0403432A RID: 213802
			DungeonTutorialButton,
			// Token: 0x0403432B RID: 213803
			WavePlateTipItem,
			// Token: 0x0403432C RID: 213804
			AlertAreaInfoItem,
			// Token: 0x0403432D RID: 213805
			FishingView,
			// Token: 0x0403432E RID: 213806
			ShipTowerBuffItem = 27,
			// Token: 0x0403432F RID: 213807
			BabelTowerStarItem,
			// Token: 0x04034330 RID: 213808
			IosSettingItem,
			// Token: 0x04034331 RID: 213809
			PanelLeftTop,
			// Token: 0x04034332 RID: 213810
			DirectTrainProButtonItem,
			// Token: 0x04034333 RID: 213811
			MapBarItem,
			// Token: 0x04034334 RID: 213812
			MoraleBuffItem,
			// Token: 0x04034335 RID: 213813
			MoraleSumButtonItem,
			// Token: 0x04034336 RID: 213814
			HonamiStoryLeaveItem,
			// Token: 0x04034337 RID: 213815
			PlayerLevelItem,
			// Token: 0x04034338 RID: 213816
			PhoneMsgButtonItem = 38,
			// Token: 0x04034339 RID: 213817
			EntitySequenceButtonRoot,
			// Token: 0x0403433A RID: 213818
			RecallTopPanel,
			// Token: 0x0403433B RID: 213819
			MAX
		}

		// Token: 0x0200A8F2 RID: 43250
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x0403433D RID: 213821
			KeyBoardPane = 41,
			// Token: 0x0403433E RID: 213822
			GamepadPanel,
			// Token: 0x0403433F RID: 213823
			WavePlateTipGamepadItem
		}

		// Token: 0x0200A8F3 RID: 43251
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034340 RID: 213824
			[Nullable(0)]
			public static Action <0>__OnClickedOnlineButton;

			// Token: 0x04034341 RID: 213825
			[Nullable(0)]
			public static Action <1>__OnClickedPhoneMsgButton;

			// Token: 0x04034342 RID: 213826
			[Nullable(0)]
			public static Action <2>__OnClickedTowerGuideButton;

			// Token: 0x04034343 RID: 213827
			[Nullable(0)]
			public static Action <3>__OnClickedDungeonGuideButton;
		}
	}
}

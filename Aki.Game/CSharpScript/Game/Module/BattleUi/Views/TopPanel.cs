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
	// Token: 0x02005CCE RID: 23758
	[NullableContext(2)]
	[Nullable(0)]
	public class TopPanel : BattleChildViewPanel
	{
		// Token: 0x0603C162 RID: 246114 RVA: 0x00E611E0 File Offset: 0x00E5F3E0
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

		// Token: 0x0603C163 RID: 246115 RVA: 0x00E617AC File Offset: 0x00E5F9AC
		public override UniTask InitializeAsync()
		{
			TopPanel.<InitializeAsync>d__48 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<TopPanel.<InitializeAsync>d__48>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C164 RID: 246116 RVA: 0x00E617EF File Offset: 0x00E5F9EF
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

		// Token: 0x0603C165 RID: 246117 RVA: 0x00E61814 File Offset: 0x00E5FA14
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

		// Token: 0x0603C166 RID: 246118 RVA: 0x00E619AC File Offset: 0x00E5FBAC
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

		// Token: 0x0603C167 RID: 246119 RVA: 0x00E61B04 File Offset: 0x00E5FD04
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

		// Token: 0x0603C168 RID: 246120 RVA: 0x00E61CC4 File Offset: 0x00E5FEC4
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

		// Token: 0x0603C169 RID: 246121 RVA: 0x00E61CF8 File Offset: 0x00E5FEF8
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

		// Token: 0x0603C16A RID: 246122 RVA: 0x00E61D48 File Offset: 0x00E5FF48
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

		// Token: 0x0603C16B RID: 246123 RVA: 0x00E61F60 File Offset: 0x00E60160
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

		// Token: 0x0603C16C RID: 246124 RVA: 0x00E62178 File Offset: 0x00E60378
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

		// Token: 0x0603C16D RID: 246125 RVA: 0x00E621CC File Offset: 0x00E603CC
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

		// Token: 0x0603C16E RID: 246126 RVA: 0x00E62208 File Offset: 0x00E60408
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

		// Token: 0x0603C16F RID: 246127 RVA: 0x00E62278 File Offset: 0x00E60478
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

		// Token: 0x0603C170 RID: 246128 RVA: 0x00E622A8 File Offset: 0x00E604A8
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

		// Token: 0x0603C171 RID: 246129 RVA: 0x00E622E8 File Offset: 0x00E604E8
		private void OnGmOnlyShowMiniMap(bool bVisible)
		{
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetGmHide(!bVisible);
			}
			this.ExitButton.SetGmHide(!bVisible);
			this.ActivityButton.SetGmHide(!bVisible);
		}

		// Token: 0x0603C172 RID: 246130 RVA: 0x00E6235C File Offset: 0x00E6055C
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

		// Token: 0x0603C173 RID: 246131 RVA: 0x00E62418 File Offset: 0x00E60618
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

		// Token: 0x0603C174 RID: 246132 RVA: 0x00E62438 File Offset: 0x00E60638
		private UniTask CreateGamepadPanel()
		{
			TopPanel.<CreateGamepadPanel>d__65 <CreateGamepadPanel>d__;
			<CreateGamepadPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanel>d__.<>4__this = this;
			<CreateGamepadPanel>d__.<>1__state = -1;
			<CreateGamepadPanel>d__.<>t__builder.Start<TopPanel.<CreateGamepadPanel>d__65>(ref <CreateGamepadPanel>d__);
			return <CreateGamepadPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C175 RID: 246133 RVA: 0x00E6247C File Offset: 0x00E6067C
		private UniTask CreateGamepadPanelInner()
		{
			TopPanel.<CreateGamepadPanelInner>d__66 <CreateGamepadPanelInner>d__;
			<CreateGamepadPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanelInner>d__.<>4__this = this;
			<CreateGamepadPanelInner>d__.<>1__state = -1;
			<CreateGamepadPanelInner>d__.<>t__builder.Start<TopPanel.<CreateGamepadPanelInner>d__66>(ref <CreateGamepadPanelInner>d__);
			return <CreateGamepadPanelInner>d__.<>t__builder.Task;
		}

		// Token: 0x0603C176 RID: 246134 RVA: 0x00E624C0 File Offset: 0x00E606C0
		private UniTask EnsureGamepadPanelCreatedAsync()
		{
			TopPanel.<EnsureGamepadPanelCreatedAsync>d__67 <EnsureGamepadPanelCreatedAsync>d__;
			<EnsureGamepadPanelCreatedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureGamepadPanelCreatedAsync>d__.<>4__this = this;
			<EnsureGamepadPanelCreatedAsync>d__.<>1__state = -1;
			<EnsureGamepadPanelCreatedAsync>d__.<>t__builder.Start<TopPanel.<EnsureGamepadPanelCreatedAsync>d__67>(ref <EnsureGamepadPanelCreatedAsync>d__);
			return <EnsureGamepadPanelCreatedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C177 RID: 246135 RVA: 0x00E62504 File Offset: 0x00E60704
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

		// Token: 0x0603C178 RID: 246136 RVA: 0x00E62547 File Offset: 0x00E60747
		private void OnActivityUpdate()
		{
			this.RefreshActivityVisibleState();
			this.RefreshActivityDungeonState();
		}

		// Token: 0x0603C179 RID: 246137 RVA: 0x00E62555 File Offset: 0x00E60755
		private bool CheckIsInRogue()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue() || MapRogueController.Instance.CheckInMapRogueInstance();
		}

		// Token: 0x0603C17A RID: 246138 RVA: 0x00E6257C File Offset: 0x00E6077C
		private bool CheckIsBossPiling()
		{
			InstanceDungeon? instanceDungeon;
			return ((GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().InstSubType : -1) == 55;
		}

		// Token: 0x0603C17B RID: 246139 RVA: 0x00E625B4 File Offset: 0x00E607B4
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

		// Token: 0x0603C17C RID: 246140 RVA: 0x00E626A5 File Offset: 0x00E608A5
		private void OnChangeRole(int i, int i1)
		{
			this.OnlineButton.RefreshButtonState();
		}

		// Token: 0x0603C17D RID: 246141 RVA: 0x00E626B4 File Offset: 0x00E608B4
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetFunctionOpen(functionType, isOpen);
			}
		}

		// Token: 0x0603C17E RID: 246142 RVA: 0x00E62708 File Offset: 0x00E60908
		private void RefreshExitButtonVisibleState()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				this.ExitButton.SetOtherHide(true);
				return;
			}
			this.ExitButton.SetOtherHide(false);
		}

		// Token: 0x0603C17F RID: 246143 RVA: 0x00E62730 File Offset: 0x00E60930
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
			this.ActivityButton.SetOtherHide(!ActivityModel.Instance.GetIfShowActivity());
		}

		// Token: 0x0603C180 RID: 246144 RVA: 0x00E62783 File Offset: 0x00E60983
		private void RefreshDirectTrainProState()
		{
			BattleEntranceButton directTrainProButton = this.DirectTrainProButton;
			if (directTrainProButton == null)
			{
				return;
			}
			directTrainProButton.SetOtherHide(!ActivityDirectTrainHelper.IsProOpen || !ActivityDirectTrainHelper.IsInValidInstance);
		}

		// Token: 0x0603C181 RID: 246145 RVA: 0x00E627A7 File Offset: 0x00E609A7
		private void RefreshTowerGuideVisibleState()
		{
			this.TowerGuideButton.SetOtherHide(!TowerModel.Instance.CheckInTower());
		}

		// Token: 0x0603C182 RID: 246146 RVA: 0x00E627C4 File Offset: 0x00E609C4
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

		// Token: 0x0603C183 RID: 246147 RVA: 0x00E6280C File Offset: 0x00E60A0C
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

		// Token: 0x0603C184 RID: 246148 RVA: 0x00E6283B File Offset: 0x00E60A3B
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

		// Token: 0x0603C185 RID: 246149 RVA: 0x00E6286C File Offset: 0x00E60A6C
		private void RefreshShipTowerTopPanelState()
		{
			bool flag = ShipTowerModel.Instance.CheckInBattleShipTower();
			bool flag2 = ShipTowerModel.Instance.CheckIsScoreBattle();
			bool shipTowerVisible = !flag || !flag2;
			this.MiniMapView.SetShipTowerVisible(shipTowerVisible);
		}

		// Token: 0x0603C186 RID: 246150 RVA: 0x00E628A4 File Offset: 0x00E60AA4
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

		// Token: 0x0603C187 RID: 246151 RVA: 0x00E628D4 File Offset: 0x00E60AD4
		private void RefreshMowingRiskVisibleState()
		{
			bool active = ActivityMowingRiskController.Instance.CheckInInstanceDungeon();
			this.MowingRiskInBattleView(active);
		}

		// Token: 0x0603C188 RID: 246152 RVA: 0x00E628F4 File Offset: 0x00E60AF4
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

		// Token: 0x0603C189 RID: 246153 RVA: 0x00E62954 File Offset: 0x00E60B54
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

		// Token: 0x0603C18A RID: 246154 RVA: 0x00E629C4 File Offset: 0x00E60BC4
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

		// Token: 0x0603C18B RID: 246155 RVA: 0x00E62A70 File Offset: 0x00E60C70
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

		// Token: 0x0603C18C RID: 246156 RVA: 0x00E62B04 File Offset: 0x00E60D04
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

		// Token: 0x0603C18D RID: 246157 RVA: 0x00E62B90 File Offset: 0x00E60D90
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

		// Token: 0x0603C18E RID: 246158 RVA: 0x00E62C48 File Offset: 0x00E60E48
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

		// Token: 0x0603C18F RID: 246159 RVA: 0x00E62C9A File Offset: 0x00E60E9A
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

		// Token: 0x0603C190 RID: 246160 RVA: 0x00E62CC9 File Offset: 0x00E60EC9
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

		// Token: 0x0603C191 RID: 246161 RVA: 0x00E62D04 File Offset: 0x00E60F04
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

		// Token: 0x0603C192 RID: 246162 RVA: 0x00E62D48 File Offset: 0x00E60F48
		private UniTask NewHomeButton()
		{
			TopPanel.<NewHomeButton>d__95 <NewHomeButton>d__;
			<NewHomeButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHomeButton>d__.<>4__this = this;
			<NewHomeButton>d__.<>1__state = -1;
			<NewHomeButton>d__.<>t__builder.Start<TopPanel.<NewHomeButton>d__95>(ref <NewHomeButton>d__);
			return <NewHomeButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C193 RID: 246163 RVA: 0x00E62D8B File Offset: 0x00E60F8B
		private void OnClickedHomeButton()
		{
			if (!RecallQuestModel.Instance.IsInRecallInstance())
			{
				UiManager.Instance.OpenView(EUiViewName.FunctionView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RecallFunctionView, null, null);
		}

		// Token: 0x0603C194 RID: 246164 RVA: 0x00E62DBC File Offset: 0x00E60FBC
		private UniTask NewGachaButton()
		{
			TopPanel.<NewGachaButton>d__97 <NewGachaButton>d__;
			<NewGachaButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewGachaButton>d__.<>4__this = this;
			<NewGachaButton>d__.<>1__state = -1;
			<NewGachaButton>d__.<>t__builder.Start<TopPanel.<NewGachaButton>d__97>(ref <NewGachaButton>d__);
			return <NewGachaButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C195 RID: 246165 RVA: 0x00E62DFF File Offset: 0x00E60FFF
		private void OnClickedGachaButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Gacha);
		}

		// Token: 0x0603C196 RID: 246166 RVA: 0x00E62E10 File Offset: 0x00E61010
		private UniTask NewExitButton()
		{
			TopPanel.<NewExitButton>d__99 <NewExitButton>d__;
			<NewExitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExitButton>d__.<>4__this = this;
			<NewExitButton>d__.<>1__state = -1;
			<NewExitButton>d__.<>t__builder.Start<TopPanel.<NewExitButton>d__99>(ref <NewExitButton>d__);
			return <NewExitButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C197 RID: 246167 RVA: 0x00E62E54 File Offset: 0x00E61054
		private UniTask NewActivityButton()
		{
			TopPanel.<NewActivityButton>d__100 <NewActivityButton>d__;
			<NewActivityButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewActivityButton>d__.<>4__this = this;
			<NewActivityButton>d__.<>1__state = -1;
			<NewActivityButton>d__.<>t__builder.Start<TopPanel.<NewActivityButton>d__100>(ref <NewActivityButton>d__);
			return <NewActivityButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C198 RID: 246168 RVA: 0x00E62E97 File Offset: 0x00E61097
		private bool GetActivityOtherHide()
		{
			return !ActivityModel.Instance.GetIfShowActivity();
		}

		// Token: 0x0603C199 RID: 246169 RVA: 0x00E62EA6 File Offset: 0x00E610A6
		private void OnClickedExitButton()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
		}

		// Token: 0x0603C19A RID: 246170 RVA: 0x00E62EB8 File Offset: 0x00E610B8
		private UniTask NewOnlineButton()
		{
			TopPanel.<NewOnlineButton>d__103 <NewOnlineButton>d__;
			<NewOnlineButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewOnlineButton>d__.<>4__this = this;
			<NewOnlineButton>d__.<>1__state = -1;
			<NewOnlineButton>d__.<>t__builder.Start<TopPanel.<NewOnlineButton>d__103>(ref <NewOnlineButton>d__);
			return <NewOnlineButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C19B RID: 246171 RVA: 0x00E62EFC File Offset: 0x00E610FC
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

		// Token: 0x0603C19C RID: 246172 RVA: 0x00E62F44 File Offset: 0x00E61144
		private UniTask NewInventoryButton()
		{
			TopPanel.<NewInventoryButton>d__105 <NewInventoryButton>d__;
			<NewInventoryButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewInventoryButton>d__.<>4__this = this;
			<NewInventoryButton>d__.<>1__state = -1;
			<NewInventoryButton>d__.<>t__builder.Start<TopPanel.<NewInventoryButton>d__105>(ref <NewInventoryButton>d__);
			return <NewInventoryButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C19D RID: 246173 RVA: 0x00E62F87 File Offset: 0x00E61187
		private void OnClickedInventoryButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Bag);
		}

		// Token: 0x0603C19E RID: 246174 RVA: 0x00E62F98 File Offset: 0x00E61198
		private UniTask NewPhoneMagButton()
		{
			TopPanel.<NewPhoneMagButton>d__107 <NewPhoneMagButton>d__;
			<NewPhoneMagButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewPhoneMagButton>d__.<>4__this = this;
			<NewPhoneMagButton>d__.<>1__state = -1;
			<NewPhoneMagButton>d__.<>t__builder.Start<TopPanel.<NewPhoneMagButton>d__107>(ref <NewPhoneMagButton>d__);
			return <NewPhoneMagButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C19F RID: 246175 RVA: 0x00E62FDB File Offset: 0x00E611DB
		private static void OnClickedPhoneMsgButton()
		{
			PhoneMsgController.Instance.OpenAndJumpShowTipShortMessage(EPhoneMsgOpenWay.HUD, EPhoneMsgViewType.Big);
		}

		// Token: 0x0603C1A0 RID: 246176 RVA: 0x00E62FEC File Offset: 0x00E611EC
		private UniTask NewShopButton()
		{
			TopPanel.<NewShopButton>d__109 <NewShopButton>d__;
			<NewShopButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewShopButton>d__.<>4__this = this;
			<NewShopButton>d__.<>1__state = -1;
			<NewShopButton>d__.<>t__builder.Start<TopPanel.<NewShopButton>d__109>(ref <NewShopButton>d__);
			return <NewShopButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A1 RID: 246177 RVA: 0x00E6302F File Offset: 0x00E6122F
		private void OnClickedShopButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Shop);
		}

		// Token: 0x0603C1A2 RID: 246178 RVA: 0x00E63040 File Offset: 0x00E61240
		private UniTask NewPassCheckButton()
		{
			TopPanel.<NewPassCheckButton>d__111 <NewPassCheckButton>d__;
			<NewPassCheckButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewPassCheckButton>d__.<>4__this = this;
			<NewPassCheckButton>d__.<>1__state = -1;
			<NewPassCheckButton>d__.<>t__builder.Start<TopPanel.<NewPassCheckButton>d__111>(ref <NewPassCheckButton>d__);
			return <NewPassCheckButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A3 RID: 246179 RVA: 0x00E63083 File Offset: 0x00E61283
		private void OnClickedPassCheckButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.BattlePass);
		}

		// Token: 0x0603C1A4 RID: 246180 RVA: 0x00E63094 File Offset: 0x00E61294
		private void OnClickedActivityButton()
		{
			ActivityController.Instance.OpenActivityById(0, EActivityViewOpenType.BattleView, null, null);
		}

		// Token: 0x0603C1A5 RID: 246181 RVA: 0x00E630A8 File Offset: 0x00E612A8
		private UniTask NewResonanceButton()
		{
			TopPanel.<NewResonanceButton>d__114 <NewResonanceButton>d__;
			<NewResonanceButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewResonanceButton>d__.<>4__this = this;
			<NewResonanceButton>d__.<>1__state = -1;
			<NewResonanceButton>d__.<>t__builder.Start<TopPanel.<NewResonanceButton>d__114>(ref <NewResonanceButton>d__);
			return <NewResonanceButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A6 RID: 246182 RVA: 0x00E630EB File Offset: 0x00E612EB
		private void OnClickedRoleButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Role);
		}

		// Token: 0x0603C1A7 RID: 246183 RVA: 0x00E630FC File Offset: 0x00E612FC
		private UniTask NewHelpButton()
		{
			TopPanel.<NewHelpButton>d__116 <NewHelpButton>d__;
			<NewHelpButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHelpButton>d__.<>4__this = this;
			<NewHelpButton>d__.<>1__state = -1;
			<NewHelpButton>d__.<>t__builder.Start<TopPanel.<NewHelpButton>d__116>(ref <NewHelpButton>d__);
			return <NewHelpButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A8 RID: 246184 RVA: 0x00E6313F File Offset: 0x00E6133F
		private void OnClickedHelpButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.AdventureGuide);
		}

		// Token: 0x0603C1A9 RID: 246185 RVA: 0x00E63150 File Offset: 0x00E61350
		private UniTask NewMiniMapView()
		{
			TopPanel.<NewMiniMapView>d__118 <NewMiniMapView>d__;
			<NewMiniMapView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMiniMapView>d__.<>4__this = this;
			<NewMiniMapView>d__.<>1__state = -1;
			<NewMiniMapView>d__.<>t__builder.Start<TopPanel.<NewMiniMapView>d__118>(ref <NewMiniMapView>d__);
			return <NewMiniMapView>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1AA RID: 246186 RVA: 0x00E63194 File Offset: 0x00E61394
		private UniTask NewSilentAreaInfo()
		{
			TopPanel.<NewSilentAreaInfo>d__119 <NewSilentAreaInfo>d__;
			<NewSilentAreaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSilentAreaInfo>d__.<>4__this = this;
			<NewSilentAreaInfo>d__.<>1__state = -1;
			<NewSilentAreaInfo>d__.<>t__builder.Start<TopPanel.<NewSilentAreaInfo>d__119>(ref <NewSilentAreaInfo>d__);
			return <NewSilentAreaInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1AB RID: 246187 RVA: 0x00E631D8 File Offset: 0x00E613D8
		private UniTask NewShipTowerBuffInfo()
		{
			TopPanel.<NewShipTowerBuffInfo>d__120 <NewShipTowerBuffInfo>d__;
			<NewShipTowerBuffInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewShipTowerBuffInfo>d__.<>4__this = this;
			<NewShipTowerBuffInfo>d__.<>1__state = -1;
			<NewShipTowerBuffInfo>d__.<>t__builder.Start<TopPanel.<NewShipTowerBuffInfo>d__120>(ref <NewShipTowerBuffInfo>d__);
			return <NewShipTowerBuffInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1AC RID: 246188 RVA: 0x00E6321C File Offset: 0x00E6141C
		private UniTask NewMoraleBuffInfo()
		{
			TopPanel.<NewMoraleBuffInfo>d__121 <NewMoraleBuffInfo>d__;
			<NewMoraleBuffInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleBuffInfo>d__.<>4__this = this;
			<NewMoraleBuffInfo>d__.<>1__state = -1;
			<NewMoraleBuffInfo>d__.<>t__builder.Start<TopPanel.<NewMoraleBuffInfo>d__121>(ref <NewMoraleBuffInfo>d__);
			return <NewMoraleBuffInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1AD RID: 246189 RVA: 0x00E63260 File Offset: 0x00E61460
		private UniTask NewBabelTowerBattleTopPanel()
		{
			TopPanel.<NewBabelTowerBattleTopPanel>d__122 <NewBabelTowerBattleTopPanel>d__;
			<NewBabelTowerBattleTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBabelTowerBattleTopPanel>d__.<>4__this = this;
			<NewBabelTowerBattleTopPanel>d__.<>1__state = -1;
			<NewBabelTowerBattleTopPanel>d__.<>t__builder.Start<TopPanel.<NewBabelTowerBattleTopPanel>d__122>(ref <NewBabelTowerBattleTopPanel>d__);
			return <NewBabelTowerBattleTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1AE RID: 246190 RVA: 0x00E632A4 File Offset: 0x00E614A4
		private UniTask NewResDownLoadItemTopPanel()
		{
			TopPanel.<NewResDownLoadItemTopPanel>d__123 <NewResDownLoadItemTopPanel>d__;
			<NewResDownLoadItemTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewResDownLoadItemTopPanel>d__.<>4__this = this;
			<NewResDownLoadItemTopPanel>d__.<>1__state = -1;
			<NewResDownLoadItemTopPanel>d__.<>t__builder.Start<TopPanel.<NewResDownLoadItemTopPanel>d__123>(ref <NewResDownLoadItemTopPanel>d__);
			return <NewResDownLoadItemTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1AF RID: 246191 RVA: 0x00E632E8 File Offset: 0x00E614E8
		private UniTask NewMowingRiskInfo()
		{
			TopPanel.<NewMowingRiskInfo>d__124 <NewMowingRiskInfo>d__;
			<NewMowingRiskInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMowingRiskInfo>d__.<>4__this = this;
			<NewMowingRiskInfo>d__.<>1__state = -1;
			<NewMowingRiskInfo>d__.<>t__builder.Start<TopPanel.<NewMowingRiskInfo>d__124>(ref <NewMowingRiskInfo>d__);
			return <NewMowingRiskInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B0 RID: 246192 RVA: 0x00E6332C File Offset: 0x00E6152C
		private UniTask NewTowerGuideButton()
		{
			TopPanel.<NewTowerGuideButton>d__125 <NewTowerGuideButton>d__;
			<NewTowerGuideButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewTowerGuideButton>d__.<>4__this = this;
			<NewTowerGuideButton>d__.<>1__state = -1;
			<NewTowerGuideButton>d__.<>t__builder.Start<TopPanel.<NewTowerGuideButton>d__125>(ref <NewTowerGuideButton>d__);
			return <NewTowerGuideButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B1 RID: 246193 RVA: 0x00E63370 File Offset: 0x00E61570
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleEntranceRoleButton> NewEntranceRoleButton(UUIItem uiItem, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			TopPanel.<NewEntranceRoleButton>d__126 <NewEntranceRoleButton>d__;
			<NewEntranceRoleButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleEntranceRoleButton>.Create();
			<NewEntranceRoleButton>d__.<>4__this = this;
			<NewEntranceRoleButton>d__.uiItem = uiItem;
			<NewEntranceRoleButton>d__.redDotName = redDotName;
			<NewEntranceRoleButton>d__.functionType = functionType;
			<NewEntranceRoleButton>d__.hideInGamepad = hideInGamepad;
			<NewEntranceRoleButton>d__.hideByRoleConfig = hideByRoleConfig;
			<NewEntranceRoleButton>d__.childType = childType;
			<NewEntranceRoleButton>d__.<>1__state = -1;
			<NewEntranceRoleButton>d__.<>t__builder.Start<TopPanel.<NewEntranceRoleButton>d__126>(ref <NewEntranceRoleButton>d__);
			return <NewEntranceRoleButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B2 RID: 246194 RVA: 0x00E633E8 File Offset: 0x00E615E8
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleEntranceButton> NewBattleEntranceButton(UUIItem uiItem, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			TopPanel.<NewBattleEntranceButton>d__127 <NewBattleEntranceButton>d__;
			<NewBattleEntranceButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleEntranceButton>.Create();
			<NewBattleEntranceButton>d__.<>4__this = this;
			<NewBattleEntranceButton>d__.uiItem = uiItem;
			<NewBattleEntranceButton>d__.redDotName = redDotName;
			<NewBattleEntranceButton>d__.functionType = functionType;
			<NewBattleEntranceButton>d__.hideInGamepad = hideInGamepad;
			<NewBattleEntranceButton>d__.hideByRoleConfig = hideByRoleConfig;
			<NewBattleEntranceButton>d__.childType = childType;
			<NewBattleEntranceButton>d__.<>1__state = -1;
			<NewBattleEntranceButton>d__.<>t__builder.Start<TopPanel.<NewBattleEntranceButton>d__127>(ref <NewBattleEntranceButton>d__);
			return <NewBattleEntranceButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B3 RID: 246195 RVA: 0x00E63460 File Offset: 0x00E61660
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<CommonTopButtonPanel> NewCommonTopButton(UUIItem parent, [Nullable(2)] string iconPath = null, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			TopPanel.<NewCommonTopButton>d__128 <NewCommonTopButton>d__;
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
			<NewCommonTopButton>d__.<>t__builder.Start<TopPanel.<NewCommonTopButton>d__128>(ref <NewCommonTopButton>d__);
			return <NewCommonTopButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B4 RID: 246196 RVA: 0x00E634E0 File Offset: 0x00E616E0
		private UniTask NewQuestButton()
		{
			TopPanel.<NewQuestButton>d__129 <NewQuestButton>d__;
			<NewQuestButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewQuestButton>d__.<>4__this = this;
			<NewQuestButton>d__.<>1__state = -1;
			<NewQuestButton>d__.<>t__builder.Start<TopPanel.<NewQuestButton>d__129>(ref <NewQuestButton>d__);
			return <NewQuestButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B5 RID: 246197 RVA: 0x00E63523 File Offset: 0x00E61723
		private void OnClickedQuestButton()
		{
			if (HonamiStoryUtil.CheckInHonamiStoryAreaDungeon())
			{
				UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, null, null);
		}

		// Token: 0x0603C1B6 RID: 246198 RVA: 0x00E63550 File Offset: 0x00E61750
		private UniTask NewDungeonGuideButton()
		{
			TopPanel.<NewDungeonGuideButton>d__131 <NewDungeonGuideButton>d__;
			<NewDungeonGuideButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDungeonGuideButton>d__.<>4__this = this;
			<NewDungeonGuideButton>d__.<>1__state = -1;
			<NewDungeonGuideButton>d__.<>t__builder.Start<TopPanel.<NewDungeonGuideButton>d__131>(ref <NewDungeonGuideButton>d__);
			return <NewDungeonGuideButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1B7 RID: 246199 RVA: 0x00E63593 File Offset: 0x00E61793
		private static void OnClickedDungeonGuideButton()
		{
			InstanceDungeonGuideController.StartReplayGuide();
		}

		// Token: 0x0603C1B8 RID: 246200 RVA: 0x00E6359A File Offset: 0x00E6179A
		private static void OnClickedTowerGuideButton()
		{
			TowerController.Instance.OpenTowerGuide();
		}

		// Token: 0x0603C1B9 RID: 246201 RVA: 0x00E635A8 File Offset: 0x00E617A8
		private UniTask NewRogueInfoButton()
		{
			TopPanel.<NewRogueInfoButton>d__134 <NewRogueInfoButton>d__;
			<NewRogueInfoButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRogueInfoButton>d__.<>4__this = this;
			<NewRogueInfoButton>d__.<>1__state = -1;
			<NewRogueInfoButton>d__.<>t__builder.Start<TopPanel.<NewRogueInfoButton>d__134>(ref <NewRogueInfoButton>d__);
			return <NewRogueInfoButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1BA RID: 246202 RVA: 0x00E635EC File Offset: 0x00E617EC
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

		// Token: 0x0603C1BB RID: 246203 RVA: 0x00E63643 File Offset: 0x00E61843
		private bool RogueInfoButtonVisible()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x0603C1BC RID: 246204 RVA: 0x00E63660 File Offset: 0x00E61860
		private UniTask NewSettingButton()
		{
			TopPanel.<NewSettingButton>d__137 <NewSettingButton>d__;
			<NewSettingButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSettingButton>d__.<>4__this = this;
			<NewSettingButton>d__.<>1__state = -1;
			<NewSettingButton>d__.<>t__builder.Start<TopPanel.<NewSettingButton>d__137>(ref <NewSettingButton>d__);
			return <NewSettingButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1BD RID: 246205 RVA: 0x00E636A3 File Offset: 0x00E618A3
		private void OnClickSettingButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Menu);
		}

		// Token: 0x0603C1BE RID: 246206 RVA: 0x00E636B4 File Offset: 0x00E618B4
		private UniTask NewIosSettingButton()
		{
			TopPanel.<NewIosSettingButton>d__139 <NewIosSettingButton>d__;
			<NewIosSettingButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewIosSettingButton>d__.<>4__this = this;
			<NewIosSettingButton>d__.<>1__state = -1;
			<NewIosSettingButton>d__.<>t__builder.Start<TopPanel.<NewIosSettingButton>d__139>(ref <NewIosSettingButton>d__);
			return <NewIosSettingButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1BF RID: 246207 RVA: 0x00E636F7 File Offset: 0x00E618F7
		private bool SettingButtonVisible()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() && !WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x0603C1C0 RID: 246208 RVA: 0x00E63714 File Offset: 0x00E61914
		private UniTask NewFightTeamButton()
		{
			TopPanel.<NewFightTeamButton>d__141 <NewFightTeamButton>d__;
			<NewFightTeamButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFightTeamButton>d__.<>4__this = this;
			<NewFightTeamButton>d__.<>1__state = -1;
			<NewFightTeamButton>d__.<>t__builder.Start<TopPanel.<NewFightTeamButton>d__141>(ref <NewFightTeamButton>d__);
			return <NewFightTeamButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1C1 RID: 246209 RVA: 0x00E63757 File Offset: 0x00E61957
		private void OnClickedFightTeamButton()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.FormatTeam);
		}

		// Token: 0x0603C1C2 RID: 246210 RVA: 0x00E63768 File Offset: 0x00E61968
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

		// Token: 0x0603C1C3 RID: 246211 RVA: 0x00E63804 File Offset: 0x00E61A04
		private UniTask NewDirectTrainProButton()
		{
			TopPanel.<NewDirectTrainProButton>d__144 <NewDirectTrainProButton>d__;
			<NewDirectTrainProButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDirectTrainProButton>d__.<>4__this = this;
			<NewDirectTrainProButton>d__.<>1__state = -1;
			<NewDirectTrainProButton>d__.<>t__builder.Start<TopPanel.<NewDirectTrainProButton>d__144>(ref <NewDirectTrainProButton>d__);
			return <NewDirectTrainProButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1C4 RID: 246212 RVA: 0x00E63847 File Offset: 0x00E61A47
		private void OnClickedDirectTrainProButton()
		{
			ActivityDirectTrainHelper.TryOpenPro(false).Forget();
		}

		// Token: 0x0603C1C5 RID: 246213 RVA: 0x00E63854 File Offset: 0x00E61A54
		private bool DirectTrainProButtonHide()
		{
			return !ActivityDirectTrainHelper.IsProOpen || !ActivityDirectTrainHelper.IsInValidInstance;
		}

		// Token: 0x0603C1C6 RID: 246214 RVA: 0x00E63867 File Offset: 0x00E61A67
		private void OnActivityDirectTrainProSetActive(bool active)
		{
			BattleEntranceButton directTrainProButton = this.DirectTrainProButton;
			if (directTrainProButton == null)
			{
				return;
			}
			directTrainProButton.SetOtherHide(!active);
		}

		// Token: 0x0603C1C7 RID: 246215 RVA: 0x00E63880 File Offset: 0x00E61A80
		private UniTask NewMoraleSumButton()
		{
			TopPanel.<NewMoraleSumButton>d__148 <NewMoraleSumButton>d__;
			<NewMoraleSumButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleSumButton>d__.<>4__this = this;
			<NewMoraleSumButton>d__.<>1__state = -1;
			<NewMoraleSumButton>d__.<>t__builder.Start<TopPanel.<NewMoraleSumButton>d__148>(ref <NewMoraleSumButton>d__);
			return <NewMoraleSumButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1C8 RID: 246216 RVA: 0x00E638C3 File Offset: 0x00E61AC3
		private void OnClickedMoraleSumButton()
		{
			if (MoraleModel.Instance.IsInitData)
			{
				UiManager.Instance.OpenView(EUiViewName.MoraleAreaSumView, null, null);
			}
		}

		// Token: 0x0603C1C9 RID: 246217 RVA: 0x00E638E2 File Offset: 0x00E61AE2
		private bool MoraleSumButtonHide()
		{
			return !MoraleBattleModel.Instance.IsMoraleActive();
		}

		// Token: 0x0603C1CA RID: 246218 RVA: 0x00E638F4 File Offset: 0x00E61AF4
		private UniTask NewWavePlateTip()
		{
			TopPanel.<NewWavePlateTip>d__151 <NewWavePlateTip>d__;
			<NewWavePlateTip>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewWavePlateTip>d__.<>4__this = this;
			<NewWavePlateTip>d__.<>1__state = -1;
			<NewWavePlateTip>d__.<>t__builder.Start<TopPanel.<NewWavePlateTip>d__151>(ref <NewWavePlateTip>d__);
			return <NewWavePlateTip>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1CB RID: 246219 RVA: 0x00E63938 File Offset: 0x00E61B38
		private UniTask NewWavePlateTipGamepad()
		{
			TopPanel.<NewWavePlateTipGamepad>d__152 <NewWavePlateTipGamepad>d__;
			<NewWavePlateTipGamepad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewWavePlateTipGamepad>d__.<>4__this = this;
			<NewWavePlateTipGamepad>d__.<>1__state = -1;
			<NewWavePlateTipGamepad>d__.<>t__builder.Start<TopPanel.<NewWavePlateTipGamepad>d__152>(ref <NewWavePlateTipGamepad>d__);
			return <NewWavePlateTipGamepad>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1CC RID: 246220 RVA: 0x00E6397C File Offset: 0x00E61B7C
		private UniTask NewAlertAreaInfo()
		{
			TopPanel.<NewAlertAreaInfo>d__153 <NewAlertAreaInfo>d__;
			<NewAlertAreaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAlertAreaInfo>d__.<>4__this = this;
			<NewAlertAreaInfo>d__.<>1__state = -1;
			<NewAlertAreaInfo>d__.<>t__builder.Start<TopPanel.<NewAlertAreaInfo>d__153>(ref <NewAlertAreaInfo>d__);
			return <NewAlertAreaInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1CD RID: 246221 RVA: 0x00E639C0 File Offset: 0x00E61BC0
		private UniTask NewRewardList()
		{
			TopPanel.<NewRewardList>d__154 <NewRewardList>d__;
			<NewRewardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRewardList>d__.<>4__this = this;
			<NewRewardList>d__.<>1__state = -1;
			<NewRewardList>d__.<>t__builder.Start<TopPanel.<NewRewardList>d__154>(ref <NewRewardList>d__);
			return <NewRewardList>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1CE RID: 246222 RVA: 0x00E63A04 File Offset: 0x00E61C04
		private UniTask NewGamepadTopPanel()
		{
			TopPanel.<NewGamepadTopPanel>d__155 <NewGamepadTopPanel>d__;
			<NewGamepadTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewGamepadTopPanel>d__.<>4__this = this;
			<NewGamepadTopPanel>d__.<>1__state = -1;
			<NewGamepadTopPanel>d__.<>t__builder.Start<TopPanel.<NewGamepadTopPanel>d__155>(ref <NewGamepadTopPanel>d__);
			return <NewGamepadTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1CF RID: 246223 RVA: 0x00E63A48 File Offset: 0x00E61C48
		private UniTask NewFishingView()
		{
			TopPanel.<NewFishingView>d__156 <NewFishingView>d__;
			<NewFishingView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFishingView>d__.<>4__this = this;
			<NewFishingView>d__.<>1__state = -1;
			<NewFishingView>d__.<>t__builder.Start<TopPanel.<NewFishingView>d__156>(ref <NewFishingView>d__);
			return <NewFishingView>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1D0 RID: 246224 RVA: 0x00E63A8C File Offset: 0x00E61C8C
		private UniTask NewMoraleExpView()
		{
			TopPanel.<NewMoraleExpView>d__157 <NewMoraleExpView>d__;
			<NewMoraleExpView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleExpView>d__.<>4__this = this;
			<NewMoraleExpView>d__.<>1__state = -1;
			<NewMoraleExpView>d__.<>t__builder.Start<TopPanel.<NewMoraleExpView>d__157>(ref <NewMoraleExpView>d__);
			return <NewMoraleExpView>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1D1 RID: 246225 RVA: 0x00E63AD0 File Offset: 0x00E61CD0
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

		// Token: 0x0603C1D2 RID: 246226 RVA: 0x00E63B2A File Offset: 0x00E61D2A
		private void ResDownLoadStateRefresh()
		{
			this.RefreshResDownLoadTopPanelState();
		}

		// Token: 0x0603C1D3 RID: 246227 RVA: 0x00E63B34 File Offset: 0x00E61D34
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

		// Token: 0x0603C1D4 RID: 246228 RVA: 0x00E63D38 File Offset: 0x00E61F38
		private UniTask NewHonamiStoryItems()
		{
			TopPanel.<NewHonamiStoryItems>d__161 <NewHonamiStoryItems>d__;
			<NewHonamiStoryItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHonamiStoryItems>d__.<>4__this = this;
			<NewHonamiStoryItems>d__.<>1__state = -1;
			<NewHonamiStoryItems>d__.<>t__builder.Start<TopPanel.<NewHonamiStoryItems>d__161>(ref <NewHonamiStoryItems>d__);
			return <NewHonamiStoryItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1D5 RID: 246229 RVA: 0x00E63D7B File Offset: 0x00E61F7B
		private void OnClickHonamiStoryBag()
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.HonamiStoryBackpack);
		}

		// Token: 0x0603C1D6 RID: 246230 RVA: 0x00E63D8C File Offset: 0x00E61F8C
		private bool HonamiStoryBagHide()
		{
			return !HonamiStoryUtil.CheckInHonamiStoryDungeon();
		}

		// Token: 0x0603C1D7 RID: 246231 RVA: 0x00E63D98 File Offset: 0x00E61F98
		private UniTask NewFlagChallengeItems()
		{
			TopPanel.<NewFlagChallengeItems>d__164 <NewFlagChallengeItems>d__;
			<NewFlagChallengeItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFlagChallengeItems>d__.<>4__this = this;
			<NewFlagChallengeItems>d__.<>1__state = -1;
			<NewFlagChallengeItems>d__.<>t__builder.Start<TopPanel.<NewFlagChallengeItems>d__164>(ref <NewFlagChallengeItems>d__);
			return <NewFlagChallengeItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1D8 RID: 246232 RVA: 0x00E63DDC File Offset: 0x00E61FDC
		private UniTask NewFlagChallengePauseButton()
		{
			TopPanel.<NewFlagChallengePauseButton>d__165 <NewFlagChallengePauseButton>d__;
			<NewFlagChallengePauseButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFlagChallengePauseButton>d__.<>4__this = this;
			<NewFlagChallengePauseButton>d__.<>1__state = -1;
			<NewFlagChallengePauseButton>d__.<>t__builder.Start<TopPanel.<NewFlagChallengePauseButton>d__165>(ref <NewFlagChallengePauseButton>d__);
			return <NewFlagChallengePauseButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1D9 RID: 246233 RVA: 0x00E63E20 File Offset: 0x00E62020
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

		// Token: 0x0603C1DA RID: 246234 RVA: 0x00E63E9C File Offset: 0x00E6209C
		private void OnClickedFlagChallengeBuffButton()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(FlagChallengeBattleModel.Instance.ActivityId, null);
		}

		// Token: 0x0603C1DB RID: 246235 RVA: 0x00E63EC6 File Offset: 0x00E620C6
		private void OnClickedFlagChallengePauseButton()
		{
			FlagChallengeBattleController.Instance.OpenPauseView();
		}

		// Token: 0x0603C1DC RID: 246236 RVA: 0x00E63ED2 File Offset: 0x00E620D2
		private bool FlagChallengeButtonHide()
		{
			return !FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
		}

		// Token: 0x0603C1DD RID: 246237 RVA: 0x00E63EE1 File Offset: 0x00E620E1
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

		// Token: 0x0603C1DE RID: 246238 RVA: 0x00E63F10 File Offset: 0x00E62110
		private UniTask NewRecallQuestItems()
		{
			TopPanel.<NewRecallQuestItems>d__171 <NewRecallQuestItems>d__;
			<NewRecallQuestItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRecallQuestItems>d__.<>4__this = this;
			<NewRecallQuestItems>d__.<>1__state = -1;
			<NewRecallQuestItems>d__.<>t__builder.Start<TopPanel.<NewRecallQuestItems>d__171>(ref <NewRecallQuestItems>d__);
			return <NewRecallQuestItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1DF RID: 246239 RVA: 0x00E63F54 File Offset: 0x00E62154
		private UniTask NewBossPilingTopPanel()
		{
			TopPanel.<NewBossPilingTopPanel>d__172 <NewBossPilingTopPanel>d__;
			<NewBossPilingTopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBossPilingTopPanel>d__.<>4__this = this;
			<NewBossPilingTopPanel>d__.<>1__state = -1;
			<NewBossPilingTopPanel>d__.<>t__builder.Start<TopPanel.<NewBossPilingTopPanel>d__172>(ref <NewBossPilingTopPanel>d__);
			return <NewBossPilingTopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1E0 RID: 246240 RVA: 0x00E63F98 File Offset: 0x00E62198
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

		// Token: 0x0603C1E1 RID: 246241 RVA: 0x00E64020 File Offset: 0x00E62220
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

		// Token: 0x0603C1E2 RID: 246242 RVA: 0x00E6409A File Offset: 0x00E6229A
		public IPhoneMessageButtonImplement GetPhoneMsgButton()
		{
			if (Info.Instance.IsInGamepad())
			{
				return this.GamepadTopPanel.GetPhoneMsgButton();
			}
			return this.PhoneMsgButton;
		}

		// Token: 0x0401F55C RID: 128348
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]TopPanelTick", "", "");

		// Token: 0x0401F55D RID: 128349
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly EBattleUiChild[] BattleUiChildren = new EBattleUiChild[]
		{
			EBattleUiChild.MiniMap,
			EBattleUiChild.TopButton,
			EBattleUiChild.HomeButton,
			EBattleUiChild.ExitButton
		};

		// Token: 0x0401F55E RID: 128350
		private MiniMapView MiniMapView;

		// Token: 0x0401F55F RID: 128351
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BattleEntranceButton> ButtonList;

		// Token: 0x0401F560 RID: 128352
		private BattleEntranceButton ExitButton;

		// Token: 0x0401F561 RID: 128353
		private BattleEntranceButton HomeButton;

		// Token: 0x0401F562 RID: 128354
		private BattleEntranceButton ActivityButton;

		// Token: 0x0401F563 RID: 128355
		private BattleEntranceButton DirectTrainProButton;

		// Token: 0x0401F564 RID: 128356
		private BattleEntranceButton MoraleBuffSumButton;

		// Token: 0x0401F565 RID: 128357
		private BattleOnlineButton OnlineButton;

		// Token: 0x0401F566 RID: 128358
		private BattlePhoneMessageButton PhoneMsgButton;

		// Token: 0x0401F567 RID: 128359
		private BattleQuestButton QuestButton;

		// Token: 0x0401F568 RID: 128360
		private BattleDungeonGuideButton DungeonGuideButton;

		// Token: 0x0401F569 RID: 128361
		private BattleEntranceButton RogueInfoButton;

		// Token: 0x0401F56A RID: 128362
		private BattleFormationButton FightTeamButton;

		// Token: 0x0401F56B RID: 128363
		private SilentAreaView SilentAreaView;

		// Token: 0x0401F56C RID: 128364
		private ShipTowerBuffBattleView ShipTowerBuffView;

		// Token: 0x0401F56D RID: 128365
		private MoraleBuffBattleView MoraleBuffView;

		// Token: 0x0401F56E RID: 128366
		private MowingRiskInBattleView MowingRiskView;

		// Token: 0x0401F56F RID: 128367
		private BabelTowerBattleTopPanel BabelTowerBattleTopPanel;

		// Token: 0x0401F570 RID: 128368
		private ResDownLoadTopPanel ResDownLoadItemTopPanel;

		// Token: 0x0401F571 RID: 128369
		private BattleTowerButton TowerGuideButton;

		// Token: 0x0401F572 RID: 128370
		private BattleEntranceButton SettingButton;

		// Token: 0x0401F573 RID: 128371
		private TopPanelWavePlateTip WavePlateTip;

		// Token: 0x0401F574 RID: 128372
		private TopPanelWavePlateTip WavePlateTipGamePad;

		// Token: 0x0401F575 RID: 128373
		private AlertAreaInfoView AlertAreaInfoView;

		// Token: 0x0401F576 RID: 128374
		private RewardListView RewardListView;

		// Token: 0x0401F577 RID: 128375
		private GamepadTopPanel GamepadTopPanel;

		// Token: 0x0401F578 RID: 128376
		private CommonTopButtonPanel HonamiStoryBagButton;

		// Token: 0x0401F579 RID: 128377
		private BattleHonamiStoryLeaveButton HonamiStoryLeaveButton;

		// Token: 0x0401F57A RID: 128378
		private BattleHonamiStoryMapLevelView HonamiStoryMapLevelView;

		// Token: 0x0401F57B RID: 128379
		private BattleHonamiStoryPlayerStateView HonamiStoryPlayerStateView;

		// Token: 0x0401F57C RID: 128380
		private BattleFishingView FishingView;

		// Token: 0x0401F57D RID: 128381
		private MoraleExpView MoraleExpView;

		// Token: 0x0401F57E RID: 128382
		private FlagChallengeExpView FlagChallengeExpView;

		// Token: 0x0401F57F RID: 128383
		private CommonTopButtonPanel FlagChallengeLevelButton;

		// Token: 0x0401F580 RID: 128384
		private CommonTopButtonPanel FlagChallengeBuffButton;

		// Token: 0x0401F581 RID: 128385
		private CommonTopButtonPanel FlagChallengePauseButton;

		// Token: 0x0401F582 RID: 128386
		private BossPilingTopItem BossPilingTopItem;

		// Token: 0x0401F583 RID: 128387
		private RecallTopPanel RecallTopPanel;

		// Token: 0x0401F584 RID: 128388
		private BattleEntranceButton InventoryButton;

		// Token: 0x0401F585 RID: 128389
		private BattleTopPanelHookCenter UiHookCenter;

		// Token: 0x0401F586 RID: 128390
		private bool IsGamepad;

		// Token: 0x0401F587 RID: 128391
		private bool IsGamepadPanelCreated;

		// Token: 0x0401F588 RID: 128392
		private UniTaskCompletionSource GamepadPanelCreatePromise;

		// Token: 0x0200BEEB RID: 48875
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039954 RID: 235860
			MiniMapItem,
			// Token: 0x04039955 RID: 235861
			HomeButtonItem,
			// Token: 0x04039956 RID: 235862
			ExitButtonItem,
			// Token: 0x04039957 RID: 235863
			GachaButtonItem,
			// Token: 0x04039958 RID: 235864
			OnlineButtonItem,
			// Token: 0x04039959 RID: 235865
			ShopButtonItem,
			// Token: 0x0403995A RID: 235866
			InventoryButtonItem,
			// Token: 0x0403995B RID: 235867
			PassCheckButtonItem,
			// Token: 0x0403995C RID: 235868
			RoleButtonItem,
			// Token: 0x0403995D RID: 235869
			HelpButtonItem,
			// Token: 0x0403995E RID: 235870
			ActivityItem,
			// Token: 0x0403995F RID: 235871
			QuestButton,
			// Token: 0x04039960 RID: 235872
			DungeonGuideButton,
			// Token: 0x04039961 RID: 235873
			RogueInfoButton,
			// Token: 0x04039962 RID: 235874
			SilentInfoItem = 15,
			// Token: 0x04039963 RID: 235875
			TowerGuideButton,
			// Token: 0x04039964 RID: 235876
			FightTeamButton,
			// Token: 0x04039965 RID: 235877
			VoiceToggle,
			// Token: 0x04039966 RID: 235878
			SettingButton,
			// Token: 0x04039967 RID: 235879
			TowerDefenseItem,
			// Token: 0x04039968 RID: 235880
			MowingRiskItem,
			// Token: 0x04039969 RID: 235881
			DungeonTutorialButton,
			// Token: 0x0403996A RID: 235882
			WavePlateTipItem,
			// Token: 0x0403996B RID: 235883
			AlertAreaInfoItem,
			// Token: 0x0403996C RID: 235884
			FishingView,
			// Token: 0x0403996D RID: 235885
			ShipTowerBuffItem = 27,
			// Token: 0x0403996E RID: 235886
			BabelTowerStarItem,
			// Token: 0x0403996F RID: 235887
			IosSettingItem,
			// Token: 0x04039970 RID: 235888
			PanelLeftTop,
			// Token: 0x04039971 RID: 235889
			DirectTrainProButtonItem,
			// Token: 0x04039972 RID: 235890
			MapBarItem,
			// Token: 0x04039973 RID: 235891
			MoraleBuffItem,
			// Token: 0x04039974 RID: 235892
			MoraleSumButtonItem,
			// Token: 0x04039975 RID: 235893
			HonamiStoryLeaveItem,
			// Token: 0x04039976 RID: 235894
			PlayerLevelItem,
			// Token: 0x04039977 RID: 235895
			PhoneMsgButtonItem = 38,
			// Token: 0x04039978 RID: 235896
			EntitySequenceButtonRoot,
			// Token: 0x04039979 RID: 235897
			RecallTopPanel,
			// Token: 0x0403997A RID: 235898
			MAX
		}

		// Token: 0x0200BEEC RID: 48876
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x0403997C RID: 235900
			KeyBoardPane = 41,
			// Token: 0x0403997D RID: 235901
			GamepadPanel,
			// Token: 0x0403997E RID: 235902
			WavePlateTipGamepadItem
		}

		// Token: 0x0200BEED RID: 48877
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403997F RID: 235903
			[Nullable(0)]
			public static Action <0>__OnClickedOnlineButton;

			// Token: 0x04039980 RID: 235904
			[Nullable(0)]
			public static Action <1>__OnClickedPhoneMsgButton;

			// Token: 0x04039981 RID: 235905
			[Nullable(0)]
			public static Action <2>__OnClickedTowerGuideButton;

			// Token: 0x04039982 RID: 235906
			[Nullable(0)]
			public static Action <3>__OnClickedDungeonGuideButton;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI;
using CSharpScript.Game.Module.BattleUiSet;
using CSharpScript.Game.Module.PhoneMessage.View;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF8 RID: 23800
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleView : UiTickViewBase
	{
		// Token: 0x0603C44D RID: 246861 RVA: 0x00E6DAE0 File Offset: 0x00E6BCE0
		public BattleView(UiViewInfo viewInfo) : base(viewInfo)
		{
			this.GuideUiItemBuilders.Add("Execution", new TGuideItemBuilder(this.BuilderForExecution));
			this.GuideUiItemBuilders.Add("Skill", new TGuideItemBuilder(this.BuilderForSkill));
			this.GuideUiItemBuilders.Add("Default", new TGuideItemBuilder(this.BuilderForDefault));
			this.GuideUiItemBuilders.Add("Teammate", new TGuideItemBuilder(this.BuilderForTeammate));
			this.GuideUiItemBuilders.Add("FirstIdleRole", new TGuideItemBuilder(this.BuilderForFirstIdleRole));
			this.GuideUiItemBuilders.Add("FishingViewBtn", new TGuideItemBuilder(this.BuilderForFishingView));
			this.GuideUiItemBuilders.Add("DangoViewBtn", new TGuideItemBuilder(this.BuilderForDangoView));
			this.GuideUiItemBuilders.Add("LinkBtn", new TGuideItemBuilder(this.BuilderForLinkBtn));
			this.GuideUiItemBuilders.Add("DangoMissionButton", new TGuideItemBuilder(this.BuilderForMissionDangoPanel));
			this.GuideUiItemBuilders.Add("MoraleTempExp", new TGuideItemBuilder(this.BuilderForMoraleTempExp));
			this.GuideUiItemBuilders.Add("MoraleExp", new TGuideItemBuilder(this.BuilderForMoraleExp));
			this.GuideUiItemBuilders.Add("ScorePanel", new TGuideItemBuilder(this.BuilderForScorePanel));
			this.GuideUiItemBuilders.Add("WeeklyRogueBtn", new TGuideItemBuilder(this.BuilderForWeeklyRogueBtn));
			this.GuideUiItemBuilders.Add("TimeDilationBtn", new TGuideItemBuilder(this.BuilderForTimeDilationBtn));
			this.GuideUiItemBuilders.Add("HonamiStoryPlayerLevel", new TGuideItemBuilder(this.BuilderForHonamiStoryPlayerLevel));
			this.GuideUiItemBuilders.Add("HonamiStoryMapLevel", new TGuideItemBuilder(this.BuilderForHonamiStoryMapLevel));
			this.GuideUiItemBuilders.Add("HonamiStoryLeaveBtn", new TGuideItemBuilder(this.BuilderForHonamiStoryLeaveBtn));
			this.GuideUiItemBuilders.Add("MotorMobile", new TGuideItemBuilder(this.BuilderForMotorMobile));
			this.GuideUiItemBuilders.Add("FlagChallengeBuff", new TGuideItemBuilder(this.BuilderForTopPanel));
			this.GuideUiItemBuilders.Add("FlagChallengePause", new TGuideItemBuilder(this.BuilderForTopPanel));
			this.GuideUiItemBuilders.Add("FlagChallengeMapBar", new TGuideItemBuilder(this.BuilderForTopPanel));
			this.GuideUiItemBuilders.Add("SkillSprite", new TGuideItemBuilder(this.BuilderForSkillSprite));
			this.GuideUiItemBuilders.Add("SkillTexture", new TGuideItemBuilder(this.BuilderForSkillTexture));
			this.GuideUiItemBuilders.Add("ResDownLoadBtn", new TGuideItemBuilder(this.BuilderForTopPanel));
		}

		// Token: 0x0603C44E RID: 246862 RVA: 0x00E6DDCC File Offset: 0x00E6BFCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
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
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(12, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIItem)));
			}
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnPureModeClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603C44F RID: 246863 RVA: 0x00E6E06C File Offset: 0x00E6C26C
		protected override UniTask OnBeforeStartAsync()
		{
			BattleView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C450 RID: 246864 RVA: 0x00E6E0B0 File Offset: 0x00E6C2B0
		private UniTask NewDangoAbyssInfo()
		{
			BattleView.<NewDangoAbyssInfo>d__26 <NewDangoAbyssInfo>d__;
			<NewDangoAbyssInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDangoAbyssInfo>d__.<>4__this = this;
			<NewDangoAbyssInfo>d__.<>1__state = -1;
			<NewDangoAbyssInfo>d__.<>t__builder.Start<BattleView.<NewDangoAbyssInfo>d__26>(ref <NewDangoAbyssInfo>d__);
			return <NewDangoAbyssInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C451 RID: 246865 RVA: 0x00E6E0F4 File Offset: 0x00E6C2F4
		private void RefreshSpecialViewElement()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (((config != null) ? new int?(config.GetValueOrDefault().WorldDungeonSubType) : null).Value != 1)
			{
				return;
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.Mission, false, true, 0);
			}
			BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
			if (childViewData2 != null)
			{
				childViewData2.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.Formation, false, true, 0);
			}
			BattleUiChildViewData childViewData3 = BattleUiModel.Instance.ChildViewData;
			if (childViewData3 == null)
			{
				return;
			}
			childViewData3.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.GamepadFormation, false, true, 0);
		}

		// Token: 0x0603C452 RID: 246866 RVA: 0x00E6E1B4 File Offset: 0x00E6C3B4
		private UniTask CreateKeyBoardPanel()
		{
			BattleView.<CreateKeyBoardPanel>d__28 <CreateKeyBoardPanel>d__;
			<CreateKeyBoardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateKeyBoardPanel>d__.<>4__this = this;
			<CreateKeyBoardPanel>d__.<>1__state = -1;
			<CreateKeyBoardPanel>d__.<>t__builder.Start<BattleView.<CreateKeyBoardPanel>d__28>(ref <CreateKeyBoardPanel>d__);
			return <CreateKeyBoardPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C453 RID: 246867 RVA: 0x00E6E1F8 File Offset: 0x00E6C3F8
		private UniTask CreateKeyBoardPanelInner()
		{
			BattleView.<CreateKeyBoardPanelInner>d__29 <CreateKeyBoardPanelInner>d__;
			<CreateKeyBoardPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateKeyBoardPanelInner>d__.<>4__this = this;
			<CreateKeyBoardPanelInner>d__.<>1__state = -1;
			<CreateKeyBoardPanelInner>d__.<>t__builder.Start<BattleView.<CreateKeyBoardPanelInner>d__29>(ref <CreateKeyBoardPanelInner>d__);
			return <CreateKeyBoardPanelInner>d__.<>t__builder.Task;
		}

		// Token: 0x0603C454 RID: 246868 RVA: 0x00E6E23C File Offset: 0x00E6C43C
		private UniTask CreateGamepadPanel()
		{
			BattleView.<CreateGamepadPanel>d__30 <CreateGamepadPanel>d__;
			<CreateGamepadPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanel>d__.<>4__this = this;
			<CreateGamepadPanel>d__.<>1__state = -1;
			<CreateGamepadPanel>d__.<>t__builder.Start<BattleView.<CreateGamepadPanel>d__30>(ref <CreateGamepadPanel>d__);
			return <CreateGamepadPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C455 RID: 246869 RVA: 0x00E6E280 File Offset: 0x00E6C480
		private UniTask CreateGamepadPanelInner()
		{
			BattleView.<CreateGamepadPanelInner>d__31 <CreateGamepadPanelInner>d__;
			<CreateGamepadPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanelInner>d__.<>4__this = this;
			<CreateGamepadPanelInner>d__.<>1__state = -1;
			<CreateGamepadPanelInner>d__.<>t__builder.Start<BattleView.<CreateGamepadPanelInner>d__31>(ref <CreateGamepadPanelInner>d__);
			return <CreateGamepadPanelInner>d__.<>t__builder.Task;
		}

		// Token: 0x0603C456 RID: 246870 RVA: 0x00E6E2C4 File Offset: 0x00E6C4C4
		protected override void OnTick(float delta)
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.TickPanelList)
			{
				if (battleChildViewPanel.GetVisible())
				{
					battleChildViewPanel.OnTickBattleChildViewPanel(delta);
				}
			}
			this.Proxy.HeadStatePanel.Tick(delta);
			this.PartStatePanel.Tick(delta);
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle == null)
			{
				return;
			}
			formationUnitNodeHandle.Tick(delta);
		}

		// Token: 0x0603C457 RID: 246871 RVA: 0x00E6E350 File Offset: 0x00E6C550
		protected override void OnAfterTick(float delta)
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.TickPanelList)
			{
				if (battleChildViewPanel.GetVisible())
				{
					battleChildViewPanel.OnAfterTickBattleChildViewPanel(delta);
				}
			}
		}

		// Token: 0x0603C458 RID: 246872 RVA: 0x00E6E3AC File Offset: 0x00E6C5AC
		protected override void OnBeforeShow()
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.RefreshPureModeBeforeShow();
			this.RefreshMobileUiSet();
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				if (this.GetChildPanelOverrideSwitch(battleChildViewPanel))
				{
					battleChildViewPanel.ShowBattleChildViewPanel();
				}
				else
				{
					battleChildViewPanel.HideBattleChildViewPanel();
				}
			}
			this.RefreshSpecialViewElement();
		}

		// Token: 0x0603C459 RID: 246873 RVA: 0x00E6E430 File Offset: 0x00E6C630
		protected override void OnAfterShow()
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.RefreshPureModeAfterShow();
			BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.BattleView);
			BattleUiModel instance = BattleUiModel.Instance;
			instance.TryBroadcastCacheRoleLevelUpData();
			instance.TryBroadcastCacheRevive();
			EventSystem.Instance.Emit(EEventName.BattleViewActiveSequenceFinish);
			EventSystem.Instance.Emit(EEventName.ActiveBattleView);
			EventSystem.Instance.Emit(EEventName.RedDotStart);
		}

		// Token: 0x0603C45A RID: 246874 RVA: 0x00E6E49C File Offset: 0x00E6C69C
		protected override void OnBeforeHide()
		{
			this.RefreshPureModeBeforeHide();
			BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.BattleView);
			EventSystem.Instance.Emit(EEventName.DisActiveBattleView);
		}

		// Token: 0x0603C45B RID: 246875 RVA: 0x00E6E4C4 File Offset: 0x00E6C6C4
		protected override void OnAfterHide()
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.HideBattleChildViewPanel();
			}
		}

		// Token: 0x0603C45C RID: 246876 RVA: 0x00E6E51C File Offset: 0x00E6C71C
		[NullableContext(2)]
		public UUIItem GetDynamicUIRootItem(EBattleViewChildType childType)
		{
			BattleView.EChildType name;
			if (!BattleView.BattleViewChildMap.TryGetValue(childType, out name))
			{
				return null;
			}
			return base.GetItem((int)name);
		}

		// Token: 0x0603C45D RID: 246877 RVA: 0x00E6E544 File Offset: 0x00E6C744
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.ResetAllChildViewPanels();
			this.ResetSceneItemDurabilityPanel();
			this.ResetBattleHeadStatePanel();
			this.ResetPartStatePanel();
			this.ResetFormationCooldownExternal();
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle != null)
			{
				formationUnitNodeHandle.Destroy();
			}
			this.FormationUnitNodeHandle = null;
			BattleViewDynamicUIController.Instance.UnregisterBattleView(this);
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				this.CheckDestroyTimer = TimerSystem.Instance.Forever(delegate(float _)
				{
					if (GameModeModel.Instance.WorldDone)
					{
						TimerSystem.Instance.Remove(this.CheckDestroyTimer);
						this.CheckDestroyTimer = null;
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "[battleView]主界面销毁超时，请将本次日志提交给测试", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}, 5000f, 1f, null, null, true);
			}
		}

		// Token: 0x0603C45E RID: 246878 RVA: 0x00E6E5CD File Offset: 0x00E6C7CD
		protected override void OnAfterDestroy()
		{
			if (this.CheckDestroyTimer != null)
			{
				TimerSystem.Instance.Remove(this.CheckDestroyTimer);
				this.CheckDestroyTimer = null;
			}
		}

		// Token: 0x0603C45F RID: 246879 RVA: 0x00E6E5F0 File Offset: 0x00E6C7F0
		private void AddEvents()
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnRefreshFormationCallback));
			EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnAllRoleDataChanged));
			EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnCreateEntity));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Add(EEventName.GmOnlyShowMiniMap, new Action<bool>(this.OnGmOnlyShowMiniMap));
			EventSystem.Instance.Add(EEventName.GmOnlyShowJoyStick, new Action<bool>(this.OnGmOnlyShowJoyStick));
			EventSystem.Instance.Add(EEventName.GmHideMissionAndBossName, new Action<bool>(this.OnGmHideMission));
			EventSystem.Instance.Add(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
			EventSystem.Instance.Add<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, new Action<int, int, float?, float?>(this.OnRefreshFormationCooldownExternal));
			EventSystem.Instance.Add(EEventName.SeamlessTravelFinishBeforeShowUI, new Action(this.OnSeamlessTravelFinish));
			EventSystem.Instance.Add<string>(EEventName.BattleUiPlayAudio, new Action<string>(this.OnBattleUiPlayAudio));
			EventSystem.Instance.Add<float>(EEventName.BattleUiAlphaChanged, new Action<float>(this.OnBattleUiAlphaChanged));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiPureModeChanged, new Action<bool>(this.OnBattleUiPureModeChanged));
			EventSystem.Instance.Add<int, bool, int?, int?, string>(EEventName.OnEnableSceneItemDurabilityUI, new Action<int, bool, int?, int?, string>(this.OnEnableSceneItemDurabilityUI));
			InputDistributeController.Instance.BindAction("退出精简模式", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputClosePureModeAction));
			InputDistributeController.Instance.BindAction("退出精简模式PC触摸板", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputClosePureModeAction));
			if (!Info.Instance.IsInTouch())
			{
				EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			}
		}

		// Token: 0x0603C460 RID: 246880 RVA: 0x00E6E800 File Offset: 0x00E6CA00
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnRefreshFormationCallback));
			EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnAllRoleDataChanged));
			EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnCreateEntity));
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Remove(EEventName.GmOnlyShowMiniMap, new Action<bool>(this.OnGmOnlyShowMiniMap));
			EventSystem.Instance.Remove(EEventName.GmOnlyShowJoyStick, new Action<bool>(this.OnGmOnlyShowJoyStick));
			EventSystem.Instance.Remove(EEventName.GmHideMissionAndBossName, new Action<bool>(this.OnGmHideMission));
			EventSystem.Instance.Remove(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
			EventSystem.Instance.Remove(EEventName.OnRefreshFormationCooldownExternalInBattleView, new <>f__AnonymousDelegate5<int, int, float?, float?>(this.OnRefreshFormationCooldownExternal));
			EventSystem.Instance.Remove(EEventName.SeamlessTravelFinishBeforeShowUI, new Action(this.OnSeamlessTravelFinish));
			EventSystem.Instance.Remove(EEventName.BattleUiPlayAudio, new Action<string>(this.OnBattleUiPlayAudio));
			EventSystem.Instance.Remove(EEventName.BattleUiAlphaChanged, new Action<float>(this.OnBattleUiAlphaChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiPureModeChanged, new Action<bool>(this.OnBattleUiPureModeChanged));
			EventSystem.Instance.Remove(EEventName.OnEnableSceneItemDurabilityUI, new Action<int, bool, int?, int?, string>(this.OnEnableSceneItemDurabilityUI));
			InputDistributeController.Instance.UnBindAction("退出精简模式", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputClosePureModeAction));
			InputDistributeController.Instance.UnBindAction("退出精简模式PC触摸板", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputClosePureModeAction));
			if (EventSystem.Instance.Has(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange)))
			{
				EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			}
		}

		// Token: 0x0603C461 RID: 246881 RVA: 0x00E6EA20 File Offset: 0x00E6CC20
		private void OnRefreshFormationCallback()
		{
			this.Proxy.HeadStatePanel.RefreshCurrentRole();
		}

		// Token: 0x0603C462 RID: 246882 RVA: 0x00E6EA34 File Offset: 0x00E6CC34
		private void OnAllRoleDataChanged()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null && curRoleData.RoleConfig != null)
			{
				this.PlayFormationSwitchAnim(curRoleData.RoleConfig.Value.RoleType == 2);
			}
		}

		// Token: 0x0603C463 RID: 246883 RVA: 0x00E6EA78 File Offset: 0x00E6CC78
		private void PlayFormationSwitchAnim(bool isPhantom)
		{
			if (this.IsPhantom == isPhantom)
			{
				return;
			}
			this.IsPhantom = isPhantom;
			if (base.IsShow && !this.IsPureModeOpen)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlaySequencePurely("Switch", false, false);
			}
		}

		// Token: 0x0603C464 RID: 246884 RVA: 0x00E6EAB2 File Offset: 0x00E6CCB2
		private void OnPureModeClicked()
		{
			BattleUiControl.Instance.TryClosePureMode();
		}

		// Token: 0x0603C465 RID: 246885 RVA: 0x00E6EABF File Offset: 0x00E6CCBF
		private void OnChangeRoleCompleted(EntityHandle newHandle, [Nullable(2)] EntityHandle oldHandle)
		{
			this.Proxy.HeadStatePanel.RefreshCurrentRole();
		}

		// Token: 0x0603C466 RID: 246886 RVA: 0x00E6EAD1 File Offset: 0x00E6CCD1
		[NullableContext(2)]
		private void OnStartSequenceStart(string _ = null)
		{
			if (base.IsShow)
			{
				this.SetActive(true);
			}
		}

		// Token: 0x0603C467 RID: 246887 RVA: 0x00E6EAE4 File Offset: 0x00E6CCE4
		private void OnCreateEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
		{
			if (!handle.Valid)
			{
				return;
			}
			this.Proxy.HeadStatePanel.OnCreateEntity(handle.Entity);
			this.PartStatePanel.OnCreateEntity(handle.Entity);
			BossStatePanel bossStatePanel = this.BossStatePanel;
			if (bossStatePanel == null)
			{
				return;
			}
			bossStatePanel.OnCreateEntity(handle);
		}

		// Token: 0x0603C468 RID: 246888 RVA: 0x00E6EB32 File Offset: 0x00E6CD32
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (!handle.Valid)
			{
				return;
			}
			this.Proxy.HeadStatePanel.OnRemoveEntity(handle.Entity);
			this.PartStatePanel.DestroyPartStateFromRole(handle.Entity);
		}

		// Token: 0x0603C469 RID: 246889 RVA: 0x00E6EB64 File Offset: 0x00E6CD64
		private UniTask PreloadBattleHeadStatePanel()
		{
			BattleView.<PreloadBattleHeadStatePanel>d__52 <PreloadBattleHeadStatePanel>d__;
			<PreloadBattleHeadStatePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadBattleHeadStatePanel>d__.<>4__this = this;
			<PreloadBattleHeadStatePanel>d__.<>1__state = -1;
			<PreloadBattleHeadStatePanel>d__.<>t__builder.Start<BattleView.<PreloadBattleHeadStatePanel>d__52>(ref <PreloadBattleHeadStatePanel>d__);
			return <PreloadBattleHeadStatePanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C46A RID: 246890 RVA: 0x00E6EBA7 File Offset: 0x00E6CDA7
		private void InitializeBattleHeadStatePanel()
		{
			BattleHeadStatePanel headStatePanel = this.Proxy.HeadStatePanel;
			if (headStatePanel == null)
			{
				return;
			}
			headStatePanel.Init();
		}

		// Token: 0x0603C46B RID: 246891 RVA: 0x00E6EBBE File Offset: 0x00E6CDBE
		private void ResetBattleHeadStatePanel()
		{
			if (this.Proxy.HeadStatePanel == null)
			{
				return;
			}
			this.Proxy.HeadStatePanel.ResetAllHeadStates();
			this.Proxy.HeadStatePanel = null;
		}

		// Token: 0x0603C46C RID: 246892 RVA: 0x00E6EBEA File Offset: 0x00E6CDEA
		private void InitializePartStatePanel()
		{
			this.PartStatePanel = new PartStatePanel();
			this.PartStatePanel.InitializePartStatePanel();
		}

		// Token: 0x0603C46D RID: 246893 RVA: 0x00E6EC02 File Offset: 0x00E6CE02
		private void ResetPartStatePanel()
		{
			if (this.PartStatePanel == null)
			{
				return;
			}
			this.PartStatePanel.ResetPartStatePanel();
			this.PartStatePanel = null;
		}

		// Token: 0x0603C46E RID: 246894 RVA: 0x00E6EC1F File Offset: 0x00E6CE1F
		private void ResetSceneItemDurabilityPanel()
		{
			if (this.SceneItemDurabilityPanel == null)
			{
				return;
			}
			this.SceneItemDurabilityPanel.Reset();
			this.SceneItemDurabilityPanel = null;
		}

		// Token: 0x0603C46F RID: 246895 RVA: 0x00E6EC3C File Offset: 0x00E6CE3C
		public void ShowLinkButton(bool isShow)
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle == null)
			{
				return;
			}
			formationUnitNodeHandle.ShowLinkButton(isShow);
		}

		// Token: 0x0603C470 RID: 246896 RVA: 0x00E6EC4F File Offset: 0x00E6CE4F
		public void UpdateTimeDilationButton()
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle == null)
			{
				return;
			}
			formationUnitNodeHandle.UpdateTimeDilationButton();
		}

		// Token: 0x0603C471 RID: 246897 RVA: 0x00E6EC64 File Offset: 0x00E6CE64
		public void OffsetMissionAnchor(float y)
		{
			UUIItem item = base.GetItem(1);
			if (this.MissionOriginalY == -1f)
			{
				this.MissionOriginalY = item.GetAnchorOffsetY();
			}
			item.SetAnchorOffsetY((y == -1f) ? this.MissionOriginalY : (this.MissionOriginalY + y));
		}

		// Token: 0x0603C472 RID: 246898 RVA: 0x00E6ECB0 File Offset: 0x00E6CEB0
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<T> NewBattleChildViewPanel<T>(int rootItemIndex, bool bTick = false, EBattleUiChild childType = EBattleUiChild.Common) where T : BattleChildViewPanel, new()
		{
			BattleView.<NewBattleChildViewPanel>d__62<T> <NewBattleChildViewPanel>d__;
			<NewBattleChildViewPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<NewBattleChildViewPanel>d__.<>4__this = this;
			<NewBattleChildViewPanel>d__.rootItemIndex = rootItemIndex;
			<NewBattleChildViewPanel>d__.bTick = bTick;
			<NewBattleChildViewPanel>d__.childType = childType;
			<NewBattleChildViewPanel>d__.<>1__state = -1;
			<NewBattleChildViewPanel>d__.<>t__builder.Start<BattleView.<NewBattleChildViewPanel>d__62<T>>(ref <NewBattleChildViewPanel>d__);
			return <NewBattleChildViewPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603C473 RID: 246899 RVA: 0x00E6ED0B File Offset: 0x00E6CF0B
		[NullableContext(2)]
		private BattleChildViewPanel GetPanel(int index)
		{
			return this.PanelMap.GetValueOrDefault(index);
		}

		// Token: 0x0603C474 RID: 246900 RVA: 0x00E6ED1C File Offset: 0x00E6CF1C
		private void OnRouletteViewVisibleChanged(bool bVisible)
		{
			UUIItem rootItem = this.GetPanel(6).GetRootItem();
			UUIItem rootItem2 = (Info.Instance.IsInTouch() ? this.GetPanel(5) : this.GetPanel(7)).GetRootItem();
			int hierarchyIndex = rootItem.GetHierarchyIndex();
			int hierarchyIndex2 = rootItem2.GetHierarchyIndex();
			if (bVisible && hierarchyIndex2 >= hierarchyIndex)
			{
				this.CenterPanelUiIndex = new int?(hierarchyIndex);
				rootItem.SetHierarchyIndex(hierarchyIndex2);
			}
			else if (this.CenterPanelUiIndex != null)
			{
				rootItem.SetHierarchyIndex(this.CenterPanelUiIndex.Value);
				this.CenterPanelUiIndex = null;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "轮盘界面显隐，调整摇杆面板层级";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bVisible", bVisible);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603C475 RID: 246901 RVA: 0x00E6EDDC File Offset: 0x00E6CFDC
		private void OnSeamlessTravelFinish()
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.OnSeamlessTravelFinish();
			}
		}

		// Token: 0x0603C476 RID: 246902 RVA: 0x00E6EE34 File Offset: 0x00E6D034
		private void OnBattleUiPlayAudio(string audioId)
		{
			AudioSystem.Instance.PostEvent(audioId);
		}

		// Token: 0x0603C477 RID: 246903 RVA: 0x00E6EE42 File Offset: 0x00E6D042
		private void OnBattleUiAlphaChanged(float alpha)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(alpha);
		}

		// Token: 0x0603C478 RID: 246904 RVA: 0x00E6EE55 File Offset: 0x00E6D055
		private void OnBattleUiPureModeChanged(bool _)
		{
			this.RefreshPureMode();
		}

		// Token: 0x0603C479 RID: 246905 RVA: 0x00E6EE60 File Offset: 0x00E6D060
		[NullableContext(2)]
		private void OnEnableSceneItemDurabilityUI(int entityId, bool enable, int? durability, int? maxDurability, string tidName)
		{
			if (this.SceneItemDurabilityPanel != null)
			{
				this.SceneItemDurabilityPanel.OnEnableSceneItemDurabilityUI(entityId, enable, durability, maxDurability, tidName);
				return;
			}
			if (!enable || this.IsLoadingDurabilityPanel)
			{
				return;
			}
			this.IsLoadingDurabilityPanel = true;
			UUIItem item = base.GetItem(0);
			this.SceneItemDurabilityPanel = new SceneItemDurabilityStatePanel();
			this.SceneItemDurabilityPanel.OpenParam = EBattleUiChild.SceneItemDurabilityState;
			this.SceneItemDurabilityPanel.CreateThenShowByResourceIdAsync("UiItem_LevelHpState_Prefab", item, false).ContinueWith(delegate()
			{
				this.IsLoadingDurabilityPanel = false;
				if (this.IsDestroyOrDestroying)
				{
					return;
				}
				this.TickPanelList.Add(this.SceneItemDurabilityPanel);
				this.SceneItemDurabilityPanel.OnEnableSceneItemDurabilityUI(entityId, enable, durability, maxDurability, tidName);
			});
		}

		// Token: 0x0603C47A RID: 246906 RVA: 0x00E6EF32 File Offset: 0x00E6D132
		private void OnInputClosePureModeAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (this.IsPureModeOpen)
			{
				BattleUiControl.Instance.TryClosePureMode();
				return;
			}
			BattleUiControl.Instance.TryOpenPureMode();
		}

		// Token: 0x0603C47B RID: 246907 RVA: 0x00E6EF58 File Offset: 0x00E6D158
		private void RefreshPureMode()
		{
			BattleUiPureModeData pureModeData = BattleUiModel.Instance.PureModeData;
			this.IsPureModeOpen = (pureModeData != null && pureModeData.IsOpen);
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(this.IsPureModeOpen);
			}
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.RefreshPureMode(this.IsPureModeOpen);
			}
			if (!this.IsPureModeOpen)
			{
				UUIItem item2 = base.GetItem(14);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
			}
		}

		// Token: 0x0603C47C RID: 246908 RVA: 0x00E6F004 File Offset: 0x00E6D204
		private void RefreshPureModeBeforeShow()
		{
			if (!this.IsPureModeOpen)
			{
				return;
			}
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603C47D RID: 246909 RVA: 0x00E6F024 File Offset: 0x00E6D224
		private void RefreshPureModeAfterShow()
		{
			if (!this.IsPureModeOpen)
			{
				return;
			}
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.RefreshPureMode(this.IsPureModeOpen);
			}
		}

		// Token: 0x0603C47E RID: 246910 RVA: 0x00E6F09C File Offset: 0x00E6D29C
		private void RefreshPureModeBeforeHide()
		{
			if (!this.IsPureModeOpen)
			{
				return;
			}
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603C47F RID: 246911 RVA: 0x00E6F0BC File Offset: 0x00E6D2BC
		private void ResetAllChildViewPanels()
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.Reset();
			}
			this.PanelMap.Clear();
			this.TickPanelList.Clear();
		}

		// Token: 0x0603C480 RID: 246912 RVA: 0x00E6F128 File Offset: 0x00E6D328
		private unsafe void RefreshMobileUiSet()
		{
			if (!Info.Instance.IsInTouch())
			{
				return;
			}
			foreach (KeyValuePair<int, BattleUiSetPanelData> keyValuePair in BattleUiSetModel.Instance.GetPanelDataMap())
			{
				int num;
				BattleUiSetPanelData battleUiSetPanelData;
				keyValuePair.Deconstruct(out num, out battleUiSetPanelData);
				int num2 = num;
				BattleUiSetPanelData battleUiSetPanelData2 = battleUiSetPanelData;
				BattleChildViewPanel panel = this.GetPanel(num2);
				if (panel != null)
				{
					foreach (KeyValuePair<int, BattleUiSetPanelItemData> keyValuePair2 in battleUiSetPanelData2.GetPanelItemDataMap())
					{
						BattleUiSetPanelItemData battleUiSetPanelItemData;
						keyValuePair2.Deconstruct(out num, out battleUiSetPanelItemData);
						int num3 = num;
						BattleUiSetPanelItemData battleUiSetPanelItemData2 = battleUiSetPanelItemData;
						if (battleUiSetPanelItemData2.IsInitialized())
						{
							UUIItem uuiitem = panel.GetItem(num3);
							if (num3 == -1)
							{
								uuiitem = panel.GetRootItem();
							}
							if (uuiitem == null)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.BattleUiSet;
								ELogAuthor author = ELogAuthor.CFT;
								string message = "刷新移动端主界面设置时，找不到对应按钮";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("panelIndex", num2);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("panelItemIndex", num3);
								instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							}
							else
							{
								float size = battleUiSetPanelItemData2.Size;
								float alpha = battleUiSetPanelItemData2.Alpha;
								float offsetX = battleUiSetPanelItemData2.OffsetX;
								float offsetY = battleUiSetPanelItemData2.OffsetY;
								int hierarchyIndex = battleUiSetPanelItemData2.HierarchyIndex;
								uuiitem.SetUIItemScale(new FVector(size));
								uuiitem.SetAnchorOffsetX(offsetX);
								uuiitem.SetAnchorOffsetY(offsetY);
								uuiitem.SetUIItemAlpha(alpha);
								uuiitem.SetHierarchyIndex(hierarchyIndex);
							}
						}
					}
				}
			}
		}

		// Token: 0x0603C481 RID: 246913 RVA: 0x00E6F300 File Offset: 0x00E6D500
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (!Info.Instance.IsInGamepad())
			{
				if (Info.Instance.IsInKeyBoard())
				{
					if (!this.IsKeyboardPanelCreated)
					{
						this.<InputControllerChange>g__Invoke|77_1().Forget();
						return;
					}
					FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
					if (formationUnitNodeHandle == null)
					{
						return;
					}
					formationUnitNodeHandle.OnInputControllerChange(this.FormationPanel, this.GamepadFormationPanel);
				}
				return;
			}
			if (!this.IsGamepadPanelCreated)
			{
				this.<InputControllerChange>g__Invoke|77_0().Forget();
				return;
			}
			FormationUnitNodeHandle formationUnitNodeHandle2 = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle2 == null)
			{
				return;
			}
			formationUnitNodeHandle2.OnInputControllerChange(this.FormationPanel, this.GamepadFormationPanel);
		}

		// Token: 0x0603C482 RID: 246914 RVA: 0x00E6F388 File Offset: 0x00E6D588
		private void OnGmOnlyShowMiniMap(bool bVisible)
		{
			foreach (KeyValuePair<int, BattleChildViewPanel> keyValuePair in this.PanelMap)
			{
				int num;
				BattleChildViewPanel battleChildViewPanel;
				keyValuePair.Deconstruct(out num, out battleChildViewPanel);
				int num2 = num;
				BattleChildViewPanel battleChildViewPanel2 = battleChildViewPanel;
				if (num2 != 5)
				{
					if (bVisible)
					{
						if (battleChildViewPanel2.GetVisible())
						{
							battleChildViewPanel2.GetRootItem().SetUIActive(true);
						}
					}
					else
					{
						battleChildViewPanel2.GetRootItem().SetUIActive(false);
					}
				}
			}
		}

		// Token: 0x0603C483 RID: 246915 RVA: 0x00E6F40C File Offset: 0x00E6D60C
		private void OnGmOnlyShowJoyStick(bool bVisible)
		{
			foreach (KeyValuePair<int, BattleChildViewPanel> keyValuePair in this.PanelMap)
			{
				int num;
				BattleChildViewPanel battleChildViewPanel;
				keyValuePair.Deconstruct(out num, out battleChildViewPanel);
				int num2 = num;
				BattleChildViewPanel battleChildViewPanel2 = battleChildViewPanel;
				if (num2 != 6)
				{
					if (bVisible)
					{
						if (battleChildViewPanel2.GetVisible())
						{
							battleChildViewPanel2.GetRootItem().SetUIActive(true);
						}
					}
					else
					{
						battleChildViewPanel2.GetRootItem().SetUIActive(false);
					}
				}
			}
		}

		// Token: 0x0603C484 RID: 246916 RVA: 0x00E6F490 File Offset: 0x00E6D690
		private void OnGmHideMission(bool bVisible)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			BattleUiModel.Instance.IsMissionPanelVisible = bVisible;
		}

		// Token: 0x0603C485 RID: 246917 RVA: 0x00E6F4B0 File Offset: 0x00E6D6B0
		private bool GetChildPanelOverrideSwitch(BattleChildViewPanel panel)
		{
			return !panel.IsChildType(EBattleUiChild.Mission) || BattleUiModel.Instance.IsMissionPanelVisible;
		}

		// Token: 0x0603C486 RID: 246918 RVA: 0x00E6F4CC File Offset: 0x00E6D6CC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForExecution(string[] configParams)
		{
			CenterPanel centerPanel = this.PanelMap.GetValueOrDefault(6) as CenterPanel;
			if (centerPanel == null)
			{
				return null;
			}
			UUIItem executionItem = centerPanel.GetExecutionItem();
			if (executionItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				executionItem,
				executionItem
			};
		}

		// Token: 0x0603C487 RID: 246919 RVA: 0x00E6F50A File Offset: 0x00E6D70A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForSkill(string[] configParams)
		{
			BattleSkillItem activeSkillItemForGuide = this.GetActiveSkillItemForGuide(configParams);
			if (activeSkillItemForGuide == null)
			{
				return null;
			}
			return activeSkillItemForGuide.GetGuideItem();
		}

		// Token: 0x0603C488 RID: 246920 RVA: 0x00E6F520 File Offset: 0x00E6D720
		[return: Nullable(2)]
		private BattleSkillItem GetActiveSkillItemForGuide(string[] configParams)
		{
			int buttonType = int.Parse(configParams[1]);
			if (Info.Instance.IsInGamepad())
			{
				GamepadSkillButtonPanel gamepadSkillButtonPanel = this.PanelMap.GetValueOrDefault(13) as GamepadSkillButtonPanel;
				if (gamepadSkillButtonPanel == null)
				{
					return null;
				}
				return gamepadSkillButtonPanel.GetBattleSkillItemByButtonType(buttonType);
			}
			else
			{
				SkillButtonPanel skillButtonPanel = this.PanelMap.GetValueOrDefault(3) as SkillButtonPanel;
				if (skillButtonPanel == null)
				{
					return null;
				}
				return skillButtonPanel.GetBattleSkillItemByButtonType((ESkillButtonType)buttonType);
			}
		}

		// Token: 0x0603C489 RID: 246921 RVA: 0x00E6F57E File Offset: 0x00E6D77E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForSkillSprite(string[] configParams)
		{
			BattleSkillItem activeSkillItemForGuide = this.GetActiveSkillItemForGuide(configParams);
			if (activeSkillItemForGuide == null)
			{
				return null;
			}
			return activeSkillItemForGuide.GetSpriteGuideItem();
		}

		// Token: 0x0603C48A RID: 246922 RVA: 0x00E6F592 File Offset: 0x00E6D792
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForSkillTexture(string[] configParams)
		{
			BattleSkillItem activeSkillItemForGuide = this.GetActiveSkillItemForGuide(configParams);
			if (activeSkillItemForGuide == null)
			{
				return null;
			}
			return activeSkillItemForGuide.GetTextureGuideItem();
		}

		// Token: 0x0603C48B RID: 246923 RVA: 0x00E6F5A8 File Offset: 0x00E6D7A8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForDefault(string[] configParams)
		{
			BattleChildViewPanel valueOrDefault = this.PanelMap.GetValueOrDefault(int.Parse(configParams[0]));
			object obj;
			if (valueOrDefault == null)
			{
				obj = null;
			}
			else
			{
				AActor uiActorForGuide = valueOrDefault.GetUiActorForGuide();
				obj = ((uiActorForGuide != null) ? uiActorForGuide.GetComponentByClass(UGuideHookRegistry.StaticClass()) : null);
			}
			UGuideHookRegistry uguideHookRegistry = obj as UGuideHookRegistry;
			if (uguideHookRegistry == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "战斗界面挂接组件(GuideHookRegistry)缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤参数", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			string text = configParams[2];
			TWeakObjectPtr<AActor> tweakObjectPtr;
			if (uguideHookRegistry.GuideHookComponents.TryGetValue(text, out tweakObjectPtr))
			{
				AUIBaseActor auibaseActor = tweakObjectPtr.Get() as AUIBaseActor;
				if (auibaseActor != null)
				{
					UUIItem uiitem = auibaseActor.GetUIItem();
					string text2 = configParams[1];
					if (string.IsNullOrEmpty(text2))
					{
						text2 = text;
					}
					TWeakObjectPtr<AActor> tweakObjectPtr2;
					if (uguideHookRegistry.GuideHookComponents.TryGetValue(text2, out tweakObjectPtr2))
					{
						AUIBaseActor auibaseActor2 = tweakObjectPtr2.Get() as AUIBaseActor;
						if (auibaseActor2 != null)
						{
							UUIItem uiitem2 = auibaseActor2.GetUIItem();
							return new UUIItem[]
							{
								uiitem,
								uiitem2
							};
						}
					}
					Log.Instance.Error(ELogModule.Guide, ELogAuthor.TL, "战斗界面挂接组件(GuideHookRegistry)不存在该挂接点（展示用）名称，请检查聚焦引导配置或挂接组件", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
			}
			Log.Instance.Error(ELogModule.Guide, ELogAuthor.TL, "战斗界面挂接组件(GuideHookRegistry)不存在该挂接点名称，请检查聚焦引导配置或挂接组件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x0603C48C RID: 246924 RVA: 0x00E6F6D4 File Offset: 0x00E6D8D4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForTeammate(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(2);
			if (panel == null)
			{
				return null;
			}
			foreach (FormationItem formationItem in (panel as FormationPanel).GetFormationItemList())
			{
				if (!formationItem.IsMyRole)
				{
					UUIItem rootItem = formationItem.GetRootItem();
					if (rootItem == null)
					{
						return null;
					}
					return new UUIItem[]
					{
						rootItem,
						rootItem
					};
				}
			}
			return null;
		}

		// Token: 0x0603C48D RID: 246925 RVA: 0x00E6F760 File Offset: 0x00E6D960
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForFirstIdleRole(string[] configParams)
		{
			FormationPanel formationPanel = Info.Instance.IsInGamepad() ? this.GamepadFormationPanel : (this.GetPanel(2) as FormationPanel);
			if (formationPanel == null)
			{
				return null;
			}
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			int? num;
			if (curRoleData == null)
			{
				num = null;
			}
			else
			{
				EntityHandle entityHandle = curRoleData.EntityHandle;
				num = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			}
			int? num2 = num;
			FormationItem formationItem = null;
			foreach (FormationItem formationItem2 in formationPanel.GetFormationItemList())
			{
				if (formationItem2.EntityId != null)
				{
					int? entityId = formationItem2.EntityId;
					int? num3 = num2;
					if (entityId.GetValueOrDefault() == num3.GetValueOrDefault() & entityId != null == (num3 != null))
					{
						continue;
					}
				}
				if (formationItem == null || formationItem2.PrefabIndex < formationItem.PrefabIndex)
				{
					formationItem = formationItem2;
				}
			}
			UUIItem uuiitem = (formationItem != null) ? formationItem.GetRootItem() : null;
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

		// Token: 0x0603C48E RID: 246926 RVA: 0x00E6F884 File Offset: 0x00E6DA84
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForFishingView(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(5);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C48F RID: 246927 RVA: 0x00E6F899 File Offset: 0x00E6DA99
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForDangoView(string[] configParams)
		{
			DangoWorldMainPanel dangoWorldMainPanel = this.DangoWorldMainPanel;
			if (dangoWorldMainPanel == null)
			{
				return null;
			}
			return dangoWorldMainPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C490 RID: 246928 RVA: 0x00E6F8B0 File Offset: 0x00E6DAB0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForLinkBtn(string[] configParams)
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			UUIItem uuiitem;
			if (formationUnitNodeHandle == null)
			{
				uuiitem = null;
			}
			else
			{
				BattleLinkEnergyButton linkEnergyButton = formationUnitNodeHandle.GetLinkEnergyButton();
				uuiitem = ((linkEnergyButton != null) ? linkEnergyButton.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
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

		// Token: 0x0603C491 RID: 246929 RVA: 0x00E6F8EF File Offset: 0x00E6DAEF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForMissionDangoPanel(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(1);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C492 RID: 246930 RVA: 0x00E6F904 File Offset: 0x00E6DB04
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForMoraleTempExp(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(4);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C493 RID: 246931 RVA: 0x00E6F919 File Offset: 0x00E6DB19
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForMoraleExp(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(5);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C494 RID: 246932 RVA: 0x00E6F92E File Offset: 0x00E6DB2E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForScorePanel(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(11);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C495 RID: 246933 RVA: 0x00E6F944 File Offset: 0x00E6DB44
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForWeeklyRogueBtn(string[] configParams)
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle == null)
			{
				return null;
			}
			BattleWeeklyRogueButton weeklyRogueButton = formationUnitNodeHandle.GetWeeklyRogueButton();
			if (weeklyRogueButton == null)
			{
				return null;
			}
			return weeklyRogueButton.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C496 RID: 246934 RVA: 0x00E6F964 File Offset: 0x00E6DB64
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForTimeDilationBtn(string[] configParams)
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			UUIItem uuiitem;
			if (formationUnitNodeHandle == null)
			{
				uuiitem = null;
			}
			else
			{
				BattleTimeDilationButton battleTimeDilationButton = formationUnitNodeHandle.GetBattleTimeDilationButton();
				uuiitem = ((battleTimeDilationButton != null) ? battleTimeDilationButton.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
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

		// Token: 0x0603C497 RID: 246935 RVA: 0x00E6F9A3 File Offset: 0x00E6DBA3
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForHonamiStoryPlayerLevel(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(5);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C498 RID: 246936 RVA: 0x00E6F9B8 File Offset: 0x00E6DBB8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForHonamiStoryMapLevel(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(5);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C499 RID: 246937 RVA: 0x00E6F9CD File Offset: 0x00E6DBCD
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForHonamiStoryLeaveBtn(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(5);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C49A RID: 246938 RVA: 0x00E6F9E2 File Offset: 0x00E6DBE2
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForMotorMobile(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(6);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C49B RID: 246939 RVA: 0x00E6F9F7 File Offset: 0x00E6DBF7
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForTopPanel(string[] configParams)
		{
			BattleChildViewPanel panel = this.GetPanel(5);
			if (panel == null)
			{
				return null;
			}
			return panel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0603C49C RID: 246940 RVA: 0x00E6FA0C File Offset: 0x00E6DC0C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				Log.Instance.Error(ELogModule.Guide, ELogAuthor.WZ, "BattleView相关的引导Extra参数设置错误，不能为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			TGuideItemBuilder tguideItemBuilder;
			if (this.GuideUiItemBuilders.TryGetValue(configParams[0], out tguideItemBuilder))
			{
				return tguideItemBuilder(configParams);
			}
			return this.GuideUiItemBuilders["Default"](configParams);
		}

		// Token: 0x0603C49D RID: 246941 RVA: 0x00E6FA6B File Offset: 0x00E6DC6B
		private void OnRefreshFormationCooldownExternal(int playerId, int roleId, float? remainCd = null, float? totalCd = null)
		{
			FormationPanel gamepadFormationPanel = this.GamepadFormationPanel;
			if (gamepadFormationPanel != null)
			{
				gamepadFormationPanel.RefreshFormationCooldownExternal(playerId, roleId, remainCd, totalCd);
			}
			FormationPanel formationPanel = this.FormationPanel;
			if (formationPanel == null)
			{
				return;
			}
			formationPanel.RefreshFormationCooldownExternal(playerId, roleId, remainCd, totalCd);
		}

		// Token: 0x0603C49E RID: 246942 RVA: 0x00E6FA98 File Offset: 0x00E6DC98
		public void ResetFormationCooldownExternal()
		{
			FormationPanel gamepadFormationPanel = this.GamepadFormationPanel;
			if (gamepadFormationPanel != null)
			{
				gamepadFormationPanel.ResetFormationCooldownExternal();
			}
			FormationPanel formationPanel = this.FormationPanel;
			if (formationPanel == null)
			{
				return;
			}
			formationPanel.ResetFormationCooldownExternal();
		}

		// Token: 0x0603C49F RID: 246943 RVA: 0x00E6FABC File Offset: 0x00E6DCBC
		private UniTask NewFormationUnitNode()
		{
			BattleView.<NewFormationUnitNode>d__108 <NewFormationUnitNode>d__;
			<NewFormationUnitNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFormationUnitNode>d__.<>4__this = this;
			<NewFormationUnitNode>d__.<>1__state = -1;
			<NewFormationUnitNode>d__.<>t__builder.Start<BattleView.<NewFormationUnitNode>d__108>(ref <NewFormationUnitNode>d__);
			return <NewFormationUnitNode>d__.<>t__builder.Task;
		}

		// Token: 0x0603C4A0 RID: 246944 RVA: 0x00E6FAFF File Offset: 0x00E6DCFF
		[NullableContext(2)]
		public UUIItem GetTopPanelPhoneMsgButtonItem()
		{
			TopPanel topPanel = this.GetPanel(5) as TopPanel;
			if (topPanel == null)
			{
				return null;
			}
			return topPanel.GetPanelItem("PhoneMsgButton");
		}

		// Token: 0x0603C4A1 RID: 246945 RVA: 0x00E6FB1D File Offset: 0x00E6DD1D
		[NullableContext(2)]
		public IPhoneMessageButtonImplement GetTopPanelPhoneMsgButton()
		{
			TopPanel topPanel = this.GetPanel(5) as TopPanel;
			if (topPanel == null)
			{
				return null;
			}
			return topPanel.GetPhoneMsgButton();
		}

		// Token: 0x0603C4A2 RID: 246946 RVA: 0x00E6FB38 File Offset: 0x00E6DD38
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UUIItem> GetTopPanelEntitySequenceButtonRootAsync()
		{
			BattleView.<GetTopPanelEntitySequenceButtonRootAsync>d__111 <GetTopPanelEntitySequenceButtonRootAsync>d__;
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUIItem>.Create();
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>4__this = this;
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>1__state = -1;
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>t__builder.Start<BattleView.<GetTopPanelEntitySequenceButtonRootAsync>d__111>(ref <GetTopPanelEntitySequenceButtonRootAsync>d__);
			return <GetTopPanelEntitySequenceButtonRootAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C4A3 RID: 246947 RVA: 0x00E6FB7B File Offset: 0x00E6DD7B
		[NullableContext(2)]
		public PositionPanel GetPositionPanel()
		{
			return this.GetPanel(9) as PositionPanel;
		}

		// Token: 0x0603C4A6 RID: 246950 RVA: 0x00E6FC74 File Offset: 0x00E6DE74
		[CompilerGenerated]
		private UniTask <InputControllerChange>g__Invoke|77_0()
		{
			BattleView.<<InputControllerChange>g__Invoke|77_0>d <<InputControllerChange>g__Invoke|77_0>d;
			<<InputControllerChange>g__Invoke|77_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<InputControllerChange>g__Invoke|77_0>d.<>4__this = this;
			<<InputControllerChange>g__Invoke|77_0>d.<>1__state = -1;
			<<InputControllerChange>g__Invoke|77_0>d.<>t__builder.Start<BattleView.<<InputControllerChange>g__Invoke|77_0>d>(ref <<InputControllerChange>g__Invoke|77_0>d);
			return <<InputControllerChange>g__Invoke|77_0>d.<>t__builder.Task;
		}

		// Token: 0x0603C4A7 RID: 246951 RVA: 0x00E6FCB8 File Offset: 0x00E6DEB8
		[CompilerGenerated]
		private UniTask <InputControllerChange>g__Invoke|77_1()
		{
			BattleView.<<InputControllerChange>g__Invoke|77_1>d <<InputControllerChange>g__Invoke|77_1>d;
			<<InputControllerChange>g__Invoke|77_1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<InputControllerChange>g__Invoke|77_1>d.<>4__this = this;
			<<InputControllerChange>g__Invoke|77_1>d.<>1__state = -1;
			<<InputControllerChange>g__Invoke|77_1>d.<>t__builder.Start<BattleView.<<InputControllerChange>g__Invoke|77_1>d>(ref <<InputControllerChange>g__Invoke|77_1>d);
			return <<InputControllerChange>g__Invoke|77_1>d.<>t__builder.Task;
		}

		// Token: 0x0401F67C RID: 128636
		private const int CHECK_DESTROY_TIME = 5000;

		// Token: 0x0401F67D RID: 128637
		private static readonly IReadOnlyDictionary<EBattleViewChildType, BattleView.EChildType> BattleViewChildMap = new Dictionary<EBattleViewChildType, BattleView.EChildType>
		{
			{
				EBattleViewChildType.BossStatePanel,
				BattleView.EChildType.BossStatePanel
			},
			{
				EBattleViewChildType.MissionPanel,
				BattleView.EChildType.MissionPanel
			},
			{
				EBattleViewChildType.FormationPanel,
				BattleView.EChildType.FormationPanel
			},
			{
				EBattleViewChildType.SkillButtonPanel,
				BattleView.EChildType.SkillButtonPanel
			},
			{
				EBattleViewChildType.BottomPanel,
				BattleView.EChildType.BottomPanel
			},
			{
				EBattleViewChildType.TopPanel,
				BattleView.EChildType.TopPanel
			},
			{
				EBattleViewChildType.CenterPanel,
				BattleView.EChildType.CenterPanel
			},
			{
				EBattleViewChildType.ChatPanel,
				BattleView.EChildType.ChatPanel
			},
			{
				EBattleViewChildType.FullScreenPanel,
				BattleView.EChildType.FullScreenPanel
			},
			{
				EBattleViewChildType.PositionPanel,
				BattleView.EChildType.PositionPanel
			},
			{
				EBattleViewChildType.OnlineInstanceDungeonDeathPanel,
				BattleView.EChildType.OnlineInstanceDungeonDeathPanel
			},
			{
				EBattleViewChildType.ScorePanel,
				BattleView.EChildType.ScorePanel
			}
		};

		// Token: 0x0401F67E RID: 128638
		[Nullable(2)]
		private PartStatePanel PartStatePanel;

		// Token: 0x0401F67F RID: 128639
		[Nullable(2)]
		private BossStatePanel BossStatePanel;

		// Token: 0x0401F680 RID: 128640
		[Nullable(2)]
		private FormationPanel FormationPanel;

		// Token: 0x0401F681 RID: 128641
		[Nullable(2)]
		private SkillButtonPanel SkillButtonPanel;

		// Token: 0x0401F682 RID: 128642
		[Nullable(2)]
		private FormationPanel GamepadFormationPanel;

		// Token: 0x0401F683 RID: 128643
		[Nullable(2)]
		private GamepadSkillButtonPanel GamepadSkillButtonPanel;

		// Token: 0x0401F684 RID: 128644
		[Nullable(2)]
		private DangoWorldMainPanel DangoWorldMainPanel;

		// Token: 0x0401F685 RID: 128645
		[Nullable(2)]
		private SceneItemDurabilityStatePanel SceneItemDurabilityPanel;

		// Token: 0x0401F686 RID: 128646
		private bool IsLoadingDurabilityPanel;

		// Token: 0x0401F687 RID: 128647
		private bool IsKeyboardPanelCreated;

		// Token: 0x0401F688 RID: 128648
		private bool IsGamepadPanelCreated;

		// Token: 0x0401F689 RID: 128649
		private readonly Dictionary<int, BattleChildViewPanel> PanelMap = new Dictionary<int, BattleChildViewPanel>();

		// Token: 0x0401F68A RID: 128650
		private readonly List<BattleChildViewPanel> TickPanelList = new List<BattleChildViewPanel>();

		// Token: 0x0401F68B RID: 128651
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]BattleViewTick", "", "");

		// Token: 0x0401F68C RID: 128652
		private int? CenterPanelUiIndex;

		// Token: 0x0401F68D RID: 128653
		private bool IsPhantom;

		// Token: 0x0401F68E RID: 128654
		private bool IsPureModeOpen;

		// Token: 0x0401F68F RID: 128655
		[Nullable(2)]
		private FormationUnitNodeHandle FormationUnitNodeHandle;

		// Token: 0x0401F690 RID: 128656
		public BattleViewProxy Proxy = new BattleViewProxy();

		// Token: 0x0401F691 RID: 128657
		[Nullable(2)]
		private TimerHandle CheckDestroyTimer;

		// Token: 0x0401F692 RID: 128658
		private float MissionOriginalY = -1f;

		// Token: 0x0401F693 RID: 128659
		private readonly Dictionary<string, TGuideItemBuilder> GuideUiItemBuilders = new Dictionary<string, TGuideItemBuilder>();

		// Token: 0x0200BF63 RID: 48995
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039B6A RID: 236394
			BossStatePanel,
			// Token: 0x04039B6B RID: 236395
			MissionPanel,
			// Token: 0x04039B6C RID: 236396
			FormationPanel,
			// Token: 0x04039B6D RID: 236397
			SkillButtonPanel,
			// Token: 0x04039B6E RID: 236398
			BottomPanel,
			// Token: 0x04039B6F RID: 236399
			TopPanel,
			// Token: 0x04039B70 RID: 236400
			CenterPanel,
			// Token: 0x04039B71 RID: 236401
			ChatPanel,
			// Token: 0x04039B72 RID: 236402
			FullScreenPanel,
			// Token: 0x04039B73 RID: 236403
			PositionPanel,
			// Token: 0x04039B74 RID: 236404
			OnlineInstanceDungeonDeathPanel,
			// Token: 0x04039B75 RID: 236405
			ScorePanel,
			// Token: 0x04039B76 RID: 236406
			PureModeRootItem = 14,
			// Token: 0x04039B77 RID: 236407
			PureModeItem,
			// Token: 0x04039B78 RID: 236408
			PureModeButton
		}

		// Token: 0x0200BF64 RID: 48996
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x04039B7A RID: 236410
			GamepadFormationPanel = 12,
			// Token: 0x04039B7B RID: 236411
			GamepadSkillButtonPanel
		}
	}
}

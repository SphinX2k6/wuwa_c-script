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
	// Token: 0x02004CDA RID: 19674
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleView : UiTickViewBase
	{
		// Token: 0x060313A3 RID: 201635 RVA: 0x00DBE094 File Offset: 0x00DBC294
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
			this.GuideUiItemBuilders.Add("RoleTowerTokenBtn", new TGuideItemBuilder(this.BuilderForRoleTowerTokenBtn));
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

		// Token: 0x060313A4 RID: 201636 RVA: 0x00DBE39C File Offset: 0x00DBC59C
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

		// Token: 0x060313A5 RID: 201637 RVA: 0x00DBE63C File Offset: 0x00DBC83C
		protected override UniTask OnBeforeStartAsync()
		{
			BattleView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060313A6 RID: 201638 RVA: 0x00DBE680 File Offset: 0x00DBC880
		private UniTask NewDangoAbyssInfo()
		{
			BattleView.<NewDangoAbyssInfo>d__26 <NewDangoAbyssInfo>d__;
			<NewDangoAbyssInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDangoAbyssInfo>d__.<>4__this = this;
			<NewDangoAbyssInfo>d__.<>1__state = -1;
			<NewDangoAbyssInfo>d__.<>t__builder.Start<BattleView.<NewDangoAbyssInfo>d__26>(ref <NewDangoAbyssInfo>d__);
			return <NewDangoAbyssInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060313A7 RID: 201639 RVA: 0x00DBE6C4 File Offset: 0x00DBC8C4
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

		// Token: 0x060313A8 RID: 201640 RVA: 0x00DBE784 File Offset: 0x00DBC984
		private UniTask CreateKeyBoardPanel()
		{
			BattleView.<CreateKeyBoardPanel>d__28 <CreateKeyBoardPanel>d__;
			<CreateKeyBoardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateKeyBoardPanel>d__.<>4__this = this;
			<CreateKeyBoardPanel>d__.<>1__state = -1;
			<CreateKeyBoardPanel>d__.<>t__builder.Start<BattleView.<CreateKeyBoardPanel>d__28>(ref <CreateKeyBoardPanel>d__);
			return <CreateKeyBoardPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060313A9 RID: 201641 RVA: 0x00DBE7C8 File Offset: 0x00DBC9C8
		private UniTask CreateKeyBoardPanelInner()
		{
			BattleView.<CreateKeyBoardPanelInner>d__29 <CreateKeyBoardPanelInner>d__;
			<CreateKeyBoardPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateKeyBoardPanelInner>d__.<>4__this = this;
			<CreateKeyBoardPanelInner>d__.<>1__state = -1;
			<CreateKeyBoardPanelInner>d__.<>t__builder.Start<BattleView.<CreateKeyBoardPanelInner>d__29>(ref <CreateKeyBoardPanelInner>d__);
			return <CreateKeyBoardPanelInner>d__.<>t__builder.Task;
		}

		// Token: 0x060313AA RID: 201642 RVA: 0x00DBE80C File Offset: 0x00DBCA0C
		private UniTask CreateGamepadPanel()
		{
			BattleView.<CreateGamepadPanel>d__30 <CreateGamepadPanel>d__;
			<CreateGamepadPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanel>d__.<>4__this = this;
			<CreateGamepadPanel>d__.<>1__state = -1;
			<CreateGamepadPanel>d__.<>t__builder.Start<BattleView.<CreateGamepadPanel>d__30>(ref <CreateGamepadPanel>d__);
			return <CreateGamepadPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060313AB RID: 201643 RVA: 0x00DBE850 File Offset: 0x00DBCA50
		private UniTask CreateGamepadPanelInner()
		{
			BattleView.<CreateGamepadPanelInner>d__31 <CreateGamepadPanelInner>d__;
			<CreateGamepadPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadPanelInner>d__.<>4__this = this;
			<CreateGamepadPanelInner>d__.<>1__state = -1;
			<CreateGamepadPanelInner>d__.<>t__builder.Start<BattleView.<CreateGamepadPanelInner>d__31>(ref <CreateGamepadPanelInner>d__);
			return <CreateGamepadPanelInner>d__.<>t__builder.Task;
		}

		// Token: 0x060313AC RID: 201644 RVA: 0x00DBE894 File Offset: 0x00DBCA94
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

		// Token: 0x060313AD RID: 201645 RVA: 0x00DBE920 File Offset: 0x00DBCB20
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

		// Token: 0x060313AE RID: 201646 RVA: 0x00DBE97C File Offset: 0x00DBCB7C
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

		// Token: 0x060313AF RID: 201647 RVA: 0x00DBEA00 File Offset: 0x00DBCC00
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

		// Token: 0x060313B0 RID: 201648 RVA: 0x00DBEA6C File Offset: 0x00DBCC6C
		protected override void OnBeforeHide()
		{
			this.RefreshPureModeBeforeHide();
			BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.BattleView);
			EventSystem.Instance.Emit(EEventName.DisActiveBattleView);
		}

		// Token: 0x060313B1 RID: 201649 RVA: 0x00DBEA94 File Offset: 0x00DBCC94
		protected override void OnAfterHide()
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.HideBattleChildViewPanel();
			}
		}

		// Token: 0x060313B2 RID: 201650 RVA: 0x00DBEAEC File Offset: 0x00DBCCEC
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

		// Token: 0x060313B3 RID: 201651 RVA: 0x00DBEB14 File Offset: 0x00DBCD14
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
		}

		// Token: 0x060313B4 RID: 201652 RVA: 0x00DBEB68 File Offset: 0x00DBCD68
		protected override void OnAfterDestroy()
		{
			if (this.CheckDestroyTimer != null)
			{
				TimerSystem.Instance.Remove(this.CheckDestroyTimer);
				this.CheckDestroyTimer = null;
			}
		}

		// Token: 0x060313B5 RID: 201653 RVA: 0x00DBEB8C File Offset: 0x00DBCD8C
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

		// Token: 0x060313B6 RID: 201654 RVA: 0x00DBED9C File Offset: 0x00DBCF9C
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

		// Token: 0x060313B7 RID: 201655 RVA: 0x00DBEFBC File Offset: 0x00DBD1BC
		private void OnRefreshFormationCallback()
		{
			this.Proxy.HeadStatePanel.RefreshCurrentRole();
		}

		// Token: 0x060313B8 RID: 201656 RVA: 0x00DBEFD0 File Offset: 0x00DBD1D0
		private void OnAllRoleDataChanged()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null && curRoleData.RoleConfig != null)
			{
				this.PlayFormationSwitchAnim(curRoleData.RoleConfig.Value.RoleType == 2);
			}
		}

		// Token: 0x060313B9 RID: 201657 RVA: 0x00DBF014 File Offset: 0x00DBD214
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

		// Token: 0x060313BA RID: 201658 RVA: 0x00DBF04E File Offset: 0x00DBD24E
		private void OnPureModeClicked()
		{
			BattleUiControl.Instance.TryClosePureMode();
		}

		// Token: 0x060313BB RID: 201659 RVA: 0x00DBF05B File Offset: 0x00DBD25B
		private void OnChangeRoleCompleted(EntityHandle newHandle, [Nullable(2)] EntityHandle oldHandle)
		{
			this.Proxy.HeadStatePanel.RefreshCurrentRole();
		}

		// Token: 0x060313BC RID: 201660 RVA: 0x00DBF06D File Offset: 0x00DBD26D
		[NullableContext(2)]
		private void OnStartSequenceStart(string _ = null)
		{
			if (base.IsShow)
			{
				this.SetActive(true);
			}
		}

		// Token: 0x060313BD RID: 201661 RVA: 0x00DBF080 File Offset: 0x00DBD280
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

		// Token: 0x060313BE RID: 201662 RVA: 0x00DBF0CE File Offset: 0x00DBD2CE
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (!handle.Valid)
			{
				return;
			}
			this.Proxy.HeadStatePanel.OnRemoveEntity(handle.Entity);
			this.PartStatePanel.DestroyPartStateFromRole(handle.Entity);
		}

		// Token: 0x060313BF RID: 201663 RVA: 0x00DBF100 File Offset: 0x00DBD300
		private UniTask PreloadBattleHeadStatePanel()
		{
			BattleView.<PreloadBattleHeadStatePanel>d__52 <PreloadBattleHeadStatePanel>d__;
			<PreloadBattleHeadStatePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadBattleHeadStatePanel>d__.<>4__this = this;
			<PreloadBattleHeadStatePanel>d__.<>1__state = -1;
			<PreloadBattleHeadStatePanel>d__.<>t__builder.Start<BattleView.<PreloadBattleHeadStatePanel>d__52>(ref <PreloadBattleHeadStatePanel>d__);
			return <PreloadBattleHeadStatePanel>d__.<>t__builder.Task;
		}

		// Token: 0x060313C0 RID: 201664 RVA: 0x00DBF143 File Offset: 0x00DBD343
		private void InitializeBattleHeadStatePanel()
		{
			BattleHeadStatePanel headStatePanel = this.Proxy.HeadStatePanel;
			if (headStatePanel == null)
			{
				return;
			}
			headStatePanel.Init();
		}

		// Token: 0x060313C1 RID: 201665 RVA: 0x00DBF15A File Offset: 0x00DBD35A
		private void ResetBattleHeadStatePanel()
		{
			if (this.Proxy.HeadStatePanel == null)
			{
				return;
			}
			this.Proxy.HeadStatePanel.ResetAllHeadStates();
			this.Proxy.HeadStatePanel = null;
		}

		// Token: 0x060313C2 RID: 201666 RVA: 0x00DBF186 File Offset: 0x00DBD386
		private void InitializePartStatePanel()
		{
			this.PartStatePanel = new PartStatePanel();
			this.PartStatePanel.InitializePartStatePanel();
		}

		// Token: 0x060313C3 RID: 201667 RVA: 0x00DBF19E File Offset: 0x00DBD39E
		private void ResetPartStatePanel()
		{
			if (this.PartStatePanel == null)
			{
				return;
			}
			this.PartStatePanel.ResetPartStatePanel();
			this.PartStatePanel = null;
		}

		// Token: 0x060313C4 RID: 201668 RVA: 0x00DBF1BB File Offset: 0x00DBD3BB
		private void ResetSceneItemDurabilityPanel()
		{
			if (this.SceneItemDurabilityPanel == null)
			{
				return;
			}
			this.SceneItemDurabilityPanel.Reset();
			this.SceneItemDurabilityPanel = null;
		}

		// Token: 0x060313C5 RID: 201669 RVA: 0x00DBF1D8 File Offset: 0x00DBD3D8
		public void ShowLinkButton(bool isShow)
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle == null)
			{
				return;
			}
			formationUnitNodeHandle.ShowLinkButton(isShow);
		}

		// Token: 0x060313C6 RID: 201670 RVA: 0x00DBF1EB File Offset: 0x00DBD3EB
		public void UpdateTimeDilationButton()
		{
			FormationUnitNodeHandle formationUnitNodeHandle = this.FormationUnitNodeHandle;
			if (formationUnitNodeHandle == null)
			{
				return;
			}
			formationUnitNodeHandle.UpdateTimeDilationButton();
		}

		// Token: 0x060313C7 RID: 201671 RVA: 0x00DBF200 File Offset: 0x00DBD400
		public void OffsetMissionAnchor(float y)
		{
			UUIItem item = base.GetItem(1);
			if (this.MissionOriginalY == -1f)
			{
				this.MissionOriginalY = item.GetAnchorOffsetY();
			}
			item.SetAnchorOffsetY((y == -1f) ? this.MissionOriginalY : (this.MissionOriginalY + y));
		}

		// Token: 0x060313C8 RID: 201672 RVA: 0x00DBF24C File Offset: 0x00DBD44C
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

		// Token: 0x060313C9 RID: 201673 RVA: 0x00DBF2A7 File Offset: 0x00DBD4A7
		[NullableContext(2)]
		private BattleChildViewPanel GetPanel(int index)
		{
			return this.PanelMap.GetValueOrDefault(index);
		}

		// Token: 0x060313CA RID: 201674 RVA: 0x00DBF2B8 File Offset: 0x00DBD4B8
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

		// Token: 0x060313CB RID: 201675 RVA: 0x00DBF378 File Offset: 0x00DBD578
		private void OnSeamlessTravelFinish()
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.OnSeamlessTravelFinish();
			}
		}

		// Token: 0x060313CC RID: 201676 RVA: 0x00DBF3D0 File Offset: 0x00DBD5D0
		private void OnBattleUiPlayAudio(string audioId)
		{
			AudioSystem.Instance.PostEvent(audioId);
		}

		// Token: 0x060313CD RID: 201677 RVA: 0x00DBF3DE File Offset: 0x00DBD5DE
		private void OnBattleUiAlphaChanged(float alpha)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(alpha);
		}

		// Token: 0x060313CE RID: 201678 RVA: 0x00DBF3F1 File Offset: 0x00DBD5F1
		private void OnBattleUiPureModeChanged(bool _)
		{
			this.RefreshPureMode();
		}

		// Token: 0x060313CF RID: 201679 RVA: 0x00DBF3FC File Offset: 0x00DBD5FC
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

		// Token: 0x060313D0 RID: 201680 RVA: 0x00DBF4CE File Offset: 0x00DBD6CE
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

		// Token: 0x060313D1 RID: 201681 RVA: 0x00DBF4F4 File Offset: 0x00DBD6F4
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

		// Token: 0x060313D2 RID: 201682 RVA: 0x00DBF5A0 File Offset: 0x00DBD7A0
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

		// Token: 0x060313D3 RID: 201683 RVA: 0x00DBF5C0 File Offset: 0x00DBD7C0
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

		// Token: 0x060313D4 RID: 201684 RVA: 0x00DBF638 File Offset: 0x00DBD838
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

		// Token: 0x060313D5 RID: 201685 RVA: 0x00DBF658 File Offset: 0x00DBD858
		private void ResetAllChildViewPanels()
		{
			foreach (BattleChildViewPanel battleChildViewPanel in this.PanelMap.Values)
			{
				battleChildViewPanel.Reset();
			}
			this.PanelMap.Clear();
			this.TickPanelList.Clear();
		}

		// Token: 0x060313D6 RID: 201686 RVA: 0x00DBF6C4 File Offset: 0x00DBD8C4
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

		// Token: 0x060313D7 RID: 201687 RVA: 0x00DBF89C File Offset: 0x00DBDA9C
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

		// Token: 0x060313D8 RID: 201688 RVA: 0x00DBF924 File Offset: 0x00DBDB24
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

		// Token: 0x060313D9 RID: 201689 RVA: 0x00DBF9A8 File Offset: 0x00DBDBA8
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

		// Token: 0x060313DA RID: 201690 RVA: 0x00DBFA2C File Offset: 0x00DBDC2C
		private void OnGmHideMission(bool bVisible)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			BattleUiModel.Instance.IsMissionPanelVisible = bVisible;
		}

		// Token: 0x060313DB RID: 201691 RVA: 0x00DBFA4C File Offset: 0x00DBDC4C
		private bool GetChildPanelOverrideSwitch(BattleChildViewPanel panel)
		{
			return !panel.IsChildType(EBattleUiChild.Mission) || BattleUiModel.Instance.IsMissionPanelVisible;
		}

		// Token: 0x060313DC RID: 201692 RVA: 0x00DBFA68 File Offset: 0x00DBDC68
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

		// Token: 0x060313DD RID: 201693 RVA: 0x00DBFAA6 File Offset: 0x00DBDCA6
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

		// Token: 0x060313DE RID: 201694 RVA: 0x00DBFABC File Offset: 0x00DBDCBC
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

		// Token: 0x060313DF RID: 201695 RVA: 0x00DBFB1A File Offset: 0x00DBDD1A
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

		// Token: 0x060313E0 RID: 201696 RVA: 0x00DBFB2E File Offset: 0x00DBDD2E
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

		// Token: 0x060313E1 RID: 201697 RVA: 0x00DBFB44 File Offset: 0x00DBDD44
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

		// Token: 0x060313E2 RID: 201698 RVA: 0x00DBFC70 File Offset: 0x00DBDE70
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

		// Token: 0x060313E3 RID: 201699 RVA: 0x00DBFCFC File Offset: 0x00DBDEFC
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

		// Token: 0x060313E4 RID: 201700 RVA: 0x00DBFE20 File Offset: 0x00DBE020
		[NullableContext(2)]
		public UUIItem GetFormationExtraContainer(int prefabIndex)
		{
			FormationPanel formationPanel = Info.Instance.IsInGamepad() ? this.GamepadFormationPanel : (this.GetPanel(2) as FormationPanel);
			if (formationPanel == null)
			{
				return null;
			}
			foreach (FormationItem formationItem in formationPanel.GetFormationItemList())
			{
				if (formationItem.PrefabIndex == prefabIndex)
				{
					return formationItem.GetExtraContainer();
				}
			}
			return null;
		}

		// Token: 0x060313E5 RID: 201701 RVA: 0x00DBFEA8 File Offset: 0x00DBE0A8
		[NullableContext(2)]
		public UUIItem GetFormationPanelRoot()
		{
			FormationPanel formationPanel = Info.Instance.IsInGamepad() ? this.GamepadFormationPanel : (this.GetPanel(2) as FormationPanel);
			if (formationPanel == null)
			{
				return null;
			}
			return formationPanel.GetFormationItemContainer();
		}

		// Token: 0x060313E6 RID: 201702 RVA: 0x00DBFED5 File Offset: 0x00DBE0D5
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

		// Token: 0x060313E7 RID: 201703 RVA: 0x00DBFEEA File Offset: 0x00DBE0EA
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

		// Token: 0x060313E8 RID: 201704 RVA: 0x00DBFF00 File Offset: 0x00DBE100
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

		// Token: 0x060313E9 RID: 201705 RVA: 0x00DBFF3F File Offset: 0x00DBE13F
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

		// Token: 0x060313EA RID: 201706 RVA: 0x00DBFF54 File Offset: 0x00DBE154
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

		// Token: 0x060313EB RID: 201707 RVA: 0x00DBFF69 File Offset: 0x00DBE169
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

		// Token: 0x060313EC RID: 201708 RVA: 0x00DBFF7E File Offset: 0x00DBE17E
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

		// Token: 0x060313ED RID: 201709 RVA: 0x00DBFF94 File Offset: 0x00DBE194
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

		// Token: 0x060313EE RID: 201710 RVA: 0x00DBFFB4 File Offset: 0x00DBE1B4
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

		// Token: 0x060313EF RID: 201711 RVA: 0x00DBFFF3 File Offset: 0x00DBE1F3
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] BuilderForRoleTowerTokenBtn(string[] configParams)
		{
			RoleTowerTokenButtonItem tokenButtonItem = RoleTowerModel.Instance.GetTokenButtonItem();
			if (tokenButtonItem == null)
			{
				return null;
			}
			return tokenButtonItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x060313F0 RID: 201712 RVA: 0x00DC000B File Offset: 0x00DBE20B
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

		// Token: 0x060313F1 RID: 201713 RVA: 0x00DC0020 File Offset: 0x00DBE220
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

		// Token: 0x060313F2 RID: 201714 RVA: 0x00DC0035 File Offset: 0x00DBE235
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

		// Token: 0x060313F3 RID: 201715 RVA: 0x00DC004A File Offset: 0x00DBE24A
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

		// Token: 0x060313F4 RID: 201716 RVA: 0x00DC005F File Offset: 0x00DBE25F
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

		// Token: 0x060313F5 RID: 201717 RVA: 0x00DC0074 File Offset: 0x00DBE274
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

		// Token: 0x060313F6 RID: 201718 RVA: 0x00DC00D3 File Offset: 0x00DBE2D3
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

		// Token: 0x060313F7 RID: 201719 RVA: 0x00DC0100 File Offset: 0x00DBE300
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

		// Token: 0x060313F8 RID: 201720 RVA: 0x00DC0124 File Offset: 0x00DBE324
		private UniTask NewFormationUnitNode()
		{
			BattleView.<NewFormationUnitNode>d__111 <NewFormationUnitNode>d__;
			<NewFormationUnitNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFormationUnitNode>d__.<>4__this = this;
			<NewFormationUnitNode>d__.<>1__state = -1;
			<NewFormationUnitNode>d__.<>t__builder.Start<BattleView.<NewFormationUnitNode>d__111>(ref <NewFormationUnitNode>d__);
			return <NewFormationUnitNode>d__.<>t__builder.Task;
		}

		// Token: 0x060313F9 RID: 201721 RVA: 0x00DC0167 File Offset: 0x00DBE367
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

		// Token: 0x060313FA RID: 201722 RVA: 0x00DC0185 File Offset: 0x00DBE385
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

		// Token: 0x060313FB RID: 201723 RVA: 0x00DC01A0 File Offset: 0x00DBE3A0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UUIItem> GetTopPanelEntitySequenceButtonRootAsync()
		{
			BattleView.<GetTopPanelEntitySequenceButtonRootAsync>d__114 <GetTopPanelEntitySequenceButtonRootAsync>d__;
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUIItem>.Create();
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>4__this = this;
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>1__state = -1;
			<GetTopPanelEntitySequenceButtonRootAsync>d__.<>t__builder.Start<BattleView.<GetTopPanelEntitySequenceButtonRootAsync>d__114>(ref <GetTopPanelEntitySequenceButtonRootAsync>d__);
			return <GetTopPanelEntitySequenceButtonRootAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060313FC RID: 201724 RVA: 0x00DC01E3 File Offset: 0x00DBE3E3
		[NullableContext(2)]
		public PositionPanel GetPositionPanel()
		{
			return this.GetPanel(9) as PositionPanel;
		}

		// Token: 0x060313FF RID: 201727 RVA: 0x00DC02DC File Offset: 0x00DBE4DC
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

		// Token: 0x06031400 RID: 201728 RVA: 0x00DC0320 File Offset: 0x00DBE520
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

		// Token: 0x0401A135 RID: 106805
		private const int CHECK_DESTROY_TIME = 5000;

		// Token: 0x0401A136 RID: 106806
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

		// Token: 0x0401A137 RID: 106807
		[Nullable(2)]
		private PartStatePanel PartStatePanel;

		// Token: 0x0401A138 RID: 106808
		[Nullable(2)]
		private BossStatePanel BossStatePanel;

		// Token: 0x0401A139 RID: 106809
		[Nullable(2)]
		private FormationPanel FormationPanel;

		// Token: 0x0401A13A RID: 106810
		[Nullable(2)]
		private SkillButtonPanel SkillButtonPanel;

		// Token: 0x0401A13B RID: 106811
		[Nullable(2)]
		private FormationPanel GamepadFormationPanel;

		// Token: 0x0401A13C RID: 106812
		[Nullable(2)]
		private GamepadSkillButtonPanel GamepadSkillButtonPanel;

		// Token: 0x0401A13D RID: 106813
		[Nullable(2)]
		private DangoWorldMainPanel DangoWorldMainPanel;

		// Token: 0x0401A13E RID: 106814
		[Nullable(2)]
		private SceneItemDurabilityStatePanel SceneItemDurabilityPanel;

		// Token: 0x0401A13F RID: 106815
		private bool IsLoadingDurabilityPanel;

		// Token: 0x0401A140 RID: 106816
		private bool IsKeyboardPanelCreated;

		// Token: 0x0401A141 RID: 106817
		private bool IsGamepadPanelCreated;

		// Token: 0x0401A142 RID: 106818
		private readonly Dictionary<int, BattleChildViewPanel> PanelMap = new Dictionary<int, BattleChildViewPanel>();

		// Token: 0x0401A143 RID: 106819
		private readonly List<BattleChildViewPanel> TickPanelList = new List<BattleChildViewPanel>();

		// Token: 0x0401A144 RID: 106820
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]BattleViewTick", "", "");

		// Token: 0x0401A145 RID: 106821
		private int? CenterPanelUiIndex;

		// Token: 0x0401A146 RID: 106822
		private bool IsPhantom;

		// Token: 0x0401A147 RID: 106823
		private bool IsPureModeOpen;

		// Token: 0x0401A148 RID: 106824
		[Nullable(2)]
		private FormationUnitNodeHandle FormationUnitNodeHandle;

		// Token: 0x0401A149 RID: 106825
		public BattleViewProxy Proxy = new BattleViewProxy();

		// Token: 0x0401A14A RID: 106826
		[Nullable(2)]
		private TimerHandle CheckDestroyTimer;

		// Token: 0x0401A14B RID: 106827
		private float MissionOriginalY = -1f;

		// Token: 0x0401A14C RID: 106828
		private readonly Dictionary<string, TGuideItemBuilder> GuideUiItemBuilders = new Dictionary<string, TGuideItemBuilder>();

		// Token: 0x0200A969 RID: 43369
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403452C RID: 214316
			BossStatePanel,
			// Token: 0x0403452D RID: 214317
			MissionPanel,
			// Token: 0x0403452E RID: 214318
			FormationPanel,
			// Token: 0x0403452F RID: 214319
			SkillButtonPanel,
			// Token: 0x04034530 RID: 214320
			BottomPanel,
			// Token: 0x04034531 RID: 214321
			TopPanel,
			// Token: 0x04034532 RID: 214322
			CenterPanel,
			// Token: 0x04034533 RID: 214323
			ChatPanel,
			// Token: 0x04034534 RID: 214324
			FullScreenPanel,
			// Token: 0x04034535 RID: 214325
			PositionPanel,
			// Token: 0x04034536 RID: 214326
			OnlineInstanceDungeonDeathPanel,
			// Token: 0x04034537 RID: 214327
			ScorePanel,
			// Token: 0x04034538 RID: 214328
			PureModeRootItem = 14,
			// Token: 0x04034539 RID: 214329
			PureModeItem,
			// Token: 0x0403453A RID: 214330
			PureModeButton
		}

		// Token: 0x0200A96A RID: 43370
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x0403453C RID: 214332
			GamepadFormationPanel = 12,
			// Token: 0x0403453D RID: 214333
			GamepadSkillButtonPanel
		}
	}
}

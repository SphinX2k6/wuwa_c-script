using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D27 RID: 7463
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueMainViewProxy : GameMainViewProxy
{
	// Token: 0x1700121C RID: 4636
	// (get) Token: 0x0600E1F4 RID: 57844 RVA: 0x00350F15 File Offset: 0x0034F115
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
		}
	}

	// Token: 0x0600E1F5 RID: 57845 RVA: 0x00350F20 File Offset: 0x0034F120
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueMainViewProxy.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E1F6 RID: 57846 RVA: 0x00350F63 File Offset: 0x0034F163
	protected override void OnBeforeDestroy()
	{
		this.RemoveScreenEffectFightRoot();
		this.CleanAllBossTrackedMarker();
	}

	// Token: 0x0600E1F7 RID: 57847 RVA: 0x00350F74 File Offset: 0x0034F174
	protected override void OnAfterShow()
	{
		foreach (UiPanelBase uiPanelBase in this.SurvivorsRogueChildPanelMap.Values)
		{
			uiPanelBase.Show(null);
		}
		foreach (SurvivorsRogueBossTrackedMarker survivorsRogueBossTrackedMarker in this.BossTrackedMarkerMap.Values)
		{
			survivorsRogueBossTrackedMarker.Show(null);
		}
		if (this.CurTipsState != (int)SurvivorsRogueModel.Instance.WaveTipsState)
		{
			this.UpdateWaveTipsByState((int)SurvivorsRogueModel.Instance.WaveTipsState);
		}
	}

	// Token: 0x0600E1F8 RID: 57848 RVA: 0x00351034 File Offset: 0x0034F234
	protected override void OnAfterHide()
	{
		foreach (UiPanelBase uiPanelBase in this.SurvivorsRogueChildPanelMap.Values)
		{
			uiPanelBase.Hide(null);
		}
		foreach (SurvivorsRogueBossTrackedMarker survivorsRogueBossTrackedMarker in this.BossTrackedMarkerMap.Values)
		{
			survivorsRogueBossTrackedMarker.Hide(null);
		}
	}

	// Token: 0x0600E1F9 RID: 57849 RVA: 0x003510D0 File Offset: 0x0034F2D0
	protected override void OnTick(float delta)
	{
		float num = delta * Time.Instance.TimeDilation;
		base.OnTick(num);
		if (this.CurTipsState == 2)
		{
			this.CountDownTips.OnTick(num);
		}
		else if (this.CurTipsState == 1)
		{
			this.PopUpWaveTips.OnTick(num);
		}
		this.FightInfoPanel.OnTick(num);
		this.PlayerTrackedMarker.OnTick(num);
		this.RoleStatePanel.OnTick(num);
		foreach (KeyValuePair<int, SurvivorsRogueBossTrackedMarker> keyValuePair in this.BossTrackedMarkerMap)
		{
			keyValuePair.Value.OnTick(num);
		}
	}

	// Token: 0x0600E1FA RID: 57850 RVA: 0x00351190 File Offset: 0x0034F390
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.SurvivorsRogueSwitchWaveTipsState, new Action<int>(this.SwitchWaveTipsState));
		EventSystem.Instance.Add(EEventName.SurvivorsRogueShowBonusWaveTips, new Action(this.ShowBonusWaveTips));
		EventSystem.Instance.Add(EEventName.SurvivorsRogueShowEndlessWaveTips, new Action(this.ShowEndlessWaveTips));
		EventSystem.Instance.Add(EEventName.SurvivorsRogueBossTrackedMarkerUpdate, new Action<int, bool>(this.OnBossTrackedMarkerUpdate));
		EventSystem.Instance.Add(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.ConsecutiveKillCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsComboUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.TreasureBoxCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsChestUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.GoldGainEfficiency.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsPositiveUpdate));
	}

	// Token: 0x0600E1FB RID: 57851 RVA: 0x00351298 File Offset: 0x0034F498
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueSwitchWaveTipsState, new Action<int>(this.SwitchWaveTipsState));
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueShowBonusWaveTips, new Action(this.ShowBonusWaveTips));
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueShowEndlessWaveTips, new Action(this.ShowEndlessWaveTips));
		EventSystem.Instance.Remove(EEventName.SurvivorsRogueBossTrackedMarkerUpdate, new Action<int, bool>(this.OnBossTrackedMarkerUpdate));
		EventSystem.Instance.Remove(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		behaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.ConsecutiveKillCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsComboUpdate));
		behaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.TreasureBoxCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsChestUpdate));
		behaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.GoldGainEfficiency.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsPositiveUpdate));
	}

	// Token: 0x0600E1FC RID: 57852 RVA: 0x003513A0 File Offset: 0x0034F5A0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected UniTask<T> CreateSurvivorsRogueChildPanel<[Nullable(0)] T>(string resourceId, UUIItem parentItem, bool bShow = true) where T : UiPanelBase, new()
	{
		SurvivorsRogueMainViewProxy.<CreateSurvivorsRogueChildPanel>d__24<T> <CreateSurvivorsRogueChildPanel>d__;
		<CreateSurvivorsRogueChildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<CreateSurvivorsRogueChildPanel>d__.<>4__this = this;
		<CreateSurvivorsRogueChildPanel>d__.resourceId = resourceId;
		<CreateSurvivorsRogueChildPanel>d__.parentItem = parentItem;
		<CreateSurvivorsRogueChildPanel>d__.bShow = bShow;
		<CreateSurvivorsRogueChildPanel>d__.<>1__state = -1;
		<CreateSurvivorsRogueChildPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateSurvivorsRogueChildPanel>d__24<T>>(ref <CreateSurvivorsRogueChildPanel>d__);
		return <CreateSurvivorsRogueChildPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E1FD RID: 57853 RVA: 0x003513FC File Offset: 0x0034F5FC
	private void OnSurvivorsCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int currencyNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshCurrencyNum(currencyNum, true);
	}

	// Token: 0x0600E1FE RID: 57854 RVA: 0x00351428 File Offset: 0x0034F628
	private void OnSurvivorsComboUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int comboNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshComboNum(comboNum);
	}

	// Token: 0x0600E1FF RID: 57855 RVA: 0x00351454 File Offset: 0x0034F654
	private void OnSurvivorsChestUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int chestNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshChestNum(chestNum, true);
	}

	// Token: 0x0600E200 RID: 57856 RVA: 0x00351480 File Offset: 0x0034F680
	private void OnSurvivorsPositiveUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int value = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshPositiveArea(value);
	}

	// Token: 0x0600E201 RID: 57857 RVA: 0x003514AC File Offset: 0x0034F6AC
	private void AddScreenEffectFightRoot()
	{
		BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
		if (instance == null || !instance.IsValid())
		{
			return;
		}
		AUIContainerActor screenEffectFightRoot = null;
		instance.GetScreenEffectFightRoot(ref screenEffectFightRoot);
		this.ScreenEffectFightRoot = screenEffectFightRoot;
		AUIContainerActor screenEffectFightRoot2 = this.ScreenEffectFightRoot;
		if (screenEffectFightRoot2 != null)
		{
			screenEffectFightRoot2.K2_AttachRootComponentTo(this.View.GetContentPanel(), default(FName), EAttachLocation.KeepRelativeOffset, true);
		}
		ScreenEffectModel.Instance.SetFightRootInited(true);
	}

	// Token: 0x0600E202 RID: 57858 RVA: 0x00351514 File Offset: 0x0034F714
	private void RemoveScreenEffectFightRoot()
	{
		AUIContainerActor screenEffectFightRoot = this.ScreenEffectFightRoot;
		if (screenEffectFightRoot != null && screenEffectFightRoot.IsValid())
		{
			this.ScreenEffectFightRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		this.ScreenEffectFightRoot = null;
		ScreenEffectModel instance = ScreenEffectModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SetFightRootInited(false);
	}

	// Token: 0x0600E203 RID: 57859 RVA: 0x00351550 File Offset: 0x0034F750
	private UniTask CreateResidentWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateResidentWaveTipsPanel>d__31 <CreateResidentWaveTipsPanel>d__;
		<CreateResidentWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateResidentWaveTipsPanel>d__.<>4__this = this;
		<CreateResidentWaveTipsPanel>d__.<>1__state = -1;
		<CreateResidentWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateResidentWaveTipsPanel>d__31>(ref <CreateResidentWaveTipsPanel>d__);
		return <CreateResidentWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E204 RID: 57860 RVA: 0x00351594 File Offset: 0x0034F794
	private UniTask CreateCountDownTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateCountDownTipsPanel>d__32 <CreateCountDownTipsPanel>d__;
		<CreateCountDownTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCountDownTipsPanel>d__.<>4__this = this;
		<CreateCountDownTipsPanel>d__.<>1__state = -1;
		<CreateCountDownTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateCountDownTipsPanel>d__32>(ref <CreateCountDownTipsPanel>d__);
		return <CreateCountDownTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E205 RID: 57861 RVA: 0x003515D8 File Offset: 0x0034F7D8
	private UniTask CreateBonusWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateBonusWaveTipsPanel>d__33 <CreateBonusWaveTipsPanel>d__;
		<CreateBonusWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBonusWaveTipsPanel>d__.<>4__this = this;
		<CreateBonusWaveTipsPanel>d__.<>1__state = -1;
		<CreateBonusWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateBonusWaveTipsPanel>d__33>(ref <CreateBonusWaveTipsPanel>d__);
		return <CreateBonusWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E206 RID: 57862 RVA: 0x0035161C File Offset: 0x0034F81C
	private UniTask CreateEndlessWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateEndlessWaveTipsPanel>d__34 <CreateEndlessWaveTipsPanel>d__;
		<CreateEndlessWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEndlessWaveTipsPanel>d__.<>4__this = this;
		<CreateEndlessWaveTipsPanel>d__.<>1__state = -1;
		<CreateEndlessWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateEndlessWaveTipsPanel>d__34>(ref <CreateEndlessWaveTipsPanel>d__);
		return <CreateEndlessWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E207 RID: 57863 RVA: 0x00351660 File Offset: 0x0034F860
	private UniTask CreatePopUpWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreatePopUpWaveTipsPanel>d__35 <CreatePopUpWaveTipsPanel>d__;
		<CreatePopUpWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePopUpWaveTipsPanel>d__.<>4__this = this;
		<CreatePopUpWaveTipsPanel>d__.<>1__state = -1;
		<CreatePopUpWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreatePopUpWaveTipsPanel>d__35>(ref <CreatePopUpWaveTipsPanel>d__);
		return <CreatePopUpWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E208 RID: 57864 RVA: 0x003516A4 File Offset: 0x0034F8A4
	private UniTask CreateWaveCompleteTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateWaveCompleteTipsPanel>d__36 <CreateWaveCompleteTipsPanel>d__;
		<CreateWaveCompleteTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateWaveCompleteTipsPanel>d__.<>4__this = this;
		<CreateWaveCompleteTipsPanel>d__.<>1__state = -1;
		<CreateWaveCompleteTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateWaveCompleteTipsPanel>d__36>(ref <CreateWaveCompleteTipsPanel>d__);
		return <CreateWaveCompleteTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E209 RID: 57865 RVA: 0x003516E8 File Offset: 0x0034F8E8
	private UniTask CreatePlayerTrackedMarkerPanel()
	{
		SurvivorsRogueMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__37 <CreatePlayerTrackedMarkerPanel>d__;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePlayerTrackedMarkerPanel>d__.<>4__this = this;
		<CreatePlayerTrackedMarkerPanel>d__.<>1__state = -1;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__37>(ref <CreatePlayerTrackedMarkerPanel>d__);
		return <CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E20A RID: 57866 RVA: 0x0035172C File Offset: 0x0034F92C
	private UniTask CreateRoleStatePanel()
	{
		SurvivorsRogueMainViewProxy.<CreateRoleStatePanel>d__38 <CreateRoleStatePanel>d__;
		<CreateRoleStatePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRoleStatePanel>d__.<>4__this = this;
		<CreateRoleStatePanel>d__.<>1__state = -1;
		<CreateRoleStatePanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateRoleStatePanel>d__38>(ref <CreateRoleStatePanel>d__);
		return <CreateRoleStatePanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E20B RID: 57867 RVA: 0x00351770 File Offset: 0x0034F970
	private UniTask CreateFightInfoPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateFightInfoPanel>d__39 <CreateFightInfoPanel>d__;
		<CreateFightInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFightInfoPanel>d__.<>4__this = this;
		<CreateFightInfoPanel>d__.<>1__state = -1;
		<CreateFightInfoPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateFightInfoPanel>d__39>(ref <CreateFightInfoPanel>d__);
		return <CreateFightInfoPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E20C RID: 57868 RVA: 0x003517B4 File Offset: 0x0034F9B4
	private UniTask CreateMobileSkillPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateMobileSkillPanel>d__40 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateMobileSkillPanel>d__40>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E20D RID: 57869 RVA: 0x003517F8 File Offset: 0x0034F9F8
	private UniTask CreateDesktopSkillPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanel>d__41 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanel>d__41>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E20E RID: 57870 RVA: 0x0035183C File Offset: 0x0034FA3C
	private UniTask CreateMobileSkillPanelInner()
	{
		SurvivorsRogueMainViewProxy.<CreateMobileSkillPanelInner>d__42 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateMobileSkillPanelInner>d__42>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E20F RID: 57871 RVA: 0x00351880 File Offset: 0x0034FA80
	private UniTask CreateDesktopSkillPanelInner()
	{
		SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanelInner>d__43 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanelInner>d__43>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E210 RID: 57872 RVA: 0x003518C4 File Offset: 0x0034FAC4
	private UniTask CreateBossTrackedMarkerPanel(int entityId)
	{
		SurvivorsRogueMainViewProxy.<CreateBossTrackedMarkerPanel>d__44 <CreateBossTrackedMarkerPanel>d__;
		<CreateBossTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBossTrackedMarkerPanel>d__.<>4__this = this;
		<CreateBossTrackedMarkerPanel>d__.entityId = entityId;
		<CreateBossTrackedMarkerPanel>d__.<>1__state = -1;
		<CreateBossTrackedMarkerPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateBossTrackedMarkerPanel>d__44>(ref <CreateBossTrackedMarkerPanel>d__);
		return <CreateBossTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E211 RID: 57873 RVA: 0x0035190F File Offset: 0x0034FB0F
	private void SwitchWaveTipsState(int state)
	{
		this.UpdateWaveTipsByState(state);
	}

	// Token: 0x0600E212 RID: 57874 RVA: 0x00351918 File Offset: 0x0034FB18
	private void ShowBonusWaveTips()
	{
		this.BonusWaveTips.ShowTips();
	}

	// Token: 0x0600E213 RID: 57875 RVA: 0x00351925 File Offset: 0x0034FB25
	private void ShowEndlessWaveTips()
	{
		this.EndlessWaveTips.ShowTips();
	}

	// Token: 0x0600E214 RID: 57876 RVA: 0x00351934 File Offset: 0x0034FB34
	private void OnBossTrackedMarkerUpdate(int entityId, bool isAdd)
	{
		if (isAdd)
		{
			this.CreateBossTrackedMarkerPanel(entityId).Forget();
			return;
		}
		SurvivorsRogueBossTrackedMarker survivorsRogueBossTrackedMarker;
		if (this.BossTrackedMarkerMap.TryGetValue(entityId, out survivorsRogueBossTrackedMarker))
		{
			this.BossTrackedMarkerMap.Remove(entityId);
			survivorsRogueBossTrackedMarker.DelayRecycle();
		}
	}

	// Token: 0x0600E215 RID: 57877 RVA: 0x00351974 File Offset: 0x0034FB74
	private void OnPlayerEntityCreated()
	{
		this.PlayerTrackedMarker.ShowTips();
	}

	// Token: 0x0600E216 RID: 57878 RVA: 0x00351984 File Offset: 0x0034FB84
	public void UpdateWaveTipsByState(int state)
	{
		this.CurTipsState = state;
		switch (state)
		{
		case 0:
			this.PopUpWaveTips.Hide(null);
			this.ResidentWaveTips.HideTips();
			this.CountDownTips.HideTips();
			this.WaveCompleteTips.HideTips();
			this.BonusWaveTips.HideTips();
			this.EndlessWaveTips.HideTips();
			return;
		case 1:
			if (ConfigSurvivorsWaveByLevel.GetConfigList(SurvivorsRogueModel.Instance.CurLevelId, true) != null)
			{
				this.PopUpWaveTips.ShowWaveTips();
				this.FightInfoPanel.SetChestActive(SurvivorsRogueModel.Instance.IsBonusWave);
				this.ResidentWaveTips.HideTips();
				this.CountDownTips.HideTips();
				this.WaveCompleteTips.HideTips();
				this.BonusWaveTips.HideTips();
				this.EndlessWaveTips.HideTips();
				return;
			}
			break;
		case 2:
			this.CountDownTips.InitCountDown((float)SurvivorsRogueConfig.Instance.GetWaveDuration(SurvivorsRogueModel.Instance.CurLevelId, SurvivorsRogueModel.Instance.CurWaveNum), SurvivorsRogueModel.Instance.IsEndlessWave);
			this.PopUpWaveTips.Hide(null);
			this.ResidentWaveTips.ShowTips();
			this.CountDownTips.ShowTips();
			this.WaveCompleteTips.HideTips();
			this.BonusWaveTips.HideTips();
			this.EndlessWaveTips.HideTips();
			return;
		case 3:
			this.CleanAllBossTrackedMarker();
			this.PopUpWaveTips.Hide(null);
			this.ResidentWaveTips.HideTips();
			this.CountDownTips.HideTips();
			this.WaveCompleteTips.ShowTips();
			this.BonusWaveTips.HideTips();
			this.EndlessWaveTips.HideTips();
			this.FightInfoPanel.ResetFightInfo();
			break;
		default:
			return;
		}
	}

	// Token: 0x0600E217 RID: 57879 RVA: 0x00351B2C File Offset: 0x0034FD2C
	private void CleanAllBossTrackedMarker()
	{
		if (this.BossTrackedMarkerMap.Count == 0)
		{
			return;
		}
		Log.Instance.Warn(ELogModule.SurvivorsRogue, ELogAuthor.CK, "结束战斗阶段时有BOSS追踪图标残留, 强制清除", default(ReadOnlySpan<ValueTuple<string, object>>));
		foreach (SurvivorsRogueBossTrackedMarker survivorsRogueBossTrackedMarker in this.BossTrackedMarkerMap.Values)
		{
			survivorsRogueBossTrackedMarker.Recycle();
		}
		this.BossTrackedMarkerMap.Clear();
	}

	// Token: 0x04006884 RID: 26756
	protected Dictionary<Type, UiPanelBase> SurvivorsRogueChildPanelMap = new Dictionary<Type, UiPanelBase>();

	// Token: 0x04006885 RID: 26757
	public SurvivorsRogueRoleStatePanel RoleStatePanel;

	// Token: 0x04006886 RID: 26758
	public SurvivorsRogueFightInfoPanel FightInfoPanel;

	// Token: 0x04006887 RID: 26759
	public SurvivorsRogueTipsPanelBase BonusWaveTips;

	// Token: 0x04006888 RID: 26760
	public SurvivorsRoguePopUpWaveTipsPanel PopUpWaveTips;

	// Token: 0x04006889 RID: 26761
	[Nullable(2)]
	public SurvivorsRogueSkillPanel MobileSkillPanel;

	// Token: 0x0400688A RID: 26762
	[Nullable(2)]
	public SurvivorsRogueSkillPanel DesktopSkillPanel;

	// Token: 0x0400688B RID: 26763
	public SurvivorsRogueResidentWaveTipsPanel ResidentWaveTips;

	// Token: 0x0400688C RID: 26764
	public SurvivorsRogueTipsPanelBase EndlessWaveTips;

	// Token: 0x0400688D RID: 26765
	public SurvivorsRogueCountDownTipsPanel CountDownTips;

	// Token: 0x0400688E RID: 26766
	public SurvivorsRogueTipsPanelBase WaveCompleteTips;

	// Token: 0x0400688F RID: 26767
	private readonly Dictionary<int, SurvivorsRogueBossTrackedMarker> BossTrackedMarkerMap = new Dictionary<int, SurvivorsRogueBossTrackedMarker>();

	// Token: 0x04006890 RID: 26768
	private SurvivorsRoguePlayerTrackerMarker PlayerTrackedMarker;

	// Token: 0x04006891 RID: 26769
	[Nullable(2)]
	private AUIContainerActor ScreenEffectFightRoot;

	// Token: 0x04006892 RID: 26770
	private int CurTipsState;
}

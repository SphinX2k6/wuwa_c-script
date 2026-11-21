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

// Token: 0x020011E9 RID: 4585
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001246 RID: 4678
	// (get) Token: 0x0600B611 RID: 46609 RVA: 0x0035C945 File Offset: 0x0035AB45
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
		}
	}

	// Token: 0x0600B612 RID: 46610 RVA: 0x0035C950 File Offset: 0x0035AB50
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueMainViewProxy.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B613 RID: 46611 RVA: 0x0035C993 File Offset: 0x0035AB93
	protected override void OnBeforeDestroy()
	{
		this.RemoveScreenEffectFightRoot();
		this.CleanAllBossTrackedMarker();
	}

	// Token: 0x0600B614 RID: 46612 RVA: 0x0035C9A4 File Offset: 0x0035ABA4
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

	// Token: 0x0600B615 RID: 46613 RVA: 0x0035CA64 File Offset: 0x0035AC64
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

	// Token: 0x0600B616 RID: 46614 RVA: 0x0035CB00 File Offset: 0x0035AD00
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

	// Token: 0x0600B617 RID: 46615 RVA: 0x0035CBC0 File Offset: 0x0035ADC0
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

	// Token: 0x0600B618 RID: 46616 RVA: 0x0035CCC8 File Offset: 0x0035AEC8
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

	// Token: 0x0600B619 RID: 46617 RVA: 0x0035CDD0 File Offset: 0x0035AFD0
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

	// Token: 0x0600B61A RID: 46618 RVA: 0x0035CE2C File Offset: 0x0035B02C
	private void OnSurvivorsCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int currencyNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshCurrencyNum(currencyNum, true);
	}

	// Token: 0x0600B61B RID: 46619 RVA: 0x0035CE58 File Offset: 0x0035B058
	private void OnSurvivorsComboUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int comboNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshComboNum(comboNum);
	}

	// Token: 0x0600B61C RID: 46620 RVA: 0x0035CE84 File Offset: 0x0035B084
	private void OnSurvivorsChestUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int chestNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshChestNum(chestNum, true);
	}

	// Token: 0x0600B61D RID: 46621 RVA: 0x0035CEB0 File Offset: 0x0035B0B0
	private void OnSurvivorsPositiveUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int value = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.FightInfoPanel.RefreshPositiveArea(value);
	}

	// Token: 0x0600B61E RID: 46622 RVA: 0x0035CEDC File Offset: 0x0035B0DC
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

	// Token: 0x0600B61F RID: 46623 RVA: 0x0035CF44 File Offset: 0x0035B144
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

	// Token: 0x0600B620 RID: 46624 RVA: 0x0035CF80 File Offset: 0x0035B180
	private UniTask CreateResidentWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateResidentWaveTipsPanel>d__31 <CreateResidentWaveTipsPanel>d__;
		<CreateResidentWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateResidentWaveTipsPanel>d__.<>4__this = this;
		<CreateResidentWaveTipsPanel>d__.<>1__state = -1;
		<CreateResidentWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateResidentWaveTipsPanel>d__31>(ref <CreateResidentWaveTipsPanel>d__);
		return <CreateResidentWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B621 RID: 46625 RVA: 0x0035CFC4 File Offset: 0x0035B1C4
	private UniTask CreateCountDownTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateCountDownTipsPanel>d__32 <CreateCountDownTipsPanel>d__;
		<CreateCountDownTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCountDownTipsPanel>d__.<>4__this = this;
		<CreateCountDownTipsPanel>d__.<>1__state = -1;
		<CreateCountDownTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateCountDownTipsPanel>d__32>(ref <CreateCountDownTipsPanel>d__);
		return <CreateCountDownTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B622 RID: 46626 RVA: 0x0035D008 File Offset: 0x0035B208
	private UniTask CreateBonusWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateBonusWaveTipsPanel>d__33 <CreateBonusWaveTipsPanel>d__;
		<CreateBonusWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBonusWaveTipsPanel>d__.<>4__this = this;
		<CreateBonusWaveTipsPanel>d__.<>1__state = -1;
		<CreateBonusWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateBonusWaveTipsPanel>d__33>(ref <CreateBonusWaveTipsPanel>d__);
		return <CreateBonusWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B623 RID: 46627 RVA: 0x0035D04C File Offset: 0x0035B24C
	private UniTask CreateEndlessWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateEndlessWaveTipsPanel>d__34 <CreateEndlessWaveTipsPanel>d__;
		<CreateEndlessWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEndlessWaveTipsPanel>d__.<>4__this = this;
		<CreateEndlessWaveTipsPanel>d__.<>1__state = -1;
		<CreateEndlessWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateEndlessWaveTipsPanel>d__34>(ref <CreateEndlessWaveTipsPanel>d__);
		return <CreateEndlessWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B624 RID: 46628 RVA: 0x0035D090 File Offset: 0x0035B290
	private UniTask CreatePopUpWaveTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreatePopUpWaveTipsPanel>d__35 <CreatePopUpWaveTipsPanel>d__;
		<CreatePopUpWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePopUpWaveTipsPanel>d__.<>4__this = this;
		<CreatePopUpWaveTipsPanel>d__.<>1__state = -1;
		<CreatePopUpWaveTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreatePopUpWaveTipsPanel>d__35>(ref <CreatePopUpWaveTipsPanel>d__);
		return <CreatePopUpWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B625 RID: 46629 RVA: 0x0035D0D4 File Offset: 0x0035B2D4
	private UniTask CreateWaveCompleteTipsPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateWaveCompleteTipsPanel>d__36 <CreateWaveCompleteTipsPanel>d__;
		<CreateWaveCompleteTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateWaveCompleteTipsPanel>d__.<>4__this = this;
		<CreateWaveCompleteTipsPanel>d__.<>1__state = -1;
		<CreateWaveCompleteTipsPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateWaveCompleteTipsPanel>d__36>(ref <CreateWaveCompleteTipsPanel>d__);
		return <CreateWaveCompleteTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B626 RID: 46630 RVA: 0x0035D118 File Offset: 0x0035B318
	private UniTask CreatePlayerTrackedMarkerPanel()
	{
		SurvivorsRogueMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__37 <CreatePlayerTrackedMarkerPanel>d__;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePlayerTrackedMarkerPanel>d__.<>4__this = this;
		<CreatePlayerTrackedMarkerPanel>d__.<>1__state = -1;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__37>(ref <CreatePlayerTrackedMarkerPanel>d__);
		return <CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B627 RID: 46631 RVA: 0x0035D15C File Offset: 0x0035B35C
	private UniTask CreateRoleStatePanel()
	{
		SurvivorsRogueMainViewProxy.<CreateRoleStatePanel>d__38 <CreateRoleStatePanel>d__;
		<CreateRoleStatePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRoleStatePanel>d__.<>4__this = this;
		<CreateRoleStatePanel>d__.<>1__state = -1;
		<CreateRoleStatePanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateRoleStatePanel>d__38>(ref <CreateRoleStatePanel>d__);
		return <CreateRoleStatePanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B628 RID: 46632 RVA: 0x0035D1A0 File Offset: 0x0035B3A0
	private UniTask CreateFightInfoPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateFightInfoPanel>d__39 <CreateFightInfoPanel>d__;
		<CreateFightInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFightInfoPanel>d__.<>4__this = this;
		<CreateFightInfoPanel>d__.<>1__state = -1;
		<CreateFightInfoPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateFightInfoPanel>d__39>(ref <CreateFightInfoPanel>d__);
		return <CreateFightInfoPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B629 RID: 46633 RVA: 0x0035D1E4 File Offset: 0x0035B3E4
	private UniTask CreateMobileSkillPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateMobileSkillPanel>d__40 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateMobileSkillPanel>d__40>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B62A RID: 46634 RVA: 0x0035D228 File Offset: 0x0035B428
	private UniTask CreateDesktopSkillPanel()
	{
		SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanel>d__41 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanel>d__41>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B62B RID: 46635 RVA: 0x0035D26C File Offset: 0x0035B46C
	private UniTask CreateMobileSkillPanelInner()
	{
		SurvivorsRogueMainViewProxy.<CreateMobileSkillPanelInner>d__42 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateMobileSkillPanelInner>d__42>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B62C RID: 46636 RVA: 0x0035D2B0 File Offset: 0x0035B4B0
	private UniTask CreateDesktopSkillPanelInner()
	{
		SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanelInner>d__43 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<SurvivorsRogueMainViewProxy.<CreateDesktopSkillPanelInner>d__43>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B62D RID: 46637 RVA: 0x0035D2F4 File Offset: 0x0035B4F4
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

	// Token: 0x0600B62E RID: 46638 RVA: 0x0035D33F File Offset: 0x0035B53F
	private void SwitchWaveTipsState(int state)
	{
		this.UpdateWaveTipsByState(state);
	}

	// Token: 0x0600B62F RID: 46639 RVA: 0x0035D348 File Offset: 0x0035B548
	private void ShowBonusWaveTips()
	{
		this.BonusWaveTips.ShowTips();
	}

	// Token: 0x0600B630 RID: 46640 RVA: 0x0035D355 File Offset: 0x0035B555
	private void ShowEndlessWaveTips()
	{
		this.EndlessWaveTips.ShowTips();
	}

	// Token: 0x0600B631 RID: 46641 RVA: 0x0035D364 File Offset: 0x0035B564
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

	// Token: 0x0600B632 RID: 46642 RVA: 0x0035D3A4 File Offset: 0x0035B5A4
	private void OnPlayerEntityCreated()
	{
		this.PlayerTrackedMarker.ShowTips();
	}

	// Token: 0x0600B633 RID: 46643 RVA: 0x0035D3B4 File Offset: 0x0035B5B4
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

	// Token: 0x0600B634 RID: 46644 RVA: 0x0035D55C File Offset: 0x0035B75C
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

	// Token: 0x04006963 RID: 26979
	protected Dictionary<Type, UiPanelBase> SurvivorsRogueChildPanelMap = new Dictionary<Type, UiPanelBase>();

	// Token: 0x04006964 RID: 26980
	public SurvivorsRogueRoleStatePanel RoleStatePanel;

	// Token: 0x04006965 RID: 26981
	public SurvivorsRogueFightInfoPanel FightInfoPanel;

	// Token: 0x04006966 RID: 26982
	public SurvivorsRogueTipsPanelBase BonusWaveTips;

	// Token: 0x04006967 RID: 26983
	public SurvivorsRoguePopUpWaveTipsPanel PopUpWaveTips;

	// Token: 0x04006968 RID: 26984
	[Nullable(2)]
	public SurvivorsRogueSkillPanel MobileSkillPanel;

	// Token: 0x04006969 RID: 26985
	[Nullable(2)]
	public SurvivorsRogueSkillPanel DesktopSkillPanel;

	// Token: 0x0400696A RID: 26986
	public SurvivorsRogueResidentWaveTipsPanel ResidentWaveTips;

	// Token: 0x0400696B RID: 26987
	public SurvivorsRogueTipsPanelBase EndlessWaveTips;

	// Token: 0x0400696C RID: 26988
	public SurvivorsRogueCountDownTipsPanel CountDownTips;

	// Token: 0x0400696D RID: 26989
	public SurvivorsRogueTipsPanelBase WaveCompleteTips;

	// Token: 0x0400696E RID: 26990
	private readonly Dictionary<int, SurvivorsRogueBossTrackedMarker> BossTrackedMarkerMap = new Dictionary<int, SurvivorsRogueBossTrackedMarker>();

	// Token: 0x0400696F RID: 26991
	private SurvivorsRoguePlayerTrackerMarker PlayerTrackedMarker;

	// Token: 0x04006970 RID: 26992
	[Nullable(2)]
	private AUIContainerActor ScreenEffectFightRoot;

	// Token: 0x04006971 RID: 26993
	private int CurTipsState;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001185 RID: 4485
[NullableContext(1)]
[Nullable(0)]
public class KurotatoMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001231 RID: 4657
	// (get) Token: 0x0600B2E3 RID: 45795 RVA: 0x0034DAA2 File Offset: 0x0034BCA2
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.Kurotato);
		}
	}

	// Token: 0x0600B2E4 RID: 45796 RVA: 0x0034DAAC File Offset: 0x0034BCAC
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoMainViewProxy.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoMainViewProxy.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2E5 RID: 45797 RVA: 0x0034DAF0 File Offset: 0x0034BCF0
	protected override void OnBeforeDestroy()
	{
		this.ClearStepAdvanceTimer();
		this.KurotatoCleanAllBossTrackedMarker();
		this.KurotatoCleanAllTreasureBoxTrackedMarker();
		foreach (UiPanelBase uiPanelBase in this.KurotatoChildPanelMap.Values)
		{
			uiPanelBase.Destroy(null);
		}
		this.KurotatoChildPanelMap.Clear();
	}

	// Token: 0x0600B2E6 RID: 45798 RVA: 0x0034DB64 File Offset: 0x0034BD64
	protected override void OnStart()
	{
		this.AttrChangePanel.SetUiActive(false);
	}

	// Token: 0x0600B2E7 RID: 45799 RVA: 0x0034DB74 File Offset: 0x0034BD74
	protected override void OnAfterShow()
	{
		foreach (UiPanelBase uiPanelBase in this.KurotatoChildPanelMap.Values)
		{
			uiPanelBase.Show(null);
		}
		foreach (KurotatoBossTrackedMarker kurotatoBossTrackedMarker in this.KurotatoBossTrackedMarkerMap.Values)
		{
			kurotatoBossTrackedMarker.Show(null);
		}
		foreach (KurotatoTreasureBoxTrackedMarker kurotatoTreasureBoxTrackedMarker in this.KurotatoTreasureBoxTrackedMarkerMap.Values)
		{
			kurotatoTreasureBoxTrackedMarker.Show(null);
		}
		BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.Kurotato);
		if (this.CurStep != KurotatoModel.Instance.GetStep())
		{
			this.UpdateTipsByState(KurotatoModel.Instance.GetStep());
		}
	}

	// Token: 0x0600B2E8 RID: 45800 RVA: 0x0034DC88 File Offset: 0x0034BE88
	protected override void OnAfterHide()
	{
		foreach (UiPanelBase uiPanelBase in this.KurotatoChildPanelMap.Values)
		{
			uiPanelBase.Hide(null);
		}
		foreach (KurotatoBossTrackedMarker kurotatoBossTrackedMarker in this.KurotatoBossTrackedMarkerMap.Values)
		{
			kurotatoBossTrackedMarker.Hide(null);
		}
		foreach (KurotatoTreasureBoxTrackedMarker kurotatoTreasureBoxTrackedMarker in this.KurotatoTreasureBoxTrackedMarkerMap.Values)
		{
			kurotatoTreasureBoxTrackedMarker.Hide(null);
		}
		BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.Kurotato);
	}

	// Token: 0x0600B2E9 RID: 45801 RVA: 0x0034DD78 File Offset: 0x0034BF78
	protected override void OnTick(float delta)
	{
		if (this.CurStep == EKurotatoStep.Combat)
		{
			this.CountDownTips.OnTick(delta);
		}
		this.ResidentWaveTips.OnTick(delta);
		this.PlayerTrackedMarker.OnTick(delta);
		this.MainPanel.OnTick(delta);
		foreach (KeyValuePair<int, KurotatoBossTrackedMarker> keyValuePair in this.KurotatoBossTrackedMarkerMap)
		{
			keyValuePair.Value.OnTick(delta);
		}
		foreach (KeyValuePair<int, KurotatoTreasureBoxTrackedMarker> keyValuePair2 in this.KurotatoTreasureBoxTrackedMarkerMap)
		{
			keyValuePair2.Value.OnTick(delta);
		}
		this.AttrChangePanel.OnTick(delta);
	}

	// Token: 0x0600B2EA RID: 45802 RVA: 0x0034DE60 File Offset: 0x0034C060
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EKurotatoStep>(EEventName.KurotatoOnStepChanged, new Action<EKurotatoStep>(this.OnStepChanged));
		EventSystem.Instance.Add<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnPropertyUpdate));
		EventSystem.Instance.Add<int, bool>(EEventName.KurotatoBossTrackedMarkerUpdate, new Action<int, bool>(this.OnKurotatoBossTrackedMarkerUpdate));
		EventSystem.Instance.Add<int, bool>(EEventName.KurotatoTreasureBoxTrackedMarkerUpdate, new Action<int, bool>(this.OnKurotatoTreasureBoxTrackedMarkerUpdate));
		EventSystem.Instance.Add(EEventName.KurotatoOnPlayerDie, new Action(this.OnPlayerDie));
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = KurotatoModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnCurrencyUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.SpareGold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSpareGoldUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.TreasureBoxCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnChestUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.UpgradeCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnUpgradeCountUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.TotalRoleExp.ToEnumString(), new TTreeVarUpdateDelegate(this.OnExpUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.ConsecutiveKillCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnComboUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.RoleLevel.ToEnumString(), new TTreeVarUpdateDelegate(this.OnRoleLevelUpdate));
	}

	// Token: 0x0600B2EB RID: 45803 RVA: 0x0034DFB4 File Offset: 0x0034C1B4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EKurotatoStep>(EEventName.KurotatoOnStepChanged, new Action<EKurotatoStep>(this.OnStepChanged));
		EventSystem.Instance.Remove<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnPropertyUpdate));
		EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoBossTrackedMarkerUpdate, new Action<int, bool>(this.OnKurotatoBossTrackedMarkerUpdate));
		EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoTreasureBoxTrackedMarkerUpdate, new Action<int, bool>(this.OnKurotatoTreasureBoxTrackedMarkerUpdate));
		EventSystem.Instance.Remove(EEventName.KurotatoOnPlayerDie, new Action(this.OnPlayerDie));
	}

	// Token: 0x0600B2EC RID: 45804 RVA: 0x0034E050 File Offset: 0x0034C250
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

	// Token: 0x0600B2ED RID: 45805 RVA: 0x0034E0B8 File Offset: 0x0034C2B8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected UniTask<T> CreateKurotatoChildPanel<[Nullable(0)] T>(string resourceId, UUIItem parentItem, bool bShow = true) where T : UiPanelBase, new()
	{
		KurotatoMainViewProxy.<CreateKurotatoChildPanel>d__26<T> <CreateKurotatoChildPanel>d__;
		<CreateKurotatoChildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<CreateKurotatoChildPanel>d__.<>4__this = this;
		<CreateKurotatoChildPanel>d__.resourceId = resourceId;
		<CreateKurotatoChildPanel>d__.parentItem = parentItem;
		<CreateKurotatoChildPanel>d__.bShow = bShow;
		<CreateKurotatoChildPanel>d__.<>1__state = -1;
		<CreateKurotatoChildPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateKurotatoChildPanel>d__26<T>>(ref <CreateKurotatoChildPanel>d__);
		return <CreateKurotatoChildPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2EE RID: 45806 RVA: 0x0034E114 File Offset: 0x0034C314
	private UniTask CreateResidentWaveTipsPanel()
	{
		KurotatoMainViewProxy.<CreateResidentWaveTipsPanel>d__27 <CreateResidentWaveTipsPanel>d__;
		<CreateResidentWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateResidentWaveTipsPanel>d__.<>4__this = this;
		<CreateResidentWaveTipsPanel>d__.<>1__state = -1;
		<CreateResidentWaveTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateResidentWaveTipsPanel>d__27>(ref <CreateResidentWaveTipsPanel>d__);
		return <CreateResidentWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2EF RID: 45807 RVA: 0x0034E158 File Offset: 0x0034C358
	private UniTask CreateCountDownTipsPanel()
	{
		KurotatoMainViewProxy.<CreateCountDownTipsPanel>d__28 <CreateCountDownTipsPanel>d__;
		<CreateCountDownTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCountDownTipsPanel>d__.<>4__this = this;
		<CreateCountDownTipsPanel>d__.<>1__state = -1;
		<CreateCountDownTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateCountDownTipsPanel>d__28>(ref <CreateCountDownTipsPanel>d__);
		return <CreateCountDownTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F0 RID: 45808 RVA: 0x0034E19C File Offset: 0x0034C39C
	private UniTask CreatePlayerTrackedMarkerPanel()
	{
		KurotatoMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__29 <CreatePlayerTrackedMarkerPanel>d__;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePlayerTrackedMarkerPanel>d__.<>4__this = this;
		<CreatePlayerTrackedMarkerPanel>d__.<>1__state = -1;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__29>(ref <CreatePlayerTrackedMarkerPanel>d__);
		return <CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F1 RID: 45809 RVA: 0x0034E1E0 File Offset: 0x0034C3E0
	private UniTask CreateMainPanel()
	{
		KurotatoMainViewProxy.<CreateMainPanel>d__30 <CreateMainPanel>d__;
		<CreateMainPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMainPanel>d__.<>4__this = this;
		<CreateMainPanel>d__.<>1__state = -1;
		<CreateMainPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateMainPanel>d__30>(ref <CreateMainPanel>d__);
		return <CreateMainPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F2 RID: 45810 RVA: 0x0034E224 File Offset: 0x0034C424
	private UniTask CreateAttrChangePanel()
	{
		KurotatoMainViewProxy.<CreateAttrChangePanel>d__31 <CreateAttrChangePanel>d__;
		<CreateAttrChangePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAttrChangePanel>d__.<>4__this = this;
		<CreateAttrChangePanel>d__.<>1__state = -1;
		<CreateAttrChangePanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateAttrChangePanel>d__31>(ref <CreateAttrChangePanel>d__);
		return <CreateAttrChangePanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F3 RID: 45811 RVA: 0x0034E268 File Offset: 0x0034C468
	private UniTask CreateWaveTipsPanel()
	{
		KurotatoMainViewProxy.<CreateWaveTipsPanel>d__32 <CreateWaveTipsPanel>d__;
		<CreateWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateWaveTipsPanel>d__.<>4__this = this;
		<CreateWaveTipsPanel>d__.<>1__state = -1;
		<CreateWaveTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateWaveTipsPanel>d__32>(ref <CreateWaveTipsPanel>d__);
		return <CreateWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F4 RID: 45812 RVA: 0x0034E2AC File Offset: 0x0034C4AC
	private UniTask CreateBossSpawnTipsPanel()
	{
		KurotatoMainViewProxy.<CreateBossSpawnTipsPanel>d__33 <CreateBossSpawnTipsPanel>d__;
		<CreateBossSpawnTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBossSpawnTipsPanel>d__.<>4__this = this;
		<CreateBossSpawnTipsPanel>d__.<>1__state = -1;
		<CreateBossSpawnTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateBossSpawnTipsPanel>d__33>(ref <CreateBossSpawnTipsPanel>d__);
		return <CreateBossSpawnTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F5 RID: 45813 RVA: 0x0034E2F0 File Offset: 0x0034C4F0
	private UniTask CreateEliteWaveTipsPanel()
	{
		KurotatoMainViewProxy.<CreateEliteWaveTipsPanel>d__34 <CreateEliteWaveTipsPanel>d__;
		<CreateEliteWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEliteWaveTipsPanel>d__.<>4__this = this;
		<CreateEliteWaveTipsPanel>d__.<>1__state = -1;
		<CreateEliteWaveTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateEliteWaveTipsPanel>d__34>(ref <CreateEliteWaveTipsPanel>d__);
		return <CreateEliteWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2F6 RID: 45814 RVA: 0x0034E334 File Offset: 0x0034C534
	public void UpdateTipsByState(EKurotatoStep state)
	{
		this.CurStep = state;
		KurotatoModel instance = KurotatoModel.Instance;
		switch (state)
		{
		case EKurotatoStep.Combat:
			if (instance.GetIsStepStart())
			{
				this.CountDownTips.InitCountDown((float)instance.GetWaveDuration());
				this.ResidentWaveTips.ShowTips();
				this.CountDownTips.ShowTips();
				this.MainPanel.RefreshExp();
				if (instance.GetIsCurWaveBoss())
				{
					this.BossSpawnTipsPanel.PlayBossSpawn();
					return;
				}
				if (instance.GetIsCurWaveElite())
				{
					this.EliteWaveTipsPanel.PlayEliteWave();
					return;
				}
			}
			break;
		case EKurotatoStep.ChestReward:
		case EKurotatoStep.Shop:
		case EKurotatoStep.WaveUpdate:
		case EKurotatoStep.UpgradeReward:
		case EKurotatoStep.Prepare:
			break;
		case EKurotatoStep.End:
			if (instance.GetIsStepStart())
			{
				this.CountDownTips.HideTips();
				this.WaveTipsPanel.PlaySuccess("Kurotato_LevelSucceed");
				this.StartStepAdvanceWatch();
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600B2F7 RID: 45815 RVA: 0x0034E400 File Offset: 0x0034C600
	private void OnStepChanged(EKurotatoStep step)
	{
		this.UpdateTipsByState(step);
	}

	// Token: 0x0600B2F8 RID: 45816 RVA: 0x0034E409 File Offset: 0x0034C609
	private void OnPropertyUpdate(IDictionary<int, int> propertyValues)
	{
		this.AttrChangePanel.ShowAttrChange(propertyValues);
	}

	// Token: 0x0600B2F9 RID: 45817 RVA: 0x0034E418 File Offset: 0x0034C618
	private void OnCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		int increment = (lastVarDefine != null) ? (num - (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int)) : 0;
		this.MainPanel.RefreshCurrencyNum(num, increment);
	}

	// Token: 0x0600B2FA RID: 45818 RVA: 0x0034E460 File Offset: 0x0034C660
	private void OnSpareGoldUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		int increment = (lastVarDefine != null) ? (num - (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int)) : 0;
		this.MainPanel.RefreshSpareGold(num, increment);
	}

	// Token: 0x0600B2FB RID: 45819 RVA: 0x0034E4A8 File Offset: 0x0034C6A8
	private void OnChestUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		bool bPlayAcquireAnim = lastVarDefine != null && num > (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int);
		this.MainPanel.RefreshChestCount(num, bPlayAcquireAnim);
	}

	// Token: 0x0600B2FC RID: 45820 RVA: 0x0034E4F0 File Offset: 0x0034C6F0
	private void OnUpgradeCountUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		bool bPlayAcquireAnim = lastVarDefine != null && num > (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int);
		this.MainPanel.RefreshLevelUpCount(num, bPlayAcquireAnim);
	}

	// Token: 0x0600B2FD RID: 45821 RVA: 0x0034E537 File Offset: 0x0034C737
	private void OnExpUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.MainPanel.RefreshExp();
	}

	// Token: 0x0600B2FE RID: 45822 RVA: 0x0034E544 File Offset: 0x0034C744
	private void OnComboUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int comboNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.MainPanel.RefreshComboNum(comboNum);
	}

	// Token: 0x0600B2FF RID: 45823 RVA: 0x0034E570 File Offset: 0x0034C770
	private void OnRoleLevelUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (lastVarDefine != null) ? ((int)MathUtils.Instance.LongToNumber(lastVarDefine.Int)) : 0;
		int num2 = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		if (num <= 0 || num2 <= num)
		{
			return;
		}
		this.AttrChangePanel.ShowLevelUp();
		this.MainPanel.PlayLvUpAnim();
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "KurotatoRoleLevelUp");
	}

	// Token: 0x0600B300 RID: 45824 RVA: 0x0034E5E0 File Offset: 0x0034C7E0
	private void OnPlayerDie()
	{
		this.WaveTipsPanel.PlayFail("Kurotato_LevelFail");
		foreach (KurotatoBossTrackedMarker kurotatoBossTrackedMarker in this.KurotatoBossTrackedMarkerMap.Values)
		{
			kurotatoBossTrackedMarker.DelayRecycle();
		}
		this.KurotatoBossTrackedMarkerMap.Clear();
		foreach (KurotatoTreasureBoxTrackedMarker kurotatoTreasureBoxTrackedMarker in this.KurotatoTreasureBoxTrackedMarkerMap.Values)
		{
			kurotatoTreasureBoxTrackedMarker.DelayRecycle();
		}
		this.KurotatoTreasureBoxTrackedMarkerMap.Clear();
	}

	// Token: 0x0600B301 RID: 45825 RVA: 0x0034E6A0 File Offset: 0x0034C8A0
	private void StartStepAdvanceWatch()
	{
		this.ClearStepAdvanceTimer();
		this.StepAdvanceTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.TriggerStepAdvance();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600B302 RID: 45826 RVA: 0x0034E6D1 File Offset: 0x0034C8D1
	private void OnWaveTipsFinish()
	{
		this.TriggerStepAdvance();
	}

	// Token: 0x0600B303 RID: 45827 RVA: 0x0034E6DC File Offset: 0x0034C8DC
	private void TriggerStepAdvance()
	{
		TimerHandle stepAdvanceTimer = this.StepAdvanceTimer;
		if (stepAdvanceTimer != null && stepAdvanceTimer.Valid())
		{
			this.StepAdvanceTimer.Remove();
		}
		this.StepAdvanceTimer = null;
		if (KurotatoModel.Instance.GetStep() != EKurotatoStep.End)
		{
			return;
		}
		KurotatoController.Instance.RequestKurotatoStepAdvance().Forget<bool>();
	}

	// Token: 0x0600B304 RID: 45828 RVA: 0x0034E72D File Offset: 0x0034C92D
	private void ClearStepAdvanceTimer()
	{
		if (this.StepAdvanceTimer != null)
		{
			this.StepAdvanceTimer.Remove();
			this.StepAdvanceTimer = null;
		}
	}

	// Token: 0x0600B305 RID: 45829 RVA: 0x0034E74C File Offset: 0x0034C94C
	private UniTask CreateKurotatoBossTrackedMarkerPanel(int entityId)
	{
		KurotatoMainViewProxy.<CreateKurotatoBossTrackedMarkerPanel>d__50 <CreateKurotatoBossTrackedMarkerPanel>d__;
		<CreateKurotatoBossTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateKurotatoBossTrackedMarkerPanel>d__.<>4__this = this;
		<CreateKurotatoBossTrackedMarkerPanel>d__.entityId = entityId;
		<CreateKurotatoBossTrackedMarkerPanel>d__.<>1__state = -1;
		<CreateKurotatoBossTrackedMarkerPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateKurotatoBossTrackedMarkerPanel>d__50>(ref <CreateKurotatoBossTrackedMarkerPanel>d__);
		return <CreateKurotatoBossTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B306 RID: 45830 RVA: 0x0034E798 File Offset: 0x0034C998
	public void OnKurotatoBossTrackedMarkerUpdate(int entityId, bool isAdd)
	{
		if (isAdd)
		{
			this.CreateKurotatoBossTrackedMarkerPanel(entityId).Forget();
			return;
		}
		KurotatoBossTrackedMarker kurotatoBossTrackedMarker;
		if (this.KurotatoBossTrackedMarkerMap.TryGetValue(entityId, out kurotatoBossTrackedMarker))
		{
			this.KurotatoBossTrackedMarkerMap.Remove(entityId);
			kurotatoBossTrackedMarker.DelayRecycle();
		}
	}

	// Token: 0x0600B307 RID: 45831 RVA: 0x0034E7D8 File Offset: 0x0034C9D8
	private void KurotatoCleanAllBossTrackedMarker()
	{
		if (this.KurotatoBossTrackedMarkerMap.Count == 0)
		{
			return;
		}
		Log.Instance.Warn(ELogModule.Kurotato, ELogAuthor.LYX, "结束战斗阶段时有BOSS追踪图标残留, 强制清除", default(ReadOnlySpan<ValueTuple<string, object>>));
		foreach (KurotatoBossTrackedMarker kurotatoBossTrackedMarker in this.KurotatoBossTrackedMarkerMap.Values)
		{
			kurotatoBossTrackedMarker.Recycle();
		}
		this.KurotatoBossTrackedMarkerMap.Clear();
	}

	// Token: 0x0600B308 RID: 45832 RVA: 0x0034E868 File Offset: 0x0034CA68
	private UniTask CreateKurotatoTreasureBoxTrackedMarkerPanel(int entityId)
	{
		KurotatoMainViewProxy.<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__53 <CreateKurotatoTreasureBoxTrackedMarkerPanel>d__;
		<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__.<>4__this = this;
		<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__.entityId = entityId;
		<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__.<>1__state = -1;
		<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateKurotatoTreasureBoxTrackedMarkerPanel>d__53>(ref <CreateKurotatoTreasureBoxTrackedMarkerPanel>d__);
		return <CreateKurotatoTreasureBoxTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B309 RID: 45833 RVA: 0x0034E8B4 File Offset: 0x0034CAB4
	public void OnKurotatoTreasureBoxTrackedMarkerUpdate(int entityId, bool isAdd)
	{
		if (isAdd)
		{
			this.CreateKurotatoTreasureBoxTrackedMarkerPanel(entityId).Forget();
			return;
		}
		KurotatoTreasureBoxTrackedMarker kurotatoTreasureBoxTrackedMarker;
		if (this.KurotatoTreasureBoxTrackedMarkerMap.TryGetValue(entityId, out kurotatoTreasureBoxTrackedMarker))
		{
			this.KurotatoTreasureBoxTrackedMarkerMap.Remove(entityId);
			kurotatoTreasureBoxTrackedMarker.DelayRecycle();
		}
	}

	// Token: 0x0600B30A RID: 45834 RVA: 0x0034E8F4 File Offset: 0x0034CAF4
	private void KurotatoCleanAllTreasureBoxTrackedMarker()
	{
		if (this.KurotatoTreasureBoxTrackedMarkerMap.Count == 0)
		{
			return;
		}
		Log.Instance.Warn(ELogModule.Kurotato, ELogAuthor.LYX, "结束战斗阶段时有宝箱追踪图标残留, 强制清除", default(ReadOnlySpan<ValueTuple<string, object>>));
		foreach (KurotatoTreasureBoxTrackedMarker kurotatoTreasureBoxTrackedMarker in this.KurotatoTreasureBoxTrackedMarkerMap.Values)
		{
			kurotatoTreasureBoxTrackedMarker.Recycle();
		}
		this.KurotatoTreasureBoxTrackedMarkerMap.Clear();
	}

	// Token: 0x0400673B RID: 26427
	private const float STEP_ADVANCE_FALLBACK_MS = 3000f;

	// Token: 0x0400673C RID: 26428
	protected Dictionary<Type, UiPanelBase> KurotatoChildPanelMap = new Dictionary<Type, UiPanelBase>();

	// Token: 0x0400673D RID: 26429
	public KurotatoResidentWaveTipsPanel ResidentWaveTips;

	// Token: 0x0400673E RID: 26430
	public KurotatoCountDownTipsPanel CountDownTips;

	// Token: 0x0400673F RID: 26431
	private SurvivorsRoguePlayerTrackerMarker PlayerTrackedMarker;

	// Token: 0x04006740 RID: 26432
	public KurotatoMainPanel MainPanel;

	// Token: 0x04006741 RID: 26433
	public KurotatoAttrChangePanel AttrChangePanel;

	// Token: 0x04006742 RID: 26434
	public KurotatoWaveTipsPanel WaveTipsPanel;

	// Token: 0x04006743 RID: 26435
	public KurotatoBossSpawnTipsPanel BossSpawnTipsPanel;

	// Token: 0x04006744 RID: 26436
	public KurotatoEliteWaveTipsPanel EliteWaveTipsPanel;

	// Token: 0x04006745 RID: 26437
	[Nullable(2)]
	private AUIContainerActor ScreenEffectFightRoot;

	// Token: 0x04006746 RID: 26438
	private readonly Dictionary<int, KurotatoBossTrackedMarker> KurotatoBossTrackedMarkerMap = new Dictionary<int, KurotatoBossTrackedMarker>();

	// Token: 0x04006747 RID: 26439
	private readonly Dictionary<int, KurotatoTreasureBoxTrackedMarker> KurotatoTreasureBoxTrackedMarkerMap = new Dictionary<int, KurotatoTreasureBoxTrackedMarker>();

	// Token: 0x04006748 RID: 26440
	private EKurotatoStep CurStep = EKurotatoStep.None;

	// Token: 0x04006749 RID: 26441
	[Nullable(2)]
	private TimerHandle StepAdvanceTimer;
}

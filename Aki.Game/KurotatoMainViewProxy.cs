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

// Token: 0x02001CC3 RID: 7363
[NullableContext(1)]
[Nullable(0)]
public class KurotatoMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001207 RID: 4615
	// (get) Token: 0x0600DEC6 RID: 57030 RVA: 0x0034207A File Offset: 0x0034027A
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.Kurotato);
		}
	}

	// Token: 0x0600DEC7 RID: 57031 RVA: 0x00342084 File Offset: 0x00340284
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoMainViewProxy.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoMainViewProxy.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DEC8 RID: 57032 RVA: 0x003420C8 File Offset: 0x003402C8
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

	// Token: 0x0600DEC9 RID: 57033 RVA: 0x0034213C File Offset: 0x0034033C
	protected override void OnStart()
	{
		this.AttrChangePanel.SetUiActive(false);
	}

	// Token: 0x0600DECA RID: 57034 RVA: 0x0034214C File Offset: 0x0034034C
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

	// Token: 0x0600DECB RID: 57035 RVA: 0x00342260 File Offset: 0x00340460
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

	// Token: 0x0600DECC RID: 57036 RVA: 0x00342350 File Offset: 0x00340550
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

	// Token: 0x0600DECD RID: 57037 RVA: 0x00342438 File Offset: 0x00340638
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

	// Token: 0x0600DECE RID: 57038 RVA: 0x0034258C File Offset: 0x0034078C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EKurotatoStep>(EEventName.KurotatoOnStepChanged, new Action<EKurotatoStep>(this.OnStepChanged));
		EventSystem.Instance.Remove<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnPropertyUpdate));
		EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoBossTrackedMarkerUpdate, new Action<int, bool>(this.OnKurotatoBossTrackedMarkerUpdate));
		EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoTreasureBoxTrackedMarkerUpdate, new Action<int, bool>(this.OnKurotatoTreasureBoxTrackedMarkerUpdate));
		EventSystem.Instance.Remove(EEventName.KurotatoOnPlayerDie, new Action(this.OnPlayerDie));
	}

	// Token: 0x0600DECF RID: 57039 RVA: 0x00342628 File Offset: 0x00340828
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

	// Token: 0x0600DED0 RID: 57040 RVA: 0x00342690 File Offset: 0x00340890
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

	// Token: 0x0600DED1 RID: 57041 RVA: 0x003426EC File Offset: 0x003408EC
	private UniTask CreateResidentWaveTipsPanel()
	{
		KurotatoMainViewProxy.<CreateResidentWaveTipsPanel>d__27 <CreateResidentWaveTipsPanel>d__;
		<CreateResidentWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateResidentWaveTipsPanel>d__.<>4__this = this;
		<CreateResidentWaveTipsPanel>d__.<>1__state = -1;
		<CreateResidentWaveTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateResidentWaveTipsPanel>d__27>(ref <CreateResidentWaveTipsPanel>d__);
		return <CreateResidentWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED2 RID: 57042 RVA: 0x00342730 File Offset: 0x00340930
	private UniTask CreateCountDownTipsPanel()
	{
		KurotatoMainViewProxy.<CreateCountDownTipsPanel>d__28 <CreateCountDownTipsPanel>d__;
		<CreateCountDownTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCountDownTipsPanel>d__.<>4__this = this;
		<CreateCountDownTipsPanel>d__.<>1__state = -1;
		<CreateCountDownTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateCountDownTipsPanel>d__28>(ref <CreateCountDownTipsPanel>d__);
		return <CreateCountDownTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED3 RID: 57043 RVA: 0x00342774 File Offset: 0x00340974
	private UniTask CreatePlayerTrackedMarkerPanel()
	{
		KurotatoMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__29 <CreatePlayerTrackedMarkerPanel>d__;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePlayerTrackedMarkerPanel>d__.<>4__this = this;
		<CreatePlayerTrackedMarkerPanel>d__.<>1__state = -1;
		<CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreatePlayerTrackedMarkerPanel>d__29>(ref <CreatePlayerTrackedMarkerPanel>d__);
		return <CreatePlayerTrackedMarkerPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED4 RID: 57044 RVA: 0x003427B8 File Offset: 0x003409B8
	private UniTask CreateMainPanel()
	{
		KurotatoMainViewProxy.<CreateMainPanel>d__30 <CreateMainPanel>d__;
		<CreateMainPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMainPanel>d__.<>4__this = this;
		<CreateMainPanel>d__.<>1__state = -1;
		<CreateMainPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateMainPanel>d__30>(ref <CreateMainPanel>d__);
		return <CreateMainPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED5 RID: 57045 RVA: 0x003427FC File Offset: 0x003409FC
	private UniTask CreateAttrChangePanel()
	{
		KurotatoMainViewProxy.<CreateAttrChangePanel>d__31 <CreateAttrChangePanel>d__;
		<CreateAttrChangePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAttrChangePanel>d__.<>4__this = this;
		<CreateAttrChangePanel>d__.<>1__state = -1;
		<CreateAttrChangePanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateAttrChangePanel>d__31>(ref <CreateAttrChangePanel>d__);
		return <CreateAttrChangePanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED6 RID: 57046 RVA: 0x00342840 File Offset: 0x00340A40
	private UniTask CreateWaveTipsPanel()
	{
		KurotatoMainViewProxy.<CreateWaveTipsPanel>d__32 <CreateWaveTipsPanel>d__;
		<CreateWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateWaveTipsPanel>d__.<>4__this = this;
		<CreateWaveTipsPanel>d__.<>1__state = -1;
		<CreateWaveTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateWaveTipsPanel>d__32>(ref <CreateWaveTipsPanel>d__);
		return <CreateWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED7 RID: 57047 RVA: 0x00342884 File Offset: 0x00340A84
	private UniTask CreateBossSpawnTipsPanel()
	{
		KurotatoMainViewProxy.<CreateBossSpawnTipsPanel>d__33 <CreateBossSpawnTipsPanel>d__;
		<CreateBossSpawnTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBossSpawnTipsPanel>d__.<>4__this = this;
		<CreateBossSpawnTipsPanel>d__.<>1__state = -1;
		<CreateBossSpawnTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateBossSpawnTipsPanel>d__33>(ref <CreateBossSpawnTipsPanel>d__);
		return <CreateBossSpawnTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED8 RID: 57048 RVA: 0x003428C8 File Offset: 0x00340AC8
	private UniTask CreateEliteWaveTipsPanel()
	{
		KurotatoMainViewProxy.<CreateEliteWaveTipsPanel>d__34 <CreateEliteWaveTipsPanel>d__;
		<CreateEliteWaveTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEliteWaveTipsPanel>d__.<>4__this = this;
		<CreateEliteWaveTipsPanel>d__.<>1__state = -1;
		<CreateEliteWaveTipsPanel>d__.<>t__builder.Start<KurotatoMainViewProxy.<CreateEliteWaveTipsPanel>d__34>(ref <CreateEliteWaveTipsPanel>d__);
		return <CreateEliteWaveTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DED9 RID: 57049 RVA: 0x0034290C File Offset: 0x00340B0C
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

	// Token: 0x0600DEDA RID: 57050 RVA: 0x003429D8 File Offset: 0x00340BD8
	private void OnStepChanged(EKurotatoStep step)
	{
		this.UpdateTipsByState(step);
	}

	// Token: 0x0600DEDB RID: 57051 RVA: 0x003429E1 File Offset: 0x00340BE1
	private void OnPropertyUpdate(IDictionary<int, int> propertyValues)
	{
		this.AttrChangePanel.ShowAttrChange(propertyValues);
	}

	// Token: 0x0600DEDC RID: 57052 RVA: 0x003429F0 File Offset: 0x00340BF0
	private void OnCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		int increment = (lastVarDefine != null) ? (num - (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int)) : 0;
		this.MainPanel.RefreshCurrencyNum(num, increment);
	}

	// Token: 0x0600DEDD RID: 57053 RVA: 0x00342A38 File Offset: 0x00340C38
	private void OnSpareGoldUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		int increment = (lastVarDefine != null) ? (num - (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int)) : 0;
		this.MainPanel.RefreshSpareGold(num, increment);
	}

	// Token: 0x0600DEDE RID: 57054 RVA: 0x00342A80 File Offset: 0x00340C80
	private void OnChestUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		bool bPlayAcquireAnim = lastVarDefine != null && num > (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int);
		this.MainPanel.RefreshChestCount(num, bPlayAcquireAnim);
	}

	// Token: 0x0600DEDF RID: 57055 RVA: 0x00342AC8 File Offset: 0x00340CC8
	private void OnUpgradeCountUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		bool bPlayAcquireAnim = lastVarDefine != null && num > (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int);
		this.MainPanel.RefreshLevelUpCount(num, bPlayAcquireAnim);
	}

	// Token: 0x0600DEE0 RID: 57056 RVA: 0x00342B0F File Offset: 0x00340D0F
	private void OnExpUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.MainPanel.RefreshExp();
	}

	// Token: 0x0600DEE1 RID: 57057 RVA: 0x00342B1C File Offset: 0x00340D1C
	private void OnComboUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int comboNum = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.MainPanel.RefreshComboNum(comboNum);
	}

	// Token: 0x0600DEE2 RID: 57058 RVA: 0x00342B48 File Offset: 0x00340D48
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

	// Token: 0x0600DEE3 RID: 57059 RVA: 0x00342BB8 File Offset: 0x00340DB8
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

	// Token: 0x0600DEE4 RID: 57060 RVA: 0x00342C78 File Offset: 0x00340E78
	private void StartStepAdvanceWatch()
	{
		this.ClearStepAdvanceTimer();
		this.StepAdvanceTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.TriggerStepAdvance();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600DEE5 RID: 57061 RVA: 0x00342CA9 File Offset: 0x00340EA9
	private void OnWaveTipsFinish()
	{
		this.TriggerStepAdvance();
	}

	// Token: 0x0600DEE6 RID: 57062 RVA: 0x00342CB4 File Offset: 0x00340EB4
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

	// Token: 0x0600DEE7 RID: 57063 RVA: 0x00342D05 File Offset: 0x00340F05
	private void ClearStepAdvanceTimer()
	{
		if (this.StepAdvanceTimer != null)
		{
			this.StepAdvanceTimer.Remove();
			this.StepAdvanceTimer = null;
		}
	}

	// Token: 0x0600DEE8 RID: 57064 RVA: 0x00342D24 File Offset: 0x00340F24
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

	// Token: 0x0600DEE9 RID: 57065 RVA: 0x00342D70 File Offset: 0x00340F70
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

	// Token: 0x0600DEEA RID: 57066 RVA: 0x00342DB0 File Offset: 0x00340FB0
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

	// Token: 0x0600DEEB RID: 57067 RVA: 0x00342E40 File Offset: 0x00341040
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

	// Token: 0x0600DEEC RID: 57068 RVA: 0x00342E8C File Offset: 0x0034108C
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

	// Token: 0x0600DEED RID: 57069 RVA: 0x00342ECC File Offset: 0x003410CC
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

	// Token: 0x0400665C RID: 26204
	private const float STEP_ADVANCE_FALLBACK_MS = 3000f;

	// Token: 0x0400665D RID: 26205
	protected Dictionary<Type, UiPanelBase> KurotatoChildPanelMap = new Dictionary<Type, UiPanelBase>();

	// Token: 0x0400665E RID: 26206
	public KurotatoResidentWaveTipsPanel ResidentWaveTips;

	// Token: 0x0400665F RID: 26207
	public KurotatoCountDownTipsPanel CountDownTips;

	// Token: 0x04006660 RID: 26208
	private SurvivorsRoguePlayerTrackerMarker PlayerTrackedMarker;

	// Token: 0x04006661 RID: 26209
	public KurotatoMainPanel MainPanel;

	// Token: 0x04006662 RID: 26210
	public KurotatoAttrChangePanel AttrChangePanel;

	// Token: 0x04006663 RID: 26211
	public KurotatoWaveTipsPanel WaveTipsPanel;

	// Token: 0x04006664 RID: 26212
	public KurotatoBossSpawnTipsPanel BossSpawnTipsPanel;

	// Token: 0x04006665 RID: 26213
	public KurotatoEliteWaveTipsPanel EliteWaveTipsPanel;

	// Token: 0x04006666 RID: 26214
	[Nullable(2)]
	private AUIContainerActor ScreenEffectFightRoot;

	// Token: 0x04006667 RID: 26215
	private readonly Dictionary<int, KurotatoBossTrackedMarker> KurotatoBossTrackedMarkerMap = new Dictionary<int, KurotatoBossTrackedMarker>();

	// Token: 0x04006668 RID: 26216
	private readonly Dictionary<int, KurotatoTreasureBoxTrackedMarker> KurotatoTreasureBoxTrackedMarkerMap = new Dictionary<int, KurotatoTreasureBoxTrackedMarker>();

	// Token: 0x04006669 RID: 26217
	private EKurotatoStep CurStep = EKurotatoStep.None;

	// Token: 0x0400666A RID: 26218
	[Nullable(2)]
	private TimerHandle StepAdvanceTimer;
}

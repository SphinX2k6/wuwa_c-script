using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.GameMainView.TrapDefense.ChildPanel;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D49 RID: 7497
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001225 RID: 4645
	// (get) Token: 0x0600E34E RID: 58190 RVA: 0x003566F8 File Offset: 0x003548F8
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.TrapDefense);
		}
	}

	// Token: 0x0600E34F RID: 58191 RVA: 0x00356700 File Offset: 0x00354900
	public TrapDefenseMainViewProxy()
	{
		this.InterfaceLogic = new TrapDefenseInterfaceLogic(this);
		this.TouchUiEditGroup = new ECommonTouchUiEditGroup?(ECommonTouchUiEditGroup.TrapDefenseMain);
	}

	// Token: 0x0600E350 RID: 58192 RVA: 0x00356720 File Offset: 0x00354920
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseMainViewProxy.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E351 RID: 58193 RVA: 0x00356763 File Offset: 0x00354963
	protected override void OnStart()
	{
		this.WarningDistance = (float)TrapDefenseConfig.Instance.GetTrapDefenseWarningDistance();
	}

	// Token: 0x0600E352 RID: 58194 RVA: 0x00356778 File Offset: 0x00354978
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.TowerDefenseEventStepUpdate, new Action<ETowerDefenseEventProcessStatus>(this.OnStepUpdate));
		EventSystem.Instance.Add(EEventName.TowerDefenseEventNotifyType, new Action<ETrapDefenseBuildTipsType>(this.OnNotifyType));
		EventSystem.Instance.Add<int?>(EEventName.TowerDefenseRecycleRaycastNotify, new Action<int?>(this.OnOrganChange));
		EventSystem.Instance.Add(EEventName.TrapDefenseComboNumChange, new Action<int>(this.OnComboNumChange));
		EventSystem.Instance.Add(EEventName.TrapDefenseActivityDataUpdate, new Action(this.OnTrapDefenseActivityDataUpdate));
		EventSystem.Instance.Add<int, float>(EEventName.TrapFollowerSkillCd, new Action<int, float>(this.OnTrapFollowerSkillCd));
		EventSystem.Instance.Add(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
		EventSystem.Instance.Add(EEventName.TrapDefenseOnSlotUpdate, new Action(this.OnSlotInfoUpdate));
	}

	// Token: 0x0600E353 RID: 58195 RVA: 0x00356868 File Offset: 0x00354A68
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TowerDefenseEventStepUpdate, new Action<ETowerDefenseEventProcessStatus>(this.OnStepUpdate));
		EventSystem.Instance.Remove(EEventName.TowerDefenseEventNotifyType, new Action<ETrapDefenseBuildTipsType>(this.OnNotifyType));
		EventSystem.Instance.Remove(EEventName.TowerDefenseRecycleRaycastNotify, new Action<int?>(this.OnOrganChange));
		EventSystem.Instance.Remove(EEventName.TrapDefenseComboNumChange, new Action<int>(this.OnComboNumChange));
		EventSystem.Instance.Remove(EEventName.TrapDefenseActivityDataUpdate, new Action(this.OnTrapDefenseActivityDataUpdate));
		EventSystem.Instance.Remove(EEventName.TrapFollowerSkillCd, new Action<int, float>(this.OnTrapFollowerSkillCd));
		EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
		EventSystem.Instance.Remove(EEventName.TrapDefenseOnSlotUpdate, new Action(this.OnSlotInfoUpdate));
	}

	// Token: 0x0600E354 RID: 58196 RVA: 0x00356958 File Offset: 0x00354B58
	protected override void OnBeforeShow(bool isFirstShow)
	{
		if (isFirstShow)
		{
			ETowerDefenseEventProcessStatus processStatus = TowerDefenseEventController.Instance.ProcessStatus;
			this.OnStepUpdate(processStatus);
			TrapDefenseDesktopSkillPanel desktopSkillPanel = this.DesktopSkillPanel;
			if (desktopSkillPanel != null)
			{
				desktopSkillPanel.RefreshButtonByIsInBuild(false);
			}
			ETrapDefenseBuildTipsType buildTipsType = TowerDefenseEventController.Instance.BuildTipsType;
			TrapDefenseMobileSkillPanel mobileSkillPanel = this.MobileSkillPanel;
			if (mobileSkillPanel == null)
			{
				return;
			}
			mobileSkillPanel.RefreshButtonByTipsType(buildTipsType);
		}
	}

	// Token: 0x0600E355 RID: 58197 RVA: 0x003569A8 File Offset: 0x00354BA8
	protected override void OnTick(float delta)
	{
		FKSC_MiniMapContext[] entityPositions = KuroSimpleCombatController.Instance.GetEntityPositions();
		this.UpdateHpPanelWarning(entityPositions);
	}

	// Token: 0x0600E356 RID: 58198 RVA: 0x003569C8 File Offset: 0x00354BC8
	private void UpdateHpPanelWarning([Nullable(new byte[]
	{
		2,
		1
	})] FKSC_MiniMapContext[] positions)
	{
		bool warningItemActive = false;
		if (positions != null && positions.Length != 0)
		{
			for (int i = 0; i < positions.Length; i++)
			{
				if (positions[i].Distance <= this.WarningDistance)
				{
					warningItemActive = true;
					break;
				}
			}
		}
		this.CampsiteHpPanel.SetWarningItemActive(warningItemActive);
	}

	// Token: 0x0600E357 RID: 58199 RVA: 0x00356A10 File Offset: 0x00354C10
	protected override void OnRouletteViewVisibleChangedInner(bool visible)
	{
		if (Info.Instance.IsInTouch())
		{
			if (!visible)
			{
				this.BuildTipsPanel.ShowBattleChildViewPanel();
				this.MissionPanel.ShowBattleChildViewPanel();
			}
			else
			{
				this.BuildTipsPanel.HideBattleChildViewPanel();
				this.MissionPanel.HideBattleChildViewPanel();
			}
			this.MachineTipsPanel.RefreshMachineStateByRoulette(visible);
		}
	}

	// Token: 0x0600E358 RID: 58200 RVA: 0x00356A68 File Offset: 0x00354C68
	private UniTask CreateMiniMap()
	{
		TrapDefenseMainViewProxy.<CreateMiniMap>d__24 <CreateMiniMap>d__;
		<CreateMiniMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMiniMap>d__.<>4__this = this;
		<CreateMiniMap>d__.<>1__state = -1;
		<CreateMiniMap>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMiniMap>d__24>(ref <CreateMiniMap>d__);
		return <CreateMiniMap>d__.<>t__builder.Task;
	}

	// Token: 0x0600E359 RID: 58201 RVA: 0x00356AAC File Offset: 0x00354CAC
	private UniTask CreateMissionPanel()
	{
		TrapDefenseMainViewProxy.<CreateMissionPanel>d__25 <CreateMissionPanel>d__;
		<CreateMissionPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMissionPanel>d__.<>4__this = this;
		<CreateMissionPanel>d__.<>1__state = -1;
		<CreateMissionPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMissionPanel>d__25>(ref <CreateMissionPanel>d__);
		return <CreateMissionPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E35A RID: 58202 RVA: 0x00356AF0 File Offset: 0x00354CF0
	private UniTask CreateMachineSelectPanel()
	{
		TrapDefenseMainViewProxy.<CreateMachineSelectPanel>d__26 <CreateMachineSelectPanel>d__;
		<CreateMachineSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMachineSelectPanel>d__.<>4__this = this;
		<CreateMachineSelectPanel>d__.<>1__state = -1;
		<CreateMachineSelectPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMachineSelectPanel>d__26>(ref <CreateMachineSelectPanel>d__);
		return <CreateMachineSelectPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E35B RID: 58203 RVA: 0x00356B34 File Offset: 0x00354D34
	private UniTask CreatePreparationPanel()
	{
		TrapDefenseMainViewProxy.<CreatePreparationPanel>d__27 <CreatePreparationPanel>d__;
		<CreatePreparationPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePreparationPanel>d__.<>4__this = this;
		<CreatePreparationPanel>d__.<>1__state = -1;
		<CreatePreparationPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreatePreparationPanel>d__27>(ref <CreatePreparationPanel>d__);
		return <CreatePreparationPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E35C RID: 58204 RVA: 0x00356B78 File Offset: 0x00354D78
	private UniTask CreateFunctionalPanel()
	{
		TrapDefenseMainViewProxy.<CreateFunctionalPanel>d__28 <CreateFunctionalPanel>d__;
		<CreateFunctionalPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFunctionalPanel>d__.<>4__this = this;
		<CreateFunctionalPanel>d__.<>1__state = -1;
		<CreateFunctionalPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateFunctionalPanel>d__28>(ref <CreateFunctionalPanel>d__);
		return <CreateFunctionalPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E35D RID: 58205 RVA: 0x00356BBC File Offset: 0x00354DBC
	private UniTask CreateCampsiteHpPanel()
	{
		TrapDefenseMainViewProxy.<CreateCampsiteHpPanel>d__29 <CreateCampsiteHpPanel>d__;
		<CreateCampsiteHpPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCampsiteHpPanel>d__.<>4__this = this;
		<CreateCampsiteHpPanel>d__.<>1__state = -1;
		<CreateCampsiteHpPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateCampsiteHpPanel>d__29>(ref <CreateCampsiteHpPanel>d__);
		return <CreateCampsiteHpPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E35E RID: 58206 RVA: 0x00356C00 File Offset: 0x00354E00
	private UniTask CreateBuildTipsPanel()
	{
		TrapDefenseMainViewProxy.<CreateBuildTipsPanel>d__30 <CreateBuildTipsPanel>d__;
		<CreateBuildTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBuildTipsPanel>d__.<>4__this = this;
		<CreateBuildTipsPanel>d__.<>1__state = -1;
		<CreateBuildTipsPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateBuildTipsPanel>d__30>(ref <CreateBuildTipsPanel>d__);
		return <CreateBuildTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E35F RID: 58207 RVA: 0x00356C44 File Offset: 0x00354E44
	private UniTask CreateComboPanel()
	{
		TrapDefenseMainViewProxy.<CreateComboPanel>d__31 <CreateComboPanel>d__;
		<CreateComboPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateComboPanel>d__.<>4__this = this;
		<CreateComboPanel>d__.<>1__state = -1;
		<CreateComboPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateComboPanel>d__31>(ref <CreateComboPanel>d__);
		return <CreateComboPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E360 RID: 58208 RVA: 0x00356C88 File Offset: 0x00354E88
	private UniTask CreateMobileSkillPanel()
	{
		TrapDefenseMainViewProxy.<CreateMobileSkillPanel>d__32 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMobileSkillPanel>d__32>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E361 RID: 58209 RVA: 0x00356CCC File Offset: 0x00354ECC
	private UniTask CreateDesktopSkillPanel()
	{
		TrapDefenseMainViewProxy.<CreateDesktopSkillPanel>d__33 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateDesktopSkillPanel>d__33>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E362 RID: 58210 RVA: 0x00356D10 File Offset: 0x00354F10
	private UniTask CreateMobileSkillPanelInner()
	{
		TrapDefenseMainViewProxy.<CreateMobileSkillPanelInner>d__34 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMobileSkillPanelInner>d__34>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E363 RID: 58211 RVA: 0x00356D54 File Offset: 0x00354F54
	private UniTask CreateDesktopSkillPanelInner()
	{
		TrapDefenseMainViewProxy.<CreateDesktopSkillPanelInner>d__35 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateDesktopSkillPanelInner>d__35>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E364 RID: 58212 RVA: 0x00356D98 File Offset: 0x00354F98
	private UniTask CreateMachineTipsPanel()
	{
		TrapDefenseMainViewProxy.<CreateMachineTipsPanel>d__36 <CreateMachineTipsPanel>d__;
		<CreateMachineTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMachineTipsPanel>d__.<>4__this = this;
		<CreateMachineTipsPanel>d__.<>1__state = -1;
		<CreateMachineTipsPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMachineTipsPanel>d__36>(ref <CreateMachineTipsPanel>d__);
		return <CreateMachineTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E365 RID: 58213 RVA: 0x00356DDB File Offset: 0x00354FDB
	private void ShowShopOpenTips()
	{
		if (TrapDefenseModel.Instance.BattleData.IsShopOpen)
		{
			TrapDefenseController.Instance.OpenTrapDefenseShopOpenTips(delegate
			{
				this.PreparationPanel.ShowBattleChildViewPanel();
			});
			return;
		}
		this.PreparationPanel.ShowBattleChildViewPanel();
	}

	// Token: 0x0600E366 RID: 58214 RVA: 0x00356E10 File Offset: 0x00355010
	private void ShowMonsterEnhancedTips()
	{
		TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
		if (currentBatchData != null && !StringUtils.IsBlank(currentBatchData.Value.ReadStageEnhanceTips))
		{
			this.FunctionalPanel.SetTips(currentBatchData.Value.ReadStageEnhanceTips);
		}
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		object obj = (instance != null) ? instance.GetCurInstToLevelData() : null;
		int batch = TrapDefenseModel.Instance.BattleData.GetBatch();
		object obj2 = obj;
		if (obj2 != null && obj2.IsBossWave(batch))
		{
			TrapDefenseController.Instance.OpenTrapDefenseBossComingTips(null);
		}
	}

	// Token: 0x0600E367 RID: 58215 RVA: 0x00356EA0 File Offset: 0x003550A0
	private void HideMonsterEnhancedTips()
	{
		TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
		if (currentBatchData != null && !StringUtils.IsBlank(currentBatchData.Value.ReadStageEnhanceTips))
		{
			this.FunctionalPanel.HideTips();
		}
	}

	// Token: 0x0600E368 RID: 58216 RVA: 0x00356EE4 File Offset: 0x003550E4
	private void OnStepUpdate(ETowerDefenseEventProcessStatus status)
	{
		if (status == ETowerDefenseEventProcessStatus.Ready)
		{
			this.ShowShopOpenTips();
			this.ShowMonsterEnhancedTips();
		}
		else if (status == ETowerDefenseEventProcessStatus.Fighting)
		{
			this.PreparationPanel.HideBattleChildViewPanel();
			this.HideMonsterEnhancedTips();
			TrapDefenseController.Instance.StartChallengeRoundTips();
		}
		if (status != ETowerDefenseEventProcessStatus.Fighting)
		{
			this.ComboPanel.HideComboPanel();
		}
		this.MiniMap.OnTowerDefenseStepUpdate(status);
		this.MachineSelectPanel.OnTowerDefenseStepUpdate(status);
	}

	// Token: 0x0600E369 RID: 58217 RVA: 0x00356F4A File Offset: 0x0035514A
	private void OnNotifyType(ETrapDefenseBuildTipsType type)
	{
		this.BuildTipsPanel.SetTipsType(type);
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.MobileSkillPanel;
		if (mobileSkillPanel == null)
		{
			return;
		}
		mobileSkillPanel.RefreshButtonByTipsType(type);
	}

	// Token: 0x0600E36A RID: 58218 RVA: 0x00356F69 File Offset: 0x00355169
	private void OnOrganChange(int? recyclePrice)
	{
		if (recyclePrice != null)
		{
			this.BuildTipsPanel.SetRecyclePrice(recyclePrice.Value);
			TrapDefenseMobileSkillPanel mobileSkillPanel = this.MobileSkillPanel;
			if (mobileSkillPanel == null)
			{
				return;
			}
			mobileSkillPanel.SetRecyclePrice(recyclePrice.Value);
		}
	}

	// Token: 0x0600E36B RID: 58219 RVA: 0x00356F9D File Offset: 0x0035519D
	private void OnComboNumChange(int num)
	{
		this.ComboPanel.RefreshComboNum(num);
	}

	// Token: 0x0600E36C RID: 58220 RVA: 0x00356FAB File Offset: 0x003551AB
	private void OnTrapDefenseActivityDataUpdate()
	{
		this.FunctionalPanel.UpdateBdSumState();
	}

	// Token: 0x0600E36D RID: 58221 RVA: 0x00356FB8 File Offset: 0x003551B8
	private void OnTrapFollowerSkillCd(int proxyId, float _)
	{
		TrapDefenseMachineSelectPanel machineSelectPanel = this.MachineSelectPanel;
		if (machineSelectPanel != null)
		{
			machineSelectPanel.RefreshMachineCdState(proxyId);
		}
		TrapDefenseMobileSkillPanel mobileSkillPanel = this.MobileSkillPanel;
		if (mobileSkillPanel == null)
		{
			return;
		}
		mobileSkillPanel.RefreshMachineCdState();
	}

	// Token: 0x0600E36E RID: 58222 RVA: 0x00356FDC File Offset: 0x003551DC
	private void OnPlotViewChange(EUiViewName viewName, bool isShow)
	{
		if (viewName == EUiViewName.PlotViewHUD)
		{
			this.MachineSelectPanel.SetMachineSelectCollapse(isShow);
		}
	}

	// Token: 0x0600E36F RID: 58223 RVA: 0x00356FF7 File Offset: 0x003551F7
	private void OnSlotInfoUpdate()
	{
		this.MachineSelectPanel.RefreshSlotState();
	}

	// Token: 0x0600E370 RID: 58224 RVA: 0x00357004 File Offset: 0x00355204
	public void RefreshSelectPanel()
	{
		this.MachineSelectPanel.RefreshMachineState();
	}

	// Token: 0x040068F4 RID: 26868
	private readonly TrapDefenseInterfaceLogic InterfaceLogic;

	// Token: 0x040068F5 RID: 26869
	public TrapDefenseMiniMapPanel MiniMap;

	// Token: 0x040068F6 RID: 26870
	public TrapDefenseMissionPanel MissionPanel;

	// Token: 0x040068F7 RID: 26871
	public TrapDefenseMachineSelectPanel MachineSelectPanel;

	// Token: 0x040068F8 RID: 26872
	public TrapDefensePreparationPanel PreparationPanel;

	// Token: 0x040068F9 RID: 26873
	public TrapDefenseFunctionalPanel FunctionalPanel;

	// Token: 0x040068FA RID: 26874
	public TrapDefenseCampsiteHpPanel CampsiteHpPanel;

	// Token: 0x040068FB RID: 26875
	public TrapDefenseBuildTipsPanel BuildTipsPanel;

	// Token: 0x040068FC RID: 26876
	public TrapDefenseComboPanel ComboPanel;

	// Token: 0x040068FD RID: 26877
	[Nullable(2)]
	public TrapDefenseMobileSkillPanel MobileSkillPanel;

	// Token: 0x040068FE RID: 26878
	[Nullable(2)]
	public TrapDefenseDesktopSkillPanel DesktopSkillPanel;

	// Token: 0x040068FF RID: 26879
	public TrapDefenseMachineTipsPanel MachineTipsPanel;

	// Token: 0x04006900 RID: 26880
	private float WarningDistance;
}

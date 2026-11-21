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

// Token: 0x0200120B RID: 4619
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMainViewProxy : GameMainViewProxy
{
	// Token: 0x1700124F RID: 4687
	// (get) Token: 0x0600B76B RID: 46955 RVA: 0x00362128 File Offset: 0x00360328
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.TrapDefense);
		}
	}

	// Token: 0x0600B76C RID: 46956 RVA: 0x00362130 File Offset: 0x00360330
	public TrapDefenseMainViewProxy()
	{
		this.InterfaceLogic = new TrapDefenseInterfaceLogic(this);
		this.TouchUiEditGroup = new ECommonTouchUiEditGroup?(ECommonTouchUiEditGroup.TrapDefenseMain);
	}

	// Token: 0x0600B76D RID: 46957 RVA: 0x00362150 File Offset: 0x00360350
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseMainViewProxy.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B76E RID: 46958 RVA: 0x00362193 File Offset: 0x00360393
	protected override void OnStart()
	{
		this.WarningDistance = (float)TrapDefenseConfig.Instance.GetTrapDefenseWarningDistance();
	}

	// Token: 0x0600B76F RID: 46959 RVA: 0x003621A8 File Offset: 0x003603A8
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

	// Token: 0x0600B770 RID: 46960 RVA: 0x00362298 File Offset: 0x00360498
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

	// Token: 0x0600B771 RID: 46961 RVA: 0x00362388 File Offset: 0x00360588
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

	// Token: 0x0600B772 RID: 46962 RVA: 0x003623D8 File Offset: 0x003605D8
	protected override void OnTick(float delta)
	{
		FKSC_MiniMapContext[] entityPositions = KuroSimpleCombatController.Instance.GetEntityPositions();
		this.UpdateHpPanelWarning(entityPositions);
	}

	// Token: 0x0600B773 RID: 46963 RVA: 0x003623F8 File Offset: 0x003605F8
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

	// Token: 0x0600B774 RID: 46964 RVA: 0x00362440 File Offset: 0x00360640
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

	// Token: 0x0600B775 RID: 46965 RVA: 0x00362498 File Offset: 0x00360698
	private UniTask CreateMiniMap()
	{
		TrapDefenseMainViewProxy.<CreateMiniMap>d__24 <CreateMiniMap>d__;
		<CreateMiniMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMiniMap>d__.<>4__this = this;
		<CreateMiniMap>d__.<>1__state = -1;
		<CreateMiniMap>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMiniMap>d__24>(ref <CreateMiniMap>d__);
		return <CreateMiniMap>d__.<>t__builder.Task;
	}

	// Token: 0x0600B776 RID: 46966 RVA: 0x003624DC File Offset: 0x003606DC
	private UniTask CreateMissionPanel()
	{
		TrapDefenseMainViewProxy.<CreateMissionPanel>d__25 <CreateMissionPanel>d__;
		<CreateMissionPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMissionPanel>d__.<>4__this = this;
		<CreateMissionPanel>d__.<>1__state = -1;
		<CreateMissionPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMissionPanel>d__25>(ref <CreateMissionPanel>d__);
		return <CreateMissionPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B777 RID: 46967 RVA: 0x00362520 File Offset: 0x00360720
	private UniTask CreateMachineSelectPanel()
	{
		TrapDefenseMainViewProxy.<CreateMachineSelectPanel>d__26 <CreateMachineSelectPanel>d__;
		<CreateMachineSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMachineSelectPanel>d__.<>4__this = this;
		<CreateMachineSelectPanel>d__.<>1__state = -1;
		<CreateMachineSelectPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMachineSelectPanel>d__26>(ref <CreateMachineSelectPanel>d__);
		return <CreateMachineSelectPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B778 RID: 46968 RVA: 0x00362564 File Offset: 0x00360764
	private UniTask CreatePreparationPanel()
	{
		TrapDefenseMainViewProxy.<CreatePreparationPanel>d__27 <CreatePreparationPanel>d__;
		<CreatePreparationPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePreparationPanel>d__.<>4__this = this;
		<CreatePreparationPanel>d__.<>1__state = -1;
		<CreatePreparationPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreatePreparationPanel>d__27>(ref <CreatePreparationPanel>d__);
		return <CreatePreparationPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B779 RID: 46969 RVA: 0x003625A8 File Offset: 0x003607A8
	private UniTask CreateFunctionalPanel()
	{
		TrapDefenseMainViewProxy.<CreateFunctionalPanel>d__28 <CreateFunctionalPanel>d__;
		<CreateFunctionalPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFunctionalPanel>d__.<>4__this = this;
		<CreateFunctionalPanel>d__.<>1__state = -1;
		<CreateFunctionalPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateFunctionalPanel>d__28>(ref <CreateFunctionalPanel>d__);
		return <CreateFunctionalPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B77A RID: 46970 RVA: 0x003625EC File Offset: 0x003607EC
	private UniTask CreateCampsiteHpPanel()
	{
		TrapDefenseMainViewProxy.<CreateCampsiteHpPanel>d__29 <CreateCampsiteHpPanel>d__;
		<CreateCampsiteHpPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCampsiteHpPanel>d__.<>4__this = this;
		<CreateCampsiteHpPanel>d__.<>1__state = -1;
		<CreateCampsiteHpPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateCampsiteHpPanel>d__29>(ref <CreateCampsiteHpPanel>d__);
		return <CreateCampsiteHpPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B77B RID: 46971 RVA: 0x00362630 File Offset: 0x00360830
	private UniTask CreateBuildTipsPanel()
	{
		TrapDefenseMainViewProxy.<CreateBuildTipsPanel>d__30 <CreateBuildTipsPanel>d__;
		<CreateBuildTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBuildTipsPanel>d__.<>4__this = this;
		<CreateBuildTipsPanel>d__.<>1__state = -1;
		<CreateBuildTipsPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateBuildTipsPanel>d__30>(ref <CreateBuildTipsPanel>d__);
		return <CreateBuildTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B77C RID: 46972 RVA: 0x00362674 File Offset: 0x00360874
	private UniTask CreateComboPanel()
	{
		TrapDefenseMainViewProxy.<CreateComboPanel>d__31 <CreateComboPanel>d__;
		<CreateComboPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateComboPanel>d__.<>4__this = this;
		<CreateComboPanel>d__.<>1__state = -1;
		<CreateComboPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateComboPanel>d__31>(ref <CreateComboPanel>d__);
		return <CreateComboPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B77D RID: 46973 RVA: 0x003626B8 File Offset: 0x003608B8
	private UniTask CreateMobileSkillPanel()
	{
		TrapDefenseMainViewProxy.<CreateMobileSkillPanel>d__32 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMobileSkillPanel>d__32>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B77E RID: 46974 RVA: 0x003626FC File Offset: 0x003608FC
	private UniTask CreateDesktopSkillPanel()
	{
		TrapDefenseMainViewProxy.<CreateDesktopSkillPanel>d__33 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateDesktopSkillPanel>d__33>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B77F RID: 46975 RVA: 0x00362740 File Offset: 0x00360940
	private UniTask CreateMobileSkillPanelInner()
	{
		TrapDefenseMainViewProxy.<CreateMobileSkillPanelInner>d__34 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMobileSkillPanelInner>d__34>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B780 RID: 46976 RVA: 0x00362784 File Offset: 0x00360984
	private UniTask CreateDesktopSkillPanelInner()
	{
		TrapDefenseMainViewProxy.<CreateDesktopSkillPanelInner>d__35 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateDesktopSkillPanelInner>d__35>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B781 RID: 46977 RVA: 0x003627C8 File Offset: 0x003609C8
	private UniTask CreateMachineTipsPanel()
	{
		TrapDefenseMainViewProxy.<CreateMachineTipsPanel>d__36 <CreateMachineTipsPanel>d__;
		<CreateMachineTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMachineTipsPanel>d__.<>4__this = this;
		<CreateMachineTipsPanel>d__.<>1__state = -1;
		<CreateMachineTipsPanel>d__.<>t__builder.Start<TrapDefenseMainViewProxy.<CreateMachineTipsPanel>d__36>(ref <CreateMachineTipsPanel>d__);
		return <CreateMachineTipsPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B782 RID: 46978 RVA: 0x0036280B File Offset: 0x00360A0B
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

	// Token: 0x0600B783 RID: 46979 RVA: 0x00362840 File Offset: 0x00360A40
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

	// Token: 0x0600B784 RID: 46980 RVA: 0x003628D0 File Offset: 0x00360AD0
	private void HideMonsterEnhancedTips()
	{
		TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
		if (currentBatchData != null && !StringUtils.IsBlank(currentBatchData.Value.ReadStageEnhanceTips))
		{
			this.FunctionalPanel.HideTips();
		}
	}

	// Token: 0x0600B785 RID: 46981 RVA: 0x00362914 File Offset: 0x00360B14
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

	// Token: 0x0600B786 RID: 46982 RVA: 0x0036297A File Offset: 0x00360B7A
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

	// Token: 0x0600B787 RID: 46983 RVA: 0x00362999 File Offset: 0x00360B99
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

	// Token: 0x0600B788 RID: 46984 RVA: 0x003629CD File Offset: 0x00360BCD
	private void OnComboNumChange(int num)
	{
		this.ComboPanel.RefreshComboNum(num);
	}

	// Token: 0x0600B789 RID: 46985 RVA: 0x003629DB File Offset: 0x00360BDB
	private void OnTrapDefenseActivityDataUpdate()
	{
		this.FunctionalPanel.UpdateBdSumState();
	}

	// Token: 0x0600B78A RID: 46986 RVA: 0x003629E8 File Offset: 0x00360BE8
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

	// Token: 0x0600B78B RID: 46987 RVA: 0x00362A0C File Offset: 0x00360C0C
	private void OnPlotViewChange(EUiViewName viewName, bool isShow)
	{
		if (viewName == EUiViewName.PlotViewHUD)
		{
			this.MachineSelectPanel.SetMachineSelectCollapse(isShow);
		}
	}

	// Token: 0x0600B78C RID: 46988 RVA: 0x00362A27 File Offset: 0x00360C27
	private void OnSlotInfoUpdate()
	{
		this.MachineSelectPanel.RefreshSlotState();
	}

	// Token: 0x0600B78D RID: 46989 RVA: 0x00362A34 File Offset: 0x00360C34
	public void RefreshSelectPanel()
	{
		this.MachineSelectPanel.RefreshMachineState();
	}

	// Token: 0x040069D3 RID: 27091
	private readonly TrapDefenseInterfaceLogic InterfaceLogic;

	// Token: 0x040069D4 RID: 27092
	public TrapDefenseMiniMapPanel MiniMap;

	// Token: 0x040069D5 RID: 27093
	public TrapDefenseMissionPanel MissionPanel;

	// Token: 0x040069D6 RID: 27094
	public TrapDefenseMachineSelectPanel MachineSelectPanel;

	// Token: 0x040069D7 RID: 27095
	public TrapDefensePreparationPanel PreparationPanel;

	// Token: 0x040069D8 RID: 27096
	public TrapDefenseFunctionalPanel FunctionalPanel;

	// Token: 0x040069D9 RID: 27097
	public TrapDefenseCampsiteHpPanel CampsiteHpPanel;

	// Token: 0x040069DA RID: 27098
	public TrapDefenseBuildTipsPanel BuildTipsPanel;

	// Token: 0x040069DB RID: 27099
	public TrapDefenseComboPanel ComboPanel;

	// Token: 0x040069DC RID: 27100
	[Nullable(2)]
	public TrapDefenseMobileSkillPanel MobileSkillPanel;

	// Token: 0x040069DD RID: 27101
	[Nullable(2)]
	public TrapDefenseDesktopSkillPanel DesktopSkillPanel;

	// Token: 0x040069DE RID: 27102
	public TrapDefenseMachineTipsPanel MachineTipsPanel;

	// Token: 0x040069DF RID: 27103
	private float WarningDistance;
}

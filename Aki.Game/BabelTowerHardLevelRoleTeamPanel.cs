using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000617 RID: 1559
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerHardLevelRoleTeamPanel : UiPanelBase
{
	// Token: 0x0600490F RID: 18703 RVA: 0x0018CC68 File Offset: 0x0018AE68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnMaskBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004910 RID: 18704 RVA: 0x0018CD94 File Offset: 0x0018AF94
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelRoleTeamPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelRoleTeamPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004911 RID: 18705 RVA: 0x0018CDD8 File Offset: 0x0018AFD8
	protected override void OnStart()
	{
		this.TabComponent = new GenericLayout<BabelTowerTeamTabItem, string>(base.GetHorizontalLayout(0), delegate()
		{
			BabelTowerTeamTabItem babelTowerTeamTabItem = new BabelTowerTeamTabItem();
			babelTowerTeamTabItem.SetToggleClickCallback(new Action<EBabelTowerTeamTabType>(this.OnTabClick));
			return babelTowerTeamTabItem;
		}, null, false, true);
		this.TabComponent.RefreshByData(new List<string>
		{
			"GhostShipRoleList_Text",
			"GhostShipPreTeam_Text"
		}, delegate
		{
			this.OnTabClick(EBabelTowerTeamTabType.RoleList);
		}, false);
	}

	// Token: 0x06004912 RID: 18706 RVA: 0x0018CE39 File Offset: 0x0018B039
	private void OnMaskBtnClick()
	{
		base.SetUiActive(false);
		Action onPanelClose = this.OnPanelClose;
		if (onPanelClose == null)
		{
			return;
		}
		onPanelClose();
	}

	// Token: 0x06004913 RID: 18707 RVA: 0x0018CE52 File Offset: 0x0018B052
	private void OnTabClick(EBabelTowerTeamTabType index)
	{
		this.CurSelectTabIndex = index;
		this.RefreshCurrentTab();
	}

	// Token: 0x06004914 RID: 18708 RVA: 0x0018CE64 File Offset: 0x0018B064
	private void RefreshCurrentTab()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		EBabelTowerTeamTabType curSelectTabIndex = this.CurSelectTabIndex;
		GenericLayout<BabelTowerTeamTabItem, string> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SelectGridProxy((int)curSelectTabIndex, false);
		}
		BabelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
		if (roleSelectPanel != null)
		{
			roleSelectPanel.SetUiActive(curSelectTabIndex == EBabelTowerTeamTabType.RoleList);
		}
		BabelTowerTeamSelectPanel teamSelectPanel = this.TeamSelectPanel;
		if (teamSelectPanel != null)
		{
			teamSelectPanel.SetUiActive(curSelectTabIndex == EBabelTowerTeamTabType.UseTeam);
		}
		if (curSelectTabIndex != EBabelTowerTeamTabType.RoleList)
		{
			if (curSelectTabIndex == EBabelTowerTeamTabType.UseTeam)
			{
				BabelTowerTeamSelectPanel teamSelectPanel2 = this.TeamSelectPanel;
				if (teamSelectPanel2 != null)
				{
					teamSelectPanel2.RefreshTeamList();
				}
			}
		}
		else
		{
			this.SyncLevelInfoToSelectModel();
			BabelTowerRoleSelectPanel roleSelectPanel2 = this.RoleSelectPanel;
			if (roleSelectPanel2 != null)
			{
				roleSelectPanel2.RefreshWithSelectedState(this.GetRoleListWithTrial());
			}
		}
		Action<EBabelTowerTeamTabType> onSelectModeChange = this.OnSelectModeChange;
		if (onSelectModeChange == null)
		{
			return;
		}
		onSelectModeChange(curSelectTabIndex);
	}

	// Token: 0x06004915 RID: 18709 RVA: 0x0018CF08 File Offset: 0x0018B108
	[NullableContext(1)]
	private List<RoleDataBase> GetRoleListWithTrial()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (RoleInstance item in RoleModel.Instance.GetRoleList())
		{
			list.Add(item);
		}
		if (this.LevelInfo == null)
		{
			return list;
		}
		int instanceId = this.LevelInfo.InstanceId;
		int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.FightFormationId;
		FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
		if (fightFormationConfig == null)
		{
			return list;
		}
		foreach (int id in fightFormationConfig.Value.GetTrialRoleArray())
		{
			TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
			if (trialRoleConfigByGroupId != null)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list.Add(roleDataById);
				}
			}
		}
		return list;
	}

	// Token: 0x06004916 RID: 18710 RVA: 0x0018D001 File Offset: 0x0018B201
	[NullableContext(1)]
	public void SetLevelInfo(IBabelTowerLevelInfo levelInfo)
	{
		this.LevelInfo = levelInfo;
	}

	// Token: 0x06004917 RID: 18711 RVA: 0x0018D00A File Offset: 0x0018B20A
	public void Refresh()
	{
		this.RefreshCurrentTab();
	}

	// Token: 0x06004918 RID: 18712 RVA: 0x0018D014 File Offset: 0x0018B214
	private void SyncLevelInfoToSelectModel()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		RoleSelectModel instance = RoleSelectModel.Instance;
		instance.ClearData();
		int num = 1;
		foreach (int num2 in this.LevelInfo.RoleList)
		{
			if (num2 > 0)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num2, true);
				if (roleDataById != null)
				{
					instance.SelectedRoleSet.Add(num2);
					instance.RoleIndexMap[num] = roleDataById;
					num++;
				}
			}
		}
	}

	// Token: 0x06004919 RID: 18713 RVA: 0x0018D0B4 File Offset: 0x0018B2B4
	private void SyncSelectModelToLevelInfo()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		this.LevelInfo.RoleList = new List<int>(RoleSelectModel.Instance.SelectedRoleSet);
	}

	// Token: 0x0600491A RID: 18714 RVA: 0x0018D0DC File Offset: 0x0018B2DC
	[NullableContext(1)]
	private void OnRoleSelect(RoleDataBase roleData, bool isSelected)
	{
		this.SyncSelectModelToLevelInfo();
		BabelTowerTeamSelectPanel teamSelectPanel = this.TeamSelectPanel;
		if (teamSelectPanel != null)
		{
			teamSelectPanel.RefreshTeamList();
		}
		int dataId = roleData.GetDataId();
		if (isSelected)
		{
			BabelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
			if (roleSelectPanel != null)
			{
				roleSelectPanel.RefreshRoleGridProxy(dataId);
			}
		}
		else
		{
			BabelTowerRoleSelectPanel roleSelectPanel2 = this.RoleSelectPanel;
			if (roleSelectPanel2 != null)
			{
				roleSelectPanel2.RefreshRoleGridProxy(dataId);
			}
			BabelTowerRoleSelectPanel roleSelectPanel3 = this.RoleSelectPanel;
			if (roleSelectPanel3 != null)
			{
				roleSelectPanel3.RefreshSelectedRoleGridProxies();
			}
		}
		Action onRefreshCallBack = this.OnRefreshCallBack;
		if (onRefreshCallBack == null)
		{
			return;
		}
		onRefreshCallBack();
	}

	// Token: 0x0600491B RID: 18715 RVA: 0x0018D154 File Offset: 0x0018B354
	[NullableContext(1)]
	private void OnTeamSelect(FormationData teamData)
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (FormationRoleData formationRoleData in teamData.GetRoleDataMapWithTrial(false).Values)
		{
			list.Add(formationRoleData.ConfigId);
		}
		this.LevelInfo.RoleList = list;
		RoleSelectModel instance = RoleSelectModel.Instance;
		instance.ClearData();
		int num = 1;
		foreach (int num2 in list)
		{
			if (num2 > 0)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num2, true);
				if (roleDataById != null)
				{
					instance.SelectedRoleSet.Add(num2);
					instance.RoleIndexMap[num] = roleDataById;
					num++;
					RoleController.Instance.SynRoleSkillBranchNormalToGamePlay(num2, ESkillBranchCacheType.BabelTower);
				}
			}
		}
		Action onRefreshCallBack = this.OnRefreshCallBack;
		if (onRefreshCallBack == null)
		{
			return;
		}
		onRefreshCallBack();
	}

	// Token: 0x0600491C RID: 18716 RVA: 0x0018D26C File Offset: 0x0018B46C
	public void RefreshPanel()
	{
		int selectedGridIndex = this.TabComponent.GetSelectedGridIndex();
		if (selectedGridIndex < 0)
		{
			return;
		}
		EBabelTowerTeamTabType ebabelTowerTeamTabType = (EBabelTowerTeamTabType)selectedGridIndex;
		if (ebabelTowerTeamTabType != EBabelTowerTeamTabType.RoleList)
		{
			if (ebabelTowerTeamTabType != EBabelTowerTeamTabType.UseTeam)
			{
				return;
			}
			BabelTowerTeamSelectPanel teamSelectPanel = this.TeamSelectPanel;
			if (teamSelectPanel == null)
			{
				return;
			}
			teamSelectPanel.RefreshTeamList();
			return;
		}
		else
		{
			this.SyncLevelInfoToSelectModel();
			BabelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
			if (roleSelectPanel == null)
			{
				return;
			}
			roleSelectPanel.RefreshSelectedRoleGridProxies();
			return;
		}
	}

	// Token: 0x0600491D RID: 18717 RVA: 0x0018D2BB File Offset: 0x0018B4BB
	public void RefreshRoleSkillBranch(int roleId)
	{
		BabelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
		if (roleSelectPanel == null)
		{
			return;
		}
		roleSelectPanel.RefreshRole(roleId);
	}

	// Token: 0x04003688 RID: 13960
	public Action OnRefreshCallBack;

	// Token: 0x04003689 RID: 13961
	public Action<EBabelTowerTeamTabType> OnSelectModeChange;

	// Token: 0x0400368A RID: 13962
	public Action OnPanelClose;

	// Token: 0x0400368B RID: 13963
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<BabelTowerTeamTabItem, string> TabComponent;

	// Token: 0x0400368C RID: 13964
	private BabelTowerRoleSelectPanel RoleSelectPanel;

	// Token: 0x0400368D RID: 13965
	private BabelTowerTeamSelectPanel TeamSelectPanel;

	// Token: 0x0400368E RID: 13966
	private EBabelTowerTeamTabType CurSelectTabIndex;

	// Token: 0x0400368F RID: 13967
	private IBabelTowerLevelInfo LevelInfo;

	// Token: 0x020068C1 RID: 26817
	[NullableContext(0)]
	private class EComp
	{
		// Token: 0x0402286A RID: 141418
		public const int TabLayout = 0;

		// Token: 0x0402286B RID: 141419
		public const int TabItem = 1;

		// Token: 0x0402286C RID: 141420
		public const int RoleSelect = 2;

		// Token: 0x0402286D RID: 141421
		public const int TeamSelect = 3;

		// Token: 0x0402286E RID: 141422
		public const int MaskBtn = 5;

		// Token: 0x0402286F RID: 141423
		public const int BlurTex = 6;
	}

	// Token: 0x020068C2 RID: 26818
	[NullableContext(0)]
	private class ETabItem
	{
		// Token: 0x04022870 RID: 141424
		public const int Toggle = 0;

		// Token: 0x04022871 RID: 141425
		public const int Name = 1;

		// Token: 0x04022872 RID: 141426
		public const int RedDot = 2;
	}
}

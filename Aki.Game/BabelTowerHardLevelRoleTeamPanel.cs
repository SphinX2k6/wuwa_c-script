using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001163 RID: 4451
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerHardLevelRoleTeamPanel : UiPanelBase
{
	// Token: 0x06007578 RID: 30072 RVA: 0x0018410C File Offset: 0x0018230C
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

	// Token: 0x06007579 RID: 30073 RVA: 0x00184238 File Offset: 0x00182438
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelRoleTeamPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelRoleTeamPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600757A RID: 30074 RVA: 0x0018427C File Offset: 0x0018247C
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

	// Token: 0x0600757B RID: 30075 RVA: 0x001842DD File Offset: 0x001824DD
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

	// Token: 0x0600757C RID: 30076 RVA: 0x001842F6 File Offset: 0x001824F6
	private void OnTabClick(EBabelTowerTeamTabType index)
	{
		this.CurSelectTabIndex = index;
		this.RefreshCurrentTab();
	}

	// Token: 0x0600757D RID: 30077 RVA: 0x00184308 File Offset: 0x00182508
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

	// Token: 0x0600757E RID: 30078 RVA: 0x001843AC File Offset: 0x001825AC
	[NullableContext(1)]
	private List<RoleDataBase> GetRoleListWithTrial()
	{
		List<RoleDataBase> list = new List<RoleDataBase>(RoleModel.Instance.GetRoleList().Cast<RoleDataBase>());
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

	// Token: 0x0600757F RID: 30079 RVA: 0x00184486 File Offset: 0x00182686
	[NullableContext(1)]
	public void SetLevelInfo(IBabelTowerLevelInfo levelInfo)
	{
		this.LevelInfo = levelInfo;
	}

	// Token: 0x06007580 RID: 30080 RVA: 0x0018448F File Offset: 0x0018268F
	public void Refresh()
	{
		this.RefreshCurrentTab();
	}

	// Token: 0x06007581 RID: 30081 RVA: 0x00184498 File Offset: 0x00182698
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

	// Token: 0x06007582 RID: 30082 RVA: 0x00184538 File Offset: 0x00182738
	private void SyncSelectModelToLevelInfo()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		this.LevelInfo.RoleList = new List<int>(RoleSelectModel.Instance.SelectedRoleSet);
	}

	// Token: 0x06007583 RID: 30083 RVA: 0x00184560 File Offset: 0x00182760
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

	// Token: 0x06007584 RID: 30084 RVA: 0x001845D8 File Offset: 0x001827D8
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

	// Token: 0x06007585 RID: 30085 RVA: 0x001846F0 File Offset: 0x001828F0
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

	// Token: 0x06007586 RID: 30086 RVA: 0x0018473F File Offset: 0x0018293F
	public void RefreshRoleSkillBranch(int roleId)
	{
		BabelTowerRoleSelectPanel roleSelectPanel = this.RoleSelectPanel;
		if (roleSelectPanel == null)
		{
			return;
		}
		roleSelectPanel.RefreshRole(roleId);
	}

	// Token: 0x040035EF RID: 13807
	public Action OnRefreshCallBack;

	// Token: 0x040035F0 RID: 13808
	public Action<EBabelTowerTeamTabType> OnSelectModeChange;

	// Token: 0x040035F1 RID: 13809
	public Action OnPanelClose;

	// Token: 0x040035F2 RID: 13810
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<BabelTowerTeamTabItem, string> TabComponent;

	// Token: 0x040035F3 RID: 13811
	private BabelTowerRoleSelectPanel RoleSelectPanel;

	// Token: 0x040035F4 RID: 13812
	private BabelTowerTeamSelectPanel TeamSelectPanel;

	// Token: 0x040035F5 RID: 13813
	private EBabelTowerTeamTabType CurSelectTabIndex;

	// Token: 0x040035F6 RID: 13814
	private IBabelTowerLevelInfo LevelInfo;

	// Token: 0x02007733 RID: 30515
	[NullableContext(0)]
	private class EComp
	{
		// Token: 0x0402752C RID: 161068
		public const int TabLayout = 0;

		// Token: 0x0402752D RID: 161069
		public const int TabItem = 1;

		// Token: 0x0402752E RID: 161070
		public const int RoleSelect = 2;

		// Token: 0x0402752F RID: 161071
		public const int TeamSelect = 3;

		// Token: 0x04027530 RID: 161072
		public const int MaskBtn = 5;

		// Token: 0x04027531 RID: 161073
		public const int BlurTex = 6;
	}

	// Token: 0x02007734 RID: 30516
	[NullableContext(0)]
	private class ETabItem
	{
		// Token: 0x04027532 RID: 161074
		public const int Toggle = 0;

		// Token: 0x04027533 RID: 161075
		public const int Name = 1;

		// Token: 0x04027534 RID: 161076
		public const int RedDot = 2;
	}
}

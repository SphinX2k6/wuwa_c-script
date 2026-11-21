using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000620 RID: 1568
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerRoleListItem : SyncGridProxyAbstract<BabelTowerRoleListItemData>
{
	// Token: 0x06004954 RID: 18772 RVA: 0x0018E19C File Offset: 0x0018C39C
	protected override void OnStart()
	{
		this.RoleGrid.Initialize(this.RootActor);
		this.RoleGrid.SetToggleInteractive(true);
		this.RoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanGridToggleStateChange));
		this.RoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnGridToggleStateChanged));
		this.RoleGrid.SetUseFixedAsync(true);
	}

	// Token: 0x06004955 RID: 18773 RVA: 0x0018E200 File Offset: 0x0018C400
	[NullableContext(2)]
	private bool OnCanGridToggleStateChange(object data, bool isForceSelected, EToggleState state)
	{
		BabelTowerRoleListItem.<>c__DisplayClass4_0 CS$<>8__locals1 = new BabelTowerRoleListItem.<>c__DisplayClass4_0();
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		BabelTowerRoleSelectPanel ownerPanel = this.Data.OwnerPanel;
		if (ownerPanel == null)
		{
			return true;
		}
		CS$<>8__locals1.configId = this.Data.RoleData.GetDataId();
		CS$<>8__locals1.roleId = this.Data.RoleData.GetRoleId();
		CS$<>8__locals1.selectedSet = RoleSelectModel.Instance.SelectedRoleSet;
		if (CS$<>8__locals1.selectedSet.Count >= 3 && !CS$<>8__locals1.selectedSet.Contains(CS$<>8__locals1.configId))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			Action onMaxSelectReached = ownerPanel.OnMaxSelectReached;
			if (onMaxSelectReached != null)
			{
				onMaxSelectReached();
			}
			return false;
		}
		IEnumerable<RoleInstance> roleList = RoleModel.Instance.GetRoleList();
		List<RoleDataBase> trialRoleList = ownerPanel.GetTrialRoleList();
		if (NoLinq.Any<RoleInstance>(roleList, new Func<RoleInstance, bool>(CS$<>8__locals1.<OnCanGridToggleStateChange>g__IsSameSelectedRole|0)) || NoLinq.Any<RoleDataBase>(trialRoleList, new Func<RoleDataBase, bool>(CS$<>8__locals1.<OnCanGridToggleStateChange>g__IsSameSelectedRole|0)))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06004956 RID: 18774 RVA: 0x0018E300 File Offset: 0x0018C500
	private void OnGridToggleStateChanged(MediumItemGridExtendCallback @params)
	{
		BabelTowerRoleSelectPanel ownerPanel = this.Data.OwnerPanel;
		if (ownerPanel == null)
		{
			return;
		}
		bool flag = @params.State == EToggleState.ETT_Checked;
		int dataId = this.Data.RoleData.GetDataId();
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		if (flag)
		{
			if (!selectedRoleSet.Contains(dataId))
			{
				selectedRoleSet.Add(dataId);
				ownerPanel.SelectedConfigIds.Add(dataId);
				int count = selectedRoleSet.Count;
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(dataId, true);
				RoleSelectModel.Instance.RoleIndexMap[count] = (roleDataById ?? this.Data.RoleData);
				Action<RoleDataBase, bool> onRoleSelect = ownerPanel.OnRoleSelect;
				if (onRoleSelect == null)
				{
					return;
				}
				onRoleSelect(this.Data.RoleData, true);
				return;
			}
		}
		else if (selectedRoleSet.Contains(dataId))
		{
			selectedRoleSet.Remove(dataId);
			ownerPanel.SelectedConfigIds.Remove(dataId);
			this.RebuildRoleIndexMap(selectedRoleSet);
			Action<RoleDataBase, bool> onRoleSelect2 = ownerPanel.OnRoleSelect;
			if (onRoleSelect2 == null)
			{
				return;
			}
			onRoleSelect2(this.Data.RoleData, false);
		}
	}

	// Token: 0x06004957 RID: 18775 RVA: 0x0018E3FC File Offset: 0x0018C5FC
	private void RebuildRoleIndexMap(HashSet<int> selectedSet)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		roleIndexMap.Clear();
		BabelTowerRoleListItemData data = this.Data;
		BabelTowerRoleSelectPanel babelTowerRoleSelectPanel = (data != null) ? data.OwnerPanel : null;
		int num = 1;
		foreach (int num2 in selectedSet)
		{
			RoleDataBase roleDataBase = RoleModel.Instance.GetRoleDataById(num2, true);
			if (roleDataBase == null && babelTowerRoleSelectPanel != null)
			{
				roleDataBase = babelTowerRoleSelectPanel.FindRoleDataById(num2);
			}
			if (roleDataBase != null)
			{
				roleIndexMap[num] = roleDataBase;
				num++;
			}
		}
	}

	// Token: 0x06004958 RID: 18776 RVA: 0x0018E49C File Offset: 0x0018C69C
	public override void Refresh(BabelTowerRoleListItemData data)
	{
		this.Data = data;
		RoleDataBase roleData = data.RoleData;
		int dataId = roleData.GetDataId();
		bool flag = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		RoleLevelData levelData = roleData.GetLevelData();
		int? index = null;
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in RoleSelectModel.Instance.RoleIndexMap)
		{
			int key = keyValuePair.Key;
			if (keyValuePair.Value.GetDataId() == dataId)
			{
				index = new int?(key);
				break;
			}
		}
		int roleSkillBranchIndexInGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInGamePlay(dataId, ESkillBranchCacheType.BabelTower);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(dataId),
			SkinId = roleData.GetRoleSkinId(),
			IsTrialRoleVisible = new bool?(roleData.IsTrialRole()),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				levelData.GetLevel()
			},
			ElementId = new int?(roleData.GetRoleConfig().ElementId),
			Data = roleData,
			Index = index,
			IsInTeam = null,
			SkillBranchIndex = ((roleSkillBranchIndexInGamePlay > -1) ? new int?(roleSkillBranchIndexInGamePlay) : null)
		};
		this.RoleGrid.Apply<CharacterMediumItemGrid>(parameters);
		this.RoleGrid.GetItemGridExtendToggle().SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040036A3 RID: 13987
	private const int MAX_SELECT_ROLE_COUNT = 3;

	// Token: 0x040036A4 RID: 13988
	public BabelTowerRoleListItemData Data;

	// Token: 0x040036A5 RID: 13989
	private readonly MediumItemGrid RoleGrid = new MediumItemGrid();
}

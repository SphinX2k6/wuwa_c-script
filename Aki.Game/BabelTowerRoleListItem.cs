using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200116C RID: 4460
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerRoleListItem : SyncGridProxyAbstract<BabelTowerRoleListItemData>
{
	// Token: 0x060075BD RID: 30141 RVA: 0x001855E4 File Offset: 0x001837E4
	protected override void OnStart()
	{
		this.RoleGrid.Initialize(this.RootActor);
		this.RoleGrid.SetToggleInteractive(true);
		this.RoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanGridToggleStateChange));
		this.RoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnGridToggleStateChanged));
		this.RoleGrid.SetUseFixedAsync(true);
	}

	// Token: 0x060075BE RID: 30142 RVA: 0x00185648 File Offset: 0x00183848
	[NullableContext(2)]
	private bool OnCanGridToggleStateChange(object data, bool isForceSelected, EToggleState state)
	{
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		BabelTowerRoleSelectPanel ownerPanel = this.Data.OwnerPanel;
		if (ownerPanel == null)
		{
			return true;
		}
		int configId = this.Data.RoleData.GetDataId();
		int roleId = this.Data.RoleData.GetRoleId();
		HashSet<int> selectedSet = RoleSelectModel.Instance.SelectedRoleSet;
		if (selectedSet.Count >= 3 && !selectedSet.Contains(configId))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			Action onMaxSelectReached = ownerPanel.OnMaxSelectReached;
			if (onMaxSelectReached != null)
			{
				onMaxSelectReached();
			}
			return false;
		}
		IEnumerable<RoleDataBase> first = RoleModel.Instance.GetRoleList().Cast<RoleDataBase>().ToList<RoleDataBase>();
		List<RoleDataBase> trialRoleList = ownerPanel.GetTrialRoleList();
		if ((from r in first.Concat(trialRoleList)
		where selectedSet.Contains(r.GetDataId())
		select r).ToList<RoleDataBase>().Any((RoleDataBase r) => r.GetRoleId() == roleId && r.GetDataId() != configId))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x060075BF RID: 30143 RVA: 0x00185758 File Offset: 0x00183958
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

	// Token: 0x060075C0 RID: 30144 RVA: 0x00185854 File Offset: 0x00183A54
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

	// Token: 0x060075C1 RID: 30145 RVA: 0x001858F4 File Offset: 0x00183AF4
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

	// Token: 0x0400360A RID: 13834
	private const int MAX_SELECT_ROLE_COUNT = 3;

	// Token: 0x0400360B RID: 13835
	public BabelTowerRoleListItemData Data;

	// Token: 0x0400360C RID: 13836
	private readonly MediumItemGrid RoleGrid = new MediumItemGrid();
}

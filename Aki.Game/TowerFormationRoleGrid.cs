using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02002BF4 RID: 11252
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerFormationRoleGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x060175EF RID: 95727 RVA: 0x005F21C8 File Offset: 0x005F03C8
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		RoleLevelData levelData = data.GetLevelData();
		int dataId = data.GetDataId();
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId);
		TowerModel instance = TowerModel.Instance;
		int roleRemainCost = instance.GetRoleRemainCost(dataId, instance.CurrentSelectDifficulties);
		TowerConfig? towerConfig;
		int num = (TowerClimbConfig.Instance.GetTowerInfo(instance.CurrentSelectFloor) != null) ? towerConfig.GetValueOrDefault().Cost : 0;
		bool floorIncludeRole = instance.GetFloorIncludeRole(dataId, instance.CurrentSelectFloor);
		int num2 = floorIncludeRole ? roleRemainCost : (roleRemainCost - num);
		int teamSlot = this.GetTeamSlot(dataId);
		int? index = (teamSlot > 0) ? new int?(teamSlot) : null;
		bool flag = instance.IsRoleCostEnough(dataId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(dataId),
			SkinId = data.GetRoleSkinId(),
			IsTrialRoleVisible = new bool?(data.IsTrialRole()),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				levelData.GetLevel()
			},
			ElementId = new int?(data.GetRoleConfig().ElementId),
			Data = data,
			IsRecommendVisible = new bool?(false),
			Index = index,
			IsDisable = new bool?(!flag),
			ShowCostData = new MediumItemGridCostComponentData
			{
				Cost = num2,
				Color = ((num2 >= 4) ? TowerData.highColor : TowerData.lowColor).Value,
				BeforeCost = (floorIncludeRole ? null : new int?(roleRemainCost)),
				BeforeColor = (floorIncludeRole ? null : ((roleRemainCost >= 4) ? TowerData.highColor : TowerData.lowColor))
			},
			SkillBranchIndex = ((roleSkillBranchIndexInCurrentGamePlay > -1) ? new int?(roleSkillBranchIndexInCurrentGamePlay) : null)
		};
		base.SetUseFixedAsync(true);
		base.Apply<CharacterMediumItemGrid>(parameters);
		if (data.IsTrialRole())
		{
			base.SetLevelAndLock(null, null, null, null, null, null);
		}
		else
		{
			bool value = data == null || !BattleTeamModel.Instance.Context.CanAddRoleToEditTeam(dataId);
			base.SetLevelAndLock(null, new bool?(value), null, null, null, null);
		}
		bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		this.SetSelected(bSelected, true);
	}

	// Token: 0x060175F0 RID: 95728 RVA: 0x005F248B File Offset: 0x005F068B
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x060175F1 RID: 95729 RVA: 0x005F2498 File Offset: 0x005F0698
	private int GetTeamSlot(int roleId)
	{
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in RoleSelectModel.Instance.RoleIndexMap)
		{
			if (keyValuePair.Value.GetDataId() == roleId)
			{
				return keyValuePair.Key;
			}
		}
		return -1;
	}

	// Token: 0x060175F2 RID: 95730 RVA: 0x005F2504 File Offset: 0x005F0704
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x060175F3 RID: 95731 RVA: 0x005F250E File Offset: 0x005F070E
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}

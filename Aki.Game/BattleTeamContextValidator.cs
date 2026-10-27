using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BBE RID: 7102
public class BattleTeamContextValidator : IFormationValidator
{
	// Token: 0x0600D3AD RID: 54189 RVA: 0x0030A9DC File Offset: 0x00308BDC
	public bool CanJoinTeam(int roleId, int formationId)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		return (!RoleUtils.IsSpecialTrialRole(roleId) || instance.CanUseSpecialTrialRole) && !instance.IsInBattleTeam(roleId, false) && instance.Context.CanAddRoleToEditTeam(roleId);
	}

	// Token: 0x0600D3AE RID: 54190 RVA: 0x0030AA1C File Offset: 0x00308C1C
	public bool IsNeedRevive(int roleId, int formationId)
	{
		if (TowerModel.Instance.IsOpenFloorFormation())
		{
			return false;
		}
		if (LordGymController.Instance.IsInLordGymDungeon())
		{
			return false;
		}
		if (AdamSmasherController.Instance.IsInAdamSmasherDungeon())
		{
			return false;
		}
		if (!GameModeModel.Instance.IsMulti)
		{
			return false;
		}
		bool flag = BattleTeamModel.Instance.IsInBattleTeam(roleId, false);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		return !((roleDataById != null) ? new bool?(roleDataById.IsTrialRole()) : null).GetValueOrDefault() && !flag && FormationModel.Instance.IsRoleDead(roleId);
	}

	// Token: 0x0600D3AF RID: 54191 RVA: 0x0030AAB0 File Offset: 0x00308CB0
	[NullableContext(1)]
	public bool CanSelectRole(int roleId, IReadOnlyList<int> selectedRoleIds)
	{
		if (RoleUtils.HasMultiTrialRole(roleId, selectedRoleIds.ToArray<int>(), null))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamMultiTrialRole", Array.Empty<object>());
			return false;
		}
		if (RoleUtils.HasSameRole(roleId, selectedRoleIds.ToArray<int>(), null))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0600D3B0 RID: 54192 RVA: 0x0030AB18 File Offset: 0x00308D18
	[NullableContext(1)]
	public bool CanQuickSelectConfirm(IReadOnlyList<int> selectedRoleIds)
	{
		FormationModel instance = FormationModel.Instance;
		if (selectedRoleIds.Count <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleEmpty", Array.Empty<object>());
			return false;
		}
		bool flag = true;
		foreach (int roleConfigId in selectedRoleIds)
		{
			if (!instance.IsRoleDead(roleConfigId))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditFormationAllDead", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0600D3B1 RID: 54193 RVA: 0x0030ABA8 File Offset: 0x00308DA8
	public bool ConfirmCheck(int roleId, int formationId, int editPosition)
	{
		if (this.IsNeedRevive(roleId, formationId))
		{
			BuffItemControl.Instance.TryUseResurrectionItem(roleId);
			return false;
		}
		BattleTeamModel instance = BattleTeamModel.Instance;
		BattleRoleSlotData currentEditRoleSlotData = instance.CurrentEditRoleSlotData;
		int editResultType = (int)this.GetEditResultType(roleId);
		int parentRolePositionInEditBattleTeam = instance.GetParentRolePositionInEditBattleTeam(roleId);
		if (editResultType != 2 && parentRolePositionInEditBattleTeam != -1 && parentRolePositionInEditBattleTeam != editPosition)
		{
			ScrollingTipsController.Instance.ShowTipsById("SameRole", Array.Empty<object>());
			return false;
		}
		if (instance.Context.IsMultiInstanceDungeon && currentEditRoleSlotData != null)
		{
			int? roleConfigId = currentEditRoleSlotData.RoleConfigId;
			if (roleConfigId.GetValueOrDefault() == roleId & roleConfigId != null)
			{
				BattleTeamModel battleTeamModel = instance;
				int? playerId;
				if (currentEditRoleSlotData == null)
				{
					playerId = null;
				}
				else
				{
					BattleRoleData roleData = currentEditRoleSlotData.RoleData;
					playerId = ((roleData != null) ? new int?(roleData.PlayerId) : null);
				}
				if (battleTeamModel.GetPlayerRoleNumber(playerId) < 2)
				{
					ScrollingTipsController.Instance.ShowTipsById("BattleTeamCanNotDownAllRole", Array.Empty<object>());
					return false;
				}
			}
		}
		if (instance.CanUseSpecialTrialRole)
		{
			int value = editPosition - 1;
			List<int> selfRoleSlotDataRoleIdList = instance.SelfRoleSlotDataRoleIdList;
			if (RoleUtils.HasMultiTrialRole(roleId, selfRoleSlotDataRoleIdList.ToArray(), new int?(value)))
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamMultiTrialRole", Array.Empty<object>());
				return false;
			}
			if (RoleUtils.HasSameRole(roleId, selfRoleSlotDataRoleIdList.ToArray(), new int?(value)))
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D3B2 RID: 54194 RVA: 0x0030ACF4 File Offset: 0x00308EF4
	public bool IsConfirmButtonEnable(int roleId, int formationId, int editPosition)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		BattleRoleSlotData currentEditRoleSlotData = instance.CurrentEditRoleSlotData;
		BattleRoleData battleRoleData = (currentEditRoleSlotData != null) ? currentEditRoleSlotData.RoleData : null;
		if (!instance.Context.CanAddRoleToEditTeam(roleId) && roleId <= 100000)
		{
			return false;
		}
		switch (this.GetEditResultType(roleId))
		{
		case EEditResultType.GoUp:
			return true;
		case EEditResultType.GoDown:
			return true;
		case EEditResultType.InOtherSlot:
			return battleRoleData != null;
		default:
			return true;
		}
	}

	// Token: 0x0600D3B3 RID: 54195 RVA: 0x0030AD58 File Offset: 0x00308F58
	[NullableContext(2)]
	public string GetConfirmButtonTextId(int roleId, int formationId, int editPosition)
	{
		if (roleId == 0)
		{
			return null;
		}
		if (this.IsNeedRevive(roleId, formationId))
		{
			return "EditBattleTeamRevive";
		}
		BattleTeamModel instance = BattleTeamModel.Instance;
		BattleRoleSlotData currentEditRoleSlotData = instance.CurrentEditRoleSlotData;
		if (!instance.Context.CanAddRoleToEditTeam(roleId) && roleId <= 100000)
		{
			return "JoinText";
		}
		switch (this.GetEditResultType(roleId))
		{
		case EEditResultType.GoUp:
			if (!currentEditRoleSlotData.HasRole)
			{
				return "JoinText";
			}
			return "ChangeText";
		case EEditResultType.GoDown:
			return "GoDownText";
		case EEditResultType.InOtherSlot:
			return "ChangeText";
		default:
			return "JoinText";
		}
	}

	// Token: 0x0600D3B4 RID: 54196 RVA: 0x0030ADE4 File Offset: 0x00308FE4
	public EEditResultType GetEditResultType(int roleConfigId)
	{
		if (roleConfigId == 0)
		{
			return EEditResultType.SelectedNone;
		}
		BattleTeamModel instance = BattleTeamModel.Instance;
		BattleRoleSlotData currentEditRoleSlotData = instance.CurrentEditRoleSlotData;
		if (currentEditRoleSlotData == null)
		{
			return EEditResultType.None;
		}
		int? roleConfigId2 = currentEditRoleSlotData.RoleConfigId;
		if (roleConfigId2.GetValueOrDefault() == roleConfigId & roleConfigId2 != null)
		{
			return EEditResultType.GoDown;
		}
		if (instance.HasSameConfigIdInAnyOwnRoleSlot(roleConfigId))
		{
			return EEditResultType.InOtherSlot;
		}
		return EEditResultType.GoUp;
	}
}

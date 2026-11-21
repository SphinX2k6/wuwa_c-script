using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200107D RID: 4221
public class BattleTeamContextValidator : IFormationValidator
{
	// Token: 0x0600A7BF RID: 42943 RVA: 0x00315AD0 File Offset: 0x00313CD0
	public bool CanJoinTeam(int roleId, int formationId)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		return (!RoleUtils.IsSpecialTrialRole(roleId) || instance.CanUseSpecialTrialRole) && !instance.IsInBattleTeam(roleId, false) && instance.Context.CanAddRoleToEditTeam(roleId);
	}

	// Token: 0x0600A7C0 RID: 42944 RVA: 0x00315B10 File Offset: 0x00313D10
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

	// Token: 0x0600A7C1 RID: 42945 RVA: 0x00315BA4 File Offset: 0x00313DA4
	[NullableContext(1)]
	public bool CanSelectRole(int roleId, IReadOnlyList<int> selectedRoleIds)
	{
		int[] array = new int[selectedRoleIds.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = selectedRoleIds[i];
		}
		if (RoleUtils.HasMultiTrialRole(roleId, array, null))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamMultiTrialRole", Array.Empty<object>());
			return false;
		}
		if (RoleUtils.HasSameRole(roleId, array, null))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0600A7C2 RID: 42946 RVA: 0x00315C28 File Offset: 0x00313E28
	[NullableContext(1)]
	public bool CanQuickSelectConfirm(IReadOnlyList<int> selectedRoleIds, int formationId)
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

	// Token: 0x0600A7C3 RID: 42947 RVA: 0x00315CB8 File Offset: 0x00313EB8
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

	// Token: 0x0600A7C4 RID: 42948 RVA: 0x00315E04 File Offset: 0x00314004
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

	// Token: 0x0600A7C5 RID: 42949 RVA: 0x00315E68 File Offset: 0x00314068
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

	// Token: 0x0600A7C6 RID: 42950 RVA: 0x00315EF4 File Offset: 0x003140F4
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

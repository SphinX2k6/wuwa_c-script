using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BBF RID: 7103
public class FormationContextValidator : IFormationValidator
{
	// Token: 0x0600D3B6 RID: 54198 RVA: 0x0030AE3B File Offset: 0x0030903B
	public bool CanJoinTeam(int roleId, int formationId)
	{
		return !FormationModel.Instance.IsInEditingFormation(formationId, roleId);
	}

	// Token: 0x0600D3B7 RID: 54199 RVA: 0x0030AE4C File Offset: 0x0030904C
	public bool IsNeedRevive(int roleId, int formationId)
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			return false;
		}
		FormationModel instance = FormationModel.Instance;
		bool flag = instance.IsInEditingFormation(formationId, roleId);
		RoleModel instance2 = RoleModel.Instance;
		bool? flag2;
		if (instance2 == null)
		{
			flag2 = null;
		}
		else
		{
			RoleDataBase roleDataById = instance2.GetRoleDataById(roleId, true);
			flag2 = ((roleDataById != null) ? new bool?(roleDataById.IsTrialRole()) : null);
		}
		bool? flag3 = flag2;
		return !flag3.GetValueOrDefault() && !flag && instance.IsRoleDead(roleId);
	}

	// Token: 0x0600D3B8 RID: 54200 RVA: 0x0030AEC4 File Offset: 0x003090C4
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

	// Token: 0x0600D3B9 RID: 54201 RVA: 0x0030AF2C File Offset: 0x0030912C
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

	// Token: 0x0600D3BA RID: 54202 RVA: 0x0030AFBC File Offset: 0x003091BC
	public bool ConfirmCheck(int roleId, int formationId, int editPosition)
	{
		if (this.IsNeedRevive(roleId, formationId))
		{
			BuffItemControl.Instance.TryUseResurrectionItem(roleId);
			return false;
		}
		FormationModel instance = FormationModel.Instance;
		bool flag = instance.IsInEditingFormation(formationId, roleId);
		int? currentFormationId = instance.CurrentFormationId;
		bool flag2 = currentFormationId.GetValueOrDefault() == formationId & currentFormationId != null;
		int[] editingRoleIdList = instance.GetEditingRoleIdList(formationId);
		bool flag3 = editingRoleIdList.Length == 1;
		if (flag2 && flag && flag3)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleEmpty", Array.Empty<object>());
			return false;
		}
		int value = editPosition - 1;
		if (RoleUtils.HasMultiTrialRole(roleId, editingRoleIdList, new int?(value)))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamMultiTrialRole", Array.Empty<object>());
			return false;
		}
		if (RoleUtils.HasSameRole(roleId, editingRoleIdList, new int?(value)))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamSameRole", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0600D3BB RID: 54203 RVA: 0x0030B08C File Offset: 0x0030928C
	public bool IsConfirmButtonEnable(int roleId, int formationId, int editPosition)
	{
		FormationModel instance = FormationModel.Instance;
		bool flag = instance.IsInEditingFormation(formationId, roleId);
		return instance.GetEditingRoleIdList(formationId).Length == 0 || instance.GetEditingRoleId(formationId, editPosition) > 0 || !flag;
	}

	// Token: 0x0600D3BC RID: 54204 RVA: 0x0030B0C8 File Offset: 0x003092C8
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
		FormationModel instance = FormationModel.Instance;
		bool flag = instance.IsInEditingFormation(formationId, roleId);
		int editingRolePosition = instance.GetEditingRolePosition(formationId, roleId);
		if (instance.GetEditingRoleIdList(formationId).Length == 0)
		{
			return "JoinText";
		}
		if (instance.GetEditingRoleId(formationId, editPosition) <= 0)
		{
			if (flag)
			{
				return "ChangeText";
			}
			return "JoinText";
		}
		else
		{
			if (!flag)
			{
				return "ChangeText";
			}
			if (editingRolePosition == 0)
			{
				return "JoinText";
			}
			if (editingRolePosition == editPosition)
			{
				return "GoDownText";
			}
			return "ChangeText";
		}
	}
}

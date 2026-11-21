using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200107E RID: 4222
public class FormationContextValidator : IFormationValidator
{
	// Token: 0x0600A7C8 RID: 42952 RVA: 0x00315F4B File Offset: 0x0031414B
	public bool CanJoinTeam(int roleId, int formationId)
	{
		return !FormationModel.Instance.IsInEditingFormation(formationId, roleId);
	}

	// Token: 0x0600A7C9 RID: 42953 RVA: 0x00315F5C File Offset: 0x0031415C
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

	// Token: 0x0600A7CA RID: 42954 RVA: 0x00315FD4 File Offset: 0x003141D4
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

	// Token: 0x0600A7CB RID: 42955 RVA: 0x00316058 File Offset: 0x00314258
	[NullableContext(1)]
	public bool CanQuickSelectConfirm(IReadOnlyList<int> selectedRoleIds, int formationId)
	{
		FormationModel instance = FormationModel.Instance;
		int? currentFormationId = instance.CurrentFormationId;
		if (!(formationId == currentFormationId.GetValueOrDefault() & currentFormationId != null))
		{
			return true;
		}
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

	// Token: 0x0600A7CC RID: 42956 RVA: 0x00316108 File Offset: 0x00314308
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

	// Token: 0x0600A7CD RID: 42957 RVA: 0x003161D8 File Offset: 0x003143D8
	public bool IsConfirmButtonEnable(int roleId, int formationId, int editPosition)
	{
		FormationModel instance = FormationModel.Instance;
		bool flag = instance.IsInEditingFormation(formationId, roleId);
		return instance.GetEditingRoleIdList(formationId).Length == 0 || instance.GetEditingRoleId(formationId, editPosition) > 0 || !flag;
	}

	// Token: 0x0600A7CE RID: 42958 RVA: 0x00316214 File Offset: 0x00314414
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

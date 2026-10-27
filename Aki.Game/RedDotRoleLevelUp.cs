using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003421 RID: 13345
public class RedDotRoleLevelUp : RedDotBase
{
	// Token: 0x0601CD83 RID: 118147 RVA: 0x0080C623 File Offset: 0x0080A823
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD84 RID: 118148 RVA: 0x0080C628 File Offset: 0x0080A828
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD85 RID: 118149 RVA: 0x0080C6C4 File Offset: 0x0080A8C4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD86 RID: 118150 RVA: 0x0080C75D File Offset: 0x0080A95D
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotAttributeTabLevelUpCondition(uId);
	}

	// Token: 0x0601CD87 RID: 118151 RVA: 0x0080C76A File Offset: 0x0080A96A
	private void OnRoleLevelUp(int roleId, int oldLevel, int newLevel)
	{
		base.EventCheckWithUid(roleId);
	}

	// Token: 0x0601CD88 RID: 118152 RVA: 0x0080C773 File Offset: 0x0080A973
	private void OnRoleBreakUp(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}

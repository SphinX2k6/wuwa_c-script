using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200341F RID: 13343
public class RedDotRoleBreakUp : RedDotBase
{
	// Token: 0x0601CD7A RID: 118138 RVA: 0x0080C498 File Offset: 0x0080A698
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD7B RID: 118139 RVA: 0x0080C49C File Offset: 0x0080A69C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD7C RID: 118140 RVA: 0x0080C538 File Offset: 0x0080A738
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD7D RID: 118141 RVA: 0x0080C5D1 File Offset: 0x0080A7D1
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotAttributeTabBreakUpCondition(uId);
	}

	// Token: 0x0601CD7E RID: 118142 RVA: 0x0080C5DE File Offset: 0x0080A7DE
	private void OnRoleLevelUp(int roleId, int oldLevel, int newLevel)
	{
		base.EventCheckWithUid(roleId);
	}

	// Token: 0x0601CD7F RID: 118143 RVA: 0x0080C5E7 File Offset: 0x0080A7E7
	private void OnRoleBreakUp(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}

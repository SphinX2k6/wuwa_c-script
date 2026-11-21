using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002993 RID: 10643
public class RedDotRoleLevelUp : RedDotBase
{
	// Token: 0x0601AA7B RID: 109179 RVA: 0x00832BE7 File Offset: 0x00830DE7
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA7C RID: 109180 RVA: 0x00832BEC File Offset: 0x00830DEC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA7D RID: 109181 RVA: 0x00832C88 File Offset: 0x00830E88
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA7E RID: 109182 RVA: 0x00832D21 File Offset: 0x00830F21
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotAttributeTabLevelUpCondition(uId);
	}

	// Token: 0x0601AA7F RID: 109183 RVA: 0x00832D2E File Offset: 0x00830F2E
	private void OnRoleLevelUp(int roleId, int oldLevel, int newLevel)
	{
		base.EventCheckWithUid(roleId);
	}

	// Token: 0x0601AA80 RID: 109184 RVA: 0x00832D37 File Offset: 0x00830F37
	private void OnRoleBreakUp(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}

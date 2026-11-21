using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002991 RID: 10641
public class RedDotRoleBreakUp : RedDotBase
{
	// Token: 0x0601AA72 RID: 109170 RVA: 0x00832A5C File Offset: 0x00830C5C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA73 RID: 109171 RVA: 0x00832A60 File Offset: 0x00830C60
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA74 RID: 109172 RVA: 0x00832AFC File Offset: 0x00830CFC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA75 RID: 109173 RVA: 0x00832B95 File Offset: 0x00830D95
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotAttributeTabBreakUpCondition(uId);
	}

	// Token: 0x0601AA76 RID: 109174 RVA: 0x00832BA2 File Offset: 0x00830DA2
	private void OnRoleLevelUp(int roleId, int oldLevel, int newLevel)
	{
		base.EventCheckWithUid(roleId);
	}

	// Token: 0x0601AA77 RID: 109175 RVA: 0x00832BAB File Offset: 0x00830DAB
	private void OnRoleBreakUp(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}

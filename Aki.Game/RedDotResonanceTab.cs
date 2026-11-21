using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002995 RID: 10645
public class RedDotResonanceTab : RedDotBase
{
	// Token: 0x0601AA87 RID: 109191 RVA: 0x00832E15 File Offset: 0x00831015
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA88 RID: 109192 RVA: 0x00832E18 File Offset: 0x00831018
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA89 RID: 109193 RVA: 0x00832E7C File Offset: 0x0083107C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA8A RID: 109194 RVA: 0x00832EDD File Offset: 0x008310DD
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotResonanceTabCondition(uId);
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003423 RID: 13347
public class RedDotResonanceTab : RedDotBase
{
	// Token: 0x0601CD8F RID: 118159 RVA: 0x0080C851 File Offset: 0x0080AA51
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD90 RID: 118160 RVA: 0x0080C854 File Offset: 0x0080AA54
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD91 RID: 118161 RVA: 0x0080C8B8 File Offset: 0x0080AAB8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD92 RID: 118162 RVA: 0x0080C919 File Offset: 0x0080AB19
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotResonanceTabCondition(uId);
	}
}

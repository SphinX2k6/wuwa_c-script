using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200341C RID: 13340
public class RedDotRoleSelectionList : RedDotBase
{
	// Token: 0x0601CD68 RID: 118120 RVA: 0x0080BE76 File Offset: 0x0080A076
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoleSelectionListUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CD69 RID: 118121 RVA: 0x0080BE94 File Offset: 0x0080A094
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoleSelectionListUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CD6A RID: 118122 RVA: 0x0080BEB2 File Offset: 0x0080A0B2
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotRoleSelectionListCondition();
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200298E RID: 10638
public class RedDotRoleSelectionList : RedDotBase
{
	// Token: 0x0601AA60 RID: 109152 RVA: 0x0083243A File Offset: 0x0083063A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoleSelectionListUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AA61 RID: 109153 RVA: 0x00832458 File Offset: 0x00830658
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoleSelectionListUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AA62 RID: 109154 RVA: 0x00832476 File Offset: 0x00830676
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotRoleSelectionListCondition();
	}
}

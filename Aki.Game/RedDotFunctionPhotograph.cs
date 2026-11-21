using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002912 RID: 10514
public class RedDotFunctionPhotograph : RedDotBase
{
	// Token: 0x0601A812 RID: 108562 RVA: 0x0082DC58 File Offset: 0x0082BE58
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotFilter, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(base.EventCheck));
	}

	// Token: 0x0601A813 RID: 108563 RVA: 0x0082DC92 File Offset: 0x0082BE92
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotFilter, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(base.EventCheck));
	}

	// Token: 0x0601A814 RID: 108564 RVA: 0x0082DCCC File Offset: 0x0082BECC
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

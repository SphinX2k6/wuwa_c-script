using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x02002919 RID: 10521
public class RedDotGiantInteract : RedDotBase
{
	// Token: 0x0601A836 RID: 108598 RVA: 0x0082E189 File Offset: 0x0082C389
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGiantNodeInteractChange, new Action(base.EventCheck));
	}

	// Token: 0x0601A837 RID: 108599 RVA: 0x0082E1A7 File Offset: 0x0082C3A7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGiantNodeInteractChange, new Action(base.EventCheck));
	}

	// Token: 0x0601A838 RID: 108600 RVA: 0x0082E1C5 File Offset: 0x0082C3C5
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.HasUnreadActivatedNode();
	}
}

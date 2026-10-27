using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant;

// Token: 0x020033A7 RID: 13223
public class RedDotGiantInteract : RedDotBase
{
	// Token: 0x0601CB3E RID: 117566 RVA: 0x00807BC5 File Offset: 0x00805DC5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGiantNodeInteractChange, new Action(base.EventCheck));
	}

	// Token: 0x0601CB3F RID: 117567 RVA: 0x00807BE3 File Offset: 0x00805DE3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGiantNodeInteractChange, new Action(base.EventCheck));
	}

	// Token: 0x0601CB40 RID: 117568 RVA: 0x00807C01 File Offset: 0x00805E01
	protected override bool OnCheck(int uId = 0)
	{
		return GiantConfig.HasUnreadActivatedNode();
	}
}

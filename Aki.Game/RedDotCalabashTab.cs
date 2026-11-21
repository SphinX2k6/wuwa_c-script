using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028E0 RID: 10464
public class RedDotCalabashTab : RedDotBase
{
	// Token: 0x0601A736 RID: 108342 RVA: 0x0082C241 File Offset: 0x0082A441
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionCalabash);
	}

	// Token: 0x0601A737 RID: 108343 RVA: 0x0082C24C File Offset: 0x0082A44C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.GetCalabashReward, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotRefreshCalabash, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
	}

	// Token: 0x0601A738 RID: 108344 RVA: 0x0082C2B0 File Offset: 0x0082A4B0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.GetCalabashReward, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshCalabash, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
	}

	// Token: 0x0601A739 RID: 108345 RVA: 0x0082C311 File Offset: 0x0082A511
	protected override bool OnCheck(int uId = 0)
	{
		return CalabashModel.Instance.CheckCanReceiveReward();
	}
}

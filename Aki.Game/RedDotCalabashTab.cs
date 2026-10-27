using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200336E RID: 13166
public class RedDotCalabashTab : RedDotBase
{
	// Token: 0x0601CA3E RID: 117310 RVA: 0x00805C7D File Offset: 0x00803E7D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionCalabash);
	}

	// Token: 0x0601CA3F RID: 117311 RVA: 0x00805C88 File Offset: 0x00803E88
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.GetCalabashReward, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotRefreshCalabash, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
	}

	// Token: 0x0601CA40 RID: 117312 RVA: 0x00805CEC File Offset: 0x00803EEC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.GetCalabashReward, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshCalabash, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
	}

	// Token: 0x0601CA41 RID: 117313 RVA: 0x00805D4D File Offset: 0x00803F4D
	protected override bool OnCheck(int uId = 0)
	{
		return CalabashModel.Instance.CheckCanReceiveReward();
	}
}

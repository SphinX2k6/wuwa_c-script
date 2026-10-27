using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003357 RID: 13143
public class RedDotAdventureFirstAward : RedDotBase
{
	// Token: 0x0601C9D5 RID: 117205 RVA: 0x00805122 File Offset: 0x00803322
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601C9D6 RID: 117206 RVA: 0x0080512B File Offset: 0x0080332B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601C9D7 RID: 117207 RVA: 0x00805149 File Offset: 0x00803349
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601C9D8 RID: 117208 RVA: 0x00805167 File Offset: 0x00803367
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideController.Instance.CheckCanGetFirstAward();
	}
}

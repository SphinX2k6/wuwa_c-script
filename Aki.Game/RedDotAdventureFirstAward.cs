using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028C9 RID: 10441
public class RedDotAdventureFirstAward : RedDotBase
{
	// Token: 0x0601A6CD RID: 108237 RVA: 0x0082B6E6 File Offset: 0x008298E6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601A6CE RID: 108238 RVA: 0x0082B6EF File Offset: 0x008298EF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601A6CF RID: 108239 RVA: 0x0082B70D File Offset: 0x0082990D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601A6D0 RID: 108240 RVA: 0x0082B72B File Offset: 0x0082992B
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideController.Instance.CheckCanGetFirstAward();
	}
}

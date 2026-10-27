using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200335A RID: 13146
public class RedDotAdventureManual : RedDotBase
{
	// Token: 0x0601C9E3 RID: 117219 RVA: 0x00805238 File Offset: 0x00803438
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601C9E4 RID: 117220 RVA: 0x00805241 File Offset: 0x00803441
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601C9E5 RID: 117221 RVA: 0x0080527B File Offset: 0x0080347B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601C9E6 RID: 117222 RVA: 0x008052B5 File Offset: 0x008034B5
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideController.Instance.CheckCanGetTaskAward();
	}
}

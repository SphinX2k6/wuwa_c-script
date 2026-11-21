using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028CC RID: 10444
public class RedDotAdventureManual : RedDotBase
{
	// Token: 0x0601A6DB RID: 108251 RVA: 0x0082B7FC File Offset: 0x008299FC
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601A6DC RID: 108252 RVA: 0x0082B805 File Offset: 0x00829A05
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601A6DD RID: 108253 RVA: 0x0082B83F File Offset: 0x00829A3F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotSilentFirstAward, new Action(base.EventCheck));
	}

	// Token: 0x0601A6DE RID: 108254 RVA: 0x0082B879 File Offset: 0x00829A79
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideController.Instance.CheckCanGetTaskAward();
	}
}

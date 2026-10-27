using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003351 RID: 13137
public class AdventurePeriodicityTab : RedDotBase
{
	// Token: 0x0601C9BC RID: 117180 RVA: 0x00804CB6 File Offset: 0x00802EB6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601C9BD RID: 117181 RVA: 0x00804CBF File Offset: 0x00802EBF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotAdventurePeriodicityTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9BE RID: 117182 RVA: 0x00804CF9 File Offset: 0x00802EF9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotAdventurePeriodicityTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9BF RID: 117183 RVA: 0x00804D33 File Offset: 0x00802F33
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideModel.Instance.CheckRedDotPeriodicityTab();
	}
}

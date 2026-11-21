using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028C3 RID: 10435
public class AdventurePeriodicityTab : RedDotBase
{
	// Token: 0x0601A6B4 RID: 108212 RVA: 0x0082B27A File Offset: 0x0082947A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601A6B5 RID: 108213 RVA: 0x0082B283 File Offset: 0x00829483
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotAdventurePeriodicityTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6B6 RID: 108214 RVA: 0x0082B2BD File Offset: 0x008294BD
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotAdventureManualUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotAdventurePeriodicityTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6B7 RID: 108215 RVA: 0x0082B2F7 File Offset: 0x008294F7
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideModel.Instance.CheckRedDotPeriodicityTab();
	}
}

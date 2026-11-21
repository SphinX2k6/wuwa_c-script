using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029AA RID: 10666
public class RedDotDrinksUnlockLevel : RedDotBase
{
	// Token: 0x0601AAF1 RID: 109297 RVA: 0x00833E45 File Offset: 0x00832045
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnDrinksUnlockClickedNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAF2 RID: 109298 RVA: 0x00833E7F File Offset: 0x0083207F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnDrinksUnlockClickedNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAF3 RID: 109299 RVA: 0x00833EB9 File Offset: 0x008320B9
	protected override bool OnCheck(int uId = 0)
	{
		return DrinksModel.Instance.CheckRedDot();
	}

	// Token: 0x0601AAF4 RID: 109300 RVA: 0x00833EC5 File Offset: 0x008320C5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}

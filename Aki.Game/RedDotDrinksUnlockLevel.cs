using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003436 RID: 13366
public class RedDotDrinksUnlockLevel : RedDotBase
{
	// Token: 0x0601CDF1 RID: 118257 RVA: 0x0080D75D File Offset: 0x0080B95D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnDrinksUnlockClickedNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDF2 RID: 118258 RVA: 0x0080D797 File Offset: 0x0080B997
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnDrinksUnlockClickedNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDF3 RID: 118259 RVA: 0x0080D7D1 File Offset: 0x0080B9D1
	protected override bool OnCheck(int uId = 0)
	{
		return DrinksModel.Instance.CheckRedDot();
	}

	// Token: 0x0601CDF4 RID: 118260 RVA: 0x0080D7DD File Offset: 0x0080B9DD
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}

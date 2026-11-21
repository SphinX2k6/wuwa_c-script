using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002958 RID: 10584
public class PersonalBirthdayRedDot : RedDotBase
{
	// Token: 0x0601A963 RID: 108899 RVA: 0x0083063F File Offset: 0x0082E83F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601A964 RID: 108900 RVA: 0x00830679 File Offset: 0x0082E879
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601A965 RID: 108901 RVA: 0x008306B3 File Offset: 0x0082E8B3
	protected override bool OnCheck(int uId = 0)
	{
		return BirthdayModel.Instance.GetBirthdayRedDotState();
	}
}

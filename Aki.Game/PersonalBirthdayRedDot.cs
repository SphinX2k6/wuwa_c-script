using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033E6 RID: 13286
public class PersonalBirthdayRedDot : RedDotBase
{
	// Token: 0x0601CC6B RID: 117867 RVA: 0x0080A07B File Offset: 0x0080827B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CC6C RID: 117868 RVA: 0x0080A0B5 File Offset: 0x008082B5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CC6D RID: 117869 RVA: 0x0080A0EF File Offset: 0x008082EF
	protected override bool OnCheck(int uId = 0)
	{
		return BirthdayModel.Instance.GetBirthdayRedDotState();
	}
}

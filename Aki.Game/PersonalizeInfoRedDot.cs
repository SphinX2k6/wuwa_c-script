using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x0200295B RID: 10587
public class PersonalizeInfoRedDot : RedDotBase
{
	// Token: 0x0601A96F RID: 108911 RVA: 0x00830768 File Offset: 0x0082E968
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601A970 RID: 108912 RVA: 0x008307E8 File Offset: 0x0082E9E8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601A971 RID: 108913 RVA: 0x00830865 File Offset: 0x0082EA65
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.GetPersonalCardRedDotState() || PersonalModel.Instance.GetPersonalTitleRedDotState() || BirthdayModel.Instance.GetBirthdayRedDotState();
	}
}

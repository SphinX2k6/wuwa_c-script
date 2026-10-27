using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x020033E9 RID: 13289
public class PersonalizeInfoRedDot : RedDotBase
{
	// Token: 0x0601CC77 RID: 117879 RVA: 0x0080A1A4 File Offset: 0x008083A4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CC78 RID: 117880 RVA: 0x0080A224 File Offset: 0x00808424
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CC79 RID: 117881 RVA: 0x0080A2A1 File Offset: 0x008084A1
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.GetPersonalCardRedDotState() || PersonalModel.Instance.GetPersonalTitleRedDotState() || BirthdayModel.Instance.GetBirthdayRedDotState();
	}
}

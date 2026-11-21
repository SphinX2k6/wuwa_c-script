using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x0200295C RID: 10588
public class PersonalTitleRedDot : RedDotBase
{
	// Token: 0x0601A973 RID: 108915 RVA: 0x00830893 File Offset: 0x0082EA93
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A974 RID: 108916 RVA: 0x008308B1 File Offset: 0x0082EAB1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A975 RID: 108917 RVA: 0x008308CF File Offset: 0x0082EACF
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.GetPersonalTitleRedDotState();
	}
}

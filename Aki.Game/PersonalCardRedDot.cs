using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x02002959 RID: 10585
public class PersonalCardRedDot : RedDotBase
{
	// Token: 0x0601A967 RID: 108903 RVA: 0x008306C7 File Offset: 0x0082E8C7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A968 RID: 108904 RVA: 0x008306E5 File Offset: 0x0082E8E5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPersonalCardRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A969 RID: 108905 RVA: 0x00830703 File Offset: 0x0082E903
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.GetPersonalCardRedDotState();
	}
}

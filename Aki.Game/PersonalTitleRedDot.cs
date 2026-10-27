using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x020033EA RID: 13290
public class PersonalTitleRedDot : RedDotBase
{
	// Token: 0x0601CC7B RID: 117883 RVA: 0x0080A2CF File Offset: 0x008084CF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC7C RID: 117884 RVA: 0x0080A2ED File Offset: 0x008084ED
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleRefreshRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC7D RID: 117885 RVA: 0x0080A30B File Offset: 0x0080850B
	protected override bool OnCheck(int uId = 0)
	{
		return PersonalModel.Instance.GetPersonalTitleRedDotState();
	}
}

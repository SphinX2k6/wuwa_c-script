using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C3 RID: 13251
public class RedDotMoonChasingMainlineTab : RedDotBase
{
	// Token: 0x0601CBBE RID: 117694 RVA: 0x00808C52 File Offset: 0x00806E52
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingAllQuest);
	}

	// Token: 0x0601CBBF RID: 117695 RVA: 0x00808C5E File Offset: 0x00806E5E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBC0 RID: 117696 RVA: 0x00808C7C File Offset: 0x00806E7C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBC1 RID: 117697 RVA: 0x00808C9A File Offset: 0x00806E9A
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingModel.Instance.CheckMainlineRedDot();
	}
}

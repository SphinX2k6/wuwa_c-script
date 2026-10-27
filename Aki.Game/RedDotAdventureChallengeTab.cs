using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003353 RID: 13139
public class RedDotAdventureChallengeTab : RedDotBase
{
	// Token: 0x0601C9C3 RID: 117187 RVA: 0x00804D6A File Offset: 0x00802F6A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionAdventure);
	}

	// Token: 0x0601C9C4 RID: 117188 RVA: 0x00804D73 File Offset: 0x00802F73
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotAdventureChallengeTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9C5 RID: 117189 RVA: 0x00804D91 File Offset: 0x00802F91
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotAdventureChallengeTabUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9C6 RID: 117190 RVA: 0x00804DAF File Offset: 0x00802FAF
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(10023) && AdventureGuideModel.Instance.CheckRedDotChallengeTab();
	}
}

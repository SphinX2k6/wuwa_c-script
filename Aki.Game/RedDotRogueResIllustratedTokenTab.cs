using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002987 RID: 10631
public class RedDotRogueResIllustratedTokenTab : RedDotBase
{
	// Token: 0x0601AA42 RID: 109122 RVA: 0x00832025 File Offset: 0x00830225
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RogueResIllustrated);
	}

	// Token: 0x0601AA43 RID: 109123 RVA: 0x00832031 File Offset: 0x00830231
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA44 RID: 109124 RVA: 0x0083206B File Offset: 0x0083026B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA45 RID: 109125 RVA: 0x008320A5 File Offset: 0x008302A5
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.GetHaveTokenAward(uId);
	}
}

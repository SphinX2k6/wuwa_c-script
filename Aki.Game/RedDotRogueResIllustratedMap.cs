using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002985 RID: 10629
public class RedDotRogueResIllustratedMap : RedDotBase
{
	// Token: 0x0601AA38 RID: 109112 RVA: 0x00831EFB File Offset: 0x008300FB
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RogueResIllustrated);
	}

	// Token: 0x0601AA39 RID: 109113 RVA: 0x00831F07 File Offset: 0x00830107
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA3A RID: 109114 RVA: 0x00831F41 File Offset: 0x00830141
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA3B RID: 109115 RVA: 0x00831F7B File Offset: 0x0083017B
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.GetHaveMapAward(uId);
	}
}

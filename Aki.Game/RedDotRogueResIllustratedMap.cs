using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003413 RID: 13331
public class RedDotRogueResIllustratedMap : RedDotBase
{
	// Token: 0x0601CD40 RID: 118080 RVA: 0x0080B937 File Offset: 0x00809B37
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RogueResIllustrated);
	}

	// Token: 0x0601CD41 RID: 118081 RVA: 0x0080B943 File Offset: 0x00809B43
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD42 RID: 118082 RVA: 0x0080B97D File Offset: 0x00809B7D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD43 RID: 118083 RVA: 0x0080B9B7 File Offset: 0x00809BB7
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.GetHaveMapAward(uId);
	}
}

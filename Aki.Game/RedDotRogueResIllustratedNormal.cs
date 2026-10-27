using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003414 RID: 13332
public class RedDotRogueResIllustratedNormal : RedDotBase
{
	// Token: 0x0601CD45 RID: 118085 RVA: 0x0080B9CC File Offset: 0x00809BCC
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RogueResIllustrated);
	}

	// Token: 0x0601CD46 RID: 118086 RVA: 0x0080B9D8 File Offset: 0x00809BD8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD47 RID: 118087 RVA: 0x0080BA12 File Offset: 0x00809C12
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD48 RID: 118088 RVA: 0x0080BA4C File Offset: 0x00809C4C
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.GetHaveNormalAward(uId);
	}
}

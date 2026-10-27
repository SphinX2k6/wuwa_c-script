using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003415 RID: 13333
public class RedDotRogueResIllustratedTokenTab : RedDotBase
{
	// Token: 0x0601CD4A RID: 118090 RVA: 0x0080BA61 File Offset: 0x00809C61
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RogueResIllustrated);
	}

	// Token: 0x0601CD4B RID: 118091 RVA: 0x0080BA6D File Offset: 0x00809C6D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD4C RID: 118092 RVA: 0x0080BAA7 File Offset: 0x00809CA7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD4D RID: 118093 RVA: 0x0080BAE1 File Offset: 0x00809CE1
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.GetHaveTokenAward(uId);
	}
}

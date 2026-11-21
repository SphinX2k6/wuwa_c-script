using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002986 RID: 10630
public class RedDotRogueResIllustratedNormal : RedDotBase
{
	// Token: 0x0601AA3D RID: 109117 RVA: 0x00831F90 File Offset: 0x00830190
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RogueResIllustrated);
	}

	// Token: 0x0601AA3E RID: 109118 RVA: 0x00831F9C File Offset: 0x0083019C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA3F RID: 109119 RVA: 0x00831FD6 File Offset: 0x008301D6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA40 RID: 109120 RVA: 0x00832010 File Offset: 0x00830210
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.GetHaveNormalAward(uId);
	}
}

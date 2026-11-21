using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002983 RID: 10627
public class RedDotRogueResEnding : RedDotBase
{
	// Token: 0x0601AA30 RID: 109104 RVA: 0x00831E5A File Offset: 0x0083005A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA31 RID: 109105 RVA: 0x00831E78 File Offset: 0x00830078
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA32 RID: 109106 RVA: 0x00831E96 File Offset: 0x00830096
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckEndingAwardRedDot(uId);
	}
}

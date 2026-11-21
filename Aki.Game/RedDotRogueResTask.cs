using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x0200298B RID: 10635
public class RedDotRogueResTask : RedDotBase
{
	// Token: 0x0601AA53 RID: 109139 RVA: 0x008321E5 File Offset: 0x008303E5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AA54 RID: 109140 RVA: 0x00832203 File Offset: 0x00830403
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AA55 RID: 109141 RVA: 0x00832221 File Offset: 0x00830421
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckAllTaskRedDot();
	}
}

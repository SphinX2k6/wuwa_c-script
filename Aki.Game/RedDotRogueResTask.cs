using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003419 RID: 13337
public class RedDotRogueResTask : RedDotBase
{
	// Token: 0x0601CD5B RID: 118107 RVA: 0x0080BC21 File Offset: 0x00809E21
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CD5C RID: 118108 RVA: 0x0080BC3F File Offset: 0x00809E3F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CD5D RID: 118109 RVA: 0x0080BC5D File Offset: 0x00809E5D
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckAllTaskRedDot();
	}
}

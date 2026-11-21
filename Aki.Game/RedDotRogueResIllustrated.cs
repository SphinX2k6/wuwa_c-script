using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002984 RID: 10628
public class RedDotRogueResIllustrated : RedDotBase
{
	// Token: 0x0601AA34 RID: 109108 RVA: 0x00831EAB File Offset: 0x008300AB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AA35 RID: 109109 RVA: 0x00831EC9 File Offset: 0x008300C9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AA36 RID: 109110 RVA: 0x00831EE7 File Offset: 0x008300E7
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckIllustratedRedDot();
	}
}

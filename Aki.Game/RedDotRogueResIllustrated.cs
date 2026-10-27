using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003412 RID: 13330
public class RedDotRogueResIllustrated : RedDotBase
{
	// Token: 0x0601CD3C RID: 118076 RVA: 0x0080B8E7 File Offset: 0x00809AE7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CD3D RID: 118077 RVA: 0x0080B905 File Offset: 0x00809B05
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CD3E RID: 118078 RVA: 0x0080B923 File Offset: 0x00809B23
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckIllustratedRedDot();
	}
}

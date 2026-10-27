using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;

// Token: 0x0200340C RID: 13324
public class RedDotRhythmShipTimeLimitTask : RedDotBase
{
	// Token: 0x0601CD1D RID: 118045 RVA: 0x0080B4DA File Offset: 0x008096DA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CD1E RID: 118046 RVA: 0x0080B4F8 File Offset: 0x008096F8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CD1F RID: 118047 RVA: 0x0080B516 File Offset: 0x00809716
	protected override bool OnCheck(int uId = 0)
	{
		return RhythmShipModel.Instance.GetCanTaskGetReward(1);
	}
}

using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;

// Token: 0x0200340A RID: 13322
public class RedDotRhythmShipTask : RedDotBase
{
	// Token: 0x0601CD14 RID: 118036 RVA: 0x0080B42B File Offset: 0x0080962B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CD15 RID: 118037 RVA: 0x0080B449 File Offset: 0x00809649
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CD16 RID: 118038 RVA: 0x0080B467 File Offset: 0x00809667
	protected override bool OnCheck(int uId = 0)
	{
		return RhythmShipModel.Instance.GetCanTaskGetReward(0);
	}
}

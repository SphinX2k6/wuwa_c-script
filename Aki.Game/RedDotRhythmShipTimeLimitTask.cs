using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;

// Token: 0x0200297E RID: 10622
public class RedDotRhythmShipTimeLimitTask : RedDotBase
{
	// Token: 0x0601AA15 RID: 109077 RVA: 0x00831A9E File Offset: 0x0082FC9E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA16 RID: 109078 RVA: 0x00831ABC File Offset: 0x0082FCBC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA17 RID: 109079 RVA: 0x00831ADA File Offset: 0x0082FCDA
	protected override bool OnCheck(int uId = 0)
	{
		return RhythmShipModel.Instance.GetCanTaskGetReward(1);
	}
}

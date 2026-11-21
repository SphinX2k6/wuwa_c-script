using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;

// Token: 0x0200297C RID: 10620
public class RedDotRhythmShipTask : RedDotBase
{
	// Token: 0x0601AA0C RID: 109068 RVA: 0x008319EF File Offset: 0x0082FBEF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA0D RID: 109069 RVA: 0x00831A0D File Offset: 0x0082FC0D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AA0E RID: 109070 RVA: 0x00831A2B File Offset: 0x0082FC2B
	protected override bool OnCheck(int uId = 0)
	{
		return RhythmShipModel.Instance.GetCanTaskGetReward(0);
	}
}

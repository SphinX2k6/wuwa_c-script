using System;
using System.Runtime.CompilerServices;

// Token: 0x0200125F RID: 4703
public class NoUiTimer : LogicTreeTimerBase
{
	// Token: 0x0600BA45 RID: 47685 RVA: 0x0036F773 File Offset: 0x0036D973
	[NullableContext(1)]
	public NoUiTimer(long treeIncId, string timerType, bool needTick = true, double intervalTime = 20.0) : base(treeIncId, timerType, needTick, intervalTime)
	{
	}

	// Token: 0x0600BA46 RID: 47686 RVA: 0x0036F780 File Offset: 0x0036D980
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		this.TimerEndTime = endTime;
		this.TimerPauseTime = pauseTime;
	}

	// Token: 0x0600BA47 RID: 47687 RVA: 0x0036F790 File Offset: 0x0036D990
	public override double GetRemainTime()
	{
		double val = (this.TimerEndTime - TimeUtil.Instance.GetServerStopTimeStamp()) / 1000.0;
		double val2 = (this.TimerPauseTime != 0.0) ? ((this.TimerEndTime - this.TimerPauseTime) / 1000.0) : -1.0;
		return Math.Max(val, Math.Max(val2, 0.0));
	}

	// Token: 0x04006B5B RID: 27483
	private double TimerEndTime;

	// Token: 0x04006B5C RID: 27484
	private double TimerPauseTime;
}

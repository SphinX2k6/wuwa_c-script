using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D9D RID: 7581
public class NoUiTimer : LogicTreeTimerBase
{
	// Token: 0x0600E627 RID: 58919 RVA: 0x00363B13 File Offset: 0x00361D13
	[NullableContext(1)]
	public NoUiTimer(long treeIncId, string timerType, bool needTick = true, double intervalTime = 20.0) : base(treeIncId, timerType, needTick, intervalTime)
	{
	}

	// Token: 0x0600E628 RID: 58920 RVA: 0x00363B20 File Offset: 0x00361D20
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		this.TimerEndTime = endTime;
		this.TimerPauseTime = pauseTime;
	}

	// Token: 0x0600E629 RID: 58921 RVA: 0x00363B30 File Offset: 0x00361D30
	public override double GetRemainTime()
	{
		double val = (this.TimerEndTime - TimeUtil.Instance.GetServerStopTimeStamp()) / 1000.0;
		double val2 = (this.TimerPauseTime != 0.0) ? ((this.TimerEndTime - this.TimerPauseTime) / 1000.0) : -1.0;
		return Math.Max(val, Math.Max(val2, 0.0));
	}

	// Token: 0x04006A7A RID: 27258
	private double TimerEndTime;

	// Token: 0x04006A7B RID: 27259
	private double TimerPauseTime;
}

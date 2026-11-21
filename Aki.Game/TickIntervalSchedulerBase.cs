using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AC0 RID: 10944
public class TickIntervalSchedulerBase
{
	// Token: 0x0601BC7F RID: 113791 RVA: 0x0088D290 File Offset: 0x0088B490
	public void SetBaseConfigs(double maxNoIntervalCount, double averageOtherTickCount, double noIntervalThreshold)
	{
		this.MaxNoIntervalCount = Math.Max(0.0, maxNoIntervalCount);
		this.AverageOtherTickCount = Math.Max(1.0, averageOtherTickCount);
		this.NoIntervalThreshold = noIntervalThreshold;
	}

	// Token: 0x0601BC80 RID: 113792 RVA: 0x0088D2C3 File Offset: 0x0088B4C3
	public void SetCountDelta(double newDelta)
	{
		this.CurrentCountDelta = MathUtils.Instance.Clamp(newDelta * this.DeltaRatio, this.MinTickCountDelta, this.MaxTickCountDelta);
	}

	// Token: 0x0601BC81 RID: 113793 RVA: 0x0088D2E9 File Offset: 0x0088B4E9
	public void Schedule()
	{
		this.GetScores();
		this.ScheduleTickInterval();
	}

	// Token: 0x0601BC82 RID: 113794 RVA: 0x0088D2F7 File Offset: 0x0088B4F7
	public virtual void ChangeTickFramePeriodByFrameRate(double frameRate)
	{
	}

	// Token: 0x0601BC83 RID: 113795 RVA: 0x0088D2F9 File Offset: 0x0088B4F9
	protected virtual void GetScores()
	{
	}

	// Token: 0x0601BC84 RID: 113796 RVA: 0x0088D2FB File Offset: 0x0088B4FB
	protected virtual void ScheduleTickInterval()
	{
	}

	// Token: 0x0400F011 RID: 61457
	protected double MaxNoIntervalCount;

	// Token: 0x0400F012 RID: 61458
	protected double AverageOtherTickCount;

	// Token: 0x0400F013 RID: 61459
	protected double NoIntervalThreshold;

	// Token: 0x0400F014 RID: 61460
	protected double MinTickCountDelta;

	// Token: 0x0400F015 RID: 61461
	protected double MaxTickCountDelta;

	// Token: 0x0400F016 RID: 61462
	protected double CurrentCountDelta;

	// Token: 0x0400F017 RID: 61463
	protected double DeltaRatio = 1.0;

	// Token: 0x0400F018 RID: 61464
	[Nullable(1)]
	private readonly Stat Stat = Stat.CreateNoFlameGraph(typeof(TickIntervalSchedulerBase).Name, "", "");
}

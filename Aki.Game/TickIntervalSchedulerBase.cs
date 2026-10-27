using System;
using System.Runtime.CompilerServices;

// Token: 0x0200354B RID: 13643
public class TickIntervalSchedulerBase
{
	// Token: 0x0601DF57 RID: 122711 RVA: 0x00865658 File Offset: 0x00863858
	public void SetBaseConfigs(double maxNoIntervalCount, double averageOtherTickCount, double noIntervalThreshold)
	{
		this.MaxNoIntervalCount = Math.Max(0.0, maxNoIntervalCount);
		this.AverageOtherTickCount = Math.Max(1.0, averageOtherTickCount);
		this.NoIntervalThreshold = noIntervalThreshold;
	}

	// Token: 0x0601DF58 RID: 122712 RVA: 0x0086568B File Offset: 0x0086388B
	public void SetCountDelta(double newDelta)
	{
		this.CurrentCountDelta = MathUtils.Instance.Clamp(newDelta * this.DeltaRatio, this.MinTickCountDelta, this.MaxTickCountDelta);
	}

	// Token: 0x0601DF59 RID: 122713 RVA: 0x008656B1 File Offset: 0x008638B1
	public void Schedule()
	{
		this.GetScores();
		this.ScheduleTickInterval();
	}

	// Token: 0x0601DF5A RID: 122714 RVA: 0x008656BF File Offset: 0x008638BF
	public virtual void ChangeTickFramePeriodByFrameRate(double frameRate)
	{
	}

	// Token: 0x0601DF5B RID: 122715 RVA: 0x008656C1 File Offset: 0x008638C1
	protected virtual void GetScores()
	{
	}

	// Token: 0x0601DF5C RID: 122716 RVA: 0x008656C3 File Offset: 0x008638C3
	protected virtual void ScheduleTickInterval()
	{
	}

	// Token: 0x0400EB54 RID: 60244
	protected double MaxNoIntervalCount;

	// Token: 0x0400EB55 RID: 60245
	protected double AverageOtherTickCount;

	// Token: 0x0400EB56 RID: 60246
	protected double NoIntervalThreshold;

	// Token: 0x0400EB57 RID: 60247
	protected double MinTickCountDelta;

	// Token: 0x0400EB58 RID: 60248
	protected double MaxTickCountDelta;

	// Token: 0x0400EB59 RID: 60249
	protected double CurrentCountDelta;

	// Token: 0x0400EB5A RID: 60250
	protected double DeltaRatio = 1.0;

	// Token: 0x0400EB5B RID: 60251
	[Nullable(1)]
	private readonly Stat Stat = Stat.CreateNoFlameGraph(typeof(TickIntervalSchedulerBase).Name, "", "");
}

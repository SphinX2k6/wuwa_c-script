using System;

// Token: 0x02000104 RID: 260
public class TickIntervalConfig
{
	// Token: 0x060009C7 RID: 2503 RVA: 0x0003226C File Offset: 0x0003046C
	public TickIntervalConfig(int tickPerFrameThreshold, int tickFramePeriod, double tickPerFrameThresholdRadio, double tickFramePeriodRatio, int maxInterval)
	{
		this.TickPerFrameThreshold = tickPerFrameThreshold;
		this.TickFramePeriod = tickFramePeriod;
		this.TickPerFrameThresholdRadio = tickPerFrameThresholdRadio;
		this.TickFramePeriodRatio = tickFramePeriodRatio;
		this.MaxInterval = maxInterval;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0003229C File Offset: 0x0003049C
	public double GetScore(double distance, double radio)
	{
		return Math.Min((double)this.MaxInterval, Math.Max(0.0, distance - (double)this.TickPerFrameThreshold) / (double)this.TickFramePeriod + Math.Max(0.0, radio - this.TickPerFrameThresholdRadio) / this.TickFramePeriodRatio);
	}

	// Token: 0x04000681 RID: 1665
	public int TickPerFrameThreshold;

	// Token: 0x04000682 RID: 1666
	public int TickFramePeriod;

	// Token: 0x04000683 RID: 1667
	public double TickPerFrameThresholdRadio;

	// Token: 0x04000684 RID: 1668
	public double TickFramePeriodRatio;

	// Token: 0x04000685 RID: 1669
	public int MaxInterval;
}

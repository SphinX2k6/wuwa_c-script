using System;

// Token: 0x02000104 RID: 260
public class TickIntervalConfig
{
	// Token: 0x06000A18 RID: 2584 RVA: 0x00032BC8 File Offset: 0x00030DC8
	public TickIntervalConfig(int tickPerFrameThreshold, int tickFramePeriod, double tickPerFrameThresholdRadio, double tickFramePeriodRatio, int maxInterval)
	{
		this.TickPerFrameThreshold = tickPerFrameThreshold;
		this.TickFramePeriod = tickFramePeriod;
		this.TickPerFrameThresholdRadio = tickPerFrameThresholdRadio;
		this.TickFramePeriodRatio = tickFramePeriodRatio;
		this.MaxInterval = maxInterval;
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00032BF8 File Offset: 0x00030DF8
	public double GetScore(double distance, double radio)
	{
		return Math.Min((double)this.MaxInterval, Math.Max(0.0, distance - (double)this.TickPerFrameThreshold) / (double)this.TickFramePeriod + Math.Max(0.0, radio - this.TickPerFrameThresholdRadio) / this.TickFramePeriodRatio);
	}

	// Token: 0x0400068C RID: 1676
	public int TickPerFrameThreshold;

	// Token: 0x0400068D RID: 1677
	public int TickFramePeriod;

	// Token: 0x0400068E RID: 1678
	public double TickPerFrameThresholdRadio;

	// Token: 0x0400068F RID: 1679
	public double TickFramePeriodRatio;

	// Token: 0x04000690 RID: 1680
	public int MaxInterval;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02000105 RID: 261
[NullableContext(1)]
[Nullable(0)]
public static class TickIntervalUtils
{
	// Token: 0x06000A1A RID: 2586 RVA: 0x00032C50 File Offset: 0x00030E50
	private static int GetTickInterval(double distance, double radio, TickIntervalConfig config)
	{
		if (distance < (double)config.TickPerFrameThreshold && radio < config.TickPerFrameThresholdRadio)
		{
			return 0;
		}
		double num = 1.0;
		if (distance > (double)config.TickPerFrameThreshold)
		{
			num = 1.0 + (distance - (double)config.TickPerFrameThreshold) / (double)config.TickFramePeriod;
			num *= num;
		}
		double num2 = 1.0;
		if (radio > config.TickPerFrameThresholdRadio)
		{
			num2 = 1.0 + (radio - config.TickPerFrameThresholdRadio) / config.TickFramePeriodRatio;
			num2 *= num2;
		}
		return (int)Math.Min(num * num2, (double)config.MaxInterval);
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00032CE7 File Offset: 0x00030EE7
	public static double GetCharacterTickInterval(double distance, double radio)
	{
		return (double)TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.characterConfig);
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00032CF6 File Offset: 0x00030EF6
	public static double GetCommonNpcTickInterval(double distance, double radio)
	{
		return (double)TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.commonNpcConfig);
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00032D05 File Offset: 0x00030F05
	public static int GetSimpleNpcTickInterval(double distance, double radio)
	{
		return TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.simpleNpcConfig);
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00032D13 File Offset: 0x00030F13
	public static int GetSceneItemTickInterval(double distance, double radio)
	{
		return TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.sceneItemConfig);
	}

	// Token: 0x04000691 RID: 1681
	private const int MAX_INTERVAL = 60;

	// Token: 0x04000692 RID: 1682
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig characterConfig = new TickIntervalConfig(5000, 5000, 1.3089969158172607, 0.1745329201221466, 60);

	// Token: 0x04000693 RID: 1683
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig commonNpcConfig = new TickIntervalConfig(5000, 5000, 1.3089969158172607, 0.1745329201221466, 60);

	// Token: 0x04000694 RID: 1684
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig simpleNpcConfig = new TickIntervalConfig(5000, 3500, 1.3089969158172607, 0.1745329201221466, 60);

	// Token: 0x04000695 RID: 1685
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig sceneItemConfig = new TickIntervalConfig(1500, 1000, 1.3089969158172607, 0.1745329201221466, 60);
}

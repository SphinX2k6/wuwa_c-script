using System;
using System.Runtime.CompilerServices;

// Token: 0x02000105 RID: 261
[NullableContext(1)]
[Nullable(0)]
public static class TickIntervalUtils
{
	// Token: 0x060009C9 RID: 2505 RVA: 0x000322F4 File Offset: 0x000304F4
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

	// Token: 0x060009CA RID: 2506 RVA: 0x0003238B File Offset: 0x0003058B
	public static double GetCharacterTickInterval(double distance, double radio)
	{
		return (double)TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.characterConfig);
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0003239A File Offset: 0x0003059A
	public static double GetCommonNpcTickInterval(double distance, double radio)
	{
		return (double)TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.commonNpcConfig);
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x000323A9 File Offset: 0x000305A9
	public static int GetSimpleNpcTickInterval(double distance, double radio)
	{
		return TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.simpleNpcConfig);
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x000323B7 File Offset: 0x000305B7
	public static int GetSceneItemTickInterval(double distance, double radio)
	{
		return TickIntervalUtils.GetTickInterval(distance, radio, TickIntervalUtils.sceneItemConfig);
	}

	// Token: 0x04000686 RID: 1670
	private const int MAX_INTERVAL = 60;

	// Token: 0x04000687 RID: 1671
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig characterConfig = new TickIntervalConfig(5000, 5000, 1.3089969158172607, 0.1745329201221466, 60);

	// Token: 0x04000688 RID: 1672
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig commonNpcConfig = new TickIntervalConfig(5000, 5000, 1.3089969158172607, 0.1745329201221466, 60);

	// Token: 0x04000689 RID: 1673
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig simpleNpcConfig = new TickIntervalConfig(5000, 3500, 1.3089969158172607, 0.1745329201221466, 60);

	// Token: 0x0400068A RID: 1674
	[StaticVariableRuleIgnore]
	private static readonly TickIntervalConfig sceneItemConfig = new TickIntervalConfig(1500, 1000, 1.3089969158172607, 0.1745329201221466, 60);
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001CE3 RID: 7395
[NullableContext(1)]
[Nullable(0)]
public static class MotorcycleUtil
{
	// Token: 0x0600E011 RID: 57361 RVA: 0x00347C54 File Offset: 0x00345E54
	public static string CompactNumberFormat(float num)
	{
		num = (float)Math.Floor((double)num);
		if (num >= 100000000f)
		{
			float value = (float)Math.Floor((double)(num / 1000000f));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(value);
			defaultInterpolatedStringHandler.AppendLiteral("M");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (num >= 100000f)
		{
			float value2 = (float)Math.Floor((double)(num / 1000f));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("K");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return num.ToString();
	}

	// Token: 0x0600E012 RID: 57362 RVA: 0x00347CEC File Offset: 0x00345EEC
	public static string TimeFormat(float milliseconds)
	{
		float num = milliseconds * 0.001f;
		int num2 = (int)Math.Floor((double)(num / 3600f));
		int num3 = (int)Math.Floor((double)(num % 3600f / 60f));
		int num4 = (int)Math.Floor((double)(num % 60f));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted(num2.ToString().PadLeft(2, '0'));
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(num3.ToString().PadLeft(2, '0'));
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(num4.ToString().PadLeft(2, '0'));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04006729 RID: 26409
	private const int HP_LEVEL1 = 100000;

	// Token: 0x0400672A RID: 26410
	private const int HP_LEVEL2 = 100000000;

	// Token: 0x0400672B RID: 26411
	private const int SECOND_PER_MINUTE = 60;

	// Token: 0x0400672C RID: 26412
	private const int SECOND_PER_HOUR = 3600;
}

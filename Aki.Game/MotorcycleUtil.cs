using System;
using System.Runtime.CompilerServices;

// Token: 0x020011A5 RID: 4517
[NullableContext(1)]
[Nullable(0)]
public static class MotorcycleUtil
{
	// Token: 0x0600B42E RID: 46126 RVA: 0x0035367C File Offset: 0x0035187C
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

	// Token: 0x0600B42F RID: 46127 RVA: 0x00353714 File Offset: 0x00351914
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

	// Token: 0x04006808 RID: 26632
	private const int HP_LEVEL1 = 100000;

	// Token: 0x04006809 RID: 26633
	private const int HP_LEVEL2 = 100000000;

	// Token: 0x0400680A RID: 26634
	private const int SECOND_PER_MINUTE = 60;

	// Token: 0x0400680B RID: 26635
	private const int SECOND_PER_HOUR = 3600;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001CA5 RID: 7333
[NullableContext(1)]
[Nullable(0)]
public static class RoleTowerTimeUtil
{
	// Token: 0x060123B7 RID: 74679 RVA: 0x0056071A File Offset: 0x0055E91A
	public static string Format(long ms)
	{
		if (ms <= 0L)
		{
			return "00:00:00";
		}
		return RoleTowerTimeUtil.FormatCore(ms);
	}

	// Token: 0x060123B8 RID: 74680 RVA: 0x0056072D File Offset: 0x0055E92D
	public static string FormatZero(long ms)
	{
		return RoleTowerTimeUtil.FormatCore((ms > 0L) ? ms : 0L);
	}

	// Token: 0x060123B9 RID: 74681 RVA: 0x00560740 File Offset: 0x0055E940
	private static string FormatCore(long ms)
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(ms, 0L);
		int value = (int)timeSpan.TotalMinutes;
		int value2 = timeSpan.Milliseconds / 10;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2, "D2");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060123BA RID: 74682 RVA: 0x005607C0 File Offset: 0x0055E9C0
	public static string FormatHud(long ms)
	{
		if (ms <= 0L)
		{
			return "00:00:00";
		}
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(ms, 0L);
		int value = (int)timeSpan.TotalMinutes;
		int value2 = timeSpan.Milliseconds / 10;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2, "D2");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060123BB RID: 74683 RVA: 0x0056084C File Offset: 0x0055EA4C
	public static string FormatHudZero(long ms)
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds((ms > 0L) ? ms : 0L, 0L);
		int value = (int)timeSpan.TotalMinutes;
		int value2 = timeSpan.Milliseconds / 10;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2, "D2");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060123BC RID: 74684 RVA: 0x005608D4 File Offset: 0x0055EAD4
	public static string FormatDelta(long ms)
	{
		return ((ms >= 0L) ? "+" : "-") + RoleTowerTimeUtil.FormatCore(Math.Abs(ms));
	}

	// Token: 0x060123BD RID: 74685 RVA: 0x005608F8 File Offset: 0x0055EAF8
	public static string FormatDeltaHud(long ms)
	{
		string value = (ms >= 0L) ? "+" : "-";
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(Math.Abs(ms), 0L);
		int value2 = (int)timeSpan.TotalMinutes;
		int value3 = timeSpan.Milliseconds / 10;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 4);
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(timeSpan.Seconds, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value3, "D2");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}

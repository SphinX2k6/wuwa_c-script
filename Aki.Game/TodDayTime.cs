using System;
using System.Runtime.CompilerServices;

// Token: 0x0200212D RID: 8493
[NullableContext(1)]
[Nullable(0)]
public class TodDayTime : IStaticVariableResetter
{
	// Token: 0x06014D02 RID: 85250 RVA: 0x0060C899 File Offset: 0x0060AA99
	static TodDayTime()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TodDayTime.CreateStaticDefaultValue), new Action(TodDayTime.ResetStaticDefaultValue));
	}

	// Token: 0x17001FA2 RID: 8098
	// (get) Token: 0x06014D03 RID: 85251 RVA: 0x0060C8B8 File Offset: 0x0060AAB8
	private static double Rate
	{
		get
		{
			if (TodDayTime.RateInternal == 0.0)
			{
				TodDayTime.RateInternal = TimeOfDayConfig.Instance.GetRate();
			}
			return TodDayTime.RateInternal;
		}
	}

	// Token: 0x06014D04 RID: 85252 RVA: 0x0060C8DE File Offset: 0x0060AADE
	public static void CreateStaticDefaultValue()
	{
		TodDayTime.RateInternal = 0.0;
	}

	// Token: 0x06014D05 RID: 85253 RVA: 0x0060C8EE File Offset: 0x0060AAEE
	public static void ResetStaticDefaultValue()
	{
		TodDayTime.RateInternal = 0.0;
	}

	// Token: 0x17001FA3 RID: 8099
	// (get) Token: 0x06014D06 RID: 85254 RVA: 0x0060C8FE File Offset: 0x0060AAFE
	// (set) Token: 0x06014D07 RID: 85255 RVA: 0x0060C906 File Offset: 0x0060AB06
	public double Second
	{
		get
		{
			return this.SecondInternal;
		}
		set
		{
			this.SecondInternal = TodDayTime.ConvertToOneDaySecond(value);
		}
	}

	// Token: 0x17001FA4 RID: 8100
	// (get) Token: 0x06014D08 RID: 85256 RVA: 0x0060C914 File Offset: 0x0060AB14
	public ETodDayState DayState
	{
		get
		{
			return TimeOfDayConfig.Instance.GetDayStateByGameTimeMinute(this.Minute);
		}
	}

	// Token: 0x17001FA5 RID: 8101
	// (get) Token: 0x06014D09 RID: 85257 RVA: 0x0060C926 File Offset: 0x0060AB26
	public double Hour
	{
		get
		{
			return this.Minute / 60.0;
		}
	}

	// Token: 0x17001FA6 RID: 8102
	// (get) Token: 0x06014D0A RID: 85258 RVA: 0x0060C938 File Offset: 0x0060AB38
	public double Minute
	{
		get
		{
			return this.Second / 60.0;
		}
	}

	// Token: 0x17001FA7 RID: 8103
	// (get) Token: 0x06014D0B RID: 85259 RVA: 0x0060C94A File Offset: 0x0060AB4A
	public string HourMinuteString
	{
		get
		{
			return TodDayTime.ConvertToHourMinuteString(this.Second);
		}
	}

	// Token: 0x06014D0C RID: 85260 RVA: 0x0060C958 File Offset: 0x0060AB58
	public static double ConvertFromRealTimeSecond(double realTimeSecond)
	{
		if (TodDayTime.Rate == 0.0)
		{
			Log.Instance.Error(ELogModule.TimeOfDay, ELogAuthor.TL, "获取时间流速比错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0.0;
		}
		return realTimeSecond * TodDayTime.Rate / 10000.0;
	}

	// Token: 0x06014D0D RID: 85261 RVA: 0x0060C9AC File Offset: 0x0060ABAC
	public static ETodDayState ConvertToDayState(double second)
	{
		return TimeOfDayConfig.Instance.GetDayStateByGameTimeMinute(TodDayTime.ConvertToMinute(second));
	}

	// Token: 0x06014D0E RID: 85262 RVA: 0x0060C9BE File Offset: 0x0060ABBE
	public static double ConvertToOneDaySecond(double second)
	{
		if (second < 0.0)
		{
			return 0.0;
		}
		return second % 86400.0;
	}

	// Token: 0x06014D0F RID: 85263 RVA: 0x0060C9E4 File Offset: 0x0060ABE4
	public static string ConvertToHourMinuteString(double second)
	{
		double num = Math.Floor(second / 3600.0);
		double num2 = Math.Floor((second - num * 3600.0) / 60.0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)num, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)num2, "D2");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06014D10 RID: 85264 RVA: 0x0060CA59 File Offset: 0x0060AC59
	public static double ConvertToDay(double second)
	{
		return second / 86400.0;
	}

	// Token: 0x06014D11 RID: 85265 RVA: 0x0060CA66 File Offset: 0x0060AC66
	public static double ConvertToHour(double second)
	{
		return second / 3600.0;
	}

	// Token: 0x06014D12 RID: 85266 RVA: 0x0060CA73 File Offset: 0x0060AC73
	public static double ConvertToMinute(double second)
	{
		return second / 60.0;
	}

	// Token: 0x06014D13 RID: 85267 RVA: 0x0060CA80 File Offset: 0x0060AC80
	public static double ConvertFromMinute(double minute)
	{
		return minute * 60.0;
	}

	// Token: 0x06014D14 RID: 85268 RVA: 0x0060CA8D File Offset: 0x0060AC8D
	public static double ConvertFromHourMinute(double hour, double minute)
	{
		return hour * 3600.0 + minute * 60.0;
	}

	// Token: 0x06014D15 RID: 85269 RVA: 0x0060CAA8 File Offset: 0x0060ACA8
	public static bool CheckInMinuteSpan(double minute, TTodTimeSpan minuteSpan)
	{
		if (minute < 0.0 || minute > 1440.0)
		{
			return false;
		}
		int startTime = minuteSpan.StartTime;
		int endTime = minuteSpan.EndTime;
		if (startTime < endTime)
		{
			if (minute >= (double)startTime && minute < (double)endTime)
			{
				return true;
			}
		}
		else if (minute >= (double)startTime || minute < (double)endTime)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0400B185 RID: 45445
	private double SecondInternal;

	// Token: 0x0400B186 RID: 45446
	private static double RateInternal;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002BB1 RID: 11185
[NullableContext(1)]
[Nullable(0)]
public class TodDayTime : IStaticVariableResetter
{
	// Token: 0x060172D1 RID: 94929 RVA: 0x005DFCC5 File Offset: 0x005DDEC5
	static TodDayTime()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TodDayTime.CreateStaticDefaultValue), new Action(TodDayTime.ResetStaticDefaultValue));
	}

	// Token: 0x17001F4A RID: 8010
	// (get) Token: 0x060172D2 RID: 94930 RVA: 0x005DFCE4 File Offset: 0x005DDEE4
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

	// Token: 0x060172D3 RID: 94931 RVA: 0x005DFD0A File Offset: 0x005DDF0A
	public static void CreateStaticDefaultValue()
	{
		TodDayTime.RateInternal = 0.0;
	}

	// Token: 0x060172D4 RID: 94932 RVA: 0x005DFD1A File Offset: 0x005DDF1A
	public static void ResetStaticDefaultValue()
	{
		TodDayTime.RateInternal = 0.0;
	}

	// Token: 0x17001F4B RID: 8011
	// (get) Token: 0x060172D5 RID: 94933 RVA: 0x005DFD2A File Offset: 0x005DDF2A
	// (set) Token: 0x060172D6 RID: 94934 RVA: 0x005DFD32 File Offset: 0x005DDF32
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

	// Token: 0x17001F4C RID: 8012
	// (get) Token: 0x060172D7 RID: 94935 RVA: 0x005DFD40 File Offset: 0x005DDF40
	public ETodDayState DayState
	{
		get
		{
			return TimeOfDayConfig.Instance.GetDayStateByGameTimeMinute(this.Minute);
		}
	}

	// Token: 0x17001F4D RID: 8013
	// (get) Token: 0x060172D8 RID: 94936 RVA: 0x005DFD52 File Offset: 0x005DDF52
	public double Hour
	{
		get
		{
			return this.Minute / 60.0;
		}
	}

	// Token: 0x17001F4E RID: 8014
	// (get) Token: 0x060172D9 RID: 94937 RVA: 0x005DFD64 File Offset: 0x005DDF64
	public double Minute
	{
		get
		{
			return this.Second / 60.0;
		}
	}

	// Token: 0x17001F4F RID: 8015
	// (get) Token: 0x060172DA RID: 94938 RVA: 0x005DFD76 File Offset: 0x005DDF76
	public string HourMinuteString
	{
		get
		{
			return TodDayTime.ConvertToHourMinuteString(this.Second);
		}
	}

	// Token: 0x060172DB RID: 94939 RVA: 0x005DFD84 File Offset: 0x005DDF84
	public static double ConvertFromRealTimeSecond(double realTimeSecond)
	{
		if (TodDayTime.Rate == 0.0)
		{
			Log.Instance.Error(ELogModule.TimeOfDay, ELogAuthor.TL, "获取时间流速比错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0.0;
		}
		return realTimeSecond * TodDayTime.Rate / 10000.0;
	}

	// Token: 0x060172DC RID: 94940 RVA: 0x005DFDD8 File Offset: 0x005DDFD8
	public static ETodDayState ConvertToDayState(double second)
	{
		return TimeOfDayConfig.Instance.GetDayStateByGameTimeMinute(TodDayTime.ConvertToMinute(second));
	}

	// Token: 0x060172DD RID: 94941 RVA: 0x005DFDEA File Offset: 0x005DDFEA
	public static double ConvertToOneDaySecond(double second)
	{
		if (second < 0.0)
		{
			return 0.0;
		}
		return second % 86400.0;
	}

	// Token: 0x060172DE RID: 94942 RVA: 0x005DFE10 File Offset: 0x005DE010
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

	// Token: 0x060172DF RID: 94943 RVA: 0x005DFE85 File Offset: 0x005DE085
	public static double ConvertToDay(double second)
	{
		return second / 86400.0;
	}

	// Token: 0x060172E0 RID: 94944 RVA: 0x005DFE92 File Offset: 0x005DE092
	public static double ConvertToHour(double second)
	{
		return second / 3600.0;
	}

	// Token: 0x060172E1 RID: 94945 RVA: 0x005DFE9F File Offset: 0x005DE09F
	public static double ConvertToMinute(double second)
	{
		return second / 60.0;
	}

	// Token: 0x060172E2 RID: 94946 RVA: 0x005DFEAC File Offset: 0x005DE0AC
	public static double ConvertFromMinute(double minute)
	{
		return minute * 60.0;
	}

	// Token: 0x060172E3 RID: 94947 RVA: 0x005DFEB9 File Offset: 0x005DE0B9
	public static double ConvertFromHourMinute(double hour, double minute)
	{
		return hour * 3600.0 + minute * 60.0;
	}

	// Token: 0x060172E4 RID: 94948 RVA: 0x005DFED4 File Offset: 0x005DE0D4
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

	// Token: 0x0400AD7E RID: 44414
	private double SecondInternal;

	// Token: 0x0400AD7F RID: 44415
	private static double RateInternal;
}

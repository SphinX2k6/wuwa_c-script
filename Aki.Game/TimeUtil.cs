using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

// Token: 0x02000259 RID: 601
[NullableContext(1)]
[Nullable(0)]
public class TimeUtil : Singleton, ITickable
{
	// Token: 0x060024E0 RID: 9440 RVA: 0x000E2D4C File Offset: 0x000E0F4C
	public void Init(TextConfig textConfig)
	{
		this.TextConfigInternal = textConfig;
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x000E2D55 File Offset: 0x000E0F55
	public double GetServerTimeStamp()
	{
		return Time.Instance.ServerTimeStamp;
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x000E2D61 File Offset: 0x000E0F61
	public double GetServerStopTimeStamp()
	{
		return Time.Instance.ServerFlowTimeStamp;
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x000E2D6D File Offset: 0x000E0F6D
	public double GetServerTime()
	{
		return Time.Instance.ServerTimeStamp * this.Millisecond;
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x000E2D80 File Offset: 0x000E0F80
	public void SetServerTimeStamp(double serverTimeStamp)
	{
		Time.Instance.SetServerTimeStamp(serverTimeStamp);
		this.InitNextDayTimeStamp();
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x000E2D93 File Offset: 0x000E0F93
	public void Tick(float delta)
	{
		if (this.NextDayTimeStamp > 0.0 && Time.Instance.ServerTimeStamp >= this.NextDayTimeStamp)
		{
			this.InitNextDayTimeStamp();
		}
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x000E2DC0 File Offset: 0x000E0FC0
	public void InitNextDayTimeStamp()
	{
		DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)Time.Instance.ServerTimeStamp).LocalDateTime;
		if (dateTime.Hour >= this.CrossDayHour)
		{
			dateTime = dateTime.AddDays(1.0);
		}
		DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, this.CrossDayHour, 0, 0, DateTimeKind.Local);
		this.NextDayTimeStamp = (double)new DateTimeOffset(dateTime2).ToUnixTimeMilliseconds() + new Random().NextDouble();
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x000E2E4B File Offset: 0x000E104B
	public double GetNextDayTimeStamp()
	{
		return this.NextDayTimeStamp;
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000E2E53 File Offset: 0x000E1053
	public double SetTimeMillisecond(double time)
	{
		return time * (double)this.InverseMillisecond;
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x000E2E5E File Offset: 0x000E105E
	public double SetTimeSecond(double time)
	{
		return time / (double)this.InverseMillisecond;
	}

	// Token: 0x060024EA RID: 9450 RVA: 0x000E2E69 File Offset: 0x000E1069
	public string DateFormat(DateTime date)
	{
		return date.ToString("yyyy.MM.dd-HH.mm.ss:fff");
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000E2E77 File Offset: 0x000E1077
	public string DateFormat2(DateTime date)
	{
		return date.ToString("yyyy-MM-dd HH:mm:ss");
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x000E2E85 File Offset: 0x000E1085
	public string DateFormat3(DateTime date)
	{
		return date.ToString("yyyy/MM/dd HH:mm");
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x000E2E93 File Offset: 0x000E1093
	public string DateFormat4(DateTime date)
	{
		return date.ToString("yyyy/MM/dd");
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x000E2EA4 File Offset: 0x000E10A4
	public string DateFormat4String(double timeStampSecond)
	{
		DateTime localDateTime = DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime;
		return this.DateFormat4(localDateTime);
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x000E2EC8 File Offset: 0x000E10C8
	public string DateFormat5(DateTime date)
	{
		return date.ToString("yyyy-MM-dd HH:mm:ss");
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x000E2ED8 File Offset: 0x000E10D8
	public string DateFormat6String(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds((long)timeStampSecond).LocalDateTime.ToString("MM.dd");
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x000E2F04 File Offset: 0x000E1104
	public string DateFormat7String(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds((long)timeStampSecond).LocalDateTime.ToString("HH:mm");
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x000E2F2D File Offset: 0x000E112D
	public string DateFormat8(in DateTime dateTime, string suffixStr)
	{
		return dateTime.ToString("yyyy-MM-dd HH:mm:ss") + suffixStr;
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x000E2F40 File Offset: 0x000E1140
	public string DateFormat9String(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime.ToString("yyyy.MM.dd");
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x000E2F69 File Offset: 0x000E1169
	public double GetServerUnixTime()
	{
		return (double)((long)Time.Instance.ServerTimeStamp / (long)this.InverseMillisecond);
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x000E2F80 File Offset: 0x000E1180
	public string DateFormatString(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime.ToString("yyyy/MM/dd HH:mm:ss");
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x000E2FAC File Offset: 0x000E11AC
	public string DateFormatString2(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime.ToString("yyyyMMddHHmmss");
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x000E2FD8 File Offset: 0x000E11D8
	public string GetTimeString(double second)
	{
		if (second < 0.0)
		{
			return "";
		}
		double num = second % this.Minute;
		string str = (num < 10.0) ? ("0" + num.ToString()) : num.ToString();
		double num2 = Math.Floor(second / this.Minute);
		return ((num2 < 10.0) ? ("0" + num2.ToString()) : num2.ToString()) + ":" + str;
	}

	// Token: 0x060024F8 RID: 9464 RVA: 0x000E3068 File Offset: 0x000E1268
	public DateTime GetDataFromTimeStamp(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime;
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x000E3084 File Offset: 0x000E1284
	public int CalculateMailDayGapByServerTime(double timeStampSeconds)
	{
		DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)this.GetServerTimeStamp()).LocalDateTime;
		DateTime localDateTime2 = DateTimeOffset.FromUnixTimeSeconds((long)timeStampSeconds).LocalDateTime;
		DateTime d = new DateTime(localDateTime.Year, localDateTime.Month, localDateTime.Day);
		DateTime d2 = new DateTime(localDateTime2.Year, localDateTime2.Month, localDateTime2.Day);
		return Math.Abs((int)Math.Round((d - d2).TotalDays));
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x000E3108 File Offset: 0x000E1308
	public int CalculateDayGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = Time.Instance.ServerTimeStamp / (double)this.InverseMillisecond;
		DateTime now = DateTime.Now;
		DateTime localDateTime = DateTimeOffset.FromUnixTimeSeconds((long)timeStamp).LocalDateTime;
		double num2;
		if ((num2 = (isFuture ? (timeStamp - num) : (num - timeStamp)) / 86400.0) < 2.0)
		{
			if (isFuture)
			{
				num2 = (double)((now.Month < localDateTime.Month) ? 1 : (localDateTime.Day - now.Day));
			}
			else
			{
				num2 = (double)((now.Month > localDateTime.Month) ? 1 : (now.Day - localDateTime.Day));
			}
		}
		return int.Parse(num2.ToString("0"));
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x000E31CC File Offset: 0x000E13CC
	public int CalculateDayTimeStampGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = Time.Instance.ServerTimeStamp / (double)this.InverseMillisecond;
		return (int)Math.Floor((isFuture ? (timeStamp - num) : (num - timeStamp)) / 86400.0);
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x000E3214 File Offset: 0x000E1414
	public double CalculateHourGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = this.GetServerTimeStamp() / (double)this.InverseMillisecond;
		return (isFuture ? (timeStamp - num) : (num - timeStamp)) / 3600.0;
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x000E3254 File Offset: 0x000E1454
	public double CalculateMinuteGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = Time.Instance.ServerTimeStamp / (double)this.InverseMillisecond;
		return (isFuture ? (timeStamp - num) : (num - timeStamp)) / 60.0;
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x000E3298 File Offset: 0x000E1498
	public string GetCoolDown(double leftTime)
	{
		string text = "";
		double num = Math.Floor(leftTime);
		if (num < 10.0)
		{
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num);
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			string str2 = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(num);
			text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x000E330C File Offset: 0x000E150C
	public float GetHoursFloat()
	{
		DateTime utcDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)Time.Instance.ServerTimeStamp).UtcDateTime;
		double hour = (double)utcDateTime.Hour;
		int minute = utcDateTime.Minute;
		int second = utcDateTime.Second;
		return (float)(hour + (double)minute / this.Minute + (double)second / this.Hour);
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x000E335F File Offset: 0x000E155F
	public bool IsExceededServerTime(long time)
	{
		return (double)time >= this.GetServerTime();
	}

	// Token: 0x06002501 RID: 9473 RVA: 0x000E3370 File Offset: 0x000E1570
	[NullableContext(2)]
	public CommonDefine.IRemainTime CalculateRemainingTime(double time, CommonDefine.ETimeType minTimeType = CommonDefine.ETimeType.Minute)
	{
		if (time <= 0.0)
		{
			return null;
		}
		CommonDefine.ETimeType etimeType = CommonDefine.ETimeType.Day;
		CommonDefine.RemainTime remainTime = new CommonDefine.RemainTime
		{
			TimeValue = 0,
			RemainingTime = time + this.TimeDeviation,
			TextId = CommonDefine.remainTimeTextId[minTimeType]
		};
		while (etimeType >= minTimeType)
		{
			ValueTuple<int, int>? valueTuple = this.RemainTimeFunction[etimeType](time);
			if (valueTuple != null)
			{
				remainTime.TimeValue = valueTuple.Value.Item1;
				remainTime.TextId = CommonDefine.remainTimeTextId[etimeType];
				remainTime.RemainingTime = (double)valueTuple.Value.Item2 + this.TimeDeviation;
				return remainTime;
			}
			etimeType--;
		}
		return remainTime;
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x000E3420 File Offset: 0x000E1620
	private CommonDefine.ICountDown GetCountDownInfoByType(double time, CommonDefine.ETimeTextType textType, CommonDefine.ETimeType? inStartType = null, CommonDefine.ETimeType? inEndType = null)
	{
		if (time <= 0.0)
		{
			return new CommonDefine.CountDown
			{
				CountDownText = null,
				RemainingTime = this.TimeDeviation
			};
		}
		StringBuilder stringBuilder = new StringBuilder();
		double num = time;
		CommonDefine.ETimeType etimeType = inStartType.GetValueOrDefault(CommonDefine.ETimeType.Day);
		CommonDefine.ETimeType valueOrDefault = inEndType.GetValueOrDefault(CommonDefine.ETimeType.Minute);
		Dictionary<CommonDefine.ETimeType, string> dictionary;
		if (textType != CommonDefine.ETimeTextType.TimeType1)
		{
			if (textType != CommonDefine.ETimeTextType.TimeType2)
			{
				dictionary = CommonDefine.remainTimeTextId;
			}
			else
			{
				dictionary = CommonDefine.remainTimeTextIdFormat2;
			}
		}
		else
		{
			dictionary = CommonDefine.remainTimeTextId;
		}
		while (etimeType >= valueOrDefault)
		{
			ValueTuple<int, int>? valueTuple = this.RemainTimeFunction[etimeType](num);
			string value = StringUtils.Format(this.TextConfigInternal.GetTextById(dictionary[etimeType]), new string[]
			{
				((double)((valueTuple != null) ? valueTuple.GetValueOrDefault().Item1 : 0)).ToString()
			});
			int? num2 = (valueTuple != null) ? new int?(valueTuple.GetValueOrDefault().Item2) : null;
			num = ((num2 != null) ? ((double)num2.GetValueOrDefault()) : num);
			stringBuilder.Append(value);
			etimeType--;
		}
		return new CommonDefine.CountDown
		{
			CountDownText = stringBuilder.ToString(),
			RemainingTime = num + this.TimeDeviation
		};
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x000E3565 File Offset: 0x000E1765
	public CommonDefine.ICountDown GetCountDownData(double time, CommonDefine.ETimeType? inStartType = null, CommonDefine.ETimeType? inEndType = null)
	{
		return this.GetCountDownInfoByType(time, CommonDefine.ETimeTextType.TimeType1, inStartType, inEndType);
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x000E3571 File Offset: 0x000E1771
	public CommonDefine.ICountDown GetCountDownDataFormat2(double time, CommonDefine.ETimeType? inStartType = null, CommonDefine.ETimeType? inEndType = null)
	{
		return this.GetCountDownInfoByType(time, CommonDefine.ETimeTextType.TimeType2, inStartType, inEndType);
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x000E3580 File Offset: 0x000E1780
	public CommonDefine.ICountDown GetRemainTimeDataFormat(double remainTime)
	{
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> timeTypeData = this.GetTimeTypeData(remainTime);
		if (timeTypeData.Item1 == CommonDefine.ETimeType.Second)
		{
			return new CommonDefine.CountDown
			{
				CountDownText = TextConfig.Instance.GetTextById("NotEnoughOneHour"),
				RemainingTime = remainTime
			};
		}
		return this.GetCountDownDataFormat2(remainTime, new CommonDefine.ETimeType?(timeTypeData.Item1), new CommonDefine.ETimeType?(timeTypeData.Item2));
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x000E35DC File Offset: 0x000E17DC
	[NullableContext(0)]
	public ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetTimeTypeData(double remainTime)
	{
		if (remainTime > 86400.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		if (remainTime > 3600.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Hour);
		}
		return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x000E3610 File Offset: 0x000E1810
	public CommonDefine.ICountDown GetRemainTimeDataFormat3(double remainTime)
	{
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
		if (remainTime > 86400.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		else if (remainTime > 3600.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Minute);
		}
		else if (remainTime > 60.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Second);
		}
		return this.GetCountDownInfoByType(remainTime, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x000E3684 File Offset: 0x000E1884
	public CommonDefine.ICountDown GetRemainTimeDataFormat4(double remainTime)
	{
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Minute);
		if (remainTime < 60.0)
		{
			return this.GetCountDownInfoByType(60.0, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
		}
		return this.GetCountDownInfoByType(remainTime, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
	}

	// Token: 0x06002509 RID: 9481 RVA: 0x000E36EC File Offset: 0x000E18EC
	public string GetRemainTimeDataFormat5(double cdRemainTime)
	{
		double num = Math.Min(Math.Max(0.0, cdRemainTime), this.Hour);
		double num2 = Math.Floor(num / this.Minute);
		double num3 = Math.Floor(num % this.Minute);
		double num4 = Math.Floor((num - Math.Floor(num)) * 100.0);
		string value = num2.ToString().PadLeft(2, '0');
		string value2 = num3.ToString().PadLeft(2, '0');
		string value3 = num4.ToString().PadLeft(2, '0');
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x000E37BC File Offset: 0x000E19BC
	public string GetRemainTimeDataFormat6(double cdRemainTime)
	{
		double num = Math.Max(0.0, cdRemainTime);
		double num2 = Math.Floor(num % this.Hour / this.Minute);
		double num3 = Math.Floor(num % this.Minute);
		string str = num2.ToString().PadLeft(2, '0');
		string str2 = num3.ToString().PadLeft(2, '0');
		return str + ":" + str2;
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x000E3824 File Offset: 0x000E1A24
	public bool IsInTimeSpan(double startTime, double endTime)
	{
		double serverTime = this.GetServerTime();
		return serverTime >= startTime && serverTime <= endTime;
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x000E3844 File Offset: 0x000E1A44
	public double GetCurrentCrossDayStamp()
	{
		DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)Time.Instance.ServerTimeStamp).UtcDateTime;
		if (dateTime.Hour < this.CrossDayHour)
		{
			dateTime = dateTime.AddDays(-1.0);
		}
		dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, this.CrossDayHour, 0, 0);
		return (double)(dateTime.Ticks / 10000L);
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x000E38BD File Offset: 0x000E1ABD
	public int GetCurrentCrossDayIndex()
	{
		return checked((int)(this.GetCurrentCrossDayStamp() / (double)this.InverseMillisecond / (double)this.OneDaySeconds));
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x000E38D8 File Offset: 0x000E1AD8
	public string GetTimeDataFormat(double secondTime)
	{
		new StringBuilder().Append(((int)Math.Floor(secondTime / 60.0)).ToString().PadLeft(2, '0'));
		object obj2;
		object obj = obj2;
		obj.Append(':');
		obj.Append(((int)(secondTime % 60.0)).ToString().PadLeft(2, '0'));
		return obj.ToString();
	}

	// Token: 0x0600250F RID: 9487 RVA: 0x000E3944 File Offset: 0x000E1B44
	public string GetTimeDataFormatWithHour(double secondTime)
	{
		double num = Math.Max(0.0, secondTime);
		double num2 = Math.Floor(num / this.Hour);
		double num3 = Math.Floor(num % this.Hour / this.Minute);
		double num4 = Math.Floor(num % this.Minute);
		string value = num2.ToString().PadLeft(2, '0');
		string value2 = num3.ToString().PadLeft(2, '0');
		string value3 = num4.ToString().PadLeft(2, '0');
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002510 RID: 9488 RVA: 0x000E3A04 File Offset: 0x000E1C04
	public FTimespan GetTimeZoneOffset()
	{
		FDateTime b = UKismetMathLibrary.UtcNow();
		FTimespan ftimespan = UKismetMathLibrary.Subtract_DateTimeDateTime(UKismetMathLibrary.Now(), b);
		if (UKismetMathLibrary.GetSeconds(ftimespan) < 0)
		{
			FDateTime a = UKismetMathLibrary.Now();
			b = UKismetMathLibrary.UtcNow();
			ftimespan = UKismetMathLibrary.Subtract_DateTimeDateTime(a, b);
		}
		return ftimespan;
	}

	// Token: 0x06002511 RID: 9489 RVA: 0x000E3A40 File Offset: 0x000E1C40
	public string GetTimeZoneOffsetString()
	{
		FTimespan timeZoneOffset = this.GetTimeZoneOffset();
		int hours = UKismetMathLibrary.GetHours(timeZoneOffset);
		int minutes = UKismetMathLibrary.GetMinutes(timeZoneOffset);
		string result;
		if (hours >= 0)
		{
			string text;
			if (minutes != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(hours);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<int>(minutes);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(hours);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			result = text;
		}
		else
		{
			int value = -hours;
			int value2 = -minutes;
			string text2;
			if (minutes != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			result = text2;
		}
		return result;
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x000E3B38 File Offset: 0x000E1D38
	public void LogTimeZoneOffset()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeUtil;
		ELogAuthor author = ELogAuthor.CFT;
		string message = "本地时间和UTC时间的偏移";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", this.GetTimeZoneOffsetString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x000E3B74 File Offset: 0x000E1D74
	public CommonDefine.ICountDown GetRemainTimeDataFormat7(double remainTime)
	{
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
		if (remainTime >= 86400.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Day);
		}
		else if (remainTime >= 3600.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Hour);
		}
		else if (remainTime >= 60.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Minute);
		}
		return TimeUtil.Instance.GetCountDownInfoByType(remainTime, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x000E3BF0 File Offset: 0x000E1DF0
	public CommonDefine.ICountDown GetRemainTimeDataFormat8(double remainTime)
	{
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Minute);
		if (remainTime >= 86400.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Day);
		}
		else if (remainTime >= 3600.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Hour);
		}
		return this.GetCountDownInfoByType(remainTime, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x000E3C50 File Offset: 0x000E1E50
	public CommonDefine.ICountDown GetRemainTimeDataFormat9(double remainTime)
	{
		if (remainTime < 60.0)
		{
			return new CommonDefine.CountDown
			{
				CountDownText = TextConfig.Instance.GetTextById("NotEnoughOneMinute"),
				RemainingTime = remainTime
			};
		}
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
		if (remainTime > 86400.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		else if (remainTime > 3600.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Minute);
		}
		else if (remainTime > 60.0)
		{
			valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Second);
		}
		return this.GetCountDownInfoByType(remainTime, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000E3CF4 File Offset: 0x000E1EF4
	public string GetCountDownTextFormat10(double remainTime)
	{
		if (remainTime >= 86400.0)
		{
			int num = (int)Math.Floor(remainTime / 86400.0);
			string id = CommonDefine.remainTimeTextIdFormat3[CommonDefine.ETimeType.Day];
			return StringUtils.Format(this.TextConfigInternal.GetTextById(id), new string[]
			{
				num.ToString()
			});
		}
		if (remainTime >= 3600.0)
		{
			int num2 = (int)Math.Floor(remainTime / 3600.0);
			string id2 = CommonDefine.remainTimeTextIdFormat3[CommonDefine.ETimeType.Hour];
			return StringUtils.Format(this.TextConfigInternal.GetTextById(id2), new string[]
			{
				num2.ToString()
			});
		}
		if (remainTime >= 60.0)
		{
			int num3 = (int)Math.Floor(remainTime / 60.0);
			string id3 = CommonDefine.remainTimeTextIdFormat3[CommonDefine.ETimeType.Minute];
			return StringUtils.Format(this.TextConfigInternal.GetTextById(id3), new string[]
			{
				num3.ToString()
			});
		}
		int num4 = (int)Math.Floor((remainTime < 0.0) ? 0.0 : remainTime);
		string id4 = CommonDefine.remainTimeTextIdFormat3[CommonDefine.ETimeType.Second];
		return StringUtils.Format(this.TextConfigInternal.GetTextById(id4), new string[]
		{
			num4.ToString()
		});
	}

	// Token: 0x170005B9 RID: 1465
	// (get) Token: 0x06002517 RID: 9495 RVA: 0x000E3E37 File Offset: 0x000E2037
	public static TimeUtil Instance
	{
		get
		{
			if (TimeUtil._instance == null)
			{
				TimeUtil._instance = new TimeUtil();
				TimeUtil._instance.OnInit();
			}
			return TimeUtil._instance;
		}
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000E3E5A File Offset: 0x000E205A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x000E3E5C File Offset: 0x000E205C
	public static void ResetStaticDefaultValue()
	{
		TimeUtil instance = TimeUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TimeUtil._instance = null;
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000E3E75 File Offset: 0x000E2075
	static TimeUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeUtil.CreateStaticDefaultValue), new Action(TimeUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000E3E94 File Offset: 0x000E2094
	public TimeUtil()
	{
		Dictionary<CommonDefine.ETimeType, Func<double, ValueTuple<int, int>?>> dictionary = new Dictionary<CommonDefine.ETimeType, Func<double, ValueTuple<int, int>?>>();
		dictionary[CommonDefine.ETimeType.Second] = delegate(double remainTime)
		{
			if (remainTime > 0.0)
			{
				int num = (int)Math.Floor(remainTime);
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(num, num));
			}
			return null;
		};
		dictionary[CommonDefine.ETimeType.Minute] = delegate(double remainTime)
		{
			if (remainTime >= 60.0)
			{
				double num = remainTime % 60.0;
				return new ValueTuple<int, int>?(new ValueTuple<int, int>((int)((remainTime - num) / 60.0), (int)num));
			}
			return null;
		};
		dictionary[CommonDefine.ETimeType.Hour] = delegate(double remainTime)
		{
			if (remainTime >= 3600.0)
			{
				double num = remainTime % 3600.0;
				return new ValueTuple<int, int>?(new ValueTuple<int, int>((int)((remainTime - num) / 3600.0), (int)num));
			}
			return null;
		};
		dictionary[CommonDefine.ETimeType.Day] = delegate(double remainTime)
		{
			if (remainTime >= 86400.0)
			{
				double num = remainTime % 86400.0;
				return new ValueTuple<int, int>?(new ValueTuple<int, int>((int)((remainTime - num) / 86400.0), (int)num));
			}
			return null;
		};
		this.RemainTimeFunction = dictionary;
		base..ctor();
	}

	// Token: 0x04002446 RID: 9286
	public readonly double OneDayHourCount = 24.0;

	// Token: 0x04002447 RID: 9287
	public readonly double Hour = 3600.0;

	// Token: 0x04002448 RID: 9288
	public readonly double Minute = 60.0;

	// Token: 0x04002449 RID: 9289
	public readonly int OneDaySeconds = 86400;

	// Token: 0x0400244A RID: 9290
	public readonly double Millisecond = 0.001;

	// Token: 0x0400244B RID: 9291
	public readonly int InverseMillisecond = 1000;

	// Token: 0x0400244C RID: 9292
	public readonly int CrossDayHour = 4;

	// Token: 0x0400244D RID: 9293
	private double NextDayTimeStamp;

	// Token: 0x0400244E RID: 9294
	public readonly double TimeDeviation = 0.1;

	// Token: 0x0400244F RID: 9295
	[Nullable(2)]
	private TextConfig TextConfigInternal;

	// Token: 0x04002450 RID: 9296
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	private readonly Dictionary<CommonDefine.ETimeType, Func<double, ValueTuple<int, int>?>> RemainTimeFunction;

	// Token: 0x04002451 RID: 9297
	[Nullable(2)]
	private static TimeUtil _instance;
}

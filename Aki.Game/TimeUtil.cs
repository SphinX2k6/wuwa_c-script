using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

// Token: 0x02000255 RID: 597
[NullableContext(1)]
[Nullable(0)]
public class TimeUtil : Singleton, ITickable
{
	// Token: 0x06002429 RID: 9257 RVA: 0x000DC998 File Offset: 0x000DAB98
	public void Init(TextConfig textConfig)
	{
		this.TextConfigInternal = textConfig;
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000DC9A1 File Offset: 0x000DABA1
	public double GetServerTimeStamp()
	{
		return Time.Instance.ServerTimeStamp;
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x000DC9AD File Offset: 0x000DABAD
	public double GetServerStopTimeStamp()
	{
		return Time.Instance.ServerFlowTimeStamp;
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x000DC9B9 File Offset: 0x000DABB9
	public double GetServerTime()
	{
		return Time.Instance.ServerTimeStamp * this.Millisecond;
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x000DC9CC File Offset: 0x000DABCC
	public void SetServerTimeStamp(double serverTimeStamp)
	{
		Time.Instance.SetServerTimeStamp(serverTimeStamp);
		this.InitNextDayTimeStamp();
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x000DC9DF File Offset: 0x000DABDF
	public void Tick(float delta)
	{
		if (this.NextDayTimeStamp > 0.0 && Time.Instance.ServerTimeStamp >= this.NextDayTimeStamp)
		{
			this.InitNextDayTimeStamp();
		}
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x000DCA0C File Offset: 0x000DAC0C
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

	// Token: 0x06002430 RID: 9264 RVA: 0x000DCA97 File Offset: 0x000DAC97
	public double GetNextDayTimeStamp()
	{
		return this.NextDayTimeStamp;
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x000DCA9F File Offset: 0x000DAC9F
	public double SetTimeMillisecond(double time)
	{
		return time * (double)this.InverseMillisecond;
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x000DCAAA File Offset: 0x000DACAA
	public double SetTimeSecond(double time)
	{
		return time / (double)this.InverseMillisecond;
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x000DCAB5 File Offset: 0x000DACB5
	public string DateFormat(DateTime date)
	{
		return date.ToString("yyyy.MM.dd-HH.mm.ss:fff");
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000DCAC3 File Offset: 0x000DACC3
	public string DateFormat2(DateTime date)
	{
		return date.ToString("yyyy-MM-dd HH:mm:ss");
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x000DCAD1 File Offset: 0x000DACD1
	public string DateFormat3(DateTime date)
	{
		return date.ToString("yyyy/MM/dd HH:mm");
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x000DCADF File Offset: 0x000DACDF
	public string DateFormat4(DateTime date)
	{
		return date.ToString("yyyy/MM/dd");
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x000DCAF0 File Offset: 0x000DACF0
	public string DateFormat4String(double timeStampSecond)
	{
		DateTime localDateTime = DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime;
		return this.DateFormat4(localDateTime);
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x000DCB14 File Offset: 0x000DAD14
	public string DateFormat5(DateTime date)
	{
		return date.ToString("yyyy-MM-dd HH:mm:ss");
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x000DCB24 File Offset: 0x000DAD24
	public string DateFormat6String(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds((long)timeStampSecond).LocalDateTime.ToString("MM.dd");
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x000DCB50 File Offset: 0x000DAD50
	public string DateFormat7String(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds((long)timeStampSecond).LocalDateTime.ToString("HH:mm");
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x000DCB79 File Offset: 0x000DAD79
	public string DateFormat8(in DateTime dateTime, string suffixStr)
	{
		return dateTime.ToString("yyyy-MM-dd HH:mm:ss") + suffixStr;
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x000DCB8C File Offset: 0x000DAD8C
	public string DateFormat9String(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime.ToString("yyyy.MM.dd");
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x000DCBB5 File Offset: 0x000DADB5
	public double GetServerUnixTime()
	{
		return (double)((long)Time.Instance.ServerTimeStamp / (long)this.InverseMillisecond);
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x000DCBCC File Offset: 0x000DADCC
	public string DateFormatString(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime.ToString("yyyy/MM/dd HH:mm:ss");
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x000DCBF8 File Offset: 0x000DADF8
	public string DateFormatString2(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime.ToString("yyyyMMddHHmmss");
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000DCC24 File Offset: 0x000DAE24
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

	// Token: 0x06002441 RID: 9281 RVA: 0x000DCCB4 File Offset: 0x000DAEB4
	public DateTime GetDataFromTimeStamp(double timeStampSecond)
	{
		return DateTimeOffset.FromUnixTimeSeconds((long)timeStampSecond).LocalDateTime;
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x000DCCD0 File Offset: 0x000DAED0
	public int CalculateMailDayGapByServerTime(double timeStampSeconds)
	{
		DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)this.GetServerTimeStamp()).LocalDateTime;
		DateTime localDateTime2 = DateTimeOffset.FromUnixTimeSeconds((long)timeStampSeconds).LocalDateTime;
		DateTime d = new DateTime(localDateTime.Year, localDateTime.Month, localDateTime.Day);
		DateTime d2 = new DateTime(localDateTime2.Year, localDateTime2.Month, localDateTime2.Day);
		return Math.Abs((int)Math.Round((d - d2).TotalDays));
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x000DCD54 File Offset: 0x000DAF54
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

	// Token: 0x06002444 RID: 9284 RVA: 0x000DCE18 File Offset: 0x000DB018
	public int CalculateDayTimeStampGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = Time.Instance.ServerTimeStamp / (double)this.InverseMillisecond;
		return (int)Math.Floor((isFuture ? (timeStamp - num) : (num - timeStamp)) / 86400.0);
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x000DCE60 File Offset: 0x000DB060
	public double CalculateHourGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = this.GetServerTimeStamp() / (double)this.InverseMillisecond;
		return (isFuture ? (timeStamp - num) : (num - timeStamp)) / 3600.0;
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x000DCEA0 File Offset: 0x000DB0A0
	public double CalculateMinuteGapBetweenNow(double timeStamp, bool isFuture)
	{
		double num = Time.Instance.ServerTimeStamp / (double)this.InverseMillisecond;
		return (isFuture ? (timeStamp - num) : (num - timeStamp)) / 60.0;
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000DCEE4 File Offset: 0x000DB0E4
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

	// Token: 0x06002448 RID: 9288 RVA: 0x000DCF58 File Offset: 0x000DB158
	public float GetHoursFloat()
	{
		DateTime utcDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)Time.Instance.ServerTimeStamp).UtcDateTime;
		double hour = (double)utcDateTime.Hour;
		int minute = utcDateTime.Minute;
		int second = utcDateTime.Second;
		return (float)(hour + (double)minute / this.Minute + (double)second / this.Hour);
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x000DCFAB File Offset: 0x000DB1AB
	public bool IsExceededServerTime(long time)
	{
		return (double)time >= this.GetServerTime();
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000DCFBC File Offset: 0x000DB1BC
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

	// Token: 0x0600244B RID: 9291 RVA: 0x000DD06C File Offset: 0x000DB26C
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

	// Token: 0x0600244C RID: 9292 RVA: 0x000DD1B1 File Offset: 0x000DB3B1
	public CommonDefine.ICountDown GetCountDownData(double time, CommonDefine.ETimeType? inStartType = null, CommonDefine.ETimeType? inEndType = null)
	{
		return this.GetCountDownInfoByType(time, CommonDefine.ETimeTextType.TimeType1, inStartType, inEndType);
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000DD1BD File Offset: 0x000DB3BD
	public CommonDefine.ICountDown GetCountDownDataFormat2(double time, CommonDefine.ETimeType? inStartType = null, CommonDefine.ETimeType? inEndType = null)
	{
		return this.GetCountDownInfoByType(time, CommonDefine.ETimeTextType.TimeType2, inStartType, inEndType);
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x000DD1CC File Offset: 0x000DB3CC
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

	// Token: 0x0600244F RID: 9295 RVA: 0x000DD228 File Offset: 0x000DB428
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

	// Token: 0x06002450 RID: 9296 RVA: 0x000DD25C File Offset: 0x000DB45C
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

	// Token: 0x06002451 RID: 9297 RVA: 0x000DD2D0 File Offset: 0x000DB4D0
	public CommonDefine.ICountDown GetRemainTimeDataFormat4(double remainTime)
	{
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> valueTuple = new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Minute);
		if (remainTime < 60.0)
		{
			return this.GetCountDownInfoByType(60.0, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
		}
		return this.GetCountDownInfoByType(remainTime, CommonDefine.ETimeTextType.TimeType2, new CommonDefine.ETimeType?(valueTuple.Item1), new CommonDefine.ETimeType?(valueTuple.Item2));
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x000DD338 File Offset: 0x000DB538
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

	// Token: 0x06002453 RID: 9299 RVA: 0x000DD408 File Offset: 0x000DB608
	public string GetRemainTimeDataFormat6(double cdRemainTime)
	{
		double num = Math.Max(0.0, cdRemainTime);
		double num2 = Math.Floor(num % this.Hour / this.Minute);
		double num3 = Math.Floor(num % this.Minute);
		string str = num2.ToString().PadLeft(2, '0');
		string str2 = num3.ToString().PadLeft(2, '0');
		return str + ":" + str2;
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x000DD470 File Offset: 0x000DB670
	public bool IsInTimeSpan(double startTime, double endTime)
	{
		double serverTime = this.GetServerTime();
		return serverTime >= startTime && serverTime <= endTime;
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000DD490 File Offset: 0x000DB690
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

	// Token: 0x06002456 RID: 9302 RVA: 0x000DD509 File Offset: 0x000DB709
	public int GetCurrentCrossDayIndex()
	{
		return checked((int)(this.GetCurrentCrossDayStamp() / (double)this.InverseMillisecond / (double)this.OneDaySeconds));
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x000DD524 File Offset: 0x000DB724
	public string GetTimeDataFormat(double secondTime)
	{
		new StringBuilder().Append(((int)Math.Floor(secondTime / 60.0)).ToString().PadLeft(2, '0'));
		object obj2;
		object obj = obj2;
		obj.Append(':');
		obj.Append(((int)(secondTime % 60.0)).ToString().PadLeft(2, '0'));
		return obj.ToString();
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x000DD590 File Offset: 0x000DB790
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

	// Token: 0x06002459 RID: 9305 RVA: 0x000DD650 File Offset: 0x000DB850
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

	// Token: 0x0600245A RID: 9306 RVA: 0x000DD68C File Offset: 0x000DB88C
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

	// Token: 0x0600245B RID: 9307 RVA: 0x000DD784 File Offset: 0x000DB984
	public void LogTimeZoneOffset()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeUtil;
		ELogAuthor author = ELogAuthor.CFT;
		string message = "本地时间和UTC时间的偏移";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", this.GetTimeZoneOffsetString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600245C RID: 9308 RVA: 0x000DD7C0 File Offset: 0x000DB9C0
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

	// Token: 0x0600245D RID: 9309 RVA: 0x000DD83C File Offset: 0x000DBA3C
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

	// Token: 0x0600245E RID: 9310 RVA: 0x000DD89C File Offset: 0x000DBA9C
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

	// Token: 0x0600245F RID: 9311 RVA: 0x000DD940 File Offset: 0x000DBB40
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

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x06002460 RID: 9312 RVA: 0x000DDA83 File Offset: 0x000DBC83
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

	// Token: 0x06002461 RID: 9313 RVA: 0x000DDAA6 File Offset: 0x000DBCA6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002462 RID: 9314 RVA: 0x000DDAA8 File Offset: 0x000DBCA8
	public static void ResetStaticDefaultValue()
	{
		TimeUtil instance = TimeUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TimeUtil._instance = null;
	}

	// Token: 0x06002463 RID: 9315 RVA: 0x000DDAC1 File Offset: 0x000DBCC1
	static TimeUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeUtil.CreateStaticDefaultValue), new Action(TimeUtil.ResetStaticDefaultValue));
	}

	// Token: 0x06002464 RID: 9316 RVA: 0x000DDAE0 File Offset: 0x000DBCE0
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

	// Token: 0x040023C8 RID: 9160
	public readonly double OneDayHourCount = 24.0;

	// Token: 0x040023C9 RID: 9161
	public readonly double Hour = 3600.0;

	// Token: 0x040023CA RID: 9162
	public readonly double Minute = 60.0;

	// Token: 0x040023CB RID: 9163
	public readonly int OneDaySeconds = 86400;

	// Token: 0x040023CC RID: 9164
	public readonly double Millisecond = 0.001;

	// Token: 0x040023CD RID: 9165
	public readonly int InverseMillisecond = 1000;

	// Token: 0x040023CE RID: 9166
	public readonly int CrossDayHour = 4;

	// Token: 0x040023CF RID: 9167
	private double NextDayTimeStamp;

	// Token: 0x040023D0 RID: 9168
	public readonly double TimeDeviation = 0.1;

	// Token: 0x040023D1 RID: 9169
	[Nullable(2)]
	private TextConfig TextConfigInternal;

	// Token: 0x040023D2 RID: 9170
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	private readonly Dictionary<CommonDefine.ETimeType, Func<double, ValueTuple<int, int>?>> RemainTimeFunction;

	// Token: 0x040023D3 RID: 9171
	[Nullable(2)]
	private static TimeUtil _instance;
}

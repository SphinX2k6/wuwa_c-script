using System;
using System.Collections;
using System.Globalization;

namespace System
{
	// Token: 0x020000EB RID: 235
	[Obsolete("System.CurrentSystemTimeZone has been deprecated. Investigate the use of System.TimeZoneInfo.Local instead.")]
	internal sealed class CurrentSystemTimeZone : TimeZone
	{
		// Token: 0x06000D97 RID: 3479 RVA: 0x00024D08 File Offset: 0x00022F08
		internal CurrentSystemTimeZone()
		{
			TimeZoneInfo local = TimeZoneInfo.Local;
			this.m_ticksOffset = local.BaseUtcOffset.Ticks;
			this.m_standardName = local.StandardName;
			this.m_daylightName = local.DaylightName;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00024D58 File Offset: 0x00022F58
		public override string StandardName
		{
			get
			{
				return this.m_standardName;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00024D60 File Offset: 0x00022F60
		public override string DaylightName
		{
			get
			{
				return this.m_daylightName;
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00024D68 File Offset: 0x00022F68
		internal long GetUtcOffsetFromUniversalTime(DateTime time, ref bool isAmbiguousLocalDst)
		{
			TimeSpan timeSpan = new TimeSpan(this.m_ticksOffset);
			DaylightTime daylightChanges = this.GetDaylightChanges(time.Year);
			isAmbiguousLocalDst = false;
			if (daylightChanges == null || daylightChanges.Delta.Ticks == 0L)
			{
				return timeSpan.Ticks;
			}
			DateTime dateTime = daylightChanges.Start - timeSpan;
			DateTime dateTime2 = daylightChanges.End - timeSpan - daylightChanges.Delta;
			DateTime t;
			DateTime t2;
			if (daylightChanges.Delta.Ticks > 0L)
			{
				t = dateTime2 - daylightChanges.Delta;
				t2 = dateTime2;
			}
			else
			{
				t = dateTime;
				t2 = dateTime - daylightChanges.Delta;
			}
			bool flag;
			if (dateTime > dateTime2)
			{
				flag = (time < dateTime2 || time >= dateTime);
			}
			else
			{
				flag = (time >= dateTime && time < dateTime2);
			}
			if (flag)
			{
				timeSpan += daylightChanges.Delta;
				if (time >= t && time < t2)
				{
					isAmbiguousLocalDst = true;
				}
			}
			return timeSpan.Ticks;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00024E70 File Offset: 0x00023070
		public override DateTime ToLocalTime(DateTime time)
		{
			if (time.Kind == DateTimeKind.Local)
			{
				return time;
			}
			bool isAmbiguousDst = false;
			long utcOffsetFromUniversalTime = this.GetUtcOffsetFromUniversalTime(time, ref isAmbiguousDst);
			long num = time.Ticks + utcOffsetFromUniversalTime;
			if (num > 3155378975999999999L)
			{
				return new DateTime(3155378975999999999L, DateTimeKind.Local);
			}
			if (num < 0L)
			{
				return new DateTime(0L, DateTimeKind.Local);
			}
			return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00024ED1 File Offset: 0x000230D1
		public override DaylightTime GetDaylightChanges(int year)
		{
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", SR.Format(SR.ArgumentOutOfRange_Range, 1, 9999));
			}
			return this.GetCachedDaylightChanges(year);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00024F0C File Offset: 0x0002310C
		private static DaylightTime CreateDaylightChanges(int year)
		{
			DateTime start = DateTime.MinValue;
			DateTime end = DateTime.MinValue;
			TimeSpan delta = TimeSpan.Zero;
			if (TimeZoneInfo.Local.SupportsDaylightSavingTime)
			{
				foreach (TimeZoneInfo.AdjustmentRule adjustmentRule in TimeZoneInfo.Local.GetAdjustmentRules())
				{
					if (adjustmentRule.DateStart.Year <= year && adjustmentRule.DateEnd.Year >= year && adjustmentRule.DaylightDelta != TimeSpan.Zero)
					{
						start = TimeZoneInfo.TransitionTimeToDateTime(year, adjustmentRule.DaylightTransitionStart);
						end = TimeZoneInfo.TransitionTimeToDateTime(year, adjustmentRule.DaylightTransitionEnd);
						delta = adjustmentRule.DaylightDelta;
						break;
					}
				}
			}
			return new DaylightTime(start, end, delta);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00024FC4 File Offset: 0x000231C4
		public override TimeSpan GetUtcOffset(DateTime time)
		{
			if (time.Kind == DateTimeKind.Utc)
			{
				return TimeSpan.Zero;
			}
			return new TimeSpan(TimeZone.CalculateUtcOffset(time, this.GetDaylightChanges(time.Year)).Ticks + this.m_ticksOffset);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00025008 File Offset: 0x00023208
		private DaylightTime GetCachedDaylightChanges(int year)
		{
			object key = year;
			if (!this.m_CachedDaylightChanges.Contains(key))
			{
				DaylightTime value = CurrentSystemTimeZone.CreateDaylightChanges(year);
				Hashtable cachedDaylightChanges = this.m_CachedDaylightChanges;
				lock (cachedDaylightChanges)
				{
					if (!this.m_CachedDaylightChanges.Contains(key))
					{
						this.m_CachedDaylightChanges.Add(key, value);
					}
				}
			}
			return (DaylightTime)this.m_CachedDaylightChanges[key];
		}

		// Token: 0x04000311 RID: 785
		private readonly long m_ticksOffset;

		// Token: 0x04000312 RID: 786
		private readonly string m_standardName;

		// Token: 0x04000313 RID: 787
		private readonly string m_daylightName;

		// Token: 0x04000314 RID: 788
		private readonly Hashtable m_CachedDaylightChanges = new Hashtable();
	}
}

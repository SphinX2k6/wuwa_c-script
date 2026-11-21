using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x020001C9 RID: 457
	[NullableContext(1)]
	[Nullable(0)]
	[Obsolete("System.TimeZone has been deprecated. Investigate the use of System.TimeZoneInfo instead.")]
	public abstract class TimeZone
	{
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x00068DFC File Offset: 0x00066FFC
		private static object InternalSyncObject
		{
			get
			{
				if (TimeZone.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref TimeZone.s_InternalSyncObject, value, null);
				}
				return TimeZone.s_InternalSyncObject;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00068E28 File Offset: 0x00067028
		public static TimeZone CurrentTimeZone
		{
			get
			{
				TimeZone timeZone = TimeZone.currentTimeZone;
				if (timeZone == null)
				{
					object internalSyncObject = TimeZone.InternalSyncObject;
					lock (internalSyncObject)
					{
						if (TimeZone.currentTimeZone == null)
						{
							TimeZone.currentTimeZone = new CurrentSystemTimeZone();
						}
						timeZone = TimeZone.currentTimeZone;
					}
				}
				return timeZone;
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00068E8C File Offset: 0x0006708C
		internal static void ResetTimeZone()
		{
			if (TimeZone.currentTimeZone != null)
			{
				object internalSyncObject = TimeZone.InternalSyncObject;
				lock (internalSyncObject)
				{
					TimeZone.currentTimeZone = null;
				}
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060022E3 RID: 8931
		public abstract string StandardName { get; }

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060022E4 RID: 8932
		public abstract string DaylightName { get; }

		// Token: 0x060022E5 RID: 8933
		public abstract TimeSpan GetUtcOffset(DateTime time);

		// Token: 0x060022E6 RID: 8934 RVA: 0x00068ED8 File Offset: 0x000670D8
		public virtual DateTime ToUniversalTime(DateTime time)
		{
			if (time.Kind == DateTimeKind.Utc)
			{
				return time;
			}
			long num = time.Ticks - this.GetUtcOffset(time).Ticks;
			if (num > 3155378975999999999L)
			{
				return new DateTime(3155378975999999999L, DateTimeKind.Utc);
			}
			if (num < 0L)
			{
				return new DateTime(0L, DateTimeKind.Utc);
			}
			return new DateTime(num, DateTimeKind.Utc);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00068F3C File Offset: 0x0006713C
		public virtual DateTime ToLocalTime(DateTime time)
		{
			if (time.Kind == DateTimeKind.Local)
			{
				return time;
			}
			bool isAmbiguousDst = false;
			long utcOffsetFromUniversalTime = ((CurrentSystemTimeZone)TimeZone.CurrentTimeZone).GetUtcOffsetFromUniversalTime(time, ref isAmbiguousDst);
			return new DateTime(time.Ticks + utcOffsetFromUniversalTime, DateTimeKind.Local, isAmbiguousDst);
		}

		// Token: 0x060022E8 RID: 8936
		public abstract DaylightTime GetDaylightChanges(int year);

		// Token: 0x060022E9 RID: 8937 RVA: 0x00068F7A File Offset: 0x0006717A
		public virtual bool IsDaylightSavingTime(DateTime time)
		{
			return TimeZone.IsDaylightSavingTime(time, this.GetDaylightChanges(time.Year));
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00068F8F File Offset: 0x0006718F
		public static bool IsDaylightSavingTime(DateTime time, DaylightTime daylightTimes)
		{
			return TimeZone.CalculateUtcOffset(time, daylightTimes) != TimeSpan.Zero;
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00068FA4 File Offset: 0x000671A4
		internal static TimeSpan CalculateUtcOffset(DateTime time, DaylightTime daylightTimes)
		{
			if (daylightTimes == null)
			{
				return TimeSpan.Zero;
			}
			if (time.Kind == DateTimeKind.Utc)
			{
				return TimeSpan.Zero;
			}
			DateTime dateTime = daylightTimes.Start + daylightTimes.Delta;
			DateTime end = daylightTimes.End;
			DateTime t;
			DateTime t2;
			if (daylightTimes.Delta.Ticks > 0L)
			{
				t = end - daylightTimes.Delta;
				t2 = end;
			}
			else
			{
				t = dateTime;
				t2 = dateTime - daylightTimes.Delta;
			}
			bool flag = false;
			if (dateTime > end)
			{
				if (time >= dateTime || time < end)
				{
					flag = true;
				}
			}
			else if (time >= dateTime && time < end)
			{
				flag = true;
			}
			if (flag && time >= t && time < t2)
			{
				flag = time.IsAmbiguousDaylightSavingTime();
			}
			if (flag)
			{
				return daylightTimes.Delta;
			}
			return TimeSpan.Zero;
		}

		// Token: 0x04000665 RID: 1637
		private static volatile TimeZone currentTimeZone;

		// Token: 0x04000666 RID: 1638
		private static object s_InternalSyncObject;
	}
}

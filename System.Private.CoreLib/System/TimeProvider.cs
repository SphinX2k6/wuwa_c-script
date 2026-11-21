using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System
{
	// Token: 0x020001FE RID: 510
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TimeProvider
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x0007D528 File Offset: 0x0007B728
		public static TimeProvider System { get; } = new TimeProvider.SystemTimeProvider();

		// Token: 0x06002888 RID: 10376 RVA: 0x0007D52F File Offset: 0x0007B72F
		public virtual DateTimeOffset GetUtcNow()
		{
			return DateTimeOffset.UtcNow;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0007D538 File Offset: 0x0007B738
		public DateTimeOffset GetLocalNow()
		{
			DateTimeOffset utcNow = this.GetUtcNow();
			TimeZoneInfo localTimeZone = this.LocalTimeZone;
			if (localTimeZone == null)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_TimeProviderNullLocalTimeZone);
			}
			TimeSpan utcOffset = localTimeZone.GetUtcOffset(utcNow);
			if (utcOffset.Ticks == 0L)
			{
				return utcNow;
			}
			long num = utcNow.Ticks + utcOffset.Ticks;
			if (num > TimeProvider.s_maxDateTicks)
			{
				num = ((num < TimeProvider.s_minDateTicks) ? TimeProvider.s_minDateTicks : TimeProvider.s_maxDateTicks);
			}
			return new DateTimeOffset(num, utcOffset);
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x0007D5A2 File Offset: 0x0007B7A2
		public virtual TimeZoneInfo LocalTimeZone
		{
			get
			{
				return TimeZoneInfo.Local;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x0007D5A9 File Offset: 0x0007B7A9
		public virtual long TimestampFrequency
		{
			get
			{
				return Stopwatch.Frequency;
			}
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0007D5B0 File Offset: 0x0007B7B0
		public virtual long GetTimestamp()
		{
			return Stopwatch.GetTimestamp();
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0007D5B8 File Offset: 0x0007B7B8
		public TimeSpan GetElapsedTime(long startingTimestamp, long endingTimestamp)
		{
			long timestampFrequency = this.TimestampFrequency;
			if (timestampFrequency <= 0L)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_TimeProviderInvalidTimestampFrequency);
			}
			return new TimeSpan((long)((double)(endingTimestamp - startingTimestamp) * (10000000.0 / (double)timestampFrequency)));
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0007D5EF File Offset: 0x0007B7EF
		public TimeSpan GetElapsedTime(long startingTimestamp)
		{
			return this.GetElapsedTime(startingTimestamp, this.GetTimestamp());
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0007D5FE File Offset: 0x0007B7FE
		public virtual ITimer CreateTimer(TimerCallback callback, [Nullable(2)] object state, TimeSpan dueTime, TimeSpan period)
		{
			ArgumentNullException.ThrowIfNull(callback, "callback");
			return new TimeProvider.SystemTimeProviderTimer(dueTime, period, callback, state);
		}

		// Token: 0x0400071E RID: 1822
		private static readonly long s_minDateTicks = DateTime.MinValue.Ticks;

		// Token: 0x0400071F RID: 1823
		private static readonly long s_maxDateTicks = DateTime.MaxValue.Ticks;

		// Token: 0x020001FF RID: 511
		private sealed class SystemTimeProviderTimer : ITimer, IDisposable, IAsyncDisposable
		{
			// Token: 0x06002891 RID: 10385 RVA: 0x0007D63F File Offset: 0x0007B83F
			public SystemTimeProviderTimer(TimeSpan dueTime, TimeSpan period, TimerCallback callback, object state)
			{
				this._timer = new TimerQueueTimer(callback, state, dueTime, period, true);
			}

			// Token: 0x06002892 RID: 10386 RVA: 0x0007D658 File Offset: 0x0007B858
			public bool Change(TimeSpan dueTime, TimeSpan period)
			{
				bool result;
				try
				{
					result = this._timer.Change(dueTime, period);
				}
				catch (ObjectDisposedException)
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06002893 RID: 10387 RVA: 0x0007D68C File Offset: 0x0007B88C
			public void Dispose()
			{
				this._timer.Dispose();
			}

			// Token: 0x06002894 RID: 10388 RVA: 0x0007D699 File Offset: 0x0007B899
			public ValueTask DisposeAsync()
			{
				return this._timer.DisposeAsync();
			}

			// Token: 0x04000720 RID: 1824
			private readonly TimerQueueTimer _timer;
		}

		// Token: 0x02000200 RID: 512
		private sealed class SystemTimeProvider : TimeProvider
		{
			// Token: 0x06002895 RID: 10389 RVA: 0x0007D6A6 File Offset: 0x0007B8A6
			internal SystemTimeProvider()
			{
			}
		}
	}
}

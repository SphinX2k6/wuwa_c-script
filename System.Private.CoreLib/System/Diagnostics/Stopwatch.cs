using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x02000890 RID: 2192
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public class Stopwatch
	{
		// Token: 0x0600897A RID: 35194 RVA: 0x0014E10A File Offset: 0x0014C30A
		public Stopwatch()
		{
			this.Reset();
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x0014E118 File Offset: 0x0014C318
		public void Start()
		{
			if (!this._isRunning)
			{
				this._startTimeStamp = Stopwatch.GetTimestamp();
				this._isRunning = true;
			}
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x0014E134 File Offset: 0x0014C334
		public static Stopwatch StartNew()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			return stopwatch;
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x0014E144 File Offset: 0x0014C344
		public void Stop()
		{
			if (this._isRunning)
			{
				long num = Stopwatch.GetTimestamp() - this._startTimeStamp;
				this._elapsed += num;
				this._isRunning = false;
				if (this._elapsed < 0L)
				{
					this._elapsed = 0L;
				}
			}
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x0014E18D File Offset: 0x0014C38D
		public void Reset()
		{
			this._elapsed = 0L;
			this._isRunning = false;
			this._startTimeStamp = 0L;
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x0014E1A6 File Offset: 0x0014C3A6
		public void Restart()
		{
			this._elapsed = 0L;
			this._startTimeStamp = Stopwatch.GetTimestamp();
			this._isRunning = true;
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x0014E1C4 File Offset: 0x0014C3C4
		public override string ToString()
		{
			return this.Elapsed.ToString();
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06008981 RID: 35201 RVA: 0x0014E1E5 File Offset: 0x0014C3E5
		public bool IsRunning
		{
			get
			{
				return this._isRunning;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06008982 RID: 35202 RVA: 0x0014E1ED File Offset: 0x0014C3ED
		public TimeSpan Elapsed
		{
			get
			{
				return new TimeSpan(this.GetElapsedDateTimeTicks());
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x0014E1FA File Offset: 0x0014C3FA
		public long ElapsedMilliseconds
		{
			get
			{
				return this.GetElapsedDateTimeTicks() / 10000L;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06008984 RID: 35204 RVA: 0x0014E209 File Offset: 0x0014C409
		public long ElapsedTicks
		{
			get
			{
				return this.GetRawElapsedTicks();
			}
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x0014E211 File Offset: 0x0014C411
		public static long GetTimestamp()
		{
			return Stopwatch.QueryPerformanceCounter();
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x0014E218 File Offset: 0x0014C418
		public static TimeSpan GetElapsedTime(long startingTimestamp)
		{
			return Stopwatch.GetElapsedTime(startingTimestamp, Stopwatch.GetTimestamp());
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x0014E225 File Offset: 0x0014C425
		public static TimeSpan GetElapsedTime(long startingTimestamp, long endingTimestamp)
		{
			return new TimeSpan((long)((double)(endingTimestamp - startingTimestamp) * Stopwatch.s_tickFrequency));
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0014E238 File Offset: 0x0014C438
		private long GetRawElapsedTicks()
		{
			long num = this._elapsed;
			if (this._isRunning)
			{
				long num2 = Stopwatch.GetTimestamp() - this._startTimeStamp;
				num += num2;
			}
			return num;
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x0014E266 File Offset: 0x0014C466
		private long GetElapsedDateTimeTicks()
		{
			return (long)((double)this.GetRawElapsedTicks() * Stopwatch.s_tickFrequency);
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x0600898A RID: 35210 RVA: 0x0014E278 File Offset: 0x0014C478
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
				defaultInterpolatedStringHandler.AppendFormatted<TimeSpan>(this.Elapsed);
				defaultInterpolatedStringHandler.AppendLiteral(" (IsRunning = ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(this._isRunning);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x0014E2C8 File Offset: 0x0014C4C8
		private unsafe static long QueryPerformanceFrequency()
		{
			long result;
			Interop.Kernel32.QueryPerformanceFrequency(&result);
			return result;
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x0014E2E0 File Offset: 0x0014C4E0
		private unsafe static long QueryPerformanceCounter()
		{
			long result;
			Interop.Kernel32.QueryPerformanceCounter(&result);
			return result;
		}

		// Token: 0x04001E46 RID: 7750
		private long _elapsed;

		// Token: 0x04001E47 RID: 7751
		private long _startTimeStamp;

		// Token: 0x04001E48 RID: 7752
		private bool _isRunning;

		// Token: 0x04001E49 RID: 7753
		public static readonly long Frequency = Stopwatch.QueryPerformanceFrequency();

		// Token: 0x04001E4A RID: 7754
		public static readonly bool IsHighResolution = true;

		// Token: 0x04001E4B RID: 7755
		private static readonly double s_tickFrequency = 10000000.0 / (double)Stopwatch.Frequency;
	}
}

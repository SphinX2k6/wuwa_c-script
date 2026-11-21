using System;
using System.Diagnostics;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks.Internal
{
	// Token: 0x0200000D RID: 13
	internal readonly struct ValueStopwatch
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000030F4 File Offset: 0x000012F4
		public static ValueStopwatch StartNew()
		{
			return new ValueStopwatch(Stopwatch.GetTimestamp());
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003100 File Offset: 0x00001300
		private ValueStopwatch(long startTimestamp)
		{
			this.startTimestamp = startTimestamp;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003109 File Offset: 0x00001309
		public TimeSpan Elapsed
		{
			get
			{
				return TimeSpan.FromTicks(this.ElapsedTicks);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003116 File Offset: 0x00001316
		public bool IsInvalid
		{
			get
			{
				return this.startTimestamp == 0L;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003122 File Offset: 0x00001322
		public long ElapsedTicks
		{
			get
			{
				if (this.startTimestamp == 0L)
				{
					throw new InvalidOperationException("Detected invalid initialization(use 'default'), only to create from StartNew().");
				}
				return (long)((double)(Stopwatch.GetTimestamp() - this.startTimestamp) * ValueStopwatch.TimestampToTicks);
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly double TimestampToTicks = 10000000.0 / (double)Stopwatch.Frequency;

		// Token: 0x04000035 RID: 53
		private readonly long startTimestamp;
	}
}

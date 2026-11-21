using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x02000410 RID: 1040
	[NullableContext(1)]
	[Nullable(0)]
	public struct SpinWait
	{
		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x000DA8FF File Offset: 0x000D8AFF
		// (set) Token: 0x06004171 RID: 16753 RVA: 0x000DA907 File Offset: 0x000D8B07
		public int Count
		{
			get
			{
				return this._count;
			}
			internal set
			{
				this._count = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x000DA910 File Offset: 0x000D8B10
		public bool NextSpinWillYield
		{
			get
			{
				return this._count >= 10 || Environment.IsSingleProcessor;
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x000DA923 File Offset: 0x000D8B23
		public void SpinOnce()
		{
			this.SpinOnceCore(20);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x000DA92D File Offset: 0x000D8B2D
		public void SpinOnce(int sleep1Threshold)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(sleep1Threshold, -1, "sleep1Threshold");
			if (sleep1Threshold >= 0 && sleep1Threshold < 10)
			{
				sleep1Threshold = 10;
			}
			this.SpinOnceCore(sleep1Threshold);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x000DA950 File Offset: 0x000D8B50
		private void SpinOnceCore(int sleep1Threshold)
		{
			if ((this._count >= 10 && ((this._count >= sleep1Threshold && sleep1Threshold >= 0) || (this._count - 10) % 2 == 0)) || Environment.IsSingleProcessor)
			{
				if (this._count >= sleep1Threshold && sleep1Threshold >= 0)
				{
					Thread.Sleep(1);
				}
				else if (((this._count >= 10) ? ((this._count - 10) / 2) : this._count) % 5 == 4)
				{
					Thread.Sleep(0);
				}
				else
				{
					Thread.Yield();
				}
			}
			else
			{
				int num = 7;
				if (this._count <= 30 && 1 << this._count < num)
				{
					num = 1 << this._count;
				}
				Thread.SpinWait(num);
			}
			this._count = ((this._count == int.MaxValue) ? 10 : (this._count + 1));
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x000DAA1A File Offset: 0x000D8C1A
		public void Reset()
		{
			this._count = 0;
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x000DAA23 File Offset: 0x000D8C23
		public static void SpinUntil(Func<bool> condition)
		{
			SpinWait.SpinUntil(condition, -1);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x000DAA30 File Offset: 0x000D8C30
		public static bool SpinUntil(Func<bool> condition, TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SR.SpinWait_SpinUntil_TimeoutWrong);
			}
			return SpinWait.SpinUntil(condition, (int)num);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x000DAA74 File Offset: 0x000D8C74
		public static bool SpinUntil(Func<bool> condition, int millisecondsTimeout)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, SR.SpinWait_SpinUntil_TimeoutWrong);
			}
			ArgumentNullException.ThrowIfNull(condition, "condition");
			uint num = 0U;
			if (millisecondsTimeout != 0 && millisecondsTimeout != -1)
			{
				num = TimeoutHelper.GetTime();
			}
			SpinWait spinWait = default(SpinWait);
			while (!condition())
			{
				if (millisecondsTimeout == 0)
				{
					return false;
				}
				spinWait.SpinOnce();
				if (millisecondsTimeout != -1 && spinWait.NextSpinWillYield && (long)millisecondsTimeout <= (long)((ulong)(TimeoutHelper.GetTime() - num)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000DE1 RID: 3553
		internal static readonly int SpinCountforSpinBeforeWait = Environment.IsSingleProcessor ? 1 : 35;

		// Token: 0x04000DE2 RID: 3554
		private int _count;
	}
}

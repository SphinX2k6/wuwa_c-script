using System;

namespace System.Threading
{
	// Token: 0x020003F7 RID: 1015
	internal struct LowLevelSpinWaiter
	{
		// Token: 0x06004095 RID: 16533 RVA: 0x000D76E8 File Offset: 0x000D58E8
		public bool SpinWaitForCondition(Func<object, bool> condition, object state, int spinCount, int sleep0Threshold)
		{
			int processorCount = Environment.ProcessorCount;
			int num = Interlocked.Increment(ref this._spinningThreadCount);
			try
			{
				if (num <= processorCount)
				{
					for (int i = (processorCount > 1) ? 0 : sleep0Threshold; i < spinCount; i++)
					{
						LowLevelSpinWaiter.Wait(i, sleep0Threshold, processorCount == 1);
						if (condition(state))
						{
							return true;
						}
					}
				}
			}
			finally
			{
				Interlocked.Decrement(ref this._spinningThreadCount);
			}
			return false;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x000D775C File Offset: 0x000D595C
		public static void Wait(int spinIndex, int sleep0Threshold, bool isSingleProcessor)
		{
			if (!isSingleProcessor && (spinIndex < sleep0Threshold || (spinIndex - sleep0Threshold) % 2 != 0))
			{
				int num = 7;
				if (spinIndex <= 30 && 1 << spinIndex < num)
				{
					num = 1 << spinIndex;
				}
				Thread.SpinWait(num);
				return;
			}
			Thread.UninterruptibleSleep0();
		}

		// Token: 0x04000D87 RID: 3463
		private int _spinningThreadCount;
	}
}

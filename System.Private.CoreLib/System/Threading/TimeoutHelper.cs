using System;

namespace System.Threading
{
	// Token: 0x02000440 RID: 1088
	internal static class TimeoutHelper
	{
		// Token: 0x06004267 RID: 16999 RVA: 0x000DD824 File Offset: 0x000DBA24
		public static uint GetTime()
		{
			return (uint)Environment.TickCount;
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x000DD82C File Offset: 0x000DBA2C
		public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			uint num = TimeoutHelper.GetTime() - startTime;
			if (num > 2147483647U)
			{
				return 0;
			}
			int num2 = originalWaitMillisecondsTimeout - (int)num;
			if (num2 <= 0)
			{
				return 0;
			}
			return num2;
		}
	}
}

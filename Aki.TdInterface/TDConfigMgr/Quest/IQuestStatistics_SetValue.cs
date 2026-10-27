using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010BE RID: 4286
	public class IQuestStatistics_SetValue
	{
		// Token: 0x04003A44 RID: 14916
		[Nullable(1)]
		public List<IQuestStatisticsType> StatisticsConfig;

		// Token: 0x04003A45 RID: 14917
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonCalculateVar> CalculationOnTriggeringStatistics;
	}
}

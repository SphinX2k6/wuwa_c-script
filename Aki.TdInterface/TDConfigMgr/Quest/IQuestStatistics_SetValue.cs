using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011EC RID: 4588
	public class IQuestStatistics_SetValue
	{
		// Token: 0x04003D91 RID: 15761
		public List<IQuestStatisticsType> StatisticsConfig;

		// Token: 0x04003D92 RID: 15762
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ICommonCalculateVar> CalculationOnTriggeringStatistics;
	}
}

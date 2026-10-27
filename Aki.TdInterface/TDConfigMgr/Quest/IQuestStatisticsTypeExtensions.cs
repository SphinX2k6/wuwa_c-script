using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010C5 RID: 4293
	[NullableContext(1)]
	[Nullable(0)]
	public static class IQuestStatisticsTypeExtensions
	{
		// Token: 0x060060E2 RID: 24802 RVA: 0x000EA0D0 File Offset: 0x000E82D0
		public static IReadOnlyList<object> GetEntityConfigs(this IQuestStatisticsType p)
		{
			IQuestMonsterPoint questMonsterPoint = p as IQuestMonsterPoint;
			IReadOnlyList<object> entityConfigs;
			if (questMonsterPoint == null)
			{
				IQuestMonsterHealthScore questMonsterHealthScore = p as IQuestMonsterHealthScore;
				if (questMonsterHealthScore == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的EntityConfigs的字段失败");
				}
				entityConfigs = questMonsterHealthScore.EntityConfigs;
			}
			else
			{
				entityConfigs = questMonsterPoint.EntityConfigs;
			}
			return entityConfigs;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x000EA128 File Offset: 0x000E8328
		public static IReadOnlyList<object> GetTypeConfigs(this IQuestStatisticsType p)
		{
			IQuestMonsterPoint questMonsterPoint = p as IQuestMonsterPoint;
			IReadOnlyList<object> typeConfigs;
			if (questMonsterPoint == null)
			{
				IQuestMonsterHealthScore questMonsterHealthScore = p as IQuestMonsterHealthScore;
				if (questMonsterHealthScore == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的TypeConfigs的字段失败");
				}
				typeConfigs = questMonsterHealthScore.TypeConfigs;
			}
			else
			{
				typeConfigs = questMonsterPoint.TypeConfigs;
			}
			return typeConfigs;
		}
	}
}

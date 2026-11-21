using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011F3 RID: 4595
	public static class IQuestStatisticsTypeExtensions
	{
		// Token: 0x060066DB RID: 26331 RVA: 0x000F71F0 File Offset: 0x000F53F0
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

		// Token: 0x060066DC RID: 26332 RVA: 0x000F7248 File Offset: 0x000F5448
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

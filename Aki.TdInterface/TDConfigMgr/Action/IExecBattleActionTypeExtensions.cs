using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB1 RID: 7089
	public static class IExecBattleActionTypeExtensions
	{
		// Token: 0x0600969D RID: 38557 RVA: 0x0015E7A4 File Offset: 0x0015C9A4
		public static IReadOnlyList<object> GetConfigs(this IExecBattleActionType p)
		{
			ISetBattleTags setBattleTags = p as ISetBattleTags;
			IReadOnlyList<object> configs;
			if (setBattleTags == null)
			{
				ISendBattleEvents sendBattleEvents = p as ISendBattleEvents;
				if (sendBattleEvents == null)
				{
					ISendBattleEventsForMonsterSummon sendBattleEventsForMonsterSummon = p as ISendBattleEventsForMonsterSummon;
					if (sendBattleEventsForMonsterSummon == null)
					{
						throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Configs的字段失败");
					}
					configs = sendBattleEventsForMonsterSummon.Configs;
				}
				else
				{
					configs = sendBattleEvents.Configs;
				}
			}
			else
			{
				configs = setBattleTags.Configs;
			}
			return configs;
		}
	}
}

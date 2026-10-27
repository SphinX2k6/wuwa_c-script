using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1C RID: 6684
	public static class IExecBattleActionTypeExtensions
	{
		// Token: 0x06008F33 RID: 36659 RVA: 0x0014E878 File Offset: 0x0014CA78
		[NullableContext(1)]
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

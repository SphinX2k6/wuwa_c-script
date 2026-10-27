using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200106F RID: 4207
	public static class IQuestConditionExtensions
	{
		// Token: 0x06005E9E RID: 24222 RVA: 0x000E4ED0 File Offset: 0x000E30D0
		[NullableContext(1)]
		public static IReadOnlyList<object> GetConditions(this IQuestCondition p)
		{
			ICheckEntityStateQuestCondition checkEntityStateQuestCondition = p as ICheckEntityStateQuestCondition;
			IReadOnlyList<object> conditions;
			if (checkEntityStateQuestCondition == null)
			{
				IDetectCombatState2Condition detectCombatState2Condition = p as IDetectCombatState2Condition;
				if (detectCombatState2Condition == null)
				{
					ICompareVarConditionInChildQuest compareVarConditionInChildQuest = p as ICompareVarConditionInChildQuest;
					if (compareVarConditionInChildQuest == null)
					{
						ICompareActorVar compareActorVar = p as ICompareActorVar;
						if (compareActorVar == null)
						{
							throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Conditions的字段失败");
						}
						conditions = compareActorVar.Conditions;
					}
					else
					{
						conditions = compareVarConditionInChildQuest.Conditions;
					}
				}
				else
				{
					conditions = detectCombatState2Condition.Conditions;
				}
			}
			else
			{
				conditions = checkEntityStateQuestCondition.Conditions;
			}
			return conditions;
		}
	}
}

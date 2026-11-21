using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200119D RID: 4509
	public static class IQuestConditionExtensions
	{
		// Token: 0x06006492 RID: 25746 RVA: 0x000F1F28 File Offset: 0x000F0128
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

		// Token: 0x06006493 RID: 25747 RVA: 0x000F1FAC File Offset: 0x000F01AC
		public static IReadOnlyList<ISpecificMonsterDeadPosition> GetSpecificMonsterDeadPositions(this IQuestCondition p)
		{
			IKillChildQuestCondition killChildQuestCondition = p as IKillChildQuestCondition;
			List<ISpecificMonsterDeadPosition> specificMonsterDeadPositions;
			if (killChildQuestCondition == null)
			{
				IMonsterCreatorQuestCondition monsterCreatorQuestCondition = p as IMonsterCreatorQuestCondition;
				if (monsterCreatorQuestCondition == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的SpecificMonsterDeadPositions的字段失败");
				}
				specificMonsterDeadPositions = monsterCreatorQuestCondition.SpecificMonsterDeadPositions;
			}
			else
			{
				specificMonsterDeadPositions = killChildQuestCondition.SpecificMonsterDeadPositions;
			}
			return specificMonsterDeadPositions;
		}
	}
}

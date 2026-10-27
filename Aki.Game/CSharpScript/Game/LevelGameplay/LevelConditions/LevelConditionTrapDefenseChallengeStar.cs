using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D8E RID: 28046
	public class LevelConditionTrapDefenseChallengeStar : LevelConditionBase
	{
		// Token: 0x060447D8 RID: 280536 RVA: 0x010E446C File Offset: 0x010E266C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int key;
			int.TryParse(inConditionInfo.GetLimitParams("ChallengeId"), out key);
			TrapDefenseLevelData trapDefenseLevelData;
			if (!TrapDefenseModel.Instance.LevelDataFromIdMap.TryGetValue(key, out trapDefenseLevelData))
			{
				return false;
			}
			int needNum = inConditionInfo.NeedNum;
			return trapDefenseLevelData.ReachTargetIndexList.Count >= needNum;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F0D RID: 24333
	public class LevelConditionTrapDefenseChallengeStar : LevelConditionBase
	{
		// Token: 0x0603A93C RID: 239932 RVA: 0x0108E694 File Offset: 0x0108C894
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

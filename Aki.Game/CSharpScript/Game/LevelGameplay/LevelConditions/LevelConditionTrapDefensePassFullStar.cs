using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D9C RID: 28060
	public class LevelConditionTrapDefensePassFullStar : LevelConditionBase
	{
		// Token: 0x060447F4 RID: 280564 RVA: 0x010E48C4 File Offset: 0x010E2AC4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int key;
			int.TryParse(inConditionInfo.GetLimitParams("ChallengeId"), out key);
			TrapDefenseLevelData trapDefenseLevelData;
			return TrapDefenseModel.Instance.LevelDataFromIdMap.TryGetValue(key, out trapDefenseLevelData) && trapDefenseLevelData.IsFullStarPassed();
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F1B RID: 24347
	public class LevelConditionTrapDefensePassFullStar : LevelConditionBase
	{
		// Token: 0x0603A958 RID: 239960 RVA: 0x0108EAEC File Offset: 0x0108CCEC
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

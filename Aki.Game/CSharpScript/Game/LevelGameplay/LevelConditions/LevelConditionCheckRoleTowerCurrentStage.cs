using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E62 RID: 24162
	public class LevelConditionCheckRoleTowerCurrentStage : LevelConditionBase
	{
		// Token: 0x0603A7C6 RID: 239558 RVA: 0x01088E6C File Offset: 0x0108706C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			int num2;
			if (!int.TryParse(inConditionInfo.GetLimitParams("LevelId"), out num) || num <= 0 || !int.TryParse(inConditionInfo.GetLimitParams("Stage"), out num2) || num2 <= 0)
			{
				return false;
			}
			RoleTowerModel instance = RoleTowerModel.Instance;
			return instance.IsInRoleTowerDungeon() && instance.GetCurrentStageSeq(num) == num2;
		}
	}
}

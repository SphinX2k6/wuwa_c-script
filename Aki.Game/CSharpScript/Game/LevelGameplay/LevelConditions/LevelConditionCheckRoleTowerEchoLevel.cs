using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E63 RID: 24163
	public class LevelConditionCheckRoleTowerEchoLevel : LevelConditionBase
	{
		// Token: 0x0603A7C8 RID: 239560 RVA: 0x01088ED0 File Offset: 0x010870D0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			int num2;
			if (!int.TryParse(inConditionInfo.GetLimitParams("LevelId"), out num) || num <= 0 || !int.TryParse(inConditionInfo.GetLimitParams("EchoLevelIndex"), out num2) || num2 <= 0)
			{
				return false;
			}
			RoleTowerModel instance = RoleTowerModel.Instance;
			int num3;
			return instance.IsInRoleTowerDungeon() && instance.TryGetCurrentEchoLevel(num, out num3) && num3 >= num2;
		}
	}
}

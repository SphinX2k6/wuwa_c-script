using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE1 RID: 24289
	public class LevelConditionOnRollBlockDifficultyChanged : LevelConditionBase
	{
		// Token: 0x0603A8CE RID: 239822 RVA: 0x0108CB30 File Offset: 0x0108AD30
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Difficulty");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && (int)eventArgs[0] == num;
		}
	}
}

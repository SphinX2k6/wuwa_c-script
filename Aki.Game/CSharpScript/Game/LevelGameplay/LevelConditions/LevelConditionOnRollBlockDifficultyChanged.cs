using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D63 RID: 28003
	public class LevelConditionOnRollBlockDifficultyChanged : LevelConditionBase
	{
		// Token: 0x0604476C RID: 280428 RVA: 0x010E2978 File Offset: 0x010E0B78
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Difficulty");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && (int)eventArgs[0] == num;
		}
	}
}

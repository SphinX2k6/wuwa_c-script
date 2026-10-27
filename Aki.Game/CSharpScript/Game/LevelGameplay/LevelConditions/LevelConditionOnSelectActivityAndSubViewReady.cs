using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D65 RID: 28005
	public class LevelConditionOnSelectActivityAndSubViewReady : LevelConditionBase
	{
		// Token: 0x06044770 RID: 280432 RVA: 0x010E2A40 File Offset: 0x010E0C40
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			return inConditionInfo.LimitParamsLength != 0 && int.TryParse(inConditionInfo.GetLimitParams("ActivityId"), out num) && num != 0 && (int)eventArgs[0] == num;
		}
	}
}

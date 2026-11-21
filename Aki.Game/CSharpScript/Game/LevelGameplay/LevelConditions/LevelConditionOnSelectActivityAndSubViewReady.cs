using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE3 RID: 24291
	public class LevelConditionOnSelectActivityAndSubViewReady : LevelConditionBase
	{
		// Token: 0x0603A8D2 RID: 239826 RVA: 0x0108CBF8 File Offset: 0x0108ADF8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			return inConditionInfo.LimitParamsLength != 0 && int.TryParse(inConditionInfo.GetLimitParams("ActivityId"), out num) && num != 0 && (int)eventArgs[0] == num;
		}
	}
}

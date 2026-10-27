using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D02 RID: 27906
	public class LevelConditionCheckWeeklyChallenge : LevelConditionBase
	{
		// Token: 0x060446A7 RID: 280231 RVA: 0x010DFFE3 File Offset: 0x010DE1E3
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return FunctionModel.Instance.IsOpen(EFunctionType.WeeklyChallenge) && WeeklyChallengeModel.Instance.WeeklyConfigId != 0;
		}
	}
}

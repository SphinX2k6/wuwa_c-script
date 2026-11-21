using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E7F RID: 24191
	public class LevelConditionCheckWeeklyChallenge : LevelConditionBase
	{
		// Token: 0x0603A807 RID: 239623 RVA: 0x0108A16F File Offset: 0x0108836F
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return FunctionModel.Instance.IsOpen(EFunctionType.WeeklyChallenge) && WeeklyChallengeModel.Instance.WeeklyConfigId != 0;
		}
	}
}

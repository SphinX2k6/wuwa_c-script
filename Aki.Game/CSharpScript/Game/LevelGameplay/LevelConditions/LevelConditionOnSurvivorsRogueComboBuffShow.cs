using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F04 RID: 24324
	public class LevelConditionOnSurvivorsRogueComboBuffShow : LevelConditionBase
	{
		// Token: 0x0603A92A RID: 239914 RVA: 0x0108E257 File Offset: 0x0108C457
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

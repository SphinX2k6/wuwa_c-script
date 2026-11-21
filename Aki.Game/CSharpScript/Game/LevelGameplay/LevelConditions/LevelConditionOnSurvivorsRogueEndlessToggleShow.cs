using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F03 RID: 24323
	public class LevelConditionOnSurvivorsRogueEndlessToggleShow : LevelConditionBase
	{
		// Token: 0x0603A928 RID: 239912 RVA: 0x0108E245 File Offset: 0x0108C445
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

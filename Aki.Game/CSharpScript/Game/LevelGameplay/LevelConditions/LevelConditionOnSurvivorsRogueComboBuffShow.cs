using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D85 RID: 28037
	public class LevelConditionOnSurvivorsRogueComboBuffShow : LevelConditionBase
	{
		// Token: 0x060447C6 RID: 280518 RVA: 0x010E402F File Offset: 0x010E222F
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

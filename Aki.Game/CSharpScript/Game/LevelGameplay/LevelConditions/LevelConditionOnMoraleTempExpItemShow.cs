using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D47 RID: 27975
	public class LevelConditionOnMoraleTempExpItemShow : LevelConditionBase
	{
		// Token: 0x06044734 RID: 280372 RVA: 0x010E2228 File Offset: 0x010E0428
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

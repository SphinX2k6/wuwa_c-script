using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC4 RID: 24260
	public class LevelConditionOnMoraleTempExpItemShow : LevelConditionBase
	{
		// Token: 0x0603A894 RID: 239764 RVA: 0x0108C3B4 File Offset: 0x0108A5B4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D6A RID: 28010
	public class LevelConditionOnTreasureCompassUnitShow : LevelConditionBase
	{
		// Token: 0x0604477A RID: 280442 RVA: 0x010E2B9A File Offset: 0x010E0D9A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length == 1 && eventArgs[0] is bool && (bool)eventArgs[0];
		}
	}
}

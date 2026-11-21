using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE9 RID: 24297
	public class LevelConditionOnTreasureCompassUnitShow : LevelConditionBase
	{
		// Token: 0x0603A8DE RID: 239838 RVA: 0x0108CD7D File Offset: 0x0108AF7D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length == 1 && eventArgs[0] is bool && (bool)eventArgs[0];
		}
	}
}

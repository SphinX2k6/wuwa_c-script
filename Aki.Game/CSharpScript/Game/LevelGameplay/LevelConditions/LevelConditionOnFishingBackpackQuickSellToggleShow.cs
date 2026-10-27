using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D59 RID: 27993
	public class LevelConditionOnFishingBackpackQuickSellToggleShow : LevelConditionBase
	{
		// Token: 0x06044758 RID: 280408 RVA: 0x010E26A5 File Offset: 0x010E08A5
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length == 1 && eventArgs[0] is bool && (bool)eventArgs[0];
		}
	}
}

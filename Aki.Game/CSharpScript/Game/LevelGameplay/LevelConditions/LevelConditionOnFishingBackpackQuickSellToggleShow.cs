using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED7 RID: 24279
	public class LevelConditionOnFishingBackpackQuickSellToggleShow : LevelConditionBase
	{
		// Token: 0x0603A8BA RID: 239802 RVA: 0x0108C85D File Offset: 0x0108AA5D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length == 1 && eventArgs[0] is bool && (bool)eventArgs[0];
		}
	}
}

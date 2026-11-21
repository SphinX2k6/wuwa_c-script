using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E0B RID: 24075
	public class LevelConditionCheckFishingDockyardItemTipsShown : LevelConditionBase
	{
		// Token: 0x0603A70C RID: 239372 RVA: 0x010853E2 File Offset: 0x010835E2
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

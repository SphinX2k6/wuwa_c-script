using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D18 RID: 27928
	public class LevelConditionOnDangoMonopolyMoveStop : LevelConditionBase
	{
		// Token: 0x060446D4 RID: 280276 RVA: 0x010E0A6C File Offset: 0x010DEC6C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !(bool)eventArgs[0];
		}
	}
}

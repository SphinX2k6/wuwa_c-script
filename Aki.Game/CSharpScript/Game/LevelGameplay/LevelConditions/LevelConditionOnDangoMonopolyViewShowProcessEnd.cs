using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D1A RID: 27930
	public class LevelConditionOnDangoMonopolyViewShowProcessEnd : LevelConditionBase
	{
		// Token: 0x060446D8 RID: 280280 RVA: 0x010E0A8C File Offset: 0x010DEC8C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !(bool)eventArgs[0];
		}
	}
}

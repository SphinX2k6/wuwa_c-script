using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E95 RID: 24213
	public class LevelConditionOnDangoMonopolyMoveStop : LevelConditionBase
	{
		// Token: 0x0603A834 RID: 239668 RVA: 0x0108ABF8 File Offset: 0x01088DF8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !(bool)eventArgs[0];
		}
	}
}

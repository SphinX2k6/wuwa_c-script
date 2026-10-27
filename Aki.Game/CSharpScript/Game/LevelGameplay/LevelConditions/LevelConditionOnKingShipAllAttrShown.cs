using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D44 RID: 27972
	public class LevelConditionOnKingShipAllAttrShown : LevelConditionBase
	{
		// Token: 0x0604472E RID: 280366 RVA: 0x010E210F File Offset: 0x010E030F
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

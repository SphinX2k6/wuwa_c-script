using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC1 RID: 24257
	public class LevelConditionOnKingShipAllAttrShown : LevelConditionBase
	{
		// Token: 0x0603A88E RID: 239758 RVA: 0x0108C29B File Offset: 0x0108A49B
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D54 RID: 27988
	public class LevelConditionOnCostInsufficient : LevelConditionBase
	{
		// Token: 0x0604474E RID: 280398 RVA: 0x010E258E File Offset: 0x010E078E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

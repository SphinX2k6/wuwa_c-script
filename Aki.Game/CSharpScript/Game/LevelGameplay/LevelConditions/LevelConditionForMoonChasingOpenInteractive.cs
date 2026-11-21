using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EAB RID: 24235
	public class LevelConditionForMoonChasingOpenInteractive : LevelConditionBase
	{
		// Token: 0x0603A860 RID: 239712 RVA: 0x0108B238 File Offset: 0x01089438
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D6E RID: 28014
	public class LevelConditionOnCardDetailShowWithFactor : LevelConditionBase
	{
		// Token: 0x06044782 RID: 280450 RVA: 0x010E2C6A File Offset: 0x010E0E6A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

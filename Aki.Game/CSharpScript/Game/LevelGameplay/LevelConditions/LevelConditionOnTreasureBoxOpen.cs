using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D69 RID: 28009
	public class LevelConditionOnTreasureBoxOpen : LevelConditionBase
	{
		// Token: 0x06044778 RID: 280440 RVA: 0x010E2B8F File Offset: 0x010E0D8F
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

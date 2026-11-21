using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE8 RID: 24296
	public class LevelConditionOnTreasureBoxOpen : LevelConditionBase
	{
		// Token: 0x0603A8DC RID: 239836 RVA: 0x0108CD72 File Offset: 0x0108AF72
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

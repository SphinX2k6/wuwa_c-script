using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DBE RID: 23998
	public class LevelConditionAlwaysTrue : LevelConditionBase
	{
		// Token: 0x0603A63C RID: 239164 RVA: 0x0107D9C3 File Offset: 0x0107BBC3
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

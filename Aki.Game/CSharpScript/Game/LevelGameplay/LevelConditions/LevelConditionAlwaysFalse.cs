using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DBD RID: 23997
	public class LevelConditionAlwaysFalse : LevelConditionBase
	{
		// Token: 0x0603A63A RID: 239162 RVA: 0x0107D9B8 File Offset: 0x0107BBB8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return false;
		}
	}
}

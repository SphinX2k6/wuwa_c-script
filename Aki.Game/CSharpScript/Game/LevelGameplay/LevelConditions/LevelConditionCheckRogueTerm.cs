using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E5D RID: 24157
	public class LevelConditionCheckRogueTerm : LevelConditionBase
	{
		// Token: 0x0603A7BC RID: 239548 RVA: 0x01088CDA File Offset: 0x01086EDA
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CE3 RID: 27875
	public class LevelConditionCheckRogueTerm : LevelConditionBase
	{
		// Token: 0x06044662 RID: 280162 RVA: 0x010DEBFA File Offset: 0x010DCDFA
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

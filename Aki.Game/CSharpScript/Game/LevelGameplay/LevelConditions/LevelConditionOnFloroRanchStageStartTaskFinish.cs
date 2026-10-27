using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D27 RID: 27943
	public class LevelConditionOnFloroRanchStageStartTaskFinish : LevelConditionBase
	{
		// Token: 0x060446F2 RID: 280306 RVA: 0x010E0E1A File Offset: 0x010DF01A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

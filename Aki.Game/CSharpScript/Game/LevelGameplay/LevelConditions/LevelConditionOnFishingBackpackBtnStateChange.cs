using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D58 RID: 27992
	public class LevelConditionOnFishingBackpackBtnStateChange : LevelConditionBase
	{
		// Token: 0x06044756 RID: 280406 RVA: 0x010E2681 File Offset: 0x010E0881
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length == 1 && eventArgs[0] is bool && (bool)eventArgs[0];
		}
	}
}

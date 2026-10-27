using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D4F RID: 27983
	public class LevelConditionOnMapRogueEventDetailShow : LevelConditionBase
	{
		// Token: 0x06044744 RID: 280388 RVA: 0x010E246F File Offset: 0x010E066F
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return Convert.ToBoolean(eventArgs[0]);
		}
	}
}

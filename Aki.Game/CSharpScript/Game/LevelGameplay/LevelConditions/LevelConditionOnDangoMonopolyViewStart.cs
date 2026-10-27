using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D19 RID: 27929
	public class LevelConditionOnDangoMonopolyViewStart : LevelConditionBase
	{
		// Token: 0x060446D6 RID: 280278 RVA: 0x010E0A81 File Offset: 0x010DEC81
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

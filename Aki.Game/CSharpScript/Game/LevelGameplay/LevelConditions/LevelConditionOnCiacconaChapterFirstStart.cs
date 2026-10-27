using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D05 RID: 27909
	public class LevelConditionOnCiacconaChapterFirstStart : LevelConditionBase
	{
		// Token: 0x060446AD RID: 280237 RVA: 0x010E002A File Offset: 0x010DE22A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

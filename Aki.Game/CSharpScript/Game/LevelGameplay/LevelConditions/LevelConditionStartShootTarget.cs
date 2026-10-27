using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D83 RID: 28035
	public class LevelConditionStartShootTarget : LevelConditionBase
	{
		// Token: 0x060447C2 RID: 280514 RVA: 0x010E4012 File Offset: 0x010E2212
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

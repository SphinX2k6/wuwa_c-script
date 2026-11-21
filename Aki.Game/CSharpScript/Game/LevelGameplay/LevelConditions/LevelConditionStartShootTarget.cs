using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F02 RID: 24322
	public class LevelConditionStartShootTarget : LevelConditionBase
	{
		// Token: 0x0603A926 RID: 239910 RVA: 0x0108E23A File Offset: 0x0108C43A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

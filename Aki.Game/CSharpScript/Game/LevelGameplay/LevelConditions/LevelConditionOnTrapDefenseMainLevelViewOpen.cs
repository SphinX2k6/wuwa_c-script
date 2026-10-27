using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D9B RID: 28059
	public class LevelConditionOnTrapDefenseMainLevelViewOpen : LevelConditionBase
	{
		// Token: 0x060447F2 RID: 280562 RVA: 0x010E48AF File Offset: 0x010E2AAF
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D98 RID: 28056
	public class LevelConditionOnTrapDefenseBuildingDevelopBottomLayoutShow : LevelConditionBase
	{
		// Token: 0x060447EC RID: 280556 RVA: 0x010E472E File Offset: 0x010E292E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

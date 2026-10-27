using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D37 RID: 27959
	public class LevelConditionPickupInTowerDefenceBattle : LevelConditionBase
	{
		// Token: 0x06044713 RID: 280339 RVA: 0x010E1614 File Offset: 0x010DF814
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

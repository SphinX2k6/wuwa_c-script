using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EB4 RID: 24244
	public class LevelConditionPickupInTowerDefenceBattle : LevelConditionBase
	{
		// Token: 0x0603A873 RID: 239731 RVA: 0x0108B7A0 File Offset: 0x010899A0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

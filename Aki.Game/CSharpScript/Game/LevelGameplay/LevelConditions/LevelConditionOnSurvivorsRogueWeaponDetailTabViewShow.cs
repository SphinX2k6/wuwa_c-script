using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D89 RID: 28041
	public class LevelConditionOnSurvivorsRogueWeaponDetailTabViewShow : LevelConditionBase
	{
		// Token: 0x060447CE RID: 280526 RVA: 0x010E4126 File Offset: 0x010E2326
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

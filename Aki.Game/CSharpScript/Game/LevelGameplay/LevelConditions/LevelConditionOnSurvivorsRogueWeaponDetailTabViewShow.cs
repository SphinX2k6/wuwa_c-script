using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F08 RID: 24328
	public class LevelConditionOnSurvivorsRogueWeaponDetailTabViewShow : LevelConditionBase
	{
		// Token: 0x0603A932 RID: 239922 RVA: 0x0108E34E File Offset: 0x0108C54E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}

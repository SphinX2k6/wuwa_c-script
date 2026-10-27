using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D6D RID: 28013
	public class LevelConditionOnHandCardsShow : LevelConditionBase
	{
		// Token: 0x06044780 RID: 280448 RVA: 0x010E2C58 File Offset: 0x010E0E58
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}

		// Token: 0x040239DB RID: 145883
		private const int BATTLE_CARD_NUM_LIMIT = 4;
	}
}

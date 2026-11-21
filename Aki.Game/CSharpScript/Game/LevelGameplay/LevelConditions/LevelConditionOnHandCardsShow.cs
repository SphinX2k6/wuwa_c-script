using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EEC RID: 24300
	public class LevelConditionOnHandCardsShow : LevelConditionBase
	{
		// Token: 0x0603A8E4 RID: 239844 RVA: 0x0108CE3C File Offset: 0x0108B03C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}

		// Token: 0x0401EC7D RID: 126077
		private const int BATTLE_CARD_NUM_LIMIT = 4;
	}
}

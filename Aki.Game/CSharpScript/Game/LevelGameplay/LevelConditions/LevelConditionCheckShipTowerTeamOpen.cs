using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E67 RID: 24167
	public class LevelConditionCheckShipTowerTeamOpen : LevelConditionBase
	{
		// Token: 0x0603A7D0 RID: 239568 RVA: 0x010891F5 File Offset: 0x010873F5
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

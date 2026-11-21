using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ECC RID: 24268
	public class LevelConditionOnMapRogueEventDetailShow : LevelConditionBase
	{
		// Token: 0x0603A8A4 RID: 239780 RVA: 0x0108C5FB File Offset: 0x0108A7FB
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return Convert.ToBoolean(eventArgs[0]);
		}
	}
}

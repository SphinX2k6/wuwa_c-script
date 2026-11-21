using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ECA RID: 24266
	public class LevelConditionOnMovieRogueLinkRefresh : LevelConditionBase
	{
		// Token: 0x0603A8A0 RID: 239776 RVA: 0x0108C5D4 File Offset: 0x0108A7D4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return Convert.ToBoolean(eventArgs[0]);
		}
	}
}

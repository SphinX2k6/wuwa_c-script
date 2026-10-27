using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D4D RID: 27981
	public class LevelConditionOnMovieRogueLinkRefresh : LevelConditionBase
	{
		// Token: 0x06044740 RID: 280384 RVA: 0x010E2448 File Offset: 0x010E0648
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return Convert.ToBoolean(eventArgs[0]);
		}
	}
}

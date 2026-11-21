using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ECB RID: 24267
	public class LevelConditionOnMovieRogueMapMoveEnd : LevelConditionBase
	{
		// Token: 0x0603A8A2 RID: 239778 RVA: 0x0108C5E6 File Offset: 0x0108A7E6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !Convert.ToBoolean(eventArgs[0]);
		}
	}
}

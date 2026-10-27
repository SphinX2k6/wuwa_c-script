using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D4E RID: 27982
	public class LevelConditionOnMovieRogueMapMoveEnd : LevelConditionBase
	{
		// Token: 0x06044742 RID: 280386 RVA: 0x010E245A File Offset: 0x010E065A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !Convert.ToBoolean(eventArgs[0]);
		}
	}
}

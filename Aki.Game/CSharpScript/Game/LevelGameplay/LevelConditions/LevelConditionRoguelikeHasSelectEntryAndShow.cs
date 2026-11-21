using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EF9 RID: 24313
	public class LevelConditionRoguelikeHasSelectEntryAndShow : LevelConditionBase
	{
		// Token: 0x0603A911 RID: 239889 RVA: 0x0108DC88 File Offset: 0x0108BE88
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

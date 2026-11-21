using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED8 RID: 24280
	public class LevelConditionOnFishingQteScoreReachedMaximum : LevelConditionBase
	{
		// Token: 0x0603A8BC RID: 239804 RVA: 0x0108C881 File Offset: 0x0108AA81
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}

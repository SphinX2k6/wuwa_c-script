using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PermanentRogue;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC8 RID: 24264
	public class LevelConditionOnMovieRogueInfoRefreshWithMultipleEnds : LevelConditionBase
	{
		// Token: 0x0603A89C RID: 239772 RVA: 0x0108C550 File Offset: 0x0108A750
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int instId = Convert.ToInt32(eventArgs[0]);
			return ActivityPermanentRogueModel.Instance.GetInstDungeonEndingTotalCount(instId) > 1;
		}
	}
}

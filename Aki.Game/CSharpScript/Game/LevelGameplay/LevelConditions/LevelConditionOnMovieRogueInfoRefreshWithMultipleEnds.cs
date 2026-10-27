using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PermanentRogue;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D4B RID: 27979
	public class LevelConditionOnMovieRogueInfoRefreshWithMultipleEnds : LevelConditionBase
	{
		// Token: 0x0604473C RID: 280380 RVA: 0x010E23C4 File Offset: 0x010E05C4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int instId = Convert.ToInt32(eventArgs[0]);
			return ActivityPermanentRogueModel.Instance.GetInstDungeonEndingTotalCount(instId) > 1;
		}
	}
}

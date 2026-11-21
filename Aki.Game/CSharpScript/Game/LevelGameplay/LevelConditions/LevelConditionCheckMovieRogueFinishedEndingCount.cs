using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PermanentRogue;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC9 RID: 24265
	public class LevelConditionCheckMovieRogueFinishedEndingCount : LevelConditionBase
	{
		// Token: 0x0603A89E RID: 239774 RVA: 0x0108C57C File Offset: 0x0108A77C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int newSeasonId = ActivityPermanentRogueModel.Instance.GetNewSeasonId();
			string limitParams = inConditionInfo.GetLimitParams("TargetCount");
			int num = (limitParams != null) ? int.Parse(limitParams) : 0;
			return ActivityPermanentRogueModel.Instance.GetEndingCount(newSeasonId)[0] >= num;
		}
	}
}

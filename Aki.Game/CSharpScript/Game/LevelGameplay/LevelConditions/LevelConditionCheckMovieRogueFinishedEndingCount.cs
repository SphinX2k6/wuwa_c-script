using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PermanentRogue;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D4C RID: 27980
	public class LevelConditionCheckMovieRogueFinishedEndingCount : LevelConditionBase
	{
		// Token: 0x0604473E RID: 280382 RVA: 0x010E23F0 File Offset: 0x010E05F0
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

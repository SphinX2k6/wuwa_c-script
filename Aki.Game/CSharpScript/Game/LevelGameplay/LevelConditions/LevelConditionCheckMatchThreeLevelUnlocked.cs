using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC3 RID: 27843
	public class LevelConditionCheckMatchThreeLevelUnlocked : LevelConditionBase
	{
		// Token: 0x0604461E RID: 280094 RVA: 0x010DD28C File Offset: 0x010DB48C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("LevelId");
			if (limitParams == null)
			{
				return false;
			}
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null)
			{
				return false;
			}
			int challengeId = int.Parse(limitParams);
			return matchThreeData.CheckPreChallengeComplete(challengeId) && matchThreeData.CheckChallengeIsOpen(challengeId);
		}
	}
}

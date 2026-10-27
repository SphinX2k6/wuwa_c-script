using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C6A RID: 27754
	public class LevelConditionCheckDangoBrawlLevelRound : LevelConditionBase
	{
		// Token: 0x0604455C RID: 279900 RVA: 0x010D88B4 File Offset: 0x010D6AB4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ActivityId");
			string limitParams2 = inConditionInfo.GetLimitParams("LevelId");
			string limitParams3 = inConditionInfo.GetLimitParams("RoundNum");
			if (limitParams == null || limitParams2 == null || limitParams3 == null)
			{
				return false;
			}
			ActivityDangoBrawlData activityDangoBrawlData = ActivityModel.Instance.GetActivityById(int.Parse(limitParams)) as ActivityDangoBrawlData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (activityDangoBrawlData != null) ? activityDangoBrawlData.InstBase : null;
			return dangoBrawlInstBaseNotify != null && dangoBrawlInstBaseNotify.ChallengeId == int.Parse(limitParams2) && dangoBrawlInstBaseNotify.RoundNum == int.Parse(limitParams3);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C69 RID: 27753
	public class LevelConditionCheckDangoBrawlLevelPassed : LevelConditionBase
	{
		// Token: 0x0604455A RID: 279898 RVA: 0x010D8834 File Offset: 0x010D6A34
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ActivityId");
			string limitParams2 = inConditionInfo.GetLimitParams("LevelId");
			if (limitParams == null || limitParams2 == null)
			{
				return false;
			}
			ActivityDangoBrawlData activityDangoBrawlData = ActivityModel.Instance.GetActivityById(int.Parse(limitParams)) as ActivityDangoBrawlData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (activityDangoBrawlData != null) ? activityDangoBrawlData.GetOutGameData() : null;
			if (dangoBrawlOutGameData == null)
			{
				return false;
			}
			DangoBrawlLevelData levelData = dangoBrawlOutGameData.GetLevelData(int.Parse(limitParams2));
			return levelData != null && levelData.IsPassed;
		}
	}
}

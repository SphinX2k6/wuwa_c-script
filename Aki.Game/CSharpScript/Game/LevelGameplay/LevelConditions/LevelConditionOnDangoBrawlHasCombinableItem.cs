using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D56 RID: 27990
	public class LevelConditionOnDangoBrawlHasCombinableItem : LevelConditionBase
	{
		// Token: 0x06044752 RID: 280402 RVA: 0x010E25D0 File Offset: 0x010E07D0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ActivityId");
			if (limitParams == null)
			{
				return false;
			}
			ActivityDangoBrawlData activityDangoBrawlData = ActivityModel.Instance.GetActivityById(int.Parse(limitParams)) as ActivityDangoBrawlData;
			return activityDangoBrawlData != null && DangoBrawlCombineUtil.GetCombineDataListAll(activityDangoBrawlData, new EDragSourceKind[]
			{
				EDragSourceKind.Bag,
				EDragSourceKind.Bench
			}, 0).Length != 0;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E43 RID: 24131
	public class LevelConditionCheckNewPlayerSupportV2 : LevelConditionBase
	{
		// Token: 0x0603A786 RID: 239494 RVA: 0x0108789C File Offset: 0x01085A9C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Has");
			if (limitParams == null)
			{
				return false;
			}
			bool flag = int.Parse(limitParams) == 1;
			return ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.NewPlayerSupportActivityV2).Count > 0 == flag;
		}
	}
}

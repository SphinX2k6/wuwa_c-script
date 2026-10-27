using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC9 RID: 27849
	public class LevelConditionCheckNewPlayerSupportV2 : LevelConditionBase
	{
		// Token: 0x0604462C RID: 280108 RVA: 0x010DD848 File Offset: 0x010DBA48
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

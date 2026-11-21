using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DC7 RID: 24007
	public class LevelConditionCheckActivityOpen : LevelConditionBase
	{
		// Token: 0x0603A660 RID: 239200 RVA: 0x0108040C File Offset: 0x0107E60C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
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
			int id = int.Parse(limitParams);
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(id);
			return activityById != null && !activityById.CheckIfClose();
		}
	}
}

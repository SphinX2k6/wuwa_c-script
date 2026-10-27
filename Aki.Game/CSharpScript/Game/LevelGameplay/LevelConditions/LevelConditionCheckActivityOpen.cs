using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C4D RID: 27725
	public class LevelConditionCheckActivityOpen : LevelConditionBase
	{
		// Token: 0x06044506 RID: 279814 RVA: 0x010D6474 File Offset: 0x010D4674
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

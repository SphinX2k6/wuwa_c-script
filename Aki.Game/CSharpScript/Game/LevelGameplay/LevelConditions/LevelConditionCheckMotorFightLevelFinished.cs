using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorFight;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC6 RID: 27846
	public class LevelConditionCheckMotorFightLevelFinished : LevelConditionBase
	{
		// Token: 0x06044624 RID: 280100 RVA: 0x010DD370 File Offset: 0x010DB570
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("ActivityId"));
			int num2 = int.Parse(inConditionInfo.GetLimitParams("LevelId"));
			if (num == 0 || num2 == 0)
			{
				return false;
			}
			MotorFightActivityData motorFightActivityData = ActivityModel.Instance.GetActivityById(num) as MotorFightActivityData;
			if (motorFightActivityData == null)
			{
				return false;
			}
			MotorFightLevelData levelDataById = motorFightActivityData.GetLevelDataById(num2);
			return levelDataById != null && levelDataById.IsFinished;
		}
	}
}

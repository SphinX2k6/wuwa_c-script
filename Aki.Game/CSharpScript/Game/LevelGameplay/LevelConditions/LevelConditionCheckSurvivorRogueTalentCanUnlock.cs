using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F06 RID: 24326
	public class LevelConditionCheckSurvivorRogueTalentCanUnlock : LevelConditionBase
	{
		// Token: 0x0603A92E RID: 239918 RVA: 0x0108E2C6 File Offset: 0x0108C4C6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
			return activityData != null && activityData.GetTalentTreeRed();
		}
	}
}

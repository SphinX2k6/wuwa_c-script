using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D87 RID: 28039
	public class LevelConditionCheckSurvivorRogueTalentCanUnlock : LevelConditionBase
	{
		// Token: 0x060447CA RID: 280522 RVA: 0x010E409E File Offset: 0x010E229E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
			return activityData != null && activityData.GetTalentTreeRed();
		}
	}
}

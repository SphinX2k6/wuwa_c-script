using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D24 RID: 27940
	public class LevelConditionCheckFloroRanchHasTechCanUnlock : LevelConditionBase
	{
		// Token: 0x060446EC RID: 280300 RVA: 0x010E0D9C File Offset: 0x010DEF9C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
			return activityData != null && activityData.HasAnyTechPointCanUnlock();
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA1 RID: 24225
	public class LevelConditionCheckFloroRanchHasTechCanUnlock : LevelConditionBase
	{
		// Token: 0x0603A84C RID: 239692 RVA: 0x0108AF28 File Offset: 0x01089128
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
			return activityData != null && activityData.HasAnyTechPointCanUnlock();
		}
	}
}

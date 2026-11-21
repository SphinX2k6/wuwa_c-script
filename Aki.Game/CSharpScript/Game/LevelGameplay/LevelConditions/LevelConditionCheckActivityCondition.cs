using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DC6 RID: 24006
	public class LevelConditionCheckActivityCondition : LevelConditionBase
	{
		// Token: 0x0603A65E RID: 239198 RVA: 0x010803D8 File Offset: 0x0107E5D8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int conditionId = int.Parse(inConditionInfo.GetLimitParams("ActivityConditionId"));
			return ActivityConditionCenter.Instance.CheckCondition(conditionId, null);
		}
	}
}

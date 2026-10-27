using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CA8 RID: 27816
	public class LevelConditionCheckInMatchThreeLevel : LevelConditionBase
	{
		// Token: 0x060445E2 RID: 280034 RVA: 0x010DBF38 File Offset: 0x010DA138
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("LevelId");
			if (limitParams == null)
			{
				return false;
			}
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			return context != null && context.LevelId == int.Parse(limitParams);
		}
	}
}

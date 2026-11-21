using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E20 RID: 24096
	public class LevelConditionCheckHasUnlockAffixInBossRush : LevelConditionBase
	{
		// Token: 0x0603A738 RID: 239416 RVA: 0x01085E5C File Offset: 0x0108405C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("ActivityId"));
			return num != 0 && (ActivityModel.Instance.GetActivityById(num) as BossRushData).GetUnlockedBuffIndices().Length > 1;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CA6 RID: 27814
	public class LevelConditionCheckHasUnlockAffixInBossRush : LevelConditionBase
	{
		// Token: 0x060445DE RID: 280030 RVA: 0x010DBEB0 File Offset: 0x010DA0B0
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

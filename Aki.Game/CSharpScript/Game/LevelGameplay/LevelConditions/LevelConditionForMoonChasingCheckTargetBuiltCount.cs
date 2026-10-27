using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D29 RID: 27945
	public class LevelConditionForMoonChasingCheckTargetBuiltCount : LevelConditionBase
	{
		// Token: 0x060446F6 RID: 280310 RVA: 0x010E0E6C File Offset: 0x010DF06C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("TargetBuiltCount");
			string limitParams2 = inConditionInfo.GetLimitParams("Op");
			if (limitParams == null || limitParams2 == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			return base.CheckCompareValue(limitParams2, (double)MoonChasingBuildingModel.Instance.GetBuiltBuildingCount(), (double)num);
		}
	}
}

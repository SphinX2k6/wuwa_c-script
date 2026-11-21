using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA6 RID: 24230
	public class LevelConditionForMoonChasingCheckTargetBuiltCount : LevelConditionBase
	{
		// Token: 0x0603A856 RID: 239702 RVA: 0x0108AFF8 File Offset: 0x010891F8
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

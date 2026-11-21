using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA7 RID: 24231
	public class LevelConditionForMoonChasingCheckHasCanLevelUpBuilding : LevelConditionBase
	{
		// Token: 0x0603A858 RID: 239704 RVA: 0x0108B04C File Offset: 0x0108924C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return MoonChasingBuildingModel.Instance.GetFirstCanLevelUpBuildingId() != null;
		}
	}
}

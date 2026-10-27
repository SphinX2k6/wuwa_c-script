using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D2A RID: 27946
	public class LevelConditionForMoonChasingCheckHasCanLevelUpBuilding : LevelConditionBase
	{
		// Token: 0x060446F8 RID: 280312 RVA: 0x010E0EC0 File Offset: 0x010DF0C0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return MoonChasingBuildingModel.Instance.GetFirstCanLevelUpBuildingId() != null;
		}
	}
}

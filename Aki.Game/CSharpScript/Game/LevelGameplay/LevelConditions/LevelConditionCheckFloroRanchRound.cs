using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA0 RID: 24224
	public class LevelConditionCheckFloroRanchRound : LevelConditionBase
	{
		// Token: 0x0603A84A RID: 239690 RVA: 0x0108AEE4 File Offset: 0x010890E4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Round");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && FloroRanchGamePlayModel.Instance.TotalDayCount >= num;
		}
	}
}

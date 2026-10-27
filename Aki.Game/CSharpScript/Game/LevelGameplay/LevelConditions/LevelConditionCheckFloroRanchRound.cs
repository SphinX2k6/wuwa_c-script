using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D23 RID: 27939
	public class LevelConditionCheckFloroRanchRound : LevelConditionBase
	{
		// Token: 0x060446EA RID: 280298 RVA: 0x010E0D58 File Offset: 0x010DEF58
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Round");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && FloroRanchGamePlayModel.Instance.TotalDayCount >= num;
		}
	}
}

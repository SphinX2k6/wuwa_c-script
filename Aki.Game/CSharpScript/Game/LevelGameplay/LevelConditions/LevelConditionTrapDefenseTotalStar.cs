using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D9D RID: 28061
	public class LevelConditionTrapDefenseTotalStar : LevelConditionBase
	{
		// Token: 0x060447F6 RID: 280566 RVA: 0x010E490C File Offset: 0x010E2B0C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = int.Parse(inConditionInfo.GetLimitParams("ActivityId"));
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null || instance.GetActivityId() != num)
			{
				return false;
			}
			int needNum = inConditionInfo.NeedNum;
			return TrapDefenseModel.Instance.GetAllGetStarByLevel() >= needNum;
		}
	}
}

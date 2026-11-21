using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F1C RID: 24348
	public class LevelConditionTrapDefenseTotalStar : LevelConditionBase
	{
		// Token: 0x0603A95A RID: 239962 RVA: 0x0108EB34 File Offset: 0x0108CD34
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

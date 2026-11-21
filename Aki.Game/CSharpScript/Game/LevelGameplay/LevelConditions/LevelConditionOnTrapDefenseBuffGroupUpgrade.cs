using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F14 RID: 24340
	public class LevelConditionOnTrapDefenseBuffGroupUpgrade : LevelConditionBase
	{
		// Token: 0x0603A94A RID: 239946 RVA: 0x0108E8B4 File Offset: 0x0108CAB4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			ValueTuple<bool, ETrapDefenseBdBuffQuality> valueTuple = (eventArgs[1] as TrapDefenseBdData).PreAddedBuffIsActiveNewQuality(-1);
			bool item = valueTuple.Item1;
			ETrapDefenseBdBuffQuality item2 = valueTuple.Item2;
			int num;
			return int.TryParse(inConditionInfo.GetLimitParams("TargetQuality"), out num) && num != 0 && item && item2 == (ETrapDefenseBdBuffQuality)num;
		}
	}
}

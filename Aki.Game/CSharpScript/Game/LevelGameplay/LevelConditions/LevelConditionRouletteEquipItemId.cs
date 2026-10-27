using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D7E RID: 28030
	public class LevelConditionRouletteEquipItemId : LevelConditionBase
	{
		// Token: 0x060447B6 RID: 280502 RVA: 0x010E3CB4 File Offset: 0x010E1EB4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			return inConditionInfo.LimitParamsLength != 0 && int.TryParse(inConditionInfo.GetLimitParams("ItemId"), out num) && RouletteModel.Instance.CurrentEquipItemId == num;
		}
	}
}

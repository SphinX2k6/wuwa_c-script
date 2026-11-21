using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EFD RID: 24317
	public class LevelConditionRouletteEquipItemId : LevelConditionBase
	{
		// Token: 0x0603A91A RID: 239898 RVA: 0x0108DE98 File Offset: 0x0108C098
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			return inConditionInfo.LimitParamsLength != 0 && int.TryParse(inConditionInfo.GetLimitParams("ItemId"), out num) && RouletteModel.Instance.CurrentEquipItemId == num;
		}
	}
}

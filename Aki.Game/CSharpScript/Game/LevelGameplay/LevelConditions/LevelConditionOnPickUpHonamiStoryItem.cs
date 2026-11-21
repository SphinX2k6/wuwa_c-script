using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EDD RID: 24285
	public class LevelConditionOnPickUpHonamiStoryItem : LevelConditionBase
	{
		// Token: 0x0603A8C6 RID: 239814 RVA: 0x0108CA2C File Offset: 0x0108AC2C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("HighPrice");
			float num;
			return limitParams == null || (float.TryParse(limitParams, out num) && (float)((HonamiStoryItemDataBase)eventArgs[0]).GetSellPrice() >= num);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D5F RID: 27999
	public class LevelConditionOnPickUpHonamiStoryItem : LevelConditionBase
	{
		// Token: 0x06044764 RID: 280420 RVA: 0x010E2874 File Offset: 0x010E0A74
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

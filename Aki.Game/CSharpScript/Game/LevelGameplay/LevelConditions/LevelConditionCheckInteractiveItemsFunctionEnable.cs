using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E2A RID: 24106
	public class LevelConditionCheckInteractiveItemsFunctionEnable : LevelConditionBase
	{
		// Token: 0x0603A74B RID: 239435 RVA: 0x0108642C File Offset: 0x0108462C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("CheckValue");
			return !string.IsNullOrEmpty(limitParams) && limitParams == "TRUE" == InventoryModel.Instance.GetInteractiveItemsFunctionEnable();
		}
	}
}

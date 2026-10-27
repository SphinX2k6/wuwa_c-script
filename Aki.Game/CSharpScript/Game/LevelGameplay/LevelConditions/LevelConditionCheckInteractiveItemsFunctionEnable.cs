using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CB0 RID: 27824
	public class LevelConditionCheckInteractiveItemsFunctionEnable : LevelConditionBase
	{
		// Token: 0x060445F1 RID: 280049 RVA: 0x010DC480 File Offset: 0x010DA680
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

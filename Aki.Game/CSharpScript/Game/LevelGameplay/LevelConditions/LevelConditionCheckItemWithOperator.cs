using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E33 RID: 24115
	public class LevelConditionCheckItemWithOperator : LevelConditionBase
	{
		// Token: 0x0603A764 RID: 239460 RVA: 0x01086DA4 File Offset: 0x01084FA4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ItemID");
			string limitParams2 = inConditionInfo.GetLimitParams("Count");
			string limitParams3 = inConditionInfo.GetLimitParams("Op");
			if (limitParams == null || limitParams2 == null || limitParams3 == null)
			{
				return false;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(int.Parse(limitParams), 0);
			int num = int.Parse(limitParams2);
			return base.CheckCompareValue(limitParams3, (double)itemCountByConfigId, (double)num);
		}
	}
}

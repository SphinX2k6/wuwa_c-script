using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D42 RID: 27970
	public class LevelConditionItemCountByType : LevelConditionBase
	{
		// Token: 0x0604472A RID: 280362 RVA: 0x010E2060 File Offset: 0x010E0260
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ItemType");
			int itemType;
			if (limitParams == null || !int.TryParse(limitParams, out itemType))
			{
				return false;
			}
			string limitParams2 = inConditionInfo.GetLimitParams("Value");
			string limitParams3 = inConditionInfo.GetLimitParams("Op");
			if (limitParams3 == null)
			{
				return false;
			}
			int num = (limitParams2 != null) ? int.Parse(limitParams2) : 0;
			return base.CheckCompareValue(limitParams3, (double)InventoryModel.Instance.GetItemDataBaseByItemType((InventoryDefine.EItemType)itemType).Count, (double)num);
		}
	}
}

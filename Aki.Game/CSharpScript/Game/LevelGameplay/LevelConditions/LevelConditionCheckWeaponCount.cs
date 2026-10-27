using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D00 RID: 27904
	public class LevelConditionCheckWeaponCount : LevelConditionBase
	{
		// Token: 0x060446A3 RID: 280227 RVA: 0x010DFF08 File Offset: 0x010DE108
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			if (limitParams == null)
			{
				return false;
			}
			string limitParams2 = inConditionInfo.GetLimitParams("Type");
			if (limitParams2 == null)
			{
				return false;
			}
			string limitParams3 = inConditionInfo.GetLimitParams("Quality");
			if (limitParams3 == null)
			{
				return false;
			}
			string limitParams4 = inConditionInfo.GetLimitParams("Op");
			return base.CheckCompareValue(limitParams4, (double)InventoryModel.Instance.GetAllWeaponItemDataByQualityAndType(int.Parse(limitParams3), int.Parse(limitParams2)).Count, (double)int.Parse(limitParams));
		}
	}
}

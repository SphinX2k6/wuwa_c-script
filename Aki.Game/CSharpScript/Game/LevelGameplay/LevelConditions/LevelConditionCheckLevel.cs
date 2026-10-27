using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CBC RID: 27836
	public class LevelConditionCheckLevel : LevelConditionBase
	{
		// Token: 0x06044610 RID: 280080 RVA: 0x010DCE88 File Offset: 0x010DB088
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
			int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Level);
			int? num = numberPropById;
			int num2 = 0;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				return false;
			}
			num = numberPropById;
			num2 = int.Parse(limitParams);
			return num.GetValueOrDefault() >= num2 & num != null;
		}
	}
}

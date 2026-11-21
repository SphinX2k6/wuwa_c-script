using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E42 RID: 24130
	public class LevelConditionCheckNewbieGuideV2 : LevelConditionBase
	{
		// Token: 0x0603A784 RID: 239492 RVA: 0x01087850 File Offset: 0x01085A50
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("CheckValue");
			return limitParams != null && PlayerInfoModel.Instance.NewbieGuideV2 == (limitParams == "TRUE");
		}
	}
}

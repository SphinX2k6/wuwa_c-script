using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CC8 RID: 27848
	public class LevelConditionCheckNewbieGuideV2 : LevelConditionBase
	{
		// Token: 0x0604462A RID: 280106 RVA: 0x010DD7FC File Offset: 0x010DB9FC
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

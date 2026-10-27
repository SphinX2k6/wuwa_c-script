using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D12 RID: 27922
	public class LevelConditionCheckDangoAbyssProgress : LevelConditionBase
	{
		// Token: 0x060446C8 RID: 280264 RVA: 0x010E08E8 File Offset: 0x010DEAE8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Progress");
			int num;
			if (limitParams == null || !int.TryParse(limitParams, out num))
			{
				return false;
			}
			DangoAbyssActivityData currentOpenAbyssActivityData = DangoAbyssModel.Instance.GetCurrentOpenAbyssActivityData();
			return ((currentOpenAbyssActivityData != null) ? currentOpenAbyssActivityData.GetCanChallengeIdList().Length : 0) >= num + 1;
		}
	}
}

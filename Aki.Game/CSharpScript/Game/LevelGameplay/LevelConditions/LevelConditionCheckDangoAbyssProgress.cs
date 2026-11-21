using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E8F RID: 24207
	public class LevelConditionCheckDangoAbyssProgress : LevelConditionBase
	{
		// Token: 0x0603A828 RID: 239656 RVA: 0x0108AA74 File Offset: 0x01088C74
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

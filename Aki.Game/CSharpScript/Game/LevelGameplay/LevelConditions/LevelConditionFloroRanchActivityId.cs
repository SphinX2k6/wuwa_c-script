using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA5 RID: 24229
	public class LevelConditionFloroRanchActivityId : LevelConditionBase
	{
		// Token: 0x0603A854 RID: 239700 RVA: 0x0108AFB8 File Offset: 0x010891B8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ActivityID");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && num == FloroRanchGamePlayModel.Instance.ActivityId;
		}
	}
}

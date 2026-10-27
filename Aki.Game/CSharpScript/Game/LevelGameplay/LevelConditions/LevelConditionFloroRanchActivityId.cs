using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D28 RID: 27944
	public class LevelConditionFloroRanchActivityId : LevelConditionBase
	{
		// Token: 0x060446F4 RID: 280308 RVA: 0x010E0E2C File Offset: 0x010DF02C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ActivityID");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && num == FloroRanchGamePlayModel.Instance.ActivityId;
		}
	}
}

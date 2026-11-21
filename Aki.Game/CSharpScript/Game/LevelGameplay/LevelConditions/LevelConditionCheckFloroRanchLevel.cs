using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA3 RID: 24227
	public class LevelConditionCheckFloroRanchLevel : LevelConditionBase
	{
		// Token: 0x0603A850 RID: 239696 RVA: 0x0108AF68 File Offset: 0x01089168
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("TargetLevel");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && FloroRanchGamePlayModel.Instance.SubInstanceId == num;
		}
	}
}

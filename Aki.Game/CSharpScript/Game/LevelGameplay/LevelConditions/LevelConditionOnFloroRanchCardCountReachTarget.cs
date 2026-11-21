using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E9F RID: 24223
	public class LevelConditionOnFloroRanchCardCountReachTarget : LevelConditionBase
	{
		// Token: 0x0603A848 RID: 239688 RVA: 0x0108AEA0 File Offset: 0x010890A0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("TargetCount");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && FloroRanchGamePlayModel.Instance.OwnCardEntityCount >= num;
		}
	}
}

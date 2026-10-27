using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D22 RID: 27938
	public class LevelConditionOnFloroRanchCardCountReachTarget : LevelConditionBase
	{
		// Token: 0x060446E8 RID: 280296 RVA: 0x010E0D14 File Offset: 0x010DEF14
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("TargetCount");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && FloroRanchGamePlayModel.Instance.OwnCardEntityCount >= num;
		}
	}
}

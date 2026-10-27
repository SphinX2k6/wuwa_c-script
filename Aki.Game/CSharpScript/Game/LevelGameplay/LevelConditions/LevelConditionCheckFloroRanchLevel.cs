using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D26 RID: 27942
	public class LevelConditionCheckFloroRanchLevel : LevelConditionBase
	{
		// Token: 0x060446F0 RID: 280304 RVA: 0x010E0DDC File Offset: 0x010DEFDC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("TargetLevel");
			int num;
			return limitParams != null && int.TryParse(limitParams, out num) && FloroRanchGamePlayModel.Instance.SubInstanceId == num;
		}
	}
}

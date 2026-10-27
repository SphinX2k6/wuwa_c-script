using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D82 RID: 28034
	public class LevelConditionSelfTagCheck : LevelConditionBase
	{
		// Token: 0x060447C0 RID: 280512 RVA: 0x010E3FC4 File Offset: 0x010E21C4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0 || inTrigger == null)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Tag");
			return limitParams != null && inTrigger.Tags.Contains(FNameUtil.GetDynamicFName(limitParams).Value);
		}
	}
}

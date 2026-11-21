using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F01 RID: 24321
	public class LevelConditionSelfTagCheck : LevelConditionBase
	{
		// Token: 0x0603A924 RID: 239908 RVA: 0x0108E1EC File Offset: 0x0108C3EC
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

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FE1 RID: 8161
public class SkipConditionContext
{
	// Token: 0x0601441D RID: 82973 RVA: 0x005E8268 File Offset: 0x005E6468
	[NullableContext(1)]
	public bool Check(ESkipConditionType conditionType, int[] @params)
	{
		ISkipConditionChecker skipConditionChecker;
		return SkipConditionDefine.SkipConditionCheckerMap.TryGetValue(conditionType, out skipConditionChecker) && skipConditionChecker.Check(@params);
	}
}

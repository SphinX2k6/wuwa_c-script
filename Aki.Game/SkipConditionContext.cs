using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A66 RID: 10854
public class SkipConditionContext
{
	// Token: 0x060169FC RID: 92668 RVA: 0x005BC0E0 File Offset: 0x005BA2E0
	[NullableContext(1)]
	public bool Check(ESkipConditionType conditionType, int[] @params)
	{
		ISkipConditionChecker skipConditionChecker;
		return SkipConditionDefine.SkipConditionCheckerMap.TryGetValue(conditionType, out skipConditionChecker) && skipConditionChecker.Check(@params);
	}
}

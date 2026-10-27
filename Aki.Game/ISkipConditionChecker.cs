using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A6E RID: 10862
[NullableContext(1)]
public interface ISkipConditionChecker
{
	// Token: 0x06016A0A RID: 92682
	ISkipCondition<ESkipConditionType> Parse(int[] @params);

	// Token: 0x06016A0B RID: 92683
	bool Check(int[] @params);
}

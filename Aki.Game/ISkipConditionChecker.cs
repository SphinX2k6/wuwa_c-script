using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FE9 RID: 8169
[NullableContext(1)]
public interface ISkipConditionChecker
{
	// Token: 0x0601442B RID: 82987
	ISkipCondition<ESkipConditionType> Parse(int[] @params);

	// Token: 0x0601442C RID: 82988
	bool Check(int[] @params);
}

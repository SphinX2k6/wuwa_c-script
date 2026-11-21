using System;
using System.Runtime.CompilerServices;

// Token: 0x02000571 RID: 1393
[NullableContext(1)]
[Nullable(0)]
public class IActivityLevelFunc
{
	// Token: 0x04003473 RID: 13427
	public Func<int, bool> CheckIsActivityLevel;

	// Token: 0x04003474 RID: 13428
	public Func<int, int, int> GetLevelRecommendLevel;
}

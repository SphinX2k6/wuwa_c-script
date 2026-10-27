using System;
using System.Runtime.CompilerServices;

// Token: 0x020010BD RID: 4285
[NullableContext(1)]
[Nullable(0)]
public class IActivityLevelFunc
{
	// Token: 0x040033DA RID: 13274
	public Func<int, bool> CheckIsActivityLevel;

	// Token: 0x040033DB RID: 13275
	public Func<int, int, int> GetLevelRecommendLevel;
}

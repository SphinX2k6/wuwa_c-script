using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A6A RID: 10858
[NullableContext(1)]
public interface ISkipCondition<[Nullable(0)] T> where T : Enum
{
	// Token: 0x17001E07 RID: 7687
	// (get) Token: 0x060169FE RID: 92670
	// (set) Token: 0x060169FF RID: 92671
	T ConditionType { get; set; }
}

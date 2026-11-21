using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FE5 RID: 8165
[NullableContext(1)]
public interface ISkipCondition<[Nullable(0)] T> where T : Enum
{
	// Token: 0x17001E5F RID: 7775
	// (get) Token: 0x0601441F RID: 82975
	// (set) Token: 0x06014420 RID: 82976
	T ConditionType { get; set; }
}

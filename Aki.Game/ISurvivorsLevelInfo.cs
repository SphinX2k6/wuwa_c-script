using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002105 RID: 8453
[NullableContext(1)]
public interface ISurvivorsLevelInfo
{
	// Token: 0x17001F31 RID: 7985
	// (get) Token: 0x06014BBA RID: 84922
	int LevelId { get; }

	// Token: 0x17001F32 RID: 7986
	// (get) Token: 0x06014BBB RID: 84923
	long OpenTime { get; }

	// Token: 0x17001F33 RID: 7987
	// (get) Token: 0x06014BBC RID: 84924
	bool IsEndlessMode { get; }

	// Token: 0x17001F34 RID: 7988
	// (get) Token: 0x06014BBD RID: 84925
	ModeInfo Info { get; }
}

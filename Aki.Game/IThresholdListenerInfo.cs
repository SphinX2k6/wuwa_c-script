using System;
using System.Runtime.CompilerServices;

// Token: 0x020003B6 RID: 950
[NullableContext(1)]
public interface IThresholdListenerInfo
{
	// Token: 0x17000793 RID: 1939
	// (get) Token: 0x060033EE RID: 13294
	// (set) Token: 0x060033EF RID: 13295
	TThresholdListener Func { get; set; }

	// Token: 0x17000794 RID: 1940
	// (get) Token: 0x060033F0 RID: 13296
	// (set) Token: 0x060033F1 RID: 13297
	float Max { get; set; }

	// Token: 0x17000795 RID: 1941
	// (get) Token: 0x060033F2 RID: 13298
	// (set) Token: 0x060033F3 RID: 13299
	float Min { get; set; }

	// Token: 0x17000796 RID: 1942
	// (get) Token: 0x060033F4 RID: 13300
	// (set) Token: 0x060033F5 RID: 13301
	bool InInterval { get; set; }
}

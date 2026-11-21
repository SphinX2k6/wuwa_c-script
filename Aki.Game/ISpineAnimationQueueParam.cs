using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E67 RID: 3687
[NullableContext(1)]
public interface ISpineAnimationQueueParam
{
	// Token: 0x17001031 RID: 4145
	// (get) Token: 0x060093A3 RID: 37795
	// (set) Token: 0x060093A4 RID: 37796
	int LayerIndex { get; set; }

	// Token: 0x17001032 RID: 4146
	// (get) Token: 0x060093A5 RID: 37797
	// (set) Token: 0x060093A6 RID: 37798
	string AnimationName { get; set; }

	// Token: 0x17001033 RID: 4147
	// (get) Token: 0x060093A7 RID: 37799
	// (set) Token: 0x060093A8 RID: 37800
	bool Loop { get; set; }
}

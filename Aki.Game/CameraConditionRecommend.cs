using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200072A RID: 1834
[NullableContext(1)]
[Nullable(0)]
public class CameraConditionRecommend : ICameraConditionRecommend
{
	// Token: 0x17000B35 RID: 2869
	// (get) Token: 0x06005468 RID: 21608 RVA: 0x001BD043 File Offset: 0x001BB243
	// (set) Token: 0x06005469 RID: 21609 RVA: 0x001BD04B File Offset: 0x001BB24B
	public HashSet<int> FilterIds { get; set; }

	// Token: 0x17000B36 RID: 2870
	// (get) Token: 0x0600546A RID: 21610 RVA: 0x001BD054 File Offset: 0x001BB254
	// (set) Token: 0x0600546B RID: 21611 RVA: 0x001BD05C File Offset: 0x001BB25C
	public HashSet<int> FrameIds { get; set; }
}

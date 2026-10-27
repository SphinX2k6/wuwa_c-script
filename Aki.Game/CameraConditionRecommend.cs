using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001276 RID: 4726
[NullableContext(1)]
[Nullable(0)]
public class CameraConditionRecommend : ICameraConditionRecommend
{
	// Token: 0x17000B15 RID: 2837
	// (get) Token: 0x060080D1 RID: 32977 RVA: 0x001B4373 File Offset: 0x001B2573
	// (set) Token: 0x060080D2 RID: 32978 RVA: 0x001B437B File Offset: 0x001B257B
	public HashSet<int> FilterIds { get; set; }

	// Token: 0x17000B16 RID: 2838
	// (get) Token: 0x060080D3 RID: 32979 RVA: 0x001B4384 File Offset: 0x001B2584
	// (set) Token: 0x060080D4 RID: 32980 RVA: 0x001B438C File Offset: 0x001B258C
	public HashSet<int> FrameIds { get; set; }
}

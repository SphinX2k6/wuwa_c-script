using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002B45 RID: 11077
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueParallaxItem : ISurvivorsRogueParallaxItem
{
	// Token: 0x17001EA3 RID: 7843
	// (get) Token: 0x06016F97 RID: 94103 RVA: 0x005D4F0D File Offset: 0x005D310D
	// (set) Token: 0x06016F98 RID: 94104 RVA: 0x005D4F15 File Offset: 0x005D3115
	public UUIItem Item { get; set; }

	// Token: 0x17001EA4 RID: 7844
	// (get) Token: 0x06016F99 RID: 94105 RVA: 0x005D4F1E File Offset: 0x005D311E
	// (set) Token: 0x06016F9A RID: 94106 RVA: 0x005D4F26 File Offset: 0x005D3126
	public float InitPosY { get; set; }

	// Token: 0x17001EA5 RID: 7845
	// (get) Token: 0x06016F9B RID: 94107 RVA: 0x005D4F2F File Offset: 0x005D312F
	// (set) Token: 0x06016F9C RID: 94108 RVA: 0x005D4F37 File Offset: 0x005D3137
	public float ParallaxFactor { get; set; }
}

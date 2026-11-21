using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020020C1 RID: 8385
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueParallaxItem : ISurvivorsRogueParallaxItem
{
	// Token: 0x17001EFB RID: 7931
	// (get) Token: 0x060149C8 RID: 84424 RVA: 0x00601A79 File Offset: 0x005FFC79
	// (set) Token: 0x060149C9 RID: 84425 RVA: 0x00601A81 File Offset: 0x005FFC81
	public UUIItem Item { get; set; }

	// Token: 0x17001EFC RID: 7932
	// (get) Token: 0x060149CA RID: 84426 RVA: 0x00601A8A File Offset: 0x005FFC8A
	// (set) Token: 0x060149CB RID: 84427 RVA: 0x00601A92 File Offset: 0x005FFC92
	public float InitPosY { get; set; }

	// Token: 0x17001EFD RID: 7933
	// (get) Token: 0x060149CC RID: 84428 RVA: 0x00601A9B File Offset: 0x005FFC9B
	// (set) Token: 0x060149CD RID: 84429 RVA: 0x00601AA3 File Offset: 0x005FFCA3
	public float ParallaxFactor { get; set; }
}

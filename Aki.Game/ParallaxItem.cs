using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020029E0 RID: 10720
[NullableContext(1)]
[Nullable(0)]
public class ParallaxItem : IParallaxItem
{
	// Token: 0x17001DAB RID: 7595
	// (get) Token: 0x06016368 RID: 90984 RVA: 0x0059DF7E File Offset: 0x0059C17E
	// (set) Token: 0x06016369 RID: 90985 RVA: 0x0059DF86 File Offset: 0x0059C186
	public UUIItem Item { get; set; }

	// Token: 0x17001DAC RID: 7596
	// (get) Token: 0x0601636A RID: 90986 RVA: 0x0059DF8F File Offset: 0x0059C18F
	// (set) Token: 0x0601636B RID: 90987 RVA: 0x0059DF97 File Offset: 0x0059C197
	public float InitPosY { get; set; }

	// Token: 0x17001DAD RID: 7597
	// (get) Token: 0x0601636C RID: 90988 RVA: 0x0059DFA0 File Offset: 0x0059C1A0
	// (set) Token: 0x0601636D RID: 90989 RVA: 0x0059DFA8 File Offset: 0x0059C1A8
	public float ParallaxSub { get; set; }
}

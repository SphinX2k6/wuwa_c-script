using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001F5B RID: 8027
[NullableContext(1)]
[Nullable(0)]
public class ParallaxItem : IParallaxItem
{
	// Token: 0x17001E04 RID: 7684
	// (get) Token: 0x06013D6E RID: 81262 RVA: 0x005C8F36 File Offset: 0x005C7136
	// (set) Token: 0x06013D6F RID: 81263 RVA: 0x005C8F3E File Offset: 0x005C713E
	public UUIItem Item { get; set; }

	// Token: 0x17001E05 RID: 7685
	// (get) Token: 0x06013D70 RID: 81264 RVA: 0x005C8F47 File Offset: 0x005C7147
	// (set) Token: 0x06013D71 RID: 81265 RVA: 0x005C8F4F File Offset: 0x005C714F
	public float InitPosY { get; set; }

	// Token: 0x17001E06 RID: 7686
	// (get) Token: 0x06013D72 RID: 81266 RVA: 0x005C8F58 File Offset: 0x005C7158
	// (set) Token: 0x06013D73 RID: 81267 RVA: 0x005C8F60 File Offset: 0x005C7160
	public float ParallaxSub { get; set; }
}

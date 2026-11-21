using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001F5A RID: 8026
[NullableContext(1)]
public interface IParallaxItem
{
	// Token: 0x17001E01 RID: 7681
	// (get) Token: 0x06013D6B RID: 81259
	UUIItem Item { get; }

	// Token: 0x17001E02 RID: 7682
	// (get) Token: 0x06013D6C RID: 81260
	float InitPosY { get; }

	// Token: 0x17001E03 RID: 7683
	// (get) Token: 0x06013D6D RID: 81261
	float ParallaxSub { get; }
}

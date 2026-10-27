using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020029DF RID: 10719
[NullableContext(1)]
public interface IParallaxItem
{
	// Token: 0x17001DA8 RID: 7592
	// (get) Token: 0x06016365 RID: 90981
	UUIItem Item { get; }

	// Token: 0x17001DA9 RID: 7593
	// (get) Token: 0x06016366 RID: 90982
	float InitPosY { get; }

	// Token: 0x17001DAA RID: 7594
	// (get) Token: 0x06016367 RID: 90983
	float ParallaxSub { get; }
}

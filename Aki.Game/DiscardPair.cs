using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001E90 RID: 7824
[NullableContext(1)]
[Nullable(0)]
public class DiscardPair : IDiscardPair
{
	// Token: 0x170012D8 RID: 4824
	// (get) Token: 0x0600EF9A RID: 61338 RVA: 0x00394FA6 File Offset: 0x003931A6
	// (set) Token: 0x0600EF9B RID: 61339 RVA: 0x00394FAE File Offset: 0x003931AE
	public UUIItem NotActive { get; set; }

	// Token: 0x170012D9 RID: 4825
	// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x00394FB7 File Offset: 0x003931B7
	// (set) Token: 0x0600EF9D RID: 61341 RVA: 0x00394FBF File Offset: 0x003931BF
	public UUIItem Active { get; set; }
}

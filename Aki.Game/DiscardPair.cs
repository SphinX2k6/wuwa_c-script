using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001352 RID: 4946
[NullableContext(1)]
[Nullable(0)]
public class DiscardPair : IDiscardPair
{
	// Token: 0x17001302 RID: 4866
	// (get) Token: 0x0600C3B9 RID: 50105 RVA: 0x003A0B62 File Offset: 0x0039ED62
	// (set) Token: 0x0600C3BA RID: 50106 RVA: 0x003A0B6A File Offset: 0x0039ED6A
	public UUIItem NotActive { get; set; }

	// Token: 0x17001303 RID: 4867
	// (get) Token: 0x0600C3BB RID: 50107 RVA: 0x003A0B73 File Offset: 0x0039ED73
	// (set) Token: 0x0600C3BC RID: 50108 RVA: 0x003A0B7B File Offset: 0x0039ED7B
	public UUIItem Active { get; set; }
}

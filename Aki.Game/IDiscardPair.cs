using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001E8F RID: 7823
[NullableContext(1)]
public interface IDiscardPair
{
	// Token: 0x170012D6 RID: 4822
	// (get) Token: 0x0600EF96 RID: 61334
	// (set) Token: 0x0600EF97 RID: 61335
	UUIItem NotActive { get; set; }

	// Token: 0x170012D7 RID: 4823
	// (get) Token: 0x0600EF98 RID: 61336
	// (set) Token: 0x0600EF99 RID: 61337
	UUIItem Active { get; set; }
}

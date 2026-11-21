using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001351 RID: 4945
[NullableContext(1)]
public interface IDiscardPair
{
	// Token: 0x17001300 RID: 4864
	// (get) Token: 0x0600C3B5 RID: 50101
	// (set) Token: 0x0600C3B6 RID: 50102
	UUIItem NotActive { get; set; }

	// Token: 0x17001301 RID: 4865
	// (get) Token: 0x0600C3B7 RID: 50103
	// (set) Token: 0x0600C3B8 RID: 50104
	UUIItem Active { get; set; }
}

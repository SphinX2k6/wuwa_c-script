using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200023C RID: 572
[NullableContext(2)]
public interface ICapabilityHostInitParam
{
	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x060023AC RID: 9132
	// (set) Token: 0x060023AD RID: 9133
	[Nullable(1)]
	object Id { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x060023AE RID: 9134
	// (set) Token: 0x060023AF RID: 9135
	Func<bool> IsValid { get; set; }

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x060023B0 RID: 9136
	// (set) Token: 0x060023B1 RID: 9137
	Func<AActor> GetBoundActor { get; set; }
}

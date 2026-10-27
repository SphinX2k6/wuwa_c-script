using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000238 RID: 568
[NullableContext(2)]
public interface ICapabilityHostInitParam
{
	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x060022F4 RID: 8948
	// (set) Token: 0x060022F5 RID: 8949
	[Nullable(1)]
	object Id { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x060022F6 RID: 8950
	// (set) Token: 0x060022F7 RID: 8951
	Func<bool> IsValid { get; set; }

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x060022F8 RID: 8952
	// (set) Token: 0x060022F9 RID: 8953
	Func<AActor> GetBoundActor { get; set; }
}

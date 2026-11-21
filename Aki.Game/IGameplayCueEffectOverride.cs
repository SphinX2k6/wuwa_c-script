using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002509 RID: 9481
[NullableContext(2)]
public interface IGameplayCueEffectOverride
{
	// Token: 0x17002475 RID: 9333
	// (get) Token: 0x06017748 RID: 96072
	// (set) Token: 0x06017749 RID: 96073
	string SocketName { get; set; }

	// Token: 0x17002476 RID: 9334
	// (get) Token: 0x0601774A RID: 96074
	// (set) Token: 0x0601774B RID: 96075
	FVector? RelativePosition { get; set; }

	// Token: 0x17002477 RID: 9335
	// (get) Token: 0x0601774C RID: 96076
	// (set) Token: 0x0601774D RID: 96077
	FVector? RelativeRotation { get; set; }

	// Token: 0x17002478 RID: 9336
	// (get) Token: 0x0601774E RID: 96078
	// (set) Token: 0x0601774F RID: 96079
	FVector? Scale { get; set; }
}

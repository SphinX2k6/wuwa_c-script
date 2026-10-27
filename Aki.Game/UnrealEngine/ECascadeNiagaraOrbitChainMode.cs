using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200445E RID: 17502
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/CascadeConversion/ECascadeNiagaraOrbitChainMode.ECascadeNiagaraOrbitChainMode")]
	public enum ECascadeNiagaraOrbitChainMode : byte
	{
		// Token: 0x040181C1 RID: 98753
		Add,
		// Token: 0x040181C2 RID: 98754
		Scale,
		// Token: 0x040181C3 RID: 98755
		Link,
		// Token: 0x040181C4 RID: 98756
		NONE,
		// Token: 0x040181C5 RID: 98757
		ECascadeNiagaraOrbitChainMode_MAX
	}
}

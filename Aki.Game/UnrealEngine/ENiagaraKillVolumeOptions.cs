using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004474 RID: 17524
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraKillVolumeOptions.ENiagaraKillVolumeOptions")]
	public enum ENiagaraKillVolumeOptions : byte
	{
		// Token: 0x04018235 RID: 98869
		Sphere,
		// Token: 0x04018236 RID: 98870
		Box,
		// Token: 0x04018237 RID: 98871
		Plane,
		// Token: 0x04018238 RID: 98872
		Slab,
		// Token: 0x04018239 RID: 98873
		Cone,
		// Token: 0x0401823A RID: 98874
		ENiagaraKillVolumeOptions_MAX
	}
}

using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004469 RID: 17513
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraCoordinateSpace.ENiagaraCoordinateSpace")]
	public enum ENiagaraCoordinateSpace : byte
	{
		// Token: 0x040181FE RID: 98814
		Simulation,
		// Token: 0x040181FF RID: 98815
		World,
		// Token: 0x04018200 RID: 98816
		Local,
		// Token: 0x04018201 RID: 98817
		ENiagaraCoordinateSpace_MAX
	}
}

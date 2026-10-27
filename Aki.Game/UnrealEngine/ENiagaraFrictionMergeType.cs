using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004470 RID: 17520
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraFrictionMergeType.ENiagaraFrictionMergeType")]
	public enum ENiagaraFrictionMergeType : byte
	{
		// Token: 0x04018222 RID: 98850
		Ignore,
		// Token: 0x04018223 RID: 98851
		Average,
		// Token: 0x04018224 RID: 98852
		Min,
		// Token: 0x04018225 RID: 98853
		Max,
		// Token: 0x04018226 RID: 98854
		ENiagaraFrictionMergeType_MAX
	}
}

using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004493 RID: 17555
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraVertexSamplingMode.ENiagaraVertexSamplingMode")]
	public enum ENiagaraVertexSamplingMode : byte
	{
		// Token: 0x040182D2 RID: 99026
		Random__All_Vertices_,
		// Token: 0x040182D3 RID: 99027
		Random__Sampling_Regions_,
		// Token: 0x040182D4 RID: 99028
		Direct__All_Vertices_,
		// Token: 0x040182D5 RID: 99029
		Direct__Sampling_Regions_,
		// Token: 0x040182D6 RID: 99030
		ENiagaraVertexSamplingMode_MAX
	}
}

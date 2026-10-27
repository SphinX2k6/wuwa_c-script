using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200449C RID: 17564
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_DirectReadParticleIDSampling.ENiagara_DirectReadParticleIDSampling")]
	public enum ENiagara_DirectReadParticleIDSampling : byte
	{
		// Token: 0x04018303 RID: 99075
		Disabled,
		// Token: 0x04018304 RID: 99076
		Apply_Sampled_ID_as_Ribbon_ID,
		// Token: 0x04018305 RID: 99077
		Output_Only,
		// Token: 0x04018306 RID: 99078
		ENiagara_MAX
	}
}

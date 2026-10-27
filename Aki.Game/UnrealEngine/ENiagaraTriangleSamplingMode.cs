using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200448E RID: 17550
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraTriangleSamplingMode.ENiagaraTriangleSamplingMode")]
	public enum ENiagaraTriangleSamplingMode : byte
	{
		// Token: 0x040182B9 RID: 99001
		Random__All_Triangles_,
		// Token: 0x040182BA RID: 99002
		Random__Sampling_Regions_,
		// Token: 0x040182BB RID: 99003
		Direct__All_Triangles_,
		// Token: 0x040182BC RID: 99004
		Direct__Sampling_Regions_,
		// Token: 0x040182BD RID: 99005
		ENiagaraTriangleSamplingMode_MAX
	}
}

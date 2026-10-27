using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200447B RID: 17531
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraMeshTransforms.ENiagaraMeshTransforms")]
	public enum ENiagaraMeshTransforms : byte
	{
		// Token: 0x0401825B RID: 98907
		Simulation,
		// Token: 0x0401825C RID: 98908
		World,
		// Token: 0x0401825D RID: 98909
		Local,
		// Token: 0x0401825E RID: 98910
		Mesh,
		// Token: 0x0401825F RID: 98911
		ENiagaraMeshTransforms_MAX
	}
}

using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004471 RID: 17521
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraGPUDepthResponseType.ENiagaraGPUDepthResponseType")]
	public enum ENiagaraGPUDepthResponseType : byte
	{
		// Token: 0x04018228 RID: 98856
		Kill,
		// Token: 0x04018229 RID: 98857
		Bounce,
		// Token: 0x0401822A RID: 98858
		ENiagaraGPUDepthResponseType_MAX
	}
}

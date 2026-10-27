using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004467 RID: 17511
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraChannelCorrelation.ENiagaraChannelCorrelation")]
	public enum ENiagaraChannelCorrelation : byte
	{
		// Token: 0x040181F4 RID: 98804
		Link_RGBA,
		// Token: 0x040181F5 RID: 98805
		Link_RGB___Link_A,
		// Token: 0x040181F6 RID: 98806
		Random_Individual_Channels,
		// Token: 0x040181F7 RID: 98807
		ENiagaraChannelCorrelation_MAX
	}
}

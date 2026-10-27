using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004489 RID: 17545
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSphereDistributionMode.ENiagaraSphereDistributionMode")]
	public enum ENiagaraSphereDistributionMode : byte
	{
		// Token: 0x040182A3 RID: 98979
		Random,
		// Token: 0x040182A4 RID: 98980
		Direct,
		// Token: 0x040182A5 RID: 98981
		Uniform,
		// Token: 0x040182A6 RID: 98982
		ENiagaraSphereDistributionMode_MAX
	}
}

using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044AE RID: 17582
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_SubUVLookupMode.ENiagara_SubUVLookupMode")]
	public enum ENiagara_SubUVLookupMode : byte
	{
		// Token: 0x0401835F RID: 99167
		Linear,
		// Token: 0x04018360 RID: 99168
		Curve,
		// Token: 0x04018361 RID: 99169
		Random,
		// Token: 0x04018362 RID: 99170
		Infinite,
		// Token: 0x04018363 RID: 99171
		ENiagara_MAX
	}
}

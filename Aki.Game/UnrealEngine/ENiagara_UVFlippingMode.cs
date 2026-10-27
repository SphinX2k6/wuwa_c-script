using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044B2 RID: 17586
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_UVFlippingMode.ENiagara_UVFlippingMode")]
	public enum ENiagara_UVFlippingMode : byte
	{
		// Token: 0x04018373 RID: 99187
		Unset,
		// Token: 0x04018374 RID: 99188
		Random_X,
		// Token: 0x04018375 RID: 99189
		Random_Y,
		// Token: 0x04018376 RID: 99190
		Random_X___Y,
		// Token: 0x04018377 RID: 99191
		Custom,
		// Token: 0x04018378 RID: 99192
		ENiagara_MAX
	}
}

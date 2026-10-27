using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044AD RID: 17581
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_SpriteRotationMode.ENiagara_SpriteRotationMode")]
	public enum ENiagara_SpriteRotationMode : byte
	{
		// Token: 0x04018359 RID: 99161
		Unset,
		// Token: 0x0401835A RID: 99162
		Random,
		// Token: 0x0401835B RID: 99163
		Direct_Angle__Degrees_,
		// Token: 0x0401835C RID: 99164
		Direct_Normalized_Angle__0_1_,
		// Token: 0x0401835D RID: 99165
		ENiagara_MAX
	}
}

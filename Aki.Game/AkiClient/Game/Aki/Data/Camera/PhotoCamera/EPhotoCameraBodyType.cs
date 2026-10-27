using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera
{
	// Token: 0x02003FB1 RID: 16305
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/EPhotoCameraBodyType.EPhotoCameraBodyType")]
	public enum EPhotoCameraBodyType : byte
	{
		// Token: 0x040156C3 RID: 87747
		None,
		// Token: 0x040156C4 RID: 87748
		FemaleS,
		// Token: 0x040156C5 RID: 87749
		FemaleM,
		// Token: 0x040156C6 RID: 87750
		FemaleXL,
		// Token: 0x040156C7 RID: 87751
		FemaleMS,
		// Token: 0x040156C8 RID: 87752
		MaleS,
		// Token: 0x040156C9 RID: 87753
		MaleM,
		// Token: 0x040156CA RID: 87754
		MaleXL,
		// Token: 0x040156CB RID: 87755
		FemaleZ,
		// Token: 0x040156CC RID: 87756
		FemaleZ2,
		// Token: 0x040156CD RID: 87757
		LittleFox,
		// Token: 0x040156CE RID: 87758
		EPhotoCameraBodyType_MAX
	}
}

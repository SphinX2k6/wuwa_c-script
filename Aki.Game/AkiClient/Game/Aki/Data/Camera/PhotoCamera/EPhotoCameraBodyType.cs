using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera
{
	// Token: 0x02003239 RID: 12857
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/EPhotoCameraBodyType.EPhotoCameraBodyType")]
	public enum EPhotoCameraBodyType : byte
	{
		// Token: 0x0401146B RID: 70763
		None,
		// Token: 0x0401146C RID: 70764
		FemaleS,
		// Token: 0x0401146D RID: 70765
		FemaleM,
		// Token: 0x0401146E RID: 70766
		FemaleXL,
		// Token: 0x0401146F RID: 70767
		FemaleMS,
		// Token: 0x04011470 RID: 70768
		MaleS,
		// Token: 0x04011471 RID: 70769
		MaleM,
		// Token: 0x04011472 RID: 70770
		MaleXL,
		// Token: 0x04011473 RID: 70771
		FemaleZ,
		// Token: 0x04011474 RID: 70772
		FemaleZ2,
		// Token: 0x04011475 RID: 70773
		LittleFox,
		// Token: 0x04011476 RID: 70774
		EPhotoCameraBodyType_MAX
	}
}

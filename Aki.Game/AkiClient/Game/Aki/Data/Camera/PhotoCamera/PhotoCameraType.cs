using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera
{
	// Token: 0x02003FB2 RID: 16306
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/PhotoCameraType.PhotoCameraType")]
	public enum PhotoCameraType : byte
	{
		// Token: 0x040156D0 RID: 87760
		Normal,
		// Token: 0x040156D1 RID: 87761
		Selfie,
		// Token: 0x040156D2 RID: 87762
		FirstPerson,
		// Token: 0x040156D3 RID: 87763
		Drone,
		// Token: 0x040156D4 RID: 87764
		PhotoCameraType_MAX
	}
}

using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera
{
	// Token: 0x0200323A RID: 12858
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/PhotoCameraType.PhotoCameraType")]
	public enum PhotoCameraType : byte
	{
		// Token: 0x04011478 RID: 70776
		Normal,
		// Token: 0x04011479 RID: 70777
		Selfie,
		// Token: 0x0401147A RID: 70778
		FirstPerson,
		// Token: 0x0401147B RID: 70779
		Drone,
		// Token: 0x0401147C RID: 70780
		PhotoCameraType_MAX
	}
}

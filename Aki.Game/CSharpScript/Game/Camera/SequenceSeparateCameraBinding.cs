using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006460 RID: 25696
	[NullableContext(1)]
	[Nullable(0)]
	internal class SequenceSeparateCameraBinding
	{
		// Token: 0x0603E6BF RID: 255679 RVA: 0x01226F59 File Offset: 0x01225159
		public SequenceSeparateCameraBinding(FName sequenceCameraTag, BP_CineCamera_C cineCamera, CameraModelInstance cameraModel)
		{
		}

		// Token: 0x170076CC RID: 30412
		// (get) Token: 0x0603E6C0 RID: 255680 RVA: 0x01226F76 File Offset: 0x01225176
		public FName SequenceCameraTag { get; } = sequenceCameraTag;

		// Token: 0x170076CD RID: 30413
		// (get) Token: 0x0603E6C1 RID: 255681 RVA: 0x01226F7E File Offset: 0x0122517E
		public BP_CineCamera_C CineCamera { get; } = cineCamera;

		// Token: 0x170076CE RID: 30414
		// (get) Token: 0x0603E6C2 RID: 255682 RVA: 0x01226F86 File Offset: 0x01225186
		public CameraModelInstance CameraModel { get; } = cameraModel;
	}
}

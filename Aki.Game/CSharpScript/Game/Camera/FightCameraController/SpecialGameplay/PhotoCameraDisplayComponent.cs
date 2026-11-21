using System;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200647F RID: 25727
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Display)]
	public class PhotoCameraDisplayComponent : PhotoCameraComponentBase
	{
		// Token: 0x0603E803 RID: 256003 RVA: 0x01230D3C File Offset: 0x0122EF3C
		protected override void OnTick(float deltaTime)
		{
			if (this.Host.CurrentConfig == null)
			{
				return;
			}
			ACameraActor cameraActor = this.Host.CameraActor;
			if (cameraActor == null || !cameraActor.IsValid())
			{
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			cameraActor.D_K2_SetActorLocationAndRotation(virtualCamera.WorldLocation.ToUeVector(true), virtualCamera.WorldRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, true);
			cameraActor.CameraComponent.SetFieldOfView(virtualCamera.Fov);
		}
	}
}

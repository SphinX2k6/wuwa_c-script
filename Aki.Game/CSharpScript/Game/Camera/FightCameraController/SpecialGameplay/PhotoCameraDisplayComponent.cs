using System;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072FC RID: 29436
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Display)]
	public class PhotoCameraDisplayComponent : PhotoCameraComponentBase
	{
		// Token: 0x060483B7 RID: 295863 RVA: 0x0128E388 File Offset: 0x0128C588
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

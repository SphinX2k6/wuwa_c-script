using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006048 RID: 24648
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabCameraConfig
	{
		// Token: 0x0603B285 RID: 242309 RVA: 0x010B9120 File Offset: 0x010B7320
		public DollGrabCameraConfig(Vector cameraLocation, Rotator cameraRotation, float fadeInTime, float fadeOutTime, bool isDisableCollision, bool isDisableDither, float fov)
		{
			this.CameraLocation.DeepCopy(cameraLocation);
			this.CameraRotation.DeepCopy(cameraRotation);
			this.FadeInTime = fadeInTime;
			this.FadeOutTime = fadeOutTime;
			this.IsDisableCollision = isDisableCollision;
			this.IsDisableDither = isDisableDither;
			this.Fov = fov;
		}

		// Token: 0x0401F209 RID: 127497
		public Vector CameraLocation = Vector.Create();

		// Token: 0x0401F20A RID: 127498
		public Rotator CameraRotation = Rotator.Create();

		// Token: 0x0401F20B RID: 127499
		public float FadeInTime;

		// Token: 0x0401F20C RID: 127500
		public float FadeOutTime;

		// Token: 0x0401F20D RID: 127501
		public bool IsDisableCollision;

		// Token: 0x0401F20E RID: 127502
		public bool IsDisableDither;

		// Token: 0x0401F20F RID: 127503
		public float Fov;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC8 RID: 28360
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabCameraConfig
	{
		// Token: 0x060450E4 RID: 282852 RVA: 0x0110F044 File Offset: 0x0110D244
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

		// Token: 0x04023F56 RID: 147286
		public Vector CameraLocation = Vector.Create();

		// Token: 0x04023F57 RID: 147287
		public Rotator CameraRotation = Rotator.Create();

		// Token: 0x04023F58 RID: 147288
		public float FadeInTime;

		// Token: 0x04023F59 RID: 147289
		public float FadeOutTime;

		// Token: 0x04023F5A RID: 147290
		public bool IsDisableCollision;

		// Token: 0x04023F5B RID: 147291
		public bool IsDisableDither;

		// Token: 0x04023F5C RID: 147292
		public float Fov;
	}
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x0200021C RID: 540
[NullableContext(1)]
[Nullable(0)]
public class CameraFadeOutData
{
	// Token: 0x04001556 RID: 5462
	public bool ModifyArmLength;

	// Token: 0x04001557 RID: 5463
	public float StartArmLength;

	// Token: 0x04001558 RID: 5464
	public float ArmLength;

	// Token: 0x04001559 RID: 5465
	public bool ModifyArmOffset;

	// Token: 0x0400155A RID: 5466
	public Vector StartArmOffset = Vector.Create();

	// Token: 0x0400155B RID: 5467
	public Vector ArmOffset = Vector.Create();

	// Token: 0x0400155C RID: 5468
	public bool ModifyCameraOffset;

	// Token: 0x0400155D RID: 5469
	public Vector StartCameraOffset = Vector.Create();

	// Token: 0x0400155E RID: 5470
	public Vector CameraOffset = Vector.Create();

	// Token: 0x0400155F RID: 5471
	public bool ModifyZoomModifier;

	// Token: 0x04001560 RID: 5472
	public float StartFinalArmLength;

	// Token: 0x04001561 RID: 5473
	public float FinalArmLength;

	// Token: 0x04001562 RID: 5474
	public bool ModifyFov;

	// Token: 0x04001563 RID: 5475
	public float StartFov;

	// Token: 0x04001564 RID: 5476
	public float Fov;

	// Token: 0x04001565 RID: 5477
	public bool ModifyArmRotationPitch;

	// Token: 0x04001566 RID: 5478
	public bool ModifyArmRotationYaw;

	// Token: 0x04001567 RID: 5479
	public bool ModifyArmRotationRoll;

	// Token: 0x04001568 RID: 5480
	public float StartArmRotationPitch;

	// Token: 0x04001569 RID: 5481
	public float StartArmRotationYaw;

	// Token: 0x0400156A RID: 5482
	public float StartArmRotationRoll;

	// Token: 0x0400156B RID: 5483
	public float ArmRotationPitch;

	// Token: 0x0400156C RID: 5484
	public float ArmRotationYaw;

	// Token: 0x0400156D RID: 5485
	public float ArmRotationRoll;

	// Token: 0x0400156E RID: 5486
	public bool ModifyPlayerLocation;

	// Token: 0x0400156F RID: 5487
	public Vector StartPlayerLocation = Vector.Create();

	// Token: 0x04001570 RID: 5488
	public Vector PlayerLocation = Vector.Create();

	// Token: 0x04001571 RID: 5489
	public float ElapsedTime;

	// Token: 0x04001572 RID: 5490
	public float FadeOutTotalTime;

	// Token: 0x04001573 RID: 5491
	public bool UseFadeOutTimeLerp;

	// Token: 0x04001574 RID: 5492
	[Nullable(2)]
	public CurveBase BlendOutCurve;
}

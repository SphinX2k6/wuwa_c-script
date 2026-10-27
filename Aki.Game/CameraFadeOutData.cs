using System;
using System.Runtime.CompilerServices;

// Token: 0x02000218 RID: 536
[NullableContext(1)]
[Nullable(0)]
public class CameraFadeOutData
{
	// Token: 0x04001514 RID: 5396
	public bool ModifyArmLength;

	// Token: 0x04001515 RID: 5397
	public float StartArmLength;

	// Token: 0x04001516 RID: 5398
	public float ArmLength;

	// Token: 0x04001517 RID: 5399
	public bool ModifyArmOffset;

	// Token: 0x04001518 RID: 5400
	public Vector StartArmOffset = Vector.Create();

	// Token: 0x04001519 RID: 5401
	public Vector ArmOffset = Vector.Create();

	// Token: 0x0400151A RID: 5402
	public bool ModifyCameraOffset;

	// Token: 0x0400151B RID: 5403
	public Vector StartCameraOffset = Vector.Create();

	// Token: 0x0400151C RID: 5404
	public Vector CameraOffset = Vector.Create();

	// Token: 0x0400151D RID: 5405
	public bool ModifyZoomModifier;

	// Token: 0x0400151E RID: 5406
	public float StartFinalArmLength;

	// Token: 0x0400151F RID: 5407
	public float FinalArmLength;

	// Token: 0x04001520 RID: 5408
	public bool ModifyFov;

	// Token: 0x04001521 RID: 5409
	public float StartFov;

	// Token: 0x04001522 RID: 5410
	public float Fov;

	// Token: 0x04001523 RID: 5411
	public bool ModifyArmRotationPitch;

	// Token: 0x04001524 RID: 5412
	public bool ModifyArmRotationYaw;

	// Token: 0x04001525 RID: 5413
	public bool ModifyArmRotationRoll;

	// Token: 0x04001526 RID: 5414
	public float StartArmRotationPitch;

	// Token: 0x04001527 RID: 5415
	public float StartArmRotationYaw;

	// Token: 0x04001528 RID: 5416
	public float StartArmRotationRoll;

	// Token: 0x04001529 RID: 5417
	public float ArmRotationPitch;

	// Token: 0x0400152A RID: 5418
	public float ArmRotationYaw;

	// Token: 0x0400152B RID: 5419
	public float ArmRotationRoll;

	// Token: 0x0400152C RID: 5420
	public bool ModifyPlayerLocation;

	// Token: 0x0400152D RID: 5421
	public Vector StartPlayerLocation = Vector.Create();

	// Token: 0x0400152E RID: 5422
	public Vector PlayerLocation = Vector.Create();

	// Token: 0x0400152F RID: 5423
	public float ElapsedTime;

	// Token: 0x04001530 RID: 5424
	public float FadeOutTotalTime;

	// Token: 0x04001531 RID: 5425
	public bool UseFadeOutTimeLerp;

	// Token: 0x04001532 RID: 5426
	[Nullable(2)]
	public CurveBase BlendOutCurve;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000206 RID: 518
[NullableContext(1)]
[Nullable(0)]
public class BaseCameraGravity
{
	// Token: 0x06002107 RID: 8455 RVA: 0x000B3BB7 File Offset: 0x000B1DB7
	public void Init(CameraGravityController owner, CameraGravityDirectionConfig config)
	{
		this.Owner = owner;
		this.CameraGravityConfig = config;
		this.StartLerpGravityVector.DeepCopy(this.Owner.GetCurrentCameraGravityDirect());
		this.SetCameraGravityMode();
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000B3BE3 File Offset: 0x000B1DE3
	protected void InternalSetCameraGravityMode(ECameraGravityMode cameraGravityMode)
	{
		this.Owner.SetCurrentCameraGravityMode(cameraGravityMode);
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000B3BF1 File Offset: 0x000B1DF1
	protected virtual void SetCameraGravityMode()
	{
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000B3BF3 File Offset: 0x000B1DF3
	public Vector GravityStartLerpVector()
	{
		return this.StartLerpGravityVector;
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x000B3BFB File Offset: 0x000B1DFB
	public virtual Vector GravityEndLerpVector()
	{
		return this.EndLerpGravityVector;
	}

	// Token: 0x04001489 RID: 5257
	[Nullable(2)]
	public CameraGravityController Owner;

	// Token: 0x0400148A RID: 5258
	[Nullable(2)]
	public CameraGravityDirectionConfig CameraGravityConfig;

	// Token: 0x0400148B RID: 5259
	protected readonly Vector StartLerpGravityVector = Vector.Create();

	// Token: 0x0400148C RID: 5260
	protected readonly Vector EndLerpGravityVector = Vector.Create();
}

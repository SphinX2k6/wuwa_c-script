using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000202 RID: 514
[NullableContext(1)]
[Nullable(0)]
public class BaseCameraGravity
{
	// Token: 0x06002059 RID: 8281 RVA: 0x000AC897 File Offset: 0x000AAA97
	public void Init(CameraGravityController owner, CameraGravityDirectionConfig config)
	{
		this.Owner = owner;
		this.CameraGravityConfig = config;
		this.StartLerpGravityVector.DeepCopy(this.Owner.GetCurrentCameraGravityDirect());
		this.SetCameraGravityMode();
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x000AC8C3 File Offset: 0x000AAAC3
	protected void InternalSetCameraGravityMode(ECameraGravityMode cameraGravityMode)
	{
		this.Owner.SetCurrentCameraGravityMode(cameraGravityMode);
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000AC8D1 File Offset: 0x000AAAD1
	protected virtual void SetCameraGravityMode()
	{
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000AC8D3 File Offset: 0x000AAAD3
	public Vector GravityStartLerpVector()
	{
		return this.StartLerpGravityVector;
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000AC8DB File Offset: 0x000AAADB
	public virtual Vector GravityEndLerpVector()
	{
		return this.EndLerpGravityVector;
	}

	// Token: 0x04001447 RID: 5191
	[Nullable(2)]
	public CameraGravityController Owner;

	// Token: 0x04001448 RID: 5192
	[Nullable(2)]
	public CameraGravityDirectionConfig CameraGravityConfig;

	// Token: 0x04001449 RID: 5193
	protected readonly Vector StartLerpGravityVector = Vector.Create();

	// Token: 0x0400144A RID: 5194
	protected readonly Vector EndLerpGravityVector = Vector.Create();
}

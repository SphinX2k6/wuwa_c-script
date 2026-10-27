using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000205 RID: 517
public class TargetCameraGravity : BaseCameraGravity
{
	// Token: 0x06002065 RID: 8293 RVA: 0x000AC959 File Offset: 0x000AAB59
	protected override void SetCameraGravityMode()
	{
		base.InternalSetCameraGravityMode(ECameraGravityMode.CameraTargetGravityDirect);
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x000AC962 File Offset: 0x000AAB62
	[NullableContext(1)]
	public override Vector GravityEndLerpVector()
	{
		this.EndLerpGravityVector.DeepCopy(this.Owner.GetGravityDirectForActor());
		return this.EndLerpGravityVector;
	}
}

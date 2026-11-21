using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000209 RID: 521
public class TargetCameraGravity : BaseCameraGravity
{
	// Token: 0x06002113 RID: 8467 RVA: 0x000B3C79 File Offset: 0x000B1E79
	protected override void SetCameraGravityMode()
	{
		base.InternalSetCameraGravityMode(ECameraGravityMode.CameraTargetGravityDirect);
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000B3C82 File Offset: 0x000B1E82
	[NullableContext(1)]
	public override Vector GravityEndLerpVector()
	{
		this.EndLerpGravityVector.DeepCopy(this.Owner.GetGravityDirectForActor());
		return this.EndLerpGravityVector;
	}
}

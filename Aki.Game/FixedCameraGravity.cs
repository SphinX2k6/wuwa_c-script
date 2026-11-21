using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000208 RID: 520
public class FixedCameraGravity : BaseCameraGravity
{
	// Token: 0x06002110 RID: 8464 RVA: 0x000B3C4A File Offset: 0x000B1E4A
	protected override void SetCameraGravityMode()
	{
		base.InternalSetCameraGravityMode(ECameraGravityMode.FixedGravityDirect);
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000B3C53 File Offset: 0x000B1E53
	[NullableContext(1)]
	public override Vector GravityEndLerpVector()
	{
		this.EndLerpGravityVector.DeepCopy(this.CameraGravityConfig.TargetGravity);
		return this.EndLerpGravityVector;
	}
}

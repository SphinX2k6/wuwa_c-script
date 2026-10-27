using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000204 RID: 516
public class FixedCameraGravity : BaseCameraGravity
{
	// Token: 0x06002062 RID: 8290 RVA: 0x000AC92A File Offset: 0x000AAB2A
	protected override void SetCameraGravityMode()
	{
		base.InternalSetCameraGravityMode(ECameraGravityMode.FixedGravityDirect);
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000AC933 File Offset: 0x000AAB33
	[NullableContext(1)]
	public override Vector GravityEndLerpVector()
	{
		this.EndLerpGravityVector.DeepCopy(this.CameraGravityConfig.TargetGravity);
		return this.EndLerpGravityVector;
	}
}

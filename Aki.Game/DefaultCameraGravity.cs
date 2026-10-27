using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000203 RID: 515
public class DefaultCameraGravity : BaseCameraGravity
{
	// Token: 0x0600205F RID: 8287 RVA: 0x000AC901 File Offset: 0x000AAB01
	protected override void SetCameraGravityMode()
	{
		base.InternalSetCameraGravityMode(ECameraGravityMode.None);
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000AC90A File Offset: 0x000AAB0A
	[NullableContext(1)]
	public override Vector GravityEndLerpVector()
	{
		this.EndLerpGravityVector.DeepCopy(Vector.DownVectorProxy);
		return this.EndLerpGravityVector;
	}
}

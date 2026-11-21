using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

// Token: 0x02000207 RID: 519
public class DefaultCameraGravity : BaseCameraGravity
{
	// Token: 0x0600210D RID: 8461 RVA: 0x000B3C21 File Offset: 0x000B1E21
	protected override void SetCameraGravityMode()
	{
		base.InternalSetCameraGravityMode(ECameraGravityMode.None);
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000B3C2A File Offset: 0x000B1E2A
	[NullableContext(1)]
	public override Vector GravityEndLerpVector()
	{
		this.EndLerpGravityVector.DeepCopy(Vector.DownVectorProxy);
		return this.EndLerpGravityVector;
	}
}

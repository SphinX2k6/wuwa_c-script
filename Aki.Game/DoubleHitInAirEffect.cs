using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020025B7 RID: 9655
[NullableContext(1)]
[Nullable(0)]
public class DoubleHitInAirEffect
{
	// Token: 0x06017F64 RID: 98148 RVA: 0x007299FC File Offset: 0x00727BFC
	public void FromUeHitEffect(SHitEffect hitEffect)
	{
		this.GravityScaleUp = hitEffect.落地反弹上升重力标量;
		this.GravityScaleDown = hitEffect.落地反弹下落重力标量;
		this.GravityScaleTop = hitEffect.落地反弹弧顶重力标量;
		Vector landingBounce = this.LandingBounce;
		FVector 落地反弹 = hitEffect.落地反弹;
		landingBounce.FromUeVector(落地反弹);
		this.VelocityTop = hitEffect.落地反弹速度阈值;
		this.Valid = true;
		this.Duration = hitEffect.落地反弹时长;
	}

	// Token: 0x06017F65 RID: 98149 RVA: 0x00729A60 File Offset: 0x00727C60
	public void Finish()
	{
		this.Valid = false;
	}

	// Token: 0x0400CD6F RID: 52591
	public float GravityScaleUp;

	// Token: 0x0400CD70 RID: 52592
	public float GravityScaleDown;

	// Token: 0x0400CD71 RID: 52593
	public float GravityScaleTop;

	// Token: 0x0400CD72 RID: 52594
	public readonly Vector LandingBounce = Vector.Create();

	// Token: 0x0400CD73 RID: 52595
	public float VelocityTop;

	// Token: 0x0400CD74 RID: 52596
	public bool Valid;

	// Token: 0x0400CD75 RID: 52597
	public float Duration;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003061 RID: 12385
[NullableContext(1)]
[Nullable(0)]
public class DoubleHitInAirEffect
{
	// Token: 0x0601A5B4 RID: 107956 RVA: 0x00702D30 File Offset: 0x00700F30
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

	// Token: 0x0601A5B5 RID: 107957 RVA: 0x00702D94 File Offset: 0x00700F94
	public void Finish()
	{
		this.Valid = false;
	}

	// Token: 0x0400C995 RID: 51605
	public float GravityScaleUp;

	// Token: 0x0400C996 RID: 51606
	public float GravityScaleDown;

	// Token: 0x0400C997 RID: 51607
	public float GravityScaleTop;

	// Token: 0x0400C998 RID: 51608
	public readonly Vector LandingBounce = Vector.Create();

	// Token: 0x0400C999 RID: 51609
	public float VelocityTop;

	// Token: 0x0400C99A RID: 51610
	public bool Valid;

	// Token: 0x0400C99B RID: 51611
	public float Duration;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x0200231A RID: 8986
[NullableContext(1)]
[Nullable(0)]
public class BulletHitEffectConf
{
	// Token: 0x06016254 RID: 90708 RVA: 0x0066F734 File Offset: 0x0066D934
	public BulletHitEffectConf(SBulletEffectOnHitConf data)
	{
		this.EnableHighLimit = data.启用约束;
		this.HighLimit = Vector2D.Create();
		this.Scale = Vector.Create();
		this.HighLimit.FromUeVector2D(data.高度约束);
		Vector scale = this.Scale;
		FVector 大小缩放 = data.大小缩放;
		scale.FromUeVector(大小缩放);
	}

	// Token: 0x0400BA8F RID: 47759
	public readonly Vector2D HighLimit;

	// Token: 0x0400BA90 RID: 47760
	public readonly Vector Scale;

	// Token: 0x0400BA91 RID: 47761
	public readonly bool EnableHighLimit;
}

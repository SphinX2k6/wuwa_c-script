using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DC0 RID: 11712
[NullableContext(1)]
[Nullable(0)]
public class BulletHitEffectConf
{
	// Token: 0x060189AC RID: 100780 RVA: 0x0064992C File Offset: 0x00647B2C
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

	// Token: 0x0400B714 RID: 46868
	public readonly Vector2D HighLimit;

	// Token: 0x0400B715 RID: 46869
	public readonly Vector Scale;

	// Token: 0x0400B716 RID: 46870
	public readonly bool EnableHighLimit;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003469 RID: 13417
[NullableContext(1)]
[Nullable(0)]
public class EffectTriggerActionParameterNames
{
	// Token: 0x0601D19C RID: 119196 RVA: 0x0081CC08 File Offset: 0x0081AE08
	public EffectTriggerActionParameterNames(IReadOnlyList<FName> trigger, IReadOnlyList<FName> duration, IReadOnlyList<FName> attackRadius, IReadOnlyList<FName> attackMagnitude, IReadOnlyList<FName> actorLocation, IReadOnlyList<FName> curveFloat, IReadOnlyList<FName> elapsedTime, IReadOnlyList<FName> textureHeight)
	{
		this.Trigger = trigger;
		this.Duration = duration;
		this.AttackRadius = attackRadius;
		this.AttackMagnitude = attackMagnitude;
		this.ActorLocation = actorLocation;
		this.CurveFloat = curveFloat;
		this.ElapsedTime = elapsedTime;
		this.TextureHeight = textureHeight;
	}

	// Token: 0x0400E517 RID: 58647
	public readonly IReadOnlyList<FName> Trigger;

	// Token: 0x0400E518 RID: 58648
	public readonly IReadOnlyList<FName> Duration;

	// Token: 0x0400E519 RID: 58649
	public readonly IReadOnlyList<FName> AttackRadius;

	// Token: 0x0400E51A RID: 58650
	public readonly IReadOnlyList<FName> AttackMagnitude;

	// Token: 0x0400E51B RID: 58651
	public readonly IReadOnlyList<FName> ActorLocation;

	// Token: 0x0400E51C RID: 58652
	public readonly IReadOnlyList<FName> CurveFloat;

	// Token: 0x0400E51D RID: 58653
	public readonly IReadOnlyList<FName> ElapsedTime;

	// Token: 0x0400E51E RID: 58654
	public readonly IReadOnlyList<FName> TextureHeight;
}

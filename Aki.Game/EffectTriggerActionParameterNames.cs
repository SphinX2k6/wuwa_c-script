using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020029DD RID: 10717
[NullableContext(1)]
[Nullable(0)]
public class EffectTriggerActionParameterNames
{
	// Token: 0x0601AEA4 RID: 110244 RVA: 0x00843F08 File Offset: 0x00842108
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

	// Token: 0x0400E9CF RID: 59855
	public readonly IReadOnlyList<FName> Trigger;

	// Token: 0x0400E9D0 RID: 59856
	public readonly IReadOnlyList<FName> Duration;

	// Token: 0x0400E9D1 RID: 59857
	public readonly IReadOnlyList<FName> AttackRadius;

	// Token: 0x0400E9D2 RID: 59858
	public readonly IReadOnlyList<FName> AttackMagnitude;

	// Token: 0x0400E9D3 RID: 59859
	public readonly IReadOnlyList<FName> ActorLocation;

	// Token: 0x0400E9D4 RID: 59860
	public readonly IReadOnlyList<FName> CurveFloat;

	// Token: 0x0400E9D5 RID: 59861
	public readonly IReadOnlyList<FName> ElapsedTime;

	// Token: 0x0400E9D6 RID: 59862
	public readonly IReadOnlyList<FName> TextureHeight;
}

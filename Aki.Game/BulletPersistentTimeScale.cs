using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002E16 RID: 11798
[NullableContext(2)]
[Nullable(0)]
public class BulletPersistentTimeScale
{
	// Token: 0x06018D52 RID: 101714 RVA: 0x0065E9C8 File Offset: 0x0065CBC8
	public BulletPersistentTimeScale(Vector centerLocation, float radius, float startTime, int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, int timeScaleId)
	{
		this.CenterLocation = centerLocation;
		this.Radius = radius;
		this.StartTime = startTime;
		this.Priority = priority;
		this.TimeDilation = timeDilation;
		this.Curve = curve;
		this.Duration = duration;
		this.SourceType = sourceType;
		this.TimeScaleId = timeScaleId;
	}

	// Token: 0x0400BA29 RID: 47657
	public readonly Vector CenterLocation;

	// Token: 0x0400BA2A RID: 47658
	public readonly float Radius;

	// Token: 0x0400BA2B RID: 47659
	public readonly float StartTime;

	// Token: 0x0400BA2C RID: 47660
	public readonly int Priority;

	// Token: 0x0400BA2D RID: 47661
	public readonly float TimeDilation;

	// Token: 0x0400BA2E RID: 47662
	public readonly UCurveFloat Curve;

	// Token: 0x0400BA2F RID: 47663
	public readonly float Duration;

	// Token: 0x0400BA30 RID: 47664
	public readonly ETimeScaleSourceType SourceType;

	// Token: 0x0400BA31 RID: 47665
	public readonly int TimeScaleId;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002372 RID: 9074
[NullableContext(2)]
[Nullable(0)]
public class BulletPersistentTimeScale
{
	// Token: 0x06016614 RID: 91668 RVA: 0x00684B50 File Offset: 0x00682D50
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

	// Token: 0x0400BDB7 RID: 48567
	public readonly Vector CenterLocation;

	// Token: 0x0400BDB8 RID: 48568
	public readonly float Radius;

	// Token: 0x0400BDB9 RID: 48569
	public readonly float StartTime;

	// Token: 0x0400BDBA RID: 48570
	public readonly int Priority;

	// Token: 0x0400BDBB RID: 48571
	public readonly float TimeDilation;

	// Token: 0x0400BDBC RID: 48572
	public readonly UCurveFloat Curve;

	// Token: 0x0400BDBD RID: 48573
	public readonly float Duration;

	// Token: 0x0400BDBE RID: 48574
	public readonly ETimeScaleSourceType SourceType;

	// Token: 0x0400BDBF RID: 48575
	public readonly int TimeScaleId;
}

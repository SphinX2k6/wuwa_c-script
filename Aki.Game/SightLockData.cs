using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003049 RID: 12361
[NullableContext(1)]
[Nullable(0)]
public class SightLockData
{
	// Token: 0x0601A3E6 RID: 107494 RVA: 0x006EBBEB File Offset: 0x006E9DEB
	public SightLockData(float[] clampYawLimit, float[] clampPitchLimit, float[] pitchLimit, float[] yawLimit, float assistLimit, FVector sightDirectInSightBone, FVector upAxisInSightBone)
	{
		this.ClampYawLimit = clampYawLimit;
		this.ClampPitchLimit = clampPitchLimit;
		this.PitchLimit = pitchLimit;
		this.YawLimit = yawLimit;
		this.AssistLimit = assistLimit;
		this.SightDirectInSightBone = sightDirectInSightBone;
		this.UpAxisInSightBone = upAxisInSightBone;
	}

	// Token: 0x0400C7C1 RID: 51137
	public readonly float[] ClampYawLimit;

	// Token: 0x0400C7C2 RID: 51138
	public readonly float[] ClampPitchLimit;

	// Token: 0x0400C7C3 RID: 51139
	public readonly float[] PitchLimit;

	// Token: 0x0400C7C4 RID: 51140
	public readonly float[] YawLimit;

	// Token: 0x0400C7C5 RID: 51141
	public readonly float AssistLimit;

	// Token: 0x0400C7C6 RID: 51142
	public readonly FVector SightDirectInSightBone;

	// Token: 0x0400C7C7 RID: 51143
	public readonly FVector UpAxisInSightBone;
}

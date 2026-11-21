using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200259F RID: 9631
[NullableContext(1)]
[Nullable(0)]
public class SightLockData
{
	// Token: 0x06017D66 RID: 97638 RVA: 0x007132D3 File Offset: 0x007114D3
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

	// Token: 0x0400CB9B RID: 52123
	public readonly float[] ClampYawLimit;

	// Token: 0x0400CB9C RID: 52124
	public readonly float[] ClampPitchLimit;

	// Token: 0x0400CB9D RID: 52125
	public readonly float[] PitchLimit;

	// Token: 0x0400CB9E RID: 52126
	public readonly float[] YawLimit;

	// Token: 0x0400CB9F RID: 52127
	public readonly float AssistLimit;

	// Token: 0x0400CBA0 RID: 52128
	public readonly FVector SightDirectInSightBone;

	// Token: 0x0400CBA1 RID: 52129
	public readonly FVector UpAxisInSightBone;
}

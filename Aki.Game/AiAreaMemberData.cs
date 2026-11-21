using System;
using System.Runtime.CompilerServices;

// Token: 0x020000FF RID: 255
[NullableContext(1)]
[Nullable(0)]
public class AiAreaMemberData
{
	// Token: 0x06000EF4 RID: 3828 RVA: 0x00057C2E File Offset: 0x00055E2E
	public AiAreaMemberData(AiScheduleGroup group)
	{
		this.Group = group;
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00057C4F File Offset: 0x00055E4F
	public AiScheduleGroup Group { get; }

	// Token: 0x04000BDF RID: 3039
	public int AreaIndex = -1;

	// Token: 0x04000BE0 RID: 3040
	public bool InZone;

	// Token: 0x04000BE1 RID: 3041
	public float AngleCenter;

	// Token: 0x04000BE2 RID: 3042
	public float MaxAngleOffset;

	// Token: 0x04000BE3 RID: 3043
	public float DistanceCenter;

	// Token: 0x04000BE4 RID: 3044
	public float MaxDistanceOffset;

	// Token: 0x04000BE5 RID: 3045
	public float NextUpdateCenterTime;

	// Token: 0x04000BE6 RID: 3046
	public Vector CachedTargetLocation = Vector.Create();

	// Token: 0x04000BE7 RID: 3047
	public float CachedControllerYaw;

	// Token: 0x04000BE8 RID: 3048
	public bool IsAttacker;

	// Token: 0x04000BE9 RID: 3049
	public bool HasAttack;

	// Token: 0x04000BEA RID: 3050
	public double NextScheduleTimeNoAttack;

	// Token: 0x04000BEB RID: 3051
	public double NextScheduleTimeAttack;

	// Token: 0x04000BEC RID: 3052
	public double NextScheduleTimeOut;

	// Token: 0x04000BED RID: 3053
	public double? NextScheduleTimeBeAttack;
}

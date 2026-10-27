using System;
using System.Runtime.CompilerServices;

// Token: 0x020000FF RID: 255
[NullableContext(1)]
[Nullable(0)]
public class AiAreaMemberData
{
	// Token: 0x06000EEE RID: 3822 RVA: 0x00056D5E File Offset: 0x00054F5E
	public AiAreaMemberData(AiScheduleGroup group)
	{
		this.Group = group;
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00056D7F File Offset: 0x00054F7F
	public AiScheduleGroup Group { get; }

	// Token: 0x04000BD7 RID: 3031
	public int AreaIndex = -1;

	// Token: 0x04000BD8 RID: 3032
	public bool InZone;

	// Token: 0x04000BD9 RID: 3033
	public float AngleCenter;

	// Token: 0x04000BDA RID: 3034
	public float MaxAngleOffset;

	// Token: 0x04000BDB RID: 3035
	public float DistanceCenter;

	// Token: 0x04000BDC RID: 3036
	public float MaxDistanceOffset;

	// Token: 0x04000BDD RID: 3037
	public float NextUpdateCenterTime;

	// Token: 0x04000BDE RID: 3038
	public Vector CachedTargetLocation = Vector.Create();

	// Token: 0x04000BDF RID: 3039
	public float CachedControllerYaw;

	// Token: 0x04000BE0 RID: 3040
	public bool IsAttacker;

	// Token: 0x04000BE1 RID: 3041
	public bool HasAttack;

	// Token: 0x04000BE2 RID: 3042
	public double NextScheduleTimeNoAttack;

	// Token: 0x04000BE3 RID: 3043
	public double NextScheduleTimeAttack;

	// Token: 0x04000BE4 RID: 3044
	public double NextScheduleTimeOut;

	// Token: 0x04000BE5 RID: 3045
	public double? NextScheduleTimeBeAttack;
}

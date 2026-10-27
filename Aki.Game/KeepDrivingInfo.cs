using System;
using System.Runtime.CompilerServices;

// Token: 0x020032F1 RID: 13041
[NullableContext(1)]
[Nullable(0)]
public abstract class KeepDrivingInfo
{
	// Token: 0x0601C62F RID: 116271
	public abstract bool UpdateDrivingInfo(float delta, VehicleMoveComponent moveComp);

	// Token: 0x0601C630 RID: 116272
	public abstract override string ToString();

	// Token: 0x0400E12A RID: 57642
	[Nullable(2)]
	public Func<bool> CheckCondition;

	// Token: 0x0400E12B RID: 57643
	[Nullable(2)]
	public Action RunAction;
}

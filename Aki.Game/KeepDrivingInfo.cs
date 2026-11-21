using System;
using System.Runtime.CompilerServices;

// Token: 0x02002863 RID: 10339
[NullableContext(1)]
[Nullable(0)]
public abstract class KeepDrivingInfo
{
	// Token: 0x0601A2F4 RID: 107252
	public abstract bool UpdateDrivingInfo(float delta, VehicleMoveComponent moveComp);

	// Token: 0x0601A2F5 RID: 107253
	public abstract override string ToString();

	// Token: 0x0400E5D5 RID: 58837
	[Nullable(2)]
	public Func<bool> CheckCondition;

	// Token: 0x0400E5D6 RID: 58838
	[Nullable(2)]
	public Action RunAction;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001327 RID: 4903
[NullableContext(1)]
[Nullable(0)]
public class Binding : HoldingHandsRelation
{
	// Token: 0x04006E94 RID: 28308
	[Nullable(2)]
	public HandRuntime LeaderRuntime;

	// Token: 0x04006E95 RID: 28309
	[Nullable(2)]
	public HandRuntime FollowerRuntime;

	// Token: 0x04006E96 RID: 28310
	public EBindingState State;

	// Token: 0x04006E97 RID: 28311
	public double BindDirDamping = 100.0;

	// Token: 0x04006E98 RID: 28312
	public bool Updated;

	// Token: 0x04006E99 RID: 28313
	public bool Reachable;

	// Token: 0x04006E9A RID: 28314
	public bool LastReachable;

	// Token: 0x04006E9B RID: 28315
	public double ReachableTime;

	// Token: 0x04006E9C RID: 28316
	public double UnReachableTime;

	// Token: 0x04006E9D RID: 28317
	public double ToReachableDistance;

	// Token: 0x04006E9E RID: 28318
	public bool NoLerpNextUpdate;

	// Token: 0x04006E9F RID: 28319
	public Vector Down = Vector.Create();

	// Token: 0x04006EA0 RID: 28320
	public Vector ShoulderDelta = Vector.Create();

	// Token: 0x04006EA1 RID: 28321
	public Vector ShoulderDeltaUnit = Vector.Create();

	// Token: 0x04006EA2 RID: 28322
	public Vector FoShoulderToLeAnimBindPos = Vector.Create();

	// Token: 0x04006EA3 RID: 28323
	public Vector BindPosDelta = Vector.Create();
}

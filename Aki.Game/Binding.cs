using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E65 RID: 7781
[NullableContext(1)]
[Nullable(0)]
public class Binding : HoldingHandsRelation
{
	// Token: 0x04006DB3 RID: 28083
	[Nullable(2)]
	public HandRuntime LeaderRuntime;

	// Token: 0x04006DB4 RID: 28084
	[Nullable(2)]
	public HandRuntime FollowerRuntime;

	// Token: 0x04006DB5 RID: 28085
	public EBindingState State;

	// Token: 0x04006DB6 RID: 28086
	public double BindDirDamping = 100.0;

	// Token: 0x04006DB7 RID: 28087
	public bool Updated;

	// Token: 0x04006DB8 RID: 28088
	public bool Reachable;

	// Token: 0x04006DB9 RID: 28089
	public bool LastReachable;

	// Token: 0x04006DBA RID: 28090
	public double ReachableTime;

	// Token: 0x04006DBB RID: 28091
	public double UnReachableTime;

	// Token: 0x04006DBC RID: 28092
	public double ToReachableDistance;

	// Token: 0x04006DBD RID: 28093
	public bool NoLerpNextUpdate;

	// Token: 0x04006DBE RID: 28094
	public Vector Down = Vector.Create();

	// Token: 0x04006DBF RID: 28095
	public Vector ShoulderDelta = Vector.Create();

	// Token: 0x04006DC0 RID: 28096
	public Vector ShoulderDeltaUnit = Vector.Create();

	// Token: 0x04006DC1 RID: 28097
	public Vector FoShoulderToLeAnimBindPos = Vector.Create();

	// Token: 0x04006DC2 RID: 28098
	public Vector BindPosDelta = Vector.Create();
}

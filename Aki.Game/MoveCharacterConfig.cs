using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02002643 RID: 9795
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class MoveCharacterConfig
{
	// Token: 0x06018797 RID: 100247 RVA: 0x00765B7C File Offset: 0x00763D7C
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MoveCharacterConfig()
	{
	}

	// Token: 0x0400D368 RID: 54120
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	[RequiredMember]
	public OneOf<MoveCharacterPoint, IList<MoveCharacterPoint>> Points;

	// Token: 0x0400D369 RID: 54121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public MoveCharacterPoint[] PointsArray;

	// Token: 0x0400D36A RID: 54122
	[RequiredMember]
	public bool Navigation;

	// Token: 0x0400D36B RID: 54123
	[RequiredMember]
	public bool ReturnFalseWhenNavigationFailed;

	// Token: 0x0400D36C RID: 54124
	public bool? StrictNavigation;

	// Token: 0x0400D36D RID: 54125
	[RequiredMember]
	public bool IsFly;

	// Token: 0x0400D36E RID: 54126
	[RequiredMember]
	public bool DebugMode;

	// Token: 0x0400D36F RID: 54127
	[RequiredMember]
	public bool Loop;

	// Token: 0x0400D370 RID: 54128
	public bool? CircleMove;

	// Token: 0x0400D371 RID: 54129
	public Action<ELevelEventState> Callback;

	// Token: 0x0400D372 RID: 54130
	public bool? UsePreviousIndex;

	// Token: 0x0400D373 RID: 54131
	public bool? UseNearestPoint;

	// Token: 0x0400D374 RID: 54132
	public float? TurnSpeed;

	// Token: 0x0400D375 RID: 54133
	public float? Distance;

	// Token: 0x0400D376 RID: 54134
	public bool? StartWithInversePath;

	// Token: 0x0400D377 RID: 54135
	public float? ReturnTimeoutFailed;

	// Token: 0x0400D378 RID: 54136
	public int? StartIndex;

	// Token: 0x0400D379 RID: 54137
	public bool? NavigateToStartPos;

	// Token: 0x0400D37A RID: 54138
	public bool? ResetAllPoints;

	// Token: 0x0400D37B RID: 54139
	public bool? EndDistanceAllPoints;

	// Token: 0x0400D37C RID: 54140
	public bool? NoAsyncPoint;

	// Token: 0x0400D37D RID: 54141
	public bool? EnablePlayerAccurateMoveToTarget;

	// Token: 0x0400D37E RID: 54142
	public Action OnResetLocationCallback;
}

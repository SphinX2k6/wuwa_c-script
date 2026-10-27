using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x020030EB RID: 12523
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class MoveCharacterConfig
{
	// Token: 0x0601AD78 RID: 109944 RVA: 0x00740190 File Offset: 0x0073E390
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MoveCharacterConfig()
	{
	}

	// Token: 0x0400CF78 RID: 53112
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	[RequiredMember]
	public OneOf<MoveCharacterPoint, IList<MoveCharacterPoint>> Points;

	// Token: 0x0400CF79 RID: 53113
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public MoveCharacterPoint[] PointsArray;

	// Token: 0x0400CF7A RID: 53114
	[RequiredMember]
	public bool Navigation;

	// Token: 0x0400CF7B RID: 53115
	[RequiredMember]
	public bool ReturnFalseWhenNavigationFailed;

	// Token: 0x0400CF7C RID: 53116
	public bool? StrictNavigation;

	// Token: 0x0400CF7D RID: 53117
	[RequiredMember]
	public bool IsFly;

	// Token: 0x0400CF7E RID: 53118
	[RequiredMember]
	public bool DebugMode;

	// Token: 0x0400CF7F RID: 53119
	[RequiredMember]
	public bool Loop;

	// Token: 0x0400CF80 RID: 53120
	public bool? CircleMove;

	// Token: 0x0400CF81 RID: 53121
	public Action<ELevelEventState> Callback;

	// Token: 0x0400CF82 RID: 53122
	public bool? UsePreviousIndex;

	// Token: 0x0400CF83 RID: 53123
	public bool? UseNearestPoint;

	// Token: 0x0400CF84 RID: 53124
	public float? TurnSpeed;

	// Token: 0x0400CF85 RID: 53125
	public float? Distance;

	// Token: 0x0400CF86 RID: 53126
	public bool? StartWithInversePath;

	// Token: 0x0400CF87 RID: 53127
	public float? ReturnTimeoutFailed;

	// Token: 0x0400CF88 RID: 53128
	public int? StartIndex;

	// Token: 0x0400CF89 RID: 53129
	public bool? NavigateToStartPos;

	// Token: 0x0400CF8A RID: 53130
	public bool? ResetAllPoints;

	// Token: 0x0400CF8B RID: 53131
	public bool? NoAsyncPoint;

	// Token: 0x0400CF8C RID: 53132
	public bool? EnablePlayerAccurateMoveToTarget;

	// Token: 0x0400CF8D RID: 53133
	public Action OnResetLocationCallback;
}

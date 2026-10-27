using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

// Token: 0x020030EC RID: 12524
[RequiredMember]
public class MoveCharacterPoint
{
	// Token: 0x0601AD79 RID: 109945 RVA: 0x00740198 File Offset: 0x0073E398
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MoveCharacterPoint()
	{
	}

	// Token: 0x0400CF8E RID: 53134
	[RequiredMember]
	public int Index;

	// Token: 0x0400CF8F RID: 53135
	[Nullable(1)]
	[RequiredMember]
	public Vector Position;

	// Token: 0x0400CF90 RID: 53136
	[Nullable(2)]
	public Action Callback;

	// Token: 0x0400CF91 RID: 53137
	public EPatrolMoveState? MoveState;

	// Token: 0x0400CF92 RID: 53138
	public ECharPositionState? PosState;

	// Token: 0x0400CF93 RID: 53139
	public float? MoveSpeed;

	// Token: 0x0400CF94 RID: 53140
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ActionInfo> Actions;

	// Token: 0x0400CF95 RID: 53141
	public bool? IsHide;
}

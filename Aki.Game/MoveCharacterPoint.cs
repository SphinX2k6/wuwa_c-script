using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

// Token: 0x02002644 RID: 9796
[RequiredMember]
public class MoveCharacterPoint
{
	// Token: 0x06018798 RID: 100248 RVA: 0x00765B84 File Offset: 0x00763D84
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MoveCharacterPoint()
	{
	}

	// Token: 0x0400D37F RID: 54143
	[RequiredMember]
	public int Index;

	// Token: 0x0400D380 RID: 54144
	[Nullable(1)]
	[RequiredMember]
	public Vector Position;

	// Token: 0x0400D381 RID: 54145
	[Nullable(2)]
	public Action Callback;

	// Token: 0x0400D382 RID: 54146
	public EPatrolMoveState? MoveState;

	// Token: 0x0400D383 RID: 54147
	public ECharPositionState? PosState;

	// Token: 0x0400D384 RID: 54148
	public float? MoveSpeed;

	// Token: 0x0400D385 RID: 54149
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ActionInfo> Actions;

	// Token: 0x0400D386 RID: 54150
	public bool? IsHide;
}

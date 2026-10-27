using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x020030F1 RID: 12529
[NullableContext(2)]
[Nullable(0)]
public class PatrolRecord
{
	// Token: 0x0601AD95 RID: 109973 RVA: 0x00740F37 File Offset: 0x0073F137
	[NullableContext(1)]
	public PatrolRecord(IPatrolParams config)
	{
		this.OnArrivePointHandle = config.OnArrivePointHandle;
		this.OnTriggerActionsHandle = config.OnTriggerActionsHandle;
		this.OnPatrolEndHandle = config.OnPatrolEndHandle;
		this.OnResetLocationCallback = config.OnResetLocationCallback;
	}

	// Token: 0x0400CFBD RID: 53181
	public bool IsActive;

	// Token: 0x0400CFBE RID: 53182
	public EPatrolState PatrolState;

	// Token: 0x0400CFBF RID: 53183
	public int LastPointIndex = -1;

	// Token: 0x0400CFC0 RID: 53184
	public Action<int> OnArrivePointHandle;

	// Token: 0x0400CFC1 RID: 53185
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<IList<ActionInfo>> OnTriggerActionsHandle;

	// Token: 0x0400CFC2 RID: 53186
	public Action<ELevelEventState> OnPatrolEndHandle;

	// Token: 0x0400CFC3 RID: 53187
	public Action OnResetLocationCallback;
}

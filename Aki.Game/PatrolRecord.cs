using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02002649 RID: 9801
[NullableContext(2)]
[Nullable(0)]
public class PatrolRecord
{
	// Token: 0x060187B6 RID: 100278 RVA: 0x007668DB File Offset: 0x00764ADB
	[NullableContext(1)]
	public PatrolRecord(IPatrolParams config)
	{
		this.OnArrivePointHandle = config.OnArrivePointHandle;
		this.OnTriggerActionsHandle = config.OnTriggerActionsHandle;
		this.OnPatrolEndHandle = config.OnPatrolEndHandle;
		this.OnResetLocationCallback = config.OnResetLocationCallback;
	}

	// Token: 0x0400D3AE RID: 54190
	public bool IsActive;

	// Token: 0x0400D3AF RID: 54191
	public EPatrolState PatrolState;

	// Token: 0x0400D3B0 RID: 54192
	public int LastPointIndex = -1;

	// Token: 0x0400D3B1 RID: 54193
	public Action<int> OnArrivePointHandle;

	// Token: 0x0400D3B2 RID: 54194
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<IList<ActionInfo>> OnTriggerActionsHandle;

	// Token: 0x0400D3B3 RID: 54195
	public Action<ELevelEventState> OnPatrolEndHandle;

	// Token: 0x0400D3B4 RID: 54196
	public Action OnResetLocationCallback;
}

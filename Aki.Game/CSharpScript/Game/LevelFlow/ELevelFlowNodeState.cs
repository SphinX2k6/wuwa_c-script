using System;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x020060E8 RID: 24808
	public enum ELevelFlowNodeState
	{
		// Token: 0x0401F5D1 RID: 128465
		Idle,
		// Token: 0x0401F5D2 RID: 128466
		WaitingCondition,
		// Token: 0x0401F5D3 RID: 128467
		RunningAction,
		// Token: 0x0401F5D4 RID: 128468
		Success,
		// Token: 0x0401F5D5 RID: 128469
		Failure
	}
}

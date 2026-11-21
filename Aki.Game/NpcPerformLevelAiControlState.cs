using System;
using System.Runtime.CompilerServices;

// Token: 0x02002796 RID: 10134
public class NpcPerformLevelAiControlState : NpcPerformBaseState
{
	// Token: 0x0601967F RID: 104063 RVA: 0x007C51E6 File Offset: 0x007C33E6
	[NullableContext(1)]
	public NpcPerformLevelAiControlState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}
}

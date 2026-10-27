using System;
using System.Runtime.CompilerServices;

// Token: 0x02003227 RID: 12839
public class NpcPerformLevelAiControlState : NpcPerformBaseState
{
	// Token: 0x0601BAFA RID: 113402 RVA: 0x0079CA4A File Offset: 0x0079AC4A
	[NullableContext(1)]
	public NpcPerformLevelAiControlState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}
}

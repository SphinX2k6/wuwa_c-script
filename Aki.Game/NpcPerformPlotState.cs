using System;
using System.Runtime.CompilerServices;

// Token: 0x02002798 RID: 10136
public class NpcPerformPlotState : NpcPerformBaseState
{
	// Token: 0x06019687 RID: 104071 RVA: 0x007C539E File Offset: 0x007C359E
	[NullableContext(1)]
	public NpcPerformPlotState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}
}

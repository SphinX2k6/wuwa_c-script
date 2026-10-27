using System;
using System.Runtime.CompilerServices;

// Token: 0x02003229 RID: 12841
public class NpcPerformPlotState : NpcPerformBaseState
{
	// Token: 0x0601BB02 RID: 113410 RVA: 0x0079CC02 File Offset: 0x0079AE02
	[NullableContext(1)]
	public NpcPerformPlotState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}
}

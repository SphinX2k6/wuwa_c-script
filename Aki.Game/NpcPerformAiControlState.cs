using System;
using System.Runtime.CompilerServices;

// Token: 0x0200278D RID: 10125
public class NpcPerformAiControlState : NpcPerformBaseState
{
	// Token: 0x0601961D RID: 103965 RVA: 0x007C2B32 File Offset: 0x007C0D32
	[NullableContext(1)]
	public NpcPerformAiControlState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}
}

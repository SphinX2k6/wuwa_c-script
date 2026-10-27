using System;
using System.Runtime.CompilerServices;

// Token: 0x0200321E RID: 12830
public class NpcPerformAiControlState : NpcPerformBaseState
{
	// Token: 0x0601BA98 RID: 113304 RVA: 0x0079A396 File Offset: 0x00798596
	[NullableContext(1)]
	public NpcPerformAiControlState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02004611 RID: 17937
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ExecutingState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x0602E3B0 RID: 189360 RVA: 0x00AB0CAE File Offset: 0x00AAEEAE
		public ExecutingState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E3B1 RID: 189361 RVA: 0x00AB0CB9 File Offset: 0x00AAEEB9
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			this.Owner.PumpStep();
		}
	}
}

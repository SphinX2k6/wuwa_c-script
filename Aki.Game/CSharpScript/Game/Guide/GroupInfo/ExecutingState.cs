using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x0200353A RID: 13626
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ExecutingState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x06022AA5 RID: 141989 RVA: 0x009DD3A2 File Offset: 0x009DB5A2
		public ExecutingState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022AA6 RID: 141990 RVA: 0x009DD3AD File Offset: 0x009DB5AD
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			this.Owner.PumpStep();
		}
	}
}

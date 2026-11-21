using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x0200352F RID: 13615
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class InitState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x06022A76 RID: 141942 RVA: 0x009DC1D7 File Offset: 0x009DA3D7
		public InitState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}
	}
}

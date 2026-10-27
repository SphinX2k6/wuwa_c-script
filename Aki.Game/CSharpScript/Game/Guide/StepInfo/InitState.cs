using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02004606 RID: 17926
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class InitState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x0602E381 RID: 189313 RVA: 0x00AAFAE3 File Offset: 0x00AADCE3
		public InitState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}
	}
}

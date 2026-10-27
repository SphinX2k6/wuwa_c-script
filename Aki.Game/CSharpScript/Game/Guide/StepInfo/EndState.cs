using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x0200460B RID: 17931
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EndState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x0602E395 RID: 189333 RVA: 0x00AB00E0 File Offset: 0x00AAE2E0
		public EndState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E396 RID: 189334 RVA: 0x00AB00EC File Offset: 0x00AAE2EC
		protected override void OnEnter(EGuideStepState? lastState)
		{
			if (this.Owner.Config.ContentType == 4)
			{
				GuideModel.Instance.RemoveFocusGuideGroupFromView(this.Owner.OwnerGroup);
			}
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x0200460A RID: 17930
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class FinishState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x0602E393 RID: 189331 RVA: 0x00AB008C File Offset: 0x00AAE28C
		public FinishState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E394 RID: 189332 RVA: 0x00AB0098 File Offset: 0x00AAE298
		protected override void OnEnter(EGuideStepState? lastState)
		{
			if (this.Owner.Config.ContentType == 4)
			{
				GuideModel.Instance.RemoveFocusGuideGroupFromView(this.Owner.OwnerGroup);
			}
			this.Owner.OwnerGroup.PumpStep();
		}
	}
}

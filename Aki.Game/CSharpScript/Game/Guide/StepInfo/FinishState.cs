using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02003533 RID: 13619
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class FinishState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x06022A88 RID: 141960 RVA: 0x009DC780 File Offset: 0x009DA980
		public FinishState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022A89 RID: 141961 RVA: 0x009DC78C File Offset: 0x009DA98C
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

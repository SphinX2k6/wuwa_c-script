using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02003534 RID: 13620
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EndState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x06022A8A RID: 141962 RVA: 0x009DC7D4 File Offset: 0x009DA9D4
		public EndState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022A8B RID: 141963 RVA: 0x009DC7E0 File Offset: 0x009DA9E0
		protected override void OnEnter(EGuideStepState? lastState)
		{
			if (this.Owner.Config.ContentType == 4)
			{
				GuideModel.Instance.RemoveFocusGuideGroupFromView(this.Owner.OwnerGroup);
			}
		}
	}
}

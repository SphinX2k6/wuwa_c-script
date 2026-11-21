using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02003532 RID: 13618
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BreakState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x06022A86 RID: 141958 RVA: 0x009DC72D File Offset: 0x009DA92D
		public BreakState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022A87 RID: 141959 RVA: 0x009DC738 File Offset: 0x009DA938
		protected override void OnEnter(EGuideStepState? lastState)
		{
			if (this.Owner.Config.ContentType == 4)
			{
				GuideModel.Instance.RemoveFocusGuideGroupFromView(this.Owner.OwnerGroup);
			}
			this.Owner.OwnerGroup.Break();
		}
	}
}

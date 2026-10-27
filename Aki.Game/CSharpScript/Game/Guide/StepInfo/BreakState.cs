using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02004609 RID: 17929
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BreakState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x0602E391 RID: 189329 RVA: 0x00AB0039 File Offset: 0x00AAE239
		public BreakState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E392 RID: 189330 RVA: 0x00AB0044 File Offset: 0x00AAE244
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

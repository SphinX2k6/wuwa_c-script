using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x0200353C RID: 13628
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FinishingState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x06022AAC RID: 141996 RVA: 0x009DD448 File Offset: 0x009DB648
		public FinishingState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022AAD RID: 141997 RVA: 0x009DD454 File Offset: 0x009DB654
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			bool isFake = this.Owner.IsFake;
			GuideController.Instance.FinishGuide(this.Owner.Id, isFake);
			if (this.Owner.FinishPromise != null)
			{
				this.Owner.FinishPromise.SetResult();
				this.Owner.FinishPromise = null;
			}
		}
	}
}

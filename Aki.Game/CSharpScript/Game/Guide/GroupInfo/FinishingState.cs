using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02004613 RID: 17939
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FinishingState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x0602E3B7 RID: 189367 RVA: 0x00AB0D54 File Offset: 0x00AAEF54
		public FinishingState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E3B8 RID: 189368 RVA: 0x00AB0D60 File Offset: 0x00AAEF60
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

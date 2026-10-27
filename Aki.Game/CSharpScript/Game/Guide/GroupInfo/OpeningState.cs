using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02004610 RID: 17936
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class OpeningState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x0602E3AD RID: 189357 RVA: 0x00AB0C0A File Offset: 0x00AAEE0A
		public OpeningState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E3AE RID: 189358 RVA: 0x00AB0C18 File Offset: 0x00AAEE18
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			if (this.Entered)
			{
				return;
			}
			this.Entered = true;
			if (this.Owner.FinishPromise != null)
			{
				this.Owner.FinishPromise.SetResult();
				this.Owner.FinishPromise = null;
			}
			this.Owner.FinishPromise = new CustomPromise();
			bool ifPreExecute = this.Owner.GetIfPreExecute();
			if (ifPreExecute)
			{
				this.Owner.SwitchState(EGuideGroupState.Executing);
			}
			EventSystem.Instance.Emit<int, bool>(EEventName.GuideGroupOpening, this.Owner.Id, ifPreExecute);
		}

		// Token: 0x0602E3AF RID: 189359 RVA: 0x00AB0CA5 File Offset: 0x00AAEEA5
		protected override void OnExit(EGuideGroupState nextState)
		{
			this.Entered = false;
		}

		// Token: 0x04018D18 RID: 101656
		private bool Entered;
	}
}

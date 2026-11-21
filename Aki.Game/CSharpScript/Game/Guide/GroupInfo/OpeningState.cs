using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02003539 RID: 13625
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class OpeningState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x06022AA2 RID: 141986 RVA: 0x009DD2FE File Offset: 0x009DB4FE
		public OpeningState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022AA3 RID: 141987 RVA: 0x009DD30C File Offset: 0x009DB50C
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

		// Token: 0x06022AA4 RID: 141988 RVA: 0x009DD399 File Offset: 0x009DB599
		protected override void OnExit(EGuideGroupState nextState)
		{
			this.Entered = false;
		}

		// Token: 0x04013357 RID: 78679
		private bool Entered;
	}
}

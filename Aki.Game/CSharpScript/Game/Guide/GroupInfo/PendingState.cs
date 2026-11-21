using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x0200353B RID: 13627
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PendingState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x06022AA7 RID: 141991 RVA: 0x009DD3BA File Offset: 0x009DB5BA
		public PendingState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022AA8 RID: 141992 RVA: 0x009DD3C5 File Offset: 0x009DB5C5
		private void ClearTimer()
		{
			if (this.CheckTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckTimer);
				this.CheckTimer = null;
			}
		}

		// Token: 0x06022AA9 RID: 141993 RVA: 0x009DD3E7 File Offset: 0x009DB5E7
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			this.ClearTimer();
			this.CheckTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				if (!this.Owner.CanEnterExecuting())
				{
					return;
				}
				this.ClearTimer();
				this.Owner.StateMachine.Switch(EGuideGroupState.Executing);
			}, 1000f, 1f, null, null, true);
		}

		// Token: 0x06022AAA RID: 141994 RVA: 0x009DD418 File Offset: 0x009DB618
		protected override void OnExit(EGuideGroupState nextState)
		{
			this.ClearTimer();
		}

		// Token: 0x04013358 RID: 78680
		[Nullable(2)]
		private TimerHandle CheckTimer;
	}
}

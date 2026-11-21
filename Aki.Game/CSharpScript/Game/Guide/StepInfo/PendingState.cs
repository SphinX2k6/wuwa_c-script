using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02003531 RID: 13617
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class PendingState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x06022A81 RID: 141953 RVA: 0x009DC69A File Offset: 0x009DA89A
		public PendingState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022A82 RID: 141954 RVA: 0x009DC6A5 File Offset: 0x009DA8A5
		private void ClearTimer()
		{
			if (this.CheckTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckTimer);
				this.CheckTimer = null;
			}
		}

		// Token: 0x06022A83 RID: 141955 RVA: 0x009DC6C7 File Offset: 0x009DA8C7
		protected override void OnEnter(EGuideStepState? lastState)
		{
			this.ClearTimer();
			this.CheckTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				if (!this.Owner.CanEnterExecuting())
				{
					return;
				}
				this.ClearTimer();
				this.Owner.SwitchState(EGuideStepState.Executing);
			}, 1000f, 1f, null, null, true);
		}

		// Token: 0x06022A84 RID: 141956 RVA: 0x009DC6F8 File Offset: 0x009DA8F8
		protected override void OnExit(EGuideStepState nextState)
		{
			this.Owner.StopLockInput();
			this.ClearTimer();
		}

		// Token: 0x04013344 RID: 78660
		[Nullable(2)]
		private TimerHandle CheckTimer;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02004608 RID: 17928
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class PendingState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x0602E38C RID: 189324 RVA: 0x00AAFFA6 File Offset: 0x00AAE1A6
		public PendingState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E38D RID: 189325 RVA: 0x00AAFFB1 File Offset: 0x00AAE1B1
		private void ClearTimer()
		{
			if (this.CheckTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckTimer);
				this.CheckTimer = null;
			}
		}

		// Token: 0x0602E38E RID: 189326 RVA: 0x00AAFFD3 File Offset: 0x00AAE1D3
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

		// Token: 0x0602E38F RID: 189327 RVA: 0x00AB0004 File Offset: 0x00AAE204
		protected override void OnExit(EGuideStepState nextState)
		{
			this.Owner.StopLockInput();
			this.ClearTimer();
		}

		// Token: 0x04018D05 RID: 101637
		[Nullable(2)]
		private TimerHandle CheckTimer;
	}
}

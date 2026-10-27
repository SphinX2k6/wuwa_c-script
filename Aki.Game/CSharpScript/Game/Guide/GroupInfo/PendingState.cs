using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02004612 RID: 17938
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PendingState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x0602E3B2 RID: 189362 RVA: 0x00AB0CC6 File Offset: 0x00AAEEC6
		public PendingState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E3B3 RID: 189363 RVA: 0x00AB0CD1 File Offset: 0x00AAEED1
		private void ClearTimer()
		{
			if (this.CheckTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckTimer);
				this.CheckTimer = null;
			}
		}

		// Token: 0x0602E3B4 RID: 189364 RVA: 0x00AB0CF3 File Offset: 0x00AAEEF3
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

		// Token: 0x0602E3B5 RID: 189365 RVA: 0x00AB0D24 File Offset: 0x00AAEF24
		protected override void OnExit(EGuideGroupState nextState)
		{
			this.ClearTimer();
		}

		// Token: 0x04018D19 RID: 101657
		[Nullable(2)]
		private TimerHandle CheckTimer;
	}
}

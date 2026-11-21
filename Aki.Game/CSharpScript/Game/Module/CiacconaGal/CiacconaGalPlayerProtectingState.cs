using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA4 RID: 19364
	internal class CiacconaGalPlayerProtectingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x06030598 RID: 198040 RVA: 0x00D7AC94 File Offset: 0x00D78E94
		[NullableContext(1)]
		public CiacconaGalPlayerProtectingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06030599 RID: 198041 RVA: 0x00D7ACA0 File Offset: 0x00D78EA0
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			float interval = CiacconaGalUtils.GetAvgCoolDownTime() * (float)TimeUtil.Instance.InverseMillisecond;
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				CiacconaGalPlayer owner = this.Owner;
				if (owner == null)
				{
					return;
				}
				owner.TrySwitchToState(ECiacconaGalPlayerState.Pausing);
			}, interval, null, null, true, 1f);
		}

		// Token: 0x0603059A RID: 198042 RVA: 0x00D7ACE6 File Offset: 0x00D78EE6
		public override void OnClick(int? id = null)
		{
		}
	}
}

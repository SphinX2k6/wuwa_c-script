using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA7 RID: 19367
	internal class CiacconaGalPlayerBeforeSubEndingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x060305A3 RID: 198051 RVA: 0x00D7AEA6 File Offset: 0x00D790A6
		[NullableContext(1)]
		public CiacconaGalPlayerBeforeSubEndingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x060305A4 RID: 198052 RVA: 0x00D7AEB4 File Offset: 0x00D790B4
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			float interval = CiacconaGalUtils.GetAvgSubEndingDelayTime() * (float)TimeUtil.Instance.InverseMillisecond;
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				CiacconaGalPlayer owner = this.Owner;
				if (owner == null)
				{
					return;
				}
				owner.TrySwitchToState(ECiacconaGalPlayerState.SubEnding);
			}, interval, null, null, true, 1f);
		}
	}
}

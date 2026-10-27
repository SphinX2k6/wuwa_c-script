using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC5 RID: 23493
	internal class CiacconaGalPlayerChoiceProtectingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B650 RID: 243280 RVA: 0x00E2AA07 File Offset: 0x00E28C07
		[NullableContext(1)]
		public CiacconaGalPlayerChoiceProtectingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B651 RID: 243281 RVA: 0x00E2AA14 File Offset: 0x00E28C14
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			float interval = CiacconaGalUtils.GetAvgChoiceProtectingTime() * (float)TimeUtil.Instance.InverseMillisecond;
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				CiacconaGalPlayer owner = this.Owner;
				if (owner == null)
				{
					return;
				}
				owner.TrySwitchToState(ECiacconaGalPlayerState.Choosing);
			}, interval, null, null, true, 1f);
		}

		// Token: 0x0603B652 RID: 243282 RVA: 0x00E2AA5A File Offset: 0x00E28C5A
		public override void OnClick(int? id = null)
		{
		}
	}
}

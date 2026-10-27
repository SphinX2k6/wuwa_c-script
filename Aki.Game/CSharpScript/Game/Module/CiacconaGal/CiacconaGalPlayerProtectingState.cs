using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC4 RID: 23492
	internal class CiacconaGalPlayerProtectingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B64C RID: 243276 RVA: 0x00E2A9A0 File Offset: 0x00E28BA0
		[NullableContext(1)]
		public CiacconaGalPlayerProtectingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B64D RID: 243277 RVA: 0x00E2A9AC File Offset: 0x00E28BAC
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

		// Token: 0x0603B64E RID: 243278 RVA: 0x00E2A9F2 File Offset: 0x00E28BF2
		public override void OnClick(int? id = null)
		{
		}
	}
}

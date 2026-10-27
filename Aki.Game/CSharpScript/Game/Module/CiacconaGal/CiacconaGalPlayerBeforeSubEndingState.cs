using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC7 RID: 23495
	internal class CiacconaGalPlayerBeforeSubEndingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B657 RID: 243287 RVA: 0x00E2ABB2 File Offset: 0x00E28DB2
		[NullableContext(1)]
		public CiacconaGalPlayerBeforeSubEndingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B658 RID: 243288 RVA: 0x00E2ABC0 File Offset: 0x00E28DC0
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

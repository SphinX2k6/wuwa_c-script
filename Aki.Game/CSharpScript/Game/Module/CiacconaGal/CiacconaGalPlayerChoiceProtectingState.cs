using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA5 RID: 19365
	internal class CiacconaGalPlayerChoiceProtectingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603059C RID: 198044 RVA: 0x00D7ACFB File Offset: 0x00D78EFB
		[NullableContext(1)]
		public CiacconaGalPlayerChoiceProtectingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603059D RID: 198045 RVA: 0x00D7AD08 File Offset: 0x00D78F08
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

		// Token: 0x0603059E RID: 198046 RVA: 0x00D7AD4E File Offset: 0x00D78F4E
		public override void OnClick(int? id = null)
		{
		}
	}
}

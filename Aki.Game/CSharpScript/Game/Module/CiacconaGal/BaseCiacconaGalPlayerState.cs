using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BBF RID: 23487
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BaseCiacconaGalPlayerState : StateBase<CiacconaGalPlayer, ECiacconaGalPlayerState>
	{
		// Token: 0x0603B63E RID: 243262 RVA: 0x00E2A8AD File Offset: 0x00E28AAD
		public BaseCiacconaGalPlayerState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B63F RID: 243263 RVA: 0x00E2A8B8 File Offset: 0x00E28AB8
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			this.Owner.ClearStatePendingToSwitchByState(this);
			this.Owner.NotifyStateChange(this.State);
		}

		// Token: 0x0603B640 RID: 243264 RVA: 0x00E2A8D7 File Offset: 0x00E28AD7
		public virtual void OnClick(int? id = null)
		{
		}
	}
}

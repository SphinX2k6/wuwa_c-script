using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004B9F RID: 19359
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BaseCiacconaGalPlayerState : StateBase<CiacconaGalPlayer, ECiacconaGalPlayerState>
	{
		// Token: 0x0603058A RID: 198026 RVA: 0x00D7ABA2 File Offset: 0x00D78DA2
		public BaseCiacconaGalPlayerState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603058B RID: 198027 RVA: 0x00D7ABAD File Offset: 0x00D78DAD
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			this.Owner.ClearStatePendingToSwitchByState(this);
			this.Owner.NotifyStateChange(this.State);
		}

		// Token: 0x0603058C RID: 198028 RVA: 0x00D7ABCC File Offset: 0x00D78DCC
		public virtual void OnClick(int? id = null)
		{
		}
	}
}

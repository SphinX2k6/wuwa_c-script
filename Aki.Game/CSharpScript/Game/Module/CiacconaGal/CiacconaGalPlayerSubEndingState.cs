using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC8 RID: 23496
	internal class CiacconaGalPlayerSubEndingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B65A RID: 243290 RVA: 0x00E2AC19 File Offset: 0x00E28E19
		[NullableContext(1)]
		public CiacconaGalPlayerSubEndingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B65B RID: 243291 RVA: 0x00E2AC24 File Offset: 0x00E28E24
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			CiacconaGalModel.Instance.IsCurStepDataListDirty = true;
		}
	}
}

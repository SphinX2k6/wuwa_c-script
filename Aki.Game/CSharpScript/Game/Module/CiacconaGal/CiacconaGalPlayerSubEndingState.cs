using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA8 RID: 19368
	internal class CiacconaGalPlayerSubEndingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x060305A6 RID: 198054 RVA: 0x00D7AF0D File Offset: 0x00D7910D
		[NullableContext(1)]
		public CiacconaGalPlayerSubEndingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x060305A7 RID: 198055 RVA: 0x00D7AF18 File Offset: 0x00D79118
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			CiacconaGalModel.Instance.IsCurStepDataListDirty = true;
		}
	}
}

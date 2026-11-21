using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA1 RID: 19361
	internal class CiacconaGalPlayerPausingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603058F RID: 198031 RVA: 0x00D7ABF7 File Offset: 0x00D78DF7
		[NullableContext(1)]
		public CiacconaGalPlayerPausingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06030590 RID: 198032 RVA: 0x00D7AC02 File Offset: 0x00D78E02
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
		}

		// Token: 0x06030591 RID: 198033 RVA: 0x00D7AC0C File Offset: 0x00D78E0C
		public override void OnClick(int? id = null)
		{
			CiacconaGalStepData stepDataById = CiacconaGalModel.Instance.GetStepDataById(this.Owner.CurHandlingStepId);
			if (stepDataById != null && stepDataById.Type == ECiacconaGalStepType.Normal)
			{
				this.Owner.TryContinue(stepDataById.NextStepId);
			}
		}
	}
}

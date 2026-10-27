using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC1 RID: 23489
	internal class CiacconaGalPlayerPausingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x0603B643 RID: 243267 RVA: 0x00E2A902 File Offset: 0x00E28B02
		[NullableContext(1)]
		public CiacconaGalPlayerPausingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603B644 RID: 243268 RVA: 0x00E2A90D File Offset: 0x00E28B0D
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
		}

		// Token: 0x0603B645 RID: 243269 RVA: 0x00E2A918 File Offset: 0x00E28B18
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

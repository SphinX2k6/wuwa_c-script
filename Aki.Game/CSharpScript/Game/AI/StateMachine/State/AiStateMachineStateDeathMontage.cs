using System;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter.StateMachine;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064AE RID: 25774
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDeathMontage : AiStateMachineState
	{
		// Token: 0x0603EA13 RID: 256531 RVA: 0x0123FB51 File Offset: 0x0123DD51
		public AiStateMachineStateDeathMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA14 RID: 256532 RVA: 0x0123FB70 File Offset: 0x0123DD70
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			BaseDeathComponent deathComponent = this.Node.DeathComponent;
			if (deathComponent == null)
			{
				return;
			}
			switch (this.DeathType)
			{
			case EMonsterDeathType.水中死亡:
				this.Handle = deathComponent.ReplaceDeathMontage(ECharacterDeathMontageType.DieInWater, this.MontageName);
				return;
			case EMonsterDeathType.空中死亡:
				this.Handle = deathComponent.ReplaceDeathMontage(ECharacterDeathMontageType.DieInAir, this.MontageName);
				return;
			}
			this.Handle = deathComponent.ReplaceDeathMontage(ECharacterDeathMontageType.Die, this.MontageName);
		}

		// Token: 0x0603EA15 RID: 256533 RVA: 0x0123FBE3 File Offset: 0x0123DDE3
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			BaseDeathComponent deathComponent = this.Node.DeathComponent;
			if (deathComponent != null)
			{
				deathComponent.ResetDeathMontage(this.Handle);
			}
			this.Handle = -1;
		}

		// Token: 0x0603EA16 RID: 256534 RVA: 0x0123FC08 File Offset: 0x0123DE08
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.DeathType = (EMonsterDeathType)state.BindDeathMontage.DeathType;
			this.MontageName = state.BindDeathMontage.MontageName;
			return true;
		}

		// Token: 0x0603EA17 RID: 256535 RVA: 0x0123FC2E File Offset: 0x0123DE2E
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402171B RID: 136987
		public EMonsterDeathType DeathType;

		// Token: 0x0402171C RID: 136988
		public string MontageName = "";

		// Token: 0x0402171D RID: 136989
		public int Handle = -1;
	}
}

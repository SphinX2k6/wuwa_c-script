using System;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter.StateMachine;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x0200732B RID: 29483
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateDeathMontage : AiStateMachineState
	{
		// Token: 0x060485C6 RID: 296390 RVA: 0x0129D0D1 File Offset: 0x0129B2D1
		public AiStateMachineStateDeathMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485C7 RID: 296391 RVA: 0x0129D0F0 File Offset: 0x0129B2F0
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

		// Token: 0x060485C8 RID: 296392 RVA: 0x0129D163 File Offset: 0x0129B363
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

		// Token: 0x060485C9 RID: 296393 RVA: 0x0129D188 File Offset: 0x0129B388
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.DeathType = (EMonsterDeathType)state.BindDeathMontage.DeathType;
			this.MontageName = state.BindDeathMontage.MontageName;
			return true;
		}

		// Token: 0x060485CA RID: 296394 RVA: 0x0129D1AE File Offset: 0x0129B3AE
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402642E RID: 156718
		public EMonsterDeathType DeathType;

		// Token: 0x0402642F RID: 156719
		public string MontageName = "";

		// Token: 0x04026430 RID: 156720
		public int Handle = -1;
	}
}

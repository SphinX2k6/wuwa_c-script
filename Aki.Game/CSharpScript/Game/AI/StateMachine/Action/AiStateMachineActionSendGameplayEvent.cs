using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064DB RID: 25819
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionSendGameplayEvent : AiStateMachineAction
	{
		// Token: 0x0603EB0F RID: 256783 RVA: 0x01243A10 File Offset: 0x01241C10
		public AiStateMachineActionSendGameplayEvent(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB10 RID: 256784 RVA: 0x01243A1C File Offset: 0x01241C1C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			CombatStateMachineDefine.Fsm.ActionSendGameplayEvent actionSendGameplayEvent = action.ActionSendGameplayEvent;
			this.TagId = ((actionSendGameplayEvent != null) ? new int?(actionSendGameplayEvent.TagId) : null);
			return true;
		}

		// Token: 0x0603EB11 RID: 256785 RVA: 0x01243A50 File Offset: 0x01241C50
		public override void DoAction(long? contextId = null)
		{
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(this.TagId.GetValueOrDefault());
			if (gameplayTagById == null)
			{
				return;
			}
			AiStateMachineBase node = this.Node;
			if (node == null)
			{
				return;
			}
			BaseAbilityComponent abilityComponent = node.AbilityComponent;
			if (abilityComponent == null)
			{
				return;
			}
			abilityComponent.SendGameplayEventToActor(gameplayTagById.Value, null);
		}

		// Token: 0x0603EB12 RID: 256786 RVA: 0x01243A9A File Offset: 0x01241C9A
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021772 RID: 137074
		private int? TagId;
	}
}

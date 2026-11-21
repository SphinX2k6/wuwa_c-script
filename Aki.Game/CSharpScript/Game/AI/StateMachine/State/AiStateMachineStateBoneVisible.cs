using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064AA RID: 25770
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateBoneVisible : AiStateMachineState
	{
		// Token: 0x0603EA00 RID: 256512 RVA: 0x0123F3C6 File Offset: 0x0123D5C6
		public AiStateMachineStateBoneVisible(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA01 RID: 256513 RVA: 0x0123F3D0 File Offset: 0x0123D5D0
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.BoneName = new FName?(new FName(state.BindBoneVisible.BoneName));
			this.Visible = state.BindBoneVisible.Visible;
			return true;
		}

		// Token: 0x0603EA02 RID: 256514 RVA: 0x0123F3FF File Offset: 0x0123D5FF
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.Node.AnimationComponent.HideBone(this.BoneName.Value, !this.Visible, false);
		}

		// Token: 0x0603EA03 RID: 256515 RVA: 0x0123F428 File Offset: 0x0123D628
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			if (this.Node.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				return;
			}
			this.Node.AnimationComponent.HideBone(this.BoneName.Value, this.Visible, false);
		}

		// Token: 0x0603EA04 RID: 256516 RVA: 0x0123F479 File Offset: 0x0123D679
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402170D RID: 136973
		private FName? BoneName;

		// Token: 0x0402170E RID: 136974
		private bool Visible;
	}
}

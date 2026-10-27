using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007327 RID: 29479
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateBoneVisible : AiStateMachineState
	{
		// Token: 0x060485B3 RID: 296371 RVA: 0x0129C946 File Offset: 0x0129AB46
		public AiStateMachineStateBoneVisible(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485B4 RID: 296372 RVA: 0x0129C950 File Offset: 0x0129AB50
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.BoneName = new FName?(new FName(state.BindBoneVisible.BoneName));
			this.Visible = state.BindBoneVisible.Visible;
			return true;
		}

		// Token: 0x060485B5 RID: 296373 RVA: 0x0129C97F File Offset: 0x0129AB7F
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.Node.AnimationComponent.HideBone(this.BoneName.Value, !this.Visible, false);
		}

		// Token: 0x060485B6 RID: 296374 RVA: 0x0129C9A8 File Offset: 0x0129ABA8
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			if (this.Node.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				return;
			}
			this.Node.AnimationComponent.HideBone(this.BoneName.Value, this.Visible, false);
		}

		// Token: 0x060485B7 RID: 296375 RVA: 0x0129C9F9 File Offset: 0x0129ABF9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026420 RID: 156704
		private FName? BoneName;

		// Token: 0x04026421 RID: 156705
		private bool Visible;
	}
}

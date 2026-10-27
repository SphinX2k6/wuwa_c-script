using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200734E RID: 29518
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionCameraLockOn : AiStateMachineAction
	{
		// Token: 0x060486A1 RID: 296609 RVA: 0x012A097B File Offset: 0x0129EB7B
		public AiStateMachineActionCameraLockOn(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486A2 RID: 296610 RVA: 0x012A0985 File Offset: 0x0129EB85
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.Enable = action.ActionCameraLockOn.Enable;
			return true;
		}

		// Token: 0x060486A3 RID: 296611 RVA: 0x012A099C File Offset: 0x0129EB9C
		public override void DoAction(long? contextId = null)
		{
			AiStateMachineBase node = this.Node;
			CameraLockOnConfig cameraLockOnConfig;
			if (node == null)
			{
				cameraLockOnConfig = null;
			}
			else
			{
				CharacterActorComponent actorComponent = node.ActorComponent;
				cameraLockOnConfig = ((actorComponent != null) ? actorComponent.CameraLockOnConfig : null);
			}
			CameraLockOnConfig cameraLockOnConfig2 = cameraLockOnConfig;
			if (cameraLockOnConfig2 != null)
			{
				cameraLockOnConfig2.IsEnabled = this.Enable;
			}
		}

		// Token: 0x060486A4 RID: 296612 RVA: 0x012A09D7 File Offset: 0x0129EBD7
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402647A RID: 156794
		public bool Enable;
	}
}

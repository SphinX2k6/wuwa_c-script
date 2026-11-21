using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D1 RID: 25809
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionCameraLockOn : AiStateMachineAction
	{
		// Token: 0x0603EAEE RID: 256750 RVA: 0x01243403 File Offset: 0x01241603
		public AiStateMachineActionCameraLockOn(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAEF RID: 256751 RVA: 0x0124340D File Offset: 0x0124160D
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.Enable = action.ActionCameraLockOn.Enable;
			return true;
		}

		// Token: 0x0603EAF0 RID: 256752 RVA: 0x01243424 File Offset: 0x01241624
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

		// Token: 0x0603EAF1 RID: 256753 RVA: 0x0124345F File Offset: 0x0124165F
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021767 RID: 137063
		public bool Enable;
	}
}

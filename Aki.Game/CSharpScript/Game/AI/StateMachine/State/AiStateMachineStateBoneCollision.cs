using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064A9 RID: 25769
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateBoneCollision : AiStateMachineState
	{
		// Token: 0x0603E9FB RID: 256507 RVA: 0x0123F29C File Offset: 0x0123D49C
		public AiStateMachineStateBoneCollision(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E9FC RID: 256508 RVA: 0x0123F2B4 File Offset: 0x0123D4B4
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.BoneName = state.BindBoneCollision.BoneName;
			this.IsBlockPawn = state.BindBoneCollision.IsBlockPawn;
			this.IsBulletDetect = state.BindBoneCollision.IsBulletDetect;
			this.IsBlockCamera = state.BindBoneCollision.IsBlockCamera;
			this.IsBlockPawnOnExit = state.BindBoneCollision.IsBlockPawnOnExit;
			this.IsBulletDetectOnExit = state.BindBoneCollision.IsBulletDetectOnExit;
			this.IsBlockCameraOnExit = state.BindBoneCollision.IsBlockCameraOnExit;
			this.IsActiveOcclusionDither = state.BindBoneCollision.IsActiveOcclusionDither;
			this.IsActiveOcclusionDitherOnExit = state.BindBoneCollision.IsActiveOcclusionDitherOnExit;
			return true;
		}

		// Token: 0x0603E9FD RID: 256509 RVA: 0x0123F35B File Offset: 0x0123D55B
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.Node.ActorComponent.SetPartCollisionSwitch(this.BoneName, this.IsBlockPawn, this.IsBulletDetect, this.IsBlockCamera, this.IsActiveOcclusionDither, false);
		}

		// Token: 0x0603E9FE RID: 256510 RVA: 0x0123F38C File Offset: 0x0123D58C
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			this.Node.ActorComponent.SetPartCollisionSwitch(this.BoneName, this.IsBlockPawnOnExit, this.IsBulletDetectOnExit, this.IsBlockCameraOnExit, this.IsActiveOcclusionDitherOnExit, false);
		}

		// Token: 0x0603E9FF RID: 256511 RVA: 0x0123F3BD File Offset: 0x0123D5BD
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021704 RID: 136964
		public string BoneName = "";

		// Token: 0x04021705 RID: 136965
		public bool IsBlockPawn;

		// Token: 0x04021706 RID: 136966
		public bool IsBulletDetect;

		// Token: 0x04021707 RID: 136967
		public bool IsBlockCamera;

		// Token: 0x04021708 RID: 136968
		public bool IsBlockPawnOnExit;

		// Token: 0x04021709 RID: 136969
		public bool IsBulletDetectOnExit;

		// Token: 0x0402170A RID: 136970
		public bool IsBlockCameraOnExit;

		// Token: 0x0402170B RID: 136971
		public bool IsActiveOcclusionDither;

		// Token: 0x0402170C RID: 136972
		public bool IsActiveOcclusionDitherOnExit;
	}
}

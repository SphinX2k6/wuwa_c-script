using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007326 RID: 29478
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateBoneCollision : AiStateMachineState
	{
		// Token: 0x060485AE RID: 296366 RVA: 0x0129C81C File Offset: 0x0129AA1C
		public AiStateMachineStateBoneCollision(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485AF RID: 296367 RVA: 0x0129C834 File Offset: 0x0129AA34
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

		// Token: 0x060485B0 RID: 296368 RVA: 0x0129C8DB File Offset: 0x0129AADB
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.Node.ActorComponent.SetPartCollisionSwitch(this.BoneName, this.IsBlockPawn, this.IsBulletDetect, this.IsBlockCamera, this.IsActiveOcclusionDither, false);
		}

		// Token: 0x060485B1 RID: 296369 RVA: 0x0129C90C File Offset: 0x0129AB0C
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			this.Node.ActorComponent.SetPartCollisionSwitch(this.BoneName, this.IsBlockPawnOnExit, this.IsBulletDetectOnExit, this.IsBlockCameraOnExit, this.IsActiveOcclusionDitherOnExit, false);
		}

		// Token: 0x060485B2 RID: 296370 RVA: 0x0129C93D File Offset: 0x0129AB3D
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026417 RID: 156695
		public string BoneName = "";

		// Token: 0x04026418 RID: 156696
		public bool IsBlockPawn;

		// Token: 0x04026419 RID: 156697
		public bool IsBulletDetect;

		// Token: 0x0402641A RID: 156698
		public bool IsBlockCamera;

		// Token: 0x0402641B RID: 156699
		public bool IsBlockPawnOnExit;

		// Token: 0x0402641C RID: 156700
		public bool IsBulletDetectOnExit;

		// Token: 0x0402641D RID: 156701
		public bool IsBlockCameraOnExit;

		// Token: 0x0402641E RID: 156702
		public bool IsActiveOcclusionDither;

		// Token: 0x0402641F RID: 156703
		public bool IsActiveOcclusionDitherOnExit;
	}
}

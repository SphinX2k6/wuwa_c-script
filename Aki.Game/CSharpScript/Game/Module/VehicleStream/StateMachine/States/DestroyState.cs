using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine.States
{
	// Token: 0x020048BB RID: 18619
	public class DestroyState : VehicleStateBase
	{
		// Token: 0x06030A8A RID: 199306 RVA: 0x00B4C2EA File Offset: 0x00B4A4EA
		[NullableContext(1)]
		public DestroyState(VehicleSmBlackBoard blackBoard) : base(EVehicleStateType.Destroy, blackBoard)
		{
		}

		// Token: 0x06030A8B RID: 199307 RVA: 0x00B4C2F4 File Offset: 0x00B4A4F4
		[NullableContext(2)]
		protected override void OnEnter(EVehicleStateType lastState, string reason = null)
		{
			VehicleStreamController.Instance.RequestNetworkEntityUpdateCurRoadPush(this.BlackBoard.CreatureDataId, this.BlackBoard.DestRoadId, this.BlackBoard.DestRoadIndex);
		}
	}
}

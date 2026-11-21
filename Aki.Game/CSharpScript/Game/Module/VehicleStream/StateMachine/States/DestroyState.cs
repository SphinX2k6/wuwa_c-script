using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine.States
{
	// Token: 0x02003832 RID: 14386
	public class DestroyState : VehicleStateBase
	{
		// Token: 0x060255B6 RID: 153014 RVA: 0x00A870F2 File Offset: 0x00A852F2
		[NullableContext(1)]
		public DestroyState(VehicleSmBlackBoard blackBoard) : base(EVehicleStateType.Destroy, blackBoard)
		{
		}

		// Token: 0x060255B7 RID: 153015 RVA: 0x00A870FC File Offset: 0x00A852FC
		[NullableContext(2)]
		protected override void OnEnter(EVehicleStateType lastState, string reason = null)
		{
			VehicleStreamController.Instance.RequestNetworkEntityUpdateCurRoadPush(this.BlackBoard.CreatureDataId, this.BlackBoard.DestRoadId, this.BlackBoard.DestRoadIndex);
		}
	}
}

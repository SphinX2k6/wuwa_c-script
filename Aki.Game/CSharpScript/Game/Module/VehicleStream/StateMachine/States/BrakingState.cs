using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine.States
{
	// Token: 0x02003831 RID: 14385
	public class BrakingState : VehicleStateBase
	{
		// Token: 0x060255B2 RID: 153010 RVA: 0x00A86FB8 File Offset: 0x00A851B8
		[NullableContext(1)]
		public BrakingState(VehicleSmBlackBoard blackBoard) : base(EVehicleStateType.Braking, blackBoard)
		{
		}

		// Token: 0x060255B3 RID: 153011 RVA: 0x00A86FC2 File Offset: 0x00A851C2
		[NullableContext(2)]
		protected override void OnEnter(EVehicleStateType lastState, string reason = null)
		{
		}

		// Token: 0x060255B4 RID: 153012 RVA: 0x00A86FC4 File Offset: 0x00A851C4
		protected override void OnUpdate(float delta)
		{
			EVehicleStateType evehicleStateType = this.CheckGetNextState();
			if (evehicleStateType != EVehicleStateType.None)
			{
				this.BlackBoard.SwitchState(evehicleStateType, null);
			}
		}

		// Token: 0x060255B5 RID: 153013 RVA: 0x00A86FEC File Offset: 0x00A851EC
		protected override EVehicleStateType CheckGetNextState()
		{
			string a = base.CheckObstruction(this.BlackBoard.CurrentRootDistance, "VehicleStream.braking");
			if (a != EObstructionCheckResult.None.ToEnumString())
			{
				this.BlackBoard.BlockTarget = this.ObstructionCheckInfo.HitEntityType;
				if ((a == EObstructionCheckResult.TraceBlock.ToEnumString() || a == EObstructionCheckResult.CheckPlayerBlock.ToEnumString()) && this.BlackBoard.HornAudio != null && TimeUtil.Instance.GetServerTimeStamp() - this.LastPlayHornAudioTime >= 10000.0)
				{
					this.BlackBoard.OpenAudio(this.BlackBoard.HornAudio, false);
					this.LastPlayHornAudioTime = TimeUtil.Instance.GetServerTimeStamp();
				}
				return EVehicleStateType.None;
			}
			this.BlackBoard.BlockTarget = null;
			UKuroRoadway nextRoadway = this.BlackBoard.NextRoadway;
			if (nextRoadway != null && nextRoadway is UKuroRoadwayIntersection)
			{
				if (!this.BlackBoard.CheckArrivedSplineEndPoint())
				{
					return EVehicleStateType.Running;
				}
				if (VehicleStreamModel.Instance.CheckIntersectionRoadwayOccupied(nextRoadway.Id))
				{
					return EVehicleStateType.None;
				}
			}
			return EVehicleStateType.Running;
		}

		// Token: 0x04014AEF RID: 84719
		private double LastPlayHornAudioTime;
	}
}

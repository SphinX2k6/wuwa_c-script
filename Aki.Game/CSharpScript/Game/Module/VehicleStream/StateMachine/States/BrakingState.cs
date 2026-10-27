using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine.States
{
	// Token: 0x020048BA RID: 18618
	public class BrakingState : VehicleStateBase
	{
		// Token: 0x06030A86 RID: 199302 RVA: 0x00B4C1B0 File Offset: 0x00B4A3B0
		[NullableContext(1)]
		public BrakingState(VehicleSmBlackBoard blackBoard) : base(EVehicleStateType.Braking, blackBoard)
		{
		}

		// Token: 0x06030A87 RID: 199303 RVA: 0x00B4C1BA File Offset: 0x00B4A3BA
		[NullableContext(2)]
		protected override void OnEnter(EVehicleStateType lastState, string reason = null)
		{
		}

		// Token: 0x06030A88 RID: 199304 RVA: 0x00B4C1BC File Offset: 0x00B4A3BC
		protected override void OnUpdate(float delta)
		{
			EVehicleStateType evehicleStateType = this.CheckGetNextState();
			if (evehicleStateType != EVehicleStateType.None)
			{
				this.BlackBoard.SwitchState(evehicleStateType, null);
			}
		}

		// Token: 0x06030A89 RID: 199305 RVA: 0x00B4C1E4 File Offset: 0x00B4A3E4
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

		// Token: 0x0401A27C RID: 107132
		private double LastPlayHornAudioTime;
	}
}

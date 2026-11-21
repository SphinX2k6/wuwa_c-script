using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.VehicleStream.StateMachineContainer;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine.States
{
	// Token: 0x02003833 RID: 14387
	[NullableContext(1)]
	[Nullable(0)]
	public class RunningState : VehicleStateBase
	{
		// Token: 0x060255B8 RID: 153016 RVA: 0x00A8712C File Offset: 0x00A8532C
		public RunningState(VehicleSmBlackBoard blackBoard) : base(EVehicleStateType.Running, blackBoard)
		{
		}

		// Token: 0x060255B9 RID: 153017 RVA: 0x00A871AB File Offset: 0x00A853AB
		protected override void OnCreate()
		{
		}

		// Token: 0x060255BA RID: 153018 RVA: 0x00A871B0 File Offset: 0x00A853B0
		[NullableContext(2)]
		protected override void OnEnter(EVehicleStateType lastState, string reason = null)
		{
			this.BlackBoard.CurrentAcceleratedSpeed = this.BlackBoard.AcceleratedSpeedConfig;
			this.SubState = ERunningSubState.Normal;
			if (this.BlackBoard.EngineAudio != null && this.EngineAudioHandle == 0)
			{
				this.EngineAudioHandle = this.BlackBoard.OpenAudio(this.BlackBoard.EngineAudio, true);
			}
		}

		// Token: 0x060255BB RID: 153019 RVA: 0x00A8720C File Offset: 0x00A8540C
		protected override void OnExit(EVehicleStateType nextState)
		{
			this.SubState = ERunningSubState.None;
			this.BlackBoard.StopAudio(this.BrakingAudioHandle, true);
			this.BrakingAudioHandle = 0;
		}

		// Token: 0x060255BC RID: 153020 RVA: 0x00A8722E File Offset: 0x00A8542E
		protected override void OnDestroy()
		{
			this.BlackBoard.StopAudio(this.EngineAudioHandle, true);
			this.EngineAudioHandle = 0;
		}

		// Token: 0x060255BD RID: 153021 RVA: 0x00A87249 File Offset: 0x00A85449
		public new void OnEnterPlayerRange()
		{
			if (this.BlackBoard.EngineAudio != null && this.EngineAudioHandle == 0)
			{
				this.EngineAudioHandle = this.BlackBoard.OpenAudio(this.BlackBoard.EngineAudio, true);
			}
		}

		// Token: 0x060255BE RID: 153022 RVA: 0x00A8727D File Offset: 0x00A8547D
		public new void OnLeavePlayerRange()
		{
			this.BlackBoard.StopAudio(this.EngineAudioHandle, true);
			this.EngineAudioHandle = 0;
		}

		// Token: 0x060255BF RID: 153023 RVA: 0x00A87298 File Offset: 0x00A85498
		protected override void OnUpdate(float delta)
		{
			if (this.UpdateMove(delta))
			{
				this.UpdateDesireLocationAndRotation();
			}
			this.SyncKeyPointToServer();
			EVehicleStateType evehicleStateType = this.CheckGetNextState();
			if (evehicleStateType != EVehicleStateType.None)
			{
				this.BlackBoard.SwitchState(evehicleStateType, this.MoveInfo.BeforeMoveCheckResult.ToEnumString());
			}
		}

		// Token: 0x060255C0 RID: 153024 RVA: 0x00A872E1 File Offset: 0x00A854E1
		protected override EVehicleStateType CheckGetNextState()
		{
			if (this.BlackBoard.CheckArrivedDestination())
			{
				return EVehicleStateType.Destroy;
			}
			if (this.BlackBoard.CurrentSpeed <= 0f)
			{
				return EVehicleStateType.Braking;
			}
			return EVehicleStateType.None;
		}

		// Token: 0x060255C1 RID: 153025 RVA: 0x00A87308 File Offset: 0x00A85508
		private bool UpdateMove(float delta)
		{
			this.CheckUpdateRoadway();
			this.OnBeforeMove();
			if (this.BlackBoard.WaitingModelBuffer)
			{
				this.SubState = ERunningSubState.WaitingModelBuffer;
				return false;
			}
			if (this.SubState == ERunningSubState.None)
			{
				return false;
			}
			this.UpdateSpeed(delta);
			if (this.BlackBoard.CurrentSpeed == 0f)
			{
				return false;
			}
			bool result = this.UpdateMoveImp(delta);
			this.PredictedVariableSpeed();
			bool enableDebug = VehicleStreamModel.Instance.EnableDebug;
			return result;
		}

		// Token: 0x060255C2 RID: 153026 RVA: 0x00A87378 File Offset: 0x00A85578
		private bool CheckUpdateRoadway()
		{
			float num = this.BlackBoard.CurrentSplineLength - this.BlackBoard.CurrentRootDistance;
			int num2 = 10;
			if (num > (float)num2)
			{
				return false;
			}
			base.EnterNextRoadway();
			return true;
		}

		// Token: 0x060255C3 RID: 153027 RVA: 0x00A873AC File Offset: 0x00A855AC
		private void OnBeforeMove()
		{
			EMoveCheckResult beforeMoveCheckResult = this.MoveInfo.BeforeMoveCheckResult;
			this.MoveInfo.Reset();
			EMoveCheckResult moveCheckResult = this.BeforeMoveCheck(this.BlackBoard.CurrentRootDistance);
			this.DoByBeforeMoveCheckResult(beforeMoveCheckResult, moveCheckResult);
		}

		// Token: 0x060255C4 RID: 153028 RVA: 0x00A873EC File Offset: 0x00A855EC
		private void UpdateSpeed(float delta)
		{
			float currentSpeed = (float)MathCommon.Clamp((double)this.BlackBoard.CurrentSpeed + (double)(this.BlackBoard.CurrentAcceleratedSpeed * delta) * TimeUtil.Instance.Millisecond, 0.0, (double)this.BlackBoard.NormalSpeed);
			this.BlackBoard.CurrentSpeed = currentSpeed;
		}

		// Token: 0x060255C5 RID: 153029 RVA: 0x00A87448 File Offset: 0x00A85648
		private bool UpdateMoveImp(float delta)
		{
			float currentRootDistance = this.BlackBoard.CurrentRootDistance;
			double num = (double)delta * TimeUtil.Instance.Millisecond * (double)this.BlackBoard.CurrentSpeed * 100.0;
			float num2 = (float)Math.Min((double)currentRootDistance + num, (double)this.BlackBoard.CurrentSplineLength);
			this.MoveInfo.AfterMoveCheckResult = this.AfterMoveCheck(currentRootDistance, num2);
			float val = num2;
			if (this.MoveInfo.AfterMoveCheckResult != EMoveCheckResult.None)
			{
				val = this.MoveInfo.AfterMoveCheckInfo.AfterAdjustDistance;
			}
			this.BlackBoard.CurrentRootDistance = Math.Min(val, this.BlackBoard.CurrentSplineLength);
			return currentRootDistance != this.BlackBoard.CurrentRootDistance;
		}

		// Token: 0x060255C6 RID: 153030 RVA: 0x00A87500 File Offset: 0x00A85700
		private EMoveCheckResult BeforeMoveCheck(float curRootDistance)
		{
			string text = base.CheckObstruction(curRootDistance, "VehicleStream.Running");
			if (text != EObstructionCheckResult.None.ToEnumString())
			{
				return (EMoveCheckResult)Enum.Parse(typeof(EMoveCheckResult), text);
			}
			if (this.CheckWillArriveIntersection())
			{
				return EMoveCheckResult.Intersection;
			}
			return EMoveCheckResult.None;
		}

		// Token: 0x060255C7 RID: 153031 RVA: 0x00A8754C File Offset: 0x00A8574C
		private bool CheckWillArriveIntersection()
		{
			UKuroRoadway nextRoadway = this.BlackBoard.NextRoadway;
			return nextRoadway != null && nextRoadway is UKuroRoadwayIntersection && VehicleStreamModel.Instance.CheckIntersectionRoadwayOccupied(nextRoadway.Id) && (this.BlackBoard.CurrentSplineLength - this.BlackBoard.CurrentRootHeadDistance) * 0.01f <= 5f;
		}

		// Token: 0x060255C8 RID: 153032 RVA: 0x00A875AC File Offset: 0x00A857AC
		private void DoByBeforeMoveCheckResult(EMoveCheckResult lastMoveCheckResult, EMoveCheckResult moveCheckResult)
		{
			this.MoveInfo.BeforeMoveCheckResult = moveCheckResult;
			switch (moveCheckResult)
			{
			case EMoveCheckResult.None:
				this.SubState = ERunningSubState.Normal;
				this.BlackBoard.CurrentAcceleratedSpeed = this.BlackBoard.AcceleratedSpeedConfig;
				if (this.BrakingAudioHandle != 0 && this.IsBrakingLoop)
				{
					this.BlackBoard.StopAudio(this.BrakingAudioHandle, true);
				}
				this.BrakingAudioHandle = 0;
				this.BlackBoard.BlockTarget = null;
				break;
			case EMoveCheckResult.TraceBlock:
			case EMoveCheckResult.CheckPlayerBlock:
			case EMoveCheckResult.SameRoadwayVehicleBlock:
			case EMoveCheckResult.NextRoadwayVehicleBlock:
			{
				this.BlackBoard.BlockTarget = this.ObstructionCheckInfo.HitEntityType;
				this.SubState = ERunningSubState.BrakingByObstruction;
				this.MoveInfo.BrakingDistance = Math.Max(this.ObstructionCheckInfo.HitDistance - this.ObstructionCheckInfo.DistanceToKeep, 0.1f);
				float num = this.CalculateAcceleratedSpeedByBrakingDistance(this.MoveInfo.BrakingDistance);
				num = Math.Min(num, -1f);
				if (num < this.BlackBoard.CurrentAcceleratedSpeed)
				{
					this.BlackBoard.CurrentAcceleratedSpeed = num;
				}
				break;
			}
			case EMoveCheckResult.Intersection:
				this.BlackBoard.BlockTarget = null;
				if (this.SubState != ERunningSubState.BrakingByIntersection)
				{
					this.SubState = ERunningSubState.BrakingByIntersection;
					float val = (this.BlackBoard.CurrentSplineLength - this.BlackBoard.CurrentRootHeadDistance) * 0.01f;
					this.MoveInfo.BrakingDistance = Math.Max(val, 0.1f);
					this.BlackBoard.CurrentAcceleratedSpeed = this.CalculateAcceleratedSpeedByBrakingDistance(this.MoveInfo.BrakingDistance);
				}
				break;
			}
			if (moveCheckResult != EMoveCheckResult.None)
			{
				this.PlayBrakingAudio(this.MoveInfo.BrakingDistance);
			}
			bool enableDebug = VehicleStreamModel.Instance.EnableDebug;
			bool flag = lastMoveCheckResult == EMoveCheckResult.TraceBlock && moveCheckResult != EMoveCheckResult.TraceBlock;
			bool flag2 = lastMoveCheckResult != EMoveCheckResult.TraceBlock && moveCheckResult == EMoveCheckResult.TraceBlock;
			if (flag2 || flag)
			{
				EventSystem.Instance.EmitWithTarget<bool>(this.BlackBoard.RoadNetworkNavigationComponent, EEventName.VehicleMemberBlockByTraceTarget, flag2);
			}
		}

		// Token: 0x060255C9 RID: 153033 RVA: 0x00A87793 File Offset: 0x00A85993
		private EMoveCheckResult AfterMoveCheck(float beforeMoveRootDistance, float afterMoveRootDistance)
		{
			this.CheckCrossPlayer(beforeMoveRootDistance, afterMoveRootDistance);
			this.CheckCrossSameRoadwayVehicle(beforeMoveRootDistance, afterMoveRootDistance);
			this.CheckCrossNextRoadwayVehicle(beforeMoveRootDistance, afterMoveRootDistance);
			this.CheckVehicleHeadOverRoadOnWaitIntersection(afterMoveRootDistance);
			return this.MoveInfo.AfterMoveCheckInfo.Result;
		}

		// Token: 0x060255CA RID: 153034 RVA: 0x00A877C4 File Offset: 0x00A859C4
		private void CheckCrossPlayer(float beforeMoveRootDistance, float afterMoveRootDistance)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (!this.BlackBoard.IsInPlayerRange || this.BlackBoard.RoadNetworkNavigationComponent.WasRecentlyRenderedOnScreen() || characterActorComponent == null)
			{
				return;
			}
			EEntityType? blockTarget = this.BlackBoard.BlockTarget;
			EEntityType eentityType = EEntityType.Player;
			if (blockTarget.GetValueOrDefault() == eentityType & blockTarget != null)
			{
				return;
			}
			UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
			USplineComponent usplineComponent = (currentRoadway != null) ? currentRoadway.RoadSpline : null;
			if (usplineComponent == null)
			{
				return;
			}
			FVectorDouble actorLocation = characterActorComponent.ActorLocation;
			float num;
			if (this.ObstructionCheckInfo.PlayerHitDistance == 0f)
			{
				num = (float)(usplineComponent.D_GetTransformAtDistanceAlongSpline(afterMoveRootDistance, ESplineCoordinateSpace.World, false).InverseTransformPosition(actorLocation).X - (double)this.BlackBoard.RootCenterToHead) * 0.01f;
			}
			else
			{
				num = this.ObstructionCheckInfo.PlayerHitDistance;
			}
			if (num <= 0f)
			{
				return;
			}
			if ((float)(usplineComponent.D_GetTransformAtDistanceAlongSpline(afterMoveRootDistance, ESplineCoordinateSpace.World, false).InverseTransformPosition(actorLocation).X - (double)this.BlackBoard.RootCenterToHead) * 0.01f >= 0f)
			{
				return;
			}
			float inKey = usplineComponent.D_FindInputKeyClosestToWorldLocation(actorLocation);
			float distanceAlongSplineAtSplineInputKey = usplineComponent.GetDistanceAlongSplineAtSplineInputKey(inKey);
			float num2 = 500f + this.BlackBoard.RootCenterToHead;
			float afterAdjustDistance = Math.Max(distanceAlongSplineAtSplineInputKey - num2, beforeMoveRootDistance);
			this.MoveInfo.TryUpdateAdjustDistance(EMoveCheckResult.CrossPlayer, afterAdjustDistance);
		}

		// Token: 0x060255CB RID: 153035 RVA: 0x00A87920 File Offset: 0x00A85B20
		private unsafe void CheckCrossSameRoadwayVehicle(float beforeMoveRootDistance, float afterMoveRootDistance)
		{
			UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
			if (currentRoadway == null)
			{
				return;
			}
			VehicleStreamModel instance = VehicleStreamModel.Instance;
			HashSet<long> allVehicleInRoadway = instance.GetAllVehicleInRoadway(currentRoadway.Id);
			if (allVehicleInRoadway == null)
			{
				return;
			}
			bool flag = false;
			float num = afterMoveRootDistance;
			foreach (long num2 in allVehicleInRoadway)
			{
				if (num2 != this.BlackBoard.CreatureDataId)
				{
					VehicleTeamMember vehicleTeamMember = instance.GetVehicleTeamMember(num2);
					if (vehicleTeamMember != null && Math.Abs(vehicleTeamMember.GetRelativeLocation().Y - this.BlackBoard.RelativeLocationToStart.Y) <= (vehicleTeamMember.GetVehicleSize().Y + this.BlackBoard.VehicleSize.Y) * 0.5)
					{
						EPositionRelationship epositionRelationship = base.CheckPositionalRelationshipToTarget(beforeMoveRootDistance, vehicleTeamMember.GetCurrentMeshHeadDistance(), vehicleTeamMember.GetCurrentMeshTailDistance());
						bool flag2 = true;
						if (epositionRelationship != EPositionRelationship.OverlapBehind)
						{
							if (epositionRelationship - EPositionRelationship.CompleteOverlap <= 2)
							{
								flag2 = false;
							}
						}
						else
						{
							flag = true;
							if (beforeMoveRootDistance < num)
							{
								num = beforeMoveRootDistance;
							}
							flag2 = false;
							Log instance2 = Log.Instance;
							ELogModule module = ELogModule.VehicleStream;
							ELogAuthor author = ELogAuthor.YSQ;
							string message = "发现载具重叠";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SelfCreatureDataId", this.BlackBoard.CreatureDataId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetCreatureDataId", this.BlackBoard.CreatureDataId);
							instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						if (flag2)
						{
							switch (base.CheckPositionalRelationshipToTarget(afterMoveRootDistance, vehicleTeamMember.GetCurrentMeshHeadDistance(), vehicleTeamMember.GetCurrentMeshTailDistance()))
							{
							case EPositionRelationship.OverlapBehind:
							case EPositionRelationship.OverlapForward:
							case EPositionRelationship.Forward:
							{
								flag = true;
								float currentMeshCenterDistance = vehicleTeamMember.GetCurrentMeshCenterDistance();
								float num3 = this.BlackBoard.RootCenterToHead + vehicleTeamMember.GetMeshCenterToTail();
								float num4 = 300f + num3;
								if (currentMeshCenterDistance - beforeMoveRootDistance > num4)
								{
									int num5 = 100;
									float num6 = currentMeshCenterDistance - num4 + (float)num5;
									if (num6 < num)
									{
										num = num6;
									}
								}
								break;
							}
							}
						}
					}
				}
			}
			if (flag)
			{
				this.MoveInfo.TryUpdateAdjustDistance(EMoveCheckResult.CrossSameRoadwayVehicle, num);
			}
		}

		// Token: 0x060255CC RID: 153036 RVA: 0x00A87B68 File Offset: 0x00A85D68
		private void CheckCrossNextRoadwayVehicle(float beforeMoveRootDistance, float afterMoveRootDistance)
		{
			UKuroRoadway nextRoadway = this.BlackBoard.NextRoadway;
			if (nextRoadway == null)
			{
				return;
			}
			VehicleStreamModel instance = VehicleStreamModel.Instance;
			HashSet<long> allVehicleInRoadway = instance.GetAllVehicleInRoadway(nextRoadway.Id);
			if (allVehicleInRoadway == null)
			{
				return;
			}
			bool flag = false;
			float num = afterMoveRootDistance;
			foreach (long num2 in allVehicleInRoadway)
			{
				if (num2 != this.BlackBoard.CreatureDataId)
				{
					VehicleTeamMember vehicleTeamMember = instance.GetVehicleTeamMember(num2);
					if (vehicleTeamMember != null && Math.Abs(vehicleTeamMember.GetRelativeLocation().Y - this.BlackBoard.RelativeLocationToStart.Y) <= (vehicleTeamMember.GetVehicleSize().Y + this.BlackBoard.VehicleSize.Y) * 0.5)
					{
						float currentSplineLength = this.BlackBoard.CurrentSplineLength;
						switch (base.CheckPositionalRelationshipToTarget(afterMoveRootDistance, currentSplineLength + vehicleTeamMember.GetCurrentMeshHeadDistance(), currentSplineLength + vehicleTeamMember.GetCurrentMeshTailDistance()))
						{
						case EPositionRelationship.OverlapBehind:
						case EPositionRelationship.OverlapForward:
						case EPositionRelationship.Forward:
						{
							flag = true;
							float currentMeshCenterDistance = vehicleTeamMember.GetCurrentMeshCenterDistance();
							float num3 = currentSplineLength - beforeMoveRootDistance;
							float num4 = this.BlackBoard.RootCenterToHead + vehicleTeamMember.GetMeshCenterToTail();
							float num5 = 600f + num4;
							if (currentMeshCenterDistance + num3 > num5)
							{
								float num6 = currentMeshCenterDistance - num5;
								if (num6 < 0f)
								{
									num6 += currentSplineLength;
								}
								if (num6 < num)
								{
									num = num6;
								}
							}
							break;
						}
						}
					}
				}
			}
			if (flag)
			{
				this.MoveInfo.TryUpdateAdjustDistance(EMoveCheckResult.CrossNextRoadwayVehicle, num);
			}
		}

		// Token: 0x060255CD RID: 153037 RVA: 0x00A87D14 File Offset: 0x00A85F14
		private void CheckVehicleHeadOverRoadOnWaitIntersection(float afterMoveRootDistance)
		{
			UKuroRoadway nextRoadway = this.BlackBoard.NextRoadway;
			if (nextRoadway == null || !(nextRoadway is UKuroRoadwayIntersection))
			{
				return;
			}
			if (!VehicleStreamModel.Instance.CheckIntersectionRoadwayOccupied(nextRoadway.Id))
			{
				return;
			}
			float rootCenterToHead = this.BlackBoard.RootCenterToHead;
			if (afterMoveRootDistance + rootCenterToHead >= this.BlackBoard.CurrentSplineLength && this.SubState != ERunningSubState.BrakingByIntersection)
			{
				float afterAdjustDistance = this.BlackBoard.CurrentSplineLength - rootCenterToHead;
				this.MoveInfo.TryUpdateAdjustDistance(EMoveCheckResult.HeadOverRoadOnWaitIntersection, afterAdjustDistance);
			}
		}

		// Token: 0x060255CE RID: 153038 RVA: 0x00A87D8D File Offset: 0x00A85F8D
		private void PredictedVariableSpeed()
		{
			if (this.SubState == ERunningSubState.BrakingByIntersection || this.SubState == ERunningSubState.BrakingByObstruction)
			{
				return;
			}
			this.CheckSlowDownByTurn();
			this.CheckSlowDownByUpSlope();
			this.CheckSpeedUpByDownSlope();
		}

		// Token: 0x060255CF RID: 153039 RVA: 0x00A87DB4 File Offset: 0x00A85FB4
		private void CheckSlowDownByTurn()
		{
		}

		// Token: 0x060255D0 RID: 153040 RVA: 0x00A87DB6 File Offset: 0x00A85FB6
		private void CheckSlowDownByUpSlope()
		{
		}

		// Token: 0x060255D1 RID: 153041 RVA: 0x00A87DB8 File Offset: 0x00A85FB8
		private void CheckSpeedUpByDownSlope()
		{
		}

		// Token: 0x060255D2 RID: 153042 RVA: 0x00A87DBC File Offset: 0x00A85FBC
		private void UpdateDesireLocationAndRotation()
		{
			UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
			if (currentRoadway == null)
			{
				return;
			}
			UKuroRoadway lastRoadway = this.BlackBoard.LastRoadway;
			bool flag = ((lastRoadway != null) ? lastRoadway.RoadSpline : null) != null || this.BlackBoard.CurrentRootTailDistance >= 0f;
			if (VehicleStreamModel.Instance.EnableRotationOptimize && flag)
			{
				this.BlackBoard.GetHeadDistanceAndRoadway(this.BlackBoard.CurrentRootDistance, this.TmpDistanceAndRoadway);
				if (!this.GetLocationWithRelativePosition(this.TmpDistanceAndRoadway.Roadway, this.TmpDistanceAndRoadway.Distance, this.CurrentHeadLocation))
				{
					return;
				}
				this.BlackBoard.GetTailDistanceAndRoadway(this.BlackBoard.CurrentRootDistance, this.TmpDistanceAndRoadway);
				if (!this.GetLocationWithRelativePosition(this.TmpDistanceAndRoadway.Roadway, this.TmpDistanceAndRoadway.Distance, this.CurrentTailLocation))
				{
					return;
				}
				this.CurrentHeadLocation.Subtraction(this.CurrentTailLocation, this.CurrentDirection);
				this.CurrentDirection.Normalize(9.99999993922529E-09);
				this.CurrentDirection.Rotation(this.CurrentRotator);
				this.BlackBoard.DesireRotator.DeepCopy(this.CurrentRotator);
				this.CurrentDirection.Multiply((double)this.BlackBoard.RootCenterToTail, this.CurrentTail2Center);
				this.CurrentTailLocation.Addition(this.CurrentTail2Center, this.CurrentLocation);
				this.BlackBoard.DesireLocation.DeepCopy(this.CurrentLocation);
				this.BlackBoard.UpdateMoved = true;
				return;
			}
			else
			{
				USplineComponent roadSpline = currentRoadway.RoadSpline;
				FTransformDouble? ftransformDouble = (roadSpline != null) ? new FTransformDouble?(roadSpline.D_GetTransformAtDistanceAlongSpline(this.BlackBoard.CurrentRootDistance, ESplineCoordinateSpace.World, false)) : null;
				if (ftransformDouble == null)
				{
					return;
				}
				FTransformDouble value = ftransformDouble.Value;
				FVectorDouble fvectorDouble = this.BlackBoard.RelativeLocationToStartWithoutX.ToUeVector(false);
				FVectorDouble fvectorDouble2 = value.TransformPositionNoScale(fvectorDouble);
				this.BlackBoard.DesireLocation.DeepCopy(fvectorDouble2);
				global::Rotator desireRotator = this.BlackBoard.DesireRotator;
				FRotator frotator = ftransformDouble.Value.GetRotation().Rotator();
				desireRotator.DeepCopy(frotator);
				this.BlackBoard.UpdateMoved = true;
				return;
			}
		}

		// Token: 0x060255D3 RID: 153043 RVA: 0x00A87FF8 File Offset: 0x00A861F8
		private void SyncKeyPointToServer()
		{
			int num = -1;
			for (int i = 0; i < this.BlackBoard.KeyPointDistances.Count; i++)
			{
				float num2 = this.BlackBoard.KeyPointDistances[i];
				if (!this.BlackBoard.KeyPointDistanceSyncRecord.GetValueOrDefault(i, false) && this.BlackBoard.CurrentMeshHeadDistance >= num2)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				this.BlackBoard.KeyPointDistanceSyncRecord[num] = true;
				VehicleStreamController instance = VehicleStreamController.Instance;
				long creatureDataId = this.BlackBoard.CreatureDataId;
				UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
				instance.RequestNetworkEntityUpdateCurRoadPush(creatureDataId, (currentRoadway != null) ? currentRoadway.Id : 0, num);
			}
		}

		// Token: 0x060255D4 RID: 153044 RVA: 0x00A880A0 File Offset: 0x00A862A0
		private bool GetLocationWithRelativePosition([Nullable(2)] UKuroRoadway roadway, float distance, global::Vector outVector)
		{
			if (roadway == null)
			{
				return false;
			}
			USplineComponent roadSpline = roadway.RoadSpline;
			FTransformDouble? ftransformDouble = (roadSpline != null) ? new FTransformDouble?(roadSpline.D_GetTransformAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World, false)) : null;
			if (ftransformDouble == null)
			{
				return false;
			}
			FTransformDouble value = ftransformDouble.Value;
			FVectorDouble fvectorDouble = this.BlackBoard.RelativeLocationToStartWithoutX.ToUeVector(false);
			FVectorDouble fvectorDouble2 = value.TransformPositionNoScale(fvectorDouble);
			outVector.DeepCopy(fvectorDouble2);
			return true;
		}

		// Token: 0x060255D5 RID: 153045 RVA: 0x00A8810E File Offset: 0x00A8630E
		private float CalculateAcceleratedSpeedByBrakingDistance(float brakingDistance)
		{
			return -(this.BlackBoard.CurrentSpeed * this.BlackBoard.CurrentSpeed) / (2f * brakingDistance);
		}

		// Token: 0x060255D6 RID: 153046 RVA: 0x00A88130 File Offset: 0x00A86330
		private void PlayBrakingAudio(float brakingDistance)
		{
			this.IsBrakingLoop = (brakingDistance > 0.1f);
			string text = this.IsBrakingLoop ? this.BlackBoard.BrakingAudio : this.BlackBoard.BrakingShortAudio;
			if (text == null || this.BrakingAudioHandle != 0)
			{
				return;
			}
			this.BrakingAudioHandle = this.BlackBoard.OpenAudio(text, this.IsBrakingLoop);
		}

		// Token: 0x04014AF0 RID: 84720
		private ERunningSubState SubState;

		// Token: 0x04014AF1 RID: 84721
		private readonly MoveCheckInfo MoveInfo = new MoveCheckInfo();

		// Token: 0x04014AF2 RID: 84722
		private readonly global::Vector CurrentHeadLocation = global::Vector.Create();

		// Token: 0x04014AF3 RID: 84723
		private readonly global::Vector CurrentTailLocation = global::Vector.Create();

		// Token: 0x04014AF4 RID: 84724
		private readonly global::Vector CurrentDirection = global::Vector.Create();

		// Token: 0x04014AF5 RID: 84725
		private readonly global::Rotator CurrentRotator = global::Rotator.Create();

		// Token: 0x04014AF6 RID: 84726
		private readonly global::Vector CurrentTail2Center = global::Vector.Create();

		// Token: 0x04014AF7 RID: 84727
		private readonly global::Vector CurrentLocation = global::Vector.Create();

		// Token: 0x04014AF8 RID: 84728
		private readonly IDistanceAndRoadway TmpDistanceAndRoadway = new DistanceAndRoadway
		{
			Distance = 0f,
			Roadway = null
		};

		// Token: 0x04014AF9 RID: 84729
		private int EngineAudioHandle;

		// Token: 0x04014AFA RID: 84730
		private int BrakingAudioHandle;

		// Token: 0x04014AFB RID: 84731
		private bool IsBrakingLoop;
	}
}

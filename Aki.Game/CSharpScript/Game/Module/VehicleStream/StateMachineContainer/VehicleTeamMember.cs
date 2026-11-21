using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.Transport;
using CSharpScript.Game.Module.VehicleStream.StateMachine;
using CSharpScript.Game.Module.VehicleStream.StateMachine.States;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream.StateMachineContainer
{
	// Token: 0x02003837 RID: 14391
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleTeamMember : StateMachineContainer
	{
		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x060255F8 RID: 153080 RVA: 0x00A88B26 File Offset: 0x00A86D26
		public override EStateContainerType Type
		{
			get
			{
				return EStateContainerType.Vehicle;
			}
		}

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x060255F9 RID: 153081 RVA: 0x00A88B29 File Offset: 0x00A86D29
		public override int Id
		{
			get
			{
				return this.BlackBoard.PbDataId;
			}
		}

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x060255FA RID: 153082 RVA: 0x00A88B36 File Offset: 0x00A86D36
		public int TeamId
		{
			get
			{
				return this.BlackBoard.TeamId;
			}
		}

		// Token: 0x060255FB RID: 153083 RVA: 0x00A88B44 File Offset: 0x00A86D44
		public VehicleTeamMember(int teamId, int memberId, long creatureDataId, int pbDataId, global::Vector startActorLocation, global::Rotator startActorRotator, global::Vector destinationLocation, int destRoadId, int destIndex, ITrafficNavigationConfig baseConfig, ITransportFindPathResult result)
		{
			UKuroTransportNetworkSubsystem transportSystem = TransportNetworkController.Instance.GetTransportSystem();
			VehicleStreamModel instance = VehicleStreamModel.Instance;
			List<UKuroRoadway> list = new List<UKuroRoadway>();
			for (int i = 0; i < result.Roadways.Num(); i++)
			{
				UKuroRoadway ukuroRoadway = result.Roadways.Get(i);
				list.Add(ukuroRoadway);
				TArray<int> tarray = new TArray<int>();
				int intersectionId = transportSystem.GetIntersectionId(ukuroRoadway.Id);
				transportSystem.GetRoadwaysAtSameIntersection(intersectionId, ref tarray);
				instance.AddIntersection(intersectionId, tarray);
				transportSystem.GetCrossingRoads(ukuroRoadway.Id, ref tarray);
				TArray<int> inCrossingRoadways = tarray;
				instance.RecordCrossingRoadways(ukuroRoadway.Id, inCrossingRoadways);
			}
			global::Vector vector = global::Vector.Create();
			global::Vector vector2 = vector;
			FVectorDouble fvectorDouble = result.RoadStartPoint;
			vector2.DeepCopy(fvectorDouble);
			global::Vector vector3 = global::Vector.Create();
			global::Vector vector4 = vector3;
			fvectorDouble = result.RoadEndPoint;
			vector4.DeepCopy(fvectorDouble);
			CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent component = CreatureModel.Instance.GetEntity(creatureDataId).Entity.GetComponent<CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent>();
			this.BlackBoard = new VehicleSmBlackBoard(teamId, memberId, creatureDataId, pbDataId, startActorLocation, startActorRotator, destinationLocation, list, vector, vector3, destRoadId, destIndex, component, baseConfig, new VehicleSmBlackBoard.SwitchStateHandleType(this.SwitchState));
		}

		// Token: 0x060255FC RID: 153084 RVA: 0x00A88C74 File Offset: 0x00A86E74
		private void AddState<[Nullable(0)] T>(EVehicleStateType stateType, Func<VehicleSmBlackBoard, T> ctor) where T : VehicleStateBase
		{
			T t = ctor(this.BlackBoard);
			t.Create();
			this.StateMachine.AddState(stateType, t);
		}

		// Token: 0x060255FD RID: 153085 RVA: 0x00A88CAC File Offset: 0x00A86EAC
		public void Init()
		{
			this.AddState<BornState>(EVehicleStateType.Born, (VehicleSmBlackBoard board) => new BornState(board));
			this.AddState<RunningState>(EVehicleStateType.Running, (VehicleSmBlackBoard board) => new RunningState(board));
			this.AddState<BrakingState>(EVehicleStateType.Braking, (VehicleSmBlackBoard board) => new BrakingState(board));
			this.AddState<DestroyState>(EVehicleStateType.Destroy, (VehicleSmBlackBoard board) => new DestroyState(board));
			this.StateMachine.Start(EVehicleStateType.Born);
		}

		// Token: 0x060255FE RID: 153086 RVA: 0x00A88D60 File Offset: 0x00A86F60
		public void Launch(USkeletalMeshComponent skeletalMeshComponent)
		{
			this.BlackBoard.SkeletalMeshComponent = skeletalMeshComponent;
			this.BlackBoard.SkeletalMeshRelativeLocation.Reset();
			global::Vector skeletalMeshRelativeLocation = this.BlackBoard.SkeletalMeshRelativeLocation;
			FVector relativeLocation = skeletalMeshComponent.RelativeLocation;
			FVectorDouble fvectorDouble = relativeLocation;
			skeletalMeshRelativeLocation.DeepCopy(fvectorDouble);
			float num = (float)this.BlackBoard.ModelCenterOffsetX();
			this.BlackBoard.MeshCenterToHead = (float)this.BlackBoard.VehicleSize.X / 2f + num;
			this.BlackBoard.MeshCenterToTail = (float)this.BlackBoard.VehicleSize.X / 2f - num;
			this.BlackBoard.RootCenterToHead = this.BlackBoard.MeshCenterToHead + (float)this.BlackBoard.SkeletalMeshRelativeLocation.X;
			this.BlackBoard.RootCenterToTail = this.BlackBoard.MeshCenterToTail - (float)this.BlackBoard.SkeletalMeshRelativeLocation.X;
			this.BlackBoard.InitTrace();
			this.BlackBoard.IsLaunch = true;
		}

		// Token: 0x060255FF RID: 153087 RVA: 0x00A88E68 File Offset: 0x00A87068
		public void Destroy()
		{
			this.StateMachine.Destroy();
			UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
			if (currentRoadway != null)
			{
				VehicleStreamModel.Instance.ExitRoadway(currentRoadway.Id, this.BlackBoard.CreatureDataId);
			}
		}

		// Token: 0x06025600 RID: 153088 RVA: 0x00A88EAC File Offset: 0x00A870AC
		public void OnForceTick(float delta)
		{
			this.BlackBoard.TickNum++;
			this.BlackBoard.TimeSinceLastTick += delta;
			this.BlackBoard.UpdateSkeletalMeshDistance();
			this.BlackBoard.UpdateRtpc(delta);
			if (!VehicleStreamModel.Instance.EnableDebug)
			{
				return;
			}
			CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent roadNetworkNavigationComponent = this.BlackBoard.RoadNetworkNavigationComponent;
			FVectorDouble location = roadNetworkNavigationComponent.GetActorComponent().ActorTransform.GetLocation();
			FVectorDouble fvectorDouble = location;
			location.Z += this.BlackBoard.VehicleSize.Z;
			if (this.BlackBoard.SkeletalMeshComponent != null)
			{
				fvectorDouble = this.BlackBoard.SkeletalMeshComponent.D_K2_GetComponentToWorld().GetLocation();
				fvectorDouble.Z += this.BlackBoard.VehicleSize.Z;
			}
			FLinearColor flinearColor = new FLinearColor(1f, 0f, 0f, 1f);
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, fvectorDouble, location, 2000f, flinearColor, 0.05f, 10f);
			EVehicleStateType currentState = this.StateMachine.GetCurrentState();
			string value = roadNetworkNavigationComponent.GetModelBufferTime().ToString("F2");
			UObject world = GlobalData.World;
			FVectorDouble textLocation = fvectorDouble;
			string str = currentState.ToString();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			VehicleSmBlackBoard blackBoard = this.BlackBoard;
			defaultInterpolatedStringHandler.AppendFormatted<bool?>((blackBoard != null) ? new bool?(blackBoard.WaitingModelBuffer) : null);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.BlackBoard.RoadNetworkNavigationComponent.IsModelBufferCompTickEnabled());
			UKismetSystemLibrary.D_DrawDebugString(world, textLocation, str + defaultInterpolatedStringHandler.ToStringAndClear(), null, new FLinearColor?(flinearColor), 0f);
		}

		// Token: 0x06025601 RID: 153089 RVA: 0x00A89084 File Offset: 0x00A87284
		public void OnTick(ETickType tickType, float delta, int tickInterval)
		{
			if (this.BlackBoard.LastTickNum == this.BlackBoard.TickNum)
			{
				return;
			}
			this.BlackBoard.TimeSinceLastTick = 0f;
			this.BlackBoard.UpdateMoved = false;
			this.CheckWaitModelBuffer();
			this.StateMachine.Update(delta);
			if (this.BlackBoard.UpdateMoved)
			{
				this.UpdateActorLocationAndRotation(tickType, delta, tickInterval);
			}
			this.BlackBoard.LastTickNum = this.BlackBoard.TickNum;
		}

		// Token: 0x06025602 RID: 153090 RVA: 0x00A89105 File Offset: 0x00A87305
		public void OnEnterPlayerRange()
		{
			this.BlackBoard.IsInPlayerRange = true;
			this.StateMachine.OnEnterPlayerRange();
		}

		// Token: 0x06025603 RID: 153091 RVA: 0x00A89120 File Offset: 0x00A87320
		public void OnLeavePlayerRange()
		{
			this.BlackBoard.IsInPlayerRange = false;
			this.StateMachine.OnLeavePlayerRange();
			foreach (int eventHandle in this.BlackBoard.AudioHandleSet)
			{
				this.BlackBoard.StopAudio(eventHandle, false);
			}
			this.BlackBoard.AudioHandleSet.Clear();
		}

		// Token: 0x06025604 RID: 153092 RVA: 0x00A891A8 File Offset: 0x00A873A8
		private bool CheckWaitModelBuffer()
		{
			CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent roadNetworkNavigationComponent = this.BlackBoard.RoadNetworkNavigationComponent;
			if (this.BlackBoard.WaitingModelBuffer && roadNetworkNavigationComponent.HasModelBuffer())
			{
				return true;
			}
			this.BlackBoard.WaitingModelBuffer = false;
			bool flag = roadNetworkNavigationComponent.WasRecentlyRenderedOnScreen();
			if (flag && !this.BlackBoard.LastRenderOnScreen && roadNetworkNavigationComponent.HasModelBuffer())
			{
				this.BlackBoard.WaitingModelBuffer = true;
			}
			this.BlackBoard.LastRenderOnScreen = flag;
			return this.BlackBoard.WaitingModelBuffer;
		}

		// Token: 0x06025605 RID: 153093 RVA: 0x00A89226 File Offset: 0x00A87426
		private void UpdateActorLocationAndRotation(ETickType tickType, float delta, int tickInterval)
		{
			this.BlackBoard.RoadNetworkNavigationComponent.SetLocationAndRotation(this.BlackBoard.DesireLocation.ToUeVector(false), this.BlackBoard.DesireRotator.ToUeRotator(), tickType, delta, tickInterval);
		}

		// Token: 0x06025606 RID: 153094 RVA: 0x00A8925C File Offset: 0x00A8745C
		[NullableContext(2)]
		private bool SwitchState(EVehicleStateType state, string reason = null)
		{
			return this.StateMachine.Switch(state, reason);
		}

		// Token: 0x06025607 RID: 153095 RVA: 0x00A8926B File Offset: 0x00A8746B
		public float GetCurrentRootDistance()
		{
			return this.BlackBoard.CurrentRootDistance;
		}

		// Token: 0x06025608 RID: 153096 RVA: 0x00A89278 File Offset: 0x00A87478
		public float GetCurrentMeshCenterDistance()
		{
			return this.BlackBoard.CurrentMeshCenterDistance;
		}

		// Token: 0x06025609 RID: 153097 RVA: 0x00A89285 File Offset: 0x00A87485
		public float GetCurrentMeshHeadDistance()
		{
			return this.BlackBoard.CurrentMeshHeadDistance;
		}

		// Token: 0x0602560A RID: 153098 RVA: 0x00A89292 File Offset: 0x00A87492
		public float GetCurrentMeshTailDistance()
		{
			return this.BlackBoard.CurrentMeshTailDistance;
		}

		// Token: 0x0602560B RID: 153099 RVA: 0x00A8929F File Offset: 0x00A8749F
		public global::Vector GetRelativeLocation()
		{
			return this.BlackBoard.RelativeLocationToStart;
		}

		// Token: 0x0602560C RID: 153100 RVA: 0x00A892AC File Offset: 0x00A874AC
		public global::Vector GetDesireLocation()
		{
			return this.BlackBoard.DesireLocation;
		}

		// Token: 0x0602560D RID: 153101 RVA: 0x00A892B9 File Offset: 0x00A874B9
		public global::Rotator GetDesireRotator()
		{
			return this.BlackBoard.DesireRotator;
		}

		// Token: 0x0602560E RID: 153102 RVA: 0x00A892C6 File Offset: 0x00A874C6
		public global::Vector GetVehicleSize()
		{
			return this.BlackBoard.VehicleSize;
		}

		// Token: 0x0602560F RID: 153103 RVA: 0x00A892D3 File Offset: 0x00A874D3
		public float GetMeshCenterToTail()
		{
			return this.BlackBoard.MeshCenterToTail;
		}

		// Token: 0x06025610 RID: 153104 RVA: 0x00A892E0 File Offset: 0x00A874E0
		public float GetSpeed()
		{
			return this.BlackBoard.CurrentSpeed;
		}

		// Token: 0x06025611 RID: 153105 RVA: 0x00A892ED File Offset: 0x00A874ED
		public EEntityType? GetBlockTarget()
		{
			return this.BlackBoard.BlockTarget;
		}

		// Token: 0x06025612 RID: 153106 RVA: 0x00A892FA File Offset: 0x00A874FA
		public bool IsInBrakeState()
		{
			return this.StateMachine.GetCurrentState() == EVehicleStateType.Braking;
		}

		// Token: 0x04014B08 RID: 84744
		private readonly VehicleStateMachine StateMachine = new VehicleStateMachine();

		// Token: 0x04014B09 RID: 84745
		[Nullable(2)]
		private readonly VehicleSmBlackBoard BlackBoard;
	}
}

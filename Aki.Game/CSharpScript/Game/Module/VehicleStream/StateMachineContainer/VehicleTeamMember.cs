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
	// Token: 0x020048C0 RID: 18624
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleTeamMember : StateMachineContainer
	{
		// Token: 0x1700797C RID: 31100
		// (get) Token: 0x06030ACC RID: 199372 RVA: 0x00B4DD1E File Offset: 0x00B4BF1E
		public override EStateContainerType Type
		{
			get
			{
				return EStateContainerType.Vehicle;
			}
		}

		// Token: 0x1700797D RID: 31101
		// (get) Token: 0x06030ACD RID: 199373 RVA: 0x00B4DD21 File Offset: 0x00B4BF21
		public override int Id
		{
			get
			{
				return this.BlackBoard.PbDataId;
			}
		}

		// Token: 0x1700797E RID: 31102
		// (get) Token: 0x06030ACE RID: 199374 RVA: 0x00B4DD2E File Offset: 0x00B4BF2E
		public int TeamId
		{
			get
			{
				return this.BlackBoard.TeamId;
			}
		}

		// Token: 0x06030ACF RID: 199375 RVA: 0x00B4DD3C File Offset: 0x00B4BF3C
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

		// Token: 0x06030AD0 RID: 199376 RVA: 0x00B4DE6C File Offset: 0x00B4C06C
		private void AddState<[Nullable(0)] T>(EVehicleStateType stateType, Func<VehicleSmBlackBoard, T> ctor) where T : VehicleStateBase
		{
			T t = ctor(this.BlackBoard);
			t.Create();
			this.StateMachine.AddState(stateType, t);
		}

		// Token: 0x06030AD1 RID: 199377 RVA: 0x00B4DEA4 File Offset: 0x00B4C0A4
		public void Init()
		{
			this.AddState<BornState>(EVehicleStateType.Born, (VehicleSmBlackBoard board) => new BornState(board));
			this.AddState<RunningState>(EVehicleStateType.Running, (VehicleSmBlackBoard board) => new RunningState(board));
			this.AddState<BrakingState>(EVehicleStateType.Braking, (VehicleSmBlackBoard board) => new BrakingState(board));
			this.AddState<DestroyState>(EVehicleStateType.Destroy, (VehicleSmBlackBoard board) => new DestroyState(board));
			this.StateMachine.Start(EVehicleStateType.Born);
		}

		// Token: 0x06030AD2 RID: 199378 RVA: 0x00B4DF58 File Offset: 0x00B4C158
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

		// Token: 0x06030AD3 RID: 199379 RVA: 0x00B4E060 File Offset: 0x00B4C260
		public void Destroy()
		{
			this.StateMachine.Destroy();
			UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
			if (currentRoadway != null)
			{
				VehicleStreamModel.Instance.ExitRoadway(currentRoadway.Id, this.BlackBoard.CreatureDataId);
			}
		}

		// Token: 0x06030AD4 RID: 199380 RVA: 0x00B4E0A4 File Offset: 0x00B4C2A4
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

		// Token: 0x06030AD5 RID: 199381 RVA: 0x00B4E27C File Offset: 0x00B4C47C
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

		// Token: 0x06030AD6 RID: 199382 RVA: 0x00B4E2FD File Offset: 0x00B4C4FD
		public void OnEnterPlayerRange()
		{
			this.BlackBoard.IsInPlayerRange = true;
			this.StateMachine.OnEnterPlayerRange();
		}

		// Token: 0x06030AD7 RID: 199383 RVA: 0x00B4E318 File Offset: 0x00B4C518
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

		// Token: 0x06030AD8 RID: 199384 RVA: 0x00B4E3A0 File Offset: 0x00B4C5A0
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

		// Token: 0x06030AD9 RID: 199385 RVA: 0x00B4E41E File Offset: 0x00B4C61E
		private void UpdateActorLocationAndRotation(ETickType tickType, float delta, int tickInterval)
		{
			this.BlackBoard.RoadNetworkNavigationComponent.SetLocationAndRotation(this.BlackBoard.DesireLocation.ToUeVector(false), this.BlackBoard.DesireRotator.ToUeRotator(), tickType, delta, tickInterval);
		}

		// Token: 0x06030ADA RID: 199386 RVA: 0x00B4E454 File Offset: 0x00B4C654
		[NullableContext(2)]
		private bool SwitchState(EVehicleStateType state, string reason = null)
		{
			return this.StateMachine.Switch(state, reason);
		}

		// Token: 0x06030ADB RID: 199387 RVA: 0x00B4E463 File Offset: 0x00B4C663
		public float GetCurrentRootDistance()
		{
			return this.BlackBoard.CurrentRootDistance;
		}

		// Token: 0x06030ADC RID: 199388 RVA: 0x00B4E470 File Offset: 0x00B4C670
		public float GetCurrentMeshCenterDistance()
		{
			return this.BlackBoard.CurrentMeshCenterDistance;
		}

		// Token: 0x06030ADD RID: 199389 RVA: 0x00B4E47D File Offset: 0x00B4C67D
		public float GetCurrentMeshHeadDistance()
		{
			return this.BlackBoard.CurrentMeshHeadDistance;
		}

		// Token: 0x06030ADE RID: 199390 RVA: 0x00B4E48A File Offset: 0x00B4C68A
		public float GetCurrentMeshTailDistance()
		{
			return this.BlackBoard.CurrentMeshTailDistance;
		}

		// Token: 0x06030ADF RID: 199391 RVA: 0x00B4E497 File Offset: 0x00B4C697
		public global::Vector GetRelativeLocation()
		{
			return this.BlackBoard.RelativeLocationToStart;
		}

		// Token: 0x06030AE0 RID: 199392 RVA: 0x00B4E4A4 File Offset: 0x00B4C6A4
		public global::Vector GetDesireLocation()
		{
			return this.BlackBoard.DesireLocation;
		}

		// Token: 0x06030AE1 RID: 199393 RVA: 0x00B4E4B1 File Offset: 0x00B4C6B1
		public global::Rotator GetDesireRotator()
		{
			return this.BlackBoard.DesireRotator;
		}

		// Token: 0x06030AE2 RID: 199394 RVA: 0x00B4E4BE File Offset: 0x00B4C6BE
		public global::Vector GetVehicleSize()
		{
			return this.BlackBoard.VehicleSize;
		}

		// Token: 0x06030AE3 RID: 199395 RVA: 0x00B4E4CB File Offset: 0x00B4C6CB
		public float GetMeshCenterToTail()
		{
			return this.BlackBoard.MeshCenterToTail;
		}

		// Token: 0x06030AE4 RID: 199396 RVA: 0x00B4E4D8 File Offset: 0x00B4C6D8
		public float GetSpeed()
		{
			return this.BlackBoard.CurrentSpeed;
		}

		// Token: 0x06030AE5 RID: 199397 RVA: 0x00B4E4E5 File Offset: 0x00B4C6E5
		public EEntityType? GetBlockTarget()
		{
			return this.BlackBoard.BlockTarget;
		}

		// Token: 0x06030AE6 RID: 199398 RVA: 0x00B4E4F2 File Offset: 0x00B4C6F2
		public bool IsInBrakeState()
		{
			return this.StateMachine.GetCurrentState() == EVehicleStateType.Braking;
		}

		// Token: 0x0401A295 RID: 107157
		private readonly VehicleStateMachine StateMachine = new VehicleStateMachine();

		// Token: 0x0401A296 RID: 107158
		[Nullable(2)]
		private readonly VehicleSmBlackBoard BlackBoard;
	}
}

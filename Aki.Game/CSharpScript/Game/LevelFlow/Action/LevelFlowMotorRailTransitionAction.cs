using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F8E RID: 28558
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowMotorRailTransitionAction : LevelFlowActionBase
	{
		// Token: 0x0604571E RID: 284446 RVA: 0x01138A09 File Offset: 0x01136C09
		[NullableContext(1)]
		public LevelFlowMotorRailTransitionAction Init(int entityId, int splineEntityId)
		{
			this.EntityId = entityId;
			this.SplineEntityId = splineEntityId;
			return this;
		}

		// Token: 0x0604571F RID: 284447 RVA: 0x01138A1C File Offset: 0x01136C1C
		protected override void OnExecute()
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.EntityId);
			if (entityById == null || !entityById.IsInit || entityById.Entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[MoveWithSpline]实体无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false);
				return;
			}
			WorldEntity entity = entityById.Entity;
			this.ActorComp = entity.GetComponent<VehicleActorComponent>();
			if (this.ActorComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[MoveWithSpline]实体没有ActorComp";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", entity.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			if (entity.GetComponent<VehicleMoveComponent>() == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelFlow;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "[MoveWithSpline]实体没有MoveComp";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", entity.Id);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				base.FinishExecute(false);
				return;
			}
			USplineComponent usplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(this.SplineEntityId, entity.Id, EIdType.EntityId);
			SplineCurve splineCurve = new SplineCurve(10);
			splineCurve.Init(usplineComponent.SplineCurves.Position, usplineComponent.SplineCurves.ReparamTable.Points, usplineComponent.SplineCurves.Rotation, usplineComponent.SplineCurves.Scale);
			splineCurve.SetSplineTransform(Transform.Create(usplineComponent.D_GetSocketTransform(null, ERelativeTransformSpace.RTS_World)), true);
			MotorcycleRailMoveConfig other = new MotorcycleRailMoveConfig();
			MotorcycleJumpToRailMoveData motorcycleJumpToRailMoveData = new MotorcycleJumpToRailMoveData(entity, null);
			motorcycleJumpToRailMoveData.MoveConfig.DeepCopy(other);
			motorcycleJumpToRailMoveData.TargetSpline = splineCurve;
			motorcycleJumpToRailMoveData.GravityDir.DeepCopy(GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp));
			motorcycleJumpToRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleJumpToRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.MoveData = motorcycleJumpToRailMoveData;
			motorcycleJumpToRailMoveData.Enter(null);
		}

		// Token: 0x06045720 RID: 284448 RVA: 0x01138C18 File Offset: 0x01136E18
		protected override void OnTick(float deltaTime)
		{
			if (this.MoveData == null)
			{
				base.FinishExecute(false);
				return;
			}
			if (this.MoveData.IsFinishMove)
			{
				base.FinishExecute(true);
				return;
			}
			MotorcycleJumpToRailMoveData moveData = this.MoveData;
			if (moveData == null)
			{
				return;
			}
			moveData.Tick(deltaTime);
		}

		// Token: 0x06045721 RID: 284449 RVA: 0x01138C50 File Offset: 0x01136E50
		private void VehicleRailMoveUpdater(Vector loc, Rotator rot, Vector velocity, bool bSweep = true)
		{
			if (this.ActorComp == null)
			{
				return;
			}
			if (loc != null && rot != null)
			{
				this.ActorComp.SetActorLocationAndRotation(loc.ToUeVector(false), rot.ToUeRotator(), "LevelFlowMotorRailTransitionAction", false, null);
			}
			else if (loc != null)
			{
				this.ActorComp.SetActorLocation(loc.ToUeVector(false), "LevelFlowMotorRailTransitionAction", false);
			}
			else if (rot != null)
			{
				this.ActorComp.SetActorRotation(rot.ToUeRotator(), "LevelFlowMotorRailTransitionAction", false);
			}
			if (velocity != null)
			{
				VehicleMoveComponent vehicleMoveComp = this.ActorComp.VehicleMoveComp;
				UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (vehicleMoveComp != null) ? vehicleMoveComp.VehicleMovement : null;
				if (vehicleMoveComp != null)
				{
					vehicleMoveComp.SetForceSpeed(velocity);
				}
				UMotorWheelDisplayInfoObject umotorWheelDisplayInfoObject = (ukuroVehicleMovementComponent != null) ? ukuroVehicleMovementComponent.WheelDisplayInfosObj : null;
				if (umotorWheelDisplayInfoObject != null && umotorWheelDisplayInfoObject.DisplayInfos.Num() >= 2)
				{
					float wheelSpeed = (float)velocity.Size();
					umotorWheelDisplayInfoObject.DisplayInfos.Get(0).WheelSpeed = wheelSpeed;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(1).WheelSpeed = wheelSpeed;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(0).WheelAccel = 0f;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(1).WheelAccel = 0f;
				}
				this.ActorComp.ResetCachedVelocityTime();
			}
		}

		// Token: 0x06045722 RID: 284450 RVA: 0x01138D7C File Offset: 0x01136F7C
		private bool VehicleRailMoveGetter(Vector outLoc, Rotator outRot, Vector outVelocity)
		{
			if (this.ActorComp == null)
			{
				return false;
			}
			if (outLoc != null)
			{
				outLoc.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
			if (outRot != null)
			{
				outRot.DeepCopy(this.ActorComp.ActorRotationProxy);
			}
			if (outVelocity == null)
			{
				return true;
			}
			MotorcycleJumpToRailMoveData moveData = this.MoveData;
			if (moveData != null && moveData.GetVelocity(outVelocity))
			{
				return true;
			}
			TsBaseVehicle actor = this.ActorComp.Actor;
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (actor != null) ? actor.VehicleMovementComponent : null;
			if (ukuroVehicleMovementComponent != null && ukuroVehicleMovementComponent.IsValid())
			{
				FVector velocity = ukuroVehicleMovementComponent.Velocity;
				outVelocity.FromUeVector(velocity);
				return true;
			}
			AActor owner = this.ActorComp.Owner;
			FVectorDouble? fvectorDouble = (owner != null) ? new FVectorDouble?(owner.D_GetVelocity()) : null;
			if (fvectorDouble != null)
			{
				FVectorDouble value = fvectorDouble.Value;
				outVelocity.FromUeVector(value);
				return true;
			}
			return false;
		}

		// Token: 0x06045723 RID: 284451 RVA: 0x01138E50 File Offset: 0x01137050
		protected unsafe override void LogExecuteInfo()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SplineEntityId", this.SplineEntityId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x040243C2 RID: 148418
		private int EntityId;

		// Token: 0x040243C3 RID: 148419
		private int SplineEntityId;

		// Token: 0x040243C4 RID: 148420
		private VehicleActorComponent ActorComp;

		// Token: 0x040243C5 RID: 148421
		private MotorcycleJumpToRailMoveData MoveData;
	}
}

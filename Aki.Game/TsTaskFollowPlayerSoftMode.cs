using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A1 RID: 161
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowPlayerSoftMode.TsTaskFollowPlayerSoftMode_C")]
public class TsTaskFollowPlayerSoftMode : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000887 RID: 2183 RVA: 0x0002B6A4 File Offset: 0x000298A4
	// (set) Token: 0x06000888 RID: 2184 RVA: 0x0002B6DD File Offset: 0x000298DD
	[UProperty(EPropertyFlags.CPF_None)]
	public SFollowMoveInfo MoveInfo
	{
		get
		{
			base.FastCheckIsValid();
			SFollowMoveInfo result;
			if ((result = this._MoveInfo) == null)
			{
				result = (this._MoveInfo = new SFollowMoveInfo(base.NativePtr + (IntPtr)TsTaskFollowPlayerSoftMode.__PropertyOffset_MoveInfo, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SFollowMoveInfo.StaticStruct(), base.NativePtr + (IntPtr)TsTaskFollowPlayerSoftMode.__PropertyOffset_MoveInfo, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000889 RID: 2185 RVA: 0x0002B708 File Offset: 0x00029908
	// (set) Token: 0x0600088A RID: 2186 RVA: 0x0002B741 File Offset: 0x00029941
	[UProperty(EPropertyFlags.CPF_None)]
	public SFollowRotateInfo RotateInfo
	{
		get
		{
			base.FastCheckIsValid();
			SFollowRotateInfo result;
			if ((result = this._RotateInfo) == null)
			{
				result = (this._RotateInfo = new SFollowRotateInfo(base.NativePtr + (IntPtr)TsTaskFollowPlayerSoftMode.__PropertyOffset_RotateInfo, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SFollowRotateInfo.StaticStruct(), base.NativePtr + (IntPtr)TsTaskFollowPlayerSoftMode.__PropertyOffset_RotateInfo, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0002B76C File Offset: 0x0002996C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsOffset = Vector.Create();
			this.TempCameraForward = Vector.Create();
			this.TempTarget = Vector.Create();
			this.TempDirect = Vector.Create();
			this.TempVector = Vector.Create();
			this.TempDirection = Vector.Create();
			this.TempRotator = Rotator.Create();
			this.TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.TempInvertRotator1 = Rotator.Create();
			this.TempInvertRotator2 = Rotator.Create();
			if (this.MoveInfo != null)
			{
				this.TsFollowTargetType = this.MoveInfo.FollowTargetType;
				this.TsMoveEntityIdBlackboardKey = this.MoveInfo.EntityIdBlackboardKey;
				this.TsKeepDistanceMin = this.MoveInfo.KeepDistanceMin;
				this.TsDistanceMin = (float)this.MoveInfo.DistanceMin;
				this.TsDistanceMaxSpeed = (float)this.MoveInfo.DistanceMaxSpeed;
				this.TsDistanceSweepMove = (float)this.MoveInfo.DistanceMax;
				this.TsDistanceForceMove = (float)this.MoveInfo.DistanceForceMove;
				this.TsMaxMoveSpeed = (float)this.MoveInfo.MaxMoveSpeed;
				Vector tsOffset = this.TsOffset;
				FVector offset = this.MoveInfo.Offset;
				tsOffset.FromUeVector(offset);
				if (this.TsDistanceMaxSpeed <= this.TsDistanceMin)
				{
					this.TsDistanceMaxSpeed = this.TsDistanceSweepMove;
				}
			}
			else
			{
				this.TsFollowTargetType = EFollowTargetType.玩家当前控制角色;
				this.TsMoveEntityIdBlackboardKey = "";
				this.TsKeepDistanceMin = true;
				this.TsDistanceMin = 100f;
				this.TsDistanceMaxSpeed = 200f;
				this.TsDistanceSweepMove = 200f;
				this.TsDistanceForceMove = 300f;
				this.TsMaxMoveSpeed = 200f;
				this.TsOffset.Set(0.0, 0.0, 0.0);
			}
			this.TsMinSquared = this.TsDistanceMin * this.TsDistanceMin;
			this.TsSweepMoveSquared = this.TsDistanceSweepMove * this.TsDistanceSweepMove;
			if (this.RotateInfo != null)
			{
				this.TsRotateSpeed = (float)this.RotateInfo.RotateSpeed;
				this.TsRotateType = this.RotateInfo.RotateType;
				this.TsCameraDistance = (float)this.RotateInfo.CameraDistance;
				this.TsRotateEntityIdBlackboardKey = this.RotateInfo.EntityIdBlackboardKey;
				TArray<TEnumAsByte<ECommonAxis>> notSyncAxisList = this.RotateInfo.NotSyncAxisList;
				this.TsNotSyncAxisList = new List<ECommonAxis>();
				for (int i = 0; i < notSyncAxisList.Num(); i++)
				{
					this.TsNotSyncAxisList.Add(notSyncAxisList.Get(i));
				}
				return;
			}
			this.TsRotateSpeed = 2000f;
			this.TsRotateType = EFollowRotateType.朝向镜头前一定距离;
			this.TsCameraDistance = 1500f;
			this.TsRotateEntityIdBlackboardKey = "";
		}
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002BA60 File Offset: 0x00029C60
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFollowPlayerSoftMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFollowPlayerSoftMode.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0002BB10 File Offset: 0x00029D10
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp2 = aiController.CharActorComp;
		BaseMoveComponent moveComp;
		if (charActorComp2 == null)
		{
			moveComp = null;
		}
		else
		{
			Entity entity = charActorComp2.Entity;
			moveComp = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		}
		this.MoveComp = moveComp;
		CharacterActorComponent charActorComp3 = aiController.CharActorComp;
		if (charActorComp3 != null)
		{
			charActorComp3.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Flying,
				Context = "[TsTaskFollowPlayerSoftMode.ReceiveExecuteAI]"
			});
		}
		if (this.TraceElement == null)
		{
			this.TraceElement = new UTraceCapsuleElement();
			this.TraceElement.bIsSingle = true;
			this.TraceElement.bIgnoreSelf = true;
			this.TraceElement.WorldContextObject = charActorComp.Owner;
			this.TraceElement.HalfHeight = charActorComp.DefaultHalfHeight;
			this.TraceElement.Radius = charActorComp.DefaultRadius;
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0002BC64 File Offset: 0x00029E64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFollowPlayerSoftMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskFollowPlayerSoftMode.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x0002BD1C File Offset: 0x00029F1C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		if (this.MoveComp != null && this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Flying)
		{
			charActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Flying,
				Context = "[TsTaskFollowPlayerSoftMode.ReceiveTickAI]"
			});
		}
		BaseActorComponent baseActorComponent = null;
		switch (this.TsFollowTargetType)
		{
		case EFollowTargetType.玩家当前控制角色:
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			baseActorComponent = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			break;
		}
		case EFollowTargetType.伴生物召唤者:
		{
			CreatureDataComponent component = charActorComp.Entity.GetComponent<CreatureDataComponent>();
			long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
			if (num != null)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num.Value);
				BaseActorComponent baseActorComponent2;
				if (entity == null)
				{
					baseActorComponent2 = null;
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					baseActorComponent2 = ((entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null);
				}
				baseActorComponent = baseActorComponent2;
			}
			break;
		}
		case EFollowTargetType.指定实体:
			if (this.TsMoveEntityIdBlackboardKey != "")
			{
				int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(charActorComp.Entity.Id, this.TsRotateEntityIdBlackboardKey);
				if (entityIdByEntity != null)
				{
					Entity entity3 = EntitySystem.Instance.Get(entityIdByEntity.Value);
					baseActorComponent = ((entity3 != null) ? entity3.GetComponent<BaseActorComponent>() : null);
				}
			}
			break;
		case EFollowTargetType.玩家当前载具:
		{
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			CharacterDriveVehicleComponent characterDriveVehicleComponent;
			if (baseCharacter2 == null)
			{
				characterDriveVehicleComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter2.CharacterActorComponent;
				characterDriveVehicleComponent = ((characterActorComponent != null) ? characterActorComponent.Entity.CheckGetComponent<CharacterDriveVehicleComponent>() : null);
			}
			CharacterDriveVehicleComponent characterDriveVehicleComponent2 = characterDriveVehicleComponent;
			if (characterDriveVehicleComponent2 != null)
			{
				Entity vehicleEntity = characterDriveVehicleComponent2.VehicleEntity;
				if (vehicleEntity != null && vehicleEntity.Valid)
				{
					Entity vehicleEntity2 = characterDriveVehicleComponent2.VehicleEntity;
					baseActorComponent = ((vehicleEntity2 != null) ? vehicleEntity2.GetComponent<BaseActorComponent>() : null);
				}
			}
			break;
		}
		}
		if (baseActorComponent == null || !baseActorComponent.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		float num2 = deltaSeconds * charActorComp.Actor.CustomTimeDilation;
		this.UpdateRotate(charActorComp, num2);
		Vector actorLocationProxy = baseActorComponent.ActorLocationProxy;
		Vector actorLocationProxy2 = charActorComp.ActorLocationProxy;
		this.TempTarget.DeepCopy(actorLocationProxy);
		FTransformDouble actorTransform = baseActorComponent.ActorTransform;
		FVectorDouble fvectorDouble = this.TsOffset.ToUeVector(false);
		FVectorDouble fvectorDouble2 = actorTransform.TransformVector(fvectorDouble);
		this.TempVector.FromUeVector(fvectorDouble2);
		this.TempTarget.AdditionEqual(this.TempVector);
		this.TempTarget.Subtraction(actorLocationProxy2, this.TempVector);
		double num3 = this.TempVector.SizeSquared();
		if (!this.TsKeepDistanceMin && num3 < (double)this.TsMinSquared)
		{
			double num4 = this.TempTarget.Z - actorLocationProxy2.Z;
			if (Math.Abs(num4) >= 10.0)
			{
				this.TempVector.Set(0.0, 0.0, num4);
				this.LerpMove(this.TempVector, num2);
			}
			return;
		}
		actorLocationProxy2.Subtraction(this.TempTarget, this.TempVector);
		Vector.VectorPlaneProject(this.TempVector, baseActorComponent.ActorUpProxy, this.TempDirection);
		this.TempDirection.Normalize(9.99999993922529E-09);
		this.TempDirection.MultiplyEqual((double)this.TsDistanceMin);
		this.TempTarget.AdditionEqual(this.TempDirection);
		if (num3 < (double)this.TsSweepMoveSquared)
		{
			this.TempTarget.Subtraction(actorLocationProxy2, this.TempVector);
			this.LerpMove(this.TempVector, num2);
			return;
		}
		if (num3 < (double)(this.TsDistanceForceMove * this.TsDistanceForceMove))
		{
			charActorComp.SetActorLocation(this.TempTarget.ToUeVector(false), "FollowPlayerSoftMode", true);
			return;
		}
		if (!this.CheckObstacle(this.TempTarget, this.TempTarget))
		{
			charActorComp.SetActorLocation(this.TempTarget.ToUeVector(false), "FollowPlayerSoftMode", false);
			return;
		}
		float num5 = charActorComp.DefaultRadius * 2f;
		this.TempTarget.Subtraction(actorLocationProxy2, this.TempVector);
		double num6 = this.TempVector.Size();
		num6 -= (double)num5;
		if (num6 <= 0.0)
		{
			return;
		}
		this.TempVector.Normalize(9.99999993922529E-09);
		this.TempVector.MultiplyEqual(num6);
		actorLocationProxy2.Addition(this.TempVector, this.TempTarget);
		if (!this.CheckObstacle(this.TempTarget, this.TempTarget))
		{
			charActorComp.SetActorLocation(this.TempTarget.ToUeVector(false), "FollowPlayerSoftMode", false);
		}
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x0002C1DC File Offset: 0x0002A3DC
	private bool CheckObstacle(Vector startLocation, Vector endLocation)
	{
		if (this.TraceElement == null)
		{
			return false;
		}
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, startLocation);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, endLocation);
		if (TraceElementCommon.Instance.CapsuleTrace(this.TraceElement, "FollowPlayerHardMode"))
		{
			UKuroHitResult hitResult = this.TraceElement.HitResult;
			return hitResult != null && hitResult.bBlockingHit;
		}
		return false;
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0002C244 File Offset: 0x0002A444
	private void LerpMove(Vector moveVector, float scaledDeltaSeconds)
	{
		float num = this.TsDistanceMaxSpeed - this.TsDistanceMin;
		if (num < 0f)
		{
			return;
		}
		double num2 = moveVector.Size();
		double alpha = num2 / (double)num;
		double num3 = MathUtils.Instance.Lerp(0.0, (double)this.TsMaxMoveSpeed, alpha) * (double)scaledDeltaSeconds;
		if (num3 < num2)
		{
			moveVector.Normalize(9.99999993922529E-09);
			moveVector.MultiplyEqual(num3);
		}
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.MoveCharacter(moveVector, 1f, "FollowPlayerSoftMode");
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002C2CC File Offset: 0x0002A4CC
	private void UpdateRotate(CharacterActorComponent selfActorComp, float deltaSeconds)
	{
		if (this.MoveComp == null)
		{
			return;
		}
		Entity entity = selfActorComp.Entity;
		Entity entity2 = null;
		switch (this.TsRotateType)
		{
		case EFollowRotateType.朝向指定实体:
		case EFollowRotateType.同步指定实体:
			if (this.TsRotateEntityIdBlackboardKey != "")
			{
				int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(entity.Id, this.TsRotateEntityIdBlackboardKey);
				if (entityIdByEntity != null)
				{
					entity2 = EntitySystem.Instance.Get(entityIdByEntity.Value);
				}
			}
			break;
		case EFollowRotateType.朝向自身技能目标:
		{
			CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
			Entity entity3;
			if (component == null)
			{
				entity3 = null;
			}
			else
			{
				EntityHandle skillTarget = component.SkillTarget;
				entity3 = ((skillTarget != null) ? skillTarget.Entity : null);
			}
			entity2 = entity3;
			break;
		}
		}
		BaseActorComponent baseActorComponent = null;
		if (entity2 != null && entity2.Valid)
		{
			baseActorComponent = entity2.GetComponent<BaseActorComponent>();
		}
		if (baseActorComponent != null && this.TsRotateType == EFollowRotateType.同步指定实体)
		{
			this.TempRotator.DeepCopy(baseActorComponent.ActorRotationProxy);
		}
		else
		{
			if (baseActorComponent != null)
			{
				this.TempTarget.DeepCopy(baseActorComponent.ActorLocationProxy);
			}
			else
			{
				Vector tempTarget = this.TempTarget;
				FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetCameraLocation();
				tempTarget.FromUeVector(fvectorDouble);
				Vector tempCameraForward = this.TempCameraForward;
				FVector actorForwardVector = Global.CharacterCameraManager.GetActorForwardVector();
				tempCameraForward.FromUeVector(actorForwardVector);
				this.TempTarget.AdditionEqual(this.TempCameraForward.MultiplyEqual((double)this.TsCameraDistance));
			}
			this.TempDirect.DeepCopy(this.TempTarget);
			this.TempDirect.Subtraction(selfActorComp.ActorLocationProxy, this.TempDirect);
			MathUtils.Instance.LookRotationForwardFirst(this.TempDirect, this.MoveComp.GravityUp, this.TempRotator);
		}
		if (this.TsNotSyncAxisList.Count <= 0)
		{
			this.MoveComp.SmoothCharacterRotation(this.TempRotator, this.TsRotateSpeed, deltaSeconds, false, "FollowPlayerSoftMode", true);
			return;
		}
		bool isStandardGravity = this.MoveComp.IsStandardGravity;
		if (isStandardGravity)
		{
			this.TempInvertRotator1.DeepCopy(this.TempRotator);
			this.TempInvertRotator2.DeepCopy(selfActorComp.ActorRotationProxy);
		}
		else
		{
			Quat.FindBetween(Vector.UpVectorProxy, this.MoveComp.GravityUp, this.TempQuat);
			GravityUtils.Instance.GetRotatorInNormal(this.TempRotator, this.TempQuat, this.TempInvertRotator1);
			GravityUtils.Instance.GetRotatorInNormal(selfActorComp.ActorRotationProxy, this.TempQuat, this.TempInvertRotator2);
		}
		foreach (ECommonAxis ecommonAxis in this.TsNotSyncAxisList)
		{
			if (ecommonAxis == ECommonAxis.X)
			{
				this.TempInvertRotator1.Roll = this.TempInvertRotator2.Roll;
			}
			else if (ecommonAxis == ECommonAxis.Y)
			{
				this.TempInvertRotator1.Pitch = this.TempInvertRotator2.Pitch;
			}
			else if (ecommonAxis == ECommonAxis.Z)
			{
				this.TempInvertRotator1.Yaw = this.TempInvertRotator2.Yaw;
			}
		}
		if (isStandardGravity)
		{
			this.TempRotator.DeepCopy(this.TempInvertRotator1);
		}
		else
		{
			this.TempQuat.Inverse(this.TempQuat);
			GravityUtils.Instance.GetRotatorInGravity(this.TempInvertRotator1, this.TempQuat, this.TempRotator);
		}
		this.MoveComp.SmoothCharacterRotation(this.TempRotator, this.TsRotateSpeed, deltaSeconds, false, "FollowPlayerSoftMode", true);
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002C608 File Offset: 0x0002A808
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFollowPlayerSoftMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowPlayerSoftMode.TsTaskFollowPlayerSoftMode_C");
		}
		return TsTaskFollowPlayerSoftMode._ClassPtr;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0002C62C File Offset: 0x0002A82C
	public TsTaskFollowPlayerSoftMode() : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowPlayerSoftMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x0002C654 File Offset: 0x0002A854
	public TsTaskFollowPlayerSoftMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowPlayerSoftMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x0002C688 File Offset: 0x0002A888
	protected TsTaskFollowPlayerSoftMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0002C758 File Offset: 0x0002A958
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0002C788 File Offset: 0x0002A988
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000674 RID: 1652
	private const float START_MOVE_HEIGHT_LIMIT = 10f;

	// Token: 0x04000675 RID: 1653
	private EFollowTargetType TsFollowTargetType;

	// Token: 0x04000676 RID: 1654
	private string TsMoveEntityIdBlackboardKey = "";

	// Token: 0x04000677 RID: 1655
	private bool TsKeepDistanceMin = true;

	// Token: 0x04000678 RID: 1656
	private float TsDistanceMin;

	// Token: 0x04000679 RID: 1657
	private float TsMinSquared;

	// Token: 0x0400067A RID: 1658
	private float TsDistanceMaxSpeed;

	// Token: 0x0400067B RID: 1659
	private float TsDistanceSweepMove;

	// Token: 0x0400067C RID: 1660
	private float TsSweepMoveSquared;

	// Token: 0x0400067D RID: 1661
	private float TsDistanceForceMove;

	// Token: 0x0400067E RID: 1662
	private float TsMaxMoveSpeed;

	// Token: 0x0400067F RID: 1663
	private Vector TsOffset = Vector.Create();

	// Token: 0x04000680 RID: 1664
	private float TsRotateSpeed;

	// Token: 0x04000681 RID: 1665
	private EFollowRotateType TsRotateType;

	// Token: 0x04000682 RID: 1666
	private string TsRotateEntityIdBlackboardKey = "";

	// Token: 0x04000683 RID: 1667
	private float TsCameraDistance;

	// Token: 0x04000684 RID: 1668
	private List<ECommonAxis> TsNotSyncAxisList = new List<ECommonAxis>();

	// Token: 0x04000685 RID: 1669
	private bool IsInitTsVariables;

	// Token: 0x04000686 RID: 1670
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x04000687 RID: 1671
	[Nullable(2)]
	private UTraceCapsuleElement TraceElement;

	// Token: 0x04000688 RID: 1672
	private Vector TempCameraForward = Vector.Create();

	// Token: 0x04000689 RID: 1673
	private Vector TempTarget = Vector.Create();

	// Token: 0x0400068A RID: 1674
	private Vector TempDirect = Vector.Create();

	// Token: 0x0400068B RID: 1675
	private Vector TempVector = Vector.Create();

	// Token: 0x0400068C RID: 1676
	private Vector TempDirection = Vector.Create();

	// Token: 0x0400068D RID: 1677
	private Rotator TempRotator = Rotator.Create();

	// Token: 0x0400068E RID: 1678
	private Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400068F RID: 1679
	private Rotator TempInvertRotator1 = Rotator.Create();

	// Token: 0x04000690 RID: 1680
	private Rotator TempInvertRotator2 = Rotator.Create();

	// Token: 0x04000691 RID: 1681
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowPlayerSoftMode.TsTaskFollowPlayerSoftMode_C";

	// Token: 0x04000692 RID: 1682
	private static IntPtr _ClassPtr;

	// Token: 0x04000693 RID: 1683
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000694 RID: 1684
	private static int __PropertyOffset_MoveInfo;

	// Token: 0x04000695 RID: 1685
	[Nullable(2)]
	private SFollowMoveInfo _MoveInfo;

	// Token: 0x04000696 RID: 1686
	private static int __PropertyOffset_RotateInfo;

	// Token: 0x04000697 RID: 1687
	[Nullable(2)]
	private SFollowRotateInfo _RotateInfo;
}

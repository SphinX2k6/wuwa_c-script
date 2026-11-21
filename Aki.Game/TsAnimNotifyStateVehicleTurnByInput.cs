using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000188 RID: 392
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleTurnByInput.TsAnimNotifyStateVehicleTurnByInput_C")]
public class TsAnimNotifyStateVehicleTurnByInput : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x0600192C RID: 6444 RVA: 0x00088CE7 File Offset: 0x00086EE7
	// (set) Token: 0x0600192D RID: 6445 RVA: 0x00088CF7 File Offset: 0x00086EF7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x0600192E RID: 6446 RVA: 0x00088D08 File Offset: 0x00086F08
	// (set) Token: 0x0600192F RID: 6447 RVA: 0x00088D18 File Offset: 0x00086F18
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableMinSpeedFixUp
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_EnableMinSpeedFixUp) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_EnableMinSpeedFixUp) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06001930 RID: 6448 RVA: 0x00088D29 File Offset: 0x00086F29
	// (set) Token: 0x06001931 RID: 6449 RVA: 0x00088D39 File Offset: 0x00086F39
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_MinSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_MinSpeed) = value;
		}
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06001932 RID: 6450 RVA: 0x00088D4A File Offset: 0x00086F4A
	// (set) Token: 0x06001933 RID: 6451 RVA: 0x00088D5A File Offset: 0x00086F5A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableRollBalanceFixUp
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_EnableRollBalanceFixUp) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_EnableRollBalanceFixUp) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06001934 RID: 6452 RVA: 0x00088D6B File Offset: 0x00086F6B
	// (set) Token: 0x06001935 RID: 6453 RVA: 0x00088D7B File Offset: 0x00086F7B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RollInterpolationSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_RollInterpolationSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleTurnByInput.__PropertyOffset_RollInterpolationSpeed) = value;
		}
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00088D8C File Offset: 0x00086F8C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleTurnByInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateVehicleTurnByInput.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x00088E4C File Offset: 0x0008704C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (owner as TsBaseVehicle).VehicleActorComponent;
		Entity entity = (vehicleActorComponent != null) ? vehicleActorComponent.Entity : null;
		VehicleMoveComponent vehicleMoveComponent = (entity != null) ? entity.GetComponent<VehicleMoveComponent>() : null;
		if (vehicleActorComponent == null || vehicleMoveComponent == null)
		{
			return false;
		}
		this.KeepVelocity(owner as TsBaseVehicle);
		return true;
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x00088EA4 File Offset: 0x000870A4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleTurnByInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateVehicleTurnByInput.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00088F64 File Offset: 0x00087164
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseVehicle tsBaseVehicle = meshComp.GetOwner() as TsBaseVehicle;
		if (tsBaseVehicle == null)
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = tsBaseVehicle.VehicleActorComponent;
		Vector inputDirectProxy = tsBaseVehicle.VehicleActorComponent.InputDirectProxy;
		GravityUtils.Instance.GetBaseQuatInGravityForActor(vehicleActorComponent, TsAnimNotifyStateVehicleTurnByInput.TmpQuat);
		TsAnimNotifyStateVehicleTurnByInput.TmpQuat.Inverse(TsAnimNotifyStateVehicleTurnByInput.TmpQuat2);
		double num = (double)this.TurnSpeed * inputDirectProxy.Y * (double)frameDeltaTime;
		TsAnimNotifyStateVehicleTurnByInput.TmpRotator.Set(0f, (float)num, 0f);
		TsAnimNotifyStateVehicleTurnByInput.TmpQuat.Multiply(TsAnimNotifyStateVehicleTurnByInput.TmpRotator.Quaternion(null), TsAnimNotifyStateVehicleTurnByInput.TmpQuat3);
		TsAnimNotifyStateVehicleTurnByInput.TmpQuat3.Multiply(TsAnimNotifyStateVehicleTurnByInput.TmpQuat2, TsAnimNotifyStateVehicleTurnByInput.TmpQuat);
		TsAnimNotifyStateVehicleTurnByInput.TmpQuat.RotateVector(vehicleActorComponent.ActorVelocityProxy, TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
		vehicleActorComponent.VehicleMoveComp.SetForceSpeed(TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
		TsAnimNotifyStateVehicleTurnByInput.TmpQuat.Multiply(vehicleActorComponent.ActorQuatProxy, TsAnimNotifyStateVehicleTurnByInput.TmpQuat2);
		TsAnimNotifyStateVehicleTurnByInput.TmpQuat3.DeepCopy(TsAnimNotifyStateVehicleTurnByInput.TmpQuat2);
		if (this.EnableRollBalanceFixUp)
		{
			Vector.CrossProduct(vehicleActorComponent.ActorForwardProxy, vehicleActorComponent.ActorGravityDirectProxy, TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
			double value = Vector.DotProduct(vehicleActorComponent.ActorRightProxy, TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
			double currentValue = Vector.DotProduct(vehicleActorComponent.ActorUpProxy, TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
			double num2 = 90.0 - Math.Acos(MathUtils.Instance.Clamp(currentValue, -1.0, 1.0)) * 57.295780181884766;
			double num3 = MathUtils.Instance.RotatorAxisInterpTo(num2, 0.0, (double)frameDeltaTime, (double)this.RollInterpolationSpeed);
			double num4 = (double)Math.Sign(value) * (num3 - num2);
			TsAnimNotifyStateVehicleTurnByInput.TmpRotator.Set(0f, 0f, (float)num4);
			TsAnimNotifyStateVehicleTurnByInput.TmpQuat2.Multiply(TsAnimNotifyStateVehicleTurnByInput.TmpRotator.Quaternion(null), TsAnimNotifyStateVehicleTurnByInput.TmpQuat3);
		}
		if (vehicleActorComponent != null)
		{
			vehicleActorComponent.SetActorRotation(TsAnimNotifyStateVehicleTurnByInput.TmpQuat3.Rotator(null).ToUeRotator(), "TsAnsVehicleTurnByInput", true);
		}
		return true;
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x00089150 File Offset: 0x00087350
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleTurnByInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateVehicleTurnByInput.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x00089206 File Offset: 0x00087406
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return meshComp.GetOwner() is TsBaseCharacter;
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x00089218 File Offset: 0x00087418
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleTurnByInput) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateVehicleTurnByInput.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x000892A8 File Offset: 0x000874A8
	protected override string GetNotifyName_Implementation()
	{
		return "输入改变载具速度和旋转";
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x000892B0 File Offset: 0x000874B0
	private bool KeepVelocity(TsBaseVehicle owner)
	{
		if (!this.EnableMinSpeedFixUp)
		{
			return true;
		}
		VehicleActorComponent vehicleActorComponent = owner.VehicleActorComponent;
		VehicleMoveComponent vehicleMoveComponent = (vehicleActorComponent != null) ? vehicleActorComponent.VehicleMoveComp : null;
		if (vehicleMoveComponent == null)
		{
			return false;
		}
		UKuroVehicleMovementComponent vehicleMovement = vehicleMoveComponent.VehicleMovement;
		if (vehicleMovement != null && vehicleMovement.MotorSubState == EMotorSubState.AirMoving)
		{
			return this.KeepVelocityFromAir(owner);
		}
		return this.KeepVelocityFromGround(owner);
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00089308 File Offset: 0x00087508
	private bool KeepVelocityFromGround(TsBaseVehicle owner)
	{
		VehicleActorComponent vehicleActorComponent = owner.VehicleActorComponent;
		if (vehicleActorComponent == null)
		{
			return false;
		}
		double num = Vector.DotProduct(vehicleActorComponent.ActorForwardProxy, vehicleActorComponent.ActorGravityDirectProxy);
		TsAnimNotifyStateVehicleTurnByInput.TmpVector1.DeepCopy(vehicleActorComponent.ActorForwardProxy);
		if (num > 0.0)
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(vehicleActorComponent, TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
			TsAnimNotifyStateVehicleTurnByInput.TmpVector1.Normalize(9.99999993922529E-09);
		}
		TsAnimNotifyStateVehicleTurnByInput.TmpVector1.Multiply(Vector.DotProduct(vehicleActorComponent.ActorVelocityProxy, TsAnimNotifyStateVehicleTurnByInput.TmpVector1), TsAnimNotifyStateVehicleTurnByInput.TmpVector2);
		if (TsAnimNotifyStateVehicleTurnByInput.TmpVector2.SizeSquared() < (double)(this.MinSpeed * this.MinSpeed))
		{
			TsAnimNotifyStateVehicleTurnByInput.TmpVector1.Multiply((double)this.MinSpeed, TsAnimNotifyStateVehicleTurnByInput.TmpVector2);
		}
		vehicleActorComponent.VehicleMoveComp.SetForceSpeed(TsAnimNotifyStateVehicleTurnByInput.TmpVector2);
		UKuroVehicleMovementComponent vehicleMovement = vehicleActorComponent.VehicleMoveComp.VehicleMovement;
		if (vehicleMovement != null && vehicleMovement.MotorSubState == EMotorSubState.Stop)
		{
			vehicleActorComponent.VehicleMoveComp.SetMotorSubState(EMotorSubState.TwoWheelMoving, ESetMotorSubStateSource.AnimNotifyTurnByInput);
		}
		return true;
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00089400 File Offset: 0x00087600
	private bool KeepVelocityFromAir(TsBaseVehicle owner)
	{
		VehicleActorComponent vehicleActorComponent = owner.VehicleActorComponent;
		if (vehicleActorComponent == null)
		{
			return false;
		}
		TsAnimNotifyStateVehicleTurnByInput.TmpVector1.DeepCopy(vehicleActorComponent.ActorForwardProxy);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(vehicleActorComponent, TsAnimNotifyStateVehicleTurnByInput.TmpVector1);
		TsAnimNotifyStateVehicleTurnByInput.TmpVector1.Normalize(9.99999993922529E-09);
		TsAnimNotifyStateVehicleTurnByInput.TmpVector1.Multiply(Vector.DotProduct(vehicleActorComponent.ActorVelocityProxy, TsAnimNotifyStateVehicleTurnByInput.TmpVector1), TsAnimNotifyStateVehicleTurnByInput.TmpVector2);
		if (TsAnimNotifyStateVehicleTurnByInput.TmpVector2.SizeSquared() < (double)(this.MinSpeed * this.MinSpeed))
		{
			TsAnimNotifyStateVehicleTurnByInput.TmpVector1.Multiply((double)this.MinSpeed, TsAnimNotifyStateVehicleTurnByInput.TmpVector2);
		}
		vehicleActorComponent.VehicleMoveComp.SetForceSpeed(TsAnimNotifyStateVehicleTurnByInput.TmpVector2);
		UKuroVehicleMovementComponent vehicleMovement = vehicleActorComponent.VehicleMoveComp.VehicleMovement;
		if (vehicleMovement != null && vehicleMovement.MotorSubState == EMotorSubState.Stop)
		{
			vehicleActorComponent.VehicleMoveComp.SetMotorSubState(EMotorSubState.AirMoving, ESetMotorSubStateSource.AnimNotifyTurnByInput);
		}
		return true;
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x000894D9 File Offset: 0x000876D9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVehicleTurnByInput._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleTurnByInput.TsAnimNotifyStateVehicleTurnByInput_C");
		}
		return TsAnimNotifyStateVehicleTurnByInput._ClassPtr;
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00089500 File Offset: 0x00087700
	public TsAnimNotifyStateVehicleTurnByInput() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleTurnByInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00089528 File Offset: 0x00087728
	public TsAnimNotifyStateVehicleTurnByInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleTurnByInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x0008955B File Offset: 0x0008775B
	protected TsAnimNotifyStateVehicleTurnByInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00089564 File Offset: 0x00087764
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x000895A0 File Offset: 0x000877A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x000895DC File Offset: 0x000877DC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x0008960F File Offset: 0x0008780F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010A1 RID: 4257
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x040010A2 RID: 4258
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x040010A3 RID: 4259
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x040010A4 RID: 4260
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040010A5 RID: 4261
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040010A6 RID: 4262
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040010A7 RID: 4263
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleTurnByInput.TsAnimNotifyStateVehicleTurnByInput_C";

	// Token: 0x040010A8 RID: 4264
	private static IntPtr _ClassPtr;

	// Token: 0x040010A9 RID: 4265
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010AA RID: 4266
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040010AB RID: 4267
	private static int __PropertyOffset_EnableMinSpeedFixUp;

	// Token: 0x040010AC RID: 4268
	private static int __PropertyOffset_MinSpeed;

	// Token: 0x040010AD RID: 4269
	private static int __PropertyOffset_EnableRollBalanceFixUp;

	// Token: 0x040010AE RID: 4270
	private static int __PropertyOffset_RollInterpolationSpeed;
}

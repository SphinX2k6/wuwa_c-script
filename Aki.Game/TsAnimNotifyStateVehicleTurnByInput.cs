using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000184 RID: 388
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleTurnByInput.TsAnimNotifyStateVehicleTurnByInput_C")]
public class TsAnimNotifyStateVehicleTurnByInput : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x0600188F RID: 6287 RVA: 0x00082C3B File Offset: 0x00080E3B
	// (set) Token: 0x06001890 RID: 6288 RVA: 0x00082C4B File Offset: 0x00080E4B
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

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06001891 RID: 6289 RVA: 0x00082C5C File Offset: 0x00080E5C
	// (set) Token: 0x06001892 RID: 6290 RVA: 0x00082C6C File Offset: 0x00080E6C
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

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06001893 RID: 6291 RVA: 0x00082C7D File Offset: 0x00080E7D
	// (set) Token: 0x06001894 RID: 6292 RVA: 0x00082C8D File Offset: 0x00080E8D
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

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001895 RID: 6293 RVA: 0x00082C9E File Offset: 0x00080E9E
	// (set) Token: 0x06001896 RID: 6294 RVA: 0x00082CAE File Offset: 0x00080EAE
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

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06001897 RID: 6295 RVA: 0x00082CBF File Offset: 0x00080EBF
	// (set) Token: 0x06001898 RID: 6296 RVA: 0x00082CCF File Offset: 0x00080ECF
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

	// Token: 0x06001899 RID: 6297 RVA: 0x00082CE0 File Offset: 0x00080EE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00082D88 File Offset: 0x00080F88
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

	// Token: 0x0600189B RID: 6299 RVA: 0x00082DE0 File Offset: 0x00080FE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x00082E88 File Offset: 0x00081088
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

	// Token: 0x0600189D RID: 6301 RVA: 0x00083074 File Offset: 0x00081274
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00083113 File Offset: 0x00081313
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return meshComp.GetOwner() is TsBaseCharacter;
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x00083128 File Offset: 0x00081328
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x000831A3 File Offset: 0x000813A3
	protected override string GetNotifyName_Implementation()
	{
		return "输入改变载具速度和旋转";
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x000831AC File Offset: 0x000813AC
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

	// Token: 0x060018A2 RID: 6306 RVA: 0x00083204 File Offset: 0x00081404
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
			vehicleActorComponent.VehicleMoveComp.SetMotorSubState(EMotorSubState.TwoWheelMoving);
		}
		return true;
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x000832F8 File Offset: 0x000814F8
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
			vehicleActorComponent.VehicleMoveComp.SetMotorSubState(EMotorSubState.AirMoving);
		}
		return true;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x000833D0 File Offset: 0x000815D0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVehicleTurnByInput._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleTurnByInput.TsAnimNotifyStateVehicleTurnByInput_C");
		}
		return TsAnimNotifyStateVehicleTurnByInput._ClassPtr;
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x000833F4 File Offset: 0x000815F4
	public TsAnimNotifyStateVehicleTurnByInput() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleTurnByInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x0008341C File Offset: 0x0008161C
	public TsAnimNotifyStateVehicleTurnByInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleTurnByInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x0008344F File Offset: 0x0008164F
	protected TsAnimNotifyStateVehicleTurnByInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x00083458 File Offset: 0x00081658
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00083494 File Offset: 0x00081694
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x000834D0 File Offset: 0x000816D0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x00083503 File Offset: 0x00081703
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400105E RID: 4190
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x0400105F RID: 4191
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04001060 RID: 4192
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x04001061 RID: 4193
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001062 RID: 4194
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001063 RID: 4195
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001064 RID: 4196
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleTurnByInput.TsAnimNotifyStateVehicleTurnByInput_C";

	// Token: 0x04001065 RID: 4197
	private static IntPtr _ClassPtr;

	// Token: 0x04001066 RID: 4198
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001067 RID: 4199
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04001068 RID: 4200
	private static int __PropertyOffset_EnableMinSpeedFixUp;

	// Token: 0x04001069 RID: 4201
	private static int __PropertyOffset_MinSpeed;

	// Token: 0x0400106A RID: 4202
	private static int __PropertyOffset_EnableRollBalanceFixUp;

	// Token: 0x0400106B RID: 4203
	private static int __PropertyOffset_RollInterpolationSpeed;
}

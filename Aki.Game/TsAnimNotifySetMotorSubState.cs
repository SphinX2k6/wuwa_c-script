using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DA RID: 474
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMotorSubState.TsAnimNotifySetMotorSubState_C")]
public class TsAnimNotifySetMotorSubState : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0009ADD7 File Offset: 0x00098FD7
	// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0009ADE7 File Offset: 0x00098FE7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EMotorSubState SubState
	{
		get
		{
			return (EMotorSubState)(*(base.NativePtr + (IntPtr)TsAnimNotifySetMotorSubState.__PropertyOffset_SubState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySetMotorSubState.__PropertyOffset_SubState) = (byte)value;
		}
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x0009ADF8 File Offset: 0x00098FF8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySetMotorSubState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySetMotorSubState.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x0009AEB0 File Offset: 0x000990B0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseVehicle tsBaseVehicle = meshComp.GetOwner() as TsBaseVehicle;
		if (tsBaseVehicle != null)
		{
			UKuroVehicleMovementComponent vehicleMovementComponent = tsBaseVehicle.VehicleMovementComponent;
			if (vehicleMovementComponent != null)
			{
				vehicleMovementComponent.SetMotorSubState(this.SubState);
			}
		}
		return true;
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x0009AEE4 File Offset: 0x000990E4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySetMotorSubState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySetMotorSubState.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x0009AF74 File Offset: 0x00099174
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置摩托移动模式";
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x0009AF7B File Offset: 0x0009917B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetMotorSubState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMotorSubState.TsAnimNotifySetMotorSubState_C");
		}
		return TsAnimNotifySetMotorSubState._ClassPtr;
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x0009AFA0 File Offset: 0x000991A0
	public TsAnimNotifySetMotorSubState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMotorSubState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x0009AFC8 File Offset: 0x000991C8
	[NullableContext(1)]
	public TsAnimNotifySetMotorSubState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMotorSubState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x0009AFFB File Offset: 0x000991FB
	protected TsAnimNotifySetMotorSubState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x0009B004 File Offset: 0x00099204
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x0009B037 File Offset: 0x00099237
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001282 RID: 4738
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMotorSubState.TsAnimNotifySetMotorSubState_C";

	// Token: 0x04001283 RID: 4739
	private static IntPtr _ClassPtr;

	// Token: 0x04001284 RID: 4740
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001285 RID: 4741
	private static int __PropertyOffset_SubState;
}

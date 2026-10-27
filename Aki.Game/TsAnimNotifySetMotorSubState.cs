using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D6 RID: 470
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMotorSubState.TsAnimNotifySetMotorSubState_C")]
public class TsAnimNotifySetMotorSubState : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00093F67 File Offset: 0x00092167
	// (set) Token: 0x06001D4C RID: 7500 RVA: 0x00093F77 File Offset: 0x00092177
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

	// Token: 0x06001D4D RID: 7501 RVA: 0x00093F88 File Offset: 0x00092188
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001D4E RID: 7502 RVA: 0x00094028 File Offset: 0x00092228
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

	// Token: 0x06001D4F RID: 7503 RVA: 0x0009405C File Offset: 0x0009225C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001D50 RID: 7504 RVA: 0x000940D7 File Offset: 0x000922D7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置摩托移动模式";
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x000940DE File Offset: 0x000922DE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetMotorSubState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMotorSubState.TsAnimNotifySetMotorSubState_C");
		}
		return TsAnimNotifySetMotorSubState._ClassPtr;
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x00094104 File Offset: 0x00092304
	public TsAnimNotifySetMotorSubState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMotorSubState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x0009412C File Offset: 0x0009232C
	[NullableContext(1)]
	public TsAnimNotifySetMotorSubState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMotorSubState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x0009415F File Offset: 0x0009235F
	protected TsAnimNotifySetMotorSubState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x00094168 File Offset: 0x00092368
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x0009419B File Offset: 0x0009239B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400123F RID: 4671
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMotorSubState.TsAnimNotifySetMotorSubState_C";

	// Token: 0x04001240 RID: 4672
	private static IntPtr _ClassPtr;

	// Token: 0x04001241 RID: 4673
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001242 RID: 4674
	private static int __PropertyOffset_SubState;
}

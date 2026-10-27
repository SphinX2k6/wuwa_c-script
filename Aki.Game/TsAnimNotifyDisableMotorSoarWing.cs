using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B1 RID: 433
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableMotorSoarWing.TsAnimNotifyDisableMotorSoarWing_C")]
public class TsAnimNotifyDisableMotorSoarWing : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001B4F RID: 6991 RVA: 0x0008D024 File Offset: 0x0008B224
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

	// Token: 0x06001B50 RID: 6992 RVA: 0x0008D0C4 File Offset: 0x0008B2C4
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseVehicle).GetEntityNoBlueprint();
		MotorcycleOutlookComponent motorcycleOutlookComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<MotorcycleOutlookComponent>() : null;
		if (motorcycleOutlookComponent == null)
		{
			return false;
		}
		motorcycleOutlookComponent.DisableSoarWing();
		return true;
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x0008D108 File Offset: 0x0008B308
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

	// Token: 0x06001B52 RID: 6994 RVA: 0x0008D183 File Offset: 0x0008B383
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏摩托翱翔翼";
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x0008D18A File Offset: 0x0008B38A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDisableMotorSoarWing._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableMotorSoarWing.TsAnimNotifyDisableMotorSoarWing_C");
		}
		return TsAnimNotifyDisableMotorSoarWing._ClassPtr;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x0008D1B0 File Offset: 0x0008B3B0
	public TsAnimNotifyDisableMotorSoarWing() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableMotorSoarWing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x0008D1D8 File Offset: 0x0008B3D8
	[NullableContext(1)]
	public TsAnimNotifyDisableMotorSoarWing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableMotorSoarWing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x0008D20B File Offset: 0x0008B40B
	protected TsAnimNotifyDisableMotorSoarWing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x0008D214 File Offset: 0x0008B414
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x0008D247 File Offset: 0x0008B447
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400117B RID: 4475
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableMotorSoarWing.TsAnimNotifyDisableMotorSoarWing_C";

	// Token: 0x0400117C RID: 4476
	private static IntPtr _ClassPtr;

	// Token: 0x0400117D RID: 4477
	private static IntPtr _ClassDefaultObjectPtr;
}

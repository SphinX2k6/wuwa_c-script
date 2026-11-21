using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019D RID: 413
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakConstraint.TsAnimNotifyBreakConstraint_C")]
public class TsAnimNotifyBreakConstraint : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0008F09F File Offset: 0x0008D29F
	// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0008F0B3 File Offset: 0x0008D2B3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 分离骨骼名
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_分离骨骼名);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_分离骨骼名) = value;
		}
	}

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0008F0C8 File Offset: 0x0008D2C8
	// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0008F0DC File Offset: 0x0008D2DC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Impulse
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_Impulse);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_Impulse) = value;
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0008F0F1 File Offset: 0x0008D2F1
	// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0008F105 File Offset: 0x0008D305
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector HitLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_HitLocation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_HitLocation) = value;
		}
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x0008F11C File Offset: 0x0008D31C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBreakConstraint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBreakConstraint.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001AA9 RID: 6825 RVA: 0x0008F1D2 File Offset: 0x0008D3D2
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp.GetOwner() is TsBaseCharacter)
		{
			meshComp.BreakConstraint(this.Impulse, this.HitLocation, this.分离骨骼名);
		}
		return true;
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x0008F1FC File Offset: 0x0008D3FC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBreakConstraint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBreakConstraint.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001AAB RID: 6827 RVA: 0x0008F28C File Offset: 0x0008D48C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "分离骨骼网格体";
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x0008F293 File Offset: 0x0008D493
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBreakConstraint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakConstraint.TsAnimNotifyBreakConstraint_C");
		}
		return TsAnimNotifyBreakConstraint._ClassPtr;
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
	public TsAnimNotifyBreakConstraint() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakConstraint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x0008F2E0 File Offset: 0x0008D4E0
	[NullableContext(1)]
	public TsAnimNotifyBreakConstraint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakConstraint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x0008F313 File Offset: 0x0008D513
	protected TsAnimNotifyBreakConstraint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x0008F31C File Offset: 0x0008D51C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0008F34F File Offset: 0x0008D54F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400113F RID: 4415
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakConstraint.TsAnimNotifyBreakConstraint_C";

	// Token: 0x04001140 RID: 4416
	private static IntPtr _ClassPtr;

	// Token: 0x04001141 RID: 4417
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001142 RID: 4418
	private static int __PropertyOffset_分离骨骼名;

	// Token: 0x04001143 RID: 4419
	private static int __PropertyOffset_Impulse;

	// Token: 0x04001144 RID: 4420
	private static int __PropertyOffset_HitLocation;
}

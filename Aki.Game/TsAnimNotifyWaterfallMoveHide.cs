using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E9 RID: 489
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWaterfallMoveHide.TsAnimNotifyWaterfallMoveHide_C")]
public class TsAnimNotifyWaterfallMoveHide : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0009E48F File Offset: 0x0009C68F
	// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0009E49F File Offset: 0x0009C69F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyWaterfallMoveHide.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyWaterfallMoveHide.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x0009E4B0 File Offset: 0x0009C6B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyWaterfallMoveHide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyWaterfallMoveHide.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EE2 RID: 7906 RVA: 0x0009E566 File Offset: 0x0009C766
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return true;
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x0009E56C File Offset: 0x0009C76C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyWaterfallMoveHide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyWaterfallMoveHide.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EE4 RID: 7908 RVA: 0x0009E5FC File Offset: 0x0009C7FC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "攀瀑进入二阶段(已废弃)";
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x0009E603 File Offset: 0x0009C803
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyWaterfallMoveHide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWaterfallMoveHide.TsAnimNotifyWaterfallMoveHide_C");
		}
		return TsAnimNotifyWaterfallMoveHide._ClassPtr;
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x0009E628 File Offset: 0x0009C828
	public TsAnimNotifyWaterfallMoveHide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWaterfallMoveHide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x0009E650 File Offset: 0x0009C850
	[NullableContext(1)]
	public TsAnimNotifyWaterfallMoveHide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWaterfallMoveHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x0009E683 File Offset: 0x0009C883
	protected TsAnimNotifyWaterfallMoveHide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x0009E68C File Offset: 0x0009C88C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x0009E6BF File Offset: 0x0009C8BF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012F1 RID: 4849
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWaterfallMoveHide.TsAnimNotifyWaterfallMoveHide_C";

	// Token: 0x040012F2 RID: 4850
	private static IntPtr _ClassPtr;

	// Token: 0x040012F3 RID: 4851
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012F4 RID: 4852
	private static int __PropertyOffset_Hide;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E5 RID: 485
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWaterfallMoveHide.TsAnimNotifyWaterfallMoveHide_C")]
public class TsAnimNotifyWaterfallMoveHide : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000973EF File Offset: 0x000955EF
	// (set) Token: 0x06001E43 RID: 7747 RVA: 0x000973FF File Offset: 0x000955FF
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

	// Token: 0x06001E44 RID: 7748 RVA: 0x00097410 File Offset: 0x00095610
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

	// Token: 0x06001E45 RID: 7749 RVA: 0x000974AF File Offset: 0x000956AF
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return true;
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000974B4 File Offset: 0x000956B4
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

	// Token: 0x06001E47 RID: 7751 RVA: 0x0009752F File Offset: 0x0009572F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "攀瀑进入二阶段(已废弃)";
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x00097536 File Offset: 0x00095736
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyWaterfallMoveHide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWaterfallMoveHide.TsAnimNotifyWaterfallMoveHide_C");
		}
		return TsAnimNotifyWaterfallMoveHide._ClassPtr;
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x0009755C File Offset: 0x0009575C
	public TsAnimNotifyWaterfallMoveHide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWaterfallMoveHide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x00097584 File Offset: 0x00095784
	[NullableContext(1)]
	public TsAnimNotifyWaterfallMoveHide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWaterfallMoveHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x000975B7 File Offset: 0x000957B7
	protected TsAnimNotifyWaterfallMoveHide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x000975C0 File Offset: 0x000957C0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000975F3 File Offset: 0x000957F3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012AE RID: 4782
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWaterfallMoveHide.TsAnimNotifyWaterfallMoveHide_C";

	// Token: 0x040012AF RID: 4783
	private static IntPtr _ClassPtr;

	// Token: 0x040012B0 RID: 4784
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012B1 RID: 4785
	private static int __PropertyOffset_Hide;
}

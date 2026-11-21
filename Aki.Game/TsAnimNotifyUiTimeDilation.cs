using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E5 RID: 485
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyUiTimeDilation.TsAnimNotifyUiTimeDilation_C")]
public class TsAnimNotifyUiTimeDilation : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001EA5 RID: 7845 RVA: 0x0009D92C File Offset: 0x0009BB2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyUiTimeDilation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyUiTimeDilation.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EA6 RID: 7846 RVA: 0x0009D9E2 File Offset: 0x0009BBE2
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return meshComp.GetOwner() is TsBaseCharacter;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x0009D9F4 File Offset: 0x0009BBF4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyUiTimeDilation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyUiTimeDilation.TsAnimNotifyUiTimeDilation_C");
		}
		return TsAnimNotifyUiTimeDilation._ClassPtr;
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x0009DA18 File Offset: 0x0009BC18
	public TsAnimNotifyUiTimeDilation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyUiTimeDilation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x0009DA40 File Offset: 0x0009BC40
	[NullableContext(1)]
	public TsAnimNotifyUiTimeDilation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyUiTimeDilation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x0009DA73 File Offset: 0x0009BC73
	protected TsAnimNotifyUiTimeDilation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x0009DA7C File Offset: 0x0009BC7C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040012D4 RID: 4820
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyUiTimeDilation.TsAnimNotifyUiTimeDilation_C";

	// Token: 0x040012D5 RID: 4821
	private static IntPtr _ClassPtr;

	// Token: 0x040012D6 RID: 4822
	private static IntPtr _ClassDefaultObjectPtr;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E1 RID: 481
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyUiTimeDilation.TsAnimNotifyUiTimeDilation_C")]
public class TsAnimNotifyUiTimeDilation : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001E08 RID: 7688 RVA: 0x000968EC File Offset: 0x00094AEC
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

	// Token: 0x06001E09 RID: 7689 RVA: 0x0009698B File Offset: 0x00094B8B
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return meshComp.GetOwner() is TsBaseCharacter;
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x0009699D File Offset: 0x00094B9D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyUiTimeDilation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyUiTimeDilation.TsAnimNotifyUiTimeDilation_C");
		}
		return TsAnimNotifyUiTimeDilation._ClassPtr;
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000969C4 File Offset: 0x00094BC4
	public TsAnimNotifyUiTimeDilation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyUiTimeDilation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000969EC File Offset: 0x00094BEC
	[NullableContext(1)]
	public TsAnimNotifyUiTimeDilation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyUiTimeDilation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x00096A1F File Offset: 0x00094C1F
	protected TsAnimNotifyUiTimeDilation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x00096A28 File Offset: 0x00094C28
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04001291 RID: 4753
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyUiTimeDilation.TsAnimNotifyUiTimeDilation_C";

	// Token: 0x04001292 RID: 4754
	private static IntPtr _ClassPtr;

	// Token: 0x04001293 RID: 4755
	private static IntPtr _ClassDefaultObjectPtr;
}

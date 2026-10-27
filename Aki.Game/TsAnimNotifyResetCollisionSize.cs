using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CB RID: 459
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetCollisionSize.TsAnimNotifyResetCollisionSize_C")]
public class TsAnimNotifyResetCollisionSize : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001CB0 RID: 7344 RVA: 0x00091BBC File Offset: 0x0008FDBC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001CB1 RID: 7345 RVA: 0x00091C5C File Offset: 0x0008FE5C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		AActor owner = MeshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		(owner as TsBaseCharacter).CharacterActorComponent.ResetCapsuleRadiusAndHeight(false);
		return true;
	}

	// Token: 0x06001CB2 RID: 7346 RVA: 0x00091C8C File Offset: 0x0008FE8C
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

	// Token: 0x06001CB3 RID: 7347 RVA: 0x00091D07 File Offset: 0x0008FF07
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "恢复默认碰撞大小";
	}

	// Token: 0x06001CB4 RID: 7348 RVA: 0x00091D0E File Offset: 0x0008FF0E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyResetCollisionSize._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetCollisionSize.TsAnimNotifyResetCollisionSize_C");
		}
		return TsAnimNotifyResetCollisionSize._ClassPtr;
	}

	// Token: 0x06001CB5 RID: 7349 RVA: 0x00091D34 File Offset: 0x0008FF34
	public TsAnimNotifyResetCollisionSize() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetCollisionSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x00091D5C File Offset: 0x0008FF5C
	[NullableContext(1)]
	public TsAnimNotifyResetCollisionSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetCollisionSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CB7 RID: 7351 RVA: 0x00091D8F File Offset: 0x0008FF8F
	protected TsAnimNotifyResetCollisionSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x00091D98 File Offset: 0x0008FF98
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x00091DCB File Offset: 0x0008FFCB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001200 RID: 4608
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetCollisionSize.TsAnimNotifyResetCollisionSize_C";

	// Token: 0x04001201 RID: 4609
	private static IntPtr _ClassPtr;

	// Token: 0x04001202 RID: 4610
	private static IntPtr _ClassDefaultObjectPtr;
}

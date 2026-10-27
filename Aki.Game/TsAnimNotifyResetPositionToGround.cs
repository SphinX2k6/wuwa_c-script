using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CC RID: 460
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetPositionToGround.TsAnimNotifyResetPositionToGround_C")]
public class TsAnimNotifyResetPositionToGround : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001CBA RID: 7354 RVA: 0x00091DE0 File Offset: 0x0008FFE0
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

	// Token: 0x06001CBB RID: 7355 RVA: 0x00091E80 File Offset: 0x00090080
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		TsBaseCharacter tsBaseCharacter = MeshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		tsBaseCharacter.CharacterActorComponent.FixBornLocation("AN.重置到地面", false, null, true, false, true);
		return true;
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x00091EB8 File Offset: 0x000900B8
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

	// Token: 0x06001CBD RID: 7357 RVA: 0x00091F33 File Offset: 0x00090133
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "重置角色到地面";
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x00091F3A File Offset: 0x0009013A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyResetPositionToGround._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetPositionToGround.TsAnimNotifyResetPositionToGround_C");
		}
		return TsAnimNotifyResetPositionToGround._ClassPtr;
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x00091F60 File Offset: 0x00090160
	public TsAnimNotifyResetPositionToGround() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetPositionToGround.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x00091F88 File Offset: 0x00090188
	[NullableContext(1)]
	public TsAnimNotifyResetPositionToGround(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetPositionToGround.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x00091FBB File Offset: 0x000901BB
	protected TsAnimNotifyResetPositionToGround(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x00091FC4 File Offset: 0x000901C4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x00091FF7 File Offset: 0x000901F7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001203 RID: 4611
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetPositionToGround.TsAnimNotifyResetPositionToGround_C";

	// Token: 0x04001204 RID: 4612
	private static IntPtr _ClassPtr;

	// Token: 0x04001205 RID: 4613
	private static IntPtr _ClassDefaultObjectPtr;
}

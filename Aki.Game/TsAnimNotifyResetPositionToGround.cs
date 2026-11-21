using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D0 RID: 464
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetPositionToGround.TsAnimNotifyResetPositionToGround_C")]
public class TsAnimNotifyResetPositionToGround : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001D57 RID: 7511 RVA: 0x00098AB0 File Offset: 0x00096CB0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyResetPositionToGround) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyResetPositionToGround.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(MeshComp, Animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x00098B68 File Offset: 0x00096D68
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

	// Token: 0x06001D59 RID: 7513 RVA: 0x00098BA0 File Offset: 0x00096DA0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyResetPositionToGround) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyResetPositionToGround.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D5A RID: 7514 RVA: 0x00098C30 File Offset: 0x00096E30
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "重置角色到地面";
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x00098C37 File Offset: 0x00096E37
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyResetPositionToGround._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetPositionToGround.TsAnimNotifyResetPositionToGround_C");
		}
		return TsAnimNotifyResetPositionToGround._ClassPtr;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x00098C5C File Offset: 0x00096E5C
	public TsAnimNotifyResetPositionToGround() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetPositionToGround.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x00098C84 File Offset: 0x00096E84
	[NullableContext(1)]
	public TsAnimNotifyResetPositionToGround(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetPositionToGround.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00098CB7 File Offset: 0x00096EB7
	protected TsAnimNotifyResetPositionToGround(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x00098CC0 File Offset: 0x00096EC0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x00098CF3 File Offset: 0x00096EF3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001246 RID: 4678
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetPositionToGround.TsAnimNotifyResetPositionToGround_C";

	// Token: 0x04001247 RID: 4679
	private static IntPtr _ClassPtr;

	// Token: 0x04001248 RID: 4680
	private static IntPtr _ClassDefaultObjectPtr;
}

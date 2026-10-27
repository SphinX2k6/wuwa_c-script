using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B0 RID: 432
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableEntity.TsAnimNotifyDisableEntity_C")]
public class TsAnimNotifyDisableEntity : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001B45 RID: 6981 RVA: 0x0008CDC4 File Offset: 0x0008AFC4
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

	// Token: 0x06001B46 RID: 6982 RVA: 0x0008CE64 File Offset: 0x0008B064
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter == null && tsBaseVehicle == null)
		{
			return false;
		}
		Entity entity = ((tsBaseCharacter != null) ? tsBaseCharacter.GetEntityNoBlueprint() : null) ?? tsBaseVehicle.GetEntityNoBlueprint();
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CreatureController.Instance.SetEntityEnable(entity, false, "TsAnimNotifyDisableEntity", true);
		return true;
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x0008CED0 File Offset: 0x0008B0D0
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

	// Token: 0x06001B48 RID: 6984 RVA: 0x0008CF4B File Offset: 0x0008B14B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "关闭自身实体";
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x0008CF52 File Offset: 0x0008B152
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDisableEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableEntity.TsAnimNotifyDisableEntity_C");
		}
		return TsAnimNotifyDisableEntity._ClassPtr;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x0008CF78 File Offset: 0x0008B178
	public TsAnimNotifyDisableEntity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0008CFA0 File Offset: 0x0008B1A0
	[NullableContext(1)]
	public TsAnimNotifyDisableEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x0008CFD3 File Offset: 0x0008B1D3
	protected TsAnimNotifyDisableEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x0008CFDC File Offset: 0x0008B1DC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x0008D00F File Offset: 0x0008B20F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001178 RID: 4472
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableEntity.TsAnimNotifyDisableEntity_C";

	// Token: 0x04001179 RID: 4473
	private static IntPtr _ClassPtr;

	// Token: 0x0400117A RID: 4474
	private static IntPtr _ClassDefaultObjectPtr;
}

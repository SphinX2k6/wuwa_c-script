using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AE RID: 430
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetachFromVehicle.TsAnimNotifyDetachFromVehicle_C")]
public class TsAnimNotifyDetachFromVehicle : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001B2F RID: 6959 RVA: 0x0008C838 File Offset: 0x0008AA38
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

	// Token: 0x06001B30 RID: 6960 RVA: 0x0008C8D8 File Offset: 0x0008AAD8
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		int? ridingVehicle = NpcVehicleRiderController.Instance.GetRidingVehicle(characterActorComponent.Entity.Id);
		if (ridingVehicle == null)
		{
			return false;
		}
		NpcVehiclePerformComponent component = EntitySystem.Instance.GetComponent<NpcVehiclePerformComponent>(ridingVehicle.Value);
		if (component == null || !component.Valid)
		{
			return false;
		}
		BaseTagComponent component2 = EntitySystem.Instance.GetComponent<BaseTagComponent>(characterActorComponent.Entity.Id);
		if (component2 != null && component2.Valid)
		{
			component2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.逻辑.强制更新移动"]));
		}
		NpcVehicleRiderController.Instance.SetNpcVehicleRideState(characterActorComponent.Entity.Id, ENpcVehicleRideState.WaitingToFinishDismount);
		component.TryLeave(characterActorComponent.Entity, ELeaveVehicleType.StandUp);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "AN提前下载具";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", characterActorComponent.Entity.Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x0008C9FC File Offset: 0x0008ABFC
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

	// Token: 0x06001B32 RID: 6962 RVA: 0x0008CA77 File Offset: 0x0008AC77
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "下载具时从载具解绑";
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x0008CA7E File Offset: 0x0008AC7E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDetachFromVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetachFromVehicle.TsAnimNotifyDetachFromVehicle_C");
		}
		return TsAnimNotifyDetachFromVehicle._ClassPtr;
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x0008CAA4 File Offset: 0x0008ACA4
	public TsAnimNotifyDetachFromVehicle() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetachFromVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x0008CACC File Offset: 0x0008ACCC
	[NullableContext(1)]
	public TsAnimNotifyDetachFromVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetachFromVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0008CAFF File Offset: 0x0008ACFF
	protected TsAnimNotifyDetachFromVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x0008CB08 File Offset: 0x0008AD08
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x0008CB3B File Offset: 0x0008AD3B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001171 RID: 4465
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetachFromVehicle.TsAnimNotifyDetachFromVehicle_C";

	// Token: 0x04001172 RID: 4466
	private static IntPtr _ClassPtr;

	// Token: 0x04001173 RID: 4467
	private static IntPtr _ClassDefaultObjectPtr;
}

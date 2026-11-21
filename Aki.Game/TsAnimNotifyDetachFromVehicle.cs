using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B2 RID: 434
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetachFromVehicle.TsAnimNotifyDetachFromVehicle_C")]
public class TsAnimNotifyDetachFromVehicle : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001BCC RID: 7116 RVA: 0x00093090 File Offset: 0x00091290
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDetachFromVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyDetachFromVehicle.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001BCD RID: 7117 RVA: 0x00093148 File Offset: 0x00091348
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

	// Token: 0x06001BCE RID: 7118 RVA: 0x0009326C File Offset: 0x0009146C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDetachFromVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyDetachFromVehicle.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001BCF RID: 7119 RVA: 0x000932FC File Offset: 0x000914FC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "下载具时从载具解绑";
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x00093303 File Offset: 0x00091503
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDetachFromVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetachFromVehicle.TsAnimNotifyDetachFromVehicle_C");
		}
		return TsAnimNotifyDetachFromVehicle._ClassPtr;
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00093328 File Offset: 0x00091528
	public TsAnimNotifyDetachFromVehicle() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetachFromVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x00093350 File Offset: 0x00091550
	[NullableContext(1)]
	public TsAnimNotifyDetachFromVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetachFromVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x00093383 File Offset: 0x00091583
	protected TsAnimNotifyDetachFromVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x0009338C File Offset: 0x0009158C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x000933BF File Offset: 0x000915BF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011B4 RID: 4532
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetachFromVehicle.TsAnimNotifyDetachFromVehicle_C";

	// Token: 0x040011B5 RID: 4533
	private static IntPtr _ClassPtr;

	// Token: 0x040011B6 RID: 4534
	private static IntPtr _ClassDefaultObjectPtr;
}

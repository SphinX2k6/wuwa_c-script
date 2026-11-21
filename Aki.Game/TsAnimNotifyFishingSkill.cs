using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BE RID: 446
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFishingSkill.TsAnimNotifyFishingSkill_C")]
public class TsAnimNotifyFishingSkill : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0009537F File Offset: 0x0009357F
	// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0009538F File Offset: 0x0009358F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EFishingSkillType SkillType
	{
		get
		{
			return (EFishingSkillType)(*(base.NativePtr + (IntPtr)TsAnimNotifyFishingSkill.__PropertyOffset_SkillType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyFishingSkill.__PropertyOffset_SkillType) = (byte)value;
		}
	}

	// Token: 0x06001C62 RID: 7266 RVA: 0x000953A0 File Offset: 0x000935A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFishingSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyFishingSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C63 RID: 7267 RVA: 0x00095458 File Offset: 0x00093658
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (owner as TsBaseVehicle).VehicleActorComponent;
		Entity entity = (vehicleActorComponent != null) ? vehicleActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		FishingController.Instance.BeginFishingSkill(this.SkillType);
		return true;
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x000954B4 File Offset: 0x000936B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFishingSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyFishingSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C65 RID: 7269 RVA: 0x00095544 File Offset: 0x00093744
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "捕鱼技能";
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x0009554B File Offset: 0x0009374B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFishingSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFishingSkill.TsAnimNotifyFishingSkill_C");
		}
		return TsAnimNotifyFishingSkill._ClassPtr;
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x00095570 File Offset: 0x00093770
	public TsAnimNotifyFishingSkill() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFishingSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x00095598 File Offset: 0x00093798
	[NullableContext(1)]
	public TsAnimNotifyFishingSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFishingSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x000955CB File Offset: 0x000937CB
	protected TsAnimNotifyFishingSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x000955D4 File Offset: 0x000937D4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x00095607 File Offset: 0x00093807
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011EC RID: 4588
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFishingSkill.TsAnimNotifyFishingSkill_C";

	// Token: 0x040011ED RID: 4589
	private static IntPtr _ClassPtr;

	// Token: 0x040011EE RID: 4590
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011EF RID: 4591
	private static int __PropertyOffset_SkillType;
}

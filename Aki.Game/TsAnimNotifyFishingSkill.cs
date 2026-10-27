using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BA RID: 442
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFishingSkill.TsAnimNotifyFishingSkill_C")]
public class TsAnimNotifyFishingSkill : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0008E96F File Offset: 0x0008CB6F
	// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0008E97F File Offset: 0x0008CB7F
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

	// Token: 0x06001BC5 RID: 7109 RVA: 0x0008E990 File Offset: 0x0008CB90
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

	// Token: 0x06001BC6 RID: 7110 RVA: 0x0008EA30 File Offset: 0x0008CC30
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

	// Token: 0x06001BC7 RID: 7111 RVA: 0x0008EA8C File Offset: 0x0008CC8C
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

	// Token: 0x06001BC8 RID: 7112 RVA: 0x0008EB07 File Offset: 0x0008CD07
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "捕鱼技能";
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0008EB0E File Offset: 0x0008CD0E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFishingSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFishingSkill.TsAnimNotifyFishingSkill_C");
		}
		return TsAnimNotifyFishingSkill._ClassPtr;
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x0008EB34 File Offset: 0x0008CD34
	public TsAnimNotifyFishingSkill() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFishingSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x0008EB5C File Offset: 0x0008CD5C
	[NullableContext(1)]
	public TsAnimNotifyFishingSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFishingSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x0008EB8F File Offset: 0x0008CD8F
	protected TsAnimNotifyFishingSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x0008EB98 File Offset: 0x0008CD98
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x0008EBCB File Offset: 0x0008CDCB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011A9 RID: 4521
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFishingSkill.TsAnimNotifyFishingSkill_C";

	// Token: 0x040011AA RID: 4522
	private static IntPtr _ClassPtr;

	// Token: 0x040011AB RID: 4523
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011AC RID: 4524
	private static int __PropertyOffset_SkillType;
}

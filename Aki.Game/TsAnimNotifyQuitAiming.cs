using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CC RID: 460
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQuitAiming.TsAnimNotifyQuitAiming_C")]
public class TsAnimNotifyQuitAiming : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00097EFB File Offset: 0x000960FB
	// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00097F0F File Offset: 0x0009610F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQuitAiming.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQuitAiming.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x06001D20 RID: 7456 RVA: 0x00097F24 File Offset: 0x00096124
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyQuitAiming) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyQuitAiming.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D21 RID: 7457 RVA: 0x00097FDC File Offset: 0x000961DC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
			if (!tsBaseCharacter.CharacterActorComponent.IsWorldOwner())
			{
				return false;
			}
			if (this.Tag.TagName == "None" || entity.GetComponent<BaseTagComponent>().HasTag(this.Tag.TagId()))
			{
				entity.GetComponent<CharacterUnifiedStateComponent>().ExitAimStatus();
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001D22 RID: 7458 RVA: 0x00098058 File Offset: 0x00096258
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyQuitAiming) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyQuitAiming.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D23 RID: 7459 RVA: 0x000980E8 File Offset: 0x000962E8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "退出瞄准模式";
	}

	// Token: 0x06001D24 RID: 7460 RVA: 0x000980EF File Offset: 0x000962EF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyQuitAiming._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQuitAiming.TsAnimNotifyQuitAiming_C");
		}
		return TsAnimNotifyQuitAiming._ClassPtr;
	}

	// Token: 0x06001D25 RID: 7461 RVA: 0x00098114 File Offset: 0x00096314
	public TsAnimNotifyQuitAiming() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQuitAiming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x0009813C File Offset: 0x0009633C
	[NullableContext(1)]
	public TsAnimNotifyQuitAiming(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQuitAiming.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x0009816F File Offset: 0x0009636F
	protected TsAnimNotifyQuitAiming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x00098178 File Offset: 0x00096378
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D29 RID: 7465 RVA: 0x000981AB File Offset: 0x000963AB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001231 RID: 4657
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQuitAiming.TsAnimNotifyQuitAiming_C";

	// Token: 0x04001232 RID: 4658
	private static IntPtr _ClassPtr;

	// Token: 0x04001233 RID: 4659
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001234 RID: 4660
	private static int __PropertyOffset_Tag;
}

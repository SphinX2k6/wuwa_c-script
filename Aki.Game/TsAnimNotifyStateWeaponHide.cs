using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018C RID: 396
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHide.TsAnimNotifyStateWeaponHide_C")]
public class TsAnimNotifyStateWeaponHide : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06001938 RID: 6456 RVA: 0x000859B7 File Offset: 0x00083BB7
	// (set) Token: 0x06001939 RID: 6457 RVA: 0x000859C7 File Offset: 0x00083BC7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x0600193A RID: 6458 RVA: 0x000859D8 File Offset: 0x00083BD8
	// (set) Token: 0x0600193B RID: 6459 RVA: 0x000859E8 File Offset: 0x00083BE8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int WeaponIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_WeaponIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_WeaponIndex) = value;
		}
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x0600193C RID: 6460 RVA: 0x000859F9 File Offset: 0x00083BF9
	// (set) Token: 0x0600193D RID: 6461 RVA: 0x00085A09 File Offset: 0x00083C09
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_HideEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_HideEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x0600193E RID: 6462 RVA: 0x00085A1A File Offset: 0x00083C1A
	// (set) Token: 0x0600193F RID: 6463 RVA: 0x00085A2A File Offset: 0x00083C2A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseHighPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_UseHighPriority) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_UseHighPriority) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06001940 RID: 6464 RVA: 0x00085A3B File Offset: 0x00083C3B
	// (set) Token: 0x06001941 RID: 6465 RVA: 0x00085A4F File Offset: 0x00083C4F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag ActivateTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_ActivateTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHide.__PropertyOffset_ActivateTag) = value;
		}
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00085A64 File Offset: 0x00083C64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00085B0C File Offset: 0x00083D0C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			if (this.ActivateTag.TagName != FName.NAME_None)
			{
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				if (component != null && !component.HasTag(this.ActivateTag.TagId()))
				{
					return false;
				}
			}
			CharacterWeaponComponent component2 = entity.GetComponent<CharacterWeaponComponent>();
			if (component2 != null)
			{
				component2.HideWeapon(this.WeaponIndex, this.Hide, this.HideEffect, false, this.UseHighPriority ? EWeaponExtraVisibleType.HighCustom : EWeaponExtraVisibleType.LowCustom, "TsAnimNotifyStateWeaponHide");
			}
		}
		return true;
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00085BC0 File Offset: 0x00083DC0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001945 RID: 6469 RVA: 0x00085C3B File Offset: 0x00083E3B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "武器隐藏";
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00085C42 File Offset: 0x00083E42
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWeaponHide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHide.TsAnimNotifyStateWeaponHide_C");
		}
		return TsAnimNotifyStateWeaponHide._ClassPtr;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00085C68 File Offset: 0x00083E68
	public TsAnimNotifyStateWeaponHide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x00085C90 File Offset: 0x00083E90
	[NullableContext(1)]
	public TsAnimNotifyStateWeaponHide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x00085CC3 File Offset: 0x00083EC3
	protected TsAnimNotifyStateWeaponHide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x00085CCC File Offset: 0x00083ECC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00085D05 File Offset: 0x00083F05
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010A5 RID: 4261
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHide.TsAnimNotifyStateWeaponHide_C";

	// Token: 0x040010A6 RID: 4262
	private static IntPtr _ClassPtr;

	// Token: 0x040010A7 RID: 4263
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010A8 RID: 4264
	private static int __PropertyOffset_Hide;

	// Token: 0x040010A9 RID: 4265
	private static int __PropertyOffset_WeaponIndex;

	// Token: 0x040010AA RID: 4266
	private static int __PropertyOffset_HideEffect;

	// Token: 0x040010AB RID: 4267
	private static int __PropertyOffset_UseHighPriority;

	// Token: 0x040010AC RID: 4268
	private static int __PropertyOffset_ActivateTag;
}

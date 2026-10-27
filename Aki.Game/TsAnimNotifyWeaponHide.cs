using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E6 RID: 486
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWeaponHide.TsAnimNotifyWeaponHide_C")]
public class TsAnimNotifyWeaponHide : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00097607 File Offset: 0x00095807
	// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00097617 File Offset: 0x00095817
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00097628 File Offset: 0x00095828
	// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00097638 File Offset: 0x00095838
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int WeaponIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_WeaponIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_WeaponIndex) = value;
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00097649 File Offset: 0x00095849
	// (set) Token: 0x06001E53 RID: 7763 RVA: 0x00097659 File Offset: 0x00095859
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_HideEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_HideEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001E54 RID: 7764 RVA: 0x0009766A File Offset: 0x0009586A
	// (set) Token: 0x06001E55 RID: 7765 RVA: 0x0009767A File Offset: 0x0009587A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseHighPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_UseHighPriority) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_UseHighPriority) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0009768B File Offset: 0x0009588B
	// (set) Token: 0x06001E57 RID: 7767 RVA: 0x0009769F File Offset: 0x0009589F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag ActivateTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_ActivateTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyWeaponHide.__PropertyOffset_ActivateTag) = value;
		}
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000976B4 File Offset: 0x000958B4
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

	// Token: 0x06001E59 RID: 7769 RVA: 0x00097754 File Offset: 0x00095954
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
				component2.HideWeapon(this.WeaponIndex, this.Hide, this.HideEffect, false, this.UseHighPriority ? EWeaponExtraVisibleType.HighCustom : EWeaponExtraVisibleType.LowCustom, "TsAnimNotifyWeaponHide");
			}
		}
		return true;
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x00097808 File Offset: 0x00095A08
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

	// Token: 0x06001E5B RID: 7771 RVA: 0x00097883 File Offset: 0x00095A83
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "武器隐藏";
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x0009788A File Offset: 0x00095A8A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyWeaponHide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWeaponHide.TsAnimNotifyWeaponHide_C");
		}
		return TsAnimNotifyWeaponHide._ClassPtr;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000978B0 File Offset: 0x00095AB0
	public TsAnimNotifyWeaponHide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWeaponHide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000978D8 File Offset: 0x00095AD8
	[NullableContext(1)]
	public TsAnimNotifyWeaponHide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWeaponHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x0009790B File Offset: 0x00095B0B
	protected TsAnimNotifyWeaponHide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x00097914 File Offset: 0x00095B14
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x00097947 File Offset: 0x00095B47
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012B2 RID: 4786
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWeaponHide.TsAnimNotifyWeaponHide_C";

	// Token: 0x040012B3 RID: 4787
	private static IntPtr _ClassPtr;

	// Token: 0x040012B4 RID: 4788
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012B5 RID: 4789
	private static int __PropertyOffset_Hide;

	// Token: 0x040012B6 RID: 4790
	private static int __PropertyOffset_WeaponIndex;

	// Token: 0x040012B7 RID: 4791
	private static int __PropertyOffset_HideEffect;

	// Token: 0x040012B8 RID: 4792
	private static int __PropertyOffset_UseHighPriority;

	// Token: 0x040012B9 RID: 4793
	private static int __PropertyOffset_ActivateTag;
}

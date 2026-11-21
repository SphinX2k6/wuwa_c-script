using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001EA RID: 490
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWeaponHide.TsAnimNotifyWeaponHide_C")]
public class TsAnimNotifyWeaponHide : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06001EEB RID: 7915 RVA: 0x0009E6D3 File Offset: 0x0009C8D3
	// (set) Token: 0x06001EEC RID: 7916 RVA: 0x0009E6E3 File Offset: 0x0009C8E3
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

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06001EED RID: 7917 RVA: 0x0009E6F4 File Offset: 0x0009C8F4
	// (set) Token: 0x06001EEE RID: 7918 RVA: 0x0009E704 File Offset: 0x0009C904
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

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0009E715 File Offset: 0x0009C915
	// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x0009E725 File Offset: 0x0009C925
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

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0009E736 File Offset: 0x0009C936
	// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0009E746 File Offset: 0x0009C946
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

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0009E757 File Offset: 0x0009C957
	// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x0009E76B File Offset: 0x0009C96B
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

	// Token: 0x06001EF5 RID: 7925 RVA: 0x0009E780 File Offset: 0x0009C980
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyWeaponHide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyWeaponHide.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EF6 RID: 7926 RVA: 0x0009E838 File Offset: 0x0009CA38
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

	// Token: 0x06001EF7 RID: 7927 RVA: 0x0009E8EC File Offset: 0x0009CAEC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyWeaponHide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyWeaponHide.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EF8 RID: 7928 RVA: 0x0009E97C File Offset: 0x0009CB7C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "武器隐藏";
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x0009E983 File Offset: 0x0009CB83
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyWeaponHide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWeaponHide.TsAnimNotifyWeaponHide_C");
		}
		return TsAnimNotifyWeaponHide._ClassPtr;
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x0009E9A8 File Offset: 0x0009CBA8
	public TsAnimNotifyWeaponHide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWeaponHide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x0009E9D0 File Offset: 0x0009CBD0
	[NullableContext(1)]
	public TsAnimNotifyWeaponHide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWeaponHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x0009EA03 File Offset: 0x0009CC03
	protected TsAnimNotifyWeaponHide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x0009EA0C File Offset: 0x0009CC0C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x0009EA3F File Offset: 0x0009CC3F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012F5 RID: 4853
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyWeaponHide.TsAnimNotifyWeaponHide_C";

	// Token: 0x040012F6 RID: 4854
	private static IntPtr _ClassPtr;

	// Token: 0x040012F7 RID: 4855
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012F8 RID: 4856
	private static int __PropertyOffset_Hide;

	// Token: 0x040012F9 RID: 4857
	private static int __PropertyOffset_WeaponIndex;

	// Token: 0x040012FA RID: 4858
	private static int __PropertyOffset_HideEffect;

	// Token: 0x040012FB RID: 4859
	private static int __PropertyOffset_UseHighPriority;

	// Token: 0x040012FC RID: 4860
	private static int __PropertyOffset_ActivateTag;
}

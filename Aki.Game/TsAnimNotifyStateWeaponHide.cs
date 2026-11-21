using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000190 RID: 400
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHide.TsAnimNotifyStateWeaponHide_C")]
public class TsAnimNotifyStateWeaponHide : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0008BCB7 File Offset: 0x00089EB7
	// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0008BCC7 File Offset: 0x00089EC7
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

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0008BCD8 File Offset: 0x00089ED8
	// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0008BCE8 File Offset: 0x00089EE8
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

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0008BCF9 File Offset: 0x00089EF9
	// (set) Token: 0x060019DA RID: 6618 RVA: 0x0008BD09 File Offset: 0x00089F09
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

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x060019DB RID: 6619 RVA: 0x0008BD1A File Offset: 0x00089F1A
	// (set) Token: 0x060019DC RID: 6620 RVA: 0x0008BD2A File Offset: 0x00089F2A
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

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x060019DD RID: 6621 RVA: 0x0008BD3B File Offset: 0x00089F3B
	// (set) Token: 0x060019DE RID: 6622 RVA: 0x0008BD4F File Offset: 0x00089F4F
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

	// Token: 0x060019DF RID: 6623 RVA: 0x0008BD64 File Offset: 0x00089F64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateWeaponHide.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x0008BE24 File Offset: 0x0008A024
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

	// Token: 0x060019E1 RID: 6625 RVA: 0x0008BED8 File Offset: 0x0008A0D8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateWeaponHide.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0008BF68 File Offset: 0x0008A168
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "武器隐藏";
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x0008BF6F File Offset: 0x0008A16F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWeaponHide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHide.TsAnimNotifyStateWeaponHide_C");
		}
		return TsAnimNotifyStateWeaponHide._ClassPtr;
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0008BF94 File Offset: 0x0008A194
	public TsAnimNotifyStateWeaponHide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x0008BFBC File Offset: 0x0008A1BC
	[NullableContext(1)]
	public TsAnimNotifyStateWeaponHide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x0008BFEF File Offset: 0x0008A1EF
	protected TsAnimNotifyStateWeaponHide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x0008BFF8 File Offset: 0x0008A1F8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x0008C031 File Offset: 0x0008A231
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010E8 RID: 4328
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHide.TsAnimNotifyStateWeaponHide_C";

	// Token: 0x040010E9 RID: 4329
	private static IntPtr _ClassPtr;

	// Token: 0x040010EA RID: 4330
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010EB RID: 4331
	private static int __PropertyOffset_Hide;

	// Token: 0x040010EC RID: 4332
	private static int __PropertyOffset_WeaponIndex;

	// Token: 0x040010ED RID: 4333
	private static int __PropertyOffset_HideEffect;

	// Token: 0x040010EE RID: 4334
	private static int __PropertyOffset_UseHighPriority;

	// Token: 0x040010EF RID: 4335
	private static int __PropertyOffset_ActivateTag;
}

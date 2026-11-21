using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018F RID: 399
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHangWithTag.TsAnimNotifyStateWeaponHangWithTag_C")]
public class TsAnimNotifyStateWeaponHangWithTag : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x060019BE RID: 6590 RVA: 0x0008B72B File Offset: 0x0008992B
	// (set) Token: 0x060019BF RID: 6591 RVA: 0x0008B73B File Offset: 0x0008993B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0008B74C File Offset: 0x0008994C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FName> 新的挂载点名
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FName> result;
			if ((result = this._新的挂载点名) == null)
			{
				result = (this._新的挂载点名 = new TArray<FName>(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_新的挂载点名, this));
			}
			return result;
		}
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0008B788 File Offset: 0x00089988
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FTransform> 挂载相对位置
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FTransform> result;
			if ((result = this._挂载相对位置) == null)
			{
				result = (this._挂载相对位置 = new TArray<FTransform>(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_挂载相对位置, this));
			}
			return result;
		}
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0008B7C1 File Offset: 0x000899C1
	// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0008B7D1 File Offset: 0x000899D1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int 结束后状态
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_结束后状态);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_结束后状态) = value;
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0008B7E2 File Offset: 0x000899E2
	// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0008B7F2 File Offset: 0x000899F2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 缓冲时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_缓冲时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_缓冲时间) = value;
		}
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0008B803 File Offset: 0x00089A03
	// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0008B817 File Offset: 0x00089A17
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag ActivateTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_ActivateTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHangWithTag.__PropertyOffset_ActivateTag) = value;
		}
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x0008B82C File Offset: 0x00089A2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHangWithTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateWeaponHangWithTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x060019C9 RID: 6601 RVA: 0x0008B8EC File Offset: 0x00089AEC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		BaseTagComponent baseTagComponent;
		if (characterActorComponent == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity entity = characterActorComponent.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null || !baseTagComponent2.HasTag(this.ActivateTag.TagId()))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
		object obj;
		if (characterActorComponent2 == null)
		{
			obj = null;
		}
		else
		{
			Entity entity2 = characterActorComponent2.Entity;
			obj = ((entity2 != null) ? entity2.GetComponent<CharacterWeaponComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.ChangeWeaponHangState(this.Id, this.新的挂载点名, this.挂载相对位置, this.缓冲时间, "TsAnimNotifyStateWeaponHangWithTag.NotifyBegin");
		}
		return true;
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0008B98C File Offset: 0x00089B8C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHangWithTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateWeaponHangWithTag.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x0008BA44 File Offset: 0x00089C44
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			BaseTagComponent baseTagComponent;
			if (characterActorComponent == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null || !baseTagComponent2.HasTag(this.ActivateTag.TagId()))
			{
				return false;
			}
			CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
			CharacterWeaponComponent characterWeaponComponent;
			if (characterActorComponent2 == null)
			{
				characterWeaponComponent = null;
			}
			else
			{
				Entity entity2 = characterActorComponent2.Entity;
				characterWeaponComponent = ((entity2 != null) ? entity2.GetComponent<CharacterWeaponComponent>() : null);
			}
			CharacterWeaponComponent characterWeaponComponent2 = characterWeaponComponent;
			if (characterWeaponComponent2 == null || !characterWeaponComponent2.Valid)
			{
				return false;
			}
			if (characterWeaponComponent2.CurrentHangState == this.Id)
			{
				if (this.结束后状态 == 0 || this.结束后状态 == 1)
				{
					characterWeaponComponent2.ChangeWeaponHangState(this.结束后状态, new TArray<FName>(), new TArray<FTransform>(), this.缓冲时间, "TsAnimNotifyStateWeaponHangWithTag.NotifyEnd");
					return true;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x0008BB14 File Offset: 0x00089D14
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHangWithTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateWeaponHangWithTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x060019CD RID: 6605 RVA: 0x0008BBA4 File Offset: 0x00089DA4
	protected override string GetNotifyName_Implementation()
	{
		return "切换武器到挂点";
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x0008BBAB File Offset: 0x00089DAB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWeaponHangWithTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHangWithTag.TsAnimNotifyStateWeaponHangWithTag_C");
		}
		return TsAnimNotifyStateWeaponHangWithTag._ClassPtr;
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x0008BBD0 File Offset: 0x00089DD0
	public TsAnimNotifyStateWeaponHangWithTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHangWithTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0008BBF8 File Offset: 0x00089DF8
	public TsAnimNotifyStateWeaponHangWithTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHangWithTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x0008BC2B File Offset: 0x00089E2B
	protected TsAnimNotifyStateWeaponHangWithTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x0008BC34 File Offset: 0x00089E34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x0008BC70 File Offset: 0x00089E70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x0008BCA3 File Offset: 0x00089EA3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010DD RID: 4317
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHangWithTag.TsAnimNotifyStateWeaponHangWithTag_C";

	// Token: 0x040010DE RID: 4318
	private static IntPtr _ClassPtr;

	// Token: 0x040010DF RID: 4319
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010E0 RID: 4320
	private static int __PropertyOffset_Id;

	// Token: 0x040010E1 RID: 4321
	private static int __PropertyOffset_新的挂载点名;

	// Token: 0x040010E2 RID: 4322
	[Nullable(2)]
	private TArray<FName> _新的挂载点名;

	// Token: 0x040010E3 RID: 4323
	private static int __PropertyOffset_挂载相对位置;

	// Token: 0x040010E4 RID: 4324
	[Nullable(2)]
	private TArray<FTransform> _挂载相对位置;

	// Token: 0x040010E5 RID: 4325
	private static int __PropertyOffset_结束后状态;

	// Token: 0x040010E6 RID: 4326
	private static int __PropertyOffset_缓冲时间;

	// Token: 0x040010E7 RID: 4327
	private static int __PropertyOffset_ActivateTag;
}

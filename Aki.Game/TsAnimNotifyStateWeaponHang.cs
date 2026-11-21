using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018E RID: 398
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHang.TsAnimNotifyStateWeaponHang_C")]
public class TsAnimNotifyStateWeaponHang : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0008B23B File Offset: 0x0008943B
	// (set) Token: 0x060019AA RID: 6570 RVA: 0x0008B24B File Offset: 0x0008944B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x060019AB RID: 6571 RVA: 0x0008B25C File Offset: 0x0008945C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FName> 新的挂载点名
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FName> result;
			if ((result = this._新的挂载点名) == null)
			{
				result = (this._新的挂载点名 = new TArray<FName>(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_新的挂载点名, this));
			}
			return result;
		}
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x060019AC RID: 6572 RVA: 0x0008B298 File Offset: 0x00089498
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FTransform> 挂载相对位置
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FTransform> result;
			if ((result = this._挂载相对位置) == null)
			{
				result = (this._挂载相对位置 = new TArray<FTransform>(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_挂载相对位置, this));
			}
			return result;
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x060019AD RID: 6573 RVA: 0x0008B2D1 File Offset: 0x000894D1
	// (set) Token: 0x060019AE RID: 6574 RVA: 0x0008B2E1 File Offset: 0x000894E1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int 结束后状态
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_结束后状态);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_结束后状态) = value;
		}
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x060019AF RID: 6575 RVA: 0x0008B2F2 File Offset: 0x000894F2
	// (set) Token: 0x060019B0 RID: 6576 RVA: 0x0008B302 File Offset: 0x00089502
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 缓冲时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_缓冲时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWeaponHang.__PropertyOffset_缓冲时间) = value;
		}
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x0008B314 File Offset: 0x00089514
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHang) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateWeaponHang.StaticClass(), out intPtr, out num))
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

	// Token: 0x060019B2 RID: 6578 RVA: 0x0008B3D4 File Offset: 0x000895D4
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			object obj;
			if (characterActorComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterWeaponComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.ChangeWeaponHangState(this.Id, this.新的挂载点名, this.挂载相对位置, this.缓冲时间, "TsAnimNotifyStateWeaponHang.NotifyBegin");
			}
			return true;
		}
		return false;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x0008B43C File Offset: 0x0008963C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHang) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateWeaponHang.StaticClass(), out intPtr, out num))
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

	// Token: 0x060019B4 RID: 6580 RVA: 0x0008B4F4 File Offset: 0x000896F4
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			CharacterWeaponComponent characterWeaponComponent;
			if (characterActorComponent == null)
			{
				characterWeaponComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterWeaponComponent = ((entity != null) ? entity.GetComponent<CharacterWeaponComponent>() : null);
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
					characterWeaponComponent2.ChangeWeaponHangState(this.结束后状态, new TArray<FName>(), new TArray<FTransform>(), this.缓冲时间, "TsAnimNotifyStateWeaponHang.NotifyEnd");
					return true;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x0008B588 File Offset: 0x00089788
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWeaponHang) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateWeaponHang.StaticClass(), out intPtr, out num))
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

	// Token: 0x060019B6 RID: 6582 RVA: 0x0008B618 File Offset: 0x00089818
	protected override string GetNotifyName_Implementation()
	{
		return "切换武器到挂点";
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x0008B61F File Offset: 0x0008981F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWeaponHang._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHang.TsAnimNotifyStateWeaponHang_C");
		}
		return TsAnimNotifyStateWeaponHang._ClassPtr;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x0008B644 File Offset: 0x00089844
	public TsAnimNotifyStateWeaponHang() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHang.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x0008B66C File Offset: 0x0008986C
	public TsAnimNotifyStateWeaponHang(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x0008B69F File Offset: 0x0008989F
	protected TsAnimNotifyStateWeaponHang(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x0008B6A8 File Offset: 0x000898A8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x0008B6E4 File Offset: 0x000898E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x0008B717 File Offset: 0x00089917
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010D3 RID: 4307
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHang.TsAnimNotifyStateWeaponHang_C";

	// Token: 0x040010D4 RID: 4308
	private static IntPtr _ClassPtr;

	// Token: 0x040010D5 RID: 4309
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010D6 RID: 4310
	private static int __PropertyOffset_Id;

	// Token: 0x040010D7 RID: 4311
	private static int __PropertyOffset_新的挂载点名;

	// Token: 0x040010D8 RID: 4312
	[Nullable(2)]
	private TArray<FName> _新的挂载点名;

	// Token: 0x040010D9 RID: 4313
	private static int __PropertyOffset_挂载相对位置;

	// Token: 0x040010DA RID: 4314
	[Nullable(2)]
	private TArray<FTransform> _挂载相对位置;

	// Token: 0x040010DB RID: 4315
	private static int __PropertyOffset_结束后状态;

	// Token: 0x040010DC RID: 4316
	private static int __PropertyOffset_缓冲时间;
}

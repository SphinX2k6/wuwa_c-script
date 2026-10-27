using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018A RID: 394
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHang.TsAnimNotifyStateWeaponHang_C")]
public class TsAnimNotifyStateWeaponHang : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x0600190C RID: 6412 RVA: 0x00084FC3 File Offset: 0x000831C3
	// (set) Token: 0x0600190D RID: 6413 RVA: 0x00084FD3 File Offset: 0x000831D3
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

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x0600190E RID: 6414 RVA: 0x00084FE4 File Offset: 0x000831E4
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

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x0600190F RID: 6415 RVA: 0x00085020 File Offset: 0x00083220
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

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06001910 RID: 6416 RVA: 0x00085059 File Offset: 0x00083259
	// (set) Token: 0x06001911 RID: 6417 RVA: 0x00085069 File Offset: 0x00083269
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

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06001912 RID: 6418 RVA: 0x0008507A File Offset: 0x0008327A
	// (set) Token: 0x06001913 RID: 6419 RVA: 0x0008508A File Offset: 0x0008328A
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

	// Token: 0x06001914 RID: 6420 RVA: 0x0008509C File Offset: 0x0008329C
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

	// Token: 0x06001915 RID: 6421 RVA: 0x00085144 File Offset: 0x00083344
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

	// Token: 0x06001916 RID: 6422 RVA: 0x000851AC File Offset: 0x000833AC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x06001917 RID: 6423 RVA: 0x0008524C File Offset: 0x0008344C
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

	// Token: 0x06001918 RID: 6424 RVA: 0x000852E0 File Offset: 0x000834E0
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

	// Token: 0x06001919 RID: 6425 RVA: 0x0008535B File Offset: 0x0008355B
	protected override string GetNotifyName_Implementation()
	{
		return "切换武器到挂点";
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00085362 File Offset: 0x00083562
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWeaponHang._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHang.TsAnimNotifyStateWeaponHang_C");
		}
		return TsAnimNotifyStateWeaponHang._ClassPtr;
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00085388 File Offset: 0x00083588
	public TsAnimNotifyStateWeaponHang() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHang.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x000853B0 File Offset: 0x000835B0
	public TsAnimNotifyStateWeaponHang(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x000853E3 File Offset: 0x000835E3
	protected TsAnimNotifyStateWeaponHang(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x000853EC File Offset: 0x000835EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00085428 File Offset: 0x00083628
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x0008545B File Offset: 0x0008365B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001090 RID: 4240
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHang.TsAnimNotifyStateWeaponHang_C";

	// Token: 0x04001091 RID: 4241
	private static IntPtr _ClassPtr;

	// Token: 0x04001092 RID: 4242
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001093 RID: 4243
	private static int __PropertyOffset_Id;

	// Token: 0x04001094 RID: 4244
	private static int __PropertyOffset_新的挂载点名;

	// Token: 0x04001095 RID: 4245
	[Nullable(2)]
	private TArray<FName> _新的挂载点名;

	// Token: 0x04001096 RID: 4246
	private static int __PropertyOffset_挂载相对位置;

	// Token: 0x04001097 RID: 4247
	[Nullable(2)]
	private TArray<FTransform> _挂载相对位置;

	// Token: 0x04001098 RID: 4248
	private static int __PropertyOffset_结束后状态;

	// Token: 0x04001099 RID: 4249
	private static int __PropertyOffset_缓冲时间;
}

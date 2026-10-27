using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018B RID: 395
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHangWithTag.TsAnimNotifyStateWeaponHangWithTag_C")]
public class TsAnimNotifyStateWeaponHangWithTag : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06001921 RID: 6433 RVA: 0x0008546F File Offset: 0x0008366F
	// (set) Token: 0x06001922 RID: 6434 RVA: 0x0008547F File Offset: 0x0008367F
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

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x06001923 RID: 6435 RVA: 0x00085490 File Offset: 0x00083690
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

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06001924 RID: 6436 RVA: 0x000854CC File Offset: 0x000836CC
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

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06001925 RID: 6437 RVA: 0x00085505 File Offset: 0x00083705
	// (set) Token: 0x06001926 RID: 6438 RVA: 0x00085515 File Offset: 0x00083715
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

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06001927 RID: 6439 RVA: 0x00085526 File Offset: 0x00083726
	// (set) Token: 0x06001928 RID: 6440 RVA: 0x00085536 File Offset: 0x00083736
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

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06001929 RID: 6441 RVA: 0x00085547 File Offset: 0x00083747
	// (set) Token: 0x0600192A RID: 6442 RVA: 0x0008555B File Offset: 0x0008375B
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

	// Token: 0x0600192B RID: 6443 RVA: 0x00085570 File Offset: 0x00083770
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

	// Token: 0x0600192C RID: 6444 RVA: 0x00085618 File Offset: 0x00083818
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

	// Token: 0x0600192D RID: 6445 RVA: 0x000856B8 File Offset: 0x000838B8
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

	// Token: 0x0600192E RID: 6446 RVA: 0x00085758 File Offset: 0x00083958
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

	// Token: 0x0600192F RID: 6447 RVA: 0x00085828 File Offset: 0x00083A28
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

	// Token: 0x06001930 RID: 6448 RVA: 0x000858A3 File Offset: 0x00083AA3
	protected override string GetNotifyName_Implementation()
	{
		return "切换武器到挂点";
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x000858AA File Offset: 0x00083AAA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWeaponHangWithTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHangWithTag.TsAnimNotifyStateWeaponHangWithTag_C");
		}
		return TsAnimNotifyStateWeaponHangWithTag._ClassPtr;
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x000858D0 File Offset: 0x00083AD0
	public TsAnimNotifyStateWeaponHangWithTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHangWithTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x000858F8 File Offset: 0x00083AF8
	public TsAnimNotifyStateWeaponHangWithTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWeaponHangWithTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x0008592B File Offset: 0x00083B2B
	protected TsAnimNotifyStateWeaponHangWithTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00085934 File Offset: 0x00083B34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00085970 File Offset: 0x00083B70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x000859A3 File Offset: 0x00083BA3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400109A RID: 4250
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWeaponHangWithTag.TsAnimNotifyStateWeaponHangWithTag_C";

	// Token: 0x0400109B RID: 4251
	private static IntPtr _ClassPtr;

	// Token: 0x0400109C RID: 4252
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400109D RID: 4253
	private static int __PropertyOffset_Id;

	// Token: 0x0400109E RID: 4254
	private static int __PropertyOffset_新的挂载点名;

	// Token: 0x0400109F RID: 4255
	[Nullable(2)]
	private TArray<FName> _新的挂载点名;

	// Token: 0x040010A0 RID: 4256
	private static int __PropertyOffset_挂载相对位置;

	// Token: 0x040010A1 RID: 4257
	[Nullable(2)]
	private TArray<FTransform> _挂载相对位置;

	// Token: 0x040010A2 RID: 4258
	private static int __PropertyOffset_结束后状态;

	// Token: 0x040010A3 RID: 4259
	private static int __PropertyOffset_缓冲时间;

	// Token: 0x040010A4 RID: 4260
	private static int __PropertyOffset_ActivateTag;
}

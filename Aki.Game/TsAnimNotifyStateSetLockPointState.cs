using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000166 RID: 358
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetLockPointState.TsAnimNotifyStateSetLockPointState_C")]
public class TsAnimNotifyStateSetLockPointState : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x0600168B RID: 5771 RVA: 0x0007AC57 File Offset: 0x00078E57
	// (set) Token: 0x0600168C RID: 5772 RVA: 0x0007AC6B File Offset: 0x00078E6B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BoneName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSetLockPointState.__PropertyOffset_BoneName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSetLockPointState.__PropertyOffset_BoneName)), value);
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x0600168D RID: 5773 RVA: 0x0007AC80 File Offset: 0x00078E80
	// (set) Token: 0x0600168E RID: 5774 RVA: 0x0007AC90 File Offset: 0x00078E90
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SoftLockValid
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetLockPointState.__PropertyOffset_SoftLockValid) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetLockPointState.__PropertyOffset_SoftLockValid) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x0600168F RID: 5775 RVA: 0x0007ACA1 File Offset: 0x00078EA1
	// (set) Token: 0x06001690 RID: 5776 RVA: 0x0007ACB1 File Offset: 0x00078EB1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HardLockValid
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetLockPointState.__PropertyOffset_HardLockValid) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetLockPointState.__PropertyOffset_HardLockValid) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0007ACC4 File Offset: 0x00078EC4
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

	// Token: 0x06001692 RID: 5778 RVA: 0x0007AD6C File Offset: 0x00078F6C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		LockOnPart lockOnPart;
		if (!tsBaseCharacter.CharacterActorComponent.LockOnParts.TryGetValue(this.BoneName, out lockOnPart))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[TsAnimNotifyStateSetLockPointState.NotifyBegin]: 角色'");
			defaultInterpolatedStringHandler.AppendFormatted<AActor>(owner);
			defaultInterpolatedStringHandler.AppendLiteral("'未找到锁定点'");
			defaultInterpolatedStringHandler.AppendFormatted(this.BoneName);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.OldSoftLockValid = lockOnPart.SoftLockValid;
		this.OldHardLockValid = lockOnPart.HardLockValid;
		lockOnPart.SoftLockValid = this.SoftLockValid;
		lockOnPart.HardLockValid = this.HardLockValid;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		object obj;
		if (baseCharacter == null)
		{
			obj = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			if (characterActorComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null);
			}
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.RefreshCurrentLockState(CharacterModel.Instance.GetHandleByEntity(tsBaseCharacter.CharacterActorComponent.Entity), this.BoneName);
		}
		return true;
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x0007AE8C File Offset: 0x0007908C
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

	// Token: 0x06001694 RID: 5780 RVA: 0x0007AF2C File Offset: 0x0007912C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		LockOnPart lockOnPart;
		if (!tsBaseCharacter.CharacterActorComponent.LockOnParts.TryGetValue(this.BoneName, out lockOnPart))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[TsAnimNotifyStateSetLockPointState.NotifyEnd]: 角色'");
			defaultInterpolatedStringHandler.AppendFormatted<AActor>(owner);
			defaultInterpolatedStringHandler.AppendLiteral("'未找到锁定点'");
			defaultInterpolatedStringHandler.AppendFormatted(this.BoneName);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		lockOnPart.SoftLockValid = this.OldSoftLockValid;
		lockOnPart.HardLockValid = this.OldHardLockValid;
		return true;
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0007AFE4 File Offset: 0x000791E4
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

	// Token: 0x06001696 RID: 5782 RVA: 0x0007B05F File Offset: 0x0007925F
	protected override string GetNotifyName_Implementation()
	{
		return "设置部位软硬锁是否启用";
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0007B066 File Offset: 0x00079266
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetLockPointState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetLockPointState.TsAnimNotifyStateSetLockPointState_C");
		}
		return TsAnimNotifyStateSetLockPointState._ClassPtr;
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0007B08C File Offset: 0x0007928C
	public TsAnimNotifyStateSetLockPointState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetLockPointState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0007B0B4 File Offset: 0x000792B4
	public TsAnimNotifyStateSetLockPointState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetLockPointState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x0007B0E7 File Offset: 0x000792E7
	protected TsAnimNotifyStateSetLockPointState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x0007B0F0 File Offset: 0x000792F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x0007B12C File Offset: 0x0007932C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x0007B15F File Offset: 0x0007935F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F9B RID: 3995
	private bool OldSoftLockValid;

	// Token: 0x04000F9C RID: 3996
	private bool OldHardLockValid;

	// Token: 0x04000F9D RID: 3997
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetLockPointState.TsAnimNotifyStateSetLockPointState_C";

	// Token: 0x04000F9E RID: 3998
	private static IntPtr _ClassPtr;

	// Token: 0x04000F9F RID: 3999
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FA0 RID: 4000
	private static int __PropertyOffset_BoneName;

	// Token: 0x04000FA1 RID: 4001
	private static int __PropertyOffset_SoftLockValid;

	// Token: 0x04000FA2 RID: 4002
	private static int __PropertyOffset_HardLockValid;
}

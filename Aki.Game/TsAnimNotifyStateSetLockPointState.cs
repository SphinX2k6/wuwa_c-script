using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016A RID: 362
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetLockPointState.TsAnimNotifyStateSetLockPointState_C")]
public class TsAnimNotifyStateSetLockPointState : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06001728 RID: 5928 RVA: 0x0008062F File Offset: 0x0007E82F
	// (set) Token: 0x06001729 RID: 5929 RVA: 0x00080643 File Offset: 0x0007E843
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

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x0600172A RID: 5930 RVA: 0x00080658 File Offset: 0x0007E858
	// (set) Token: 0x0600172B RID: 5931 RVA: 0x00080668 File Offset: 0x0007E868
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

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x0600172C RID: 5932 RVA: 0x00080679 File Offset: 0x0007E879
	// (set) Token: 0x0600172D RID: 5933 RVA: 0x00080689 File Offset: 0x0007E889
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

	// Token: 0x0600172E RID: 5934 RVA: 0x0008069C File Offset: 0x0007E89C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetLockPointState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetLockPointState.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600172F RID: 5935 RVA: 0x0008075C File Offset: 0x0007E95C
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

	// Token: 0x06001730 RID: 5936 RVA: 0x0008087C File Offset: 0x0007EA7C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetLockPointState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetLockPointState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001731 RID: 5937 RVA: 0x00080934 File Offset: 0x0007EB34
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

	// Token: 0x06001732 RID: 5938 RVA: 0x000809EC File Offset: 0x0007EBEC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetLockPointState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetLockPointState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001733 RID: 5939 RVA: 0x00080A7C File Offset: 0x0007EC7C
	protected override string GetNotifyName_Implementation()
	{
		return "设置部位软硬锁是否启用";
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x00080A83 File Offset: 0x0007EC83
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetLockPointState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetLockPointState.TsAnimNotifyStateSetLockPointState_C");
		}
		return TsAnimNotifyStateSetLockPointState._ClassPtr;
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00080AA8 File Offset: 0x0007ECA8
	public TsAnimNotifyStateSetLockPointState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetLockPointState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x00080AD0 File Offset: 0x0007ECD0
	public TsAnimNotifyStateSetLockPointState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetLockPointState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x00080B03 File Offset: 0x0007ED03
	protected TsAnimNotifyStateSetLockPointState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00080B0C File Offset: 0x0007ED0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x00080B48 File Offset: 0x0007ED48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600173A RID: 5946 RVA: 0x00080B7B File Offset: 0x0007ED7B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FDE RID: 4062
	private bool OldSoftLockValid;

	// Token: 0x04000FDF RID: 4063
	private bool OldHardLockValid;

	// Token: 0x04000FE0 RID: 4064
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetLockPointState.TsAnimNotifyStateSetLockPointState_C";

	// Token: 0x04000FE1 RID: 4065
	private static IntPtr _ClassPtr;

	// Token: 0x04000FE2 RID: 4066
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FE3 RID: 4067
	private static int __PropertyOffset_BoneName;

	// Token: 0x04000FE4 RID: 4068
	private static int __PropertyOffset_SoftLockValid;

	// Token: 0x04000FE5 RID: 4069
	private static int __PropertyOffset_HardLockValid;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200013D RID: 317
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateIgnoreLockOnTarget.TsAnimNotifyStateIgnoreLockOnTarget_C")]
public class TsAnimNotifyStateIgnoreLockOnTarget : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700032C RID: 812
	// (get) Token: 0x0600136C RID: 4972 RVA: 0x0006D0FB File Offset: 0x0006B2FB
	// (set) Token: 0x0600136D RID: 4973 RVA: 0x0006D10F File Offset: 0x0006B30F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string IgnoreSocket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateIgnoreLockOnTarget.__PropertyOffset_IgnoreSocket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateIgnoreLockOnTarget.__PropertyOffset_IgnoreSocket)), value);
		}
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x0006D124 File Offset: 0x0006B324
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

	// Token: 0x0600136F RID: 4975 RVA: 0x0006D1CC File Offset: 0x0006B3CC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		return aactor is TsBaseCharacter && this.ForceIgnore((TsBaseCharacter)aactor, true);
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x0006D200 File Offset: 0x0006B400
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

	// Token: 0x06001371 RID: 4977 RVA: 0x0006D2A0 File Offset: 0x0006B4A0
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		return aactor is TsBaseCharacter && this.ForceIgnore((TsBaseCharacter)aactor, false);
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x0006D2D4 File Offset: 0x0006B4D4
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

	// Token: 0x06001373 RID: 4979 RVA: 0x0006D34F File Offset: 0x0006B54F
	protected override string GetNotifyName_Implementation()
	{
		return "强制忽略目标";
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x0006D358 File Offset: 0x0006B558
	private bool ForceIgnore(TsBaseCharacter owner, bool enable)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return false;
		}
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(owner, true);
		CharacterLockOnComponent characterLockOnComponent;
		if (getCurrentEntity == null)
		{
			characterLockOnComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			characterLockOnComponent = ((entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null);
		}
		CharacterLockOnComponent characterLockOnComponent2 = characterLockOnComponent;
		if (characterLockOnComponent2 != null)
		{
			characterLockOnComponent2.ForceIgnore(new LockOnInfo(entityByActor, this.IgnoreSocket), enable);
			return true;
		}
		return false;
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x0006D3AF File Offset: 0x0006B5AF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateIgnoreLockOnTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateIgnoreLockOnTarget.TsAnimNotifyStateIgnoreLockOnTarget_C");
		}
		return TsAnimNotifyStateIgnoreLockOnTarget._ClassPtr;
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
	public TsAnimNotifyStateIgnoreLockOnTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x0006D3FC File Offset: 0x0006B5FC
	public TsAnimNotifyStateIgnoreLockOnTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x0006D42F File Offset: 0x0006B62F
	protected TsAnimNotifyStateIgnoreLockOnTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x0006D438 File Offset: 0x0006B638
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x0006D474 File Offset: 0x0006B674
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x0006D4A7 File Offset: 0x0006B6A7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E2D RID: 3629
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateIgnoreLockOnTarget.TsAnimNotifyStateIgnoreLockOnTarget_C";

	// Token: 0x04000E2E RID: 3630
	private static IntPtr _ClassPtr;

	// Token: 0x04000E2F RID: 3631
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E30 RID: 3632
	private static int __PropertyOffset_IgnoreSocket;
}

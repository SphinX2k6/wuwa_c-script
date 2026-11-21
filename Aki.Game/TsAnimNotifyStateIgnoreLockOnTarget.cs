using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200013E RID: 318
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateIgnoreLockOnTarget.TsAnimNotifyStateIgnoreLockOnTarget_C")]
public class TsAnimNotifyStateIgnoreLockOnTarget : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000347 RID: 839
	// (get) Token: 0x060013EA RID: 5098 RVA: 0x000716F7 File Offset: 0x0006F8F7
	// (set) Token: 0x060013EB RID: 5099 RVA: 0x0007170B File Offset: 0x0006F90B
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

	// Token: 0x060013EC RID: 5100 RVA: 0x00071720 File Offset: 0x0006F920
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateIgnoreLockOnTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013ED RID: 5101 RVA: 0x000717E0 File Offset: 0x0006F9E0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		return aactor is TsBaseCharacter && this.ForceIgnore((TsBaseCharacter)aactor, true);
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00071814 File Offset: 0x0006FA14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateIgnoreLockOnTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013EF RID: 5103 RVA: 0x000718CC File Offset: 0x0006FACC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		return aactor is TsBaseCharacter && this.ForceIgnore((TsBaseCharacter)aactor, false);
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00071900 File Offset: 0x0006FB00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateIgnoreLockOnTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013F1 RID: 5105 RVA: 0x00071990 File Offset: 0x0006FB90
	protected override string GetNotifyName_Implementation()
	{
		return "强制忽略目标";
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00071998 File Offset: 0x0006FB98
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

	// Token: 0x060013F3 RID: 5107 RVA: 0x000719EF File Offset: 0x0006FBEF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateIgnoreLockOnTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateIgnoreLockOnTarget.TsAnimNotifyStateIgnoreLockOnTarget_C");
		}
		return TsAnimNotifyStateIgnoreLockOnTarget._ClassPtr;
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00071A14 File Offset: 0x0006FC14
	public TsAnimNotifyStateIgnoreLockOnTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00071A3C File Offset: 0x0006FC3C
	public TsAnimNotifyStateIgnoreLockOnTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateIgnoreLockOnTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00071A6F File Offset: 0x0006FC6F
	protected TsAnimNotifyStateIgnoreLockOnTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00071A78 File Offset: 0x0006FC78
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00071AB4 File Offset: 0x0006FCB4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00071AE7 File Offset: 0x0006FCE7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E5F RID: 3679
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateIgnoreLockOnTarget.TsAnimNotifyStateIgnoreLockOnTarget_C";

	// Token: 0x04000E60 RID: 3680
	private static IntPtr _ClassPtr;

	// Token: 0x04000E61 RID: 3681
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E62 RID: 3682
	private static int __PropertyOffset_IgnoreSocket;
}

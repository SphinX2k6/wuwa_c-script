using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000163 RID: 355
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionLv.TsAnimNotifyStateSetCollisionLv_C")]
public class TsAnimNotifyStateSetCollisionLv : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003AD RID: 941
	// (get) Token: 0x0600165A RID: 5722 RVA: 0x0007A163 File Offset: 0x00078363
	// (set) Token: 0x0600165B RID: 5723 RVA: 0x0007A173 File Offset: 0x00078373
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int HitPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionLv.__PropertyOffset_HitPriority);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionLv.__PropertyOffset_HitPriority) = value;
		}
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0007A184 File Offset: 0x00078384
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

	// Token: 0x0600165D RID: 5725 RVA: 0x0007A22C File Offset: 0x0007842C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			(owner as TsBaseCharacter).CharacterMovement.HitPriority = this.HitPriority;
			this.HitPriority = 0;
			return true;
		}
		return false;
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0007A268 File Offset: 0x00078468
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

	// Token: 0x0600165F RID: 5727 RVA: 0x0007A308 File Offset: 0x00078508
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			(owner as TsBaseCharacter).CharacterMovement.HitPriority = this.HitPriority;
			return true;
		}
		return false;
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x0007A33D File Offset: 0x0007853D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetCollisionLv._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionLv.TsAnimNotifyStateSetCollisionLv_C");
		}
		return TsAnimNotifyStateSetCollisionLv._ClassPtr;
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x0007A364 File Offset: 0x00078564
	public TsAnimNotifyStateSetCollisionLv() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionLv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x0007A38C File Offset: 0x0007858C
	[NullableContext(1)]
	public TsAnimNotifyStateSetCollisionLv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionLv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0007A3BF File Offset: 0x000785BF
	protected TsAnimNotifyStateSetCollisionLv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0007A3C8 File Offset: 0x000785C8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0007A404 File Offset: 0x00078604
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000F8C RID: 3980
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionLv.TsAnimNotifyStateSetCollisionLv_C";

	// Token: 0x04000F8D RID: 3981
	private static IntPtr _ClassPtr;

	// Token: 0x04000F8E RID: 3982
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F8F RID: 3983
	private static int __PropertyOffset_HitPriority;
}

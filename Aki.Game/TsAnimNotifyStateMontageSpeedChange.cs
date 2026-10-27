using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000148 RID: 328
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMontageSpeedChange.TsAnimNotifyStateMontageSpeedChange_C")]
public class TsAnimNotifyStateMontageSpeedChange : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000344 RID: 836
	// (get) Token: 0x0600142B RID: 5163 RVA: 0x000708E7 File Offset: 0x0006EAE7
	// (set) Token: 0x0600142C RID: 5164 RVA: 0x000708F7 File Offset: 0x0006EAF7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MontagePlayRate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateMontageSpeedChange.__PropertyOffset_MontagePlayRate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateMontageSpeedChange.__PropertyOffset_MontagePlayRate) = value;
		}
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x00070908 File Offset: 0x0006EB08
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

	// Token: 0x0600142E RID: 5166 RVA: 0x000709B0 File Offset: 0x0006EBB0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			UAnimInstance animInstance = meshComp.GetAnimInstance();
			if (animInstance != null)
			{
				animInstance.Montage_SetPlayRate(null, this.MontagePlayRate);
			}
			return true;
		}
		Entity entityNoBlueprint = ((TsBaseCharacter)owner).GetEntityNoBlueprint();
		if (entityNoBlueprint != null)
		{
			CharacterAnimationComponent component = entityNoBlueprint.GetComponent<CharacterAnimationComponent>();
			if (component != null)
			{
				UAnimInstance mainAnimInstance = component.MainAnimInstance;
				if (mainAnimInstance != null)
				{
					mainAnimInstance.Montage_SetPlayRate(null, this.MontagePlayRate);
				}
			}
		}
		return true;
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00070A1C File Offset: 0x0006EC1C
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

	// Token: 0x06001430 RID: 5168 RVA: 0x00070ABC File Offset: 0x0006ECBC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			UAnimInstance animInstance = meshComp.GetAnimInstance();
			if (animInstance != null)
			{
				animInstance.Montage_SetPlayRate(null, 1f);
			}
			return true;
		}
		Entity entityNoBlueprint = ((TsBaseCharacter)owner).GetEntityNoBlueprint();
		if (entityNoBlueprint != null)
		{
			CharacterAnimationComponent component = entityNoBlueprint.GetComponent<CharacterAnimationComponent>();
			if (component != null)
			{
				UAnimInstance mainAnimInstance = component.MainAnimInstance;
				if (mainAnimInstance != null)
				{
					mainAnimInstance.Montage_SetPlayRate(null, 1f);
				}
			}
		}
		return true;
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x00070B24 File Offset: 0x0006ED24
	[NullableContext(1)]
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

	// Token: 0x06001432 RID: 5170 RVA: 0x00070B9F File Offset: 0x0006ED9F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "配置蒙太奇播放速度变化";
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x00070BA6 File Offset: 0x0006EDA6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateMontageSpeedChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMontageSpeedChange.TsAnimNotifyStateMontageSpeedChange_C");
		}
		return TsAnimNotifyStateMontageSpeedChange._ClassPtr;
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x00070BCC File Offset: 0x0006EDCC
	public TsAnimNotifyStateMontageSpeedChange() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMontageSpeedChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x00070BF4 File Offset: 0x0006EDF4
	[NullableContext(1)]
	public TsAnimNotifyStateMontageSpeedChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMontageSpeedChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x00070C27 File Offset: 0x0006EE27
	protected TsAnimNotifyStateMontageSpeedChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00070C30 File Offset: 0x0006EE30
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x00070C6C File Offset: 0x0006EE6C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00070C9F File Offset: 0x0006EE9F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E83 RID: 3715
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMontageSpeedChange.TsAnimNotifyStateMontageSpeedChange_C";

	// Token: 0x04000E84 RID: 3716
	private static IntPtr _ClassPtr;

	// Token: 0x04000E85 RID: 3717
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E86 RID: 3718
	private static int __PropertyOffset_MontagePlayRate;
}

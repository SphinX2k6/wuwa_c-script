using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200014C RID: 332
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMontageSpeedChange.TsAnimNotifyStateMontageSpeedChange_C")]
public class TsAnimNotifyStateMontageSpeedChange : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000366 RID: 870
	// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00075BB3 File Offset: 0x00073DB3
	// (set) Token: 0x060014C9 RID: 5321 RVA: 0x00075BC3 File Offset: 0x00073DC3
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

	// Token: 0x060014CA RID: 5322 RVA: 0x00075BD4 File Offset: 0x00073DD4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMontageSpeedChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateMontageSpeedChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014CB RID: 5323 RVA: 0x00075C94 File Offset: 0x00073E94
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

	// Token: 0x060014CC RID: 5324 RVA: 0x00075D00 File Offset: 0x00073F00
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMontageSpeedChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateMontageSpeedChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014CD RID: 5325 RVA: 0x00075DB8 File Offset: 0x00073FB8
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

	// Token: 0x060014CE RID: 5326 RVA: 0x00075E20 File Offset: 0x00074020
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMontageSpeedChange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateMontageSpeedChange.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014CF RID: 5327 RVA: 0x00075EB0 File Offset: 0x000740B0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "配置蒙太奇播放速度变化";
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x00075EB7 File Offset: 0x000740B7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateMontageSpeedChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMontageSpeedChange.TsAnimNotifyStateMontageSpeedChange_C");
		}
		return TsAnimNotifyStateMontageSpeedChange._ClassPtr;
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x00075EDC File Offset: 0x000740DC
	public TsAnimNotifyStateMontageSpeedChange() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMontageSpeedChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x00075F04 File Offset: 0x00074104
	[NullableContext(1)]
	public TsAnimNotifyStateMontageSpeedChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMontageSpeedChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x00075F37 File Offset: 0x00074137
	protected TsAnimNotifyStateMontageSpeedChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x00075F40 File Offset: 0x00074140
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x00075F7C File Offset: 0x0007417C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x00075FAF File Offset: 0x000741AF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EC6 RID: 3782
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMontageSpeedChange.TsAnimNotifyStateMontageSpeedChange_C";

	// Token: 0x04000EC7 RID: 3783
	private static IntPtr _ClassPtr;

	// Token: 0x04000EC8 RID: 3784
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EC9 RID: 3785
	private static int __PropertyOffset_MontagePlayRate;
}

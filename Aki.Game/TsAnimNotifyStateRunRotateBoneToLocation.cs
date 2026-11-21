using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000164 RID: 356
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRunRotateBoneToLocation.TsAnimNotifyStateRunRotateBoneToLocation_C")]
public class TsAnimNotifyStateRunRotateBoneToLocation : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0007E893 File Offset: 0x0007CA93
	// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0007E8A7 File Offset: 0x0007CAA7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D TurnLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_TurnLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_TurnLimit) = value;
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x060016B8 RID: 5816 RVA: 0x0007E8BC File Offset: 0x0007CABC
	// (set) Token: 0x060016B9 RID: 5817 RVA: 0x0007E8D0 File Offset: 0x0007CAD0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D LookUpLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_LookUpLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_LookUpLimit) = value;
		}
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x060016BA RID: 5818 RVA: 0x0007E8E5 File Offset: 0x0007CAE5
	// (set) Token: 0x060016BB RID: 5819 RVA: 0x0007E8F9 File Offset: 0x0007CAF9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat TurnSpeed
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_TurnSpeed);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_TurnSpeed, value);
		}
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x060016BC RID: 5820 RVA: 0x0007E90E File Offset: 0x0007CB0E
	// (set) Token: 0x060016BD RID: 5821 RVA: 0x0007E922 File Offset: 0x0007CB22
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat LookUpSpeed
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_LookUpSpeed);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_LookUpSpeed, value);
		}
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x060016BE RID: 5822 RVA: 0x0007E937 File Offset: 0x0007CB37
	// (set) Token: 0x060016BF RID: 5823 RVA: 0x0007E947 File Offset: 0x0007CB47
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_TurnOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_TurnOffset) = value;
		}
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0007E958 File Offset: 0x0007CB58
	// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0007E968 File Offset: 0x0007CB68
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LookUpOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_LookUpOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRunRotateBoneToLocation.__PropertyOffset_LookUpOffset) = value;
		}
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0007E97C File Offset: 0x0007CB7C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRunRotateBoneToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016C3 RID: 5827 RVA: 0x0007EA3C File Offset: 0x0007CC3C
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			if ((owner as TsBaseCharacter).CharacterActorComponent == null)
			{
				return false;
			}
			Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
			CharacterAnimationComponent characterAnimationComponent = (entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null;
			if (characterAnimationComponent == null || characterAnimationComponent.MainAnimInstance == null || !(characterAnimationComponent.MainAnimInstance is UKuroAnimInstance))
			{
				return false;
			}
			float turnAngle = 1f;
			if (this.TurnSpeed != null)
			{
				turnAngle = this.TurnSpeed.GetFloatValue(0f);
			}
			float lookUpAngle = 1f;
			if (this.LookUpSpeed != null)
			{
				lookUpAngle = this.LookUpSpeed.GetFloatValue(0f);
			}
			(characterAnimationComponent.MainAnimInstance as UKuroAnimInstance).SetBoneRotateToLocationInfoRunBegin(turnAngle, lookUpAngle, this.TurnLimit, this.LookUpLimit, this.TurnOffset, this.LookUpOffset);
		}
		return true;
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x0007EB0C File Offset: 0x0007CD0C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRunRotateBoneToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016C5 RID: 5829 RVA: 0x0007EBC4 File Offset: 0x0007CDC4
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			if ((owner as TsBaseCharacter).CharacterActorComponent == null)
			{
				return false;
			}
			Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
			CharacterAnimationComponent characterAnimationComponent = (entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null;
			if (characterAnimationComponent == null || characterAnimationComponent.MainAnimInstance == null || !(characterAnimationComponent.MainAnimInstance is UKuroAnimInstance))
			{
				return false;
			}
			(characterAnimationComponent.MainAnimInstance as UKuroAnimInstance).SetBoneRotateToLocationInfoRunEnd();
		}
		return true;
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x0007EC38 File Offset: 0x0007CE38
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRunRotateBoneToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x0007ECF8 File Offset: 0x0007CEF8
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			CharacterAnimationComponent characterAnimationComponent;
			if (characterActorComponent == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 != null && characterAnimationComponent2.MainAnimInstance != null)
			{
				UKuroAnimInstance ukuroAnimInstance = characterAnimationComponent2.MainAnimInstance as UKuroAnimInstance;
				if (ukuroAnimInstance != null)
				{
					float currentTriggerOffsetInThisNotifyTick = base.GetCurrentTriggerOffsetInThisNotifyTick();
					float turnAngle = 1f;
					if (this.TurnSpeed != null)
					{
						turnAngle = this.TurnSpeed.GetFloatValue(currentTriggerOffsetInThisNotifyTick);
					}
					float lookUpAngle = 1f;
					if (this.LookUpSpeed != null)
					{
						lookUpAngle = this.LookUpSpeed.GetFloatValue(currentTriggerOffsetInThisNotifyTick);
					}
					ukuroAnimInstance.SetBoneRotateToLocationInfoRunTick(turnAngle, lookUpAngle);
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x0007EDA0 File Offset: 0x0007CFA0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRunRotateBoneToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016C9 RID: 5833 RVA: 0x0007EE30 File Offset: 0x0007D030
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "控制一根骨骼朝向目标";
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x0007EE37 File Offset: 0x0007D037
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRunRotateBoneToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRunRotateBoneToLocation.TsAnimNotifyStateRunRotateBoneToLocation_C");
		}
		return TsAnimNotifyStateRunRotateBoneToLocation._ClassPtr;
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x0007EE5C File Offset: 0x0007D05C
	public TsAnimNotifyStateRunRotateBoneToLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0007EE84 File Offset: 0x0007D084
	[NullableContext(1)]
	public TsAnimNotifyStateRunRotateBoneToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x0007EEB7 File Offset: 0x0007D0B7
	protected TsAnimNotifyStateRunRotateBoneToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0007EEC0 File Offset: 0x0007D0C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x0007EEFC File Offset: 0x0007D0FC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0007EF30 File Offset: 0x0007D130
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x0007EF69 File Offset: 0x0007D169
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FB6 RID: 4022
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRunRotateBoneToLocation.TsAnimNotifyStateRunRotateBoneToLocation_C";

	// Token: 0x04000FB7 RID: 4023
	private static IntPtr _ClassPtr;

	// Token: 0x04000FB8 RID: 4024
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FB9 RID: 4025
	private static int __PropertyOffset_TurnLimit;

	// Token: 0x04000FBA RID: 4026
	private static int __PropertyOffset_LookUpLimit;

	// Token: 0x04000FBB RID: 4027
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000FBC RID: 4028
	private static int __PropertyOffset_LookUpSpeed;

	// Token: 0x04000FBD RID: 4029
	private static int __PropertyOffset_TurnOffset;

	// Token: 0x04000FBE RID: 4030
	private static int __PropertyOffset_LookUpOffset;
}

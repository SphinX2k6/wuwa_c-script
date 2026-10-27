using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000160 RID: 352
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRunRotateBoneToLocation.TsAnimNotifyStateRunRotateBoneToLocation_C")]
public class TsAnimNotifyStateRunRotateBoneToLocation : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003A1 RID: 929
	// (get) Token: 0x06001619 RID: 5657 RVA: 0x00079057 File Offset: 0x00077257
	// (set) Token: 0x0600161A RID: 5658 RVA: 0x0007906B File Offset: 0x0007726B
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

	// Token: 0x170003A2 RID: 930
	// (get) Token: 0x0600161B RID: 5659 RVA: 0x00079080 File Offset: 0x00077280
	// (set) Token: 0x0600161C RID: 5660 RVA: 0x00079094 File Offset: 0x00077294
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

	// Token: 0x170003A3 RID: 931
	// (get) Token: 0x0600161D RID: 5661 RVA: 0x000790A9 File Offset: 0x000772A9
	// (set) Token: 0x0600161E RID: 5662 RVA: 0x000790BD File Offset: 0x000772BD
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

	// Token: 0x170003A4 RID: 932
	// (get) Token: 0x0600161F RID: 5663 RVA: 0x000790D2 File Offset: 0x000772D2
	// (set) Token: 0x06001620 RID: 5664 RVA: 0x000790E6 File Offset: 0x000772E6
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

	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x06001621 RID: 5665 RVA: 0x000790FB File Offset: 0x000772FB
	// (set) Token: 0x06001622 RID: 5666 RVA: 0x0007910B File Offset: 0x0007730B
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

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06001623 RID: 5667 RVA: 0x0007911C File Offset: 0x0007731C
	// (set) Token: 0x06001624 RID: 5668 RVA: 0x0007912C File Offset: 0x0007732C
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

	// Token: 0x06001625 RID: 5669 RVA: 0x00079140 File Offset: 0x00077340
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

	// Token: 0x06001626 RID: 5670 RVA: 0x000791E8 File Offset: 0x000773E8
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

	// Token: 0x06001627 RID: 5671 RVA: 0x000792B8 File Offset: 0x000774B8
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

	// Token: 0x06001628 RID: 5672 RVA: 0x00079358 File Offset: 0x00077558
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

	// Token: 0x06001629 RID: 5673 RVA: 0x000793CC File Offset: 0x000775CC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x00079474 File Offset: 0x00077674
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

	// Token: 0x0600162B RID: 5675 RVA: 0x0007951C File Offset: 0x0007771C
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

	// Token: 0x0600162C RID: 5676 RVA: 0x00079597 File Offset: 0x00077797
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "控制一根骨骼朝向目标";
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0007959E File Offset: 0x0007779E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRunRotateBoneToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRunRotateBoneToLocation.TsAnimNotifyStateRunRotateBoneToLocation_C");
		}
		return TsAnimNotifyStateRunRotateBoneToLocation._ClassPtr;
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x000795C4 File Offset: 0x000777C4
	public TsAnimNotifyStateRunRotateBoneToLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x000795EC File Offset: 0x000777EC
	[NullableContext(1)]
	public TsAnimNotifyStateRunRotateBoneToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRunRotateBoneToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x0007961F File Offset: 0x0007781F
	protected TsAnimNotifyStateRunRotateBoneToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x00079628 File Offset: 0x00077828
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00079664 File Offset: 0x00077864
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x00079698 File Offset: 0x00077898
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x000796D1 File Offset: 0x000778D1
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F73 RID: 3955
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRunRotateBoneToLocation.TsAnimNotifyStateRunRotateBoneToLocation_C";

	// Token: 0x04000F74 RID: 3956
	private static IntPtr _ClassPtr;

	// Token: 0x04000F75 RID: 3957
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F76 RID: 3958
	private static int __PropertyOffset_TurnLimit;

	// Token: 0x04000F77 RID: 3959
	private static int __PropertyOffset_LookUpLimit;

	// Token: 0x04000F78 RID: 3960
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000F79 RID: 3961
	private static int __PropertyOffset_LookUpSpeed;

	// Token: 0x04000F7A RID: 3962
	private static int __PropertyOffset_TurnOffset;

	// Token: 0x04000F7B RID: 3963
	private static int __PropertyOffset_LookUpOffset;
}

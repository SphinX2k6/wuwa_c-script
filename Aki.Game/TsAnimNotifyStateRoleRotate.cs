using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015B RID: 347
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRoleRotate.TsAnimNotifyStateRoleRotate_C")]
public class TsAnimNotifyStateRoleRotate : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700039A RID: 922
	// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0007B223 File Offset: 0x00079423
	// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0007B233 File Offset: 0x00079433
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 旋转速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_旋转速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_旋转速度) = value;
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0007B244 File Offset: 0x00079444
	// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0007B254 File Offset: 0x00079454
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否自动朝向目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_是否自动朝向目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_是否自动朝向目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x060015FA RID: 5626 RVA: 0x0007B268 File Offset: 0x00079468
	// (set) Token: 0x060015FB RID: 5627 RVA: 0x0007B2A1 File Offset: 0x000794A1
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	private FGameplayTagContainer TagContainer
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._TagContainer) == null)
			{
				result = (this._TagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_TagContainer, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_TagContainer, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x060015FC RID: 5628 RVA: 0x0007B2C9 File Offset: 0x000794C9
	// (set) Token: 0x060015FD RID: 5629 RVA: 0x0007B2D9 File Offset: 0x000794D9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 在横板模式中禁用
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_在横板模式中禁用) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_在横板模式中禁用) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x060015FE RID: 5630 RVA: 0x0007B2EA File Offset: 0x000794EA
	// (set) Token: 0x060015FF RID: 5631 RVA: 0x0007B2FA File Offset: 0x000794FA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 只在横板模式中生效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_只在横板模式中生效) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRoleRotate.__PropertyOffset_只在横板模式中生效) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0007B30C File Offset: 0x0007950C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRoleRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRoleRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001601 RID: 5633 RVA: 0x0007B3CC File Offset: 0x000795CC
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Init();
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			if (entityNoBlueprint == null || !entityNoBlueprint.Valid)
			{
				return false;
			}
			if (this.在横板模式中禁用)
			{
				CharacterSplineMoveComponent component = entityNoBlueprint.GetComponent<CharacterSplineMoveComponent>();
				if (component != null && component.Active)
				{
					return false;
				}
			}
			else if (this.只在横板模式中生效)
			{
				CharacterSplineMoveComponent component2 = entityNoBlueprint.GetComponent<CharacterSplineMoveComponent>();
				if (component2 == null || !component2.Active)
				{
					return false;
				}
			}
			CharacterSkillComponent component3 = entityNoBlueprint.GetComponent<CharacterSkillComponent>();
			if (component3 != null && component3.Valid)
			{
				component3.SetSkillRotateToTarget(this.是否自动朝向目标, false, 0f, 0f, 0f);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0007B47C File Offset: 0x0007967C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRoleRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateRoleRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001603 RID: 5635 RVA: 0x0007B53C File Offset: 0x0007973C
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			UBaseAbilitySystemComponent abilitySystemComponent = tsBaseCharacter.AbilitySystemComponent;
			bool flag;
			if (abilitySystemComponent == null)
			{
				flag = true;
			}
			else
			{
				FGameplayTagContainer tagContainer = this.TagContainer;
				flag = !abilitySystemComponent.HasAnyGameplayTag(tagContainer);
			}
			if (flag)
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
				if (entity == null || !entity.Valid)
				{
					return false;
				}
				if (this.在横板模式中禁用)
				{
					CharacterSplineMoveComponent component = entity.GetComponent<CharacterSplineMoveComponent>();
					if (component != null && component.Active)
					{
						return false;
					}
				}
				else if (this.只在横板模式中生效)
				{
					CharacterSplineMoveComponent component2 = entity.GetComponent<CharacterSplineMoveComponent>();
					if (component2 == null || !component2.Active)
					{
						return false;
					}
				}
				CharacterSkillComponent component3 = entity.GetComponent<CharacterSkillComponent>();
				if (component3 == null || !component3.Valid)
				{
					return false;
				}
				CharacterUnifiedStateComponent component4 = entity.GetComponent<CharacterUnifiedStateComponent>();
				if (component4 != null && component4.PositionState == ECharPositionState.Ride)
				{
					return false;
				}
				if (this.是否自动朝向目标)
				{
					BaseSkillComponent baseSkillComponent = component3;
					EntityHandle skillTargetForAns = component3.GetSkillTargetForAns();
					baseSkillComponent.SetSkillRotateToTarget(skillTargetForAns != null && skillTargetForAns.Valid, false, 0f, 0f, 0f);
					component3.SetSkillRotateSpeed(this.旋转速度);
				}
				else
				{
					CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
					Vector inputDirectProxy = characterActorComponent2.InputDirectProxy;
					if (!inputDirectProxy.IsNearlyZero(9.999999747378752E-05))
					{
						Vector actorForwardProxy = characterActorComponent2.ActorForwardProxy;
						double d = MathUtils.Instance.Clamp(actorForwardProxy.DotProduct(inputDirectProxy), -1.0, 1.0);
						GravityUtils.Instance.RotatorInterpConstantToForActor(characterActorComponent2, characterActorComponent2.ActorRotationProxy, characterActorComponent2.InputRotatorProxy, frameDeltaTime, (float)Math.Acos(d) * 57.29578f / 180f * this.旋转速度, this.TmpRotator);
						return characterActorComponent2.SetActorRotationWithPriority(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStateRoleRotate", ESetRotationPriority.Movement, true, false);
					}
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x0007B708 File Offset: 0x00079908
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRoleRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRoleRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001605 RID: 5637 RVA: 0x0007B7C0 File Offset: 0x000799C0
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			CharacterSkillComponent characterSkillComponent;
			if (characterActorComponent == null)
			{
				characterSkillComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			CharacterSkillComponent characterSkillComponent2 = characterSkillComponent;
			if (characterSkillComponent2 != null && characterSkillComponent2.Valid)
			{
				characterSkillComponent2.SetSkillCanRotate(false);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x0007B810 File Offset: 0x00079A10
	private void Init()
	{
		this.TmpRotator = Rotator.Create();
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x0007B81D File Offset: 0x00079A1D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRoleRotate._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRoleRotate.TsAnimNotifyStateRoleRotate_C");
		}
		return TsAnimNotifyStateRoleRotate._ClassPtr;
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x0007B844 File Offset: 0x00079A44
	public TsAnimNotifyStateRoleRotate() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRoleRotate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x0007B86C File Offset: 0x00079A6C
	[NullableContext(1)]
	public TsAnimNotifyStateRoleRotate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRoleRotate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x0007B89F File Offset: 0x00079A9F
	protected TsAnimNotifyStateRoleRotate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0007B8A8 File Offset: 0x00079AA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x0007B8E4 File Offset: 0x00079AE4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0007B920 File Offset: 0x00079B20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000F53 RID: 3923
	private Rotator TmpRotator;

	// Token: 0x04000F54 RID: 3924
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRoleRotate.TsAnimNotifyStateRoleRotate_C";

	// Token: 0x04000F55 RID: 3925
	private static IntPtr _ClassPtr;

	// Token: 0x04000F56 RID: 3926
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F57 RID: 3927
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000F58 RID: 3928
	private static int __PropertyOffset_是否自动朝向目标;

	// Token: 0x04000F59 RID: 3929
	private static int __PropertyOffset_TagContainer;

	// Token: 0x04000F5A RID: 3930
	private FGameplayTagContainer _TagContainer;

	// Token: 0x04000F5B RID: 3931
	private static int __PropertyOffset_在横板模式中禁用;

	// Token: 0x04000F5C RID: 3932
	private static int __PropertyOffset_只在横板模式中生效;
}

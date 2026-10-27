using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000157 RID: 343
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRoleRotate.TsAnimNotifyStateRoleRotate_C")]
public class TsAnimNotifyStateRoleRotate : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06001559 RID: 5465 RVA: 0x00075BF7 File Offset: 0x00073DF7
	// (set) Token: 0x0600155A RID: 5466 RVA: 0x00075C07 File Offset: 0x00073E07
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

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x0600155B RID: 5467 RVA: 0x00075C18 File Offset: 0x00073E18
	// (set) Token: 0x0600155C RID: 5468 RVA: 0x00075C28 File Offset: 0x00073E28
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

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x0600155D RID: 5469 RVA: 0x00075C3C File Offset: 0x00073E3C
	// (set) Token: 0x0600155E RID: 5470 RVA: 0x00075C75 File Offset: 0x00073E75
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

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x0600155F RID: 5471 RVA: 0x00075C9D File Offset: 0x00073E9D
	// (set) Token: 0x06001560 RID: 5472 RVA: 0x00075CAD File Offset: 0x00073EAD
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

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06001561 RID: 5473 RVA: 0x00075CBE File Offset: 0x00073EBE
	// (set) Token: 0x06001562 RID: 5474 RVA: 0x00075CCE File Offset: 0x00073ECE
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

	// Token: 0x06001563 RID: 5475 RVA: 0x00075CE0 File Offset: 0x00073EE0
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

	// Token: 0x06001564 RID: 5476 RVA: 0x00075D88 File Offset: 0x00073F88
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

	// Token: 0x06001565 RID: 5477 RVA: 0x00075E38 File Offset: 0x00074038
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

	// Token: 0x06001566 RID: 5478 RVA: 0x00075EE0 File Offset: 0x000740E0
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

	// Token: 0x06001567 RID: 5479 RVA: 0x000760AC File Offset: 0x000742AC
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

	// Token: 0x06001568 RID: 5480 RVA: 0x0007614C File Offset: 0x0007434C
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

	// Token: 0x06001569 RID: 5481 RVA: 0x0007619C File Offset: 0x0007439C
	private void Init()
	{
		this.TmpRotator = Rotator.Create();
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x000761A9 File Offset: 0x000743A9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRoleRotate._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRoleRotate.TsAnimNotifyStateRoleRotate_C");
		}
		return TsAnimNotifyStateRoleRotate._ClassPtr;
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x000761D0 File Offset: 0x000743D0
	public TsAnimNotifyStateRoleRotate() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRoleRotate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x000761F8 File Offset: 0x000743F8
	[NullableContext(1)]
	public TsAnimNotifyStateRoleRotate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRoleRotate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x0007622B File Offset: 0x0007442B
	protected TsAnimNotifyStateRoleRotate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x00076234 File Offset: 0x00074434
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x00076270 File Offset: 0x00074470
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x000762AC File Offset: 0x000744AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000F10 RID: 3856
	private Rotator TmpRotator;

	// Token: 0x04000F11 RID: 3857
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRoleRotate.TsAnimNotifyStateRoleRotate_C";

	// Token: 0x04000F12 RID: 3858
	private static IntPtr _ClassPtr;

	// Token: 0x04000F13 RID: 3859
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F14 RID: 3860
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000F15 RID: 3861
	private static int __PropertyOffset_是否自动朝向目标;

	// Token: 0x04000F16 RID: 3862
	private static int __PropertyOffset_TagContainer;

	// Token: 0x04000F17 RID: 3863
	private FGameplayTagContainer _TagContainer;

	// Token: 0x04000F18 RID: 3864
	private static int __PropertyOffset_在横板模式中禁用;

	// Token: 0x04000F19 RID: 3865
	private static int __PropertyOffset_只在横板模式中生效;
}

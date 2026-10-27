using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015A RID: 346
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotate.TsAnimNotifyStateRotate_C")]
public class TsAnimNotifyStateRotate : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06001575 RID: 5493 RVA: 0x0007636C File Offset: 0x0007456C
	// (set) Token: 0x06001576 RID: 5494 RVA: 0x0007637C File Offset: 0x0007457C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 旋转速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_旋转速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_旋转速度) = value;
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06001577 RID: 5495 RVA: 0x0007638D File Offset: 0x0007458D
	// (set) Token: 0x06001578 RID: 5496 RVA: 0x0007639D File Offset: 0x0007459D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否自动朝向目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_是否自动朝向目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_是否自动朝向目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06001579 RID: 5497 RVA: 0x000763AE File Offset: 0x000745AE
	// (set) Token: 0x0600157A RID: 5498 RVA: 0x000763BE File Offset: 0x000745BE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否平滑旋转
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_是否平滑旋转) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_是否平滑旋转) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x0600157B RID: 5499 RVA: 0x000763CF File Offset: 0x000745CF
	// (set) Token: 0x0600157C RID: 5500 RVA: 0x000763E3 File Offset: 0x000745E3
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat Curve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRotate.__PropertyOffset_Curve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRotate.__PropertyOffset_Curve, value);
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x0600157D RID: 5501 RVA: 0x000763F8 File Offset: 0x000745F8
	// (set) Token: 0x0600157E RID: 5502 RVA: 0x00076408 File Offset: 0x00074608
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否应用旋转偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_是否应用旋转偏移) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_是否应用旋转偏移) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000382 RID: 898
	// (get) Token: 0x0600157F RID: 5503 RVA: 0x00076419 File Offset: 0x00074619
	// (set) Token: 0x06001580 RID: 5504 RVA: 0x00076429 File Offset: 0x00074629
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 旋转偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_旋转偏移);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_旋转偏移) = value;
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06001581 RID: 5505 RVA: 0x0007643A File Offset: 0x0007463A
	// (set) Token: 0x06001582 RID: 5506 RVA: 0x0007644A File Offset: 0x0007464A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 设置为朝向黑板目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_设置为朝向黑板目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_设置为朝向黑板目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06001583 RID: 5507 RVA: 0x0007645B File Offset: 0x0007465B
	// (set) Token: 0x06001584 RID: 5508 RVA: 0x0007646B File Offset: 0x0007466B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnsRotateBlackboardType 黑板类型
	{
		get
		{
			return (EAnsRotateBlackboardType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_黑板类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_黑板类型) = (byte)value;
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06001585 RID: 5509 RVA: 0x0007647C File Offset: 0x0007467C
	// (set) Token: 0x06001586 RID: 5510 RVA: 0x00076490 File Offset: 0x00074690
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 朝向黑板目标名
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_朝向黑板目标名)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_朝向黑板目标名)), value);
		}
	}

	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06001587 RID: 5511 RVA: 0x000764A5 File Offset: 0x000746A5
	// (set) Token: 0x06001588 RID: 5512 RVA: 0x000764B5 File Offset: 0x000746B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 停止旋转阈值
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_停止旋转阈值);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_停止旋转阈值) = value;
		}
	}

	// Token: 0x17000387 RID: 903
	// (get) Token: 0x06001589 RID: 5513 RVA: 0x000764C6 File Offset: 0x000746C6
	// (set) Token: 0x0600158A RID: 5514 RVA: 0x000764D6 File Offset: 0x000746D6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 继续旋转阈值
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_继续旋转阈值);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_继续旋转阈值) = value;
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x0600158B RID: 5515 RVA: 0x000764E7 File Offset: 0x000746E7
	// (set) Token: 0x0600158C RID: 5516 RVA: 0x000764F7 File Offset: 0x000746F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 在横板模式中禁用
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_在横板模式中禁用) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_在横板模式中禁用) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000389 RID: 905
	// (get) Token: 0x0600158D RID: 5517 RVA: 0x00076508 File Offset: 0x00074708
	// (set) Token: 0x0600158E RID: 5518 RVA: 0x00076518 File Offset: 0x00074718
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 只在横板模式中生效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_只在横板模式中生效) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_只在横板模式中生效) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700038A RID: 906
	// (get) Token: 0x0600158F RID: 5519 RVA: 0x00076529 File Offset: 0x00074729
	// (set) Token: 0x06001590 RID: 5520 RVA: 0x00076539 File Offset: 0x00074739
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 定向旋转功能
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转功能) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转功能) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700038B RID: 907
	// (get) Token: 0x06001591 RID: 5521 RVA: 0x0007654A File Offset: 0x0007474A
	// (set) Token: 0x06001592 RID: 5522 RVA: 0x0007655A File Offset: 0x0007475A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 定向旋转阈值最小值
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转阈值最小值);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转阈值最小值) = value;
		}
	}

	// Token: 0x1700038C RID: 908
	// (get) Token: 0x06001593 RID: 5523 RVA: 0x0007656B File Offset: 0x0007476B
	// (set) Token: 0x06001594 RID: 5524 RVA: 0x0007657B File Offset: 0x0007477B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 定向旋转阈值最大值
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转阈值最大值);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转阈值最大值) = value;
		}
	}

	// Token: 0x1700038D RID: 909
	// (get) Token: 0x06001595 RID: 5525 RVA: 0x0007658C File Offset: 0x0007478C
	// (set) Token: 0x06001596 RID: 5526 RVA: 0x0007659C File Offset: 0x0007479C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnsRotateDetectionType 定向旋转方式
	{
		get
		{
			return (EAnsRotateDetectionType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转方式));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_定向旋转方式) = (byte)value;
		}
	}

	// Token: 0x1700038E RID: 910
	// (get) Token: 0x06001597 RID: 5527 RVA: 0x000765AD File Offset: 0x000747AD
	// (set) Token: 0x06001598 RID: 5528 RVA: 0x000765BD File Offset: 0x000747BD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 调试定向旋转范围
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_调试定向旋转范围) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_调试定向旋转范围) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x06001599 RID: 5529 RVA: 0x000765D0 File Offset: 0x000747D0
	// (set) Token: 0x0600159A RID: 5530 RVA: 0x00076609 File Offset: 0x00074809
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer 屏蔽标签列表
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._屏蔽标签列表) == null)
			{
				result = (this._屏蔽标签列表 = new FGameplayTagContainer(base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_屏蔽标签列表, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateRotate.__PropertyOffset_屏蔽标签列表, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x00076634 File Offset: 0x00074834
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

	// Token: 0x0600159C RID: 5532 RVA: 0x000766DC File Offset: 0x000748DC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Initialize();
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
				FGameplayTagContainer 屏蔽标签列表 = this.屏蔽标签列表;
				flag = !abilitySystemComponent.HasAnyGameplayTag(屏蔽标签列表);
			}
			if (flag)
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
				if (entity == null || !entity.Valid)
				{
					return false;
				}
				if (!this.ParamsMap.ContainsKey(entity.Id))
				{
					this.ParamsMap.Add(entity.Id, new AnsRotateParam(totalDuration));
				}
				else
				{
					this.ParamsMap[entity.Id].Update(0f, totalDuration);
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
				AnsRotateParam ansRotateParam = this.ParamsMap[entity.Id];
				if (this.定向旋转功能)
				{
					this.UpdateAnsBlackBoardTargetType(ansRotateParam);
					this.UpdateContinueDetection(ansRotateParam, component3, tsBaseCharacter.CharacterActorComponent);
				}
				else
				{
					this.UpdateBlackBoardTargetType(component3);
				}
				component3.SetSkillCanRotate(true);
				component3.SetSkillRotateToTarget(this.是否自动朝向目标 || this.设置为朝向黑板目标, this.是否应用旋转偏移, this.旋转偏移, this.停止旋转阈值, this.继续旋转阈值);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x00076860 File Offset: 0x00074A60
	[NullableContext(2)]
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

	// Token: 0x0600159E RID: 5534 RVA: 0x00076908 File Offset: 0x00074B08
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		AnsRotateParam valueOrDefault = this.ParamsMap.GetValueOrDefault(entity.Id);
		if (valueOrDefault == null)
		{
			return false;
		}
		float nowTime = valueOrDefault.NowTime;
		valueOrDefault.NowTime += frameDeltaTime;
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
		if (this.定向旋转功能)
		{
			this.UpdateContinueDetection(valueOrDefault, component3, tsBaseCharacter.CharacterActorComponent);
		}
		float num = this.旋转速度;
		if (this.是否平滑旋转)
		{
			float num2 = nowTime * valueOrDefault.TotalDurationReciprocal;
			float num3 = valueOrDefault.NowTime * valueOrDefault.TotalDurationReciprocal;
			if (this.Curve != null)
			{
				num2 = this.Curve.GetFloatValue(MathUtils.Instance.Clamp(num2, 0f, 1f));
				num3 = this.Curve.GetFloatValue(MathUtils.Instance.Clamp(num3, 0f, 1f));
			}
			float num4 = Math.Abs(this.GetSkillRotateAngle(tsBaseCharacter.CharacterActorComponent, component3));
			float num5 = MathUtils.Instance.Clamp((num3 - num2) / (1f - num2), 0f, 1f);
			float currentValue = num4 * num5 / frameDeltaTime;
			num = MathUtils.Instance.Clamp(currentValue, 0f, num);
		}
		component3.SetSkillRotateSpeed(num);
		return true;
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x00076AC8 File Offset: 0x00074CC8
	private float GetSkillRotateAngle(CharacterActorComponent actorComp, CharacterSkillComponent skillComp)
	{
		Vector actorForwardProxy = actorComp.ActorForwardProxy;
		Vector skillRotateDirect = skillComp.GetSkillRotateDirect();
		if (actorForwardProxy.IsNearlyZero(9.999999747378752E-05) || skillRotateDirect.IsNearlyZero(9.999999747378752E-05))
		{
			return 180f;
		}
		return GravityUtils.Instance.GetAngleOffsetInGravityAbsForActor(actorComp, actorForwardProxy, skillRotateDirect);
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x00076B18 File Offset: 0x00074D18
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

	// Token: 0x060015A1 RID: 5537 RVA: 0x00076BB8 File Offset: 0x00074DB8
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Dictionary<int, AnsRotateParam> paramsMap = this.ParamsMap;
			if (paramsMap != null)
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				paramsMap.Remove((characterActorComponent != null) ? characterActorComponent.Entity.Id : 0);
			}
			CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
			CharacterSkillComponent characterSkillComponent;
			if (characterActorComponent2 == null)
			{
				characterSkillComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent2.Entity;
				characterSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			CharacterSkillComponent characterSkillComponent2 = characterSkillComponent;
			if (characterSkillComponent2 != null && characterSkillComponent2.Valid)
			{
				characterSkillComponent2.SetSkillCanRotate(false);
				characterSkillComponent2.SetRotateTarget(null, ESkillRotateType.None);
			}
		}
		return false;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x00076C37 File Offset: 0x00074E37
	private void Initialize()
	{
		if (this.IsInitialize)
		{
			return;
		}
		this.IsInitialize = true;
		this.ParamsMap = new Dictionary<int, AnsRotateParam>();
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x00076C54 File Offset: 0x00074E54
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

	// Token: 0x060015A4 RID: 5540 RVA: 0x00076CCF File Offset: 0x00074ECF
	protected override string GetNotifyName_Implementation()
	{
		return "旋转到黑板目标或技能目标或输入方向";
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x00076CD8 File Offset: 0x00074ED8
	private void UpdateBlackBoardTargetType(BaseSkillComponent skillComp)
	{
		if (this.设置为朝向黑板目标)
		{
			switch (this.黑板类型)
			{
			case EAnsRotateBlackboardType.EntityId:
				skillComp.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardEntityId);
				return;
			case EAnsRotateBlackboardType.Location:
				skillComp.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardLocation);
				return;
			case EAnsRotateBlackboardType.Direct:
				skillComp.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardDirect);
				return;
			case EAnsRotateBlackboardType.Int:
				skillComp.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardInt);
				return;
			default:
				skillComp.SetRotateTarget(null, ESkillRotateType.None);
				break;
			}
		}
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00076D4C File Offset: 0x00074F4C
	private void UpdateAnsBlackBoardTargetType(AnsRotateParam ansRotateParam)
	{
		if (this.设置为朝向黑板目标)
		{
			switch (this.黑板类型)
			{
			case EAnsRotateBlackboardType.EntityId:
				ansRotateParam.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardEntityId);
				return;
			case EAnsRotateBlackboardType.Location:
				ansRotateParam.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardLocation);
				return;
			case EAnsRotateBlackboardType.Direct:
				ansRotateParam.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardDirect);
				return;
			case EAnsRotateBlackboardType.Int:
				ansRotateParam.SetRotateTarget(this.朝向黑板目标名, ESkillRotateType.BlackBoardInt);
				return;
			default:
				ansRotateParam.SetRotateTarget(null, ESkillRotateType.None);
				break;
			}
		}
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x00076DC0 File Offset: 0x00074FC0
	private bool IsInContinueDetectionAngle(float angle)
	{
		float num = (this.定向旋转阈值最大值 - this.定向旋转阈值最小值) % 360f;
		if (!MathUtils.Instance.IsNearlyEqual((double)this.定向旋转阈值最大值, (double)this.定向旋转阈值最小值, null) && (MathUtils.Instance.IsNearlyZero((double)num, null) || MathUtils.Instance.IsNearlyEqual((double)num, 360.0, null)))
		{
			return true;
		}
		float num2 = 180f + this.定向旋转阈值最小值;
		float num3 = MathUtils.Instance.WrapAngle(angle - num2);
		float num4 = MathUtils.Instance.WrapAngle(this.定向旋转阈值最大值 - num2);
		return -180f <= num3 && num3 <= num4;
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00076E80 File Offset: 0x00075080
	private void UpdateContinueDetection(AnsRotateParam ansRotateParam, BaseSkillComponent skillComp, CharacterActorComponent actorComp)
	{
		Vector tmpVector = this.TmpVector;
		SkillUtils.GetSkillRotateDirect(CharacterModel.Instance.GetHandleByEntity(actorComp.Entity), ansRotateParam.SkillRotateTarget, null, tmpVector);
		if (tmpVector.IsNearlyZero(9.999999747378752E-05))
		{
			ansRotateParam.RotateDetectionType = EAnsRotateDetectionTypeLocal.None;
			return;
		}
		float angleOffsetInGravityForActor = GravityUtils.Instance.GetAngleOffsetInGravityForActor(actorComp, actorComp.ActorForwardProxy, tmpVector);
		switch (this.定向旋转方式)
		{
		case EAnsRotateDetectionType.持续旋转:
			if (ansRotateParam.RotateDetectionType != EAnsRotateDetectionTypeLocal.持续旋转)
			{
				if (!this.IsInContinueDetectionAngle(angleOffsetInGravityForActor))
				{
					skillComp.SetRotateTarget(null, ESkillRotateType.StandBy);
					return;
				}
				ansRotateParam.RotateDetectionType = EAnsRotateDetectionTypeLocal.持续旋转;
				this.UpdateBlackBoardTargetType(skillComp);
				return;
			}
			break;
		case EAnsRotateDetectionType.单次旋转:
			if (ansRotateParam.RotateDetectionType != EAnsRotateDetectionTypeLocal.单次旋转)
			{
				ansRotateParam.RotateDetectionType = EAnsRotateDetectionTypeLocal.单次旋转;
				if (!this.IsInContinueDetectionAngle(angleOffsetInGravityForActor))
				{
					skillComp.SetRotateTarget(null, ESkillRotateType.StandBy);
					return;
				}
				skillComp.SetRotateTarget(Vector.Create(tmpVector), ESkillRotateType.Direct);
				return;
			}
			break;
		case EAnsRotateDetectionType.动态单次旋转:
			if (ansRotateParam.RotateDetectionType != EAnsRotateDetectionTypeLocal.动态单次旋转)
			{
				if (!this.IsInContinueDetectionAngle(angleOffsetInGravityForActor))
				{
					skillComp.SetRotateTarget(null, ESkillRotateType.StandBy);
					return;
				}
				ansRotateParam.RotateDetectionType = EAnsRotateDetectionTypeLocal.动态单次旋转;
				skillComp.SetRotateTarget(Vector.Create(tmpVector), ESkillRotateType.Direct);
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x00076F83 File Offset: 0x00075183
	[Conditional("DEBUG")]
	private void DebugDraw(AnsRotateParam ansRotateParam, CharacterActorComponent actorComp)
	{
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00076F85 File Offset: 0x00075185
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotate._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotate.TsAnimNotifyStateRotate_C");
		}
		return TsAnimNotifyStateRotate._ClassPtr;
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00076FAC File Offset: 0x000751AC
	public TsAnimNotifyStateRotate() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00076FD4 File Offset: 0x000751D4
	public TsAnimNotifyStateRotate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00077008 File Offset: 0x00075208
	protected TsAnimNotifyStateRotate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00077064 File Offset: 0x00075264
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x000770A0 File Offset: 0x000752A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x000770DC File Offset: 0x000752DC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x0007710F File Offset: 0x0007530F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F23 RID: 3875
	private const int DEBUG_DRAW_LENGTH = 500;

	// Token: 0x04000F24 RID: 3876
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, AnsRotateParam> ParamsMap;

	// Token: 0x04000F25 RID: 3877
	private bool IsInitialize;

	// Token: 0x04000F26 RID: 3878
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04000F27 RID: 3879
	private readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000F28 RID: 3880
	public readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F29 RID: 3881
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotate.TsAnimNotifyStateRotate_C";

	// Token: 0x04000F2A RID: 3882
	private static IntPtr _ClassPtr;

	// Token: 0x04000F2B RID: 3883
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F2C RID: 3884
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000F2D RID: 3885
	private static int __PropertyOffset_是否自动朝向目标;

	// Token: 0x04000F2E RID: 3886
	private static int __PropertyOffset_是否平滑旋转;

	// Token: 0x04000F2F RID: 3887
	private static int __PropertyOffset_Curve;

	// Token: 0x04000F30 RID: 3888
	private static int __PropertyOffset_是否应用旋转偏移;

	// Token: 0x04000F31 RID: 3889
	private static int __PropertyOffset_旋转偏移;

	// Token: 0x04000F32 RID: 3890
	private static int __PropertyOffset_设置为朝向黑板目标;

	// Token: 0x04000F33 RID: 3891
	private static int __PropertyOffset_黑板类型;

	// Token: 0x04000F34 RID: 3892
	private static int __PropertyOffset_朝向黑板目标名;

	// Token: 0x04000F35 RID: 3893
	private static int __PropertyOffset_停止旋转阈值;

	// Token: 0x04000F36 RID: 3894
	private static int __PropertyOffset_继续旋转阈值;

	// Token: 0x04000F37 RID: 3895
	private static int __PropertyOffset_在横板模式中禁用;

	// Token: 0x04000F38 RID: 3896
	private static int __PropertyOffset_只在横板模式中生效;

	// Token: 0x04000F39 RID: 3897
	private static int __PropertyOffset_定向旋转功能;

	// Token: 0x04000F3A RID: 3898
	private static int __PropertyOffset_定向旋转阈值最小值;

	// Token: 0x04000F3B RID: 3899
	private static int __PropertyOffset_定向旋转阈值最大值;

	// Token: 0x04000F3C RID: 3900
	private static int __PropertyOffset_定向旋转方式;

	// Token: 0x04000F3D RID: 3901
	private static int __PropertyOffset_调试定向旋转范围;

	// Token: 0x04000F3E RID: 3902
	private static int __PropertyOffset_屏蔽标签列表;

	// Token: 0x04000F3F RID: 3903
	[Nullable(2)]
	private FGameplayTagContainer _屏蔽标签列表;
}

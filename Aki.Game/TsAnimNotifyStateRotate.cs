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

// Token: 0x0200015E RID: 350
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotate.TsAnimNotifyStateRotate_C")]
public class TsAnimNotifyStateRotate : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700039F RID: 927
	// (get) Token: 0x06001612 RID: 5650 RVA: 0x0007B9E0 File Offset: 0x00079BE0
	// (set) Token: 0x06001613 RID: 5651 RVA: 0x0007B9F0 File Offset: 0x00079BF0
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

	// Token: 0x170003A0 RID: 928
	// (get) Token: 0x06001614 RID: 5652 RVA: 0x0007BA01 File Offset: 0x00079C01
	// (set) Token: 0x06001615 RID: 5653 RVA: 0x0007BA11 File Offset: 0x00079C11
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

	// Token: 0x170003A1 RID: 929
	// (get) Token: 0x06001616 RID: 5654 RVA: 0x0007BA22 File Offset: 0x00079C22
	// (set) Token: 0x06001617 RID: 5655 RVA: 0x0007BA32 File Offset: 0x00079C32
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

	// Token: 0x170003A2 RID: 930
	// (get) Token: 0x06001618 RID: 5656 RVA: 0x0007BA43 File Offset: 0x00079C43
	// (set) Token: 0x06001619 RID: 5657 RVA: 0x0007BA57 File Offset: 0x00079C57
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

	// Token: 0x170003A3 RID: 931
	// (get) Token: 0x0600161A RID: 5658 RVA: 0x0007BA6C File Offset: 0x00079C6C
	// (set) Token: 0x0600161B RID: 5659 RVA: 0x0007BA7C File Offset: 0x00079C7C
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

	// Token: 0x170003A4 RID: 932
	// (get) Token: 0x0600161C RID: 5660 RVA: 0x0007BA8D File Offset: 0x00079C8D
	// (set) Token: 0x0600161D RID: 5661 RVA: 0x0007BA9D File Offset: 0x00079C9D
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

	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x0600161E RID: 5662 RVA: 0x0007BAAE File Offset: 0x00079CAE
	// (set) Token: 0x0600161F RID: 5663 RVA: 0x0007BABE File Offset: 0x00079CBE
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

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06001620 RID: 5664 RVA: 0x0007BACF File Offset: 0x00079CCF
	// (set) Token: 0x06001621 RID: 5665 RVA: 0x0007BADF File Offset: 0x00079CDF
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

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06001622 RID: 5666 RVA: 0x0007BAF0 File Offset: 0x00079CF0
	// (set) Token: 0x06001623 RID: 5667 RVA: 0x0007BB04 File Offset: 0x00079D04
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

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06001624 RID: 5668 RVA: 0x0007BB19 File Offset: 0x00079D19
	// (set) Token: 0x06001625 RID: 5669 RVA: 0x0007BB29 File Offset: 0x00079D29
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

	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x06001626 RID: 5670 RVA: 0x0007BB3A File Offset: 0x00079D3A
	// (set) Token: 0x06001627 RID: 5671 RVA: 0x0007BB4A File Offset: 0x00079D4A
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

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x06001628 RID: 5672 RVA: 0x0007BB5B File Offset: 0x00079D5B
	// (set) Token: 0x06001629 RID: 5673 RVA: 0x0007BB6B File Offset: 0x00079D6B
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

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x0600162A RID: 5674 RVA: 0x0007BB7C File Offset: 0x00079D7C
	// (set) Token: 0x0600162B RID: 5675 RVA: 0x0007BB8C File Offset: 0x00079D8C
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

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x0600162C RID: 5676 RVA: 0x0007BB9D File Offset: 0x00079D9D
	// (set) Token: 0x0600162D RID: 5677 RVA: 0x0007BBAD File Offset: 0x00079DAD
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

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x0600162E RID: 5678 RVA: 0x0007BBBE File Offset: 0x00079DBE
	// (set) Token: 0x0600162F RID: 5679 RVA: 0x0007BBCE File Offset: 0x00079DCE
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

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06001630 RID: 5680 RVA: 0x0007BBDF File Offset: 0x00079DDF
	// (set) Token: 0x06001631 RID: 5681 RVA: 0x0007BBEF File Offset: 0x00079DEF
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

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06001632 RID: 5682 RVA: 0x0007BC00 File Offset: 0x00079E00
	// (set) Token: 0x06001633 RID: 5683 RVA: 0x0007BC10 File Offset: 0x00079E10
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

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x06001634 RID: 5684 RVA: 0x0007BC21 File Offset: 0x00079E21
	// (set) Token: 0x06001635 RID: 5685 RVA: 0x0007BC31 File Offset: 0x00079E31
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

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x06001636 RID: 5686 RVA: 0x0007BC44 File Offset: 0x00079E44
	// (set) Token: 0x06001637 RID: 5687 RVA: 0x0007BC7D File Offset: 0x00079E7D
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

	// Token: 0x06001638 RID: 5688 RVA: 0x0007BCA8 File Offset: 0x00079EA8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001639 RID: 5689 RVA: 0x0007BD68 File Offset: 0x00079F68
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

	// Token: 0x0600163A RID: 5690 RVA: 0x0007BEEC File Offset: 0x0007A0EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600163B RID: 5691 RVA: 0x0007BFAC File Offset: 0x0007A1AC
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

	// Token: 0x0600163C RID: 5692 RVA: 0x0007C16C File Offset: 0x0007A36C
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

	// Token: 0x0600163D RID: 5693 RVA: 0x0007C1BC File Offset: 0x0007A3BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600163E RID: 5694 RVA: 0x0007C274 File Offset: 0x0007A474
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

	// Token: 0x0600163F RID: 5695 RVA: 0x0007C2F3 File Offset: 0x0007A4F3
	private void Initialize()
	{
		if (this.IsInitialize)
		{
			return;
		}
		this.IsInitialize = true;
		this.ParamsMap = new Dictionary<int, AnsRotateParam>();
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0007C310 File Offset: 0x0007A510
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotate) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRotate.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001641 RID: 5697 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
	protected override string GetNotifyName_Implementation()
	{
		return "旋转到黑板目标或技能目标或输入方向";
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0007C3A8 File Offset: 0x0007A5A8
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

	// Token: 0x06001643 RID: 5699 RVA: 0x0007C41C File Offset: 0x0007A61C
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

	// Token: 0x06001644 RID: 5700 RVA: 0x0007C490 File Offset: 0x0007A690
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

	// Token: 0x06001645 RID: 5701 RVA: 0x0007C550 File Offset: 0x0007A750
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

	// Token: 0x06001646 RID: 5702 RVA: 0x0007C653 File Offset: 0x0007A853
	[Conditional("DEBUG")]
	private void DebugDraw(AnsRotateParam ansRotateParam, CharacterActorComponent actorComp)
	{
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x0007C655 File Offset: 0x0007A855
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotate._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotate.TsAnimNotifyStateRotate_C");
		}
		return TsAnimNotifyStateRotate._ClassPtr;
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x0007C67C File Offset: 0x0007A87C
	public TsAnimNotifyStateRotate() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x0007C6A4 File Offset: 0x0007A8A4
	public TsAnimNotifyStateRotate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x0007C6D8 File Offset: 0x0007A8D8
	protected TsAnimNotifyStateRotate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x0007C734 File Offset: 0x0007A934
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x0007C770 File Offset: 0x0007A970
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x0007C7AC File Offset: 0x0007A9AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x0007C7DF File Offset: 0x0007A9DF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F66 RID: 3942
	private const int DEBUG_DRAW_LENGTH = 500;

	// Token: 0x04000F67 RID: 3943
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, AnsRotateParam> ParamsMap;

	// Token: 0x04000F68 RID: 3944
	private bool IsInitialize;

	// Token: 0x04000F69 RID: 3945
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04000F6A RID: 3946
	private readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000F6B RID: 3947
	public readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F6C RID: 3948
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotate.TsAnimNotifyStateRotate_C";

	// Token: 0x04000F6D RID: 3949
	private static IntPtr _ClassPtr;

	// Token: 0x04000F6E RID: 3950
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F6F RID: 3951
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000F70 RID: 3952
	private static int __PropertyOffset_是否自动朝向目标;

	// Token: 0x04000F71 RID: 3953
	private static int __PropertyOffset_是否平滑旋转;

	// Token: 0x04000F72 RID: 3954
	private static int __PropertyOffset_Curve;

	// Token: 0x04000F73 RID: 3955
	private static int __PropertyOffset_是否应用旋转偏移;

	// Token: 0x04000F74 RID: 3956
	private static int __PropertyOffset_旋转偏移;

	// Token: 0x04000F75 RID: 3957
	private static int __PropertyOffset_设置为朝向黑板目标;

	// Token: 0x04000F76 RID: 3958
	private static int __PropertyOffset_黑板类型;

	// Token: 0x04000F77 RID: 3959
	private static int __PropertyOffset_朝向黑板目标名;

	// Token: 0x04000F78 RID: 3960
	private static int __PropertyOffset_停止旋转阈值;

	// Token: 0x04000F79 RID: 3961
	private static int __PropertyOffset_继续旋转阈值;

	// Token: 0x04000F7A RID: 3962
	private static int __PropertyOffset_在横板模式中禁用;

	// Token: 0x04000F7B RID: 3963
	private static int __PropertyOffset_只在横板模式中生效;

	// Token: 0x04000F7C RID: 3964
	private static int __PropertyOffset_定向旋转功能;

	// Token: 0x04000F7D RID: 3965
	private static int __PropertyOffset_定向旋转阈值最小值;

	// Token: 0x04000F7E RID: 3966
	private static int __PropertyOffset_定向旋转阈值最大值;

	// Token: 0x04000F7F RID: 3967
	private static int __PropertyOffset_定向旋转方式;

	// Token: 0x04000F80 RID: 3968
	private static int __PropertyOffset_调试定向旋转范围;

	// Token: 0x04000F81 RID: 3969
	private static int __PropertyOffset_屏蔽标签列表;

	// Token: 0x04000F82 RID: 3970
	[Nullable(2)]
	private FGameplayTagContainer _屏蔽标签列表;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000163 RID: 355
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateToPlayer.TsAnimNotifyStateRotateToPlayer_C")]
public class TsAnimNotifyStateRotateToPlayer : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x0600169D RID: 5789 RVA: 0x0007E005 File Offset: 0x0007C205
	// (set) Token: 0x0600169E RID: 5790 RVA: 0x0007E015 File Offset: 0x0007C215
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 旋转速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateToPlayer.__PropertyOffset_旋转速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateToPlayer.__PropertyOffset_旋转速度) = value;
		}
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x0600169F RID: 5791 RVA: 0x0007E026 File Offset: 0x0007C226
	// (set) Token: 0x060016A0 RID: 5792 RVA: 0x0007E03A File Offset: 0x0007C23A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat Curve
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRotateToPlayer.__PropertyOffset_Curve);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateRotateToPlayer.__PropertyOffset_Curve, value);
		}
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0007E050 File Offset: 0x0007C250
	// (set) Token: 0x060016A2 RID: 5794 RVA: 0x0007E089 File Offset: 0x0007C289
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer 屏蔽标签列表
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._屏蔽标签列表) == null)
			{
				result = (this._屏蔽标签列表 = new FGameplayTagContainer(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateToPlayer.__PropertyOffset_屏蔽标签列表, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateRotateToPlayer.__PropertyOffset_屏蔽标签列表, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0007E0B4 File Offset: 0x0007C2B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateToPlayer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRotateToPlayer.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016A4 RID: 5796 RVA: 0x0007E174 File Offset: 0x0007C374
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Initialize();
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		UBaseAbilitySystemComponent abilitySystemComponent = (owner as TsBaseCharacter).AbilitySystemComponent;
		bool flag;
		if (abilitySystemComponent == null)
		{
			flag = false;
		}
		else
		{
			FGameplayTagContainer 屏蔽标签列表 = this.屏蔽标签列表;
			flag = abilitySystemComponent.HasAnyGameplayTag(屏蔽标签列表);
		}
		if (flag)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		if (!this.ParamsMap.ContainsKey(entity.Id))
		{
			this.ParamsMap[entity.Id] = new RotateToPlayerParam(totalDuration);
		}
		else
		{
			this.ParamsMap[entity.Id].Update(0f, totalDuration);
		}
		return true;
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x0007E230 File Offset: 0x0007C430
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateToPlayer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateRotateToPlayer.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016A6 RID: 5798 RVA: 0x0007E2F0 File Offset: 0x0007C4F0
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		return entity != null && entity.Valid && this.UpdateRotationRole(tsBaseCharacter.CharacterActorComponent, frameDeltaTime);
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x0007E340 File Offset: 0x0007C540
	[NullableContext(1)]
	private bool UpdateRotationRole(CharacterActorComponent actorComp, float frameDeltaTime)
	{
		RotateToPlayerParam rotateToPlayerParam;
		if (!this.ParamsMap.TryGetValue(actorComp.Entity.Id, out rotateToPlayerParam))
		{
			return false;
		}
		float nowTime = rotateToPlayerParam.NowTime;
		rotateToPlayerParam.NowTime += frameDeltaTime;
		float inYaw = this.旋转速度 * frameDeltaTime;
		float num = nowTime * rotateToPlayerParam.TotalDurationReciprocal;
		float num2 = rotateToPlayerParam.NowTime * rotateToPlayerParam.TotalDurationReciprocal;
		if (this.Curve != null)
		{
			num = this.Curve.GetFloatValue(MathUtils.Instance.Clamp(num, 0f, 1f));
			num2 = this.Curve.GetFloatValue(MathUtils.Instance.Clamp(num2, 0f, 1f));
		}
		float rotationRoleAngle = this.GetRotationRoleAngle(actorComp);
		float num3 = MathUtils.Instance.Clamp((num2 - num) / (1f - num), 0f, 1f);
		float value = rotationRoleAngle * num3 / frameDeltaTime;
		inYaw = (float)Math.Sign(value) * MathUtils.Instance.Clamp(Math.Abs(value), 0f, this.旋转速度) * frameDeltaTime;
		MathUtils.Instance.CommonTempQuat.DeepCopy(actorComp.ActorQuatProxy);
		MathUtils.Instance.CommonTempRotator.Set(0f, inYaw, 0f);
		MathUtils.Instance.CommonTempQuat.Multiply(MathUtils.Instance.CommonTempRotator.Quaternion(null), this.TmpQuat);
		this.TmpQuat.Rotator(MathUtils.Instance.CommonTempRotator);
		actorComp.SetActorRotation(MathUtils.Instance.CommonTempRotator.ToUeRotator(), "TsAnimNotifyStateRotate", false);
		actorComp.SetInputRotator(MathUtils.Instance.CommonTempRotator);
		return true;
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
	[NullableContext(1)]
	private float GetRotationRoleAngle(CharacterActorComponent actorComp)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null || !baseCharacter.IsValid())
		{
			return 0f;
		}
		Vector actorForwardProxy = actorComp.ActorForwardProxy;
		Vector tmpVector = this.TmpVector;
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		tmpVector.DeepCopy(characterActorComponent.ActorLocationProxy);
		tmpVector.SubtractionEqual(actorComp.ActorLocationProxy);
		tmpVector.Normalize(9.99999993922529E-09);
		return GravityUtils.Instance.GetAngleOffsetInGravityForActor(actorComp, actorForwardProxy, tmpVector);
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x0007E54C File Offset: 0x0007C74C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateToPlayer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRotateToPlayer.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016AA RID: 5802 RVA: 0x0007E604 File Offset: 0x0007C804
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			Dictionary<int, RotateToPlayerParam> paramsMap = this.ParamsMap;
			if (paramsMap != null)
			{
				CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
				paramsMap.Remove((characterActorComponent != null) ? characterActorComponent.Entity.Id : 0);
			}
		}
		return false;
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x0007E650 File Offset: 0x0007C850
	private void Initialize()
	{
		if (this.IsInitialize)
		{
			return;
		}
		this.IsInitialize = true;
		this.ParamsMap = new Dictionary<int, RotateToPlayerParam>();
		this.TmpVector = Vector.Create();
		this.TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x0007E6B4 File Offset: 0x0007C8B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateToPlayer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRotateToPlayer.StaticClass(), out intPtr, out num))
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

	// Token: 0x060016AD RID: 5805 RVA: 0x0007E744 File Offset: 0x0007C944
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "旋转朝向玩家";
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x0007E74B File Offset: 0x0007C94B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateToPlayer._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateToPlayer.TsAnimNotifyStateRotateToPlayer_C");
		}
		return TsAnimNotifyStateRotateToPlayer._ClassPtr;
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x0007E770 File Offset: 0x0007C970
	public TsAnimNotifyStateRotateToPlayer() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateToPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x0007E798 File Offset: 0x0007C998
	[NullableContext(1)]
	public TsAnimNotifyStateRotateToPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateToPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x0007E7CB File Offset: 0x0007C9CB
	protected TsAnimNotifyStateRotateToPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0007E7D4 File Offset: 0x0007C9D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x0007E810 File Offset: 0x0007CA10
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x0007E84C File Offset: 0x0007CA4C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x0007E87F File Offset: 0x0007CA7F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FAB RID: 4011
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, RotateToPlayerParam> ParamsMap;

	// Token: 0x04000FAC RID: 4012
	private bool IsInitialize;

	// Token: 0x04000FAD RID: 4013
	private Vector TmpVector;

	// Token: 0x04000FAE RID: 4014
	private Quat TmpQuat;

	// Token: 0x04000FAF RID: 4015
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateToPlayer.TsAnimNotifyStateRotateToPlayer_C";

	// Token: 0x04000FB0 RID: 4016
	private static IntPtr _ClassPtr;

	// Token: 0x04000FB1 RID: 4017
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FB2 RID: 4018
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000FB3 RID: 4019
	private static int __PropertyOffset_Curve;

	// Token: 0x04000FB4 RID: 4020
	private static int __PropertyOffset_屏蔽标签列表;

	// Token: 0x04000FB5 RID: 4021
	private FGameplayTagContainer _屏蔽标签列表;
}

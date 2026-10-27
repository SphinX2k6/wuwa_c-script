using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015F RID: 351
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateToPlayer.TsAnimNotifyStateRotateToPlayer_C")]
public class TsAnimNotifyStateRotateToPlayer : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700039E RID: 926
	// (get) Token: 0x06001600 RID: 5632 RVA: 0x00078825 File Offset: 0x00076A25
	// (set) Token: 0x06001601 RID: 5633 RVA: 0x00078835 File Offset: 0x00076A35
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

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x06001602 RID: 5634 RVA: 0x00078846 File Offset: 0x00076A46
	// (set) Token: 0x06001603 RID: 5635 RVA: 0x0007885A File Offset: 0x00076A5A
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

	// Token: 0x170003A0 RID: 928
	// (get) Token: 0x06001604 RID: 5636 RVA: 0x00078870 File Offset: 0x00076A70
	// (set) Token: 0x06001605 RID: 5637 RVA: 0x000788A9 File Offset: 0x00076AA9
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

	// Token: 0x06001606 RID: 5638 RVA: 0x000788D4 File Offset: 0x00076AD4
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

	// Token: 0x06001607 RID: 5639 RVA: 0x0007897C File Offset: 0x00076B7C
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

	// Token: 0x06001608 RID: 5640 RVA: 0x00078A38 File Offset: 0x00076C38
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

	// Token: 0x06001609 RID: 5641 RVA: 0x00078AE0 File Offset: 0x00076CE0
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

	// Token: 0x0600160A RID: 5642 RVA: 0x00078B30 File Offset: 0x00076D30
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

	// Token: 0x0600160B RID: 5643 RVA: 0x00078CC4 File Offset: 0x00076EC4
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

	// Token: 0x0600160C RID: 5644 RVA: 0x00078D3C File Offset: 0x00076F3C
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

	// Token: 0x0600160D RID: 5645 RVA: 0x00078DDC File Offset: 0x00076FDC
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

	// Token: 0x0600160E RID: 5646 RVA: 0x00078E28 File Offset: 0x00077028
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

	// Token: 0x0600160F RID: 5647 RVA: 0x00078E8C File Offset: 0x0007708C
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

	// Token: 0x06001610 RID: 5648 RVA: 0x00078F07 File Offset: 0x00077107
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "旋转朝向玩家";
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00078F0E File Offset: 0x0007710E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateToPlayer._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateToPlayer.TsAnimNotifyStateRotateToPlayer_C");
		}
		return TsAnimNotifyStateRotateToPlayer._ClassPtr;
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00078F34 File Offset: 0x00077134
	public TsAnimNotifyStateRotateToPlayer() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateToPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00078F5C File Offset: 0x0007715C
	[NullableContext(1)]
	public TsAnimNotifyStateRotateToPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateToPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00078F8F File Offset: 0x0007718F
	protected TsAnimNotifyStateRotateToPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00078F98 File Offset: 0x00077198
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00078FD4 File Offset: 0x000771D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00079010 File Offset: 0x00077210
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x00079043 File Offset: 0x00077243
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F68 RID: 3944
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, RotateToPlayerParam> ParamsMap;

	// Token: 0x04000F69 RID: 3945
	private bool IsInitialize;

	// Token: 0x04000F6A RID: 3946
	private Vector TmpVector;

	// Token: 0x04000F6B RID: 3947
	private Quat TmpQuat;

	// Token: 0x04000F6C RID: 3948
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateToPlayer.TsAnimNotifyStateRotateToPlayer_C";

	// Token: 0x04000F6D RID: 3949
	private static IntPtr _ClassPtr;

	// Token: 0x04000F6E RID: 3950
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F6F RID: 3951
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000F70 RID: 3952
	private static int __PropertyOffset_Curve;

	// Token: 0x04000F71 RID: 3953
	private static int __PropertyOffset_屏蔽标签列表;

	// Token: 0x04000F72 RID: 3954
	private FGameplayTagContainer _屏蔽标签列表;
}

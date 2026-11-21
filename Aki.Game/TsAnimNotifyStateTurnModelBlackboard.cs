using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000186 RID: 390
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnModelBlackboard.TsAnimNotifyStateTurnModelBlackboard_C")]
public class TsAnimNotifyStateTurnModelBlackboard : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x060018FE RID: 6398 RVA: 0x00087FA1 File Offset: 0x000861A1
	// (set) Token: 0x060018FF RID: 6399 RVA: 0x00087FB5 File Offset: 0x000861B5
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TurnModelKey
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_TurnModelKey)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_TurnModelKey)), value);
		}
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06001900 RID: 6400 RVA: 0x00087FCA File Offset: 0x000861CA
	// (set) Token: 0x06001901 RID: 6401 RVA: 0x00087FDE File Offset: 0x000861DE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat Curve
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_Curve);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_Curve, value);
		}
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06001902 RID: 6402 RVA: 0x00087FF3 File Offset: 0x000861F3
	// (set) Token: 0x06001903 RID: 6403 RVA: 0x00088003 File Offset: 0x00086203
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool TurnActorOnEnd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_TurnActorOnEnd) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_TurnActorOnEnd) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06001904 RID: 6404 RVA: 0x00088014 File Offset: 0x00086214
	// (set) Token: 0x06001905 RID: 6405 RVA: 0x00088024 File Offset: 0x00086224
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Absolute
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_Absolute) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateTurnModelBlackboard.__PropertyOffset_Absolute) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x00088035 File Offset: 0x00086235
	private void Init()
	{
		if (this.ParamsMap != null)
		{
			return;
		}
		this.ParamsMap = new Dictionary<AActor, TurnModelBlackboardParams>();
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x0008804C File Offset: 0x0008624C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnModelBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateTurnModelBlackboard.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001908 RID: 6408 RVA: 0x0008810C File Offset: 0x0008630C
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Init();
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		int id = entity.Id;
		if (string.IsNullOrEmpty(this.TurnModelKey))
		{
			return false;
		}
		Aki.Protocol.Rotator rotatorValueByEntity = BlackboardController.Instance.GetRotatorValueByEntity(id, this.TurnModelKey);
		if (rotatorValueByEntity == null)
		{
			return false;
		}
		if (this.Absolute)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			global::Rotator rotator = (characterActorComponent != null) ? characterActorComponent.ActorRotationProxy : null;
			if (rotator != null)
			{
				rotatorValueByEntity.Pitch -= rotator.Pitch;
				rotatorValueByEntity.Yaw -= rotator.Yaw;
				rotatorValueByEntity.Roll -= rotator.Roll;
			}
		}
		TurnModelBlackboardParams turnModelBlackboardParams = new TurnModelBlackboardParams();
		turnModelBlackboardParams.TotalDuration = totalDuration;
		turnModelBlackboardParams.TurnModel.FromUeRotator(rotatorValueByEntity);
		turnModelBlackboardParams.TurnModel.Quaternion(turnModelBlackboardParams.TurnModelQuat);
		turnModelBlackboardParams.RunTime = 0f;
		this.ParamsMap[owner] = turnModelBlackboardParams;
		return true;
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x00088234 File Offset: 0x00086434
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnModelBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateTurnModelBlackboard.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, deltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = deltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x000882F4 File Offset: 0x000864F4
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterAnimationComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		TurnModelBlackboardParams turnModelBlackboardParams;
		if (!this.ParamsMap.TryGetValue(tsBaseCharacter, out turnModelBlackboardParams))
		{
			return false;
		}
		float totalDuration = turnModelBlackboardParams.TotalDuration;
		Quat turnModelQuat = turnModelBlackboardParams.TurnModelQuat;
		float runTime = turnModelBlackboardParams.RunTime;
		float num = runTime + deltaTime;
		float slerp;
		if (this.Curve != null)
		{
			slerp = this.Curve.GetFloatValue(num / totalDuration) - this.Curve.GetFloatValue(runTime / totalDuration);
		}
		else
		{
			slerp = deltaTime / totalDuration;
		}
		Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		Quat.Slerp(Quat.IdentityProxy, turnModelQuat, slerp, quat);
		component.AddModelQuat(quat, true);
		turnModelBlackboardParams.RunTime = num;
		return true;
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x000883EC File Offset: 0x000865EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnModelBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateTurnModelBlackboard.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600190C RID: 6412 RVA: 0x000884A4 File Offset: 0x000866A4
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
		TurnModelBlackboardParams turnModelBlackboardParams;
		if (!this.ParamsMap.TryGetValue(owner, out turnModelBlackboardParams))
		{
			return false;
		}
		this.ParamsMap.Remove(owner);
		if (this.TurnActorOnEnd)
		{
			characterActorComponent.AddActorLocalRotation(turnModelBlackboardParams.TurnModel.ToUeRotator(), "TsAnimNotifyStateTurnModelBlackboard", false);
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null)
		{
			return false;
		}
		component.ResetModelQuat();
		return true;
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x00088534 File Offset: 0x00086734
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnModelBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateTurnModelBlackboard.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600190E RID: 6414 RVA: 0x000885C4 File Offset: 0x000867C4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "黑板旋转角色";
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x000885CB File Offset: 0x000867CB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateTurnModelBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnModelBlackboard.TsAnimNotifyStateTurnModelBlackboard_C");
		}
		return TsAnimNotifyStateTurnModelBlackboard._ClassPtr;
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x000885F0 File Offset: 0x000867F0
	public TsAnimNotifyStateTurnModelBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnModelBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x00088618 File Offset: 0x00086818
	[NullableContext(1)]
	public TsAnimNotifyStateTurnModelBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnModelBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x0008864B File Offset: 0x0008684B
	protected TsAnimNotifyStateTurnModelBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x00088660 File Offset: 0x00086860
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x0008869C File Offset: 0x0008689C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x000886D8 File Offset: 0x000868D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x0008870B File Offset: 0x0008690B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001092 RID: 4242
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<AActor, TurnModelBlackboardParams> ParamsMap = new Dictionary<AActor, TurnModelBlackboardParams>();

	// Token: 0x04001093 RID: 4243
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnModelBlackboard.TsAnimNotifyStateTurnModelBlackboard_C";

	// Token: 0x04001094 RID: 4244
	private static IntPtr _ClassPtr;

	// Token: 0x04001095 RID: 4245
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001096 RID: 4246
	private static int __PropertyOffset_TurnModelKey;

	// Token: 0x04001097 RID: 4247
	private static int __PropertyOffset_Curve;

	// Token: 0x04001098 RID: 4248
	private static int __PropertyOffset_TurnActorOnEnd;

	// Token: 0x04001099 RID: 4249
	private static int __PropertyOffset_Absolute;
}

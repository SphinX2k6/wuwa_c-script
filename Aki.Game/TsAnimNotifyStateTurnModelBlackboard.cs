using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000182 RID: 386
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnModelBlackboard.TsAnimNotifyStateTurnModelBlackboard_C")]
public class TsAnimNotifyStateTurnModelBlackboard : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06001861 RID: 6241 RVA: 0x00081F95 File Offset: 0x00080195
	// (set) Token: 0x06001862 RID: 6242 RVA: 0x00081FA9 File Offset: 0x000801A9
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

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06001863 RID: 6243 RVA: 0x00081FBE File Offset: 0x000801BE
	// (set) Token: 0x06001864 RID: 6244 RVA: 0x00081FD2 File Offset: 0x000801D2
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

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06001865 RID: 6245 RVA: 0x00081FE7 File Offset: 0x000801E7
	// (set) Token: 0x06001866 RID: 6246 RVA: 0x00081FF7 File Offset: 0x000801F7
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

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06001867 RID: 6247 RVA: 0x00082008 File Offset: 0x00080208
	// (set) Token: 0x06001868 RID: 6248 RVA: 0x00082018 File Offset: 0x00080218
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

	// Token: 0x06001869 RID: 6249 RVA: 0x00082029 File Offset: 0x00080229
	private void Init()
	{
		if (this.ParamsMap != null)
		{
			return;
		}
		this.ParamsMap = new Dictionary<AActor, TurnModelBlackboardParams>();
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00082040 File Offset: 0x00080240
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

	// Token: 0x0600186B RID: 6251 RVA: 0x000820E8 File Offset: 0x000802E8
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

	// Token: 0x0600186C RID: 6252 RVA: 0x00082210 File Offset: 0x00080410
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
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
			ptr2->FrameDeltaTime = deltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x000822B8 File Offset: 0x000804B8
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

	// Token: 0x0600186E RID: 6254 RVA: 0x000823B0 File Offset: 0x000805B0
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

	// Token: 0x0600186F RID: 6255 RVA: 0x00082450 File Offset: 0x00080650
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

	// Token: 0x06001870 RID: 6256 RVA: 0x000824E0 File Offset: 0x000806E0
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

	// Token: 0x06001871 RID: 6257 RVA: 0x0008255B File Offset: 0x0008075B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "黑板旋转角色";
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00082562 File Offset: 0x00080762
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateTurnModelBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnModelBlackboard.TsAnimNotifyStateTurnModelBlackboard_C");
		}
		return TsAnimNotifyStateTurnModelBlackboard._ClassPtr;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00082588 File Offset: 0x00080788
	public TsAnimNotifyStateTurnModelBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnModelBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x000825B0 File Offset: 0x000807B0
	[NullableContext(1)]
	public TsAnimNotifyStateTurnModelBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnModelBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x000825E3 File Offset: 0x000807E3
	protected TsAnimNotifyStateTurnModelBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x000825F8 File Offset: 0x000807F8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00082634 File Offset: 0x00080834
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x00082670 File Offset: 0x00080870
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x000826A3 File Offset: 0x000808A3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400104F RID: 4175
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<AActor, TurnModelBlackboardParams> ParamsMap = new Dictionary<AActor, TurnModelBlackboardParams>();

	// Token: 0x04001050 RID: 4176
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnModelBlackboard.TsAnimNotifyStateTurnModelBlackboard_C";

	// Token: 0x04001051 RID: 4177
	private static IntPtr _ClassPtr;

	// Token: 0x04001052 RID: 4178
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001053 RID: 4179
	private static int __PropertyOffset_TurnModelKey;

	// Token: 0x04001054 RID: 4180
	private static int __PropertyOffset_Curve;

	// Token: 0x04001055 RID: 4181
	private static int __PropertyOffset_TurnActorOnEnd;

	// Token: 0x04001056 RID: 4182
	private static int __PropertyOffset_Absolute;
}

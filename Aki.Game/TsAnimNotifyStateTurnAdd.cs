using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000184 RID: 388
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnAdd.TsAnimNotifyStateTurnAdd_C")]
public class TsAnimNotifyStateTurnAdd : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060018E7 RID: 6375 RVA: 0x000877EE File Offset: 0x000859EE
	static TsAnimNotifyStateTurnAdd()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateTurnAdd.CreateStaticDefaultValue), new Action(TsAnimNotifyStateTurnAdd.ResetStaticDefaultValue));
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x0008780D File Offset: 0x00085A0D
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateTurnAdd.IsInit = false;
		TsAnimNotifyStateTurnAdd.CachedMap = new Dictionary<AActor, TurningParams>();
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x0008781F File Offset: 0x00085A1F
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateTurnAdd.IsInit = false;
		TsAnimNotifyStateTurnAdd.CachedMap = null;
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x060018EA RID: 6378 RVA: 0x0008782D File Offset: 0x00085A2D
	// (set) Token: 0x060018EB RID: 6379 RVA: 0x0008783D File Offset: 0x00085A3D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int AffectType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateTurnAdd.__PropertyOffset_AffectType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateTurnAdd.__PropertyOffset_AffectType) = value;
		}
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x00087850 File Offset: 0x00085A50
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnAdd) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateTurnAdd.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018ED RID: 6381 RVA: 0x00087910 File Offset: 0x00085B10
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		if (characterActorComponent.GetSequenceBinding())
		{
			return false;
		}
		if (!characterActorComponent.IsMoveAutonomousProxy)
		{
			return false;
		}
		TsAnimNotifyStateTurnAdd.Initialize();
		TurningParams turningParams = new TurningParams(totalDuration);
		turningParams.IsRootMotionValid = characterActorComponent.NeedFixBornLocation;
		TsAnimNotifyStateTurnAdd.CachedMap.Add(owner, turningParams);
		NpcMoveComponent component = characterActorComponent.Entity.GetComponent<NpcMoveComponent>();
		if (component != null)
		{
			component.IsTurning = true;
		}
		return true;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x0008799C File Offset: 0x00085B9C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnAdd) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateTurnAdd.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018EF RID: 6383 RVA: 0x00087A5C File Offset: 0x00085C5C
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		if (characterActorComponent.GetSequenceBinding())
		{
			return false;
		}
		if (!characterActorComponent.IsMoveAutonomousProxy)
		{
			return false;
		}
		CharacterAnimationComponent component = characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		TurningParams turningParams;
		if (!TsAnimNotifyStateTurnAdd.CachedMap.TryGetValue(tsBaseCharacter, out turningParams))
		{
			return false;
		}
		if (!turningParams.IsInit)
		{
			turningParams.CalcTurningRate(characterActorComponent, base.CurrentTimeLength, frameDeltaTime);
			return turningParams.NeedTurn;
		}
		if (!turningParams.NeedTurn)
		{
			return false;
		}
		float addRate = turningParams.AddRate;
		float mainAnimsCurveValueWithDelta = component.MainAnimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_LOOK, 0f, false, false);
		float preFrameAngle = turningParams.PreFrameAngle;
		CharacterDriveVehicleComponent component2 = characterActorComponent.Entity.GetComponent<CharacterDriveVehicleComponent>();
		bool flag = component2 != null && component2.IsOnVehicle;
		if (flag)
		{
			characterActorComponent.SetForbidSettingLocAndRot(false, EForbidSettingLocAndRotReason.RideVehicle);
		}
		TsAnimNotifyStateTurnAdd.TmpRotator.Yaw = addRate * (mainAnimsCurveValueWithDelta - preFrameAngle);
		characterActorComponent.AddActorLocalRotation(TsAnimNotifyStateTurnAdd.TmpRotator, "TsAnimNotifyStateTurnAdd", false);
		turningParams.PreFrameAngle = mainAnimsCurveValueWithDelta;
		if (flag)
		{
			characterActorComponent.SetForbidSettingLocAndRot(true, EForbidSettingLocAndRotReason.RideVehicle);
		}
		return true;
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x00087B88 File Offset: 0x00085D88
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnAdd) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateTurnAdd.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018F1 RID: 6385 RVA: 0x00087C40 File Offset: 0x00085E40
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		if (characterActorComponent.GetSequenceBinding())
		{
			return false;
		}
		if (!characterActorComponent.IsMoveAutonomousProxy)
		{
			return false;
		}
		Dictionary<AActor, TurningParams> cachedMap = TsAnimNotifyStateTurnAdd.CachedMap;
		if (cachedMap != null)
		{
			cachedMap.Remove(owner);
		}
		NpcMoveComponent component = characterActorComponent.Entity.GetComponent<NpcMoveComponent>();
		if (component != null)
		{
			component.IsTurning = false;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "TurnAdd End";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", characterActorComponent.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Current", characterActorComponent.ActorRotationProxy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Input", characterActorComponent.InputRotatorProxy);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return true;
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x00087D40 File Offset: 0x00085F40
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateTurnAdd) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateTurnAdd.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018F3 RID: 6387 RVA: 0x00087DD0 File Offset: 0x00085FD0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "根据RootLook曲线控制角色转向";
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00087DD7 File Offset: 0x00085FD7
	private static void Initialize()
	{
		if (TsAnimNotifyStateTurnAdd.IsInit)
		{
			return;
		}
		TsAnimNotifyStateTurnAdd.CachedMap = new Dictionary<AActor, TurningParams>();
		TsAnimNotifyStateTurnAdd.TmpRotator = new FRotator(0f, 0f, 0f);
		TsAnimNotifyStateTurnAdd.IsInit = true;
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x00087E0A File Offset: 0x0008600A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateTurnAdd._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnAdd.TsAnimNotifyStateTurnAdd_C");
		}
		return TsAnimNotifyStateTurnAdd._ClassPtr;
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x00087E30 File Offset: 0x00086030
	public TsAnimNotifyStateTurnAdd() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnAdd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x00087E58 File Offset: 0x00086058
	[NullableContext(1)]
	public TsAnimNotifyStateTurnAdd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnAdd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x00087E8B File Offset: 0x0008608B
	protected TsAnimNotifyStateTurnAdd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x00087E94 File Offset: 0x00086094
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x00087ED0 File Offset: 0x000860D0
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x00087F0C File Offset: 0x0008610C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x00087F3F File Offset: 0x0008613F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001087 RID: 4231
	private static bool IsInit;

	// Token: 0x04001088 RID: 4232
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<AActor, TurningParams> CachedMap;

	// Token: 0x04001089 RID: 4233
	[StaticVariableRuleIgnore]
	private static FRotator TmpRotator;

	// Token: 0x0400108A RID: 4234
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnAdd.TsAnimNotifyStateTurnAdd_C";

	// Token: 0x0400108B RID: 4235
	private static IntPtr _ClassPtr;

	// Token: 0x0400108C RID: 4236
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400108D RID: 4237
	private static int __PropertyOffset_AffectType;
}

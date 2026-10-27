using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000180 RID: 384
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnAdd.TsAnimNotifyStateTurnAdd_C")]
public class TsAnimNotifyStateTurnAdd : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600184A RID: 6218 RVA: 0x0008183E File Offset: 0x0007FA3E
	static TsAnimNotifyStateTurnAdd()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateTurnAdd.CreateStaticDefaultValue), new Action(TsAnimNotifyStateTurnAdd.ResetStaticDefaultValue));
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x0008185D File Offset: 0x0007FA5D
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateTurnAdd.IsInit = false;
		TsAnimNotifyStateTurnAdd.CachedMap = new Dictionary<AActor, TurningParams>();
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x0008186F File Offset: 0x0007FA6F
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateTurnAdd.IsInit = false;
		TsAnimNotifyStateTurnAdd.CachedMap = null;
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x0600184D RID: 6221 RVA: 0x0008187D File Offset: 0x0007FA7D
	// (set) Token: 0x0600184E RID: 6222 RVA: 0x0008188D File Offset: 0x0007FA8D
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

	// Token: 0x0600184F RID: 6223 RVA: 0x000818A0 File Offset: 0x0007FAA0
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

	// Token: 0x06001850 RID: 6224 RVA: 0x00081948 File Offset: 0x0007FB48
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

	// Token: 0x06001851 RID: 6225 RVA: 0x000819D4 File Offset: 0x0007FBD4
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

	// Token: 0x06001852 RID: 6226 RVA: 0x00081A7C File Offset: 0x0007FC7C
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

	// Token: 0x06001853 RID: 6227 RVA: 0x00081BA8 File Offset: 0x0007FDA8
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

	// Token: 0x06001854 RID: 6228 RVA: 0x00081C48 File Offset: 0x0007FE48
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

	// Token: 0x06001855 RID: 6229 RVA: 0x00081D48 File Offset: 0x0007FF48
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

	// Token: 0x06001856 RID: 6230 RVA: 0x00081DC3 File Offset: 0x0007FFC3
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "根据RootLook曲线控制角色转向";
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00081DCA File Offset: 0x0007FFCA
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

	// Token: 0x06001858 RID: 6232 RVA: 0x00081DFD File Offset: 0x0007FFFD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateTurnAdd._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnAdd.TsAnimNotifyStateTurnAdd_C");
		}
		return TsAnimNotifyStateTurnAdd._ClassPtr;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x00081E24 File Offset: 0x00080024
	public TsAnimNotifyStateTurnAdd() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnAdd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x00081E4C File Offset: 0x0008004C
	[NullableContext(1)]
	public TsAnimNotifyStateTurnAdd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateTurnAdd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x00081E7F File Offset: 0x0008007F
	protected TsAnimNotifyStateTurnAdd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x00081E88 File Offset: 0x00080088
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x00081EC4 File Offset: 0x000800C4
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00081F00 File Offset: 0x00080100
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x00081F33 File Offset: 0x00080133
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001044 RID: 4164
	private static bool IsInit;

	// Token: 0x04001045 RID: 4165
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<AActor, TurningParams> CachedMap;

	// Token: 0x04001046 RID: 4166
	[StaticVariableRuleIgnore]
	private static FRotator TmpRotator;

	// Token: 0x04001047 RID: 4167
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateTurnAdd.TsAnimNotifyStateTurnAdd_C";

	// Token: 0x04001048 RID: 4168
	private static IntPtr _ClassPtr;

	// Token: 0x04001049 RID: 4169
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400104A RID: 4170
	private static int __PropertyOffset_AffectType;
}

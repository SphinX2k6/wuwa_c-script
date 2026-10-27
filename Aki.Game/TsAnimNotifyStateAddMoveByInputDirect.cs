using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000108 RID: 264
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddMoveByInputDirect.TsAnimNotifyStateAddMoveByInputDirect_C")]
public class TsAnimNotifyStateAddMoveByInputDirect : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000F5C RID: 3932 RVA: 0x00058EAA File Offset: 0x000570AA
	static TsAnimNotifyStateAddMoveByInputDirect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAddMoveByInputDirect.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAddMoveByInputDirect.ResetStaticDefaultValue));
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00058EC9 File Offset: 0x000570C9
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAddMoveByInputDirect.paramMap = new Dictionary<int, AddMoveParams>();
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00058ED5 File Offset: 0x000570D5
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAddMoveByInputDirect.paramMap = null;
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00058EDD File Offset: 0x000570DD
	// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00058EED File Offset: 0x000570ED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00058EFE File Offset: 0x000570FE
	// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00058F0E File Offset: 0x0005710E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AccelerationTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_AccelerationTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_AccelerationTime) = value;
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00058F1F File Offset: 0x0005711F
	// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00058F2F File Offset: 0x0005712F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DecelerationTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_DecelerationTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_DecelerationTime) = value;
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00058F40 File Offset: 0x00057140
	// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00058F54 File Offset: 0x00057154
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat SpeedCurve
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_SpeedCurve);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_SpeedCurve, value);
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00058F69 File Offset: 0x00057169
	// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00058F79 File Offset: 0x00057179
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddMoveByInputDirect.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00058F8C File Offset: 0x0005718C
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

	// Token: 0x06000F6A RID: 3946 RVA: 0x00059034 File Offset: 0x00057234
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		if (this.TmpVector == null)
		{
			this.TmpVector = Vector.Create();
		}
		AddMoveParams addMoveParams = new AddMoveParams();
		Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
		addMoveParams.CharSkillComp = entity.GetComponent<CharacterSkillComponent>();
		addMoveParams.MoveComp = entity.GetComponent<BaseMoveComponent>();
		addMoveParams.CharActorComp = (owner as TsBaseCharacter).CharacterActorComponent;
		TsAnimNotifyStateAddMoveByInputDirect.paramMap.Add((owner as TsBaseCharacter).EntityId, addMoveParams);
		this.TotalTime = totalDuration;
		if (this.AccelerationTime + this.DecelerationTime > totalDuration)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity2 = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
			string message = "加速时间+减速时间大于帧事件总时长";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("加速时间", this.AccelerationTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("减速时间", this.DecelerationTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("总时长", this.TotalTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("动画", animation);
			instance.Error(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		if (this.AccelerationTime > 0f)
		{
			this.Acceleration = this.MaxSpeed / this.AccelerationTime;
		}
		if (this.DecelerationTime > 0f)
		{
			this.Deceleration = this.MaxSpeed / this.DecelerationTime;
		}
		return true;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x000591C8 File Offset: 0x000573C8
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

	// Token: 0x06000F6C RID: 3948 RVA: 0x00059270 File Offset: 0x00057470
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		AddMoveParams addMoveParams;
		if (!TsAnimNotifyStateAddMoveByInputDirect.paramMap.TryGetValue(tsBaseCharacter.EntityId, out addMoveParams))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
			string message = "没有找到对应的AddMoveParams";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", tsBaseCharacter.EntityId);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Vector inputDirectProxy = tsBaseCharacter.CharacterActorComponent.InputDirectProxy;
		if (!inputDirectProxy.IsNearlyZero(9.999999747378752E-05))
		{
			addMoveParams.InputDirectCache.DeepCopy(inputDirectProxy);
		}
		Vector offset = this.GetOffset(inputDirectProxy, frameDeltaTime, addMoveParams);
		BaseMoveComponent moveComp = addMoveParams.MoveComp;
		if (moveComp != null)
		{
			moveComp.MoveCharacter(offset, frameDeltaTime, "TsAnimNotifyStateAddMoveByInputDirect");
		}
		addMoveParams.NowTime += frameDeltaTime;
		return true;
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00059338 File Offset: 0x00057538
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

	// Token: 0x06000F6E RID: 3950 RVA: 0x000593D8 File Offset: 0x000575D8
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		TsAnimNotifyStateAddMoveByInputDirect.paramMap.Remove((owner as TsBaseCharacter).EntityId);
		return true;
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00059410 File Offset: 0x00057610
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

	// Token: 0x06000F70 RID: 3952 RVA: 0x0005948B File Offset: 0x0005768B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "输入向量叠加位移";
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00059494 File Offset: 0x00057694
	[NullableContext(1)]
	private Vector GetOffset(Vector inputDirect, float frameDeltaTime, AddMoveParams param)
	{
		if (this.SpeedCurve != null)
		{
			if (this.IsDecelerating(inputDirect, param))
			{
				if (this.DecelerationTime <= 0f)
				{
					this.SetCurrentSpeedFromCurve(param, 0f);
				}
				else if (this.AccelerationTime <= 0f)
				{
					param.AccumulativeSpeedUpTime -= frameDeltaTime;
					param.AccumulativeSpeedUpTime = Math.Max(param.AccumulativeSpeedUpTime, 0f);
					float floatValue = this.SpeedCurve.GetFloatValue(param.AccumulativeSpeedUpTime / this.DecelerationTime);
					this.SetCurrentSpeedFromCurve(param, floatValue);
				}
				else
				{
					param.AccumulativeSpeedUpTime -= frameDeltaTime * (this.AccelerationTime / this.DecelerationTime);
					param.AccumulativeSpeedUpTime = Math.Max(param.AccumulativeSpeedUpTime, 0f);
					float floatValue2 = this.SpeedCurve.GetFloatValue(param.AccumulativeSpeedUpTime / this.AccelerationTime);
					this.SetCurrentSpeedFromCurve(param, floatValue2);
				}
			}
			else if (this.AccelerationTime <= 0f)
			{
				this.SetCurrentSpeedFromCurve(param, 1f);
				param.AccumulativeSpeedUpTime = this.DecelerationTime;
			}
			else
			{
				param.AccumulativeSpeedUpTime += frameDeltaTime;
				param.AccumulativeSpeedUpTime = Math.Min(param.AccumulativeSpeedUpTime, this.AccelerationTime);
				float floatValue3 = this.SpeedCurve.GetFloatValue(param.AccumulativeSpeedUpTime / this.AccelerationTime);
				this.SetCurrentSpeedFromCurve(param, floatValue3);
			}
		}
		else if (this.IsDecelerating(inputDirect, param))
		{
			if (this.Deceleration != 0f)
			{
				param.CurrentSpeed -= this.Deceleration * frameDeltaTime;
				param.CurrentSpeed = Math.Max(param.CurrentSpeed, 0f);
			}
			else
			{
				param.CurrentSpeed = 0f;
			}
		}
		else if (this.Acceleration != 0f)
		{
			param.CurrentSpeed += this.Acceleration * frameDeltaTime;
			param.CurrentSpeed = Math.Min(param.CurrentSpeed, this.MaxSpeed);
		}
		else
		{
			param.CurrentSpeed = this.MaxSpeed;
		}
		this.TmpVector.DeepCopy(param.InputDirectCache);
		this.TmpVector.Normalize(9.99999993922529E-09);
		this.TmpVector.MultiplyEqual((double)(param.CurrentSpeed * frameDeltaTime));
		return this.TmpVector;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x000596D4 File Offset: 0x000578D4
	[NullableContext(1)]
	private bool IsDecelerating(Vector inputDirect, AddMoveParams param)
	{
		CharacterSkillComponent charSkillComp = param.CharSkillComp;
		EntityHandle entityHandle = (charSkillComp != null) ? charSkillComp.GetSkillTargetForAns() : null;
		if (this.Distance > 0f && entityHandle != null)
		{
			Vector actorLocationProxy = param.CharActorComp.ActorLocationProxy;
			Vector targetPosition = this.GetTargetPosition(param, entityHandle);
			if (Vector.Dist2D(actorLocationProxy, targetPosition) < (double)this.Distance)
			{
				return true;
			}
		}
		return inputDirect.IsNearlyZero(9.999999747378752E-05) || param.NowTime > this.TotalTime - this.DecelerationTime;
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00059754 File Offset: 0x00057954
	[NullableContext(1)]
	private void SetCurrentSpeedFromCurve(AddMoveParams param, float nextSpeedRate)
	{
		float num = this.MaxSpeed * nextSpeedRate;
		if (num <= 0f)
		{
			param.CurrentSpeed = 0f;
			return;
		}
		param.CurrentSpeed = num;
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00059788 File Offset: 0x00057988
	[NullableContext(1)]
	private Vector GetTargetPosition(AddMoveParams param, EntityHandle target)
	{
		string skillTargetSocket = param.CharSkillComp.SkillTargetSocket;
		CharacterActorComponent component = target.Entity.GetComponent<CharacterActorComponent>();
		if (!string.IsNullOrEmpty(skillTargetSocket) && component != null)
		{
			FVectorDouble fvectorDouble = component.Actor.Mesh.D_GetSocketLocation(FNameUtil.GetDynamicFName(skillTargetSocket).Value);
			this.TmpVector.DeepCopy(fvectorDouble);
		}
		else
		{
			BaseActorComponent component2 = target.Entity.GetComponent<BaseActorComponent>();
			this.TmpVector.DeepCopy(component2.ActorLocationProxy);
		}
		return this.TmpVector;
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x0005980B File Offset: 0x00057A0B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddMoveByInputDirect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddMoveByInputDirect.TsAnimNotifyStateAddMoveByInputDirect_C");
		}
		return TsAnimNotifyStateAddMoveByInputDirect._ClassPtr;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00059830 File Offset: 0x00057A30
	public TsAnimNotifyStateAddMoveByInputDirect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00059858 File Offset: 0x00057A58
	[NullableContext(1)]
	public TsAnimNotifyStateAddMoveByInputDirect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x0005988B File Offset: 0x00057A8B
	protected TsAnimNotifyStateAddMoveByInputDirect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00059894 File Offset: 0x00057A94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x000598D0 File Offset: 0x00057AD0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x0005990C File Offset: 0x00057B0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x0005993F File Offset: 0x00057B3F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C1A RID: 3098
	[Nullable(1)]
	private static Dictionary<int, AddMoveParams> paramMap;

	// Token: 0x04000C1B RID: 3099
	private float Acceleration;

	// Token: 0x04000C1C RID: 3100
	private float Deceleration;

	// Token: 0x04000C1D RID: 3101
	private float TotalTime;

	// Token: 0x04000C1E RID: 3102
	private Vector TmpVector;

	// Token: 0x04000C1F RID: 3103
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddMoveByInputDirect.TsAnimNotifyStateAddMoveByInputDirect_C";

	// Token: 0x04000C20 RID: 3104
	private static IntPtr _ClassPtr;

	// Token: 0x04000C21 RID: 3105
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C22 RID: 3106
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000C23 RID: 3107
	private static int __PropertyOffset_AccelerationTime;

	// Token: 0x04000C24 RID: 3108
	private static int __PropertyOffset_DecelerationTime;

	// Token: 0x04000C25 RID: 3109
	private static int __PropertyOffset_SpeedCurve;

	// Token: 0x04000C26 RID: 3110
	private static int __PropertyOffset_Distance;
}

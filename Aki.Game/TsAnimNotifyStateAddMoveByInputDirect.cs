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
	// Token: 0x06000F62 RID: 3938 RVA: 0x00059ED2 File Offset: 0x000580D2
	static TsAnimNotifyStateAddMoveByInputDirect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAddMoveByInputDirect.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAddMoveByInputDirect.ResetStaticDefaultValue));
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00059EF1 File Offset: 0x000580F1
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAddMoveByInputDirect.paramMap = new Dictionary<int, AddMoveParams>();
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00059EFD File Offset: 0x000580FD
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAddMoveByInputDirect.paramMap = null;
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00059F05 File Offset: 0x00058105
	// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00059F15 File Offset: 0x00058115
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

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00059F26 File Offset: 0x00058126
	// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00059F36 File Offset: 0x00058136
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

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00059F47 File Offset: 0x00058147
	// (set) Token: 0x06000F6A RID: 3946 RVA: 0x00059F57 File Offset: 0x00058157
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

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00059F68 File Offset: 0x00058168
	// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00059F7C File Offset: 0x0005817C
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

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00059F91 File Offset: 0x00058191
	// (set) Token: 0x06000F6E RID: 3950 RVA: 0x00059FA1 File Offset: 0x000581A1
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

	// Token: 0x06000F6F RID: 3951 RVA: 0x00059FB4 File Offset: 0x000581B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddMoveByInputDirect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F70 RID: 3952 RVA: 0x0005A074 File Offset: 0x00058274
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

	// Token: 0x06000F71 RID: 3953 RVA: 0x0005A208 File Offset: 0x00058408
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddMoveByInputDirect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F72 RID: 3954 RVA: 0x0005A2C8 File Offset: 0x000584C8
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

	// Token: 0x06000F73 RID: 3955 RVA: 0x0005A390 File Offset: 0x00058590
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddMoveByInputDirect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F74 RID: 3956 RVA: 0x0005A448 File Offset: 0x00058648
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

	// Token: 0x06000F75 RID: 3957 RVA: 0x0005A480 File Offset: 0x00058680
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddMoveByInputDirect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F76 RID: 3958 RVA: 0x0005A510 File Offset: 0x00058710
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "输入向量叠加位移";
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x0005A518 File Offset: 0x00058718
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

	// Token: 0x06000F78 RID: 3960 RVA: 0x0005A758 File Offset: 0x00058958
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

	// Token: 0x06000F79 RID: 3961 RVA: 0x0005A7D8 File Offset: 0x000589D8
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

	// Token: 0x06000F7A RID: 3962 RVA: 0x0005A80C File Offset: 0x00058A0C
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

	// Token: 0x06000F7B RID: 3963 RVA: 0x0005A88F File Offset: 0x00058A8F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddMoveByInputDirect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddMoveByInputDirect.TsAnimNotifyStateAddMoveByInputDirect_C");
		}
		return TsAnimNotifyStateAddMoveByInputDirect._ClassPtr;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x0005A8B4 File Offset: 0x00058AB4
	public TsAnimNotifyStateAddMoveByInputDirect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x0005A8DC File Offset: 0x00058ADC
	[NullableContext(1)]
	public TsAnimNotifyStateAddMoveByInputDirect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddMoveByInputDirect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x0005A90F File Offset: 0x00058B0F
	protected TsAnimNotifyStateAddMoveByInputDirect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0005A918 File Offset: 0x00058B18
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x0005A954 File Offset: 0x00058B54
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0005A990 File Offset: 0x00058B90
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x0005A9C3 File Offset: 0x00058BC3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C22 RID: 3106
	[Nullable(1)]
	private static Dictionary<int, AddMoveParams> paramMap;

	// Token: 0x04000C23 RID: 3107
	private float Acceleration;

	// Token: 0x04000C24 RID: 3108
	private float Deceleration;

	// Token: 0x04000C25 RID: 3109
	private float TotalTime;

	// Token: 0x04000C26 RID: 3110
	private Vector TmpVector;

	// Token: 0x04000C27 RID: 3111
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddMoveByInputDirect.TsAnimNotifyStateAddMoveByInputDirect_C";

	// Token: 0x04000C28 RID: 3112
	private static IntPtr _ClassPtr;

	// Token: 0x04000C29 RID: 3113
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C2A RID: 3114
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000C2B RID: 3115
	private static int __PropertyOffset_AccelerationTime;

	// Token: 0x04000C2C RID: 3116
	private static int __PropertyOffset_DecelerationTime;

	// Token: 0x04000C2D RID: 3117
	private static int __PropertyOffset_SpeedCurve;

	// Token: 0x04000C2E RID: 3118
	private static int __PropertyOffset_Distance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000141 RID: 321
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInputBehavior.TsAnimNotifyStateInputBehavior_C")]
public class TsAnimNotifyStateInputBehavior : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06001402 RID: 5122 RVA: 0x00071B68 File Offset: 0x0006FD68
	// (set) Token: 0x06001403 RID: 5123 RVA: 0x00071BA1 File Offset: 0x0006FDA1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SInputBehavior> 输入行为
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SInputBehavior> result;
			if ((result = this._输入行为) == null)
			{
				result = (this._输入行为 = new TArray<SInputBehavior>(base.NativePtr + (IntPtr)TsAnimNotifyStateInputBehavior.__PropertyOffset_输入行为, this));
			}
			return result;
		}
		set
		{
			this.输入行为.CopyAssign(value);
		}
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00071BB0 File Offset: 0x0006FDB0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInputBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateInputBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001405 RID: 5125 RVA: 0x00071C70 File Offset: 0x0006FE70
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (meshComp == null || animation == null)
		{
			return false;
		}
		this.CleanupState(meshComp, null);
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterActorComponent characterActorComponent2 = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		CharacterInputComponent characterInputComponent = (entity != null) ? entity.GetComponent<CharacterInputComponent>() : null;
		CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
		Skill skill = (characterSkillComponent != null) ? characterSkillComponent.CurrentSkill : null;
		if (entity == null || (characterActorComponent2 == null || !characterActorComponent2.IsAutonomousProxy) || characterInputComponent == null || characterSkillComponent == null || skill == null)
		{
			return false;
		}
		if (characterSkillComponent.IsSkillMontageInvalid(animation.GetName()))
		{
			return false;
		}
		TArray<SInputBehavior> 输入行为 = this.输入行为;
		int num = (输入行为 != null) ? 输入行为.Num() : 0;
		if (num == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AnimNotify;
			ELogAuthor author = ELogAuthor.LXH;
			string message = "输入行为ANS配置为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("技能Id", skill.SkillId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			if (this.输入行为.Get(i).BehaviorConditionArray.Num() == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.AnimNotify;
				ELogAuthor author2 = ELogAuthor.LXH;
				string message2 = "输入行为ANS存在空条件组，终止当前ANS";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", skill.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("行为索引", i);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
		}
		IInputBehaviorParam param = new IInputBehaviorParam
		{
			Entity = entity,
			SkillComponent = characterSkillComponent,
			Skill = skill
		};
		double worldTimeSeconds = Time.Instance.WorldTimeSeconds;
		InputBehaviorInputHandler inputBehaviorInputHandler = new InputBehaviorInputHandler(this.输入行为, worldTimeSeconds, characterInputComponent);
		List<InputBehaviorRuntimeState> list = new List<InputBehaviorRuntimeState>();
		for (int j = 0; j < num; j++)
		{
			SInputBehavior sinputBehavior = this.输入行为.Get(j);
			InputBehaviorConditionContext inputBehaviorConditionContext = InputBehaviorCondition.CreateContext(sinputBehavior, param);
			if (inputBehaviorConditionContext == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.AnimNotify;
				ELogAuthor author3 = ELogAuthor.LXH;
				string message3 = "输入行为ANS条件初始化失败，终止当前ANS";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("技能Id", skill.SkillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("行为索引", j);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			list.Add(new InputBehaviorRuntimeState(sinputBehavior, inputBehaviorConditionContext));
		}
		InputBehaviorAnsState inputBehaviorAnsState = new InputBehaviorAnsState(param, inputBehaviorInputHandler, list, totalDuration);
		this.StateMap[meshComp] = inputBehaviorAnsState;
		inputBehaviorInputHandler.Start();
		this.ProcessConditions(meshComp, inputBehaviorAnsState, inputBehaviorInputHandler.ConsumeInputFrame());
		return true;
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x00071F28 File Offset: 0x00070128
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInputBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateInputBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001407 RID: 5127 RVA: 0x00071FE8 File Offset: 0x000701E8
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		InputBehaviorAnsState inputBehaviorAnsState;
		if (meshComp == null || animation == null || !this.StateMap.TryGetValue(meshComp, out inputBehaviorAnsState))
		{
			return false;
		}
		if (!this.IsStateValid(inputBehaviorAnsState, animation))
		{
			this.CleanupState(meshComp, inputBehaviorAnsState);
			return false;
		}
		this.ProcessConditions(meshComp, inputBehaviorAnsState, inputBehaviorAnsState.InputHandler.ConsumeInputFrame());
		return true;
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00072038 File Offset: 0x00070238
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInputBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateInputBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001409 RID: 5129 RVA: 0x000720F0 File Offset: 0x000702F0
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		InputBehaviorAnsState inputBehaviorAnsState;
		if (meshComp == null || animation == null || !this.StateMap.TryGetValue(meshComp, out inputBehaviorAnsState))
		{
			return false;
		}
		if (inputBehaviorAnsState.Executing || inputBehaviorAnsState.Executed || !this.IsStateValid(inputBehaviorAnsState, animation) || !this.IsNaturallyCompleted(inputBehaviorAnsState))
		{
			this.CleanupState(meshComp, inputBehaviorAnsState);
			return true;
		}
		this.ProcessConditions(meshComp, inputBehaviorAnsState, inputBehaviorAnsState.InputHandler.ConsumeInputFrame());
		InputBehaviorAnsState inputBehaviorAnsState2;
		if (!this.StateMap.TryGetValue(meshComp, out inputBehaviorAnsState2) || inputBehaviorAnsState2 != inputBehaviorAnsState)
		{
			return true;
		}
		foreach (InputBehaviorRuntimeState inputBehaviorRuntimeState in inputBehaviorAnsState.Behaviors)
		{
			if (inputBehaviorRuntimeState.ConditionSatisfied && !inputBehaviorRuntimeState.DispatchAttempted && inputBehaviorRuntimeState.Config.BehaviorActionTiming == EInputBehaviorActionTiming.等待ANS完成时执行)
			{
				this.DispatchBehavior(meshComp, inputBehaviorAnsState, inputBehaviorRuntimeState);
				break;
			}
		}
		this.CleanupState(meshComp, inputBehaviorAnsState);
		return true;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x000721E4 File Offset: 0x000703E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInputBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateInputBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600140B RID: 5131 RVA: 0x00072274 File Offset: 0x00070474
	protected override string GetNotifyName_Implementation()
	{
		return "输入行为";
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x0007227B File Offset: 0x0007047B
	private bool IsStateValid(InputBehaviorAnsState state, UAnimSequenceBase animation)
	{
		return state.Param.SkillComponent.CurrentSkill == state.Param.Skill && !state.Param.SkillComponent.IsSkillMontageInvalid(animation.GetName());
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x000722B8 File Offset: 0x000704B8
	private bool IsNaturallyCompleted(InputBehaviorAnsState state)
	{
		float num = MathF.Min(0.05f, state.TotalDuration * 0.5f);
		float currentTimeLength = base.GetCurrentTimeLength();
		return currentTimeLength > 0f && currentTimeLength >= state.TotalDuration - num;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x000722FC File Offset: 0x000704FC
	private bool ProcessConditions(USkeletalMeshComponent meshComp, InputBehaviorAnsState state, [Nullable(2)] IInputBehaviorInputFrame inputFrame = null)
	{
		if (state.Executing || state.Executed)
		{
			return state.Executed;
		}
		foreach (InputBehaviorRuntimeState inputBehaviorRuntimeState in state.Behaviors)
		{
			if (!inputBehaviorRuntimeState.ConditionSatisfied && !inputBehaviorRuntimeState.DispatchAttempted && InputBehaviorCondition.SatisfyGroup(inputBehaviorRuntimeState.ConditionContext, state.Param, inputFrame))
			{
				inputBehaviorRuntimeState.ConditionSatisfied = true;
				if (inputBehaviorRuntimeState.Config.BehaviorActionTiming == EInputBehaviorActionTiming.立即执行)
				{
					this.DispatchBehavior(meshComp, state, inputBehaviorRuntimeState);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x000723AC File Offset: 0x000705AC
	private void DispatchBehavior(USkeletalMeshComponent meshComp, InputBehaviorAnsState state, InputBehaviorRuntimeState behavior)
	{
		behavior.DispatchAttempted = true;
		state.Executing = true;
		InputBehaviorAction.ExecuteGroup(behavior.Config.BehaviorActionArray, state.Param);
		state.Executing = false;
		state.Executed = true;
		this.CleanupState(meshComp, state);
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x000723E8 File Offset: 0x000705E8
	private void CleanupState(USkeletalMeshComponent meshComp, [Nullable(2)] InputBehaviorAnsState expectedState = null)
	{
		InputBehaviorAnsState inputBehaviorAnsState;
		if (!this.StateMap.TryGetValue(meshComp, out inputBehaviorAnsState) || (expectedState != null && inputBehaviorAnsState != expectedState))
		{
			return;
		}
		inputBehaviorAnsState.InputHandler.Clear();
		this.StateMap.Remove(meshComp);
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00072425 File Offset: 0x00070625
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateInputBehavior._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInputBehavior.TsAnimNotifyStateInputBehavior_C");
		}
		return TsAnimNotifyStateInputBehavior._ClassPtr;
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x0007244C File Offset: 0x0007064C
	public TsAnimNotifyStateInputBehavior() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00072474 File Offset: 0x00070674
	public TsAnimNotifyStateInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x000724A7 File Offset: 0x000706A7
	protected TsAnimNotifyStateInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x000724BC File Offset: 0x000706BC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x000724F8 File Offset: 0x000706F8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00072534 File Offset: 0x00070734
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x00072567 File Offset: 0x00070767
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E6D RID: 3693
	private const float INTERRUPT_THRESHOLD = 0.05f;

	// Token: 0x04000E6E RID: 3694
	private readonly Dictionary<USkeletalMeshComponent, InputBehaviorAnsState> StateMap = new Dictionary<USkeletalMeshComponent, InputBehaviorAnsState>();

	// Token: 0x04000E6F RID: 3695
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInputBehavior.TsAnimNotifyStateInputBehavior_C";

	// Token: 0x04000E70 RID: 3696
	private static IntPtr _ClassPtr;

	// Token: 0x04000E71 RID: 3697
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E72 RID: 3698
	private static int __PropertyOffset_输入行为;

	// Token: 0x04000E73 RID: 3699
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SInputBehavior> _输入行为;
}

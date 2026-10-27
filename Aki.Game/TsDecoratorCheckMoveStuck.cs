using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200003B RID: 59
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckMoveStuck.TsDecoratorCheckMoveStuck_C")]
public class TsDecoratorCheckMoveStuck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600021E RID: 542 RVA: 0x0000A53F File Offset: 0x0000873F
	// (set) Token: 0x0600021F RID: 543 RVA: 0x0000A54F File Offset: 0x0000874F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinMoveSpeedRate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckMoveStuck.__PropertyOffset_MinMoveSpeedRate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckMoveStuck.__PropertyOffset_MinMoveSpeedRate) = value;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000220 RID: 544 RVA: 0x0000A560 File Offset: 0x00008760
	// (set) Token: 0x06000221 RID: 545 RVA: 0x0000A570 File Offset: 0x00008770
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StuckDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckMoveStuck.__PropertyOffset_StuckDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckMoveStuck.__PropertyOffset_StuckDuration) = value;
		}
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000A581 File Offset: 0x00008781
	private void ResetSampleState()
	{
		this.HasSample = false;
		this.LastSampleTime = 0.0;
		this.LowSpeedDuration = 0.0;
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000A5A8 File Offset: 0x000087A8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMinMoveSpeedRate = this.MinMoveSpeedRate;
			this.TsStuckDuration = this.StuckDuration;
		}
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000A5D8 File Offset: 0x000087D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000A678 File Offset: 0x00008878
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		CharacterActorComponent characterActorComponent = (aiController != null) ? aiController.CharActorComp : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		this.InitTsVariables();
		if (this.TsStuckDuration <= 0f || this.TsMinMoveSpeedRate <= 0f)
		{
			return true;
		}
		double worldTime = Time.Instance.WorldTime;
		if (!this.HasSample)
		{
			this.LastSampleTime = worldTime;
			this.LastSampleLocation.DeepCopy(characterActorComponent.ActorLocationProxy);
			this.HasSample = true;
			return true;
		}
		double num = worldTime - this.LastSampleTime;
		if (num <= 0.0)
		{
			return true;
		}
		Vector safeActorVelocityProxy = characterActorComponent.SafeActorVelocityProxy;
		if (safeActorVelocityProxy == null)
		{
			return false;
		}
		BaseUnifiedStateComponent component = characterActorComponent.Entity.GetComponent<BaseUnifiedStateComponent>();
		ECharMoveState? echarMoveState = (component != null) ? new ECharMoveState?(component.MoveState) : null;
		object obj = echarMoveState != null && this.RealGroundStates.Contains(echarMoveState.Value);
		double num2 = num * 0.0010000000474974513;
		object obj2 = obj;
		double num3 = (obj2 != null) ? GravityUtils.Instance.GetPlanarSizeSquared2dForActor(characterActorComponent, safeActorVelocityProxy) : safeActorVelocityProxy.SizeSquared();
		double num4 = ((obj2 != null) ? GravityUtils.Instance.GetDistSquared2dForActor(characterActorComponent, characterActorComponent.ActorLocationProxy, this.LastSampleLocation) : Vector.DistSquared(characterActorComponent.ActorLocationProxy, this.LastSampleLocation)) / (num2 * num2);
		this.LastSampleLocation.DeepCopy(characterActorComponent.ActorLocationProxy);
		this.LastSampleTime = worldTime;
		double num5 = num3 * (double)this.TsMinMoveSpeedRate * (double)this.TsMinMoveSpeedRate;
		if (num4 < num5)
		{
			this.LowSpeedDuration += num;
			if (this.LowSpeedDuration >= (double)this.TsStuckDuration)
			{
				return false;
			}
		}
		else
		{
			this.LowSpeedDuration = 0.0;
		}
		return true;
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000A82C File Offset: 0x00008A2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecutionFinishAI(AAIController ownerController, APawn controlledPawn, EBTNodeResult nodeResult)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecutionFinishAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			*(byte*)(&ptr2->NodeResult) = (byte)nodeResult;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000A8D0 File Offset: 0x00008AD0
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecutionFinishAI_Implementation(AAIController ownerController, APawn controlledPawn, EBTNodeResult nodeResult)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.YY;
		string message = "[CheckMoveStuck] ReceiveExecutionFinishAI";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Controller", ((ownerController != null) ? ownerController.GetName() : null) ?? "Unknown");
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Result", nodeResult);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.ResetSampleState();
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000A950 File Offset: 0x00008B50
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveObserverDeactivatedAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveObserverDeactivatedAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000A9EC File Offset: 0x00008BEC
	[NullableContext(2)]
	protected virtual void ReceiveObserverDeactivatedAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.YY;
		string message = "[CheckMoveStuck] ReceiveObserverDeactivatedAI";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Controller", ((ownerController != null) ? ownerController.GetName() : null) ?? "Unknown");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ResetSampleState();
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000AA3A File Offset: 0x00008C3A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckMoveStuck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckMoveStuck.TsDecoratorCheckMoveStuck_C");
		}
		return TsDecoratorCheckMoveStuck._ClassPtr;
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000AA60 File Offset: 0x00008C60
	public TsDecoratorCheckMoveStuck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckMoveStuck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000AA88 File Offset: 0x00008C88
	[NullableContext(1)]
	public TsDecoratorCheckMoveStuck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckMoveStuck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000AABC File Offset: 0x00008CBC
	protected TsDecoratorCheckMoveStuck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000AB20 File Offset: 0x00008D20
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000AB54 File Offset: 0x00008D54
	protected unsafe virtual void __CPPCALL_ReceiveExecutionFinishAI_Implementation(UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		EBTNodeResult nodeResult = __Params->NodeResult;
		this.ReceiveExecutionFinishAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, nodeResult);
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000AB90 File Offset: 0x00008D90
	protected unsafe virtual void __CPPCALL_ReceiveObserverDeactivatedAI_Implementation(UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveObserverDeactivatedAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000169 RID: 361
	private bool IsInitTsVariables;

	// Token: 0x0400016A RID: 362
	private float TsMinMoveSpeedRate;

	// Token: 0x0400016B RID: 363
	private float TsStuckDuration;

	// Token: 0x0400016C RID: 364
	private double LastSampleTime;

	// Token: 0x0400016D RID: 365
	[Nullable(1)]
	private readonly Vector LastSampleLocation = Vector.Create();

	// Token: 0x0400016E RID: 366
	private double LowSpeedDuration;

	// Token: 0x0400016F RID: 367
	private bool HasSample;

	// Token: 0x04000170 RID: 368
	[Nullable(1)]
	private readonly HashSet<ECharMoveState> RealGroundStates = new HashSet<ECharMoveState>
	{
		ECharMoveState.Walk,
		ECharMoveState.WalkStop,
		ECharMoveState.Run,
		ECharMoveState.RunStop,
		ECharMoveState.Sprint,
		ECharMoveState.SprintStop,
		ECharMoveState.Dodge
	};

	// Token: 0x04000171 RID: 369
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckMoveStuck.TsDecoratorCheckMoveStuck_C";

	// Token: 0x04000172 RID: 370
	private static IntPtr _ClassPtr;

	// Token: 0x04000173 RID: 371
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000174 RID: 372
	private static int __PropertyOffset_MinMoveSpeedRate;

	// Token: 0x04000175 RID: 373
	private static int __PropertyOffset_StuckDuration;
}

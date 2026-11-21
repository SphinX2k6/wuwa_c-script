using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000037 RID: 55
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckFsmState.TsDecoratorCheckFsmState_C")]
public class TsDecoratorCheckFsmState : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x00009E63 File Offset: 0x00008063
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x00009E77 File Offset: 0x00008077
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string State
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorCheckFsmState.__PropertyOffset_State)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorCheckFsmState.__PropertyOffset_State)), value);
		}
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00009E8C File Offset: 0x0000808C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckFsmState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckFsmState.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00009F44 File Offset: 0x00008144
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterStateMachineNewComponent component = aiController.CharActorComp.Entity.GetComponent<CharacterStateMachineNewComponent>();
		AiStateMachineGroup aiStateMachineGroup = (component != null) ? component.StateMachineGroup : null;
		AiStateMachineBase aiStateMachineBase = (aiStateMachineGroup != null) ? aiStateMachineGroup.GetNodeByName(this.State) : null;
		return aiStateMachineBase != null && aiStateMachineBase.Activated;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00009FCE File Offset: 0x000081CE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckFsmState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckFsmState.TsDecoratorCheckFsmState_C");
		}
		return TsDecoratorCheckFsmState._ClassPtr;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00009FF4 File Offset: 0x000081F4
	public TsDecoratorCheckFsmState() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckFsmState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000A01C File Offset: 0x0000821C
	public TsDecoratorCheckFsmState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckFsmState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000A04F File Offset: 0x0000824F
	protected TsDecoratorCheckFsmState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000A058 File Offset: 0x00008258
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000152 RID: 338
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckFsmState.TsDecoratorCheckFsmState_C";

	// Token: 0x04000153 RID: 339
	private static IntPtr _ClassPtr;

	// Token: 0x04000154 RID: 340
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000155 RID: 341
	private static int __PropertyOffset_State;
}

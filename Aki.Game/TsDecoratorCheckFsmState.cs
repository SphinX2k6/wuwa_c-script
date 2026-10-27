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
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x00009ADF File Offset: 0x00007CDF
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x00009AF3 File Offset: 0x00007CF3
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

	// Token: 0x060001FA RID: 506 RVA: 0x00009B08 File Offset: 0x00007D08
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

	// Token: 0x060001FB RID: 507 RVA: 0x00009BA8 File Offset: 0x00007DA8
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

	// Token: 0x060001FC RID: 508 RVA: 0x00009C32 File Offset: 0x00007E32
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckFsmState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckFsmState.TsDecoratorCheckFsmState_C");
		}
		return TsDecoratorCheckFsmState._ClassPtr;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00009C58 File Offset: 0x00007E58
	public TsDecoratorCheckFsmState() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckFsmState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00009C80 File Offset: 0x00007E80
	public TsDecoratorCheckFsmState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckFsmState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00009CB3 File Offset: 0x00007EB3
	protected TsDecoratorCheckFsmState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00009CBC File Offset: 0x00007EBC
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

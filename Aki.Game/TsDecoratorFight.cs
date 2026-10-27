using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000042 RID: 66
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorFight.TsDecoratorFight_C")]
public class TsDecoratorFight : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000274 RID: 628 RVA: 0x0000BAC4 File Offset: 0x00009CC4
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

	// Token: 0x06000275 RID: 629 RVA: 0x0000BB64 File Offset: 0x00009D64
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		bool? flag;
		if (aiController == null)
		{
			flag = null;
		}
		else
		{
			EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
			flag = ((currentTarget != null) ? new bool?(currentTarget.Valid) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0000BBB6 File Offset: 0x00009DB6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorFight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorFight.TsDecoratorFight_C");
		}
		return TsDecoratorFight._ClassPtr;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0000BBDC File Offset: 0x00009DDC
	public TsDecoratorFight() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorFight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000BC04 File Offset: 0x00009E04
	[NullableContext(1)]
	public TsDecoratorFight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorFight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0000BC37 File Offset: 0x00009E37
	protected TsDecoratorFight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0000BC40 File Offset: 0x00009E40
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001A0 RID: 416
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorFight.TsDecoratorFight_C";

	// Token: 0x040001A1 RID: 417
	private static IntPtr _ClassPtr;

	// Token: 0x040001A2 RID: 418
	private static IntPtr _ClassDefaultObjectPtr;
}

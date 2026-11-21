using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200004F RID: 79
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorSightReachTarget.TsDecoratorSightReachTarget_C")]
public class TsDecoratorSightReachTarget : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060002FB RID: 763 RVA: 0x0000E17F File Offset: 0x0000C37F
	// (set) Token: 0x060002FC RID: 764 RVA: 0x0000E18F File Offset: 0x0000C38F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ToleranceDegree
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorSightReachTarget.__PropertyOffset_ToleranceDegree);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorSightReachTarget.__PropertyOffset_ToleranceDegree) = value;
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorSightReachTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorSightReachTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x060002FE RID: 766 RVA: 0x0000E258 File Offset: 0x0000C458
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			return false;
		}
		CharacterAnimationComponent component = charActorComp.Entity.GetComponent<CharacterAnimationComponent>();
		return component != null && component.Valid && component.IsSightDirectReachTarget(this.ToleranceDegree);
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0000E2F7 File Offset: 0x0000C4F7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorSightReachTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorSightReachTarget.TsDecoratorSightReachTarget_C");
		}
		return TsDecoratorSightReachTarget._ClassPtr;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0000E31C File Offset: 0x0000C51C
	public TsDecoratorSightReachTarget() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSightReachTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0000E344 File Offset: 0x0000C544
	[NullableContext(1)]
	public TsDecoratorSightReachTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSightReachTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0000E377 File Offset: 0x0000C577
	protected TsDecoratorSightReachTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0000E380 File Offset: 0x0000C580
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001F4 RID: 500
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorSightReachTarget.TsDecoratorSightReachTarget_C";

	// Token: 0x040001F5 RID: 501
	private static IntPtr _ClassPtr;

	// Token: 0x040001F6 RID: 502
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001F7 RID: 503
	private static int __PropertyOffset_ToleranceDegree;
}

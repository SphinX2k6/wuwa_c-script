using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200003A RID: 58
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInPlot.TsDecoratorCheckInPlot_C")]
public class TsDecoratorCheckInPlot : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000215 RID: 533 RVA: 0x0000A793 File Offset: 0x00008993
	// (set) Token: 0x06000216 RID: 534 RVA: 0x0000A7A7 File Offset: 0x000089A7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string PlotName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorCheckInPlot.__PropertyOffset_PlotName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorCheckInPlot.__PropertyOffset_PlotName)), value);
		}
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000A7BC File Offset: 0x000089BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckInPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckInPlot.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000218 RID: 536 RVA: 0x0000A874 File Offset: 0x00008A74
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		string text = this.PlotName.Trim();
		if (text == string.Empty)
		{
			return true;
		}
		string flowName = FlowController.Instance.GetFlowName();
		return !(flowName == string.Empty) && flowName == text;
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000A8BD File Offset: 0x00008ABD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckInPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInPlot.TsDecoratorCheckInPlot_C");
		}
		return TsDecoratorCheckInPlot._ClassPtr;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000A8E4 File Offset: 0x00008AE4
	public TsDecoratorCheckInPlot() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000A90C File Offset: 0x00008B0C
	public TsDecoratorCheckInPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000A93F File Offset: 0x00008B3F
	protected TsDecoratorCheckInPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000A948 File Offset: 0x00008B48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000165 RID: 357
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInPlot.TsDecoratorCheckInPlot_C";

	// Token: 0x04000166 RID: 358
	private static IntPtr _ClassPtr;

	// Token: 0x04000167 RID: 359
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000168 RID: 360
	private static int __PropertyOffset_PlotName;
}

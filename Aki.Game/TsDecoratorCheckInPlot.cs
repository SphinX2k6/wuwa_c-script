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
	// (get) Token: 0x06000215 RID: 533 RVA: 0x0000A36F File Offset: 0x0000856F
	// (set) Token: 0x06000216 RID: 534 RVA: 0x0000A383 File Offset: 0x00008583
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

	// Token: 0x06000217 RID: 535 RVA: 0x0000A398 File Offset: 0x00008598
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

	// Token: 0x06000218 RID: 536 RVA: 0x0000A438 File Offset: 0x00008638
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

	// Token: 0x06000219 RID: 537 RVA: 0x0000A481 File Offset: 0x00008681
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckInPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInPlot.TsDecoratorCheckInPlot_C");
		}
		return TsDecoratorCheckInPlot._ClassPtr;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000A4A8 File Offset: 0x000086A8
	public TsDecoratorCheckInPlot() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000A4D0 File Offset: 0x000086D0
	public TsDecoratorCheckInPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000A503 File Offset: 0x00008703
	protected TsDecoratorCheckInPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000A50C File Offset: 0x0000870C
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

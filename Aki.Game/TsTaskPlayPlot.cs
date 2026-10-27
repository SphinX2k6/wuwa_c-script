using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B1 RID: 177
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayPlot.TsTaskPlayPlot_C")]
public class TsTaskPlayPlot : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000328B1 File Offset: 0x00030AB1
	// (set) Token: 0x06000A0E RID: 2574 RVA: 0x000328C5 File Offset: 0x00030AC5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SeqNetworkId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayPlot.__PropertyOffset_SeqNetworkId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayPlot.__PropertyOffset_SeqNetworkId)), value);
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000328DA File Offset: 0x00030ADA
	// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000328EE File Offset: 0x00030AEE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SeqNetworkRes
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayPlot.__PropertyOffset_SeqNetworkRes)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayPlot.__PropertyOffset_SeqNetworkRes)), value);
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00032903 File Offset: 0x00030B03
	// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00032917 File Offset: 0x00030B17
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string PlotConfigRes
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayPlot.__PropertyOffset_PlotConfigRes)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayPlot.__PropertyOffset_PlotConfigRes)), value);
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003292C File Offset: 0x00030B2C
	// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0003293C File Offset: 0x00030B3C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float WaitTickCount
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayPlot.__PropertyOffset_WaitTickCount);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayPlot.__PropertyOffset_WaitTickCount) = value;
		}
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00032950 File Offset: 0x00030B50
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSeqNetworkId = this.SeqNetworkId;
			this.TsSeqNetworkRes = this.SeqNetworkRes;
			this.TsPlotConfigRes = this.PlotConfigRes;
			this.TsWaitTickCount = (int)this.WaitTickCount;
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x000329A4 File Offset: 0x00030BA4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
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

	// Token: 0x06000A17 RID: 2583 RVA: 0x00032A40 File Offset: 0x00030C40
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		if (((tsAiController != null) ? tsAiController.AiController : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.IsPlotStart = false;
		this.TickRemain = ((this.TsWaitTickCount != 0) ? this.TsWaitTickCount : 5);
		if (!string.IsNullOrEmpty(this.TsPlotConfigRes))
		{
			FlowController.Instance.StartFlowByRes(this.TsPlotConfigRes);
			return;
		}
		if (string.IsNullOrEmpty(this.TsSeqNetworkId) || string.IsNullOrEmpty(this.TsSeqNetworkRes))
		{
			this.IsPlotStart = true;
			base.FinishExecute(true);
		}
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00032B08 File Offset: 0x00030D08
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00032BA8 File Offset: 0x00030DA8
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!this.IsPlotStart)
		{
			this.TickRemain--;
			if (!string.IsNullOrEmpty(this.TsPlotConfigRes) && PlotModel.Instance.IsInPlot)
			{
				this.IsPlotStart = true;
			}
			if (!this.IsPlotStart && this.TickRemain < 1)
			{
				base.FinishExecute(true);
				return;
			}
		}
		else if (!string.IsNullOrEmpty(this.TsPlotConfigRes) && !PlotModel.Instance.IsInPlot)
		{
			base.FinishExecute(true);
		}
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00032C24 File Offset: 0x00030E24
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayPlot.TsTaskPlayPlot_C");
		}
		return TsTaskPlayPlot._ClassPtr;
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00032C48 File Offset: 0x00030E48
	public TsTaskPlayPlot() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00032C70 File Offset: 0x00030E70
	public TsTaskPlayPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00032CA3 File Offset: 0x00030EA3
	protected TsTaskPlayPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00032CD0 File Offset: 0x00030ED0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00032D00 File Offset: 0x00030F00
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040007C1 RID: 1985
	private const int DEFAULT_WAIT_TICK = 5;

	// Token: 0x040007C2 RID: 1986
	private bool IsInitTsVariables;

	// Token: 0x040007C3 RID: 1987
	private string TsSeqNetworkId = "";

	// Token: 0x040007C4 RID: 1988
	private string TsSeqNetworkRes = "";

	// Token: 0x040007C5 RID: 1989
	private string TsPlotConfigRes = "";

	// Token: 0x040007C6 RID: 1990
	private int TsWaitTickCount;

	// Token: 0x040007C7 RID: 1991
	private bool IsPlotStart;

	// Token: 0x040007C8 RID: 1992
	private int TickRemain;

	// Token: 0x040007C9 RID: 1993
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayPlot.TsTaskPlayPlot_C";

	// Token: 0x040007CA RID: 1994
	private static IntPtr _ClassPtr;

	// Token: 0x040007CB RID: 1995
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007CC RID: 1996
	private static int __PropertyOffset_SeqNetworkId;

	// Token: 0x040007CD RID: 1997
	private static int __PropertyOffset_SeqNetworkRes;

	// Token: 0x040007CE RID: 1998
	private static int __PropertyOffset_PlotConfigRes;

	// Token: 0x040007CF RID: 1999
	private static int __PropertyOffset_WaitTickCount;
}

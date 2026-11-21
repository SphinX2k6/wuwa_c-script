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
	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000339D5 File Offset: 0x00031BD5
	// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000339E9 File Offset: 0x00031BE9
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

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000339FE File Offset: 0x00031BFE
	// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00033A12 File Offset: 0x00031C12
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

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00033A27 File Offset: 0x00031C27
	// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00033A3B File Offset: 0x00031C3B
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

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00033A50 File Offset: 0x00031C50
	// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00033A60 File Offset: 0x00031C60
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

	// Token: 0x06000A1B RID: 2587 RVA: 0x00033A74 File Offset: 0x00031C74
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

	// Token: 0x06000A1C RID: 2588 RVA: 0x00033AC8 File Offset: 0x00031CC8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPlayPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPlayPlot.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00033B78 File Offset: 0x00031D78
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

	// Token: 0x06000A1E RID: 2590 RVA: 0x00033C40 File Offset: 0x00031E40
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPlayPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskPlayPlot.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00033CF8 File Offset: 0x00031EF8
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

	// Token: 0x06000A20 RID: 2592 RVA: 0x00033D74 File Offset: 0x00031F74
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayPlot.TsTaskPlayPlot_C");
		}
		return TsTaskPlayPlot._ClassPtr;
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00033D98 File Offset: 0x00031F98
	public TsTaskPlayPlot() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00033DC0 File Offset: 0x00031FC0
	public TsTaskPlayPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00033DF3 File Offset: 0x00031FF3
	protected TsTaskPlayPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00033E20 File Offset: 0x00032020
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00033E50 File Offset: 0x00032050
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040007C9 RID: 1993
	private const int DEFAULT_WAIT_TICK = 5;

	// Token: 0x040007CA RID: 1994
	private bool IsInitTsVariables;

	// Token: 0x040007CB RID: 1995
	private string TsSeqNetworkId = "";

	// Token: 0x040007CC RID: 1996
	private string TsSeqNetworkRes = "";

	// Token: 0x040007CD RID: 1997
	private string TsPlotConfigRes = "";

	// Token: 0x040007CE RID: 1998
	private int TsWaitTickCount;

	// Token: 0x040007CF RID: 1999
	private bool IsPlotStart;

	// Token: 0x040007D0 RID: 2000
	private int TickRemain;

	// Token: 0x040007D1 RID: 2001
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayPlot.TsTaskPlayPlot_C";

	// Token: 0x040007D2 RID: 2002
	private static IntPtr _ClassPtr;

	// Token: 0x040007D3 RID: 2003
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007D4 RID: 2004
	private static int __PropertyOffset_SeqNetworkId;

	// Token: 0x040007D5 RID: 2005
	private static int __PropertyOffset_SeqNetworkRes;

	// Token: 0x040007D6 RID: 2006
	private static int __PropertyOffset_PlotConfigRes;

	// Token: 0x040007D7 RID: 2007
	private static int __PropertyOffset_WaitTickCount;
}

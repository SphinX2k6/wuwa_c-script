using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000068 RID: 104
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskLog.TsTaskLog_C")]
public class TsTaskLog : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000453 RID: 1107 RVA: 0x00014D71 File Offset: 0x00012F71
	// (set) Token: 0x06000454 RID: 1108 RVA: 0x00014D85 File Offset: 0x00012F85
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Level
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskLog.__PropertyOffset_Level)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskLog.__PropertyOffset_Level)), value);
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000455 RID: 1109 RVA: 0x00014D9A File Offset: 0x00012F9A
	// (set) Token: 0x06000456 RID: 1110 RVA: 0x00014DAE File Offset: 0x00012FAE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Content
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskLog.__PropertyOffset_Content)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskLog.__PropertyOffset_Content)), value);
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000457 RID: 1111 RVA: 0x00014DC3 File Offset: 0x00012FC3
	// (set) Token: 0x06000458 RID: 1112 RVA: 0x00014DD3 File Offset: 0x00012FD3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool LogOnTick
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskLog.__PropertyOffset_LogOnTick) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskLog.__PropertyOffset_LogOnTick) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00014DE4 File Offset: 0x00012FE4
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

	// Token: 0x0600045A RID: 1114 RVA: 0x00014E7D File Offset: 0x0001307D
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (string.IsNullOrEmpty(this.Level) || string.IsNullOrEmpty(this.Content))
		{
			base.FinishExecute(false);
			return;
		}
		if (this.LogOnTick)
		{
			return;
		}
		this.PrintLog("Execute");
		base.FinishExecute(true);
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00014EBC File Offset: 0x000130BC
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

	// Token: 0x0600045C RID: 1116 RVA: 0x00014F5C File Offset: 0x0001315C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!this.LogOnTick)
		{
			return;
		}
		this.PrintLog("Tick");
		base.FinishExecute(true);
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00014F7C File Offset: 0x0001317C
	private void PrintLog(string mainContext)
	{
		string level = this.Level;
		if (level == "Warn")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.YJX;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Content", this.Content);
			instance.Warn(module, author, mainContext, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (level == "Info")
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.YJX;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Content", this.Content);
			instance2.Info(module2, author2, mainContext, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		if (!(level == "Error"))
		{
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.BehaviorTree;
		ELogAuthor author3 = ELogAuthor.YJX;
		ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Content", this.Content);
		instance3.Error(module3, author3, mainContext, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00015032 File Offset: 0x00013232
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskLog._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskLog.TsTaskLog_C");
		}
		return TsTaskLog._ClassPtr;
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00015058 File Offset: 0x00013258
	public TsTaskLog() : this(BuiltinUtils.AllocNativeUObject(TsTaskLog.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00015080 File Offset: 0x00013280
	public TsTaskLog(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskLog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x000150B3 File Offset: 0x000132B3
	protected TsTaskLog(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x000150BC File Offset: 0x000132BC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x000150EC File Offset: 0x000132EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040002FC RID: 764
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskLog.TsTaskLog_C";

	// Token: 0x040002FD RID: 765
	private static IntPtr _ClassPtr;

	// Token: 0x040002FE RID: 766
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002FF RID: 767
	private static int __PropertyOffset_Level;

	// Token: 0x04000300 RID: 768
	private static int __PropertyOffset_Content;

	// Token: 0x04000301 RID: 769
	private static int __PropertyOffset_LogOnTick;
}

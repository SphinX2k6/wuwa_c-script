using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008C RID: 140
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetString.TsTaskBlackBoardSetString_C")]
public class TsTaskBlackBoardSetString : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000705 RID: 1797 RVA: 0x00023567 File Offset: 0x00021767
	// (set) Token: 0x06000706 RID: 1798 RVA: 0x0002357B File Offset: 0x0002177B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StringName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringName)), value);
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000707 RID: 1799 RVA: 0x00023590 File Offset: 0x00021790
	// (set) Token: 0x06000708 RID: 1800 RVA: 0x000235A4 File Offset: 0x000217A4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StringValue
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringValue)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringValue)), value);
		}
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x000235BC File Offset: 0x000217BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x0002362C File Offset: 0x0002182C
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsStringName = this.StringName;
			this.TsStringValue = this.StringValue;
		}
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x0002365C File Offset: 0x0002185C
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

	// Token: 0x0600070C RID: 1804 RVA: 0x000236F8 File Offset: 0x000218F8
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
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
		this.InitTsVariables();
		int id = aiController.CharActorComp.Entity.Id;
		BlackboardController.Instance.SetStringValueByEntity(id, this.TsStringName, this.TsStringValue);
		base.FinishExecute(true);
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x0002378B File Offset: 0x0002198B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBlackBoardSetString._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetString.TsTaskBlackBoardSetString_C");
		}
		return TsTaskBlackBoardSetString._ClassPtr;
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x000237B0 File Offset: 0x000219B0
	public TsTaskBlackBoardSetString() : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x000237D8 File Offset: 0x000219D8
	public TsTaskBlackBoardSetString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x0002380B File Offset: 0x00021A0B
	protected TsTaskBlackBoardSetString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x0002382A File Offset: 0x00021A2A
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00023834 File Offset: 0x00021A34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000528 RID: 1320
	private bool IsInitTsVariables;

	// Token: 0x04000529 RID: 1321
	private string TsStringName = "";

	// Token: 0x0400052A RID: 1322
	private string TsStringValue = "";

	// Token: 0x0400052B RID: 1323
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetString.TsTaskBlackBoardSetString_C";

	// Token: 0x0400052C RID: 1324
	private static IntPtr _ClassPtr;

	// Token: 0x0400052D RID: 1325
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400052E RID: 1326
	private static int __PropertyOffset_StringName;

	// Token: 0x0400052F RID: 1327
	private static int __PropertyOffset_StringValue;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008F RID: 143
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeInteractionState.TsTaskChangeInteractionState_C")]
public class TsTaskChangeInteractionState : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000737 RID: 1847 RVA: 0x0002509D File Offset: 0x0002329D
	// (set) Token: 0x06000738 RID: 1848 RVA: 0x000250AD File Offset: 0x000232AD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool InteractionState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeInteractionState.__PropertyOffset_InteractionState) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeInteractionState.__PropertyOffset_InteractionState) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x000250C0 File Offset: 0x000232C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeInteractionState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskChangeInteractionState.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00025119 File Offset: 0x00023319
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsInteractionState = this.InteractionState;
		}
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00025140 File Offset: 0x00023340
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeInteractionState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskChangeInteractionState.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600073C RID: 1852 RVA: 0x000251F0 File Offset: 0x000233F0
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		PawnInteractNewComponent component = aiController.CharActorComp.Entity.GetComponent<PawnInteractNewComponent>();
		if (component == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.CJH;
			string message2 = "实体交互组件无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", aiController.CharActorComp.CreatureData.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", aiController.CharActorComp.CreatureData.GetPbDataId());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.FinishExecute(true);
			return;
		}
		component.SetInteractionState(this.TsInteractionState, "TsTaskChangeInteractionState ReceiveExecuteAI");
		base.FinishExecute(true);
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00025308 File Offset: 0x00023508
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeInteractionState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeInteractionState.TsTaskChangeInteractionState_C");
		}
		return TsTaskChangeInteractionState._ClassPtr;
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x0002532C File Offset: 0x0002352C
	public TsTaskChangeInteractionState() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeInteractionState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00025354 File Offset: 0x00023554
	[NullableContext(1)]
	public TsTaskChangeInteractionState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeInteractionState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00025387 File Offset: 0x00023587
	protected TsTaskChangeInteractionState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00025390 File Offset: 0x00023590
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00025398 File Offset: 0x00023598
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400054F RID: 1359
	private bool IsInitTsVariables;

	// Token: 0x04000550 RID: 1360
	private bool TsInteractionState;

	// Token: 0x04000551 RID: 1361
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeInteractionState.TsTaskChangeInteractionState_C";

	// Token: 0x04000552 RID: 1362
	private static IntPtr _ClassPtr;

	// Token: 0x04000553 RID: 1363
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000554 RID: 1364
	private static int __PropertyOffset_InteractionState;
}

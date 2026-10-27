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
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000733 RID: 1843 RVA: 0x00024385 File Offset: 0x00022585
	// (set) Token: 0x06000734 RID: 1844 RVA: 0x00024395 File Offset: 0x00022595
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

	// Token: 0x06000735 RID: 1845 RVA: 0x000243A8 File Offset: 0x000225A8
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

	// Token: 0x06000736 RID: 1846 RVA: 0x00024418 File Offset: 0x00022618
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsInteractionState = this.InteractionState;
		}
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x0002443C File Offset: 0x0002263C
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

	// Token: 0x06000738 RID: 1848 RVA: 0x000244D8 File Offset: 0x000226D8
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

	// Token: 0x06000739 RID: 1849 RVA: 0x000245F0 File Offset: 0x000227F0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeInteractionState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeInteractionState.TsTaskChangeInteractionState_C");
		}
		return TsTaskChangeInteractionState._ClassPtr;
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00024614 File Offset: 0x00022814
	public TsTaskChangeInteractionState() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeInteractionState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x0002463C File Offset: 0x0002283C
	[NullableContext(1)]
	public TsTaskChangeInteractionState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeInteractionState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x0002466F File Offset: 0x0002286F
	protected TsTaskChangeInteractionState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00024678 File Offset: 0x00022878
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00024680 File Offset: 0x00022880
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400054B RID: 1355
	private bool IsInitTsVariables;

	// Token: 0x0400054C RID: 1356
	private bool TsInteractionState;

	// Token: 0x0400054D RID: 1357
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeInteractionState.TsTaskChangeInteractionState_C";

	// Token: 0x0400054E RID: 1358
	private static IntPtr _ClassPtr;

	// Token: 0x0400054F RID: 1359
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000550 RID: 1360
	private static int __PropertyOffset_InteractionState;
}

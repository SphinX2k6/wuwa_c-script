using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000097 RID: 151
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskExecuteEvent.TsTaskExecuteEvent_C")]
public class TsTaskExecuteEvent : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060007BE RID: 1982 RVA: 0x00027543 File Offset: 0x00025743
	// (set) Token: 0x060007BF RID: 1983 RVA: 0x00027553 File Offset: 0x00025753
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EventGroupId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskExecuteEvent.__PropertyOffset_EventGroupId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskExecuteEvent.__PropertyOffset_EventGroupId) = value;
		}
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00027564 File Offset: 0x00025764
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
		}
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x0002757C File Offset: 0x0002577C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskExecuteEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskExecuteEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x060007C2 RID: 1986 RVA: 0x0002762C File Offset: 0x0002582C
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
		base.FinishExecute(true);
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00027695 File Offset: 0x00025895
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskExecuteEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskExecuteEvent.TsTaskExecuteEvent_C");
		}
		return TsTaskExecuteEvent._ClassPtr;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x000276BC File Offset: 0x000258BC
	public TsTaskExecuteEvent() : this(BuiltinUtils.AllocNativeUObject(TsTaskExecuteEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x000276E4 File Offset: 0x000258E4
	[NullableContext(1)]
	public TsTaskExecuteEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskExecuteEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00027717 File Offset: 0x00025917
	protected TsTaskExecuteEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00027720 File Offset: 0x00025920
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005AF RID: 1455
	private bool IsInitTsVariables;

	// Token: 0x040005B0 RID: 1456
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskExecuteEvent.TsTaskExecuteEvent_C";

	// Token: 0x040005B1 RID: 1457
	private static IntPtr _ClassPtr;

	// Token: 0x040005B2 RID: 1458
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005B3 RID: 1459
	private static int __PropertyOffset_EventGroupId;
}

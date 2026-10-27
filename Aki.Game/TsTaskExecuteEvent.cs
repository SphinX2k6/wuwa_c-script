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
	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060007BA RID: 1978 RVA: 0x00026793 File Offset: 0x00024993
	// (set) Token: 0x060007BB RID: 1979 RVA: 0x000267A3 File Offset: 0x000249A3
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

	// Token: 0x060007BC RID: 1980 RVA: 0x000267B4 File Offset: 0x000249B4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
		}
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x000267CC File Offset: 0x000249CC
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

	// Token: 0x060007BE RID: 1982 RVA: 0x00026868 File Offset: 0x00024A68
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

	// Token: 0x060007BF RID: 1983 RVA: 0x000268D1 File Offset: 0x00024AD1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskExecuteEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskExecuteEvent.TsTaskExecuteEvent_C");
		}
		return TsTaskExecuteEvent._ClassPtr;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x000268F8 File Offset: 0x00024AF8
	public TsTaskExecuteEvent() : this(BuiltinUtils.AllocNativeUObject(TsTaskExecuteEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00026920 File Offset: 0x00024B20
	[NullableContext(1)]
	public TsTaskExecuteEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskExecuteEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00026953 File Offset: 0x00024B53
	protected TsTaskExecuteEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x0002695C File Offset: 0x00024B5C
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005AB RID: 1451
	private bool IsInitTsVariables;

	// Token: 0x040005AC RID: 1452
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskExecuteEvent.TsTaskExecuteEvent_C";

	// Token: 0x040005AD RID: 1453
	private static IntPtr _ClassPtr;

	// Token: 0x040005AE RID: 1454
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005AF RID: 1455
	private static int __PropertyOffset_EventGroupId;
}

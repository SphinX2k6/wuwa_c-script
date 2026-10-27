using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000092 RID: 146
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangePatrol.TsTaskChangePatrol_C")]
public class TsTaskChangePatrol : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000757 RID: 1879 RVA: 0x00024C4D File Offset: 0x00022E4D
	// (set) Token: 0x06000758 RID: 1880 RVA: 0x00024C5D File Offset: 0x00022E5D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int PatrolIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangePatrol.__PropertyOffset_PatrolIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangePatrol.__PropertyOffset_PatrolIndex) = value;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000759 RID: 1881 RVA: 0x00024C6E File Offset: 0x00022E6E
	// (set) Token: 0x0600075A RID: 1882 RVA: 0x00024C82 File Offset: 0x00022E82
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string PatrolIdBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskChangePatrol.__PropertyOffset_PatrolIdBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskChangePatrol.__PropertyOffset_PatrolIdBlackboardKey)), value);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00024C97 File Offset: 0x00022E97
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsPatrolIndex = this.PatrolIndex;
			this.TsPatrolIdBlackboardKey = this.PatrolIdBlackboardKey;
		}
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00024CC8 File Offset: 0x00022EC8
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

	// Token: 0x0600075D RID: 1885 RVA: 0x00024D64 File Offset: 0x00022F64
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
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
		int id = aiController.CharActorComp.Entity.Id;
		AiPatrolController aiPatrol = aiController.AiPatrol;
		if (this.TsPatrolIdBlackboardKey != "")
		{
			aiPatrol.ResetPatrolById(BlackboardController.Instance.GetIntValueByEntity(id, this.TsPatrolIdBlackboardKey).Value);
		}
		else
		{
			aiPatrol.ResetPatrol(this.TsPatrolIndex);
		}
		base.FinishExecute(true);
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00024E28 File Offset: 0x00023028
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangePatrol._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangePatrol.TsTaskChangePatrol_C");
		}
		return TsTaskChangePatrol._ClassPtr;
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00024E4C File Offset: 0x0002304C
	public TsTaskChangePatrol() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangePatrol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00024E74 File Offset: 0x00023074
	public TsTaskChangePatrol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangePatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00024EA7 File Offset: 0x000230A7
	protected TsTaskChangePatrol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00024EBC File Offset: 0x000230BC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400055F RID: 1375
	private bool IsInitTsVariables;

	// Token: 0x04000560 RID: 1376
	private int TsPatrolIndex;

	// Token: 0x04000561 RID: 1377
	private string TsPatrolIdBlackboardKey = "";

	// Token: 0x04000562 RID: 1378
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangePatrol.TsTaskChangePatrol_C";

	// Token: 0x04000563 RID: 1379
	private static IntPtr _ClassPtr;

	// Token: 0x04000564 RID: 1380
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000565 RID: 1381
	private static int __PropertyOffset_PatrolIndex;

	// Token: 0x04000566 RID: 1382
	private static int __PropertyOffset_PatrolIdBlackboardKey;
}

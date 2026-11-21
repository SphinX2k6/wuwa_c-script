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
	// Token: 0x17000127 RID: 295
	// (get) Token: 0x0600075B RID: 1883 RVA: 0x00025975 File Offset: 0x00023B75
	// (set) Token: 0x0600075C RID: 1884 RVA: 0x00025985 File Offset: 0x00023B85
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

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x0600075D RID: 1885 RVA: 0x00025996 File Offset: 0x00023B96
	// (set) Token: 0x0600075E RID: 1886 RVA: 0x000259AA File Offset: 0x00023BAA
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

	// Token: 0x0600075F RID: 1887 RVA: 0x000259BF File Offset: 0x00023BBF
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsPatrolIndex = this.PatrolIndex;
			this.TsPatrolIdBlackboardKey = this.PatrolIdBlackboardKey;
		}
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x000259F0 File Offset: 0x00023BF0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangePatrol) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskChangePatrol.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000761 RID: 1889 RVA: 0x00025AA0 File Offset: 0x00023CA0
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

	// Token: 0x06000762 RID: 1890 RVA: 0x00025B64 File Offset: 0x00023D64
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangePatrol._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangePatrol.TsTaskChangePatrol_C");
		}
		return TsTaskChangePatrol._ClassPtr;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00025B88 File Offset: 0x00023D88
	public TsTaskChangePatrol() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangePatrol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00025BB0 File Offset: 0x00023DB0
	public TsTaskChangePatrol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangePatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00025BE3 File Offset: 0x00023DE3
	protected TsTaskChangePatrol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00025BF8 File Offset: 0x00023DF8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000563 RID: 1379
	private bool IsInitTsVariables;

	// Token: 0x04000564 RID: 1380
	private int TsPatrolIndex;

	// Token: 0x04000565 RID: 1381
	private string TsPatrolIdBlackboardKey = "";

	// Token: 0x04000566 RID: 1382
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangePatrol.TsTaskChangePatrol_C";

	// Token: 0x04000567 RID: 1383
	private static IntPtr _ClassPtr;

	// Token: 0x04000568 RID: 1384
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000569 RID: 1385
	private static int __PropertyOffset_PatrolIndex;

	// Token: 0x0400056A RID: 1386
	private static int __PropertyOffset_PatrolIdBlackboardKey;
}

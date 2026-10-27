using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200006F RID: 111
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolStateReset.TsTaskPatrolStateReset_C")]
public class TsTaskPatrolStateReset : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00017DD7 File Offset: 0x00015FD7
	// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00017DE7 File Offset: 0x00015FE7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SplineId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolStateReset.__PropertyOffset_SplineId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolStateReset.__PropertyOffset_SplineId) = value;
		}
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00017DF8 File Offset: 0x00015FF8
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

	// Token: 0x060004F7 RID: 1271 RVA: 0x00017E94 File Offset: 0x00016094
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
			base.FinishExecute(true);
			return;
		}
		string stringValueByEntity = BlackboardController.Instance.GetStringValueByEntity(aiController.CharAiDesignComp.Entity.Id, "PATROL_STATE");
		if (stringValueByEntity == null || !stringValueByEntity.EndsWith(this.SplineId.ToString()) || stringValueByEntity == "PATROL_COMPLETE")
		{
			string patrolStateName = BehaviorTreeDefines.GetPatrolStateName(this.SplineId);
			BlackboardController.Instance.SetStringValueByEntity(aiController.CharAiDesignComp.Entity.Id, "PATROL_STATE", patrolStateName);
		}
		base.FinishExecute(true);
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00017F74 File Offset: 0x00016174
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolStateReset._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolStateReset.TsTaskPatrolStateReset_C");
		}
		return TsTaskPatrolStateReset._ClassPtr;
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00017F98 File Offset: 0x00016198
	public TsTaskPatrolStateReset() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolStateReset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00017FC0 File Offset: 0x000161C0
	[NullableContext(1)]
	public TsTaskPatrolStateReset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolStateReset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00017FF3 File Offset: 0x000161F3
	protected TsTaskPatrolStateReset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00017FFC File Offset: 0x000161FC
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400038F RID: 911
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolStateReset.TsTaskPatrolStateReset_C";

	// Token: 0x04000390 RID: 912
	private static IntPtr _ClassPtr;

	// Token: 0x04000391 RID: 913
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000392 RID: 914
	private static int __PropertyOffset_SplineId;
}

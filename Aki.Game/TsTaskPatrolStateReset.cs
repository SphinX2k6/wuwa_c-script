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
	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00018793 File Offset: 0x00016993
	// (set) Token: 0x060004F7 RID: 1271 RVA: 0x000187A3 File Offset: 0x000169A3
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

	// Token: 0x060004F8 RID: 1272 RVA: 0x000187B4 File Offset: 0x000169B4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPatrolStateReset) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPatrolStateReset.StaticClass(), out intPtr, out num))
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

	// Token: 0x060004F9 RID: 1273 RVA: 0x00018864 File Offset: 0x00016A64
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

	// Token: 0x060004FA RID: 1274 RVA: 0x00018944 File Offset: 0x00016B44
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolStateReset._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolStateReset.TsTaskPatrolStateReset_C");
		}
		return TsTaskPatrolStateReset._ClassPtr;
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00018968 File Offset: 0x00016B68
	public TsTaskPatrolStateReset() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolStateReset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00018990 File Offset: 0x00016B90
	[NullableContext(1)]
	public TsTaskPatrolStateReset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolStateReset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x000189C3 File Offset: 0x00016BC3
	protected TsTaskPatrolStateReset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x000189CC File Offset: 0x00016BCC
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000391 RID: 913
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolStateReset.TsTaskPatrolStateReset_C";

	// Token: 0x04000392 RID: 914
	private static IntPtr _ClassPtr;

	// Token: 0x04000393 RID: 915
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000394 RID: 916
	private static int __PropertyOffset_SplineId;
}

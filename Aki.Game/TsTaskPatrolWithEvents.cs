using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000070 RID: 112
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolWithEvents.TsTaskPatrolWithEvents_C")]
public class TsTaskPatrolWithEvents : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060004FF RID: 1279 RVA: 0x000189F9 File Offset: 0x00016BF9
	// (set) Token: 0x06000500 RID: 1280 RVA: 0x00018A09 File Offset: 0x00016C09
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseLastMoveIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_UseLastMoveIndex) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_UseLastMoveIndex) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x00018A1A File Offset: 0x00016C1A
	// (set) Token: 0x06000502 RID: 1282 RVA: 0x00018A2A File Offset: 0x00016C2A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool StartWithNearestPoint
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_StartWithNearestPoint) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_StartWithNearestPoint) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000503 RID: 1283 RVA: 0x00018A3B File Offset: 0x00016C3B
	// (set) Token: 0x06000504 RID: 1284 RVA: 0x00018A4B File Offset: 0x00016C4B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SplineId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_SplineId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_SplineId) = value;
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x00018A5C File Offset: 0x00016C5C
	// (set) Token: 0x06000506 RID: 1286 RVA: 0x00018A6C File Offset: 0x00016C6C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Version
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_Version);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_Version) = value;
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000507 RID: 1287 RVA: 0x00018A7D File Offset: 0x00016C7D
	// (set) Token: 0x06000508 RID: 1288 RVA: 0x00018A8D File Offset: 0x00016C8D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RandomDistanceMin
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_RandomDistanceMin);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_RandomDistanceMin) = value;
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000509 RID: 1289 RVA: 0x00018A9E File Offset: 0x00016C9E
	// (set) Token: 0x0600050A RID: 1290 RVA: 0x00018AAE File Offset: 0x00016CAE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RandomDistanceMax
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_RandomDistanceMax);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolWithEvents.__PropertyOffset_RandomDistanceMax) = value;
		}
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00018AC0 File Offset: 0x00016CC0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsStartWithNearestPoint = this.StartWithNearestPoint;
			this.TsSplineId = this.SplineId;
			this.TsRandomDistanceMin = this.RandomDistanceMin;
			this.TsRandomDistanceMax = this.RandomDistanceMax;
		}
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00018B14 File Offset: 0x00016D14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPatrolWithEvents) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPatrolWithEvents.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600050D RID: 1293 RVA: 0x00018BC4 File Offset: 0x00016DC4
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		Entity entity = aiController.CharAiDesignComp.Entity;
		this.PerformComp = entity.GetComponent<BasePerformComponent>();
		if (this.PerformComp == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (entity.GetComponent<CharacterPatrolComponent>() == null)
		{
			base.FinishExecute(false);
			return;
		}
		int version = this.Version;
		if (version == 0)
		{
			this.ExecuteWithVersion0(entity);
			return;
		}
		if (version != 1)
		{
			base.FinishExecute(false);
			return;
		}
		this.ExecuteWithVersion1(entity);
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00018C8A File Offset: 0x00016E8A
	protected override void OnAbort()
	{
		BasePerformComponent performComp = this.PerformComp;
		if (performComp == null)
		{
			return;
		}
		performComp.PerformStopMove(EPerformMode.Ecology, new IStopMoveParams
		{
			SplineId = this.TsSplineId,
			Context = "PatrolWithEvents",
			Method = new EStopMoveMethod?(EStopMoveMethod.Pause)
		}, null, null);
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00018CC8 File Offset: 0x00016EC8
	protected override void OnClear()
	{
		if (!(base.AIOwner is TsAiController))
		{
			return;
		}
		this.PerformComp = null;
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00018CE0 File Offset: 0x00016EE0
	protected void ExecuteWithVersion0(Entity entity)
	{
		CharacterPatrolComponent patrolComp = entity.GetComponent<CharacterPatrolComponent>();
		Action<int> onArrivePointHandle = delegate(int pIndex)
		{
			BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_POINT_INDEX", pIndex);
		};
		Action<ELevelEventState> onPatrolEndHandle = delegate(ELevelEventState result)
		{
			BlackboardController.Instance.SetStringValueByEntity(entity.Id, "PATROL_STATE", "PATROL_COMPLETE");
			this.Finish(result == ELevelEventState.Success);
		};
		Action<IList<ActionInfo>> onTriggerActionsHandle = delegate(IList<ActionInfo> _)
		{
			int lastPointRawIndex = patrolComp.GetLastPointRawIndex();
			string patrolActionStateName = BehaviorTreeDefines.GetPatrolActionStateName(this.TsSplineId, lastPointRawIndex, false);
			BlackboardController.Instance.SetStringValueByEntity(entity.Id, "PATROL_STATE", patrolActionStateName);
		};
		IStartMoveParams startMoveParams = new IStartMoveParams();
		startMoveParams.SplineId = this.TsSplineId;
		startMoveParams.Context = "PatrolWithEvents";
		startMoveParams.DebugMode = new bool?(false);
		startMoveParams.StartMode = new EPatrolStartMode?(this.TsStartWithNearestPoint ? EPatrolStartMode.NearestPoint : EPatrolStartMode.Default);
		List<double> randomDistanceRange;
		if (this.TsRandomDistanceMin == 0 && this.TsRandomDistanceMax == 0)
		{
			randomDistanceRange = null;
		}
		else
		{
			List<double> list = new List<double>();
			list.Add((double)this.TsRandomDistanceMin);
			randomDistanceRange = list;
			list.Add((double)this.TsRandomDistanceMax);
		}
		startMoveParams.RandomDistanceRange = randomDistanceRange;
		startMoveParams.ReturnFalseWhenNavigationFailed = new bool?(false);
		startMoveParams.OnArrivePointHandle = onArrivePointHandle;
		startMoveParams.OnTriggerActionsHandle = onTriggerActionsHandle;
		startMoveParams.OnPatrolEndHandle = onPatrolEndHandle;
		IStartMoveParams param = startMoveParams;
		this.PerformComp.PerformStartMove(EPerformMode.Ecology, param, null, null);
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00018DE0 File Offset: 0x00016FE0
	protected void ExecuteWithVersion1(Entity entity)
	{
		if (this.TryResumeSplineActions(entity))
		{
			return;
		}
		CharacterPatrolComponent patrolComp = entity.GetComponent<CharacterPatrolComponent>();
		Action<int> onArrivePointHandle = delegate(int pIndex)
		{
			BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_POINT_INDEX", pIndex);
		};
		Action<ELevelEventState> onPatrolEndHandle = delegate(ELevelEventState result)
		{
			BlackboardController.Instance.SetStringValueByEntity(entity.Id, "PATROL_STATE", "PATROL_COMPLETE");
			this.Finish(result == ELevelEventState.Success);
		};
		Action<IList<ActionInfo>> onTriggerActionsHandle = delegate(IList<ActionInfo> _)
		{
			int lastPointRawIndex = patrolComp.GetLastPointRawIndex();
			IList<ActionInfo> pointActions = patrolComp.GetPointActions(lastPointRawIndex);
			BlackboardController.Instance.SetStringValueByEntity(entity.Id, "PATROL_STATE", BehaviorTreeDefines.GetPatrolActionStateName(this.TsSplineId, lastPointRawIndex, true));
			BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_ACTION_INDEX", 1);
			BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_ACTION_TYPE", CommonBtRuntimeHelper.Instance.GetCommonActionNodeId(pointActions[0].Name, true).GetValueOrDefault(-1));
		};
		Action<int> onBeforeExecute = delegate(int _)
		{
			BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_ACTION_INDEX", 0);
		};
		IStartMoveParams param = new IStartMoveParams
		{
			SplineId = this.TsSplineId,
			Context = "PatrolWithEvents",
			DebugMode = new bool?(false),
			StartMode = new EPatrolStartMode?(this.TsStartWithNearestPoint ? EPatrolStartMode.NearestPoint : EPatrolStartMode.Default),
			ReturnFalseWhenNavigationFailed = new bool?(false),
			OnArrivePointHandle = onArrivePointHandle,
			OnTriggerActionsHandle = onTriggerActionsHandle,
			OnPatrolEndHandle = onPatrolEndHandle
		};
		this.PerformComp.PerformStartMove(EPerformMode.Ecology, param, onBeforeExecute, null);
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00018ECC File Offset: 0x000170CC
	protected bool TryResumeSplineActions(Entity entity)
	{
		CharacterPatrolComponent component = entity.GetComponent<CharacterPatrolComponent>();
		if (!component.HasPatrolRecord(new long?((long)this.TsSplineId)))
		{
			return false;
		}
		int lastPointRawIndex = component.GetLastPointRawIndex();
		int valueOrDefault = BlackboardController.Instance.GetIntValueByEntity(entity.Id, "PATROL_ACTION_INDEX").GetValueOrDefault();
		if (valueOrDefault == 0)
		{
			return false;
		}
		IList<ActionInfo> pointActions = component.GetPointActions(lastPointRawIndex);
		int num = (pointActions != null) ? pointActions.Count : 0;
		if (valueOrDefault >= num)
		{
			return false;
		}
		BlackboardController.Instance.SetStringValueByEntity(entity.Id, "PATROL_STATE", BehaviorTreeDefines.GetPatrolActionStateName(this.TsSplineId, lastPointRawIndex, true));
		BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_ACTION_INDEX", valueOrDefault + 1);
		BlackboardController.Instance.SetIntValueByEntity(entity.Id, "PATROL_ACTION_TYPE", CommonBtRuntimeHelper.Instance.GetCommonActionNodeId(pointActions[valueOrDefault].Name, true).GetValueOrDefault(-1));
		return true;
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00018FB1 File Offset: 0x000171B1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolWithEvents._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolWithEvents.TsTaskPatrolWithEvents_C");
		}
		return TsTaskPatrolWithEvents._ClassPtr;
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00018FD8 File Offset: 0x000171D8
	public TsTaskPatrolWithEvents() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00019000 File Offset: 0x00017200
	public TsTaskPatrolWithEvents(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00019033 File Offset: 0x00017233
	protected TsTaskPatrolWithEvents(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0001903C File Offset: 0x0001723C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000395 RID: 917
	[Nullable(2)]
	private BasePerformComponent PerformComp;

	// Token: 0x04000396 RID: 918
	private bool IsInitTsVariables;

	// Token: 0x04000397 RID: 919
	private bool TsStartWithNearestPoint;

	// Token: 0x04000398 RID: 920
	private int TsSplineId;

	// Token: 0x04000399 RID: 921
	private int TsRandomDistanceMin;

	// Token: 0x0400039A RID: 922
	private int TsRandomDistanceMax;

	// Token: 0x0400039B RID: 923
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolWithEvents.TsTaskPatrolWithEvents_C";

	// Token: 0x0400039C RID: 924
	private static IntPtr _ClassPtr;

	// Token: 0x0400039D RID: 925
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400039E RID: 926
	private static int __PropertyOffset_UseLastMoveIndex;

	// Token: 0x0400039F RID: 927
	private static int __PropertyOffset_StartWithNearestPoint;

	// Token: 0x040003A0 RID: 928
	private static int __PropertyOffset_SplineId;

	// Token: 0x040003A1 RID: 929
	private static int __PropertyOffset_Version;

	// Token: 0x040003A2 RID: 930
	private static int __PropertyOffset_RandomDistanceMin;

	// Token: 0x040003A3 RID: 931
	private static int __PropertyOffset_RandomDistanceMax;
}

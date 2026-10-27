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
	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060004FD RID: 1277 RVA: 0x00018029 File Offset: 0x00016229
	// (set) Token: 0x060004FE RID: 1278 RVA: 0x00018039 File Offset: 0x00016239
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

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001804A File Offset: 0x0001624A
	// (set) Token: 0x06000500 RID: 1280 RVA: 0x0001805A File Offset: 0x0001625A
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

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001806B File Offset: 0x0001626B
	// (set) Token: 0x06000502 RID: 1282 RVA: 0x0001807B File Offset: 0x0001627B
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

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000503 RID: 1283 RVA: 0x0001808C File Offset: 0x0001628C
	// (set) Token: 0x06000504 RID: 1284 RVA: 0x0001809C File Offset: 0x0001629C
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

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x000180AD File Offset: 0x000162AD
	// (set) Token: 0x06000506 RID: 1286 RVA: 0x000180BD File Offset: 0x000162BD
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

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000507 RID: 1287 RVA: 0x000180CE File Offset: 0x000162CE
	// (set) Token: 0x06000508 RID: 1288 RVA: 0x000180DE File Offset: 0x000162DE
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

	// Token: 0x06000509 RID: 1289 RVA: 0x000180F0 File Offset: 0x000162F0
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

	// Token: 0x0600050A RID: 1290 RVA: 0x00018144 File Offset: 0x00016344
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

	// Token: 0x0600050B RID: 1291 RVA: 0x000181E0 File Offset: 0x000163E0
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

	// Token: 0x0600050C RID: 1292 RVA: 0x000182A6 File Offset: 0x000164A6
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

	// Token: 0x0600050D RID: 1293 RVA: 0x000182E4 File Offset: 0x000164E4
	protected override void OnClear()
	{
		if (!(base.AIOwner is TsAiController))
		{
			return;
		}
		this.PerformComp = null;
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x000182FC File Offset: 0x000164FC
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

	// Token: 0x0600050F RID: 1295 RVA: 0x000183FC File Offset: 0x000165FC
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

	// Token: 0x06000510 RID: 1296 RVA: 0x000184E8 File Offset: 0x000166E8
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

	// Token: 0x06000511 RID: 1297 RVA: 0x000185CD File Offset: 0x000167CD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolWithEvents._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolWithEvents.TsTaskPatrolWithEvents_C");
		}
		return TsTaskPatrolWithEvents._ClassPtr;
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x000185F4 File Offset: 0x000167F4
	public TsTaskPatrolWithEvents() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001861C File Offset: 0x0001681C
	public TsTaskPatrolWithEvents(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0001864F File Offset: 0x0001684F
	protected TsTaskPatrolWithEvents(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00018658 File Offset: 0x00016858
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000393 RID: 915
	[Nullable(2)]
	private BasePerformComponent PerformComp;

	// Token: 0x04000394 RID: 916
	private bool IsInitTsVariables;

	// Token: 0x04000395 RID: 917
	private bool TsStartWithNearestPoint;

	// Token: 0x04000396 RID: 918
	private int TsSplineId;

	// Token: 0x04000397 RID: 919
	private int TsRandomDistanceMin;

	// Token: 0x04000398 RID: 920
	private int TsRandomDistanceMax;

	// Token: 0x04000399 RID: 921
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPatrolWithEvents.TsTaskPatrolWithEvents_C";

	// Token: 0x0400039A RID: 922
	private static IntPtr _ClassPtr;

	// Token: 0x0400039B RID: 923
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400039C RID: 924
	private static int __PropertyOffset_UseLastMoveIndex;

	// Token: 0x0400039D RID: 925
	private static int __PropertyOffset_StartWithNearestPoint;

	// Token: 0x0400039E RID: 926
	private static int __PropertyOffset_SplineId;

	// Token: 0x0400039F RID: 927
	private static int __PropertyOffset_Version;

	// Token: 0x040003A0 RID: 928
	private static int __PropertyOffset_RandomDistanceMin;

	// Token: 0x040003A1 RID: 929
	private static int __PropertyOffset_RandomDistanceMax;
}

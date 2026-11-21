using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using Google.Protobuf;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000AA RID: 170
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrol.TsTaskPatrol_C")]
public class TsTaskPatrol : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000955 RID: 2389 RVA: 0x0003013C File Offset: 0x0002E33C
	// (set) Token: 0x06000956 RID: 2390 RVA: 0x0003014C File Offset: 0x0002E34C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000957 RID: 2391 RVA: 0x0003015D File Offset: 0x0002E35D
	// (set) Token: 0x06000958 RID: 2392 RVA: 0x0003016D File Offset: 0x0002E36D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MoveOnePath
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_MoveOnePath) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_MoveOnePath) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000959 RID: 2393 RVA: 0x0003017E File Offset: 0x0002E37E
	// (set) Token: 0x0600095A RID: 2394 RVA: 0x0003018E File Offset: 0x0002E38E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseSimpleMove
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_UseSimpleMove) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_UseSimpleMove) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600095B RID: 2395 RVA: 0x0003019F File Offset: 0x0002E39F
	// (set) Token: 0x0600095C RID: 2396 RVA: 0x000301AF File Offset: 0x0002E3AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseActorForward
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_UseActorForward) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_UseActorForward) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x0600095D RID: 2397 RVA: 0x000301C0 File Offset: 0x0002E3C0
	// (set) Token: 0x0600095E RID: 2398 RVA: 0x000301D0 File Offset: 0x0002E3D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseLastMoveIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_UseLastMoveIndex) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_UseLastMoveIndex) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x0600095F RID: 2399 RVA: 0x000301E1 File Offset: 0x0002E3E1
	// (set) Token: 0x06000960 RID: 2400 RVA: 0x000301F1 File Offset: 0x0002E3F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OpenDebugNode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_OpenDebugNode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrol.__PropertyOffset_OpenDebugNode) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00030204 File Offset: 0x0002E404
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveState = this.MoveState;
			this.TsMoveOnePath = this.MoveOnePath;
			this.TsUseLastMoveIndex = this.UseLastMoveIndex;
			this.TsOpenDebugNode = this.OpenDebugNode;
		}
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00030258 File Offset: 0x0002E458
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPatrol) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPatrol.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000963 RID: 2403 RVA: 0x00030308 File Offset: 0x0002E508
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
		this.PatrolLogic = aiController.AiPatrol;
		this.PatrolConfig = this.PatrolLogic.GetConfig();
		if (this.PatrolConfig == null)
		{
			base.Finish(false);
			return;
		}
		this.Entity = aiController.CharAiDesignComp.Entity;
		this.MoveComp = this.Entity.GetComponent<BaseMoveComponent>();
		this.StateComp = this.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.ActorComp = aiController.CharActorComp;
		if (this.PatrolConfig.ContainZ)
		{
			CharacterActorComponent charActorComp = aiController.CharActorComp;
			if (charActorComp != null)
			{
				charActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Flying,
					Context = "[TsTaskPatrol.ReceiveExecuteAI]"
				});
			}
		}
		if (this.HandleMoveEnd == null)
		{
			this.HandleMoveEnd = new Action<ELevelEventState>(this.ExecuteMoveEnd);
		}
		this.InitPatrolInfo();
		AiPatrolController patrolLogic = this.PatrolLogic;
		if (((patrolLogic != null) ? patrolLogic.PatrolPoint : null) == null)
		{
			base.Finish(false);
			return;
		}
		EntityPatrolStartRequest entityPatrolStartRequest = EntityPatrolStartRequest.Create();
		entityPatrolStartRequest.EntityId = MathUtils.Instance.NumberToLong(aiController.CharActorComp.CreatureData.GetCreatureDataId());
		entityPatrolStartRequest.Dir = !this.PatrolLogic.StartWithInversePath.GetValueOrDefault();
		this.PatrolStopPending = true;
		Net.Instance.Call(ERequestMessageId.EntityPatrolStartRequest, entityPatrolStartRequest, delegate(IMessage _, Net.CallbackStatus _)
		{
		}, 0);
		this.MoveToPatrolPoint();
		if (aiController.AiPatrol.StartWithInversePath != null)
		{
			aiController.AiPatrol.StartWithInversePath = null;
		}
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x000304F0 File Offset: 0x0002E6F0
	private void CallOutside()
	{
		if (GlobalData.BpEventManager == null)
		{
			return;
		}
		AiPatrolController patrolLogic = this.PatrolLogic;
		PatrolPoint patrolPoint = (patrolLogic != null) ? patrolLogic.PatrolPoint : null;
		if (patrolPoint == null)
		{
			return;
		}
		if (!patrolPoint.IsMain)
		{
			return;
		}
		GlobalData.BpEventManager.AI巡逻达到样条点.Broadcast(this.ActorComp.Actor, this.PatrolLogic.PatrolIndex);
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x0003054C File Offset: 0x0002E74C
	private void InitPatrolInfo()
	{
		this.PatrolLogic.GeneratePatrol(true);
		this.PatrolLogic.StartPatrol(this.TsUseLastMoveIndex, new Action(this.CallOutside));
		this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.TsMoveState);
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x000305A0 File Offset: 0x0002E7A0
	private void MoveToPatrolPoint()
	{
		TsTaskPatrol.<>c__DisplayClass37_0 CS$<>8__locals1 = new TsTaskPatrol.<>c__DisplayClass37_0();
		CS$<>8__locals1.<>4__this = this;
		TsTaskPatrol.<>c__DisplayClass37_0 CS$<>8__locals2 = CS$<>8__locals1;
		AiPatrolController patrolLogic = this.PatrolLogic;
		CS$<>8__locals2.curPoint = ((patrolLogic != null) ? patrolLogic.PatrolPoint : null);
		if (CS$<>8__locals1.curPoint == null)
		{
			return;
		}
		List<MoveCharacterPoint> list = new List<MoveCharacterPoint>();
		int num = 0;
		for (int i = 0; i < this.PatrolLogic.AllPatrolPoints.Count; i++)
		{
			PatrolPoint patrolPoint = this.PatrolLogic.AllPatrolPoints[i];
			int currentIndex = i;
			MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
			{
				Index = (patrolPoint.IsMain ? num : -1),
				Position = patrolPoint.Point,
				MoveState = new EPatrolMoveState?((EPatrolMoveState)patrolPoint.MoveState),
				MoveSpeed = new float?(patrolPoint.MoveSpeed),
				Actions = patrolPoint.Actions,
				Callback = delegate()
				{
					CS$<>8__locals1.<>4__this.PatrolLogic.SetPatrolIndex(currentIndex);
					if (CS$<>8__locals1.curPoint.IsMain)
					{
						CS$<>8__locals1.<>4__this.CallOutside();
					}
				}
			};
			if (patrolPoint.IsMain)
			{
				num++;
			}
			if (moveCharacterPoint.Actions == null)
			{
				moveCharacterPoint.Actions = new List<ActionInfo>();
			}
			list.Add(moveCharacterPoint);
		}
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = list,
			Navigation = this.PatrolConfig.IsNavigation,
			IsFly = this.PatrolConfig.ContainZ,
			DebugMode = this.TsOpenDebugNode,
			Loop = this.PatrolConfig.Loop,
			CircleMove = new bool?(this.PatrolConfig.CirclePatrol),
			StartWithInversePath = this.PatrolLogic.StartWithInversePath,
			Distance = new float?(this.PatrolConfig.EndDistance),
			TurnSpeed = new float?(this.PatrolConfig.TurnSpeed),
			Callback = delegate(ELevelEventState result)
			{
				if (result == ELevelEventState.Success)
				{
					CS$<>8__locals1.<>4__this.PatrolFinish();
				}
				CS$<>8__locals1.<>4__this.Finish(true);
			},
			UsePreviousIndex = new bool?(this.UseLastMoveIndex),
			UseNearestPoint = new bool?(this.UseLastMoveIndex),
			ReturnFalseWhenNavigationFailed = false
		};
		this.TsMoveHandleId = this.MoveComp.MoveAlongPath(config, "TsTaskPatrol.MoveToPatrolPoint");
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x000307C0 File Offset: 0x0002E9C0
	private void ExecuteMoveEnd(ELevelEventState result)
	{
		if (result == ELevelEventState.Success)
		{
			AiPatrolController patrolLogic = this.PatrolLogic;
			if (((patrolLogic != null) ? patrolLogic.PatrolPoint : null) == null)
			{
				return;
			}
			PatrolPoint patrolPoint = this.PatrolLogic.PatrolPoint;
			if (this.CheckMoveEnd(patrolPoint))
			{
				this.PatrolFinish();
				base.Finish(true);
				return;
			}
			if (patrolPoint != this.PatrolLogic.PatrolPoint)
			{
				patrolPoint = this.PatrolLogic.PatrolPoint;
				if (patrolPoint == null)
				{
					base.Finish(true);
					return;
				}
				if (patrolPoint.IsMain)
				{
					this.CallOutside();
					this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.TsMoveState);
				}
				this.MoveToPatrolPoint();
				return;
			}
		}
		else
		{
			base.Finish(false);
		}
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x0003086C File Offset: 0x0002EA6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPatrol) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskPatrol.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00030924 File Offset: 0x0002EB24
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00030928 File Offset: 0x0002EB28
	[NullableContext(1)]
	private bool CheckMoveEnd(PatrolPoint curPoint)
	{
		bool result = this.PatrolLogic.CheckPatrolEnd();
		if (curPoint.IsMain)
		{
			if (this.TsMoveOnePath && !curPoint.IsIgnorePoint)
			{
				result = true;
			}
			if (curPoint.Actions != null)
			{
				LevelGeneralController.Instance.ExecuteActionsNew(curPoint.Actions, EntityContext.Create(this.Entity.Id, null), null);
			}
		}
		return result;
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x0003098E File Offset: 0x0002EB8E
	private void PatrolFinish()
	{
		this.CallOutside();
		AiPatrolController patrolLogic = this.PatrolLogic;
		if (patrolLogic == null)
		{
			return;
		}
		patrolLogic.PatrolFinish();
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x000309A6 File Offset: 0x0002EBA6
	protected override void OnAbort()
	{
		this.PatrolFinish();
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.StopMoveByHandleId(this.TsMoveHandleId, "TsTaskPatrol.OnAbort");
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x000309CC File Offset: 0x0002EBCC
	protected override void OnClear()
	{
		if (!(base.AIOwner is TsAiController))
		{
			return;
		}
		if (this.PatrolStopPending)
		{
			this.PatrolStopPending = false;
			if (this.Entity != null && this.ActorComp != null && EntitySystem.Instance.Get(this.Entity.Id) != null)
			{
				EntityPatrolStopRequest entityPatrolStopRequest = EntityPatrolStopRequest.Create();
				entityPatrolStopRequest.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
				Net.Instance.Call(ERequestMessageId.EntityPatrolStopRequest, entityPatrolStopRequest, delegate(IMessage _, Net.CallbackStatus _)
				{
				}, 0);
			}
		}
		if (this.MoveComp != null)
		{
			if (this.TsMoveOnePath)
			{
				this.MoveComp.SetForceSpeed(global::Vector.ZeroVectorProxy);
			}
			this.MoveComp.IsSpecialMove = false;
		}
		this.Entity = null;
		this.ActorComp = null;
		this.MoveComp = null;
		this.StateComp = null;
		this.PatrolLogic = null;
		this.PatrolConfig = null;
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00030ACC File Offset: 0x0002ECCC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrol._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrol.TsTaskPatrol_C");
		}
		return TsTaskPatrol._ClassPtr;
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00030AF0 File Offset: 0x0002ECF0
	public TsTaskPatrol() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00030B18 File Offset: 0x0002ED18
	[NullableContext(1)]
	public TsTaskPatrol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00030B4B File Offset: 0x0002ED4B
	protected TsTaskPatrol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00030B54 File Offset: 0x0002ED54
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00030B84 File Offset: 0x0002ED84
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000733 RID: 1843
	private Entity Entity;

	// Token: 0x04000734 RID: 1844
	private CharacterActorComponent ActorComp;

	// Token: 0x04000735 RID: 1845
	private BaseMoveComponent MoveComp;

	// Token: 0x04000736 RID: 1846
	private BaseUnifiedStateComponent StateComp;

	// Token: 0x04000737 RID: 1847
	private AiPatrolController PatrolLogic;

	// Token: 0x04000738 RID: 1848
	private AiPatrolConfig PatrolConfig;

	// Token: 0x04000739 RID: 1849
	private bool IsInitTsVariables;

	// Token: 0x0400073A RID: 1850
	private int TsMoveState;

	// Token: 0x0400073B RID: 1851
	private bool TsMoveOnePath;

	// Token: 0x0400073C RID: 1852
	private bool TsUseLastMoveIndex;

	// Token: 0x0400073D RID: 1853
	private bool TsOpenDebugNode;

	// Token: 0x0400073E RID: 1854
	private int TsMoveHandleId;

	// Token: 0x0400073F RID: 1855
	private Action<ELevelEventState> HandleMoveEnd;

	// Token: 0x04000740 RID: 1856
	private bool PatrolStopPending;

	// Token: 0x04000741 RID: 1857
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrol.TsTaskPatrol_C";

	// Token: 0x04000742 RID: 1858
	private static IntPtr _ClassPtr;

	// Token: 0x04000743 RID: 1859
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000744 RID: 1860
	private static int __PropertyOffset_MoveState;

	// Token: 0x04000745 RID: 1861
	private static int __PropertyOffset_MoveOnePath;

	// Token: 0x04000746 RID: 1862
	private static int __PropertyOffset_UseSimpleMove;

	// Token: 0x04000747 RID: 1863
	private static int __PropertyOffset_UseActorForward;

	// Token: 0x04000748 RID: 1864
	private static int __PropertyOffset_UseLastMoveIndex;

	// Token: 0x04000749 RID: 1865
	private static int __PropertyOffset_OpenDebugNode;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MonsterGroup;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000067 RID: 103
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskEnterPatrolState.TsTaskEnterPatrolState_C")]
public class TsTaskEnterPatrolState : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x000153A9 File Offset: 0x000135A9
	// (set) Token: 0x0600044B RID: 1099 RVA: 0x000153B9 File Offset: 0x000135B9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskEnterPatrolState.__PropertyOffset_EntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskEnterPatrolState.__PropertyOffset_EntityId) = value;
		}
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x000153CC File Offset: 0x000135CC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskEnterPatrolState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskEnterPatrolState.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600044D RID: 1101 RVA: 0x0001547C File Offset: 0x0001367C
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		this.EntityId = charActorComp.Entity.Id;
		this.CheckGroupPatrolAction(0f);
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00015500 File Offset: 0x00013700
	private void CheckGroupPatrolAction(float delta)
	{
		if (this.TimeHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.TimeHandle);
			this.TimeHandle = null;
		}
		MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.EntityId);
		if (monsterInfoByEntityId != null)
		{
			monsterInfoByEntityId.GroupPatrolState = EGroupPatrolState.Ready;
			return;
		}
		this.TimeHandle = TimerSystem.FlowTimeInstance.Delay(new TTimerAction(this.CheckGroupPatrolAction), 1000f, null, null, true, 1f);
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00015574 File Offset: 0x00013774
	protected override void OnAbort()
	{
		MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.EntityId);
		if (monsterInfoByEntityId != null)
		{
			MonsterGroupInfo group = monsterInfoByEntityId.Group;
			if (group != null)
			{
				group.PausePatrol();
			}
			monsterInfoByEntityId.GroupPatrolState = EGroupPatrolState.None;
		}
		if (this.TimeHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.TimeHandle);
		}
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x000155C6 File Offset: 0x000137C6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskEnterPatrolState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskEnterPatrolState.TsTaskEnterPatrolState_C");
		}
		return TsTaskEnterPatrolState._ClassPtr;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x000155EC File Offset: 0x000137EC
	public TsTaskEnterPatrolState() : this(BuiltinUtils.AllocNativeUObject(TsTaskEnterPatrolState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00015614 File Offset: 0x00013814
	[NullableContext(1)]
	public TsTaskEnterPatrolState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskEnterPatrolState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00015647 File Offset: 0x00013847
	protected TsTaskEnterPatrolState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00015650 File Offset: 0x00013850
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002F8 RID: 760
	private const int TRY_CHECK_TIME_INTERVAL = 1000;

	// Token: 0x040002F9 RID: 761
	[Nullable(2)]
	private TimerHandle TimeHandle;

	// Token: 0x040002FA RID: 762
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskEnterPatrolState.TsTaskEnterPatrolState_C";

	// Token: 0x040002FB RID: 763
	private static IntPtr _ClassPtr;

	// Token: 0x040002FC RID: 764
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002FD RID: 765
	private static int __PropertyOffset_EntityId;
}

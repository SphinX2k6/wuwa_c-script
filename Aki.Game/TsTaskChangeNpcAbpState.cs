using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000065 RID: 101
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskChangeNpcAbpState.TsTaskChangeNpcAbpState_C")]
public class TsTaskChangeNpcAbpState : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000437 RID: 1079 RVA: 0x00014ED5 File Offset: 0x000130D5
	// (set) Token: 0x06000438 RID: 1080 RVA: 0x00014EE5 File Offset: 0x000130E5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeNpcAbpState.__PropertyOffset_EntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeNpcAbpState.__PropertyOffset_EntityId) = value;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000439 RID: 1081 RVA: 0x00014EF6 File Offset: 0x000130F6
	// (set) Token: 0x0600043A RID: 1082 RVA: 0x00014F0A File Offset: 0x0001310A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetState
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskChangeNpcAbpState.__PropertyOffset_TargetState)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskChangeNpcAbpState.__PropertyOffset_TargetState)), value);
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00014F20 File Offset: 0x00013120
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeNpcAbpState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskChangeNpcAbpState.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600043C RID: 1084 RVA: 0x00014FD0 File Offset: 0x000131D0
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
		Entity entity = (charActorComp != null) ? charActorComp.Entity : null;
		NpcPerformComponent performComp = (entity != null) ? entity.GetComponent<NpcPerformComponent>() : null;
		if (performComp == null)
		{
			base.FinishExecute(true);
			return;
		}
		Action<int> <>9__1;
		this.Handle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.Handle = null;
			BasePerformComponent performComp = performComp;
			EPerformMode mode = EPerformMode.Ecology;
			SwitchState switchState = new SwitchState();
			switchState.TargetStateName = this.TargetState;
			switchState.IsNoTransition = new bool?(false);
			switchState.Context = "TsTaskChangeNpcApbState";
			Action<int> onBeforeExecute = null;
			Action<int> onAfterExecute;
			if ((onAfterExecute = <>9__1) == null)
			{
				onAfterExecute = (<>9__1 = delegate(int _)
				{
					this.FinishExecute(true);
				});
			}
			performComp.PerformSwitchState(mode, switchState, onBeforeExecute, onAfterExecute);
		}, 100f, null, null, true, 1f);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0001509A File Offset: 0x0001329A
	protected override void OnAbort()
	{
		if (this.Handle != null)
		{
			TimerSystem.Instance.Remove(this.Handle);
		}
		this.Handle = null;
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x000150BC File Offset: 0x000132BC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeNpcAbpState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskChangeNpcAbpState.TsTaskChangeNpcAbpState_C");
		}
		return TsTaskChangeNpcAbpState._ClassPtr;
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x000150E0 File Offset: 0x000132E0
	public TsTaskChangeNpcAbpState() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeNpcAbpState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00015108 File Offset: 0x00013308
	public TsTaskChangeNpcAbpState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeNpcAbpState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0001513B File Offset: 0x0001333B
	protected TsTaskChangeNpcAbpState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00015144 File Offset: 0x00013344
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002EE RID: 750
	private const float DEFAULT_BLEND_TIME = 100f;

	// Token: 0x040002EF RID: 751
	[Nullable(2)]
	private TimerHandle Handle;

	// Token: 0x040002F0 RID: 752
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskChangeNpcAbpState.TsTaskChangeNpcAbpState_C";

	// Token: 0x040002F1 RID: 753
	private static IntPtr _ClassPtr;

	// Token: 0x040002F2 RID: 754
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002F3 RID: 755
	private static int __PropertyOffset_EntityId;

	// Token: 0x040002F4 RID: 756
	private static int __PropertyOffset_TargetState;
}

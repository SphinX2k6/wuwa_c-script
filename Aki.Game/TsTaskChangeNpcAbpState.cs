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
	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000435 RID: 1077 RVA: 0x00014605 File Offset: 0x00012805
	// (set) Token: 0x06000436 RID: 1078 RVA: 0x00014615 File Offset: 0x00012815
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

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000437 RID: 1079 RVA: 0x00014626 File Offset: 0x00012826
	// (set) Token: 0x06000438 RID: 1080 RVA: 0x0001463A File Offset: 0x0001283A
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

	// Token: 0x06000439 RID: 1081 RVA: 0x00014650 File Offset: 0x00012850
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

	// Token: 0x0600043A RID: 1082 RVA: 0x000146EC File Offset: 0x000128EC
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

	// Token: 0x0600043B RID: 1083 RVA: 0x000147B6 File Offset: 0x000129B6
	protected override void OnAbort()
	{
		if (this.Handle != null)
		{
			TimerSystem.Instance.Remove(this.Handle);
		}
		this.Handle = null;
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000147D8 File Offset: 0x000129D8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeNpcAbpState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskChangeNpcAbpState.TsTaskChangeNpcAbpState_C");
		}
		return TsTaskChangeNpcAbpState._ClassPtr;
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x000147FC File Offset: 0x000129FC
	public TsTaskChangeNpcAbpState() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeNpcAbpState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00014824 File Offset: 0x00012A24
	public TsTaskChangeNpcAbpState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeNpcAbpState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00014857 File Offset: 0x00012A57
	protected TsTaskChangeNpcAbpState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00014860 File Offset: 0x00012A60
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002EC RID: 748
	private const float DEFAULT_BLEND_TIME = 100f;

	// Token: 0x040002ED RID: 749
	[Nullable(2)]
	private TimerHandle Handle;

	// Token: 0x040002EE RID: 750
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskChangeNpcAbpState.TsTaskChangeNpcAbpState_C";

	// Token: 0x040002EF RID: 751
	private static IntPtr _ClassPtr;

	// Token: 0x040002F0 RID: 752
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002F1 RID: 753
	private static int __PropertyOffset_EntityId;

	// Token: 0x040002F2 RID: 754
	private static int __PropertyOffset_TargetState;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000066 RID: 102
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskClearPlayBubble.TsTaskClearPlayBubble_C")]
public class TsTaskClearPlayBubble : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000441 RID: 1089 RVA: 0x00014890 File Offset: 0x00012A90
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

	// Token: 0x06000442 RID: 1090 RVA: 0x0001492C File Offset: 0x00012B2C
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (!(ownerController is TsAiController))
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
		CharacterActorComponent charActorComp = ((TsAiController)ownerController).AiController.CharActorComp;
		if (charActorComp == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "[TsTaskPlayBubble]无效的ActorComp";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(true);
			return;
		}
		int pbDataId = charActorComp.CreatureData.GetPbDataId();
		DynamicFlowActorInfo dynamicFlowActorInfo = new DynamicFlowActorInfo();
		dynamicFlowActorInfo.PbDataId = pbDataId;
		DynamicFlowController.Instance.RemoveDynamicFlow(dynamicFlowActorInfo);
		base.FinishExecute(true);
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x000149FA File Offset: 0x00012BFA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskClearPlayBubble._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskClearPlayBubble.TsTaskClearPlayBubble_C");
		}
		return TsTaskClearPlayBubble._ClassPtr;
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00014A20 File Offset: 0x00012C20
	public TsTaskClearPlayBubble() : this(BuiltinUtils.AllocNativeUObject(TsTaskClearPlayBubble.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00014A48 File Offset: 0x00012C48
	[NullableContext(1)]
	public TsTaskClearPlayBubble(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskClearPlayBubble.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00014A7B File Offset: 0x00012C7B
	protected TsTaskClearPlayBubble(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00014A84 File Offset: 0x00012C84
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002F3 RID: 755
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskClearPlayBubble.TsTaskClearPlayBubble_C";

	// Token: 0x040002F4 RID: 756
	private static IntPtr _ClassPtr;

	// Token: 0x040002F5 RID: 757
	private static IntPtr _ClassDefaultObjectPtr;
}

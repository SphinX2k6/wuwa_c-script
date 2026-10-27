using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000071 RID: 113
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPlayBubble.TsTaskPlayBubble_C")]
public class TsTaskPlayBubble : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000516 RID: 1302 RVA: 0x00018685 File Offset: 0x00016885
	// (set) Token: 0x06000517 RID: 1303 RVA: 0x00018699 File Offset: 0x00016899
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FlowListName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayBubble.__PropertyOffset_FlowListName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayBubble.__PropertyOffset_FlowListName)), value);
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000518 RID: 1304 RVA: 0x000186AE File Offset: 0x000168AE
	// (set) Token: 0x06000519 RID: 1305 RVA: 0x000186BE File Offset: 0x000168BE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FlowId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayBubble.__PropertyOffset_FlowId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayBubble.__PropertyOffset_FlowId) = value;
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x0600051A RID: 1306 RVA: 0x000186CF File Offset: 0x000168CF
	// (set) Token: 0x0600051B RID: 1307 RVA: 0x000186DF File Offset: 0x000168DF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int StateId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayBubble.__PropertyOffset_StateId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayBubble.__PropertyOffset_StateId) = value;
		}
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x000186F0 File Offset: 0x000168F0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFlowListName = this.FlowListName;
			this.TsFlowId = this.FlowId;
			this.TsStateId = this.StateId;
		}
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001872C File Offset: 0x0001692C
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

	// Token: 0x0600051E RID: 1310 RVA: 0x000187C8 File Offset: 0x000169C8
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(true);
			return;
		}
		if (this.TsFlowListName == "")
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "[TsTaskPlayBubble]无效的FlowListName";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(true);
			return;
		}
		CharacterActorComponent charActorComp = ((TsAiController)ownerController).AiController.CharActorComp;
		if (charActorComp == null)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.YJX;
			string message3 = "[TsTaskPlayBubble]无效的ActorComp";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			base.FinishExecute(true);
			return;
		}
		IBubbleIndex flowIndex = new IBubbleIndex
		{
			FlowListName = this.TsFlowListName,
			FlowId = this.TsFlowId,
			StateId = new int?(this.TsStateId)
		};
		CharacterAiComponent aiComp = ((TsAiController)ownerController).GetAiComp();
		if (aiComp == null)
		{
			base.FinishExecute(true);
			return;
		}
		long creatureDataId = charActorComp.CreatureData.GetCreatureDataId();
		CharacterDynamicFlowData flowData = this.CreateCharacterFlowData(creatureDataId, flowIndex);
		flowData.Callback = delegate()
		{
			aiComp.RemoveBehaviorTreeBubble(flowData);
		};
		aiComp.AddBehaviorTreeBubble(flowData);
		base.FinishExecute(true);
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00018960 File Offset: 0x00016B60
	private CharacterDynamicFlowData CreateCharacterFlowData(long creatureId, IFlowIndex flowIndex)
	{
		CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
		AddPlayBubble bubbleData = new AddPlayBubble
		{
			EntityIds = new List<int>(),
			Flow = (IBubbleIndex)flowIndex,
			WaitTime = new int?(0),
			RedDot = new bool?(false)
		};
		characterDynamicFlowData.MasterInfo = new DynamicFlowActorInfo
		{
			CreatureId = creatureId
		};
		characterDynamicFlowData.BubbleData = bubbleData;
		return characterDynamicFlowData;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x000189C2 File Offset: 0x00016BC2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayBubble._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPlayBubble.TsTaskPlayBubble_C");
		}
		return TsTaskPlayBubble._ClassPtr;
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x000189E8 File Offset: 0x00016BE8
	public TsTaskPlayBubble() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayBubble.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x00018A10 File Offset: 0x00016C10
	public TsTaskPlayBubble(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayBubble.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00018A43 File Offset: 0x00016C43
	protected TsTaskPlayBubble(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00018A58 File Offset: 0x00016C58
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040003A2 RID: 930
	private bool IsInitTsVariables;

	// Token: 0x040003A3 RID: 931
	private string TsFlowListName = "";

	// Token: 0x040003A4 RID: 932
	private int TsFlowId;

	// Token: 0x040003A5 RID: 933
	private int TsStateId;

	// Token: 0x040003A6 RID: 934
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskPlayBubble.TsTaskPlayBubble_C";

	// Token: 0x040003A7 RID: 935
	private static IntPtr _ClassPtr;

	// Token: 0x040003A8 RID: 936
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003A9 RID: 937
	private static int __PropertyOffset_FlowListName;

	// Token: 0x040003AA RID: 938
	private static int __PropertyOffset_FlowId;

	// Token: 0x040003AB RID: 939
	private static int __PropertyOffset_StateId;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000064 RID: 100
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskAddPlayBubble.TsTaskAddPlayBubble_C")]
public class TsTaskAddPlayBubble : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00013EF1 File Offset: 0x000120F1
	// (set) Token: 0x0600041D RID: 1053 RVA: 0x00013F05 File Offset: 0x00012105
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FlowListName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAddPlayBubble.__PropertyOffset_FlowListName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAddPlayBubble.__PropertyOffset_FlowListName)), value);
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x00013F1A File Offset: 0x0001211A
	// (set) Token: 0x0600041F RID: 1055 RVA: 0x00013F2A File Offset: 0x0001212A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FlowId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_FlowId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_FlowId) = value;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x00013F3B File Offset: 0x0001213B
	// (set) Token: 0x06000421 RID: 1057 RVA: 0x00013F4B File Offset: 0x0001214B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StateId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_StateId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_StateId) = value;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x00013F5C File Offset: 0x0001215C
	// (set) Token: 0x06000423 RID: 1059 RVA: 0x00013F95 File Offset: 0x00012195
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> PbDataIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._PbDataIds) == null)
			{
				result = (this._PbDataIds = new TArray<int>(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_PbDataIds, this));
			}
			return result;
		}
		set
		{
			this.PbDataIds.CopyAssign(value);
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x00013FA3 File Offset: 0x000121A3
	// (set) Token: 0x06000425 RID: 1061 RVA: 0x00013FB3 File Offset: 0x000121B3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EnterRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_EnterRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_EnterRadius) = value;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x00013FC4 File Offset: 0x000121C4
	// (set) Token: 0x06000427 RID: 1063 RVA: 0x00013FD4 File Offset: 0x000121D4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LeaveRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_LeaveRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_LeaveRadius) = value;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x00013FE5 File Offset: 0x000121E5
	// (set) Token: 0x06000429 RID: 1065 RVA: 0x00013FF5 File Offset: 0x000121F5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EnterHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_EnterHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_EnterHeight) = value;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x00014006 File Offset: 0x00012206
	// (set) Token: 0x0600042B RID: 1067 RVA: 0x00014016 File Offset: 0x00012216
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LeaveHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_LeaveHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_LeaveHeight) = value;
		}
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00014028 File Offset: 0x00012228
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFlowListName = this.FlowListName;
			this.TsFlowId = this.FlowId;
			this.TsStateId = this.StateId;
			this.TsEnterRadius = this.EnterRadius;
			this.TsLeaveRadius = this.LeaveRadius;
			this.TsEnterHeight = this.EnterHeight;
			this.TsLeaveHeight = this.LeaveHeight;
			this.TsPbDataIds.Clear();
			TArray<int> pbDataIds = this.PbDataIds;
			int num = (pbDataIds != null) ? pbDataIds.Num() : 0;
			for (int i = 0; i < num; i++)
			{
				int item = this.PbDataIds.Get(i);
				this.TsPbDataIds.Add(item);
			}
		}
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x000140E8 File Offset: 0x000122E8
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

	// Token: 0x0600042E RID: 1070 RVA: 0x00014184 File Offset: 0x00012384
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
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
		if (this.TsPbDataIds.Count == 0)
		{
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
		int pbDataId = charActorComp.CreatureData.GetPbDataId();
		List<int> list = new List<int>
		{
			pbDataId
		};
		bool flag = false;
		foreach (int num in this.TsPbDataIds)
		{
			if (num == pbDataId)
			{
				flag = true;
			}
			else
			{
				list.Add(num);
			}
		}
		if (!flag)
		{
			global::Log instance4 = global::Log.Instance;
			ELogModule module4 = ELogModule.LevelAi;
			ELogAuthor author4 = ELogAuthor.YJX;
			string message4 = "禁止添加非自身参与的多人冒泡";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowName", this.TsFlowListName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", this.TsFlowId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("StateId", this.TsStateId);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			base.FinishExecute(true);
			return;
		}
		CharacterDynamicFlowData data = this.CreateCharacterFlowData();
		DynamicFlowController.Instance.AddDynamicFlow(data);
		base.FinishExecute(true);
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x000143C8 File Offset: 0x000125C8
	private CharacterDynamicFlowData CreateCharacterFlowData()
	{
		List<int> list = new List<int>(this.TsPbDataIds);
		CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
		IFlowIndex flowIndex = new IBubbleIndex
		{
			FlowListName = this.TsFlowListName,
			FlowId = this.TsFlowId,
			StateId = new int?((int)this.TsStateId)
		};
		IBubbleCylinderConfig innerConfig = new IBubbleCylinderConfig
		{
			Radius = this.TsEnterRadius,
			Height = this.TsEnterHeight
		};
		IBubbleCylinderConfig outerConfig = new IBubbleCylinderConfig
		{
			Radius = this.TsLeaveRadius,
			Height = this.TsLeaveHeight
		};
		IBubbleRangeCylinderConfig bubbleRangeCylinderConfig = new IBubbleRangeCylinderConfig
		{
			InnerConfig = innerConfig,
			OuterConfig = outerConfig
		};
		AddPlayBubble bubbleData = new AddPlayBubble
		{
			EntityIds = list,
			EnterRadius = ((this.TsEnterRadius != 0f) ? new float?(this.TsEnterRadius) : null),
			LeaveRadius = ((this.TsLeaveRadius != 0f) ? new float?(this.TsLeaveRadius) : null),
			TriggerCylinderConfig = ((this.TsLeaveHeight != 0f) ? bubbleRangeCylinderConfig : null),
			Flow = (IBubbleIndex)flowIndex,
			WaitTime = new int?(0),
			RedDot = new bool?(false)
		};
		characterDynamicFlowData.MasterInfo = new DynamicFlowActorInfo
		{
			PbDataId = list[0]
		};
		characterDynamicFlowData.BubbleData = bubbleData;
		characterDynamicFlowData.Type = new EDynamicFlowType?(EDynamicFlowType.LevelAi);
		return characterDynamicFlowData;
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00014536 File Offset: 0x00012736
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAddPlayBubble._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskAddPlayBubble.TsTaskAddPlayBubble_C");
		}
		return TsTaskAddPlayBubble._ClassPtr;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0001455C File Offset: 0x0001275C
	public TsTaskAddPlayBubble() : this(BuiltinUtils.AllocNativeUObject(TsTaskAddPlayBubble.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00014584 File Offset: 0x00012784
	public TsTaskAddPlayBubble(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddPlayBubble.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x000145B7 File Offset: 0x000127B7
	protected TsTaskAddPlayBubble(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x000145D8 File Offset: 0x000127D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002D7 RID: 727
	private bool IsInitTsVariables;

	// Token: 0x040002D8 RID: 728
	private string TsFlowListName = "";

	// Token: 0x040002D9 RID: 729
	private int TsFlowId;

	// Token: 0x040002DA RID: 730
	private float TsStateId;

	// Token: 0x040002DB RID: 731
	private readonly List<int> TsPbDataIds = new List<int>();

	// Token: 0x040002DC RID: 732
	private float TsEnterRadius;

	// Token: 0x040002DD RID: 733
	private float TsLeaveRadius;

	// Token: 0x040002DE RID: 734
	protected float TsEnterHeight;

	// Token: 0x040002DF RID: 735
	protected float TsLeaveHeight;

	// Token: 0x040002E0 RID: 736
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskAddPlayBubble.TsTaskAddPlayBubble_C";

	// Token: 0x040002E1 RID: 737
	private static IntPtr _ClassPtr;

	// Token: 0x040002E2 RID: 738
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002E3 RID: 739
	private static int __PropertyOffset_FlowListName;

	// Token: 0x040002E4 RID: 740
	private static int __PropertyOffset_FlowId;

	// Token: 0x040002E5 RID: 741
	private static int __PropertyOffset_StateId;

	// Token: 0x040002E6 RID: 742
	private static int __PropertyOffset_PbDataIds;

	// Token: 0x040002E7 RID: 743
	[Nullable(2)]
	private TArray<int> _PbDataIds;

	// Token: 0x040002E8 RID: 744
	private static int __PropertyOffset_EnterRadius;

	// Token: 0x040002E9 RID: 745
	private static int __PropertyOffset_LeaveRadius;

	// Token: 0x040002EA RID: 746
	private static int __PropertyOffset_EnterHeight;

	// Token: 0x040002EB RID: 747
	private static int __PropertyOffset_LeaveHeight;
}

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
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00014771 File Offset: 0x00012971
	// (set) Token: 0x0600041D RID: 1053 RVA: 0x00014785 File Offset: 0x00012985
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
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001479A File Offset: 0x0001299A
	// (set) Token: 0x0600041F RID: 1055 RVA: 0x000147AA File Offset: 0x000129AA
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
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x000147BB File Offset: 0x000129BB
	// (set) Token: 0x06000421 RID: 1057 RVA: 0x000147CB File Offset: 0x000129CB
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
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x000147DC File Offset: 0x000129DC
	// (set) Token: 0x06000423 RID: 1059 RVA: 0x00014815 File Offset: 0x00012A15
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
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x00014823 File Offset: 0x00012A23
	// (set) Token: 0x06000425 RID: 1061 RVA: 0x00014833 File Offset: 0x00012A33
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsRangeFollowEntity
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_IsRangeFollowEntity) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddPlayBubble.__PropertyOffset_IsRangeFollowEntity) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x00014844 File Offset: 0x00012A44
	// (set) Token: 0x06000427 RID: 1063 RVA: 0x00014854 File Offset: 0x00012A54
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

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x00014865 File Offset: 0x00012A65
	// (set) Token: 0x06000429 RID: 1065 RVA: 0x00014875 File Offset: 0x00012A75
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

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x00014886 File Offset: 0x00012A86
	// (set) Token: 0x0600042B RID: 1067 RVA: 0x00014896 File Offset: 0x00012A96
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

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600042C RID: 1068 RVA: 0x000148A7 File Offset: 0x00012AA7
	// (set) Token: 0x0600042D RID: 1069 RVA: 0x000148B7 File Offset: 0x00012AB7
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

	// Token: 0x0600042E RID: 1070 RVA: 0x000148C8 File Offset: 0x00012AC8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFlowListName = this.FlowListName;
			this.TsFlowId = this.FlowId;
			this.TsStateId = this.StateId;
			this.TsIsRangeFollowEntity = this.IsRangeFollowEntity;
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

	// Token: 0x0600042F RID: 1071 RVA: 0x00014994 File Offset: 0x00012B94
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAddPlayBubble) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAddPlayBubble.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000430 RID: 1072 RVA: 0x00014A44 File Offset: 0x00012C44
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

	// Token: 0x06000431 RID: 1073 RVA: 0x00014C88 File Offset: 0x00012E88
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
			IsRangeFollowEntity = new bool?(this.TsIsRangeFollowEntity),
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

	// Token: 0x06000432 RID: 1074 RVA: 0x00014E07 File Offset: 0x00013007
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAddPlayBubble._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskAddPlayBubble.TsTaskAddPlayBubble_C");
		}
		return TsTaskAddPlayBubble._ClassPtr;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00014E2C File Offset: 0x0001302C
	public TsTaskAddPlayBubble() : this(BuiltinUtils.AllocNativeUObject(TsTaskAddPlayBubble.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00014E54 File Offset: 0x00013054
	public TsTaskAddPlayBubble(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddPlayBubble.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00014E87 File Offset: 0x00013087
	protected TsTaskAddPlayBubble(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00014EA8 File Offset: 0x000130A8
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
	private bool TsIsRangeFollowEntity;

	// Token: 0x040002DD RID: 733
	private float TsEnterRadius;

	// Token: 0x040002DE RID: 734
	private float TsLeaveRadius;

	// Token: 0x040002DF RID: 735
	protected float TsEnterHeight;

	// Token: 0x040002E0 RID: 736
	protected float TsLeaveHeight;

	// Token: 0x040002E1 RID: 737
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskAddPlayBubble.TsTaskAddPlayBubble_C";

	// Token: 0x040002E2 RID: 738
	private static IntPtr _ClassPtr;

	// Token: 0x040002E3 RID: 739
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002E4 RID: 740
	private static int __PropertyOffset_FlowListName;

	// Token: 0x040002E5 RID: 741
	private static int __PropertyOffset_FlowId;

	// Token: 0x040002E6 RID: 742
	private static int __PropertyOffset_StateId;

	// Token: 0x040002E7 RID: 743
	private static int __PropertyOffset_PbDataIds;

	// Token: 0x040002E8 RID: 744
	[Nullable(2)]
	private TArray<int> _PbDataIds;

	// Token: 0x040002E9 RID: 745
	private static int __PropertyOffset_IsRangeFollowEntity;

	// Token: 0x040002EA RID: 746
	private static int __PropertyOffset_EnterRadius;

	// Token: 0x040002EB RID: 747
	private static int __PropertyOffset_LeaveRadius;

	// Token: 0x040002EC RID: 748
	private static int __PropertyOffset_EnterHeight;

	// Token: 0x040002ED RID: 749
	private static int __PropertyOffset_LeaveHeight;
}

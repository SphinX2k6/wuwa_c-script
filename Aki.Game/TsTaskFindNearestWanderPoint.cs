using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200009A RID: 154
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindNearestWanderPoint.TsTaskFindNearestWanderPoint_C")]
public class TsTaskFindNearestWanderPoint : UBTTask_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000149 RID: 329
	// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000276F4 File Offset: 0x000258F4
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> PbDataIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._PbDataIds) == null)
			{
				result = (this._PbDataIds = new TArray<int>(base.NativePtr + (IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_PbDataIds, this));
			}
			return result;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0002772D File Offset: 0x0002592D
	// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00027741 File Offset: 0x00025941
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ResultBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_ResultBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_ResultBlackboardKey)), value);
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00027756 File Offset: 0x00025956
	// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0002776A File Offset: 0x0002596A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ResultIndexKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_ResultIndexKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_ResultIndexKey)), value);
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002777F File Offset: 0x0002597F
	// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0002778F File Offset: 0x0002598F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_CheckDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_CheckDistance) = value;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000277A0 File Offset: 0x000259A0
	// (set) Token: 0x060007F9 RID: 2041 RVA: 0x000277B0 File Offset: 0x000259B0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsResetSearchedWanderPointCount
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_IsResetSearchedWanderPointCount) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindNearestWanderPoint.__PropertyOffset_IsResetSearchedWanderPointCount) = (value ? 1 : 0);
		}
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x000277C4 File Offset: 0x000259C4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsPbDataIds.Clear();
			for (int i = 0; i < this.PbDataIds.Num(); i++)
			{
				this.TsPbDataIds.Add(this.PbDataIds.Get(i), i);
			}
			this.TsResultBlackboardKey = this.ResultBlackboardKey;
			this.TsCheckDistance = this.CheckDistance;
			this.TsResultIndexKey = this.ResultIndexKey;
			this.TsIsResetSearchedWanderPointCount = this.IsResetSearchedWanderPointCount;
		}
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00027850 File Offset: 0x00025A50
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

	// Token: 0x060007FC RID: 2044 RVA: 0x000278EC File Offset: 0x00025AEC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		if (string.IsNullOrEmpty(this.TsResultBlackboardKey))
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		this.EntityList.Clear();
		int num = 0;
		foreach (int num2 in this.TsPbDataIds.Keys)
		{
			if (IdlePerformModel.Instance.HasAiSearchedWanderPointId(id, num2))
			{
				num++;
			}
			else
			{
				this.TempEntityList.Clear();
				CreatureModel.Instance.GetEntitiesWithPbDataId(num2, ref this.TempEntityList);
				foreach (EntityHandle entityHandle in this.TempEntityList)
				{
					if (entityHandle.Valid)
					{
						this.EntityList.Add(entityHandle);
					}
				}
			}
		}
		if (this.EntityList.Count == 0)
		{
			if (this.TsIsResetSearchedWanderPointCount && num >= this.TsPbDataIds.Count)
			{
				IdlePerformModel.Instance.ClearAiSearchedWanderPointIdSet(id);
			}
			base.FinishExecute(false);
			return;
		}
		FVectorDouble actorLocation = charActorComp.ActorLocation;
		float num3 = this.TsCheckDistance * this.TsCheckDistance;
		int value = 0;
		int num4 = 0;
		double num5 = 3.402823466E+38;
		bool flag = false;
		foreach (EntityHandle entityHandle2 in this.EntityList)
		{
			if (entityHandle2.Valid && entityHandle2.Id != id)
			{
				BaseActorComponent component = entityHandle2.Entity.GetComponent<BaseActorComponent>();
				if (component != null && component.Valid)
				{
					FVectorDouble actorLocation2 = component.ActorLocation;
					double num6 = FVectorDouble.DistSquared(actorLocation, actorLocation2);
					if (num6 <= (double)num3 && num6 < num5)
					{
						CreatureDataComponent component2 = entityHandle2.Entity.GetComponent<CreatureDataComponent>();
						int num7 = (component2 != null) ? component2.GetPbDataId() : 0;
						if (AiControllerLibrary.NavigationFindPath(ownerController, actorLocation, actorLocation2, null, new bool?(true), new bool?(true)))
						{
							num5 = num6;
							value = entityHandle2.Id;
							num4 = num7;
							flag = true;
						}
					}
				}
			}
		}
		if (!flag)
		{
			BlackboardController.Instance.SetIntValueByEntity(id, this.TsResultIndexKey, -1);
			BlackboardController.Instance.SetEntityIdByEntity(id, this.TsResultBlackboardKey, 0);
			base.FinishExecute(false);
			return;
		}
		BlackboardController.Instance.SetIntValueByEntity(id, this.TsResultIndexKey, this.TsPbDataIds[num4]);
		BlackboardController.Instance.SetEntityIdByEntity(id, this.TsResultBlackboardKey, value);
		IdlePerformModel.Instance.AddAiSearchedWanderPointId(id, num4);
		base.FinishExecute(true);
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00027C2C File Offset: 0x00025E2C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindNearestWanderPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindNearestWanderPoint.TsTaskFindNearestWanderPoint_C");
		}
		return TsTaskFindNearestWanderPoint._ClassPtr;
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00027C50 File Offset: 0x00025E50
	public TsTaskFindNearestWanderPoint() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestWanderPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00027C78 File Offset: 0x00025E78
	public TsTaskFindNearestWanderPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestWanderPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00027CAB File Offset: 0x00025EAB
	protected TsTaskFindNearestWanderPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00027CEC File Offset: 0x00025EEC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005DF RID: 1503
	private bool IsInitTsVariables;

	// Token: 0x040005E0 RID: 1504
	private Dictionary<int, int> TsPbDataIds = new Dictionary<int, int>();

	// Token: 0x040005E1 RID: 1505
	private string TsResultBlackboardKey = "";

	// Token: 0x040005E2 RID: 1506
	private string TsResultIndexKey = "";

	// Token: 0x040005E3 RID: 1507
	private float TsCheckDistance;

	// Token: 0x040005E4 RID: 1508
	private bool TsIsResetSearchedWanderPointCount;

	// Token: 0x040005E5 RID: 1509
	private List<EntityHandle> EntityList = new List<EntityHandle>();

	// Token: 0x040005E6 RID: 1510
	private List<EntityHandle> TempEntityList = new List<EntityHandle>();

	// Token: 0x040005E7 RID: 1511
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindNearestWanderPoint.TsTaskFindNearestWanderPoint_C";

	// Token: 0x040005E8 RID: 1512
	private static IntPtr _ClassPtr;

	// Token: 0x040005E9 RID: 1513
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005EA RID: 1514
	private static int __PropertyOffset_PbDataIds;

	// Token: 0x040005EB RID: 1515
	[Nullable(2)]
	private TArray<int> _PbDataIds;

	// Token: 0x040005EC RID: 1516
	private static int __PropertyOffset_ResultBlackboardKey;

	// Token: 0x040005ED RID: 1517
	private static int __PropertyOffset_ResultIndexKey;

	// Token: 0x040005EE RID: 1518
	private static int __PropertyOffset_CheckDistance;

	// Token: 0x040005EF RID: 1519
	private static int __PropertyOffset_IsResetSearchedWanderPointCount;
}

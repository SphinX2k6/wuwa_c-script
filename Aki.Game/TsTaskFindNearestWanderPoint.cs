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
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000284E0 File Offset: 0x000266E0
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

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00028519 File Offset: 0x00026719
	// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0002852D File Offset: 0x0002672D
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

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00028542 File Offset: 0x00026742
	// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00028556 File Offset: 0x00026756
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

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002856B File Offset: 0x0002676B
	// (set) Token: 0x060007FB RID: 2043 RVA: 0x0002857B File Offset: 0x0002677B
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

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x060007FC RID: 2044 RVA: 0x0002858C File Offset: 0x0002678C
	// (set) Token: 0x060007FD RID: 2045 RVA: 0x0002859C File Offset: 0x0002679C
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

	// Token: 0x060007FE RID: 2046 RVA: 0x000285B0 File Offset: 0x000267B0
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

	// Token: 0x060007FF RID: 2047 RVA: 0x0002863C File Offset: 0x0002683C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFindNearestWanderPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFindNearestWanderPoint.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000800 RID: 2048 RVA: 0x000286EC File Offset: 0x000268EC
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

	// Token: 0x06000801 RID: 2049 RVA: 0x00028A2C File Offset: 0x00026C2C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindNearestWanderPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindNearestWanderPoint.TsTaskFindNearestWanderPoint_C");
		}
		return TsTaskFindNearestWanderPoint._ClassPtr;
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00028A50 File Offset: 0x00026C50
	public TsTaskFindNearestWanderPoint() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestWanderPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00028A78 File Offset: 0x00026C78
	public TsTaskFindNearestWanderPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestWanderPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00028AAB File Offset: 0x00026CAB
	protected TsTaskFindNearestWanderPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00028AEC File Offset: 0x00026CEC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005E3 RID: 1507
	private bool IsInitTsVariables;

	// Token: 0x040005E4 RID: 1508
	private Dictionary<int, int> TsPbDataIds = new Dictionary<int, int>();

	// Token: 0x040005E5 RID: 1509
	private string TsResultBlackboardKey = "";

	// Token: 0x040005E6 RID: 1510
	private string TsResultIndexKey = "";

	// Token: 0x040005E7 RID: 1511
	private float TsCheckDistance;

	// Token: 0x040005E8 RID: 1512
	private bool TsIsResetSearchedWanderPointCount;

	// Token: 0x040005E9 RID: 1513
	private List<EntityHandle> EntityList = new List<EntityHandle>();

	// Token: 0x040005EA RID: 1514
	private List<EntityHandle> TempEntityList = new List<EntityHandle>();

	// Token: 0x040005EB RID: 1515
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindNearestWanderPoint.TsTaskFindNearestWanderPoint_C";

	// Token: 0x040005EC RID: 1516
	private static IntPtr _ClassPtr;

	// Token: 0x040005ED RID: 1517
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005EE RID: 1518
	private static int __PropertyOffset_PbDataIds;

	// Token: 0x040005EF RID: 1519
	[Nullable(2)]
	private TArray<int> _PbDataIds;

	// Token: 0x040005F0 RID: 1520
	private static int __PropertyOffset_ResultBlackboardKey;

	// Token: 0x040005F1 RID: 1521
	private static int __PropertyOffset_ResultIndexKey;

	// Token: 0x040005F2 RID: 1522
	private static int __PropertyOffset_CheckDistance;

	// Token: 0x040005F3 RID: 1523
	private static int __PropertyOffset_IsResetSearchedWanderPointCount;
}

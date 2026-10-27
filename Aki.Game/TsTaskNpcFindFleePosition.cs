using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000079 RID: 121
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcFindFleePosition.TsTaskNpcFindFleePosition_C")]
public class TsTaskNpcFindFleePosition : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001B1F6 File Offset: 0x000193F6
	// (set) Token: 0x0600059D RID: 1437 RVA: 0x0001B206 File Offset: 0x00019406
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SearchRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcFindFleePosition.__PropertyOffset_SearchRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcFindFleePosition.__PropertyOffset_SearchRange) = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001B217 File Offset: 0x00019417
	// (set) Token: 0x0600059F RID: 1439 RVA: 0x0001B22B File Offset: 0x0001942B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcFindFleePosition.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcFindFleePosition.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0001B240 File Offset: 0x00019440
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSearchRange = this.SearchRange;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0001B270 File Offset: 0x00019470
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

	// Token: 0x060005A2 RID: 1442 RVA: 0x0001B30C File Offset: 0x0001950C
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			base.FinishExecute(false);
			return;
		}
		if (this.TempEnemyList == null)
		{
			this.TempEnemyList = new List<Entity>();
		}
		this.TempEnemyList.Clear();
		AiController aiController = ((TsAiController)ownerController).AiController;
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int id = charActorComp.Entity.Id;
		Vector actorLocationProxy = charActorComp.ActorLocationProxy;
		this.InitTraceElement();
		if (aiController.AiPerception != null)
		{
			this.FindEnemies(aiController.AiPerception);
		}
		float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(this.TsSearchRange / 2f, this.TsSearchRange);
		List<Vector> noTargetDirectionList = this.GetNoTargetDirectionList(actorLocationProxy, charActorComp);
		if (noTargetDirectionList.Count > 0)
		{
			Vector vector = this.GetOptimalDirection(actorLocationProxy, noTargetDirectionList).MultiplyEqual((double)randomFloatNumber).AdditionEqual(actorLocationProxy);
			BlackboardController.Instance.SetVectorValueByEntity(id, this.TsBlackboardKey, (double)((float)vector.X), (double)((float)vector.Y), (double)((float)vector.Z));
		}
		else
		{
			int count = this.TempEnemyList.Count;
			if (count <= 0)
			{
				base.FinishExecute(false);
				return;
			}
			int index = (int)Math.Floor((double)MathUtils.Instance.GetRandomFloatNumber(0f, (float)count));
			Entity entity = this.TempEnemyList[index];
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			Vector vector2 = Vector.Create(actorLocationProxy).SubtractionEqual(baseActorComponent.ActorLocationProxy);
			vector2.Normalize(9.99999993922529E-09);
			Vector vector3 = vector2.MultiplyEqual((double)randomFloatNumber).AdditionEqual(actorLocationProxy);
			BlackboardController.Instance.SetVectorValueByEntity(id, this.TsBlackboardKey, (double)((float)vector3.X), (double)((float)vector3.Y), (double)((float)vector3.Z));
		}
		base.FinishExecute(true);
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001B4C4 File Offset: 0x000196C4
	private void InitTraceElement()
	{
		if (this.TraceElement == null)
		{
			this.TraceElement = new UTraceLineElement();
			this.TraceElement.bIsSingle = true;
			this.TraceElement.bIgnoreSelf = true;
			this.TraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		}
		this.TraceElement.WorldContextObject = this.GetWorld();
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0001B520 File Offset: 0x00019720
	private void FindEnemies(IAiPerception aiPerception)
	{
		foreach (int id in aiPerception.AllEnemies)
		{
			Entity entity = EntitySystem.Instance.Get(id);
			if (entity != null)
			{
				this.TempEnemyList.Add(entity);
			}
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0001B588 File Offset: 0x00019788
	private List<Vector> GetNoTargetDirectionList(Vector nowPosition, CharacterActorComponent actorComp)
	{
		List<Vector> list = new List<Vector>();
		Vector actorForwardProxy = actorComp.ActorForwardProxy;
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, nowPosition);
		double num = 24.0;
		int num2 = 0;
		while ((double)num2 < num)
		{
			int num3 = num2 * 15;
			Vector vector = Vector.Create();
			actorForwardProxy.RotateAngleAxis((double)num3, Vector.UpVectorProxy, vector);
			Vector vector2 = Vector.Create();
			vector.Multiply((double)this.TsSearchRange, vector2);
			vector2.AdditionEqual(nowPosition);
			TraceElementCommon.Instance.SetEndLocation(this.TraceElement, vector2);
			if (!TraceElementCommon.Instance.LineTrace(this.TraceElement, "TsTaskNpcFindFleePosition_GetNoTargetDirectionList") || !this.TraceElement.HitResult.bBlockingHit)
			{
				list.Add(vector);
			}
			num2++;
		}
		return list;
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001B654 File Offset: 0x00019854
	private Vector GetOptimalDirection(Vector nowPosition, List<Vector> dirList)
	{
		int count = this.TempEnemyList.Count;
		if (count == 0)
		{
			int index = (int)Math.Floor((double)MathUtils.Instance.GetRandomFloatNumber(0f, (float)dirList.Count));
			return dirList[index];
		}
		int index2 = 0;
		double num = 0.0;
		int i = 0;
		int count2 = dirList.Count;
		while (i < count2)
		{
			Vector vector = Vector.Create(dirList[i]).MultiplyEqual((double)this.TsSearchRange);
			vector.AdditionEqual(nowPosition);
			double num2 = 0.0;
			for (int j = 0; j < count; j++)
			{
				Entity entity = this.TempEnemyList[j];
				double num3 = Vector.Dist(((entity != null) ? entity.GetComponent<BaseActorComponent>() : null).ActorLocationProxy, vector);
				if (num2 < num3)
				{
					num2 = num3;
				}
			}
			if (num2 > num)
			{
				num = num2;
				index2 = i;
			}
			i++;
		}
		return dirList[index2];
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0001B743 File Offset: 0x00019943
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcFindFleePosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcFindFleePosition.TsTaskNpcFindFleePosition_C");
		}
		return TsTaskNpcFindFleePosition._ClassPtr;
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0001B768 File Offset: 0x00019968
	public TsTaskNpcFindFleePosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcFindFleePosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0001B790 File Offset: 0x00019990
	public TsTaskNpcFindFleePosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcFindFleePosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0001B7C3 File Offset: 0x000199C3
	protected TsTaskNpcFindFleePosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0001B7D8 File Offset: 0x000199D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000405 RID: 1029
	private const string PROFILE_KEY = "TsTaskNpcFindFleePosition_GetNoTargetDirectionList";

	// Token: 0x04000406 RID: 1030
	private const int CHECK_DEGREE_ADDITION = 15;

	// Token: 0x04000407 RID: 1031
	private const double PI_DEG_DOUBLE = 360.0;

	// Token: 0x04000408 RID: 1032
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Entity> TempEnemyList;

	// Token: 0x04000409 RID: 1033
	[Nullable(2)]
	private UTraceLineElement TraceElement;

	// Token: 0x0400040A RID: 1034
	private bool IsInitTsVariables;

	// Token: 0x0400040B RID: 1035
	private float TsSearchRange;

	// Token: 0x0400040C RID: 1036
	private string TsBlackboardKey = "";

	// Token: 0x0400040D RID: 1037
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcFindFleePosition.TsTaskNpcFindFleePosition_C";

	// Token: 0x0400040E RID: 1038
	private static IntPtr _ClassPtr;

	// Token: 0x0400040F RID: 1039
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000410 RID: 1040
	private static int __PropertyOffset_SearchRange;

	// Token: 0x04000411 RID: 1041
	private static int __PropertyOffset_BlackboardKey;
}

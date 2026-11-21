using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000096 RID: 150
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskDoTurn.TsTaskDoTurn_C")]
public class TsTaskDoTurn : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00026DD9 File Offset: 0x00024FD9
	// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00026DE9 File Offset: 0x00024FE9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool TurnToPlayer
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TurnToPlayer) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TurnToPlayer) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00026DFA File Offset: 0x00024FFA
	// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00026E0A File Offset: 0x0002500A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TargetConfigId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TargetConfigId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TargetConfigId) = value;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00026E1B File Offset: 0x0002501B
	// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00026E2F File Offset: 0x0002502F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetEntityKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskDoTurn.__PropertyOffset_TargetEntityKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskDoTurn.__PropertyOffset_TargetEntityKey)), value);
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00026E44 File Offset: 0x00025044
	// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00026E58 File Offset: 0x00025058
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetDirectKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskDoTurn.__PropertyOffset_TargetDirectKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskDoTurn.__PropertyOffset_TargetDirectKey)), value);
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00026E6D File Offset: 0x0002506D
	// (set) Token: 0x060007AA RID: 1962 RVA: 0x00026E7D File Offset: 0x0002507D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnAngleAxis
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TurnAngleAxis);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TurnAngleAxis) = value;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060007AB RID: 1963 RVA: 0x00026E8E File Offset: 0x0002508E
	// (set) Token: 0x060007AC RID: 1964 RVA: 0x00026E9E File Offset: 0x0002509E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060007AD RID: 1965 RVA: 0x00026EAF File Offset: 0x000250AF
	// (set) Token: 0x060007AE RID: 1966 RVA: 0x00026EBF File Offset: 0x000250BF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_MinAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_MinAngle) = value;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060007AF RID: 1967 RVA: 0x00026ED0 File Offset: 0x000250D0
	// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00026EE0 File Offset: 0x000250E0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_LoopTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskDoTurn.__PropertyOffset_LoopTime) = value;
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00026EF4 File Offset: 0x000250F4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTurnToPlayer = this.TurnToPlayer;
			this.TsTargetConfigId = this.TargetConfigId;
			this.TsTargetEntityKey = this.TargetEntityKey;
			this.TsTargetDirectKey = this.TargetDirectKey;
			this.TsTurnAngleAxis = this.TurnAngleAxis;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsMinAngle = this.MinAngle;
			this.TsLoopTime = this.LoopTime;
		}
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00026F78 File Offset: 0x00025178
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskDoTurn) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskDoTurn.StaticClass(), out intPtr, out num))
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

	// Token: 0x060007B3 RID: 1971 RVA: 0x00027028 File Offset: 0x00025228
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		this.InitTurnForward(charActorComp);
		this.EndTime = (double)this.TsLoopTime + Time.Instance.WorldTime;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00027078 File Offset: 0x00025278
	private void InitTurnForward(CharacterActorComponent actorComp)
	{
		if (this.EndForward == null)
		{
			this.EndForward = global::Vector.Create();
		}
		if (this.TsTurnToPlayer)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null)
			{
				baseCharacter.CharacterActorComponent.ActorLocationProxy.Subtraction(actorComp.ActorLocationProxy, this.EndForward);
			}
		}
		else if (this.TsTargetConfigId > 0)
		{
			List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
			int i = 0;
			int count = allScenePlayers.Count;
			while (i < count)
			{
				ScenePlayerData scenePlayerData = allScenePlayers[i];
				foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItemsByPlayer(scenePlayerData.GetPlayerId()))
				{
					EntityHandle entityHandle = sceneTeamItem.EntityHandle;
					if (entityHandle != null)
					{
						CreatureDataComponent component = entityHandle.Entity.GetComponent<CreatureDataComponent>();
						if (component != null && component.GetVisible() && component.GetPbDataId() == this.TsTargetConfigId)
						{
							scenePlayerData.GetLocation().Subtraction(actorComp.ActorLocationProxy, this.EndForward);
						}
					}
				}
				i++;
			}
		}
		else if (this.TsTargetEntityKey != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(actorComp.Entity.Id, this.TsTargetEntityKey);
			EntitySystem.Instance.Get(entityIdByEntity.Value).GetComponent<CharacterActorComponent>().ActorLocationProxy.Subtraction(actorComp.ActorLocationProxy, this.EndForward);
		}
		else if (this.TsTargetDirectKey != "")
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(actorComp.Entity.Id, this.TsTargetDirectKey);
			if (vectorValueByEntity != null)
			{
				this.EndForward.FromUeVector(vectorValueByEntity);
			}
		}
		else
		{
			global::Vector vector = global::Vector.Create(actorComp.ActorForward);
			vector.Normalize(1E-08);
			vector.RotateAngleAxis((double)this.TsTurnAngleAxis, global::Vector.UpVectorProxy, this.EndForward);
		}
		this.EndForward.Z = 0.0;
		this.EndForward.Normalize(1E-08);
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x000272A4 File Offset: 0x000254A4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskDoTurn) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskDoTurn.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x0002735C File Offset: 0x0002555C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
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
			base.FinishExecute(false);
			return;
		}
		FVectorDouble actorForward = aiController.CharActorComp.ActorForward;
		if (MathUtils.Instance.GetAngleByVectorDot(actorForward, this.EndForward) <= (double)this.TsMinAngle)
		{
			base.Finish(true);
			return;
		}
		AiControllerLibrary.TurnToDirect(aiController.CharActorComp, this.EndForward, this.TsTurnSpeed, false, 0f);
		if (this.EndTime < Time.Instance.WorldTime)
		{
			base.Finish(true);
		}
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00027423 File Offset: 0x00025623
	protected override void OnClear()
	{
		this.EndForward.Reset();
		this.EndTime = 0.0;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0002743F File Offset: 0x0002563F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskDoTurn._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskDoTurn.TsTaskDoTurn_C");
		}
		return TsTaskDoTurn._ClassPtr;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00027464 File Offset: 0x00025664
	public TsTaskDoTurn() : this(BuiltinUtils.AllocNativeUObject(TsTaskDoTurn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0002748C File Offset: 0x0002568C
	public TsTaskDoTurn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskDoTurn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000274BF File Offset: 0x000256BF
	protected TsTaskDoTurn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x000274E0 File Offset: 0x000256E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00027510 File Offset: 0x00025710
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000599 RID: 1433
	private bool IsInitTsVariables;

	// Token: 0x0400059A RID: 1434
	private bool TsTurnToPlayer;

	// Token: 0x0400059B RID: 1435
	private int TsTargetConfigId;

	// Token: 0x0400059C RID: 1436
	private string TsTargetEntityKey = "";

	// Token: 0x0400059D RID: 1437
	private string TsTargetDirectKey = "";

	// Token: 0x0400059E RID: 1438
	private float TsTurnAngleAxis;

	// Token: 0x0400059F RID: 1439
	private float TsTurnSpeed;

	// Token: 0x040005A0 RID: 1440
	private float TsMinAngle;

	// Token: 0x040005A1 RID: 1441
	private float TsLoopTime;

	// Token: 0x040005A2 RID: 1442
	[Nullable(2)]
	private global::Vector EndForward;

	// Token: 0x040005A3 RID: 1443
	private double EndTime;

	// Token: 0x040005A4 RID: 1444
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskDoTurn.TsTaskDoTurn_C";

	// Token: 0x040005A5 RID: 1445
	private static IntPtr _ClassPtr;

	// Token: 0x040005A6 RID: 1446
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005A7 RID: 1447
	private static int __PropertyOffset_TurnToPlayer;

	// Token: 0x040005A8 RID: 1448
	private static int __PropertyOffset_TargetConfigId;

	// Token: 0x040005A9 RID: 1449
	private static int __PropertyOffset_TargetEntityKey;

	// Token: 0x040005AA RID: 1450
	private static int __PropertyOffset_TargetDirectKey;

	// Token: 0x040005AB RID: 1451
	private static int __PropertyOffset_TurnAngleAxis;

	// Token: 0x040005AC RID: 1452
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040005AD RID: 1453
	private static int __PropertyOffset_MinAngle;

	// Token: 0x040005AE RID: 1454
	private static int __PropertyOffset_LoopTime;
}

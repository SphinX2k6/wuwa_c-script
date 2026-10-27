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
	// Token: 0x17000134 RID: 308
	// (get) Token: 0x0600079D RID: 1949 RVA: 0x00026055 File Offset: 0x00024255
	// (set) Token: 0x0600079E RID: 1950 RVA: 0x00026065 File Offset: 0x00024265
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

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x0600079F RID: 1951 RVA: 0x00026076 File Offset: 0x00024276
	// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00026086 File Offset: 0x00024286
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

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00026097 File Offset: 0x00024297
	// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000260AB File Offset: 0x000242AB
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

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060007A3 RID: 1955 RVA: 0x000260C0 File Offset: 0x000242C0
	// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000260D4 File Offset: 0x000242D4
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

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000260E9 File Offset: 0x000242E9
	// (set) Token: 0x060007A6 RID: 1958 RVA: 0x000260F9 File Offset: 0x000242F9
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

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0002610A File Offset: 0x0002430A
	// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0002611A File Offset: 0x0002431A
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

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0002612B File Offset: 0x0002432B
	// (set) Token: 0x060007AA RID: 1962 RVA: 0x0002613B File Offset: 0x0002433B
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

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060007AB RID: 1963 RVA: 0x0002614C File Offset: 0x0002434C
	// (set) Token: 0x060007AC RID: 1964 RVA: 0x0002615C File Offset: 0x0002435C
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

	// Token: 0x060007AD RID: 1965 RVA: 0x00026170 File Offset: 0x00024370
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

	// Token: 0x060007AE RID: 1966 RVA: 0x000261F4 File Offset: 0x000243F4
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

	// Token: 0x060007AF RID: 1967 RVA: 0x00026290 File Offset: 0x00024490
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

	// Token: 0x060007B0 RID: 1968 RVA: 0x000262E0 File Offset: 0x000244E0
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

	// Token: 0x060007B1 RID: 1969 RVA: 0x0002650C File Offset: 0x0002470C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x000265AC File Offset: 0x000247AC
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

	// Token: 0x060007B3 RID: 1971 RVA: 0x00026673 File Offset: 0x00024873
	protected override void OnClear()
	{
		this.EndForward.Reset();
		this.EndTime = 0.0;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0002668F File Offset: 0x0002488F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskDoTurn._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskDoTurn.TsTaskDoTurn_C");
		}
		return TsTaskDoTurn._ClassPtr;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x000266B4 File Offset: 0x000248B4
	public TsTaskDoTurn() : this(BuiltinUtils.AllocNativeUObject(TsTaskDoTurn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x000266DC File Offset: 0x000248DC
	public TsTaskDoTurn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskDoTurn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0002670F File Offset: 0x0002490F
	protected TsTaskDoTurn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00026730 File Offset: 0x00024930
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00026760 File Offset: 0x00024960
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000595 RID: 1429
	private bool IsInitTsVariables;

	// Token: 0x04000596 RID: 1430
	private bool TsTurnToPlayer;

	// Token: 0x04000597 RID: 1431
	private int TsTargetConfigId;

	// Token: 0x04000598 RID: 1432
	private string TsTargetEntityKey = "";

	// Token: 0x04000599 RID: 1433
	private string TsTargetDirectKey = "";

	// Token: 0x0400059A RID: 1434
	private float TsTurnAngleAxis;

	// Token: 0x0400059B RID: 1435
	private float TsTurnSpeed;

	// Token: 0x0400059C RID: 1436
	private float TsMinAngle;

	// Token: 0x0400059D RID: 1437
	private float TsLoopTime;

	// Token: 0x0400059E RID: 1438
	[Nullable(2)]
	private global::Vector EndForward;

	// Token: 0x0400059F RID: 1439
	private double EndTime;

	// Token: 0x040005A0 RID: 1440
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskDoTurn.TsTaskDoTurn_C";

	// Token: 0x040005A1 RID: 1441
	private static IntPtr _ClassPtr;

	// Token: 0x040005A2 RID: 1442
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005A3 RID: 1443
	private static int __PropertyOffset_TurnToPlayer;

	// Token: 0x040005A4 RID: 1444
	private static int __PropertyOffset_TargetConfigId;

	// Token: 0x040005A5 RID: 1445
	private static int __PropertyOffset_TargetEntityKey;

	// Token: 0x040005A6 RID: 1446
	private static int __PropertyOffset_TargetDirectKey;

	// Token: 0x040005A7 RID: 1447
	private static int __PropertyOffset_TurnAngleAxis;

	// Token: 0x040005A8 RID: 1448
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040005A9 RID: 1449
	private static int __PropertyOffset_MinAngle;

	// Token: 0x040005AA RID: 1450
	private static int __PropertyOffset_LoopTime;
}

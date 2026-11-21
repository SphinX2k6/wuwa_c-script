using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000CB RID: 203
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTargetContinuously.TsTaskTurnToTargetContinuously_C")]
public class TsTaskTurnToTargetContinuously : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0003C18B File Offset: 0x0003A38B
	// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0003C19F File Offset: 0x0003A39F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyActor
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToTargetContinuously.__PropertyOffset_BlackboardKeyActor)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToTargetContinuously.__PropertyOffset_BlackboardKeyActor)), value);
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
	// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0003C1C4 File Offset: 0x0003A3C4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToTargetContinuously.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToTargetContinuously.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0003C1D5 File Offset: 0x0003A3D5
	// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0003C1E5 File Offset: 0x0003A3E5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EndAfterTurnToTarget
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToTargetContinuously.__PropertyOffset_EndAfterTurnToTarget) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToTargetContinuously.__PropertyOffset_EndAfterTurnToTarget) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0003C1F6 File Offset: 0x0003A3F6
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyActor = this.BlackboardKeyActor;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsEndAfterTurnToTarget = this.EndAfterTurnToTarget;
		}
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0003C234 File Offset: 0x0003A434
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToTargetContinuously) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurnToTargetContinuously.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000BD5 RID: 3029 RVA: 0x0003C2EC File Offset: 0x0003A4EC
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		this.InitTsVariables();
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		BaseActorComponent baseActorComponent;
		if (currentTarget == null)
		{
			baseActorComponent = null;
		}
		else
		{
			WorldEntity entity = currentTarget.Entity;
			baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
		}
		BaseActorComponent baseActorComponent2 = baseActorComponent;
		if (this.TsBlackboardKeyActor == "_currentPlayer")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			BaseActorComponent baseActorComponent3;
			if (baseCharacter == null)
			{
				baseActorComponent3 = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					baseActorComponent3 = null;
				}
				else
				{
					Entity entity2 = characterActorComponent.Entity;
					baseActorComponent3 = ((entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null);
				}
			}
			baseActorComponent2 = baseActorComponent3;
		}
		else if (this.TsBlackboardKeyActor != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyActor);
			if (entityIdByEntity != null)
			{
				baseActorComponent2 = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityIdByEntity.Value);
			}
		}
		if (baseActorComponent2 == null)
		{
			base.FinishExecute(false);
			return;
		}
		AiControllerLibrary.TurnToTarget(charActorComp, baseActorComponent2.ActorLocationProxy, this.TsTurnSpeed, false, 0f);
		if (this.TsEndAfterTurnToTarget && GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(charActorComp) < 5f)
		{
			base.FinishExecute(true);
		}
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0003C44D File Offset: 0x0003A64D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToTargetContinuously._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTargetContinuously.TsTaskTurnToTargetContinuously_C");
		}
		return TsTaskTurnToTargetContinuously._ClassPtr;
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x0003C474 File Offset: 0x0003A674
	public TsTaskTurnToTargetContinuously() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTargetContinuously.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0003C49C File Offset: 0x0003A69C
	public TsTaskTurnToTargetContinuously(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTargetContinuously.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0003C4CF File Offset: 0x0003A6CF
	protected TsTaskTurnToTargetContinuously(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0003C4E4 File Offset: 0x0003A6E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400094E RID: 2382
	private const float TOLERANCE_ANGLE = 5f;

	// Token: 0x0400094F RID: 2383
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x04000950 RID: 2384
	private bool IsInitTsVariables;

	// Token: 0x04000951 RID: 2385
	private string TsBlackboardKeyActor = "";

	// Token: 0x04000952 RID: 2386
	private float TsTurnSpeed;

	// Token: 0x04000953 RID: 2387
	private bool TsEndAfterTurnToTarget;

	// Token: 0x04000954 RID: 2388
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTargetContinuously.TsTaskTurnToTargetContinuously_C";

	// Token: 0x04000955 RID: 2389
	private static IntPtr _ClassPtr;

	// Token: 0x04000956 RID: 2390
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000957 RID: 2391
	private static int __PropertyOffset_BlackboardKeyActor;

	// Token: 0x04000958 RID: 2392
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000959 RID: 2393
	private static int __PropertyOffset_EndAfterTurnToTarget;
}

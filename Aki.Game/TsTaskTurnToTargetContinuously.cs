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
	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0003AF23 File Offset: 0x00039123
	// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0003AF37 File Offset: 0x00039137
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

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0003AF4C File Offset: 0x0003914C
	// (set) Token: 0x06000BCA RID: 3018 RVA: 0x0003AF5C File Offset: 0x0003915C
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

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0003AF6D File Offset: 0x0003916D
	// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0003AF7D File Offset: 0x0003917D
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

	// Token: 0x06000BCD RID: 3021 RVA: 0x0003AF8E File Offset: 0x0003918E
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

	// Token: 0x06000BCE RID: 3022 RVA: 0x0003AFCC File Offset: 0x000391CC
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

	// Token: 0x06000BCF RID: 3023 RVA: 0x0003B06C File Offset: 0x0003926C
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
		CharacterActorComponent characterActorComponent;
		if (currentTarget == null)
		{
			characterActorComponent = null;
		}
		else
		{
			WorldEntity entity = currentTarget.Entity;
			characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		if (this.TsBlackboardKeyActor == "_currentPlayer")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent3;
			if (baseCharacter == null)
			{
				characterActorComponent3 = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent4 = baseCharacter.CharacterActorComponent;
				if (characterActorComponent4 == null)
				{
					characterActorComponent3 = null;
				}
				else
				{
					Entity entity2 = characterActorComponent4.Entity;
					characterActorComponent3 = ((entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null);
				}
			}
			characterActorComponent2 = characterActorComponent3;
		}
		else if (this.TsBlackboardKeyActor != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyActor);
			if (entityIdByEntity != null)
			{
				characterActorComponent2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityIdByEntity.Value);
			}
		}
		if (characterActorComponent2 == null)
		{
			base.FinishExecute(false);
			return;
		}
		AiControllerLibrary.TurnToTarget(charActorComp, characterActorComponent2.ActorLocationProxy, this.TsTurnSpeed, false, 0f);
		if (this.TsEndAfterTurnToTarget && GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(charActorComp) < 5f)
		{
			base.FinishExecute(true);
		}
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0003B1CD File Offset: 0x000393CD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToTargetContinuously._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTargetContinuously.TsTaskTurnToTargetContinuously_C");
		}
		return TsTaskTurnToTargetContinuously._ClassPtr;
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x0003B1F4 File Offset: 0x000393F4
	public TsTaskTurnToTargetContinuously() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTargetContinuously.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x0003B21C File Offset: 0x0003941C
	public TsTaskTurnToTargetContinuously(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTargetContinuously.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0003B24F File Offset: 0x0003944F
	protected TsTaskTurnToTargetContinuously(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0003B264 File Offset: 0x00039464
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000946 RID: 2374
	private const float TOLERANCE_ANGLE = 5f;

	// Token: 0x04000947 RID: 2375
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x04000948 RID: 2376
	private bool IsInitTsVariables;

	// Token: 0x04000949 RID: 2377
	private string TsBlackboardKeyActor = "";

	// Token: 0x0400094A RID: 2378
	private float TsTurnSpeed;

	// Token: 0x0400094B RID: 2379
	private bool TsEndAfterTurnToTarget;

	// Token: 0x0400094C RID: 2380
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTargetContinuously.TsTaskTurnToTargetContinuously_C";

	// Token: 0x0400094D RID: 2381
	private static IntPtr _ClassPtr;

	// Token: 0x0400094E RID: 2382
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400094F RID: 2383
	private static int __PropertyOffset_BlackboardKeyActor;

	// Token: 0x04000950 RID: 2384
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000951 RID: 2385
	private static int __PropertyOffset_EndAfterTurnToTarget;
}

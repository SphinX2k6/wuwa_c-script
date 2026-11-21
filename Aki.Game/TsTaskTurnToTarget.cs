using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000CA RID: 202
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTarget.TsTaskTurnToTarget_C")]
public class TsTaskTurnToTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0003BE23 File Offset: 0x0003A023
	// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0003BE37 File Offset: 0x0003A037
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyActor
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToTarget.__PropertyOffset_BlackboardKeyActor)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToTarget.__PropertyOffset_BlackboardKeyActor)), value);
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0003BE4C File Offset: 0x0003A04C
	// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0003BE5C File Offset: 0x0003A05C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToTarget.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToTarget.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0003BE6D File Offset: 0x0003A06D
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyActor = this.BlackboardKeyActor;
			this.TsTurnSpeed = this.TurnSpeed;
		}
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0003BEA0 File Offset: 0x0003A0A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurnToTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000BC7 RID: 3015 RVA: 0x0003BF58 File Offset: 0x0003A158
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
			CharacterActorComponent characterActorComponent5 = characterActorComponent3;
			if (characterActorComponent5 == null)
			{
				Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.LCZ, "不存在玩家", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterActorComponent2 = characterActorComponent5;
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
		base.FinishExecute(true);
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTarget.TsTaskTurnToTarget_C");
		}
		return TsTaskTurnToTarget._ClassPtr;
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
	public TsTaskTurnToTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x0003C110 File Offset: 0x0003A310
	public TsTaskTurnToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0003C143 File Offset: 0x0003A343
	protected TsTaskTurnToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0003C158 File Offset: 0x0003A358
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000945 RID: 2373
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x04000946 RID: 2374
	private bool IsInitTsVariables;

	// Token: 0x04000947 RID: 2375
	private string TsBlackboardKeyActor = "";

	// Token: 0x04000948 RID: 2376
	private float TsTurnSpeed;

	// Token: 0x04000949 RID: 2377
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTarget.TsTaskTurnToTarget_C";

	// Token: 0x0400094A RID: 2378
	private static IntPtr _ClassPtr;

	// Token: 0x0400094B RID: 2379
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400094C RID: 2380
	private static int __PropertyOffset_BlackboardKeyActor;

	// Token: 0x0400094D RID: 2381
	private static int __PropertyOffset_TurnSpeed;
}

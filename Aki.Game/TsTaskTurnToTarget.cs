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
	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0003ABD3 File Offset: 0x00038DD3
	// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0003ABE7 File Offset: 0x00038DE7
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

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0003ABFC File Offset: 0x00038DFC
	// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0003AC0C File Offset: 0x00038E0C
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

	// Token: 0x06000BBF RID: 3007 RVA: 0x0003AC1D File Offset: 0x00038E1D
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyActor = this.BlackboardKeyActor;
			this.TsTurnSpeed = this.TurnSpeed;
		}
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0003AC50 File Offset: 0x00038E50
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

	// Token: 0x06000BC1 RID: 3009 RVA: 0x0003ACF0 File Offset: 0x00038EF0
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

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0003AE5C File Offset: 0x0003905C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTarget.TsTaskTurnToTarget_C");
		}
		return TsTaskTurnToTarget._ClassPtr;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0003AE80 File Offset: 0x00039080
	public TsTaskTurnToTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x0003AEA8 File Offset: 0x000390A8
	public TsTaskTurnToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0003AEDB File Offset: 0x000390DB
	protected TsTaskTurnToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0003AEF0 File Offset: 0x000390F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400093D RID: 2365
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x0400093E RID: 2366
	private bool IsInitTsVariables;

	// Token: 0x0400093F RID: 2367
	private string TsBlackboardKeyActor = "";

	// Token: 0x04000940 RID: 2368
	private float TsTurnSpeed;

	// Token: 0x04000941 RID: 2369
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToTarget.TsTaskTurnToTarget_C";

	// Token: 0x04000942 RID: 2370
	private static IntPtr _ClassPtr;

	// Token: 0x04000943 RID: 2371
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000944 RID: 2372
	private static int __PropertyOffset_BlackboardKeyActor;

	// Token: 0x04000945 RID: 2373
	private static int __PropertyOffset_TurnSpeed;
}

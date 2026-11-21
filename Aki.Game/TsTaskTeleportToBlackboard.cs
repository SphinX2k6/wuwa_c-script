using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C7 RID: 199
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeleportToBlackboard.TsTaskTeleportToBlackboard_C")]
public class TsTaskTeleportToBlackboard : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003A8BB File Offset: 0x00038ABB
	// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0003A8CF File Offset: 0x00038ACF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTeleportToBlackboard.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTeleportToBlackboard.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0003A8E4 File Offset: 0x00038AE4
	// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0003A91D File Offset: 0x00038B1D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> TeleportEffectBuffId
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._TeleportEffectBuffId) == null)
			{
				result = (this._TeleportEffectBuffId = new TArray<int>(base.NativePtr + (IntPtr)TsTaskTeleportToBlackboard.__PropertyOffset_TeleportEffectBuffId, this));
			}
			return result;
		}
		set
		{
			this.TeleportEffectBuffId.CopyAssign(value);
		}
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x0003A92C File Offset: 0x00038B2C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsTeleportEffectBuffId = new int[this.TeleportEffectBuffId.Num()];
			int i = 0;
			int num = this.TeleportEffectBuffId.Num();
			while (i < num)
			{
				this.TsTeleportEffectBuffId[i] = this.TeleportEffectBuffId.Get(i);
				i++;
			}
		}
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x0003A9A0 File Offset: 0x00038BA0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTeleportToBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTeleportToBlackboard.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B85 RID: 2949 RVA: 0x0003AA50 File Offset: 0x00038C50
	[NullableContext(2)]
	protected void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int id = aiController.CharAiDesignComp.Entity.Id;
		Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(id, this.TsBlackboardKey);
		if (vectorValueByEntity == null)
		{
			base.Finish(false);
			return;
		}
		if (this.TsTeleportEffectBuffId != null)
		{
			Entity entity = aiController.CharAiDesignComp.Entity;
			BaseGameplayCueComponent baseGameplayCueComponent = (entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null;
			foreach (int num in this.TsTeleportEffectBuffId)
			{
				if (baseGameplayCueComponent != null)
				{
					baseGameplayCueComponent.AddCue((long)num, new GameplayCueParam?(new GameplayCueParam
					{
						Instant = true
					}));
				}
			}
		}
		this.Target.X = (double)vectorValueByEntity.X;
		this.Target.Y = (double)vectorValueByEntity.Y;
		this.Target.Z = (double)vectorValueByEntity.Z;
		charActorComp.TeleportTo(this.Target.ToUeVector(false), charActorComp.ActorRotationProxy.ToUeRotator(), "黑板传送");
		base.Finish(true);
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0003AB7F File Offset: 0x00038D7F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTeleportToBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeleportToBlackboard.TsTaskTeleportToBlackboard_C");
		}
		return TsTaskTeleportToBlackboard._ClassPtr;
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x0003ABA4 File Offset: 0x00038DA4
	public TsTaskTeleportToBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsTaskTeleportToBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x0003ABCC File Offset: 0x00038DCC
	public TsTaskTeleportToBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeleportToBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x0003ABFF File Offset: 0x00038DFF
	protected TsTaskTeleportToBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0003AC20 File Offset: 0x00038E20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000908 RID: 2312
	private bool IsInitTsVariables;

	// Token: 0x04000909 RID: 2313
	private string TsBlackboardKey = "";

	// Token: 0x0400090A RID: 2314
	[Nullable(2)]
	private int[] TsTeleportEffectBuffId;

	// Token: 0x0400090B RID: 2315
	private readonly global::Vector Target = global::Vector.Create();

	// Token: 0x0400090C RID: 2316
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeleportToBlackboard.TsTaskTeleportToBlackboard_C";

	// Token: 0x0400090D RID: 2317
	private static IntPtr _ClassPtr;

	// Token: 0x0400090E RID: 2318
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400090F RID: 2319
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x04000910 RID: 2320
	private static int __PropertyOffset_TeleportEffectBuffId;

	// Token: 0x04000911 RID: 2321
	[Nullable(2)]
	private TArray<int> _TeleportEffectBuffId;
}

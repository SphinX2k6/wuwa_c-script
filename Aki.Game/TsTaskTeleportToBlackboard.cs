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
	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0003968B File Offset: 0x0003788B
	// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0003969F File Offset: 0x0003789F
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

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000396B4 File Offset: 0x000378B4
	// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000396ED File Offset: 0x000378ED
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

	// Token: 0x06000B7D RID: 2941 RVA: 0x000396FC File Offset: 0x000378FC
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

	// Token: 0x06000B7E RID: 2942 RVA: 0x00039770 File Offset: 0x00037970
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

	// Token: 0x06000B7F RID: 2943 RVA: 0x0003980C File Offset: 0x00037A0C
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

	// Token: 0x06000B80 RID: 2944 RVA: 0x0003993B File Offset: 0x00037B3B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTeleportToBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeleportToBlackboard.TsTaskTeleportToBlackboard_C");
		}
		return TsTaskTeleportToBlackboard._ClassPtr;
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x00039960 File Offset: 0x00037B60
	public TsTaskTeleportToBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsTaskTeleportToBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00039988 File Offset: 0x00037B88
	public TsTaskTeleportToBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeleportToBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x000399BB File Offset: 0x00037BBB
	protected TsTaskTeleportToBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x000399DC File Offset: 0x00037BDC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000900 RID: 2304
	private bool IsInitTsVariables;

	// Token: 0x04000901 RID: 2305
	private string TsBlackboardKey = "";

	// Token: 0x04000902 RID: 2306
	[Nullable(2)]
	private int[] TsTeleportEffectBuffId;

	// Token: 0x04000903 RID: 2307
	private readonly global::Vector Target = global::Vector.Create();

	// Token: 0x04000904 RID: 2308
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeleportToBlackboard.TsTaskTeleportToBlackboard_C";

	// Token: 0x04000905 RID: 2309
	private static IntPtr _ClassPtr;

	// Token: 0x04000906 RID: 2310
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000907 RID: 2311
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x04000908 RID: 2312
	private static int __PropertyOffset_TeleportEffectBuffId;

	// Token: 0x04000909 RID: 2313
	[Nullable(2)]
	private TArray<int> _TeleportEffectBuffId;
}

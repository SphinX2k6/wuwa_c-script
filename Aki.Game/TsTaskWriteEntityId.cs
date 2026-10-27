using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000D1 RID: 209
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWriteEntityId.TsTaskWriteEntityId_C")]
public class TsTaskWriteEntityId : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0004056F File Offset: 0x0003E76F
	// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00040583 File Offset: 0x0003E783
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTarget
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyTarget)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyTarget)), value);
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00040598 File Offset: 0x0003E798
	// (set) Token: 0x06000C86 RID: 3206 RVA: 0x000405AC File Offset: 0x0003E7AC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyWriteTo
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyWriteTo)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyWriteTo)), value);
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x000405C1 File Offset: 0x0003E7C1
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyTarget = this.BlackboardKeyTarget;
			this.TsBlackboardKeyWriteTo = this.BlackboardKeyWriteTo;
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x000405F4 File Offset: 0x0003E7F4
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

	// Token: 0x06000C89 RID: 3209 RVA: 0x00040694 File Offset: 0x0003E894
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
		this.InitTsVariables();
		if (this.TsBlackboardKeyTarget == "")
		{
			base.FinishExecute(false);
			return;
		}
		int num = 0;
		if (this.TsBlackboardKeyTarget != "")
		{
			num = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyTarget).GetValueOrDefault();
			if (num == 0)
			{
				base.FinishExecute(false);
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(num);
			object obj;
			if (entityById == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = entityById.Entity;
				if (entity == null)
				{
					obj = null;
				}
				else
				{
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					obj = ((component != null) ? component.Owner : null);
				}
			}
			if (!(obj is TsBaseCharacter))
			{
				base.FinishExecute(false);
				return;
			}
		}
		BlackboardController.Instance.SetEntityIdByEntity(num, this.TsBlackboardKeyWriteTo, aiController.CharAiDesignComp.Entity.Id);
		base.FinishExecute(true);
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x000407C1 File Offset: 0x0003E9C1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskWriteEntityId._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWriteEntityId.TsTaskWriteEntityId_C");
		}
		return TsTaskWriteEntityId._ClassPtr;
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x000407E8 File Offset: 0x0003E9E8
	public TsTaskWriteEntityId() : this(BuiltinUtils.AllocNativeUObject(TsTaskWriteEntityId.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00040810 File Offset: 0x0003EA10
	public TsTaskWriteEntityId(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWriteEntityId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00040843 File Offset: 0x0003EA43
	protected TsTaskWriteEntityId(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00040864 File Offset: 0x0003EA64
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000A04 RID: 2564
	private bool IsInitTsVariables;

	// Token: 0x04000A05 RID: 2565
	private string TsBlackboardKeyTarget = "";

	// Token: 0x04000A06 RID: 2566
	private string TsBlackboardKeyWriteTo = "";

	// Token: 0x04000A07 RID: 2567
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWriteEntityId.TsTaskWriteEntityId_C";

	// Token: 0x04000A08 RID: 2568
	private static IntPtr _ClassPtr;

	// Token: 0x04000A09 RID: 2569
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000A0A RID: 2570
	private static int __PropertyOffset_BlackboardKeyTarget;

	// Token: 0x04000A0B RID: 2571
	private static int __PropertyOffset_BlackboardKeyWriteTo;
}

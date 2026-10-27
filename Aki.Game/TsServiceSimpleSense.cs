using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000057 RID: 87
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceSimpleSense.TsServiceSimpleSense_C")]
public class TsServiceSimpleSense : UBTService_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000352 RID: 850 RVA: 0x0000F72B File Offset: 0x0000D92B
	// (set) Token: 0x06000353 RID: 851 RVA: 0x0000F73F File Offset: 0x0000D93F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange SenseRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsServiceSimpleSense.__PropertyOffset_SenseRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsServiceSimpleSense.__PropertyOffset_SenseRadius) = value;
		}
	}

	// Token: 0x06000354 RID: 852 RVA: 0x0000F754 File Offset: 0x0000D954
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
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

	// Token: 0x06000355 RID: 853 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return;
		}
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			return;
		}
		Entity entity = charActorComp.Entity;
		PawnSensoryInfoComponent component = entity.GetComponent<PawnSensoryInfoComponent>();
		if (component == null)
		{
			return;
		}
		if (!this.IsInit)
		{
			this.IsInit = true;
			float value = this.SenseRadius.LowerBound.Value;
			float value2 = this.SenseRadius.UpperBound.Value;
			this.MinRangeSquared = (double)(value * value);
			this.MaxRangeSquared = (double)(value2 * value2);
			component.SetLogicRange(value2);
		}
		double playerDistSquared = component.PlayerDistSquared;
		int num;
		if (playerDistSquared > this.MaxRangeSquared)
		{
			num = 0;
			if (this.IsEnter)
			{
				this.IsEnter = false;
			}
		}
		else if (playerDistSquared > this.MinRangeSquared)
		{
			if (this.IsEnter)
			{
				num = baseCharacter.CharacterActorComponent.Entity.Id;
			}
			else
			{
				num = 0;
			}
		}
		else
		{
			num = baseCharacter.CharacterActorComponent.Entity.Id;
			if (!this.IsEnter)
			{
				this.IsEnter = true;
			}
		}
		if (num == 0)
		{
			if (this.IsSetNearerPlayerId)
			{
				this.IsSetNearerPlayerId = false;
				BlackboardController.Instance.RemoveValueByEntity(entity.Id, ENpcBlackBoardKeys.NearerPlayerId.ToString());
			}
		}
		else
		{
			BlackboardController.Instance.SetEntityIdByEntity(entity.Id, ENpcBlackBoardKeys.NearerPlayerId.ToString(), num);
			this.IsSetNearerPlayerId = true;
		}
		BlackboardController.Instance.SetIntValueByEntity(entity.Id, "NearerPlayerIntId", num);
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0000F982 File Offset: 0x0000DB82
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsServiceSimpleSense._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceSimpleSense.TsServiceSimpleSense_C");
		}
		return TsServiceSimpleSense._ClassPtr;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
	public TsServiceSimpleSense() : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
	[NullableContext(1)]
	public TsServiceSimpleSense(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0000FA03 File Offset: 0x0000DC03
	protected TsServiceSimpleSense(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0000FA0C File Offset: 0x0000DC0C
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400022B RID: 555
	[Nullable(1)]
	private const string NRARER_PLAYER_INT_ID = "NearerPlayerIntId";

	// Token: 0x0400022C RID: 556
	private bool IsEnter;

	// Token: 0x0400022D RID: 557
	private bool IsInit;

	// Token: 0x0400022E RID: 558
	private double MinRangeSquared;

	// Token: 0x0400022F RID: 559
	private double MaxRangeSquared;

	// Token: 0x04000230 RID: 560
	private bool IsSetNearerPlayerId;

	// Token: 0x04000231 RID: 561
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceSimpleSense.TsServiceSimpleSense_C";

	// Token: 0x04000232 RID: 562
	private static IntPtr _ClassPtr;

	// Token: 0x04000233 RID: 563
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000234 RID: 564
	private static int __PropertyOffset_SenseRadius;
}

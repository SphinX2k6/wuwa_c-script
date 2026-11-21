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
	// (get) Token: 0x06000352 RID: 850 RVA: 0x0000FE5B File Offset: 0x0000E05B
	// (set) Token: 0x06000353 RID: 851 RVA: 0x0000FE6F File Offset: 0x0000E06F
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

	// Token: 0x06000354 RID: 852 RVA: 0x0000FE84 File Offset: 0x0000E084
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsServiceSimpleSense) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsServiceSimpleSense.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000355 RID: 853 RVA: 0x0000FF3C File Offset: 0x0000E13C
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

	// Token: 0x06000356 RID: 854 RVA: 0x000100CA File Offset: 0x0000E2CA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsServiceSimpleSense._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceSimpleSense.TsServiceSimpleSense_C");
		}
		return TsServiceSimpleSense._ClassPtr;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x000100F0 File Offset: 0x0000E2F0
	public TsServiceSimpleSense() : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00010118 File Offset: 0x0000E318
	[NullableContext(1)]
	public TsServiceSimpleSense(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceSimpleSense.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0001014B File Offset: 0x0000E34B
	protected TsServiceSimpleSense(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00010154 File Offset: 0x0000E354
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

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000055 RID: 85
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceAnimalPerception.TsServiceAnimalPerception_C")]
public class TsServiceAnimalPerception : UBTService_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700007D RID: 125
	// (get) Token: 0x0600033C RID: 828 RVA: 0x0000F44B File Offset: 0x0000D64B
	// (set) Token: 0x0600033D RID: 829 RVA: 0x0000F45F File Offset: 0x0000D65F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange SenseRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsServiceAnimalPerception.__PropertyOffset_SenseRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsServiceAnimalPerception.__PropertyOffset_SenseRadius) = value;
		}
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0000F474 File Offset: 0x0000D674
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			float value = this.SenseRadius.LowerBound.Value;
			float value2 = this.SenseRadius.UpperBound.Value;
			this.MinRangeSquared = (double)(value * value);
			this.MaxRangeSquared = (double)(value2 * value2);
			this.VectorCache = Vector.Create();
			this.IsEnter = false;
			this.IsSetNearerPlayerId = false;
			this.IsInitTsVariables = true;
		}
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveActivationAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsServiceAnimalPerception) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveActivationAI"), TsServiceAnimalPerception.StaticClass(), out intPtr, out num))
		{
			this.ReceiveActivationAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTService_BlueprintBase.__ReceiveActivationAI_FunctionParams* ptr = stackalloc UBTService_BlueprintBase.__ReceiveActivationAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTService_BlueprintBase.__ReceiveActivationAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0000F598 File Offset: 0x0000D798
	[NullableContext(2)]
	protected virtual void ReceiveActivationAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (!(ownerController is TsAiController))
		{
			return;
		}
		this.InitTsVariables();
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0000F5AC File Offset: 0x0000D7AC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsServiceAnimalPerception) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsServiceAnimalPerception.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000342 RID: 834 RVA: 0x0000F664 File Offset: 0x0000D864
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			return;
		}
		this.InitTsVariables();
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		this.HandlePerception(charActorComp);
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
	[NullableContext(1)]
	private unsafe void HandlePerception(CharacterActorComponent actorComp)
	{
		Entity entity = actorComp.Entity;
		EntityHandle entityHandle;
		double num;
		if (GameModeModel.Instance.IsMulti)
		{
			ValueTuple<EntityHandle, double> minPlayerDistSquared = this.GetMinPlayerDistSquared(actorComp.ActorLocationProxy);
			entityHandle = minPlayerDistSquared.Item1;
			num = minPlayerDistSquared.Item2;
		}
		else
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				if (this.IsSetNearerPlayerId)
				{
					this.IsSetNearerPlayerId = false;
					BlackboardController.Instance.RemoveValueByEntity(entity.Id, ENpcBlackBoardKeys.NearerPlayerId.ToString());
				}
				return;
			}
			entityHandle = CreatureModel.Instance.GetEntityById(baseCharacter.EntityId);
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			Vector vector = (characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null;
			if (vector == null || actorComp.ActorLocationProxy == null || this.VectorCache == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AnimalPerception] HandlePerception null detected";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", this);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("playerLocation", vector != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("actorLocationProxy", actorComp.ActorLocationProxy != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("VectorCache", this.VectorCache != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("charEntityId", baseCharacter.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("IsInitTsVariables", this.IsInitTsVariables);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				return;
			}
			vector.Subtraction(actorComp.ActorLocationProxy, this.VectorCache);
			num = this.VectorCache.SizeSquared();
		}
		if (entityHandle == null || !entityHandle.Valid)
		{
			if (this.IsSetNearerPlayerId)
			{
				this.IsSetNearerPlayerId = false;
				BlackboardController.Instance.RemoveValueByEntity(entity.Id, ENpcBlackBoardKeys.NearerPlayerId.ToString());
			}
			return;
		}
		int id = entityHandle.Id;
		double num2 = num;
		int num3;
		if (num2 > this.MaxRangeSquared)
		{
			num3 = 0;
			if (this.IsEnter)
			{
				this.IsEnter = false;
			}
		}
		else if (num2 > this.MinRangeSquared)
		{
			if (this.IsEnter)
			{
				num3 = id;
			}
			else
			{
				num3 = 0;
			}
		}
		else
		{
			num3 = id;
			if (!this.IsEnter)
			{
				this.IsEnter = true;
			}
		}
		if (num3 == 0)
		{
			if (this.IsSetNearerPlayerId)
			{
				this.IsSetNearerPlayerId = false;
				BlackboardController.Instance.RemoveValueByEntity(entity.Id, ENpcBlackBoardKeys.NearerPlayerId.ToString());
				return;
			}
		}
		else if (!PerformanceController.Instance.IsEntityPerformanceTest)
		{
			BlackboardController.Instance.SetEntityIdByEntity(entity.Id, ENpcBlackBoardKeys.NearerPlayerId.ToString(), num3);
			this.IsSetNearerPlayerId = true;
		}
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0000F984 File Offset: 0x0000DB84
	[NullableContext(1)]
	[return: TupleElementNames(new string[]
	{
		"PlayerEntity",
		"MinDistSquared"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private ValueTuple<EntityHandle, double> GetMinPlayerDistSquared(Vector selfLocation)
	{
		Dictionary<int, ScenePlayerData> scenePlayerDataMap = CreatureModel.Instance.ScenePlayerDataMap;
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle item = null;
		double num = 3.402823466E+38;
		foreach (KeyValuePair<int, ScenePlayerData> keyValuePair in scenePlayerDataMap)
		{
			SceneTeamItem teamItem = instance.GetTeamItem((long)keyValuePair.Key, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.PlayerId,
				IsControl = new bool?(true)
			});
			EntityHandle entityHandle = (teamItem != null) ? teamItem.EntityHandle : null;
			if (!(!entityHandle))
			{
				entityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy.Subtraction(selfLocation, this.VectorCache);
				double num2 = this.VectorCache.SizeSquared();
				if (num2 < num)
				{
					num = num2;
					item = entityHandle;
				}
			}
		}
		return new ValueTuple<EntityHandle, double>(item, num);
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0000FA64 File Offset: 0x0000DC64
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsServiceAnimalPerception._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceAnimalPerception.TsServiceAnimalPerception_C");
		}
		return TsServiceAnimalPerception._ClassPtr;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x0000FA88 File Offset: 0x0000DC88
	public TsServiceAnimalPerception() : this(BuiltinUtils.AllocNativeUObject(TsServiceAnimalPerception.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
	[NullableContext(1)]
	public TsServiceAnimalPerception(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceAnimalPerception.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000348 RID: 840 RVA: 0x0000FAE3 File Offset: 0x0000DCE3
	protected TsServiceAnimalPerception(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0000FAEC File Offset: 0x0000DCEC
	protected unsafe virtual void __CPPCALL_ReceiveActivationAI_Implementation(UBTService_BlueprintBase.__ReceiveActivationAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveActivationAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600034A RID: 842 RVA: 0x0000FB1C File Offset: 0x0000DD1C
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400021E RID: 542
	private bool IsInitTsVariables;

	// Token: 0x0400021F RID: 543
	[Nullable(2)]
	private Vector VectorCache;

	// Token: 0x04000220 RID: 544
	private double MinRangeSquared;

	// Token: 0x04000221 RID: 545
	private double MaxRangeSquared;

	// Token: 0x04000222 RID: 546
	private bool IsEnter;

	// Token: 0x04000223 RID: 547
	private bool IsSetNearerPlayerId;

	// Token: 0x04000224 RID: 548
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceAnimalPerception.TsServiceAnimalPerception_C";

	// Token: 0x04000225 RID: 549
	private static IntPtr _ClassPtr;

	// Token: 0x04000226 RID: 550
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000227 RID: 551
	private static int __PropertyOffset_SenseRadius;
}

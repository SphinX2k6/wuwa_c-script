using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A8 RID: 168
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToActor.TsTaskMoveToActor_C")]
public class TsTaskMoveToActor : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000913 RID: 2323 RVA: 0x0002ED4F File Offset: 0x0002CF4F
	// (set) Token: 0x06000914 RID: 2324 RVA: 0x0002ED5F File Offset: 0x0002CF5F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000915 RID: 2325 RVA: 0x0002ED70 File Offset: 0x0002CF70
	// (set) Token: 0x06000916 RID: 2326 RVA: 0x0002ED80 File Offset: 0x0002CF80
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NavigationOn
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_NavigationOn) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_NavigationOn) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000917 RID: 2327 RVA: 0x0002ED91 File Offset: 0x0002CF91
	// (set) Token: 0x06000918 RID: 2328 RVA: 0x0002EDA5 File Offset: 0x0002CFA5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyActor
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskMoveToActor.__PropertyOffset_BlackboardKeyActor)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskMoveToActor.__PropertyOffset_BlackboardKeyActor)), value);
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002EDBA File Offset: 0x0002CFBA
	// (set) Token: 0x0600091A RID: 2330 RVA: 0x0002EDCA File Offset: 0x0002CFCA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_EndDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_EndDistance) = value;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002EDDB File Offset: 0x0002CFDB
	// (set) Token: 0x0600091C RID: 2332 RVA: 0x0002EDEB File Offset: 0x0002CFEB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002EDFC File Offset: 0x0002CFFC
	// (set) Token: 0x0600091E RID: 2334 RVA: 0x0002EE0C File Offset: 0x0002D00C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FixPeriod
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_FixPeriod);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_FixPeriod) = value;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x0600091F RID: 2335 RVA: 0x0002EE1D File Offset: 0x0002D01D
	// (set) Token: 0x06000920 RID: 2336 RVA: 0x0002EE2D File Offset: 0x0002D02D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool WalkOff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_WalkOff) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_WalkOff) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000921 RID: 2337 RVA: 0x0002EE3E File Offset: 0x0002D03E
	// (set) Token: 0x06000922 RID: 2338 RVA: 0x0002EE4E File Offset: 0x0002D04E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseBounds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_UseBounds) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_UseBounds) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000923 RID: 2339 RVA: 0x0002EE5F File Offset: 0x0002D05F
	// (set) Token: 0x06000924 RID: 2340 RVA: 0x0002EE6F File Offset: 0x0002D06F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EndDistanceAllPoints
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_EndDistanceAllPoints) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_EndDistanceAllPoints) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000925 RID: 2341 RVA: 0x0002EE80 File Offset: 0x0002D080
	// (set) Token: 0x06000926 RID: 2342 RVA: 0x0002EE90 File Offset: 0x0002D090
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxExecuteTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_MaxExecuteTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_MaxExecuteTime) = value;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002EEA1 File Offset: 0x0002D0A1
	// (set) Token: 0x06000928 RID: 2344 RVA: 0x0002EEB1 File Offset: 0x0002D0B1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool FixFacingWhenEnableRVO
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_FixFacingWhenEnableRVO) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToActor.__PropertyOffset_FixFacingWhenEnableRVO) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x0002EEC4 File Offset: 0x0002D0C4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveState = this.MoveState;
			this.TsNavigationOn = this.NavigationOn;
			this.TsBlackboardKeyActor = this.BlackboardKeyActor;
			this.TsEndDistance = this.EndDistance;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsFixPeriod = this.FixPeriod;
			this.TsWalkOff = this.WalkOff;
			this.TsUseBounds = this.UseBounds;
			this.TsFixFacingWhenEnableRVO = this.FixFacingWhenEnableRVO;
			this.SelectedTargetLocation = Vector.Create();
			this.CacheVector = Vector.Create();
			this.CacheVector2 = Vector.Create();
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x0002EF78 File Offset: 0x0002D178
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskMoveToActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskMoveToActor.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600092B RID: 2347 RVA: 0x0002F028 File Offset: 0x0002D228
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
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
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.ExecuteTimeStamp = Time.Instance.WorldTime;
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (!this.TsWalkOff)
		{
			BaseMoveComponent component = charActorComp.Entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.SetWalkOffLedgeRecord(false);
			}
		}
		long num3;
		if (this.TsBlackboardKeyActor == "_currentPlayer")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num;
			if (baseCharacter == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				num = ((characterActorComponent != null) ? new int?(characterActorComponent.Entity.Id) : null);
			}
			int? num2 = num;
			num3 = (long)num2.GetValueOrDefault();
		}
		else
		{
			num3 = (long)BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyActor).GetValueOrDefault();
		}
		Entity entity = EntitySystem.Instance.Get((int)num3);
		if (num3 == 0L || (entity == null || !entity.Valid))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "TsTaskMoveToEntity没有获取到目标EntityId";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BehaviorTree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetKey", this.TsBlackboardKeyActor);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.FoundPath = false;
			return;
		}
		this.SelectedTargetLocation.DeepCopy(AiControllerLibrary.GetLocationFromEntity(entity));
		if (this.TsUseBounds)
		{
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			if (component2 != null && component2.Valid)
			{
				AActor owner = component2.Owner;
				if (owner != null && owner.IsValid())
				{
					FVectorDouble fvectorDouble = default(FVectorDouble);
					FVector fvector = default(FVector);
					owner.D_GetActorBounds(true, ref fvectorDouble, ref fvector, true);
					float tsEndDistance = fvector.Size();
					this.TsEndDistance = tsEndDistance;
				}
			}
		}
		else
		{
			this.TsEndDistance = this.EndDistance + charActorComp.ScaledRadius;
		}
		BaseMoveComponent moveComp = charActorComp.MoveComp;
		TEnumAsByte<EMovementMode>? tenumAsByte;
		if (moveComp == null)
		{
			tenumAsByte = null;
		}
		else
		{
			UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
			tenumAsByte = ((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null);
		}
		TEnumAsByte<EMovementMode>? tenumAsByte2 = tenumAsByte;
		bool flag = tenumAsByte2 == EMovementMode.MOVE_Walking || tenumAsByte2 == EMovementMode.MOVE_NavWalking;
		CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
		CharacterUnifiedStateComponent characterUnifiedStateComponent = (charAiDesignComp != null) ? charAiDesignComp.Entity.GetComponent<CharacterUnifiedStateComponent>() : null;
		if (characterUnifiedStateComponent != null && characterUnifiedStateComponent.Valid && flag)
		{
			switch (this.TsMoveState)
			{
			case 1:
				characterUnifiedStateComponent.SetMoveState(ECharMoveState.Walk);
				break;
			case 2:
				characterUnifiedStateComponent.SetMoveState(ECharMoveState.Run);
				break;
			case 3:
				characterUnifiedStateComponent.SetMoveState(ECharMoveState.Sprint);
				break;
			}
		}
		this.NextCheckTime = Time.Instance.WorldTime + (double)this.TsFixPeriod;
		Vector cacheVector = this.CacheVector;
		FVectorDouble actorLocation = charActorComp.ActorLocation;
		cacheVector.DeepCopy(actorLocation);
		BaseUnifiedStateComponent component3 = charActorComp.Entity.GetComponent<BaseUnifiedStateComponent>();
		if (component3 != null && component3.PositionState == ECharPositionState.Ground)
		{
			this.CacheVector.Z -= (double)charActorComp.HalfHeight;
		}
		this.FindNewPath(ownerController, this.CacheVector.ToUeVector(false));
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x0002F3BC File Offset: 0x0002D5BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskMoveToActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskMoveToActor.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600092D RID: 2349 RVA: 0x0002F474 File Offset: 0x0002D674
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			base.Finish(false);
			return;
		}
		if (Time.Instance.WorldTime > this.ExecuteTimeStamp + (double)this.MaxExecuteTime)
		{
			base.Finish(false);
			return;
		}
		AiController aiController = tsAiController.AiController;
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Vector actorLocationProxy = charActorComp.ActorLocationProxy;
		if (Time.Instance.WorldTime > this.NextCheckTime)
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyActor);
			Entity entity = EntitySystem.Instance.Get(entityIdByEntity.GetValueOrDefault());
			if (entityIdByEntity == null || (entity == null || !entity.Valid))
			{
				base.Finish(false);
				return;
			}
			Vector locationFromEntity = AiControllerLibrary.GetLocationFromEntity(entity);
			this.NextCheckTime = Time.Instance.WorldTime + (double)this.TsFixPeriod;
			if (Vector.Dist(locationFromEntity, this.SelectedTargetLocation) > 10.0)
			{
				this.SelectedTargetLocation.DeepCopy(locationFromEntity);
				this.CacheVector.DeepCopy(actorLocationProxy);
				BaseUnifiedStateComponent component = charActorComp.Entity.GetComponent<BaseUnifiedStateComponent>();
				if (component != null && component.PositionState == ECharPositionState.Ground)
				{
					this.CacheVector.Z -= (double)charActorComp.HalfHeight;
				}
				this.FindNewPath(ownerController, this.CacheVector.ToUeVector(false));
			}
		}
		if (!this.FoundPath)
		{
			base.Finish(false);
			return;
		}
		this.CacheVector.DeepCopy(this.SelectedTargetLocation);
		this.CacheVector.Subtraction(actorLocationProxy, this.CacheVector2);
		double num = this.CacheVector2.Size();
		Vector vector = this.SelectedTargetLocation;
		if (this.TsNavigationOn && this.NavigationPath != null && this.CurrentNavigationIndex < this.NavigationPath.Count)
		{
			this.CacheVector.DeepCopy(this.NavigationPath[this.CurrentNavigationIndex]);
			vector = this.CacheVector;
		}
		this.CacheVector2.DeepCopy(vector);
		Vector cacheVector = this.CacheVector2;
		cacheVector.Subtraction(actorLocationProxy, cacheVector);
		cacheVector.Z = 0.0;
		double num2 = cacheVector.Size();
		if ((!this.TsNavigationOn || this.CurrentNavigationIndex == this.NavigationPath.Count - 1 || this.EndDistanceAllPoints) && num < (double)this.TsEndDistance)
		{
			base.Finish(true);
			return;
		}
		if (num2 < (double)(10f + charActorComp.ScaledRadius))
		{
			this.CurrentNavigationIndex++;
		}
		if (this.TsFixFacingWhenEnableRVO)
		{
			BaseMoveComponent moveComp = charActorComp.MoveComp;
			bool flag;
			if (moveComp == null)
			{
				flag = false;
			}
			else
			{
				UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
				flag = ((characterMovement != null) ? new bool?(characterMovement.bUseRVOAvoidance) : null).GetValueOrDefault();
			}
			if (flag)
			{
				UeMovementTickManageComponent component2 = charActorComp.Entity.GetComponent<UeMovementTickManageComponent>();
				if (component2 == null)
				{
					goto IL_2E8;
				}
				component2.EnableFixFacingForVelocityOneFrame(true, new float?(this.TsTurnSpeed));
				goto IL_2E8;
			}
		}
		AiControllerLibrary.TurnToTarget(charActorComp, vector, this.TsTurnSpeed, false, 0f);
		IL_2E8:
		cacheVector.DivisionEqual(num2);
		charActorComp.SetInputDirect(cacheVector, true, EInputDirectSpace.World);
		CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
		CharacterUnifiedStateComponent characterUnifiedStateComponent = (charAiDesignComp != null) ? charAiDesignComp.Entity.GetComponent<CharacterUnifiedStateComponent>() : null;
		BaseMoveComponent moveComp2 = charActorComp.MoveComp;
		TEnumAsByte<EMovementMode>? tenumAsByte;
		if (moveComp2 == null)
		{
			tenumAsByte = null;
		}
		else
		{
			UCharacterMovementComponent characterMovement2 = moveComp2.CharacterMovement;
			tenumAsByte = ((characterMovement2 != null) ? new TEnumAsByte<EMovementMode>?(characterMovement2.MovementMode) : null);
		}
		TEnumAsByte<EMovementMode>? tenumAsByte2 = tenumAsByte;
		bool flag2 = tenumAsByte2 == EMovementMode.MOVE_Walking || tenumAsByte2 == EMovementMode.MOVE_NavWalking;
		if (characterUnifiedStateComponent != null && characterUnifiedStateComponent.Valid && flag2)
		{
			switch (this.TsMoveState)
			{
			case 1:
				characterUnifiedStateComponent.SetMoveState(ECharMoveState.Walk);
				return;
			case 2:
				characterUnifiedStateComponent.SetMoveState(ECharMoveState.Run);
				return;
			case 3:
				characterUnifiedStateComponent.SetMoveState(ECharMoveState.Sprint);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x0002F870 File Offset: 0x0002DA70
	private void FindNewPath(AAIController tsAiController, FVectorDouble selfLocation)
	{
		if (this.TsNavigationOn)
		{
			if (this.NavigationPath == null)
			{
				this.NavigationPath = new List<Vector>();
			}
			this.FoundPath = AiControllerLibrary.NavigationFindPath(tsAiController, selfLocation, this.SelectedTargetLocation.ToUeVector(false), this.NavigationPath, null, null);
			this.CurrentNavigationIndex = 1;
			return;
		}
		this.FoundPath = true;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0002F8D8 File Offset: 0x0002DAD8
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			AiControllerLibrary.ClearInput(tsAiController);
			if (!this.TsWalkOff)
			{
				BaseMoveComponent component = tsAiController.AiController.CharActorComp.Entity.GetComponent<BaseMoveComponent>();
				if (component == null)
				{
					return;
				}
				component.SetWalkOffLedgeRecord(true);
			}
		}
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x0002F922 File Offset: 0x0002DB22
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskMoveToActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToActor.TsTaskMoveToActor_C");
		}
		return TsTaskMoveToActor._ClassPtr;
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x0002F948 File Offset: 0x0002DB48
	public TsTaskMoveToActor() : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x0002F970 File Offset: 0x0002DB70
	public TsTaskMoveToActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x0002F9A3 File Offset: 0x0002DBA3
	protected TsTaskMoveToActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040006F6 RID: 1782
	private const float NAVIGATION_COMPLETE_DISTANCE = 10f;

	// Token: 0x040006F7 RID: 1783
	private const float DEFAULT_MAX_EXECUTION_TIME = 10000f;

	// Token: 0x040006F8 RID: 1784
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x040006F9 RID: 1785
	private bool IsInitTsVariables;

	// Token: 0x040006FA RID: 1786
	private int TsMoveState;

	// Token: 0x040006FB RID: 1787
	private bool TsNavigationOn;

	// Token: 0x040006FC RID: 1788
	private string TsBlackboardKeyActor = "";

	// Token: 0x040006FD RID: 1789
	private float TsEndDistance;

	// Token: 0x040006FE RID: 1790
	private float TsTurnSpeed;

	// Token: 0x040006FF RID: 1791
	private float TsFixPeriod;

	// Token: 0x04000700 RID: 1792
	private bool TsWalkOff;

	// Token: 0x04000701 RID: 1793
	private bool TsUseBounds;

	// Token: 0x04000702 RID: 1794
	private bool TsFixFacingWhenEnableRVO;

	// Token: 0x04000703 RID: 1795
	[Nullable(2)]
	private Vector SelectedTargetLocation;

	// Token: 0x04000704 RID: 1796
	private bool FoundPath;

	// Token: 0x04000705 RID: 1797
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> NavigationPath;

	// Token: 0x04000706 RID: 1798
	private int CurrentNavigationIndex;

	// Token: 0x04000707 RID: 1799
	private double NextCheckTime;

	// Token: 0x04000708 RID: 1800
	[Nullable(2)]
	private Vector CacheVector;

	// Token: 0x04000709 RID: 1801
	[Nullable(2)]
	private Vector CacheVector2;

	// Token: 0x0400070A RID: 1802
	private double ExecuteTimeStamp;

	// Token: 0x0400070B RID: 1803
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToActor.TsTaskMoveToActor_C";

	// Token: 0x0400070C RID: 1804
	private static IntPtr _ClassPtr;

	// Token: 0x0400070D RID: 1805
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400070E RID: 1806
	private static int __PropertyOffset_MoveState;

	// Token: 0x0400070F RID: 1807
	private static int __PropertyOffset_NavigationOn;

	// Token: 0x04000710 RID: 1808
	private static int __PropertyOffset_BlackboardKeyActor;

	// Token: 0x04000711 RID: 1809
	private static int __PropertyOffset_EndDistance;

	// Token: 0x04000712 RID: 1810
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000713 RID: 1811
	private static int __PropertyOffset_FixPeriod;

	// Token: 0x04000714 RID: 1812
	private static int __PropertyOffset_WalkOff;

	// Token: 0x04000715 RID: 1813
	private static int __PropertyOffset_UseBounds;

	// Token: 0x04000716 RID: 1814
	private static int __PropertyOffset_EndDistanceAllPoints;

	// Token: 0x04000717 RID: 1815
	private static int __PropertyOffset_MaxExecuteTime;

	// Token: 0x04000718 RID: 1816
	private static int __PropertyOffset_FixFacingWhenEnableRVO;
}

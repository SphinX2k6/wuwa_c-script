using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020032C4 RID: 12996
[NullableContext(1)]
[Nullable(0)]
public class VehicleActorComponent : BaseActorComponent
{
	// Token: 0x17002723 RID: 10019
	// (get) Token: 0x0601C360 RID: 115552 RVA: 0x007DB0E9 File Offset: 0x007D92E9
	[Nullable(2)]
	public AController DefaultController
	{
		[NullableContext(2)]
		get
		{
			return this.DefaultControllerInternal;
		}
	}

	// Token: 0x17002724 RID: 10020
	// (get) Token: 0x0601C361 RID: 115553 RVA: 0x007DB0F1 File Offset: 0x007D92F1
	public TsBaseVehicle Actor
	{
		get
		{
			return this.ActorInternal as TsBaseVehicle;
		}
	}

	// Token: 0x17002725 RID: 10021
	// (get) Token: 0x0601C362 RID: 115554 RVA: 0x007DB0FE File Offset: 0x007D92FE
	[Nullable(2)]
	public TsBaseVehicle VehicleOwner
	{
		[NullableContext(2)]
		get
		{
			return this.ActorInternal as TsBaseVehicle;
		}
	}

	// Token: 0x17002726 RID: 10022
	// (get) Token: 0x0601C363 RID: 115555 RVA: 0x007DB10B File Offset: 0x007D930B
	[Nullable(2)]
	public override USkeletalMeshComponent SkeletalMesh
	{
		[NullableContext(2)]
		get
		{
			return this.Actor.Mesh;
		}
	}

	// Token: 0x0601C364 RID: 115556 RVA: 0x007DB118 File Offset: 0x007D9318
	public UPrimitiveComponent GetPrimitiveComponent()
	{
		return this.SkeletalMesh;
	}

	// Token: 0x17002727 RID: 10023
	// (get) Token: 0x0601C365 RID: 115557 RVA: 0x007DB120 File Offset: 0x007D9320
	public global::Vector InputDirectProxy
	{
		get
		{
			return this.InputDirectInternal;
		}
	}

	// Token: 0x17002728 RID: 10024
	// (get) Token: 0x0601C366 RID: 115558 RVA: 0x007DB128 File Offset: 0x007D9328
	public FVector InputDirect
	{
		get
		{
			return this.InputDirectInternal.ToUeVectorOld();
		}
	}

	// Token: 0x17002729 RID: 10025
	// (get) Token: 0x0601C367 RID: 115559 RVA: 0x007DB138 File Offset: 0x007D9338
	public global::Rotator InputRotatorProxy
	{
		get
		{
			if (this.NewestInputFacingType == VehicleActorComponent.ENewestInputFacingType.Facing)
			{
				if (this.VehicleMoveComp == null || this.VehicleMoveComp.IsStandardGravity)
				{
					this.InputRotatorInternal.Set((float)(Math.Asin(this.InputFacingInternal.Z) * 57.295780181884766), (float)MathUtils.Instance.GetAngleByVector2D(this.InputFacingInternal), 0f);
				}
				else
				{
					VehicleActorComponent.TmpVector.Multiply(-1.0, VehicleActorComponent.TmpVector);
					MathUtils.Instance.LookRotationForwardFirst(this.InputFacingInternal, VehicleActorComponent.TmpVector, VehicleActorComponent.TmpQuat);
					VehicleActorComponent.TmpQuat.Rotator(this.InputRotatorInternal);
				}
				this.NewestInputFacingType = VehicleActorComponent.ENewestInputFacingType.All;
			}
			return this.InputRotatorInternal;
		}
	}

	// Token: 0x1700272A RID: 10026
	// (get) Token: 0x0601C368 RID: 115560 RVA: 0x007DB1F8 File Offset: 0x007D93F8
	public global::Vector InputFacingProxy
	{
		get
		{
			if (this.NewestInputFacingType == VehicleActorComponent.ENewestInputFacingType.Rotator)
			{
				if (this.VehicleMoveComp == null || this.VehicleMoveComp.IsStandardGravity)
				{
					float num = this.InputRotatorInternal.Pitch * 0.017453292f;
					this.InputFacingInternal.Z = Math.Sin((double)num);
					double num2 = Math.Cos((double)num);
					float num3 = this.InputRotatorInternal.Yaw * 0.017453292f;
					this.InputFacingInternal.X = Math.Cos((double)num3) * num2;
					this.InputFacingInternal.Y = Math.Sin((double)num3) * num2;
				}
				else
				{
					this.InputRotatorInternal.Quaternion(VehicleActorComponent.TmpQuat);
					VehicleActorComponent.TmpQuat.RotateVector(global::Vector.ForwardVectorProxy, this.InputFacingInternal);
				}
				this.NewestInputFacingType = VehicleActorComponent.ENewestInputFacingType.All;
			}
			return this.InputFacingInternal;
		}
	}

	// Token: 0x1700272B RID: 10027
	// (get) Token: 0x0601C369 RID: 115561 RVA: 0x007DB2C4 File Offset: 0x007D94C4
	public override global::Vector ActorGravityDirectProxy
	{
		get
		{
			if (this.CachedGravityDirectTime < Time.Instance.Frame)
			{
				this.CachedGravityDirectTime = Time.Instance.Frame;
				if (this.VehicleMoveComp != null)
				{
					this.CachedActorGravityDirect.DeepCopy(this.VehicleMoveComp.GravityDirect);
				}
				else
				{
					Aki.Protocol.Vector initGravityDirection = base.CreatureData.GetInitGravityDirection();
					if (initGravityDirection != null)
					{
						this.CachedActorGravityDirect.FromConfigVector(initGravityDirection);
					}
				}
			}
			return this.CachedActorGravityDirect;
		}
	}

	// Token: 0x0601C36A RID: 115562 RVA: 0x007DB334 File Offset: 0x007D9534
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		base.OnInitData(args);
		this.SetRotationRequestProxy = new FunctionRequestProxy<FunctionRequestWithPriority<ESetRotationPriority>>();
		return base.InitCreatureData();
	}

	// Token: 0x0601C36B RID: 115563 RVA: 0x007DB354 File Offset: 0x007D9554
	protected override void InitSizeInternal()
	{
		this.RadiusInternal = this.Actor.CapsuleComponent.CapsuleRadius;
		this.HalfHeightInternal = this.Actor.CapsuleComponent.CapsuleHalfHeight;
		this.DefaultRadiusInternal = this.RadiusInternal;
		this.DefaultHalfHeightInternal = this.HalfHeightInternal;
	}

	// Token: 0x0601C36C RID: 115564 RVA: 0x007DB3A8 File Offset: 0x007D95A8
	protected unsafe override bool OnInit()
	{
		base.OnInit();
		int modelId = this.CreatureDataInternal.GetModelId();
		if (modelId == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[SceneItemActorComponent.OnInit] 加载actor失败，无法找到modelId";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", base.CreatureData.GetPbDataId());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		AActor actorInternal = this.InitActorNew(modelId);
		this.ActorInternal = actorInternal;
		if (this.ActorInternal == null || !this.ActorInternal.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[VehicleActorComponent.OnInit] 加载actor失败。";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", base.CreatureData.GetPbDataId());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		if (!this.ActorInternal.IsA(TsBaseVehicle.StaticClass()))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Character;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "[VehicleActorComponent.OnInit] Actor不是TsBaseVehicle";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Name", this.ActorInternal.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Class", this.ActorInternal.GetClass().ToClass().GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("ModelId", modelId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("PbDataId", base.CreatureData.GetPbDataId());
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
			return false;
		}
		if (this.ActorInternal != null)
		{
			this.ActorInternal.OnDestroyed.Add(new Action<AActor>(this.OnActorDestroy));
		}
		TsBaseVehicle tsBaseVehicle = this.ActorInternal as TsBaseVehicle;
		tsBaseVehicle.VehicleActorComponent = this;
		tsBaseVehicle.SetEntityId(base.Entity.Id);
		this.InitSizeInternal();
		this.InitDefaultController(this.ActorInternal as ACharacter);
		this.SetInputFacing(base.ActorForwardProxy, false);
		base.SetActorVisible(false, "[VehicleActorComponent.OnInit] 默认隐藏");
		base.SetCollisionEnable(false, "[VehicleActorComponent.OnInit] 默认关闭碰撞");
		base.SetTickEnable(false, "[VehicleActorComponent.OnInit] 默认关闭Tick");
		this.LoadPartHitConf();
		tsBaseVehicle.CharRenderingComponent.Init(tsBaseVehicle.RenderType);
		this.ActorInternal.SetPrimitiveBlueprintTypeName(new FName(this.CreatureDataInternal.EntityPbModelConfigId));
		if (GameBudgetInterfaceController.IsOpen)
		{
			if (base.Entity.GameBudgetManagedToken != 0U)
			{
				UKuroGameBudgetAllocatorCSharpInterface.UpdateActor(base.Entity.GameBudgetConfig.GroupName, base.Entity.GameBudgetManagedToken, this.ActorInternal);
			}
			else
			{
				base.Entity.RegisterToGameBudgetController(this.ActorInternal);
			}
		}
		UKuroJsModelFunctionLibrary.UpdateEntityActor(base.Entity.Id, this.ActorInternal);
		return true;
	}

	// Token: 0x0601C36D RID: 115565 RVA: 0x007DB6EB File Offset: 0x007D98EB
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.InputComp = base.Entity.GetComponent<VehicleInputComponent>();
		this.VehicleMoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
		this.DebugMovementComp = base.Entity.GetComponent<ActorDebugMovementComponent>();
		return true;
	}

	// Token: 0x0601C36E RID: 115566 RVA: 0x007DB72C File Offset: 0x007D992C
	protected override void OnActivate()
	{
		base.OnActivate();
		base.SetActorVisible(true, "[VehicleActorComponent.OnActivate] Visible");
		base.SetCollisionEnable(true, "[VehicleActorComponent.OnActivate] Visible");
		base.SetTickEnable(true, "[VehicleActorComponent.OnActivate] Visible");
		this.Actor.VehicleMovementComponent.InitVehicleShapes();
		WorldController.Instance.SetActorDataByCreature(this.CreatureDataInternal, this.ActorInternal);
		bool flag = this.CreatureDataInternal.GetPlayerId() == CreatureModel.Instance.GetPlayerId();
		ValueTuple<int, MoveStateInfo>? entitySplineMoveInfo = VehiclePathMoveController.Instance.GetEntitySplineMoveInfo(base.Entity);
		this.SetAutonomous(flag || entitySplineMoveInfo != null, null);
	}

	// Token: 0x0601C36F RID: 115567 RVA: 0x007DB7D0 File Offset: 0x007D99D0
	protected override bool OnClear()
	{
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			this.ActorInternal.OnDestroyed.Remove(new Action<AActor>(this.OnActorDestroy));
			TsBaseVehicle tsBaseVehicle = this.ActorInternal as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				CharacterDitherEffectController ditherEffectController = tsBaseVehicle.DitherEffectController;
				if (ditherEffectController != null)
				{
					ditherEffectController.Clear();
				}
				tsBaseVehicle.DitherEffectController = null;
			}
			AActor platformActor = this.Actor.PlatformActor;
			if (platformActor != null && platformActor.IsValid())
			{
				this.Actor.PlatformActor.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
		}
		return base.OnClear();
	}

	// Token: 0x0601C370 RID: 115568 RVA: 0x007DB866 File Offset: 0x007D9A66
	protected override void OnDisable(string reason)
	{
		this.OnSetActorActive(false, reason);
	}

	// Token: 0x0601C371 RID: 115569 RVA: 0x007DB870 File Offset: 0x007D9A70
	protected override void OnEnable()
	{
		this.OnSetActorActive(true, null);
		base.ResetAllCachedTime();
	}

	// Token: 0x0601C372 RID: 115570 RVA: 0x007DB880 File Offset: 0x007D9A80
	[NullableContext(2)]
	protected unsafe AActor InitActorNew(int modelId)
	{
		CreatureDataComponent creatureDataInternal = this.CreatureDataInternal;
		FTransformDouble transform = creatureDataInternal.D_GetTransform();
		AActor aactor = null;
		this.CreatureDataInternal.SetModelConfig(modelId);
		SModelConfig modelConfig = this.CreatureDataInternal.GetModelConfig();
		if (modelConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[CharacterActorComponent.OnInit] 缺少ModelConfig配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ModelId", modelId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return aactor;
		}
		aactor = ActorUtils.LoadActorByModelConfig(modelConfig, transform);
		if (aactor == null || !aactor.IsValid())
		{
			return null;
		}
		TsBaseVehicle tsBaseVehicle = aactor as TsBaseVehicle;
		if (tsBaseVehicle != null)
		{
			ActorUtils.LoadAndChangeMeshAnim(tsBaseVehicle.Mesh, modelConfig.网格体, modelConfig.动画蓝图);
		}
		return aactor;
	}

	// Token: 0x0601C373 RID: 115571 RVA: 0x007DB964 File Offset: 0x007D9B64
	protected override void OnChangeTimeDilation(float timeDilation)
	{
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		float num = (component != null) ? component.CurrentTimeScale : 1f;
		this.ActorInternal.CustomTimeDilation = timeDilation * num;
	}

	// Token: 0x0601C374 RID: 115572 RVA: 0x007DB99C File Offset: 0x007D9B9C
	protected override void SetMoveAutonomous(bool moveAutonomous, string reason = "")
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Control;
		Entity entity = base.Entity;
		string message = "设置移动主控";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(reason, moveAutonomous);
		instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		base.SetMoveAutonomous(moveAutonomous, reason);
		VehicleAnimationComponent component = base.Entity.GetComponent<VehicleAnimationComponent>();
		if (component != null)
		{
			UAnimInstance mainAnimInstance = component.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.SetStateMachineNetMode(!moveAutonomous);
			}
			UAnimInstance specialAnimInstance = component.SpecialAnimInstance;
			if (specialAnimInstance == null)
			{
				return;
			}
			specialAnimInstance.SetStateMachineNetMode(!moveAutonomous);
		}
	}

	// Token: 0x0601C375 RID: 115573 RVA: 0x007DBA14 File Offset: 0x007D9C14
	[NullableContext(2)]
	protected unsafe void OnActorDestroy(AActor aActor)
	{
		if (this.CreatureDataInternal.GetRemoveState())
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Entity;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "Entity还没销毁，Actor已经被销毁了，需检查造物点是否会使生成的实体掉出边界外";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureData", this.CreatureDataInternal.GetCreatureDataId());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigType", this.CreatureDataInternal.GetEntityConfigType());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601C376 RID: 115574 RVA: 0x007DBAC8 File Offset: 0x007D9CC8
	private void LoadPartHitConf()
	{
		UClassStackOnlyPtr @class = this.Actor.GetClass();
		TSoftClassPtr<UObject> tsoftClassPtr = UKismetSystemLibrary.Conv_ClassToSoftClassReference(@class);
		string characterResourcePath = UKismetSystemLibrary.Conv_SoftClassReferenceToString(tsoftClassPtr);
		SCharacterFightInfo characterFightInfo = WorldConfig.Instance.GetCharacterFightInfo(characterResourcePath);
		string text = (characterFightInfo != null) ? characterFightInfo.PartHitEffect.ToAssetPathName() : null;
		bool isValid = text != null && text.Length > 0 && text != "None";
		if (isValid)
		{
			ResourceSystem.Instance.LoadAsync<BP_PartHitEffect_C>(text, delegate([Nullable(2)] BP_PartHitEffect_C res, string _)
			{
				TsBaseVehicle actor = this.Actor;
				if (actor == null || !actor.IsValid())
				{
					return;
				}
				this.PartHitConf = res;
				BP_PartHitEffect_C partHitConf = this.PartHitConf;
				isValid = (partHitConf != null && partHitConf.IsValid());
				if (isValid && this.Actor != null)
				{
					this.StartHideDistance = this.PartHitConf.StartHideDistance;
					this.CompleteHideDistance = this.PartHitConf.CompleteHideDistance;
					this.StartDitherValue = this.PartHitConf.StartDitherValue;
				}
			}, 100, "js_undefined");
		}
	}

	// Token: 0x0601C377 RID: 115575 RVA: 0x007DBB63 File Offset: 0x007D9D63
	public void SetInputRotator(IRotator value)
	{
		this.SetInputRotatorByNumber(value.Pitch, value.Yaw, value.Roll);
	}

	// Token: 0x0601C378 RID: 115576 RVA: 0x007DBB7D File Offset: 0x007D9D7D
	public void SetInputRotatorByNumber(float pitch, float yaw, float roll)
	{
		this.InputRotatorInternal.Pitch = pitch;
		this.InputRotatorInternal.Yaw = yaw;
		this.InputRotatorInternal.Roll = roll;
		this.NewestInputFacingType = VehicleActorComponent.ENewestInputFacingType.Rotator;
	}

	// Token: 0x0601C379 RID: 115577 RVA: 0x007DBBAC File Offset: 0x007D9DAC
	public unsafe void SetInputDirect(IVector value, bool clearGravityDirect = false)
	{
		if (!MathUtils.Instance.IsValidVector(value, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SetInputDirect has NaN";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("x", value.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("y", value.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("z", value.Z);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (!clearGravityDirect)
		{
			this.InputDirectInternal.DeepCopy(value);
			return;
		}
		if (this.VehicleMoveComp == null || this.VehicleMoveComp.IsStandardGravity)
		{
			this.InputDirectInternal.DeepCopy(value);
			this.InputDirectInternal.Z = 0.0;
			return;
		}
		VehicleActorComponent.TmpVector.DeepCopy(value);
		global::Vector.VectorPlaneProject(VehicleActorComponent.TmpVector, this.VehicleMoveComp.GravityDirect, this.InputDirectInternal);
	}

	// Token: 0x0601C37A RID: 115578 RVA: 0x007DBCC4 File Offset: 0x007D9EC4
	public unsafe void SetInputDirectByNumber(float x, float y, float z)
	{
		if (!MathUtils.Instance.IsValidNumbers((double)x, (double)y, (double)z, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SetInputDirect has NaN";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("x", x);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("y", y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("z", z);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		this.InputDirectInternal.X = (double)x;
		this.InputDirectInternal.Y = (double)y;
		this.InputDirectInternal.Z = (double)z;
	}

	// Token: 0x0601C37B RID: 115579 RVA: 0x007DBD8C File Offset: 0x007D9F8C
	public void SetInputFacing(global::Vector facing, bool clearGravityDirect = false)
	{
		this.InputFacingInternal.DeepCopy(facing);
		if (clearGravityDirect)
		{
			if (this.VehicleMoveComp == null || this.VehicleMoveComp.IsStandardGravity)
			{
				this.InputFacingInternal.Z = 0.0;
			}
			else
			{
				global::Vector.VectorPlaneProject(this.InputFacingInternal, this.VehicleMoveComp.GravityDirect, VehicleActorComponent.TmpVector);
				this.InputFacingInternal.DeepCopy(VehicleActorComponent.TmpVector);
			}
		}
		if (!this.InputFacingInternal.Normalize(9.99999993922529E-09))
		{
			this.InputFacingInternal.DeepCopy(base.ActorForwardProxy);
		}
		this.NewestInputFacingType = VehicleActorComponent.ENewestInputFacingType.Facing;
	}

	// Token: 0x0601C37C RID: 115580 RVA: 0x007DBE2C File Offset: 0x007DA02C
	public void SetOverrideTurnSpeed(float? value)
	{
		this.OverrideTurnSpeed = value;
	}

	// Token: 0x0601C37D RID: 115581 RVA: 0x007DBE35 File Offset: 0x007DA035
	public void ClearInput()
	{
		this.SetInputDirect(global::Vector.ZeroVector, false);
		this.SetInputFacing(base.ActorForwardProxy, false);
		this.SetOverrideTurnSpeed(new float?(0f));
	}

	// Token: 0x0601C37E RID: 115582 RVA: 0x007DBE68 File Offset: 0x007DA068
	public unsafe void InitDefaultController(ACharacter actor)
	{
		this.DefaultControllerInternal = actor.GetController();
		if (this.DefaultController == null)
		{
			this.CreateDefaultController(actor);
			return;
		}
		if (!(this.DefaultController is AAIController))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "Character初始化的默认Controller基类为非AiController";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureData", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigType", this.CreatureDataInternal.GetEntityConfigType());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("DefaultController", this.DefaultController.GetName());
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		if (this.DefaultController is APlayerController)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "Character初始化的默认Controller基类为PlayerController,下场的人将会导致Movement不执行";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureData", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ConfigType", this.CreatureDataInternal.GetEntityConfigType());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			if (this.DefaultController.Pawn == actor)
			{
				this.DefaultController.Pawn.DetachFromControllerPendingDestroy();
			}
			this.DefaultControllerInternal = null;
			this.CreateDefaultController(actor);
		}
	}

	// Token: 0x0601C37F RID: 115583 RVA: 0x007DC02F File Offset: 0x007DA22F
	public void CreateDefaultController(ACharacter actor)
	{
		actor.AIControllerClass = AKuroAIController.StaticClass();
		actor.SpawnDefaultController();
		this.DefaultControllerInternal = actor.GetController();
	}

	// Token: 0x0601C380 RID: 115584 RVA: 0x007DC054 File Offset: 0x007DA254
	public void RestoreDefaultController()
	{
		if (this.DefaultController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[VehicleActorComponent.RestoreDefaultController] 没有DefaultController,将导致这个实体部分功能失效比如移动,查看OnStart 有无正常初始化DefaultController";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.DefaultController.Possess(this.Actor);
	}

	// Token: 0x0601C381 RID: 115585 RVA: 0x007DC0B4 File Offset: 0x007DA2B4
	public override bool SetActorRotation(FRotator value, string context, bool sweep = false)
	{
		bool result = false;
		if (!MathUtils.Instance.IsValidRotator(value, 100000000))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.MZJ, "SetActorRotation NaN", default(ReadOnlySpan<ValueTuple<string, object>>));
			return result;
		}
		result = base.SetActorRotation(value, context, sweep);
		this.CachedActorRotation.DeepCopy(value);
		this.CachedRotationTime = Time.Instance.Frame;
		this.CachedActorRotation.Quaternion(this.CachedActorQuat);
		return result;
	}

	// Token: 0x0601C382 RID: 115586 RVA: 0x007DC134 File Offset: 0x007DA334
	public unsafe bool SetActorRotationWithPriority(FRotator value, string module, ESetRotationPriority priority, bool clearMeshRotationBuffer = false, bool sweep = false)
	{
		FunctionRequestWithPriority<ESetRotationPriority> functionRequestWithPriority = new FunctionRequestWithPriority<ESetRotationPriority>();
		functionRequestWithPriority.ModuleName = module;
		functionRequestWithPriority.Priority = priority;
		if (this.SetRotationRequestProxy.DecideCall(functionRequestWithPriority))
		{
			if (this.ShowDebug)
			{
				Log instance = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[CharacterActorComponent.SetActorRotationWithPriority] 修改Rotation";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("module", module);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("rotation", value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("oldRotation", base.ActorRotationProxy);
				instance.Info(module2, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			if (clearMeshRotationBuffer)
			{
				EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.RequestClearMeshRotationBuffer);
			}
			this.SetActorRotation(value, module, sweep);
			return true;
		}
		return false;
	}

	// Token: 0x0601C383 RID: 115587 RVA: 0x007DC238 File Offset: 0x007DA438
	public override bool SetActorLocationAndRotation(FVectorDouble location, FRotator rotation, string context, bool sweep = false, ESetRotationPriority? priority = null)
	{
		if (!MathUtils.Instance.IsValidVector(location, 100000000) || !MathUtils.Instance.IsValidRotator(rotation, 100000000))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.MZJ, "SetActorLocationAndRotation NaN", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		bool result;
		if (priority != null)
		{
			FunctionRequestWithPriority<ESetRotationPriority> functionRequestWithPriority = new FunctionRequestWithPriority<ESetRotationPriority>();
			functionRequestWithPriority.ModuleName = context;
			functionRequestWithPriority.Priority = priority.Value;
			if (!this.SetRotationRequestProxy.DecideCall(functionRequestWithPriority))
			{
				result = base.SetActorLocation(location, context, sweep);
			}
			else
			{
				result = base.SetActorLocationAndRotation(location, rotation, context, sweep, null);
			}
		}
		else
		{
			result = base.SetActorLocationAndRotation(location, rotation, context, sweep, null);
		}
		base.ResetTransformCachedTime();
		this.OnTeleport();
		return result;
	}

	// Token: 0x0601C384 RID: 115588 RVA: 0x007DC30C File Offset: 0x007DA50C
	public override bool SetActorTransform(FTransformDouble value, string context, bool sweep = true, ESetRotationPriority? priority = null)
	{
		if (priority != null)
		{
			FunctionRequestWithPriority<ESetRotationPriority> functionRequestWithPriority = new FunctionRequestWithPriority<ESetRotationPriority>();
			functionRequestWithPriority.ModuleName = context;
			functionRequestWithPriority.Priority = priority.Value;
			if (!this.SetRotationRequestProxy.DecideCall(functionRequestWithPriority))
			{
				FQuat fquat = base.ActorRotation.Quaternion();
				value.SetRotation(fquat);
			}
		}
		return base.SetActorTransform(value, context, sweep, null);
	}

	// Token: 0x0601C385 RID: 115589 RVA: 0x007DC374 File Offset: 0x007DA574
	public virtual bool SetActorTransformExceptMesh(FTransformDouble value, string context, bool sweep = true, ESetRotationPriority? priority = null)
	{
		global::Vector cachedDesiredActorLocation = this.CachedDesiredActorLocation;
		FVectorDouble location = value.GetLocation();
		cachedDesiredActorLocation.FromUeVector(location);
		this.IsChangingLocation = true;
		bool result = this.Actor.SetActorTransformExceptSkelMesh(value, sweep, ref WorldGlobal.SweepHitResult, true, true);
		this.IsChangingLocation = false;
		base.CheckIsForbidSettingLocAndRot(true, true, true);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorTransformExceptMesh", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetTransformCachedTime();
		this.OnTeleport();
		return result;
	}

	// Token: 0x0601C386 RID: 115590 RVA: 0x007DC3F4 File Offset: 0x007DA5F4
	public virtual bool SetActorLocationAndRotationExceptMesh(FVectorDouble location, FRotator rotation, string context, bool sweep = true, ESetRotationPriority? priority = null)
	{
		this.CachedDesiredActorLocation.FromUeVector(location);
		this.IsChangingLocation = true;
		bool result = this.Actor.SetActorLocationAndRotationExceptSkelMesh(location, rotation, sweep, ref WorldGlobal.SweepHitResult, true, true);
		this.IsChangingLocation = false;
		base.CheckIsForbidSettingLocAndRot(true, true, true);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocationAndRotationExceptMesh", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetTransformCachedTime();
		return result;
	}

	// Token: 0x0601C387 RID: 115591 RVA: 0x007DC46C File Offset: 0x007DA66C
	public void SetActorVelocity(global::Vector v)
	{
		if (this.Actor.RootComponent == null)
		{
			return;
		}
		if (!MathUtils.Instance.IsValidVector(v, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Set Invalid Velocity";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", v);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FVector fvector = v.ToUeVectorOld();
		this.Actor.RootComponent.ComponentVelocity = fvector;
		if (this.Actor.VehicleMovementComponent != null)
		{
			this.Actor.VehicleMovementComponent.Velocity = fvector;
		}
		this.CachedActorVelocity.DeepCopy(v);
	}

	// Token: 0x0601C388 RID: 115592 RVA: 0x007DC502 File Offset: 0x007DA702
	public void FixBornLocation([Nullable(2)] global::Vector target = null, string context = "FixBornLocation")
	{
		BaseVehiclePerformComponent component = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		if (component == null)
		{
			return;
		}
		component.FixBornLocation(target, context);
	}

	// Token: 0x0601C389 RID: 115593 RVA: 0x007DC51B File Offset: 0x007DA71B
	public virtual void EnterFirstPersonMode()
	{
	}

	// Token: 0x0601C38A RID: 115594 RVA: 0x007DC51D File Offset: 0x007DA71D
	public virtual void ExitFirstPersonMode()
	{
	}

	// Token: 0x0601C38B RID: 115595 RVA: 0x007DC520 File Offset: 0x007DA720
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (VehicleActorComponent)componentTemplate;
		if (base.CanResetComponentProperty("InputComp"))
		{
			if (vehicleActorComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleInputComponent>(this.InputComp), "InputComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ShowDebug"))
		{
			this.ShowDebug = vehicleActorComponent.ShowDebug;
		}
		if (base.CanResetComponentProperty("SetRotationRequestProxy"))
		{
			if (vehicleActorComponent.SetRotationRequestProxy == null)
			{
				this.SetRotationRequestProxy = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FunctionRequestProxy<FunctionRequestWithPriority<ESetRotationPriority>>>(this.SetRotationRequestProxy), "SetRotationRequestProxy"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DefaultControllerInternal"))
		{
			if (vehicleActorComponent.DefaultControllerInternal == null)
			{
				this.DefaultControllerInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AController>(this.DefaultControllerInternal), "DefaultControllerInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartHitConf"))
		{
			if (vehicleActorComponent.PartHitConf == null)
			{
				this.PartHitConf = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_PartHitEffect_C>(this.PartHitConf), "PartHitConf"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StartHideDistance"))
		{
			this.StartHideDistance = vehicleActorComponent.StartHideDistance;
		}
		if (base.CanResetComponentProperty("CompleteHideDistance"))
		{
			this.CompleteHideDistance = vehicleActorComponent.CompleteHideDistance;
		}
		if (base.CanResetComponentProperty("StartDitherValue"))
		{
			this.StartDitherValue = vehicleActorComponent.StartDitherValue;
		}
		if (base.CanResetComponentProperty("InputDirectInternal") && vehicleActorComponent.InputDirectInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.InputDirectInternal), "InputDirectInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InputRotatorInternal") && vehicleActorComponent.InputRotatorInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.InputRotatorInternal), "InputRotatorInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InputFacingInternal") && vehicleActorComponent.InputFacingInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.InputFacingInternal), "InputFacingInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("NewestInputFacingType"))
		{
			this.NewestInputFacingType = vehicleActorComponent.NewestInputFacingType;
		}
		if (base.CanResetComponentProperty("OverrideTurnSpeed"))
		{
			this.OverrideTurnSpeed = vehicleActorComponent.OverrideTurnSpeed;
		}
		return true;
	}

	// Token: 0x0400DF35 RID: 57141
	[Nullable(2)]
	public VehicleInputComponent InputComp;

	// Token: 0x0400DF36 RID: 57142
	public bool ShowDebug;

	// Token: 0x0400DF37 RID: 57143
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected FunctionRequestProxy<FunctionRequestWithPriority<ESetRotationPriority>> SetRotationRequestProxy;

	// Token: 0x0400DF38 RID: 57144
	[Nullable(2)]
	protected AController DefaultControllerInternal;

	// Token: 0x0400DF39 RID: 57145
	[Nullable(2)]
	private BP_PartHitEffect_C PartHitConf;

	// Token: 0x0400DF3A RID: 57146
	public float StartHideDistance;

	// Token: 0x0400DF3B RID: 57147
	public float CompleteHideDistance;

	// Token: 0x0400DF3C RID: 57148
	public float StartDitherValue;

	// Token: 0x0400DF3D RID: 57149
	[StaticVariableRuleIgnore]
	protected static global::Vector TmpVector = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400DF3E RID: 57150
	[StaticVariableRuleIgnore]
	protected static Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400DF3F RID: 57151
	private readonly global::Vector InputDirectInternal = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400DF40 RID: 57152
	private readonly global::Rotator InputRotatorInternal = global::Rotator.Create(0f, 0f, 0f);

	// Token: 0x0400DF41 RID: 57153
	private readonly global::Vector InputFacingInternal = global::Vector.Create(1.0, 0.0, 0.0);

	// Token: 0x0400DF42 RID: 57154
	protected VehicleActorComponent.ENewestInputFacingType NewestInputFacingType;

	// Token: 0x0400DF43 RID: 57155
	public float? OverrideTurnSpeed = new float?(0f);

	// Token: 0x0200976A RID: 38762
	[NullableContext(0)]
	public enum ENewestInputFacingType
	{
		// Token: 0x040306A7 RID: 198311
		All,
		// Token: 0x040306A8 RID: 198312
		Rotator,
		// Token: 0x040306A9 RID: 198313
		Facing
	}
}

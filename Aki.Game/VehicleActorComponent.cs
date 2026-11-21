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

// Token: 0x02002835 RID: 10293
[NullableContext(1)]
[Nullable(0)]
public class VehicleActorComponent : BaseActorComponent
{
	// Token: 0x17002A1E RID: 10782
	// (get) Token: 0x06019FB1 RID: 106417 RVA: 0x00802080 File Offset: 0x00800280
	[Nullable(2)]
	public AController DefaultController
	{
		[NullableContext(2)]
		get
		{
			return this.DefaultControllerInternal;
		}
	}

	// Token: 0x17002A1F RID: 10783
	// (get) Token: 0x06019FB2 RID: 106418 RVA: 0x00802088 File Offset: 0x00800288
	public TsBaseVehicle Actor
	{
		get
		{
			return this.ActorInternal as TsBaseVehicle;
		}
	}

	// Token: 0x17002A20 RID: 10784
	// (get) Token: 0x06019FB3 RID: 106419 RVA: 0x00802095 File Offset: 0x00800295
	[Nullable(2)]
	public TsBaseVehicle VehicleOwner
	{
		[NullableContext(2)]
		get
		{
			return this.ActorInternal as TsBaseVehicle;
		}
	}

	// Token: 0x17002A21 RID: 10785
	// (get) Token: 0x06019FB4 RID: 106420 RVA: 0x008020A2 File Offset: 0x008002A2
	[Nullable(2)]
	public override USkeletalMeshComponent SkeletalMesh
	{
		[NullableContext(2)]
		get
		{
			return this.Actor.Mesh;
		}
	}

	// Token: 0x06019FB5 RID: 106421 RVA: 0x008020AF File Offset: 0x008002AF
	public UPrimitiveComponent GetPrimitiveComponent()
	{
		return this.SkeletalMesh;
	}

	// Token: 0x17002A22 RID: 10786
	// (get) Token: 0x06019FB6 RID: 106422 RVA: 0x008020B7 File Offset: 0x008002B7
	public global::Vector InputDirectProxy
	{
		get
		{
			return this.InputDirectInternal;
		}
	}

	// Token: 0x17002A23 RID: 10787
	// (get) Token: 0x06019FB7 RID: 106423 RVA: 0x008020BF File Offset: 0x008002BF
	public FVector InputDirect
	{
		get
		{
			return this.InputDirectInternal.ToUeVectorOld();
		}
	}

	// Token: 0x17002A24 RID: 10788
	// (get) Token: 0x06019FB8 RID: 106424 RVA: 0x008020CC File Offset: 0x008002CC
	public EInputDirectSpace InputDirectSpace
	{
		get
		{
			return this.InputDirectSpaceInternal;
		}
	}

	// Token: 0x17002A25 RID: 10789
	// (get) Token: 0x06019FB9 RID: 106425 RVA: 0x008020D4 File Offset: 0x008002D4
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

	// Token: 0x17002A26 RID: 10790
	// (get) Token: 0x06019FBA RID: 106426 RVA: 0x00802194 File Offset: 0x00800394
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

	// Token: 0x17002A27 RID: 10791
	// (get) Token: 0x06019FBB RID: 106427 RVA: 0x00802260 File Offset: 0x00800460
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
					CreatureDataComponent creatureData = base.CreatureData;
					Aki.Protocol.Vector vector = (creatureData != null) ? creatureData.GetInitGravityDirection() : null;
					if (vector != null)
					{
						this.CachedActorGravityDirect.FromConfigVector(vector);
					}
				}
			}
			return this.CachedActorGravityDirect;
		}
	}

	// Token: 0x06019FBC RID: 106428 RVA: 0x008022D7 File Offset: 0x008004D7
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		base.OnInitData(args);
		this.SetRotationRequestProxy = new FunctionRequestProxy<FunctionRequestWithPriority<ESetRotationPriority>>();
		return base.InitCreatureData();
	}

	// Token: 0x06019FBD RID: 106429 RVA: 0x008022F8 File Offset: 0x008004F8
	protected override void InitSizeInternal()
	{
		this.RadiusInternal = this.Actor.CapsuleComponent.CapsuleRadius;
		this.HalfHeightInternal = this.Actor.CapsuleComponent.CapsuleHalfHeight;
		this.DefaultRadiusInternal = this.RadiusInternal;
		this.DefaultHalfHeightInternal = this.HalfHeightInternal;
	}

	// Token: 0x06019FBE RID: 106430 RVA: 0x0080234C File Offset: 0x0080054C
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

	// Token: 0x06019FBF RID: 106431 RVA: 0x0080268F File Offset: 0x0080088F
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

	// Token: 0x06019FC0 RID: 106432 RVA: 0x008026D0 File Offset: 0x008008D0
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

	// Token: 0x06019FC1 RID: 106433 RVA: 0x00802774 File Offset: 0x00800974
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

	// Token: 0x06019FC2 RID: 106434 RVA: 0x0080280A File Offset: 0x00800A0A
	protected override void OnDisable(string reason)
	{
		this.OnSetActorActive(false, reason);
	}

	// Token: 0x06019FC3 RID: 106435 RVA: 0x00802814 File Offset: 0x00800A14
	protected override void OnEnable()
	{
		this.OnSetActorActive(true, null);
		base.ResetAllCachedTime();
	}

	// Token: 0x06019FC4 RID: 106436 RVA: 0x00802824 File Offset: 0x00800A24
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

	// Token: 0x06019FC5 RID: 106437 RVA: 0x00802908 File Offset: 0x00800B08
	protected override void OnChangeTimeDilation(float timeDilation)
	{
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		float num = (component != null) ? component.CurrentTimeScale : 1f;
		this.ActorInternal.CustomTimeDilation = timeDilation * num;
	}

	// Token: 0x06019FC6 RID: 106438 RVA: 0x00802940 File Offset: 0x00800B40
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

	// Token: 0x06019FC7 RID: 106439 RVA: 0x008029B8 File Offset: 0x00800BB8
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

	// Token: 0x06019FC8 RID: 106440 RVA: 0x00802A6C File Offset: 0x00800C6C
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

	// Token: 0x06019FC9 RID: 106441 RVA: 0x00802B07 File Offset: 0x00800D07
	public void SetInputRotator(IRotator value)
	{
		this.SetInputRotatorByNumber(value.Pitch, value.Yaw, value.Roll);
	}

	// Token: 0x06019FCA RID: 106442 RVA: 0x00802B21 File Offset: 0x00800D21
	public void SetInputRotatorByNumber(float pitch, float yaw, float roll)
	{
		this.InputRotatorInternal.Pitch = pitch;
		this.InputRotatorInternal.Yaw = yaw;
		this.InputRotatorInternal.Roll = roll;
		this.NewestInputFacingType = VehicleActorComponent.ENewestInputFacingType.Rotator;
	}

	// Token: 0x06019FCB RID: 106443 RVA: 0x00802B50 File Offset: 0x00800D50
	public unsafe void SetInputDirect(IVector value, bool clearGravityDirect = false, EInputDirectSpace space = EInputDirectSpace.World)
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
		this.InputDirectSpaceInternal = space;
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

	// Token: 0x06019FCC RID: 106444 RVA: 0x00802C70 File Offset: 0x00800E70
	public unsafe void SetInputDirectByNumber(float x, float y, float z, EInputDirectSpace space = EInputDirectSpace.World)
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
		this.InputDirectSpaceInternal = space;
		this.InputDirectInternal.X = (double)x;
		this.InputDirectInternal.Y = (double)y;
		this.InputDirectInternal.Z = (double)z;
	}

	// Token: 0x06019FCD RID: 106445 RVA: 0x00802D40 File Offset: 0x00800F40
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

	// Token: 0x06019FCE RID: 106446 RVA: 0x00802DE0 File Offset: 0x00800FE0
	public void SetOverrideTurnSpeed(float? value)
	{
		this.OverrideTurnSpeed = value;
	}

	// Token: 0x06019FCF RID: 106447 RVA: 0x00802DE9 File Offset: 0x00800FE9
	public void ClearInput()
	{
		this.SetInputDirect(global::Vector.ZeroVector, false, EInputDirectSpace.World);
		this.SetInputFacing(base.ActorForwardProxy, false);
		this.SetOverrideTurnSpeed(new float?(0f));
	}

	// Token: 0x06019FD0 RID: 106448 RVA: 0x00802E1C File Offset: 0x0080101C
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

	// Token: 0x06019FD1 RID: 106449 RVA: 0x00802FE3 File Offset: 0x008011E3
	public void CreateDefaultController(ACharacter actor)
	{
		actor.AIControllerClass = AKuroAIController.StaticClass();
		actor.SpawnDefaultController();
		this.DefaultControllerInternal = actor.GetController();
	}

	// Token: 0x06019FD2 RID: 106450 RVA: 0x00803008 File Offset: 0x00801208
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

	// Token: 0x06019FD3 RID: 106451 RVA: 0x00803068 File Offset: 0x00801268
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

	// Token: 0x06019FD4 RID: 106452 RVA: 0x008030E8 File Offset: 0x008012E8
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

	// Token: 0x06019FD5 RID: 106453 RVA: 0x008031EC File Offset: 0x008013EC
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

	// Token: 0x06019FD6 RID: 106454 RVA: 0x008032C0 File Offset: 0x008014C0
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

	// Token: 0x06019FD7 RID: 106455 RVA: 0x00803328 File Offset: 0x00801528
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

	// Token: 0x06019FD8 RID: 106456 RVA: 0x008033A8 File Offset: 0x008015A8
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

	// Token: 0x06019FD9 RID: 106457 RVA: 0x00803420 File Offset: 0x00801620
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

	// Token: 0x06019FDA RID: 106458 RVA: 0x008034B6 File Offset: 0x008016B6
	public void FixBornLocation([Nullable(2)] global::Vector target = null, string context = "FixBornLocation")
	{
		BaseVehiclePerformComponent component = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		if (component == null)
		{
			return;
		}
		component.FixBornLocation(target, context);
	}

	// Token: 0x06019FDB RID: 106459 RVA: 0x008034CF File Offset: 0x008016CF
	public virtual void EnterFirstPersonMode()
	{
	}

	// Token: 0x06019FDC RID: 106460 RVA: 0x008034D1 File Offset: 0x008016D1
	public virtual void ExitFirstPersonMode()
	{
	}

	// Token: 0x06019FDD RID: 106461 RVA: 0x008034D4 File Offset: 0x008016D4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (VehicleActorComponent)componentTemplate;
		if (vehicleActorComponent.InputComp == null)
		{
			this.InputComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
		{
			return false;
		}
		this.ShowDebug = vehicleActorComponent.ShowDebug;
		if (vehicleActorComponent.SetRotationRequestProxy == null)
		{
			this.SetRotationRequestProxy = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SetRotationRequestProxy), "SetRotationRequestProxy"))
		{
			return false;
		}
		if (vehicleActorComponent.DefaultControllerInternal == null)
		{
			this.DefaultControllerInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultControllerInternal), "DefaultControllerInternal"))
		{
			return false;
		}
		if (vehicleActorComponent.PartHitConf == null)
		{
			this.PartHitConf = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PartHitConf), "PartHitConf"))
		{
			return false;
		}
		this.StartHideDistance = vehicleActorComponent.StartHideDistance;
		this.CompleteHideDistance = vehicleActorComponent.CompleteHideDistance;
		this.StartDitherValue = vehicleActorComponent.StartDitherValue;
		if (vehicleActorComponent.InputDirectInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputDirectInternal), "InputDirectInternal"))
		{
			return false;
		}
		this.InputDirectSpaceInternal = vehicleActorComponent.InputDirectSpaceInternal;
		if (vehicleActorComponent.InputRotatorInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputRotatorInternal), "InputRotatorInternal"))
		{
			return false;
		}
		if (vehicleActorComponent.InputFacingInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputFacingInternal), "InputFacingInternal"))
		{
			return false;
		}
		this.NewestInputFacingType = vehicleActorComponent.NewestInputFacingType;
		this.OverrideTurnSpeed = vehicleActorComponent.OverrideTurnSpeed;
		return true;
	}

	// Token: 0x17002A28 RID: 10792
	// (get) Token: 0x06019FDE RID: 106462 RVA: 0x0080365A File Offset: 0x0080185A
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A29 RID: 10793
	// (get) Token: 0x06019FDF RID: 106463 RVA: 0x0080365D File Offset: 0x0080185D
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A2A RID: 10794
	// (get) Token: 0x06019FE0 RID: 106464 RVA: 0x00803660 File Offset: 0x00801860
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A2B RID: 10795
	// (get) Token: 0x06019FE1 RID: 106465 RVA: 0x00803663 File Offset: 0x00801863
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A2C RID: 10796
	// (get) Token: 0x06019FE2 RID: 106466 RVA: 0x00803666 File Offset: 0x00801866
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A2D RID: 10797
	// (get) Token: 0x06019FE3 RID: 106467 RVA: 0x00803669 File Offset: 0x00801869
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A2E RID: 10798
	// (get) Token: 0x06019FE4 RID: 106468 RVA: 0x0080366C File Offset: 0x0080186C
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A2F RID: 10799
	// (get) Token: 0x06019FE5 RID: 106469 RVA: 0x0080366F File Offset: 0x0080186F
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A30 RID: 10800
	// (get) Token: 0x06019FE6 RID: 106470 RVA: 0x00803672 File Offset: 0x00801872
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E3D7 RID: 58327
	[Nullable(2)]
	public VehicleInputComponent InputComp;

	// Token: 0x0400E3D8 RID: 58328
	public bool ShowDebug;

	// Token: 0x0400E3D9 RID: 58329
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected FunctionRequestProxy<FunctionRequestWithPriority<ESetRotationPriority>> SetRotationRequestProxy;

	// Token: 0x0400E3DA RID: 58330
	[Nullable(2)]
	protected AController DefaultControllerInternal;

	// Token: 0x0400E3DB RID: 58331
	[Nullable(2)]
	private BP_PartHitEffect_C PartHitConf;

	// Token: 0x0400E3DC RID: 58332
	public float StartHideDistance;

	// Token: 0x0400E3DD RID: 58333
	public float CompleteHideDistance;

	// Token: 0x0400E3DE RID: 58334
	public float StartDitherValue;

	// Token: 0x0400E3DF RID: 58335
	[StaticVariableRuleIgnore]
	protected static global::Vector TmpVector = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400E3E0 RID: 58336
	[StaticVariableRuleIgnore]
	protected static Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E3E1 RID: 58337
	private readonly global::Vector InputDirectInternal = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400E3E2 RID: 58338
	private EInputDirectSpace InputDirectSpaceInternal;

	// Token: 0x0400E3E3 RID: 58339
	private readonly global::Rotator InputRotatorInternal = global::Rotator.Create(0f, 0f, 0f);

	// Token: 0x0400E3E4 RID: 58340
	private readonly global::Vector InputFacingInternal = global::Vector.Create(1.0, 0.0, 0.0);

	// Token: 0x0400E3E5 RID: 58341
	protected VehicleActorComponent.ENewestInputFacingType NewestInputFacingType;

	// Token: 0x0400E3E6 RID: 58342
	public float? OverrideTurnSpeed = new float?(0f);

	// Token: 0x0200898D RID: 35213
	[NullableContext(0)]
	public enum ENewestInputFacingType
	{
		// Token: 0x0402BD34 RID: 179508
		All,
		// Token: 0x0402BD35 RID: 179509
		Rotator,
		// Token: 0x0402BD36 RID: 179510
		Facing
	}
}

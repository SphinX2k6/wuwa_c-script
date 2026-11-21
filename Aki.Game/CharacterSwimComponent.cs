using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.TickScore;
using UnrealEngine;

// Token: 0x020025E9 RID: 9705
[NullableContext(2)]
[Nullable(0)]
public class CharacterSwimComponent : EntityComponent, IScoreUpdateObject, IStaticVariableResetter
{
	// Token: 0x060182E1 RID: 99041 RVA: 0x007446F0 File Offset: 0x007428F0
	static CharacterSwimComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSwimComponent.CreateStaticDefaultValue), new Action(CharacterSwimComponent.ResetStaticDefaultValue));
	}

	// Token: 0x170025EC RID: 9708
	// (get) Token: 0x060182E2 RID: 99042 RVA: 0x00744754 File Offset: 0x00742954
	[Nullable(1)]
	public override Type[] Dependencies
	{
		[NullableContext(1)]
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterMoveComponent),
				typeof(BaseTagComponent)
			};
		}
	}

	// Token: 0x060182E3 RID: 99043 RVA: 0x00744783 File Offset: 0x00742983
	private void TeleportComplete(TeleportContext teleportContext)
	{
		this.SetForceCheck();
	}

	// Token: 0x060182E4 RID: 99044 RVA: 0x0074478B File Offset: 0x0074298B
	private void SetForceCheck()
	{
		this.ForceCheck = true;
	}

	// Token: 0x060182E5 RID: 99045 RVA: 0x00744794 File Offset: 0x00742994
	private void ReceiveMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.空中入水"]));
		if (this.EnterSwimFromAirBuffIndex != 0)
		{
			CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
			if (component != null)
			{
				component.RemoveBuffByHandle(this.EnterSwimFromAirBuffIndex, -1, "空中入水结束", null, null, null);
			}
			this.EnterSwimFromAirBuffIndex = 0;
		}
		if (newMoveState == global::ECharMoveState.FastSwim)
		{
			this.MaxSpeed = this.MoveComp.MovementData.FaceDirection.Standing.FastSwimSpeed;
			this.IsFastSwim = true;
			this.RefreshSwimBuff();
			return;
		}
		if (newMoveState == global::ECharMoveState.NormalSwim)
		{
			this.MaxSpeed = this.MoveComp.MovementData.FaceDirection.Standing.NormalSwimSpeed;
			this.IsFastSwim = false;
			this.RefreshSwimBuff();
			return;
		}
		this.LeaveSwim();
	}

	// Token: 0x060182E6 RID: 99046 RVA: 0x0074487A File Offset: 0x00742A7A
	private void ReceivePositionStateChanged(global::ECharPositionState oldPositionState, global::ECharPositionState newPositionState)
	{
		if (oldPositionState == global::ECharPositionState.Water)
		{
			this.LeaveSwim();
			return;
		}
		if (newPositionState == global::ECharPositionState.Water)
		{
			this.RefreshSwimBuff();
		}
	}

	// Token: 0x060182E7 RID: 99047 RVA: 0x00744891 File Offset: 0x00742A91
	private void SwimStrengthTagChanged(int count, int tagId, int exactTagId, int oldCount)
	{
		this.RefreshSwimBuff();
	}

	// Token: 0x060182E8 RID: 99048 RVA: 0x0074489C File Offset: 0x00742A9C
	private void ReceiveSwimEvent(float deltaTime)
	{
		double num = (double)((-(double)MathUtils.Instance.Clamp(this.MoveComp.Speed / 75f, 0f, 1f) + 1f) * 10000f + 1f) * 0.01;
		float angleOffsetFromCurrentToInputAbs = GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.ActorComp);
		float accelerator = this.SwimAcceleratorCurve.GetFloatValue(angleOffsetFromCurrentToInputAbs) * 200f;
		this.RotateSpeed = this.SwimRotationCurve.GetFloatValue(angleOffsetFromCurrentToInputAbs);
		double num2 = (this.SwimState == ESwimState.Other) ? 0.0 : 1.4;
		this.MoveComp.CharacterMovement.KuroSwimming(deltaTime, true, this.Depth, (float)num2, (float)num, this.MaxSpeed, this.WaterSlope, accelerator, 0.06f);
	}

	// Token: 0x170025ED RID: 9709
	// (get) Token: 0x060182E9 RID: 99049 RVA: 0x0074496F File Offset: 0x00742B6F
	// (set) Token: 0x060182EA RID: 99050 RVA: 0x00744977 File Offset: 0x00742B77
	protected long BuffIndex
	{
		get
		{
			return this.BuffIndexInternal;
		}
		set
		{
			if (this.BuffIndexInternal == value)
			{
				return;
			}
			this.BuffIndexInternal = value;
			EventSystem.Instance.EmitWithTarget<long>(base.Entity, EEventName.CharSwimStrengthChanged, this.BuffIndexInternal);
		}
	}

	// Token: 0x170025EE RID: 9710
	// (get) Token: 0x060182EB RID: 99051 RVA: 0x007449A6 File Offset: 0x00742BA6
	// (set) Token: 0x060182EC RID: 99052 RVA: 0x007449B0 File Offset: 0x00742BB0
	protected int WaterType
	{
		get
		{
			return (int)this.WaterTypeInternal;
		}
		set
		{
			if (this.WaterTypeInternal == (EInteractionWaterType)value)
			{
				return;
			}
			this.WaterTypeInternal = (EInteractionWaterType)value;
			EventSystem.Instance.EmitWithTarget<EInteractionWaterType>(base.Entity, EEventName.OnInteractionWaterTypeChange, (EInteractionWaterType)value);
		}
	}

	// Token: 0x060182ED RID: 99053 RVA: 0x007449E7 File Offset: 0x00742BE7
	[NullableContext(1)]
	private void StateInheritHandle(Entity oldEntity, bool notInheritMoveAndAnim)
	{
		this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
	}

	// Token: 0x060182EE RID: 99054 RVA: 0x00744A00 File Offset: 0x00742C00
	private void EnterSwimmingState()
	{
		if (!this.ActorComp.IsBoss)
		{
			this.SkillComp.StopAllSkills("CharacterSwimComponent.EnterSwimmingState");
			if (this.IsDebug)
			{
				Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[游泳组件]触发入水,打断0组技能", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
		if (!this.MoveComp.FallingIntoWater)
		{
			global::Vector tempVector = this.TempVector;
			FVector lastUpdateVelocity = this.MoveComp.CharacterMovement.LastUpdateVelocity;
			FVectorDouble fvectorDouble = lastUpdateVelocity;
			tempVector.DeepCopy(fvectorDouble);
			double num = GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TempVector);
			num = MathUtils.Instance.Clamp(num, -50.0, 50.0);
			GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.TempVector, num);
			this.MoveComp.CharacterMovement.LastUpdateVelocity = this.TempVector.ToUeVectorOld();
			this.MoveComp.SetForceSpeed(this.TempVector);
			if (this.IsDebug)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[游泳组件]触发入水,入水速度过大，限制到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("入水速度", this.TempVector);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Custom,
			CustomMode = 1,
			Context = "[CharacterSwimComponent.EnterSwimmingState]"
		});
	}

	// Token: 0x060182EF RID: 99055 RVA: 0x00744B64 File Offset: 0x00742D64
	protected override bool OnStart()
	{
		this.Depth = 0f;
		this.MaxSpeed = 0f;
		this.WaterSlope = 0f;
		this.RotateSpeed = 0f;
		this.IsFastSwim = false;
		this.InSwimTriggerCount = 0;
		this.ForceCheck = false;
		this.CreateTempVector();
		this.LastEnterWaterTime = 0f;
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.IsRole = (component.GetEntityType() == EEntityType.Player);
		this.SwimState = ESwimState.Swim;
		if (!this.LoadActorInfo())
		{
			return false;
		}
		if (!this.LoadConfig())
		{
			return false;
		}
		if (!this.LoadCurve())
		{
			return false;
		}
		this.InitTraceElements();
		if (this.IsRole)
		{
			EventSystem.Instance.AddWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.ReceiveMoveStateChange));
			EventSystem.Instance.AddWithTarget<global::ECharPositionState, global::ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.ReceivePositionStateChanged));
			EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMoveSwim, new Action<float>(this.ReceiveSwimEvent));
			EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.StateInheritHandle));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.SetForceCheck));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.TeleportComplete));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.SetForceCheck));
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTagChangedListener(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.游泳.游泳体力消耗"], new BaseTagComponent.TTagChangedCallback(this.SwimStrengthTagChanged), null);
			}
		}
		this.ActorComp.Actor.Tags.Add(CharacterNameDefines.Instance.ENABLE_MOVE_TRIGGER_TAG);
		return true;
	}

	// Token: 0x060182F0 RID: 99056 RVA: 0x00744D3C File Offset: 0x00742F3C
	private void InitTraceElements()
	{
		this.WaterTrace = new UTraceSphereElement();
		this.WaterTrace.WorldContextObject = this.ActorComp.Actor;
		this.WaterTrace.Radius = 1f;
		this.WaterTrace.bIgnoreSelf = true;
		this.WaterTrace.bIsSingle = false;
		this.WaterTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
		this.WaterTrace.DrawTime = 0.1f;
		this.WaterTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		TraceElementCommon.Instance.SetTraceColor(this.WaterTrace, CharacterSwimUtils.DebugColor3);
		TraceElementCommon.Instance.SetTraceHitColor(this.WaterTrace, CharacterSwimUtils.DebugColor4);
	}

	// Token: 0x060182F1 RID: 99057 RVA: 0x00744DF4 File Offset: 0x00742FF4
	private void RefreshSwimAreaHeight()
	{
		if (this.MoveComp != null && !this.MoveComp.IsStandardGravity)
		{
			this.InSwimAreaInternal = true;
			this.SwimAreaHeightAboveActor = 500f;
			this.WaterHeightAboveMe = 0f;
			return;
		}
		if (CharacterSwimComponent.UseSwimTrigger)
		{
			this.InSwimAreaInternal = (this.InSwimTriggerCount > 0);
			this.SwimAreaHeightAboveActor = 500f;
			this.WaterHeightAboveMe = 0f;
			return;
		}
		float num = 0f;
		FVectorDouble actorLocation;
		bool flag;
		if (this.ActorComp.IsRoleAndCtrlByMe)
		{
			CharacterUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
			if (unifiedStateComp != null && unifiedStateComp.PositionState == global::ECharPositionState.Air)
			{
				this.ActorComp.ActorVelocityProxy.Multiply((double)this.DeltaTime, this.TempVector);
				double addZ = Math.Min(0.0, GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector));
				this.TempVector.Set(500.0, 500.0, 5000.0);
				GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempVector, addZ);
				UObject actor = this.ActorComp.Actor;
				actorLocation = this.ActorComp.ActorLocation;
				FVectorDouble fvectorDouble = this.TempVector.ToUeVector(false);
				flag = UNavigationSystemV1.D_NavigationGetWaterSurface(actor, actorLocation, fvectorDouble, ref num, this.ActorComp.Actor, null, this.ActorComp.Actor.CapsuleComponent.CapsuleHalfHeight + 50f);
				goto IL_1C1;
			}
		}
		UObject actor2 = this.ActorComp.Actor;
		actorLocation = this.ActorComp.ActorLocation;
		flag = UNavigationSystemV1.D_NavigationGetWaterSurface(actor2, actorLocation, CharacterSwimComponent.waterAreaDetectExtent, ref num, this.ActorComp.Actor, null, this.ActorComp.Actor.CapsuleComponent.CapsuleHalfHeight + 50f);
		IL_1C1:
		this.InSwimAreaInternal = flag;
		if (flag)
		{
			this.WaterHeightAboveMe = (float)((double)num - this.ActorComp.FloorLocation.Z);
			this.SwimAreaHeightAboveActor = (float)((double)num - this.ActorComp.ActorLocationProxy.Z + 100.0);
			return;
		}
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.强制游泳检测"]))
		{
			this.SwimAreaHeightAboveActor = 500f;
			this.InSwimAreaInternal = true;
			return;
		}
		this.SwimAreaHeightAboveActor = 0f;
	}

	// Token: 0x060182F2 RID: 99058 RVA: 0x0074504C File Offset: 0x0074324C
	private bool InSwimArea()
	{
		return this.InSwimAreaInternal;
	}

	// Token: 0x060182F3 RID: 99059 RVA: 0x00745054 File Offset: 0x00743254
	private void RemoveTraceElements()
	{
		if (this.WaterTrace != null)
		{
			this.WaterTrace.Dispose();
			this.WaterTrace = null;
		}
	}

	// Token: 0x060182F4 RID: 99060 RVA: 0x00745070 File Offset: 0x00743270
	protected unsafe override void OnTick(float deltaTime)
	{
		this.ResetWaterLocation();
		if (!this.ActorComp.IsAutonomousProxy)
		{
			return;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.取消游泳检测"]) || this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不会入水"]))
		{
			int id = base.Entity.Id;
			SceneTeamModel instance = SceneTeamModel.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				num = ((getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null);
			}
			int? num2 = num;
			if (id == num2.GetValueOrDefault() & num2 != null)
			{
				this.TempPlayerLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
				if (this.AnimComp != null)
				{
					GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempPlayerLocation, (double)this.AnimComp.IkMeshOffset);
				}
				this.TempPlayerGravityUp.DeepCopy(GravityUtils.Instance.GetGravityUpForActor(this.ActorComp));
				this.CheckTagInWater(true);
				this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
			return;
		}
		this.RefreshSwimAreaHeight();
		if (!this.IsRole)
		{
			if (!this.InSwimArea())
			{
				if (this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom && this.MoveComp.CharacterMovement.CustomMovementMode == 1)
				{
					CharacterActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = EMovementMode.MOVE_Falling,
							CustomMode = 0,
							Context = "[CharacterSwimComponent.OnTick]"
						});
					}
				}
			}
			else
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 == null || !actorComp2.ActorLocationProxy.Equals(this.ActorComp.LastActorLocation, 9.999999747378752E-05))
				{
					TickScoreController.Instance.SwimTickScore.AddScore(this, 1);
				}
			}
			global::Vector.VectorCopy(this.ActorComp.ActorLocationProxy, this.LastTickLocation);
			return;
		}
		if ((!(this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom) || this.MoveComp.CharacterMovement.CustomMovementMode != 1) && !this.InSwimArea() && !this.ForceCheck)
		{
			if (this.MoveComp.FallingIntoWater && Time.Instance.Now > (double)this.LastEnterWaterTime)
			{
				this.MoveComp.FallingIntoWater = false;
				this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.空中入水"]));
				if (this.EnterSwimFromAirBuffIndex != 0)
				{
					CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
					if (component != null)
					{
						component.RemoveBuffByHandle(this.EnterSwimFromAirBuffIndex, -1, "空中入水结束", null, null, null);
					}
					this.EnterSwimFromAirBuffIndex = 0;
				}
			}
			this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			return;
		}
		this.DeltaTime = deltaTime * 0.001f;
		this.TempPlayerLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		if (this.AnimComp != null)
		{
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempPlayerLocation, (double)this.AnimComp.IkMeshOffset);
		}
		this.TempPlayerGravityUp.DeepCopy(GravityUtils.Instance.GetGravityUpForActor(this.ActorComp));
		if (global::Vector.DistSquared(this.LastTickLocation, this.TempPlayerLocation) > 100000000.0)
		{
			if (this.IsDebug)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[游泳组件]与上一帧位置差巨大,重新设置这一帧位置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastTickLocation", this.LastTickLocation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerLocation", this.TempPlayerLocation);
				instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		if (this.CheckTagInOtherStateThenEnterWater(this.GetCurrentExpectedEnterState()))
		{
			this.Depth = 1f;
			this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			return;
		}
		this.CheckTagInWater(false);
		this.CheckCustomMovementIsSwim(this.DeltaTime);
		this.HasFloor = this.CheckHasArrivedFloorInSwimming();
		this.CheckSwimState();
		this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.ForceCheck = false;
	}

	// Token: 0x060182F5 RID: 99061 RVA: 0x007454E3 File Offset: 0x007436E3
	public void ScoreUpdate()
	{
		if (!base.Active || this.ActorComp == null)
		{
			return;
		}
		global::Vector.VectorCopy(this.ActorComp.ActorLocationProxy, this.TempPlayerLocation);
		this.SimpleCheckInWater();
	}

	// Token: 0x060182F6 RID: 99062 RVA: 0x00745514 File Offset: 0x00743714
	protected override bool OnEnd()
	{
		this.ClearTempVector();
		this.RemoveTraceElements();
		if (this.IsRole)
		{
			EventSystem.Instance.RemoveWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.ReceiveMoveStateChange));
			EventSystem.Instance.RemoveWithTarget<global::ECharPositionState, global::ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.ReceivePositionStateChanged));
			EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMoveSwim, new Action<float>(this.ReceiveSwimEvent));
			EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.StateInheritHandle));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.SetForceCheck));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.TeleportComplete));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.SetForceCheck));
		}
		return true;
	}

	// Token: 0x060182F7 RID: 99063 RVA: 0x00745614 File Offset: 0x00743814
	private void CreateTempVector()
	{
		this.TempStartPoint = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempEndPoint = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempVector = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempVector2 = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempVector3 = global::Vector.Create(0.0, 0.0, 0.0);
		this.DetectFallIntoWaterPosition = global::Vector.Create(0.0, 0.0, 0.0);
		this.LastTickLocation = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempPlayerLocation = global::Vector.Create(0.0, 0.0, 0.0);
		this.TempPlayerGravityUp = global::Vector.Create(0.0, 0.0, 1.0);
		this.TempWaterImpactPoint = global::Vector.Create(0.0, 0.0, double.MinValue);
		this.TempSwimImpactPoint = global::Vector.Create(0.0, 0.0, double.MinValue);
		this.TempSwimNormalPoint = global::Vector.Create(0.0, 0.0, 0.0);
	}

	// Token: 0x060182F8 RID: 99064 RVA: 0x007457EC File Offset: 0x007439EC
	private void ClearTempVector()
	{
		this.TempVector = null;
		this.TempVector2 = null;
		this.TempVector3 = null;
		this.TempStartPoint = null;
		this.TempEndPoint = null;
		this.DetectFallIntoWaterPosition = null;
		this.LastTickLocation = null;
		this.TempPlayerLocation = null;
		this.TempPlayerGravityUp = null;
		this.TempWaterImpactPoint = null;
		this.TempSwimImpactPoint = null;
		this.TempSwimNormalPoint = null;
	}

	// Token: 0x060182F9 RID: 99065 RVA: 0x00745850 File Offset: 0x00743A50
	private bool LoadActorInfo()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		global::Vector.VectorCopy(this.ActorComp.ActorLocationProxy, this.TempPlayerLocation);
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		this.TagComp = component;
		this.UnifiedStateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.SkillComp = base.Entity.GetComponent<CharacterSkillComponent>();
		this.ClimbComp = base.Entity.GetComponent<CharacterClimbComponent>();
		CharacterMoveComponent component2 = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		this.MoveComp = component2;
		this.CharacterHalfHeight = this.ActorComp.HalfHeight;
		global::Vector.VectorCopy(this.ActorComp.ActorLocationProxy, this.LastTickLocation);
		return true;
	}

	// Token: 0x060182FA RID: 99066 RVA: 0x0074593C File Offset: 0x00743B3C
	private bool LoadConfig()
	{
		if (!this.IsRole)
		{
			return true;
		}
		this.SwimConfigInternal = SwimConfig.Instance.GetSwimConfigByRoleBodyId(this.ActorComp.CreatureData.GetRoleConfig().Value.RoleBody);
		if (this.SwimConfigInternal != null)
		{
			this.SprintSwimOffset = 0f;
			this.SprintSwimOffsetLerpSpeed = this.SwimConfigInternal.Value.SprintZOffsetSpeed;
			return true;
		}
		return false;
	}

	// Token: 0x060182FB RID: 99067 RVA: 0x007459B8 File Offset: 0x00743BB8
	private bool LoadCurve()
	{
		if (!this.IsRole)
		{
			return true;
		}
		this.SwimAcceleratorCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/Role/Common/Data/Curves/CT_SwimAcceleratorStrength.CT_SwimAcceleratorStrength");
		this.SwimRotationCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/Role/Common/Data/Curves/CT_SwimRotateSpeed.CT_SwimRotateSpeed");
		if (this.SwimAcceleratorCurve != null && this.SwimRotationCurve != null)
		{
			return true;
		}
		Log.Instance.Error(ELogModule.Movement, ELogAuthor.LJM, "游泳配置曲线加载失败，曲线为/Game/Aki/Character/Role/Common/Data/Curves/CT_SwimAcceleratorStrength.CT_SwimAcceleratorStrength或者/Game/Aki/Character/Role/Common/Data/Curves/CT_SwimRotateSpeed.CT_SwimRotateSpeed", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x060182FC RID: 99068 RVA: 0x00745A28 File Offset: 0x00743C28
	private ECheckFloorResult CheckHasArrivedFloorInSwimming()
	{
		if (!this.MoveComp.HasSwimmingBlock)
		{
			return ECheckFloorResult.None;
		}
		FFindFloorResult ffindFloorResult = new FFindFloorResult();
		this.MoveComp.CharacterMovement.D_K2_FindFloor(this.TempPlayerLocation.ToUeVector(false), ref ffindFloorResult);
		CharacterMoveComponent moveComp = this.MoveComp;
		bool flag;
		if (moveComp == null)
		{
			flag = false;
		}
		else
		{
			UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
			bool? flag2;
			if (characterMovement == null)
			{
				flag2 = null;
			}
			else
			{
				FHitResult hitResult = ffindFloorResult.HitResult;
				flag2 = new bool?(characterMovement.IsWalkable(hitResult));
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (!flag)
		{
			return ECheckFloorResult.NotFloor;
		}
		return ECheckFloorResult.Floor;
	}

	// Token: 0x060182FD RID: 99069 RVA: 0x00745AAC File Offset: 0x00743CAC
	private void CheckTagInWater(bool forceCheck = false)
	{
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]) && !forceCheck)
		{
			return;
		}
		int num = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.贡多拉.攀瀑"]) ? 600 : 0;
		int num2 = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.贡多拉.攀瀑"]) ? 250 : 0;
		global::Vector tempVector = this.TempVector;
		this.TempPlayerGravityUp.Multiply((double)(this.CharacterHalfHeight * 2f + (float)num), tempVector);
		global::Vector tempStartPoint = this.TempStartPoint;
		this.TempPlayerLocation.Addition(tempVector, tempStartPoint);
		this.TempPlayerGravityUp.Multiply((double)(this.CharacterHalfHeight + (float)num2), tempVector);
		global::Vector tempEndPoint = this.TempEndPoint;
		this.TempPlayerLocation.Subtraction(tempVector, tempEndPoint);
		this.Depth = this.DetectWaterDepth(tempStartPoint, tempEndPoint);
		this.WaterVolume = this.WaterTrace.HitResult.bBlockingHit;
		this.FixNormal(this.TempSwimNormalPoint);
	}

	// Token: 0x060182FE RID: 99070 RVA: 0x00745BBC File Offset: 0x00743DBC
	[NullableContext(1)]
	private bool UpdateWaterTraceResult(UKuroHitResult hitResult)
	{
		bool flag = false;
		bool flag2 = false;
		this.TempSwimImpactPoint.Reset();
		this.TempSwimNormalPoint.Reset();
		this.TempWaterImpactPoint.Reset();
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempSwimImpactPoint, double.MinValue);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempWaterImpactPoint, double.MinValue);
		double num = double.MinValue;
		double num2 = double.MinValue;
		int hitCount = hitResult.GetHitCount();
		for (int i = 0; i < hitCount; i++)
		{
			TWeakObjectPtr<AActor> weak = hitResult.Actors.Get(i);
			if (weak.IsValid(false, false))
			{
				if (UKuroCollisionLibrary.ActorHasTag(weak, CharacterSwimComponent.TagWaterNoSwim, hitResult.ItemArray.Get(i)))
				{
					flag2 = true;
					TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TempVector);
					double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector);
					if (znInGravityForActor > num2)
					{
						num2 = znInGravityForActor;
						this.TempWaterImpactPoint.DeepCopy(this.TempVector);
					}
				}
				else
				{
					flag = true;
					TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TempVector);
					double znInGravityForActor2 = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector);
					if (znInGravityForActor2 > num)
					{
						num = znInGravityForActor2;
						TraceElementCommon.Instance.GetImpactNormal(hitResult, i, this.TempSwimNormalPoint);
						this.TempSwimImpactPoint.DeepCopy(this.TempVector);
						this.SwimTime = hitResult.TimeArray.Get(i);
					}
				}
			}
		}
		if (!flag2 && flag)
		{
			this.TempWaterImpactPoint.DeepCopy(this.TempSwimImpactPoint);
		}
		return flag;
	}

	// Token: 0x060182FF RID: 99071 RVA: 0x00745D70 File Offset: 0x00743F70
	private EEnterWaterState GetCurrentExpectedEnterState()
	{
		if (this.MoveComp.FallingIntoWater)
		{
			return EEnterWaterState.Air;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			return EEnterWaterState.Air;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			return EEnterWaterState.Climb;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]))
		{
			return EEnterWaterState.Ground;
		}
		return EEnterWaterState.None;
	}

	// Token: 0x06018300 RID: 99072 RVA: 0x00745DE8 File Offset: 0x00743FE8
	[NullableContext(1)]
	private bool SimpleVisibleTrace(global::Vector start, global::Vector end, float scale = -1f)
	{
		if (scale < 0f)
		{
			scale = this.ActorComp.ScaledRadius;
		}
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = scale;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, start);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, end);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		return TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "CharacterSwimComponent_CheckHasArrivedFloorInSwimming", "CharacterSwimComponent_CheckHasArrivedFloorInSwimming");
	}

	// Token: 0x06018301 RID: 99073 RVA: 0x00745EC8 File Offset: 0x007440C8
	[NullableContext(1)]
	private bool SimpleWaterTrace(global::Vector start, global::Vector end)
	{
		TraceElementCommon.Instance.SetStartLocation(this.WaterTrace, start);
		TraceElementCommon.Instance.SetEndLocation(this.WaterTrace, end);
		bool flag = TraceElementCommon.Instance.SphereTrace(this.WaterTrace, "CharacterSwimComponent_DetectWaterDepth");
		if (flag)
		{
			flag = this.UpdateWaterTraceResult(this.WaterTrace.HitResult);
		}
		if (this.WaterTrace.HitResult.bBlockingHit)
		{
			this.CheckHitWaterType();
		}
		return flag && this.WaterTrace.HitResult.bBlockingHit;
	}

	// Token: 0x06018302 RID: 99074 RVA: 0x00745F50 File Offset: 0x00744150
	private void CheckHitWaterType()
	{
		TArray<TWeakObjectPtr<UPhysicalMaterial>> physMaterials = this.WaterTrace.HitResult.PhysMaterials;
		int hitCount = this.WaterTrace.HitResult.GetHitCount();
		int i = 0;
		while (i < hitCount)
		{
			UPrimitiveComponent uprimitiveComponent = this.WaterTrace.HitResult.Components.Get(i).Get();
			UPhysicalMaterial uphysicalMaterial;
			if (uprimitiveComponent is ULandscapeHeightfieldCollisionComponent)
			{
				uphysicalMaterial = physMaterials.Get(i);
			}
			else
			{
				uphysicalMaterial = UKuroCollisionLibrary.GetBodyInstance(this.WaterTrace.HitResult, i).PhysMaterialOverride;
			}
			if (uphysicalMaterial == null)
			{
				uphysicalMaterial = UKuroRenderingRuntimeBPPluginBPLibrary.GetComponentPhysicalMaterial(uprimitiveComponent);
			}
			if (uphysicalMaterial != null)
			{
				string name = uphysicalMaterial.GetName();
				if (name == "CloudSeaLand")
				{
					this.WaterType = 1;
					return;
				}
				if (!(name == "GoldWater"))
				{
					this.WaterType = 0;
					return;
				}
				this.WaterType = 2;
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x06018303 RID: 99075 RVA: 0x00746034 File Offset: 0x00744234
	private bool SimpleCheckInWater()
	{
		global::Vector tempStartPoint = this.TempStartPoint;
		global::Vector tempEndPoint = this.TempEndPoint;
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]) && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.不会淹死"]))
		{
			tempStartPoint.DeepCopy(this.TempPlayerLocation);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempStartPoint, 0.25 * (double)this.CharacterHalfHeight * 2.0);
			tempEndPoint.DeepCopy(this.TempPlayerLocation);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempEndPoint, (double)this.SwimAreaHeightAboveActor);
			if (!this.SimpleWaterTrace(tempStartPoint, tempEndPoint))
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						CustomMode = 0,
						Context = "[CharacterSwimComponent.SimpleCheckInWater]"
					});
				}
				this.Depth = 0f;
			}
			else
			{
				this.Depth = 2f;
			}
		}
		else
		{
			tempStartPoint.DeepCopy(this.LastTickLocation);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempStartPoint, (double)(this.CharacterHalfHeight * 2f));
			tempEndPoint.DeepCopy(this.TempPlayerLocation);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempEndPoint, (double)(-(double)this.CharacterHalfHeight));
			this.Depth = this.DetectWaterDepth(tempStartPoint, tempEndPoint);
			if ((double)this.Depth > 0.75)
			{
				this.EnterSwimmingState();
				return true;
			}
		}
		return false;
	}

	// Token: 0x06018304 RID: 99076 RVA: 0x007461BC File Offset: 0x007443BC
	[NullableContext(1)]
	private unsafe void SetDetectFallIntoWaterPosition(global::Vector hitLocation, float rootMotionBaseOffset)
	{
		global::Vector tempVector = this.TempVector3;
		tempVector.DeepCopy(hitLocation);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempVector, (double)rootMotionBaseOffset);
		this.DetectFallIntoWaterPosition.DeepCopy(tempVector);
		this.ActorComp.SetActorLocation(this.DetectFallIntoWaterPosition.ToUeVector(false), "游泳.游泳入水播放位置设置", true);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				CustomMode = 0,
				Context = "[CharacterSwimComponent.SetDetectFallIntoWaterPosition]"
			});
		}
		global::Vector tempVector2 = this.TempVector;
		tempVector2.Reset();
		this.MoveComp.SetForceSpeed(tempVector2);
		if (this.IsDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[游泳组件]游泳触发入水机制,游泳入水设置位置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("坐标：", this.DetectFallIntoWaterPosition);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("强制速度：", tempVector2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor1);
		}
	}

	// Token: 0x06018305 RID: 99077 RVA: 0x007462CC File Offset: 0x007444CC
	public void DetectEnterWaterFromAir()
	{
		if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy) > 0.0 || this.MoveComp.FallingIntoWater)
		{
			return;
		}
		global::Vector tempVector = this.TempVector;
		global::Vector tempVector2 = this.TempVector2;
		tempVector2.DeepCopy(this.ActorComp.ActorVelocityProxy);
		tempVector2.Multiply((double)this.DeltaTime, tempVector2);
		tempVector2.Addition(this.TempPlayerLocation, tempVector);
		if (this.SimpleVisibleTrace(this.TempPlayerLocation, tempVector, -1f))
		{
			return;
		}
		bool flag = this.SimpleWaterTrace(this.TempPlayerLocation, tempVector);
		float characterHalfHeight = this.CharacterHalfHeight;
		if (!flag)
		{
			global::Vector tempVector3 = this.TempVector2;
			tempVector3.DeepCopy(tempVector);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempVector3, (double)(-(double)characterHalfHeight));
			if (this.SimpleVisibleTrace(tempVector, tempVector3, -1f))
			{
				return;
			}
			flag = this.SimpleWaterTrace(tempVector, tempVector3);
		}
		if (!flag)
		{
			return;
		}
		this.FixNormal(this.TempSwimNormalPoint);
		if (!this.IsNormalAccepted(this.TempSwimNormalPoint))
		{
			return;
		}
		global::Vector tempStartPoint = this.TempStartPoint;
		tempStartPoint.DeepCopy(this.TempSwimImpactPoint);
		global::Vector tempEndPoint = this.TempEndPoint;
		tempEndPoint.DeepCopy(tempStartPoint);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempEndPoint, (double)(-(double)this.CharacterHalfHeight) * 0.75 * 2.0);
		if (this.SimpleVisibleTrace(tempStartPoint, tempEndPoint, -1f))
		{
			return;
		}
		this.SkillComp.StopAllSkills("CharacterSwimComponent.DetectEnterWaterFromAir");
		this.SetDetectFallIntoWaterPosition(tempStartPoint, characterHalfHeight);
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.空中入水"]));
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		if (component != null)
		{
			this.EnterSwimFromAirBuffIndex = component.AddBuffLocal(3098L, new AddBuffParam
			{
				InstigatorId = this.ActorComp.CreatureData.GetCreatureDataId(),
				Duration = new float?((float)1),
				Reason = "空中入水"
			});
		}
		this.MoveComp.FallingIntoWater = true;
		this.LastEnterWaterTime = (float)Time.Instance.Now + 500f;
	}

	// Token: 0x06018306 RID: 99078 RVA: 0x007464F0 File Offset: 0x007446F0
	[NullableContext(1)]
	private void FixNormal(global::Vector inVector)
	{
		double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, inVector);
		if (znInGravityForActor < 0.0)
		{
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, inVector, -znInGravityForActor * 2.0);
		}
	}

	// Token: 0x06018307 RID: 99079 RVA: 0x00746538 File Offset: 0x00744738
	[NullableContext(1)]
	private bool CheckIntoWater(global::Vector start, global::Vector end, float enterWaterZ)
	{
		start.Subtraction(end, this.TempVector);
		if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector) < 0.0)
		{
			return false;
		}
		if (this.DetectWaterDepth(start, end) == 0f)
		{
			return false;
		}
		if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempSwimImpactPoint) < (double)enterWaterZ)
		{
			return false;
		}
		this.FixNormal(this.TempSwimNormalPoint);
		return this.IsNormalAccepted(this.TempSwimNormalPoint);
	}

	// Token: 0x06018308 RID: 99080 RVA: 0x007465BC File Offset: 0x007447BC
	private bool CheckTagFromAir()
	{
		if (!this.MoveComp.FallingIntoWater)
		{
			this.DetectEnterWaterFromAir();
		}
		global::Vector tempStartPoint = this.TempStartPoint;
		global::Vector tempEndPoint = this.TempEndPoint;
		tempStartPoint.DeepCopy(this.TempPlayerLocation);
		GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, tempStartPoint, GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.LastTickLocation) + (double)this.CharacterHalfHeight);
		tempEndPoint.DeepCopy(this.TempPlayerLocation);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempEndPoint, (double)(-(double)this.CharacterHalfHeight));
		if (!this.CheckIntoWater(tempStartPoint, tempEndPoint, (float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempPlayerLocation)))
		{
			return false;
		}
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempEndPoint, (double)(-(double)this.CharacterHalfHeight) * 0.75 * 2.0);
		if (this.SimpleVisibleTrace(tempStartPoint, tempEndPoint, 1f))
		{
			return false;
		}
		this.EnterSwimmingState();
		this.TempPlayerLocation.Subtraction(this.TempSwimImpactPoint, this.TempVector);
		if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector) < (double)(-(double)this.CharacterHalfHeight))
		{
			this.ActorComp.SetActorLocation(this.TempSwimImpactPoint.ToUeVector(false), "游泳.入水位置修正", true);
		}
		if (this.IsDebug)
		{
			Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[游泳组件]触发空中入水", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor2);
		}
		return true;
	}

	// Token: 0x06018309 RID: 99081 RVA: 0x0074673C File Offset: 0x0074493C
	private bool CheckTagFromGround()
	{
		global::Vector tempStartPoint = this.TempStartPoint;
		global::Vector tempEndPoint = this.TempEndPoint;
		tempStartPoint.DeepCopy(this.TempPlayerLocation);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempStartPoint, (double)this.CharacterHalfHeight);
		tempEndPoint.DeepCopy(this.TempPlayerLocation);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, tempEndPoint, (double)(-(double)this.CharacterHalfHeight));
		if (this.CheckIntoWater(tempStartPoint, tempEndPoint, (float)(GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempPlayerLocation) + 0.25 * (double)this.CharacterHalfHeight * 2.0)))
		{
			this.EnterSwimmingState();
			if (this.IsDebug)
			{
				Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[游泳组件]触发地面入水", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor2);
			}
			return true;
		}
		return false;
	}

	// Token: 0x0601830A RID: 99082 RVA: 0x00746818 File Offset: 0x00744A18
	private bool CheckTagFromClimb()
	{
		if (this.ClimbComp.GetTsClimbState().攀爬状态 == EClimbState.退出攀爬)
		{
			return false;
		}
		global::Vector tempVector = this.TempVector;
		tempVector.DeepCopy(this.TempPlayerGravityUp);
		tempVector.Multiply((double)this.CharacterHalfHeight, tempVector);
		this.LastTickLocation.Addition(tempVector, this.TempStartPoint);
		this.TempPlayerLocation.Subtraction(tempVector, this.TempEndPoint);
		if (!this.CheckIntoWater(this.TempStartPoint, this.TempEndPoint, (float)(GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempPlayerLocation) + 0.8 * (double)this.CharacterHalfHeight)))
		{
			return false;
		}
		if (this.SimpleVisibleTrace(this.TempStartPoint, this.TempEndPoint, 1f))
		{
			return false;
		}
		this.EnterSwimmingState();
		if (this.IsDebug)
		{
			Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[游泳组件]触发攀爬入水", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor2);
		}
		return true;
	}

	// Token: 0x0601830B RID: 99083 RVA: 0x00746914 File Offset: 0x00744B14
	public bool CheckUpWaterSurface()
	{
		global::Vector tempStartPoint = this.TempStartPoint;
		this.TempPlayerGravityUp.Multiply((double)this.SwimAreaHeightAboveActor, tempStartPoint);
		tempStartPoint.Addition(this.TempPlayerLocation, tempStartPoint);
		global::Vector tempEndPoint = this.TempEndPoint;
		this.TempPlayerGravityUp.Multiply((double)this.CharacterHalfHeight, tempEndPoint);
		tempEndPoint.Addition(this.TempPlayerLocation, tempEndPoint);
		bool flag = this.CheckIntoWater(tempStartPoint, tempEndPoint, (float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, tempEndPoint));
		if (flag && this.SimpleVisibleTrace(tempEndPoint, this.TempSwimImpactPoint, -1f))
		{
			UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
			TraceElementCommon.Instance.GetImpactPoint(actorTrace.HitResult, 0, this.TempVector);
			double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector);
			TraceElementCommon.Instance.GetImpactPoint(this.WaterTrace.HitResult, 0, this.TempVector);
			double znInGravityForActor2 = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector);
			if (znInGravityForActor < znInGravityForActor2)
			{
				this.ResetWaterLocation();
				return false;
			}
		}
		return flag;
	}

	// Token: 0x0601830C RID: 99084 RVA: 0x00746A24 File Offset: 0x00744C24
	private bool CheckTagFromUp()
	{
		bool flag = this.CheckUpWaterSurface();
		if (flag)
		{
			this.EnterSwimmingState();
			if (this.IsDebug)
			{
				Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[游泳组件]触发保底的向上探测入水", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor2);
			}
		}
		return flag;
	}

	// Token: 0x0601830D RID: 99085 RVA: 0x00746A70 File Offset: 0x00744C70
	private bool CheckTagInOtherStateThenEnterWater(EEnterWaterState enterState)
	{
		if (this.MoveComp.FallingIntoWater && Time.Instance.Now > (double)this.LastEnterWaterTime)
		{
			this.MoveComp.FallingIntoWater = false;
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.空中入水"]));
			if (this.EnterSwimFromAirBuffIndex != 0)
			{
				CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
				if (component != null)
				{
					component.RemoveBuffByHandle(this.EnterSwimFromAirBuffIndex, -1, "空中入水结束", null, null, null);
				}
				this.EnterSwimFromAirBuffIndex = 0;
			}
		}
		bool flag = false;
		switch (enterState)
		{
		case EEnterWaterState.None:
			flag = false;
			break;
		case EEnterWaterState.Air:
			flag = this.CheckTagFromAir();
			break;
		case EEnterWaterState.Climb:
			flag = this.CheckTagFromClimb();
			break;
		case EEnterWaterState.Ground:
			flag = this.CheckTagFromGround();
			break;
		}
		if (enterState != EEnterWaterState.None && !flag)
		{
			flag = this.CheckTagFromUp();
		}
		return flag;
	}

	// Token: 0x0601830E RID: 99086 RVA: 0x00746B60 File Offset: 0x00744D60
	private void CheckCustomMovementIsSwim(float deltaTime)
	{
		if (this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom && this.MoveComp.CharacterMovement.CustomMovementMode == 1)
		{
			this.SprintSwimOffset = (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]) ? (this.SwimConfigInternal.Value.SprintZOffsetRate * this.ActorComp.Radius) : 0f);
			this.MoveComp.FallingIntoWater = false;
		}
	}

	// Token: 0x0601830F RID: 99087 RVA: 0x00746BF3 File Offset: 0x00744DF3
	[NullableContext(1)]
	private bool IsNormalAccepted(global::Vector normal)
	{
		return MathUtils.Instance.DotProduct(normal, this.MoveComp.GravityUp) > 0.173;
	}

	// Token: 0x06018310 RID: 99088 RVA: 0x00746C16 File Offset: 0x00744E16
	private void LeaveSwim()
	{
		this.BuffIndex = 0L;
		this.SprintSwimOffset = 0f;
	}

	// Token: 0x06018311 RID: 99089 RVA: 0x00746C2C File Offset: 0x00744E2C
	private unsafe void CheckSwimState()
	{
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]))
		{
			return;
		}
		if (this.WaterVolume && !this.IsNormalAccepted(this.TempSwimNormalPoint))
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Falling,
					CustomMode = 0,
					Context = "[CharacterSwimComponent.CheckSwimState] 1"
				});
			}
			if (this.IsDebug)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[游泳组件]触发水面角度不够游泳支持触发出水";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("水面法线:", this.TempSwimNormalPoint);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor3);
				return;
			}
		}
		else if (!this.WaterVolume && !this.MoveComp.FallingIntoWater)
		{
			if (this.CheckUpWaterSurface())
			{
				this.Depth = 2f;
				return;
			}
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Walking,
					CustomMode = 0,
					Context = "[CharacterSwimComponent.CheckSwimState] 2"
				});
			}
			this.LeaveSwim();
			if (this.IsDebug)
			{
				Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[游泳组件]游泳向上探测出水未有水面触发出水", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor3);
				return;
			}
		}
		else if ((double)this.Depth <= 0.7)
		{
			if (this.HasFloor == ECheckFloorResult.Floor)
			{
				CharacterActorComponent actorComp3 = this.ActorComp;
				if (actorComp3 != null)
				{
					actorComp3.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Walking,
						CustomMode = 0,
						Context = "[CharacterSwimComponent.CheckSwimState] 3"
					});
				}
				if (this.IsDebug)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Movement;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "[游泳组件]触发碰撞并且游泳深度不够触发出水";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前深度:", this.Depth);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("出水深度:", 0.7);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.DrawDebugCapsuleComponent(CharacterSwimUtils.DebugColor3);
					return;
				}
			}
			else if (this.HasFloor == ECheckFloorResult.NotFloor)
			{
				CharacterActorComponent actorComp4 = this.ActorComp;
				if (actorComp4 == null)
				{
					return;
				}
				actorComp4.SetActorLocation(this.ActorComp.LastActorLocation.ToUeVector(false), "SwimOff", false);
			}
		}
	}

	// Token: 0x06018312 RID: 99090 RVA: 0x00746E89 File Offset: 0x00745089
	public bool CheckCanEnterClimbFromSwim()
	{
		return !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]) || (double)this.Depth <= 0.8;
	}

	// Token: 0x06018313 RID: 99091 RVA: 0x00746EC0 File Offset: 0x007450C0
	[NullableContext(1)]
	private float DetectWaterDepth(global::Vector start, global::Vector end)
	{
		if (!this.SimpleWaterTrace(start, end))
		{
			return 0f;
		}
		if (this.IsDebug)
		{
			FVectorDouble fvectorDouble = this.TempSwimImpactPoint.ToUeVector(false);
			this.DrawDebugSphere(fvectorDouble, CharacterSwimUtils.DebugColor2);
		}
		start.Subtraction(end, this.TempVector3);
		return (float)(GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TempVector3) * (double)(1f - this.SwimTime) / (double)(2f * this.CharacterHalfHeight));
	}

	// Token: 0x06018314 RID: 99092 RVA: 0x00746F48 File Offset: 0x00745148
	private void RefreshSwimBuff()
	{
		CharacterUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
		if (unifiedStateComp == null || unifiedStateComp.PositionState != global::ECharPositionState.Water)
		{
			this.BuffIndex = 0L;
			return;
		}
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.游泳.游泳体力消耗"]))
		{
			this.BuffIndex = 0L;
			return;
		}
		bool hasMoveInput = this.MoveComp.HasMoveInput;
		this.BuffIndex = SwimConfig.Instance.GetSwimBuffId(hasMoveInput, this.IsFastSwim).Value;
	}

	// Token: 0x06018315 RID: 99093 RVA: 0x00746FC8 File Offset: 0x007451C8
	private void ResetWaterLocation()
	{
		if (this.TempSwimImpactPoint != null)
		{
			this.TempSwimImpactPoint.Reset();
		}
		if (this.TempSwimNormalPoint != null)
		{
			this.TempSwimNormalPoint.Reset();
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempSwimNormalPoint, double.MinValue);
		}
		if (this.TempWaterImpactPoint != null)
		{
			this.TempWaterImpactPoint.Reset();
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempWaterImpactPoint, double.MinValue);
		}
	}

	// Token: 0x06018316 RID: 99094 RVA: 0x0074704C File Offset: 0x0074524C
	public FVectorDouble GetWaterLocation()
	{
		return this.TempWaterImpactPoint.ToUeVector(false);
	}

	// Token: 0x06018317 RID: 99095 RVA: 0x0074705A File Offset: 0x0074525A
	public FVectorDouble GetSwimLocation()
	{
		return this.TempSwimImpactPoint.ToUeVector(false);
	}

	// Token: 0x06018318 RID: 99096 RVA: 0x00747068 File Offset: 0x00745268
	public bool GetWaterVolume()
	{
		return this.WaterVolume;
	}

	// Token: 0x06018319 RID: 99097 RVA: 0x00747070 File Offset: 0x00745270
	public void SetEnterWaterState(bool isEnter)
	{
		this.SwimState = (isEnter ? ESwimState.Other : ESwimState.Swim);
	}

	// Token: 0x0601831A RID: 99098 RVA: 0x00747080 File Offset: 0x00745280
	[return: TupleElementNames(new string[]
	{
		"Depth",
		"WaterHeight",
		"SurfaceNormal",
		"Velocity",
		"Location"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public ValueTuple<float, float, global::Vector, global::Vector, global::Vector>? GetAboveFootWaterSurfaceInfo()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.SkeletalMesh : null) == null)
		{
			return null;
		}
		if (!this.InSwimArea() || this.Depth <= 0f || this.TempSwimNormalPoint == null)
		{
			return null;
		}
		if (this.Depth == 2f)
		{
			return null;
		}
		float item = this.Depth * this.CharacterHalfHeight * 2f;
		this.FixNormal(this.TempSwimNormalPoint);
		global::Vector item2 = global::Vector.Create(this.TempSwimNormalPoint);
		global::Vector vector = global::Vector.Create();
		global::Vector vector2 = vector;
		FVectorDouble fvectorDouble = this.ActorComp.SkeletalMesh.D_K2_GetComponentLocation();
		vector2.FromUeVector(fvectorDouble);
		global::Vector item3 = global::Vector.Create(this.ActorComp.ActorVelocityProxy);
		return new ValueTuple<float, float, global::Vector, global::Vector, global::Vector>?(new ValueTuple<float, float, global::Vector, global::Vector, global::Vector>(this.Depth, item, item2, item3, vector));
	}

	// Token: 0x0601831B RID: 99099 RVA: 0x00747160 File Offset: 0x00745360
	private void DrawDebugCapsuleComponent(FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugCapsule(this.ActorComp.Actor, this.ActorComp.Actor.D_K2_GetActorLocation(), this.ActorComp.Actor.CapsuleComponent.CapsuleHalfHeight, this.ActorComp.Actor.CapsuleComponent.CapsuleRadius, this.ActorComp.Actor.K2_GetActorRotation(), new FLinearColor?(color), 5f, 2f);
	}

	// Token: 0x0601831C RID: 99100 RVA: 0x007471D7 File Offset: 0x007453D7
	private void DrawDebugSphere(FVector location, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(this.ActorComp.Actor, location, this.ActorComp.Actor.CapsuleComponent.CapsuleHalfHeight, 12, new FLinearColor?(color), 0f, 1f);
	}

	// Token: 0x0601831D RID: 99101 RVA: 0x00747217 File Offset: 0x00745417
	public void SetDebug(bool debug)
	{
		this.IsDebug = debug;
		this.WaterTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
	}

	// Token: 0x0601831E RID: 99102 RVA: 0x00747237 File Offset: 0x00745437
	public void LogSwimTriggerCount()
	{
		bool isDebug = this.IsDebug;
	}

	// Token: 0x0601831F RID: 99103 RVA: 0x00747240 File Offset: 0x00745440
	public static void CreateStaticDefaultValue()
	{
		CharacterSwimComponent.UseSwimTrigger = false;
	}

	// Token: 0x06018320 RID: 99104 RVA: 0x00747248 File Offset: 0x00745448
	public static void ResetStaticDefaultValue()
	{
		CharacterSwimComponent.UseSwimTrigger = false;
	}

	// Token: 0x06018321 RID: 99105 RVA: 0x00747250 File Offset: 0x00745450
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSwimComponent characterSwimComponent = (CharacterSwimComponent)componentTemplate;
		this.IsDebug = characterSwimComponent.IsDebug;
		if (characterSwimComponent.TempPlayerLocation == null)
		{
			this.TempPlayerLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempPlayerLocation), "TempPlayerLocation"))
		{
			return false;
		}
		if (characterSwimComponent.TempPlayerGravityUp == null)
		{
			this.TempPlayerGravityUp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempPlayerGravityUp), "TempPlayerGravityUp"))
		{
			return false;
		}
		this.CharacterHalfHeight = characterSwimComponent.CharacterHalfHeight;
		if (characterSwimComponent.LastTickLocation == null)
		{
			this.LastTickLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastTickLocation), "LastTickLocation"))
		{
			return false;
		}
		this.HasFloor = characterSwimComponent.HasFloor;
		this.Depth = characterSwimComponent.Depth;
		this.RotateSpeed = characterSwimComponent.RotateSpeed;
		if (characterSwimComponent.SwimAcceleratorCurve == null)
		{
			this.SwimAcceleratorCurve = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwimAcceleratorCurve), "SwimAcceleratorCurve"))
		{
			return false;
		}
		if (characterSwimComponent.SwimRotationCurve == null)
		{
			this.SwimRotationCurve = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwimRotationCurve), "SwimRotationCurve"))
		{
			return false;
		}
		if (characterSwimComponent.TempWaterImpactPoint == null)
		{
			this.TempWaterImpactPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempWaterImpactPoint), "TempWaterImpactPoint"))
		{
			return false;
		}
		if (characterSwimComponent.TempSwimImpactPoint == null)
		{
			this.TempSwimImpactPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempSwimImpactPoint), "TempSwimImpactPoint"))
		{
			return false;
		}
		if (characterSwimComponent.TempSwimNormalPoint == null)
		{
			this.TempSwimNormalPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempSwimNormalPoint), "TempSwimNormalPoint"))
		{
			return false;
		}
		this.SwimTime = characterSwimComponent.SwimTime;
		this.WaterVolume = characterSwimComponent.WaterVolume;
		this.WaterSlope = characterSwimComponent.WaterSlope;
		this.MaxSpeed = characterSwimComponent.MaxSpeed;
		if (characterSwimComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterSwimComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterSwimComponent.UnifiedStateComp == null)
		{
			this.UnifiedStateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComp), "UnifiedStateComp"))
		{
			return false;
		}
		if (characterSwimComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterSwimComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (characterSwimComponent.ClimbComp == null)
		{
			this.ClimbComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClimbComp), "ClimbComp"))
		{
			return false;
		}
		if (characterSwimComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterSwimComponent.TempVector == null)
		{
			this.TempVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterSwimComponent.TempVector2 == null)
		{
			this.TempVector2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (characterSwimComponent.TempVector3 == null)
		{
			this.TempVector3 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector3), "TempVector3"))
		{
			return false;
		}
		if (characterSwimComponent.TempStartPoint == null)
		{
			this.TempStartPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempStartPoint), "TempStartPoint"))
		{
			return false;
		}
		if (characterSwimComponent.TempEndPoint == null)
		{
			this.TempEndPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempEndPoint), "TempEndPoint"))
		{
			return false;
		}
		this.SwimConfigInternal = characterSwimComponent.SwimConfigInternal;
		this.SprintSwimOffset = characterSwimComponent.SprintSwimOffset;
		this.SprintSwimOffsetLerpSpeed = characterSwimComponent.SprintSwimOffsetLerpSpeed;
		this.DeltaTime = characterSwimComponent.DeltaTime;
		if (characterSwimComponent.DetectFallIntoWaterPosition == null)
		{
			this.DetectFallIntoWaterPosition = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DetectFallIntoWaterPosition), "DetectFallIntoWaterPosition"))
		{
			return false;
		}
		this.BuffIndexInternal = characterSwimComponent.BuffIndexInternal;
		this.EnterSwimFromAirBuffIndex = characterSwimComponent.EnterSwimFromAirBuffIndex;
		this.IsFastSwim = characterSwimComponent.IsFastSwim;
		this.SwimState = characterSwimComponent.SwimState;
		this.LastEnterWaterTime = characterSwimComponent.LastEnterWaterTime;
		if (characterSwimComponent.WaterTrace == null)
		{
			this.WaterTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterTrace), "WaterTrace"))
		{
			return false;
		}
		this.InSwimTriggerCount = characterSwimComponent.InSwimTriggerCount;
		this.IsRole = characterSwimComponent.IsRole;
		this.SwimAreaHeightAboveActor = characterSwimComponent.SwimAreaHeightAboveActor;
		this.InSwimAreaInternal = characterSwimComponent.InSwimAreaInternal;
		this.WaterHeightAboveMe = characterSwimComponent.WaterHeightAboveMe;
		this.ForceCheck = characterSwimComponent.ForceCheck;
		this.WaterTypeInternal = characterSwimComponent.WaterTypeInternal;
		return true;
	}

	// Token: 0x170025EF RID: 9711
	// (get) Token: 0x06018322 RID: 99106 RVA: 0x0074774E File Offset: 0x0074594E
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025F0 RID: 9712
	// (get) Token: 0x06018323 RID: 99107 RVA: 0x00747751 File Offset: 0x00745951
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025F1 RID: 9713
	// (get) Token: 0x06018324 RID: 99108 RVA: 0x00747754 File Offset: 0x00745954
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D011 RID: 53265
	[Nullable(1)]
	private const string PROFILE_DETECT_WATER_DEPTH = "CharacterSwimComponent_DetectWaterDepth";

	// Token: 0x0400D012 RID: 53266
	[Nullable(1)]
	private const string PROFILE_FLOOR = "CharacterSwimComponent_CheckHasArrivedFloorInSwimming";

	// Token: 0x0400D013 RID: 53267
	private const long MAX_LAST_TICK_OFFSET_SQUARE = 100000000L;

	// Token: 0x0400D014 RID: 53268
	private const int MAX_SPEED_INTO_WATER = 50;

	// Token: 0x0400D015 RID: 53269
	private const double ENTER_SWIM_BIGGER_THAN_THIS = 0.75;

	// Token: 0x0400D016 RID: 53270
	public const double LEAVE_SWIM_LESS_THAN_THIS = 0.7;

	// Token: 0x0400D017 RID: 53271
	public const double LEAVE_SWIM_LESS_THAN_THIS_AIR = 0.6;

	// Token: 0x0400D018 RID: 53272
	private const double CLIMB_CHECK_ENTER_WATER_RATE = 0.8;

	// Token: 0x0400D019 RID: 53273
	private const int ONE_HUNDRED_TO_FIND_SURFACE = 100;

	// Token: 0x0400D01A RID: 53274
	private const int FIVE_HUNDRED_TO_FIND_SURFACE = 500;

	// Token: 0x0400D01B RID: 53275
	private const int TIME_CLEAR_ENTER_WATER = 500;

	// Token: 0x0400D01C RID: 53276
	public const double SWIMMING_BUOYANCY = 1.4;

	// Token: 0x0400D01D RID: 53277
	private const double SWIMMING_FRICTION = 0.01;

	// Token: 0x0400D01E RID: 53278
	private const int SWIMMING_FRICTION_MIN_SPEED = 75;

	// Token: 0x0400D01F RID: 53279
	private const int SWIMMING_FRICTION_RATION = 10000;

	// Token: 0x0400D020 RID: 53280
	private const int SWIMMING_MAX_DEPTH = 2;

	// Token: 0x0400D021 RID: 53281
	private const int SWIMMING_ACCELERATOR = 200;

	// Token: 0x0400D022 RID: 53282
	public const float SWIMMING_DECELERATION = 0.06f;

	// Token: 0x0400D023 RID: 53283
	private const double COS_EIGHTY = 0.173;

	// Token: 0x0400D024 RID: 53284
	private const double MIN_DEPTH = -1.7976931348623157E+308;

	// Token: 0x0400D025 RID: 53285
	private static readonly FVectorDouble waterAreaDetectExtent = new FVectorDouble(500.0, 500.0, 10000.0);

	// Token: 0x0400D026 RID: 53286
	private const int WATER_BOTTOM_TOLERANCE = 50;

	// Token: 0x0400D027 RID: 53287
	private const int VEHICLE_ADDITIONAL_HEIGHT = 600;

	// Token: 0x0400D028 RID: 53288
	private const int VEHICLE_ADDITIONAL_DEPTH = 250;

	// Token: 0x0400D029 RID: 53289
	public bool IsDebug;

	// Token: 0x0400D02A RID: 53290
	private static readonly FName TagWaterNoSwim = new FName("Water_No_Swim");

	// Token: 0x0400D02B RID: 53291
	public static bool UseSwimTrigger = false;

	// Token: 0x0400D02C RID: 53292
	private global::Vector TempPlayerLocation;

	// Token: 0x0400D02D RID: 53293
	private global::Vector TempPlayerGravityUp;

	// Token: 0x0400D02E RID: 53294
	private float CharacterHalfHeight;

	// Token: 0x0400D02F RID: 53295
	private global::Vector LastTickLocation;

	// Token: 0x0400D030 RID: 53296
	private ECheckFloorResult HasFloor;

	// Token: 0x0400D031 RID: 53297
	public float Depth;

	// Token: 0x0400D032 RID: 53298
	public float RotateSpeed;

	// Token: 0x0400D033 RID: 53299
	public UCurveFloat SwimAcceleratorCurve;

	// Token: 0x0400D034 RID: 53300
	public UCurveFloat SwimRotationCurve;

	// Token: 0x0400D035 RID: 53301
	private global::Vector TempWaterImpactPoint;

	// Token: 0x0400D036 RID: 53302
	private global::Vector TempSwimImpactPoint;

	// Token: 0x0400D037 RID: 53303
	private global::Vector TempSwimNormalPoint;

	// Token: 0x0400D038 RID: 53304
	private float SwimTime;

	// Token: 0x0400D039 RID: 53305
	private bool WaterVolume;

	// Token: 0x0400D03A RID: 53306
	public float WaterSlope;

	// Token: 0x0400D03B RID: 53307
	public float MaxSpeed;

	// Token: 0x0400D03C RID: 53308
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D03D RID: 53309
	private BaseTagComponent TagComp;

	// Token: 0x0400D03E RID: 53310
	private CharacterUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400D03F RID: 53311
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D040 RID: 53312
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400D041 RID: 53313
	private CharacterClimbComponent ClimbComp;

	// Token: 0x0400D042 RID: 53314
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D043 RID: 53315
	private global::Vector TempVector;

	// Token: 0x0400D044 RID: 53316
	private global::Vector TempVector2;

	// Token: 0x0400D045 RID: 53317
	private global::Vector TempVector3;

	// Token: 0x0400D046 RID: 53318
	private global::Vector TempStartPoint;

	// Token: 0x0400D047 RID: 53319
	private global::Vector TempEndPoint;

	// Token: 0x0400D048 RID: 53320
	private Swim? SwimConfigInternal;

	// Token: 0x0400D049 RID: 53321
	public float SprintSwimOffset;

	// Token: 0x0400D04A RID: 53322
	public float SprintSwimOffsetLerpSpeed;

	// Token: 0x0400D04B RID: 53323
	private float DeltaTime;

	// Token: 0x0400D04C RID: 53324
	private global::Vector DetectFallIntoWaterPosition;

	// Token: 0x0400D04D RID: 53325
	private long BuffIndexInternal;

	// Token: 0x0400D04E RID: 53326
	protected int EnterSwimFromAirBuffIndex;

	// Token: 0x0400D04F RID: 53327
	private bool IsFastSwim;

	// Token: 0x0400D050 RID: 53328
	private ESwimState SwimState = ESwimState.Other;

	// Token: 0x0400D051 RID: 53329
	private float LastEnterWaterTime;

	// Token: 0x0400D052 RID: 53330
	private UTraceSphereElement WaterTrace;

	// Token: 0x0400D053 RID: 53331
	public int InSwimTriggerCount;

	// Token: 0x0400D054 RID: 53332
	public bool IsRole;

	// Token: 0x0400D055 RID: 53333
	private float SwimAreaHeightAboveActor;

	// Token: 0x0400D056 RID: 53334
	private bool InSwimAreaInternal;

	// Token: 0x0400D057 RID: 53335
	public float WaterHeightAboveMe;

	// Token: 0x0400D058 RID: 53336
	private bool ForceCheck;

	// Token: 0x0400D059 RID: 53337
	private EInteractionWaterType WaterTypeInternal;
}

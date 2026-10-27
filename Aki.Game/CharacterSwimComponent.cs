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

// Token: 0x02003092 RID: 12434
[NullableContext(2)]
[Nullable(0)]
public class CharacterSwimComponent : EntityComponent, IScoreUpdateObject, IComponentDependency, IStaticVariableResetter
{
	// Token: 0x0601A8F4 RID: 108788 RVA: 0x0071E420 File Offset: 0x0071C620
	static CharacterSwimComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSwimComponent.CreateStaticDefaultValue), new Action(CharacterSwimComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700248B RID: 9355
	// (get) Token: 0x0601A8F5 RID: 108789 RVA: 0x0071E484 File Offset: 0x0071C684
	[Nullable(1)]
	public static Type[] Dependencies
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

	// Token: 0x0601A8F6 RID: 108790 RVA: 0x0071E4B3 File Offset: 0x0071C6B3
	private void TeleportComplete(TeleportContext teleportContext)
	{
		this.SetForceCheck();
	}

	// Token: 0x0601A8F7 RID: 108791 RVA: 0x0071E4BB File Offset: 0x0071C6BB
	private void SetForceCheck()
	{
		this.ForceCheck = true;
	}

	// Token: 0x0601A8F8 RID: 108792 RVA: 0x0071E4C4 File Offset: 0x0071C6C4
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

	// Token: 0x0601A8F9 RID: 108793 RVA: 0x0071E5AA File Offset: 0x0071C7AA
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

	// Token: 0x0601A8FA RID: 108794 RVA: 0x0071E5C1 File Offset: 0x0071C7C1
	private void SwimStrengthTagChanged(int count, int tagId, int exactTagId, int oldCount)
	{
		this.RefreshSwimBuff();
	}

	// Token: 0x0601A8FB RID: 108795 RVA: 0x0071E5CC File Offset: 0x0071C7CC
	private void ReceiveSwimEvent(float deltaTime)
	{
		double num = (double)((-(double)MathUtils.Instance.Clamp(this.MoveComp.Speed / 75f, 0f, 1f) + 1f) * 10000f + 1f) * 0.01;
		float angleOffsetFromCurrentToInputAbs = GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.ActorComp);
		float accelerator = this.SwimAcceleratorCurve.GetFloatValue(angleOffsetFromCurrentToInputAbs) * 200f;
		this.RotateSpeed = this.SwimRotationCurve.GetFloatValue(angleOffsetFromCurrentToInputAbs);
		double num2 = (this.SwimState == ESwimState.Other) ? 0.0 : 1.4;
		this.MoveComp.CharacterMovement.KuroSwimming(deltaTime, true, this.Depth, (float)num2, (float)num, this.MaxSpeed, this.WaterSlope, accelerator, 0.06f);
	}

	// Token: 0x1700248C RID: 9356
	// (get) Token: 0x0601A8FC RID: 108796 RVA: 0x0071E69F File Offset: 0x0071C89F
	// (set) Token: 0x0601A8FD RID: 108797 RVA: 0x0071E6A7 File Offset: 0x0071C8A7
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

	// Token: 0x1700248D RID: 9357
	// (get) Token: 0x0601A8FE RID: 108798 RVA: 0x0071E6D6 File Offset: 0x0071C8D6
	// (set) Token: 0x0601A8FF RID: 108799 RVA: 0x0071E6E0 File Offset: 0x0071C8E0
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

	// Token: 0x0601A900 RID: 108800 RVA: 0x0071E717 File Offset: 0x0071C917
	[NullableContext(1)]
	private void StateInheritHandle(Entity oldEntity, bool notInheritMoveAndAnim)
	{
		this.LastTickLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
	}

	// Token: 0x0601A901 RID: 108801 RVA: 0x0071E730 File Offset: 0x0071C930
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

	// Token: 0x0601A902 RID: 108802 RVA: 0x0071E894 File Offset: 0x0071CA94
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

	// Token: 0x0601A903 RID: 108803 RVA: 0x0071EA6C File Offset: 0x0071CC6C
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

	// Token: 0x0601A904 RID: 108804 RVA: 0x0071EB24 File Offset: 0x0071CD24
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

	// Token: 0x0601A905 RID: 108805 RVA: 0x0071ED7C File Offset: 0x0071CF7C
	private bool InSwimArea()
	{
		return this.InSwimAreaInternal;
	}

	// Token: 0x0601A906 RID: 108806 RVA: 0x0071ED84 File Offset: 0x0071CF84
	private void RemoveTraceElements()
	{
		if (this.WaterTrace != null)
		{
			this.WaterTrace.Dispose();
			this.WaterTrace = null;
		}
	}

	// Token: 0x0601A907 RID: 108807 RVA: 0x0071EDA0 File Offset: 0x0071CFA0
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

	// Token: 0x0601A908 RID: 108808 RVA: 0x0071F213 File Offset: 0x0071D413
	public void ScoreUpdate()
	{
		if (!base.Active || this.ActorComp == null)
		{
			return;
		}
		global::Vector.VectorCopy(this.ActorComp.ActorLocationProxy, this.TempPlayerLocation);
		this.SimpleCheckInWater();
	}

	// Token: 0x0601A909 RID: 108809 RVA: 0x0071F244 File Offset: 0x0071D444
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

	// Token: 0x0601A90A RID: 108810 RVA: 0x0071F344 File Offset: 0x0071D544
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

	// Token: 0x0601A90B RID: 108811 RVA: 0x0071F51C File Offset: 0x0071D71C
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

	// Token: 0x0601A90C RID: 108812 RVA: 0x0071F580 File Offset: 0x0071D780
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

	// Token: 0x0601A90D RID: 108813 RVA: 0x0071F66C File Offset: 0x0071D86C
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

	// Token: 0x0601A90E RID: 108814 RVA: 0x0071F6E8 File Offset: 0x0071D8E8
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

	// Token: 0x0601A90F RID: 108815 RVA: 0x0071F758 File Offset: 0x0071D958
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

	// Token: 0x0601A910 RID: 108816 RVA: 0x0071F7DC File Offset: 0x0071D9DC
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

	// Token: 0x0601A911 RID: 108817 RVA: 0x0071F8EC File Offset: 0x0071DAEC
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

	// Token: 0x0601A912 RID: 108818 RVA: 0x0071FAA0 File Offset: 0x0071DCA0
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

	// Token: 0x0601A913 RID: 108819 RVA: 0x0071FB18 File Offset: 0x0071DD18
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

	// Token: 0x0601A914 RID: 108820 RVA: 0x0071FBF8 File Offset: 0x0071DDF8
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

	// Token: 0x0601A915 RID: 108821 RVA: 0x0071FC80 File Offset: 0x0071DE80
	private void CheckHitWaterType()
	{
		TArray<TWeakObjectPtr<UPhysicalMaterial>> physMaterials = this.WaterTrace.HitResult.PhysMaterials;
		int hitCount = this.WaterTrace.HitResult.GetHitCount();
		int i = 0;
		while (i < hitCount)
		{
			TWeakObjectPtr<UPrimitiveComponent> weak = this.WaterTrace.HitResult.Components.Get(i);
			UPhysicalMaterial uphysicalMaterial = UKuroCollisionLibrary.GetBodyInstance(this.WaterTrace.HitResult, i).PhysMaterialOverride;
			if (uphysicalMaterial == null)
			{
				uphysicalMaterial = UKuroRenderingRuntimeBPPluginBPLibrary.GetComponentPhysicalMaterial(weak);
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

	// Token: 0x0601A916 RID: 108822 RVA: 0x0071FD48 File Offset: 0x0071DF48
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

	// Token: 0x0601A917 RID: 108823 RVA: 0x0071FED0 File Offset: 0x0071E0D0
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

	// Token: 0x0601A918 RID: 108824 RVA: 0x0071FFE0 File Offset: 0x0071E1E0
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

	// Token: 0x0601A919 RID: 108825 RVA: 0x00720204 File Offset: 0x0071E404
	[NullableContext(1)]
	private void FixNormal(global::Vector inVector)
	{
		double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, inVector);
		if (znInGravityForActor < 0.0)
		{
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, inVector, -znInGravityForActor * 2.0);
		}
	}

	// Token: 0x0601A91A RID: 108826 RVA: 0x0072024C File Offset: 0x0071E44C
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

	// Token: 0x0601A91B RID: 108827 RVA: 0x007202D0 File Offset: 0x0071E4D0
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

	// Token: 0x0601A91C RID: 108828 RVA: 0x00720450 File Offset: 0x0071E650
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

	// Token: 0x0601A91D RID: 108829 RVA: 0x0072052C File Offset: 0x0071E72C
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

	// Token: 0x0601A91E RID: 108830 RVA: 0x00720628 File Offset: 0x0071E828
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

	// Token: 0x0601A91F RID: 108831 RVA: 0x00720738 File Offset: 0x0071E938
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

	// Token: 0x0601A920 RID: 108832 RVA: 0x00720784 File Offset: 0x0071E984
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

	// Token: 0x0601A921 RID: 108833 RVA: 0x00720874 File Offset: 0x0071EA74
	private void CheckCustomMovementIsSwim(float deltaTime)
	{
		if (this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom && this.MoveComp.CharacterMovement.CustomMovementMode == 1)
		{
			this.SprintSwimOffset = (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]) ? (this.SwimConfigInternal.Value.SprintZOffsetRate * this.ActorComp.Radius) : 0f);
			this.MoveComp.FallingIntoWater = false;
		}
	}

	// Token: 0x0601A922 RID: 108834 RVA: 0x00720907 File Offset: 0x0071EB07
	[NullableContext(1)]
	private bool IsNormalAccepted(global::Vector normal)
	{
		return MathUtils.Instance.DotProduct(normal, this.MoveComp.GravityUp) > 0.173;
	}

	// Token: 0x0601A923 RID: 108835 RVA: 0x0072092A File Offset: 0x0071EB2A
	private void LeaveSwim()
	{
		this.BuffIndex = 0L;
		this.SprintSwimOffset = 0f;
	}

	// Token: 0x0601A924 RID: 108836 RVA: 0x00720940 File Offset: 0x0071EB40
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

	// Token: 0x0601A925 RID: 108837 RVA: 0x00720B9D File Offset: 0x0071ED9D
	public bool CheckCanEnterClimbFromSwim()
	{
		return !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]) || (double)this.Depth <= 0.8;
	}

	// Token: 0x0601A926 RID: 108838 RVA: 0x00720BD4 File Offset: 0x0071EDD4
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

	// Token: 0x0601A927 RID: 108839 RVA: 0x00720C5C File Offset: 0x0071EE5C
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

	// Token: 0x0601A928 RID: 108840 RVA: 0x00720CDC File Offset: 0x0071EEDC
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

	// Token: 0x0601A929 RID: 108841 RVA: 0x00720D60 File Offset: 0x0071EF60
	public FVectorDouble GetWaterLocation()
	{
		return this.TempWaterImpactPoint.ToUeVector(false);
	}

	// Token: 0x0601A92A RID: 108842 RVA: 0x00720D6E File Offset: 0x0071EF6E
	public FVectorDouble GetSwimLocation()
	{
		return this.TempSwimImpactPoint.ToUeVector(false);
	}

	// Token: 0x0601A92B RID: 108843 RVA: 0x00720D7C File Offset: 0x0071EF7C
	public bool GetWaterVolume()
	{
		return this.WaterVolume;
	}

	// Token: 0x0601A92C RID: 108844 RVA: 0x00720D84 File Offset: 0x0071EF84
	public void SetEnterWaterState(bool isEnter)
	{
		this.SwimState = (isEnter ? ESwimState.Other : ESwimState.Swim);
	}

	// Token: 0x0601A92D RID: 108845 RVA: 0x00720D94 File Offset: 0x0071EF94
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

	// Token: 0x0601A92E RID: 108846 RVA: 0x00720E74 File Offset: 0x0071F074
	private void DrawDebugCapsuleComponent(FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugCapsule(this.ActorComp.Actor, this.ActorComp.Actor.D_K2_GetActorLocation(), this.ActorComp.Actor.CapsuleComponent.CapsuleHalfHeight, this.ActorComp.Actor.CapsuleComponent.CapsuleRadius, this.ActorComp.Actor.K2_GetActorRotation(), new FLinearColor?(color), 5f, 2f);
	}

	// Token: 0x0601A92F RID: 108847 RVA: 0x00720EEB File Offset: 0x0071F0EB
	private void DrawDebugSphere(FVector location, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(this.ActorComp.Actor, location, this.ActorComp.Actor.CapsuleComponent.CapsuleHalfHeight, 12, new FLinearColor?(color), 0f, 1f);
	}

	// Token: 0x0601A930 RID: 108848 RVA: 0x00720F2B File Offset: 0x0071F12B
	public void SetDebug(bool debug)
	{
		this.IsDebug = debug;
		this.WaterTrace.SetDrawDebugTrace(this.IsDebug ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
	}

	// Token: 0x0601A931 RID: 108849 RVA: 0x00720F4B File Offset: 0x0071F14B
	public void LogSwimTriggerCount()
	{
		bool isDebug = this.IsDebug;
	}

	// Token: 0x0601A932 RID: 108850 RVA: 0x00720F54 File Offset: 0x0071F154
	public static void CreateStaticDefaultValue()
	{
		CharacterSwimComponent.UseSwimTrigger = false;
	}

	// Token: 0x0601A933 RID: 108851 RVA: 0x00720F5C File Offset: 0x0071F15C
	public static void ResetStaticDefaultValue()
	{
		CharacterSwimComponent.UseSwimTrigger = false;
	}

	// Token: 0x0601A934 RID: 108852 RVA: 0x00720F64 File Offset: 0x0071F164
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSwimComponent characterSwimComponent = (CharacterSwimComponent)componentTemplate;
		if (base.CanResetComponentProperty("IsDebug"))
		{
			this.IsDebug = characterSwimComponent.IsDebug;
		}
		if (base.CanResetComponentProperty("TempPlayerLocation"))
		{
			if (characterSwimComponent.TempPlayerLocation == null)
			{
				this.TempPlayerLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempPlayerLocation), "TempPlayerLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempPlayerGravityUp"))
		{
			if (characterSwimComponent.TempPlayerGravityUp == null)
			{
				this.TempPlayerGravityUp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempPlayerGravityUp), "TempPlayerGravityUp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CharacterHalfHeight"))
		{
			this.CharacterHalfHeight = characterSwimComponent.CharacterHalfHeight;
		}
		if (base.CanResetComponentProperty("LastTickLocation"))
		{
			if (characterSwimComponent.LastTickLocation == null)
			{
				this.LastTickLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastTickLocation), "LastTickLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasFloor"))
		{
			this.HasFloor = characterSwimComponent.HasFloor;
		}
		if (base.CanResetComponentProperty("Depth"))
		{
			this.Depth = characterSwimComponent.Depth;
		}
		if (base.CanResetComponentProperty("RotateSpeed"))
		{
			this.RotateSpeed = characterSwimComponent.RotateSpeed;
		}
		if (base.CanResetComponentProperty("SwimAcceleratorCurve"))
		{
			if (characterSwimComponent.SwimAcceleratorCurve == null)
			{
				this.SwimAcceleratorCurve = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCurveFloat>(this.SwimAcceleratorCurve), "SwimAcceleratorCurve"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SwimRotationCurve"))
		{
			if (characterSwimComponent.SwimRotationCurve == null)
			{
				this.SwimRotationCurve = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCurveFloat>(this.SwimRotationCurve), "SwimRotationCurve"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempWaterImpactPoint"))
		{
			if (characterSwimComponent.TempWaterImpactPoint == null)
			{
				this.TempWaterImpactPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempWaterImpactPoint), "TempWaterImpactPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempSwimImpactPoint"))
		{
			if (characterSwimComponent.TempSwimImpactPoint == null)
			{
				this.TempSwimImpactPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempSwimImpactPoint), "TempSwimImpactPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempSwimNormalPoint"))
		{
			if (characterSwimComponent.TempSwimNormalPoint == null)
			{
				this.TempSwimNormalPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempSwimNormalPoint), "TempSwimNormalPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SwimTime"))
		{
			this.SwimTime = characterSwimComponent.SwimTime;
		}
		if (base.CanResetComponentProperty("WaterVolume"))
		{
			this.WaterVolume = characterSwimComponent.WaterVolume;
		}
		if (base.CanResetComponentProperty("WaterSlope"))
		{
			this.WaterSlope = characterSwimComponent.WaterSlope;
		}
		if (base.CanResetComponentProperty("MaxSpeed"))
		{
			this.MaxSpeed = characterSwimComponent.MaxSpeed;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterSwimComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterSwimComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComp"))
		{
			if (characterSwimComponent.UnifiedStateComp == null)
			{
				this.UnifiedStateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComp), "UnifiedStateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterSwimComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterSwimComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ClimbComp"))
		{
			if (characterSwimComponent.ClimbComp == null)
			{
				this.ClimbComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterClimbComponent>(this.ClimbComp), "ClimbComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterSwimComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector"))
		{
			if (characterSwimComponent.TempVector == null)
			{
				this.TempVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector2"))
		{
			if (characterSwimComponent.TempVector2 == null)
			{
				this.TempVector2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector2), "TempVector2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector3"))
		{
			if (characterSwimComponent.TempVector3 == null)
			{
				this.TempVector3 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector3), "TempVector3"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempStartPoint"))
		{
			if (characterSwimComponent.TempStartPoint == null)
			{
				this.TempStartPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempStartPoint), "TempStartPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempEndPoint"))
		{
			if (characterSwimComponent.TempEndPoint == null)
			{
				this.TempEndPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempEndPoint), "TempEndPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SwimConfigInternal"))
		{
			this.SwimConfigInternal = characterSwimComponent.SwimConfigInternal;
		}
		if (base.CanResetComponentProperty("SprintSwimOffset"))
		{
			this.SprintSwimOffset = characterSwimComponent.SprintSwimOffset;
		}
		if (base.CanResetComponentProperty("SprintSwimOffsetLerpSpeed"))
		{
			this.SprintSwimOffsetLerpSpeed = characterSwimComponent.SprintSwimOffsetLerpSpeed;
		}
		if (base.CanResetComponentProperty("DeltaTime"))
		{
			this.DeltaTime = characterSwimComponent.DeltaTime;
		}
		if (base.CanResetComponentProperty("DetectFallIntoWaterPosition"))
		{
			if (characterSwimComponent.DetectFallIntoWaterPosition == null)
			{
				this.DetectFallIntoWaterPosition = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.DetectFallIntoWaterPosition), "DetectFallIntoWaterPosition"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffIndexInternal"))
		{
			this.BuffIndexInternal = characterSwimComponent.BuffIndexInternal;
		}
		if (base.CanResetComponentProperty("EnterSwimFromAirBuffIndex"))
		{
			this.EnterSwimFromAirBuffIndex = characterSwimComponent.EnterSwimFromAirBuffIndex;
		}
		if (base.CanResetComponentProperty("IsFastSwim"))
		{
			this.IsFastSwim = characterSwimComponent.IsFastSwim;
		}
		if (base.CanResetComponentProperty("SwimState"))
		{
			this.SwimState = characterSwimComponent.SwimState;
		}
		if (base.CanResetComponentProperty("LastEnterWaterTime"))
		{
			this.LastEnterWaterTime = characterSwimComponent.LastEnterWaterTime;
		}
		if (base.CanResetComponentProperty("WaterTrace"))
		{
			if (characterSwimComponent.WaterTrace == null)
			{
				this.WaterTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.WaterTrace), "WaterTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InSwimTriggerCount"))
		{
			this.InSwimTriggerCount = characterSwimComponent.InSwimTriggerCount;
		}
		if (base.CanResetComponentProperty("IsRole"))
		{
			this.IsRole = characterSwimComponent.IsRole;
		}
		if (base.CanResetComponentProperty("SwimAreaHeightAboveActor"))
		{
			this.SwimAreaHeightAboveActor = characterSwimComponent.SwimAreaHeightAboveActor;
		}
		if (base.CanResetComponentProperty("InSwimAreaInternal"))
		{
			this.InSwimAreaInternal = characterSwimComponent.InSwimAreaInternal;
		}
		if (base.CanResetComponentProperty("WaterHeightAboveMe"))
		{
			this.WaterHeightAboveMe = characterSwimComponent.WaterHeightAboveMe;
		}
		if (base.CanResetComponentProperty("ForceCheck"))
		{
			this.ForceCheck = characterSwimComponent.ForceCheck;
		}
		if (base.CanResetComponentProperty("WaterTypeInternal"))
		{
			this.WaterTypeInternal = characterSwimComponent.WaterTypeInternal;
		}
		return true;
	}

	// Token: 0x0400CC2E RID: 52270
	[Nullable(1)]
	private const string PROFILE_DETECT_WATER_DEPTH = "CharacterSwimComponent_DetectWaterDepth";

	// Token: 0x0400CC2F RID: 52271
	[Nullable(1)]
	private const string PROFILE_FLOOR = "CharacterSwimComponent_CheckHasArrivedFloorInSwimming";

	// Token: 0x0400CC30 RID: 52272
	private const long MAX_LAST_TICK_OFFSET_SQUARE = 100000000L;

	// Token: 0x0400CC31 RID: 52273
	private const int MAX_SPEED_INTO_WATER = 50;

	// Token: 0x0400CC32 RID: 52274
	private const double ENTER_SWIM_BIGGER_THAN_THIS = 0.75;

	// Token: 0x0400CC33 RID: 52275
	public const double LEAVE_SWIM_LESS_THAN_THIS = 0.7;

	// Token: 0x0400CC34 RID: 52276
	public const double LEAVE_SWIM_LESS_THAN_THIS_AIR = 0.6;

	// Token: 0x0400CC35 RID: 52277
	private const double CLIMB_CHECK_ENTER_WATER_RATE = 0.8;

	// Token: 0x0400CC36 RID: 52278
	private const int ONE_HUNDRED_TO_FIND_SURFACE = 100;

	// Token: 0x0400CC37 RID: 52279
	private const int FIVE_HUNDRED_TO_FIND_SURFACE = 500;

	// Token: 0x0400CC38 RID: 52280
	private const int TIME_CLEAR_ENTER_WATER = 500;

	// Token: 0x0400CC39 RID: 52281
	public const double SWIMMING_BUOYANCY = 1.4;

	// Token: 0x0400CC3A RID: 52282
	private const double SWIMMING_FRICTION = 0.01;

	// Token: 0x0400CC3B RID: 52283
	private const int SWIMMING_FRICTION_MIN_SPEED = 75;

	// Token: 0x0400CC3C RID: 52284
	private const int SWIMMING_FRICTION_RATION = 10000;

	// Token: 0x0400CC3D RID: 52285
	private const int SWIMMING_MAX_DEPTH = 2;

	// Token: 0x0400CC3E RID: 52286
	private const int SWIMMING_ACCELERATOR = 200;

	// Token: 0x0400CC3F RID: 52287
	public const float SWIMMING_DECELERATION = 0.06f;

	// Token: 0x0400CC40 RID: 52288
	private const double COS_EIGHTY = 0.173;

	// Token: 0x0400CC41 RID: 52289
	private const double MIN_DEPTH = -1.7976931348623157E+308;

	// Token: 0x0400CC42 RID: 52290
	private static readonly FVectorDouble waterAreaDetectExtent = new FVectorDouble(500.0, 500.0, 10000.0);

	// Token: 0x0400CC43 RID: 52291
	private const int WATER_BOTTOM_TOLERANCE = 50;

	// Token: 0x0400CC44 RID: 52292
	private const int VEHICLE_ADDITIONAL_HEIGHT = 600;

	// Token: 0x0400CC45 RID: 52293
	private const int VEHICLE_ADDITIONAL_DEPTH = 250;

	// Token: 0x0400CC46 RID: 52294
	public bool IsDebug;

	// Token: 0x0400CC47 RID: 52295
	private static readonly FName TagWaterNoSwim = new FName("Water_No_Swim");

	// Token: 0x0400CC48 RID: 52296
	public static bool UseSwimTrigger = false;

	// Token: 0x0400CC49 RID: 52297
	private global::Vector TempPlayerLocation;

	// Token: 0x0400CC4A RID: 52298
	private global::Vector TempPlayerGravityUp;

	// Token: 0x0400CC4B RID: 52299
	private float CharacterHalfHeight;

	// Token: 0x0400CC4C RID: 52300
	private global::Vector LastTickLocation;

	// Token: 0x0400CC4D RID: 52301
	private ECheckFloorResult HasFloor;

	// Token: 0x0400CC4E RID: 52302
	public float Depth;

	// Token: 0x0400CC4F RID: 52303
	public float RotateSpeed;

	// Token: 0x0400CC50 RID: 52304
	public UCurveFloat SwimAcceleratorCurve;

	// Token: 0x0400CC51 RID: 52305
	public UCurveFloat SwimRotationCurve;

	// Token: 0x0400CC52 RID: 52306
	private global::Vector TempWaterImpactPoint;

	// Token: 0x0400CC53 RID: 52307
	private global::Vector TempSwimImpactPoint;

	// Token: 0x0400CC54 RID: 52308
	private global::Vector TempSwimNormalPoint;

	// Token: 0x0400CC55 RID: 52309
	private float SwimTime;

	// Token: 0x0400CC56 RID: 52310
	private bool WaterVolume;

	// Token: 0x0400CC57 RID: 52311
	public float WaterSlope;

	// Token: 0x0400CC58 RID: 52312
	public float MaxSpeed;

	// Token: 0x0400CC59 RID: 52313
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CC5A RID: 52314
	private BaseTagComponent TagComp;

	// Token: 0x0400CC5B RID: 52315
	private CharacterUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400CC5C RID: 52316
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CC5D RID: 52317
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400CC5E RID: 52318
	private CharacterClimbComponent ClimbComp;

	// Token: 0x0400CC5F RID: 52319
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CC60 RID: 52320
	private global::Vector TempVector;

	// Token: 0x0400CC61 RID: 52321
	private global::Vector TempVector2;

	// Token: 0x0400CC62 RID: 52322
	private global::Vector TempVector3;

	// Token: 0x0400CC63 RID: 52323
	private global::Vector TempStartPoint;

	// Token: 0x0400CC64 RID: 52324
	private global::Vector TempEndPoint;

	// Token: 0x0400CC65 RID: 52325
	private Swim? SwimConfigInternal;

	// Token: 0x0400CC66 RID: 52326
	public float SprintSwimOffset;

	// Token: 0x0400CC67 RID: 52327
	public float SprintSwimOffsetLerpSpeed;

	// Token: 0x0400CC68 RID: 52328
	private float DeltaTime;

	// Token: 0x0400CC69 RID: 52329
	private global::Vector DetectFallIntoWaterPosition;

	// Token: 0x0400CC6A RID: 52330
	private long BuffIndexInternal;

	// Token: 0x0400CC6B RID: 52331
	protected int EnterSwimFromAirBuffIndex;

	// Token: 0x0400CC6C RID: 52332
	private bool IsFastSwim;

	// Token: 0x0400CC6D RID: 52333
	private ESwimState SwimState = ESwimState.Other;

	// Token: 0x0400CC6E RID: 52334
	private float LastEnterWaterTime;

	// Token: 0x0400CC6F RID: 52335
	private UTraceSphereElement WaterTrace;

	// Token: 0x0400CC70 RID: 52336
	public int InSwimTriggerCount;

	// Token: 0x0400CC71 RID: 52337
	public bool IsRole;

	// Token: 0x0400CC72 RID: 52338
	private float SwimAreaHeightAboveActor;

	// Token: 0x0400CC73 RID: 52339
	private bool InSwimAreaInternal;

	// Token: 0x0400CC74 RID: 52340
	public float WaterHeightAboveMe;

	// Token: 0x0400CC75 RID: 52341
	private bool ForceCheck;

	// Token: 0x0400CC76 RID: 52342
	private EInteractionWaterType WaterTypeInternal;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using UnrealEngine;

// Token: 0x020016E6 RID: 5862
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class AnimController : ControllerBase
{
	// Token: 0x0600A802 RID: 43010 RVA: 0x0025B8E4 File Offset: 0x00259AE4
	protected override bool OnInit()
	{
		Log.Instance.Info(ELogModule.Controller, ELogAuthor.WY, "AnimController.OnInit", default(ReadOnlySpan<ValueTuple<string, object>>));
		FUpdateAnimInfoDelegate updateAnimInfoCsFunction = DelegateUtils.ToManualReleaseDelegate<FUpdateAnimInfoDelegate>(new Action<int>(this.UpdateAnimInfo));
		FUpdateAnimInfoDelegate updateAnimInfoCsFunction2 = DelegateUtils.ToManualReleaseDelegate<FUpdateAnimInfoDelegate>(new Action<int>(this.UpdateMonsterAnimInfo));
		FUpdateAnimInfoDelegate updateAnimInfoCsFunction3 = DelegateUtils.ToManualReleaseDelegate<FUpdateAnimInfoDelegate>(new Action<int>(this.UpdateNpcAnimInfo));
		UKuroAnimJsSubsystemProxy.RegisterUpdateAnimInfoCsFunction(GlobalData.GameInstance, updateAnimInfoCsFunction);
		UKuroAnimJsSubsystemProxy.RegisterUpdateMonsterInfoCsFunction(GlobalData.GameInstance, updateAnimInfoCsFunction2);
		UKuroAnimJsSubsystemProxy.RegisterUpdateNpcInfoCsFunction(GlobalData.GameInstance, updateAnimInfoCsFunction3);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "p.KuroHumanIK.CVarExtendClimbTraceRadius 0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.EnableSoftAnimAssetRelease 1", null);
		UeMovementTickController.MovementPredictMode = false;
		return true;
	}

	// Token: 0x0600A803 RID: 43011 RVA: 0x0025B990 File Offset: 0x00259B90
	protected override bool OnClear()
	{
		Log.Instance.Info(ELogModule.Controller, ELogAuthor.WY, "AnimController.OnClear", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKuroAnimJsSubsystemProxy.UnregisterUpdateAnimInfoFunction(GlobalData.GameInstance);
		return true;
	}

	// Token: 0x0600A804 RID: 43012 RVA: 0x0025B9C8 File Offset: 0x00259BC8
	protected override void OnTick(float delta)
	{
		this.DeleteArray.Clear();
		foreach (KeyValuePair<int, SeatMorphRuntimeStruct> keyValuePair in this.SeatMorphRuntimeMap)
		{
			if (keyValuePair.Value.Update(delta))
			{
				this.DeleteArray.Add(keyValuePair.Key);
			}
		}
		foreach (int key in this.DeleteArray)
		{
			this.SeatMorphRuntimeMap.Remove(key);
		}
	}

	// Token: 0x0600A805 RID: 43013 RVA: 0x0025BA88 File Offset: 0x00259C88
	public void SetSeatMorph(Entity seatEntity, int charEntityId, double seatMorphValue)
	{
		SeatMorphRuntimeStruct seatMorphRuntimeStruct;
		if (!this.SeatMorphRuntimeMap.TryGetValue(seatEntity.Id, out seatMorphRuntimeStruct))
		{
			seatMorphRuntimeStruct = new SeatMorphRuntimeStruct(seatEntity, charEntityId);
			this.SeatMorphRuntimeMap.Add(seatEntity.Id, seatMorphRuntimeStruct);
		}
		seatMorphRuntimeStruct.TrySetTargetSeatMorph(charEntityId, seatMorphValue);
	}

	// Token: 0x0600A806 RID: 43014 RVA: 0x0025BACD File Offset: 0x00259CCD
	public void CacheForceDisableAnimOptimization(int pbDataId)
	{
		AnimController.Instance.ForceDisableAnimOptimizationCache.Add(pbDataId);
	}

	// Token: 0x0600A807 RID: 43015 RVA: 0x0025BAE0 File Offset: 0x00259CE0
	public bool ConsumeForceDisableAnimOptimization(int pbDataId)
	{
		return AnimController.Instance.ForceDisableAnimOptimizationCache.Remove(pbDataId);
	}

	// Token: 0x0600A808 RID: 43016 RVA: 0x0025BAF2 File Offset: 0x00259CF2
	public void ClearForceDisableAnimOptimizationCache()
	{
		AnimController.Instance.ForceDisableAnimOptimizationCache.Clear();
	}

	// Token: 0x0600A809 RID: 43017 RVA: 0x0025BB03 File Offset: 0x00259D03
	public void RegisterUpdateAnimInfoEntity(int entityId)
	{
		UKuroAnimJsSubsystemProxy.RegisterEntity(GlobalData.GameInstance, entityId);
	}

	// Token: 0x0600A80A RID: 43018 RVA: 0x0025BB10 File Offset: 0x00259D10
	public void UnregisterUpdateAnimInfoEntity(int entityId)
	{
		UKuroAnimJsSubsystemProxy.UnregisterEntity(GlobalData.GameInstance, entityId);
	}

	// Token: 0x0600A80B RID: 43019 RVA: 0x0025BB1D File Offset: 0x00259D1D
	public void UpdateAnimInfo(int entityId)
	{
		this.UpdateAnimInfoMove(entityId);
		this.UpdateAnimInfoMeshAnim(entityId);
		this.UpdateAnimInfoHit(entityId);
		this.UpdateAnimInfoUnifiedState(entityId);
		this.UpdateAnimInfoSceneInteract(entityId);
		this.UpdateAnimInfoHoldingHands(entityId);
		this.UpdateAnimInfoVehicle(entityId);
	}

	// Token: 0x0600A80C RID: 43020 RVA: 0x0025BB50 File Offset: 0x00259D50
	public void UpdateMonsterAnimInfo(int entityId)
	{
		this.UpdateMonsterAnimInfoHit(entityId);
		this.UpdateMonsterAnimInfoMove(entityId);
		this.UpdateMonsterAnimInfoSkill(entityId);
		this.UpdateMonsterAnimInfoUnifiedState(entityId);
		this.UpdateAnimInfoHoldingHands(entityId);
	}

	// Token: 0x0600A80D RID: 43021 RVA: 0x0025BB75 File Offset: 0x00259D75
	public void UpdateNpcAnimInfo(int entityId)
	{
		this.UpdateNpcAnimInfoMove(entityId);
		this.UpdateNpcAnimInfoUnifiedState(entityId);
	}

	// Token: 0x0600A80E RID: 43022 RVA: 0x0025BB88 File Offset: 0x00259D88
	public void UpdateAnimInfoMove(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component2 != null && component2.Valid)
		{
			Vector inputDirectProxy = component2.InputDirectProxy;
			if (!animLogicParamsSetter.InputDirect.Equals(inputDirectProxy, 9.999999747378752E-05))
			{
				animLogicParamsSetter.InputDirect.DeepCopy(inputDirectProxy);
				logicParams.InputDirectRef = inputDirectProxy.ToUeVectorOld();
			}
			Rotator inputRotatorProxy = component2.InputRotatorProxy;
			if (!animLogicParamsSetter.InputRotator.Equals(inputRotatorProxy, 0.0001f))
			{
				animLogicParamsSetter.InputRotator.DeepCopy(inputRotatorProxy);
				logicParams.InputRotatorRef = inputRotatorProxy.ToUeRotator();
			}
		}
		BaseMoveComponent component3 = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component3 != null && component3.Valid)
		{
			Vector acceleration = component3.Acceleration;
			if (!animLogicParamsSetter.Acceleration.Equals(acceleration, 9.999999747378752E-05))
			{
				animLogicParamsSetter.Acceleration.DeepCopy(acceleration);
				logicParams.AccelerationRef = acceleration.ToUeVectorOld();
			}
			bool isMoving = component3.IsMoving;
			if (animLogicParamsSetter.IsMoving != isMoving)
			{
				animLogicParamsSetter.IsMoving = isMoving;
				logicParams.IsMovingRef = isMoving;
			}
			bool hasMoveInput = component3.HasMoveInput;
			if (animLogicParamsSetter.HasMoveInput != hasMoveInput)
			{
				animLogicParamsSetter.HasMoveInput = hasMoveInput;
				logicParams.HasMoveInputRef = hasMoveInput;
			}
			float speed = component3.Speed;
			if (animLogicParamsSetter.Speed != speed)
			{
				animLogicParamsSetter.Speed = speed;
				logicParams.SpeedRef = speed;
			}
			bool isJump = component3.IsJump;
			if (animLogicParamsSetter.IsJump != isJump)
			{
				animLogicParamsSetter.IsJump = isJump;
				logicParams.IsJumpRef = isJump;
			}
			float groundedTimeUe = component3.GroundedTimeUe;
			if (animLogicParamsSetter.GroundedTime != groundedTimeUe)
			{
				animLogicParamsSetter.GroundedTime = groundedTimeUe;
				logicParams.GroundedTimeRef = groundedTimeUe;
			}
			bool isFallingIntoWater = component3.IsFallingIntoWater;
			if (animLogicParamsSetter.IsFallingIntoWater != isFallingIntoWater)
			{
				animLogicParamsSetter.IsFallingIntoWater = isFallingIntoWater;
				logicParams.IsFallingIntoWaterRef = isFallingIntoWater;
			}
			float jumpUpRate = component3.JumpUpRate;
			if (animLogicParamsSetter.JumpUpRate != jumpUpRate)
			{
				animLogicParamsSetter.JumpUpRate = jumpUpRate;
				logicParams.JumpUpRateRef = jumpUpRate;
			}
			bool forceExitStateStop = component3.ForceExitStateStop;
			if (animLogicParamsSetter.ForceExitStateStop != forceExitStateStop)
			{
				animLogicParamsSetter.ForceExitStateStop = forceExitStateStop;
				logicParams.ForceExitStateStopRef = forceExitStateStop;
			}
		}
		CharacterFloatingComponent component4 = EntitySystem.Instance.GetComponent<CharacterFloatingComponent>(entityId);
		if (component4 != null && component4.Valid)
		{
			Vector floatingLocalDirection = component4.FloatingLocalDirection;
			if (!animLogicParamsSetter.FloatingLocalDirection.Equals(floatingLocalDirection, 9.999999747378752E-05))
			{
				animLogicParamsSetter.FloatingLocalDirection.DeepCopy(floatingLocalDirection);
				logicParams.FloatingLocalDirectionRef = floatingLocalDirection.ToUeVectorOld();
			}
			float floatingMoveMix = component4.FloatingMoveMix;
			if (animLogicParamsSetter.FloatingMoveMix != floatingMoveMix)
			{
				animLogicParamsSetter.FloatingMoveMix = floatingMoveMix;
				logicParams.FloatingMoveMixRef = floatingMoveMix;
			}
		}
		CharacterClimbComponent component5 = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component5 != null && component5.Valid)
		{
			SClimbInfo tsClimbInfo = component5.GetTsClimbInfo();
			if (!animLogicParamsSetter.ClimbInfo.Equals(tsClimbInfo))
			{
				animLogicParamsSetter.ClimbInfo.DeepCopy(tsClimbInfo);
				logicParams.ClimbInfoRef = component5.GetClimbInfoNew();
			}
			SClimbState tsClimbState = component5.GetTsClimbState();
			if (!animLogicParamsSetter.ClimbState.Equals(tsClimbState))
			{
				animLogicParamsSetter.ClimbState.DeepCopy(tsClimbState);
				logicParams.ClimbStateRef = component5.GetClimbStateNew();
			}
			float onWallAngle = component5.GetOnWallAngle();
			if (animLogicParamsSetter.ClimbOnWallAngle != onWallAngle)
			{
				animLogicParamsSetter.ClimbOnWallAngle = onWallAngle;
				logicParams.ClimbOnWallAngleRef = onWallAngle;
			}
		}
		CharacterSwimComponent component6 = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		if (component6 != null && component6.Valid)
		{
			float sprintSwimOffset = component6.SprintSwimOffset;
			if (animLogicParamsSetter.SprintSwimOffset != sprintSwimOffset)
			{
				animLogicParamsSetter.SprintSwimOffset = sprintSwimOffset;
				logicParams.SprintSwimOffsetRef = sprintSwimOffset;
			}
			float sprintSwimOffsetLerpSpeed = component6.SprintSwimOffsetLerpSpeed;
			if (animLogicParamsSetter.SprintSwimOffsetLerpSpeed != sprintSwimOffsetLerpSpeed)
			{
				animLogicParamsSetter.SprintSwimOffsetLerpSpeed = sprintSwimOffsetLerpSpeed;
				logicParams.SprintSwimOffsetLerpSpeedRef = sprintSwimOffsetLerpSpeed;
			}
		}
		CharacterSlideComponent component7 = EntitySystem.Instance.GetComponent<CharacterSlideComponent>(entityId);
		if (component7 != null && component7.Valid)
		{
			Vector slideForward = component7.SlideForward;
			if (!animLogicParamsSetter.SlideForward.Equals(slideForward, 9.999999747378752E-05))
			{
				animLogicParamsSetter.SlideForward.DeepCopy(slideForward);
				logicParams.SlideForwardRef = slideForward.ToUeVectorOld();
			}
			bool slideSwitchThisFrame = component7.SlideSwitchThisFrame;
			if (animLogicParamsSetter.SlideSwitchThisFrame != slideSwitchThisFrame)
			{
				animLogicParamsSetter.SlideSwitchThisFrame = slideSwitchThisFrame;
				logicParams.SlideSwitchThisFrameRef = slideSwitchThisFrame;
			}
			bool standMode = component7.StandMode;
			if (animLogicParamsSetter.SlideStandMode != standMode)
			{
				animLogicParamsSetter.SlideStandMode = standMode;
				logicParams.SlideStandModeRef = standMode;
			}
		}
		CharacterSplineMoveComponent component8 = EntitySystem.Instance.GetComponent<CharacterSplineMoveComponent>(entityId);
		if (component8 != null && component8.Valid)
		{
			bool active = component8.Active;
			if (animLogicParamsSetter.IsInSplineMove != active)
			{
				animLogicParamsSetter.IsInSplineMove = active;
				logicParams.bIsInSplineMove = active;
			}
		}
		RoleSceneInteractComponent component9 = EntitySystem.Instance.GetComponent<RoleSceneInteractComponent>(entityId);
		if (component9 != null && component9.Valid)
		{
			Vector currentTargetLocation = component9.GetCurrentTargetLocation();
			if (!animLogicParamsSetter.HookTargetLocation.Equals(currentTargetLocation, 9.999999747378752E-05))
			{
				animLogicParamsSetter.HookTargetLocation.DeepCopy(currentTargetLocation);
				logicParams.HookTargetLocation = currentTargetLocation.ToUeVectorOld();
			}
		}
		CharacterRailSlideComponent component10 = EntitySystem.Instance.GetComponent<CharacterRailSlideComponent>(entityId);
		if (component10 != null && component10.Valid)
		{
			bool flag = component10.IsRailSlideState();
			if (animLogicParamsSetter.IsRailSlideMove != flag)
			{
				animLogicParamsSetter.IsRailSlideMove = flag;
				logicParams.bIsRailSlideMove = flag;
			}
			bool flag2 = component10.IsRailSlideAirState();
			if (animLogicParamsSetter.IsAirRailSlideMove != flag2)
			{
				animLogicParamsSetter.IsAirRailSlideMove = flag2;
				logicParams.bIsAirRailSlideMove = flag2;
			}
			ERailSlideJumpType railSlideAirType = component10.GetRailSlideAirType();
			if (animLogicParamsSetter.RailSlideJumpType != railSlideAirType)
			{
				animLogicParamsSetter.RailSlideJumpType = railSlideAirType;
				logicParams.RailSlideJumpType = railSlideAirType;
			}
			ERailSlideAnimType railSlideAnimType = component10.GetRailSlideAnimType();
			if (animLogicParamsSetter.RailSlideAnimType != railSlideAnimType)
			{
				animLogicParamsSetter.RailSlideAnimType = railSlideAnimType;
				logicParams.RailSlideAnimType = railSlideAnimType;
			}
			bool flag3 = component10.IsRailSlideLandAnim();
			if (animLogicParamsSetter.UseLandAnimation != flag3)
			{
				animLogicParamsSetter.UseLandAnimation = flag3;
				logicParams.bUseLandAnimation = flag3;
			}
		}
	}

	// Token: 0x0600A80F RID: 43023 RVA: 0x0025C148 File Offset: 0x0025A348
	public void UpdateAnimInfoMeshAnim(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		float battleIdleEndTime = component.BattleIdleEndTime;
		if (animLogicParamsSetter.BattleIdleTime != battleIdleEndTime)
		{
			animLogicParamsSetter.BattleIdleTime = battleIdleEndTime;
			logicParams.BattleIdleTimeRef = battleIdleEndTime;
		}
		float degMovementSlope = component.DegMovementSlope;
		if (animLogicParamsSetter.DegMovementSlope != degMovementSlope)
		{
			animLogicParamsSetter.DegMovementSlope = degMovementSlope;
			logicParams.DegMovementSlopeRef = degMovementSlope;
		}
		bool flag;
		Vector sightDirectForLogicParams = component.GetSightDirectForLogicParams(out flag);
		if (flag || !animLogicParamsSetter.SightDirect.Equals(sightDirectForLogicParams, 9.999999747378752E-05))
		{
			animLogicParamsSetter.SightDirect.DeepCopy(sightDirectForLogicParams);
			logicParams.SightDirectRef = sightDirectForLogicParams.ToUeVectorOld();
		}
		bool disableBlink = component.DisableBlink;
		if (animLogicParamsSetter.DisableBlink != disableBlink)
		{
			animLogicParamsSetter.DisableBlink = disableBlink;
			logicParams.bDisableBlink = disableBlink;
		}
		bool ignoreMontageBlinkCurve = component.IgnoreMontageBlinkCurve;
		if (animLogicParamsSetter.IgnoreMontageBlinkCurve != ignoreMontageBlinkCurve)
		{
			animLogicParamsSetter.IgnoreMontageBlinkCurve = ignoreMontageBlinkCurve;
			logicParams.bIgnoreMontageBlinkCurve = ignoreMontageBlinkCurve;
		}
		CharacterPhysicsAssetComponent component2 = EntitySystem.Instance.GetComponent<CharacterPhysicsAssetComponent>(entityId);
		if (component2 != null)
		{
			bool ragRollQuitState = component2.GetRagRollQuitState();
			if (animLogicParamsSetter.RagQuitState != ragRollQuitState)
			{
				animLogicParamsSetter.RagQuitState = ragRollQuitState;
				logicParams.RagQuitStateRef = ragRollQuitState;
			}
		}
	}

	// Token: 0x0600A810 RID: 43024 RVA: 0x0025C284 File Offset: 0x0025A484
	public void UpdateAnimInfoHit(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterHitComponent component2 = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		bool enterFkAndReset = component2.GetEnterFkAndReset();
		if (animLogicParamsSetter.EnterFk != enterFkAndReset)
		{
			animLogicParamsSetter.EnterFk = enterFkAndReset;
			logicParams.EnterFkRef = enterFkAndReset;
		}
		if (enterFkAndReset)
		{
			logicParams.HitInfo = component2.GetFbHitInfo();
		}
		Vector vector = component2.BeHitDirect;
		if (!animLogicParamsSetter.BeHitDirect.Equals(vector, 9.999999747378752E-05))
		{
			animLogicParamsSetter.BeHitDirect.DeepCopy(vector);
			logicParams.BeHitDirectRef = vector.ToUeVectorOld();
		}
		vector = component2.BeHitLocation;
		if (!animLogicParamsSetter.BeHitLocation.Equals(vector, 9.999999747378752E-05))
		{
			animLogicParamsSetter.BeHitLocation.DeepCopy(vector);
			logicParams.BeHitLocationRef = vector.ToUeVectorOld();
		}
		FName? beHitSocketName = component2.BeHitSocketName;
		if (animLogicParamsSetter.BeHitSocketName != beHitSocketName.Value)
		{
			animLogicParamsSetter.BeHitSocketName = beHitSocketName.Value;
			logicParams.BeHitSocketNameRef = beHitSocketName.Value;
		}
	}

	// Token: 0x0600A811 RID: 43025 RVA: 0x0025C3B4 File Offset: 0x0025A5B4
	public void UpdateAnimInfoUnifiedState(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterUnifiedStateComponent component2 = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		ECharMoveState moveState = component2.MoveState;
		if (animLogicParamsSetter.CharMoveState != moveState)
		{
			animLogicParamsSetter.CharMoveState = moveState;
			logicParams.CharMoveStateRef = (ECharMoveStateType)moveState;
		}
		ECharPositionState positionState = component2.PositionState;
		if (animLogicParamsSetter.CharPositionState != positionState)
		{
			animLogicParamsSetter.CharPositionState = positionState;
			logicParams.CharPositionStateRef = (ECharPositionStateType)positionState;
		}
		ECharDirectionState directionState = component2.DirectionState;
		if (animLogicParamsSetter.CharCameraState != directionState)
		{
			animLogicParamsSetter.CharCameraState = directionState;
			logicParams.CharCameraStateRef = (ECharViewDirectionStateType)directionState;
		}
		CharacterSkillComponent component3 = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component3 != null)
		{
			int skillTarget = animLogicParamsSetter.SkillTarget;
			EntityHandle skillTarget2 = component3.SkillTarget;
			if (skillTarget != ((skillTarget2 != null) ? skillTarget2.Id : 0))
			{
				AnimLogicParamsSetter animLogicParamsSetter2 = animLogicParamsSetter;
				EntityHandle skillTarget3 = component3.SkillTarget;
				animLogicParamsSetter2.SkillTarget = ((skillTarget3 != null) ? skillTarget3.Id : 0);
				UAbpLogicParams uabpLogicParams = logicParams;
				EntityHandle skillTarget4 = component3.SkillTarget;
				AActor skillTarget5;
				if (skillTarget4 == null)
				{
					skillTarget5 = null;
				}
				else
				{
					WorldEntity entity = skillTarget4.Entity;
					if (entity == null)
					{
						skillTarget5 = null;
					}
					else
					{
						BaseActorComponent component4 = entity.GetComponent<BaseActorComponent>();
						skillTarget5 = ((component4 != null) ? component4.Owner : null);
					}
				}
				uabpLogicParams.SkillTarget = skillTarget5;
			}
		}
		float lastActivateSkillTime = component3.LastActivateSkillTime;
		if (animLogicParamsSetter.LastActiveSkillTime != (double)lastActivateSkillTime)
		{
			animLogicParamsSetter.LastActiveSkillTime = (double)lastActivateSkillTime;
			logicParams.LastActiveSkillTime = lastActivateSkillTime;
		}
		BasePerformComponent component5 = EntitySystem.Instance.GetComponent<BasePerformComponent>(entityId);
		BaseActorComponent component6 = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		bool flag = PlotModel.Instance.IsInInteraction || (component5 != null && component5.IsInPlot) || (component6 != null && component6.IsRoleAndCtrlByMe && PlotModel.Instance.PlotConfig.DisableInput);
		if (animLogicParamsSetter.IsInPerformingPlot != flag)
		{
			animLogicParamsSetter.IsInPerformingPlot = flag;
			logicParams.bIsInPerformingPlot = flag;
		}
		bool flag2;
		if (component6 != null && component6.GetSequenceBinding())
		{
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			EPlotLevel eplotLevel = EPlotLevel.LevelA;
			flag2 = ((plotLevel.GetValueOrDefault() == eplotLevel & plotLevel != null) || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelB);
		}
		else
		{
			flag2 = false;
		}
		bool flag3 = flag2;
		if (animLogicParamsSetter.IsInSequence != flag3)
		{
			animLogicParamsSetter.IsInSequence = flag3;
			logicParams.bIsInSequence = flag3;
		}
		TeleportModel instance = TeleportModel.Instance;
		bool flag4;
		if (instance == null || !instance.IsTeleport)
		{
			GameModeModel instance2 = GameModeModel.Instance;
			flag4 = (instance2 != null && instance2.Loading);
		}
		else
		{
			flag4 = true;
		}
		bool flag5 = flag4;
		bool flag6 = UiCameraAnimationManager.Instance.IsDisablePlayer() || flag5;
		if (animLogicParamsSetter.IsInUiCamera != flag6)
		{
			animLogicParamsSetter.IsInUiCamera = flag6;
			logicParams.bIsInUiCamera = flag6;
		}
	}

	// Token: 0x0600A812 RID: 43026 RVA: 0x0025C640 File Offset: 0x0025A840
	public void UpdateAnimInfoSceneInteract(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterActionComponent component2 = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		bool sitDownState = component2.GetSitDownState();
		if (animLogicParamsSetter.SitDown != sitDownState)
		{
			animLogicParamsSetter.SitDown = sitDownState;
			logicParams.bSitDown = sitDownState;
		}
		int sitDownTypeIndex = component2.SitDownTypeIndex;
		if (animLogicParamsSetter.SitDownType != sitDownTypeIndex)
		{
			animLogicParamsSetter.SitDownType = sitDownTypeIndex;
			logicParams.SitDownType = sitDownTypeIndex;
		}
		int enterSitDownIndex = component2.EnterSitDownIndex;
		if (animLogicParamsSetter.SitDownDirect != enterSitDownIndex)
		{
			animLogicParamsSetter.SitDownDirect = enterSitDownIndex;
			logicParams.SitDownDirect = enterSitDownIndex;
		}
		int leaveSitDownIndex = component2.LeaveSitDownIndex;
		if (animLogicParamsSetter.StandUpDirect != leaveSitDownIndex)
		{
			animLogicParamsSetter.StandUpDirect = leaveSitDownIndex;
			logicParams.StandUpDirect = leaveSitDownIndex;
		}
	}

	// Token: 0x0600A813 RID: 43027 RVA: 0x0025C71C File Offset: 0x0025A91C
	public void UpdateAnimInfoVehicle(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterDriveVehicleComponent component2 = EntitySystem.Instance.GetComponent<CharacterDriveVehicleComponent>(entityId);
		if (!component2)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		bool isDriver = component2.IsDriver;
		if (animLogicParamsSetter.IsDriver != isDriver)
		{
			animLogicParamsSetter.IsDriver = isDriver;
			logicParams.IsDriver = isDriver;
		}
		bool isOnVehicle = component2.IsOnVehicle;
		if (animLogicParamsSetter.IsOnVehicle != isOnVehicle)
		{
			animLogicParamsSetter.IsOnVehicle = isOnVehicle;
			logicParams.IsOnVehicle = isOnVehicle;
		}
		bool isOnVehicleWithOther = component2.IsOnVehicleWithOther;
		if (animLogicParamsSetter.IsOnVehicleWithOther != isOnVehicleWithOther)
		{
			animLogicParamsSetter.IsOnVehicleWithOther = isOnVehicleWithOther;
			logicParams.IsOnVehicleWithOther = isOnVehicleWithOther;
		}
		EVehicleTypeInt vehicleTypeInt = component2.VehicleTypeInt;
		if (animLogicParamsSetter.VehicleType != (int)vehicleTypeInt)
		{
			animLogicParamsSetter.VehicleType = (int)vehicleTypeInt;
			logicParams.VehicleType = (int)vehicleTypeInt;
		}
		bool isLeavingVehicle = component2.IsLeavingVehicle;
		if (animLogicParamsSetter.IsLeavingVehicle != isLeavingVehicle)
		{
			animLogicParamsSetter.IsLeavingVehicle = isLeavingVehicle;
			logicParams.IsLeavingVehicle = isLeavingVehicle;
		}
		Entity vehicleEntity = component2.VehicleEntity;
		GongduolaPerformComponent gongduolaPerformComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaPerformComponent>() : null;
		if (gongduolaPerformComponent != null)
		{
			if (animLogicParamsSetter.IsVehicleImpact != gongduolaPerformComponent.IsBeingImpacted)
			{
				animLogicParamsSetter.IsVehicleImpact = gongduolaPerformComponent.IsBeingImpacted;
				logicParams.IsVehicleImpact = gongduolaPerformComponent.IsBeingImpacted;
			}
			if (animLogicParamsSetter.VehicleCollisionAngle != gongduolaPerformComponent.CollisionDirection)
			{
				animLogicParamsSetter.VehicleCollisionAngle = gongduolaPerformComponent.CollisionDirection;
				logicParams.VehicleCollisionAngle = gongduolaPerformComponent.CollisionDirection;
			}
			if (animLogicParamsSetter.VehicleCollisionStrength != gongduolaPerformComponent.CollisionStrength)
			{
				animLogicParamsSetter.VehicleCollisionStrength = gongduolaPerformComponent.CollisionStrength;
				logicParams.VehicleCollisionStrength = gongduolaPerformComponent.CollisionStrength;
			}
		}
		if (component2.SeatReletiveTrans != null)
		{
			float num = -component2.SeatReletiveTrans.GetRotation().Rotator(null).Yaw;
			if (animLogicParamsSetter.YawInPassengerCoordinate != num)
			{
				animLogicParamsSetter.YawInPassengerCoordinate = num;
				logicParams.YawInPassengerCoordinate = num;
			}
		}
		Entity vehicleEntity2 = component2.VehicleEntity;
		if (((vehicleEntity2 != null) ? vehicleEntity2.GetComponent<VehicleActorComponent>() : null) != null)
		{
			Entity vehicleEntity3 = component2.VehicleEntity;
			if (((vehicleEntity3 != null) ? vehicleEntity3.GetComponent<BaseVehiclePerformComponent>() : null) != null)
			{
				Vector commonTempVector = MathUtils.Instance.CommonTempVector;
				commonTempVector.Reset();
				if (gongduolaPerformComponent != null)
				{
					gongduolaPerformComponent.GetVehicleVelocity(commonTempVector);
				}
				if (!animLogicParamsSetter.VehicleVelocity.Equals(commonTempVector, 9.999999747378752E-05))
				{
					animLogicParamsSetter.VehicleVelocity.DeepCopy(commonTempVector);
					logicParams.VehicleVelocity = commonTempVector.ToUeVectorOld();
				}
			}
		}
	}

	// Token: 0x0600A814 RID: 43028 RVA: 0x0025C960 File Offset: 0x0025AB60
	public void UpdateAnimInfoHoldingHands(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		IkTarget ikTarget = null;
		IkTarget ikTarget2 = null;
		FIKTarget fiktarget = null;
		FIKTarget fiktarget2 = null;
		CharacterDriveVehicleComponent component2 = EntitySystem.Instance.GetComponent<CharacterDriveVehicleComponent>(entityId);
		if (component2 != null)
		{
			ValueTuple<IkTarget, IkTarget> handIkTarget = component2.GetHandIkTarget();
			ikTarget2 = handIkTarget.Item1;
			ikTarget = handIkTarget.Item2;
			ValueTuple<FIKTarget, FIKTarget> handIkTargetUe = component2.GetHandIkTargetUe();
			fiktarget2 = handIkTargetUe.Item1;
			fiktarget = handIkTargetUe.Item2;
		}
		CharacterHoldingHandsComponent component3 = EntitySystem.Instance.GetComponent<CharacterHoldingHandsComponent>(entityId);
		if (component3 != null)
		{
			if (ikTarget == null)
			{
				ikTarget = component3.GetHandIkTarget(EHandType.Left);
				fiktarget = component3.GetHandIkTargetUe(EHandType.Left);
			}
			if (ikTarget2 == null)
			{
				ikTarget2 = component3.GetHandIkTarget(EHandType.Right);
				fiktarget2 = component3.GetHandIkTargetUe(EHandType.Right);
			}
		}
		if (!animLogicParamsSetter.LeftHandIkTarget.Equals(ikTarget))
		{
			animLogicParamsSetter.LeftHandIkTarget.DeepCopy(ikTarget);
			FIKTarget fiktarget3 = fiktarget;
			if (fiktarget3 != null)
			{
				logicParams.LeftHandIKTargetCS = fiktarget3;
			}
			else
			{
				logicParams.LeftHandIKTargetCS.Alpha = 0f;
			}
		}
		if (!animLogicParamsSetter.RightHandIkTarget.Equals(ikTarget2))
		{
			animLogicParamsSetter.RightHandIkTarget.DeepCopy(ikTarget2);
			FIKTarget fiktarget4 = fiktarget2;
			if (fiktarget4 != null)
			{
				logicParams.RightHandIKTargetCS = fiktarget4;
				return;
			}
			logicParams.RightHandIKTargetCS.Alpha = 0f;
		}
	}

	// Token: 0x0600A815 RID: 43029 RVA: 0x0025CAB0 File Offset: 0x0025ACB0
	public void UpdateMonsterAnimInfoMove(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component2 != null && component2.Valid)
		{
			Vector inputDirectProxy = component2.InputDirectProxy;
			if (!animLogicParamsSetter.InputDirect.Equals(inputDirectProxy, 9.999999747378752E-05))
			{
				animLogicParamsSetter.InputDirect.DeepCopy(inputDirectProxy);
				logicParams.InputDirectRef = inputDirectProxy.ToUeVectorOld();
			}
		}
		Vector tsSightDirect = component.GetTsSightDirect();
		if (!animLogicParamsSetter.SightDirect.Equals(tsSightDirect, 9.999999747378752E-05))
		{
			animLogicParamsSetter.SightDirect.DeepCopy(tsSightDirect);
			logicParams.SightDirectRef = tsSightDirect.ToUeVectorOld();
		}
	}

	// Token: 0x0600A816 RID: 43030 RVA: 0x0025CB80 File Offset: 0x0025AD80
	public void UpdateMonsterAnimInfoSkill(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterSkillComponent component2 = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component2 != null)
		{
			int skillTarget = animLogicParamsSetter.SkillTarget;
			EntityHandle skillTarget2 = component2.SkillTarget;
			if (skillTarget != ((skillTarget2 != null) ? skillTarget2.Id : 0))
			{
				AnimLogicParamsSetter animLogicParamsSetter2 = animLogicParamsSetter;
				EntityHandle skillTarget3 = component2.SkillTarget;
				animLogicParamsSetter2.SkillTarget = ((skillTarget3 != null) ? skillTarget3.Id : 0);
				UAbpLogicParams uabpLogicParams = logicParams;
				EntityHandle skillTarget4 = component2.SkillTarget;
				AActor skillTarget5;
				if (skillTarget4 == null)
				{
					skillTarget5 = null;
				}
				else
				{
					WorldEntity entity = skillTarget4.Entity;
					if (entity == null)
					{
						skillTarget5 = null;
					}
					else
					{
						BaseActorComponent component3 = entity.GetComponent<BaseActorComponent>();
						skillTarget5 = ((component3 != null) ? component3.Owner : null);
					}
				}
				uabpLogicParams.SkillTarget = skillTarget5;
			}
		}
	}

	// Token: 0x0600A817 RID: 43031 RVA: 0x0025CC34 File Offset: 0x0025AE34
	public void UpdateMonsterAnimInfoHit(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterHitComponent component2 = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		bool enterFkAndReset = component2.GetEnterFkAndReset();
		if (animLogicParamsSetter.EnterFk != enterFkAndReset)
		{
			animLogicParamsSetter.EnterFk = enterFkAndReset;
			logicParams.EnterFkRef = enterFkAndReset;
			logicParams.HitInfo = component2.GetFbHitInfo();
		}
		if (((component2 != null) ? component2.BeHitBones : null) != null && component2 != null)
		{
			FName[] beHitBones = component2.BeHitBones;
			int? num = (beHitBones != null) ? new int?(beHitBones.Length) : null;
			int num2 = 0;
			if ((num.GetValueOrDefault() > num2 & num != null) && animLogicParamsSetter.BeHitBone != component2.BeHitBones[0])
			{
				animLogicParamsSetter.BeHitBone = component2.BeHitBones[0];
				logicParams.BeHitBoneRef = component2.BeHitBones[0];
			}
		}
		if (enterFkAndReset)
		{
			Vector vector = component2.BeHitDirect;
			if (!animLogicParamsSetter.BeHitDirect.Equals(vector, 9.999999747378752E-05))
			{
				animLogicParamsSetter.BeHitDirect.DeepCopy(vector);
				logicParams.BeHitDirectRef = vector.ToUeVectorOld();
			}
			vector = component2.BeHitLocation;
			if (!animLogicParamsSetter.BeHitLocation.Equals(vector, 9.999999747378752E-05))
			{
				animLogicParamsSetter.BeHitLocation.DeepCopy(vector);
				logicParams.BeHitLocationRef = vector.ToUeVectorOld();
			}
		}
		int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(entityId, "HateTarget");
		if (entityIdByEntity != null)
		{
			BaseActorComponent component3 = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityIdByEntity.Value);
			int hateTarget = animLogicParamsSetter.HateTarget;
			int? num = entityIdByEntity;
			if (!(hateTarget == num.GetValueOrDefault() & num != null))
			{
				animLogicParamsSetter.HateTarget = entityIdByEntity.Value;
				logicParams.HateTarget = ((component3 != null) ? component3.Owner : null);
			}
		}
	}

	// Token: 0x0600A818 RID: 43032 RVA: 0x0025CE20 File Offset: 0x0025B020
	public void UpdateMonsterAnimInfoUnifiedState(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		BaseUnifiedStateComponent component2 = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		ECharMoveState moveState = component2.MoveState;
		if (animLogicParamsSetter.CharMoveState != moveState)
		{
			animLogicParamsSetter.CharMoveState = moveState;
			logicParams.CharMoveStateRef = (ECharMoveStateType)moveState;
		}
		ECharPositionState positionState = component2.PositionState;
		if (animLogicParamsSetter.CharPositionState != positionState)
		{
			animLogicParamsSetter.CharPositionState = positionState;
			logicParams.CharPositionStateRef = (ECharPositionStateType)positionState;
		}
		ECharDirectionState directionState = component2.DirectionState;
		if (animLogicParamsSetter.CharCameraState != directionState)
		{
			animLogicParamsSetter.CharCameraState = directionState;
			logicParams.CharCameraStateRef = (ECharViewDirectionStateType)directionState;
		}
	}

	// Token: 0x0600A819 RID: 43033 RVA: 0x0025CEDC File Offset: 0x0025B0DC
	public void UpdateNpcAnimInfoMove(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component2 != null && component2.Valid)
		{
			Vector inputDirectProxy = component2.InputDirectProxy;
			if (!animLogicParamsSetter.InputDirect.Equals(inputDirectProxy, 9.999999747378752E-05))
			{
				animLogicParamsSetter.InputDirect.DeepCopy(inputDirectProxy);
				logicParams.InputDirectRef = inputDirectProxy.ToUeVectorOld();
			}
		}
	}

	// Token: 0x0600A81A RID: 43034 RVA: 0x0025CF70 File Offset: 0x0025B170
	public void UpdateNpcAnimInfoUnifiedState(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		BaseUnifiedStateComponent component2 = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		UAbpLogicParams logicParams = (component.MainAnimInstance as UKuroAnimInstanceChar).LogicParams;
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		ECharMoveState moveState = component2.MoveState;
		if (animLogicParamsSetter.CharMoveState != moveState)
		{
			animLogicParamsSetter.CharMoveState = moveState;
			logicParams.CharMoveStateRef = (ECharMoveStateType)moveState;
		}
		ECharPositionState positionState = component2.PositionState;
		if (animLogicParamsSetter.CharPositionState != positionState)
		{
			animLogicParamsSetter.CharPositionState = positionState;
			logicParams.CharPositionStateRef = (ECharPositionStateType)positionState;
		}
		ECharDirectionState directionState = component2.DirectionState;
		if (animLogicParamsSetter.CharCameraState != directionState)
		{
			animLogicParamsSetter.CharCameraState = directionState;
			logicParams.CharCameraStateRef = (ECharViewDirectionStateType)directionState;
		}
	}

	// Token: 0x17000DED RID: 3565
	// (get) Token: 0x0600A81B RID: 43035 RVA: 0x0025D02C File Offset: 0x0025B22C
	public static AnimController Instance
	{
		get
		{
			return AnimController._Instance;
		}
	}

	// Token: 0x0600A81C RID: 43036 RVA: 0x0025D033 File Offset: 0x0025B233
	public static AnimController GetOrCreateInstance()
	{
		if (AnimController._Instance == null)
		{
			AnimController.CreateInstance();
		}
		return AnimController._Instance;
	}

	// Token: 0x0600A81D RID: 43037 RVA: 0x0025D047 File Offset: 0x0025B247
	public static bool CreateInstance()
	{
		if (AnimController._Instance != null)
		{
			return true;
		}
		AnimController._Instance = new AnimController();
		return true;
	}

	// Token: 0x0600A81E RID: 43038 RVA: 0x0025D05D File Offset: 0x0025B25D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A81F RID: 43039 RVA: 0x0025D05F File Offset: 0x0025B25F
	public static void ResetStaticDefaultValue()
	{
		AnimController._Instance = null;
	}

	// Token: 0x0600A820 RID: 43040 RVA: 0x0025D067 File Offset: 0x0025B267
	static AnimController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnimController.CreateStaticDefaultValue), new Action(AnimController.ResetStaticDefaultValue));
	}

	// Token: 0x04004BB5 RID: 19381
	public HashSet<int> ForceDisableAnimOptimizationCache = new HashSet<int>();

	// Token: 0x04004BB6 RID: 19382
	private Dictionary<int, SeatMorphRuntimeStruct> SeatMorphRuntimeMap = new Dictionary<int, SeatMorphRuntimeStruct>();

	// Token: 0x04004BB7 RID: 19383
	private List<int> DeleteArray = new List<int>();

	// Token: 0x04004BB8 RID: 19384
	[Nullable(2)]
	private static AnimController _Instance;
}

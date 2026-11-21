using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SplineClimb;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063AF RID: 25519
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterSplineClimbComponent : EntityComponent
	{
		// Token: 0x17007595 RID: 30101
		// (get) Token: 0x0603DDE2 RID: 253410 RVA: 0x011F3809 File Offset: 0x011F1A09
		private SplineClimbParams Params
		{
			get
			{
				if (CharacterSplineClimbComponent.CommonParams == null)
				{
					CharacterSplineClimbComponent.CommonParams = CharacterSplineClimbComponent.LoadCommonParams();
				}
				return CharacterSplineClimbComponent.CommonParams;
			}
		}

		// Token: 0x0603DDE3 RID: 253411 RVA: 0x011F3824 File Offset: 0x011F1A24
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
			this.AnimComp = base.Entity.CheckGetComponent<CharacterAnimationComponent>();
			this.TagComp = base.Entity.CheckGetComponent<BaseTagComponent>();
			this.MoveComp = base.Entity.CheckGetComponent<CharacterMoveComponent>();
			this.ClimbComp = base.Entity.GetComponent<CharacterClimbComponent>();
			CharacterAnimationComponent animComp = this.AnimComp;
			this.AnimInstance = (((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceRole);
			return true;
		}

		// Token: 0x0603DDE4 RID: 253412 RVA: 0x011F38A4 File Offset: 0x011F1AA4
		protected override bool OnEnd()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x0603DDE5 RID: 253413 RVA: 0x011F38AD File Offset: 0x011F1AAD
		protected override void OnTick(float delta)
		{
			if (this.StateChangeExit)
			{
				this.ExitSplineClimb("位置状态改变", true, false);
				this.StateChangeExit = false;
			}
		}

		// Token: 0x0603DDE6 RID: 253414 RVA: 0x011F38CC File Offset: 0x011F1ACC
		public unsafe void EnterSplineClimb(USplineComponent splineAsset, Vector traceDirection, Action<bool> callback)
		{
			if (this.InSplineClimb)
			{
				this.ExitSplineClimb("重复进入", false, true);
			}
			this.TraceDirection.DeepCopy(traceDirection);
			this.InitSplineRuntime(splineAsset);
			this.SetInitialLocation();
			this.FastClimbMix = 0f;
			this.SmoothedSpeed = 500f;
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Custom,
					CustomMode = 13,
					Context = "[CharacterSplineClimbComponent.EnterSplineClimb]"
				});
			}
			foreach (int value in this.Params.Tags)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTag(new int?(value));
				}
			}
			this.AddEvents();
			Entity entity = base.Entity;
			BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
			if (baseSkillComponent != null)
			{
				baseSkillComponent.StopAllSkills("开始样条跑墙");
			}
			EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, "[CharacterSplineClimbComponent] 开始样条跑墙");
			this.EndCallback = callback;
			this.InSplineClimb = true;
			if (GlobalData.IsPlayInEditor)
			{
				CharacterSplineClimbComponent.LoadCommonParams();
			}
			if (this.IsFirstPerson())
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					moveComp.SetLockedRotation(false);
				}
			}
			if (this.ClimbComp != null)
			{
				this.DisableClimbHandle = this.ClimbComp.Disable("样条跑墙开始");
			}
			this.TargetLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			SplineRuntime splineRuntime = this.SplineRuntime;
			float splineLength = splineRuntime.SourceSpline.GetSplineLength();
			if (!this.BuildWallSpline(splineRuntime.SourceSpline, splineRuntime.WallSpline, (double)splineRuntime.DistanceInSource, (double)splineLength, this.TraceDirection, this.ActorComp.ActorLocationProxy))
			{
				this.ExitSplineClimb("无法投影", true, true);
				return;
			}
			splineRuntime.DistanceInSource = splineLength;
			splineRuntime.DistanceInWallSpline = 0f;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "开始样条跑墙";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SourceLength", splineLength);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DistanceInSource", splineRuntime.DistanceInSource);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "SourceLengthUe";
			USplineComponent sourceSplineUe = splineRuntime.SourceSplineUe;
			ptr = new ValueTuple<string, object>(item, (sourceSplineUe != null) ? new float?(sourceSplineUe.GetSplineLength()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("WallSplineLength", splineRuntime.WallSpline.GetSplineLength());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("SplineLocation", splineRuntime.SourceSpline.SplineTransform.GetLocation());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("ActorLocation", this.ActorComp.ActorLocationProxy);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
		}

		// Token: 0x0603DDE7 RID: 253415 RVA: 0x011F3BC4 File Offset: 0x011F1DC4
		public unsafe void ExitSplineClimb(string reason, bool tryChangeState = true, bool jumpExit = true)
		{
			this.RemoveEvents();
			if (this.ClimbComp != null)
			{
				this.ClimbComp.Enable(new int?(this.DisableClimbHandle), "样条跑墙结束");
				this.DisableClimbHandle = 0;
			}
			ECharPositionState positionState = base.Entity.GetComponent<CharacterUnifiedStateComponent>().PositionState;
			bool flag = !jumpExit || this.IsFirstPerson() || this.ClimbComp == null;
			bool flag2 = tryChangeState && flag && (positionState == ECharPositionState.Air || positionState == ECharPositionState.Climb);
			bool flag3 = tryChangeState && positionState == ECharPositionState.Climb;
			if (flag2)
			{
				this.FixCharacterExitRotation();
			}
			if (flag3)
			{
				this.OnExitSplineClimbState(flag || this.ClimbComp == null);
			}
			foreach (int value in this.Params.Tags)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.RemoveTag(new int?(value));
				}
			}
			this.InSplineClimb = false;
			this.StateChangeExit = false;
			if (this.IsFirstPerson())
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					moveComp.SetLockedRotation(true);
				}
			}
			Action<bool> endCallback = this.EndCallback;
			if (endCallback != null)
			{
				endCallback(true);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "退出样条跑墙";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "DistanceInSource";
			SplineRuntime splineRuntime = this.SplineRuntime;
			ptr = new ValueTuple<string, object>(item, (splineRuntime != null) ? new float?(splineRuntime.DistanceInSource) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item2 = "WallSplineLength";
			SplineRuntime splineRuntime2 = this.SplineRuntime;
			float? num;
			if (splineRuntime2 == null)
			{
				num = null;
			}
			else
			{
				SplineCurve wallSpline = splineRuntime2.WallSpline;
				num = ((wallSpline != null) ? new float?(wallSpline.GetSplineLength()) : null);
			}
			ptr2 = new ValueTuple<string, object>(item2, num);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item3 = "DistanceOnWall";
			SplineRuntime splineRuntime3 = this.SplineRuntime;
			ptr3 = new ValueTuple<string, object>(item3, (splineRuntime3 != null) ? new float?(splineRuntime3.DistanceInWallSpline) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("bChangeState", flag3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("bToFall", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("hasClimbComp", this.ClimbComp != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x0603DDE8 RID: 253416 RVA: 0x011F3E64 File Offset: 0x011F2064
		private void OnExitSplineClimbState(bool falling)
		{
			if (falling)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp == null)
				{
					return;
				}
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Falling,
					Context = "[CharacterSplineClimbComponent.OnExitClimb] Falling"
				});
				return;
			}
			else
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 != null)
				{
					actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Custom,
						CustomMode = 0,
						Context = "[CharacterSplineClimbComponent.ExitSplineClimb]"
					});
				}
				CharacterClimbComponent climbComp = this.ClimbComp;
				if (climbComp == null)
				{
					return;
				}
				climbComp.KickWallExit();
				return;
			}
		}

		// Token: 0x0603DDE9 RID: 253417 RVA: 0x011F3EE8 File Offset: 0x011F20E8
		private void FixCharacterExitRotation()
		{
			if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy) > 0.0)
			{
				this.TempVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
				GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TempVector);
				this.MoveComp.SetForceSpeed(this.TempVector);
			}
			Vector tempVector = this.TempVector;
			tempVector.DeepCopy(this.MoveOffset);
			SplineRuntime splineRuntime = this.SplineRuntime;
			SplineCurve splineCurve = (splineRuntime != null) ? splineRuntime.WallSpline : null;
			if (splineCurve != null)
			{
				float splineLength = splineCurve.GetSplineLength();
				splineCurve.GetDirectionAtDistanceAlongSpline(splineLength - 1f, ESplineCoordinateSpace.World, tempVector);
			}
			double inB = Vector.DotProduct(tempVector, this.MoveComp.GravityUp);
			Vector tempVector2 = this.TempVector2;
			this.MoveComp.GravityUp.Multiply(inB, tempVector2);
			tempVector.SubtractionEqual(tempVector2);
			if (!tempVector.IsNearlyZero(9.999999747378752E-05))
			{
				MathUtils.Instance.LookRotationUpFirst(tempVector, this.MoveComp.GravityUp, this.TempQuat);
				FTransformDouble actorTransform = this.ActorComp.ActorTransform;
				FQuat fquat = this.TempQuat.ToUeQuat();
				actorTransform.SetRotation(fquat);
				if (this.ClimbComp != null)
				{
					this.ClimbComp.SetCharacterTransformAndBuffer(actorTransform, 300f, null, true);
					return;
				}
				this.SetCharacterTransformWithBuffer(actorTransform, 300f, true);
			}
		}

		// Token: 0x0603DDEA RID: 253418 RVA: 0x011F404C File Offset: 0x011F224C
		private void SetCharacterTransformWithBuffer(FTransformDouble newTransform, float smoothTime, bool sweep = true)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null && animComp.Valid)
			{
				this.AnimComp.SetTransformWithModelBuffer(newTransform, smoothTime, null, sweep);
				return;
			}
			this.ActorComp.SetActorTransform(newTransform, "[SplineClimb] SetCharacterTransformWithBuffer", sweep, null);
		}

		// Token: 0x0603DDEB RID: 253419 RVA: 0x011F40A4 File Offset: 0x011F22A4
		private void InitSplineRuntime(USplineComponent splineAsset)
		{
			this.SplineRuntime = new SplineRuntime();
			this.SplineRuntime.SourceSplineUe = splineAsset;
			SplineCurve sourceSpline = this.SplineRuntime.SourceSpline;
			sourceSpline.Init(splineAsset.SplineCurves.Position, splineAsset.SplineCurves.ReparamTable.Points, splineAsset.SplineCurves.Rotation, splineAsset.SplineCurves.Scale);
			sourceSpline.SetSplineTransform(Transform.Create(splineAsset.D_K2_GetComponentToWorld()), false);
		}

		// Token: 0x0603DDEC RID: 253420 RVA: 0x011F4120 File Offset: 0x011F2320
		private void SetInitialLocation()
		{
			USplineComponent sourceSplineUe = this.SplineRuntime.SourceSplineUe;
			FVectorDouble actorLocation = this.ActorComp.ActorLocation;
			float inKey = sourceSplineUe.D_FindInputKeyClosestToWorldLocationInGravity(actorLocation, this.ActorComp.ActorGravityDirectProxy.ToUeVectorOld(), 800f);
			float distanceAlongSplineAtSplineInputKey = this.SplineRuntime.SourceSplineUe.GetDistanceAlongSplineAtSplineInputKey(inKey);
			this.SplineRuntime.DistanceInSource = distanceAlongSplineAtSplineInputKey;
		}

		// Token: 0x0603DDED RID: 253421 RVA: 0x011F4180 File Offset: 0x011F2380
		private void AddEvents()
		{
			if (this.EventAdded)
			{
				return;
			}
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CustomMoveSplineClimb, new Action<float>(this.ReceiveSplineClimbEvent));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChange));
			this.EventAdded = true;
		}

		// Token: 0x0603DDEE RID: 253422 RVA: 0x011F4238 File Offset: 0x011F2438
		private void RemoveEvents()
		{
			if (!this.EventAdded)
			{
				return;
			}
			EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CustomMoveSplineClimb, new Action<float>(this.ReceiveSplineClimbEvent));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChange));
			this.EventAdded = false;
		}

		// Token: 0x0603DDEF RID: 253423 RVA: 0x011F42F0 File Offset: 0x011F24F0
		private void ReceiveSplineClimbEvent(float deltaTime)
		{
			this.MoveToTarget(deltaTime);
		}

		// Token: 0x0603DDF0 RID: 253424 RVA: 0x011F42F9 File Offset: 0x011F24F9
		private void OnTeleportStart(bool _)
		{
			this.ExitSplineClimb("OnTeleportStart", true, false);
		}

		// Token: 0x0603DDF1 RID: 253425 RVA: 0x011F4308 File Offset: 0x011F2508
		private void OnRoleDead()
		{
			this.ExitSplineClimb("OnRoleDead", true, false);
		}

		// Token: 0x0603DDF2 RID: 253426 RVA: 0x011F4318 File Offset: 0x011F2518
		private void OnUseSkill(int charId, int skillId, bool isAutonomousProxy)
		{
			SplineClimbParams @params = this.Params;
			bool flag = @params != null && @params.InterruptSkills.Contains((long)skillId);
			if (charId != base.Entity.Id || !flag)
			{
				return;
			}
			this.ExitSplineClimb("使用技能" + skillId.ToString(), true, false);
		}

		// Token: 0x0603DDF3 RID: 253427 RVA: 0x011F436C File Offset: 0x011F256C
		private void OnPositionStateChange(ECharPositionState oldPositionState, ECharPositionState newPositionState)
		{
			this.StateChangeExit = true;
		}

		// Token: 0x0603DDF4 RID: 253428 RVA: 0x011F4378 File Offset: 0x011F2578
		private void MoveToTarget(float deltaSeconds)
		{
			SplineRuntime splineRuntime = this.SplineRuntime;
			if (!this.InSplineClimb || splineRuntime == null)
			{
				return;
			}
			float splineLength = splineRuntime.WallSpline.GetSplineLength();
			float num = Math.Max(0f, splineLength - 0.1f);
			if (splineRuntime.DistanceInWallSpline >= num)
			{
				this.ExitSplineClimb("样条结束", true, true);
				return;
			}
			splineRuntime.WallSpline.GetTransformAtDistanceAlongSpline(splineRuntime.DistanceInWallSpline, ESplineCoordinateSpace.World, this.TargetTransform);
			float num2 = this.MoveComp.CharacterMovement.AnimRootMotionVelocity.Size();
			UKuroAnimInstanceRole animInstance = this.AnimInstance;
			float num3 = (animInstance != null && animInstance.HasKuroRootMotionAnim()) ? num2 : 500f;
			float num4 = (deltaSeconds > 0f) ? (1f - (float)Math.Exp((double)(-(double)deltaSeconds / 0.2f))) : 1f;
			this.SmoothedSpeed += (num3 - this.SmoothedSpeed) * num4;
			float smoothedSpeed = this.SmoothedSpeed;
			splineRuntime.DistanceInWallSpline = Math.Min(splineRuntime.DistanceInWallSpline + smoothedSpeed * deltaSeconds, num);
			this.TargetLocation.DeepCopy(this.TargetTransform.GetLocation());
			this.TargetLocation.Subtraction(this.ActorComp.ActorLocationProxy, this.MoveOffset);
			this.ActorComp.AddActorWorldOffset(this.MoveOffset.ToUeVector(false), "[CharacterSplineClimbComponent] 沿样条跑墙", true);
			this.GetTargetRotator(this.TargetTransform, this.TargetRotator);
			this.MoveComp.SmoothCharacterRotation(this.TargetRotator, 800f, deltaSeconds, false, "[SplineClimb] 沿样条跑墙", true);
			this.UpdateAnimParams(this.TargetTransform, deltaSeconds);
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null)
			{
				animComp.ConsumeRootMotion();
			}
			CharacterClimbComponent climbComp = this.ClimbComp;
			if (climbComp == null)
			{
				return;
			}
			climbComp.SetLastSafeLocation(this.ActorComp.ActorLocationProxy);
		}

		// Token: 0x0603DDF5 RID: 253429 RVA: 0x011F4534 File Offset: 0x011F2734
		private void GetTargetRotator(Transform targetTransform, Rotator outRotator)
		{
			this.TempVector3.DeepCopy(this.ActorComp.ActorGravityDirectProxy);
			this.TempVector3.UnaryNegation(this.TempVector3);
			targetTransform.GetRotation().GetUpVector(this.TempVector2);
			this.TempVector2.UnaryNegation(this.TempVector2);
			if (this.IsFirstPerson())
			{
				MathUtils.Instance.LookRotationUpFirst(this.TempVector2, this.TempVector3, outRotator);
				return;
			}
			MathUtils.Instance.LookRotationForwardFirst(this.TempVector2, this.TempVector3, outRotator);
		}

		// Token: 0x0603DDF6 RID: 253430 RVA: 0x011F45C4 File Offset: 0x011F27C4
		private unsafe bool BuildWallSpline(SplineCurve sourceSpline, SplineCurve wallSpline, double startDistance, double endDistance, Vector direction, [Nullable(2)] Vector prependLocation = null)
		{
			List<InterpCurvePointVector> list = new List<InterpCurvePointVector>();
			List<InterpCurvePointQuat> list2 = new List<InterpCurvePointQuat>();
			if (prependLocation != null)
			{
				InterpCurvePointVector interpCurvePointVector = new InterpCurvePointVector(global::EInterpCurveMode.Linear);
				interpCurvePointVector.OutVal.DeepCopy(prependLocation);
				Vector tempVector = this.TempVector;
				sourceSpline.GetDirectionAtDistanceAlongSpline((float)Math.Min(startDistance, (double)sourceSpline.GetSplineLength() - 0.1), ESplineCoordinateSpace.World, tempVector);
				Vector tempVector2 = this.TempVector2;
				tempVector2.DeepCopy(this.ActorComp.ActorGravityDirectProxy);
				tempVector2.UnaryNegation(tempVector2);
				InterpCurvePointQuat interpCurvePointQuat = new InterpCurvePointQuat(global::EInterpCurveMode.Linear);
				MathUtils.Instance.LookRotationUpFirst(tempVector, tempVector2, interpCurvePointQuat.OutVal);
				interpCurvePointQuat.LeaveTangent.DeepCopy(interpCurvePointQuat.OutVal);
				interpCurvePointQuat.ArriveTangent.DeepCopy(interpCurvePointQuat.OutVal);
				list.Add(interpCurvePointVector);
				list2.Add(interpCurvePointQuat);
			}
			double num = (double)sourceSpline.GetSplineLength();
			double num2 = endDistance - startDistance;
			if (num2 < 10.0)
			{
				wallSpline.InitPoints(list, null);
			}
			double sampleInterval = this.Params.SampleInterval;
			int num3 = (int)(num2 / sampleInterval);
			CharacterClimbComponent climbComp = this.ClimbComp;
			float num4 = (climbComp != null) ? climbComp.GetClimbRadius() : 35f;
			double traceStartOffset = this.Params.TraceStartOffset;
			double traceLength = this.Params.TraceLength;
			double extraWallRadius = this.Params.ExtraWallRadius;
			for (int i = 0; i <= num3; i++)
			{
				double num5 = startDistance + (double)i * sampleInterval;
				float distance = (float)Math.Min(num5, num - 0.1);
				Transform tempTransform = this.TempTransform;
				sourceSpline.GetTransformAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World, tempTransform);
				if (this.TraceElement == null)
				{
					this.TraceElement = this.CreateTraceElement();
				}
				this.TraceElement.Radius = num4;
				Vector tempVector3 = this.TempVector;
				direction.GetSafeNormal(tempVector3, 9.99999993922529E-09);
				tempVector3.MultiplyEqual(traceStartOffset);
				tempVector3.AdditionEqual(tempTransform.GetLocation());
				Vector tempVector4 = this.TempVector2;
				direction.GetSafeNormal(tempVector4, 9.99999993922529E-09);
				tempVector4.MultiplyEqual(traceLength);
				tempVector4.AdditionEqual(tempTransform.GetLocation());
				TraceElementCommon.Instance.SetStartLocation(this.TraceElement, tempVector3);
				TraceElementCommon.Instance.SetEndLocation(this.TraceElement, tempVector4);
				if (TraceElementCommon.Instance.SphereTrace(this.TraceElement, "CharacterSplineClimbComponent.BuildWallSpline") && this.TraceElement.HitResult != null)
				{
					Vector tempVector5 = this.TempVector;
					TraceElementCommon.Instance.GetImpactPoint(this.TraceElement.HitResult, 0, tempVector5);
					Vector tempVector6 = this.TempVector2;
					TraceElementCommon.Instance.GetImpactNormal(this.TraceElement.HitResult, 0, tempVector6);
					InterpCurvePointVector interpCurvePointVector2 = new InterpCurvePointVector(global::EInterpCurveMode.CurveAutoClamped);
					interpCurvePointVector2.InVal = (float)i;
					tempVector6.MultiplyEqual((double)num4 + extraWallRadius);
					tempVector5.AdditionEqual(tempVector6);
					tempVector6.Normalize(9.99999993922529E-09);
					interpCurvePointVector2.OutVal.DeepCopy(tempVector5);
					Vector tempVector7 = this.TempVector;
					sourceSpline.GetDirectionAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World, tempVector7);
					InterpCurvePointQuat interpCurvePointQuat2 = new InterpCurvePointQuat(global::EInterpCurveMode.Linear);
					interpCurvePointQuat2.InVal = (float)i;
					MathUtils.Instance.LookRotationUpFirst(tempVector7, tempVector6, interpCurvePointQuat2.OutVal);
					interpCurvePointQuat2.LeaveTangent.DeepCopy(interpCurvePointQuat2.OutVal);
					interpCurvePointQuat2.ArriveTangent.DeepCopy(interpCurvePointQuat2.OutVal);
					double inB = Vector.DotProduct(tempVector7, tempVector6);
					tempVector6.MultiplyEqual(inB);
					tempVector7.SubtractionEqual(tempVector6);
					tempVector7.Normalize(9.99999993922529E-09);
					interpCurvePointVector2.ArriveTangent.DeepCopy(tempVector7);
					interpCurvePointVector2.LeaveTangent.DeepCopy(tempVector7);
					list.Add(interpCurvePointVector2);
					list2.Add(interpCurvePointQuat2);
					if (GlobalData.IsPlayInEditor && this.Params.DebugDraw)
					{
						FVectorDouble fvectorDouble = interpCurvePointVector2.OutVal.ToUeVector(false);
						UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, fvectorDouble, 5f, 12, new FLinearColor?(ColorUtils.LinearYellow), 5f, 0f);
						FVectorDouble fvectorDouble2 = interpCurvePointVector2.ArriveTangent.ToUeVector(false);
						UObject world = GlobalData.World;
						FVectorDouble lineStart = fvectorDouble;
						FVectorDouble fvectorDouble3 = fvectorDouble2 * 20.0;
						UKismetSystemLibrary.D_DrawDebugLine(world, lineStart, fvectorDouble + fvectorDouble3, ColorUtils.LinearRed, 5f, 0f);
						UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, tempTransform.GetLocation().ToUeVector(false), 2f, 12, new FLinearColor?(ColorUtils.LinearBlue), 5f, 0f);
					}
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.LJF;
					string message = "[CharacterSplineClimbComponent] 未检测到墙壁";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("distance", num5);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("maxDistance", num);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				if (num5 >= num)
				{
					break;
				}
			}
			wallSpline.InitPoints(list, list2);
			return list.Count >= 1;
		}

		// Token: 0x0603DDF7 RID: 253431 RVA: 0x011F4AAC File Offset: 0x011F2CAC
		private UTraceSphereElement CreateTraceElement()
		{
			UTraceSphereElement utraceSphereElement = new UTraceSphereElement();
			utraceSphereElement.bIsSingle = true;
			utraceSphereElement.bIgnoreSelf = true;
			utraceSphereElement.WorldContextObject = this.ActorComp.Owner;
			utraceSphereElement.Radius = 2f;
			utraceSphereElement.bTraceComplex = false;
			utraceSphereElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			utraceSphereElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
			return utraceSphereElement;
		}

		// Token: 0x0603DDF8 RID: 253432 RVA: 0x011F4B08 File Offset: 0x011F2D08
		private void UpdateAnimParams(Transform targetTransform, float deltaSeconds)
		{
			Quat rotation = targetTransform.GetRotation();
			Vector tempVector = this.TempVector;
			rotation.GetForwardVector(tempVector);
			double blendSpaceAxis = this.GetBlendSpaceAxis(tempVector);
			this.FastClimbMix = (float)MathUtils.Instance.InterpTo((double)this.FastClimbMix, blendSpaceAxis, (double)deltaSeconds, 4.0);
			this.AnimInstance.FastClimbMix = this.FastClimbMix;
		}

		// Token: 0x0603DDF9 RID: 253433 RVA: 0x011F4B68 File Offset: 0x011F2D68
		private double GetBlendSpaceAxis(Vector moveDirection)
		{
			Vector actorRightProxy = this.ActorComp.ActorRightProxy;
			double num = Vector.DotProduct(moveDirection, actorRightProxy);
			if (-Vector.DotProduct(moveDirection, this.ActorComp.ActorGravityDirectProxy) < 0.0)
			{
				num = (double)((num < 0.0) ? -1 : 1);
			}
			return num;
		}

		// Token: 0x0603DDFA RID: 253434 RVA: 0x011F4BBC File Offset: 0x011F2DBC
		private static SplineClimbParams LoadCommonParams()
		{
			string text = "/Game/Aki/Data/Level/SplineClimb/DA_SplineClimb_Common.DA_SplineClimb_Common";
			BP_SplineClimbConfig_C bp_SplineClimbConfig_C = ResourceSystem.Instance.Load<BP_SplineClimbConfig_C>(text, "js_undefined");
			if (bp_SplineClimbConfig_C == null || !bp_SplineClimbConfig_C.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LJF;
				string message = "[CharacterSplineClimbComponent] 获取样条跑墙DA参数失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DaPath", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new SplineClimbParams(null);
			}
			return CharacterSplineClimbComponent.CommonParams = new SplineClimbParams(bp_SplineClimbConfig_C);
		}

		// Token: 0x0603DDFB RID: 253435 RVA: 0x011F4C25 File Offset: 0x011F2E25
		private bool IsFirstPerson()
		{
			return this.TagComp != null && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.第一人称镜头"]);
		}

		// Token: 0x0603DDFC RID: 253436 RVA: 0x011F4C4C File Offset: 0x011F2E4C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterSplineClimbComponent characterSplineClimbComponent = (CharacterSplineClimbComponent)componentTemplate;
			if (characterSplineClimbComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterSplineClimbComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
			{
				return false;
			}
			if (characterSplineClimbComponent.ClimbComp == null)
			{
				this.ClimbComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClimbComp), "ClimbComp"))
			{
				return false;
			}
			if (characterSplineClimbComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (characterSplineClimbComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (characterSplineClimbComponent.EndCallback == null)
			{
				this.EndCallback = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndCallback), "EndCallback"))
			{
				return false;
			}
			if (characterSplineClimbComponent.SplineRuntime == null)
			{
				this.SplineRuntime = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineRuntime), "SplineRuntime"))
			{
				return false;
			}
			if (characterSplineClimbComponent.TraceDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceDirection), "TraceDirection"))
			{
				return false;
			}
			if (characterSplineClimbComponent.AnimInstance == null)
			{
				this.AnimInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimInstance), "AnimInstance"))
			{
				return false;
			}
			this.FastClimbMix = characterSplineClimbComponent.FastClimbMix;
			this.SmoothedSpeed = characterSplineClimbComponent.SmoothedSpeed;
			if (characterSplineClimbComponent.TraceElement == null)
			{
				this.TraceElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceElement), "TraceElement"))
			{
				return false;
			}
			this.InSplineClimb = characterSplineClimbComponent.InSplineClimb;
			this.DisableClimbHandle = characterSplineClimbComponent.DisableClimbHandle;
			this.StateChangeExit = characterSplineClimbComponent.StateChangeExit;
			this.EventAdded = characterSplineClimbComponent.EventAdded;
			return (characterSplineClimbComponent.TargetTransform == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetTransform), "TargetTransform")) && (characterSplineClimbComponent.MoveOffset == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveOffset), "MoveOffset")) && (characterSplineClimbComponent.TargetLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetLocation), "TargetLocation")) && (characterSplineClimbComponent.TargetRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetRotator), "TargetRotator")) && (characterSplineClimbComponent.TempTransform == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempTransform), "TempTransform")) && (characterSplineClimbComponent.TempVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector")) && (characterSplineClimbComponent.TempVector2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2")) && (characterSplineClimbComponent.TempVector3 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector3), "TempVector3")) && (characterSplineClimbComponent.TempQuat == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempQuat), "TempQuat"));
		}

		// Token: 0x17007596 RID: 30102
		// (get) Token: 0x0603DDFD RID: 253437 RVA: 0x011F4F8B File Offset: 0x011F318B
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007597 RID: 30103
		// (get) Token: 0x0603DDFE RID: 253438 RVA: 0x011F4F8E File Offset: 0x011F318E
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007598 RID: 30104
		// (get) Token: 0x0603DDFF RID: 253439 RVA: 0x011F4F91 File Offset: 0x011F3191
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020D85 RID: 134533
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04020D86 RID: 134534
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04020D87 RID: 134535
		[Nullable(2)]
		private CharacterClimbComponent ClimbComp;

		// Token: 0x04020D88 RID: 134536
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04020D89 RID: 134537
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04020D8A RID: 134538
		[Nullable(2)]
		private Action<bool> EndCallback;

		// Token: 0x04020D8B RID: 134539
		[Nullable(2)]
		private SplineRuntime SplineRuntime;

		// Token: 0x04020D8C RID: 134540
		private readonly Vector TraceDirection = Vector.Create();

		// Token: 0x04020D8D RID: 134541
		[Nullable(2)]
		private UKuroAnimInstanceRole AnimInstance;

		// Token: 0x04020D8E RID: 134542
		private float FastClimbMix;

		// Token: 0x04020D8F RID: 134543
		private float SmoothedSpeed;

		// Token: 0x04020D90 RID: 134544
		[Nullable(2)]
		private UTraceSphereElement TraceElement;

		// Token: 0x04020D91 RID: 134545
		private bool InSplineClimb;

		// Token: 0x04020D92 RID: 134546
		private int DisableClimbHandle;

		// Token: 0x04020D93 RID: 134547
		private bool StateChangeExit;

		// Token: 0x04020D94 RID: 134548
		private bool EventAdded;

		// Token: 0x04020D95 RID: 134549
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		private static SplineClimbParams CommonParams;

		// Token: 0x04020D96 RID: 134550
		private readonly Transform TargetTransform = Transform.Create();

		// Token: 0x04020D97 RID: 134551
		private readonly Vector MoveOffset = Vector.Create();

		// Token: 0x04020D98 RID: 134552
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x04020D99 RID: 134553
		private readonly Rotator TargetRotator = Rotator.Create();

		// Token: 0x04020D9A RID: 134554
		private readonly Transform TempTransform = Transform.Create();

		// Token: 0x04020D9B RID: 134555
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04020D9C RID: 134556
		private readonly Vector TempVector2 = Vector.Create();

		// Token: 0x04020D9D RID: 134557
		private readonly Vector TempVector3 = Vector.Create();

		// Token: 0x04020D9E RID: 134558
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}

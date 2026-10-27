using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SplineClimb;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070FF RID: 28927
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterSplineClimbComponent : EntityComponent
	{
		// Token: 0x17009D09 RID: 40201
		// (get) Token: 0x060469E6 RID: 289254 RVA: 0x011C46B1 File Offset: 0x011C28B1
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

		// Token: 0x060469E7 RID: 289255 RVA: 0x011C46CC File Offset: 0x011C28CC
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

		// Token: 0x060469E8 RID: 289256 RVA: 0x011C474C File Offset: 0x011C294C
		protected override bool OnEnd()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x060469E9 RID: 289257 RVA: 0x011C4755 File Offset: 0x011C2955
		protected override void OnTick(float delta)
		{
			if (this.StateChangeExit)
			{
				this.ExitSplineClimb("位置状态改变", true, false);
				this.StateChangeExit = false;
			}
		}

		// Token: 0x060469EA RID: 289258 RVA: 0x011C4774 File Offset: 0x011C2974
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

		// Token: 0x060469EB RID: 289259 RVA: 0x011C4A6C File Offset: 0x011C2C6C
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

		// Token: 0x060469EC RID: 289260 RVA: 0x011C4D0C File Offset: 0x011C2F0C
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

		// Token: 0x060469ED RID: 289261 RVA: 0x011C4D90 File Offset: 0x011C2F90
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

		// Token: 0x060469EE RID: 289262 RVA: 0x011C4EF4 File Offset: 0x011C30F4
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

		// Token: 0x060469EF RID: 289263 RVA: 0x011C4F4C File Offset: 0x011C314C
		private void InitSplineRuntime(USplineComponent splineAsset)
		{
			this.SplineRuntime = new SplineRuntime();
			this.SplineRuntime.SourceSplineUe = splineAsset;
			SplineCurve sourceSpline = this.SplineRuntime.SourceSpline;
			sourceSpline.Init(splineAsset.SplineCurves.Position, splineAsset.SplineCurves.ReparamTable.Points, splineAsset.SplineCurves.Rotation, splineAsset.SplineCurves.Scale);
			sourceSpline.SetSplineTransform(Transform.Create(splineAsset.D_K2_GetComponentToWorld()), false);
		}

		// Token: 0x060469F0 RID: 289264 RVA: 0x011C4FC8 File Offset: 0x011C31C8
		private void SetInitialLocation()
		{
			USplineComponent sourceSplineUe = this.SplineRuntime.SourceSplineUe;
			FVectorDouble actorLocation = this.ActorComp.ActorLocation;
			float inKey = sourceSplineUe.D_FindInputKeyClosestToWorldLocationInGravity(actorLocation, this.ActorComp.ActorGravityDirectProxy.ToUeVectorOld(), 800f);
			float distanceAlongSplineAtSplineInputKey = this.SplineRuntime.SourceSplineUe.GetDistanceAlongSplineAtSplineInputKey(inKey);
			this.SplineRuntime.DistanceInSource = distanceAlongSplineAtSplineInputKey;
		}

		// Token: 0x060469F1 RID: 289265 RVA: 0x011C5028 File Offset: 0x011C3228
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

		// Token: 0x060469F2 RID: 289266 RVA: 0x011C50E0 File Offset: 0x011C32E0
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

		// Token: 0x060469F3 RID: 289267 RVA: 0x011C5195 File Offset: 0x011C3395
		private void ReceiveSplineClimbEvent(float deltaTime)
		{
			this.MoveToTarget(deltaTime);
		}

		// Token: 0x060469F4 RID: 289268 RVA: 0x011C519E File Offset: 0x011C339E
		private void OnTeleportStart(bool _)
		{
			this.ExitSplineClimb("OnTeleportStart", true, false);
		}

		// Token: 0x060469F5 RID: 289269 RVA: 0x011C51AD File Offset: 0x011C33AD
		private void OnRoleDead()
		{
			this.ExitSplineClimb("OnRoleDead", true, false);
		}

		// Token: 0x060469F6 RID: 289270 RVA: 0x011C51BC File Offset: 0x011C33BC
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

		// Token: 0x060469F7 RID: 289271 RVA: 0x011C5210 File Offset: 0x011C3410
		private void OnPositionStateChange(ECharPositionState oldPositionState, ECharPositionState newPositionState)
		{
			this.StateChangeExit = true;
		}

		// Token: 0x060469F8 RID: 289272 RVA: 0x011C521C File Offset: 0x011C341C
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

		// Token: 0x060469F9 RID: 289273 RVA: 0x011C53D8 File Offset: 0x011C35D8
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

		// Token: 0x060469FA RID: 289274 RVA: 0x011C5468 File Offset: 0x011C3668
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

		// Token: 0x060469FB RID: 289275 RVA: 0x011C5950 File Offset: 0x011C3B50
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

		// Token: 0x060469FC RID: 289276 RVA: 0x011C59AC File Offset: 0x011C3BAC
		private void UpdateAnimParams(Transform targetTransform, float deltaSeconds)
		{
			Quat rotation = targetTransform.GetRotation();
			Vector tempVector = this.TempVector;
			rotation.GetForwardVector(tempVector);
			double blendSpaceAxis = this.GetBlendSpaceAxis(tempVector);
			this.FastClimbMix = (float)MathUtils.Instance.InterpTo((double)this.FastClimbMix, blendSpaceAxis, (double)deltaSeconds, 4.0);
			this.AnimInstance.FastClimbMix = this.FastClimbMix;
		}

		// Token: 0x060469FD RID: 289277 RVA: 0x011C5A0C File Offset: 0x011C3C0C
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

		// Token: 0x060469FE RID: 289278 RVA: 0x011C5A60 File Offset: 0x011C3C60
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

		// Token: 0x060469FF RID: 289279 RVA: 0x011C5AC9 File Offset: 0x011C3CC9
		private bool IsFirstPerson()
		{
			return this.TagComp != null && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.第一人称镜头"]);
		}

		// Token: 0x06046A00 RID: 289280 RVA: 0x011C5AF0 File Offset: 0x011C3CF0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterSplineClimbComponent characterSplineClimbComponent = (CharacterSplineClimbComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterSplineClimbComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimComp"))
			{
				if (characterSplineClimbComponent.AnimComp == null)
				{
					this.AnimComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbComp"))
			{
				if (characterSplineClimbComponent.ClimbComp == null)
				{
					this.ClimbComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterClimbComponent>(this.ClimbComp), "ClimbComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (characterSplineClimbComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterSplineClimbComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EndCallback"))
			{
				if (characterSplineClimbComponent.EndCallback == null)
				{
					this.EndCallback = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<bool>>(this.EndCallback), "EndCallback"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SplineRuntime"))
			{
				if (characterSplineClimbComponent.SplineRuntime == null)
				{
					this.SplineRuntime = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SplineRuntime>(this.SplineRuntime), "SplineRuntime"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TraceDirection") && characterSplineClimbComponent.TraceDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TraceDirection), "TraceDirection"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("AnimInstance"))
			{
				if (characterSplineClimbComponent.AnimInstance == null)
				{
					this.AnimInstance = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroAnimInstanceRole>(this.AnimInstance), "AnimInstance"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FastClimbMix"))
			{
				this.FastClimbMix = characterSplineClimbComponent.FastClimbMix;
			}
			if (base.CanResetComponentProperty("SmoothedSpeed"))
			{
				this.SmoothedSpeed = characterSplineClimbComponent.SmoothedSpeed;
			}
			if (base.CanResetComponentProperty("TraceElement"))
			{
				if (characterSplineClimbComponent.TraceElement == null)
				{
					this.TraceElement = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.TraceElement), "TraceElement"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InSplineClimb"))
			{
				this.InSplineClimb = characterSplineClimbComponent.InSplineClimb;
			}
			if (base.CanResetComponentProperty("DisableClimbHandle"))
			{
				this.DisableClimbHandle = characterSplineClimbComponent.DisableClimbHandle;
			}
			if (base.CanResetComponentProperty("StateChangeExit"))
			{
				this.StateChangeExit = characterSplineClimbComponent.StateChangeExit;
			}
			if (base.CanResetComponentProperty("EventAdded"))
			{
				this.EventAdded = characterSplineClimbComponent.EventAdded;
			}
			return (!base.CanResetComponentProperty("TargetTransform") || characterSplineClimbComponent.TargetTransform == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Transform>(this.TargetTransform), "TargetTransform")) && (!base.CanResetComponentProperty("MoveOffset") || characterSplineClimbComponent.MoveOffset == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MoveOffset), "MoveOffset")) && (!base.CanResetComponentProperty("TargetLocation") || characterSplineClimbComponent.TargetLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TargetLocation), "TargetLocation")) && (!base.CanResetComponentProperty("TargetRotator") || characterSplineClimbComponent.TargetRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TargetRotator), "TargetRotator")) && (!base.CanResetComponentProperty("TempTransform") || characterSplineClimbComponent.TempTransform == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Transform>(this.TempTransform), "TempTransform")) && (!base.CanResetComponentProperty("TempVector") || characterSplineClimbComponent.TempVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector), "TempVector")) && (!base.CanResetComponentProperty("TempVector2") || characterSplineClimbComponent.TempVector2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector2), "TempVector2")) && (!base.CanResetComponentProperty("TempVector3") || characterSplineClimbComponent.TempVector3 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector3), "TempVector3")) && (!base.CanResetComponentProperty("TempQuat") || characterSplineClimbComponent.TempQuat == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TempQuat), "TempQuat"));
		}

		// Token: 0x040250F0 RID: 151792
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x040250F1 RID: 151793
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x040250F2 RID: 151794
		[Nullable(2)]
		private CharacterClimbComponent ClimbComp;

		// Token: 0x040250F3 RID: 151795
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x040250F4 RID: 151796
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x040250F5 RID: 151797
		[Nullable(2)]
		private Action<bool> EndCallback;

		// Token: 0x040250F6 RID: 151798
		[Nullable(2)]
		private SplineRuntime SplineRuntime;

		// Token: 0x040250F7 RID: 151799
		private readonly Vector TraceDirection = Vector.Create();

		// Token: 0x040250F8 RID: 151800
		[Nullable(2)]
		private UKuroAnimInstanceRole AnimInstance;

		// Token: 0x040250F9 RID: 151801
		private float FastClimbMix;

		// Token: 0x040250FA RID: 151802
		private float SmoothedSpeed;

		// Token: 0x040250FB RID: 151803
		[Nullable(2)]
		private UTraceSphereElement TraceElement;

		// Token: 0x040250FC RID: 151804
		private bool InSplineClimb;

		// Token: 0x040250FD RID: 151805
		private int DisableClimbHandle;

		// Token: 0x040250FE RID: 151806
		private bool StateChangeExit;

		// Token: 0x040250FF RID: 151807
		private bool EventAdded;

		// Token: 0x04025100 RID: 151808
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		private static SplineClimbParams CommonParams;

		// Token: 0x04025101 RID: 151809
		private readonly Transform TargetTransform = Transform.Create();

		// Token: 0x04025102 RID: 151810
		private readonly Vector MoveOffset = Vector.Create();

		// Token: 0x04025103 RID: 151811
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x04025104 RID: 151812
		private readonly Rotator TargetRotator = Rotator.Create();

		// Token: 0x04025105 RID: 151813
		private readonly Transform TempTransform = Transform.Create();

		// Token: 0x04025106 RID: 151814
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04025107 RID: 151815
		private readonly Vector TempVector2 = Vector.Create();

		// Token: 0x04025108 RID: 151816
		private readonly Vector TempVector3 = Vector.Create();

		// Token: 0x04025109 RID: 151817
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}

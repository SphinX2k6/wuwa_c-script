using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007198 RID: 29080
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemTrackGuideComponent : EntityComponent
	{
		// Token: 0x06047264 RID: 291428 RVA: 0x012121D0 File Offset: 0x012103D0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			FollowTrackComponent followTrackComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemTrackGuideComponent>() as FollowTrackComponent;
			if (followTrackComponent.SplineEntityId != 0)
			{
				this.SplineEntityId = followTrackComponent.SplineEntityId;
			}
			this.IsInRange = false;
			this.UpdateState = SceneItemTrackGuideComponent.EUpdateState.UpdateToSplineStart;
			this.HasFinished = false;
			SModelConfig modelConfig = base.Entity.GetComponent<CreatureDataComponent>().GetModelConfig();
			FGameplayTag value = GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["物体.表现.常驻特效"]).Value;
			this.UseCommonEffect = (((modelConfig != null) ? modelConfig.常驻特效列表.GetValueOrDefault(value) : null) != null);
			switch (followTrackComponent.EndType.Type)
			{
			case EFollowTrackEndType.ToStart:
				this.FoundationId = null;
				this.ReachedEndOfSplineType = new EFollowTrackEndType?(EFollowTrackEndType.ToStart);
				break;
			case EFollowTrackEndType.ToFoundation:
			{
				IFollowTrackToFoundation followTrackToFoundation = (IFollowTrackToFoundation)followTrackComponent.EndType;
				this.FoundationId = new int?(followTrackToFoundation.FoundationId);
				this.ReachedEndOfSplineType = new EFollowTrackEndType?(EFollowTrackEndType.ToFoundation);
				if (followTrackToFoundation.FinalOffset != null)
				{
					this.FoundationOffset = global::Vector.Create((double)followTrackToFoundation.FinalOffset.X.Value, (double)followTrackToFoundation.FinalOffset.Y.Value, (double)followTrackToFoundation.FinalOffset.Z.Value);
				}
				else
				{
					this.FoundationOffset = global::Vector.Create();
				}
				break;
			}
			case EFollowTrackEndType.ToSplineDestination:
				this.ReachedEndOfSplineType = new EFollowTrackEndType?(EFollowTrackEndType.ToSplineDestination);
				break;
			}
			this.DistanceAlongSpline = 0f;
			this.TargetPointIndex = 0;
			this.NeedCheckWait = true;
			this.FoundationLocation = global::Vector.Create();
			this.SplineStartLocation = global::Vector.Create();
			this.SplineEndLocation = global::Vector.Create();
			this.DirectionCache = global::Vector.Create();
			this.DistanceBetweenLastTwoPointsInverse = 0f;
			this.PawnSensoryInfo = base.Entity.GetComponent<PawnSensoryInfoComponent>();
			this.PawnSensoryInfo.SetLogicRange(followTrackComponent.Range);
			this.AddEvents();
			return true;
		}

		// Token: 0x06047265 RID: 291429 RVA: 0x012123BC File Offset: 0x012105BC
		private void AddEvents()
		{
			if (this.UseCommonEffect)
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnAddCommonEffect, new Action(this.OnAddCommonEffect));
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.EnterLogicRange, new Action(this.OnEnterLogicRange));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.LeaveLogicRange, new Action(this.OnLeaveLogicRange));
			EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
		}

		// Token: 0x06047266 RID: 291430 RVA: 0x01212454 File Offset: 0x01210654
		private void RemoveEvents()
		{
			if (this.UseCommonEffect)
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnAddCommonEffect, new Action(this.OnAddCommonEffect));
			}
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.EnterLogicRange, new Action(this.OnEnterLogicRange));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.LeaveLogicRange, new Action(this.OnLeaveLogicRange));
			EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
		}

		// Token: 0x06047267 RID: 291431 RVA: 0x012124EC File Offset: 0x012106EC
		protected unsafe override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log.Instance.Error(ELogModule.SceneGameplay, ELogAuthor.CJH, "[SceneItemTrackGuideComponent] SceneItemPatrolComponent初始化失败 Actor Component Undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			CreatureDataComponent creatureData = this.ActorComp.CreatureData;
			BaseInfoComponent baseInfo = creatureData.GetBaseInfo();
			if (baseInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "[PawnAdsorbComponent.OnStart] SceneItemPatrolComponent初始化失败 Config Invalid";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureGenID:", creatureData.GetOwnerId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId:", creatureData.GetPbDataId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.OnlineInteractType = new EOnlineInteractType?(baseInfo.OnlineInteractType);
			if (this.OnlineInteractType.GetValueOrDefault() == EOnlineInteractType.EveryOne)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneGameplay;
				ELogAuthor author2 = ELogAuthor.CJH;
				string message2 = "[PawnAdsorbComponent.OnStart] 不支持的联机类型配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureGenID:", creatureData.GetOwnerId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId:", creatureData.GetPbDataId());
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.OnlineInteractType = new EOnlineInteractType?(EOnlineInteractType.HostOnly);
			}
			this.PerformanceComp = base.Entity.GetComponent<PerformanceComponent>();
			this.PropertyComp = base.Entity.GetComponent<SceneItemPropertyComponent>();
			this.SyncComp = base.Entity.GetComponent<SceneItemMovementSyncComponent>();
			this.MoveComp = base.Entity.GetComponent<SceneItemMoveComponent>();
			if (GameModeModel.Instance.IsMulti && !LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(this.OnlineInteractType.Value, false))
			{
				this.DisableHandle = new int?(base.Disable("[SceneItemTrackGuideComponent.OnStart] 联机停止交互"));
				return true;
			}
			this.InitSpline();
			return true;
		}

		// Token: 0x06047268 RID: 291432 RVA: 0x012126C9 File Offset: 0x012108C9
		protected override void OnActivate()
		{
			if (GameModeModel.Instance.IsMulti && !LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(this.OnlineInteractType.Value, false))
			{
				SceneItemMovementSyncComponent syncComp = this.SyncComp;
				if (syncComp == null)
				{
					return;
				}
				syncComp.SetEnableMovementSync(true, "SceneItemTrackGuideComponent OnActivate");
			}
		}

		// Token: 0x06047269 RID: 291433 RVA: 0x01212708 File Offset: 0x01210908
		private void InitSpline()
		{
			USplineComponent usplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(this.SplineEntityId, this.ActorComp.CreatureData.GetPbDataId(), EIdType.PbDataId);
			if (usplineComponent == null)
			{
				return;
			}
			this.PathLine = usplineComponent;
			TsGameSplineActor splineActorBySplineId = GameSplineModel.Instance.GetSplineActorBySplineId(this.SplineEntityId);
			global::Vector splineStartLocation = this.SplineStartLocation;
			FVectorDouble fvectorDouble = usplineComponent.D_GetLocationAtDistanceAlongSpline(0f, ESplineCoordinateSpace.World);
			splineStartLocation.FromUeVector(fvectorDouble);
			this.NumSplinePoints = usplineComponent.GetNumberOfSplinePoints();
			ISplineType splineData = splineActorBySplineId.SplineData;
			this.WaitConfig = new List<bool>(this.NumSplinePoints);
			this.SpeedConfig = new List<float>(this.NumSplinePoints);
			List<float> list = new List<float>(this.NumSplinePoints);
			for (int i = 0; i < this.NumSplinePoints; i++)
			{
				this.WaitConfig.Add(!SceneItemTrackGuideComponent.IsSplinePointIgnored(splineData, i));
				list.Add(0f);
			}
			for (int j = 0; j < this.NumSplinePoints; j++)
			{
				this.LastSpeed = MathUtils.Instance.Clamp(SceneItemTrackGuideComponent.GetSplinePointMoveSpeed(splineData, j), 50f, 800f);
				this.SpeedConfig.Add(this.LastSpeed);
			}
			this.SplineMoveParam = new SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam(usplineComponent);
			SceneItemSplineMoveTaskUtils.ParseOldConfigToSplineMoveParam(usplineComponent, this.SpeedConfig, list, false, false, true, 0f, this.SplineMoveParam);
			this.SplineLength = usplineComponent.GetSplineLength();
			global::Vector splineEndLocation = this.SplineEndLocation;
			fvectorDouble = usplineComponent.D_GetLocationAtSplinePoint(this.NumSplinePoints - 1, ESplineCoordinateSpace.World);
			splineEndLocation.FromUeVector(fvectorDouble);
			if (this.FoundationLocation != null)
			{
				this.SplineEndLocation.Subtraction(this.FoundationLocation, this.DirectionCache);
				if (this.DirectionCache.SizeSquared() < 10000.0)
				{
					this.WaitConfig[this.NumSplinePoints - 1] = false;
					this.SpeedConfig[this.NumSplinePoints - 1] = 150f;
					this.LastSpeed = 150f;
				}
			}
			if (this.NumSplinePoints >= 2)
			{
				this.DistanceBetweenLastTwoPointsInverse = this.SplineLength - usplineComponent.GetDistanceAlongSplineAtSplinePoint(this.NumSplinePoints - 2);
				if ((double)this.DistanceBetweenLastTwoPointsInverse <= 1.0)
				{
					this.DistanceBetweenLastTwoPointsInverse = 0f;
					return;
				}
				this.DistanceBetweenLastTwoPointsInverse = 1f / this.DistanceBetweenLastTwoPointsInverse;
			}
		}

		// Token: 0x0604726A RID: 291434 RVA: 0x0121293C File Offset: 0x01210B3C
		private static bool IsSplinePointIgnored(ISplineType splineData, int index)
		{
			IButterflySpline butterflySpline = splineData as IButterflySpline;
			bool result;
			if (butterflySpline == null)
			{
				IPatrolSpline patrolSpline = splineData as IPatrolSpline;
				result = (patrolSpline != null && patrolSpline.Points[index].IgnorePoint.GetValueOrDefault());
			}
			else
			{
				result = butterflySpline.Points[index].IgnorePoint;
			}
			return result;
		}

		// Token: 0x0604726B RID: 291435 RVA: 0x01212994 File Offset: 0x01210B94
		private static float GetSplinePointMoveSpeed(ISplineType splineData, int index)
		{
			IButterflySpline butterflySpline = splineData as IButterflySpline;
			int num;
			if (butterflySpline == null)
			{
				IPatrolSpline patrolSpline = splineData as IPatrolSpline;
				if (patrolSpline == null)
				{
					num = 800;
				}
				else
				{
					num = patrolSpline.Points[index].MoveSpeed;
				}
			}
			else
			{
				num = butterflySpline.Points[index].MoveSpeed;
			}
			return (float)num;
		}

		// Token: 0x0604726C RID: 291436 RVA: 0x012129E7 File Offset: 0x01210BE7
		protected override void OnTick(float delta)
		{
			if (this.HasFinished || (this.UseCommonEffect && !this.CommonEffectInit))
			{
				return;
			}
			if (this.UpdateState != SceneItemTrackGuideComponent.EUpdateState.UpdateToSplineEnd)
			{
				this.UpdateNoSplineMovement(delta);
				return;
			}
			this.UpdateSplineMovement(delta);
		}

		// Token: 0x0604726D RID: 291437 RVA: 0x01212A1C File Offset: 0x01210C1C
		private void UpdateSplineMovement(float delta)
		{
			USplineComponent pathLine = this.PathLine;
			if (pathLine != null && pathLine.IsValid() && this.SplineMoveParam != null)
			{
				SceneItemActorComponent actorComp = this.ActorComp;
				if (actorComp == null || !actorComp.CreatureData.GetRemoveState())
				{
					if (this.NeedCheckWait && this.CheckAndUpdateIfNeedWaiting())
					{
						if (this.ShouldBeMoving)
						{
							this.ShouldBeMoving = false;
							SceneItemMovementSyncComponent syncComp = this.SyncComp;
							if (syncComp != null)
							{
								syncComp.SetEnableMovementSync(false, "SceneItemTrackGuideComponent UpdateSplineMovement MoveStop");
							}
							this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 0f);
							SceneItemMoveComponent moveComp = this.MoveComp;
							if (moveComp == null)
							{
								return;
							}
							moveComp.StopMove(true, true);
						}
						return;
					}
					USplineComponent pathLine2 = this.PathLine;
					int targetPointIndex = this.TargetPointIndex;
					float distanceAlongSplineAtSplinePoint = pathLine2.GetDistanceAlongSplineAtSplinePoint(targetPointIndex);
					SceneItemMoveComponent moveComp2 = this.MoveComp;
					if (moveComp2 != null && moveComp2.IsMoving)
					{
						this.DistanceAlongSpline = this.MoveComp.GetDistanceAloneSpline();
					}
					if (!this.ShouldBeMoving)
					{
						this.ShouldBeMoving = true;
						this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 1f);
						if (!this.HasTriggered)
						{
							this.HasTriggered = true;
							this.ReportTrigger();
						}
					}
					base.Entity.ChangeTickInterval(0);
					SceneItemMoveComponent moveComp3 = this.MoveComp;
					if (moveComp3 == null || !moveComp3.IsMoving)
					{
						this.SplineMoveParam.StartDis = this.DistanceAlongSpline;
						this.SplineMoveParam.EndDis = distanceAlongSplineAtSplinePoint;
						SceneItemMoveComponent moveComp4 = this.MoveComp;
						if (moveComp4 != null)
						{
							moveComp4.StartSplineMoveAtConstantTimeImplement(this.SplineMoveParam, new Action(this.SplineMoveStopCallback), true);
						}
					}
					if (this.ReachedEndOfSplineType.GetValueOrDefault() == EFollowTrackEndType.ToFoundation && this.PerformanceComp != null && this.TargetPointIndex == this.NumSplinePoints - 1)
					{
						float alpha = (this.SplineLength - this.DistanceAlongSpline) * this.DistanceBetweenLastTwoPointsInverse;
						float value = MathUtils.Instance.Lerp(0f, 50f, alpha);
						this.PerformanceComp.ApplyNiagaraParameters("Radius", value);
						this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 1f);
					}
					return;
				}
			}
		}

		// Token: 0x0604726E RID: 291438 RVA: 0x01212C14 File Offset: 0x01210E14
		private void SplineMoveStopCallback()
		{
			this.ShouldBeMoving = false;
			this.NeedCheckWait = true;
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.CollectSampleAndSend(false);
			}
			SceneItemMovementSyncComponent syncComp2 = this.SyncComp;
			if (syncComp2 != null)
			{
				syncComp2.SetEnableMovementSync(false, "SceneItemTrackGuideComponent SplineMoveStopCallback");
			}
			USplineComponent pathLine = this.PathLine;
			if (pathLine != null && pathLine.IsValid())
			{
				SceneItemActorComponent actorComp = this.ActorComp;
				if (actorComp == null || !actorComp.CreatureData.GetRemoveState())
				{
					USplineComponent pathLine2 = this.PathLine;
					this.DistanceAlongSpline = pathLine2.GetDistanceAlongSplineAtSplinePoint(this.TargetPointIndex);
					this.TargetPointIndex++;
					if (this.TargetPointIndex > this.NumSplinePoints - 1)
					{
						this.TargetPointIndex = this.NumSplinePoints - 1;
						this.DistanceAlongSpline = this.SplineLength;
						EFollowTrackEndType? reachedEndOfSplineType = this.ReachedEndOfSplineType;
						if (reachedEndOfSplineType != null)
						{
							switch (reachedEndOfSplineType.GetValueOrDefault())
							{
							case EFollowTrackEndType.ToStart:
								this.UpdateState = SceneItemTrackGuideComponent.EUpdateState.UpdateToSplineStart;
								break;
							case EFollowTrackEndType.ToFoundation:
								this.UpdateState = SceneItemTrackGuideComponent.EUpdateState.UpdateToFoundation;
								break;
							case EFollowTrackEndType.ToSplineDestination:
								this.UpdateState = SceneItemTrackGuideComponent.EUpdateState.UpdateToStopAtEnd;
								break;
							}
						}
					}
					if (this.ReachedEndOfSplineType.GetValueOrDefault() == EFollowTrackEndType.ToFoundation && this.PerformanceComp != null && this.TargetPointIndex == this.NumSplinePoints - 1)
					{
						float alpha = (this.SplineLength - this.DistanceAlongSpline) * this.DistanceBetweenLastTwoPointsInverse;
						float value = MathUtils.Instance.Lerp(0f, 50f, alpha);
						this.PerformanceComp.ApplyNiagaraParameters("Radius", value);
						this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 1f);
					}
					return;
				}
			}
		}

		// Token: 0x0604726F RID: 291439 RVA: 0x01212D9C File Offset: 0x01210F9C
		private void UpdateNoSplineMovement(float delta)
		{
			if (this.NeedCheckWait && this.CheckAndUpdateIfNeedWaiting())
			{
				if (this.ShouldBeMoving)
				{
					this.ShouldBeMoving = false;
					SceneItemMovementSyncComponent syncComp = this.SyncComp;
					if (syncComp != null)
					{
						syncComp.CollectSampleAndSend(false);
					}
					SceneItemMovementSyncComponent syncComp2 = this.SyncComp;
					if (syncComp2 != null)
					{
						syncComp2.SetEnableMovementSync(false, "SceneItemTrackGuideComponent UpdateNoSplineMovement MoveStop");
					}
					this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 0f);
				}
				return;
			}
			if (!this.ShouldBeMoving)
			{
				this.ShouldBeMoving = true;
				this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 1f);
				if (!this.HasTriggered)
				{
					this.HasTriggered = true;
					this.ReportTrigger();
				}
			}
			base.Entity.ChangeTickInterval(0);
			switch (this.UpdateState)
			{
			case SceneItemTrackGuideComponent.EUpdateState.UpdateToSplineStart:
				this.UpdateToSplineStart(delta);
				if (this.CheckIfReach(this.SplineStartLocation))
				{
					this.OnTrackGuideReset();
					return;
				}
				break;
			case SceneItemTrackGuideComponent.EUpdateState.UpdateToSplineEnd:
				break;
			case SceneItemTrackGuideComponent.EUpdateState.UpdateToFoundation:
				this.UpdateToFoundation(delta);
				if (this.CheckIfReach(this.FoundationLocation))
				{
					this.ActorComp.SetActorLocation(this.FoundationLocation.ToUeVector(false), "unknown", true);
					this.OnTrackGuideFinish();
					return;
				}
				break;
			case SceneItemTrackGuideComponent.EUpdateState.UpdateToStopAtEnd:
				this.UpdateToStopAtEnd(delta);
				if (this.CheckIfReach(this.SplineEndLocation))
				{
					this.OnTrackGuideFinish();
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06047270 RID: 291440 RVA: 0x01212EE0 File Offset: 0x012110E0
		private void UpdateToSplineStart(float delta)
		{
			USplineComponent pathLine = this.PathLine;
			if (pathLine == null || !pathLine.IsValid())
			{
				return;
			}
			SceneItemMoveComponent moveComp = this.MoveComp;
			if (moveComp != null && moveComp.IsMoving)
			{
				return;
			}
			double num = global::Vector.Dist(this.ActorComp.ActorLocationProxy, this.SplineStartLocation) / 600.0;
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.SetEnableMovementSync(true, "UpdateNoSplineMovement UpdateToSplineStart");
			}
			SceneItemMoveComponent moveComp2 = this.MoveComp;
			if (moveComp2 != null)
			{
				moveComp2.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(global::Vector.Create(this.SplineStartLocation), (float)num, 0f, -1f, -1f));
			}
			this.HasMoveStart = true;
		}

		// Token: 0x06047271 RID: 291441 RVA: 0x01212F8C File Offset: 0x0121118C
		private void UpdateToFoundation(float delta)
		{
			bool flag = (this.FoundationId ?? 0) == 0;
			if (flag)
			{
				return;
			}
			SceneItemMoveComponent moveComp = this.MoveComp;
			if (moveComp != null && moveComp.IsMoving)
			{
				return;
			}
			if (this.FoundationEntity == null)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.FoundationId.Value);
				if (entityByPbDataId == null)
				{
					return;
				}
				BaseActorComponent component = entityByPbDataId.Entity.GetComponent<BaseActorComponent>();
				if (component == null || component.Owner == null)
				{
					return;
				}
				this.FoundationEntity = entityByPbDataId;
				this.FoundationLocation.DeepCopy(component.ActorLocationProxy);
				this.FoundationLocation.AdditionEqual(this.FoundationOffset);
			}
			double num = global::Vector.Dist(this.ActorComp.ActorLocationProxy, this.FoundationLocation) / (double)this.LastSpeed;
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.SetEnableMovementSync(true, "UpdateNoSplineMovement UpdateToFoundation");
			}
			SceneItemMoveComponent moveComp2 = this.MoveComp;
			if (moveComp2 == null)
			{
				return;
			}
			moveComp2.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(global::Vector.Create(this.FoundationLocation), (float)num, 0f, -1f, -1f));
		}

		// Token: 0x06047272 RID: 291442 RVA: 0x012130A0 File Offset: 0x012112A0
		private void UpdateToStopAtEnd(float delta)
		{
			this.ActorComp.SetActorLocation(this.SplineEndLocation.ToUeVector(false), "unknown", true);
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp == null)
			{
				return;
			}
			syncComp.SetEnableMovementSync(true, "UpdateNoSplineMovement UpdateToStopAtEnd");
		}

		// Token: 0x06047273 RID: 291443 RVA: 0x012130D8 File Offset: 0x012112D8
		private void OnTrackGuideFinish()
		{
			SceneItemMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.StopMove(true, true);
			}
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.CollectSampleAndSend(false);
			}
			SceneItemMovementSyncComponent syncComp2 = this.SyncComp;
			if (syncComp2 != null)
			{
				syncComp2.SetEnableMovementSync(false, "UpdateNoSplineMovement OnTrackGuideFinish");
			}
			this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 0f);
			this.PerformanceComp.ApplyNiagaraParameters("IsDying", 1f);
			this.HasFinished = true;
			LevelGamePlayController.Instance.EntityFollowTrackRequest(this.ActorComp.CreatureData.GetCreatureDataId(), delegate(FollowTrackResponse response, Net.CallbackStatus _)
			{
			});
		}

		// Token: 0x06047274 RID: 291444 RVA: 0x01213190 File Offset: 0x01211390
		private void OnTrackGuideReset()
		{
			this.ActorComp.SetActorLocation(this.SplineStartLocation.ToUeVector(false), "unknown", true);
			this.UpdateState = SceneItemTrackGuideComponent.EUpdateState.UpdateToSplineEnd;
			this.DistanceAlongSpline = 0f;
			this.TargetPointIndex = 0;
			this.NeedCheckWait = true;
			this.ShouldBeMoving = false;
			SceneItemMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.StopMove(true, true);
			}
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.CollectSampleAndSend(false);
			}
			SceneItemMovementSyncComponent syncComp2 = this.SyncComp;
			if (syncComp2 != null)
			{
				syncComp2.SetEnableMovementSync(false, "UpdateNoSplineMovement OnTrackGuideReset");
			}
			this.HasMoveStart = true;
			this.PerformanceComp.ApplyNiagaraParameters("IsMoving", 0f);
		}

		// Token: 0x06047275 RID: 291445 RVA: 0x0121323C File Offset: 0x0121143C
		private bool CheckAndUpdateIfNeedWaiting()
		{
			USplineComponent pathLine = this.PathLine;
			if (pathLine == null || !pathLine.IsValid())
			{
				this.NeedCheckWait = true;
				return true;
			}
			SceneItemPropertyComponent propertyComp = this.PropertyComp;
			if (propertyComp != null && propertyComp.IsLocked)
			{
				this.NeedCheckWait = true;
				return true;
			}
			if (this.IsInRange && !SceneTeamModel.Instance.IsPhantomTeam)
			{
				this.NeedCheckWait = false;
				return false;
			}
			if (!this.HasMoveStart)
			{
				this.NeedCheckWait = true;
				return true;
			}
			int index = (this.TargetPointIndex == 0) ? 0 : (this.TargetPointIndex - 1);
			this.NeedCheckWait = this.WaitConfig[index];
			return this.NeedCheckWait;
		}

		// Token: 0x06047276 RID: 291446 RVA: 0x012132E0 File Offset: 0x012114E0
		[NullableContext(1)]
		private bool CheckIfReach(global::Vector location)
		{
			return this.ActorComp != null && global::Vector.DistSquared(this.ActorComp.ActorLocationProxy, location) <= 2500.0;
		}

		// Token: 0x06047277 RID: 291447 RVA: 0x0121330B File Offset: 0x0121150B
		private void OnAddCommonEffect()
		{
			this.CommonEffectInit = true;
		}

		// Token: 0x06047278 RID: 291448 RVA: 0x01213314 File Offset: 0x01211514
		private void OnEnterLogicRange()
		{
			this.IsInRange = true;
		}

		// Token: 0x06047279 RID: 291449 RVA: 0x0121331D File Offset: 0x0121151D
		private void OnLeaveLogicRange()
		{
			this.IsInRange = false;
		}

		// Token: 0x0604727A RID: 291450 RVA: 0x01213328 File Offset: 0x01211528
		private void OnChangeModeFinish()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				int? disableHandle = this.DisableHandle;
				if (disableHandle != null && disableHandle.GetValueOrDefault() != 0)
				{
					base.Enable(new int?(this.DisableHandle.Value), "[SceneItemTrackGuideComponent.OnChangeModeFinish] 单机启用交互");
					this.DisableHandle = null;
					return;
				}
			}
			else
			{
				if (!LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(this.OnlineInteractType.Value, false))
				{
					this.DisableHandle = new int?(base.Disable("[SceneItemTrackGuideComponent.OnChangeModeFinish] 联机停止交互"));
					this.Reset();
					return;
				}
				int? disableHandle = this.DisableHandle;
				if (disableHandle != null && disableHandle.GetValueOrDefault() != 0)
				{
					base.Enable(new int?(this.DisableHandle.Value), "[SceneItemTrackGuideComponent.OnChangeModeFinish] 联机启用交互");
					this.DisableHandle = null;
				}
			}
		}

		// Token: 0x0604727B RID: 291451 RVA: 0x012133FF File Offset: 0x012115FF
		private void Reset()
		{
			if (this.HasFinished)
			{
				return;
			}
			this.OnTrackGuideReset();
		}

		// Token: 0x0604727C RID: 291452 RVA: 0x01213410 File Offset: 0x01211610
		protected override bool OnEnd()
		{
			this.RemoveEvents();
			if (this.PathLine != null)
			{
				GameSplineModel.Instance.ReleaseSpline(this.SplineEntityId, (long)this.ActorComp.CreatureData.GetPbDataId(), EIdType.PbDataId);
			}
			return true;
		}

		// Token: 0x0604727D RID: 291453 RVA: 0x01213444 File Offset: 0x01211644
		private void ReportTrigger()
		{
			if (this.HasReportTriggered)
			{
				return;
			}
			SceneItemTrackGuideComponent.ButterflyTriggerData butterflyTriggerData = new SceneItemTrackGuideComponent.ButterflyTriggerData();
			butterflyTriggerData.event_id = "10";
			butterflyTriggerData.i_inst_id = CreatureModel.Instance.GetInstanceId();
			butterflyTriggerData.i_config_id = this.ActorComp.CreatureData.GetPbDataId().ToString();
			butterflyTriggerData.f_player_pos_x = this.ActorComp.ActorLocationProxy.X.ToString();
			butterflyTriggerData.f_player_pos_y = this.ActorComp.ActorLocationProxy.Y.ToString();
			butterflyTriggerData.f_player_pos_z = this.ActorComp.ActorLocationProxy.Z.ToString();
			butterflyTriggerData.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId.ToString();
			butterflyTriggerData.s_tag = this.ActorComp.CreatureData.GetPlayerId().ToString() + "|" + this.ActorComp.CreatureData.GetCreatureDataId().ToString();
			LogReportController.Instance.LogReport(butterflyTriggerData);
			this.HasReportTriggered = true;
		}

		// Token: 0x0604727E RID: 291454 RVA: 0x01213568 File Offset: 0x01211768
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTrackGuideComponent sceneItemTrackGuideComponent = (SceneItemTrackGuideComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemTrackGuideComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PerformanceComp"))
			{
				if (sceneItemTrackGuideComponent.PerformanceComp == null)
				{
					this.PerformanceComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PerformanceComponent>(this.PerformanceComp), "PerformanceComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (sceneItemTrackGuideComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PropertyComp"))
			{
				if (sceneItemTrackGuideComponent.PropertyComp == null)
				{
					this.PropertyComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemPropertyComponent>(this.PropertyComp), "PropertyComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ReachedEndOfSplineType"))
			{
				this.ReachedEndOfSplineType = sceneItemTrackGuideComponent.ReachedEndOfSplineType;
			}
			if (base.CanResetComponentProperty("SyncComp"))
			{
				if (sceneItemTrackGuideComponent.SyncComp == null)
				{
					this.SyncComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMovementSyncComponent>(this.SyncComp), "SyncComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FoundationId"))
			{
				this.FoundationId = sceneItemTrackGuideComponent.FoundationId;
			}
			if (base.CanResetComponentProperty("FoundationOffset"))
			{
				if (sceneItemTrackGuideComponent.FoundationOffset == null)
				{
					this.FoundationOffset = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.FoundationOffset), "FoundationOffset"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FoundationEntity"))
			{
				if (sceneItemTrackGuideComponent.FoundationEntity == null)
				{
					this.FoundationEntity = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.FoundationEntity), "FoundationEntity"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FoundationLocation"))
			{
				if (sceneItemTrackGuideComponent.FoundationLocation == null)
				{
					this.FoundationLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.FoundationLocation), "FoundationLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PathLine"))
			{
				if (sceneItemTrackGuideComponent.PathLine == null)
				{
					this.PathLine = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USplineComponent>(this.PathLine), "PathLine"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SplineStartLocation"))
			{
				if (sceneItemTrackGuideComponent.SplineStartLocation == null)
				{
					this.SplineStartLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SplineStartLocation), "SplineStartLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SplineEndLocation"))
			{
				if (sceneItemTrackGuideComponent.SplineEndLocation == null)
				{
					this.SplineEndLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SplineEndLocation), "SplineEndLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DistanceAlongSpline"))
			{
				this.DistanceAlongSpline = sceneItemTrackGuideComponent.DistanceAlongSpline;
			}
			if (base.CanResetComponentProperty("TargetPointIndex"))
			{
				this.TargetPointIndex = sceneItemTrackGuideComponent.TargetPointIndex;
			}
			if (base.CanResetComponentProperty("NumSplinePoints"))
			{
				this.NumSplinePoints = sceneItemTrackGuideComponent.NumSplinePoints;
			}
			if (base.CanResetComponentProperty("SplineLength"))
			{
				this.SplineLength = sceneItemTrackGuideComponent.SplineLength;
			}
			if (base.CanResetComponentProperty("DistanceBetweenLastTwoPointsInverse"))
			{
				this.DistanceBetweenLastTwoPointsInverse = sceneItemTrackGuideComponent.DistanceBetweenLastTwoPointsInverse;
			}
			if (base.CanResetComponentProperty("WaitConfig"))
			{
				if (sceneItemTrackGuideComponent.WaitConfig == null)
				{
					this.WaitConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<bool>>(this.WaitConfig), "WaitConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SpeedConfig"))
			{
				if (sceneItemTrackGuideComponent.SpeedConfig == null)
				{
					this.SpeedConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<float>>(this.SpeedConfig), "SpeedConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SplineMoveParam"))
			{
				if (sceneItemTrackGuideComponent.SplineMoveParam == null)
				{
					this.SplineMoveParam = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam>(this.SplineMoveParam), "SplineMoveParam"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NeedCheckWait"))
			{
				this.NeedCheckWait = sceneItemTrackGuideComponent.NeedCheckWait;
			}
			if (base.CanResetComponentProperty("IsInRange"))
			{
				this.IsInRange = sceneItemTrackGuideComponent.IsInRange;
			}
			if (base.CanResetComponentProperty("UpdateState"))
			{
				this.UpdateState = sceneItemTrackGuideComponent.UpdateState;
			}
			if (base.CanResetComponentProperty("HasFinished"))
			{
				this.HasFinished = sceneItemTrackGuideComponent.HasFinished;
			}
			if (base.CanResetComponentProperty("DirectionCache"))
			{
				if (sceneItemTrackGuideComponent.DirectionCache == null)
				{
					this.DirectionCache = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.DirectionCache), "DirectionCache"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PawnSensoryInfo"))
			{
				if (sceneItemTrackGuideComponent.PawnSensoryInfo == null)
				{
					this.PawnSensoryInfo = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnSensoryInfoComponent>(this.PawnSensoryInfo), "PawnSensoryInfo"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("UseCommonEffect"))
			{
				this.UseCommonEffect = sceneItemTrackGuideComponent.UseCommonEffect;
			}
			if (base.CanResetComponentProperty("CommonEffectInit"))
			{
				this.CommonEffectInit = sceneItemTrackGuideComponent.CommonEffectInit;
			}
			if (base.CanResetComponentProperty("HasMoveStart"))
			{
				this.HasMoveStart = sceneItemTrackGuideComponent.HasMoveStart;
			}
			if (base.CanResetComponentProperty("ShouldBeMoving"))
			{
				this.ShouldBeMoving = sceneItemTrackGuideComponent.ShouldBeMoving;
			}
			if (base.CanResetComponentProperty("LastSpeed"))
			{
				this.LastSpeed = sceneItemTrackGuideComponent.LastSpeed;
			}
			if (base.CanResetComponentProperty("OnlineInteractType"))
			{
				this.OnlineInteractType = sceneItemTrackGuideComponent.OnlineInteractType;
			}
			if (base.CanResetComponentProperty("DisableHandle"))
			{
				this.DisableHandle = sceneItemTrackGuideComponent.DisableHandle;
			}
			if (base.CanResetComponentProperty("HasTriggered"))
			{
				this.HasTriggered = sceneItemTrackGuideComponent.HasTriggered;
			}
			if (base.CanResetComponentProperty("HasReportTriggered"))
			{
				this.HasReportTriggered = sceneItemTrackGuideComponent.HasReportTriggered;
			}
			if (base.CanResetComponentProperty("SplineEntityId"))
			{
				this.SplineEntityId = sceneItemTrackGuideComponent.SplineEntityId;
			}
			return true;
		}

		// Token: 0x0402567D RID: 153213
		private const int DISTANCE_SPLINE_FOUNDATION_THRESHOLD = 10000;

		// Token: 0x0402567E RID: 153214
		private const int SPLINE_FOUNDATION_SPEED = 150;

		// Token: 0x0402567F RID: 153215
		private const int DISTANCE_SQUARE_THRESHOLD = 2500;

		// Token: 0x04025680 RID: 153216
		private const int MOVEMENT_SPEED = 600;

		// Token: 0x04025681 RID: 153217
		private const int CONFIG_DEFAULT_MOVEMENT_SPEED = 50;

		// Token: 0x04025682 RID: 153218
		private const int MAX_MOVEMENT_SPEED = 800;

		// Token: 0x04025683 RID: 153219
		private const int NORMAL_RADIUS = 50;

		// Token: 0x04025684 RID: 153220
		private const int COMPRESS_RADIUS = 0;

		// Token: 0x04025685 RID: 153221
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025686 RID: 153222
		private PerformanceComponent PerformanceComp;

		// Token: 0x04025687 RID: 153223
		private SceneItemMoveComponent MoveComp;

		// Token: 0x04025688 RID: 153224
		private SceneItemPropertyComponent PropertyComp;

		// Token: 0x04025689 RID: 153225
		private EFollowTrackEndType? ReachedEndOfSplineType;

		// Token: 0x0402568A RID: 153226
		private SceneItemMovementSyncComponent SyncComp;

		// Token: 0x0402568B RID: 153227
		private int? FoundationId;

		// Token: 0x0402568C RID: 153228
		private global::Vector FoundationOffset;

		// Token: 0x0402568D RID: 153229
		private EntityHandle FoundationEntity;

		// Token: 0x0402568E RID: 153230
		private global::Vector FoundationLocation;

		// Token: 0x0402568F RID: 153231
		private USplineComponent PathLine;

		// Token: 0x04025690 RID: 153232
		private global::Vector SplineStartLocation;

		// Token: 0x04025691 RID: 153233
		private global::Vector SplineEndLocation;

		// Token: 0x04025692 RID: 153234
		private float DistanceAlongSpline;

		// Token: 0x04025693 RID: 153235
		private int TargetPointIndex;

		// Token: 0x04025694 RID: 153236
		private int NumSplinePoints;

		// Token: 0x04025695 RID: 153237
		private float SplineLength;

		// Token: 0x04025696 RID: 153238
		private float DistanceBetweenLastTwoPointsInverse;

		// Token: 0x04025697 RID: 153239
		private List<bool> WaitConfig;

		// Token: 0x04025698 RID: 153240
		private List<float> SpeedConfig;

		// Token: 0x04025699 RID: 153241
		private SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam SplineMoveParam;

		// Token: 0x0402569A RID: 153242
		private bool NeedCheckWait = true;

		// Token: 0x0402569B RID: 153243
		private bool IsInRange;

		// Token: 0x0402569C RID: 153244
		private SceneItemTrackGuideComponent.EUpdateState UpdateState;

		// Token: 0x0402569D RID: 153245
		private bool HasFinished;

		// Token: 0x0402569E RID: 153246
		private global::Vector DirectionCache;

		// Token: 0x0402569F RID: 153247
		private PawnSensoryInfoComponent PawnSensoryInfo;

		// Token: 0x040256A0 RID: 153248
		private bool UseCommonEffect;

		// Token: 0x040256A1 RID: 153249
		private bool CommonEffectInit;

		// Token: 0x040256A2 RID: 153250
		private bool HasMoveStart;

		// Token: 0x040256A3 RID: 153251
		private bool ShouldBeMoving;

		// Token: 0x040256A4 RID: 153252
		private float LastSpeed;

		// Token: 0x040256A5 RID: 153253
		private EOnlineInteractType? OnlineInteractType;

		// Token: 0x040256A6 RID: 153254
		private int? DisableHandle;

		// Token: 0x040256A7 RID: 153255
		private bool HasTriggered;

		// Token: 0x040256A8 RID: 153256
		private bool HasReportTriggered;

		// Token: 0x040256A9 RID: 153257
		private int SplineEntityId;

		// Token: 0x0200CEE5 RID: 52965
		[NullableContext(0)]
		private enum EUpdateState
		{
			// Token: 0x0403E3D9 RID: 254937
			UpdateToSplineStart,
			// Token: 0x0403E3DA RID: 254938
			UpdateToSplineEnd,
			// Token: 0x0403E3DB RID: 254939
			UpdateToFoundation,
			// Token: 0x0403E3DC RID: 254940
			UpdateToStopAtEnd
		}

		// Token: 0x0200CEE6 RID: 52966
		[NullableContext(1)]
		[Nullable(0)]
		private class ButterflyTriggerData : PlayerCommonLogData
		{
			// Token: 0x0403E3DD RID: 254941
			public int i_inst_id;

			// Token: 0x0403E3DE RID: 254942
			public string i_config_id = "";

			// Token: 0x0403E3DF RID: 254943
			public string f_player_pos_x = "";

			// Token: 0x0403E3E0 RID: 254944
			public string f_player_pos_y = "";

			// Token: 0x0403E3E1 RID: 254945
			public string f_player_pos_z = "";

			// Token: 0x0403E3E2 RID: 254946
			public string i_area_id = "";

			// Token: 0x0403E3E3 RID: 254947
			public string s_tag = "";
		}
	}
}

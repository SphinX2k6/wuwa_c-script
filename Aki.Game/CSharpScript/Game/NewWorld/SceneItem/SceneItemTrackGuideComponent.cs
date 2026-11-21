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
	// Token: 0x0200624D RID: 25165
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemTrackGuideComponent : EntityComponent
	{
		// Token: 0x0603CB4F RID: 248655 RVA: 0x0116C6EC File Offset: 0x0116A8EC
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

		// Token: 0x0603CB50 RID: 248656 RVA: 0x0116C8D8 File Offset: 0x0116AAD8
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

		// Token: 0x0603CB51 RID: 248657 RVA: 0x0116C970 File Offset: 0x0116AB70
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

		// Token: 0x0603CB52 RID: 248658 RVA: 0x0116CA08 File Offset: 0x0116AC08
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

		// Token: 0x0603CB53 RID: 248659 RVA: 0x0116CBE5 File Offset: 0x0116ADE5
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

		// Token: 0x0603CB54 RID: 248660 RVA: 0x0116CC24 File Offset: 0x0116AE24
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

		// Token: 0x0603CB55 RID: 248661 RVA: 0x0116CE58 File Offset: 0x0116B058
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

		// Token: 0x0603CB56 RID: 248662 RVA: 0x0116CEB0 File Offset: 0x0116B0B0
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

		// Token: 0x0603CB57 RID: 248663 RVA: 0x0116CF03 File Offset: 0x0116B103
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

		// Token: 0x0603CB58 RID: 248664 RVA: 0x0116CF38 File Offset: 0x0116B138
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

		// Token: 0x0603CB59 RID: 248665 RVA: 0x0116D130 File Offset: 0x0116B330
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

		// Token: 0x0603CB5A RID: 248666 RVA: 0x0116D2B8 File Offset: 0x0116B4B8
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

		// Token: 0x0603CB5B RID: 248667 RVA: 0x0116D3FC File Offset: 0x0116B5FC
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

		// Token: 0x0603CB5C RID: 248668 RVA: 0x0116D4A8 File Offset: 0x0116B6A8
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

		// Token: 0x0603CB5D RID: 248669 RVA: 0x0116D5BC File Offset: 0x0116B7BC
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

		// Token: 0x0603CB5E RID: 248670 RVA: 0x0116D5F4 File Offset: 0x0116B7F4
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

		// Token: 0x0603CB5F RID: 248671 RVA: 0x0116D6AC File Offset: 0x0116B8AC
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

		// Token: 0x0603CB60 RID: 248672 RVA: 0x0116D758 File Offset: 0x0116B958
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

		// Token: 0x0603CB61 RID: 248673 RVA: 0x0116D7FC File Offset: 0x0116B9FC
		[NullableContext(1)]
		private bool CheckIfReach(global::Vector location)
		{
			return this.ActorComp != null && global::Vector.DistSquared(this.ActorComp.ActorLocationProxy, location) <= 2500.0;
		}

		// Token: 0x0603CB62 RID: 248674 RVA: 0x0116D827 File Offset: 0x0116BA27
		private void OnAddCommonEffect()
		{
			this.CommonEffectInit = true;
		}

		// Token: 0x0603CB63 RID: 248675 RVA: 0x0116D830 File Offset: 0x0116BA30
		private void OnEnterLogicRange()
		{
			this.IsInRange = true;
		}

		// Token: 0x0603CB64 RID: 248676 RVA: 0x0116D839 File Offset: 0x0116BA39
		private void OnLeaveLogicRange()
		{
			this.IsInRange = false;
		}

		// Token: 0x0603CB65 RID: 248677 RVA: 0x0116D844 File Offset: 0x0116BA44
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

		// Token: 0x0603CB66 RID: 248678 RVA: 0x0116D91B File Offset: 0x0116BB1B
		private void Reset()
		{
			if (this.HasFinished)
			{
				return;
			}
			this.OnTrackGuideReset();
		}

		// Token: 0x0603CB67 RID: 248679 RVA: 0x0116D92C File Offset: 0x0116BB2C
		protected override bool OnEnd()
		{
			this.RemoveEvents();
			if (this.PathLine != null)
			{
				GameSplineModel.Instance.ReleaseSpline(this.SplineEntityId, (long)this.ActorComp.CreatureData.GetPbDataId(), EIdType.PbDataId);
			}
			return true;
		}

		// Token: 0x0603CB68 RID: 248680 RVA: 0x0116D960 File Offset: 0x0116BB60
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

		// Token: 0x0603CB69 RID: 248681 RVA: 0x0116DA84 File Offset: 0x0116BC84
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTrackGuideComponent sceneItemTrackGuideComponent = (SceneItemTrackGuideComponent)componentTemplate;
			if (sceneItemTrackGuideComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.PerformanceComp == null)
			{
				this.PerformanceComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformanceComp), "PerformanceComp"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.PropertyComp == null)
			{
				this.PropertyComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PropertyComp), "PropertyComp"))
			{
				return false;
			}
			this.ReachedEndOfSplineType = sceneItemTrackGuideComponent.ReachedEndOfSplineType;
			if (sceneItemTrackGuideComponent.SyncComp == null)
			{
				this.SyncComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SyncComp), "SyncComp"))
			{
				return false;
			}
			this.FoundationId = sceneItemTrackGuideComponent.FoundationId;
			if (sceneItemTrackGuideComponent.FoundationOffset == null)
			{
				this.FoundationOffset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FoundationOffset), "FoundationOffset"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.FoundationEntity == null)
			{
				this.FoundationEntity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FoundationEntity), "FoundationEntity"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.FoundationLocation == null)
			{
				this.FoundationLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FoundationLocation), "FoundationLocation"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.PathLine == null)
			{
				this.PathLine = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PathLine), "PathLine"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.SplineStartLocation == null)
			{
				this.SplineStartLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineStartLocation), "SplineStartLocation"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.SplineEndLocation == null)
			{
				this.SplineEndLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineEndLocation), "SplineEndLocation"))
			{
				return false;
			}
			this.DistanceAlongSpline = sceneItemTrackGuideComponent.DistanceAlongSpline;
			this.TargetPointIndex = sceneItemTrackGuideComponent.TargetPointIndex;
			this.NumSplinePoints = sceneItemTrackGuideComponent.NumSplinePoints;
			this.SplineLength = sceneItemTrackGuideComponent.SplineLength;
			this.DistanceBetweenLastTwoPointsInverse = sceneItemTrackGuideComponent.DistanceBetweenLastTwoPointsInverse;
			if (sceneItemTrackGuideComponent.WaitConfig == null)
			{
				this.WaitConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaitConfig), "WaitConfig"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.SpeedConfig == null)
			{
				this.SpeedConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpeedConfig), "SpeedConfig"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.SplineMoveParam == null)
			{
				this.SplineMoveParam = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineMoveParam), "SplineMoveParam"))
			{
				return false;
			}
			this.NeedCheckWait = sceneItemTrackGuideComponent.NeedCheckWait;
			this.IsInRange = sceneItemTrackGuideComponent.IsInRange;
			this.UpdateState = sceneItemTrackGuideComponent.UpdateState;
			this.HasFinished = sceneItemTrackGuideComponent.HasFinished;
			if (sceneItemTrackGuideComponent.DirectionCache == null)
			{
				this.DirectionCache = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DirectionCache), "DirectionCache"))
			{
				return false;
			}
			if (sceneItemTrackGuideComponent.PawnSensoryInfo == null)
			{
				this.PawnSensoryInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PawnSensoryInfo), "PawnSensoryInfo"))
			{
				return false;
			}
			this.UseCommonEffect = sceneItemTrackGuideComponent.UseCommonEffect;
			this.CommonEffectInit = sceneItemTrackGuideComponent.CommonEffectInit;
			this.HasMoveStart = sceneItemTrackGuideComponent.HasMoveStart;
			this.ShouldBeMoving = sceneItemTrackGuideComponent.ShouldBeMoving;
			this.LastSpeed = sceneItemTrackGuideComponent.LastSpeed;
			this.OnlineInteractType = sceneItemTrackGuideComponent.OnlineInteractType;
			this.DisableHandle = sceneItemTrackGuideComponent.DisableHandle;
			this.HasTriggered = sceneItemTrackGuideComponent.HasTriggered;
			this.HasReportTriggered = sceneItemTrackGuideComponent.HasReportTriggered;
			this.SplineEntityId = sceneItemTrackGuideComponent.SplineEntityId;
			return true;
		}

		// Token: 0x170072D8 RID: 29400
		// (get) Token: 0x0603CB6A RID: 248682 RVA: 0x0116DE50 File Offset: 0x0116C050
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D9 RID: 29401
		// (get) Token: 0x0603CB6B RID: 248683 RVA: 0x0116DE53 File Offset: 0x0116C053
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072DA RID: 29402
		// (get) Token: 0x0603CB6C RID: 248684 RVA: 0x0116DE56 File Offset: 0x0116C056
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072DB RID: 29403
		// (get) Token: 0x0603CB6D RID: 248685 RVA: 0x0116DE59 File Offset: 0x0116C059
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202ED RID: 131821
		private const int DISTANCE_SPLINE_FOUNDATION_THRESHOLD = 10000;

		// Token: 0x040202EE RID: 131822
		private const int SPLINE_FOUNDATION_SPEED = 150;

		// Token: 0x040202EF RID: 131823
		private const int DISTANCE_SQUARE_THRESHOLD = 2500;

		// Token: 0x040202F0 RID: 131824
		private const int MOVEMENT_SPEED = 600;

		// Token: 0x040202F1 RID: 131825
		private const int CONFIG_DEFAULT_MOVEMENT_SPEED = 50;

		// Token: 0x040202F2 RID: 131826
		private const int MAX_MOVEMENT_SPEED = 800;

		// Token: 0x040202F3 RID: 131827
		private const int NORMAL_RADIUS = 50;

		// Token: 0x040202F4 RID: 131828
		private const int COMPRESS_RADIUS = 0;

		// Token: 0x040202F5 RID: 131829
		private SceneItemActorComponent ActorComp;

		// Token: 0x040202F6 RID: 131830
		private PerformanceComponent PerformanceComp;

		// Token: 0x040202F7 RID: 131831
		private SceneItemMoveComponent MoveComp;

		// Token: 0x040202F8 RID: 131832
		private SceneItemPropertyComponent PropertyComp;

		// Token: 0x040202F9 RID: 131833
		private EFollowTrackEndType? ReachedEndOfSplineType;

		// Token: 0x040202FA RID: 131834
		private SceneItemMovementSyncComponent SyncComp;

		// Token: 0x040202FB RID: 131835
		private int? FoundationId;

		// Token: 0x040202FC RID: 131836
		private global::Vector FoundationOffset;

		// Token: 0x040202FD RID: 131837
		private EntityHandle FoundationEntity;

		// Token: 0x040202FE RID: 131838
		private global::Vector FoundationLocation;

		// Token: 0x040202FF RID: 131839
		private USplineComponent PathLine;

		// Token: 0x04020300 RID: 131840
		private global::Vector SplineStartLocation;

		// Token: 0x04020301 RID: 131841
		private global::Vector SplineEndLocation;

		// Token: 0x04020302 RID: 131842
		private float DistanceAlongSpline;

		// Token: 0x04020303 RID: 131843
		private int TargetPointIndex;

		// Token: 0x04020304 RID: 131844
		private int NumSplinePoints;

		// Token: 0x04020305 RID: 131845
		private float SplineLength;

		// Token: 0x04020306 RID: 131846
		private float DistanceBetweenLastTwoPointsInverse;

		// Token: 0x04020307 RID: 131847
		private List<bool> WaitConfig;

		// Token: 0x04020308 RID: 131848
		private List<float> SpeedConfig;

		// Token: 0x04020309 RID: 131849
		private SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam SplineMoveParam;

		// Token: 0x0402030A RID: 131850
		private bool NeedCheckWait = true;

		// Token: 0x0402030B RID: 131851
		private bool IsInRange;

		// Token: 0x0402030C RID: 131852
		private SceneItemTrackGuideComponent.EUpdateState UpdateState;

		// Token: 0x0402030D RID: 131853
		private bool HasFinished;

		// Token: 0x0402030E RID: 131854
		private global::Vector DirectionCache;

		// Token: 0x0402030F RID: 131855
		private PawnSensoryInfoComponent PawnSensoryInfo;

		// Token: 0x04020310 RID: 131856
		private bool UseCommonEffect;

		// Token: 0x04020311 RID: 131857
		private bool CommonEffectInit;

		// Token: 0x04020312 RID: 131858
		private bool HasMoveStart;

		// Token: 0x04020313 RID: 131859
		private bool ShouldBeMoving;

		// Token: 0x04020314 RID: 131860
		private float LastSpeed;

		// Token: 0x04020315 RID: 131861
		private EOnlineInteractType? OnlineInteractType;

		// Token: 0x04020316 RID: 131862
		private int? DisableHandle;

		// Token: 0x04020317 RID: 131863
		private bool HasTriggered;

		// Token: 0x04020318 RID: 131864
		private bool HasReportTriggered;

		// Token: 0x04020319 RID: 131865
		private int SplineEntityId;

		// Token: 0x0200BA7B RID: 47739
		[NullableContext(0)]
		private enum EUpdateState
		{
			// Token: 0x040396FF RID: 235263
			UpdateToSplineStart,
			// Token: 0x04039700 RID: 235264
			UpdateToSplineEnd,
			// Token: 0x04039701 RID: 235265
			UpdateToFoundation,
			// Token: 0x04039702 RID: 235266
			UpdateToStopAtEnd
		}

		// Token: 0x0200BA7C RID: 47740
		[NullableContext(1)]
		[Nullable(0)]
		private class ButterflyTriggerData : PlayerCommonLogData
		{
			// Token: 0x04039703 RID: 235267
			public int i_inst_id;

			// Token: 0x04039704 RID: 235268
			public string i_config_id = "";

			// Token: 0x04039705 RID: 235269
			public string f_player_pos_x = "";

			// Token: 0x04039706 RID: 235270
			public string f_player_pos_y = "";

			// Token: 0x04039707 RID: 235271
			public string f_player_pos_z = "";

			// Token: 0x04039708 RID: 235272
			public string i_area_id = "";

			// Token: 0x04039709 RID: 235273
			public string s_tag = "";
		}
	}
}

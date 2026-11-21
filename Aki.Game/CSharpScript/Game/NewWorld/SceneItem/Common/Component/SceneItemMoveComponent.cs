using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;
using CSharpScript.Game.Module.Movement.Model;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062D4 RID: 25300
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemMoveComponent : EntityComponent
	{
		// Token: 0x170073B1 RID: 29617
		// (get) Token: 0x0603D199 RID: 250265 RVA: 0x01196C05 File Offset: 0x01194E05
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(SceneItemActorComponent),
					typeof(CreatureDataComponent)
				};
			}
		}

		// Token: 0x170073B2 RID: 29618
		// (get) Token: 0x0603D19A RID: 250266 RVA: 0x01196C27 File Offset: 0x01194E27
		public bool IsMovingPrepareCompleted
		{
			get
			{
				return this.IsMovingPrepareCompletedInternal;
			}
		}

		// Token: 0x170073B3 RID: 29619
		// (get) Token: 0x0603D19B RID: 250267 RVA: 0x01196C30 File Offset: 0x01194E30
		public bool IsMoving
		{
			get
			{
				if (Info.Instance.EnableForceTick)
				{
					return this.MoveTargetList.Count > 0 || this.CurState == SceneItemMoveComponent.ERunningState.RUN;
				}
				if (!this.IsMovingPrepareCompleted)
				{
					return this.MoveTargetList.Count > 0;
				}
				return this.MoveComponent.IsMoving(false);
			}
		}

		// Token: 0x170073B4 RID: 29620
		// (get) Token: 0x0603D19C RID: 250268 RVA: 0x01196C86 File Offset: 0x01194E86
		// (set) Token: 0x0603D19D RID: 250269 RVA: 0x01196C8E File Offset: 0x01194E8E
		public bool ForceSyncing
		{
			get
			{
				return this.ForceSyncingInternal;
			}
			set
			{
				this.ForceSyncingInternal = value;
				if (this.ForceSyncingInternal)
				{
					SceneItemMovementSyncComponent syncComp = this.SyncComp;
					if (syncComp == null)
					{
						return;
					}
					syncComp.SetEnableMovementSync(true, "SceneItemMoveComponent ForceSyncing");
				}
			}
		}

		// Token: 0x0603D19E RID: 250270 RVA: 0x01196CB5 File Offset: 0x01194EB5
		public bool IsSplineMoving()
		{
			if (!this.IsMovingPrepareCompleted)
			{
				return false;
			}
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			return moveComponent != null && moveComponent.IsValid() && this.MoveComponent.GetSplineRunState() > ESplineRunState.None;
		}

		// Token: 0x0603D19F RID: 250271 RVA: 0x01196CE5 File Offset: 0x01194EE5
		public float GetDistanceAloneSpline()
		{
			if (!this.IsMovingPrepareCompleted)
			{
				return 0f;
			}
			return this.MoveComponent.GetDistanceAlongSpline();
		}

		// Token: 0x0603D1A0 RID: 250272 RVA: 0x01196D00 File Offset: 0x01194F00
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0603D1A1 RID: 250273 RVA: 0x01196D14 File Offset: 0x01194F14
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.SyncComp = base.Entity.GetComponent<SceneItemMovementSyncComponent>();
			this.PropertyComp = base.Entity.GetComponent<SceneItemPropertyComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.UeTickComponent = base.Entity.GetComponent<UeSceneItemMoveTickManagerComponent>();
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.SetEnableMovementSync(false, "SceneItemMoveComponent OnStart");
			}
			if (this.CreatureDataComp == null)
			{
				return true;
			}
			if (this.CreatureDataComp.GetPbEntityInitData() == null)
			{
				return true;
			}
			if (base.Entity.GameBudgetConfig.GroupName == FNameUtil.GetDynamicFName("MoveSceneItemEntity"))
			{
				this.NeedTickOutside = true;
			}
			if (!Info.Instance.EnableForceTick)
			{
				this.MoveComponent = (this.ActorComp.Owner.GetComponentByClass(UKuroSceneItemMoveComponent.StaticClass()) as UKuroSceneItemMoveComponent);
				UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
				if (moveComponent == null || !moveComponent.IsValid())
				{
					AActor owner = this.ActorComp.Owner;
					TSubclassOf<UActorComponent> @class = UKuroSceneItemMoveComponent.StaticClass();
					bool bManualAttachment = false;
					FTransform ftransform = new FTransform();
					this.MoveComponent = (owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroSceneItemMoveComponent);
				}
				this.MoveComponent.Kuro_SetGravityDirect(this.ActorComp.ActorGravityDirectProxy.ToUeVectorOld());
				this.MoveComponent.SetTickingMoveEnable(false);
				this.AddUeArrivePointCallback(new Action<int>(this.OnUeArrivePointCallback));
				this.AddUeMoveStopCallback(new Action(this.OnUeMoveStopCallback));
				if (this.NeedTickOutside)
				{
					this.MoveComponent.SetKuroOnlyTickOutside(true);
				}
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(base.Entity.Id);
				if (entityById != null && !EventSystem.Instance.HasWithTarget(entityById, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveSelfEntity)))
				{
					EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, entityById, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveSelfEntity));
				}
				if (AvoidanceModel.Instance.UseRVOAvoidance)
				{
					UKuroSceneItemMoveComponent moveComponent2 = this.MoveComponent;
					FNavAvoidanceMask fnavAvoidanceMask = AvoidanceModel.Instance.SceneItemAvoidanceGroupMask;
					moveComponent2.SetAvoidanceGroupMask(fnavAvoidanceMask);
					UKuroSceneItemMoveComponent moveComponent3 = this.MoveComponent;
					fnavAvoidanceMask = AvoidanceModel.Instance.SceneItemGroupsToAvoidMask;
					moveComponent3.SetGroupsToAvoidMask(fnavAvoidanceMask);
					this.MoveComponent.AvoidanceRadius = AvoidanceModel.Instance.SceneItemAvoidanceRadius;
					this.MoveComponent.SetAvoidanceEnabled(true);
				}
			}
			return true;
		}

		// Token: 0x0603D1A2 RID: 250274 RVA: 0x01196F7C File Offset: 0x0119517C
		protected override bool OnEnd()
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent != null && moveComponent.IsValid())
			{
				this.RemoveUeArrivePointCallback(new Action<int>(this.OnUeArrivePointCallback));
				this.RemoveUeMoveStopCallback(new Action(this.OnUeMoveStopCallback));
			}
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			this.ResetTrackMode();
			return true;
		}

		// Token: 0x0603D1A3 RID: 250275 RVA: 0x01196FD4 File Offset: 0x011951D4
		protected override void OnActivate()
		{
			if (!Info.Instance.EnableForceTick && this.MoveTargetList.Count > 0)
			{
				foreach (SceneItemMoveComponent.MoveTarget moveTarget in this.MoveTargetList)
				{
					this.MoveComponent.AddMoveTarget(new FVectorDouble(moveTarget.TargetPosData.X, moveTarget.TargetPosData.Y, moveTarget.TargetPosData.Z), moveTarget.MoveTime, moveTarget.StayTime, -1f, -1f);
				}
				this.MoveMode = SceneItemMoveComponent.EMoveMode.Simple;
				this.MoveTargetList.Clear();
				this.MoveComponent.SetTickingMoveEnable(true);
				this.PropertyComp.IsMoving = true;
			}
			this.IsMovingPrepareCompletedInternal = true;
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			int? num = (creatureDataComp != null) ? new int?(creatureDataComp.PbMoveSplineId) : null;
			if (num != null && num.GetValueOrDefault() != 0)
			{
				this.OnRecvSyncSplineMoving(this.CreatureDataComp.PbMoveSplineId, this.CreatureDataComp.PbMoveSplineConfig, this.CreatureDataComp.PbMoveSplineSceneItemRuntimeData);
			}
		}

		// Token: 0x0603D1A4 RID: 250276 RVA: 0x01197114 File Offset: 0x01195314
		private bool CheckReachTarget()
		{
			return global::Vector.DistSquared(this.StartLocation, this.CurLocation) >= (double)this.MaxDist;
		}

		// Token: 0x0603D1A5 RID: 250277 RVA: 0x01197134 File Offset: 0x01195334
		protected override void OnTick(float delta)
		{
			if (this.NeedTickOutside)
			{
				UeSceneItemMoveTickManagerComponent ueTickComponent = this.UeTickComponent;
				if (ueTickComponent != null)
				{
					ueTickComponent.TickMovement(delta, false);
				}
			}
			if (this.PropertyComp.IsMoving)
			{
				if (!this.IsMoving)
				{
					this.PropertyComp.IsMoving = false;
				}
				else if (this.MoveComponent.GetSimpleRunState() == ESimpleRunState.Wait)
				{
					this.PropertyComp.IsMoving = false;
				}
			}
			else if (this.IsMoving && this.MoveComponent.GetSimpleRunState() == ESimpleRunState.Run)
			{
				this.PropertyComp.IsMoving = true;
			}
			if (this.IsSyncing && !this.IsMoving && !this.ForceSyncing)
			{
				this.IsSyncing = false;
				SceneItemMovementSyncComponent syncComp = this.SyncComp;
				if (syncComp != null && syncComp.GetEnableMovementSync())
				{
					SceneItemMovementSyncComponent syncComp2 = this.SyncComp;
					if (syncComp2 == null)
					{
						return;
					}
					syncComp2.SetEnableMovementSync(false, "SceneItemMoveComponent MoveStop");
				}
			}
		}

		// Token: 0x0603D1A6 RID: 250278 RVA: 0x01197208 File Offset: 0x01195408
		protected override void OnForceTick(float delta)
		{
			base.OnTick(delta);
			if (this.CurState == SceneItemMoveComponent.ERunningState.RUN)
			{
				this.Velocity.Addition(this.ActorComp.ActorLocationProxy, this.CurLocation);
				if (this.CheckReachTarget())
				{
					this.ActorComp.SetActorLocation(this.TargetLocation.ToUeVector(false), "unknown", true);
					this.CurState = SceneItemMoveComponent.ERunningState.STOP;
					return;
				}
				this.ActorComp.SetActorLocation(this.CurLocation.ToUeVector(false), "unknown", true);
				return;
			}
			else
			{
				if (this.MoveTargetList == null || this.MoveTargetList.Count == 0)
				{
					return;
				}
				SceneItemMoveComponent.MoveTarget moveTarget = this.MoveTargetList[0];
				this.MoveTargetList.RemoveAt(0);
				this.TargetLocation = global::Vector.Create(moveTarget.TargetPosData.X, moveTarget.TargetPosData.Y, moveTarget.TargetPosData.Z);
				if ((double)moveTarget.MoveTime <= 0.0001)
				{
					this.ActorComp.SetActorLocation(this.TargetLocation.ToUeVector(false), "unknown", true);
					return;
				}
				this.StartLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
				this.MaxDist = (float)global::Vector.DistSquared(this.StartLocation, this.TargetLocation);
				global::Vector vector = global::Vector.Create();
				this.TargetLocation.Subtraction(this.StartLocation, vector);
				vector.Division((double)(moveTarget.MoveTime * (float)TimeUtil.Instance.InverseMillisecond / delta), vector);
				this.Velocity = vector;
				this.CurState = SceneItemMoveComponent.ERunningState.RUN;
				return;
			}
		}

		// Token: 0x0603D1A7 RID: 250279 RVA: 0x0119738C File Offset: 0x0119558C
		private unsafe void OnRemoveSelfEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent != null && moveComponent.IsValid() && this.MoveComponent.IsMoving(true))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "当前SceneItem移动时被删除，保底停止移动";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.StopMove(true, true);
			}
		}

		// Token: 0x0603D1A8 RID: 250280 RVA: 0x01197450 File Offset: 0x01195650
		public void AddSimpleRotation(AActor actor, global::Rotator beginRotator, global::Rotator endRotator, float time)
		{
			this.MoveComponent.InitRotationData(actor, false);
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			FRotator frotator = beginRotator.ToUeRotator();
			FRotator frotator2 = endRotator.ToUeRotator();
			moveComponent.AddRotationStep(frotator, frotator2, time, 0f, null);
			this.MoveComponent.StartRotate();
		}

		// Token: 0x0603D1A9 RID: 250281 RVA: 0x011974A0 File Offset: 0x011956A0
		private unsafe void AddMoveTargetInternal(SceneItemMoveComponent.MoveTarget target)
		{
			if (Info.Instance.EnableForceTick)
			{
				this.MoveTargetList.Add(target);
			}
			else if (!this.IsMovingPrepareCompleted)
			{
				this.MoveTargetList.Add(target);
			}
			else
			{
				global::Vector vector = global::Vector.Create(target.TargetPosData.X, target.TargetPosData.Y, target.TargetPosData.Z);
				this.MoveComponent.AddMoveTarget(vector.ToUeVector(false), target.MoveTime, target.StayTime, target.MaxSpeed, target.Acceleration);
				this.MoveMode = SceneItemMoveComponent.EMoveMode.Simple;
				this.MoveComponent.SetTickingMoveEnable(true);
				double num = global::Vector.Dist(vector, this.ActorComp.ActorLocationProxy);
				if (this.MoveComponent.GetSimpleRunState() == ESimpleRunState.Stop && num > 100.0)
				{
					this.PropertyComp.IsMoving = true;
				}
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加路径点";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("moveTargetX", target.TargetPosData.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("moveTargetY", target.TargetPosData.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("moveTargetZ", target.TargetPosData.Z);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Time", target.MoveTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0603D1AA RID: 250282 RVA: 0x01197638 File Offset: 0x01195838
		public void AddMoveTarget(object targetData)
		{
			if (this.InPotral)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CH;
				string message = "当前SceneItem正在巡逻中,不可再添加目标点";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SceneItemMoveComponent.MoveTarget moveTarget = targetData as SceneItemMoveComponent.MoveTarget;
			SceneItemMoveComponent.MoveTarget target;
			if (moveTarget != null)
			{
				target = moveTarget;
			}
			else
			{
				IMoveToPoint moveToPoint = targetData as IMoveToPoint;
				ISceneItemMoveMotionType moveMotion = moveToPoint.MoveMotion;
				float num;
				if (moveMotion == null || moveMotion.Type != EMoveMotion.VariableMotion)
				{
					IUniformMotion uniformMotion = moveToPoint.MoveMotion as IUniformMotion;
					num = ((uniformMotion != null) ? uniformMotion.Time : 0f);
				}
				else
				{
					num = -1f;
				}
				float moveTime = num;
				target = new SceneItemMoveComponent.MoveTarget(moveToPoint.Point, moveTime, 0f, -1f, -1f);
			}
			this.AddMoveTargetInternal(target);
			if (GameModeModel.Instance.IsMulti)
			{
				this.RequestMoveToTarget(target);
			}
		}

		// Token: 0x0603D1AB RID: 250283 RVA: 0x01197728 File Offset: 0x01195928
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"HasTarget",
			"Target",
			"Velocity"
		})]
		public unsafe ValueTuple<bool, FVectorDouble, FVectorDouble> GetNextTarget()
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsValid())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CH;
				string message = "SceneItemMoveComponent不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsEntityInit", base.Entity.IsInit);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return new ValueTuple<bool, FVectorDouble, FVectorDouble>(false, new FVectorDouble(), new FVectorDouble());
			}
			FVectorDouble item2 = new FVectorDouble();
			FVectorDouble item3 = new FVectorDouble();
			return new ValueTuple<bool, FVectorDouble, FVectorDouble>(this.MoveComponent.GetNextMoveTarget(ref item2, ref item3), item2, item3);
		}

		// Token: 0x0603D1AC RID: 250284 RVA: 0x0119780C File Offset: 0x01195A0C
		public void RequestMoveToTarget(SceneItemMoveComponent.MoveTarget target)
		{
			SceneItemMoveTargetRequest sceneItemMoveTargetRequest = SceneItemMoveTargetRequest.Create();
			sceneItemMoveTargetRequest.MoveInfo = SceneItemMoveTargetInfo.Create();
			sceneItemMoveTargetRequest.MoveInfo.EntityId = this.ActorComp.CreatureData.GetCreatureDataId();
			sceneItemMoveTargetRequest.MoveInfo.Location = new Aki.Protocol.Vector
			{
				X = (float)target.TargetPosData.X,
				Y = (float)target.TargetPosData.Y,
				Z = (float)target.TargetPosData.Z
			};
			sceneItemMoveTargetRequest.MoveInfo.MoveTime = target.MoveTime;
			sceneItemMoveTargetRequest.MoveInfo.StayTime = target.StayTime;
			sceneItemMoveTargetRequest.MoveInfo.MaxSpeed = target.MaxSpeed;
			sceneItemMoveTargetRequest.MoveInfo.Acceleration = target.Acceleration;
			Net.Instance.Call(ERequestMessageId.SceneItemMoveTargetRequest, sceneItemMoveTargetRequest, null, 0);
		}

		// Token: 0x0603D1AD RID: 250285 RVA: 0x011978E4 File Offset: 0x01195AE4
		public void HandleMoveToTarget(SceneItemMoveTargetNotify notify)
		{
			SceneItemMoveComponent.MoveTarget target = new SceneItemMoveComponent.MoveTarget(new global::Vector
			{
				X = (double)notify.MoveInfo.Location.X,
				Y = (double)notify.MoveInfo.Location.Y,
				Z = (double)notify.MoveInfo.Location.Z
			}, notify.MoveInfo.MoveTime, notify.MoveInfo.StayTime, notify.MoveInfo.MaxSpeed, notify.MoveInfo.Acceleration);
			this.AddMoveTargetInternal(target);
		}

		// Token: 0x0603D1AE RID: 250286 RVA: 0x01197974 File Offset: 0x01195B74
		public unsafe bool StartTrackPlayer(float moveSpeed, FRotator initRotatorOffset, float angleSpeed)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return false;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
			if (tsBaseCharacter == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "SceneItemMoveComponent 追踪当前角色失败，当前角色Actor无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (!this.StartTrackMoveInternal(tsBaseCharacter, moveSpeed, initRotatorOffset, angleSpeed))
			{
				return false;
			}
			this.TrackMode = SceneItemMoveComponent.ETrackMode.Player;
			if (!EventSystem.Instance.Has<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole)))
			{
				EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			}
			return true;
		}

		// Token: 0x0603D1AF RID: 250287 RVA: 0x01197A94 File Offset: 0x01195C94
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			if (this.TrackMode == SceneItemMoveComponent.ETrackMode.Player)
			{
				CharacterActorComponent component = newEntity.Entity.GetComponent<CharacterActorComponent>();
				TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
				if (tsBaseCharacter != null)
				{
					this.SwitchTrackTargetInternal(tsBaseCharacter);
				}
			}
		}

		// Token: 0x0603D1B0 RID: 250288 RVA: 0x01197ACD File Offset: 0x01195CCD
		private void ResetTrackMode()
		{
			if (this.TrackMode == SceneItemMoveComponent.ETrackMode.Player)
			{
				EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
				this.TrackMode = SceneItemMoveComponent.ETrackMode.None;
			}
		}

		// Token: 0x0603D1B1 RID: 250289 RVA: 0x01197AFC File Offset: 0x01195CFC
		private unsafe bool StartTrackMoveInternal(AActor targetActor, float moveSpeed, FRotator initRotatorOffset, float angleSpeed)
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsValid())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "SceneItemMoveComponent 追踪移动开始失败，MoveComponent不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (!targetActor.IsValid())
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.LYY;
				string message2 = "SceneItemMoveComponent 追踪移动开始失败，目标Actor无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			if (!this.MoveComponent.StartTrackMove(targetActor, moveSpeed, initRotatorOffset, angleSpeed))
			{
				return false;
			}
			this.MoveMode = SceneItemMoveComponent.EMoveMode.Track;
			this.PropertyComp.IsMoving = true;
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.SceneItem;
			ELogAuthor author3 = ELogAuthor.LYY;
			string message3 = "SceneItemMoveComponent 追踪移动开始";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
			string item3 = "PbDataId";
			CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
			ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return true;
		}

		// Token: 0x0603D1B2 RID: 250290 RVA: 0x01197CEC File Offset: 0x01195EEC
		private unsafe bool SwitchTrackTargetInternal(AActor newTargetActor)
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsValid())
			{
				return false;
			}
			if (newTargetActor == null || !newTargetActor.IsValid())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "SceneItemMoveComponent 切换追踪目标失败，目标Actor无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return this.MoveComponent.SwitchTrackTarget(newTargetActor);
		}

		// Token: 0x0603D1B3 RID: 250291 RVA: 0x01197DBC File Offset: 0x01195FBC
		public void StartSplineMoveTask(ISceneItemSplineMoveTaskParam param)
		{
			if (this.GetCurSplineMoveTask() != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "SceneItemMoveComponent 样条移动任务未结束时开始新任务，清除旧任务";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				SplineMoveTaskController.Instance.EndEntityTasks((long)base.Entity.Id);
			}
			SceneItemSplineMoveTask.Create(CreatureModel.Instance.GetEntityById(base.Entity.Id), param).StartTask();
		}

		// Token: 0x0603D1B4 RID: 250292 RVA: 0x01197E40 File Offset: 0x01196040
		public void SwitchSplineMoveTask(ISceneItemSplineMoveTaskParam newParam)
		{
			SceneItemSplineMoveTask curSplineMoveTask = this.GetCurSplineMoveTask();
			bool flag = curSplineMoveTask != null && curSplineMoveTask.IsEnableSplineMoveSync;
			bool flag2 = newParam != null && newParam.EnableSplineMoveSync;
			if (flag && flag2)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SceneItemMoveComponent.SwitchSplineMoveTask] 切换样条移动,新旧task都需要走样条协议同步，将使用Switch协议切换样条移动";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				curSplineMoveTask.MarkSuppressSplineMoveSyncOnEnd();
				curSplineMoveTask.EndTask(false);
				this.StartSplineMoveTask(new SceneItemSplineMoveTaskParam
				{
					SplineId = newParam.SplineId,
					SplineMoveConfig = newParam.SplineMoveConfig,
					EnableSplineMoveSync = newParam.EnableSplineMoveSync,
					EnableMovementSync = newParam.EnableMovementSync,
					NeedMoveToStartPoint = newParam.NeedMoveToStartPoint,
					SplineMoveRuntimeData = newParam.SplineMoveRuntimeData,
					Callback = newParam.Callback,
					Context = newParam.Context,
					UseSplineMoveSyncSwitchOnStart = new bool?(true)
				});
				return;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.SceneItem;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "[SceneItemMoveComponent.SwitchSplineMoveTask] 切换样条移动,新旧task至少有一个不走样条协议同步，将使用Stop+Start的方式切换样条移动";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			if (curSplineMoveTask != null)
			{
				curSplineMoveTask.EndTask(false);
			}
			this.StartSplineMoveTask(new SceneItemSplineMoveTaskParam
			{
				SplineId = newParam.SplineId,
				SplineMoveConfig = newParam.SplineMoveConfig,
				EnableSplineMoveSync = newParam.EnableSplineMoveSync,
				EnableMovementSync = newParam.EnableMovementSync,
				NeedMoveToStartPoint = newParam.NeedMoveToStartPoint,
				SplineMoveRuntimeData = newParam.SplineMoveRuntimeData,
				Callback = newParam.Callback,
				Context = newParam.Context,
				UseSplineMoveSyncSwitchOnStart = new bool?(false)
			});
		}

		// Token: 0x0603D1B5 RID: 250293 RVA: 0x01197FE8 File Offset: 0x011961E8
		[NullableContext(2)]
		public SceneItemSplineMoveTask GetCurSplineMoveTask()
		{
			SplineMoveTaskBase entityCurSplineMoveTask = SplineMoveTaskController.Instance.GetEntityCurSplineMoveTask((long)base.Entity.Id);
			if (entityCurSplineMoveTask == null)
			{
				return null;
			}
			return entityCurSplineMoveTask as SceneItemSplineMoveTask;
		}

		// Token: 0x0603D1B6 RID: 250294 RVA: 0x01198018 File Offset: 0x01196218
		public unsafe bool StartSplineMoveAtConstantTimeImplement(SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam param, [Nullable(2)] Action potralEndCallback = null, bool enableMovementSync = true)
		{
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			if (creatureDataComp != null && creatureDataComp.GetRemoveState())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "SceneItemMoveComponent 样条移动(ConstantTime)开始失败，Entity已删除";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataComp.GetPbDataId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (!this.MoveComponent.StartMoveWithSplineAtConstantTime(param.Spline, param.IsRepeat, param.IsCycle, param.IsKeepLookAt, param.TimeSec, param.TimeDisCurve, param.StartTimeOffset, param.StartDis, param.EndDis))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "SceneItemMoveComponent 样条移动(ConstantTime)开始失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			this.InPotral = true;
			this.IsSyncing = enableMovementSync;
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.SetEnableMovementSync(enableMovementSync, "SceneItemMoveComponent StartPatrolAtConstantTime");
			}
			this.MoveMode = SceneItemMoveComponent.EMoveMode.Spline;
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.移动机关.样条移动.移动中"]));
			}
			if (potralEndCallback != null)
			{
				Action callback = null;
				callback = delegate()
				{
					this.RemoveStopMoveCallback(callback);
					potralEndCallback();
				};
				this.AddStopMoveCallback(callback);
			}
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.SceneItem;
			ELogAuthor author3 = ELogAuthor.ZYL;
			string message3 = "SceneItemMoveComponent 样条移动(ConstantTime)开始";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
			ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveStarted, base.Entity);
			return true;
		}

		// Token: 0x0603D1B7 RID: 250295 RVA: 0x011982B0 File Offset: 0x011964B0
		public unsafe bool StartSplineMoveAtDynamicSpeedImplement(SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedParam param, [Nullable(2)] Action potralEndCallback = null, bool enableMovementSync = true)
		{
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			if (creatureDataComp != null && creatureDataComp.GetRemoveState())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "SceneItemMoveComponent 样条移动(DynamicSpeed)开始失败，Entity已删除";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataComp.GetPbDataId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (!this.MoveComponent.StartMoveWithSplineAtDynamicSpeed(param.Spline, param.MaxMoveTimes, param.IsCycle, param.IsKeepLookAt, param.InitSpeed, param.Acceleration, param.TargetSpeed, param.StartDis, param.EndDis))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "SceneItemMoveComponent 样条移动(DynamicSpeed)开始失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			this.InPotral = true;
			this.IsSyncing = enableMovementSync;
			SceneItemMovementSyncComponent syncComp = this.SyncComp;
			if (syncComp != null)
			{
				syncComp.SetEnableMovementSync(enableMovementSync, "SceneItemMoveComponent StartPatrolAtDynamicSpeed");
			}
			this.MoveMode = SceneItemMoveComponent.EMoveMode.Spline;
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.移动机关.样条移动.移动中"]));
			}
			if (potralEndCallback != null)
			{
				Action callback = null;
				callback = delegate()
				{
					this.RemoveStopMoveCallback(callback);
					potralEndCallback();
				};
				this.AddStopMoveCallback(callback);
			}
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.SceneItem;
			ELogAuthor author3 = ELogAuthor.ZYL;
			string message3 = "SceneItemMoveComponent 样条移动(DynamicSpeed)开始";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
			ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveStarted, base.Entity);
			return true;
		}

		// Token: 0x0603D1B8 RID: 250296 RVA: 0x01198548 File Offset: 0x01196748
		public unsafe bool UpdatePatrolAtDynamicSpeedEditableParam(SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam param)
		{
			if (!this.IsSplineMoving() || this.MoveComponent == null)
			{
				return false;
			}
			FSplineMoveDynamicSpeedData dynamicSpeedData = this.MoveComponent.SplineMoveData.DynamicSpeedData;
			float currentSpeed = param.CurrentSpeed ?? dynamicSpeedData.CurrentSpeed;
			float acceleration = param.Acceleration ?? dynamicSpeedData.Acceleration;
			float targetSpeed = param.TargetSpeed ?? dynamicSpeedData.TargetSpeed;
			bool flag = this.MoveComponent.UpdateDynamicSpeedSplineMoveParams(currentSpeed, acceleration, targetSpeed);
			if (!flag)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "SceneItemMoveComponent 更新样条移动动态参数失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			SundryModel.Instance.GetModuleDebugLevel("SCENEITEM_MOVE_DEBUG");
			return flag;
		}

		// Token: 0x0603D1B9 RID: 250297 RVA: 0x0119868C File Offset: 0x0119688C
		public bool UpdateSplineMoveDistance(float newDisAlongPath)
		{
			return this.IsSplineMoving() && this.MoveComponent != null && this.MoveComponent.UpdateSplineMoveDistance(newDisAlongPath);
		}

		// Token: 0x0603D1BA RID: 250298 RVA: 0x011986AC File Offset: 0x011968AC
		public bool UpdateSplineMoveDistanceByPos(global::Vector newPos)
		{
			return this.IsSplineMoving() && this.MoveComponent != null && this.MoveComponent.UpdateSplineMoveDistanceByPosition(newPos.ToUeVector(false));
		}

		// Token: 0x0603D1BB RID: 250299 RVA: 0x011986D4 File Offset: 0x011968D4
		public unsafe bool UpdateSplineMoveDistanceByRuntimeData(SceneItemSplineMoveRuntimeData splineMoveRuntimeData, float tolerance = 100f)
		{
			if (!this.IsSplineMoving() || this.MoveComponent == null)
			{
				return false;
			}
			if (splineMoveRuntimeData.DistanceAloneSpline != null)
			{
				float? distanceAloneSpline = splineMoveRuntimeData.DistanceAloneSpline;
				float num = 0f;
				if (distanceAloneSpline.GetValueOrDefault() >= num & distanceAloneSpline != null)
				{
					if (!SceneItemSplineMoveTaskUtils.CheckSplineMoveDistanceNearlyEqual((double)splineMoveRuntimeData.DistanceAloneSpline.Value, (double)this.MoveComponent.GetDistanceAlongSpline(), (double)tolerance))
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.SceneItem;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "[SceneItemMoveComponent.UpdateSplineMoveDistanceByRuntimeData] 更新样条移动进度";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
						string item = "PbDataId";
						CreatureDataComponent creatureDataComp = this.CreatureDataComp;
						ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OldDistanceAlongSpline", this.MoveComponent.GetDistanceAlongSpline());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("NewDistanceAlongSpline", splineMoveRuntimeData.DistanceAloneSpline);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
						this.UpdateSplineMoveDistance(splineMoveRuntimeData.DistanceAloneSpline.Value);
						return true;
					}
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[SceneItemMoveComponent.UpdateSplineMoveDistanceByRuntimeData] 样条移动进度相差过小，不更新";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item2 = "PbDataId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("OldDistanceAlongSpline", this.MoveComponent.GetDistanceAlongSpline());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("NewDistanceAlongSpline", splineMoveRuntimeData.DistanceAloneSpline);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
					return false;
				}
			}
			if (splineMoveRuntimeData.CurPos != null)
			{
				if (!SceneItemSplineMoveTaskUtils.CheckSplineMoveLocationNearlyEqual(this.ActorComp.ActorLocationProxy, splineMoveRuntimeData.CurPos, (double)tolerance))
				{
					global::Log instance3 = global::Log.Instance;
					ELogModule module3 = ELogModule.SceneItem;
					ELogAuthor author3 = ELogAuthor.ZYL;
					string message3 = "[SceneItemMoveComponent.UpdateSplineMoveDistanceByRuntimeData] 更新样条移动进度";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
					string item3 = "PbDataId";
					CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
					ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("OldPos", this.ActorComp.ActorLocationProxy);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("NewPos", splineMoveRuntimeData.CurPos);
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
					this.UpdateSplineMoveDistanceByPos(splineMoveRuntimeData.CurPos);
					return true;
				}
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[SceneItemMoveComponent.UpdateSplineMoveDistanceByRuntimeData] 样条移动进度相差过小，不更新";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1);
				string item4 = "PbDataId";
				CreatureDataComponent creatureDataComp4 = this.CreatureDataComp;
				ptr4 = new ValueTuple<string, object>(item4, (creatureDataComp4 != null) ? new int?(creatureDataComp4.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("OldPos", this.ActorComp.ActorLocationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("NewPos", splineMoveRuntimeData.CurPos);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
			}
			return false;
		}

		// Token: 0x0603D1BC RID: 250300 RVA: 0x01198AD4 File Offset: 0x01196CD4
		public unsafe bool UpdateSplineMoveRotationByRuntimeData(SceneItemSplineMoveRuntimeData splineMoveRuntimeData, float tolerance = 0.017453292f)
		{
			if (!this.IsSplineMoving() || this.MoveComponent == null)
			{
				return false;
			}
			if (splineMoveRuntimeData.CurRot != null)
			{
				MathUtils.Instance.CommonTempRotator.DeepCopy(splineMoveRuntimeData.CurRot);
				if (!SceneItemSplineMoveTaskUtils.CheckSplineMoveRotatorNearlyEqual(MathUtils.Instance.CommonTempRotator, this.ActorComp.ActorRotationProxy, (double)tolerance))
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SceneItemMoveComponent.UpdateSplineMoveRotationByRuntimeData] 更新样条移动旋转";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "PbDataId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OldRot", this.ActorComp.ActorRotationProxy);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("NewRot", splineMoveRuntimeData.CurRot);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					AActor owner = this.MoveComponent.GetOwner();
					if (owner != null)
					{
						owner.K2_SetActorRotation(MathUtils.Instance.CommonTempRotator.ToUeRotator(), false);
					}
					return true;
				}
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SceneItemMoveComponent.UpdateSplineMoveRotationByRuntimeData] 样条移动旋转相差过小，不更新";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("OldRot", this.ActorComp.ActorRotationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("NewRot", splineMoveRuntimeData.CurRot);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			}
			return false;
		}

		// Token: 0x0603D1BD RID: 250301 RVA: 0x01198CE8 File Offset: 0x01196EE8
		public FSplineMoveDynamicSpeedData? GetSplineMoveDynamicSpeedData()
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsMoving(false))
			{
				return null;
			}
			return new FSplineMoveDynamicSpeedData?(this.MoveComponent.SplineMoveData.DynamicSpeedData);
		}

		// Token: 0x0603D1BE RID: 250302 RVA: 0x01198D2C File Offset: 0x01196F2C
		[NullableContext(2)]
		public unsafe void OnRecvSyncSplineMoving(int protoSplineId, MoveSplineConfig protoMoveSplineConfig = null, SceneItemSplineRuntimeData protoRuntimeData = null)
		{
			ISceneItemSplineMoveConfig sceneItemSplineMoveConfig = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralConfig();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveConfigToGeneralConfig(protoSplineId, protoMoveSplineConfig, sceneItemSplineMoveConfig))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SceneItemMoveComponent.OnRecvSyncSplineMoving] 解析样条移动协议中的样条移动配置失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			SceneItemSplineMoveRuntimeData sceneItemSplineMoveRuntimeData = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralRuntimeData();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveRuntimeDataToGeneralRuntimeData(protoRuntimeData, sceneItemSplineMoveRuntimeData))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SceneItemMoveComponent.OnRecvSyncSplineMoving] 解析样条移动协议中的样条移动运行时数据失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			SceneItemSplineMoveTask curSplineMoveTask = this.GetCurSplineMoveTask();
			if (curSplineMoveTask == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[SceneItemMoveComponent.OnRecvSyncSplineMoving] 当前没有样条移动task，直接开始新的样条移动task";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
				string item3 = "PbDataId";
				CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
				ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
				this.StartSplineMoveTask(new SceneItemSplineMoveTaskParam
				{
					SplineId = protoSplineId,
					SplineMoveConfig = sceneItemSplineMoveConfig,
					EnableSplineMoveSync = true,
					EnableMovementSync = false,
					NeedMoveToStartPoint = false,
					SplineMoveRuntimeData = sceneItemSplineMoveRuntimeData
				});
				return;
			}
			if (curSplineMoveTask.SplineEntityId != protoSplineId || !curSplineMoveTask.CheckSplineMoveConfigEqual(sceneItemSplineMoveConfig))
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[SceneItemMoveComponent.OnRecvSyncSplineMoving] 当前样条ID或移动task参数与同步信息不同，中断并开始新的样条移动task";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1);
				string item4 = "PbDataId";
				CreatureDataComponent creatureDataComp4 = this.CreatureDataComp;
				ptr4 = new ValueTuple<string, object>(item4, (creatureDataComp4 != null) ? new int?(creatureDataComp4.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 5));
				curSplineMoveTask.EndTask(false);
				this.StartSplineMoveTask(new SceneItemSplineMoveTaskParam
				{
					SplineId = protoSplineId,
					SplineMoveConfig = sceneItemSplineMoveConfig,
					EnableSplineMoveSync = true,
					EnableMovementSync = false,
					NeedMoveToStartPoint = false,
					SplineMoveRuntimeData = sceneItemSplineMoveRuntimeData
				});
				return;
			}
			if (!this.IsSplineMoving())
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.SceneItem;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[SceneItemMoveComponent.OnRecvSyncSplineMoving] 当前样条移动task未在进行样条移动，中断并开始新的样条移动task";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 4));
				curSplineMoveTask.EndTask(false);
				this.StartSplineMoveTask(new SceneItemSplineMoveTaskParam
				{
					SplineId = protoSplineId,
					SplineMoveConfig = sceneItemSplineMoveConfig,
					EnableSplineMoveSync = true,
					EnableMovementSync = false,
					NeedMoveToStartPoint = false,
					SplineMoveRuntimeData = sceneItemSplineMoveRuntimeData
				});
				return;
			}
			bool flag = false;
			flag = (this.UpdateSplineMoveDistanceByRuntimeData(sceneItemSplineMoveRuntimeData, 100f) || flag);
			flag = (this.UpdateSplineMoveRotationByRuntimeData(sceneItemSplineMoveRuntimeData, 0.017453292f) || flag);
			if (flag)
			{
				UeSceneItemMoveTickManagerComponent ueTickComponent = this.UeTickComponent;
				if (ueTickComponent == null)
				{
					return;
				}
				ueTickComponent.TickMovement(0f, true);
			}
		}

		// Token: 0x0603D1BF RID: 250303 RVA: 0x011991FC File Offset: 0x011973FC
		[NullableContext(2)]
		public unsafe void OnRecvSyncSplineStop(int protoSplineId, MoveSplineConfig protoMoveSplineConfig = null, SceneItemSplineRuntimeData protoRuntimeData = null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SceneItemMoveComponent.OnRecvSyncSplineStop] 停止样条移动task";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "PbDataId";
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			ISceneItemSplineMoveConfig sceneItemSplineMoveConfig = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralConfig();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveConfigToGeneralConfig(protoSplineId, protoMoveSplineConfig, sceneItemSplineMoveConfig))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SceneItemMoveComponent.OnRecvSyncSplineStop] 解析样条移动协议中的样条移动配置失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			SceneItemSplineMoveRuntimeData sceneItemSplineMoveRuntimeData = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralRuntimeData();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveRuntimeDataToGeneralRuntimeData(protoRuntimeData, sceneItemSplineMoveRuntimeData))
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[SceneItemMoveComponent.OnRecvSyncSplineStop] 解析样条移动协议中的样条移动运行时数据失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
				string item3 = "PbDataId";
				CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
				ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return;
			}
			SceneItemSplineMoveTask curSplineMoveTask = this.GetCurSplineMoveTask();
			if (curSplineMoveTask == null)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[SceneItemMoveComponent.OnRecvSyncSplineStop] 当前没有样条移动task，不需要处理停止";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1);
				string item4 = "PbDataId";
				CreatureDataComponent creatureDataComp4 = this.CreatureDataComp;
				ptr4 = new ValueTuple<string, object>(item4, (creatureDataComp4 != null) ? new int?(creatureDataComp4.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 5));
				return;
			}
			if (curSplineMoveTask.SplineEntityId != protoSplineId || !curSplineMoveTask.CheckSplineMoveConfigEqual(sceneItemSplineMoveConfig))
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.SceneItem;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[SceneItemMoveComponent.OnRecvSyncSplineStop] 当前样条ID或移动task参数与同步信息不同，不处理停止";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr5 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1);
				string item5 = "PbDataId";
				CreatureDataComponent creatureDataComp5 = this.CreatureDataComp;
				ptr5 = new ValueTuple<string, object>(item5, (creatureDataComp5 != null) ? new int?(creatureDataComp5.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 5));
				return;
			}
			if (this.MoveComponent != null && this.IsSplineMoving())
			{
				bool flag = false;
				flag = (this.UpdateSplineMoveDistanceByRuntimeData(sceneItemSplineMoveRuntimeData, 0f) || flag);
				flag = (this.UpdateSplineMoveRotationByRuntimeData(sceneItemSplineMoveRuntimeData, 0f) || flag);
				if (flag)
				{
					UeSceneItemMoveTickManagerComponent ueTickComponent = this.UeTickComponent;
					if (ueTickComponent != null)
					{
						ueTickComponent.TickMovement(0f, true);
					}
				}
			}
			curSplineMoveTask.EndTask(true);
		}

		// Token: 0x0603D1C0 RID: 250304 RVA: 0x0119963C File Offset: 0x0119783C
		[NullableContext(2)]
		public unsafe void OnRecvSyncSplineInterrupt(int protoSplineId, MoveSplineConfig protoMoveSplineConfig = null, SceneItemSplineRuntimeData protoRuntimeData = null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SceneItemMoveComponent.OnRecvSyncSplineInterrupt] 中断样条移动task";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "PbDataId";
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			ISceneItemSplineMoveConfig sceneItemSplineMoveConfig = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralConfig();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveConfigToGeneralConfig(protoSplineId, protoMoveSplineConfig, sceneItemSplineMoveConfig))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SceneItemMoveComponent.OnRecvSyncSplineInterrupt] 解析样条移动协议中的样条移动配置失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			SceneItemSplineMoveRuntimeData sceneItemSplineMoveRuntimeData = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralRuntimeData();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveRuntimeDataToGeneralRuntimeData(protoRuntimeData, sceneItemSplineMoveRuntimeData))
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[SceneItemMoveComponent.OnRecvSyncSplineInterrupt] 解析样条移动协议中的样条移动运行时数据失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
				string item3 = "PbDataId";
				CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
				ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return;
			}
			SceneItemSplineMoveTask curSplineMoveTask = this.GetCurSplineMoveTask();
			if (curSplineMoveTask == null)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[SceneItemMoveComponent.OnRecvSyncSplineInterrupt] 当前没有样条移动task，不需要处理中断";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1);
				string item4 = "PbDataId";
				CreatureDataComponent creatureDataComp4 = this.CreatureDataComp;
				ptr4 = new ValueTuple<string, object>(item4, (creatureDataComp4 != null) ? new int?(creatureDataComp4.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 5));
				return;
			}
			if (curSplineMoveTask.SplineEntityId != protoSplineId || !curSplineMoveTask.CheckSplineMoveConfigEqual(sceneItemSplineMoveConfig))
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.SceneItem;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[SceneItemMoveComponent.OnRecvSyncSplineInterrupt] 当前样条ID或移动task参数与同步信息不同，不处理中断";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr5 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1);
				string item5 = "PbDataId";
				CreatureDataComponent creatureDataComp5 = this.CreatureDataComp;
				ptr5 = new ValueTuple<string, object>(item5, (creatureDataComp5 != null) ? new int?(creatureDataComp5.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("SplineEntityId", protoSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("SplineMoveRuntimeData", sceneItemSplineMoveRuntimeData);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("SplineMoveConfig", sceneItemSplineMoveConfig);
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 5));
				return;
			}
			if (this.MoveComponent != null && this.IsSplineMoving())
			{
				bool flag = false;
				flag = (this.UpdateSplineMoveDistanceByRuntimeData(sceneItemSplineMoveRuntimeData, 0f) || flag);
				flag = (this.UpdateSplineMoveRotationByRuntimeData(sceneItemSplineMoveRuntimeData, 0f) || flag);
				if (flag)
				{
					UeSceneItemMoveTickManagerComponent ueTickComponent = this.UeTickComponent;
					if (ueTickComponent != null)
					{
						ueTickComponent.TickMovement(0f, true);
					}
				}
			}
			if (curSplineMoveTask != null)
			{
				curSplineMoveTask.EndTask(false);
			}
		}

		// Token: 0x0603D1C1 RID: 250305 RVA: 0x01199A80 File Offset: 0x01197C80
		[NullableContext(2)]
		public unsafe void OnRecvSyncSplineSwitch(int protoSplineId, MoveSplineConfig protoMoveSplineConfig = null, SceneItemSplineRuntimeData protoRuntimeData = null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SceneItemMoveComponent.OnRecvSyncSplineSwitch] 接收切换样条移动";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "PbDataId";
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NewSplineEntityId", protoSplineId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			ISceneItemSplineMoveConfig sceneItemSplineMoveConfig = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralConfig();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveConfigToGeneralConfig(protoSplineId, protoMoveSplineConfig, sceneItemSplineMoveConfig))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SceneItemMoveComponent.OnRecvSyncSplineSwitch] 解析样条移动协议中的新样条配置失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("NewSplineEntityId", protoSplineId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			SceneItemSplineMoveRuntimeData sceneItemSplineMoveRuntimeData = SceneItemSplineMoveTaskUtils.CreateDefaultGeneralRuntimeData();
			if (!SceneItemSplineMoveTaskUtils.ParseProtoSplineMoveRuntimeDataToGeneralRuntimeData(protoRuntimeData, sceneItemSplineMoveRuntimeData))
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[SceneItemMoveComponent.OnRecvSyncSplineSwitch] 解析样条移动协议中的运行时数据失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
				string item3 = "PbDataId";
				CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
				ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp3 != null) ? new int?(creatureDataComp3.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("NewSplineEntityId", protoSplineId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return;
			}
			this.SwitchSplineMoveTask(new SceneItemSplineMoveTaskParam
			{
				SplineId = protoSplineId,
				SplineMoveConfig = sceneItemSplineMoveConfig,
				EnableSplineMoveSync = true,
				EnableMovementSync = false,
				NeedMoveToStartPoint = false,
				SplineMoveRuntimeData = sceneItemSplineMoveRuntimeData
			});
		}

		// Token: 0x0603D1C2 RID: 250306 RVA: 0x01199CD4 File Offset: 0x01197ED4
		public unsafe void StopMove(bool broadcastStopCallback = true, bool boardcastIndexCallback = true)
		{
			if (Info.Instance.EnableForceTick)
			{
				this.MoveTargetList.Clear();
				this.CurState = SceneItemMoveComponent.ERunningState.STOP;
				return;
			}
			if (!this.IsMovingPrepareCompleted)
			{
				this.MoveTargetList.Clear();
				return;
			}
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			bool flag = moveComponent != null && moveComponent.IsMoving(true);
			bool flag2;
			if (!flag)
			{
				flag2 = false;
			}
			else
			{
				UKuroSceneItemMoveComponent moveComponent2 = this.MoveComponent;
				flag2 = (moveComponent2 == null || moveComponent2.GetSplineRunState() > ESplineRunState.None);
			}
			bool flag3 = flag2;
			if (flag)
			{
				if (!flag3)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "SceneItemMoveComponent 非样条移动中断";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "PbDataId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemMoveBroken, base.Entity);
				}
				else
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "SceneItemMoveComponent 样条移动中断";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item2 = "PbDataId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemMoveBroken, base.Entity);
					EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveBroken, base.Entity);
				}
			}
			this.MoveComponent.StopAllMove(broadcastStopCallback, boardcastIndexCallback);
		}

		// Token: 0x0603D1C3 RID: 250307 RVA: 0x01199EBE File Offset: 0x011980BE
		private void AddUeArrivePointCallback(Action<int> callback)
		{
			this.MoveComponent.OnArrivePointCallback.Add(callback);
		}

		// Token: 0x0603D1C4 RID: 250308 RVA: 0x01199ED1 File Offset: 0x011980D1
		private void RemoveUeArrivePointCallback(Action<int> callback)
		{
			this.MoveComponent.OnArrivePointCallback.Remove(callback);
		}

		// Token: 0x0603D1C5 RID: 250309 RVA: 0x01199EE4 File Offset: 0x011980E4
		private void OnUeArrivePointCallback(int index)
		{
			this.CallOnArrivePointCallbacks(index);
		}

		// Token: 0x0603D1C6 RID: 250310 RVA: 0x01199EED File Offset: 0x011980ED
		public void AddOnArrivePointCallback(Action<int> callback)
		{
			if (!this.OnArrivePointCallbacks.Contains(callback))
			{
				this.OnArrivePointCallbacks.Add(callback);
			}
		}

		// Token: 0x0603D1C7 RID: 250311 RVA: 0x01199F0C File Offset: 0x0119810C
		public void RemoveOnArrivePointCallback(Action<int> callback)
		{
			int num = this.OnArrivePointCallbacks.IndexOf(callback);
			if (num != -1)
			{
				this.OnArrivePointCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x0603D1C8 RID: 250312 RVA: 0x01199F36 File Offset: 0x01198136
		public void ClearOnArrivePointCallbacks()
		{
			this.OnArrivePointCallbacks.Clear();
		}

		// Token: 0x0603D1C9 RID: 250313 RVA: 0x01199F44 File Offset: 0x01198144
		private void CallOnArrivePointCallbacks(int index)
		{
			foreach (Action<int> action in new List<Action<int>>(this.OnArrivePointCallbacks))
			{
				action(index);
			}
		}

		// Token: 0x0603D1CA RID: 250314 RVA: 0x01199F9C File Offset: 0x0119819C
		private void AddUeMoveStopCallback(Action callback)
		{
			this.MoveComponent.OnMoveStopCallback.Add(callback);
		}

		// Token: 0x0603D1CB RID: 250315 RVA: 0x01199FAF File Offset: 0x011981AF
		private void RemoveUeMoveStopCallback(Action callback)
		{
			this.MoveComponent.OnMoveStopCallback.Remove(callback);
		}

		// Token: 0x0603D1CC RID: 250316 RVA: 0x01199FC4 File Offset: 0x011981C4
		private void OnUeMoveStopCallback()
		{
			SceneItemMoveComponent.EMoveMode moveMode = this.MoveMode;
			this.MoveMode = SceneItemMoveComponent.EMoveMode.None;
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.移动机关.样条移动.移动中"]));
			}
			if (moveMode == SceneItemMoveComponent.EMoveMode.Simple)
			{
				this.OnUeMoveStopCallbackForSimpleMove();
				return;
			}
			if (moveMode == SceneItemMoveComponent.EMoveMode.Spline)
			{
				this.OnUeMoveStopCallbackForSplineMove();
				return;
			}
			if (moveMode == SceneItemMoveComponent.EMoveMode.Track)
			{
				this.OnUeMoveStopCallbackForTrackMove();
			}
		}

		// Token: 0x0603D1CD RID: 250317 RVA: 0x0119A025 File Offset: 0x01198225
		private void OnUeMoveStopCallbackForSimpleMove()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ResetAllCachedTime();
			}
			this.CallOnMoveStopCallbacksWithEntity();
			this.CallOnMoveStopCallbacks();
			EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemMoveStopped, base.Entity);
		}

		// Token: 0x0603D1CE RID: 250318 RVA: 0x0119A060 File Offset: 0x01198260
		private void OnUeMoveStopCallbackForSplineMove()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "SceneItemMoveComponent 样条移动停止";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ResetAllCachedTime();
			}
			this.InPotral = false;
			this.CallOnMoveStopCallbacksWithEntity();
			this.CallOnMoveStopCallbacks();
			EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemMoveStopped, base.Entity);
			EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemSplineMoveStopped, base.Entity);
		}

		// Token: 0x0603D1CF RID: 250319 RVA: 0x0119A100 File Offset: 0x01198300
		private void OnUeMoveStopCallbackForTrackMove()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ResetAllCachedTime();
			}
			this.ResetTrackMode();
			this.CallOnMoveStopCallbacksWithEntity();
			this.CallOnMoveStopCallbacks();
			EventSystem.Instance.EmitWithTarget<Entity>(base.Entity, EEventName.OnSceneItemMoveStopped, base.Entity);
		}

		// Token: 0x0603D1D0 RID: 250320 RVA: 0x0119A14C File Offset: 0x0119834C
		public void AddStopMoveCallback(Action callback)
		{
			if (!this.MoveStopCallbacks.Contains(callback))
			{
				this.MoveStopCallbacks.Add(callback);
			}
		}

		// Token: 0x0603D1D1 RID: 250321 RVA: 0x0119A168 File Offset: 0x01198368
		public void RemoveStopMoveCallback(Action callback)
		{
			int num = this.MoveStopCallbacks.IndexOf(callback);
			if (num != -1)
			{
				this.MoveStopCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x0603D1D2 RID: 250322 RVA: 0x0119A192 File Offset: 0x01198392
		public void ClearStopMoveCallback()
		{
			this.MoveStopCallbacks.Clear();
		}

		// Token: 0x0603D1D3 RID: 250323 RVA: 0x0119A1A0 File Offset: 0x011983A0
		private void CallOnMoveStopCallbacks()
		{
			foreach (Action action in new List<Action>(this.MoveStopCallbacks))
			{
				action();
			}
		}

		// Token: 0x0603D1D4 RID: 250324 RVA: 0x0119A1F8 File Offset: 0x011983F8
		public void AddStopMoveCallbackWithEntity(Action<Entity> callback)
		{
			if (!this.MoveStopCallbacksWithEntity.Contains(callback))
			{
				this.MoveStopCallbacksWithEntity.Add(callback);
			}
		}

		// Token: 0x0603D1D5 RID: 250325 RVA: 0x0119A214 File Offset: 0x01198414
		public void RemoveStopMoveCallbackWithEntity(Action<Entity> callback)
		{
			int num = this.MoveStopCallbacksWithEntity.IndexOf(callback);
			if (num != -1)
			{
				this.MoveStopCallbacksWithEntity.RemoveAt(num);
			}
		}

		// Token: 0x0603D1D6 RID: 250326 RVA: 0x0119A23E File Offset: 0x0119843E
		public void ClearStopMoveCallbacksWithEntity()
		{
			this.MoveStopCallbacksWithEntity.Clear();
		}

		// Token: 0x0603D1D7 RID: 250327 RVA: 0x0119A24C File Offset: 0x0119844C
		private void CallOnMoveStopCallbacksWithEntity()
		{
			foreach (Action<Entity> action in new List<Action<Entity>>(this.MoveStopCallbacksWithEntity))
			{
				action(base.Entity);
			}
		}

		// Token: 0x0603D1D8 RID: 250328 RVA: 0x0119A2A8 File Offset: 0x011984A8
		public string GetDebugString()
		{
			string text = "";
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsValid())
			{
				return text;
			}
			bool flag = this.MoveComponent.IsMoving(true);
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("移动中: ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			if (!flag)
			{
				return text;
			}
			ESimpleRunState simpleRunState = this.MoveComponent.GetSimpleRunState();
			string str2 = text;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("简单移动状态: ");
			defaultInterpolatedStringHandler.AppendFormatted<ESimpleRunState>(simpleRunState);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
			ESplineRunState splineRunState = this.MoveComponent.GetSplineRunState();
			string str3 = text;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("样条移动状态: ");
			defaultInterpolatedStringHandler.AppendFormatted<ESplineRunState>(splineRunState);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
			if (splineRunState != ESplineRunState.None)
			{
				FSplineMoveDynamicSpeedData dynamicSpeedData = this.MoveComponent.SplineMoveData.DynamicSpeedData;
				text += "动态速度参数:\n";
				string str4 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\tCurrentSpeed: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(dynamicSpeedData.CurrentSpeed, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
				string str5 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\tTargetSpeed: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(dynamicSpeedData.TargetSpeed, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str5 + defaultInterpolatedStringHandler.ToStringAndClear();
				string str6 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\tAcceleration: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(dynamicSpeedData.Acceleration, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str6 + defaultInterpolatedStringHandler.ToStringAndClear();
				string str7 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\tEndDis: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(dynamicSpeedData.EndDis, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str7 + defaultInterpolatedStringHandler.ToStringAndClear();
				FSplineMoveStaticTimeDisData staticTimeDisData = this.MoveComponent.SplineMoveData.StaticTimeDisData;
				text += "固定时间参数:\n";
				string str8 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\tTimeDisCurveValid: ");
				UCurveFloat timeDisCurve = staticTimeDisData.TimeDisCurve;
				defaultInterpolatedStringHandler.AppendFormatted<bool>(timeDisCurve != null && timeDisCurve.IsValid());
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str8 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return text;
		}

		// Token: 0x0603D1D9 RID: 250329 RVA: 0x0119A540 File Offset: 0x01198740
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMoveComponent sceneItemMoveComponent = (SceneItemMoveComponent)componentTemplate;
			if (sceneItemMoveComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemMoveComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
			if (sceneItemMoveComponent.SyncComp == null)
			{
				this.SyncComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SyncComp), "SyncComp"))
			{
				return false;
			}
			if (sceneItemMoveComponent.PropertyComp == null)
			{
				this.PropertyComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PropertyComp), "PropertyComp"))
			{
				return false;
			}
			if (sceneItemMoveComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemMoveComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (sceneItemMoveComponent.UeTickComponent == null)
			{
				this.UeTickComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UeTickComponent), "UeTickComponent"))
			{
				return false;
			}
			this.MoveMode = sceneItemMoveComponent.MoveMode;
			this.TrackMode = sceneItemMoveComponent.TrackMode;
			this.IsSyncing = sceneItemMoveComponent.IsSyncing;
			this.ForceSyncingInternal = sceneItemMoveComponent.ForceSyncingInternal;
			if (sceneItemMoveComponent.Velocity == null)
			{
				this.Velocity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Velocity), "Velocity"))
			{
				return false;
			}
			if (sceneItemMoveComponent.MoveTargetList == null)
			{
				this.MoveTargetList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveTargetList), "MoveTargetList"))
			{
				return false;
			}
			this.CurState = sceneItemMoveComponent.CurState;
			if (sceneItemMoveComponent.StartLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartLocation), "StartLocation"))
			{
				return false;
			}
			if (sceneItemMoveComponent.TargetLocation == null)
			{
				this.TargetLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetLocation), "TargetLocation"))
			{
				return false;
			}
			if (sceneItemMoveComponent.CurLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurLocation), "CurLocation"))
			{
				return false;
			}
			this.MaxDist = sceneItemMoveComponent.MaxDist;
			this.InPotral = sceneItemMoveComponent.InPotral;
			this.IsMovingPrepareCompletedInternal = sceneItemMoveComponent.IsMovingPrepareCompletedInternal;
			this.NeedTickOutside = sceneItemMoveComponent.NeedTickOutside;
			return (sceneItemMoveComponent.OnArrivePointCallbacks == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnArrivePointCallbacks), "OnArrivePointCallbacks")) && (sceneItemMoveComponent.MoveStopCallbacks == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveStopCallbacks), "MoveStopCallbacks")) && (sceneItemMoveComponent.MoveStopCallbacksWithEntity == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveStopCallbacksWithEntity), "MoveStopCallbacksWithEntity"));
		}

		// Token: 0x170073B5 RID: 29621
		// (get) Token: 0x0603D1DA RID: 250330 RVA: 0x0119A824 File Offset: 0x01198A24
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073B6 RID: 29622
		// (get) Token: 0x0603D1DB RID: 250331 RVA: 0x0119A827 File Offset: 0x01198A27
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073B7 RID: 29623
		// (get) Token: 0x0603D1DC RID: 250332 RVA: 0x0119A82A File Offset: 0x01198A2A
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073B8 RID: 29624
		// (get) Token: 0x0603D1DD RID: 250333 RVA: 0x0119A82D File Offset: 0x01198A2D
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073B9 RID: 29625
		// (get) Token: 0x0603D1DE RID: 250334 RVA: 0x0119A830 File Offset: 0x01198A30
		public override bool NeedForceTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020680 RID: 132736
		private const string SCENEITEM_MOVE_DEBUG_KEY = "SCENEITEM_MOVE_DEBUG";

		// Token: 0x04020681 RID: 132737
		private const float OFFSET = 100f;

		// Token: 0x04020682 RID: 132738
		[Nullable(2)]
		public SceneItemActorComponent ActorComp;

		// Token: 0x04020683 RID: 132739
		[Nullable(2)]
		private UKuroSceneItemMoveComponent MoveComponent;

		// Token: 0x04020684 RID: 132740
		[Nullable(2)]
		private SceneItemMovementSyncComponent SyncComp;

		// Token: 0x04020685 RID: 132741
		[Nullable(2)]
		private SceneItemPropertyComponent PropertyComp;

		// Token: 0x04020686 RID: 132742
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04020687 RID: 132743
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04020688 RID: 132744
		[Nullable(2)]
		private UeSceneItemMoveTickManagerComponent UeTickComponent;

		// Token: 0x04020689 RID: 132745
		private SceneItemMoveComponent.EMoveMode MoveMode;

		// Token: 0x0402068A RID: 132746
		private SceneItemMoveComponent.ETrackMode TrackMode;

		// Token: 0x0402068B RID: 132747
		private bool IsSyncing;

		// Token: 0x0402068C RID: 132748
		private bool ForceSyncingInternal;

		// Token: 0x0402068D RID: 132749
		private global::Vector Velocity = global::Vector.Create();

		// Token: 0x0402068E RID: 132750
		private List<SceneItemMoveComponent.MoveTarget> MoveTargetList = new List<SceneItemMoveComponent.MoveTarget>();

		// Token: 0x0402068F RID: 132751
		private SceneItemMoveComponent.ERunningState CurState = SceneItemMoveComponent.ERunningState.STOP;

		// Token: 0x04020690 RID: 132752
		private readonly global::Vector StartLocation = global::Vector.Create();

		// Token: 0x04020691 RID: 132753
		private global::Vector TargetLocation = global::Vector.Create();

		// Token: 0x04020692 RID: 132754
		private readonly global::Vector CurLocation = global::Vector.Create();

		// Token: 0x04020693 RID: 132755
		private float MaxDist;

		// Token: 0x04020694 RID: 132756
		private bool InPotral;

		// Token: 0x04020695 RID: 132757
		private bool IsMovingPrepareCompletedInternal;

		// Token: 0x04020696 RID: 132758
		private bool NeedTickOutside;

		// Token: 0x04020697 RID: 132759
		private readonly List<Action<int>> OnArrivePointCallbacks = new List<Action<int>>();

		// Token: 0x04020698 RID: 132760
		private readonly List<Action> MoveStopCallbacks = new List<Action>();

		// Token: 0x04020699 RID: 132761
		private readonly List<Action<Entity>> MoveStopCallbacksWithEntity = new List<Action<Entity>>();

		// Token: 0x0200BAE9 RID: 47849
		[NullableContext(0)]
		private enum ERunningState
		{
			// Token: 0x0403985A RID: 235610
			RUN,
			// Token: 0x0403985B RID: 235611
			STOP
		}

		// Token: 0x0200BAEA RID: 47850
		[NullableContext(0)]
		private enum EMoveMode
		{
			// Token: 0x0403985D RID: 235613
			None,
			// Token: 0x0403985E RID: 235614
			Simple,
			// Token: 0x0403985F RID: 235615
			Spline,
			// Token: 0x04039860 RID: 235616
			Track
		}

		// Token: 0x0200BAEB RID: 47851
		[NullableContext(0)]
		private enum ETrackMode
		{
			// Token: 0x04039862 RID: 235618
			None,
			// Token: 0x04039863 RID: 235619
			Player
		}

		// Token: 0x0200BAEC RID: 47852
		[Nullable(0)]
		public class MoveTarget
		{
			// Token: 0x06048858 RID: 297048 RVA: 0x0161E1F1 File Offset: 0x0161C3F1
			public MoveTarget(IVector targetPosData, float moveTime, float stayTime = 0f, float maxSpeed = -1f, float acceleration = -1f)
			{
				this.TargetPosData.DeepCopy(targetPosData);
				this.MoveTime = moveTime;
				this.StayTime = stayTime;
				this.MaxSpeed = maxSpeed;
				this.Acceleration = acceleration;
			}

			// Token: 0x04039864 RID: 235620
			public global::Vector TargetPosData = global::Vector.Create();

			// Token: 0x04039865 RID: 235621
			public float MoveTime;

			// Token: 0x04039866 RID: 235622
			public float StayTime;

			// Token: 0x04039867 RID: 235623
			public float MaxSpeed;

			// Token: 0x04039868 RID: 235624
			public float Acceleration;
		}

		// Token: 0x0200BAED RID: 47853
		[Nullable(0)]
		public abstract class SceneItemSplineMoveBaseParam
		{
			// Token: 0x06048859 RID: 297049 RVA: 0x0161E22E File Offset: 0x0161C42E
			protected SceneItemSplineMoveBaseParam(USplineComponent spline)
			{
			}

			// Token: 0x04039869 RID: 235625
			public bool IsCycle;

			// Token: 0x0403986A RID: 235626
			public bool IsKeepLookAt;

			// Token: 0x0403986B RID: 235627
			public float StartDis = -1f;

			// Token: 0x0403986C RID: 235628
			public float EndDis = -1f;

			// Token: 0x0403986D RID: 235629
			public USplineComponent Spline = spline;
		}

		// Token: 0x0200BAEE RID: 47854
		[NullableContext(0)]
		public class SceneItemSplineMoveAtConstantTimeParam : SceneItemMoveComponent.SceneItemSplineMoveBaseParam
		{
			// Token: 0x0604885A RID: 297050 RVA: 0x0161E253 File Offset: 0x0161C453
			[NullableContext(1)]
			public SceneItemSplineMoveAtConstantTimeParam(USplineComponent spline) : base(spline)
			{
			}

			// Token: 0x0403986E RID: 235630
			public bool IsRepeat;

			// Token: 0x0403986F RID: 235631
			public float TimeSec;

			// Token: 0x04039870 RID: 235632
			[Nullable(2)]
			public UCurveFloat TimeDisCurve;

			// Token: 0x04039871 RID: 235633
			public float StartTimeOffset;
		}

		// Token: 0x0200BAEF RID: 47855
		[NullableContext(0)]
		public class SceneItemSplineMoveAtDynamicSpeedParam : SceneItemMoveComponent.SceneItemSplineMoveBaseParam
		{
			// Token: 0x0604885B RID: 297051 RVA: 0x0161E25C File Offset: 0x0161C45C
			[NullableContext(1)]
			public SceneItemSplineMoveAtDynamicSpeedParam(USplineComponent spline) : base(spline)
			{
			}

			// Token: 0x04039872 RID: 235634
			public int MaxMoveTimes = -1;

			// Token: 0x04039873 RID: 235635
			public float InitSpeed;

			// Token: 0x04039874 RID: 235636
			public float TargetSpeed;

			// Token: 0x04039875 RID: 235637
			public float Acceleration;
		}

		// Token: 0x0200BAF0 RID: 47856
		[NullableContext(0)]
		public class SceneItemSplineMoveAtDynamicSpeedEditableParam
		{
			// Token: 0x0604885C RID: 297052 RVA: 0x0161E26C File Offset: 0x0161C46C
			public void Clear()
			{
				this.CurrentSpeed = null;
				this.TargetSpeed = null;
				this.Acceleration = null;
			}

			// Token: 0x0604885D RID: 297053 RVA: 0x0161E294 File Offset: 0x0161C494
			[NullableContext(2)]
			public bool Equals(SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam other)
			{
				if (other != null)
				{
					float? num = this.CurrentSpeed;
					float? num2 = other.CurrentSpeed;
					if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
					{
						num2 = this.TargetSpeed;
						num = other.TargetSpeed;
						if (num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null))
						{
							num = this.Acceleration;
							num2 = other.Acceleration;
							return num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null);
						}
					}
				}
				return false;
			}

			// Token: 0x04039876 RID: 235638
			public float? CurrentSpeed;

			// Token: 0x04039877 RID: 235639
			public float? TargetSpeed;

			// Token: 0x04039878 RID: 235640
			public float? Acceleration;
		}
	}
}

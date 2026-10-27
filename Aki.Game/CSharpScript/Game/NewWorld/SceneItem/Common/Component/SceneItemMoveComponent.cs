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
	// Token: 0x0200721F RID: 29215
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemMoveComponent : EntityComponent
	{
		// Token: 0x17009E28 RID: 40488
		// (get) Token: 0x06047866 RID: 292966 RVA: 0x0123D667 File Offset: 0x0123B867
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public new static Type[] Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return new Type[]
				{
					typeof(SceneItemActorComponent),
					typeof(CreatureDataComponent)
				};
			}
		}

		// Token: 0x17009E29 RID: 40489
		// (get) Token: 0x06047867 RID: 292967 RVA: 0x0123D689 File Offset: 0x0123B889
		public bool IsMovingPrepareCompleted
		{
			get
			{
				return this.IsMovingPrepareCompletedInternal;
			}
		}

		// Token: 0x17009E2A RID: 40490
		// (get) Token: 0x06047868 RID: 292968 RVA: 0x0123D694 File Offset: 0x0123B894
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

		// Token: 0x17009E2B RID: 40491
		// (get) Token: 0x06047869 RID: 292969 RVA: 0x0123D6EA File Offset: 0x0123B8EA
		// (set) Token: 0x0604786A RID: 292970 RVA: 0x0123D6F2 File Offset: 0x0123B8F2
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

		// Token: 0x0604786B RID: 292971 RVA: 0x0123D719 File Offset: 0x0123B919
		public bool IsSplineMoving()
		{
			if (!this.IsMovingPrepareCompleted)
			{
				return false;
			}
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			return moveComponent != null && moveComponent.IsValid() && this.MoveComponent.GetSplineRunState() > ESplineRunState.None;
		}

		// Token: 0x0604786C RID: 292972 RVA: 0x0123D749 File Offset: 0x0123B949
		public float GetDistanceAloneSpline()
		{
			if (!this.IsMovingPrepareCompleted)
			{
				return 0f;
			}
			return this.MoveComponent.GetDistanceAlongSpline();
		}

		// Token: 0x0604786D RID: 292973 RVA: 0x0123D764 File Offset: 0x0123B964
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0604786E RID: 292974 RVA: 0x0123D778 File Offset: 0x0123B978
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

		// Token: 0x0604786F RID: 292975 RVA: 0x0123D9E0 File Offset: 0x0123BBE0
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

		// Token: 0x06047870 RID: 292976 RVA: 0x0123DA38 File Offset: 0x0123BC38
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

		// Token: 0x06047871 RID: 292977 RVA: 0x0123DB78 File Offset: 0x0123BD78
		private bool CheckReachTarget()
		{
			return global::Vector.DistSquared(this.StartLocation, this.CurLocation) >= (double)this.MaxDist;
		}

		// Token: 0x06047872 RID: 292978 RVA: 0x0123DB98 File Offset: 0x0123BD98
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

		// Token: 0x06047873 RID: 292979 RVA: 0x0123DC6C File Offset: 0x0123BE6C
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

		// Token: 0x06047874 RID: 292980 RVA: 0x0123DDF0 File Offset: 0x0123BFF0
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

		// Token: 0x06047875 RID: 292981 RVA: 0x0123DEB4 File Offset: 0x0123C0B4
		public void AddSimpleRotation(AActor actor, global::Rotator beginRotator, global::Rotator endRotator, float time)
		{
			this.MoveComponent.InitRotationData(actor, false);
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			FRotator frotator = beginRotator.ToUeRotator();
			FRotator frotator2 = endRotator.ToUeRotator();
			moveComponent.AddRotationStep(frotator, frotator2, time, 0f, null);
			this.MoveComponent.StartRotate();
		}

		// Token: 0x06047876 RID: 292982 RVA: 0x0123DF04 File Offset: 0x0123C104
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

		// Token: 0x06047877 RID: 292983 RVA: 0x0123E09C File Offset: 0x0123C29C
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

		// Token: 0x06047878 RID: 292984 RVA: 0x0123E18C File Offset: 0x0123C38C
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

		// Token: 0x06047879 RID: 292985 RVA: 0x0123E270 File Offset: 0x0123C470
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

		// Token: 0x0604787A RID: 292986 RVA: 0x0123E348 File Offset: 0x0123C548
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

		// Token: 0x0604787B RID: 292987 RVA: 0x0123E3D8 File Offset: 0x0123C5D8
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

		// Token: 0x0604787C RID: 292988 RVA: 0x0123E4F8 File Offset: 0x0123C6F8
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

		// Token: 0x0604787D RID: 292989 RVA: 0x0123E531 File Offset: 0x0123C731
		private void ResetTrackMode()
		{
			if (this.TrackMode == SceneItemMoveComponent.ETrackMode.Player)
			{
				EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
				this.TrackMode = SceneItemMoveComponent.ETrackMode.None;
			}
		}

		// Token: 0x0604787E RID: 292990 RVA: 0x0123E560 File Offset: 0x0123C760
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

		// Token: 0x0604787F RID: 292991 RVA: 0x0123E750 File Offset: 0x0123C950
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

		// Token: 0x06047880 RID: 292992 RVA: 0x0123E820 File Offset: 0x0123CA20
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

		// Token: 0x06047881 RID: 292993 RVA: 0x0123E8A4 File Offset: 0x0123CAA4
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

		// Token: 0x06047882 RID: 292994 RVA: 0x0123EA4C File Offset: 0x0123CC4C
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

		// Token: 0x06047883 RID: 292995 RVA: 0x0123EA7C File Offset: 0x0123CC7C
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

		// Token: 0x06047884 RID: 292996 RVA: 0x0123ED14 File Offset: 0x0123CF14
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

		// Token: 0x06047885 RID: 292997 RVA: 0x0123EFAC File Offset: 0x0123D1AC
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

		// Token: 0x06047886 RID: 292998 RVA: 0x0123F0F0 File Offset: 0x0123D2F0
		public bool UpdateSplineMoveDistance(float newDisAlongPath)
		{
			return this.IsSplineMoving() && this.MoveComponent != null && this.MoveComponent.UpdateSplineMoveDistance(newDisAlongPath);
		}

		// Token: 0x06047887 RID: 292999 RVA: 0x0123F110 File Offset: 0x0123D310
		public bool UpdateSplineMoveDistanceByPos(global::Vector newPos)
		{
			return this.IsSplineMoving() && this.MoveComponent != null && this.MoveComponent.UpdateSplineMoveDistanceByPosition(newPos.ToUeVector(false));
		}

		// Token: 0x06047888 RID: 293000 RVA: 0x0123F138 File Offset: 0x0123D338
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

		// Token: 0x06047889 RID: 293001 RVA: 0x0123F538 File Offset: 0x0123D738
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

		// Token: 0x0604788A RID: 293002 RVA: 0x0123F74C File Offset: 0x0123D94C
		public FSplineMoveDynamicSpeedData? GetSplineMoveDynamicSpeedData()
		{
			UKuroSceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent == null || !moveComponent.IsMoving(false))
			{
				return null;
			}
			return new FSplineMoveDynamicSpeedData?(this.MoveComponent.SplineMoveData.DynamicSpeedData);
		}

		// Token: 0x0604788B RID: 293003 RVA: 0x0123F790 File Offset: 0x0123D990
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
			if (!curSplineMoveTask.CheckSplineMoveConfigEqual(sceneItemSplineMoveConfig))
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[SceneItemMoveComponent.OnRecvSyncSplineMoving] 当前样条移动task参数与同步信息不同，中断并开始新的样条移动task";
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

		// Token: 0x0604788C RID: 293004 RVA: 0x0123FC54 File Offset: 0x0123DE54
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
			if (!curSplineMoveTask.CheckSplineMoveConfigEqual(sceneItemSplineMoveConfig))
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.SceneItem;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[SceneItemMoveComponent.OnRecvSyncSplineStop] 当前样条移动task参数与同步信息不同，不处理停止";
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

		// Token: 0x0604788D RID: 293005 RVA: 0x0124008C File Offset: 0x0123E28C
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
			if (!curSplineMoveTask.CheckSplineMoveConfigEqual(sceneItemSplineMoveConfig))
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.SceneItem;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[SceneItemMoveComponent.OnRecvSyncSplineInterrupt] 当前样条移动task参数与同步信息不同，不处理中断";
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

		// Token: 0x0604788E RID: 293006 RVA: 0x012404C4 File Offset: 0x0123E6C4
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

		// Token: 0x0604788F RID: 293007 RVA: 0x01240718 File Offset: 0x0123E918
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

		// Token: 0x06047890 RID: 293008 RVA: 0x01240902 File Offset: 0x0123EB02
		private void AddUeArrivePointCallback(Action<int> callback)
		{
			this.MoveComponent.OnArrivePointCallback.Add(callback);
		}

		// Token: 0x06047891 RID: 293009 RVA: 0x01240915 File Offset: 0x0123EB15
		private void RemoveUeArrivePointCallback(Action<int> callback)
		{
			this.MoveComponent.OnArrivePointCallback.Remove(callback);
		}

		// Token: 0x06047892 RID: 293010 RVA: 0x01240928 File Offset: 0x0123EB28
		private void OnUeArrivePointCallback(int index)
		{
			this.CallOnArrivePointCallbacks(index);
		}

		// Token: 0x06047893 RID: 293011 RVA: 0x01240931 File Offset: 0x0123EB31
		public void AddOnArrivePointCallback(Action<int> callback)
		{
			if (!this.OnArrivePointCallbacks.Contains(callback))
			{
				this.OnArrivePointCallbacks.Add(callback);
			}
		}

		// Token: 0x06047894 RID: 293012 RVA: 0x01240950 File Offset: 0x0123EB50
		public void RemoveOnArrivePointCallback(Action<int> callback)
		{
			int num = this.OnArrivePointCallbacks.IndexOf(callback);
			if (num != -1)
			{
				this.OnArrivePointCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x06047895 RID: 293013 RVA: 0x0124097A File Offset: 0x0123EB7A
		public void ClearOnArrivePointCallbacks()
		{
			this.OnArrivePointCallbacks.Clear();
		}

		// Token: 0x06047896 RID: 293014 RVA: 0x01240988 File Offset: 0x0123EB88
		private void CallOnArrivePointCallbacks(int index)
		{
			foreach (Action<int> action in new List<Action<int>>(this.OnArrivePointCallbacks))
			{
				action(index);
			}
		}

		// Token: 0x06047897 RID: 293015 RVA: 0x012409E0 File Offset: 0x0123EBE0
		private void AddUeMoveStopCallback(Action callback)
		{
			this.MoveComponent.OnMoveStopCallback.Add(callback);
		}

		// Token: 0x06047898 RID: 293016 RVA: 0x012409F3 File Offset: 0x0123EBF3
		private void RemoveUeMoveStopCallback(Action callback)
		{
			this.MoveComponent.OnMoveStopCallback.Remove(callback);
		}

		// Token: 0x06047899 RID: 293017 RVA: 0x01240A08 File Offset: 0x0123EC08
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

		// Token: 0x0604789A RID: 293018 RVA: 0x01240A69 File Offset: 0x0123EC69
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

		// Token: 0x0604789B RID: 293019 RVA: 0x01240AA4 File Offset: 0x0123ECA4
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

		// Token: 0x0604789C RID: 293020 RVA: 0x01240B44 File Offset: 0x0123ED44
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

		// Token: 0x0604789D RID: 293021 RVA: 0x01240B90 File Offset: 0x0123ED90
		public void AddStopMoveCallback(Action callback)
		{
			if (!this.MoveStopCallbacks.Contains(callback))
			{
				this.MoveStopCallbacks.Add(callback);
			}
		}

		// Token: 0x0604789E RID: 293022 RVA: 0x01240BAC File Offset: 0x0123EDAC
		public void RemoveStopMoveCallback(Action callback)
		{
			int num = this.MoveStopCallbacks.IndexOf(callback);
			if (num != -1)
			{
				this.MoveStopCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x0604789F RID: 293023 RVA: 0x01240BD6 File Offset: 0x0123EDD6
		public void ClearStopMoveCallback()
		{
			this.MoveStopCallbacks.Clear();
		}

		// Token: 0x060478A0 RID: 293024 RVA: 0x01240BE4 File Offset: 0x0123EDE4
		private void CallOnMoveStopCallbacks()
		{
			foreach (Action action in new List<Action>(this.MoveStopCallbacks))
			{
				action();
			}
		}

		// Token: 0x060478A1 RID: 293025 RVA: 0x01240C3C File Offset: 0x0123EE3C
		public void AddStopMoveCallbackWithEntity(Action<Entity> callback)
		{
			if (!this.MoveStopCallbacksWithEntity.Contains(callback))
			{
				this.MoveStopCallbacksWithEntity.Add(callback);
			}
		}

		// Token: 0x060478A2 RID: 293026 RVA: 0x01240C58 File Offset: 0x0123EE58
		public void RemoveStopMoveCallbackWithEntity(Action<Entity> callback)
		{
			int num = this.MoveStopCallbacksWithEntity.IndexOf(callback);
			if (num != -1)
			{
				this.MoveStopCallbacksWithEntity.RemoveAt(num);
			}
		}

		// Token: 0x060478A3 RID: 293027 RVA: 0x01240C82 File Offset: 0x0123EE82
		public void ClearStopMoveCallbacksWithEntity()
		{
			this.MoveStopCallbacksWithEntity.Clear();
		}

		// Token: 0x060478A4 RID: 293028 RVA: 0x01240C90 File Offset: 0x0123EE90
		private void CallOnMoveStopCallbacksWithEntity()
		{
			foreach (Action<Entity> action in new List<Action<Entity>>(this.MoveStopCallbacksWithEntity))
			{
				action(base.Entity);
			}
		}

		// Token: 0x060478A5 RID: 293029 RVA: 0x01240CEC File Offset: 0x0123EEEC
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

		// Token: 0x060478A6 RID: 293030 RVA: 0x01240F84 File Offset: 0x0123F184
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMoveComponent sceneItemMoveComponent = (SceneItemMoveComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemMoveComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComponent"))
			{
				if (sceneItemMoveComponent.MoveComponent == null)
				{
					this.MoveComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroSceneItemMoveComponent>(this.MoveComponent), "MoveComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SyncComp"))
			{
				if (sceneItemMoveComponent.SyncComp == null)
				{
					this.SyncComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMovementSyncComponent>(this.SyncComp), "SyncComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PropertyComp"))
			{
				if (sceneItemMoveComponent.PropertyComp == null)
				{
					this.PropertyComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemPropertyComponent>(this.PropertyComp), "PropertyComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (sceneItemMoveComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemMoveComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("UeTickComponent"))
			{
				if (sceneItemMoveComponent.UeTickComponent == null)
				{
					this.UeTickComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UeSceneItemMoveTickManagerComponent>(this.UeTickComponent), "UeTickComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveMode"))
			{
				this.MoveMode = sceneItemMoveComponent.MoveMode;
			}
			if (base.CanResetComponentProperty("TrackMode"))
			{
				this.TrackMode = sceneItemMoveComponent.TrackMode;
			}
			if (base.CanResetComponentProperty("IsSyncing"))
			{
				this.IsSyncing = sceneItemMoveComponent.IsSyncing;
			}
			if (base.CanResetComponentProperty("ForceSyncingInternal"))
			{
				this.ForceSyncingInternal = sceneItemMoveComponent.ForceSyncingInternal;
			}
			if (base.CanResetComponentProperty("Velocity"))
			{
				if (sceneItemMoveComponent.Velocity == null)
				{
					this.Velocity = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.Velocity), "Velocity"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveTargetList"))
			{
				if (sceneItemMoveComponent.MoveTargetList == null)
				{
					this.MoveTargetList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<SceneItemMoveComponent.MoveTarget>>(this.MoveTargetList), "MoveTargetList"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurState"))
			{
				this.CurState = sceneItemMoveComponent.CurState;
			}
			if (base.CanResetComponentProperty("StartLocation") && sceneItemMoveComponent.StartLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.StartLocation), "StartLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TargetLocation"))
			{
				if (sceneItemMoveComponent.TargetLocation == null)
				{
					this.TargetLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TargetLocation), "TargetLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurLocation") && sceneItemMoveComponent.CurLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CurLocation), "CurLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("MaxDist"))
			{
				this.MaxDist = sceneItemMoveComponent.MaxDist;
			}
			if (base.CanResetComponentProperty("InPotral"))
			{
				this.InPotral = sceneItemMoveComponent.InPotral;
			}
			if (base.CanResetComponentProperty("IsMovingPrepareCompletedInternal"))
			{
				this.IsMovingPrepareCompletedInternal = sceneItemMoveComponent.IsMovingPrepareCompletedInternal;
			}
			if (base.CanResetComponentProperty("NeedTickOutside"))
			{
				this.NeedTickOutside = sceneItemMoveComponent.NeedTickOutside;
			}
			return (!base.CanResetComponentProperty("OnArrivePointCallbacks") || sceneItemMoveComponent.OnArrivePointCallbacks == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<Action<int>>>(this.OnArrivePointCallbacks), "OnArrivePointCallbacks")) && (!base.CanResetComponentProperty("MoveStopCallbacks") || sceneItemMoveComponent.MoveStopCallbacks == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<Action>>(this.MoveStopCallbacks), "MoveStopCallbacks")) && (!base.CanResetComponentProperty("MoveStopCallbacksWithEntity") || sceneItemMoveComponent.MoveStopCallbacksWithEntity == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<Action<Entity>>>(this.MoveStopCallbacksWithEntity), "MoveStopCallbacksWithEntity"));
		}

		// Token: 0x04025A11 RID: 154129
		private const string SCENEITEM_MOVE_DEBUG_KEY = "SCENEITEM_MOVE_DEBUG";

		// Token: 0x04025A12 RID: 154130
		private const float OFFSET = 100f;

		// Token: 0x04025A13 RID: 154131
		[Nullable(2)]
		public SceneItemActorComponent ActorComp;

		// Token: 0x04025A14 RID: 154132
		[Nullable(2)]
		private UKuroSceneItemMoveComponent MoveComponent;

		// Token: 0x04025A15 RID: 154133
		[Nullable(2)]
		private SceneItemMovementSyncComponent SyncComp;

		// Token: 0x04025A16 RID: 154134
		[Nullable(2)]
		private SceneItemPropertyComponent PropertyComp;

		// Token: 0x04025A17 RID: 154135
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04025A18 RID: 154136
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04025A19 RID: 154137
		[Nullable(2)]
		private UeSceneItemMoveTickManagerComponent UeTickComponent;

		// Token: 0x04025A1A RID: 154138
		private SceneItemMoveComponent.EMoveMode MoveMode;

		// Token: 0x04025A1B RID: 154139
		private SceneItemMoveComponent.ETrackMode TrackMode;

		// Token: 0x04025A1C RID: 154140
		private bool IsSyncing;

		// Token: 0x04025A1D RID: 154141
		private bool ForceSyncingInternal;

		// Token: 0x04025A1E RID: 154142
		private global::Vector Velocity = global::Vector.Create();

		// Token: 0x04025A1F RID: 154143
		private List<SceneItemMoveComponent.MoveTarget> MoveTargetList = new List<SceneItemMoveComponent.MoveTarget>();

		// Token: 0x04025A20 RID: 154144
		private SceneItemMoveComponent.ERunningState CurState = SceneItemMoveComponent.ERunningState.STOP;

		// Token: 0x04025A21 RID: 154145
		private readonly global::Vector StartLocation = global::Vector.Create();

		// Token: 0x04025A22 RID: 154146
		private global::Vector TargetLocation = global::Vector.Create();

		// Token: 0x04025A23 RID: 154147
		private readonly global::Vector CurLocation = global::Vector.Create();

		// Token: 0x04025A24 RID: 154148
		private float MaxDist;

		// Token: 0x04025A25 RID: 154149
		private bool InPotral;

		// Token: 0x04025A26 RID: 154150
		private bool IsMovingPrepareCompletedInternal;

		// Token: 0x04025A27 RID: 154151
		private bool NeedTickOutside;

		// Token: 0x04025A28 RID: 154152
		private readonly List<Action<int>> OnArrivePointCallbacks = new List<Action<int>>();

		// Token: 0x04025A29 RID: 154153
		private readonly List<Action> MoveStopCallbacks = new List<Action>();

		// Token: 0x04025A2A RID: 154154
		private readonly List<Action<Entity>> MoveStopCallbacksWithEntity = new List<Action<Entity>>();

		// Token: 0x0200CF54 RID: 53076
		[NullableContext(0)]
		private enum ERunningState
		{
			// Token: 0x0403E534 RID: 255284
			RUN,
			// Token: 0x0403E535 RID: 255285
			STOP
		}

		// Token: 0x0200CF55 RID: 53077
		[NullableContext(0)]
		private enum EMoveMode
		{
			// Token: 0x0403E537 RID: 255287
			None,
			// Token: 0x0403E538 RID: 255288
			Simple,
			// Token: 0x0403E539 RID: 255289
			Spline,
			// Token: 0x0403E53A RID: 255290
			Track
		}

		// Token: 0x0200CF56 RID: 53078
		[NullableContext(0)]
		private enum ETrackMode
		{
			// Token: 0x0403E53C RID: 255292
			None,
			// Token: 0x0403E53D RID: 255293
			Player
		}

		// Token: 0x0200CF57 RID: 53079
		[Nullable(0)]
		public class MoveTarget
		{
			// Token: 0x060520AD RID: 336045 RVA: 0x0164C0D9 File Offset: 0x0164A2D9
			public MoveTarget(IVector targetPosData, float moveTime, float stayTime = 0f, float maxSpeed = -1f, float acceleration = -1f)
			{
				this.TargetPosData.DeepCopy(targetPosData);
				this.MoveTime = moveTime;
				this.StayTime = stayTime;
				this.MaxSpeed = maxSpeed;
				this.Acceleration = acceleration;
			}

			// Token: 0x0403E53E RID: 255294
			public global::Vector TargetPosData = global::Vector.Create();

			// Token: 0x0403E53F RID: 255295
			public float MoveTime;

			// Token: 0x0403E540 RID: 255296
			public float StayTime;

			// Token: 0x0403E541 RID: 255297
			public float MaxSpeed;

			// Token: 0x0403E542 RID: 255298
			public float Acceleration;
		}

		// Token: 0x0200CF58 RID: 53080
		[Nullable(0)]
		public abstract class SceneItemSplineMoveBaseParam
		{
			// Token: 0x060520AE RID: 336046 RVA: 0x0164C116 File Offset: 0x0164A316
			protected SceneItemSplineMoveBaseParam(USplineComponent spline)
			{
			}

			// Token: 0x0403E543 RID: 255299
			public bool IsCycle;

			// Token: 0x0403E544 RID: 255300
			public bool IsKeepLookAt;

			// Token: 0x0403E545 RID: 255301
			public float StartDis = -1f;

			// Token: 0x0403E546 RID: 255302
			public float EndDis = -1f;

			// Token: 0x0403E547 RID: 255303
			public USplineComponent Spline = spline;
		}

		// Token: 0x0200CF59 RID: 53081
		[NullableContext(0)]
		public class SceneItemSplineMoveAtConstantTimeParam : SceneItemMoveComponent.SceneItemSplineMoveBaseParam
		{
			// Token: 0x060520AF RID: 336047 RVA: 0x0164C13B File Offset: 0x0164A33B
			[NullableContext(1)]
			public SceneItemSplineMoveAtConstantTimeParam(USplineComponent spline) : base(spline)
			{
			}

			// Token: 0x0403E548 RID: 255304
			public bool IsRepeat;

			// Token: 0x0403E549 RID: 255305
			public float TimeSec;

			// Token: 0x0403E54A RID: 255306
			[Nullable(2)]
			public UCurveFloat TimeDisCurve;

			// Token: 0x0403E54B RID: 255307
			public float StartTimeOffset;
		}

		// Token: 0x0200CF5A RID: 53082
		[NullableContext(0)]
		public class SceneItemSplineMoveAtDynamicSpeedParam : SceneItemMoveComponent.SceneItemSplineMoveBaseParam
		{
			// Token: 0x060520B0 RID: 336048 RVA: 0x0164C144 File Offset: 0x0164A344
			[NullableContext(1)]
			public SceneItemSplineMoveAtDynamicSpeedParam(USplineComponent spline) : base(spline)
			{
			}

			// Token: 0x0403E54C RID: 255308
			public int MaxMoveTimes = -1;

			// Token: 0x0403E54D RID: 255309
			public float InitSpeed;

			// Token: 0x0403E54E RID: 255310
			public float TargetSpeed;

			// Token: 0x0403E54F RID: 255311
			public float Acceleration;
		}

		// Token: 0x0200CF5B RID: 53083
		[NullableContext(0)]
		public class SceneItemSplineMoveAtDynamicSpeedEditableParam
		{
			// Token: 0x060520B1 RID: 336049 RVA: 0x0164C154 File Offset: 0x0164A354
			public void Clear()
			{
				this.CurrentSpeed = null;
				this.TargetSpeed = null;
				this.Acceleration = null;
			}

			// Token: 0x060520B2 RID: 336050 RVA: 0x0164C17C File Offset: 0x0164A37C
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

			// Token: 0x0403E550 RID: 255312
			public float? CurrentSpeed;

			// Token: 0x0403E551 RID: 255313
			public float? TargetSpeed;

			// Token: 0x0403E552 RID: 255314
			public float? Acceleration;
		}
	}
}

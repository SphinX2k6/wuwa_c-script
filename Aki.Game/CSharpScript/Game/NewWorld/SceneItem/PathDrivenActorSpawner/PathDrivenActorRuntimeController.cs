using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.ElementalCasket;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071C2 RID: 29122
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorRuntimeController
	{
		// Token: 0x0604742B RID: 291883 RVA: 0x0121F21C File Offset: 0x0121D41C
		public PathDrivenActorRuntimeController(Entity ownerEntity, int? ownerPbDataId, UClass actorClass, IIntervalSplineSpawn spawnRule, IReadOnlyList<IPathDrivenSplineRuntimeData> trackList, bool usePreMoveTick, bool isChainMode)
		{
			this.OwnerEntity = ownerEntity;
			this.OwnerPbDataId = ownerPbDataId;
			this.ActorClass = actorClass;
			this.SpawnRule = spawnRule;
			this.TrackList = trackList;
			this.UsePreMoveTick = usePreMoveTick;
			this.IsChainMode = isChainMode;
			IIntervalSplineSpawnAllActorAudio audioConfig = this.SpawnRule.AudioConfig;
			if (audioConfig != null)
			{
				this.Audio = new PathDrivenActorAudio(audioConfig, this.OwnerEntity, this.OwnerPbDataId);
			}
		}

		// Token: 0x17009DC1 RID: 40385
		// (get) Token: 0x0604742C RID: 291884 RVA: 0x0121F2D8 File Offset: 0x0121D4D8
		private bool IsLoopMode
		{
			get
			{
				IPathDrivenActorSplineMove moveMode = this.SpawnRule.MoveMode;
				return moveMode != null && moveMode.IsLoop.GetValueOrDefault();
			}
		}

		// Token: 0x17009DC2 RID: 40386
		// (get) Token: 0x0604742D RID: 291885 RVA: 0x0121F303 File Offset: 0x0121D503
		public bool IsBatchSpawned
		{
			get
			{
				return this.BatchSpawned;
			}
		}

		// Token: 0x17009DC3 RID: 40387
		// (get) Token: 0x0604742E RID: 291886 RVA: 0x0121F30B File Offset: 0x0121D50B
		public bool IsRunning
		{
			get
			{
				return this.BatchSpawned && this.RuntimeContext.StagnationCount == 0 && this.TrackSwitchWaitingRuntimeDataSet.Count == 0;
			}
		}

		// Token: 0x0604742F RID: 291887 RVA: 0x0121F334 File Offset: 0x0121D534
		public void Tick(float deltaSeconds)
		{
			this.RecyclePendingActors();
			this.UpdateActiveActors();
			this.SyncStagnationFromContext();
			if (deltaSeconds <= 0f)
			{
				return;
			}
			this.ProcessPendingTrackSwitches();
			this.TickActiveBehaviors(deltaSeconds);
			if (this.IsRunning)
			{
				PathDrivenActorAudio audio = this.Audio;
				if (audio != null)
				{
					audio.UpdatePositions(this.ActiveRuntimeDataList);
				}
			}
			this.UpdateSpawn(deltaSeconds);
		}

		// Token: 0x06047430 RID: 291888 RVA: 0x0121F390 File Offset: 0x0121D590
		public void TickMoveComponents(float deltaSeconds)
		{
			if (!this.IsRunning || deltaSeconds <= 0f)
			{
				return;
			}
			for (int i = this.ActiveRuntimeDataList.Count - 1; i >= 0; i--)
			{
				IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.ActiveRuntimeDataList[i];
				if (this.ShouldTickMoveComponent(pathDrivenActorRuntimeData))
				{
					pathDrivenActorRuntimeData.MoveComponent.KuroTickComponentOutside(deltaSeconds);
				}
			}
		}

		// Token: 0x06047431 RID: 291889 RVA: 0x0121F3E8 File Offset: 0x0121D5E8
		private bool ShouldTickMoveComponent(IPathDrivenActorRuntimeData runtimeData)
		{
			if (this.UsePreMoveTick && runtimeData.HasStartedMove.GetValueOrDefault() && !runtimeData.Finished && !runtimeData.PendingRecycle)
			{
				UKuroSceneItemMoveComponent moveComponent = runtimeData.MoveComponent;
				return moveComponent != null && moveComponent.IsValid();
			}
			return false;
		}

		// Token: 0x06047432 RID: 291890 RVA: 0x0121F430 File Offset: 0x0121D630
		public void ClearAllActors(string reason)
		{
			PathDrivenActorAudio audio = this.Audio;
			if (audio != null)
			{
				audio.Stop();
			}
			this.TrackSwitchWaitingRuntimeDataSet.Clear();
			this.SuppressActorListNotify = true;
			for (int i = this.ActiveRuntimeDataList.Count - 1; i >= 0; i--)
			{
				this.CleanupActiveRuntimeData(this.ActiveRuntimeDataList[i], reason);
			}
			this.SuppressActorListNotify = false;
			this.PendingRecycleList.Clear();
			this.PendingTrackSwitchList.Clear();
			this.NextSpawnDelaySec = 0f;
			this.NextSplineIndex = 0;
			bool batchSpawned = this.BatchSpawned;
			this.BatchSpawned = false;
			this.RuntimeContext.Reset();
			this.LastSyncedContextVersion = this.RuntimeContext.Version;
			this.AppliedSpawnerStagnated = false;
			this.AppliedStagnatedActors.Clear();
			this.ApplyRunStateTransition();
			this.NotifyActorListChanged();
			if (batchSpawned)
			{
				this.NotifyBatchSpawnedChanged(false);
			}
		}

		// Token: 0x06047433 RID: 291891 RVA: 0x0121F50C File Offset: 0x0121D70C
		public List<AActor> GetActiveActors()
		{
			List<AActor> list = new List<AActor>();
			foreach (IPathDrivenActorRuntimeData pathDrivenActorRuntimeData in this.ActiveRuntimeDataList)
			{
				if (!pathDrivenActorRuntimeData.Finished)
				{
					AActor actor = pathDrivenActorRuntimeData.Actor;
					if (actor != null && actor.IsValid())
					{
						list.Add(pathDrivenActorRuntimeData.Actor);
					}
				}
			}
			return list;
		}

		// Token: 0x06047434 RID: 291892 RVA: 0x0121F588 File Offset: 0x0121D788
		private void UpdateActiveActors()
		{
			for (int i = this.ActiveRuntimeDataList.Count - 1; i >= 0; i--)
			{
				IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.ActiveRuntimeDataList[i];
				AActor actor = pathDrivenActorRuntimeData.Actor;
				if (actor == null || !actor.IsValid())
				{
					this.CleanupActiveRuntimeData(pathDrivenActorRuntimeData, "[PathDrivenActorSpawnerComponent] ActorInvalid");
				}
			}
		}

		// Token: 0x06047435 RID: 291893 RVA: 0x0121F5E0 File Offset: 0x0121D7E0
		private void TickActiveBehaviors(float deltaSeconds)
		{
			if (!this.IsRunning)
			{
				return;
			}
			foreach (IPathDrivenActorRuntimeData pathDrivenActorRuntimeData in this.TickableRuntimeDataList)
			{
				if (!pathDrivenActorRuntimeData.Finished)
				{
					AActor actor = pathDrivenActorRuntimeData.Actor;
					if (actor != null && actor.IsValid())
					{
						IPathDrivenActorTickBehavior pathDrivenActorTickBehavior = pathDrivenActorRuntimeData.Behavior as IPathDrivenActorTickBehavior;
						if (pathDrivenActorTickBehavior != null)
						{
							pathDrivenActorTickBehavior.Tick(pathDrivenActorRuntimeData, deltaSeconds);
						}
					}
				}
			}
		}

		// Token: 0x06047436 RID: 291894 RVA: 0x0121F66C File Offset: 0x0121D86C
		private void UpdateSpawn(float deltaSeconds)
		{
			if (!this.IsRunning || this.IsLoopMode)
			{
				return;
			}
			this.NextSpawnDelaySec -= deltaSeconds;
			if (this.NextSpawnDelaySec > 0f)
			{
				return;
			}
			this.TrySpawnActor();
			this.NextSpawnDelaySec = this.GetNextSpawnDelaySec();
		}

		// Token: 0x06047437 RID: 291895 RVA: 0x0121F6B8 File Offset: 0x0121D8B8
		private void TrySpawnActor()
		{
			int valueOrDefault = this.SpawnRule.MaxActiveCount.GetValueOrDefault();
			int activeRuntimeCount = this.GetActiveRuntimeCount();
			if (activeRuntimeCount >= 50 || (valueOrDefault > 0 && activeRuntimeCount >= valueOrDefault))
			{
				return;
			}
			int num = this.SelectTrackIndex();
			IPathDrivenSplineRuntimeData pathDrivenSplineRuntimeData = (num >= 0) ? this.TrackList[num] : null;
			if (pathDrivenSplineRuntimeData == null)
			{
				return;
			}
			SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam sceneItemSplineMoveAtConstantTimeParam = this.CloneMoveParam(pathDrivenSplineRuntimeData.MoveParamTemplate);
			float distance = (sceneItemSplineMoveAtConstantTimeParam.StartDis >= 0f) ? sceneItemSplineMoveAtConstantTimeParam.StartDis : 0f;
			FTransformDouble startTransform = pathDrivenSplineRuntimeData.SplineComponent.D_GetTransformAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World, false);
			this.ApplySpawnRotationByFollowDir(ref startTransform);
			IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.CreateAndRegisterActor(startTransform, num);
			if (pathDrivenActorRuntimeData == null)
			{
				return;
			}
			this.RestoreBehaviorCollisionAfterSpawn(pathDrivenActorRuntimeData);
			if (!pathDrivenActorRuntimeData.Finished)
			{
				AActor actor = pathDrivenActorRuntimeData.Actor;
				if (actor != null && actor.IsValid())
				{
					this.StartActorMove(pathDrivenActorRuntimeData, sceneItemSplineMoveAtConstantTimeParam, pathDrivenSplineRuntimeData.SplineEntityId);
					return;
				}
			}
		}

		// Token: 0x06047438 RID: 291896 RVA: 0x0121F7A0 File Offset: 0x0121D9A0
		private void ApplySpawnRotationByFollowDir(ref FTransformDouble transform)
		{
			IPathDrivenActorSplineMove moveMode = this.SpawnRule.MoveMode;
			if (((moveMode != null) ? moveMode.IsFollowSplineDir : null).GetValueOrDefault(true))
			{
				return;
			}
			transform.SetRotation(FQuat.Identity);
		}

		// Token: 0x06047439 RID: 291897 RVA: 0x0121F7E4 File Offset: 0x0121D9E4
		[NullableContext(2)]
		private unsafe IPathDrivenActorRuntimeData CreateAndRegisterActor(FTransformDouble startTransform, int trackIndex)
		{
			PathDrivenActorRuntimeController.<>c__DisplayClass41_0 CS$<>8__locals1 = new PathDrivenActorRuntimeController.<>c__DisplayClass41_0();
			CS$<>8__locals1.<>4__this = this;
			AActor aactor = ActorSystem.Instance.Get<AActor>(this.ActorClass.ClassStackOnlyPtr, startTransform, null, true);
			if (aactor == null || !aactor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorSpawnerComponent] 创建Actor失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorBlueprintPath", this.SpawnRule.ActorBlueprintPath);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			aactor.SetActorTickEnabled(false);
			aactor.SetActorHiddenInGame(true);
			UKuroSceneItemMoveComponent orAddMoveComponent = this.GetOrAddMoveComponent(aactor);
			if (orAddMoveComponent == null || !orAddMoveComponent.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PathDrivenActor;
				ELogAuthor author2 = ELogAuthor.WRY;
				string message2 = "[PathDrivenActorSpawnerComponent] Actor缺少KuroSceneItemMoveComponent";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActorBlueprintPath", this.SpawnRule.ActorBlueprintPath);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				ActorSystem.Instance.Put("[PathDrivenActorSpawnerComponent] InvalidMoveComponent", aactor, null);
				return null;
			}
			PathDrivenActorRuntimeController.<>c__DisplayClass41_0 CS$<>8__locals2 = CS$<>8__locals1;
			PathDrivenActorRuntimeData pathDrivenActorRuntimeData = new PathDrivenActorRuntimeData();
			pathDrivenActorRuntimeData.OwnerEntity = this.OwnerEntity;
			pathDrivenActorRuntimeData.Actor = aactor;
			pathDrivenActorRuntimeData.MoveComponent = orAddMoveComponent;
			pathDrivenActorRuntimeData.Finished = false;
			pathDrivenActorRuntimeData.PendingRecycle = false;
			pathDrivenActorRuntimeData.CurrentTrackIndex = trackIndex;
			pathDrivenActorRuntimeData.RequestFinish = delegate(EPathDrivenActorFinishReason _)
			{
			};
			pathDrivenActorRuntimeData.OnMoveStoppedHandler = delegate()
			{
			};
			CS$<>8__locals2.runtimeData = pathDrivenActorRuntimeData;
			CS$<>8__locals1.runtimeData.RequestFinish = delegate(EPathDrivenActorFinishReason reason)
			{
				CS$<>8__locals1.<>4__this.RequestFinish(CS$<>8__locals1.runtimeData, reason);
			};
			CS$<>8__locals1.runtimeData.OnMoveStoppedHandler = delegate()
			{
				AActor actor = CS$<>8__locals1.runtimeData.Actor;
				if (actor == null || !actor.IsValid())
				{
					return;
				}
				if (CS$<>8__locals1.<>4__this.IsChainMode && CS$<>8__locals1.runtimeData.CurrentTrackIndex + 1 < CS$<>8__locals1.<>4__this.TrackList.Count)
				{
					CS$<>8__locals1.<>4__this.MarkPendingTrackSwitch(CS$<>8__locals1.runtimeData);
					return;
				}
				CS$<>8__locals1.runtimeData.RequestFinish(EPathDrivenActorFinishReason.ReachEnd);
			};
			CS$<>8__locals1.runtimeData.Behavior = PathDrivenActorBehaviorRegistry.CreatePathDrivenActorBehavior(aactor, this.OwnerPbDataId);
			if (CS$<>8__locals1.runtimeData.Behavior != null && !CS$<>8__locals1.runtimeData.Behavior.Initialize(CS$<>8__locals1.runtimeData))
			{
				this.CleanupBehavior(CS$<>8__locals1.runtimeData);
				orAddMoveComponent.StopAllMove(false, false);
				orAddMoveComponent.SetKuroOnlyTickOutside(false);
				ActorSystem.Instance.Put("[PathDrivenActorSpawnerComponent] InitBehaviorFailed", aactor, null);
				return null;
			}
			this.ApplyMoveTickControl(CS$<>8__locals1.runtimeData);
			this.PrepareBehaviorCollisionBeforeSpawn(CS$<>8__locals1.runtimeData);
			this.RegisterActiveRuntimeData(CS$<>8__locals1.runtimeData);
			aactor.D_K2_SetActorTransform(startTransform, false, null, false);
			aactor.SetActorHiddenInGame(false);
			return CS$<>8__locals1.runtimeData;
		}

		// Token: 0x0604743A RID: 291898 RVA: 0x0121FA94 File Offset: 0x0121DC94
		private unsafe void StartActorMove(IPathDrivenActorRuntimeData runtimeData, SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam moveParam, int splineEntityId)
		{
			if (!runtimeData.MoveComponent.StartMoveWithSplineAtConstantTime(moveParam.Spline, moveParam.IsRepeat, moveParam.IsCycle, moveParam.IsKeepLookAt, moveParam.TimeSec, moveParam.TimeDisCurve, moveParam.StartTimeOffset, moveParam.StartDis, moveParam.EndDis))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorSpawnerComponent] 原生样条移动启动失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineEntityId", splineEntityId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CleanupActiveRuntimeData(runtimeData, "[PathDrivenActorSpawnerComponent] StartMoveFailed");
				return;
			}
			runtimeData.HasStartedMove = new bool?(true);
		}

		// Token: 0x0604743B RID: 291899 RVA: 0x0121FB64 File Offset: 0x0121DD64
		private void MarkPendingTrackSwitch(IPathDrivenActorRuntimeData runtimeData)
		{
			if (runtimeData.PendingTrackSwitch.GetValueOrDefault() || runtimeData.Finished)
			{
				return;
			}
			runtimeData.PendingTrackSwitch = new bool?(true);
			this.PendingTrackSwitchList.Add(runtimeData);
		}

		// Token: 0x0604743C RID: 291900 RVA: 0x0121FBA4 File Offset: 0x0121DDA4
		private void ProcessPendingTrackSwitches()
		{
			if (this.PendingTrackSwitchList.Count <= 0 || !this.IsRunning)
			{
				return;
			}
			int count = this.PendingTrackSwitchList.Count;
			for (int i = 0; i < count; i++)
			{
				IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.PendingTrackSwitchList[i];
				if (pathDrivenActorRuntimeData.PendingTrackSwitch.GetValueOrDefault())
				{
					pathDrivenActorRuntimeData.PendingTrackSwitch = new bool?(false);
					this.SwitchToNextTrack(pathDrivenActorRuntimeData).Forget();
				}
			}
			this.PendingTrackSwitchList.Clear();
		}

		// Token: 0x0604743D RID: 291901 RVA: 0x0121FC20 File Offset: 0x0121DE20
		private bool BeginTrackSwitchWait(IPathDrivenActorRuntimeData runtimeData)
		{
			if (!this.TrackSwitchWaitingRuntimeDataSet.Add(runtimeData))
			{
				return false;
			}
			this.ApplyRunStateTransition();
			return true;
		}

		// Token: 0x0604743E RID: 291902 RVA: 0x0121FC39 File Offset: 0x0121DE39
		private void EndTrackSwitchWait(IPathDrivenActorRuntimeData runtimeData)
		{
			if (!this.TrackSwitchWaitingRuntimeDataSet.Remove(runtimeData))
			{
				return;
			}
			this.ApplyRunStateTransition();
		}

		// Token: 0x0604743F RID: 291903 RVA: 0x0121FC50 File Offset: 0x0121DE50
		private UniTask SwitchToNextTrack(IPathDrivenActorRuntimeData runtimeData)
		{
			PathDrivenActorRuntimeController.<SwitchToNextTrack>d__47 <SwitchToNextTrack>d__;
			<SwitchToNextTrack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchToNextTrack>d__.<>4__this = this;
			<SwitchToNextTrack>d__.runtimeData = runtimeData;
			<SwitchToNextTrack>d__.<>1__state = -1;
			<SwitchToNextTrack>d__.<>t__builder.Start<PathDrivenActorRuntimeController.<SwitchToNextTrack>d__47>(ref <SwitchToNextTrack>d__);
			return <SwitchToNextTrack>d__.<>t__builder.Task;
		}

		// Token: 0x06047440 RID: 291904 RVA: 0x0121FC9C File Offset: 0x0121DE9C
		public void SpawnBatch()
		{
			if (this.BatchSpawned)
			{
				return;
			}
			this.BatchSpawned = true;
			IPathDrivenActorInitialSpawnConfig initialSpawnConfig = this.SpawnRule.InitialSpawnConfig;
			if (initialSpawnConfig != null && initialSpawnConfig.EnableInitialSpawn)
			{
				this.SuppressActorListNotify = true;
				this.SpawnInitialBatch(initialSpawnConfig.InitialSpawnHandles ?? new List<IPathDrivenActorInitialSpawnHandle>());
				foreach (IPathDrivenActorRuntimeData runtimeData in this.ActiveRuntimeDataList.ToArray())
				{
					this.RestoreBehaviorCollisionAfterSpawn(runtimeData);
				}
				this.SuppressActorListNotify = false;
				this.NotifyActorListChanged();
				if (this.GetActiveRuntimeCount() > 0)
				{
					this.NextSpawnDelaySec = this.GetNextSpawnDelaySec();
				}
			}
			else if (this.IsLoopMode)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorRuntimeController] 闭环模式未启用初始铺设，不会生成任何Actor";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.SyncStagnationFromContext();
			this.NotifyBatchSpawnedChanged(true);
		}

		// Token: 0x06047441 RID: 291905 RVA: 0x0121FD80 File Offset: 0x0121DF80
		private unsafe void SpawnInitialBatch(IReadOnlyList<IPathDrivenActorInitialSpawnHandle> handles)
		{
			if (!this.IsChainMode && this.TrackList.Count > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorRuntimeController] 未启用链式轨道时初始铺设仅使用第一条样条";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TrackCount", this.TrackList.Count);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			int num = this.IsChainMode ? this.TrackList.Count : 1;
			List<float> list = new List<float>();
			float num2 = 0f;
			for (int i = 0; i < num; i++)
			{
				IPathDrivenSplineRuntimeData pathDrivenSplineRuntimeData = (i < this.TrackList.Count) ? this.TrackList[i] : null;
				float num3 = (pathDrivenSplineRuntimeData != null) ? pathDrivenSplineRuntimeData.MoveParamTemplate.TimeSec : 0f;
				bool flag;
				if (pathDrivenSplineRuntimeData == null)
				{
					flag = true;
				}
				else
				{
					USplineComponent splineComponent = pathDrivenSplineRuntimeData.SplineComponent;
					flag = !((splineComponent != null) ? new bool?(splineComponent.IsValid()) : null).GetValueOrDefault();
				}
				if (flag || num3 <= 0f)
				{
					return;
				}
				list.Add(num3);
				num2 += num3;
			}
			if (num2 <= 0f)
			{
				return;
			}
			float num4 = Math.Max(this.SpawnRule.SpawnInterval, 0.01f);
			int valueOrDefault = this.SpawnRule.MaxActiveCount.GetValueOrDefault();
			int num5 = 0;
			float num6;
			for (;;)
			{
				num6 = (float)num5 * num4;
				if (num6 >= num2)
				{
					return;
				}
				int activeRuntimeCount = this.GetActiveRuntimeCount();
				if (activeRuntimeCount >= 50)
				{
					break;
				}
				if (valueOrDefault > 0 && activeRuntimeCount >= valueOrDefault)
				{
					goto Block_14;
				}
				int num7 = 0;
				float num8 = num6;
				while (num7 + 1 < num && num8 >= list[num7])
				{
					num8 -= list[num7];
					num7++;
				}
				IPathDrivenSplineRuntimeData pathDrivenSplineRuntimeData2 = this.TrackList[num7];
				SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam moveParamTemplate = pathDrivenSplineRuntimeData2.MoveParamTemplate;
				float distance = this.CalcDistanceByTimeOffset(moveParamTemplate, num8, moveParamTemplate.TimeSec, pathDrivenSplineRuntimeData2.SplineComponent.GetSplineLength());
				FTransformDouble startTransform = pathDrivenSplineRuntimeData2.SplineComponent.D_GetTransformAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World, false);
				this.ApplySpawnRotationByFollowDir(ref startTransform);
				IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.CreateAndRegisterActor(startTransform, num7);
				if (pathDrivenActorRuntimeData != null)
				{
					SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam sceneItemSplineMoveAtConstantTimeParam = this.CloneMoveParam(moveParamTemplate);
					sceneItemSplineMoveAtConstantTimeParam.StartTimeOffset = num8;
					this.ApplyLoopMoveParam(sceneItemSplineMoveAtConstantTimeParam);
					pathDrivenActorRuntimeData.LaunchMoveParam = sceneItemSplineMoveAtConstantTimeParam;
					if (this.HasStagnationHandle(handles, num5 + 1))
					{
						this.RuntimeContext.MarkStagnated(pathDrivenActorRuntimeData.Actor, EStagnationSource.InitialConfig);
					}
				}
				num5++;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PathDrivenActor;
			ELogAuthor author2 = ELogAuthor.WRY;
			string message2 = "[PathDrivenActorRuntimeController] 初始铺设数量达到硬上限，停止铺设";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("MaxActiveActorCount", 50);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("CoveredTimeSec", num6);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("TotalTimeSec", num2);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			return;
			Block_14:
			if (this.IsChainMode)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PathDrivenActor;
				ELogAuthor author3 = ELogAuthor.WRY;
				string message3 = "[PathDrivenActorRuntimeController] 链式初始铺设受MaxActiveCount限制提前结束，链尾部分未铺满";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("MaxActiveCount", valueOrDefault);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("CoveredTimeSec", num6);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("TotalTimeSec", num2);
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
				return;
			}
		}

		// Token: 0x06047442 RID: 291906 RVA: 0x01220168 File Offset: 0x0121E368
		public bool MarkActorStagnated(AActor actor, EStagnationSource source)
		{
			IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.FindRuntimeDataByActor(actor);
			if (pathDrivenActorRuntimeData == null)
			{
				return false;
			}
			this.RuntimeContext.MarkStagnated(pathDrivenActorRuntimeData.Actor, source);
			this.SyncStagnationFromContext();
			return true;
		}

		// Token: 0x06047443 RID: 291907 RVA: 0x0122019C File Offset: 0x0121E39C
		public bool UnmarkActorStagnated(AActor actor, int sources)
		{
			IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.FindRuntimeDataByActor(actor);
			if (pathDrivenActorRuntimeData == null)
			{
				return false;
			}
			this.RuntimeContext.UnmarkStagnated(pathDrivenActorRuntimeData.Actor, sources);
			this.SyncStagnationFromContext();
			return true;
		}

		// Token: 0x06047444 RID: 291908 RVA: 0x012201D0 File Offset: 0x0121E3D0
		private void SyncStagnationFromContext()
		{
			if (this.LastSyncedContextVersion != this.RuntimeContext.Version)
			{
				this.LastSyncedContextVersion = this.RuntimeContext.Version;
				foreach (IPathDrivenActorRuntimeData pathDrivenActorRuntimeData in this.ActiveRuntimeDataList)
				{
					bool flag = this.RuntimeContext.IsStagnated(pathDrivenActorRuntimeData.Actor);
					if (this.AppliedStagnatedActors.Contains(pathDrivenActorRuntimeData.Actor) != flag)
					{
						if (flag)
						{
							this.AppliedStagnatedActors.Add(pathDrivenActorRuntimeData.Actor);
						}
						else
						{
							this.AppliedStagnatedActors.Remove(pathDrivenActorRuntimeData.Actor);
						}
						IPathDrivenActorBehavior behavior = pathDrivenActorRuntimeData.Behavior;
						if (behavior != null)
						{
							behavior.OnStagnationChanged(pathDrivenActorRuntimeData, flag);
						}
					}
				}
			}
			bool flag2 = this.RuntimeContext.StagnationCount > 0;
			if (flag2 != this.AppliedSpawnerStagnated)
			{
				this.AppliedSpawnerStagnated = flag2;
				foreach (IPathDrivenActorRuntimeData pathDrivenActorRuntimeData2 in this.ActiveRuntimeDataList)
				{
					IPathDrivenActorBehavior behavior2 = pathDrivenActorRuntimeData2.Behavior;
					if (behavior2 != null)
					{
						behavior2.OnSpawnerStagnationChanged(pathDrivenActorRuntimeData2, flag2);
					}
				}
			}
			this.ApplyRunStateTransition();
		}

		// Token: 0x06047445 RID: 291909 RVA: 0x0122031C File Offset: 0x0121E51C
		private void ApplyRunStateTransition()
		{
			bool isRunning = this.IsRunning;
			if (isRunning == this.AppliedRunning)
			{
				return;
			}
			this.AppliedRunning = isRunning;
			if (isRunning)
			{
				PathDrivenActorAudio audio = this.Audio;
				if (audio != null)
				{
					audio.UpdatePositions(this.ActiveRuntimeDataList);
				}
			}
			PathDrivenActorAudio audio2 = this.Audio;
			if (audio2 != null)
			{
				audio2.SetRunning(isRunning);
			}
			if (isRunning)
			{
				this.RunAll();
			}
			else
			{
				this.FreezeAll();
			}
			Entity ownerEntity = this.OwnerEntity;
			if (ownerEntity != null && ownerEntity.Valid)
			{
				EventSystem.Instance.EmitWithTarget<bool>(this.OwnerEntity, EEventName.OnPathDrivenActorRunStateChanged, isRunning);
			}
		}

		// Token: 0x06047446 RID: 291910 RVA: 0x012203A9 File Offset: 0x0121E5A9
		private void NotifyBatchSpawnedChanged(bool isBatchSpawned)
		{
			Entity ownerEntity = this.OwnerEntity;
			if (ownerEntity != null && ownerEntity.Valid)
			{
				EventSystem.Instance.EmitWithTarget<bool>(this.OwnerEntity, EEventName.OnPathDrivenActorBatchSpawnedChanged, isBatchSpawned);
			}
		}

		// Token: 0x06047447 RID: 291911 RVA: 0x012203D8 File Offset: 0x0121E5D8
		private void RunAll()
		{
			for (int i = this.ActiveRuntimeDataList.Count - 1; i >= 0; i--)
			{
				this.RunActor(this.ActiveRuntimeDataList[i]);
			}
		}

		// Token: 0x06047448 RID: 291912 RVA: 0x01220410 File Offset: 0x0121E610
		private void FreezeAll()
		{
			foreach (IPathDrivenActorRuntimeData pathDrivenActorRuntimeData in this.ActiveRuntimeDataList)
			{
				UKuroSceneItemMoveComponent moveComponent = pathDrivenActorRuntimeData.MoveComponent;
				if (moveComponent != null && moveComponent.IsValid() && pathDrivenActorRuntimeData.HasStartedMove.GetValueOrDefault())
				{
					pathDrivenActorRuntimeData.MoveComponent.SetTickingMoveEnable(false);
				}
			}
		}

		// Token: 0x06047449 RID: 291913 RVA: 0x0122048C File Offset: 0x0121E68C
		private void RunActor(IPathDrivenActorRuntimeData runtimeData)
		{
			if (!this.RuntimeContext.IsStagnated(runtimeData.Actor))
			{
				AActor actor = runtimeData.Actor;
				if (actor != null && actor.IsValid())
				{
					if (!runtimeData.HasStartedMove.GetValueOrDefault())
					{
						SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam launchMoveParam = runtimeData.LaunchMoveParam;
						runtimeData.LaunchMoveParam = null;
						if (launchMoveParam != null)
						{
							int splineEntityId = (runtimeData.CurrentTrackIndex < this.TrackList.Count) ? this.TrackList[runtimeData.CurrentTrackIndex].SplineEntityId : 0;
							this.StartActorMove(runtimeData, launchMoveParam, splineEntityId);
							return;
						}
					}
					else
					{
						UKuroSceneItemMoveComponent moveComponent = runtimeData.MoveComponent;
						if (moveComponent != null && moveComponent.IsValid())
						{
							runtimeData.MoveComponent.SetTickingMoveEnable(true);
						}
					}
					return;
				}
			}
		}

		// Token: 0x0604744A RID: 291914 RVA: 0x0122053C File Offset: 0x0121E73C
		[NullableContext(2)]
		private IPathDrivenActorRuntimeData FindRuntimeDataByActor(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			foreach (IPathDrivenActorRuntimeData pathDrivenActorRuntimeData in this.ActiveRuntimeDataList)
			{
				if (pathDrivenActorRuntimeData.Actor == actor)
				{
					return pathDrivenActorRuntimeData;
				}
			}
			return null;
		}

		// Token: 0x0604744B RID: 291915 RVA: 0x012205AC File Offset: 0x0121E7AC
		private bool HasStagnationHandle(IReadOnlyList<IPathDrivenActorInitialSpawnHandle> handles, int index)
		{
			foreach (IPathDrivenActorInitialSpawnHandle pathDrivenActorInitialSpawnHandle in handles)
			{
				if (pathDrivenActorInitialSpawnHandle.Index == index && pathDrivenActorInitialSpawnHandle.HandleType == EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604744C RID: 291916 RVA: 0x01220608 File Offset: 0x0121E808
		private float CalcDistanceByTimeOffset(SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam template, float timeOffset, float timeSec, float splineLength)
		{
			float num = MathUtils.Instance.Clamp(timeOffset / timeSec, 0f, 1f);
			UCurveFloat timeDisCurve = template.TimeDisCurve;
			float currentValue = (timeDisCurve != null && timeDisCurve.IsValid()) ? template.TimeDisCurve.GetFloatValue(num) : num;
			return MathUtils.Instance.Clamp(currentValue, 0f, 1f) * splineLength;
		}

		// Token: 0x0604744D RID: 291917 RVA: 0x01220669 File Offset: 0x0121E869
		private void ApplyLoopMoveParam(SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam moveParam)
		{
			if (!this.IsLoopMode)
			{
				return;
			}
			moveParam.IsRepeat = true;
			moveParam.IsCycle = true;
		}

		// Token: 0x0604744E RID: 291918 RVA: 0x01220684 File Offset: 0x0121E884
		private int GetActiveRuntimeCount()
		{
			int num = 0;
			for (int i = 0; i < this.ActiveRuntimeDataList.Count; i++)
			{
				if (!this.ActiveRuntimeDataList[i].Finished)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0604744F RID: 291919 RVA: 0x012206C4 File Offset: 0x0121E8C4
		private int SelectTrackIndex()
		{
			if (this.TrackList.Count <= 0)
			{
				return -1;
			}
			if (this.IsChainMode)
			{
				return 0;
			}
			IPathDrivenActorSplineMove moveMode = this.SpawnRule.MoveMode;
			if (moveMode != null && moveMode.IsRandomSpline.GetValueOrDefault())
			{
				int num = (int)Math.Floor(MathUtils.Instance.GetRandomRange(0.0, (double)this.TrackList.Count));
				if (num >= this.TrackList.Count)
				{
					num = this.TrackList.Count - 1;
				}
				return num;
			}
			int result = this.NextSplineIndex % this.TrackList.Count;
			this.NextSplineIndex++;
			return result;
		}

		// Token: 0x06047450 RID: 291920 RVA: 0x01220770 File Offset: 0x0121E970
		private float GetNextSpawnDelaySec()
		{
			float num = Math.Max(this.SpawnRule.SpawnInterval, 0.01f);
			float? maxSpawnInterval = this.SpawnRule.MaxSpawnInterval;
			if (maxSpawnInterval != null)
			{
				float? num2 = maxSpawnInterval;
				float num3 = num;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					return (float)Math.Max(MathUtils.Instance.GetRandomRange((double)num, (double)maxSpawnInterval.Value), 0.009999999776482582);
				}
			}
			return num;
		}

		// Token: 0x06047451 RID: 291921 RVA: 0x012207E8 File Offset: 0x0121E9E8
		private SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam CloneMoveParam(SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam template)
		{
			return new SceneItemMoveComponent.SceneItemSplineMoveAtConstantTimeParam(template.Spline)
			{
				IsRepeat = template.IsRepeat,
				IsCycle = template.IsCycle,
				IsKeepLookAt = template.IsKeepLookAt,
				TimeSec = template.TimeSec,
				TimeDisCurve = template.TimeDisCurve,
				StartTimeOffset = template.StartTimeOffset,
				StartDis = template.StartDis,
				EndDis = template.EndDis
			};
		}

		// Token: 0x06047452 RID: 291922 RVA: 0x01220860 File Offset: 0x0121EA60
		[return: Nullable(2)]
		private UKuroSceneItemMoveComponent GetOrAddMoveComponent(AActor actor)
		{
			UKuroSceneItemMoveComponent ukuroSceneItemMoveComponent = actor.GetComponentByClass(UKuroSceneItemMoveComponent.StaticClass()) as UKuroSceneItemMoveComponent;
			if (ukuroSceneItemMoveComponent == null || !ukuroSceneItemMoveComponent.IsValid())
			{
				TSubclassOf<UActorComponent> @class = UKuroSceneItemMoveComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				ukuroSceneItemMoveComponent = (actor.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroSceneItemMoveComponent);
			}
			if (ukuroSceneItemMoveComponent == null || !ukuroSceneItemMoveComponent.IsValid())
			{
				return null;
			}
			return ukuroSceneItemMoveComponent;
		}

		// Token: 0x06047453 RID: 291923 RVA: 0x012208CB File Offset: 0x0121EACB
		private void ApplyMoveTickControl(IPathDrivenActorRuntimeData runtimeData)
		{
			UKuroSceneItemMoveComponent moveComponent = runtimeData.MoveComponent;
			if (moveComponent != null && moveComponent.IsValid())
			{
				runtimeData.MoveComponent.SetKuroOnlyTickOutside(this.UsePreMoveTick);
			}
		}

		// Token: 0x06047454 RID: 291924 RVA: 0x012208F2 File Offset: 0x0121EAF2
		private void PrepareBehaviorCollisionBeforeSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			IPathDrivenActorBehavior behavior = runtimeData.Behavior;
			if (behavior == null)
			{
				return;
			}
			behavior.PrepareCollisionBeforeSpawn(runtimeData);
		}

		// Token: 0x06047455 RID: 291925 RVA: 0x01220905 File Offset: 0x0121EB05
		private void RestoreBehaviorCollisionAfterSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			if (!runtimeData.Finished)
			{
				AActor actor = runtimeData.Actor;
				if (actor != null && actor.IsValid())
				{
					IPathDrivenActorBehavior behavior = runtimeData.Behavior;
					if (behavior == null)
					{
						return;
					}
					behavior.RestoreCollisionAfterSpawn(runtimeData);
					return;
				}
			}
		}

		// Token: 0x06047456 RID: 291926 RVA: 0x01220938 File Offset: 0x0121EB38
		private void ClearBehaviorCollisionBeforeRecycle(IPathDrivenActorRuntimeData runtimeData)
		{
			IPathDrivenActorBehavior behavior = runtimeData.Behavior;
			if (behavior == null)
			{
				return;
			}
			behavior.ClearCollisionBeforeRecycle(runtimeData);
		}

		// Token: 0x06047457 RID: 291927 RVA: 0x0122094C File Offset: 0x0121EB4C
		private void RegisterActiveRuntimeData(IPathDrivenActorRuntimeData runtimeData)
		{
			runtimeData.MoveComponent.OnMoveStopCallback.Add(runtimeData.OnMoveStoppedHandler);
			this.ActiveRuntimeDataList.Add(runtimeData);
			if (runtimeData.Behavior is IPathDrivenActorTickBehavior)
			{
				this.TickableRuntimeDataList.Add(runtimeData);
			}
			this.NotifyActorListChanged();
		}

		// Token: 0x06047458 RID: 291928 RVA: 0x0122099A File Offset: 0x0121EB9A
		private void CleanupMoveCallback(IPathDrivenActorRuntimeData runtimeData)
		{
			UKuroSceneItemMoveComponent moveComponent = runtimeData.MoveComponent;
			if (moveComponent != null && moveComponent.IsValid())
			{
				runtimeData.MoveComponent.OnMoveStopCallback.Remove(runtimeData.OnMoveStoppedHandler);
			}
		}

		// Token: 0x06047459 RID: 291929 RVA: 0x012209C8 File Offset: 0x0121EBC8
		private void RemoveRuntimeData(IPathDrivenActorRuntimeData runtimeData)
		{
			this.TickableRuntimeDataList.Remove(runtimeData);
			int num = this.ActiveRuntimeDataList.IndexOf(runtimeData);
			if (num >= 0)
			{
				this.ActiveRuntimeDataList.RemoveAt(num);
			}
		}

		// Token: 0x0604745A RID: 291930 RVA: 0x012209FF File Offset: 0x0121EBFF
		private bool TryStartFinishing(IPathDrivenActorRuntimeData runtimeData)
		{
			if (runtimeData.Finished)
			{
				return false;
			}
			runtimeData.Finished = true;
			this.CleanupMoveCallback(runtimeData);
			return true;
		}

		// Token: 0x0604745B RID: 291931 RVA: 0x01220A1A File Offset: 0x0121EC1A
		private void RequestFinish(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason)
		{
			if (!this.TryStartFinishing(runtimeData))
			{
				return;
			}
			this.ApplyFinishPresentation(runtimeData, reason);
			this.NotifyBehaviorFinishing(runtimeData, reason);
			this.MarkPendingRecycle(runtimeData);
		}

		// Token: 0x0604745C RID: 291932 RVA: 0x01220A3D File Offset: 0x0121EC3D
		private void ApplyFinishPresentation(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason)
		{
			if (reason == EPathDrivenActorFinishReason.Overlap)
			{
				AActor actor = runtimeData.Actor;
				if (actor != null && actor.IsValid())
				{
					runtimeData.Actor.SetActorHiddenInGame(true);
					runtimeData.Actor.SetActorTickEnabled(false);
					return;
				}
			}
		}

		// Token: 0x0604745D RID: 291933 RVA: 0x01220A72 File Offset: 0x0121EC72
		private void NotifyBehaviorFinishing(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason)
		{
			if (runtimeData.Behavior == null)
			{
				return;
			}
			this.ClearBehaviorCollisionBeforeRecycle(runtimeData);
			runtimeData.Behavior.OnFinishing(runtimeData, reason);
		}

		// Token: 0x0604745E RID: 291934 RVA: 0x01220A94 File Offset: 0x0121EC94
		private void CleanupActiveRuntimeData(IPathDrivenActorRuntimeData runtimeData, string reason)
		{
			UKuroSceneItemMoveComponent moveComponent = runtimeData.MoveComponent;
			runtimeData.Finished = true;
			runtimeData.PendingRecycle = false;
			runtimeData.PendingTrackSwitch = new bool?(false);
			this.CleanupMoveCallback(runtimeData);
			this.RemoveRuntimeData(runtimeData);
			this.RuntimeContext.RemoveActor(runtimeData.Actor);
			this.AppliedStagnatedActors.Remove(runtimeData.Actor);
			this.ClearBehaviorCollisionBeforeRecycle(runtimeData);
			this.CleanupBehavior(runtimeData);
			if (moveComponent != null && moveComponent.IsValid())
			{
				moveComponent.StopAllMove(false, false);
				moveComponent.SetKuroOnlyTickOutside(false);
			}
			AActor actor = runtimeData.Actor;
			if (actor != null && actor.IsValid())
			{
				ActorSystem.Instance.Put(reason, runtimeData.Actor, null);
			}
			this.EndTrackSwitchWait(runtimeData);
			this.NotifyActorListChanged();
		}

		// Token: 0x0604745F RID: 291935 RVA: 0x01220B4F File Offset: 0x0121ED4F
		private void NotifyActorListChanged()
		{
			if (this.SuppressActorListNotify)
			{
				return;
			}
			if (this.OwnerEntity.GetComponent<SceneItemElementalDetectableComponent>() == null)
			{
				return;
			}
			EventSystem.Instance.EmitWithTarget(this.OwnerEntity, EEventName.OnDynamicDetectableActorsChanged);
		}

		// Token: 0x06047460 RID: 291936 RVA: 0x01220B7E File Offset: 0x0121ED7E
		private void CleanupBehavior(IPathDrivenActorRuntimeData runtimeData)
		{
			if (runtimeData.Behavior == null)
			{
				return;
			}
			runtimeData.Behavior.Cleanup(runtimeData);
			runtimeData.Behavior = null;
		}

		// Token: 0x06047461 RID: 291937 RVA: 0x01220B9C File Offset: 0x0121ED9C
		private void MarkPendingRecycle(IPathDrivenActorRuntimeData runtimeData)
		{
			if (runtimeData.PendingRecycle)
			{
				return;
			}
			runtimeData.PendingRecycle = true;
			this.PendingRecycleList.Add(runtimeData);
		}

		// Token: 0x06047462 RID: 291938 RVA: 0x01220BBC File Offset: 0x0121EDBC
		private void RecyclePendingActors()
		{
			int count = this.PendingRecycleList.Count;
			for (int i = 0; i < count; i++)
			{
				IPathDrivenActorRuntimeData pathDrivenActorRuntimeData = this.PendingRecycleList[i];
				if (pathDrivenActorRuntimeData.PendingRecycle)
				{
					this.CleanupActiveRuntimeData(pathDrivenActorRuntimeData, "[PathDrivenActorSpawnerComponent] FinishRecycle");
				}
			}
			this.PendingRecycleList.Clear();
		}

		// Token: 0x040257A9 RID: 153513
		private const float MIN_SPAWN_INTERVAL = 0.01f;

		// Token: 0x040257AA RID: 153514
		private const int MAX_ACTIVE_ACTOR_COUNT = 50;

		// Token: 0x040257AB RID: 153515
		private readonly Entity OwnerEntity;

		// Token: 0x040257AC RID: 153516
		private readonly int? OwnerPbDataId;

		// Token: 0x040257AD RID: 153517
		private readonly UClass ActorClass;

		// Token: 0x040257AE RID: 153518
		private readonly IIntervalSplineSpawn SpawnRule;

		// Token: 0x040257AF RID: 153519
		private readonly IReadOnlyList<IPathDrivenSplineRuntimeData> TrackList;

		// Token: 0x040257B0 RID: 153520
		private readonly bool UsePreMoveTick;

		// Token: 0x040257B1 RID: 153521
		private readonly bool IsChainMode;

		// Token: 0x040257B2 RID: 153522
		private float NextSpawnDelaySec;

		// Token: 0x040257B3 RID: 153523
		private int NextSplineIndex;

		// Token: 0x040257B4 RID: 153524
		private bool BatchSpawned;

		// Token: 0x040257B5 RID: 153525
		private readonly PathDrivenActorRuntimeContext RuntimeContext = new PathDrivenActorRuntimeContext();

		// Token: 0x040257B6 RID: 153526
		private int LastSyncedContextVersion;

		// Token: 0x040257B7 RID: 153527
		private bool AppliedRunning;

		// Token: 0x040257B8 RID: 153528
		private bool AppliedSpawnerStagnated;

		// Token: 0x040257B9 RID: 153529
		private readonly HashSet<AActor> AppliedStagnatedActors = new HashSet<AActor>();

		// Token: 0x040257BA RID: 153530
		private bool SuppressActorListNotify;

		// Token: 0x040257BB RID: 153531
		private readonly List<IPathDrivenActorRuntimeData> ActiveRuntimeDataList = new List<IPathDrivenActorRuntimeData>();

		// Token: 0x040257BC RID: 153532
		private readonly List<IPathDrivenActorRuntimeData> TickableRuntimeDataList = new List<IPathDrivenActorRuntimeData>();

		// Token: 0x040257BD RID: 153533
		private readonly List<IPathDrivenActorRuntimeData> PendingRecycleList = new List<IPathDrivenActorRuntimeData>();

		// Token: 0x040257BE RID: 153534
		private readonly List<IPathDrivenActorRuntimeData> PendingTrackSwitchList = new List<IPathDrivenActorRuntimeData>();

		// Token: 0x040257BF RID: 153535
		private readonly HashSet<IPathDrivenActorRuntimeData> TrackSwitchWaitingRuntimeDataSet = new HashSet<IPathDrivenActorRuntimeData>();

		// Token: 0x040257C0 RID: 153536
		[Nullable(2)]
		private readonly PathDrivenActorAudio Audio;
	}
}

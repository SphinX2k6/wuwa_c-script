using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.ElementalCasket;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Interface;
using CSharpScript.Game.World.Controller;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071C3 RID: 29123
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorSpawnerComponent : EntityComponent, IComponentDependency, IDynamicDetectableActorSource
	{
		// Token: 0x17009DC4 RID: 40388
		// (get) Token: 0x06047463 RID: 291939 RVA: 0x01220C0D File Offset: 0x0121EE0D
		public static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CreatureDataComponent),
					typeof(SceneItemStateComponent)
				};
			}
		}

		// Token: 0x06047464 RID: 291940 RVA: 0x01220C30 File Offset: 0x0121EE30
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object param = args.GetP1<CreateEntityData>().GetParam<PathDrivenActorSpawnerComponent>();
			this.Config = (param as PathDrivenActorSpawnerComponent);
			PathDrivenActorSpawnerComponent config = this.Config;
			this.SpawnRule = ((config != null) ? config.SpawnRule : null);
			return this.Config != null && this.SpawnRule != null;
		}

		// Token: 0x06047465 RID: 291941 RVA: 0x01220C80 File Offset: 0x0121EE80
		protected unsafe override bool OnStart()
		{
			this.StateComp = base.Entity.GetComponent<SceneItemStateComponent>();
			IIntervalSplineSpawn spawnRule = this.SpawnRule;
			if (spawnRule == null || spawnRule.Type > EPathDrivenActorSpawnType.IntervalSplineSpawn)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorSpawnerComponent] 不支持的生成规则类型";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.GetOwnerPbDataId());
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "SpawnType";
				IIntervalSplineSpawn spawnRule2 = this.SpawnRule;
				ptr = new ValueTuple<string, object>(item, (spawnRule2 != null) ? new EPathDrivenActorSpawnType?(spawnRule2.Type) : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			IPathDrivenActorSplineMove moveMode = this.SpawnRule.MoveMode;
			if (this.SpawnRule.MoveMode.Type != EPathDrivenActorMoveType.Spline || moveMode == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PathDrivenActor;
				ELogAuthor author2 = ELogAuthor.WRY;
				string message2 = "[PathDrivenActorSpawnerComponent] 当前仅支持样条运动模式";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", this.GetOwnerPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("MoveType", this.SpawnRule.MoveMode.Type);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			this.IsChainMode = moveMode.IsChainedSpline.GetValueOrDefault();
			if (this.IsChainMode && moveMode.IsLoop.GetValueOrDefault())
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PathDrivenActor;
				ELogAuthor author3 = ELogAuthor.WRY;
				string message3 = "[PathDrivenActorSpawnerComponent] 链式轨道暂不支持闭环循环";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PbDataId", this.GetOwnerPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("TrackCount", moveMode.SplineEntityIds.Count);
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return false;
			}
			this.ActorClassPath = this.NormalizeActorClassPath(this.SpawnRule.ActorBlueprintPath);
			return !string.IsNullOrEmpty(this.ActorClassPath);
		}

		// Token: 0x06047466 RID: 291942 RVA: 0x01220E9C File Offset: 0x0121F09C
		protected override void OnActivate()
		{
			EventSystem.Instance.AddWithTargetUseHoldKey<int, bool>(this, base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange));
			this.TrySubscribeHitUnfreeze();
			SceneItemStateComponent stateComp = this.StateComp;
			if (stateComp == null || !stateComp.IsInState(SceneItemStateComponent.ESceneItemState.Born))
			{
				this.OnStateChange(0, false);
			}
		}

		// Token: 0x06047467 RID: 291943 RVA: 0x01220EF2 File Offset: 0x0121F0F2
		protected override void OnEnable()
		{
			this.TryRegisterPreMoveTick();
		}

		// Token: 0x06047468 RID: 291944 RVA: 0x01220EFC File Offset: 0x0121F0FC
		private void TrySubscribeHitUnfreeze()
		{
			bool flag = base.Entity.GetComponent<SceneItemElementalDetectableComponent>() != null;
			if (!this.HasStagnationHandleConfig() && !flag)
			{
				return;
			}
			EventSystem.Instance.AddWithTargetUseHoldKey<HitInformation>(this, base.Entity, EEventName.OnSceneItemEntityHitAlways, new Action<HitInformation>(this.OnEntityHitAlways));
			EventSystem.Instance.AddWithTargetUseHoldKey<BulletHitActorData>(this, base.Entity, EEventName.OnSceneItemEntityHitByHitActorData, new Action<BulletHitActorData>(this.OnEntityHitByHitActorData));
			if (this.HasStagnationHandleConfig() && base.Entity.GetComponent<SceneItemHitComponent>() == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorSpawnerComponent] 配置了凝滞初始处理但实体未配置HitComponent，击打解冻不会生效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.GetOwnerPbDataId());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06047469 RID: 291945 RVA: 0x01220FB4 File Offset: 0x0121F1B4
		protected override void OnTick(float delta)
		{
			if (this.State != EPathDrivenActorSpawnerState.Running)
			{
				return;
			}
			float num = Math.Max(delta, 0f) * 0.001f;
			if (num <= 0f)
			{
				return;
			}
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			if (runtimeController == null)
			{
				return;
			}
			runtimeController.Tick(num);
		}

		// Token: 0x0604746A RID: 291946 RVA: 0x01220FF7 File Offset: 0x0121F1F7
		protected override void OnDisable(string reason)
		{
			this.TryUnregisterPreMoveTick();
		}

		// Token: 0x0604746B RID: 291947 RVA: 0x01220FFF File Offset: 0x0121F1FF
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			this.TryUnregisterPreMoveTick();
			this.StopAndClear("[PathDrivenActorSpawnerComponent] OnEnd");
			this.CancelActorClassLoad();
			return true;
		}

		// Token: 0x0604746C RID: 291948 RVA: 0x01221028 File Offset: 0x0121F228
		protected override bool OnClear()
		{
			this.TryUnregisterPreMoveTick();
			this.StopAndClear("[PathDrivenActorSpawnerComponent] OnClear");
			this.CancelActorClassLoad();
			this.Config = null;
			this.SpawnRule = null;
			this.ActorClassPath = null;
			this.ActorClass = null;
			this.IsWaterBoxTransportClass = false;
			this.IsExplosiveBarrelClass = false;
			this.IsChainMode = false;
			this.StateComp = null;
			this.LastEntityHitData = null;
			return true;
		}

		// Token: 0x0604746D RID: 291949 RVA: 0x0122108C File Offset: 0x0121F28C
		private void OnPreMoveTick(float delta)
		{
			if (this.State != EPathDrivenActorSpawnerState.Running)
			{
				return;
			}
			float num = Math.Max(delta, 0f) * 0.001f;
			if (num <= 0f)
			{
				return;
			}
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			if (runtimeController == null)
			{
				return;
			}
			runtimeController.TickMoveComponents(num);
		}

		// Token: 0x0604746E RID: 291950 RVA: 0x012210CF File Offset: 0x0121F2CF
		private void OnStateChange(int _1 = 0, bool _2 = false)
		{
			SceneItemStateComponent stateComp = this.StateComp;
			if (stateComp != null && stateComp.IsInState(SceneItemStateComponent.ESceneItemState.Active))
			{
				this.RequestStart();
				return;
			}
			this.RequestStop("[PathDrivenActorSpawnerComponent] StateInactive");
		}

		// Token: 0x0604746F RID: 291951 RVA: 0x012210F8 File Offset: 0x0121F2F8
		private void OnEntityHitAlways(HitInformation hitData)
		{
			this.LastEntityHitData = hitData;
		}

		// Token: 0x06047470 RID: 291952 RVA: 0x01221104 File Offset: 0x0121F304
		private void OnEntityHitByHitActorData(BulletHitActorData hitActorData)
		{
			HitInformation lastEntityHitData = this.LastEntityHitData;
			this.LastEntityHitData = null;
			AActor actor = hitActorData.Actor;
			if (lastEntityHitData == null || (actor == null || !actor.IsValid()))
			{
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
			if (num != null)
			{
				Entity attacker = lastEntityHitData.Attacker;
				bool flag;
				if (attacker == null)
				{
					flag = (num != null);
				}
				else
				{
					int id = attacker.Id;
					int? num2 = num;
					flag = !(id == num2.GetValueOrDefault() & num2 != null);
				}
				if (!flag)
				{
					PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
					if (runtimeController == null)
					{
						return;
					}
					runtimeController.UnmarkActorStagnated(actor, 3);
					return;
				}
			}
		}

		// Token: 0x06047471 RID: 291953 RVA: 0x012211A7 File Offset: 0x0121F3A7
		private void RequestStart()
		{
			this.DesiredRunning = true;
			if (this.State == EPathDrivenActorSpawnerState.Running)
			{
				this.TryEnableOwnerConstantTick();
				return;
			}
			this.TryStartRunning();
		}

		// Token: 0x06047472 RID: 291954 RVA: 0x012211C8 File Offset: 0x0121F3C8
		private void TryStartRunning()
		{
			if (this.DesiredRunning)
			{
				SceneItemStateComponent stateComp = this.StateComp;
				if (stateComp != null && stateComp.IsInState(SceneItemStateComponent.ESceneItemState.Active))
				{
					UClass actorClass = this.ActorClass;
					if (actorClass == null || !actorClass.IsValid())
					{
						this.EnterState(EPathDrivenActorSpawnerState.LoadingActorClass);
						this.TryLoadActorClassAsync();
						return;
					}
					if (this.TrackRuntimeSet == null || this.TrackRuntimeSet.TrackList.Count <= 0)
					{
						this.StartPrepareTracks();
						return;
					}
					this.TryCreateRuntimeController();
					if (this.RuntimeController == null)
					{
						this.DesiredRunning = false;
						this.EnterState(EPathDrivenActorSpawnerState.Idle);
						return;
					}
					this.EnterState(EPathDrivenActorSpawnerState.Running);
					this.RuntimeController.SpawnBatch();
					return;
				}
			}
		}

		// Token: 0x06047473 RID: 291955 RVA: 0x0122126C File Offset: 0x0121F46C
		private void StartPrepareTracks()
		{
			if (this.State == EPathDrivenActorSpawnerState.PreparingTracks || this.SpawnRule == null)
			{
				return;
			}
			IPathDrivenActorSplineMove moveMode = this.SpawnRule.MoveMode;
			if (moveMode == null)
			{
				return;
			}
			this.ReleaseTrackSet();
			this.EnterState(EPathDrivenActorSpawnerState.PreparingTracks);
			int? ownerPbDataId = this.GetOwnerPbDataId();
			IReadOnlyList<int> splineEntityIds = moveMode.SplineEntityIds;
			bool valueOrDefault = moveMode.IsLoop.GetValueOrDefault();
			bool valueOrDefault2 = moveMode.IsFollowSplineDir.GetValueOrDefault(true);
			this.PrepareTracksAsync(ownerPbDataId, splineEntityIds, valueOrDefault, valueOrDefault2);
		}

		// Token: 0x06047474 RID: 291956 RVA: 0x012212E4 File Offset: 0x0121F4E4
		private UniTask PrepareTracksAsync(int? ownerPbDataId, IReadOnlyList<int> splineEntityIds, bool allowClosedLoopTrack, bool isFollowSplineDir)
		{
			PathDrivenActorSpawnerComponent.<PrepareTracksAsync>d__36 <PrepareTracksAsync>d__;
			<PrepareTracksAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareTracksAsync>d__.<>4__this = this;
			<PrepareTracksAsync>d__.ownerPbDataId = ownerPbDataId;
			<PrepareTracksAsync>d__.splineEntityIds = splineEntityIds;
			<PrepareTracksAsync>d__.allowClosedLoopTrack = allowClosedLoopTrack;
			<PrepareTracksAsync>d__.isFollowSplineDir = isFollowSplineDir;
			<PrepareTracksAsync>d__.<>1__state = -1;
			<PrepareTracksAsync>d__.<>t__builder.Start<PathDrivenActorSpawnerComponent.<PrepareTracksAsync>d__36>(ref <PrepareTracksAsync>d__);
			return <PrepareTracksAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06047475 RID: 291957 RVA: 0x01221348 File Offset: 0x0121F548
		private void RequestStop(string reason)
		{
			if (!this.DesiredRunning && this.State == EPathDrivenActorSpawnerState.Idle && this.TrackRuntimeSet == null && this.RuntimeController == null)
			{
				return;
			}
			this.StopAndClear(reason);
		}

		// Token: 0x06047476 RID: 291958 RVA: 0x01221372 File Offset: 0x0121F572
		private void StopAndClear(string reason)
		{
			this.DesiredRunning = false;
			this.EnterState(EPathDrivenActorSpawnerState.Idle);
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			if (runtimeController != null)
			{
				runtimeController.ClearAllActors(reason);
			}
			this.RuntimeController = null;
			this.TrackRuntimeBuilder.CancelBuild();
			this.ReleaseTrackSet();
		}

		// Token: 0x06047477 RID: 291959 RVA: 0x012213AC File Offset: 0x0121F5AC
		private void EnterState(EPathDrivenActorSpawnerState state)
		{
			this.State = state;
			if (state == EPathDrivenActorSpawnerState.Running)
			{
				this.TryEnableOwnerConstantTick();
				return;
			}
			this.TryDisableOwnerConstantTick();
		}

		// Token: 0x06047478 RID: 291960 RVA: 0x012213C6 File Offset: 0x0121F5C6
		private void ReleaseTrackSet()
		{
			PathDrivenTrackRuntimeSet trackRuntimeSet = this.TrackRuntimeSet;
			if (trackRuntimeSet != null)
			{
				trackRuntimeSet.Release();
			}
			this.TrackRuntimeSet = null;
		}

		// Token: 0x06047479 RID: 291961 RVA: 0x012213E0 File Offset: 0x0121F5E0
		private void TryCreateRuntimeController()
		{
			if (this.RuntimeController == null)
			{
				UClass actorClass = this.ActorClass;
				if (actorClass != null && actorClass.IsValid() && this.SpawnRule != null && this.TrackRuntimeSet != null && this.TrackRuntimeSet.TrackList.Count > 0)
				{
					this.RuntimeController = new PathDrivenActorRuntimeController(base.Entity, this.GetOwnerPbDataId(), this.ActorClass, this.SpawnRule, this.TrackRuntimeSet.TrackList, this.ShouldUsePreMoveTick(), this.IsChainMode);
					return;
				}
			}
		}

		// Token: 0x0604747A RID: 291962 RVA: 0x0122146A File Offset: 0x0121F66A
		public bool IsRunning()
		{
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			return runtimeController != null && runtimeController.IsRunning;
		}

		// Token: 0x0604747B RID: 291963 RVA: 0x0122147D File Offset: 0x0121F67D
		public bool IsBatchSpawned()
		{
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			return runtimeController != null && runtimeController.IsBatchSpawned;
		}

		// Token: 0x0604747C RID: 291964 RVA: 0x01221490 File Offset: 0x0121F690
		public List<AActor> GetDetectableActors()
		{
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			return ((runtimeController != null) ? runtimeController.GetActiveActors() : null) ?? new List<AActor>();
		}

		// Token: 0x0604747D RID: 291965 RVA: 0x012214B0 File Offset: 0x0121F6B0
		public void OnActorsEnterField(IReadOnlyList<AActor> actors)
		{
			foreach (AActor actor in actors)
			{
				PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
				if (runtimeController != null)
				{
					runtimeController.MarkActorStagnated(actor, EStagnationSource.ElementalField);
				}
			}
		}

		// Token: 0x0604747E RID: 291966 RVA: 0x01221508 File Offset: 0x0121F708
		public void OnActorsLeaveField(IReadOnlyList<AActor> actors)
		{
			foreach (AActor actor in actors)
			{
				PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
				if (runtimeController != null)
				{
					runtimeController.UnmarkActorStagnated(actor, 2);
				}
			}
		}

		// Token: 0x0604747F RID: 291967 RVA: 0x01221560 File Offset: 0x0121F760
		private void TryEnableOwnerConstantTick()
		{
			if (this.IsOwnerConstantTickEnabled || !this.IsExplosiveBarrelClass)
			{
				return;
			}
			TsGameBudgetGroupConfig gameBudgetConfig = base.Entity.GameBudgetConfig;
			uint gameBudgetManagedToken = base.Entity.GameBudgetManagedToken;
			if (gameBudgetConfig == null || gameBudgetManagedToken == 0U)
			{
				return;
			}
			UKuroGameBudgetAllocatorCSharpInterface.SetConstantTick(gameBudgetConfig.GroupName, gameBudgetManagedToken, true, false);
			this.IsOwnerConstantTickEnabled = true;
		}

		// Token: 0x06047480 RID: 291968 RVA: 0x012215B4 File Offset: 0x0121F7B4
		private void TryDisableOwnerConstantTick()
		{
			if (!this.IsOwnerConstantTickEnabled)
			{
				return;
			}
			TsGameBudgetGroupConfig gameBudgetConfig = base.Entity.GameBudgetConfig;
			uint gameBudgetManagedToken = base.Entity.GameBudgetManagedToken;
			if (gameBudgetConfig != null && gameBudgetManagedToken != 0U)
			{
				UKuroGameBudgetAllocatorCSharpInterface.SetConstantTick(gameBudgetConfig.GroupName, gameBudgetManagedToken, false, false);
			}
			this.IsOwnerConstantTickEnabled = false;
		}

		// Token: 0x06047481 RID: 291969 RVA: 0x012215FD File Offset: 0x0121F7FD
		private void TryRegisterPreMoveTick()
		{
			if (this.IsPreMoveTickRegistered)
			{
				return;
			}
			if (!base.Active || !this.ShouldUsePreMoveTick())
			{
				return;
			}
			ComponentForceTickController.Instance.RegisterPreMoveTick(this, new Action<float>(this.OnPreMoveTick));
			this.IsPreMoveTickRegistered = true;
		}

		// Token: 0x06047482 RID: 291970 RVA: 0x01221637 File Offset: 0x0121F837
		private void TryUnregisterPreMoveTick()
		{
			if (!this.IsPreMoveTickRegistered)
			{
				return;
			}
			ComponentForceTickController.Instance.UnregisterPreMoveTick(this);
			this.IsPreMoveTickRegistered = false;
		}

		// Token: 0x06047483 RID: 291971 RVA: 0x01221654 File Offset: 0x0121F854
		private bool ShouldUsePreMoveTick()
		{
			return this.IsWaterBoxTransportClass;
		}

		// Token: 0x06047484 RID: 291972 RVA: 0x0122165C File Offset: 0x0121F85C
		[NullableContext(2)]
		private string NormalizeActorClassPath(string actorBlueprintPath)
		{
			if (string.IsNullOrEmpty(actorBlueprintPath))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorSpawnerComponent] ActorBlueprintPath为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.GetOwnerPbDataId());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			string text = actorBlueprintPath;
			if (!text.EndsWith("_C"))
			{
				text += "_C";
			}
			return text;
		}

		// Token: 0x06047485 RID: 291973 RVA: 0x012216C4 File Offset: 0x0121F8C4
		private unsafe void TryLoadActorClassAsync()
		{
			PathDrivenActorSpawnerComponent.<>c__DisplayClass53_0 CS$<>8__locals1 = new PathDrivenActorSpawnerComponent.<>c__DisplayClass53_0();
			CS$<>8__locals1.<>4__this = this;
			UClass actorClass = this.ActorClass;
			if ((actorClass != null && actorClass.IsValid()) || string.IsNullOrEmpty(this.ActorClassPath) || this.ActorClassLoadHandle != -1)
			{
				return;
			}
			PathDrivenActorSpawnerComponent.<>c__DisplayClass53_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.ActorClassLoadToken + 1;
			this.ActorClassLoadToken = num;
			CS$<>8__locals2.loadToken = num;
			int num2 = ResourceSystem.Instance.LoadAsync<UClass>(this.ActorClassPath, delegate([Nullable(2)] UClass result, string _)
			{
				if (CS$<>8__locals1.loadToken != CS$<>8__locals1.<>4__this.ActorClassLoadToken)
				{
					return;
				}
				CS$<>8__locals1.<>4__this.ActorClassLoadHandle = -1;
				Entity entity = CS$<>8__locals1.<>4__this.Entity;
				if (entity == null || !entity.Valid)
				{
					return;
				}
				if (result == null || !result.IsValid())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.PathDrivenActor;
					ELogAuthor author2 = ELogAuthor.WRY;
					string message2 = "[PathDrivenActorSpawnerComponent] Actor类异步加载失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", CS$<>8__locals1.<>4__this.GetOwnerPbDataId());
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item2 = "ActorBlueprintPath";
					IIntervalSplineSpawn spawnRule2 = CS$<>8__locals1.<>4__this.SpawnRule;
					ptr2 = new ValueTuple<string, object>(item2, (spawnRule2 != null) ? spawnRule2.ActorBlueprintPath : null);
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					CS$<>8__locals1.<>4__this.DesiredRunning = false;
					CS$<>8__locals1.<>4__this.EnterState(EPathDrivenActorSpawnerState.Idle);
					return;
				}
				UObject defaultObject = UKuroStaticLibrary.GetDefaultObject(result.ClassStackOnlyPtr);
				if (!(defaultObject is AActor))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.PathDrivenActor;
					ELogAuthor author3 = ELogAuthor.WRY;
					string message3 = "[PathDrivenActorSpawnerComponent] 异步加载结果不是Actor类";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PbDataId", CS$<>8__locals1.<>4__this.GetOwnerPbDataId());
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
					string item3 = "ActorBlueprintPath";
					IIntervalSplineSpawn spawnRule3 = CS$<>8__locals1.<>4__this.SpawnRule;
					ptr3 = new ValueTuple<string, object>(item3, (spawnRule3 != null) ? spawnRule3.ActorBlueprintPath : null);
					instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					CS$<>8__locals1.<>4__this.DesiredRunning = false;
					CS$<>8__locals1.<>4__this.EnterState(EPathDrivenActorSpawnerState.Idle);
					return;
				}
				CS$<>8__locals1.<>4__this.ActorClass = result;
				AActor aactor = (AActor)defaultObject;
				CS$<>8__locals1.<>4__this.IsWaterBoxTransportClass = aactor.ActorHasTag(FNameUtil.GetDynamicFName("PathDrivenBehavior.WaterBoxTransport").Value);
				CS$<>8__locals1.<>4__this.IsExplosiveBarrelClass = aactor.ActorHasTag(FNameUtil.GetDynamicFName("PathDrivenBehavior.ExplosiveBarrel").Value);
				CS$<>8__locals1.<>4__this.TryRegisterPreMoveTick();
				if (CS$<>8__locals1.<>4__this.State == EPathDrivenActorSpawnerState.Running)
				{
					CS$<>8__locals1.<>4__this.TryEnableOwnerConstantTick();
				}
				if (CS$<>8__locals1.<>4__this.DesiredRunning)
				{
					SceneItemStateComponent stateComp = CS$<>8__locals1.<>4__this.StateComp;
					if (stateComp != null && stateComp.IsInState(SceneItemStateComponent.ESceneItemState.Active))
					{
						CS$<>8__locals1.<>4__this.TryStartRunning();
					}
				}
			}, 100, "js_undefined");
			if (num2 == -1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathDrivenActorSpawnerComponent] Actor类异步加载请求失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.GetOwnerPbDataId());
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "ActorBlueprintPath";
				IIntervalSplineSpawn spawnRule = this.SpawnRule;
				ptr = new ValueTuple<string, object>(item, (spawnRule != null) ? spawnRule.ActorBlueprintPath : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.DesiredRunning = false;
				this.EnterState(EPathDrivenActorSpawnerState.Idle);
				return;
			}
			this.ActorClassLoadHandle = num2;
		}

		// Token: 0x06047486 RID: 291974 RVA: 0x012217D2 File Offset: 0x0121F9D2
		private void CancelActorClassLoad()
		{
			if (this.ActorClassLoadHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.ActorClassLoadHandle);
				this.ActorClassLoadHandle = -1;
			}
			this.ActorClassLoadToken++;
			this.DesiredRunning = false;
		}

		// Token: 0x06047487 RID: 291975 RVA: 0x0122180C File Offset: 0x0121FA0C
		private int? GetOwnerPbDataId()
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return null;
			}
			return new int?(component.GetPbDataId());
		}

		// Token: 0x06047488 RID: 291976 RVA: 0x0122183C File Offset: 0x0121FA3C
		private bool HasStagnationHandleConfig()
		{
			IIntervalSplineSpawn spawnRule = this.SpawnRule;
			IPathDrivenActorInitialSpawnConfig pathDrivenActorInitialSpawnConfig = (spawnRule != null) ? spawnRule.InitialSpawnConfig : null;
			if (pathDrivenActorInitialSpawnConfig == null || !pathDrivenActorInitialSpawnConfig.EnableInitialSpawn || pathDrivenActorInitialSpawnConfig.InitialSpawnHandles == null)
			{
				return false;
			}
			using (List<IPathDrivenActorInitialSpawnHandle>.Enumerator enumerator = pathDrivenActorInitialSpawnConfig.InitialSpawnHandles.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HandleType == EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06047489 RID: 291977 RVA: 0x012218C4 File Offset: 0x0121FAC4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PathDrivenActorSpawnerComponent pathDrivenActorSpawnerComponent = (PathDrivenActorSpawnerComponent)componentTemplate;
			if (base.CanResetComponentProperty("StateComp"))
			{
				if (pathDrivenActorSpawnerComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (pathDrivenActorSpawnerComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PathDrivenActorSpawnerComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SpawnRule"))
			{
				if (pathDrivenActorSpawnerComponent.SpawnRule == null)
				{
					this.SpawnRule = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IIntervalSplineSpawn>(this.SpawnRule), "SpawnRule"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorClassPath"))
			{
				this.ActorClassPath = pathDrivenActorSpawnerComponent.ActorClassPath;
			}
			if (base.CanResetComponentProperty("ActorClass"))
			{
				if (pathDrivenActorSpawnerComponent.ActorClass == null)
				{
					this.ActorClass = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UClass>(this.ActorClass), "ActorClass"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsWaterBoxTransportClass"))
			{
				this.IsWaterBoxTransportClass = pathDrivenActorSpawnerComponent.IsWaterBoxTransportClass;
			}
			if (base.CanResetComponentProperty("IsExplosiveBarrelClass"))
			{
				this.IsExplosiveBarrelClass = pathDrivenActorSpawnerComponent.IsExplosiveBarrelClass;
			}
			if (base.CanResetComponentProperty("IsChainMode"))
			{
				this.IsChainMode = pathDrivenActorSpawnerComponent.IsChainMode;
			}
			if (base.CanResetComponentProperty("ActorClassLoadHandle"))
			{
				this.ActorClassLoadHandle = pathDrivenActorSpawnerComponent.ActorClassLoadHandle;
			}
			if (base.CanResetComponentProperty("ActorClassLoadToken"))
			{
				this.ActorClassLoadToken = pathDrivenActorSpawnerComponent.ActorClassLoadToken;
			}
			if (base.CanResetComponentProperty("DesiredRunning"))
			{
				this.DesiredRunning = pathDrivenActorSpawnerComponent.DesiredRunning;
			}
			if (base.CanResetComponentProperty("State"))
			{
				this.State = pathDrivenActorSpawnerComponent.State;
			}
			if (base.CanResetComponentProperty("IsOwnerConstantTickEnabled"))
			{
				this.IsOwnerConstantTickEnabled = pathDrivenActorSpawnerComponent.IsOwnerConstantTickEnabled;
			}
			if (base.CanResetComponentProperty("IsPreMoveTickRegistered"))
			{
				this.IsPreMoveTickRegistered = pathDrivenActorSpawnerComponent.IsPreMoveTickRegistered;
			}
			if (base.CanResetComponentProperty("TrackRuntimeSet"))
			{
				if (pathDrivenActorSpawnerComponent.TrackRuntimeSet == null)
				{
					this.TrackRuntimeSet = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PathDrivenTrackRuntimeSet>(this.TrackRuntimeSet), "TrackRuntimeSet"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TrackRuntimeBuilder") && pathDrivenActorSpawnerComponent.TrackRuntimeBuilder != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PathDrivenTrackRuntimeBuilder>(this.TrackRuntimeBuilder), "TrackRuntimeBuilder"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("RuntimeController"))
			{
				if (pathDrivenActorSpawnerComponent.RuntimeController == null)
				{
					this.RuntimeController = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PathDrivenActorRuntimeController>(this.RuntimeController), "RuntimeController"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastEntityHitData"))
			{
				if (pathDrivenActorSpawnerComponent.LastEntityHitData == null)
				{
					this.LastEntityHitData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HitInformation>(this.LastEntityHitData), "LastEntityHitData"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040257C1 RID: 153537
		[Nullable(2)]
		private SceneItemStateComponent StateComp;

		// Token: 0x040257C2 RID: 153538
		[Nullable(2)]
		private PathDrivenActorSpawnerComponent Config;

		// Token: 0x040257C3 RID: 153539
		[Nullable(2)]
		private IIntervalSplineSpawn SpawnRule;

		// Token: 0x040257C4 RID: 153540
		[Nullable(2)]
		private string ActorClassPath;

		// Token: 0x040257C5 RID: 153541
		[Nullable(2)]
		private UClass ActorClass;

		// Token: 0x040257C6 RID: 153542
		private bool IsWaterBoxTransportClass;

		// Token: 0x040257C7 RID: 153543
		private bool IsExplosiveBarrelClass;

		// Token: 0x040257C8 RID: 153544
		private bool IsChainMode;

		// Token: 0x040257C9 RID: 153545
		private int ActorClassLoadHandle = -1;

		// Token: 0x040257CA RID: 153546
		private int ActorClassLoadToken;

		// Token: 0x040257CB RID: 153547
		private bool DesiredRunning;

		// Token: 0x040257CC RID: 153548
		private EPathDrivenActorSpawnerState State;

		// Token: 0x040257CD RID: 153549
		private bool IsOwnerConstantTickEnabled;

		// Token: 0x040257CE RID: 153550
		private bool IsPreMoveTickRegistered;

		// Token: 0x040257CF RID: 153551
		[Nullable(2)]
		private PathDrivenTrackRuntimeSet TrackRuntimeSet;

		// Token: 0x040257D0 RID: 153552
		private readonly PathDrivenTrackRuntimeBuilder TrackRuntimeBuilder = new PathDrivenTrackRuntimeBuilder();

		// Token: 0x040257D1 RID: 153553
		[Nullable(2)]
		private PathDrivenActorRuntimeController RuntimeController;

		// Token: 0x040257D2 RID: 153554
		[Nullable(2)]
		private HitInformation LastEntityHitData;
	}
}

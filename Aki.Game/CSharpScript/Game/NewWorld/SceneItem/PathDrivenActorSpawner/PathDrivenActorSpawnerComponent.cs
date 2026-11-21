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
	// Token: 0x02006278 RID: 25208
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorSpawnerComponent : EntityComponent, IDynamicDetectableActorSource
	{
		// Token: 0x17007314 RID: 29460
		// (get) Token: 0x0603CD5E RID: 249182 RVA: 0x0117AB19 File Offset: 0x01178D19
		public override Type[] Dependencies
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

		// Token: 0x0603CD5F RID: 249183 RVA: 0x0117AB3C File Offset: 0x01178D3C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object param = args.GetP1<CreateEntityData>().GetParam<PathDrivenActorSpawnerComponent>();
			this.Config = (param as PathDrivenActorSpawnerComponent);
			PathDrivenActorSpawnerComponent config = this.Config;
			this.SpawnRule = ((config != null) ? config.SpawnRule : null);
			return this.Config != null && this.SpawnRule != null;
		}

		// Token: 0x0603CD60 RID: 249184 RVA: 0x0117AB8C File Offset: 0x01178D8C
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

		// Token: 0x0603CD61 RID: 249185 RVA: 0x0117ADA8 File Offset: 0x01178FA8
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

		// Token: 0x0603CD62 RID: 249186 RVA: 0x0117ADFE File Offset: 0x01178FFE
		protected override void OnEnable()
		{
			this.TryRegisterPreMoveTick();
		}

		// Token: 0x0603CD63 RID: 249187 RVA: 0x0117AE08 File Offset: 0x01179008
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

		// Token: 0x0603CD64 RID: 249188 RVA: 0x0117AEC0 File Offset: 0x011790C0
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

		// Token: 0x0603CD65 RID: 249189 RVA: 0x0117AF03 File Offset: 0x01179103
		protected override void OnDisable(string reason)
		{
			this.TryUnregisterPreMoveTick();
		}

		// Token: 0x0603CD66 RID: 249190 RVA: 0x0117AF0B File Offset: 0x0117910B
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			this.TryUnregisterPreMoveTick();
			this.StopAndClear("[PathDrivenActorSpawnerComponent] OnEnd");
			this.CancelActorClassLoad();
			return true;
		}

		// Token: 0x0603CD67 RID: 249191 RVA: 0x0117AF34 File Offset: 0x01179134
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

		// Token: 0x0603CD68 RID: 249192 RVA: 0x0117AF98 File Offset: 0x01179198
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

		// Token: 0x0603CD69 RID: 249193 RVA: 0x0117AFDB File Offset: 0x011791DB
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

		// Token: 0x0603CD6A RID: 249194 RVA: 0x0117B004 File Offset: 0x01179204
		private void OnEntityHitAlways(HitInformation hitData)
		{
			this.LastEntityHitData = hitData;
		}

		// Token: 0x0603CD6B RID: 249195 RVA: 0x0117B010 File Offset: 0x01179210
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

		// Token: 0x0603CD6C RID: 249196 RVA: 0x0117B0B3 File Offset: 0x011792B3
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

		// Token: 0x0603CD6D RID: 249197 RVA: 0x0117B0D4 File Offset: 0x011792D4
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

		// Token: 0x0603CD6E RID: 249198 RVA: 0x0117B178 File Offset: 0x01179378
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

		// Token: 0x0603CD6F RID: 249199 RVA: 0x0117B1F0 File Offset: 0x011793F0
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

		// Token: 0x0603CD70 RID: 249200 RVA: 0x0117B254 File Offset: 0x01179454
		private void RequestStop(string reason)
		{
			if (!this.DesiredRunning && this.State == EPathDrivenActorSpawnerState.Idle && this.TrackRuntimeSet == null && this.RuntimeController == null)
			{
				return;
			}
			this.StopAndClear(reason);
		}

		// Token: 0x0603CD71 RID: 249201 RVA: 0x0117B27E File Offset: 0x0117947E
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

		// Token: 0x0603CD72 RID: 249202 RVA: 0x0117B2B8 File Offset: 0x011794B8
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

		// Token: 0x0603CD73 RID: 249203 RVA: 0x0117B2D2 File Offset: 0x011794D2
		private void ReleaseTrackSet()
		{
			PathDrivenTrackRuntimeSet trackRuntimeSet = this.TrackRuntimeSet;
			if (trackRuntimeSet != null)
			{
				trackRuntimeSet.Release();
			}
			this.TrackRuntimeSet = null;
		}

		// Token: 0x0603CD74 RID: 249204 RVA: 0x0117B2EC File Offset: 0x011794EC
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

		// Token: 0x0603CD75 RID: 249205 RVA: 0x0117B376 File Offset: 0x01179576
		public bool IsRunning()
		{
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			return runtimeController != null && runtimeController.IsRunning;
		}

		// Token: 0x0603CD76 RID: 249206 RVA: 0x0117B389 File Offset: 0x01179589
		public bool IsBatchSpawned()
		{
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			return runtimeController != null && runtimeController.IsBatchSpawned;
		}

		// Token: 0x0603CD77 RID: 249207 RVA: 0x0117B39C File Offset: 0x0117959C
		public List<AActor> GetDetectableActors()
		{
			PathDrivenActorRuntimeController runtimeController = this.RuntimeController;
			return ((runtimeController != null) ? runtimeController.GetActiveActors() : null) ?? new List<AActor>();
		}

		// Token: 0x0603CD78 RID: 249208 RVA: 0x0117B3BC File Offset: 0x011795BC
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

		// Token: 0x0603CD79 RID: 249209 RVA: 0x0117B414 File Offset: 0x01179614
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

		// Token: 0x0603CD7A RID: 249210 RVA: 0x0117B46C File Offset: 0x0117966C
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

		// Token: 0x0603CD7B RID: 249211 RVA: 0x0117B4C0 File Offset: 0x011796C0
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

		// Token: 0x0603CD7C RID: 249212 RVA: 0x0117B509 File Offset: 0x01179709
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

		// Token: 0x0603CD7D RID: 249213 RVA: 0x0117B543 File Offset: 0x01179743
		private void TryUnregisterPreMoveTick()
		{
			if (!this.IsPreMoveTickRegistered)
			{
				return;
			}
			ComponentForceTickController.Instance.UnregisterPreMoveTick(this);
			this.IsPreMoveTickRegistered = false;
		}

		// Token: 0x0603CD7E RID: 249214 RVA: 0x0117B560 File Offset: 0x01179760
		private bool ShouldUsePreMoveTick()
		{
			return this.IsWaterBoxTransportClass;
		}

		// Token: 0x0603CD7F RID: 249215 RVA: 0x0117B568 File Offset: 0x01179768
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

		// Token: 0x0603CD80 RID: 249216 RVA: 0x0117B5D0 File Offset: 0x011797D0
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

		// Token: 0x0603CD81 RID: 249217 RVA: 0x0117B6DE File Offset: 0x011798DE
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

		// Token: 0x0603CD82 RID: 249218 RVA: 0x0117B718 File Offset: 0x01179918
		private int? GetOwnerPbDataId()
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return null;
			}
			return new int?(component.GetPbDataId());
		}

		// Token: 0x0603CD83 RID: 249219 RVA: 0x0117B748 File Offset: 0x01179948
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

		// Token: 0x0603CD84 RID: 249220 RVA: 0x0117B7D0 File Offset: 0x011799D0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PathDrivenActorSpawnerComponent pathDrivenActorSpawnerComponent = (PathDrivenActorSpawnerComponent)componentTemplate;
			if (pathDrivenActorSpawnerComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (pathDrivenActorSpawnerComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (pathDrivenActorSpawnerComponent.SpawnRule == null)
			{
				this.SpawnRule = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpawnRule), "SpawnRule"))
			{
				return false;
			}
			this.ActorClassPath = pathDrivenActorSpawnerComponent.ActorClassPath;
			if (pathDrivenActorSpawnerComponent.ActorClass == null)
			{
				this.ActorClass = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorClass), "ActorClass"))
			{
				return false;
			}
			this.IsWaterBoxTransportClass = pathDrivenActorSpawnerComponent.IsWaterBoxTransportClass;
			this.IsExplosiveBarrelClass = pathDrivenActorSpawnerComponent.IsExplosiveBarrelClass;
			this.IsChainMode = pathDrivenActorSpawnerComponent.IsChainMode;
			this.ActorClassLoadHandle = pathDrivenActorSpawnerComponent.ActorClassLoadHandle;
			this.ActorClassLoadToken = pathDrivenActorSpawnerComponent.ActorClassLoadToken;
			this.DesiredRunning = pathDrivenActorSpawnerComponent.DesiredRunning;
			this.State = pathDrivenActorSpawnerComponent.State;
			this.IsOwnerConstantTickEnabled = pathDrivenActorSpawnerComponent.IsOwnerConstantTickEnabled;
			this.IsPreMoveTickRegistered = pathDrivenActorSpawnerComponent.IsPreMoveTickRegistered;
			if (pathDrivenActorSpawnerComponent.TrackRuntimeSet == null)
			{
				this.TrackRuntimeSet = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TrackRuntimeSet), "TrackRuntimeSet"))
			{
				return false;
			}
			if (pathDrivenActorSpawnerComponent.TrackRuntimeBuilder != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TrackRuntimeBuilder), "TrackRuntimeBuilder"))
			{
				return false;
			}
			if (pathDrivenActorSpawnerComponent.RuntimeController == null)
			{
				this.RuntimeController = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RuntimeController), "RuntimeController"))
			{
				return false;
			}
			if (pathDrivenActorSpawnerComponent.LastEntityHitData == null)
			{
				this.LastEntityHitData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastEntityHitData), "LastEntityHitData"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007315 RID: 29461
		// (get) Token: 0x0603CD85 RID: 249221 RVA: 0x0117B9B7 File Offset: 0x01179BB7
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007316 RID: 29462
		// (get) Token: 0x0603CD86 RID: 249222 RVA: 0x0117B9BA File Offset: 0x01179BBA
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007317 RID: 29463
		// (get) Token: 0x0603CD87 RID: 249223 RVA: 0x0117B9BD File Offset: 0x01179BBD
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007318 RID: 29464
		// (get) Token: 0x0603CD88 RID: 249224 RVA: 0x0117B9C0 File Offset: 0x01179BC0
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007319 RID: 29465
		// (get) Token: 0x0603CD89 RID: 249225 RVA: 0x0117B9C3 File Offset: 0x01179BC3
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700731A RID: 29466
		// (get) Token: 0x0603CD8A RID: 249226 RVA: 0x0117B9C6 File Offset: 0x01179BC6
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700731B RID: 29467
		// (get) Token: 0x0603CD8B RID: 249227 RVA: 0x0117B9C9 File Offset: 0x01179BC9
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020430 RID: 132144
		[Nullable(2)]
		private SceneItemStateComponent StateComp;

		// Token: 0x04020431 RID: 132145
		[Nullable(2)]
		private PathDrivenActorSpawnerComponent Config;

		// Token: 0x04020432 RID: 132146
		[Nullable(2)]
		private IIntervalSplineSpawn SpawnRule;

		// Token: 0x04020433 RID: 132147
		[Nullable(2)]
		private string ActorClassPath;

		// Token: 0x04020434 RID: 132148
		[Nullable(2)]
		private UClass ActorClass;

		// Token: 0x04020435 RID: 132149
		private bool IsWaterBoxTransportClass;

		// Token: 0x04020436 RID: 132150
		private bool IsExplosiveBarrelClass;

		// Token: 0x04020437 RID: 132151
		private bool IsChainMode;

		// Token: 0x04020438 RID: 132152
		private int ActorClassLoadHandle = -1;

		// Token: 0x04020439 RID: 132153
		private int ActorClassLoadToken;

		// Token: 0x0402043A RID: 132154
		private bool DesiredRunning;

		// Token: 0x0402043B RID: 132155
		private EPathDrivenActorSpawnerState State;

		// Token: 0x0402043C RID: 132156
		private bool IsOwnerConstantTickEnabled;

		// Token: 0x0402043D RID: 132157
		private bool IsPreMoveTickRegistered;

		// Token: 0x0402043E RID: 132158
		[Nullable(2)]
		private PathDrivenTrackRuntimeSet TrackRuntimeSet;

		// Token: 0x0402043F RID: 132159
		private readonly PathDrivenTrackRuntimeBuilder TrackRuntimeBuilder = new PathDrivenTrackRuntimeBuilder();

		// Token: 0x04020440 RID: 132160
		[Nullable(2)]
		private PathDrivenActorRuntimeController RuntimeController;

		// Token: 0x04020441 RID: 132161
		[Nullable(2)]
		private HitInformation LastEntityHitData;
	}
}

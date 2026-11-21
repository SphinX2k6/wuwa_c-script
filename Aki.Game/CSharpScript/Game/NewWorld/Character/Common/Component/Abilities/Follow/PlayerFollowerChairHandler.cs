using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using CSharpScript.Game.Utils.Command;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006378 RID: 25464
	internal class PlayerFollowerChairHandler : PlayerFollowerSwallowHandler, IPlayerFollowerChairHandler, IPlayerFollowerHandler, IChairPresentationHost
	{
		// Token: 0x1700751C RID: 29980
		// (get) Token: 0x0603DB06 RID: 252678 RVA: 0x011DF583 File Offset: 0x011DD783
		// (set) Token: 0x0603DB07 RID: 252679 RVA: 0x011DF58B File Offset: 0x011DD78B
		public int OwnerPlayerId { get; private set; }

		// Token: 0x1700751D RID: 29981
		// (get) Token: 0x0603DB08 RID: 252680 RVA: 0x011DF594 File Offset: 0x011DD794
		// (set) Token: 0x0603DB09 RID: 252681 RVA: 0x011DF59C File Offset: 0x011DD79C
		public long ChairCreatureDataId { get; set; }

		// Token: 0x1700751E RID: 29982
		// (get) Token: 0x0603DB0A RID: 252682 RVA: 0x011DF5A5 File Offset: 0x011DD7A5
		// (set) Token: 0x0603DB0B RID: 252683 RVA: 0x011DF5AD File Offset: 0x011DD7AD
		public bool IsChairShown { get; set; }

		// Token: 0x1700751F RID: 29983
		// (get) Token: 0x0603DB0C RID: 252684 RVA: 0x011DF5B6 File Offset: 0x011DD7B6
		// (set) Token: 0x0603DB0D RID: 252685 RVA: 0x011DF5C4 File Offset: 0x011DD7C4
		Func<bool> IChairPresentationHost.IsLocalOwner
		{
			get
			{
				return new Func<bool>(this.IsLocalOwner);
			}
			set
			{
			}
		}

		// Token: 0x17007520 RID: 29984
		// (get) Token: 0x0603DB0E RID: 252686 RVA: 0x011DF5C6 File Offset: 0x011DD7C6
		// (set) Token: 0x0603DB0F RID: 252687 RVA: 0x011DF5D4 File Offset: 0x011DD7D4
		Action<Entity, EChairPerformanceState> IChairPresentationHost.ChangeChairPerformanceState
		{
			get
			{
				return new Action<Entity, EChairPerformanceState>(this.ChangeChairPerformanceState);
			}
			set
			{
			}
		}

		// Token: 0x17007521 RID: 29985
		// (get) Token: 0x0603DB10 RID: 252688 RVA: 0x011DF5D6 File Offset: 0x011DD7D6
		// (set) Token: 0x0603DB11 RID: 252689 RVA: 0x011DF5E4 File Offset: 0x011DD7E4
		Action<Entity, bool> IChairPresentationHost.SetChairPerformanceControlledExternally
		{
			get
			{
				return new Action<Entity, bool>(this.SetChairPerformanceControlledExternally);
			}
			set
			{
			}
		}

		// Token: 0x17007522 RID: 29986
		// (get) Token: 0x0603DB12 RID: 252690 RVA: 0x011DF5E6 File Offset: 0x011DD7E6
		// (set) Token: 0x0603DB13 RID: 252691 RVA: 0x011DF5F4 File Offset: 0x011DD7F4
		Action IChairPresentationHost.CleanupCurrentChair
		{
			get
			{
				return new Action(this.CleanupCurrentChair);
			}
			set
			{
			}
		}

		// Token: 0x0603DB14 RID: 252692 RVA: 0x011DF5F8 File Offset: 0x011DD7F8
		public static PlayerFollowerChairHandler Create(int ownerPlayerId)
		{
			PlayerFollowerChairHandler handler = new PlayerFollowerChairHandler
			{
				OwnerPlayerId = ownerPlayerId
			};
			handler.RemotePresenter = new ChairRemotePresenter(handler);
			PlotModel instance = PlotModel.Instance;
			handler.IsChairSummonBlockedByPlot = (instance != null && instance.IsInPlot && instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelD);
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(handler.OnChairEntityRemoved));
			if (handler.IsLocalOwner())
			{
				EventSystem.Instance.Add<Entity, global::Vector, bool>(EEventName.AnyCharGravityDirectChanged, new Action<Entity, global::Vector, bool>(handler.OnAnyCharGravityDirectChanged));
				EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(handler.OnPlotNetworkStart));
				EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(handler.OnPlotNetworkEnd));
				EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(handler.OnChangeRole));
				EventSystem.Instance.Add(EEventName.ScenePlayerChanged, new Action(handler.OnObserverChanged));
				EventSystem.Instance.Add(EEventName.ReConnectSuccess, new Action(handler.OnReconnectSuccess));
				handler.IsLocalEventListening = true;
				handler.RegisterRestrictCondition();
				string effectPath = EffectUtil.GetEffectPath("GoBattleMaterial");
				ResourceSystem.Instance.LoadAsync<PD_CharacterControllerDataGroup_C>(effectPath, delegate([Nullable(2)] PD_CharacterControllerDataGroup_C effect, string path)
				{
					if (effect == null)
					{
						return;
					}
					handler.GoBattleMaterial = effect;
				}, 100, "js_undefined");
			}
			return handler;
		}

		// Token: 0x0603DB15 RID: 252693 RVA: 0x011DF7A6 File Offset: 0x011DD9A6
		private PlayerFollowerChairHandler()
		{
		}

		// Token: 0x0603DB16 RID: 252694 RVA: 0x011DF7C4 File Offset: 0x011DD9C4
		public bool IsLocalOwner()
		{
			CreatureModel instance = CreatureModel.Instance;
			int num = (instance != null) ? instance.GetPlayerId() : 0;
			return num <= 0 || this.OwnerPlayerId == num;
		}

		// Token: 0x0603DB17 RID: 252695 RVA: 0x011DF7F4 File Offset: 0x011DD9F4
		private bool IsPlayerInAbnormalGravity()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				obj = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			object obj2 = obj;
			CharacterMoveComponent characterMoveComponent = (obj2 != null) ? obj2.GetComponent<CharacterMoveComponent>() : null;
			return characterMoveComponent != null && !characterMoveComponent.IsStandardGravity;
		}

		// Token: 0x0603DB18 RID: 252696 RVA: 0x011DF83C File Offset: 0x011DDA3C
		private bool CanSummonChair()
		{
			string text = null;
			if (this.IsPlayerInAbnormalGravity())
			{
				text = "当前处于非常规重力";
			}
			else if (this.IsChairSummonBlockedByPlot)
			{
				text = "当前处于非 D 级剧情";
			}
			if (text == null)
			{
				return true;
			}
			Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] " + text + ", 禁止召唤椅子", default(ReadOnlySpan<ValueTuple<string, object>>));
			ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
			return false;
		}

		// Token: 0x0603DB19 RID: 252697 RVA: 0x011DF8AC File Offset: 0x011DDAAC
		private void OnAnyCharGravityDirectChanged(Entity entity, global::Vector newGravityDirect, bool isStandardGravity)
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				worldEntity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 == null || worldEntity2 != entity)
			{
				return;
			}
			if (isStandardGravity)
			{
				return;
			}
			this.RecallChair("PlayerFollowerChairHandler.GravityChanged");
		}

		// Token: 0x0603DB1A RID: 252698 RVA: 0x011DF8EE File Offset: 0x011DDAEE
		private void OnPlotNetworkStart(PlotInfo plotInfo)
		{
			this.IsChairSummonBlockedByPlot = (plotInfo.PlotLevel != EPlotLevel.LevelD);
			if (!this.IsChairSummonBlockedByPlot)
			{
				return;
			}
			this.RecallChair("PlayerFollowerChairHandler.EnterPlot");
		}

		// Token: 0x0603DB1B RID: 252699 RVA: 0x011DF916 File Offset: 0x011DDB16
		private void OnPlotNetworkEnd(PlotResultInfo plotResult)
		{
			this.IsChairSummonBlockedByPlot = false;
		}

		// Token: 0x0603DB1C RID: 252700 RVA: 0x011DF920 File Offset: 0x011DDB20
		private void RegisterRestrictCondition()
		{
			int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(70360001).Value.RestrictConditionGroupId;
			if (restrictConditionGroupId <= 0)
			{
				return;
			}
			ConditionPassCallback conditionPassCallback = new ConditionPassCallback(new TConditionPassCallback(this.OnRestrictConditionCallback), null);
			if (!LevelConditionRegistry.Instance.RegisterConditionGroup(restrictConditionGroupId, conditionPassCallback))
			{
				return;
			}
			this.RestrictConditionGroupId = restrictConditionGroupId;
			this.RestrictConditionCallback = conditionPassCallback;
		}

		// Token: 0x0603DB1D RID: 252701 RVA: 0x011DF982 File Offset: 0x011DDB82
		private void UnregisterRestrictCondition()
		{
			if (this.RestrictConditionGroupId <= 0 || this.RestrictConditionCallback == null)
			{
				return;
			}
			LevelConditionRegistry.Instance.UnRegisterConditionGroup(this.RestrictConditionGroupId, this.RestrictConditionCallback);
			this.RestrictConditionGroupId = 0;
			this.RestrictConditionCallback = null;
		}

		// Token: 0x0603DB1E RID: 252702 RVA: 0x011DF9BA File Offset: 0x011DDBBA
		private void OnRestrictConditionCallback([Nullable(new byte[]
		{
			2,
			0
		})] object[] parameters)
		{
			this.RecallChair("PlayerFollowerChairHandler.RestrictCondition");
		}

		// Token: 0x0603DB1F RID: 252703 RVA: 0x011DF9C7 File Offset: 0x011DDBC7
		private void RecallChair(string reason)
		{
			if (this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			this.HideChair(reason);
		}

		// Token: 0x0603DB20 RID: 252704 RVA: 0x011DF9DB File Offset: 0x011DDBDB
		public override bool HasFollower(long creatureDataId)
		{
			return this.ChairCreatureDataId == creatureDataId;
		}

		// Token: 0x0603DB21 RID: 252705 RVA: 0x011DF9E6 File Offset: 0x011DDBE6
		public long GetChairCreatureDataId()
		{
			return this.ChairCreatureDataId;
		}

		// Token: 0x0603DB22 RID: 252706 RVA: 0x011DF9F0 File Offset: 0x011DDBF0
		private bool IsMySummonedChair(Entity chairEntity)
		{
			if (this.ChairCreatureDataId <= 0L)
			{
				return false;
			}
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity = ((entity != null) ? entity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			return worldEntity2 != null && worldEntity2 == chairEntity;
		}

		// Token: 0x0603DB23 RID: 252707 RVA: 0x011DFA36 File Offset: 0x011DDC36
		public bool IsSummonedChairSitDownNotSettled(Entity chairEntity)
		{
			return this.IsMySummonedChair(chairEntity) && this.RealChairPerformanceState.GetValueOrDefault() != EChairPerformanceState.Seated;
		}

		// Token: 0x0603DB24 RID: 252708 RVA: 0x011DFA54 File Offset: 0x011DDC54
		public bool IsSummonedChairManualSitBlocked(Entity chairEntity)
		{
			return this.IsMySummonedChair(chairEntity) && this.IsChairShown && this.RealChairPerformanceState.GetValueOrDefault() != EChairPerformanceState.StoodUp;
		}

		// Token: 0x0603DB25 RID: 252709 RVA: 0x011DFA7C File Offset: 0x011DDC7C
		public bool IsChairSpaceOccupied(Entity chairEntity)
		{
			return this.IsMySummonedChair(chairEntity) && this.ChairSpaceOccupied;
		}

		// Token: 0x0603DB26 RID: 252710 RVA: 0x011DFA90 File Offset: 0x011DDC90
		[NullableContext(2)]
		public unsafe void SetChairSpaceOccupied([Nullable(0)] Entity chairEntity, bool occupied, AActor triggerActor = null, AActor currentOccupantActor = null)
		{
			if (!this.IsMySummonedChair(chairEntity))
			{
				return;
			}
			bool chairSpaceOccupied = this.ChairSpaceOccupied;
			this.ChairSpaceOccupied = occupied;
			if (chairSpaceOccupied != occupied)
			{
				this.UpdateChairOccupiedSequence(chairEntity, occupied);
			}
			AActor aactor = (triggerActor != null && triggerActor.IsValid()) ? triggerActor : null;
			AActor aactor2 = (currentOccupantActor != null && currentOccupantActor.IsValid()) ? currentOccupantActor : null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.SetChairSpaceOccupied] 椅子空间占用状态";
			<>y__InlineArray10<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray10<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChairId", chairEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ChairCreatureDataId", this.ChairCreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Occupied", occupied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Previous", chairSpaceOccupied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TriggerActor", aactor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("TriggerActorName", (aactor != null) ? aactor.GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("TriggerActorClass", (aactor != null) ? aactor.GetClass().GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("CurrentOccupantActor", aactor2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("CurrentOccupantActorName", (aactor2 != null) ? aactor2.GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("CurrentOccupantActorClass", (aactor2 != null) ? aactor2.GetClass().GetName() : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 10));
		}

		// Token: 0x0603DB27 RID: 252711 RVA: 0x011DFC58 File Offset: 0x011DDE58
		private unsafe void UpdateChairOccupiedSequence(Entity chairEntity, bool occupied)
		{
			if (!this.IsLocalOwner() || !this.IsChairShown || !chairEntity.Valid || !this.IsMySummonedChair(chairEntity))
			{
				return;
			}
			EChairPerformanceState? realChairPerformanceState = this.RealChairPerformanceState;
			if (((realChairPerformanceState != null) ? realChairPerformanceState : this.CurChairPerformanceState).GetValueOrDefault() != EChairPerformanceState.StoodUp)
			{
				return;
			}
			ChairFollowerConfig chairConfig = this.GetChairConfig(chairEntity);
			ULevelSequence ulevelSequence = (chairConfig != null) ? chairConfig.OccupiedSequence : null;
			if (ulevelSequence == null || !ulevelSequence.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler] 椅子占用表现 Sequence 不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChairId", chairEntity.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!this.OccupiedSequenceKeepStateApplied)
			{
				this.OccupiedSequenceKeepStateApplied = true;
				PlayerFollowerChairHandler.ForceSequenceKeepState(ulevelSequence);
			}
			SceneItemActorComponent component = chairEntity.GetComponent<SceneItemActorComponent>();
			AActor aactor = (component != null) ? component.GetInteractionMainActor() : null;
			if (aactor == null || !aactor.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "[PlayerFollowerChairHandler] 椅子占用表现 Sequence 目标预制体 Actor 不可用";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ChairId", chairEntity.Id);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			bool flag = this.ChairOccupiedSequenceActor == null || !this.ChairOccupiedSequenceActor.IsDirectorValid() || this.ChairOccupiedSequenceTargetActor != aactor;
			if (flag)
			{
				this.ClearChairOccupiedSequence();
				this.ChairOccupiedSequenceActor = new SimpleLevelSequenceActor(ulevelSequence);
			}
			SimpleLevelSequenceActor chairOccupiedSequenceActor = this.ChairOccupiedSequenceActor;
			ALevelSequenceActor alevelSequenceActor = (chairOccupiedSequenceActor != null) ? chairOccupiedSequenceActor.GetSequenceActor() : null;
			if (alevelSequenceActor == null || !alevelSequenceActor.IsValid())
			{
				return;
			}
			SimpleLevelSequenceActor chairOccupiedSequenceActor2 = this.ChairOccupiedSequenceActor;
			UMovieSceneSequencePlayer umovieSceneSequencePlayer = (chairOccupiedSequenceActor2 != null) ? chairOccupiedSequenceActor2.GetPlayer() : null;
			if (umovieSceneSequencePlayer == null || !umovieSceneSequencePlayer.IsValid())
			{
				return;
			}
			UMovieScene movieScene = ulevelSequence.GetMovieScene();
			if (movieScene == null)
			{
				return;
			}
			if (flag)
			{
				UKuroSceneInteractionActorSystem ukuroSceneInteractionActorSystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroSceneInteractionActorSystem.StaticClass()) as UKuroSceneInteractionActorSystem;
				if (ukuroSceneInteractionActorSystem == null || !ukuroSceneInteractionActorSystem.IsValid())
				{
					this.ClearChairOccupiedSequence();
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SceneItem;
					ELogAuthor author3 = ELogAuthor.CK;
					string message3 = "[PlayerFollowerChairHandler] 椅子占用表现 Sequence 初始化失败, 场景交互子系统不可用";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ChairId", chairEntity.Id);
					instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return;
				}
				if (umovieSceneSequencePlayer.IsPlaying())
				{
					umovieSceneSequencePlayer.Pause();
				}
				alevelSequenceActor.ResetBindings();
				ukuroSceneInteractionActorSystem.SetSequenceWithTargetLevelActor(alevelSequenceActor, ulevelSequence, aactor);
				this.ChairOccupiedSequenceTargetActor = aactor;
				string text;
				int occupiedSequenceResolvedBindings = PlayerFollowerChairHandler.GetOccupiedSequenceResolvedBindings(ulevelSequence, umovieSceneSequencePlayer, false, out text);
				int num = movieScene.ObjectBindings.Num();
				if (occupiedSequenceResolvedBindings <= 0 || occupiedSequenceResolvedBindings != num)
				{
					string item;
					PlayerFollowerChairHandler.GetOccupiedSequenceResolvedBindings(ulevelSequence, umovieSceneSequencePlayer, true, out item);
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.SceneItem;
					ELogAuthor author4 = ELogAuthor.CK;
					string message4 = "[PlayerFollowerChairHandler] 椅子占用表现 Sequence 播放前绑定未完整解析";
					<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChairId", chairEntity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Sequence", UKismetSystemLibrary.GetPathName(ulevelSequence));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetLevel", UKismetSystemLibrary.GetPathName(aactor.GetLevel()));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ResolvedBindingCount", occupiedSequenceResolvedBindings);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TotalBindingCount", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Bindings", item);
					instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				}
			}
			if (umovieSceneSequencePlayer.IsPlaying())
			{
				umovieSceneSequencePlayer.Pause();
			}
			if (!occupied && umovieSceneSequencePlayer.GetCurrentTime().Time.FrameNumber.Value == 0)
			{
				umovieSceneSequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
				{
					Frame = umovieSceneSequencePlayer.GetEndTime().Time,
					PositionType = EMovieScenePositionType.Frame,
					UpdateMethod = EUpdatePositionMethod.Jump
				});
			}
			if (occupied)
			{
				umovieSceneSequencePlayer.Play();
				return;
			}
			umovieSceneSequencePlayer.PlayReverse();
		}

		// Token: 0x0603DB28 RID: 252712 RVA: 0x011E0013 File Offset: 0x011DE213
		private void ClearChairOccupiedSequence()
		{
			SimpleLevelSequenceActor chairOccupiedSequenceActor = this.ChairOccupiedSequenceActor;
			if (chairOccupiedSequenceActor != null)
			{
				chairOccupiedSequenceActor.Clear();
			}
			this.ChairOccupiedSequenceActor = null;
			this.ChairOccupiedSequenceTargetActor = null;
		}

		// Token: 0x0603DB29 RID: 252713 RVA: 0x011E0034 File Offset: 0x011DE234
		private void ResetChairOccupiedSequence()
		{
			SimpleLevelSequenceActor chairOccupiedSequenceActor = this.ChairOccupiedSequenceActor;
			UMovieSceneSequencePlayer umovieSceneSequencePlayer = (chairOccupiedSequenceActor != null) ? chairOccupiedSequenceActor.GetPlayer() : null;
			if (umovieSceneSequencePlayer != null && umovieSceneSequencePlayer.IsValid())
			{
				umovieSceneSequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
				{
					Frame = umovieSceneSequencePlayer.GetStartTime().Time,
					PositionType = EMovieScenePositionType.Frame,
					UpdateMethod = EUpdatePositionMethod.Jump
				});
				umovieSceneSequencePlayer.StopAtCurrentTime();
			}
			this.ClearChairOccupiedSequence();
		}

		// Token: 0x0603DB2A RID: 252714 RVA: 0x011E0098 File Offset: 0x011DE298
		private void FinishChairOccupiedSequence()
		{
			SimpleLevelSequenceActor chairOccupiedSequenceActor = this.ChairOccupiedSequenceActor;
			UMovieSceneSequencePlayer umovieSceneSequencePlayer = (chairOccupiedSequenceActor != null) ? chairOccupiedSequenceActor.GetPlayer() : null;
			if (umovieSceneSequencePlayer == null || !umovieSceneSequencePlayer.IsValid() || !umovieSceneSequencePlayer.IsPlaying())
			{
				return;
			}
			FFrameTime frame = this.ChairSpaceOccupied ? umovieSceneSequencePlayer.GetEndTime().Time : umovieSceneSequencePlayer.GetStartTime().Time;
			umovieSceneSequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
			{
				Frame = frame,
				PositionType = EMovieScenePositionType.Frame,
				UpdateMethod = EUpdatePositionMethod.Jump
			});
			umovieSceneSequencePlayer.StopAtCurrentTime();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler] 椅子状态切换, 占用半透渐变已推进至终态并停止";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Occupied", this.ChairSpaceOccupied);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603DB2B RID: 252715 RVA: 0x011E014C File Offset: 0x011DE34C
		private static bool IsSitStandStateSwitch(EChairPerformanceState? from, EChairPerformanceState to)
		{
			bool flag = from.GetValueOrDefault() == EChairPerformanceState.Seated || from.GetValueOrDefault() == EChairPerformanceState.StoodUp;
			bool flag2 = to == EChairPerformanceState.Seated || to == EChairPerformanceState.StoodUp;
			return flag && flag2;
		}

		// Token: 0x0603DB2C RID: 252716 RVA: 0x011E0180 File Offset: 0x011DE380
		private static void ForceSequenceKeepState(ULevelSequence sequence)
		{
			sequence.DefaultCompletionMode = EMovieSceneCompletionMode.KeepState;
			UMovieScene movieScene = sequence.GetMovieScene();
			if (movieScene == null)
			{
				return;
			}
			PlayerFollowerChairHandler.ApplyKeepStateToTracks(UKuroSequenceRuntimeFunctionLibrary.GetMasterTracks(sequence));
			TArray<FMovieSceneBinding> objectBindings = movieScene.ObjectBindings;
			for (int i = 0; i < objectBindings.Num(); i++)
			{
				FMovieSceneBinding fmovieSceneBinding = objectBindings.Get(i);
				if (!(fmovieSceneBinding == null))
				{
					FSequencerBindingRuntimeProxy self = UKuroSequenceRuntimeFunctionLibrary.FindBindingById(sequence, fmovieSceneBinding.ObjectGuid);
					if (!(self == null))
					{
						PlayerFollowerChairHandler.ApplyKeepStateToTracks(UKuroSequenceRuntimeFunctionLibrary.GetTracks(self));
					}
				}
			}
			UKuroSequenceRuntimeFunctionLibrary.ResetMovieSceneCompiledData(sequence);
		}

		// Token: 0x0603DB2D RID: 252717 RVA: 0x011E0200 File Offset: 0x011DE400
		private static void ApplyKeepStateToTracks([Nullable(new byte[]
		{
			2,
			0
		})] TArray<UMovieSceneTrack> tracks)
		{
			if (tracks == null)
			{
				return;
			}
			for (int i = 0; i < tracks.Num(); i++)
			{
				TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(tracks.Get(i));
				if (sections != null)
				{
					for (int j = 0; j < sections.Num(); j++)
					{
						sections.Get(j).SetCompletionMode(EMovieSceneCompletionMode.KeepState);
					}
				}
			}
		}

		// Token: 0x0603DB2E RID: 252718 RVA: 0x011E0250 File Offset: 0x011DE450
		private static int GetOccupiedSequenceResolvedBindings(ULevelSequence sequence, UMovieSceneSequencePlayer player, bool includeDetails, out string bindingDetails)
		{
			bindingDetails = string.Empty;
			UMovieScene movieScene = sequence.GetMovieScene();
			if (movieScene == null)
			{
				return 0;
			}
			List<string> list = includeDetails ? new List<string>() : null;
			int num = 0;
			TArray<FMovieSceneBinding> objectBindings = movieScene.ObjectBindings;
			for (int i = 0; i < objectBindings.Num(); i++)
			{
				FMovieSceneBinding fmovieSceneBinding = objectBindings.Get(i);
				if (!(fmovieSceneBinding == null))
				{
					FMovieSceneObjectBindingID objectBinding = new FMovieSceneObjectBindingID
					{
						SequenceID = 0,
						Guid = fmovieSceneBinding.ObjectGuid
					};
					TArray<UObject> boundObjects = player.GetBoundObjects(objectBinding);
					List<string> list2 = includeDetails ? new List<string>() : null;
					bool flag = false;
					if (boundObjects != null)
					{
						foreach (UObject uobject in boundObjects)
						{
							if (uobject != null && uobject.IsValid())
							{
								flag = true;
								if (!includeDetails)
								{
									break;
								}
								if (list2 != null)
								{
									list2.Add(UKismetSystemLibrary.GetPathName(uobject));
								}
							}
						}
					}
					if (flag)
					{
						num++;
					}
					if (list != null && list2 != null)
					{
						string str = flag ? string.Join(",", list2) : "Unresolved";
						list.Add(fmovieSceneBinding.BindingName + ":[" + str + "]");
					}
				}
			}
			bindingDetails = ((list != null) ? string.Join(";", list) : string.Empty);
			return num;
		}

		// Token: 0x0603DB2F RID: 252719 RVA: 0x011E03B4 File Offset: 0x011DE5B4
		public override IReceiver<ICommandTypeAddFollower> AddFollowerReceiver()
		{
			return new Receiver<ICommandTypeAddFollower>
			{
				ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeAddFollower> param)
				{
					PlayerFollowerInfo playerFollowerInfo = ((TCommandHandleParamsAddFollower)param).PlayerFollowerInfo;
					CreatureModel instance = CreatureModel.Instance;
					WorldEntity worldEntity;
					if (instance == null)
					{
						worldEntity = null;
					}
					else
					{
						EntityHandle entity = instance.GetEntity(playerFollowerInfo.CreatureDataId);
						worldEntity = ((entity != null) ? entity.Entity : null);
					}
					WorldEntity worldEntity2 = worldEntity;
					if ((this.ChairCreatureDataId == playerFollowerInfo.CreatureDataId && this.StateReachedListenEntity == worldEntity2 && worldEntity2 != null && worldEntity2.Valid) || this.WaitEntityTasks.ContainsKey(playerFollowerInfo.CreatureDataId))
					{
						return;
					}
					WaitEntityTask waitEntityTask = WaitEntityTask.Create("PlayerFollowerChairHandler.AddFollower", playerFollowerInfo.CreatureDataId, delegate(bool? result)
					{
						this.WaitEntityTasks.Remove(playerFollowerInfo.CreatureDataId);
						if (!result.GetValueOrDefault())
						{
							return;
						}
						CreatureModel instance2 = CreatureModel.Instance;
						WorldEntity worldEntity3;
						if (instance2 == null)
						{
							worldEntity3 = null;
						}
						else
						{
							EntityHandle entity2 = instance2.GetEntity(playerFollowerInfo.CreatureDataId);
							worldEntity3 = ((entity2 != null) ? entity2.Entity : null);
						}
						WorldEntity worldEntity4 = worldEntity3;
						if (worldEntity4 == null)
						{
							return;
						}
						DecorationFollowerComponent component = worldEntity4.GetComponent<DecorationFollowerComponent>();
						if (component == null || !component.IsChair)
						{
							return;
						}
						if (this.ChairCreatureDataId > 0L && this.ChairCreatureDataId != playerFollowerInfo.CreatureDataId)
						{
							this.CleanupCurrentChair();
						}
						this.ChairCreatureDataId = playerFollowerInfo.CreatureDataId;
						this.SetChairPerformanceControlledExternally(worldEntity4, true);
						this.ChangeChairPerformanceState(worldEntity4, EChairPerformanceState.Init);
						CreatureController.Instance.SetEntityEnable(worldEntity4, false, "PlayerFollowerChairHandler.InitHide", false);
					}, 90000, false, true);
					if (waitEntityTask != null)
					{
						this.WaitEntityTasks[playerFollowerInfo.CreatureDataId] = waitEntityTask;
					}
				}
			};
		}

		// Token: 0x0603DB30 RID: 252720 RVA: 0x011E03CD File Offset: 0x011DE5CD
		public void TryStartRemoteVisibilityByChairEntity(Entity chairEntity)
		{
			this.RemotePresenter.TryStartRemoteVisibilityByChairEntity(chairEntity);
			if (!ChairPresentationNet.ApplyCachedPresentation(this.OwnerPlayerId, this.ChairCreatureDataId, this))
			{
				this.RemotePresenter.TryRestoreFromEntityState(chairEntity);
			}
		}

		// Token: 0x0603DB31 RID: 252721 RVA: 0x011E03FC File Offset: 0x011DE5FC
		public void TryRebindLocalChairEntity(Entity chairEntity)
		{
			if (this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			CreatureDataComponent component = chairEntity.GetComponent<CreatureDataComponent>();
			long? num = (component != null) ? new long?(component.GetCreatureDataId()) : null;
			long chairCreatureDataId = this.ChairCreatureDataId;
			if (!(num.GetValueOrDefault() == chairCreatureDataId & num != null) || this.StateReachedListenEntity == chairEntity)
			{
				return;
			}
			this.StopMonitor();
			this.IsChairShown = false;
			this.SetChairPerformanceControlledExternally(chairEntity, true);
			this.ChangeChairPerformanceState(chairEntity, EChairPerformanceState.Init);
			CreatureController.Instance.SetEntityEnable(chairEntity, false, "PlayerFollowerChairHandler.RebindLocalChair", false);
		}

		// Token: 0x0603DB32 RID: 252722 RVA: 0x011E0488 File Offset: 0x011DE688
		[NullableContext(2)]
		public void OnRemoteChairPresentationNotify(long chairCreatureDataId, bool isShow, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation)
		{
			this.RemotePresenter.OnRemotePresentationNotify(chairCreatureDataId, isShow, location, rotation);
		}

		// Token: 0x0603DB33 RID: 252723 RVA: 0x011E049A File Offset: 0x011DE69A
		public override IReceiver<ICommandTypeRemoveFollower> RemoveFollowerReceiver()
		{
			return new Receiver<ICommandTypeRemoveFollower>
			{
				ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeRemoveFollower> param)
				{
					long creatureDataId = ((TCommandHandleParamsRemoveFollower)param).CreatureDataId;
					if (this.ChairCreatureDataId == creatureDataId)
					{
						if (this.IsChairShown)
						{
							this.ReportChairPresentation(false, "PlayerFollowerChairHandler.RemoveFollower");
						}
						this.InvalidateSummonTransaction();
						this.ClearSitDownWaiters();
						this.StopListenSummonSkillEnd();
						this.StopListenSitDownLeave();
						this.RemotePresenter.StopRemoteVisibility();
						this.RestorePendingRole();
						this.SetCameraFollowing(true, "PlayerFollowerChairHandler.RemoveFollower");
						this.ExitSitDown(null, null);
						this.StopMonitor();
						CreatureModel instance = CreatureModel.Instance;
						WorldEntity worldEntity;
						if (instance == null)
						{
							worldEntity = null;
						}
						else
						{
							EntityHandle entity = instance.GetEntity(creatureDataId);
							worldEntity = ((entity != null) ? entity.Entity : null);
						}
						WorldEntity worldEntity2 = worldEntity;
						if (worldEntity2 != null)
						{
							this.ChangeChairPerformanceState(worldEntity2, EChairPerformanceState.Init);
							this.SetChairPerformanceControlledExternally(worldEntity2, false);
						}
						this.StopListenStateReached();
						this.ClearChairOccupiedSequence();
						this.IsChairShown = false;
						this.ChairCreatureDataId = 0L;
						this.CurChairPerformanceState = null;
						this.RealChairPerformanceState = null;
					}
					WaitEntityTask waitEntityTask;
					if (this.WaitEntityTasks.TryGetValue(creatureDataId, out waitEntityTask))
					{
						waitEntityTask.Cancel();
						this.WaitEntityTasks.Remove(creatureDataId);
					}
				}
			};
		}

		// Token: 0x0603DB34 RID: 252724 RVA: 0x011E04B4 File Offset: 0x011DE6B4
		[NullableContext(2)]
		private void ExitSitDown(Entity removingChairEntity = null, Entity playerEntity = null)
		{
			if (playerEntity == null)
			{
				SceneTeamModel instance = SceneTeamModel.Instance;
				Entity entity;
				if (instance == null)
				{
					entity = null;
				}
				else
				{
					EntityHandle getCurrentEntity = instance.GetCurrentEntity;
					entity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
				}
				playerEntity = entity;
			}
			CharacterActionComponent characterActionComponent = (playerEntity != null) ? playerEntity.GetComponent<CharacterActionComponent>() : null;
			if (characterActionComponent != null)
			{
				characterActionComponent.ReleaseSummonSitDownLock("PlayerFollowerChairHandler.ExitSitDown");
			}
			if (characterActionComponent == null || !characterActionComponent.IsSitDown)
			{
				return;
			}
			if (characterActionComponent.Chair != null)
			{
				if (!this.IsMySummonedChair(characterActionComponent.Chair))
				{
					return;
				}
			}
			else if (removingChairEntity == null || !this.IsMySummonedChair(removingChairEntity))
			{
				return;
			}
			characterActionComponent.PreLeaveSitDownAction("PlayerFollowerChairHandler.RemoveFollower");
		}

		// Token: 0x0603DB35 RID: 252725 RVA: 0x011E0539 File Offset: 0x011DE739
		public void ExitSitDownDueToOverlap()
		{
			this.ExitSitDown(null, null);
		}

		// Token: 0x0603DB36 RID: 252726 RVA: 0x011E0543 File Offset: 0x011DE743
		public void ExitSitDownDueToPlayerMove()
		{
			this.ExitSitDown(null, null);
		}

		// Token: 0x0603DB37 RID: 252727 RVA: 0x011E054D File Offset: 0x011DE74D
		public void RecallChairDueToTickGroundCheck()
		{
			this.RecallChair("PlayerFollowerChairHandler.TickGroundCheck");
		}

		// Token: 0x0603DB38 RID: 252728 RVA: 0x011E055A File Offset: 0x011DE75A
		public void HideChairDueToLeaveRange(Entity chairEntity, int transactionVersion)
		{
			if (transactionVersion != this.SummonTransactionVersion || !this.IsChairShown || !this.IsMySummonedChair(chairEntity))
			{
				return;
			}
			this.HideChair("PlayerFollowerChairHandler.AutoHide");
		}

		// Token: 0x0603DB39 RID: 252729 RVA: 0x011E0584 File Offset: 0x011DE784
		public void CleanupCurrentChair()
		{
			if (this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			long chairCreatureDataId = this.ChairCreatureDataId;
			if (this.IsChairShown)
			{
				this.ReportChairPresentation(false, "PlayerFollowerChairHandler.CleanupCurrentChair");
			}
			this.RemotePresenter.StopRemoteVisibility();
			if (this.IsLocalOwner())
			{
				this.InvalidateSummonTransaction();
				this.ClearSitDownWaiters();
				this.StopListenSummonSkillEnd();
				this.StopListenSitDownLeave();
				this.RestorePendingRole();
				this.SetCameraFollowing(true, "PlayerFollowerChairHandler.CleanupCurrentChair");
				this.ExitSitDown(null, null);
				this.StopMonitor();
			}
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity = ((entity != null) ? entity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 != null)
			{
				this.ChangeChairPerformanceState(worldEntity2, EChairPerformanceState.Init);
				this.SetChairPerformanceControlledExternally(worldEntity2, false);
				CreatureController.Instance.SetEntityEnable(worldEntity2, false, "PlayerFollowerChairHandler.ReplaceHide", false);
			}
			this.StopListenStateReached();
			this.ClearChairOccupiedSequence();
			this.IsChairShown = false;
			this.ChairCreatureDataId = 0L;
			this.CurChairPerformanceState = null;
			this.RealChairPerformanceState = null;
			ChairPresentationNet.RemoveSnapshot(this.OwnerPlayerId, chairCreatureDataId);
		}

		// Token: 0x0603DB3A RID: 252730 RVA: 0x011E068C File Offset: 0x011DE88C
		private unsafe void OnChairEntityRemoved(ERemoveEntityType removeType, EntityHandle handle)
		{
			Entity stateReachedListenEntity = this.StateReachedListenEntity;
			if (stateReachedListenEntity == null || handle.Entity != stateReachedListenEntity || !this.IsMySummonedChair(stateReachedListenEntity))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler] 椅子实体被直接移除, 清理坐下与召唤状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.ChairCreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RemoveType", removeType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.IsLocalOwner())
			{
				if (this.IsChairShown)
				{
					this.ReportChairPresentation(false, "PlayerFollowerChairHandler.ChairEntityRemoved");
				}
				this.InvalidateSummonTransaction();
				this.ClearSitDownWaiters();
				this.StopListenSummonSkillEnd();
				this.StopListenSitDownLeave();
				this.RestorePendingRole();
				this.SetCameraFollowing(true, "PlayerFollowerChairHandler.ChairEntityRemoved");
				this.ExitSitDown(stateReachedListenEntity, null);
				this.StopMonitor();
			}
			this.RemotePresenter.StopRemoteVisibility();
			this.StopListenStateReached();
			this.ClearChairOccupiedSequence();
			this.IsChairShown = false;
			this.CurChairPerformanceState = null;
			this.RealChairPerformanceState = null;
		}

		// Token: 0x0603DB3B RID: 252731 RVA: 0x011E07A4 File Offset: 0x011DE9A4
		public override void OnClear()
		{
			EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnChairEntityRemoved));
			if (this.IsLocalEventListening)
			{
				EventSystem.Instance.Remove<Entity, global::Vector, bool>(EEventName.AnyCharGravityDirectChanged, new Action<Entity, global::Vector, bool>(this.OnAnyCharGravityDirectChanged));
				EventSystem.Instance.Remove<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotNetworkStart));
				EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
				EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
				EventSystem.Instance.Remove(EEventName.ScenePlayerChanged, new Action(this.OnObserverChanged));
				EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.OnReconnectSuccess));
				this.IsLocalEventListening = false;
			}
			this.UnregisterRestrictCondition();
			this.RemotePresenter.StopRemoteVisibility();
			if (this.IsLocalOwner())
			{
				this.InvalidateSummonTransaction();
				this.ClearSitDownWaiters();
				this.StopListenSummonSkillEnd();
				this.StopListenSitDownLeave();
				this.RestorePendingRole();
				SceneTeamModel instance = SceneTeamModel.Instance;
				if (instance != null)
				{
					EntityHandle getCurrentEntity = instance.GetCurrentEntity;
					if (getCurrentEntity != null)
					{
						WorldEntity entity = getCurrentEntity.Entity;
						if (entity != null)
						{
							CharacterActionComponent component = entity.GetComponent<CharacterActionComponent>();
							if (component != null)
							{
								component.ReleaseSummonSitDownLock("PlayerFollowerChairHandler.OnClear");
							}
						}
					}
				}
				this.ExitSitDown(null, null);
				this.SetCameraFollowing(true, "PlayerFollowerChairHandler.OnClear");
				this.StopMonitor();
			}
			this.SummonEvaluator.Dispose();
			this.ResetChairOccupiedSequence();
			this.ChairCreatureDataId = 0L;
			this.IsChairShown = false;
			this.CurChairPerformanceState = null;
			this.RealChairPerformanceState = null;
			this.IsChairSummonBlockedByPlot = false;
			this.StopListenStateReached();
			foreach (WaitEntityTask waitEntityTask in this.WaitEntityTasks.Values)
			{
				waitEntityTask.Cancel();
			}
			this.WaitEntityTasks.Clear();
		}

		// Token: 0x0603DB3C RID: 252732 RVA: 0x011E09A8 File Offset: 0x011DEBA8
		public void SummonChair()
		{
			if (!ChairSummonEvaluator.DebugDraw)
			{
				this.SummonEvaluator.StopDebugDraw();
			}
			if (!this.CanSummonChair())
			{
				return;
			}
			if (this.ChairCreatureDataId <= 0L)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 椅子实体尚未就绪, 无法召唤", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity = ((entity != null) ? entity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler] 召唤时找不到椅子实体";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", this.ChairCreatureDataId);
				instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ChairFollowerConfig chairConfig = this.GetChairConfig(worldEntity2);
			if (chairConfig == null)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 椅子实体缺少配置组件或类型非椅子, 无法召唤", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!chairConfig.IsLoaded)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 椅子配置尚未加载完成, 跳过本次召唤", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsBlockedByExistingChair(worldEntity2, chairConfig))
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 范围内已存在椅子, 本次召唤直接失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				return;
			}
			IChairSummonResult chairSummonResult = this.EvaluateSummonLocation(worldEntity2, chairConfig);
			if (chairSummonResult == null)
			{
				return;
			}
			if (this.IsChairShown)
			{
				Log.Instance.Info(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 椅子已召唤, 先立刻隐藏再重新召唤", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.HideChair("PlayerFollowerChairHandler.ReSummonHide");
			}
			this.InvalidateSummonTransaction();
			this.ClearSitDownWaiters();
			this.StopListenSummonSkillEnd();
			this.StopListenSitDownLeave();
			this.RestorePendingRole();
			SceneTeamModel instance3 = SceneTeamModel.Instance;
			WorldEntity worldEntity3;
			if (instance3 == null)
			{
				worldEntity3 = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance3.GetCurrentEntity;
				worldEntity3 = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			WorldEntity worldEntity4 = worldEntity3;
			CharacterActorComponent characterActorComponent = (worldEntity4 != null) ? worldEntity4.GetComponent<CharacterActorComponent>() : null;
			if (worldEntity4 == null || characterActorComponent == null)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 缺少玩家组件, 无法召唤自动坐下", default(ReadOnlySpan<ValueTuple<string, object>>));
				ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				return;
			}
			int num = this.SummonTransactionVersion + 1;
			this.SummonTransactionVersion = num;
			int num2 = num;
			this.PendingRoleActorComp = characterActorComponent;
			this.PendingRoleDisableHandle = characterActorComponent.DisableActor("PlayerFollowerChairHandler.SummonChairHideRole");
			this.PlaceChair(worldEntity2, chairSummonResult);
			this.PendingChairEntity = worldEntity2;
			this.PendingSitDownPlayerEntity = worldEntity4;
			this.PendingSummonTransactionVersion = num2;
			this.StartListenSummonSkillEnd(worldEntity4, num2);
		}

		// Token: 0x0603DB3D RID: 252733 RVA: 0x011E0BF4 File Offset: 0x011DEDF4
		private void StartListenSummonSkillEnd(Entity playerEntity, int transactionVersion)
		{
			if (this.SummonSkillEndListening)
			{
				return;
			}
			this.SummonSkillEndCallback = delegate(int entityId, int skillId)
			{
				this.OnSummonSkillEnd(entityId, skillId, transactionVersion);
			};
			EventSystem.Instance.AddWithTarget<int, int>(playerEntity, EEventName.OnSkillEnd, this.SummonSkillEndCallback);
			this.SummonSkillEndListening = true;
		}

		// Token: 0x0603DB3E RID: 252734 RVA: 0x011E0C4C File Offset: 0x011DEE4C
		private void StopListenSummonSkillEnd()
		{
			if (!this.SummonSkillEndListening)
			{
				return;
			}
			Entity pendingSitDownPlayerEntity = this.PendingSitDownPlayerEntity;
			if (pendingSitDownPlayerEntity != null && pendingSitDownPlayerEntity.Valid && this.SummonSkillEndCallback != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, int>(this.PendingSitDownPlayerEntity, EEventName.OnSkillEnd, this.SummonSkillEndCallback);
			}
			this.SummonSkillEndListening = false;
			this.SummonSkillEndCallback = null;
			this.PendingChairEntity = null;
			this.PendingSitDownPlayerEntity = null;
			this.PendingSummonTransactionVersion = 0;
		}

		// Token: 0x0603DB3F RID: 252735 RVA: 0x011E0CBC File Offset: 0x011DEEBC
		private void OnSummonSkillEnd(int entityId, int skillId, int transactionVersion)
		{
			if (skillId != 210062)
			{
				return;
			}
			if (transactionVersion != this.SummonTransactionVersion || transactionVersion != this.PendingSummonTransactionVersion)
			{
				return;
			}
			Entity pendingSitDownPlayerEntity = this.PendingSitDownPlayerEntity;
			Entity pendingChairEntity = this.PendingChairEntity;
			this.StopListenSummonSkillEnd();
			bool flag = pendingChairEntity != null && pendingChairEntity.Valid && this.IsMySummonedChair(pendingChairEntity);
			if (pendingSitDownPlayerEntity != null && pendingSitDownPlayerEntity.Valid && (pendingChairEntity != null && pendingChairEntity.Valid) && flag)
			{
				CharacterSkillComponent component = pendingSitDownPlayerEntity.GetComponent<CharacterSkillComponent>();
				EEndSkillReason? eendSkillReason;
				if (component == null)
				{
					eendSkillReason = null;
				}
				else
				{
					Skill skill = component.GetSkill(210062);
					if (skill == null)
					{
						eendSkillReason = null;
					}
					else
					{
						EndSkillInfo endSkillInfo = skill.EndSkillInfo;
						eendSkillReason = ((endSkillInfo != null) ? new EEndSkillReason?(endSkillInfo.Reason) : null);
					}
				}
				EEndSkillReason? eendSkillReason2 = eendSkillReason;
				if (eendSkillReason2 != null)
				{
					EEndSkillReason? eendSkillReason3 = eendSkillReason2;
					EEndSkillReason eendSkillReason4 = EEndSkillReason.Default;
					if (!(eendSkillReason3.GetValueOrDefault() == eendSkillReason4 & eendSkillReason3 != null))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SceneItem;
						ELogAuthor author = ELogAuthor.CK;
						string message = "[PlayerFollowerChairHandler] 召唤技能被打断, 放弃坐下并回滚重显角色";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EndReason", eendSkillReason2);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.RollbackSummon(pendingChairEntity);
						return;
					}
				}
				this.EnterSitDownAfterSummonSkill(pendingChairEntity, pendingSitDownPlayerEntity, transactionVersion);
				return;
			}
			Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 召唤技能结束时玩家或椅子实体已失效或椅子已不归当前事务, 放弃坐下并回滚", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (pendingChairEntity != null && pendingChairEntity.Valid && flag)
			{
				this.RollbackSummon(pendingChairEntity);
				return;
			}
			this.InvalidateSummonTransaction();
			this.RestorePendingRole();
		}

		// Token: 0x0603DB40 RID: 252736 RVA: 0x011E0E28 File Offset: 0x011DF028
		private unsafe void EnterSitDownAfterSummonSkill(Entity chairEntity, Entity playerEntity, int transactionVersion)
		{
			if (transactionVersion != this.SummonTransactionVersion)
			{
				return;
			}
			CharacterActorComponent component = playerEntity.GetComponent<CharacterActorComponent>();
			CharacterActionComponent component2 = playerEntity.GetComponent<CharacterActionComponent>();
			BaseTagComponent component3 = playerEntity.GetComponent<BaseTagComponent>();
			if (component == null || component2 == null || component3 == null)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 召唤技能结束后缺少玩家组件, 无法发起坐下, 回滚重显角色", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.RollbackSummon(chairEntity);
				ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				return;
			}
			bool flag = component2.EnterSitDownAction(chairEntity, 1, false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.EnterSitDownAfterSummonSkill] 召唤技能结束, 发起自动坐下";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChairId", chairEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ChairActive", chairEntity.Active);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SitSuccess", flag);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!flag)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 自动坐下发起失败, 回滚重显角色", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.RollbackSummon(chairEntity);
				ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				return;
			}
			component2.ApplySummonSitDownLock("PlayerFollowerChairHandler.EnterSitDownAfterSummonSkill");
			this.SetCameraFollowing(false, "PlayerFollowerChairHandler.EnterSitDownAfterSummonSkill");
			if (component.Valid)
			{
				component.EnableActor(this.PendingRoleDisableHandle);
				this.PlayGoBattleMaterialOnRole(component);
			}
			this.PendingRoleDisableHandle = 0;
			this.PendingRoleActorComp = null;
			this.ShowChair(chairEntity, transactionVersion);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneItem;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[PlayerFollowerChairHandler.EnterSitDownAfterSummonSkill] 已注册坐下.持续 tag 监听, 等待服务器下发";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ChairId", chairEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TimeoutMs", 3000);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			ITagTask sitDownCompleteTagTask = null;
			sitDownCompleteTagTask = component3.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下.持续"]), delegate(int tagId, bool tagExist)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "[PlayerFollowerChairHandler] 坐下.持续 tag 变更回调";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("tagId", tagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("tagExist", tagExist);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				if (transactionVersion != this.SummonTransactionVersion || this.SitDownCompleteTagTask != sitDownCompleteTagTask || !tagExist || !this.IsValidSitDownCompletion(chairEntity, playerEntity))
				{
					return;
				}
				this.OnSitDownComplete(chairEntity, playerEntity, transactionVersion, sitDownCompleteTagTask);
			}, null);
			this.SitDownCompleteTagTask = sitDownCompleteTagTask;
			TimerHandle sitDownTimeoutTimer = null;
			sitDownTimeoutTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (this.SitDownTimeoutTimer == sitDownTimeoutTimer)
				{
					this.SitDownTimeoutTimer = null;
				}
				if (transactionVersion != this.SummonTransactionVersion || !chairEntity.Valid || !this.IsMySummonedChair(chairEntity))
				{
					return;
				}
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 坐下完成超时, 回滚重显角色", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearSitDownWaiters();
				this.RollbackSummon(chairEntity);
			}, 3000f, null, null, true, 1f);
			this.SitDownTimeoutTimer = sitDownTimeoutTimer;
		}

		// Token: 0x0603DB41 RID: 252737 RVA: 0x011E10EC File Offset: 0x011DF2EC
		private bool IsValidSitDownCompletion(Entity chairEntity, Entity playerEntity)
		{
			if (!playerEntity.Valid || !chairEntity.Valid || !this.IsMySummonedChair(chairEntity))
			{
				return false;
			}
			CharacterActionComponent component = playerEntity.GetComponent<CharacterActionComponent>();
			return component != null && component.IsSitDown && component.Chair == chairEntity;
		}

		// Token: 0x0603DB42 RID: 252738 RVA: 0x011E1134 File Offset: 0x011DF334
		private unsafe void OnSitDownComplete(Entity chairEntity, Entity playerEntity, int transactionVersion, [Nullable(2)] ITagTask sitDownCompleteTagTask)
		{
			if (transactionVersion != this.SummonTransactionVersion || this.SitDownCompleteTagTask != sitDownCompleteTagTask || !this.IsValidSitDownCompletion(chairEntity, playerEntity))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.OnSitDownComplete] 坐下落位完成, 落位收尾";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChairId", chairEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ChairValid", chairEntity.Valid);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ClearSitDownWaiters();
			CharacterActionComponent component = playerEntity.GetComponent<CharacterActionComponent>();
			if (component != null)
			{
				component.ReleaseSummonSitDownLock("PlayerFollowerChairHandler.OnSitDownComplete");
			}
			this.StartListenSitDownLeave(chairEntity, playerEntity, transactionVersion);
			this.SetCameraFollowing(true, "PlayerFollowerChairHandler.OnSitDownComplete");
			this.ReportChairPresentation(true, "PlayerFollowerChairHandler.OnSitDownComplete");
			this.StartMonitor();
		}

		// Token: 0x0603DB43 RID: 252739 RVA: 0x011E120C File Offset: 0x011DF40C
		private unsafe void StartListenSitDownLeave(Entity chairEntity, [Nullable(2)] Entity playerEntity, int transactionVersion)
		{
			BaseTagComponent baseTagComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseTagComponent>() : null;
			CharacterActionComponent actionComp = (playerEntity != null) ? playerEntity.GetComponent<CharacterActionComponent>() : null;
			if (playerEntity == null || baseTagComponent == null || actionComp == null)
			{
				return;
			}
			if (this.SitDownLeaveListenEntity == playerEntity && this.SitDownLeaveTransactionVersion == transactionVersion && this.SitDownLeaveTagTask != null)
			{
				return;
			}
			this.StopListenSitDownLeave();
			ITagTask sitDownLeaveTagTask = null;
			sitDownLeaveTagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下.持续"]), delegate(int tagId, bool tagExist)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler.StartListenSitDownLeave] 坐下.持续 tag 回调";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TagId", tagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagExist", tagExist);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ChairValid", chairEntity.Valid);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				bool flag = transactionVersion != this.SummonTransactionVersion;
				bool flag2 = this.SitDownLeaveTagTask != sitDownLeaveTagTask;
				bool flag3 = actionComp.Chair != chairEntity;
				if (flag || flag2 || !chairEntity.Valid || flag3)
				{
					return;
				}
				this.ChangeChairPerformanceState(chairEntity, tagExist ? EChairPerformanceState.Seated : EChairPerformanceState.StoodUp);
				if (tagExist)
				{
					this.ReportChairPresentation(true, "PlayerFollowerChairHandler.SitDownLeaveReSit");
				}
			}, null);
			this.SitDownLeaveTagTask = sitDownLeaveTagTask;
			this.SitDownLeaveListenEntity = playerEntity;
			this.SitDownLeaveTransactionVersion = transactionVersion;
			if (actionComp.Chair == chairEntity && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下.持续"]))
			{
				this.ChangeChairPerformanceState(chairEntity, EChairPerformanceState.Seated);
				this.ReportChairPresentation(true, "PlayerFollowerChairHandler.SitDownLeaveRebind");
			}
		}

		// Token: 0x0603DB44 RID: 252740 RVA: 0x011E131E File Offset: 0x011DF51E
		private void StopListenSitDownLeave()
		{
			ITagTask sitDownLeaveTagTask = this.SitDownLeaveTagTask;
			this.SitDownLeaveTagTask = null;
			this.SitDownLeaveListenEntity = null;
			this.SitDownLeaveTransactionVersion = 0;
			if (sitDownLeaveTagTask == null)
			{
				return;
			}
			sitDownLeaveTagTask.EndTask();
		}

		// Token: 0x0603DB45 RID: 252741 RVA: 0x011E1348 File Offset: 0x011DF548
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			Entity entity = ((oldEntity != null) ? oldEntity.Entity : null) ?? this.SitDownLeaveListenEntity;
			CharacterActionComponent characterActionComponent = (entity != null) ? entity.GetComponent<CharacterActionComponent>() : null;
			bool flag = ((characterActionComponent != null) ? characterActionComponent.Chair : null) != null && this.IsMySummonedChair(characterActionComponent.Chair);
			if (this.SummonSkillEndListening || this.PendingRoleActorComp != null || this.SitDownCompleteTagTask != null || (flag && characterActionComponent != null && characterActionComponent.IsSitDown))
			{
				this.ExitSitDown(null, entity);
				this.RecallChair("PlayerFollowerChairHandler.ChangeRole");
				return;
			}
			if (this.SitDownLeaveTagTask == null || this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			WorldEntity worldEntity = (newEntity != null) ? newEntity.Entity : null;
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity2;
			if (instance == null)
			{
				worldEntity2 = null;
			}
			else
			{
				EntityHandle entity2 = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity2 = ((entity2 != null) ? entity2.Entity : null);
			}
			WorldEntity worldEntity3 = worldEntity2;
			if (worldEntity == null || !worldEntity.Valid || (worldEntity3 == null || !worldEntity3.Valid))
			{
				return;
			}
			this.StartListenSitDownLeave(worldEntity3, worldEntity, this.SummonTransactionVersion);
		}

		// Token: 0x0603DB46 RID: 252742 RVA: 0x011E1450 File Offset: 0x011DF650
		private void ShowChair(Entity chairEntity, int transactionVersion)
		{
			this.ResetChairOccupiedSequence();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.ShowChair] 显示椅子";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChairId", chairEntity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ChangeChairPerformanceState(chairEntity, EChairPerformanceState.Init);
			CreatureController.Instance.SetEntityEnable(chairEntity, true, "PlayerFollowerChairHandler.SummonChair", false);
			this.IsChairShown = true;
			this.ReportChairPresentation(true, "PlayerFollowerChairHandler.ShowChair");
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (transactionVersion != this.SummonTransactionVersion || !chairEntity.Valid || !this.IsChairShown || !this.IsMySummonedChair(chairEntity))
				{
					return;
				}
				this.ChangeChairPerformanceState(chairEntity, EChairPerformanceState.Seated);
			}, null, null);
		}

		// Token: 0x0603DB47 RID: 252743 RVA: 0x011E1504 File Offset: 0x011DF704
		public void ChangeChairPerformanceState(Entity chairEntity, EChairPerformanceState chairState)
		{
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.ChangeChairPerformanceState] 切换椅子表现状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChairState", chairState);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SceneItemActorComponent sceneItemActorComponent = component as SceneItemActorComponent;
			if (sceneItemActorComponent == null)
			{
				return;
			}
			this.StartListenStateReached(chairEntity);
			EKuroSceneInteractionState ekuroSceneInteractionState = PlayerFollowerChairHandler.ChairPerformanceStateToSceneState[chairState];
			if (sceneItemActorComponent.GetSceneInteractionLevelHandleId() == -1)
			{
				sceneItemActorComponent.LoadSceneInteractionLevel(ekuroSceneInteractionState, false);
				this.CurChairPerformanceState = new EChairPerformanceState?(chairState);
				this.RealChairPerformanceState = new EChairPerformanceState?(chairState);
				return;
			}
			EChairPerformanceState? curChairPerformanceState = this.CurChairPerformanceState;
			if (curChairPerformanceState.GetValueOrDefault() == chairState & curChairPerformanceState != null)
			{
				return;
			}
			if (PlayerFollowerChairHandler.IsSitStandStateSwitch(this.CurChairPerformanceState, chairState))
			{
				this.FinishChairOccupiedSequence();
			}
			this.CurChairPerformanceState = new EChairPerformanceState?(chairState);
			this.ChairConvergeRetryCount = 0;
			sceneItemActorComponent.SwitchToState(ekuroSceneInteractionState, true, false);
		}

		// Token: 0x0603DB48 RID: 252744 RVA: 0x011E15DC File Offset: 0x011DF7DC
		private void StartListenStateReached(Entity chairEntity)
		{
			if (this.StateReachedListenEntity == chairEntity)
			{
				return;
			}
			this.StopListenStateReached();
			this.CurChairPerformanceState = null;
			this.RealChairPerformanceState = null;
			EventSystem.Instance.AddWithTarget<int, EKuroSceneInteractionState>(chairEntity, EEventName.OnSceneInteractionStateReached, new Action<int, EKuroSceneInteractionState>(this.OnChairStateReached));
			this.StateReachedListenEntity = chairEntity;
		}

		// Token: 0x0603DB49 RID: 252745 RVA: 0x011E1638 File Offset: 0x011DF838
		private void StopListenStateReached()
		{
			if (this.ChairConvergeTimer != null)
			{
				TimerSystem.Instance.Remove(this.ChairConvergeTimer);
				this.ChairConvergeTimer = null;
			}
			this.PendingChairConvergeState = null;
			this.ChairConvergeRetryCount = 0;
			if (this.StateReachedListenEntity != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, EKuroSceneInteractionState>(this.StateReachedListenEntity, EEventName.OnSceneInteractionStateReached, new Action<int, EKuroSceneInteractionState>(this.OnChairStateReached));
				this.StateReachedListenEntity = null;
			}
		}

		// Token: 0x0603DB4A RID: 252746 RVA: 0x011E16AC File Offset: 0x011DF8AC
		private unsafe void OnChairStateReached(int handle, EKuroSceneInteractionState state)
		{
			Entity stateReachedListenEntity = this.StateReachedListenEntity;
			SceneItemActorComponent sceneItemActorComponent = ((stateReachedListenEntity != null) ? stateReachedListenEntity.GetComponent<BaseActorComponent>() : null) as SceneItemActorComponent;
			if (sceneItemActorComponent == null || sceneItemActorComponent.GetSceneInteractionLevelHandleId() != handle)
			{
				return;
			}
			EChairPerformanceState value;
			EChairPerformanceState? echairPerformanceState = PlayerFollowerChairHandler.SceneStateToChairPerformanceState.TryGetValue(state, out value) ? new EChairPerformanceState?(value) : null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.OnChairStateReached] 椅子状态机到达目标态";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sceneState", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("realPerformanceState", echairPerformanceState);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (echairPerformanceState == null)
			{
				return;
			}
			this.RealChairPerformanceState = new EChairPerformanceState?(echairPerformanceState.Value);
			if (echairPerformanceState.Value == EChairPerformanceState.StoodUp && this.ChairSpaceOccupied && this.StateReachedListenEntity != null)
			{
				this.UpdateChairOccupiedSequence(this.StateReachedListenEntity, true);
			}
			if (this.CurChairPerformanceState != null)
			{
				EChairPerformanceState value2 = echairPerformanceState.Value;
				EChairPerformanceState? curChairPerformanceState = this.CurChairPerformanceState;
				if (!(value2 == curChairPerformanceState.GetValueOrDefault() & curChairPerformanceState != null))
				{
					this.ScheduleChairConverge();
					return;
				}
			}
			this.ChairConvergeRetryCount = 0;
		}

		// Token: 0x0603DB4B RID: 252747 RVA: 0x011E17FA File Offset: 0x011DF9FA
		private void ScheduleChairConverge()
		{
			this.PendingChairConvergeState = this.CurChairPerformanceState;
			if (this.ChairConvergeTimer != null)
			{
				return;
			}
			this.ChairConvergeTimer = TimerSystem.Instance.Next(delegate(float _)
			{
				this.ChairConvergeTimer = null;
				this.ExecuteChairConverge();
			}, null, null);
		}

		// Token: 0x0603DB4C RID: 252748 RVA: 0x011E1830 File Offset: 0x011DFA30
		private unsafe void ExecuteChairConverge()
		{
			EChairPerformanceState? pendingChairConvergeState = this.PendingChairConvergeState;
			this.PendingChairConvergeState = null;
			if (pendingChairConvergeState != null)
			{
				EChairPerformanceState value = pendingChairConvergeState.Value;
				EChairPerformanceState? echairPerformanceState = this.CurChairPerformanceState;
				if (value == echairPerformanceState.GetValueOrDefault() & echairPerformanceState != null)
				{
					Entity stateReachedListenEntity = this.StateReachedListenEntity;
					SceneItemActorComponent sceneItemActorComponent = ((stateReachedListenEntity != null) ? stateReachedListenEntity.GetComponent<BaseActorComponent>() : null) as SceneItemActorComponent;
					if (sceneItemActorComponent == null)
					{
						return;
					}
					int sceneInteractionLevelHandleId = sceneItemActorComponent.GetSceneInteractionLevelHandleId();
					if (sceneInteractionLevelHandleId != -1)
					{
						echairPerformanceState = this.RealChairPerformanceState;
						EChairPerformanceState? echairPerformanceState2 = pendingChairConvergeState;
						if (!(echairPerformanceState.GetValueOrDefault() == echairPerformanceState2.GetValueOrDefault() & echairPerformanceState != null == (echairPerformanceState2 != null)))
						{
							if (this.ChairConvergeRetryCount >= 2)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.SceneItem;
								ELogAuthor author = ELogAuthor.CK;
								string message = "[PlayerFollowerChairHandler.ExecuteChairConverge] 检测到状态反复切换疑似死循环, 中断本次切换; 请排查椅子状态资产 IsForceSetState / TransitionMap 配置";
								<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", sceneInteractionLevelHandleId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reached", this.RealChairPerformanceState);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("targetPerformanceState", pendingChairConvergeState);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("retryCount", this.ChairConvergeRetryCount);
								instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
								return;
							}
							this.ChairConvergeRetryCount++;
							SceneInteractionManager.Get().SwitchSceneInteractionToState(sceneInteractionLevelHandleId, PlayerFollowerChairHandler.ChairPerformanceStateToSceneState[pendingChairConvergeState.Value], true, true, false);
							return;
						}
					}
					this.ChairConvergeRetryCount = 0;
					return;
				}
			}
		}

		// Token: 0x0603DB4D RID: 252749 RVA: 0x011E19B8 File Offset: 0x011DFBB8
		public void SetChairPerformanceControlledExternally(Entity chairEntity, bool controlled)
		{
			SceneItemStateComponent component = chairEntity.GetComponent<SceneItemStateComponent>();
			if (component == null)
			{
				return;
			}
			component.SetPerformanceStateControlledExternally(controlled);
		}

		// Token: 0x0603DB4E RID: 252750 RVA: 0x011E19D8 File Offset: 0x011DFBD8
		private void RollbackSummon(Entity chairEntity)
		{
			this.InvalidateSummonTransaction();
			this.ClearSitDownWaiters();
			this.StopListenSummonSkillEnd();
			this.RestorePendingRole();
			this.SetCameraFollowing(true, "PlayerFollowerChairHandler.RollbackSummon");
			this.ExitSitDown(null, null);
			CreatureController.Instance.SetEntityEnable(chairEntity, false, "PlayerFollowerChairHandler.RollbackSummon", false);
			this.ReportChairPresentation(false, "PlayerFollowerChairHandler.RollbackSummon");
			this.IsChairShown = false;
		}

		// Token: 0x0603DB4F RID: 252751 RVA: 0x011E1A36 File Offset: 0x011DFC36
		private void RestorePendingRole()
		{
			CharacterActorComponent pendingRoleActorComp = this.PendingRoleActorComp;
			if (pendingRoleActorComp != null && pendingRoleActorComp.Valid)
			{
				this.PendingRoleActorComp.EnableActor(this.PendingRoleDisableHandle);
			}
			this.PendingRoleDisableHandle = 0;
			this.PendingRoleActorComp = null;
		}

		// Token: 0x0603DB50 RID: 252752 RVA: 0x011E1A6C File Offset: 0x011DFC6C
		private void ClearSitDownWaiters()
		{
			ITagTask sitDownCompleteTagTask = this.SitDownCompleteTagTask;
			if (sitDownCompleteTagTask != null)
			{
				sitDownCompleteTagTask.EndTask();
			}
			this.SitDownCompleteTagTask = null;
			if (this.SitDownTimeoutTimer != null)
			{
				TimerSystem.Instance.Remove(this.SitDownTimeoutTimer);
				this.SitDownTimeoutTimer = null;
			}
		}

		// Token: 0x0603DB51 RID: 252753 RVA: 0x011E1AA6 File Offset: 0x011DFCA6
		private void InvalidateSummonTransaction()
		{
			this.SummonTransactionVersion++;
			this.PendingSummonTransactionVersion = 0;
		}

		// Token: 0x0603DB52 RID: 252754 RVA: 0x011E1ABD File Offset: 0x011DFCBD
		[return: Nullable(2)]
		public ChairFollowerConfig GetChairConfig(Entity chairEntity)
		{
			DecorationFollowerComponent component = chairEntity.GetComponent<DecorationFollowerComponent>();
			if (component == null)
			{
				return null;
			}
			return component.ChairConfig;
		}

		// Token: 0x0603DB53 RID: 252755 RVA: 0x011E1AD0 File Offset: 0x011DFCD0
		private bool IsBlockedByExistingChair(Entity chairEntity, ChairFollowerConfig chairConfig)
		{
			float reSummonBlockDistanceSquared = chairConfig.ReSummonBlockDistanceSquared;
			if (reSummonBlockDistanceSquared <= 0f)
			{
				return false;
			}
			if (!this.IsChairShown)
			{
				return false;
			}
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			SceneTeamModel instance = SceneTeamModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				obj = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			object obj2 = obj;
			BaseActorComponent baseActorComponent = (obj2 != null) ? obj2.GetComponent<BaseActorComponent>() : null;
			return component != null && baseActorComponent != null && global::Vector.DistSquared(component.ActorLocationProxy, baseActorComponent.ActorLocationProxy) <= (double)reSummonBlockDistanceSquared;
		}

		// Token: 0x0603DB54 RID: 252756 RVA: 0x011E1B4C File Offset: 0x011DFD4C
		[return: Nullable(2)]
		private unsafe IChairSummonResult EvaluateSummonLocation(Entity chairEntity, ChairFollowerConfig chairConfig)
		{
			IChairSummonResult chairSummonResult = this.SummonEvaluator.Evaluate(chairEntity, chairConfig);
			if (!chairSummonResult.Success)
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler] 召唤选点失败: " + chairSummonResult.FailReason, default(ReadOnlySpan<ValueTuple<string, object>>));
				ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				return null;
			}
			ChairPresentationNet.ChairPresentationSnapshot chairPresentationSnapshot = ChairPresentationNet.FindNearbyShownChair(this.ChairCreatureDataId, chairSummonResult.FinalLocation, (double)chairConfig.MinDistanceToOtherChairSquared);
			if (chairPresentationSnapshot != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler] 椅子召唤距离过近";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MinDistanceToOtherChair", (float)Math.Sqrt((double)chairConfig.MinDistanceToOtherChairSquared));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NearbyPlayerId", chairPresentationSnapshot.PlayerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NearbyChairCreatureDataId", chairPresentationSnapshot.ChairCreatureDataId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				return null;
			}
			return chairSummonResult;
		}

		// Token: 0x0603DB55 RID: 252757 RVA: 0x011E1C78 File Offset: 0x011DFE78
		private void PlaceChair(Entity chairEntity, IChairSummonResult result)
		{
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return;
			}
			component.SetActorLocationAndRotation(result.FinalLocation.ToUeVector(false), global::Rotator.Create(0f, result.Yaw, 0f).ToUeRotator(), "ChairSummonRelocate", false, null);
		}

		// Token: 0x0603DB56 RID: 252758 RVA: 0x011E1CCC File Offset: 0x011DFECC
		private unsafe void ReportChairPresentation(bool isShow, string reason)
		{
			if (!this.IsLocalOwner() || this.OwnerPlayerId <= 0 || this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler] 上报椅子表现";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsShow", isShow);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!isShow)
			{
				ChairPresentationNet.SendChairPresentationPush(this.ChairCreatureDataId, false, null, null);
				return;
			}
			CreatureModel instance2 = CreatureModel.Instance;
			object obj;
			if (instance2 == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle entity = instance2.GetEntity(this.ChairCreatureDataId);
				obj = ((entity != null) ? entity.Entity : null);
			}
			object obj2 = obj;
			BaseActorComponent baseActorComponent = (obj2 != null) ? obj2.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return;
			}
			ChairPresentationNet.SendChairPresentationPush(this.ChairCreatureDataId, isShow, baseActorComponent.ActorLocationProxy, baseActorComponent.ActorRotationProxy);
		}

		// Token: 0x0603DB57 RID: 252759 RVA: 0x011E1DAB File Offset: 0x011DFFAB
		private void OnObserverChanged()
		{
			this.ReportChairPresentation(this.IsChairShown, "PlayerFollowerChairHandler.ScenePlayerChanged");
		}

		// Token: 0x0603DB58 RID: 252760 RVA: 0x011E1DBE File Offset: 0x011DFFBE
		private void OnReconnectSuccess()
		{
			this.ReportChairPresentation(this.IsChairShown, "PlayerFollowerChairHandler.ReConnectSuccess");
			this.MigrateSitDownLeaveToCurrentPlayer();
		}

		// Token: 0x0603DB59 RID: 252761 RVA: 0x011E1DD8 File Offset: 0x011DFFD8
		private void MigrateSitDownLeaveToCurrentPlayer()
		{
			if (this.SitDownLeaveTagTask == null || this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity = ((entity != null) ? entity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			SceneTeamModel instance2 = SceneTeamModel.Instance;
			WorldEntity worldEntity3;
			if (instance2 == null)
			{
				worldEntity3 = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance2.GetCurrentEntity;
				worldEntity3 = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			WorldEntity worldEntity4 = worldEntity3;
			if (worldEntity2 == null || !worldEntity2.Valid || (worldEntity4 == null || !worldEntity4.Valid))
			{
				return;
			}
			this.StartListenSitDownLeave(worldEntity2, worldEntity4, this.SummonTransactionVersion);
		}

		// Token: 0x0603DB5A RID: 252762 RVA: 0x011E1E6C File Offset: 0x011E006C
		private void HideChair(string reason)
		{
			this.InvalidateSummonTransaction();
			this.ClearSitDownWaiters();
			this.StopListenSummonSkillEnd();
			this.StopListenSitDownLeave();
			this.RestorePendingRole();
			this.SetCameraFollowing(true, "PlayerFollowerChairHandler.HideChair: " + reason);
			this.ExitSitDown(null, null);
			this.StopMonitor();
			this.ResetChairOccupiedSequence();
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity = ((entity != null) ? entity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 != null)
			{
				this.ChangeChairPerformanceState(worldEntity2, EChairPerformanceState.Init);
				CreatureController.Instance.SetEntityEnable(worldEntity2, false, reason, false);
			}
			this.ReportChairPresentation(false, reason);
			this.IsChairShown = false;
		}

		// Token: 0x0603DB5B RID: 252763 RVA: 0x011E1F09 File Offset: 0x011E0109
		[NullableContext(2)]
		private void PlayGoBattleMaterialOnRole(CharacterActorComponent playerActorComp)
		{
			if (this.GoBattleMaterial == null)
			{
				return;
			}
			if (playerActorComp == null || !playerActorComp.Valid)
			{
				return;
			}
			CharRenderingComponent charRenderingComponent = playerActorComp.Actor.CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.AddMaterialControllerDataGroup(this.GoBattleMaterial);
		}

		// Token: 0x0603DB5C RID: 252764 RVA: 0x011E1F44 File Offset: 0x011E0144
		private unsafe void SetCameraFollowing(bool follow, string reason)
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent == null)
			{
				return;
			}
			if (fightCameraLogicComponent.IsFollowing == follow)
			{
				return;
			}
			fightCameraLogicComponent.IsFollowing = follow;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler] SetCameraFollowing";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Follow", follow);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603DB5D RID: 252765 RVA: 0x011E1FDA File Offset: 0x011E01DA
		private void StartMonitor()
		{
			this.EnsureChairRuntimeMonitor();
		}

		// Token: 0x0603DB5E RID: 252766 RVA: 0x011E1FE2 File Offset: 0x011E01E2
		private void StopMonitor()
		{
			this.StopChairRuntimeMonitor();
		}

		// Token: 0x0603DB5F RID: 252767 RVA: 0x011E1FEC File Offset: 0x011E01EC
		private void EnsureChairRuntimeMonitor()
		{
			if (this.ChairRuntimeMonitor != null)
			{
				return;
			}
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(this.ChairCreatureDataId);
				worldEntity = ((entity != null) ? entity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			ChairFollowerConfig chairFollowerConfig = (worldEntity2 == null) ? null : this.GetChairConfig(worldEntity2);
			if (worldEntity2 == null || chairFollowerConfig == null)
			{
				return;
			}
			this.ChairRuntimeMonitor = new ChairMonitor(worldEntity2, chairFollowerConfig, this, this.SummonTransactionVersion);
		}

		// Token: 0x0603DB60 RID: 252768 RVA: 0x011E204F File Offset: 0x011E024F
		private void StopChairRuntimeMonitor()
		{
			ChairMonitor chairRuntimeMonitor = this.ChairRuntimeMonitor;
			if (chairRuntimeMonitor != null)
			{
				chairRuntimeMonitor.Dispose();
			}
			this.ChairRuntimeMonitor = null;
			this.ChairSpaceOccupied = false;
		}

		// Token: 0x04020B6C RID: 133996
		private const string WAIT_REASON = "PlayerFollowerChairHandler.AddFollower";

		// Token: 0x04020B6D RID: 133997
		private const string SUMMON_FAIL_TIP_TEXT_ID = "Flying_Tip_002";

		// Token: 0x04020B6E RID: 133998
		private const int CHAIR_SIT_DOWN_TYPE = 1;

		// Token: 0x04020B6F RID: 133999
		private const int CHAIR_ITEM_ID = 70360001;

		// Token: 0x04020B70 RID: 134000
		private const int SUMMON_CHAIR_SKILL_ID = 210062;

		// Token: 0x04020B71 RID: 134001
		private const int SIT_DOWN_COMPLETE_TIMEOUT_MS = 3000;

		// Token: 0x04020B72 RID: 134002
		private const int CHAIR_CONVERGE_MAX_RETRY_COUNT = 2;

		// Token: 0x04020B73 RID: 134003
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EChairPerformanceState, EKuroSceneInteractionState> ChairPerformanceStateToSceneState = new Dictionary<EChairPerformanceState, EKuroSceneInteractionState>
		{
			{
				EChairPerformanceState.Init,
				EKuroSceneInteractionState.State3
			},
			{
				EChairPerformanceState.Seated,
				EKuroSceneInteractionState.State2
			},
			{
				EChairPerformanceState.StoodUp,
				EKuroSceneInteractionState.State1
			}
		};

		// Token: 0x04020B74 RID: 134004
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EKuroSceneInteractionState, EChairPerformanceState> SceneStateToChairPerformanceState = new Dictionary<EKuroSceneInteractionState, EChairPerformanceState>
		{
			{
				EKuroSceneInteractionState.State3,
				EChairPerformanceState.Init
			},
			{
				EKuroSceneInteractionState.State2,
				EChairPerformanceState.Seated
			},
			{
				EKuroSceneInteractionState.State1,
				EChairPerformanceState.StoodUp
			}
		};

		// Token: 0x04020B77 RID: 134007
		private readonly Dictionary<long, WaitEntityTask> WaitEntityTasks = new Dictionary<long, WaitEntityTask>();

		// Token: 0x04020B78 RID: 134008
		[Nullable(2)]
		private ChairMonitor ChairRuntimeMonitor;

		// Token: 0x04020B79 RID: 134009
		private bool ChairSpaceOccupied;

		// Token: 0x04020B7A RID: 134010
		[Nullable(2)]
		private SimpleLevelSequenceActor ChairOccupiedSequenceActor;

		// Token: 0x04020B7B RID: 134011
		[Nullable(2)]
		private AActor ChairOccupiedSequenceTargetActor;

		// Token: 0x04020B7C RID: 134012
		private bool OccupiedSequenceKeepStateApplied;

		// Token: 0x04020B7D RID: 134013
		private ChairRemotePresenter RemotePresenter;

		// Token: 0x04020B7E RID: 134014
		private int SummonTransactionVersion;

		// Token: 0x04020B7F RID: 134015
		private readonly ChairSummonEvaluator SummonEvaluator = new ChairSummonEvaluator();

		// Token: 0x04020B81 RID: 134017
		private EChairPerformanceState? CurChairPerformanceState;

		// Token: 0x04020B82 RID: 134018
		private EChairPerformanceState? RealChairPerformanceState;

		// Token: 0x04020B83 RID: 134019
		[Nullable(2)]
		private Entity StateReachedListenEntity;

		// Token: 0x04020B84 RID: 134020
		private int ChairConvergeRetryCount;

		// Token: 0x04020B85 RID: 134021
		private EChairPerformanceState? PendingChairConvergeState;

		// Token: 0x04020B86 RID: 134022
		[Nullable(2)]
		private TimerHandle ChairConvergeTimer;

		// Token: 0x04020B87 RID: 134023
		[Nullable(2)]
		private PD_CharacterControllerDataGroup_C GoBattleMaterial;

		// Token: 0x04020B88 RID: 134024
		private int PendingRoleDisableHandle;

		// Token: 0x04020B89 RID: 134025
		[Nullable(2)]
		private CharacterActorComponent PendingRoleActorComp;

		// Token: 0x04020B8A RID: 134026
		[Nullable(2)]
		private ITagTask SitDownCompleteTagTask;

		// Token: 0x04020B8B RID: 134027
		[Nullable(2)]
		private ITagTask SitDownLeaveTagTask;

		// Token: 0x04020B8C RID: 134028
		[Nullable(2)]
		private Entity SitDownLeaveListenEntity;

		// Token: 0x04020B8D RID: 134029
		private int SitDownLeaveTransactionVersion;

		// Token: 0x04020B8E RID: 134030
		[Nullable(2)]
		private TimerHandle SitDownTimeoutTimer;

		// Token: 0x04020B8F RID: 134031
		private bool SummonSkillEndListening;

		// Token: 0x04020B90 RID: 134032
		[Nullable(2)]
		private Entity PendingChairEntity;

		// Token: 0x04020B91 RID: 134033
		[Nullable(2)]
		private Entity PendingSitDownPlayerEntity;

		// Token: 0x04020B92 RID: 134034
		private int PendingSummonTransactionVersion;

		// Token: 0x04020B93 RID: 134035
		[Nullable(2)]
		private Action<int, int> SummonSkillEndCallback;

		// Token: 0x04020B94 RID: 134036
		private bool IsChairSummonBlockedByPlot;

		// Token: 0x04020B95 RID: 134037
		[Nullable(2)]
		private ConditionPassCallback RestrictConditionCallback;

		// Token: 0x04020B96 RID: 134038
		private int RestrictConditionGroupId;

		// Token: 0x04020B97 RID: 134039
		private bool IsLocalEventListening;
	}
}

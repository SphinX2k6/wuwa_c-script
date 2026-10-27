using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using CSharpScript.Game.Utils.Command;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200714A RID: 29002
	internal class PlayerFollowerChairHandler : PlayerFollowerSwallowHandler, IPlayerFollowerChairHandler, IPlayerFollowerHandler, IChairPresentationHost
	{
		// Token: 0x17009D49 RID: 40265
		// (get) Token: 0x06046CB4 RID: 289972 RVA: 0x011D6BA3 File Offset: 0x011D4DA3
		// (set) Token: 0x06046CB5 RID: 289973 RVA: 0x011D6BAB File Offset: 0x011D4DAB
		public int OwnerPlayerId { get; private set; }

		// Token: 0x17009D4A RID: 40266
		// (get) Token: 0x06046CB6 RID: 289974 RVA: 0x011D6BB4 File Offset: 0x011D4DB4
		// (set) Token: 0x06046CB7 RID: 289975 RVA: 0x011D6BBC File Offset: 0x011D4DBC
		public long ChairCreatureDataId { get; set; }

		// Token: 0x17009D4B RID: 40267
		// (get) Token: 0x06046CB8 RID: 289976 RVA: 0x011D6BC5 File Offset: 0x011D4DC5
		// (set) Token: 0x06046CB9 RID: 289977 RVA: 0x011D6BCD File Offset: 0x011D4DCD
		public bool IsChairShown { get; set; }

		// Token: 0x17009D4C RID: 40268
		// (get) Token: 0x06046CBA RID: 289978 RVA: 0x011D6BD6 File Offset: 0x011D4DD6
		// (set) Token: 0x06046CBB RID: 289979 RVA: 0x011D6BE4 File Offset: 0x011D4DE4
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

		// Token: 0x17009D4D RID: 40269
		// (get) Token: 0x06046CBC RID: 289980 RVA: 0x011D6BE6 File Offset: 0x011D4DE6
		// (set) Token: 0x06046CBD RID: 289981 RVA: 0x011D6BF4 File Offset: 0x011D4DF4
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

		// Token: 0x17009D4E RID: 40270
		// (get) Token: 0x06046CBE RID: 289982 RVA: 0x011D6BF6 File Offset: 0x011D4DF6
		// (set) Token: 0x06046CBF RID: 289983 RVA: 0x011D6C04 File Offset: 0x011D4E04
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

		// Token: 0x17009D4F RID: 40271
		// (get) Token: 0x06046CC0 RID: 289984 RVA: 0x011D6C06 File Offset: 0x011D4E06
		// (set) Token: 0x06046CC1 RID: 289985 RVA: 0x011D6C14 File Offset: 0x011D4E14
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

		// Token: 0x06046CC2 RID: 289986 RVA: 0x011D6C18 File Offset: 0x011D4E18
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

		// Token: 0x06046CC3 RID: 289987 RVA: 0x011D6DC6 File Offset: 0x011D4FC6
		private PlayerFollowerChairHandler()
		{
		}

		// Token: 0x06046CC4 RID: 289988 RVA: 0x011D6DE4 File Offset: 0x011D4FE4
		public bool IsLocalOwner()
		{
			CreatureModel instance = CreatureModel.Instance;
			int num = (instance != null) ? instance.GetPlayerId() : 0;
			return num <= 0 || this.OwnerPlayerId == num;
		}

		// Token: 0x06046CC5 RID: 289989 RVA: 0x011D6E14 File Offset: 0x011D5014
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

		// Token: 0x06046CC6 RID: 289990 RVA: 0x011D6E5C File Offset: 0x011D505C
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

		// Token: 0x06046CC7 RID: 289991 RVA: 0x011D6ECC File Offset: 0x011D50CC
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

		// Token: 0x06046CC8 RID: 289992 RVA: 0x011D6F0E File Offset: 0x011D510E
		private void OnPlotNetworkStart(PlotInfo plotInfo)
		{
			this.IsChairSummonBlockedByPlot = (plotInfo.PlotLevel != EPlotLevel.LevelD);
			if (!this.IsChairSummonBlockedByPlot)
			{
				return;
			}
			this.RecallChair("PlayerFollowerChairHandler.EnterPlot");
		}

		// Token: 0x06046CC9 RID: 289993 RVA: 0x011D6F36 File Offset: 0x011D5136
		private void OnPlotNetworkEnd(PlotResultInfo plotResult)
		{
			this.IsChairSummonBlockedByPlot = false;
		}

		// Token: 0x06046CCA RID: 289994 RVA: 0x011D6F40 File Offset: 0x011D5140
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

		// Token: 0x06046CCB RID: 289995 RVA: 0x011D6FA2 File Offset: 0x011D51A2
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

		// Token: 0x06046CCC RID: 289996 RVA: 0x011D6FDA File Offset: 0x011D51DA
		private void OnRestrictConditionCallback([Nullable(new byte[]
		{
			2,
			0
		})] object[] parameters)
		{
			this.RecallChair("PlayerFollowerChairHandler.RestrictCondition");
		}

		// Token: 0x06046CCD RID: 289997 RVA: 0x011D6FE7 File Offset: 0x011D51E7
		private void RecallChair(string reason)
		{
			if (this.ChairCreatureDataId <= 0L)
			{
				return;
			}
			this.HideChair(reason);
		}

		// Token: 0x06046CCE RID: 289998 RVA: 0x011D6FFB File Offset: 0x011D51FB
		public override bool HasFollower(long creatureDataId)
		{
			return this.ChairCreatureDataId == creatureDataId;
		}

		// Token: 0x06046CCF RID: 289999 RVA: 0x011D7006 File Offset: 0x011D5206
		public long GetChairCreatureDataId()
		{
			return this.ChairCreatureDataId;
		}

		// Token: 0x06046CD0 RID: 290000 RVA: 0x011D7010 File Offset: 0x011D5210
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

		// Token: 0x06046CD1 RID: 290001 RVA: 0x011D7056 File Offset: 0x011D5256
		public bool IsSummonedChairSitDownNotSettled(Entity chairEntity)
		{
			return this.IsMySummonedChair(chairEntity) && this.RealChairPerformanceState.GetValueOrDefault() != EChairPerformanceState.Seated;
		}

		// Token: 0x06046CD2 RID: 290002 RVA: 0x011D7074 File Offset: 0x011D5274
		public bool IsSummonedChairManualSitBlocked(Entity chairEntity)
		{
			return this.IsMySummonedChair(chairEntity) && this.IsChairShown && this.RealChairPerformanceState.GetValueOrDefault() != EChairPerformanceState.StoodUp;
		}

		// Token: 0x06046CD3 RID: 290003 RVA: 0x011D709C File Offset: 0x011D529C
		public bool IsChairSpaceOccupied(Entity chairEntity)
		{
			return this.IsMySummonedChair(chairEntity) && this.ChairSpaceOccupied;
		}

		// Token: 0x06046CD4 RID: 290004 RVA: 0x011D70B0 File Offset: 0x011D52B0
		[NullableContext(2)]
		public unsafe void SetChairSpaceOccupied([Nullable(0)] Entity chairEntity, bool occupied, AActor triggerActor = null, AActor currentOccupantActor = null)
		{
			if (!this.IsMySummonedChair(chairEntity))
			{
				return;
			}
			bool chairSpaceOccupied = this.ChairSpaceOccupied;
			this.ChairSpaceOccupied = occupied;
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

		// Token: 0x06046CD5 RID: 290005 RVA: 0x011D7269 File Offset: 0x011D5469
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

		// Token: 0x06046CD6 RID: 290006 RVA: 0x011D7282 File Offset: 0x011D5482
		public void TryStartRemoteVisibilityByChairEntity(Entity chairEntity)
		{
			this.RemotePresenter.TryStartRemoteVisibilityByChairEntity(chairEntity);
			if (!ChairPresentationNet.ApplyCachedPresentation(this.OwnerPlayerId, this.ChairCreatureDataId, this))
			{
				this.RemotePresenter.TryRestoreFromEntityState(chairEntity);
			}
		}

		// Token: 0x06046CD7 RID: 290007 RVA: 0x011D72B0 File Offset: 0x011D54B0
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

		// Token: 0x06046CD8 RID: 290008 RVA: 0x011D733C File Offset: 0x011D553C
		[NullableContext(2)]
		public void OnRemoteChairPresentationNotify(long chairCreatureDataId, bool isShow, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation)
		{
			this.RemotePresenter.OnRemotePresentationNotify(chairCreatureDataId, isShow, location, rotation);
		}

		// Token: 0x06046CD9 RID: 290009 RVA: 0x011D734E File Offset: 0x011D554E
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

		// Token: 0x06046CDA RID: 290010 RVA: 0x011D7368 File Offset: 0x011D5568
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

		// Token: 0x06046CDB RID: 290011 RVA: 0x011D73ED File Offset: 0x011D55ED
		public void ExitSitDownDueToOverlap()
		{
			this.ExitSitDown(null, null);
		}

		// Token: 0x06046CDC RID: 290012 RVA: 0x011D73F7 File Offset: 0x011D55F7
		public void ExitSitDownDueToPlayerMove()
		{
			this.ExitSitDown(null, null);
		}

		// Token: 0x06046CDD RID: 290013 RVA: 0x011D7401 File Offset: 0x011D5601
		public void RecallChairDueToTickGroundCheck()
		{
			this.RecallChair("PlayerFollowerChairHandler.TickGroundCheck");
		}

		// Token: 0x06046CDE RID: 290014 RVA: 0x011D740E File Offset: 0x011D560E
		public void HideChairDueToLeaveRange(Entity chairEntity, int transactionVersion)
		{
			if (transactionVersion != this.SummonTransactionVersion || !this.IsChairShown || !this.IsMySummonedChair(chairEntity))
			{
				return;
			}
			this.HideChair("PlayerFollowerChairHandler.AutoHide");
		}

		// Token: 0x06046CDF RID: 290015 RVA: 0x011D7438 File Offset: 0x011D5638
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
			this.IsChairShown = false;
			this.ChairCreatureDataId = 0L;
			this.CurChairPerformanceState = null;
			this.RealChairPerformanceState = null;
			ChairPresentationNet.RemoveSnapshot(this.OwnerPlayerId, chairCreatureDataId);
		}

		// Token: 0x06046CE0 RID: 290016 RVA: 0x011D7538 File Offset: 0x011D5738
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
			this.IsChairShown = false;
			this.CurChairPerformanceState = null;
			this.RealChairPerformanceState = null;
		}

		// Token: 0x06046CE1 RID: 290017 RVA: 0x011D7648 File Offset: 0x011D5848
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

		// Token: 0x06046CE2 RID: 290018 RVA: 0x011D7844 File Offset: 0x011D5A44
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

		// Token: 0x06046CE3 RID: 290019 RVA: 0x011D7A90 File Offset: 0x011D5C90
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

		// Token: 0x06046CE4 RID: 290020 RVA: 0x011D7AE8 File Offset: 0x011D5CE8
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

		// Token: 0x06046CE5 RID: 290021 RVA: 0x011D7B58 File Offset: 0x011D5D58
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

		// Token: 0x06046CE6 RID: 290022 RVA: 0x011D7CC4 File Offset: 0x011D5EC4
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

		// Token: 0x06046CE7 RID: 290023 RVA: 0x011D7F88 File Offset: 0x011D6188
		private bool IsValidSitDownCompletion(Entity chairEntity, Entity playerEntity)
		{
			if (!playerEntity.Valid || !chairEntity.Valid || !this.IsMySummonedChair(chairEntity))
			{
				return false;
			}
			CharacterActionComponent component = playerEntity.GetComponent<CharacterActionComponent>();
			return component != null && component.IsSitDown && component.Chair == chairEntity;
		}

		// Token: 0x06046CE8 RID: 290024 RVA: 0x011D7FD0 File Offset: 0x011D61D0
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

		// Token: 0x06046CE9 RID: 290025 RVA: 0x011D80A8 File Offset: 0x011D62A8
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

		// Token: 0x06046CEA RID: 290026 RVA: 0x011D81BA File Offset: 0x011D63BA
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

		// Token: 0x06046CEB RID: 290027 RVA: 0x011D81E4 File Offset: 0x011D63E4
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

		// Token: 0x06046CEC RID: 290028 RVA: 0x011D82EC File Offset: 0x011D64EC
		private void ShowChair(Entity chairEntity, int transactionVersion)
		{
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

		// Token: 0x06046CED RID: 290029 RVA: 0x011D839C File Offset: 0x011D659C
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
			EKuroSceneInteractionState ekuroSceneInteractionState = PlayerFollowerChairHandler.CHAIR_PERFORMANCE_STATE_TO_SCENE_STATE[chairState];
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
			this.CurChairPerformanceState = new EChairPerformanceState?(chairState);
			this.ChairConvergeRetryCount = 0;
			sceneItemActorComponent.SwitchToState(ekuroSceneInteractionState, true, false);
		}

		// Token: 0x06046CEE RID: 290030 RVA: 0x011D8460 File Offset: 0x011D6660
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

		// Token: 0x06046CEF RID: 290031 RVA: 0x011D84BC File Offset: 0x011D66BC
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

		// Token: 0x06046CF0 RID: 290032 RVA: 0x011D8530 File Offset: 0x011D6730
		private unsafe void OnChairStateReached(int handle, EKuroSceneInteractionState state)
		{
			Entity stateReachedListenEntity = this.StateReachedListenEntity;
			SceneItemActorComponent sceneItemActorComponent = ((stateReachedListenEntity != null) ? stateReachedListenEntity.GetComponent<BaseActorComponent>() : null) as SceneItemActorComponent;
			if (sceneItemActorComponent == null || sceneItemActorComponent.GetSceneInteractionLevelHandleId() != handle)
			{
				return;
			}
			EChairPerformanceState value;
			EChairPerformanceState? echairPerformanceState = PlayerFollowerChairHandler.SCENE_STATE_TO_CHAIR_PERFORMANCE_STATE.TryGetValue(state, out value) ? new EChairPerformanceState?(value) : null;
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

		// Token: 0x06046CF1 RID: 290033 RVA: 0x011D8657 File Offset: 0x011D6857
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

		// Token: 0x06046CF2 RID: 290034 RVA: 0x011D868C File Offset: 0x011D688C
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
							SceneInteractionManager.Get().SwitchSceneInteractionToState(sceneInteractionLevelHandleId, PlayerFollowerChairHandler.CHAIR_PERFORMANCE_STATE_TO_SCENE_STATE[pendingChairConvergeState.Value], true, true, false);
							return;
						}
					}
					this.ChairConvergeRetryCount = 0;
					return;
				}
			}
		}

		// Token: 0x06046CF3 RID: 290035 RVA: 0x011D8814 File Offset: 0x011D6A14
		public void SetChairPerformanceControlledExternally(Entity chairEntity, bool controlled)
		{
			SceneItemStateComponent component = chairEntity.GetComponent<SceneItemStateComponent>();
			if (component == null)
			{
				return;
			}
			component.SetPerformanceStateControlledExternally(controlled);
		}

		// Token: 0x06046CF4 RID: 290036 RVA: 0x011D8834 File Offset: 0x011D6A34
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

		// Token: 0x06046CF5 RID: 290037 RVA: 0x011D8892 File Offset: 0x011D6A92
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

		// Token: 0x06046CF6 RID: 290038 RVA: 0x011D88C8 File Offset: 0x011D6AC8
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

		// Token: 0x06046CF7 RID: 290039 RVA: 0x011D8902 File Offset: 0x011D6B02
		private void InvalidateSummonTransaction()
		{
			this.SummonTransactionVersion++;
			this.PendingSummonTransactionVersion = 0;
		}

		// Token: 0x06046CF8 RID: 290040 RVA: 0x011D8919 File Offset: 0x011D6B19
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

		// Token: 0x06046CF9 RID: 290041 RVA: 0x011D892C File Offset: 0x011D6B2C
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

		// Token: 0x06046CFA RID: 290042 RVA: 0x011D89A8 File Offset: 0x011D6BA8
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

		// Token: 0x06046CFB RID: 290043 RVA: 0x011D8AD4 File Offset: 0x011D6CD4
		private void PlaceChair(Entity chairEntity, IChairSummonResult result)
		{
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return;
			}
			component.SetActorLocationAndRotation(result.FinalLocation.ToUeVector(false), global::Rotator.Create(0f, result.Yaw, 0f).ToUeRotator(), "ChairSummonRelocate", false, null);
		}

		// Token: 0x06046CFC RID: 290044 RVA: 0x011D8B28 File Offset: 0x011D6D28
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

		// Token: 0x06046CFD RID: 290045 RVA: 0x011D8C07 File Offset: 0x011D6E07
		private void OnObserverChanged()
		{
			this.ReportChairPresentation(this.IsChairShown, "PlayerFollowerChairHandler.ScenePlayerChanged");
		}

		// Token: 0x06046CFE RID: 290046 RVA: 0x011D8C1A File Offset: 0x011D6E1A
		private void OnReconnectSuccess()
		{
			this.ReportChairPresentation(this.IsChairShown, "PlayerFollowerChairHandler.ReConnectSuccess");
			this.MigrateSitDownLeaveToCurrentPlayer();
		}

		// Token: 0x06046CFF RID: 290047 RVA: 0x011D8C34 File Offset: 0x011D6E34
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

		// Token: 0x06046D00 RID: 290048 RVA: 0x011D8CC8 File Offset: 0x011D6EC8
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

		// Token: 0x06046D01 RID: 290049 RVA: 0x011D8D5F File Offset: 0x011D6F5F
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

		// Token: 0x06046D02 RID: 290050 RVA: 0x011D8D98 File Offset: 0x011D6F98
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

		// Token: 0x06046D03 RID: 290051 RVA: 0x011D8E2E File Offset: 0x011D702E
		private void StartMonitor()
		{
			this.EnsureChairRuntimeMonitor();
		}

		// Token: 0x06046D04 RID: 290052 RVA: 0x011D8E36 File Offset: 0x011D7036
		private void StopMonitor()
		{
			this.StopChairRuntimeMonitor();
		}

		// Token: 0x06046D05 RID: 290053 RVA: 0x011D8E40 File Offset: 0x011D7040
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

		// Token: 0x06046D06 RID: 290054 RVA: 0x011D8EA3 File Offset: 0x011D70A3
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

		// Token: 0x0402528C RID: 152204
		private const string WAIT_REASON = "PlayerFollowerChairHandler.AddFollower";

		// Token: 0x0402528D RID: 152205
		private const string SUMMON_FAIL_TIP_TEXT_ID = "Flying_Tip_002";

		// Token: 0x0402528E RID: 152206
		private const int CHAIR_SIT_DOWN_TYPE = 1;

		// Token: 0x0402528F RID: 152207
		private const int CHAIR_ITEM_ID = 70360001;

		// Token: 0x04025290 RID: 152208
		private const int SUMMON_CHAIR_SKILL_ID = 210062;

		// Token: 0x04025291 RID: 152209
		private const int SIT_DOWN_COMPLETE_TIMEOUT_MS = 3000;

		// Token: 0x04025292 RID: 152210
		private const int CHAIR_CONVERGE_MAX_RETRY_COUNT = 2;

		// Token: 0x04025293 RID: 152211
		private static readonly Dictionary<EChairPerformanceState, EKuroSceneInteractionState> CHAIR_PERFORMANCE_STATE_TO_SCENE_STATE = new Dictionary<EChairPerformanceState, EKuroSceneInteractionState>
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

		// Token: 0x04025294 RID: 152212
		private static readonly Dictionary<EKuroSceneInteractionState, EChairPerformanceState> SCENE_STATE_TO_CHAIR_PERFORMANCE_STATE = new Dictionary<EKuroSceneInteractionState, EChairPerformanceState>
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

		// Token: 0x04025297 RID: 152215
		private readonly Dictionary<long, WaitEntityTask> WaitEntityTasks = new Dictionary<long, WaitEntityTask>();

		// Token: 0x04025298 RID: 152216
		[Nullable(2)]
		private ChairMonitor ChairRuntimeMonitor;

		// Token: 0x04025299 RID: 152217
		private bool ChairSpaceOccupied;

		// Token: 0x0402529A RID: 152218
		private ChairRemotePresenter RemotePresenter;

		// Token: 0x0402529B RID: 152219
		private int SummonTransactionVersion;

		// Token: 0x0402529C RID: 152220
		private readonly ChairSummonEvaluator SummonEvaluator = new ChairSummonEvaluator();

		// Token: 0x0402529E RID: 152222
		private EChairPerformanceState? CurChairPerformanceState;

		// Token: 0x0402529F RID: 152223
		private EChairPerformanceState? RealChairPerformanceState;

		// Token: 0x040252A0 RID: 152224
		[Nullable(2)]
		private Entity StateReachedListenEntity;

		// Token: 0x040252A1 RID: 152225
		private int ChairConvergeRetryCount;

		// Token: 0x040252A2 RID: 152226
		private EChairPerformanceState? PendingChairConvergeState;

		// Token: 0x040252A3 RID: 152227
		[Nullable(2)]
		private TimerHandle ChairConvergeTimer;

		// Token: 0x040252A4 RID: 152228
		[Nullable(2)]
		private PD_CharacterControllerDataGroup_C GoBattleMaterial;

		// Token: 0x040252A5 RID: 152229
		private int PendingRoleDisableHandle;

		// Token: 0x040252A6 RID: 152230
		[Nullable(2)]
		private CharacterActorComponent PendingRoleActorComp;

		// Token: 0x040252A7 RID: 152231
		[Nullable(2)]
		private ITagTask SitDownCompleteTagTask;

		// Token: 0x040252A8 RID: 152232
		[Nullable(2)]
		private ITagTask SitDownLeaveTagTask;

		// Token: 0x040252A9 RID: 152233
		[Nullable(2)]
		private Entity SitDownLeaveListenEntity;

		// Token: 0x040252AA RID: 152234
		private int SitDownLeaveTransactionVersion;

		// Token: 0x040252AB RID: 152235
		[Nullable(2)]
		private TimerHandle SitDownTimeoutTimer;

		// Token: 0x040252AC RID: 152236
		private bool SummonSkillEndListening;

		// Token: 0x040252AD RID: 152237
		[Nullable(2)]
		private Entity PendingChairEntity;

		// Token: 0x040252AE RID: 152238
		[Nullable(2)]
		private Entity PendingSitDownPlayerEntity;

		// Token: 0x040252AF RID: 152239
		private int PendingSummonTransactionVersion;

		// Token: 0x040252B0 RID: 152240
		[Nullable(2)]
		private Action<int, int> SummonSkillEndCallback;

		// Token: 0x040252B1 RID: 152241
		private bool IsChairSummonBlockedByPlot;

		// Token: 0x040252B2 RID: 152242
		[Nullable(2)]
		private ConditionPassCallback RestrictConditionCallback;

		// Token: 0x040252B3 RID: 152243
		private int RestrictConditionGroupId;

		// Token: 0x040252B4 RID: 152244
		private bool IsLocalEventListening;
	}
}

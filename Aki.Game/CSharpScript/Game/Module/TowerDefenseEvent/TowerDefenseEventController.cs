using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using CSharpScript.Game.Module.TrapDefense;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent
{
	// Token: 0x02004B03 RID: 19203
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class TowerDefenseEventController : ControllerBase
	{
		// Token: 0x17007B03 RID: 31491
		// (get) Token: 0x06031BB5 RID: 203701 RVA: 0x00B8CB8F File Offset: 0x00B8AD8F
		public ETowerDefenseEventProcessStatus ProcessStatus
		{
			get
			{
				return this.ProcessStatusInternal;
			}
		}

		// Token: 0x06031BB6 RID: 203702 RVA: 0x00B8CB97 File Offset: 0x00B8AD97
		public bool IsInPreview()
		{
			return this.ProcessStatusInternal == ETowerDefenseEventProcessStatus.Ready;
		}

		// Token: 0x06031BB7 RID: 203703 RVA: 0x00B8CBA2 File Offset: 0x00B8ADA2
		public bool IsFighting()
		{
			return this.ProcessStatusInternal == ETowerDefenseEventProcessStatus.Fighting;
		}

		// Token: 0x06031BB8 RID: 203704 RVA: 0x00B8CBAD File Offset: 0x00B8ADAD
		public void ResetWorldAttr()
		{
			this.GoldNum = 0L;
			this.BattleWave = 0;
		}

		// Token: 0x06031BB9 RID: 203705 RVA: 0x00B8CBC0 File Offset: 0x00B8ADC0
		public bool IsTowerDefenseEventInstance()
		{
			return GameModeController.Instance.IsInInstance() && GameModeModel.Instance.InstanceDungeon != null && GameModeModel.Instance.InstanceDungeon.Value.InstSubType == 37;
		}

		// Token: 0x06031BBA RID: 203706 RVA: 0x00B8CC0F File Offset: 0x00B8AE0F
		public void InitMap()
		{
			this.InitTowerDefenseEventInstance();
			Net.Instance.Register(ENotifyMessageId.TrapDefenseStepUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStepUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.TrapDefenseEntityDataChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEntityDataChanged));
		}

		// Token: 0x06031BBB RID: 203707 RVA: 0x00B8CC4F File Offset: 0x00B8AE4F
		public void OnWorldDone()
		{
			this.IsWorldInit = true;
			this.ResetWorldAttr();
		}

		// Token: 0x06031BBC RID: 203708 RVA: 0x00B8CC5E File Offset: 0x00B8AE5E
		public void OnWorldReset()
		{
			if (!this.IsWorldInit)
			{
				return;
			}
			this.IsWorldInit = false;
			Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseStepUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseEntityDataChangeNotify);
			this.ResetTowerDefenseEventInstance();
		}

		// Token: 0x06031BBD RID: 203709 RVA: 0x00B8CC98 File Offset: 0x00B8AE98
		[NullableContext(2)]
		private void OnEntityDataChanged(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseEntityDataChangeNotify trapDefenseEntityDataChangeNotify = (TrapDefenseEntityDataChangeNotify)msg;
			if (trapDefenseEntityDataChangeNotify != null)
			{
				this.EntityRedirectFilter.UpdateEntity(trapDefenseEntityDataChangeNotify);
			}
		}

		// Token: 0x06031BBE RID: 203710 RVA: 0x00B8CCBC File Offset: 0x00B8AEBC
		public unsafe void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
		{
			if (context.IsPreview)
			{
				this.PreviewMonsterSpawner.RemovePreviewMonster(context.CreatureDataId);
				return;
			}
			ITowerDefenseEventCombatInfo entity = TowerDefenseEventModel.Instance.GetEntity(context.CreatureDataId);
			if (entity == null)
			{
				return;
			}
			if (context.ReasonName != KscEntityRemoveReason.LandFire)
			{
				entity.Position.DeepCopy(context.Location);
			}
			SimpleCombatEntityDieContext simpleCombatEntityDieContext = SimpleCombatEntityDieContext.Create();
			Aki.Protocol.Vector vector = Aki.Protocol.Vector.Create();
			vector.X = (float)entity.Position.X;
			vector.Y = (float)entity.Position.Y;
			vector.Z = (float)entity.Position.Z;
			simpleCombatEntityDieContext.DiePos = vector;
			FName? dynamicFName = FNameUtil.GetDynamicFName(context.ReasonName.ToString());
			if (dynamicFName == KscEntityRemoveReason.Dead)
			{
				TrapDefenseMonsterKilledCtxPb trapDefenseMonsterKilledCtxPb = TrapDefenseMonsterKilledCtxPb.Create();
				trapDefenseMonsterKilledCtxPb.EntityId = context.KillerId;
				trapDefenseMonsterKilledCtxPb.PollutedGridCells.AddRange(this.DoDeathRattle(entity));
				simpleCombatEntityDieContext.TrapDefenseMonsterKilledCtx = trapDefenseMonsterKilledCtxPb;
			}
			else if (dynamicFName == KscEntityRemoveReason.WorldKill)
			{
				TrapDefenseEnvironmentalKillCtxPb trapDefenseEnvironmentalKillCtxPb = TrapDefenseEnvironmentalKillCtxPb.Create();
				trapDefenseEnvironmentalKillCtxPb.TrapId = context.KillerId;
				simpleCombatEntityDieContext.TrapDefenseEnvironmentalKillCtx = trapDefenseEnvironmentalKillCtxPb;
			}
			else if (dynamicFName == KscEntityRemoveReason.Arrival)
			{
				TrapDefenseReachInstEndpointCtxPb trapDefenseReachInstEndpointCtx = TrapDefenseReachInstEndpointCtxPb.Create();
				simpleCombatEntityDieContext.TrapDefenseReachInstEndpointCtx = trapDefenseReachInstEndpointCtx;
			}
			else if (dynamicFName == KscEntityRemoveReason.Coin)
			{
				TrapDefenseGoldenCoinAbosorbedCtxPb trapDefenseGoldenCoinAbosorbedCtx = TrapDefenseGoldenCoinAbosorbedCtxPb.Create();
				simpleCombatEntityDieContext.TrapDefenseGoldenCoinAbosorbedCtx = trapDefenseGoldenCoinAbosorbedCtx;
			}
			else
			{
				if (!(dynamicFName == KscEntityRemoveReason.LandFire))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.TowerDefenseEvent;
					ELogAuthor author = ELogAuthor.XY;
					string message = "移除塔防实体失败: 未处理移除原因";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", context.CreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reasonName", context.ReasonName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				TrapDefenseTrapSelfDestructCtxPb trapDefenseTrapSelfDestructCtxPb = TrapDefenseTrapSelfDestructCtxPb.Create();
				List<GridPlacementPbInfo> gridCells = new List<GridPlacementPbInfo>();
				BuildingGridController.Instance.LandFireGrids(entity.Position, context.EffectRange, context.ClearCell, delegate(string gridId, FKuroBuildingGridCellVector coords)
				{
					GridPlacementPbInfo gridPlacementPbInfo = GridPlacementPbInfo.Create();
					gridPlacementPbInfo.ActorGuid = gridId;
					gridPlacementPbInfo.X = coords.X;
					gridPlacementPbInfo.Y = coords.Y;
					gridPlacementPbInfo.Direction = GridPbDirection.GridForward;
					gridCells.Add(gridPlacementPbInfo);
				});
				this.DoLandFire(entity, context.Params);
				trapDefenseTrapSelfDestructCtxPb.DamagedGridCells.AddRange(gridCells);
				trapDefenseTrapSelfDestructCtxPb.FireCount = context.FireNum;
				simpleCombatEntityDieContext.TrapDefenseTrapSelfDestructCtx = trapDefenseTrapSelfDestructCtxPb;
			}
			if (entity is ITowerDefenseEventSpecialCellBaseInfo)
			{
				TrapDefenseSpcecialCellDestructCtxPb trapDefenseSpcecialCellDestructCtx = TrapDefenseSpcecialCellDestructCtxPb.Create();
				simpleCombatEntityDieContext.TrapDefenseSpcecialCellDestructCtx = trapDefenseSpcecialCellDestructCtx;
			}
			protoContexts[context.CreatureDataId] = simpleCombatEntityDieContext;
		}

		// Token: 0x06031BBF RID: 203711 RVA: 0x00B8CFC8 File Offset: 0x00B8B1C8
		private void DoLandFire(ITowerDefenseEventCombatInfo model, [Nullable(2)] TMap<EKSC_AttrType, int> @params)
		{
			if (@params == null || @params.Num() <= 0)
			{
				return;
			}
			TMap<EKSC_AttrType, int> tmap = new TMap<EKSC_AttrType, int>();
			foreach (KeyValuePair<EKSC_AttrType, int> keyValuePair in @params)
			{
				EKSC_AttrType eksc_AttrType;
				int num;
				keyValuePair.Deconstruct(out eksc_AttrType, out num);
				EKSC_AttrType key = eksc_AttrType;
				int value = num;
				tmap[key] = value;
			}
			Dictionary<ETowerDefenseEventCombatExtraInfoType, CombatExtraInfoBase> dictionary = new Dictionary<ETowerDefenseEventCombatExtraInfoType, CombatExtraInfoBase>();
			dictionary[ETowerDefenseEventCombatExtraInfoType.LandFire] = new LandFireExtraInfo
			{
				Params = tmap
			};
			model.ExtraInfo = dictionary;
		}

		// Token: 0x06031BC0 RID: 203712 RVA: 0x00B8D054 File Offset: 0x00B8B254
		private List<GridPlacementPbInfo> DoDeathRattle(ITowerDefenseEventCombatInfo model)
		{
			ITowerDefenseEventMonsterInfo towerDefenseEventMonsterInfo = model as ITowerDefenseEventMonsterInfo;
			if (towerDefenseEventMonsterInfo == null)
			{
				return new List<GridPlacementPbInfo>();
			}
			if (towerDefenseEventMonsterInfo.DeathType == ETowerDefenseEventMonsterDeathType.Pollute)
			{
				return BuildingGridController.Instance.PolluteGrids(towerDefenseEventMonsterInfo.Position, towerDefenseEventMonsterInfo.PolluteRadius);
			}
			return new List<GridPlacementPbInfo>();
		}

		// Token: 0x06031BC1 RID: 203713 RVA: 0x00B8D098 File Offset: 0x00B8B298
		private void InitTowerDefenseEventInstance()
		{
			TrapDefenseActivity? config = ConfigTrapDefenseActivityByInstId.GetConfig(GameModeModel.Instance.InstanceDungeon.Value.Id, true);
			TowerDefenseEventModel.Instance.InitInstance(config);
		}

		// Token: 0x06031BC2 RID: 203714 RVA: 0x00B8D0D4 File Offset: 0x00B8B2D4
		private void ResetTowerDefenseEventInstance()
		{
			this.ProcessStatusInternal = ETowerDefenseEventProcessStatus.None;
			this.RaycastResult.Reset();
			this.DestroyPreviewTrapActor("TowerDefenseEventController.ResetTowerDefenseEventInstance");
			this.TrapTemplateInfo.Reset();
			this.PrepareRemoveTrapActor = null;
			this.BuildTipsTypeInternal = ETrapDefenseBuildTipsType.None;
			this.PreviewMonsterSpawner.Clear();
		}

		// Token: 0x06031BC3 RID: 203715 RVA: 0x00B8D124 File Offset: 0x00B8B324
		[NullableContext(2)]
		private void OnStepUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseStepUpdateNotify trapDefenseStepUpdateNotify = (TrapDefenseStepUpdateNotify)msg;
			if (trapDefenseStepUpdateNotify == null)
			{
				return;
			}
			string a = trapDefenseStepUpdateNotify.StepPbDataCase.ToString();
			if (!(a == "PreviewStepPbData"))
			{
				if (!(a == "MonsterStepPbData"))
				{
					if (a == "RewardStepPbData")
					{
						this.ProcessStatusInternal = ETowerDefenseEventProcessStatus.Reward;
					}
				}
				else
				{
					this.ProcessStatusInternal = ETowerDefenseEventProcessStatus.Fighting;
					TrapDefenseSpawnMonsterStepPbData monsterStepPbData = trapDefenseStepUpdateNotify.MonsterStepPbData;
					if (monsterStepPbData != null)
					{
						this.OnFightingStepUpdate(monsterStepPbData);
					}
					else
					{
						Log.Instance.Error(ELogModule.TowerDefenseEvent, ELogAuthor.XY, "战斗阶段数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					AudioSystem.Instance.SetState("tower_defence_music_2_6", "battle", true);
				}
			}
			else
			{
				this.ProcessStatusInternal = ETowerDefenseEventProcessStatus.Ready;
				TrapDefensePreviewStepPbData previewStepPbData = trapDefenseStepUpdateNotify.PreviewStepPbData;
				if (previewStepPbData != null)
				{
					this.OnPreviewStepUpdate(previewStepPbData);
				}
				else
				{
					Log.Instance.Error(ELogModule.TowerDefenseEvent, ELogAuthor.XY, "预览阶段数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				if (!TrapDefenseModel.Instance.BattleData.HasStartAkEvent)
				{
					TrapDefenseModel.Instance.BattleData.SetHasStartAkEvent(true);
					AudioSystem.Instance.PostEvent("play_2_6_tower_defence_music_ingame");
				}
				else
				{
					AudioSystem.Instance.SetState("tower_defence_music_2_6", "none", true);
				}
			}
			TsTowerDefenseEventActor.UpdateTrapRangeState();
			EventSystem.Instance.Emit<ETowerDefenseEventProcessStatus>(EEventName.TowerDefenseEventStepUpdate, this.ProcessStatusInternal);
		}

		// Token: 0x06031BC4 RID: 203716 RVA: 0x00B8D280 File Offset: 0x00B8B480
		private void OnPreviewStepUpdate(TrapDefensePreviewStepPbData data)
		{
			this.PreviewMonsterSpawner.Init(data.MonsterRoutesPreviewInfo.ToDictionary<int, TrapDefenseMonsterPbGroup>());
			if (data.ShopInfo != null)
			{
				TrapDefenseModel.Instance.BattleData.SetShopOpen(data.ShopInfo.ShopProductPbInfos.Count > 0);
			}
			else
			{
				TrapDefenseModel.Instance.BattleData.SetShopOpen(false);
			}
			Log.Instance.Info(ELogModule.TowerDefenseEvent, ELogAuthor.XXJ, "塔防进入准备阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (data.ShopInfo != null)
			{
				TrapDefenseModel.Instance.ProtoShopInitNotify(data.ShopInfo);
			}
		}

		// Token: 0x06031BC5 RID: 203717 RVA: 0x00B8D318 File Offset: 0x00B8B518
		private void OnFightingStepUpdate(TrapDefenseSpawnMonsterStepPbData data)
		{
			this.PreviewMonsterSpawner.Reset();
			TrapDefenseModel.Instance.BattleData.SetPreviewCountDown((float)data.EndCountdownSecond);
			TrapDefenseModel.Instance.BattleData.SetSpecialShow(data.IsWarningPrepareStyle);
			Log.Instance.Info(ELogModule.TowerDefenseEvent, ELogAuthor.XXJ, "塔防进入战斗阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06031BC6 RID: 203718 RVA: 0x00B8D37A File Offset: 0x00B8B57A
		public void ControllerTick(float delta)
		{
			this.OnTick(delta);
		}

		// Token: 0x06031BC7 RID: 203719 RVA: 0x00B8D384 File Offset: 0x00B8B584
		protected override void OnTick(float delta)
		{
			if (this.IsInPreview())
			{
				this.PreviewMonsterSpawner.OnTick(delta);
			}
			if (this.IsFighting())
			{
				int batch = TrapDefenseModel.Instance.BattleData.GetBatch();
				if (batch != this.BattleWave)
				{
					UKSC_World kscWorld = KscEnv.Instance.KscWorld;
					if (kscWorld != null)
					{
						kscWorld.SetWorldAttr(EKSC_WorldAttrType.Wave, batch);
					}
					this.BattleWave = batch;
				}
				long goldNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
				if (goldNum != this.GoldNum)
				{
					UKSC_World kscWorld2 = KscEnv.Instance.KscWorld;
					if (kscWorld2 != null)
					{
						kscWorld2.SetWorldAttr(EKSC_WorldAttrType.Gold, (int)goldNum);
					}
					this.GoldNum = goldNum;
				}
			}
			bool flag = (this.IsInPreview() && TowerDefenseEventModel.Instance.CurrentTrapCount > 0) || this.TrapTemplateInfo.IsInPreview();
			if (flag)
			{
				if (this.RaycastResult.Raycast(this.PreviewTrapActor, this.TrapTemplateInfo.PlacementType, (float)this.TrapTemplateInfo.Degree, !this.IsFighting()))
				{
					this.TrapTemplateInfo.Position.DeepCopy(this.RaycastResult.Location);
					this.TrapTemplateInfo.Rotation.DeepCopy(this.RaycastResult.Rotation);
					this.TrapTemplateInfo.Degree = (int)this.RaycastResult.Degree;
				}
			}
			else if (this.IsRaycast)
			{
				this.RaycastResult.Reset();
			}
			this.IsRaycast = flag;
			if (!this.RaycastResult.IsCanPlace)
			{
				this.HidePreviewTrap();
			}
			if (this.RaycastResult.IsCanRecycle)
			{
				if (this.PrepareRemoveTrapActor != this.RaycastResult.RaycastTarget)
				{
					TsTowerDefenseEventActor prepareRemoveTrapActor = this.PrepareRemoveTrapActor;
					if (prepareRemoveTrapActor != null)
					{
						prepareRemoveTrapActor.ResetRemove();
					}
					this.PrepareRemoveTrapActor = this.RaycastResult.RaycastTarget;
					this.PrepareRemoveTrapActor.PrepareRemove();
				}
			}
			else if (this.PrepareRemoveTrapActor != null)
			{
				this.PrepareRemoveTrapActor.ResetRemove();
				this.PrepareRemoveTrapActor = null;
			}
			this.CheckRaycastOnOrgan();
			if (this.TrapTemplateInfo.GetConfigDirtyAndReset() || this.RaycastResult.IsStateDirty)
			{
				this.UpdateRaycastState();
			}
		}

		// Token: 0x06031BC8 RID: 203720 RVA: 0x00B8D584 File Offset: 0x00B8B784
		private void HidePreviewTrap()
		{
			if (!this.TrapTemplateInfo.IsInPreview())
			{
				return;
			}
			if (this.PreviewTrapActor != null && this.PreviewTrapActor.IsValid())
			{
				this.PreviewTrapActor.Hide();
			}
		}

		// Token: 0x17007B04 RID: 31492
		// (get) Token: 0x06031BC9 RID: 203721 RVA: 0x00B8D5B4 File Offset: 0x00B8B7B4
		public ETrapDefenseBuildTipsType BuildTipsType
		{
			get
			{
				return this.BuildTipsTypeInternal;
			}
		}

		// Token: 0x06031BCA RID: 203722 RVA: 0x00B8D5BC File Offset: 0x00B8B7BC
		private void UpdateRaycastState()
		{
			ETrapDefenseBuildTipsType etrapDefenseBuildTipsType = ETrapDefenseBuildTipsType.None;
			if (this.RaycastResult.IsCanBuild)
			{
				etrapDefenseBuildTipsType |= ETrapDefenseBuildTipsType.Build;
			}
			else if (this.TrapTemplateInfo.IsInPreview())
			{
				etrapDefenseBuildTipsType |= ETrapDefenseBuildTipsType.Disable;
			}
			if (this.RaycastResult.IsCanRecycle)
			{
				etrapDefenseBuildTipsType |= ETrapDefenseBuildTipsType.Recycle;
			}
			if (this.RaycastResult.IsPolluted)
			{
				etrapDefenseBuildTipsType |= ETrapDefenseBuildTipsType.Pollute;
			}
			if (this.TrapTemplateInfo.IsInPreview() && this.TrapTemplateInfo.CanRotate)
			{
				etrapDefenseBuildTipsType |= ETrapDefenseBuildTipsType.Rotate;
			}
			if (this.BuildTipsTypeInternal != etrapDefenseBuildTipsType)
			{
				this.BuildTipsTypeInternal = etrapDefenseBuildTipsType;
				EventSystem.Instance.Emit<ETrapDefenseBuildTipsType>(EEventName.TowerDefenseEventNotifyType, this.BuildTipsTypeInternal);
			}
		}

		// Token: 0x06031BCB RID: 203723 RVA: 0x00B8D658 File Offset: 0x00B8B858
		[NullableContext(0)]
		private UniTask<bool> StartFighting()
		{
			TowerDefenseEventController.<StartFighting>d__40 <StartFighting>d__;
			<StartFighting>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartFighting>d__.<>4__this = this;
			<StartFighting>d__.<>1__state = -1;
			<StartFighting>d__.<>t__builder.Start<TowerDefenseEventController.<StartFighting>d__40>(ref <StartFighting>d__);
			return <StartFighting>d__.<>t__builder.Task;
		}

		// Token: 0x06031BCC RID: 203724 RVA: 0x00B8D69C File Offset: 0x00B8B89C
		private void DoSelectAction(int index)
		{
			int? machineIdByIndex = TowerDefenseEventModel.Instance.GetMachineIdByIndex(index);
			if (machineIdByIndex == null || machineIdByIndex.Value == 0)
			{
				return;
			}
			if (this.TrapTemplateInfo.IsTargetLevel(machineIdByIndex.Value))
			{
				return;
			}
			this.PreviewTrap(machineIdByIndex.Value);
		}

		// Token: 0x06031BCD RID: 203725 RVA: 0x00B8D6EB File Offset: 0x00B8B8EB
		public void HandleTowerDefenseSelect(int index)
		{
			TowerDefensePlayerController.EnablePlayerFollower(false);
			this.DoSelectAction(index);
		}

		// Token: 0x06031BCE RID: 203726 RVA: 0x00B8D6FC File Offset: 0x00B8B8FC
		public void CancelCurrentPreviewTrap()
		{
			if (this.PreviewTrapActor == null)
			{
				return;
			}
			ITowerDefenseEventTrapBaseInfo tapModel = this.PreviewTrapActor.GetTapModel();
			if (tapModel == null)
			{
				return;
			}
			if (this.TrapTemplateInfo.IsTargetLevel(tapModel.ConfigId))
			{
				this.TrapTemplateInfo.Reset();
				this.DestroyPreviewTrapActor("TowerDefenseEventController.CancelCurrentPreviewTrap");
			}
		}

		// Token: 0x06031BCF RID: 203727 RVA: 0x00B8D74C File Offset: 0x00B8B94C
		[NullableContext(0)]
		public UniTask<bool> ExecuteStartFighting()
		{
			TowerDefenseEventController.<ExecuteStartFighting>d__44 <ExecuteStartFighting>d__;
			<ExecuteStartFighting>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteStartFighting>d__.<>4__this = this;
			<ExecuteStartFighting>d__.<>1__state = -1;
			<ExecuteStartFighting>d__.<>t__builder.Start<TowerDefenseEventController.<ExecuteStartFighting>d__44>(ref <ExecuteStartFighting>d__);
			return <ExecuteStartFighting>d__.<>t__builder.Task;
		}

		// Token: 0x06031BD0 RID: 203728 RVA: 0x00B8D790 File Offset: 0x00B8B990
		[NullableContext(0)]
		public UniTask<bool> ExecuteOccupyTrap()
		{
			TowerDefenseEventController.<ExecuteOccupyTrap>d__45 <ExecuteOccupyTrap>d__;
			<ExecuteOccupyTrap>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOccupyTrap>d__.<>4__this = this;
			<ExecuteOccupyTrap>d__.<>1__state = -1;
			<ExecuteOccupyTrap>d__.<>t__builder.Start<TowerDefenseEventController.<ExecuteOccupyTrap>d__45>(ref <ExecuteOccupyTrap>d__);
			return <ExecuteOccupyTrap>d__.<>t__builder.Task;
		}

		// Token: 0x06031BD1 RID: 203729 RVA: 0x00B8D7D4 File Offset: 0x00B8B9D4
		[NullableContext(0)]
		public UniTask<bool> ExecuteUnOccupyTrap()
		{
			TowerDefenseEventController.<ExecuteUnOccupyTrap>d__46 <ExecuteUnOccupyTrap>d__;
			<ExecuteUnOccupyTrap>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteUnOccupyTrap>d__.<>4__this = this;
			<ExecuteUnOccupyTrap>d__.<>1__state = -1;
			<ExecuteUnOccupyTrap>d__.<>t__builder.Start<TowerDefenseEventController.<ExecuteUnOccupyTrap>d__46>(ref <ExecuteUnOccupyTrap>d__);
			return <ExecuteUnOccupyTrap>d__.<>t__builder.Task;
		}

		// Token: 0x06031BD2 RID: 203730 RVA: 0x00B8D817 File Offset: 0x00B8BA17
		public void ExecuteRotateTrap()
		{
			this.RotateTrap();
		}

		// Token: 0x06031BD3 RID: 203731 RVA: 0x00B8D820 File Offset: 0x00B8BA20
		public unsafe bool PreviewTrap(int configId)
		{
			this.RaycastResult.Reset();
			this.TrapTemplateInfo.BeginInit(configId);
			string text = TowerDefenseEventConfig.FillUpModelInfo(this.TrapTemplateInfo, false);
			this.TrapTemplateInfo.EndInit();
			if (text != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefenseEvent;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预览陷阱失败: " + text;
				<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", configId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("trapId", this.TrapTemplateInfo.TrapId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("level", this.TrapTemplateInfo.Level);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("branchId", this.TrapTemplateInfo.BranchId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("templateId", this.TrapTemplateInfo.TemplateId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("subTypeId", this.TrapTemplateInfo.SubTypeId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("combatId", this.TrapTemplateInfo.CombatId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("prefabPath", this.TrapTemplateInfo.PrefabPath);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
				return false;
			}
			this.InitPreviewTrapActor();
			EventSystem.Instance.Emit<int>(EEventName.TrapDefensePreviewMachine, configId);
			return true;
		}

		// Token: 0x06031BD4 RID: 203732 RVA: 0x00B8D9D4 File Offset: 0x00B8BBD4
		private void InitPreviewTrapActor()
		{
			if (this.PreviewTrapActor == null)
			{
				this.PreviewTrapActor = (ActorSystem.Instance.Get(TsTowerDefenseEventActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as TsTowerDefenseEventActor);
			}
			this.PreviewTrapActor.Init(this.TrapTemplateInfo, null);
		}

		// Token: 0x06031BD5 RID: 203733 RVA: 0x00B8DA22 File Offset: 0x00B8BC22
		private void DestroyPreviewTrapActor(string reason)
		{
			if (this.PreviewTrapActor != null && this.PreviewTrapActor.IsValid())
			{
				this.PreviewTrapActor.Destroy(reason);
			}
			this.PreviewTrapActor = null;
		}

		// Token: 0x06031BD6 RID: 203734 RVA: 0x00B8DA4C File Offset: 0x00B8BC4C
		public void RotateTrap()
		{
			this.TrapTemplateInfo.Rotate();
		}

		// Token: 0x06031BD7 RID: 203735 RVA: 0x00B8DA59 File Offset: 0x00B8BC59
		public bool IsEnoughGoldToBuildTrap()
		{
			return TowerDefenseEventModel.Instance.IsEnoughGoldToBuildTrap(this.TrapTemplateInfo);
		}

		// Token: 0x06031BD8 RID: 203736 RVA: 0x00B8DA6C File Offset: 0x00B8BC6C
		[NullableContext(0)]
		public UniTask<bool> OccupyTrap()
		{
			TowerDefenseEventController.<OccupyTrap>d__53 <OccupyTrap>d__;
			<OccupyTrap>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OccupyTrap>d__.<>4__this = this;
			<OccupyTrap>d__.<>1__state = -1;
			<OccupyTrap>d__.<>t__builder.Start<TowerDefenseEventController.<OccupyTrap>d__53>(ref <OccupyTrap>d__);
			return <OccupyTrap>d__.<>t__builder.Task;
		}

		// Token: 0x06031BD9 RID: 203737 RVA: 0x00B8DAB0 File Offset: 0x00B8BCB0
		[NullableContext(0)]
		private UniTask<Aki.Protocol.ErrorCode?> RequestOccupyTrap([Nullable(1)] ITowerDefenseEventTrapInfo trapInfo)
		{
			TowerDefenseEventController.<RequestOccupyTrap>d__54 <RequestOccupyTrap>d__;
			<RequestOccupyTrap>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode?>.Create();
			<RequestOccupyTrap>d__.trapInfo = trapInfo;
			<RequestOccupyTrap>d__.<>1__state = -1;
			<RequestOccupyTrap>d__.<>t__builder.Start<TowerDefenseEventController.<RequestOccupyTrap>d__54>(ref <RequestOccupyTrap>d__);
			return <RequestOccupyTrap>d__.<>t__builder.Task;
		}

		// Token: 0x06031BDA RID: 203738 RVA: 0x00B8DAF4 File Offset: 0x00B8BCF4
		[NullableContext(0)]
		public UniTask<bool> UnOccupyTrap()
		{
			TowerDefenseEventController.<UnOccupyTrap>d__55 <UnOccupyTrap>d__;
			<UnOccupyTrap>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UnOccupyTrap>d__.<>4__this = this;
			<UnOccupyTrap>d__.<>1__state = -1;
			<UnOccupyTrap>d__.<>t__builder.Start<TowerDefenseEventController.<UnOccupyTrap>d__55>(ref <UnOccupyTrap>d__);
			return <UnOccupyTrap>d__.<>t__builder.Task;
		}

		// Token: 0x06031BDB RID: 203739 RVA: 0x00B8DB38 File Offset: 0x00B8BD38
		[NullableContext(0)]
		private UniTask<Aki.Protocol.ErrorCode?> RequestUnoccupyTrap([Nullable(1)] ITowerDefenseEventTrapInfo trapInfo)
		{
			TowerDefenseEventController.<RequestUnoccupyTrap>d__56 <RequestUnoccupyTrap>d__;
			<RequestUnoccupyTrap>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode?>.Create();
			<RequestUnoccupyTrap>d__.trapInfo = trapInfo;
			<RequestUnoccupyTrap>d__.<>1__state = -1;
			<RequestUnoccupyTrap>d__.<>t__builder.Start<TowerDefenseEventController.<RequestUnoccupyTrap>d__56>(ref <RequestUnoccupyTrap>d__);
			return <RequestUnoccupyTrap>d__.<>t__builder.Task;
		}

		// Token: 0x06031BDC RID: 203740 RVA: 0x00B8DB7C File Offset: 0x00B8BD7C
		private void CheckRaycastOnOrgan()
		{
			TsTowerDefenseEventActor raycastTarget = this.RaycastResult.RaycastTarget;
			ITowerDefenseEventTrapInfo towerDefenseEventTrapInfo = ((raycastTarget != null) ? raycastTarget.GetTapModel() : null) as ITowerDefenseEventTrapInfo;
			long? num = (towerDefenseEventTrapInfo != null) ? new long?(towerDefenseEventTrapInfo.Uid) : null;
			long? curRaycastOrgan = this.CurRaycastOrgan;
			long? num2 = num;
			if (!(curRaycastOrgan.GetValueOrDefault() == num2.GetValueOrDefault() & curRaycastOrgan != null == (num2 != null)))
			{
				this.CurRaycastOrgan = num;
				if (num != null && num.Value != 0L)
				{
					EventSystem.Instance.Emit<int?>(EEventName.TowerDefenseRecycleRaycastNotify, (towerDefenseEventTrapInfo != null) ? new int?(towerDefenseEventTrapInfo.DeconstructReturn) : null);
				}
			}
		}

		// Token: 0x17007B05 RID: 31493
		// (get) Token: 0x06031BDD RID: 203741 RVA: 0x00B8DC2F File Offset: 0x00B8BE2F
		public static TowerDefenseEventController Instance
		{
			get
			{
				return TowerDefenseEventController._Instance;
			}
		}

		// Token: 0x06031BDE RID: 203742 RVA: 0x00B8DC36 File Offset: 0x00B8BE36
		public static TowerDefenseEventController GetOrCreateInstance()
		{
			if (TowerDefenseEventController._Instance == null)
			{
				TowerDefenseEventController.CreateInstance();
			}
			return TowerDefenseEventController._Instance;
		}

		// Token: 0x06031BDF RID: 203743 RVA: 0x00B8DC4A File Offset: 0x00B8BE4A
		public static bool CreateInstance()
		{
			if (TowerDefenseEventController._Instance != null)
			{
				return true;
			}
			TowerDefenseEventController._Instance = new TowerDefenseEventController();
			return true;
		}

		// Token: 0x06031BE0 RID: 203744 RVA: 0x00B8DC60 File Offset: 0x00B8BE60
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031BE1 RID: 203745 RVA: 0x00B8DC62 File Offset: 0x00B8BE62
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseEventController._Instance = null;
		}

		// Token: 0x06031BE2 RID: 203746 RVA: 0x00B8DC6A File Offset: 0x00B8BE6A
		static TowerDefenseEventController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseEventController.CreateStaticDefaultValue), new Action(TowerDefenseEventController.ResetStaticDefaultValue));
		}

		// Token: 0x0401A8E8 RID: 108776
		private readonly Stat StepUpdateNotifyStat = Stat.Create("TowerDefenseEventController.StepUpdateNotify", "", "");

		// Token: 0x0401A8E9 RID: 108777
		private readonly Stat RaycastStateChangedStat = Stat.Create("TowerDefenseEventController.RaycastStateChanged", "", "");

		// Token: 0x0401A8EA RID: 108778
		private long? CurRaycastOrgan;

		// Token: 0x0401A8EB RID: 108779
		protected bool IsWorldInit;

		// Token: 0x0401A8EC RID: 108780
		public bool TestBpUsing;

		// Token: 0x0401A8ED RID: 108781
		private ETowerDefenseEventProcessStatus ProcessStatusInternal;

		// Token: 0x0401A8EE RID: 108782
		private ETrapDefenseBuildTipsType BuildTipsTypeInternal;

		// Token: 0x0401A8EF RID: 108783
		public readonly TowerDefenseEventEntityRedirectFilter EntityRedirectFilter = new TowerDefenseEventEntityRedirectFilter();

		// Token: 0x0401A8F0 RID: 108784
		private readonly TowerDefenseTrapTemplateInfo TrapTemplateInfo = new TowerDefenseTrapTemplateInfo();

		// Token: 0x0401A8F1 RID: 108785
		[Nullable(2)]
		private TsTowerDefenseEventActor PreviewTrapActor;

		// Token: 0x0401A8F2 RID: 108786
		[Nullable(2)]
		private TsTowerDefenseEventActor PrepareRemoveTrapActor;

		// Token: 0x0401A8F3 RID: 108787
		public readonly TowerDefenseEventRaycastResult RaycastResult = new TowerDefenseEventRaycastResult();

		// Token: 0x0401A8F4 RID: 108788
		private bool IsRaycast;

		// Token: 0x0401A8F5 RID: 108789
		private readonly TowerDefenseEventPreviewMonsterSpawner PreviewMonsterSpawner = new TowerDefenseEventPreviewMonsterSpawner();

		// Token: 0x0401A8F6 RID: 108790
		private long GoldNum;

		// Token: 0x0401A8F7 RID: 108791
		private int BattleWave;

		// Token: 0x0401A8F8 RID: 108792
		[Nullable(2)]
		private static TowerDefenseEventController _Instance;
	}
}

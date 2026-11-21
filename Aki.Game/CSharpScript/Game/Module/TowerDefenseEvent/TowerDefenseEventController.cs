using System;
using System.Collections.Generic;
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
	// Token: 0x02003AAB RID: 15019
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class TowerDefenseEventController : ControllerBase
	{
		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x06026945 RID: 158021 RVA: 0x00AD0BF3 File Offset: 0x00ACEDF3
		public ETowerDefenseEventProcessStatus ProcessStatus
		{
			get
			{
				return this.ProcessStatusInternal;
			}
		}

		// Token: 0x06026946 RID: 158022 RVA: 0x00AD0BFB File Offset: 0x00ACEDFB
		public bool IsInPreview()
		{
			return this.ProcessStatusInternal == ETowerDefenseEventProcessStatus.Ready;
		}

		// Token: 0x06026947 RID: 158023 RVA: 0x00AD0C06 File Offset: 0x00ACEE06
		public bool IsFighting()
		{
			return this.ProcessStatusInternal == ETowerDefenseEventProcessStatus.Fighting;
		}

		// Token: 0x06026948 RID: 158024 RVA: 0x00AD0C11 File Offset: 0x00ACEE11
		public void ResetWorldAttr()
		{
			this.GoldNum = 0L;
			this.BattleWave = 0;
		}

		// Token: 0x06026949 RID: 158025 RVA: 0x00AD0C24 File Offset: 0x00ACEE24
		public bool IsTowerDefenseEventInstance()
		{
			return GameModeController.Instance.IsInInstance() && GameModeModel.Instance.InstanceDungeon != null && GameModeModel.Instance.InstanceDungeon.Value.InstSubType == 37;
		}

		// Token: 0x0602694A RID: 158026 RVA: 0x00AD0C73 File Offset: 0x00ACEE73
		public void InitMap()
		{
			this.InitTowerDefenseEventInstance();
			Net.Instance.Register(ENotifyMessageId.TrapDefenseStepUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStepUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.TrapDefenseEntityDataChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEntityDataChanged));
		}

		// Token: 0x0602694B RID: 158027 RVA: 0x00AD0CB3 File Offset: 0x00ACEEB3
		public void OnWorldDone()
		{
			this.IsWorldInit = true;
			this.ResetWorldAttr();
		}

		// Token: 0x0602694C RID: 158028 RVA: 0x00AD0CC2 File Offset: 0x00ACEEC2
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

		// Token: 0x0602694D RID: 158029 RVA: 0x00AD0CFC File Offset: 0x00ACEEFC
		[NullableContext(2)]
		private void OnEntityDataChanged(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseEntityDataChangeNotify trapDefenseEntityDataChangeNotify = (TrapDefenseEntityDataChangeNotify)msg;
			if (trapDefenseEntityDataChangeNotify != null)
			{
				this.EntityRedirectFilter.UpdateEntity(trapDefenseEntityDataChangeNotify);
			}
		}

		// Token: 0x0602694E RID: 158030 RVA: 0x00AD0D20 File Offset: 0x00ACEF20
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

		// Token: 0x0602694F RID: 158031 RVA: 0x00AD102C File Offset: 0x00ACF22C
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

		// Token: 0x06026950 RID: 158032 RVA: 0x00AD10C0 File Offset: 0x00ACF2C0
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

		// Token: 0x06026951 RID: 158033 RVA: 0x00AD1104 File Offset: 0x00ACF304
		private void InitTowerDefenseEventInstance()
		{
			TrapDefenseActivity? config = ConfigTrapDefenseActivityByInstId.GetConfig(GameModeModel.Instance.InstanceDungeon.Value.Id, true);
			TowerDefenseEventModel.Instance.InitInstance(config);
		}

		// Token: 0x06026952 RID: 158034 RVA: 0x00AD1140 File Offset: 0x00ACF340
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

		// Token: 0x06026953 RID: 158035 RVA: 0x00AD1190 File Offset: 0x00ACF390
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

		// Token: 0x06026954 RID: 158036 RVA: 0x00AD12EC File Offset: 0x00ACF4EC
		private void OnPreviewStepUpdate(TrapDefensePreviewStepPbData data)
		{
			this.PreviewMonsterSpawner.Init(new Dictionary<int, TrapDefenseMonsterPbGroup>(data.MonsterRoutesPreviewInfo));
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

		// Token: 0x06026955 RID: 158037 RVA: 0x00AD1384 File Offset: 0x00ACF584
		private void OnFightingStepUpdate(TrapDefenseSpawnMonsterStepPbData data)
		{
			this.PreviewMonsterSpawner.Reset();
			TrapDefenseModel.Instance.BattleData.SetPreviewCountDown((float)data.EndCountdownSecond);
			TrapDefenseModel.Instance.BattleData.SetSpecialShow(data.IsWarningPrepareStyle);
			Log.Instance.Info(ELogModule.TowerDefenseEvent, ELogAuthor.XXJ, "塔防进入战斗阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06026956 RID: 158038 RVA: 0x00AD13E6 File Offset: 0x00ACF5E6
		public void ControllerTick(float delta)
		{
			this.OnTick(delta);
		}

		// Token: 0x06026957 RID: 158039 RVA: 0x00AD13F0 File Offset: 0x00ACF5F0
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

		// Token: 0x06026958 RID: 158040 RVA: 0x00AD15F0 File Offset: 0x00ACF7F0
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

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x06026959 RID: 158041 RVA: 0x00AD1620 File Offset: 0x00ACF820
		public ETrapDefenseBuildTipsType BuildTipsType
		{
			get
			{
				return this.BuildTipsTypeInternal;
			}
		}

		// Token: 0x0602695A RID: 158042 RVA: 0x00AD1628 File Offset: 0x00ACF828
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

		// Token: 0x0602695B RID: 158043 RVA: 0x00AD16C4 File Offset: 0x00ACF8C4
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

		// Token: 0x0602695C RID: 158044 RVA: 0x00AD1708 File Offset: 0x00ACF908
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

		// Token: 0x0602695D RID: 158045 RVA: 0x00AD1757 File Offset: 0x00ACF957
		public void HandleTowerDefenseSelect(int index)
		{
			TowerDefensePlayerController.EnablePlayerFollower(false);
			this.DoSelectAction(index);
		}

		// Token: 0x0602695E RID: 158046 RVA: 0x00AD1768 File Offset: 0x00ACF968
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

		// Token: 0x0602695F RID: 158047 RVA: 0x00AD17B8 File Offset: 0x00ACF9B8
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

		// Token: 0x06026960 RID: 158048 RVA: 0x00AD17FC File Offset: 0x00ACF9FC
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

		// Token: 0x06026961 RID: 158049 RVA: 0x00AD1840 File Offset: 0x00ACFA40
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

		// Token: 0x06026962 RID: 158050 RVA: 0x00AD1883 File Offset: 0x00ACFA83
		public void ExecuteRotateTrap()
		{
			this.RotateTrap();
		}

		// Token: 0x06026963 RID: 158051 RVA: 0x00AD188C File Offset: 0x00ACFA8C
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

		// Token: 0x06026964 RID: 158052 RVA: 0x00AD1A40 File Offset: 0x00ACFC40
		private void InitPreviewTrapActor()
		{
			if (this.PreviewTrapActor == null)
			{
				this.PreviewTrapActor = (ActorSystem.Instance.Get(TsTowerDefenseEventActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as TsTowerDefenseEventActor);
			}
			this.PreviewTrapActor.Init(this.TrapTemplateInfo, null);
		}

		// Token: 0x06026965 RID: 158053 RVA: 0x00AD1A8E File Offset: 0x00ACFC8E
		private void DestroyPreviewTrapActor(string reason)
		{
			if (this.PreviewTrapActor != null && this.PreviewTrapActor.IsValid())
			{
				this.PreviewTrapActor.Destroy(reason);
			}
			this.PreviewTrapActor = null;
		}

		// Token: 0x06026966 RID: 158054 RVA: 0x00AD1AB8 File Offset: 0x00ACFCB8
		public void RotateTrap()
		{
			this.TrapTemplateInfo.Rotate();
		}

		// Token: 0x06026967 RID: 158055 RVA: 0x00AD1AC5 File Offset: 0x00ACFCC5
		public bool IsEnoughGoldToBuildTrap()
		{
			return TowerDefenseEventModel.Instance.IsEnoughGoldToBuildTrap(this.TrapTemplateInfo);
		}

		// Token: 0x06026968 RID: 158056 RVA: 0x00AD1AD8 File Offset: 0x00ACFCD8
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

		// Token: 0x06026969 RID: 158057 RVA: 0x00AD1B1C File Offset: 0x00ACFD1C
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

		// Token: 0x0602696A RID: 158058 RVA: 0x00AD1B60 File Offset: 0x00ACFD60
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

		// Token: 0x0602696B RID: 158059 RVA: 0x00AD1BA4 File Offset: 0x00ACFDA4
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

		// Token: 0x0602696C RID: 158060 RVA: 0x00AD1BE8 File Offset: 0x00ACFDE8
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

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x0602696D RID: 158061 RVA: 0x00AD1C9B File Offset: 0x00ACFE9B
		public static TowerDefenseEventController Instance
		{
			get
			{
				return TowerDefenseEventController._Instance;
			}
		}

		// Token: 0x0602696E RID: 158062 RVA: 0x00AD1CA2 File Offset: 0x00ACFEA2
		public static TowerDefenseEventController GetOrCreateInstance()
		{
			if (TowerDefenseEventController._Instance == null)
			{
				TowerDefenseEventController.CreateInstance();
			}
			return TowerDefenseEventController._Instance;
		}

		// Token: 0x0602696F RID: 158063 RVA: 0x00AD1CB6 File Offset: 0x00ACFEB6
		public static bool CreateInstance()
		{
			if (TowerDefenseEventController._Instance != null)
			{
				return true;
			}
			TowerDefenseEventController._Instance = new TowerDefenseEventController();
			return true;
		}

		// Token: 0x06026970 RID: 158064 RVA: 0x00AD1CCC File Offset: 0x00ACFECC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026971 RID: 158065 RVA: 0x00AD1CCE File Offset: 0x00ACFECE
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseEventController._Instance = null;
		}

		// Token: 0x06026972 RID: 158066 RVA: 0x00AD1CD6 File Offset: 0x00ACFED6
		static TowerDefenseEventController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseEventController.CreateStaticDefaultValue), new Action(TowerDefenseEventController.ResetStaticDefaultValue));
		}

		// Token: 0x0401523A RID: 86586
		private readonly Stat StepUpdateNotifyStat = Stat.Create("TowerDefenseEventController.StepUpdateNotify", "", "");

		// Token: 0x0401523B RID: 86587
		private readonly Stat RaycastStateChangedStat = Stat.Create("TowerDefenseEventController.RaycastStateChanged", "", "");

		// Token: 0x0401523C RID: 86588
		private long? CurRaycastOrgan;

		// Token: 0x0401523D RID: 86589
		protected bool IsWorldInit;

		// Token: 0x0401523E RID: 86590
		public bool TestBpUsing;

		// Token: 0x0401523F RID: 86591
		private ETowerDefenseEventProcessStatus ProcessStatusInternal;

		// Token: 0x04015240 RID: 86592
		private ETrapDefenseBuildTipsType BuildTipsTypeInternal;

		// Token: 0x04015241 RID: 86593
		public readonly TowerDefenseEventEntityRedirectFilter EntityRedirectFilter = new TowerDefenseEventEntityRedirectFilter();

		// Token: 0x04015242 RID: 86594
		private readonly TowerDefenseTrapTemplateInfo TrapTemplateInfo = new TowerDefenseTrapTemplateInfo();

		// Token: 0x04015243 RID: 86595
		[Nullable(2)]
		private TsTowerDefenseEventActor PreviewTrapActor;

		// Token: 0x04015244 RID: 86596
		[Nullable(2)]
		private TsTowerDefenseEventActor PrepareRemoveTrapActor;

		// Token: 0x04015245 RID: 86597
		public readonly TowerDefenseEventRaycastResult RaycastResult = new TowerDefenseEventRaycastResult();

		// Token: 0x04015246 RID: 86598
		private bool IsRaycast;

		// Token: 0x04015247 RID: 86599
		private readonly TowerDefenseEventPreviewMonsterSpawner PreviewMonsterSpawner = new TowerDefenseEventPreviewMonsterSpawner();

		// Token: 0x04015248 RID: 86600
		private long GoldNum;

		// Token: 0x04015249 RID: 86601
		private int BattleWave;

		// Token: 0x0401524A RID: 86602
		[Nullable(2)]
		private static TowerDefenseEventController _Instance;
	}
}

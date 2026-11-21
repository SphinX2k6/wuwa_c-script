using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003C03 RID: 15363
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SheriffModel : ModelBase
	{
		// Token: 0x060275E7 RID: 161255 RVA: 0x00B08756 File Offset: 0x00B06956
		public SheriffActivityData GetActivityData()
		{
			return SheriffController.Instance.GetActivityData();
		}

		// Token: 0x060275E8 RID: 161256 RVA: 0x00B08764 File Offset: 0x00B06964
		public List<int> GetClueListByAnomalyId(int anomalyId)
		{
			if (this.ClueListMap.Count == 0)
			{
				foreach (SheriffClue sheriffClue in SheriffConfig.Instance.GetAllClueConfig())
				{
					if (!this.ClueListMap.ContainsKey(sheriffClue.SheriffAnomalyId))
					{
						this.ClueListMap[sheriffClue.SheriffAnomalyId] = new List<int>();
					}
					this.ClueListMap[sheriffClue.SheriffAnomalyId].Add(sheriffClue.Id);
				}
			}
			List<int> result;
			if (this.ClueListMap.TryGetValue(anomalyId, out result))
			{
				return result;
			}
			return new List<int>();
		}

		// Token: 0x060275E9 RID: 161257 RVA: 0x00B0881C File Offset: 0x00B06A1C
		public int GetAnomalyProgressPercent(int anomalyId)
		{
			SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(anomalyId);
			if (anomalyInfo == null)
			{
				return 0;
			}
			return anomalyInfo.Progress;
		}

		// Token: 0x060275EA RID: 161258 RVA: 0x00B08830 File Offset: 0x00B06A30
		public bool CheckGameplayActivated(int anomalyId)
		{
			SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(anomalyId);
			return anomalyInfo != null && anomalyInfo.State > ESheriffAnomalyState.UnActivated;
		}

		// Token: 0x060275EB RID: 161259 RVA: 0x00B08854 File Offset: 0x00B06A54
		public bool CheckInBehaviorTreeRange(int anomalyId)
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value;
			return GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, value.MainBTId) != null;
		}

		// Token: 0x060275EC RID: 161260 RVA: 0x00B0888C File Offset: 0x00B06A8C
		public bool IsBehaviorTreeTracking(int anomalyId)
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value;
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, value.MainBTId);
			return behaviorTreeByConfigId != null && behaviorTreeByConfigId.IsTracking();
		}

		// Token: 0x060275ED RID: 161261 RVA: 0x00B088CC File Offset: 0x00B06ACC
		public string GetCurrentBehaviorTreeNodeText(int anomalyId)
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value;
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, value.MainBTId);
			if (behaviorTreeByConfigId == null)
			{
				return "";
			}
			string result = "";
			foreach (BehaviorNodeBase behaviorNodeBase in behaviorTreeByConfigId.GetCurrentActiveChildQuestNodes())
			{
				if (!StringUtils.IsBlank(behaviorNodeBase.MultiTrackText) && behaviorNodeBase.TrackTextConfig != null)
				{
					result = behaviorNodeBase.TrackTextConfig;
				}
			}
			return result;
		}

		// Token: 0x060275EE RID: 161262 RVA: 0x00B08970 File Offset: 0x00B06B70
		public bool CheckInReasoningNode(int anomalyId)
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value;
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, value.MainBTId);
			if (behaviorTreeByConfigId == null)
			{
				return false;
			}
			string btparamName = value.BTParamName;
			VarDefinePb treeVarByKey = behaviorTreeByConfigId.GetTreeVarByKey(btparamName);
			return treeVarByKey != null && treeVarByKey != null && treeVarByKey.Boolean;
		}

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x060275EF RID: 161263 RVA: 0x00B089CA File Offset: 0x00B06BCA
		public PayShopDefine.EPayShopTabType ShopId
		{
			get
			{
				return PayShopDefine.EPayShopTabType.SheriffShop;
			}
		}

		// Token: 0x060275F0 RID: 161264 RVA: 0x00B089D1 File Offset: 0x00B06BD1
		public List<PayShopGoods> GetShopDataList(int level)
		{
			return PayShopModel.Instance.GetPayShopTabData(this.ShopId, level, true);
		}

		// Token: 0x060275F1 RID: 161265 RVA: 0x00B089E8 File Offset: 0x00B06BE8
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Spent",
			"AllNum",
			"Held"
		})]
		public ValueTuple<int, int, int> GetShopGoodsPriceInfo()
		{
			List<int> payShopInfoMoney = PayShopModel.Instance.GetPayShopInfoMoney(this.ShopId);
			int num = (payShopInfoMoney.Count > 0) ? payShopInfoMoney[0] : 0;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
			int num2 = 0;
			int num3 = 0;
			foreach (int tabId in PayShopModel.Instance.GetPayShopTabIdList(this.ShopId, false))
			{
				foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData(this.ShopId, tabId, false))
				{
					IPriceData priceData = payShopGoods.GetPriceData();
					if (priceData.CurrencyId == num)
					{
						PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
						num3 += priceData.NowPrice * goodsData.BuyLimit;
						num2 += priceData.NowPrice * goodsData.BoughtCount;
					}
				}
			}
			return new ValueTuple<int, int, int>(num2, num3, itemCountByConfigId);
		}

		// Token: 0x060275F2 RID: 161266 RVA: 0x00B08B14 File Offset: 0x00B06D14
		public int GetShopItemCount()
		{
			int num = 0;
			foreach (int num2 in this.ZoneItemCountMap.Values)
			{
				num += num2;
			}
			return num;
		}

		// Token: 0x060275F3 RID: 161267 RVA: 0x00B08B6C File Offset: 0x00B06D6C
		public int GetShopCurrencyId()
		{
			List<int> payShopInfoMoney = PayShopModel.Instance.GetPayShopInfoMoney(this.ShopId);
			if (payShopInfoMoney.Count <= 0)
			{
				return 0;
			}
			return payShopInfoMoney[0];
		}

		// Token: 0x060275F4 RID: 161268 RVA: 0x00B08B9C File Offset: 0x00B06D9C
		private bool HasShopAffordableGoods()
		{
			int shopCurrencyId = this.GetShopCurrencyId();
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(shopCurrencyId, 0);
			foreach (int tabId in PayShopModel.Instance.GetPayShopTabIdList(this.ShopId, false))
			{
				foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData(this.ShopId, tabId, false))
				{
					if (!payShopGoods.IsLocked() && payShopGoods.IfCanBuy() && !payShopGoods.IsSoldOut() && payShopGoods.CheckGoodIfShow())
					{
						IPriceData priceData = payShopGoods.GetPriceData();
						if (priceData.CurrencyId == shopCurrencyId && itemCountByConfigId >= priceData.NowPrice)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060275F5 RID: 161269 RVA: 0x00B08CA0 File Offset: 0x00B06EA0
		public bool CheckShopRedDot()
		{
			return !this.ShopRedDotChecked && this.HasShopAffordableGoods();
		}

		// Token: 0x060275F6 RID: 161270 RVA: 0x00B08CB2 File Offset: 0x00B06EB2
		public void ReArmShopRedDot()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.SheriffShopView))
			{
				return;
			}
			this.ShopRedDotChecked = false;
			this.EmitShopRedDotRefresh();
		}

		// Token: 0x060275F7 RID: 161271 RVA: 0x00B08CD3 File Offset: 0x00B06ED3
		public void ClearShopRedDot()
		{
			this.ShopRedDotChecked = true;
			this.EmitShopRedDotRefresh();
		}

		// Token: 0x060275F8 RID: 161272 RVA: 0x00B08CE4 File Offset: 0x00B06EE4
		private void EmitShopRedDotRefresh()
		{
			int activityId = SheriffController.Instance.ActivityId;
			if (activityId > 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			}
			EventSystem.Instance.Emit(EEventName.OnSheriffShopRedDotRefresh);
		}

		// Token: 0x060275F9 RID: 161273 RVA: 0x00B08D24 File Offset: 0x00B06F24
		public void UpdateZoneInfo(IEnumerable<SheriffZoneInfo> info)
		{
			foreach (SheriffZoneInfo sheriffZoneInfo in info)
			{
				this.UpdateAnomalyInfo(sheriffZoneInfo.AnomalyInfos, new int?(sheriffZoneInfo.ZoneId));
				this.UpdateCriminalInfo(sheriffZoneInfo.CriminalInfos, new int?(sheriffZoneInfo.ZoneId));
				this.ZoneItemCountMap[sheriffZoneInfo.ZoneId] = (int)sheriffZoneInfo.ItemCount;
			}
		}

		// Token: 0x060275FA RID: 161274 RVA: 0x00B08DAC File Offset: 0x00B06FAC
		public void UpdateZoneItemCount(int zoneId, int itemCount)
		{
			this.ZoneItemCountMap[zoneId] = itemCount;
		}

		// Token: 0x060275FB RID: 161275 RVA: 0x00B08DBC File Offset: 0x00B06FBC
		public void UpdateAnomalyInfo(IReadOnlyList<SheriffAnomalyInfo> info, int? zoneId = null)
		{
			int num = info.Count - 1;
			for (int i = 0; i < info.Count; i++)
			{
				SheriffAnomalyInfo sheriffAnomalyInfo = info[i];
				if (!this.AnomalyInfoMap.ContainsKey(sheriffAnomalyInfo.AnomalyId))
				{
					this.AnomalyInfoMap[sheriffAnomalyInfo.AnomalyId] = new SheriffAnomalyInfo();
				}
				SheriffAnomalyInfo sheriffAnomalyInfo2 = this.AnomalyInfoMap[sheriffAnomalyInfo.AnomalyId];
				if (i == num)
				{
					List<int> clueIds = sheriffAnomalyInfo2.ClueIds;
					this.LastCacheAnomaly = sheriffAnomalyInfo.AnomalyId;
					List<int> list = (sheriffAnomalyInfo.ClueIds != null) ? new List<int>(sheriffAnomalyInfo.ClueIds) : new List<int>();
					int lastCacheClue = 0;
					foreach (int num2 in list)
					{
						if (!clueIds.Contains(num2))
						{
							lastCacheClue = num2;
							break;
						}
					}
					this.LastCacheClue = lastCacheClue;
				}
				sheriffAnomalyInfo2.UpdateByProto(sheriffAnomalyInfo, zoneId);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Sheriff;
			ELogAuthor author = ELogAuthor.WHJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 2);
			defaultInterpolatedStringHandler.AppendLiteral("UpdateAnomalyInfo LastCacheAnomaly=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastCacheAnomaly);
			defaultInterpolatedStringHandler.AppendLiteral(" LastCacheClue=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LastCacheClue);
			instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060275FC RID: 161276 RVA: 0x00B08F1C File Offset: 0x00B0711C
		public void UpdateCriminalInfo(IEnumerable<SheriffCriminalInfo> info, int? zoneId = null)
		{
			foreach (SheriffCriminalInfo sheriffCriminalInfo in info)
			{
				if (!this.CriminalInfoMap.ContainsKey(sheriffCriminalInfo.CriminalId))
				{
					this.CriminalInfoMap[sheriffCriminalInfo.CriminalId] = new SheriffCriminalInfo();
				}
				SheriffCriminalInfo sheriffCriminalInfo2 = this.CriminalInfoMap[sheriffCriminalInfo.CriminalId];
				sheriffCriminalInfo2.UpdateByProto(sheriffCriminalInfo, zoneId);
				SheriffAnomalyInfo sheriffAnomalyInfo;
				if (this.AnomalyInfoMap.TryGetValue(sheriffCriminalInfo2.AnomalyId, out sheriffAnomalyInfo))
				{
					sheriffAnomalyInfo.CalAnomalyState();
				}
			}
		}

		// Token: 0x060275FD RID: 161277 RVA: 0x00B08FBC File Offset: 0x00B071BC
		[NullableContext(2)]
		public SheriffAnomalyInfo GetAnomalyInfo(int anomalyId)
		{
			SheriffAnomalyInfo result;
			this.AnomalyInfoMap.TryGetValue(anomalyId, out result);
			return result;
		}

		// Token: 0x060275FE RID: 161278 RVA: 0x00B08FDC File Offset: 0x00B071DC
		[NullableContext(2)]
		public SheriffCriminalInfo GetCriminalInfo(int criminalId)
		{
			SheriffCriminalInfo result;
			this.CriminalInfoMap.TryGetValue(criminalId, out result);
			return result;
		}

		// Token: 0x060275FF RID: 161279 RVA: 0x00B08FFC File Offset: 0x00B071FC
		public void CheckNeedOpenReportPop()
		{
			foreach (KeyValuePair<int, SheriffAnomalyInfo> keyValuePair in this.AnomalyInfoMap)
			{
				int num;
				SheriffAnomalyInfo sheriffAnomalyInfo;
				keyValuePair.Deconstruct(out num, out sheriffAnomalyInfo);
				SheriffAnomalyInfo sheriffAnomalyInfo2 = sheriffAnomalyInfo;
				if (sheriffAnomalyInfo2.NeedOpenReport)
				{
					sheriffAnomalyInfo2.NeedOpenReport = false;
					SheriffController.Instance.OpenSheriffReportPop(sheriffAnomalyInfo2.CriminalId, false);
					break;
				}
			}
		}

		// Token: 0x06027600 RID: 161280 RVA: 0x00B09078 File Offset: 0x00B07278
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"ArrestedCount",
			"TotalCount"
		})]
		public ValueTuple<int, int> GetCriminalProgress()
		{
			int num = 0;
			int num2 = 0;
			foreach (SheriffCriminalInfo sheriffCriminalInfo in this.CriminalInfoMap.Values)
			{
				SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(sheriffCriminalInfo.AnomalyId);
				if (anomalyInfo != null && anomalyInfo.MarkId != 0)
				{
					num2++;
					if (sheriffCriminalInfo.State == ESheriffCriminalState.Arrested)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x06027601 RID: 161281 RVA: 0x00B09100 File Offset: 0x00B07300
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"CompletedCount",
			"TotalCount"
		})]
		public ValueTuple<int, int> GetAnomalyProgress()
		{
			int num = 0;
			int num2 = 0;
			foreach (SheriffAnomalyInfo sheriffAnomalyInfo in this.AnomalyInfoMap.Values)
			{
				if (sheriffAnomalyInfo.MarkId != 0)
				{
					num2++;
					if (sheriffAnomalyInfo.State == ESheriffAnomalyState.Completed)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x06027602 RID: 161282 RVA: 0x00B09178 File Offset: 0x00B07378
		public List<SheriffCriminalInfo> GetCriminalList(int zoneId)
		{
			List<SheriffCriminalInfo> list = new List<SheriffCriminalInfo>();
			foreach (SheriffCriminalInfo sheriffCriminalInfo in this.CriminalInfoMap.Values)
			{
				if (sheriffCriminalInfo.ZoneId == zoneId)
				{
					SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(sheriffCriminalInfo.AnomalyId);
					if (anomalyInfo == null || anomalyInfo.MarkId != 0)
					{
						list.Add(sheriffCriminalInfo);
					}
				}
			}
			return list;
		}

		// Token: 0x06027603 RID: 161283 RVA: 0x00B09200 File Offset: 0x00B07400
		public SheriffQuestState GetQuestState(int zoneId, ESheriffQuestType questType)
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			IReadOnlyList<SheriffQuest> questConfigByZoneId = SheriffConfig.Instance.GetQuestConfigByZoneId(zoneId);
			if (questConfigByZoneId != null)
			{
				foreach (SheriffQuest sheriffQuest in questConfigByZoneId)
				{
					if (sheriffQuest.QuestType == (int)questType)
					{
						list2.Add(sheriffQuest.QuestId);
						if (!QuestNewModel.Instance.CheckQuestFinished(sheriffQuest.QuestId))
						{
							list.Add(sheriffQuest.QuestId);
						}
					}
				}
			}
			return new SheriffQuestState
			{
				UnFinishList = list,
				TotalList = list2
			};
		}

		// Token: 0x06027604 RID: 161284 RVA: 0x00B092A8 File Offset: 0x00B074A8
		public int GetTodoCount()
		{
			int num = 0;
			foreach (SheriffAnomalyInfo sheriffAnomalyInfo in this.AnomalyInfoMap.Values)
			{
				if (sheriffAnomalyInfo.MarkId != 0 && sheriffAnomalyInfo.State != ESheriffAnomalyState.Completed && sheriffAnomalyInfo.State != ESheriffAnomalyState.Lock)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06027605 RID: 161285 RVA: 0x00B0931C File Offset: 0x00B0751C
		public int GetTargetAnomalyMarkId()
		{
			foreach (SheriffAnomalyInfo sheriffAnomalyInfo in this.AnomalyInfoMap.Values)
			{
				if (!this.CheckInBehaviorTreeRange(sheriffAnomalyInfo.AnomalyId))
				{
					MapModel instance = MapModel.Instance;
					if (instance == null || !instance.IsMarkTracking(sheriffAnomalyInfo.MarkId))
					{
						continue;
					}
				}
				return sheriffAnomalyInfo.MarkId;
			}
			int num = 0;
			foreach (SheriffAnomalyInfo sheriffAnomalyInfo2 in this.AnomalyInfoMap.Values)
			{
				if (sheriffAnomalyInfo2.MarkId != 0)
				{
					if (num == 0)
					{
						num = sheriffAnomalyInfo2.MarkId;
					}
					if (sheriffAnomalyInfo2.State != ESheriffAnomalyState.Completed && sheriffAnomalyInfo2.State != ESheriffAnomalyState.Lock)
					{
						return sheriffAnomalyInfo2.MarkId;
					}
				}
			}
			return num;
		}

		// Token: 0x06027606 RID: 161286 RVA: 0x00B09418 File Offset: 0x00B07618
		public int GetAnomalyCurrentPercent(int anomalyId)
		{
			SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(anomalyId);
			if (anomalyInfo == null)
			{
				return 0;
			}
			return anomalyInfo.Progress;
		}

		// Token: 0x06027607 RID: 161287 RVA: 0x00B09438 File Offset: 0x00B07638
		public int GetTargetMapMarkIdByQuestIds(List<int> questIds)
		{
			int num = 0;
			if (questIds.Count == 0)
			{
				return num;
			}
			int num2 = 1000;
			global::Vector playerPosition = WorldMapModel.Instance.GetPlayerPosition();
			playerPosition.DivisionEqual((double)num2);
			double num3 = double.MaxValue;
			foreach (int questId in questIds)
			{
				SheriffQuest? questConfigByQuestId = SheriffConfig.Instance.GetQuestConfigByQuestId(questId);
				MapMark? configMark = MapConfig.Instance.GetConfigMark(questConfigByQuestId.Value.MarkId);
				if (QuestNewModel.Instance.IsTrackingQuest(questId))
				{
					num = configMark.Value.MarkId;
					break;
				}
				QuestMarkCreateInfo markByQuestId = MapModel.Instance.GetMarkByQuestId(questId);
				if (markByQuestId != null && markByQuestId.MarkId != null)
				{
					TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
					int? num4 = (curTrackMark != null) ? new int?(curTrackMark.MarkId) : null;
					int? markId = markByQuestId.MarkId;
					if (num4.GetValueOrDefault() == markId.GetValueOrDefault() & num4 != null == (markId != null))
					{
						num = configMark.Value.MarkId;
						break;
					}
				}
				global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(configMark.Value.EntityConfigId, configMark.Value.MapId, false);
				entityPosition.DivisionEqual((double)(num2 * 100));
				double num5 = global::Vector.DistSquared(playerPosition, entityPosition);
				if (num5 < num3)
				{
					num3 = num5;
					num = configMark.Value.MarkId;
				}
			}
			if (num == 0)
			{
				return SheriffConfig.Instance.GetQuestConfigByQuestId(questIds[0]).Value.MarkId;
			}
			return num;
		}

		// Token: 0x06027608 RID: 161288 RVA: 0x00B09620 File Offset: 0x00B07820
		public bool IsShortcutShowMainBoard(BaseBehaviorTree tree)
		{
			ITrackCustomBoard currentNodeCustomTrackBoard = tree.GetCurrentNodeCustomTrackBoard();
			if (((currentNodeCustomTrackBoard != null) ? currentNodeCustomTrackBoard.SheriffMainBoard : null) != null)
			{
				return true;
			}
			foreach (BehaviorNodeBase behaviorNodeBase in tree.GetCurrentActiveLogicNodes())
			{
				LogicNodeBase logicNodeBase = behaviorNodeBase as LogicNodeBase;
				if (logicNodeBase != null)
				{
					ITrackCustomBoardOnBtLogicNode trackCustomBoard = logicNodeBase.TrackCustomBoard;
					if (((trackCustomBoard != null) ? trackCustomBoard.SheriffMainBoard : null) != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x06027609 RID: 161289 RVA: 0x00B096A8 File Offset: 0x00B078A8
		public static SheriffModel Instance
		{
			get
			{
				return SheriffModel._Instance;
			}
		}

		// Token: 0x0602760A RID: 161290 RVA: 0x00B096AF File Offset: 0x00B078AF
		public static SheriffModel GetOrCreateInstance()
		{
			if (SheriffModel._Instance == null)
			{
				SheriffModel.CreateInstance();
			}
			return SheriffModel._Instance;
		}

		// Token: 0x0602760B RID: 161291 RVA: 0x00B096C3 File Offset: 0x00B078C3
		public static bool CreateInstance()
		{
			if (SheriffModel._Instance != null)
			{
				return true;
			}
			SheriffModel._Instance = new SheriffModel();
			return true;
		}

		// Token: 0x0602760C RID: 161292 RVA: 0x00B096D9 File Offset: 0x00B078D9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602760D RID: 161293 RVA: 0x00B096DB File Offset: 0x00B078DB
		public static void ResetStaticDefaultValue()
		{
			SheriffModel._Instance = null;
		}

		// Token: 0x0602760E RID: 161294 RVA: 0x00B096E3 File Offset: 0x00B078E3
		static SheriffModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SheriffModel.CreateStaticDefaultValue), new Action(SheriffModel.ResetStaticDefaultValue));
		}

		// Token: 0x040157A9 RID: 87977
		protected Dictionary<int, List<int>> ClueListMap = new Dictionary<int, List<int>>();

		// Token: 0x040157AA RID: 87978
		protected Dictionary<int, SheriffAnomalyInfo> AnomalyInfoMap = new Dictionary<int, SheriffAnomalyInfo>();

		// Token: 0x040157AB RID: 87979
		protected Dictionary<int, SheriffCriminalInfo> CriminalInfoMap = new Dictionary<int, SheriffCriminalInfo>();

		// Token: 0x040157AC RID: 87980
		protected Dictionary<int, int> ZoneItemCountMap = new Dictionary<int, int>();

		// Token: 0x040157AD RID: 87981
		public Dictionary<int, ESheriffAnomalyState> GmAnomalyStateMap = new Dictionary<int, ESheriffAnomalyState>();

		// Token: 0x040157AE RID: 87982
		public int LastCacheAnomaly;

		// Token: 0x040157AF RID: 87983
		public int LastCacheClue;

		// Token: 0x040157B0 RID: 87984
		private bool ShopRedDotChecked = true;

		// Token: 0x040157B1 RID: 87985
		[Nullable(2)]
		private static SheriffModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004C52 RID: 19538
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SheriffModel : ModelBase
	{
		// Token: 0x06032834 RID: 206900 RVA: 0x00BC3B38 File Offset: 0x00BC1D38
		public SheriffActivityData GetActivityData()
		{
			return SheriffController.Instance.GetActivityData();
		}

		// Token: 0x06032835 RID: 206901 RVA: 0x00BC3B44 File Offset: 0x00BC1D44
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

		// Token: 0x06032836 RID: 206902 RVA: 0x00BC3BFC File Offset: 0x00BC1DFC
		public int GetAnomalyProgressPercent(int anomalyId)
		{
			SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(anomalyId);
			if (anomalyInfo == null)
			{
				return 0;
			}
			return anomalyInfo.Progress;
		}

		// Token: 0x06032837 RID: 206903 RVA: 0x00BC3C10 File Offset: 0x00BC1E10
		public bool CheckGameplayActivated(int anomalyId)
		{
			SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(anomalyId);
			return anomalyInfo != null && anomalyInfo.State > ESheriffAnomalyState.UnActivated;
		}

		// Token: 0x06032838 RID: 206904 RVA: 0x00BC3C34 File Offset: 0x00BC1E34
		public bool CheckInBehaviorTreeRange(int anomalyId)
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value;
			return GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, value.MainBTId) != null;
		}

		// Token: 0x06032839 RID: 206905 RVA: 0x00BC3C6C File Offset: 0x00BC1E6C
		public bool IsBehaviorTreeTracking(int anomalyId)
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value;
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, value.MainBTId);
			return behaviorTreeByConfigId != null && behaviorTreeByConfigId.IsTracking();
		}

		// Token: 0x0603283A RID: 206906 RVA: 0x00BC3CAC File Offset: 0x00BC1EAC
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

		// Token: 0x0603283B RID: 206907 RVA: 0x00BC3D50 File Offset: 0x00BC1F50
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

		// Token: 0x17007CCE RID: 31950
		// (get) Token: 0x0603283C RID: 206908 RVA: 0x00BC3DAA File Offset: 0x00BC1FAA
		public PayShopDefine.EPayShopTabType ShopId
		{
			get
			{
				return PayShopDefine.EPayShopTabType.SheriffShop;
			}
		}

		// Token: 0x0603283D RID: 206909 RVA: 0x00BC3DB1 File Offset: 0x00BC1FB1
		public List<PayShopGoods> GetShopDataList(int level)
		{
			return PayShopModel.Instance.GetPayShopTabData(this.ShopId, level, true);
		}

		// Token: 0x0603283E RID: 206910 RVA: 0x00BC3DC8 File Offset: 0x00BC1FC8
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

		// Token: 0x0603283F RID: 206911 RVA: 0x00BC3EF4 File Offset: 0x00BC20F4
		public int GetShopItemCount()
		{
			int num = 0;
			foreach (int num2 in this.ZoneItemCountMap.Values)
			{
				num += num2;
			}
			return num;
		}

		// Token: 0x06032840 RID: 206912 RVA: 0x00BC3F4C File Offset: 0x00BC214C
		public int GetShopCurrencyId()
		{
			List<int> payShopInfoMoney = PayShopModel.Instance.GetPayShopInfoMoney(this.ShopId);
			if (payShopInfoMoney.Count <= 0)
			{
				return 0;
			}
			return payShopInfoMoney[0];
		}

		// Token: 0x06032841 RID: 206913 RVA: 0x00BC3F7C File Offset: 0x00BC217C
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

		// Token: 0x06032842 RID: 206914 RVA: 0x00BC4080 File Offset: 0x00BC2280
		public bool CheckShopRedDot()
		{
			return !this.ShopRedDotChecked && this.HasShopAffordableGoods();
		}

		// Token: 0x06032843 RID: 206915 RVA: 0x00BC4092 File Offset: 0x00BC2292
		public void ReArmShopRedDot()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.SheriffShopView))
			{
				return;
			}
			this.ShopRedDotChecked = false;
			this.EmitShopRedDotRefresh();
		}

		// Token: 0x06032844 RID: 206916 RVA: 0x00BC40B3 File Offset: 0x00BC22B3
		public void ClearShopRedDot()
		{
			this.ShopRedDotChecked = true;
			this.EmitShopRedDotRefresh();
		}

		// Token: 0x06032845 RID: 206917 RVA: 0x00BC40C4 File Offset: 0x00BC22C4
		private void EmitShopRedDotRefresh()
		{
			int activityId = SheriffController.Instance.ActivityId;
			if (activityId > 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			}
			EventSystem.Instance.Emit(EEventName.OnSheriffShopRedDotRefresh);
		}

		// Token: 0x06032846 RID: 206918 RVA: 0x00BC4104 File Offset: 0x00BC2304
		public void UpdateZoneInfo(List<SheriffZoneInfo> info)
		{
			foreach (SheriffZoneInfo sheriffZoneInfo in info)
			{
				this.UpdateAnomalyInfo(sheriffZoneInfo.AnomalyInfos.ToList<SheriffAnomalyInfo>(), new int?(sheriffZoneInfo.ZoneId));
				this.UpdateCriminalInfo(sheriffZoneInfo.CriminalInfos.ToList<SheriffCriminalInfo>(), new int?(sheriffZoneInfo.ZoneId));
				this.ZoneItemCountMap[sheriffZoneInfo.ZoneId] = (int)sheriffZoneInfo.ItemCount;
			}
		}

		// Token: 0x06032847 RID: 206919 RVA: 0x00BC419C File Offset: 0x00BC239C
		public void UpdateZoneItemCount(int zoneId, int itemCount)
		{
			this.ZoneItemCountMap[zoneId] = itemCount;
		}

		// Token: 0x06032848 RID: 206920 RVA: 0x00BC41AC File Offset: 0x00BC23AC
		public void UpdateAnomalyInfo(List<SheriffAnomalyInfo> info, int? zoneId = null)
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

		// Token: 0x06032849 RID: 206921 RVA: 0x00BC430C File Offset: 0x00BC250C
		public void UpdateCriminalInfo(List<SheriffCriminalInfo> info, int? zoneId = null)
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

		// Token: 0x0603284A RID: 206922 RVA: 0x00BC43B4 File Offset: 0x00BC25B4
		[NullableContext(2)]
		public SheriffAnomalyInfo GetAnomalyInfo(int anomalyId)
		{
			SheriffAnomalyInfo result;
			this.AnomalyInfoMap.TryGetValue(anomalyId, out result);
			return result;
		}

		// Token: 0x0603284B RID: 206923 RVA: 0x00BC43D4 File Offset: 0x00BC25D4
		[NullableContext(2)]
		public SheriffCriminalInfo GetCriminalInfo(int criminalId)
		{
			SheriffCriminalInfo result;
			this.CriminalInfoMap.TryGetValue(criminalId, out result);
			return result;
		}

		// Token: 0x0603284C RID: 206924 RVA: 0x00BC43F4 File Offset: 0x00BC25F4
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

		// Token: 0x0603284D RID: 206925 RVA: 0x00BC4470 File Offset: 0x00BC2670
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

		// Token: 0x0603284E RID: 206926 RVA: 0x00BC44F8 File Offset: 0x00BC26F8
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

		// Token: 0x0603284F RID: 206927 RVA: 0x00BC4570 File Offset: 0x00BC2770
		public List<SheriffCriminalInfo> GetCriminalList(int zoneId)
		{
			return this.CriminalInfoMap.Values.Where(delegate(SheriffCriminalInfo item)
			{
				if (item.ZoneId == zoneId)
				{
					SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(item.AnomalyId);
					return anomalyInfo == null || anomalyInfo.MarkId != 0;
				}
				return false;
			}).ToList<SheriffCriminalInfo>();
		}

		// Token: 0x06032850 RID: 206928 RVA: 0x00BC45B4 File Offset: 0x00BC27B4
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

		// Token: 0x06032851 RID: 206929 RVA: 0x00BC465C File Offset: 0x00BC285C
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

		// Token: 0x06032852 RID: 206930 RVA: 0x00BC46D0 File Offset: 0x00BC28D0
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

		// Token: 0x06032853 RID: 206931 RVA: 0x00BC47CC File Offset: 0x00BC29CC
		public int GetAnomalyCurrentPercent(int anomalyId)
		{
			SheriffAnomalyInfo anomalyInfo = this.GetAnomalyInfo(anomalyId);
			if (anomalyInfo == null)
			{
				return 0;
			}
			return anomalyInfo.Progress;
		}

		// Token: 0x06032854 RID: 206932 RVA: 0x00BC47EC File Offset: 0x00BC29EC
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
				global::Vector entityPosition = WorldMapModel.Instance.GetEntityPosition(configMark.Value.EntityConfigId, configMark.Value.MapId);
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

		// Token: 0x06032855 RID: 206933 RVA: 0x00BC49D4 File Offset: 0x00BC2BD4
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

		// Token: 0x17007CCF RID: 31951
		// (get) Token: 0x06032856 RID: 206934 RVA: 0x00BC4A5C File Offset: 0x00BC2C5C
		public static SheriffModel Instance
		{
			get
			{
				return SheriffModel._Instance;
			}
		}

		// Token: 0x06032857 RID: 206935 RVA: 0x00BC4A63 File Offset: 0x00BC2C63
		public static SheriffModel GetOrCreateInstance()
		{
			if (SheriffModel._Instance == null)
			{
				SheriffModel.CreateInstance();
			}
			return SheriffModel._Instance;
		}

		// Token: 0x06032858 RID: 206936 RVA: 0x00BC4A77 File Offset: 0x00BC2C77
		public static bool CreateInstance()
		{
			if (SheriffModel._Instance != null)
			{
				return true;
			}
			SheriffModel._Instance = new SheriffModel();
			return true;
		}

		// Token: 0x06032859 RID: 206937 RVA: 0x00BC4A8D File Offset: 0x00BC2C8D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603285A RID: 206938 RVA: 0x00BC4A8F File Offset: 0x00BC2C8F
		public static void ResetStaticDefaultValue()
		{
			SheriffModel._Instance = null;
		}

		// Token: 0x0603285B RID: 206939 RVA: 0x00BC4A97 File Offset: 0x00BC2C97
		static SheriffModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SheriffModel.CreateStaticDefaultValue), new Action(SheriffModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AE4C RID: 110156
		protected Dictionary<int, List<int>> ClueListMap = new Dictionary<int, List<int>>();

		// Token: 0x0401AE4D RID: 110157
		protected Dictionary<int, SheriffAnomalyInfo> AnomalyInfoMap = new Dictionary<int, SheriffAnomalyInfo>();

		// Token: 0x0401AE4E RID: 110158
		protected Dictionary<int, SheriffCriminalInfo> CriminalInfoMap = new Dictionary<int, SheriffCriminalInfo>();

		// Token: 0x0401AE4F RID: 110159
		protected Dictionary<int, int> ZoneItemCountMap = new Dictionary<int, int>();

		// Token: 0x0401AE50 RID: 110160
		public Dictionary<int, ESheriffAnomalyState> GmAnomalyStateMap = new Dictionary<int, ESheriffAnomalyState>();

		// Token: 0x0401AE51 RID: 110161
		public int LastCacheAnomaly;

		// Token: 0x0401AE52 RID: 110162
		public int LastCacheClue;

		// Token: 0x0401AE53 RID: 110163
		private bool ShopRedDotChecked = true;

		// Token: 0x0401AE54 RID: 110164
		[Nullable(2)]
		private static SheriffModel _Instance;
	}
}

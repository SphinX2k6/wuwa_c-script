using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048DC RID: 18652
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class InfrastructureModel : ModelBase
	{
		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x0602ECC5 RID: 191685 RVA: 0x00D0C5F9 File Offset: 0x00D0A7F9
		public int TracedRoadId
		{
			get
			{
				return this.TracedRoadIdInner;
			}
		}

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x0602ECC6 RID: 191686 RVA: 0x00D0C601 File Offset: 0x00D0A801
		public int RecommendRoadId
		{
			get
			{
				return this.RecommendRoadIdInner;
			}
		}

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x0602ECC7 RID: 191687 RVA: 0x00D0C609 File Offset: 0x00D0A809
		public long FireExp
		{
			get
			{
				return this.FireExpInner;
			}
		}

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x0602ECC8 RID: 191688 RVA: 0x00D0C611 File Offset: 0x00D0A811
		public int FireLevel
		{
			get
			{
				if (this.FireLevelInner <= 0)
				{
					return 1;
				}
				return this.FireLevelInner;
			}
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x0602ECC9 RID: 191689 RVA: 0x00D0C624 File Offset: 0x00D0A824
		public long FireLevelReachTime
		{
			get
			{
				return this.FireLevelReachTimeInner;
			}
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x0602ECCA RID: 191690 RVA: 0x00D0C62C File Offset: 0x00D0A82C
		public InfrStatusPb FireStatus
		{
			get
			{
				return this.FireStatusInner;
			}
		}

		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x0602ECCB RID: 191691 RVA: 0x00D0C634 File Offset: 0x00D0A834
		public long MoneyCount
		{
			get
			{
				return this.MoneyCountInner;
			}
		}

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x0602ECCC RID: 191692 RVA: 0x00D0C63C File Offset: 0x00D0A83C
		public long MoneyHistorySpent
		{
			get
			{
				return this.MoneyHistorySpentInner;
			}
		}

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x0602ECCD RID: 191693 RVA: 0x00D0C644 File Offset: 0x00D0A844
		public bool NeedHighlightTrackedRoad
		{
			get
			{
				return this.NeedHighlightTrackedRoadInner;
			}
		}

		// Token: 0x0602ECCE RID: 191694 RVA: 0x00D0C64C File Offset: 0x00D0A84C
		public void SetNeedHighlightTrackedRoad(bool value)
		{
			this.NeedHighlightTrackedRoadInner = value;
		}

		// Token: 0x0602ECCF RID: 191695 RVA: 0x00D0C658 File Offset: 0x00D0A858
		public int GetInfrRecordObservatoryLevel()
		{
			ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.InfrRecordObservatoryLevel, EClientStorageSystemIdType.InfrRecordObservatoryLevel, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.InfrRecordObservatoryLevel) as ServerStorageNumber).Get().GetValueOrDefault(1);
		}

		// Token: 0x0602ECD0 RID: 191696 RVA: 0x00D0C694 File Offset: 0x00D0A894
		public bool GetShopHasNewRedDot()
		{
			int infrRecordObservatoryLevel = this.GetInfrRecordObservatoryLevel();
			return this.FireLevel > infrRecordObservatoryLevel;
		}

		// Token: 0x0602ECD1 RID: 191697 RVA: 0x00D0C6B4 File Offset: 0x00D0A8B4
		public void RefreshShopHasNewRedDot()
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.InfrRecordObservatoryLevel) as ServerStorageNumber).Set(new int?(this.FireLevel));
			EventSystem.Instance.Emit(EEventName.InfrastructureShopRedDotUpdate);
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x0602ECD2 RID: 191698 RVA: 0x00D0C718 File Offset: 0x00D0A918
		public bool GetLibraryTaskRedDot()
		{
			using (Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData>.ValueCollection.Enumerator enumerator = this.LibraryTaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == InfrTaskStatusPb.InfrTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602ECD3 RID: 191699 RVA: 0x00D0C778 File Offset: 0x00D0A978
		public bool GetPhoneTaskRedDot()
		{
			using (Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData>.ValueCollection.Enumerator enumerator = this.PhoneTaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == InfrTaskStatusPb.InfrTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602ECD4 RID: 191700 RVA: 0x00D0C7D8 File Offset: 0x00D0A9D8
		public List<int> GetUnreadArchives()
		{
			return this.UnreadArchives;
		}

		// Token: 0x0602ECD5 RID: 191701 RVA: 0x00D0C7E0 File Offset: 0x00D0A9E0
		public void SetArchiveRead(int[] archiveIds)
		{
			List<int> list = new List<int>();
			foreach (int num in this.UnreadArchives)
			{
				if (Array.IndexOf<int>(archiveIds, num) < 0)
				{
					list.Add(num);
				}
			}
			this.UnreadArchives = list;
		}

		// Token: 0x0602ECD6 RID: 191702 RVA: 0x00D0C84C File Offset: 0x00D0AA4C
		public bool GetArchiveIsUnRead(int archiveId)
		{
			return this.UnreadArchives.Contains(archiveId);
		}

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x0602ECD7 RID: 191703 RVA: 0x00D0C85A File Offset: 0x00D0AA5A
		public int InteractingRoadId
		{
			get
			{
				return this.InteractingRoadIdInner;
			}
		}

		// Token: 0x0602ECD8 RID: 191704 RVA: 0x00D0C862 File Offset: 0x00D0AA62
		public void SetInteractingRoadId(int roadId)
		{
			this.InteractingRoadIdInner = roadId;
		}

		// Token: 0x0602ECD9 RID: 191705 RVA: 0x00D0C86B File Offset: 0x00D0AA6B
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602ECDA RID: 191706 RVA: 0x00D0C86E File Offset: 0x00D0AA6E
		public void SetInfrastructureData(InfrPb data)
		{
			this.SetRoadData(data.RoadInfo);
			this.SetFireData(data.FireInfo);
			this.SetLibraryData(data.LibraryInfo);
		}

		// Token: 0x0602ECDB RID: 191707 RVA: 0x00D0C894 File Offset: 0x00D0AA94
		[NullableContext(2)]
		public InfrastructureDefine.IInfrRoadData GetRoadDataByRoadId(int roadId)
		{
			InfrastructureDefine.IInfrRoadData result;
			this.RoadDataMap.TryGetValue(roadId, out result);
			return result;
		}

		// Token: 0x0602ECDC RID: 191708 RVA: 0x00D0C8B4 File Offset: 0x00D0AAB4
		public void SetRoadData(InfrRoadPb data)
		{
			this.RoadDataMap.Clear();
			foreach (InfrOneRoad infrOneRoad in data.Roads)
			{
				this.RoadDataMap[infrOneRoad.RoadId] = new InfrastructureDefine.InfrRoadData
				{
					RoadId = infrOneRoad.RoadId,
					Status = infrOneRoad.Status,
					CompleteTime = (int)MathUtils.Instance.LongToBigInt(infrOneRoad.CompleteTime),
					TotalGiftCount = (int)MathUtils.Instance.LongToBigInt(infrOneRoad.TotalGiftCount),
					LastGiftTime = (int)MathUtils.Instance.LongToBigInt(infrOneRoad.LastGiftTime)
				};
			}
			this.TracedRoadIdInner = data.ManualTraceRoad;
			this.RecommendRoadIdInner = data.RecommendRoad;
			EventSystem.Instance.Emit(EEventName.InfrastructureRoadDataUpdate);
		}

		// Token: 0x0602ECDD RID: 191709 RVA: 0x00D0C9A4 File Offset: 0x00D0ABA4
		public void ChangeTraceRoad(int roadId)
		{
			this.TracedRoadIdInner = roadId;
		}

		// Token: 0x0602ECDE RID: 191710 RVA: 0x00D0C9B0 File Offset: 0x00D0ABB0
		public List<int> GetHasUnlockRoadAndNotPlaySeqMark()
		{
			ServerStorageUtil.OverrideLocalSetToServerSet(ELocalStoragePlayerKey.InfrRoadMarkUnlockRecord, EClientStorageSystemIdType.InfrRoadMarkUnlockRecord, true);
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.InfrRoadMarkUnlockRecord) as ServerStorageSet;
			List<int> list = new List<int>();
			foreach (InfrastructureDefine.IInfrRoadData infrRoadData in this.RoadDataMap.Values)
			{
				if (infrRoadData.Status == InfrStatusPb.InfrStatusProgress && !serverStorageSet.Has(infrRoadData.RoadId))
				{
					list.Add(infrRoadData.RoadId);
				}
			}
			return list;
		}

		// Token: 0x0602ECDF RID: 191711 RVA: 0x00D0CA4C File Offset: 0x00D0AC4C
		public void SetUnlockRoadMarkPlaySeq(int roadId)
		{
			ServerStorageUtil.OverrideLocalSetToServerSet(ELocalStoragePlayerKey.InfrRoadMarkUnlockRecord, EClientStorageSystemIdType.InfrRoadMarkUnlockRecord, true);
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.InfrRoadMarkUnlockRecord) as ServerStorageSet).Add(roadId);
		}

		// Token: 0x0602ECE0 RID: 191712 RVA: 0x00D0CA74 File Offset: 0x00D0AC74
		public bool GetRoadMaterialEnough(int roadId)
		{
			InfrRoadBuild? roadConfigById = InfrastructureConfig.Instance.GetRoadConfigById(roadId);
			InventoryModel instance = InventoryModel.Instance;
			foreach (KeyValuePair<int, int> keyValuePair in roadConfigById.Value.Requirement())
			{
				if (instance.GetItemCountByConfigId(keyValuePair.Key, 0) < keyValuePair.Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602ECE1 RID: 191713 RVA: 0x00D0CAFC File Offset: 0x00D0ACFC
		public List<int> GetCompleteRoadIds()
		{
			List<int> list = new List<int>();
			foreach (int num in this.RoadDataMap.Keys)
			{
				if (this.RoadDataMap[num].Status == InfrStatusPb.InfrStatusComplete)
				{
					list.Add(num);
				}
			}
			return list;
		}

		// Token: 0x0602ECE2 RID: 191714 RVA: 0x00D0CB70 File Offset: 0x00D0AD70
		public void SetFireData(InfrFirePb data)
		{
			this.FireExpInner = MathUtils.Instance.LongToBigInt(data.FireExp);
			this.FireLevelInner = data.FireLevel;
			this.FireLevelReachTimeInner = MathUtils.Instance.LongToBigInt(data.FireLevelReachTime);
			this.FireStatusInner = data.FireStatus;
			EventSystem.Instance.Emit(EEventName.InfrastructureFireDataUpdate);
		}

		// Token: 0x0602ECE3 RID: 191715 RVA: 0x00D0CBD1 File Offset: 0x00D0ADD1
		public void AddFireLevel(InfrFireAddNotify data)
		{
			this.SetFireData(data.FireInfo);
		}

		// Token: 0x0602ECE4 RID: 191716 RVA: 0x00D0CBDF File Offset: 0x00D0ADDF
		public void SetFireShopCoinData(FireShopCoinNotify data)
		{
			this.MoneyCountInner = MathUtils.Instance.LongToBigInt(data.MoneyCount);
			this.MoneyHistorySpentInner = MathUtils.Instance.LongToBigInt(data.MoneyHistorySpent);
		}

		// Token: 0x0602ECE5 RID: 191717 RVA: 0x00D0CC10 File Offset: 0x00D0AE10
		public void SetLibraryData(InfrLibraryPb data)
		{
			this.SetArchiveTaskData(data.ArchiveTasks);
			this.SetPhoneTaskData(data.PhoneTasks);
			int[] array = new int[data.UnreadArchives.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = data.UnreadArchives[i];
			}
			this.SetUnreadArchives(array);
		}

		// Token: 0x0602ECE6 RID: 191718 RVA: 0x00D0CC6C File Offset: 0x00D0AE6C
		public void SetArchiveTaskData(IReadOnlyList<InfrTaskPb> data)
		{
			this.LibraryTaskDataMap.Clear();
			foreach (InfrTaskPb infrTaskPb in data)
			{
				this.LibraryTaskDataMap[infrTaskPb.TaskId] = new InfrastructureDefine.InfrLibraryTaskData
				{
					TaskId = infrTaskPb.TaskId,
					Target = infrTaskPb.Target,
					Status = infrTaskPb.Status
				};
			}
			EventSystem.Instance.Emit(EEventName.InfrastructureArchiveTaskUpdate);
		}

		// Token: 0x0602ECE7 RID: 191719 RVA: 0x00D0CD04 File Offset: 0x00D0AF04
		public void SetPhoneTaskData(IReadOnlyList<InfrTaskPb> data)
		{
			this.PhoneTaskDataMap.Clear();
			foreach (InfrTaskPb infrTaskPb in data)
			{
				this.PhoneTaskDataMap[infrTaskPb.TaskId] = new InfrastructureDefine.InfrLibraryTaskData
				{
					TaskId = infrTaskPb.TaskId,
					Target = infrTaskPb.Target,
					Status = infrTaskPb.Status
				};
			}
			EventSystem.Instance.Emit(EEventName.InfrastructurePhoneTaskUpdate);
		}

		// Token: 0x0602ECE8 RID: 191720 RVA: 0x00D0CD9C File Offset: 0x00D0AF9C
		public void SetUnreadArchives(int[] data)
		{
			this.UnreadArchives = new List<int>(data);
		}

		// Token: 0x0602ECE9 RID: 191721 RVA: 0x00D0CDAA File Offset: 0x00D0AFAA
		public void SetLibraryTaskData(InfrLibraryTaskUpdateNotify data)
		{
			this.SetArchiveTaskData(data.ArchiveTasks);
			this.SetPhoneTaskData(data.PhoneTasks);
		}

		// Token: 0x0602ECEA RID: 191722 RVA: 0x00D0CDC4 File Offset: 0x00D0AFC4
		[NullableContext(2)]
		public InfrastructureDefine.IInfrLibraryTaskData GetLibraryTaskDataByTaskId(int taskId)
		{
			InfrastructureDefine.IInfrLibraryTaskData result;
			this.LibraryTaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x0602ECEB RID: 191723 RVA: 0x00D0CDE4 File Offset: 0x00D0AFE4
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetLibraryTaskDataByTaskState(InfrTaskStatusPb taskState)
		{
			List<InfrastructureDefine.IInfrLibraryTaskData> list = new List<InfrastructureDefine.IInfrLibraryTaskData>();
			foreach (InfrastructureDefine.IInfrLibraryTaskData infrLibraryTaskData in this.LibraryTaskDataMap.Values)
			{
				if (infrLibraryTaskData.Status == taskState)
				{
					list.Add(infrLibraryTaskData);
				}
			}
			return list;
		}

		// Token: 0x0602ECEC RID: 191724 RVA: 0x00D0CE4C File Offset: 0x00D0B04C
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetLibraryTaskData()
		{
			List<InfrastructureDefine.IInfrLibraryTaskData> list = new List<InfrastructureDefine.IInfrLibraryTaskData>();
			foreach (InfrastructureDefine.IInfrLibraryTaskData item in this.LibraryTaskDataMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602ECED RID: 191725 RVA: 0x00D0CEAC File Offset: 0x00D0B0AC
		[NullableContext(2)]
		public InfrastructureDefine.IInfrLibraryTaskData GetPhoneTaskDataByTaskId(int taskId)
		{
			InfrastructureDefine.IInfrLibraryTaskData result;
			this.PhoneTaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x0602ECEE RID: 191726 RVA: 0x00D0CECC File Offset: 0x00D0B0CC
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetPhoneTaskDataByTaskState(InfrTaskStatusPb taskState)
		{
			List<InfrastructureDefine.IInfrLibraryTaskData> list = new List<InfrastructureDefine.IInfrLibraryTaskData>();
			foreach (InfrastructureDefine.IInfrLibraryTaskData infrLibraryTaskData in this.PhoneTaskDataMap.Values)
			{
				if (infrLibraryTaskData.Status == taskState)
				{
					list.Add(infrLibraryTaskData);
				}
			}
			return list;
		}

		// Token: 0x0602ECEF RID: 191727 RVA: 0x00D0CF34 File Offset: 0x00D0B134
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetPhoneTaskData()
		{
			List<InfrastructureDefine.IInfrLibraryTaskData> list = new List<InfrastructureDefine.IInfrLibraryTaskData>();
			foreach (InfrastructureDefine.IInfrLibraryTaskData item in this.PhoneTaskDataMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602ECF0 RID: 191728 RVA: 0x00D0CF94 File Offset: 0x00D0B194
		public List<PayShopGoods> GetShopDataList(int level, bool isSort = true)
		{
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.InfrFireShop, level, isSort);
			if (PayShopModel.Instance.ReadShopItemCheckFlag(PayShopDefine.EPayShopTabType.InfrFireShop, 1))
			{
				EventSystem.Instance.Emit(EEventName.InfrastructureFireShopRefresh);
			}
			return payShopTabData;
		}

		// Token: 0x0602ECF1 RID: 191729 RVA: 0x00D0CFCC File Offset: 0x00D0B1CC
		public int GetAllShopCurrencyNum()
		{
			PayShopGoods[] array = NoLinq.SelectManyToArray<InfrLevel, PayShopGoods>(InfrastructureConfig.Instance.GetAllLevelConfigs(), delegate(InfrLevel level)
			{
				if (level.Level <= 1)
				{
					return Array.Empty<PayShopGoods>();
				}
				return this.GetShopDataList(level.Level, false);
			});
			int num = 0;
			foreach (PayShopGoods payShopGoods in array)
			{
				IPriceData priceData = payShopGoods.GetPriceData();
				if (priceData.CurrencyId == 80700004)
				{
					num += priceData.NowPrice * payShopGoods.GetGoodsData().BuyLimit;
				}
			}
			return num;
		}

		// Token: 0x0602ECF2 RID: 191730 RVA: 0x00D0D036 File Offset: 0x00D0B236
		public void SetActivityData(InfrastructureActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0602ECF3 RID: 191731 RVA: 0x00D0D040 File Offset: 0x00D0B240
		[NullableContext(2)]
		public InfrastructureActivityData GetActivityData()
		{
			if (this.ActivityData == null)
			{
				Log.Instance.Error(ELogModule.Infrastructure, ELogAuthor.LYX, "InfrastructureActivityData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.ActivityData;
		}

		// Token: 0x0602ECF4 RID: 191732 RVA: 0x00D0D07C File Offset: 0x00D0B27C
		public int GetOpenShopId()
		{
			return 219;
		}

		// Token: 0x0602ECF5 RID: 191733 RVA: 0x00D0D083 File Offset: 0x00D0B283
		public void UpdateActivityTaskData(InfrThemeActivityTaskDataUpdateNotify data)
		{
			InfrastructureActivityData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.UpdateActivityTaskData(data.ActivityTask);
			}
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x0602ECF6 RID: 191734 RVA: 0x00D0D0BF File Offset: 0x00D0B2BF
		public IActivityRewardViewData GetScoreRewardData()
		{
			return new ActivityRewardViewData
			{
				DataPageList = new List<IActivityRewardDataPage>
				{
					this.GetCollectionRewardViewData(),
					this.GetRoleMessageViewData()
				},
				Source = EActivityRewardSource.Infrastructure,
				TitleTextId = "PrefabTextItem_1336900617_Text"
			};
		}

		// Token: 0x0602ECF7 RID: 191735 RVA: 0x00D0D100 File Offset: 0x00D0B300
		private IActivityRewardDataPage GetCollectionRewardViewData()
		{
			List<IActivityRewardData> list = new List<IActivityRewardData>();
			foreach (InfrArchiveTask infrArchiveTask in InfrastructureConfig.Instance.GetInfrArchiveTaskList())
			{
				InfrastructureDefine.IInfrLibraryTaskData libraryTaskDataByTaskId = this.GetLibraryTaskDataByTaskId(infrArchiveTask.TaskId);
				List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(infrArchiveTask.TaskReward);
				InfrTaskStatusPb infrTaskStatusPb = (libraryTaskDataByTaskId != null) ? libraryTaskDataByTaskId.Status : InfrTaskStatusPb.InfrTaskRunning;
				ActivityRewardData activityRewardData = new ActivityRewardData();
				activityRewardData.Id = new int?(infrArchiveTask.TaskId);
				activityRewardData.NameText = "";
				activityRewardData.NameTextId = "BuildArchives_GeneralTask";
				activityRewardData.NameTextArgs = new string[]
				{
					infrArchiveTask.Target.ToString()
				};
				activityRewardData.RewardList = dropPackagePreviewItemList.ToArray();
				activityRewardData.RewardState = InfrastructureDefine.infrTaskStateToRewardStateResolver[infrTaskStatusPb];
				activityRewardData.RewardButtonTextId = InfrastructureDefine.infrTaskStateToRewardText[infrTaskStatusPb];
				activityRewardData.RewardButtonRedDot = new bool?(infrTaskStatusPb == InfrTaskStatusPb.InfrTaskTaken);
				activityRewardData.ClickFunction = delegate()
				{
					InfrastructureController.Instance.RequestInfrastructureArchiveTaskReward().Forget<bool>();
				};
				ActivityRewardData item = activityRewardData;
				list.Add(item);
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BuildRoadFile_RecordsPage", null);
			return new ActivityRewardDataPage
			{
				TabName = localTextNew,
				DataList = list
			};
		}

		// Token: 0x0602ECF8 RID: 191736 RVA: 0x00D0D278 File Offset: 0x00D0B478
		private IActivityRewardDataPage GetRoleMessageViewData()
		{
			List<IActivityRewardData> list = new List<IActivityRewardData>();
			foreach (InfrPhoneTask infrPhoneTask in InfrastructureConfig.Instance.GetInfrPhoneTaskList())
			{
				InfrastructureDefine.IInfrLibraryTaskData phoneTaskDataByTaskId = this.GetPhoneTaskDataByTaskId(infrPhoneTask.TaskId);
				List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(infrPhoneTask.TaskReward);
				InfrTaskStatusPb infrTaskStatusPb = (phoneTaskDataByTaskId != null) ? phoneTaskDataByTaskId.Status : InfrTaskStatusPb.InfrTaskRunning;
				ActivityRewardData activityRewardData = new ActivityRewardData();
				activityRewardData.Id = new int?(infrPhoneTask.TaskId);
				activityRewardData.NameText = "";
				activityRewardData.NameTextId = "BuildArchives_GeneralCommunication";
				activityRewardData.NameTextArgs = new string[]
				{
					infrPhoneTask.Target.ToString()
				};
				activityRewardData.RewardList = dropPackagePreviewItemList.ToArray();
				activityRewardData.RewardState = InfrastructureDefine.infrTaskStateToRewardStateResolver[infrTaskStatusPb];
				activityRewardData.RewardButtonTextId = InfrastructureDefine.infrTaskStateToRewardText[infrTaskStatusPb];
				activityRewardData.RewardButtonRedDot = new bool?(infrTaskStatusPb == InfrTaskStatusPb.InfrTaskTaken);
				activityRewardData.ClickFunction = delegate()
				{
					InfrastructureController.Instance.RequestInfrastructurePhoneTaskReward().Forget<bool>();
				};
				ActivityRewardData item = activityRewardData;
				list.Add(item);
			}
			return new ActivityRewardDataPage
			{
				TabName = ConfigMultiTextLang.GetLocalTextNew("BuildRoadFile_MessagePage", null),
				DataList = list
			};
		}

		// Token: 0x0602ECF9 RID: 191737 RVA: 0x00D0D3EC File Offset: 0x00D0B5EC
		public bool GetArchiveRedDot()
		{
			IEnumerable<InfrArchiveTask> infrArchiveTaskList = InfrastructureConfig.Instance.GetInfrArchiveTaskList();
			IReadOnlyList<InfrPhoneTask> infrPhoneTaskList = InfrastructureConfig.Instance.GetInfrPhoneTaskList();
			bool flag = false;
			foreach (InfrArchiveTask infrArchiveTask in infrArchiveTaskList)
			{
				InfrastructureDefine.IInfrLibraryTaskData libraryTaskDataByTaskId = this.GetLibraryTaskDataByTaskId(infrArchiveTask.TaskId);
				if (libraryTaskDataByTaskId != null && libraryTaskDataByTaskId.Status == InfrTaskStatusPb.InfrTaskFinish)
				{
					flag = true;
					break;
				}
			}
			bool flag2 = false;
			foreach (InfrPhoneTask infrPhoneTask in infrPhoneTaskList)
			{
				InfrastructureDefine.IInfrLibraryTaskData phoneTaskDataByTaskId = this.GetPhoneTaskDataByTaskId(infrPhoneTask.TaskId);
				if (phoneTaskDataByTaskId != null && phoneTaskDataByTaskId.Status == InfrTaskStatusPb.InfrTaskFinish)
				{
					flag2 = true;
					break;
				}
			}
			return flag || flag2;
		}

		// Token: 0x0602ECFA RID: 191738 RVA: 0x00D0D4C4 File Offset: 0x00D0B6C4
		public int GetCurrentQuestId()
		{
			InfrLevel? levelConfigById = InfrastructureConfig.Instance.GetLevelConfigById(this.FireLevel);
			if (levelConfigById.Value.QuestIdsLength == 0)
			{
				return 0;
			}
			int j = 0;
			for (int i = 0; i < levelConfigById.Value.QuestIdsLength; i++)
			{
				int questId = levelConfigById.Value.QuestIds(i);
				global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
				if (quest != null && quest.CanShowInUiPanel())
				{
					j = i;
					break;
				}
			}
			return levelConfigById.Value.QuestIds(j);
		}

		// Token: 0x0602ECFB RID: 191739 RVA: 0x00D0D554 File Offset: 0x00D0B754
		public InfrastructureLoadingPanel CreateLoadingPanel()
		{
			if (this.LoadingPanel != null)
			{
				this.DestroyLoadingPanel();
				Log.Instance.Error(ELogModule.Infrastructure, ELogAuthor.LYX, "LoadingPanel is not undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.LoadingPanel = new InfrastructureLoadingPanel();
			return this.LoadingPanel;
		}

		// Token: 0x0602ECFC RID: 191740 RVA: 0x00D0D59F File Offset: 0x00D0B79F
		public void CloseLoadingPanel()
		{
			InfrastructureLoadingPanel loadingPanel = this.LoadingPanel;
			if (loadingPanel == null)
			{
				return;
			}
			loadingPanel.CloseSelf();
		}

		// Token: 0x0602ECFD RID: 191741 RVA: 0x00D0D5B1 File Offset: 0x00D0B7B1
		public void DestroyLoadingPanel()
		{
			InfrastructureLoadingPanel loadingPanel = this.LoadingPanel;
			if (loadingPanel != null)
			{
				loadingPanel.Destroy(null);
			}
			this.LoadingPanel = null;
		}

		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x0602ECFE RID: 191742 RVA: 0x00D0D5CC File Offset: 0x00D0B7CC
		public static InfrastructureModel Instance
		{
			get
			{
				return InfrastructureModel._Instance;
			}
		}

		// Token: 0x0602ECFF RID: 191743 RVA: 0x00D0D5D3 File Offset: 0x00D0B7D3
		public static InfrastructureModel GetOrCreateInstance()
		{
			if (InfrastructureModel._Instance == null)
			{
				InfrastructureModel.CreateInstance();
			}
			return InfrastructureModel._Instance;
		}

		// Token: 0x0602ED00 RID: 191744 RVA: 0x00D0D5E7 File Offset: 0x00D0B7E7
		public static bool CreateInstance()
		{
			if (InfrastructureModel._Instance != null)
			{
				return true;
			}
			InfrastructureModel._Instance = new InfrastructureModel();
			return true;
		}

		// Token: 0x0602ED01 RID: 191745 RVA: 0x00D0D5FD File Offset: 0x00D0B7FD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602ED02 RID: 191746 RVA: 0x00D0D5FF File Offset: 0x00D0B7FF
		public static void ResetStaticDefaultValue()
		{
			InfrastructureModel._Instance = null;
		}

		// Token: 0x0602ED03 RID: 191747 RVA: 0x00D0D607 File Offset: 0x00D0B807
		static InfrastructureModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InfrastructureModel.CreateStaticDefaultValue), new Action(InfrastructureModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018D8B RID: 101771
		private int InteractingRoadIdInner;

		// Token: 0x04018D8C RID: 101772
		[Nullable(2)]
		private InfrastructureLoadingPanel LoadingPanel;

		// Token: 0x04018D8D RID: 101773
		private readonly Dictionary<int, InfrastructureDefine.IInfrRoadData> RoadDataMap = new Dictionary<int, InfrastructureDefine.IInfrRoadData>();

		// Token: 0x04018D8E RID: 101774
		private int TracedRoadIdInner;

		// Token: 0x04018D8F RID: 101775
		private int RecommendRoadIdInner;

		// Token: 0x04018D90 RID: 101776
		public bool NeedHighlightTrackedRoadInner;

		// Token: 0x04018D91 RID: 101777
		private long FireExpInner;

		// Token: 0x04018D92 RID: 101778
		private int FireLevelInner;

		// Token: 0x04018D93 RID: 101779
		private long FireLevelReachTimeInner;

		// Token: 0x04018D94 RID: 101780
		private InfrStatusPb FireStatusInner;

		// Token: 0x04018D95 RID: 101781
		private long MoneyCountInner;

		// Token: 0x04018D96 RID: 101782
		private long MoneyHistorySpentInner;

		// Token: 0x04018D97 RID: 101783
		private readonly Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData> LibraryTaskDataMap = new Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData>();

		// Token: 0x04018D98 RID: 101784
		private readonly Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData> PhoneTaskDataMap = new Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData>();

		// Token: 0x04018D99 RID: 101785
		private List<int> UnreadArchives = new List<int>();

		// Token: 0x04018D9A RID: 101786
		[Nullable(2)]
		private InfrastructureActivityData ActivityData;

		// Token: 0x04018D9B RID: 101787
		[Nullable(2)]
		private static InfrastructureModel _Instance;
	}
}

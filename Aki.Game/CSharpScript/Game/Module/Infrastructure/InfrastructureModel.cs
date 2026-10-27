using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005903 RID: 22787
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class InfrastructureModel : ModelBase
	{
		// Token: 0x17008ACB RID: 35531
		// (get) Token: 0x06039D9F RID: 236959 RVA: 0x00DBD5E9 File Offset: 0x00DBB7E9
		public int TracedRoadId
		{
			get
			{
				return this.TracedRoadIdInner;
			}
		}

		// Token: 0x17008ACC RID: 35532
		// (get) Token: 0x06039DA0 RID: 236960 RVA: 0x00DBD5F1 File Offset: 0x00DBB7F1
		public int RecommendRoadId
		{
			get
			{
				return this.RecommendRoadIdInner;
			}
		}

		// Token: 0x17008ACD RID: 35533
		// (get) Token: 0x06039DA1 RID: 236961 RVA: 0x00DBD5F9 File Offset: 0x00DBB7F9
		public long FireExp
		{
			get
			{
				return this.FireExpInner;
			}
		}

		// Token: 0x17008ACE RID: 35534
		// (get) Token: 0x06039DA2 RID: 236962 RVA: 0x00DBD601 File Offset: 0x00DBB801
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

		// Token: 0x17008ACF RID: 35535
		// (get) Token: 0x06039DA3 RID: 236963 RVA: 0x00DBD614 File Offset: 0x00DBB814
		public long FireLevelReachTime
		{
			get
			{
				return this.FireLevelReachTimeInner;
			}
		}

		// Token: 0x17008AD0 RID: 35536
		// (get) Token: 0x06039DA4 RID: 236964 RVA: 0x00DBD61C File Offset: 0x00DBB81C
		public InfrStatusPb FireStatus
		{
			get
			{
				return this.FireStatusInner;
			}
		}

		// Token: 0x17008AD1 RID: 35537
		// (get) Token: 0x06039DA5 RID: 236965 RVA: 0x00DBD624 File Offset: 0x00DBB824
		public long MoneyCount
		{
			get
			{
				return this.MoneyCountInner;
			}
		}

		// Token: 0x17008AD2 RID: 35538
		// (get) Token: 0x06039DA6 RID: 236966 RVA: 0x00DBD62C File Offset: 0x00DBB82C
		public long MoneyHistorySpent
		{
			get
			{
				return this.MoneyHistorySpentInner;
			}
		}

		// Token: 0x17008AD3 RID: 35539
		// (get) Token: 0x06039DA7 RID: 236967 RVA: 0x00DBD634 File Offset: 0x00DBB834
		public bool NeedHighlightTrackedRoad
		{
			get
			{
				return this.NeedHighlightTrackedRoadInner;
			}
		}

		// Token: 0x06039DA8 RID: 236968 RVA: 0x00DBD63C File Offset: 0x00DBB83C
		public void SetNeedHighlightTrackedRoad(bool value)
		{
			this.NeedHighlightTrackedRoadInner = value;
		}

		// Token: 0x06039DA9 RID: 236969 RVA: 0x00DBD645 File Offset: 0x00DBB845
		public int GetInfrRecordObservatoryLevel()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.InfrRecordObservatoryLevel, 1);
		}

		// Token: 0x06039DAA RID: 236970 RVA: 0x00DBD654 File Offset: 0x00DBB854
		public bool GetShopHasNewRedDot()
		{
			int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.InfrRecordObservatoryLevel, 1);
			return this.FireLevel > player;
		}

		// Token: 0x06039DAB RID: 236971 RVA: 0x00DBD678 File Offset: 0x00DBB878
		public void RefreshShopHasNewRedDot()
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.InfrRecordObservatoryLevel, this.FireLevel);
			EventSystem.Instance.Emit(EEventName.InfrastructureShopRedDotUpdate);
			if (this.ActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
			}
		}

		// Token: 0x06039DAC RID: 236972 RVA: 0x00DBD6CC File Offset: 0x00DBB8CC
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

		// Token: 0x06039DAD RID: 236973 RVA: 0x00DBD72C File Offset: 0x00DBB92C
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

		// Token: 0x06039DAE RID: 236974 RVA: 0x00DBD78C File Offset: 0x00DBB98C
		public List<int> GetUnreadArchives()
		{
			return this.UnreadArchives;
		}

		// Token: 0x06039DAF RID: 236975 RVA: 0x00DBD794 File Offset: 0x00DBB994
		public void SetArchiveRead(int[] archiveIds)
		{
			this.UnreadArchives = (from id in this.UnreadArchives
			where !archiveIds.Contains(id)
			select id).ToList<int>();
		}

		// Token: 0x06039DB0 RID: 236976 RVA: 0x00DBD7D0 File Offset: 0x00DBB9D0
		public bool GetArchiveIsUnRead(int archiveId)
		{
			return this.UnreadArchives.Contains(archiveId);
		}

		// Token: 0x17008AD4 RID: 35540
		// (get) Token: 0x06039DB1 RID: 236977 RVA: 0x00DBD7DE File Offset: 0x00DBB9DE
		public int InteractingRoadId
		{
			get
			{
				return this.InteractingRoadIdInner;
			}
		}

		// Token: 0x06039DB2 RID: 236978 RVA: 0x00DBD7E6 File Offset: 0x00DBB9E6
		public void SetInteractingRoadId(int roadId)
		{
			this.InteractingRoadIdInner = roadId;
		}

		// Token: 0x06039DB3 RID: 236979 RVA: 0x00DBD7EF File Offset: 0x00DBB9EF
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06039DB4 RID: 236980 RVA: 0x00DBD7F2 File Offset: 0x00DBB9F2
		public void SetInfrastructureData(InfrPb data)
		{
			this.SetRoadData(data.RoadInfo);
			this.SetFireData(data.FireInfo);
			this.SetLibraryData(data.LibraryInfo);
		}

		// Token: 0x06039DB5 RID: 236981 RVA: 0x00DBD818 File Offset: 0x00DBBA18
		[NullableContext(2)]
		public InfrastructureDefine.IInfrRoadData GetRoadDataByRoadId(int roadId)
		{
			InfrastructureDefine.IInfrRoadData result;
			this.RoadDataMap.TryGetValue(roadId, out result);
			return result;
		}

		// Token: 0x06039DB6 RID: 236982 RVA: 0x00DBD838 File Offset: 0x00DBBA38
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

		// Token: 0x06039DB7 RID: 236983 RVA: 0x00DBD928 File Offset: 0x00DBBB28
		public void ChangeTraceRoad(int roadId)
		{
			this.TracedRoadIdInner = roadId;
		}

		// Token: 0x06039DB8 RID: 236984 RVA: 0x00DBD934 File Offset: 0x00DBBB34
		public List<int> GetHasUnlockRoadAndNotPlaySeqMark()
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.InfrRoadMarkUnlockRecord, null) ?? new HashSet<int>();
			List<int> list = new List<int>();
			foreach (InfrastructureDefine.IInfrRoadData infrRoadData in this.RoadDataMap.Values)
			{
				if (infrRoadData.Status == InfrStatusPb.InfrStatusProgress && !hashSet.Contains(infrRoadData.RoadId))
				{
					list.Add(infrRoadData.RoadId);
				}
			}
			return list;
		}

		// Token: 0x06039DB9 RID: 236985 RVA: 0x00DBD9C4 File Offset: 0x00DBBBC4
		public void SetUnlockRoadMarkPlaySeq(int roadId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.InfrRoadMarkUnlockRecord, null) ?? new HashSet<int>();
			hashSet.Add(roadId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.InfrRoadMarkUnlockRecord, hashSet);
		}

		// Token: 0x06039DBA RID: 236986 RVA: 0x00DBD9FC File Offset: 0x00DBBBFC
		public bool GetRoadMaterialEnough(int roadId)
		{
			IEnumerable<KeyValuePair<int, int>> source = InfrastructureConfig.Instance.GetRoadConfigById(roadId).Value.Requirement().ToList<KeyValuePair<int, int>>();
			InventoryModel inventoryModel = InventoryModel.Instance;
			return source.All((KeyValuePair<int, int> item) => inventoryModel.GetItemCountByConfigId(item.Key, 0) >= item.Value);
		}

		// Token: 0x06039DBB RID: 236987 RVA: 0x00DBDA4B File Offset: 0x00DBBC4B
		public List<int> GetCompleteRoadIds()
		{
			return (from id in this.RoadDataMap.Keys
			where this.RoadDataMap[id].Status == InfrStatusPb.InfrStatusComplete
			select id).ToList<int>();
		}

		// Token: 0x06039DBC RID: 236988 RVA: 0x00DBDA70 File Offset: 0x00DBBC70
		public void SetFireData(InfrFirePb data)
		{
			this.FireExpInner = MathUtils.Instance.LongToBigInt(data.FireExp);
			this.FireLevelInner = data.FireLevel;
			this.FireLevelReachTimeInner = MathUtils.Instance.LongToBigInt(data.FireLevelReachTime);
			this.FireStatusInner = data.FireStatus;
			EventSystem.Instance.Emit(EEventName.InfrastructureFireDataUpdate);
		}

		// Token: 0x06039DBD RID: 236989 RVA: 0x00DBDAD1 File Offset: 0x00DBBCD1
		public void AddFireLevel(InfrFireAddNotify data)
		{
			this.SetFireData(data.FireInfo);
		}

		// Token: 0x06039DBE RID: 236990 RVA: 0x00DBDADF File Offset: 0x00DBBCDF
		public void SetFireShopCoinData(FireShopCoinNotify data)
		{
			this.MoneyCountInner = MathUtils.Instance.LongToBigInt(data.MoneyCount);
			this.MoneyHistorySpentInner = MathUtils.Instance.LongToBigInt(data.MoneyHistorySpent);
		}

		// Token: 0x06039DBF RID: 236991 RVA: 0x00DBDB0D File Offset: 0x00DBBD0D
		public void SetLibraryData(InfrLibraryPb data)
		{
			this.SetArchiveTaskData(data.ArchiveTasks.ToArray<InfrTaskPb>());
			this.SetPhoneTaskData(data.PhoneTasks.ToArray<InfrTaskPb>());
			this.SetUnreadArchives(data.UnreadArchives.ToArray<int>());
		}

		// Token: 0x06039DC0 RID: 236992 RVA: 0x00DBDB44 File Offset: 0x00DBBD44
		public void SetArchiveTaskData(InfrTaskPb[] data)
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

		// Token: 0x06039DC1 RID: 236993 RVA: 0x00DBDBBC File Offset: 0x00DBBDBC
		public void SetPhoneTaskData(InfrTaskPb[] data)
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

		// Token: 0x06039DC2 RID: 236994 RVA: 0x00DBDC32 File Offset: 0x00DBBE32
		public void SetUnreadArchives(int[] data)
		{
			this.UnreadArchives = data.ToList<int>();
		}

		// Token: 0x06039DC3 RID: 236995 RVA: 0x00DBDC40 File Offset: 0x00DBBE40
		public void SetLibraryTaskData(InfrLibraryTaskUpdateNotify data)
		{
			this.SetArchiveTaskData(data.ArchiveTasks.ToArray<InfrTaskPb>());
			this.SetPhoneTaskData(data.PhoneTasks.ToArray<InfrTaskPb>());
		}

		// Token: 0x06039DC4 RID: 236996 RVA: 0x00DBDC64 File Offset: 0x00DBBE64
		[NullableContext(2)]
		public InfrastructureDefine.IInfrLibraryTaskData GetLibraryTaskDataByTaskId(int taskId)
		{
			InfrastructureDefine.IInfrLibraryTaskData result;
			this.LibraryTaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x06039DC5 RID: 236997 RVA: 0x00DBDC84 File Offset: 0x00DBBE84
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetLibraryTaskDataByTaskState(InfrTaskStatusPb taskState)
		{
			return (from task in this.LibraryTaskDataMap.Values
			where task.Status == taskState
			select task).ToList<InfrastructureDefine.IInfrLibraryTaskData>();
		}

		// Token: 0x06039DC6 RID: 236998 RVA: 0x00DBDCBF File Offset: 0x00DBBEBF
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetLibraryTaskData()
		{
			return this.LibraryTaskDataMap.Values.ToList<InfrastructureDefine.IInfrLibraryTaskData>();
		}

		// Token: 0x06039DC7 RID: 236999 RVA: 0x00DBDCD4 File Offset: 0x00DBBED4
		[NullableContext(2)]
		public InfrastructureDefine.IInfrLibraryTaskData GetPhoneTaskDataByTaskId(int taskId)
		{
			InfrastructureDefine.IInfrLibraryTaskData result;
			this.PhoneTaskDataMap.TryGetValue(taskId, out result);
			return result;
		}

		// Token: 0x06039DC8 RID: 237000 RVA: 0x00DBDCF4 File Offset: 0x00DBBEF4
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetPhoneTaskDataByTaskState(InfrTaskStatusPb taskState)
		{
			return (from task in this.PhoneTaskDataMap.Values
			where task.Status == taskState
			select task).ToList<InfrastructureDefine.IInfrLibraryTaskData>();
		}

		// Token: 0x06039DC9 RID: 237001 RVA: 0x00DBDD2F File Offset: 0x00DBBF2F
		public List<InfrastructureDefine.IInfrLibraryTaskData> GetPhoneTaskData()
		{
			return this.PhoneTaskDataMap.Values.ToList<InfrastructureDefine.IInfrLibraryTaskData>();
		}

		// Token: 0x06039DCA RID: 237002 RVA: 0x00DBDD41 File Offset: 0x00DBBF41
		public List<PayShopGoods> GetShopDataList(int level, bool isSort = true)
		{
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.InfrFireShop, level, isSort);
			if (PayShopModel.Instance.ReadShopItemCheckFlag(PayShopDefine.EPayShopTabType.InfrFireShop, 1))
			{
				EventSystem.Instance.Emit(EEventName.InfrastructureFireShopRefresh);
			}
			return payShopTabData;
		}

		// Token: 0x06039DCB RID: 237003 RVA: 0x00DBDD78 File Offset: 0x00DBBF78
		public int GetAllShopCurrencyNum()
		{
			PayShopGoods[] array = (from item in InfrastructureConfig.Instance.GetAllLevelConfigs()
			select item.Level into level
			where level > 1
			select level).SelectMany((int level) => this.GetShopDataList(level, false)).ToArray<PayShopGoods>();
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

		// Token: 0x06039DCC RID: 237004 RVA: 0x00DBDE2F File Offset: 0x00DBC02F
		public void SetActivityData(InfrastructureActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x06039DCD RID: 237005 RVA: 0x00DBDE38 File Offset: 0x00DBC038
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

		// Token: 0x06039DCE RID: 237006 RVA: 0x00DBDE74 File Offset: 0x00DBC074
		public int GetOpenShopId()
		{
			return 219;
		}

		// Token: 0x06039DCF RID: 237007 RVA: 0x00DBDE7B File Offset: 0x00DBC07B
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

		// Token: 0x06039DD0 RID: 237008 RVA: 0x00DBDEB7 File Offset: 0x00DBC0B7
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

		// Token: 0x06039DD1 RID: 237009 RVA: 0x00DBDEF8 File Offset: 0x00DBC0F8
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

		// Token: 0x06039DD2 RID: 237010 RVA: 0x00DBE070 File Offset: 0x00DBC270
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

		// Token: 0x06039DD3 RID: 237011 RVA: 0x00DBE1E4 File Offset: 0x00DBC3E4
		public bool GetArchiveRedDot()
		{
			IEnumerable<InfrArchiveTask> infrArchiveTaskList = InfrastructureConfig.Instance.GetInfrArchiveTaskList();
			IReadOnlyList<InfrPhoneTask> infrPhoneTaskList = InfrastructureConfig.Instance.GetInfrPhoneTaskList();
			bool flag = infrArchiveTaskList.Any(delegate(InfrArchiveTask taskConfig)
			{
				InfrastructureDefine.IInfrLibraryTaskData libraryTaskDataByTaskId = this.GetLibraryTaskDataByTaskId(taskConfig.TaskId);
				return libraryTaskDataByTaskId != null && libraryTaskDataByTaskId.Status == InfrTaskStatusPb.InfrTaskFinish;
			});
			bool flag2 = infrPhoneTaskList.Any(delegate(InfrPhoneTask taskConfig)
			{
				InfrastructureDefine.IInfrLibraryTaskData phoneTaskDataByTaskId = this.GetPhoneTaskDataByTaskId(taskConfig.TaskId);
				return phoneTaskDataByTaskId != null && phoneTaskDataByTaskId.Status == InfrTaskStatusPb.InfrTaskFinish;
			});
			return flag || flag2;
		}

		// Token: 0x06039DD4 RID: 237012 RVA: 0x00DBE22C File Offset: 0x00DBC42C
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

		// Token: 0x06039DD5 RID: 237013 RVA: 0x00DBE2BC File Offset: 0x00DBC4BC
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

		// Token: 0x06039DD6 RID: 237014 RVA: 0x00DBE307 File Offset: 0x00DBC507
		public void CloseLoadingPanel()
		{
			InfrastructureLoadingPanel loadingPanel = this.LoadingPanel;
			if (loadingPanel == null)
			{
				return;
			}
			loadingPanel.CloseSelf();
		}

		// Token: 0x06039DD7 RID: 237015 RVA: 0x00DBE319 File Offset: 0x00DBC519
		public void DestroyLoadingPanel()
		{
			InfrastructureLoadingPanel loadingPanel = this.LoadingPanel;
			if (loadingPanel != null)
			{
				loadingPanel.Destroy(null);
			}
			this.LoadingPanel = null;
		}

		// Token: 0x17008AD5 RID: 35541
		// (get) Token: 0x06039DD8 RID: 237016 RVA: 0x00DBE334 File Offset: 0x00DBC534
		public static InfrastructureModel Instance
		{
			get
			{
				return InfrastructureModel._Instance;
			}
		}

		// Token: 0x06039DD9 RID: 237017 RVA: 0x00DBE33B File Offset: 0x00DBC53B
		public static InfrastructureModel GetOrCreateInstance()
		{
			if (InfrastructureModel._Instance == null)
			{
				InfrastructureModel.CreateInstance();
			}
			return InfrastructureModel._Instance;
		}

		// Token: 0x06039DDA RID: 237018 RVA: 0x00DBE34F File Offset: 0x00DBC54F
		public static bool CreateInstance()
		{
			if (InfrastructureModel._Instance != null)
			{
				return true;
			}
			InfrastructureModel._Instance = new InfrastructureModel();
			return true;
		}

		// Token: 0x06039DDB RID: 237019 RVA: 0x00DBE365 File Offset: 0x00DBC565
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039DDC RID: 237020 RVA: 0x00DBE367 File Offset: 0x00DBC567
		public static void ResetStaticDefaultValue()
		{
			InfrastructureModel._Instance = null;
		}

		// Token: 0x06039DDD RID: 237021 RVA: 0x00DBE36F File Offset: 0x00DBC56F
		static InfrastructureModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InfrastructureModel.CreateStaticDefaultValue), new Action(InfrastructureModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E2EE RID: 123630
		private int InteractingRoadIdInner;

		// Token: 0x0401E2EF RID: 123631
		[Nullable(2)]
		private InfrastructureLoadingPanel LoadingPanel;

		// Token: 0x0401E2F0 RID: 123632
		private readonly Dictionary<int, InfrastructureDefine.IInfrRoadData> RoadDataMap = new Dictionary<int, InfrastructureDefine.IInfrRoadData>();

		// Token: 0x0401E2F1 RID: 123633
		private int TracedRoadIdInner;

		// Token: 0x0401E2F2 RID: 123634
		private int RecommendRoadIdInner;

		// Token: 0x0401E2F3 RID: 123635
		public bool NeedHighlightTrackedRoadInner;

		// Token: 0x0401E2F4 RID: 123636
		private long FireExpInner;

		// Token: 0x0401E2F5 RID: 123637
		private int FireLevelInner;

		// Token: 0x0401E2F6 RID: 123638
		private long FireLevelReachTimeInner;

		// Token: 0x0401E2F7 RID: 123639
		private InfrStatusPb FireStatusInner;

		// Token: 0x0401E2F8 RID: 123640
		private long MoneyCountInner;

		// Token: 0x0401E2F9 RID: 123641
		private long MoneyHistorySpentInner;

		// Token: 0x0401E2FA RID: 123642
		private readonly Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData> LibraryTaskDataMap = new Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData>();

		// Token: 0x0401E2FB RID: 123643
		private readonly Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData> PhoneTaskDataMap = new Dictionary<int, InfrastructureDefine.IInfrLibraryTaskData>();

		// Token: 0x0401E2FC RID: 123644
		private List<int> UnreadArchives = new List<int>();

		// Token: 0x0401E2FD RID: 123645
		[Nullable(2)]
		private InfrastructureActivityData ActivityData;

		// Token: 0x0401E2FE RID: 123646
		[Nullable(2)]
		private static InfrastructureModel _Instance;
	}
}

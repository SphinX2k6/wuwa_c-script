using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Mowing
{
	// Token: 0x02005321 RID: 21281
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMowingData : ActivityBaseData
	{
		// Token: 0x06034F4C RID: 216908 RVA: 0x00ECF9D0 File Offset: 0x00ECDBD0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<string, int> GetButtonTextByRewardTextAndSort(int state)
		{
			string text = "";
			int item = 0;
			switch (state)
			{
			case 0:
				text = "PrefabTextItem_1443074454_Text";
				item = 2;
				break;
			case 1:
				text = "CollectActivity_state_CanRecive";
				item = 1;
				break;
			case 2:
				text = "CollectActivity_state_recived";
				item = 3;
				break;
			}
			string item2 = "";
			if (text != "")
			{
				item2 = (ConfigMultiTextLang.GetLocalTextNew(text, null) ?? "");
			}
			return new ValueTuple<string, int>(item2, item);
		}

		// Token: 0x06034F4D RID: 216909 RVA: 0x00ECFA40 File Offset: 0x00ECDC40
		protected override void PhraseEx(ActivityData data)
		{
			if (data.HarvestActivity == null)
			{
				this.MowingPointRewards = new List<IActivityRewardData>();
				this.MowingLevelRewards = new List<IActivityRewardData>();
				return;
			}
			this.MowingPointRewards = new List<IActivityRewardData>();
			this.MowingLevelRewards = new List<IActivityRewardData>();
			this.MowingLevelRewardDict = new Dictionary<int, IActivityRewardData>();
			this.MowingPointRewardDict = new Dictionary<int, IActivityRewardData>();
			this.MowingLevelInfoDict = new Dictionary<int, HarvestLevelReward>();
			foreach (HarvestLevelReward harvestLevelReward in data.HarvestActivity.HarvestLevelRewards)
			{
				KillMonstersScores? config = ConfigKillMonstersScoresByInstanceID.GetConfig(harvestLevelReward.Id, true);
				if (config != null)
				{
					this.MowingLevelInfoDict[harvestLevelReward.Id] = harvestLevelReward;
					IActivityRewardData activityRewardData = this.CreateActivityRewardDataByLevel(harvestLevelReward, config.Value);
					this.MowingLevelRewardDict[harvestLevelReward.Id] = activityRewardData;
					this.MowingLevelRewards.Add(activityRewardData);
				}
			}
			foreach (HarvestPointReward harvestPointReward in data.HarvestActivity.HarvestPointRewards)
			{
				ScoreReward? config2 = ConfigScoreRewardById.GetConfig(harvestPointReward.Id, true);
				if (config2 != null)
				{
					IActivityRewardData activityRewardData2 = this.CreateActivityRewardDataByPoint(harvestPointReward, config2.Value);
					this.MowingPointRewards.Add(activityRewardData2);
					this.MowingPointRewardDict[harvestPointReward.Id] = activityRewardData2;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
		}

		// Token: 0x06034F4E RID: 216910 RVA: 0x00ECFBD8 File Offset: 0x00ECDDD8
		private IActivityRewardData CreateActivityRewardDataByPoint(HarvestPointReward pointReward, ScoreReward pointConf)
		{
			ActivityMowingController controller = (ActivityMowingController)ActivityManager.GetActivityController(base.Type);
			string item = this.GetButtonTextByRewardTextAndSort((int)pointReward.State).Item1;
			return new ActivityRewardData
			{
				Id = new int?(pointReward.Id),
				NameText = ConfigMultiTextLang.GetLocalTextNew(pointConf.Desc, null),
				RewardList = this.GetRewardItems(pointConf.Reward).ToArray(),
				RewardButtonText = item,
				RewardState = (EActivityRewardState)pointReward.State,
				ClickFunction = delegate
				{
					controller.RequestGetPointReward(this.Id, pointReward.Id);
				}
			};
		}

		// Token: 0x06034F4F RID: 216911 RVA: 0x00ECFC98 File Offset: 0x00ECDE98
		private IActivityRewardData CreateActivityRewardDataByLevel(HarvestLevelReward levelReward, KillMonstersScores levelConf)
		{
			ActivityMowingController controller = (ActivityMowingController)ActivityManager.GetActivityController(base.Type);
			string item = this.GetButtonTextByRewardTextAndSort((int)levelReward.State).Item1;
			return new ActivityRewardData
			{
				Id = new int?(levelReward.Id),
				NameText = ConfigMultiTextLang.GetLocalTextNew(levelConf.Desc, null),
				RewardList = this.GetRewardItems(levelConf.Reward).ToArray(),
				RewardState = (EActivityRewardState)levelReward.State,
				RewardButtonText = item,
				ClickFunction = delegate
				{
					controller.RequestGetLevelReward(this.Id, levelConf.InstanceID, levelReward.Id);
				}
			};
		}

		// Token: 0x06034F50 RID: 216912 RVA: 0x00ECFD68 File Offset: 0x00ECDF68
		private void RefreshText(IActivityRewardData data, string descId)
		{
			string item = this.GetButtonTextByRewardTextAndSort((int)data.RewardState).Item1;
			data.NameText = ConfigMultiTextLang.GetLocalTextNew(descId, null);
			data.RewardButtonText = item;
		}

		// Token: 0x06034F51 RID: 216913 RVA: 0x00ECFD9B File Offset: 0x00ECDF9B
		public override bool GetExDataRedPointShowState()
		{
			return this.IsHaveRewardToGet() || this.IsNewInstanceOpen();
		}

		// Token: 0x06034F52 RID: 216914 RVA: 0x00ECFDB0 File Offset: 0x00ECDFB0
		public bool IsHaveRewardToGet()
		{
			using (List<IActivityRewardData>.Enumerator enumerator = this.MowingPointRewards.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
			using (List<IActivityRewardData>.Enumerator enumerator = this.MowingLevelRewards.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06034F53 RID: 216915 RVA: 0x00ECFE50 File Offset: 0x00ECE050
		public bool IsNewInstanceOpen()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			foreach (KeyValuePair<int, HarvestLevelReward> keyValuePair in this.MowingLevelInfoDict)
			{
				HarvestLevelReward value = keyValuePair.Value;
				bool flag = (double)value.StartTime <= TimeUtil.Instance.GetServerTime();
				if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, value.Id, 0, 0) == 0 && flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06034F54 RID: 216916 RVA: 0x00ECFEF8 File Offset: 0x00ECE0F8
		public void ReadNewInstance()
		{
			foreach (KeyValuePair<int, HarvestLevelReward> keyValuePair in this.MowingLevelInfoDict)
			{
				HarvestLevelReward value = keyValuePair.Value;
				if ((double)value.StartTime <= TimeUtil.Instance.GetServerTime())
				{
					ActivityModel.Instance.SaveActivityData(base.Id, value.Id, 0, 0, 1);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06034F55 RID: 216917 RVA: 0x00ECFF94 File Offset: 0x00ECE194
		private List<TItem> GetRewardItems(int dropId)
		{
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		}

		// Token: 0x06034F56 RID: 216918 RVA: 0x00ECFFA4 File Offset: 0x00ECE1A4
		public string GetDesc()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.LocalConfig.Value.Desc, null);
		}

		// Token: 0x06034F57 RID: 216919 RVA: 0x00ECFFCC File Offset: 0x00ECE1CC
		public List<IActivityRewardData> GetPointRewards()
		{
			foreach (IActivityRewardData activityRewardData in this.MowingPointRewards)
			{
				ScoreReward? config = ConfigScoreRewardById.GetConfig(activityRewardData.Id.GetValueOrDefault(), true);
				if (config != null)
				{
					this.RefreshText(activityRewardData, config.Value.Desc);
				}
			}
			this.MowingPointRewards.Sort(new Comparison<IActivityRewardData>(this.SortReward));
			return this.MowingPointRewards;
		}

		// Token: 0x06034F58 RID: 216920 RVA: 0x00ED006C File Offset: 0x00ECE26C
		public List<IActivityRewardData> GetLevelRewards()
		{
			foreach (IActivityRewardData activityRewardData in this.MowingLevelRewards)
			{
				KillMonstersScores? config = ConfigKillMonstersScoresByInstanceID.GetConfig(activityRewardData.Id.GetValueOrDefault(), true);
				if (config != null)
				{
					this.RefreshText(activityRewardData, config.Value.Desc);
				}
			}
			this.MowingLevelRewards.Sort(new Comparison<IActivityRewardData>(this.SortReward));
			return this.MowingLevelRewards;
		}

		// Token: 0x06034F59 RID: 216921 RVA: 0x00ED010C File Offset: 0x00ECE30C
		private int SortReward(IActivityRewardData a, IActivityRewardData b)
		{
			int item = this.GetButtonTextByRewardTextAndSort((int)a.RewardState).Item2;
			int item2 = this.GetButtonTextByRewardTextAndSort((int)b.RewardState).Item2;
			if (item == item2)
			{
				return a.Id.GetValueOrDefault() - b.Id.GetValueOrDefault();
			}
			return item - item2;
		}

		// Token: 0x06034F5A RID: 216922 RVA: 0x00ED0164 File Offset: 0x00ECE364
		public IActivityRewardViewData GetRewardViewData()
		{
			string tabTips = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MowingTotalPoint", null), new string[]
			{
				this.GetTotalPoint().ToString()
			});
			ActivityRewardDataPage item = new ActivityRewardDataPage
			{
				DataList = this.GetLevelRewards(),
				TabName = ConfigMultiTextLang.GetLocalTextNew("MowingLevelRewards", null),
				TabTips = tabTips
			};
			ActivityRewardDataPage item2 = new ActivityRewardDataPage
			{
				DataList = this.GetPointRewards(),
				TabName = ConfigMultiTextLang.GetLocalTextNew("MowingPointRewards", null),
				TabTips = tabTips
			};
			return new ActivityRewardViewData
			{
				DataPageList = new List<IActivityRewardDataPage>
				{
					item,
					item2
				},
				Source = EActivityRewardSource.Mowing
			};
		}

		// Token: 0x06034F5B RID: 216923 RVA: 0x00ED0218 File Offset: 0x00ECE418
		public void SetLevelRewardStateToGot(int instanceId)
		{
			IActivityRewardData activityRewardData;
			if (this.MowingLevelRewardDict.TryGetValue(instanceId, out activityRewardData))
			{
				activityRewardData.RewardState = EActivityRewardState.Claimed;
				string item = this.GetButtonTextByRewardTextAndSort(2).Item1;
				activityRewardData.RewardState = EActivityRewardState.Claimed;
				activityRewardData.RewardButtonText = item;
			}
		}

		// Token: 0x06034F5C RID: 216924 RVA: 0x00ED0258 File Offset: 0x00ECE458
		public void SetPointRewardState(int id)
		{
			IActivityRewardData activityRewardData;
			if (this.MowingPointRewardDict.TryGetValue(id, out activityRewardData))
			{
				string item = this.GetButtonTextByRewardTextAndSort(2).Item1;
				activityRewardData.RewardState = EActivityRewardState.Claimed;
				activityRewardData.RewardButtonText = item;
			}
		}

		// Token: 0x06034F5D RID: 216925 RVA: 0x00ED0290 File Offset: 0x00ECE490
		public int GetInstanceCurrentPoint(int instanceId)
		{
			HarvestLevelReward harvestLevelReward;
			if (this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				return harvestLevelReward.Point;
			}
			return 0;
		}

		// Token: 0x06034F5E RID: 216926 RVA: 0x00ED02B8 File Offset: 0x00ECE4B8
		public void SetInstanceCurrentSelectedDiff(int instanceId, int diff)
		{
			HarvestLevelReward harvestLevelReward;
			if (this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				harvestLevelReward.Diff = diff;
			}
		}

		// Token: 0x06034F5F RID: 216927 RVA: 0x00ED02DC File Offset: 0x00ECE4DC
		public void UpdatePointRewards(HarvestActivityPointNotify notify)
		{
			foreach (HarvestPointReward harvestPointReward in notify.HarvestPointReward)
			{
				ScoreReward? config = ConfigScoreRewardById.GetConfig(harvestPointReward.Id, true);
				if (config != null)
				{
					IActivityRewardData activityRewardData = this.CreateActivityRewardDataByPoint(harvestPointReward, config.Value);
					IActivityRewardData activityRewardData2;
					if (this.MowingPointRewardDict.TryGetValue(harvestPointReward.Id, out activityRewardData2))
					{
						activityRewardData2.RewardButtonText = activityRewardData.RewardButtonText;
						activityRewardData2.RewardState = activityRewardData.RewardState;
					}
				}
			}
		}

		// Token: 0x06034F60 RID: 216928 RVA: 0x00ED0378 File Offset: 0x00ECE578
		public void UpdateLevelRewards(HarvestActivityLevelNotify notify)
		{
			foreach (HarvestLevelReward harvestLevelReward in notify.HarvestLevelRewards)
			{
				HarvestLevelReward harvestLevelReward2;
				if (this.MowingLevelInfoDict.TryGetValue(harvestLevelReward.Id, out harvestLevelReward2))
				{
					this.MowingLevelInfoDict[harvestLevelReward.Id] = harvestLevelReward;
					IActivityRewardData activityRewardData = this.CreateActivityRewardDataByLevel(harvestLevelReward, ConfigKillMonstersScoresByInstanceID.GetConfig(harvestLevelReward.Id, true).Value);
					IActivityRewardData activityRewardData2;
					if (this.MowingLevelRewardDict.TryGetValue(harvestLevelReward.Id, out activityRewardData2))
					{
						activityRewardData2.RewardState = activityRewardData.RewardState;
						activityRewardData2.RewardButtonText = activityRewardData.RewardButtonText;
					}
				}
			}
		}

		// Token: 0x06034F61 RID: 216929 RVA: 0x00ED0438 File Offset: 0x00ECE638
		public int GetLevelDiffIndex(int instanceId)
		{
			HarvestLevelReward harvestLevelReward;
			if (!this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.LK, "当前[击杀积分|KillMonstersScores]没有割草活动副本数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return 0;
			}
			int num = Array.IndexOf<int>(ConfigKillMonstersScoresByInstanceID.GetConfig(instanceId, true).Value.GetDifficultyOptionsArray() ?? Array.Empty<int>(), harvestLevelReward.Diff);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06034F62 RID: 216930 RVA: 0x00ED04AC File Offset: 0x00ECE6AC
		public int GetLevelDiffRecommendLevel(int instanceId)
		{
			HarvestLevelReward harvestLevelReward;
			if (!this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				return 0;
			}
			TakeWeedsDifficulty? config = ConfigTakeWeedsDifficultyById.GetConfig(harvestLevelReward.Diff, true);
			if (config == null)
			{
				return 0;
			}
			return config.GetValueOrDefault().RecommendedLevel;
		}

		// Token: 0x06034F63 RID: 216931 RVA: 0x00ED04F4 File Offset: 0x00ECE6F4
		public int GetTotalPoint()
		{
			int num = 0;
			foreach (KeyValuePair<int, HarvestLevelReward> keyValuePair in this.MowingLevelInfoDict)
			{
				num += keyValuePair.Value.Point;
			}
			return num;
		}

		// Token: 0x06034F64 RID: 216932 RVA: 0x00ED0554 File Offset: 0x00ECE754
		public int GetLevelMaxPoint(int instanceId)
		{
			HarvestLevelReward harvestLevelReward;
			if (!this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				return 0;
			}
			return harvestLevelReward.Point;
		}

		// Token: 0x06034F65 RID: 216933 RVA: 0x00ED057C File Offset: 0x00ECE77C
		public bool GetActivityLevelUnlockState(int levelId)
		{
			HarvestLevelReward harvestLevelReward;
			return this.MowingLevelInfoDict.TryGetValue(levelId, out harvestLevelReward) && (double)harvestLevelReward.StartTime <= TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x06034F66 RID: 216934 RVA: 0x00ED05B4 File Offset: 0x00ECE7B4
		public string GetActivityLevelCountdownText(int levelId)
		{
			HarvestLevelReward harvestLevelReward;
			if (!this.MowingLevelInfoDict.TryGetValue(levelId, out harvestLevelReward))
			{
				return "";
			}
			double num = (double)harvestLevelReward.StartTime - TimeUtil.Instance.GetServerTime();
			if (num <= 0.0)
			{
				return "";
			}
			return this.GetRemainTime(num);
		}

		// Token: 0x06034F67 RID: 216935 RVA: 0x00ED0604 File Offset: 0x00ECE804
		private string GetRemainTime(double cdTime)
		{
			double num = Math.Max(cdTime, TimeUtil.Instance.Minute);
			ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> questLockTimeTypeData = this.GetQuestLockTimeTypeData(num);
			string text = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(questLockTimeTypeData.Item1), new CommonDefine.ETimeType?(questLockTimeTypeData.Item2)).CountDownText ?? "";
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("ActivityMowing_UnlockCondition", null), new string[]
			{
				text
			});
		}

		// Token: 0x06034F68 RID: 216936 RVA: 0x00ED0674 File Offset: 0x00ECE874
		[NullableContext(0)]
		private ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetQuestLockTimeTypeData(double remainTime)
		{
			if (remainTime > 86400.0)
			{
				return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Day);
			}
			if (remainTime > 3600.0)
			{
				return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Hour);
			}
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Minute);
		}

		// Token: 0x0401BFEF RID: 114671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActivityRewardData> MowingPointRewards;

		// Token: 0x0401BFF0 RID: 114672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActivityRewardData> MowingLevelRewards;

		// Token: 0x0401BFF1 RID: 114673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IActivityRewardData> MowingPointRewardDict;

		// Token: 0x0401BFF2 RID: 114674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IActivityRewardData> MowingLevelRewardDict;

		// Token: 0x0401BFF3 RID: 114675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, HarvestLevelReward> MowingLevelInfoDict;
	}
}

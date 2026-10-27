using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Mowing
{
	// Token: 0x020063A3 RID: 25507
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMowingData : ActivityBaseData
	{
		// Token: 0x0604028B RID: 262795 RVA: 0x00F88A98 File Offset: 0x00F86C98
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

		// Token: 0x0604028C RID: 262796 RVA: 0x00F88B08 File Offset: 0x00F86D08
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

		// Token: 0x0604028D RID: 262797 RVA: 0x00F88CA0 File Offset: 0x00F86EA0
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

		// Token: 0x0604028E RID: 262798 RVA: 0x00F88D60 File Offset: 0x00F86F60
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

		// Token: 0x0604028F RID: 262799 RVA: 0x00F88E30 File Offset: 0x00F87030
		private void RefreshText(IActivityRewardData data, string descId)
		{
			string item = this.GetButtonTextByRewardTextAndSort((int)data.RewardState).Item1;
			data.NameText = ConfigMultiTextLang.GetLocalTextNew(descId, null);
			data.RewardButtonText = item;
		}

		// Token: 0x06040290 RID: 262800 RVA: 0x00F88E63 File Offset: 0x00F87063
		public override bool GetExDataRedPointShowState()
		{
			return this.IsHaveRewardToGet() || this.IsNewInstanceOpen();
		}

		// Token: 0x06040291 RID: 262801 RVA: 0x00F88E78 File Offset: 0x00F87078
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

		// Token: 0x06040292 RID: 262802 RVA: 0x00F88F18 File Offset: 0x00F87118
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

		// Token: 0x06040293 RID: 262803 RVA: 0x00F88FC0 File Offset: 0x00F871C0
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

		// Token: 0x06040294 RID: 262804 RVA: 0x00F8905C File Offset: 0x00F8725C
		private List<TItem> GetRewardItems(int dropId)
		{
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		}

		// Token: 0x06040295 RID: 262805 RVA: 0x00F8906C File Offset: 0x00F8726C
		public string GetDesc()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.LocalConfig.Value.Desc, null);
		}

		// Token: 0x06040296 RID: 262806 RVA: 0x00F89094 File Offset: 0x00F87294
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

		// Token: 0x06040297 RID: 262807 RVA: 0x00F89134 File Offset: 0x00F87334
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

		// Token: 0x06040298 RID: 262808 RVA: 0x00F891D4 File Offset: 0x00F873D4
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

		// Token: 0x06040299 RID: 262809 RVA: 0x00F8922C File Offset: 0x00F8742C
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

		// Token: 0x0604029A RID: 262810 RVA: 0x00F892E0 File Offset: 0x00F874E0
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

		// Token: 0x0604029B RID: 262811 RVA: 0x00F89320 File Offset: 0x00F87520
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

		// Token: 0x0604029C RID: 262812 RVA: 0x00F89358 File Offset: 0x00F87558
		public int GetInstanceCurrentPoint(int instanceId)
		{
			HarvestLevelReward harvestLevelReward;
			if (this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				return harvestLevelReward.Point;
			}
			return 0;
		}

		// Token: 0x0604029D RID: 262813 RVA: 0x00F89380 File Offset: 0x00F87580
		public void SetInstanceCurrentSelectedDiff(int instanceId, int diff)
		{
			HarvestLevelReward harvestLevelReward;
			if (this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				harvestLevelReward.Diff = diff;
			}
		}

		// Token: 0x0604029E RID: 262814 RVA: 0x00F893A4 File Offset: 0x00F875A4
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

		// Token: 0x0604029F RID: 262815 RVA: 0x00F89440 File Offset: 0x00F87640
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

		// Token: 0x060402A0 RID: 262816 RVA: 0x00F89500 File Offset: 0x00F87700
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

		// Token: 0x060402A1 RID: 262817 RVA: 0x00F89574 File Offset: 0x00F87774
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

		// Token: 0x060402A2 RID: 262818 RVA: 0x00F895BC File Offset: 0x00F877BC
		public int GetTotalPoint()
		{
			int num = 0;
			foreach (KeyValuePair<int, HarvestLevelReward> keyValuePair in this.MowingLevelInfoDict)
			{
				num += keyValuePair.Value.Point;
			}
			return num;
		}

		// Token: 0x060402A3 RID: 262819 RVA: 0x00F8961C File Offset: 0x00F8781C
		public int GetLevelMaxPoint(int instanceId)
		{
			HarvestLevelReward harvestLevelReward;
			if (!this.MowingLevelInfoDict.TryGetValue(instanceId, out harvestLevelReward))
			{
				return 0;
			}
			return harvestLevelReward.Point;
		}

		// Token: 0x060402A4 RID: 262820 RVA: 0x00F89644 File Offset: 0x00F87844
		public bool GetActivityLevelUnlockState(int levelId)
		{
			HarvestLevelReward harvestLevelReward;
			return this.MowingLevelInfoDict.TryGetValue(levelId, out harvestLevelReward) && (double)harvestLevelReward.StartTime <= TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x060402A5 RID: 262821 RVA: 0x00F8967C File Offset: 0x00F8787C
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

		// Token: 0x060402A6 RID: 262822 RVA: 0x00F896CC File Offset: 0x00F878CC
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

		// Token: 0x060402A7 RID: 262823 RVA: 0x00F8973C File Offset: 0x00F8793C
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

		// Token: 0x040216C0 RID: 136896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActivityRewardData> MowingPointRewards;

		// Token: 0x040216C1 RID: 136897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActivityRewardData> MowingLevelRewards;

		// Token: 0x040216C2 RID: 136898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IActivityRewardData> MowingPointRewardDict;

		// Token: 0x040216C3 RID: 136899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IActivityRewardData> MowingLevelRewardDict;

		// Token: 0x040216C4 RID: 136900
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, HarvestLevelReward> MowingLevelInfoDict;
	}
}

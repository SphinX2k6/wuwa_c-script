using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TowerDefence;

// Token: 0x0200213C RID: 8508
[NullableContext(1)]
[Nullable(0)]
public class ParsedTowerDefenseMsg : ActivityBaseData
{
	// Token: 0x06014E6A RID: 85610 RVA: 0x00614CDE File Offset: 0x00612EDE
	protected override void OnInit(ActivityData data)
	{
		EventSystem.Instance.Emit(EEventName.TowerDefenseDataInit);
	}

	// Token: 0x06014E6B RID: 85611 RVA: 0x00614CF0 File Offset: 0x00612EF0
	protected unsafe override void PhraseEx(ActivityData data)
	{
		TowerDefenceActivityInfo towerDefenceActivityData = data.TowerDefenceActivityData;
		if (towerDefenceActivityData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "塔防数据为空，请确认活动协议类型是否正确";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", data.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActivityType", data.Type);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.ParseTowerDefenseActivityData(towerDefenceActivityData);
	}

	// Token: 0x06014E6C RID: 85612 RVA: 0x00614D79 File Offset: 0x00612F79
	public override bool GetExDataRedPointShowState()
	{
		return TowerDefenseController.Instance.CheckHasNewStage() || TowerDefenseController.Instance.CheckHasReward();
	}

	// Token: 0x06014E6D RID: 85613 RVA: 0x00614D94 File Offset: 0x00612F94
	protected override bool GetExDataFinishShowState()
	{
		if (!base.IsUnLock())
		{
			return false;
		}
		if (this.StageListCache.Count == 0)
		{
			return false;
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.StageListCache)
		{
			if (!towerDefenseParsedStageMessage.Passed || !towerDefenseParsedStageMessage.Rewarded)
			{
				return false;
			}
		}
		IReadOnlyList<TowerDefenceReward> configList = ConfigTowerDefenceRewardAll.GetConfigList(true);
		if (configList == null)
		{
			return false;
		}
		foreach (TowerDefenceReward towerDefenceReward in configList)
		{
			if (towerDefenceReward.ActivityId == base.Id && !this.ScoreRewardCache.ContainsKey(towerDefenceReward.Id))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014E6E RID: 85614 RVA: 0x00614E7C File Offset: 0x0061307C
	public void ParseTowerDefenseActivityData(TowerDefenceActivityInfo data)
	{
		this.ScoreRewardCache.Clear();
		this.TotalScore = 0;
		foreach (int num in data.RewardedScoreIds)
		{
			TowerDefenceReward value = ConfigTowerDefenceRewardById.GetConfig(num, true).Value;
			this.ScoreRewardCache[num] = value;
		}
		this.ParseTowerDefenseInstanceDataList(data.InstanceInfos, true);
		this.TotalScore = data.TotalScore;
	}

	// Token: 0x06014E6F RID: 85615 RVA: 0x00614F0C File Offset: 0x0061310C
	public void ParseTowerDefenseInstanceDataList(IEnumerable<TowerDefenceInstanceInfo> dataList, bool isFull = true)
	{
		if (isFull)
		{
			this.TotalScore = 0;
			this.StageListCache.Clear();
			this.StageMapCache.Clear();
			using (IEnumerator<TowerDefenceInstanceInfo> enumerator = dataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TowerDefenceInstanceInfo towerDefenceInstanceInfo = enumerator.Current;
					TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(towerDefenceInstanceInfo.Id, true);
					if (config == null)
					{
						Log.Instance.Error(ELogModule.TowerDefense, ELogAuthor.WZ, "塔防副本协议数据与配置不匹配，协议ID：" + towerDefenceInstanceInfo.Id.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = new TowerDefenseParsedStageMessage
						{
							Meta = towerDefenceInstanceInfo,
							Id = towerDefenceInstanceInfo.Id,
							UnlockTime = towerDefenceInstanceInfo.UnlockTime,
							Passed = towerDefenceInstanceInfo.Passed,
							PassTime = (double)towerDefenceInstanceInfo.PassTime,
							Rewarded = towerDefenceInstanceInfo.Rewarded,
							Record = towerDefenceInstanceInfo.MaxScore,
							RecordOverThreshold = (towerDefenceInstanceInfo.MaxScore >= config.Value.RewardScore)
						};
						this.StageListCache.Add(towerDefenseParsedStageMessage);
						this.StageMapCache[towerDefenceInstanceInfo.Id] = towerDefenseParsedStageMessage;
					}
				}
				return;
			}
		}
		foreach (TowerDefenceInstanceInfo towerDefenceInstanceInfo2 in dataList)
		{
			if (!this.StageMapCache.ContainsKey(towerDefenceInstanceInfo2.Id))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "塔防关卡协议存量更新时，出现未缓存的数据，本条协议不更新";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("协议数据", dataList);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
		}
		foreach (TowerDefenceInstanceInfo towerDefenceInstanceInfo3 in dataList)
		{
			TowerDefenceInstance? config2 = ConfigTowerDefenceInstanceById.GetConfig(towerDefenceInstanceInfo3.Id, true);
			ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage2 = this.StageMapCache[towerDefenceInstanceInfo3.Id];
			towerDefenseParsedStageMessage2.Meta = towerDefenceInstanceInfo3;
			towerDefenseParsedStageMessage2.Id = towerDefenceInstanceInfo3.Id;
			towerDefenseParsedStageMessage2.UnlockTime = towerDefenceInstanceInfo3.UnlockTime;
			towerDefenseParsedStageMessage2.Passed = towerDefenceInstanceInfo3.Passed;
			towerDefenseParsedStageMessage2.PassTime = (double)towerDefenceInstanceInfo3.PassTime;
			towerDefenseParsedStageMessage2.Rewarded = towerDefenceInstanceInfo3.Rewarded;
			towerDefenseParsedStageMessage2.Record = towerDefenceInstanceInfo3.MaxScore;
			towerDefenseParsedStageMessage2.RecordOverThreshold = (towerDefenceInstanceInfo3.MaxScore >= config2.Value.RewardScore);
		}
	}

	// Token: 0x06014E70 RID: 85616 RVA: 0x006151C8 File Offset: 0x006133C8
	public void ParseTowerDefenseOwnPhantomDataList(IEnumerable<TowerDefencePhantomInfo> infoList)
	{
		foreach (TowerDefencePhantomInfo towerDefencePhantomInfo in infoList)
		{
			TowerDefencePhantomInfo towerDefencePhantomInfo2 = null;
			if (this.OwnPhantomInBattleDataCache.TryGetValue(towerDefencePhantomInfo.Id, out towerDefencePhantomInfo2) && towerDefencePhantomInfo.Level > towerDefencePhantomInfo2.Level)
			{
				this.OwnPhantomInBattleNewLevelUpFlagCache[towerDefencePhantomInfo.Id] = true;
			}
			this.OwnPhantomInBattleDataCache[towerDefencePhantomInfo.Id] = towerDefencePhantomInfo;
		}
	}

	// Token: 0x06014E71 RID: 85617 RVA: 0x00615254 File Offset: 0x00613454
	public EActivityRewardState GetScoreRewardStateById(int rewardId)
	{
		TowerDefenceReward? config = ConfigTowerDefenceRewardById.GetConfig(rewardId, true);
		if (this.TotalScore < config.Value.Score)
		{
			return EActivityRewardState.Disabled;
		}
		if (this.ScoreRewardCache.ContainsKey(rewardId))
		{
			return EActivityRewardState.Claimed;
		}
		return EActivityRewardState.Enable;
	}

	// Token: 0x06014E72 RID: 85618 RVA: 0x00615294 File Offset: 0x00613494
	public EActivityRewardState GetPassRewardStateById(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(instanceId, true);
		if (config == null)
		{
			return EActivityRewardState.Disabled;
		}
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = this.StageMapCache[instanceId];
		if (config.Value.IsDifficult)
		{
			if (!towerDefenseParsedStageMessage.Passed)
			{
				return EActivityRewardState.Disabled;
			}
			if (towerDefenseParsedStageMessage.Rewarded)
			{
				return EActivityRewardState.Claimed;
			}
			return EActivityRewardState.Enable;
		}
		else
		{
			if (!towerDefenseParsedStageMessage.RecordOverThreshold)
			{
				return EActivityRewardState.Disabled;
			}
			if (towerDefenseParsedStageMessage.Rewarded)
			{
				return EActivityRewardState.Claimed;
			}
			return EActivityRewardState.Enable;
		}
	}

	// Token: 0x06014E73 RID: 85619 RVA: 0x00615300 File Offset: 0x00613500
	public void UpdateByScoreRewardRequest(int rewardId)
	{
		this.ScoreRewardCache[rewardId] = ConfigTowerDefenceRewardById.GetConfig(rewardId, true).Value;
	}

	// Token: 0x06014E74 RID: 85620 RVA: 0x00615328 File Offset: 0x00613528
	public void UpdateByInstanceRewardRequest(int instanceId)
	{
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = this.StageMapCache[instanceId];
		towerDefenseParsedStageMessage.Rewarded = true;
		towerDefenseParsedStageMessage.Meta.Rewarded = true;
	}

	// Token: 0x06014E75 RID: 85621 RVA: 0x00615348 File Offset: 0x00613548
	public bool IsStageUnLocked(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		return config != null && this.IsStageUnlockedByTowerDefenseInstanceId(config.Value.Id);
	}

	// Token: 0x06014E76 RID: 85622 RVA: 0x00615380 File Offset: 0x00613580
	public unsafe bool IsStageUnlockedByTowerDefenseInstanceId(int towerDefenseInstanceId)
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = null;
		if (!this.StageMapCache.TryGetValue(towerDefenseInstanceId, out towerDefenseParsedStageMessage))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "塔防关卡协议数据丢失";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TowerDefenseInstanceId", towerDefenseInstanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("关卡协议缓存", this.StageMapCache);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		long unlockTime = towerDefenseParsedStageMessage.UnlockTime;
		return serverTimeStamp > (double)unlockTime;
	}

	// Token: 0x06014E77 RID: 85623 RVA: 0x00615418 File Offset: 0x00613618
	public unsafe bool IsPassedInstance(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = this.StageMapCache[config.Value.Id];
		if (towerDefenseParsedStageMessage == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "是否通关数据查询,塔防关卡协议数据丢失";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TowerDefenseInstanceId", config.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("关卡协议缓存", this.StageMapCache);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		return towerDefenseParsedStageMessage.Passed;
	}

	// Token: 0x06014E78 RID: 85624 RVA: 0x006154C4 File Offset: 0x006136C4
	public unsafe double GetPassTimeByInstanceId(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = this.StageMapCache[config.Value.Id];
		if (towerDefenseParsedStageMessage == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "获取通关时间数据,塔防关卡协议数据丢失";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TowerDefenseInstanceId", config.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("关卡协议缓存", this.StageMapCache);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0.0;
		}
		return towerDefenseParsedStageMessage.PassTime;
	}

	// Token: 0x06014E79 RID: 85625 RVA: 0x00615578 File Offset: 0x00613778
	public int GetSuitableInstanceId()
	{
		int result = 0;
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.StageListCache)
		{
			if (this.IsStageUnlockedByTowerDefenseInstanceId(towerDefenseParsedStageMessage.Id))
			{
				TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true);
				result = ((config != null) ? config.Value.InstanceId : 0);
				if (towerDefenseParsedStageMessage.Record == 0)
				{
					if (config == null)
					{
						break;
					}
					if (!config.Value.IsDifficult)
					{
						break;
					}
					if (!towerDefenseParsedStageMessage.Passed)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06014E7A RID: 85626 RVA: 0x00615630 File Offset: 0x00613830
	public int GetSuitableStageId()
	{
		int result = 0;
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in this.StageListCache)
		{
			if (this.IsStageUnlockedByTowerDefenseInstanceId(towerDefenseParsedStageMessage.Id))
			{
				TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(towerDefenseParsedStageMessage.Id, true);
				result = ((config != null) ? config.Value.Id : 0);
				if (towerDefenseParsedStageMessage.Record == 0)
				{
					if (config == null)
					{
						break;
					}
					if (!config.Value.IsDifficult)
					{
						break;
					}
					if (!towerDefenseParsedStageMessage.Passed)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0400B1F7 RID: 45559
	public Dictionary<int, TowerDefencePhantomInfo> OwnPhantomInBattleDataCache = new Dictionary<int, TowerDefencePhantomInfo>();

	// Token: 0x0400B1F8 RID: 45560
	public Dictionary<int, bool> OwnPhantomInBattleNewLevelUpFlagCache = new Dictionary<int, bool>();

	// Token: 0x0400B1F9 RID: 45561
	public Dictionary<int, TowerDefenceReward> ScoreRewardCache = new Dictionary<int, TowerDefenceReward>();

	// Token: 0x0400B1FA RID: 45562
	public List<ITowerDefenseParsedStageMessage> StageListCache = new List<ITowerDefenseParsedStageMessage>();

	// Token: 0x0400B1FB RID: 45563
	public Dictionary<int, ITowerDefenseParsedStageMessage> StageMapCache = new Dictionary<int, ITowerDefenseParsedStageMessage>();

	// Token: 0x0400B1FC RID: 45564
	public int TotalScore;
}

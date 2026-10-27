using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TowerDefence;

// Token: 0x02002BC1 RID: 11201
[NullableContext(1)]
[Nullable(0)]
public class ParsedTowerDefenseMsg : ActivityBaseData
{
	// Token: 0x06017439 RID: 95289 RVA: 0x005E8112 File Offset: 0x005E6312
	protected override void OnInit(ActivityData data)
	{
		EventSystem.Instance.Emit(EEventName.TowerDefenseDataInit);
	}

	// Token: 0x0601743A RID: 95290 RVA: 0x005E8124 File Offset: 0x005E6324
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

	// Token: 0x0601743B RID: 95291 RVA: 0x005E81AD File Offset: 0x005E63AD
	public override bool GetExDataRedPointShowState()
	{
		return TowerDefenseController.Instance.CheckHasNewStage() || TowerDefenseController.Instance.CheckHasReward();
	}

	// Token: 0x0601743C RID: 95292 RVA: 0x005E81C8 File Offset: 0x005E63C8
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

	// Token: 0x0601743D RID: 95293 RVA: 0x005E82B0 File Offset: 0x005E64B0
	public void ParseTowerDefenseActivityData(TowerDefenceActivityInfo data)
	{
		this.ScoreRewardCache.Clear();
		this.TotalScore = 0;
		foreach (int num in data.RewardedScoreIds)
		{
			TowerDefenceReward value = ConfigTowerDefenceRewardById.GetConfig(num, true).Value;
			this.ScoreRewardCache[num] = value;
		}
		this.ParseTowerDefenseInstanceDataList(data.InstanceInfos.ToList<TowerDefenceInstanceInfo>(), true);
		this.TotalScore = data.TotalScore;
	}

	// Token: 0x0601743E RID: 95294 RVA: 0x005E8344 File Offset: 0x005E6544
	public void ParseTowerDefenseInstanceDataList(List<TowerDefenceInstanceInfo> dataList, bool isFull = true)
	{
		if (isFull)
		{
			this.TotalScore = 0;
			this.StageListCache.Clear();
			this.StageMapCache.Clear();
			using (List<TowerDefenceInstanceInfo>.Enumerator enumerator = dataList.GetEnumerator())
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

	// Token: 0x0601743F RID: 95295 RVA: 0x005E8614 File Offset: 0x005E6814
	public void ParseTowerDefenseOwnPhantomDataList(List<TowerDefencePhantomInfo> infoList)
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

	// Token: 0x06017440 RID: 95296 RVA: 0x005E86A4 File Offset: 0x005E68A4
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

	// Token: 0x06017441 RID: 95297 RVA: 0x005E86E4 File Offset: 0x005E68E4
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

	// Token: 0x06017442 RID: 95298 RVA: 0x005E8750 File Offset: 0x005E6950
	public void UpdateByScoreRewardRequest(int rewardId)
	{
		this.ScoreRewardCache[rewardId] = ConfigTowerDefenceRewardById.GetConfig(rewardId, true).Value;
	}

	// Token: 0x06017443 RID: 95299 RVA: 0x005E8778 File Offset: 0x005E6978
	public void UpdateByInstanceRewardRequest(int instanceId)
	{
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage = this.StageMapCache[instanceId];
		towerDefenseParsedStageMessage.Rewarded = true;
		towerDefenseParsedStageMessage.Meta.Rewarded = true;
	}

	// Token: 0x06017444 RID: 95300 RVA: 0x005E8798 File Offset: 0x005E6998
	public bool IsStageUnLocked(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		return config != null && this.IsStageUnlockedByTowerDefenseInstanceId(config.Value.Id);
	}

	// Token: 0x06017445 RID: 95301 RVA: 0x005E87D0 File Offset: 0x005E69D0
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

	// Token: 0x06017446 RID: 95302 RVA: 0x005E8868 File Offset: 0x005E6A68
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

	// Token: 0x06017447 RID: 95303 RVA: 0x005E8914 File Offset: 0x005E6B14
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

	// Token: 0x06017448 RID: 95304 RVA: 0x005E89C8 File Offset: 0x005E6BC8
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

	// Token: 0x06017449 RID: 95305 RVA: 0x005E8A80 File Offset: 0x005E6C80
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

	// Token: 0x0400ADF2 RID: 44530
	public Dictionary<int, TowerDefencePhantomInfo> OwnPhantomInBattleDataCache = new Dictionary<int, TowerDefencePhantomInfo>();

	// Token: 0x0400ADF3 RID: 44531
	public Dictionary<int, bool> OwnPhantomInBattleNewLevelUpFlagCache = new Dictionary<int, bool>();

	// Token: 0x0400ADF4 RID: 44532
	public Dictionary<int, TowerDefenceReward> ScoreRewardCache = new Dictionary<int, TowerDefenceReward>();

	// Token: 0x0400ADF5 RID: 44533
	public List<ITowerDefenseParsedStageMessage> StageListCache = new List<ITowerDefenseParsedStageMessage>();

	// Token: 0x0400ADF6 RID: 44534
	public Dictionary<int, ITowerDefenseParsedStageMessage> StageMapCache = new Dictionary<int, ITowerDefenseParsedStageMessage>();

	// Token: 0x0400ADF7 RID: 44535
	public int TotalScore;
}

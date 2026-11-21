using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x020006D2 RID: 1746
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssActivityData : ActivityBaseData
{
	// Token: 0x0600502B RID: 20523 RVA: 0x001ADE90 File Offset: 0x001AC090
	protected override void PhraseEx(ActivityData data)
	{
		this.InitAllRoleData();
		AbyssInfo abyssInfo = data.AbyssInfo;
		foreach (Aki.Protocol.AbyssPluginItemInfo data2 in abyssInfo.PluginItems)
		{
			this.UpdatePluginInfo(data2);
		}
		foreach (AbyssRoleInfo data3 in abyssInfo.RoleList)
		{
			this.UpdateRoleInfo(data3, false);
		}
		this.CurrentLikeCount = abyssInfo.LikeCount;
		this.PhraseChallengeData(abyssInfo.ChallengeInfos);
		this.PhraseRewardInfo(abyssInfo.RewardInfo);
		this.LimitStartTime = MathUtils.Instance.LongToBigInt(abyssInfo.LimitBeginTime) / 1000L;
		this.LimitEndTime = MathUtils.Instance.LongToBigInt(abyssInfo.LimitEndTime) / 1000L;
	}

	// Token: 0x17000AB2 RID: 2738
	// (get) Token: 0x0600502C RID: 20524 RVA: 0x001ADF88 File Offset: 0x001AC188
	public override bool RedPointShowState
	{
		get
		{
			return this.CheckIfInShowTime() && ((base.IsUnLock() && DangoAbyssModel.Instance.GetAbyssDangoEnterNew()) || base.RedPointShowState);
		}
	}

	// Token: 0x0600502D RID: 20525 RVA: 0x001ADFB0 File Offset: 0x001AC1B0
	protected override bool GetExDataFinishShowState()
	{
		foreach (int tab in this.GetRewardTypeTabList(2))
		{
			global::AbyssRewardInfo[] rewardInfoByRewardTypeAndTab = this.GetRewardInfoByRewardTypeAndTab(2, tab);
			for (int j = 0; j < rewardInfoByRewardTypeAndTab.Length; j++)
			{
				if (!rewardInfoByRewardTypeAndTab[j].GetHasGetReward())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600502E RID: 20526 RVA: 0x001AE000 File Offset: 0x001AC200
	public override bool GetExDataRedPointShowState()
	{
		bool rewardTypeIfHaveCanTakeReward = this.GetRewardTypeIfHaveCanTakeReward(EAbyssShopType.Common);
		bool rewardTypeIfHaveCanTakeReward2 = this.GetRewardTypeIfHaveCanTakeReward(EAbyssShopType.Limit);
		bool dangoNewRedDot = DangoAbyssModel.Instance.GetDangoNewRedDot();
		return base.GetPreGuideQuestFinishState() && (rewardTypeIfHaveCanTakeReward || rewardTypeIfHaveCanTakeReward2 || dangoNewRedDot);
	}

	// Token: 0x0600502F RID: 20527 RVA: 0x001AE038 File Offset: 0x001AC238
	public bool CheckInLimitTime()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)this.LimitStartTime && serverTime <= (double)this.LimitEndTime;
	}

	// Token: 0x06005030 RID: 20528 RVA: 0x001AE06C File Offset: 0x001AC26C
	public string GetRemainTimeText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = Math.Max((double)this.LimitEndTime - serverTime, 1.0);
		return TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText ?? "";
	}

	// Token: 0x06005031 RID: 20529 RVA: 0x001AE0B5 File Offset: 0x001AC2B5
	public bool EntranceRedDot()
	{
		return this.GetExDataRedPointShowState();
	}

	// Token: 0x06005032 RID: 20530 RVA: 0x001AE0C0 File Offset: 0x001AC2C0
	private void PhraseChallengeData(IReadOnlyList<AbyssChallenge> data)
	{
		foreach (AbyssChallenge abyssChallenge in data)
		{
			AbyssChallengeData abyssChallengeData;
			if (this.ChallengeDataMap.TryGetValue(abyssChallenge.ChallengeId, out abyssChallengeData))
			{
				abyssChallengeData.Phrase(abyssChallenge);
			}
			else
			{
				AbyssChallengeData abyssChallengeData2 = new AbyssChallengeData();
				abyssChallengeData2.Phrase(abyssChallenge);
				this.ChallengeDataMap[abyssChallengeData2.GetChallengeId()] = abyssChallengeData2;
			}
		}
	}

	// Token: 0x06005033 RID: 20531 RVA: 0x001AE140 File Offset: 0x001AC340
	private void PhraseRewardInfo(IReadOnlyList<Aki.Protocol.AbyssRewardInfo> data)
	{
		foreach (Aki.Protocol.AbyssRewardInfo abyssRewardInfo in data)
		{
			global::AbyssRewardInfo abyssRewardInfo2;
			if (!this.RewardMap.TryGetValue(abyssRewardInfo.Id, out abyssRewardInfo2))
			{
				abyssRewardInfo2 = new global::AbyssRewardInfo();
				abyssRewardInfo2.Pharse(abyssRewardInfo);
				this.RewardMap[abyssRewardInfo.Id] = abyssRewardInfo2;
			}
			else
			{
				abyssRewardInfo2.Pharse(abyssRewardInfo);
			}
			this.RefreshRewardCategoryMap(abyssRewardInfo2);
		}
	}

	// Token: 0x06005034 RID: 20532 RVA: 0x001AE1C8 File Offset: 0x001AC3C8
	[NullableContext(2)]
	public global::AbyssRewardInfo GetRewardInfoById(int id)
	{
		global::AbyssRewardInfo result;
		if (this.RewardMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06005035 RID: 20533 RVA: 0x001AE1E8 File Offset: 0x001AC3E8
	public void OnRoleInfoUpdate(AbyssRoleInfoUpdateNotify notify)
	{
		foreach (AbyssRoleInfo data in notify.RoleList)
		{
			this.UpdateRoleInfo(data, false);
		}
	}

	// Token: 0x06005036 RID: 20534 RVA: 0x001AE238 File Offset: 0x001AC438
	public void OnAddRoleInfo(AbyssRoleAddNotify notify)
	{
		foreach (AbyssRoleInfo data in notify.RoleList)
		{
			this.UpdateRoleInfo(data, true);
		}
	}

	// Token: 0x06005037 RID: 20535 RVA: 0x001AE288 File Offset: 0x001AC488
	public void OnPluginInfoUpdate(AbyssPluginItemInfoUpdateNotify notify)
	{
		foreach (Aki.Protocol.AbyssPluginItemInfo data in notify.PluginItems)
		{
			this.UpdatePluginInfo(data);
		}
	}

	// Token: 0x06005038 RID: 20536 RVA: 0x001AE2D8 File Offset: 0x001AC4D8
	public void OnPluginAdd(AbyssPluginItemAddNotify notify)
	{
		foreach (Aki.Protocol.AbyssPluginItemInfo data in notify.PluginItems)
		{
			this.UpdatePluginInfo(data);
		}
	}

	// Token: 0x06005039 RID: 20537 RVA: 0x001AE328 File Offset: 0x001AC528
	public void OnPluginEquip(AbyssRoleInfo data)
	{
		this.UpdateRoleInfo(data, false);
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x001AE334 File Offset: 0x001AC534
	public void OnPluginRemove(AbyssPluginItemRemoveNotify notify)
	{
		foreach (int key in notify.IncrIds)
		{
			this.PluginItemMap.Remove(key);
		}
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x001AE388 File Offset: 0x001AC588
	public void OnUpdateRewardIdList(AbyssRewardsUpdateNotify notify)
	{
		foreach (Aki.Protocol.AbyssRewardInfo abyssRewardInfo in notify.RewardInfos)
		{
			global::AbyssRewardInfo abyssRewardInfo2;
			if (!this.RewardMap.TryGetValue(abyssRewardInfo.Id, out abyssRewardInfo2))
			{
				abyssRewardInfo2 = new global::AbyssRewardInfo();
				abyssRewardInfo2.Pharse(abyssRewardInfo);
				this.RewardMap[abyssRewardInfo.Id] = abyssRewardInfo2;
			}
			else
			{
				abyssRewardInfo2.Pharse(abyssRewardInfo);
			}
			this.RefreshRewardCategoryMap(abyssRewardInfo2);
		}
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x001AE414 File Offset: 0x001AC614
	public string GetRewardFinishProgressText()
	{
		int[] rewardTypeTabList = this.GetRewardTypeTabList(2);
		int num = 0;
		int num2 = 0;
		foreach (int tab in rewardTypeTabList)
		{
			foreach (global::AbyssRewardInfo abyssRewardInfo in this.GetRewardInfoByRewardTypeAndTab(2, tab))
			{
				num2++;
				if (abyssRewardInfo.GetHasGetReward() || abyssRewardInfo.GetCanGetReward())
				{
					num++;
				}
			}
		}
		return StringUtils.Format("{0}/{1}", new string[]
		{
			num.ToString(),
			num2.ToString()
		});
	}

	// Token: 0x0600503D RID: 20541 RVA: 0x001AE4A4 File Offset: 0x001AC6A4
	public bool GetRewardTypeIfHaveCanTakeReward(EAbyssShopType rewardType)
	{
		if (rewardType == EAbyssShopType.Limit && !this.CheckInLimitTime())
		{
			return false;
		}
		foreach (int tab in this.GetRewardTypeTabList((int)rewardType))
		{
			foreach (global::AbyssRewardInfo abyssRewardInfo in this.GetRewardInfoByRewardTypeAndTab((int)rewardType, tab))
			{
				if (!abyssRewardInfo.GetHasGetReward() && abyssRewardInfo.GetCanGetReward())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x001AE510 File Offset: 0x001AC710
	public int[] GetRewardTypeTabList(int rewardType)
	{
		List<int> list = new List<int>();
		Dictionary<int, List<global::AbyssRewardInfo>> dictionary;
		if (!this.RewardCategoryMap.TryGetValue(rewardType, out dictionary))
		{
			return list.ToArray();
		}
		foreach (KeyValuePair<int, List<global::AbyssRewardInfo>> keyValuePair in dictionary)
		{
			list.Add(keyValuePair.Key);
		}
		return list.ToArray();
	}

	// Token: 0x0600503F RID: 20543 RVA: 0x001AE588 File Offset: 0x001AC788
	public global::AbyssRewardInfo[] GetRewardInfoByRewardTypeAndTab(int rewardType, int tab)
	{
		Dictionary<int, List<global::AbyssRewardInfo>> dictionary;
		if (!this.RewardCategoryMap.TryGetValue(rewardType, out dictionary))
		{
			return Array.Empty<global::AbyssRewardInfo>();
		}
		List<global::AbyssRewardInfo> list;
		if (!dictionary.TryGetValue(tab, out list))
		{
			return Array.Empty<global::AbyssRewardInfo>();
		}
		return list.ToArray();
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x001AE5C4 File Offset: 0x001AC7C4
	public IActivityRewardData[] GetTaskActivityRewardDataList(int rewardType, int tab)
	{
		global::AbyssRewardInfo[] rewardInfoByRewardTypeAndTab = this.GetRewardInfoByRewardTypeAndTab(rewardType, tab);
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		global::AbyssRewardInfo[] array = rewardInfoByRewardTypeAndTab;
		for (int i = 0; i < array.Length; i++)
		{
			IActivityRewardData activityRewardData = array[i].GetActivityRewardData();
			list.Add(activityRewardData);
		}
		list.Sort(new Comparison<IActivityRewardData>(this.SortReward));
		return list.ToArray();
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x001AE618 File Offset: 0x001AC818
	private int SortReward(IActivityRewardData a, IActivityRewardData b)
	{
		int rewardSort = this.GetRewardSort(b);
		int rewardSort2 = this.GetRewardSort(a);
		if (rewardSort == rewardSort2)
		{
			return a.Id.Value - b.Id.Value;
		}
		return rewardSort - rewardSort2;
	}

	// Token: 0x06005042 RID: 20546 RVA: 0x001AE65C File Offset: 0x001AC85C
	private int GetRewardSort(IActivityRewardData data)
	{
		int result;
		switch (data.RewardState)
		{
		case EActivityRewardState.Disabled:
			result = 2;
			break;
		case EActivityRewardState.Enable:
			result = 3;
			break;
		case EActivityRewardState.Claimed:
			result = 1;
			break;
		default:
			result = 4;
			break;
		}
		return result;
	}

	// Token: 0x06005043 RID: 20547 RVA: 0x001AE698 File Offset: 0x001AC898
	private void RefreshRewardCategoryMap(global::AbyssRewardInfo data)
	{
		Dictionary<int, List<global::AbyssRewardInfo>> dictionary;
		if (!this.RewardCategoryMap.TryGetValue(data.GetRewardType(), out dictionary))
		{
			dictionary = new Dictionary<int, List<global::AbyssRewardInfo>>();
			this.RewardCategoryMap[data.GetRewardType()] = dictionary;
		}
		int tabId = data.GetTabId();
		List<global::AbyssRewardInfo> list;
		if (!dictionary.TryGetValue(tabId, out list))
		{
			list = new List<global::AbyssRewardInfo>();
			dictionary[tabId] = list;
		}
		bool flag = false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].GetId() == data.GetId())
			{
				list[i] = data;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			list.Add(data);
		}
	}

	// Token: 0x06005044 RID: 20548 RVA: 0x001AE735 File Offset: 0x001AC935
	public void OnUpdateUnlockChallengeIdList(AbyssChallengeUpdateNotify notify)
	{
		this.PhraseChallengeData(notify.ChallengeInfos);
	}

	// Token: 0x06005045 RID: 20549 RVA: 0x001AE744 File Offset: 0x001AC944
	public int[] GetUnLockChallengeIdList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			if (keyValuePair.Value.GetIfUnlock())
			{
				list.Add(keyValuePair.Value.GetChallengeId());
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005046 RID: 20550 RVA: 0x001AE7BC File Offset: 0x001AC9BC
	public int[] GetCanChallengeIdList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			if (keyValuePair.Value.GetCanChallenge())
			{
				list.Add(keyValuePair.Value.GetChallengeId());
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005047 RID: 20551 RVA: 0x001AE834 File Offset: 0x001ACA34
	public int GetLikeCount()
	{
		return this.CurrentLikeCount;
	}

	// Token: 0x06005048 RID: 20552 RVA: 0x001AE83C File Offset: 0x001ACA3C
	private void InitAllRoleData()
	{
		if (this.InitDangoState)
		{
			return;
		}
		this.InitDangoState = true;
		foreach (int id in DangoAbyssConfig.Instance.GetAbyssActivityData(base.Id).Value.DangoList())
		{
			AbyssDangoRoleData abyssDangoRoleData = new AbyssDangoRoleData();
			AbyssLittleRole value = DangoAbyssConfig.Instance.GetDangoRoleById(id).Value;
			abyssDangoRoleData.Init(value);
			this.RoleMap[value.Id] = abyssDangoRoleData;
		}
	}

	// Token: 0x06005049 RID: 20553 RVA: 0x001AE8C8 File Offset: 0x001ACAC8
	private void UpdateRoleInfo(AbyssRoleInfo data, bool isAdd = false)
	{
		this.UpdatePluginRoleInfo(data);
		AbyssDangoRoleData abyssDangoRoleData;
		if (!this.RoleMap.TryGetValue(data.Id, out abyssDangoRoleData))
		{
			abyssDangoRoleData = new AbyssDangoRoleData();
			this.RoleMap[data.Id] = abyssDangoRoleData;
		}
		if (isAdd)
		{
			DangoAbyssModel.Instance.SetDangoIfNew(data.Id, true);
			DangoAbyssModel.Instance.SetDangoFormationIfNew(data.Id, true);
		}
		RepeatedField<int> equipItems = data.EquipItems;
		List<int> list = new List<int>();
		foreach (int num in equipItems)
		{
			global::AbyssPluginItemInfo abyssPluginItemInfo;
			if (!this.PluginItemMap.TryGetValue(num, out abyssPluginItemInfo) && num > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "团子中含有未初始化的插件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dangoId", data.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			list.Add((abyssPluginItemInfo != null) ? abyssPluginItemInfo.GetConfigId() : 0);
		}
		abyssDangoRoleData.Phrase(data, list.ToArray());
	}

	// Token: 0x0600504A RID: 20554 RVA: 0x001AE9D8 File Offset: 0x001ACBD8
	private void UpdatePluginRoleInfo(AbyssRoleInfo data)
	{
		AbyssDangoRoleData abyssDangoRoleData;
		if (!this.RoleMap.TryGetValue(data.Id, out abyssDangoRoleData))
		{
			return;
		}
		RepeatedField<int> equipItems = data.EquipItems;
		int[] equipItems2 = abyssDangoRoleData.GetEquipItems();
		int count = equipItems.Count;
		for (int i = 0; i < count; i++)
		{
			int num = (i < equipItems2.Length) ? equipItems2[i] : 0;
			int num2 = equipItems[i];
			if (num != num2)
			{
				global::AbyssPluginItemInfo abyssPluginItemInfo;
				if (num2 > 0 && this.PluginItemMap.TryGetValue(num2, out abyssPluginItemInfo))
				{
					abyssPluginItemInfo.SetRoleId(data.Id);
				}
				bool flag = false;
				using (IEnumerator<int> enumerator = equipItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == num)
						{
							flag = true;
							break;
						}
					}
				}
				global::AbyssPluginItemInfo abyssPluginItemInfo2;
				if (num > 0 && !flag && this.PluginItemMap.TryGetValue(num, out abyssPluginItemInfo2))
				{
					abyssPluginItemInfo2.SetRoleId(0);
				}
			}
		}
	}

	// Token: 0x0600504B RID: 20555 RVA: 0x001AEAD0 File Offset: 0x001ACCD0
	[NullableContext(2)]
	public AbyssDangoRoleData GetRoleDataById(int id)
	{
		AbyssDangoRoleData result;
		if (this.RoleMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600504C RID: 20556 RVA: 0x001AEAF0 File Offset: 0x001ACCF0
	public AbyssDangoRoleData[] GetAllDangoList()
	{
		List<AbyssDangoRoleData> list = new List<AbyssDangoRoleData>();
		foreach (KeyValuePair<int, AbyssDangoRoleData> keyValuePair in this.RoleMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x0600504D RID: 20557 RVA: 0x001AEB58 File Offset: 0x001ACD58
	public string GetAbyssWorldProgressText()
	{
		int num = 0;
		foreach (KeyValuePair<int, AbyssDangoRoleData> keyValuePair in this.RoleMap)
		{
			if (!keyValuePair.Value.GetIfLock())
			{
				num++;
			}
		}
		return StringUtils.Format("{0}/{1}", new string[]
		{
			num.ToString(),
			this.RoleMap.Count.ToString()
		});
	}

	// Token: 0x0600504E RID: 20558 RVA: 0x001AEBE8 File Offset: 0x001ACDE8
	public float GetAbyssWorldProgressPercentage()
	{
		int num = 0;
		foreach (KeyValuePair<int, AbyssDangoRoleData> keyValuePair in this.RoleMap)
		{
			if (!keyValuePair.Value.GetIfLock())
			{
				num++;
			}
		}
		return (float)num / (float)this.RoleMap.Count;
	}

	// Token: 0x0600504F RID: 20559 RVA: 0x001AEC58 File Offset: 0x001ACE58
	public string GetAbyssProgressText()
	{
		int num = this.GetCanChallengeIdList().Length;
		int count = this.ChallengeDataMap.Count;
		return StringUtils.Format("{0}/{1}", new string[]
		{
			num.ToString(),
			count.ToString()
		});
	}

	// Token: 0x06005050 RID: 20560 RVA: 0x001AECA0 File Offset: 0x001ACEA0
	public bool GetPreChallengeFinishState(int challengeId)
	{
		List<AbyssChallengeData> list = new List<AbyssChallengeData>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i].GetChallengeId() == challengeId)
			{
				return i == 0 || list[i - 1].GetIfPass();
			}
		}
		return false;
	}

	// Token: 0x06005051 RID: 20561 RVA: 0x001AED40 File Offset: 0x001ACF40
	public int GetCurrentLastFinishChallengeId()
	{
		int num = 0;
		List<AbyssChallengeData> list = new List<AbyssChallengeData>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (i == 0)
			{
				num = list[i].GetChallengeId();
			}
			else if (list[i - 1].GetIfPass())
			{
				num = list[i].GetChallengeId();
			}
		}
		if (num == 0)
		{
			num = this.GetFirstUnlockChallengeId();
		}
		return num;
	}

	// Token: 0x06005052 RID: 20562 RVA: 0x001AEDF8 File Offset: 0x001ACFF8
	public int GetCurrentCanSelectChallengeId()
	{
		int num = 0;
		List<AbyssChallengeData> list = new List<AbyssChallengeData>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (i == 0)
			{
				num = list[i].GetChallengeId();
			}
			else
			{
				AbyssChallengeData abyssChallengeData = list[i - 1];
				AbyssChallengeData challengeData = list[i];
				if (abyssChallengeData.GetIfPass() && this.GetChallengeIfCanEnterState(challengeData))
				{
					num = list[i].GetChallengeId();
				}
			}
		}
		if (num == 0)
		{
			num = this.GetFirstUnlockChallengeId();
		}
		return num;
	}

	// Token: 0x06005053 RID: 20563 RVA: 0x001AEEC8 File Offset: 0x001AD0C8
	private bool GetChallengeIfCanEnterState(AbyssChallengeData challengeData)
	{
		bool canChallenge = challengeData.GetCanChallenge();
		bool preChallengeFinishState = this.GetPreChallengeFinishState(challengeData.GetChallengeId());
		bool conditionFinishState = challengeData.GetConditionFinishState();
		bool overUnlockTime = challengeData.GetOverUnlockTime();
		return canChallenge && preChallengeFinishState && conditionFinishState && overUnlockTime;
	}

	// Token: 0x06005054 RID: 20564 RVA: 0x001AEEFC File Offset: 0x001AD0FC
	public int GetFirstUnlockChallengeId()
	{
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			if (keyValuePair.Value.GetIfUnlock())
			{
				return keyValuePair.Value.GetChallengeId();
			}
		}
		return 0;
	}

	// Token: 0x06005055 RID: 20565 RVA: 0x001AEF68 File Offset: 0x001AD168
	private void UpdatePluginInfo(Aki.Protocol.AbyssPluginItemInfo data)
	{
		global::AbyssPluginItemInfo value;
		if (!this.PluginItemMap.TryGetValue(data.IncrId, out value))
		{
			value = new global::AbyssPluginItemInfo(data);
			this.PluginItemMap[data.IncrId] = value;
		}
	}

	// Token: 0x06005056 RID: 20566 RVA: 0x001AEFA4 File Offset: 0x001AD1A4
	[NullableContext(2)]
	public global::AbyssPluginItemInfo GetPluginItemInfoById(int incId)
	{
		global::AbyssPluginItemInfo result;
		if (this.PluginItemMap.TryGetValue(incId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06005057 RID: 20567 RVA: 0x001AEFC4 File Offset: 0x001AD1C4
	public global::AbyssPluginItemInfo[] GetPluginItemInfoAll()
	{
		List<global::AbyssPluginItemInfo> list = new List<global::AbyssPluginItemInfo>();
		foreach (KeyValuePair<int, global::AbyssPluginItemInfo> keyValuePair in this.PluginItemMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x06005058 RID: 20568 RVA: 0x001AF02C File Offset: 0x001AD22C
	public AbyssChallengeData[] GetAbyssChallengeDataList()
	{
		List<AbyssChallengeData> list = new List<AbyssChallengeData>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x06005059 RID: 20569 RVA: 0x001AF094 File Offset: 0x001AD294
	public AbyssChallengeData[] GetAbyssChallengeRankList()
	{
		List<AbyssChallengeData> list = new List<AbyssChallengeData>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		List<AbyssChallengeData> list2 = new List<AbyssChallengeData>();
		foreach (AbyssChallengeData abyssChallengeData in list)
		{
			int challengeId = abyssChallengeData.GetChallengeId();
			AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(challengeId);
			if (dangoAbyssInstById != null && dangoAbyssInstById.Value.RankOpen)
			{
				list2.Add(abyssChallengeData);
			}
		}
		return list2.ToArray();
	}

	// Token: 0x0600505A RID: 20570 RVA: 0x001AF174 File Offset: 0x001AD374
	[NullableContext(2)]
	public AbyssChallengeData GetAbyssChallengeDataById(int id)
	{
		AbyssChallengeData result;
		if (this.ChallengeDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x04003982 RID: 14722
	private bool InitDangoState;

	// Token: 0x04003983 RID: 14723
	private readonly Dictionary<int, global::AbyssRewardInfo> RewardMap = new Dictionary<int, global::AbyssRewardInfo>();

	// Token: 0x04003984 RID: 14724
	private readonly Dictionary<int, Dictionary<int, List<global::AbyssRewardInfo>>> RewardCategoryMap = new Dictionary<int, Dictionary<int, List<global::AbyssRewardInfo>>>();

	// Token: 0x04003985 RID: 14725
	private readonly Dictionary<int, AbyssDangoRoleData> RoleMap = new Dictionary<int, AbyssDangoRoleData>();

	// Token: 0x04003986 RID: 14726
	private readonly Dictionary<int, global::AbyssPluginItemInfo> PluginItemMap = new Dictionary<int, global::AbyssPluginItemInfo>();

	// Token: 0x04003987 RID: 14727
	private readonly Dictionary<int, AbyssChallengeData> ChallengeDataMap = new Dictionary<int, AbyssChallengeData>();

	// Token: 0x04003988 RID: 14728
	private int CurrentLikeCount;

	// Token: 0x04003989 RID: 14729
	private long LimitStartTime;

	// Token: 0x0400398A RID: 14730
	private long LimitEndTime;
}

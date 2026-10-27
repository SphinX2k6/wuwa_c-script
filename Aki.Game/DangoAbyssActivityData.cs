using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x0200121E RID: 4638
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssActivityData : ActivityBaseData
{
	// Token: 0x06007C95 RID: 31893 RVA: 0x001A5208 File Offset: 0x001A3408
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
		this.PhraseChallengeData(abyssInfo.ChallengeInfos.ToArray<AbyssChallenge>());
		this.PhraseRewardInfo(abyssInfo.RewardInfo.ToArray<Aki.Protocol.AbyssRewardInfo>());
		this.LimitStartTime = MathUtils.Instance.LongToBigInt(abyssInfo.LimitBeginTime) / 1000L;
		this.LimitEndTime = MathUtils.Instance.LongToBigInt(abyssInfo.LimitEndTime) / 1000L;
	}

	// Token: 0x17000A92 RID: 2706
	// (get) Token: 0x06007C96 RID: 31894 RVA: 0x001A530C File Offset: 0x001A350C
	public override bool RedPointShowState
	{
		get
		{
			return this.CheckIfInShowTime() && ((base.IsUnLock() && DangoAbyssModel.Instance.GetAbyssDangoEnterNew()) || base.RedPointShowState);
		}
	}

	// Token: 0x06007C97 RID: 31895 RVA: 0x001A5334 File Offset: 0x001A3534
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

	// Token: 0x06007C98 RID: 31896 RVA: 0x001A5384 File Offset: 0x001A3584
	public override bool GetExDataRedPointShowState()
	{
		bool rewardTypeIfHaveCanTakeReward = this.GetRewardTypeIfHaveCanTakeReward(EAbyssShopType.Common);
		bool rewardTypeIfHaveCanTakeReward2 = this.GetRewardTypeIfHaveCanTakeReward(EAbyssShopType.Limit);
		bool dangoNewRedDot = DangoAbyssModel.Instance.GetDangoNewRedDot();
		return base.GetPreGuideQuestFinishState() && (rewardTypeIfHaveCanTakeReward || rewardTypeIfHaveCanTakeReward2 || dangoNewRedDot);
	}

	// Token: 0x06007C99 RID: 31897 RVA: 0x001A53BC File Offset: 0x001A35BC
	public bool CheckInLimitTime()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)this.LimitStartTime && serverTime <= (double)this.LimitEndTime;
	}

	// Token: 0x06007C9A RID: 31898 RVA: 0x001A53F0 File Offset: 0x001A35F0
	public string GetRemainTimeText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = Math.Max((double)this.LimitEndTime - serverTime, 1.0);
		return TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText ?? "";
	}

	// Token: 0x06007C9B RID: 31899 RVA: 0x001A5439 File Offset: 0x001A3639
	public bool EntranceRedDot()
	{
		return this.GetExDataRedPointShowState();
	}

	// Token: 0x06007C9C RID: 31900 RVA: 0x001A5444 File Offset: 0x001A3644
	private void PhraseChallengeData(AbyssChallenge[] data)
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

	// Token: 0x06007C9D RID: 31901 RVA: 0x001A54A8 File Offset: 0x001A36A8
	private void PhraseRewardInfo(Aki.Protocol.AbyssRewardInfo[] data)
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

	// Token: 0x06007C9E RID: 31902 RVA: 0x001A5510 File Offset: 0x001A3710
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

	// Token: 0x06007C9F RID: 31903 RVA: 0x001A5530 File Offset: 0x001A3730
	public void OnRoleInfoUpdate(AbyssRoleInfoUpdateNotify notify)
	{
		foreach (AbyssRoleInfo data in notify.RoleList)
		{
			this.UpdateRoleInfo(data, false);
		}
	}

	// Token: 0x06007CA0 RID: 31904 RVA: 0x001A5580 File Offset: 0x001A3780
	public void OnAddRoleInfo(AbyssRoleAddNotify notify)
	{
		foreach (AbyssRoleInfo data in notify.RoleList)
		{
			this.UpdateRoleInfo(data, true);
		}
	}

	// Token: 0x06007CA1 RID: 31905 RVA: 0x001A55D0 File Offset: 0x001A37D0
	public void OnPluginInfoUpdate(AbyssPluginItemInfoUpdateNotify notify)
	{
		foreach (Aki.Protocol.AbyssPluginItemInfo data in notify.PluginItems)
		{
			this.UpdatePluginInfo(data);
		}
	}

	// Token: 0x06007CA2 RID: 31906 RVA: 0x001A5620 File Offset: 0x001A3820
	public void OnPluginAdd(AbyssPluginItemAddNotify notify)
	{
		foreach (Aki.Protocol.AbyssPluginItemInfo data in notify.PluginItems)
		{
			this.UpdatePluginInfo(data);
		}
	}

	// Token: 0x06007CA3 RID: 31907 RVA: 0x001A5670 File Offset: 0x001A3870
	public void OnPluginEquip(AbyssRoleInfo data)
	{
		this.UpdateRoleInfo(data, false);
	}

	// Token: 0x06007CA4 RID: 31908 RVA: 0x001A567C File Offset: 0x001A387C
	public void OnPluginRemove(AbyssPluginItemRemoveNotify notify)
	{
		foreach (int key in notify.IncrIds)
		{
			this.PluginItemMap.Remove(key);
		}
	}

	// Token: 0x06007CA5 RID: 31909 RVA: 0x001A56D0 File Offset: 0x001A38D0
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

	// Token: 0x06007CA6 RID: 31910 RVA: 0x001A575C File Offset: 0x001A395C
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

	// Token: 0x06007CA7 RID: 31911 RVA: 0x001A57EC File Offset: 0x001A39EC
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

	// Token: 0x06007CA8 RID: 31912 RVA: 0x001A5858 File Offset: 0x001A3A58
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

	// Token: 0x06007CA9 RID: 31913 RVA: 0x001A58D0 File Offset: 0x001A3AD0
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

	// Token: 0x06007CAA RID: 31914 RVA: 0x001A590C File Offset: 0x001A3B0C
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

	// Token: 0x06007CAB RID: 31915 RVA: 0x001A5960 File Offset: 0x001A3B60
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

	// Token: 0x06007CAC RID: 31916 RVA: 0x001A59A4 File Offset: 0x001A3BA4
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

	// Token: 0x06007CAD RID: 31917 RVA: 0x001A59E0 File Offset: 0x001A3BE0
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

	// Token: 0x06007CAE RID: 31918 RVA: 0x001A5A7D File Offset: 0x001A3C7D
	public void OnUpdateUnlockChallengeIdList(AbyssChallengeUpdateNotify notify)
	{
		this.PhraseChallengeData(notify.ChallengeInfos.ToArray<AbyssChallenge>());
	}

	// Token: 0x06007CAF RID: 31919 RVA: 0x001A5A90 File Offset: 0x001A3C90
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

	// Token: 0x06007CB0 RID: 31920 RVA: 0x001A5B08 File Offset: 0x001A3D08
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

	// Token: 0x06007CB1 RID: 31921 RVA: 0x001A5B80 File Offset: 0x001A3D80
	public int GetLikeCount()
	{
		return this.CurrentLikeCount;
	}

	// Token: 0x06007CB2 RID: 31922 RVA: 0x001A5B88 File Offset: 0x001A3D88
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

	// Token: 0x06007CB3 RID: 31923 RVA: 0x001A5C14 File Offset: 0x001A3E14
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

	// Token: 0x06007CB4 RID: 31924 RVA: 0x001A5D24 File Offset: 0x001A3F24
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

	// Token: 0x06007CB5 RID: 31925 RVA: 0x001A5E1C File Offset: 0x001A401C
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

	// Token: 0x06007CB6 RID: 31926 RVA: 0x001A5E3C File Offset: 0x001A403C
	public AbyssDangoRoleData[] GetAllDangoList()
	{
		List<AbyssDangoRoleData> list = new List<AbyssDangoRoleData>();
		foreach (KeyValuePair<int, AbyssDangoRoleData> keyValuePair in this.RoleMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x06007CB7 RID: 31927 RVA: 0x001A5EA4 File Offset: 0x001A40A4
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

	// Token: 0x06007CB8 RID: 31928 RVA: 0x001A5F34 File Offset: 0x001A4134
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

	// Token: 0x06007CB9 RID: 31929 RVA: 0x001A5FA4 File Offset: 0x001A41A4
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

	// Token: 0x06007CBA RID: 31930 RVA: 0x001A5FEC File Offset: 0x001A41EC
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

	// Token: 0x06007CBB RID: 31931 RVA: 0x001A608C File Offset: 0x001A428C
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

	// Token: 0x06007CBC RID: 31932 RVA: 0x001A6144 File Offset: 0x001A4344
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

	// Token: 0x06007CBD RID: 31933 RVA: 0x001A6214 File Offset: 0x001A4414
	private bool GetChallengeIfCanEnterState(AbyssChallengeData challengeData)
	{
		bool canChallenge = challengeData.GetCanChallenge();
		bool preChallengeFinishState = this.GetPreChallengeFinishState(challengeData.GetChallengeId());
		bool conditionFinishState = challengeData.GetConditionFinishState();
		bool overUnlockTime = challengeData.GetOverUnlockTime();
		return canChallenge && preChallengeFinishState && conditionFinishState && overUnlockTime;
	}

	// Token: 0x06007CBE RID: 31934 RVA: 0x001A6248 File Offset: 0x001A4448
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

	// Token: 0x06007CBF RID: 31935 RVA: 0x001A62B4 File Offset: 0x001A44B4
	private void UpdatePluginInfo(Aki.Protocol.AbyssPluginItemInfo data)
	{
		global::AbyssPluginItemInfo value;
		if (!this.PluginItemMap.TryGetValue(data.IncrId, out value))
		{
			value = new global::AbyssPluginItemInfo(data);
			this.PluginItemMap[data.IncrId] = value;
		}
	}

	// Token: 0x06007CC0 RID: 31936 RVA: 0x001A62F0 File Offset: 0x001A44F0
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

	// Token: 0x06007CC1 RID: 31937 RVA: 0x001A6310 File Offset: 0x001A4510
	public global::AbyssPluginItemInfo[] GetPluginItemInfoAll()
	{
		List<global::AbyssPluginItemInfo> list = new List<global::AbyssPluginItemInfo>();
		foreach (KeyValuePair<int, global::AbyssPluginItemInfo> keyValuePair in this.PluginItemMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x06007CC2 RID: 31938 RVA: 0x001A6378 File Offset: 0x001A4578
	public AbyssChallengeData[] GetAbyssChallengeDataList()
	{
		List<AbyssChallengeData> list = new List<AbyssChallengeData>();
		foreach (KeyValuePair<int, AbyssChallengeData> keyValuePair in this.ChallengeDataMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x06007CC3 RID: 31939 RVA: 0x001A63E0 File Offset: 0x001A45E0
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

	// Token: 0x06007CC4 RID: 31940 RVA: 0x001A64C0 File Offset: 0x001A46C0
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

	// Token: 0x040038E9 RID: 14569
	private bool InitDangoState;

	// Token: 0x040038EA RID: 14570
	private readonly Dictionary<int, global::AbyssRewardInfo> RewardMap = new Dictionary<int, global::AbyssRewardInfo>();

	// Token: 0x040038EB RID: 14571
	private readonly Dictionary<int, Dictionary<int, List<global::AbyssRewardInfo>>> RewardCategoryMap = new Dictionary<int, Dictionary<int, List<global::AbyssRewardInfo>>>();

	// Token: 0x040038EC RID: 14572
	private readonly Dictionary<int, AbyssDangoRoleData> RoleMap = new Dictionary<int, AbyssDangoRoleData>();

	// Token: 0x040038ED RID: 14573
	private readonly Dictionary<int, global::AbyssPluginItemInfo> PluginItemMap = new Dictionary<int, global::AbyssPluginItemInfo>();

	// Token: 0x040038EE RID: 14574
	private readonly Dictionary<int, AbyssChallengeData> ChallengeDataMap = new Dictionary<int, AbyssChallengeData>();

	// Token: 0x040038EF RID: 14575
	private int CurrentLikeCount;

	// Token: 0x040038F0 RID: 14576
	private long LimitStartTime;

	// Token: 0x040038F1 RID: 14577
	private long LimitEndTime;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A17 RID: 6679
[NullableContext(1)]
[Nullable(0)]
public class AbyssRankChallengeInfo
{
	// Token: 0x0600C401 RID: 50177 RVA: 0x002C5F44 File Offset: 0x002C4144
	public void SetIsOpenAnonymousName(int challengeId, bool isOpen)
	{
		this.ChallengeAnonymousMap[challengeId] = isOpen;
		List<global::AbyssChallengeInfo> list;
		if (this.AllMultiPassDataMap.TryGetValue(challengeId, out list))
		{
			foreach (global::AbyssChallengeInfo abyssChallengeInfo in list)
			{
				abyssChallengeInfo.SetNameMode(isOpen);
			}
		}
		List<global::AbyssChallengeInfo> list2;
		if (this.AllSinglePassDataMap.TryGetValue(challengeId, out list2))
		{
			foreach (global::AbyssChallengeInfo abyssChallengeInfo2 in list2)
			{
				abyssChallengeInfo2.SetNameMode(isOpen);
			}
		}
	}

	// Token: 0x0600C402 RID: 50178 RVA: 0x002C5FF8 File Offset: 0x002C41F8
	public void OnSelfRankInfoUpdate(AbyssSelfPassResponse data)
	{
		this.RemoveAllSelfPassData(this.AllSinglePassDataMap);
		this.RemoveAllSelfPassData(this.AllMultiPassDataMap);
		if (data.SelfPassData.Count == 0)
		{
			return;
		}
		this.SelfRankInfo = Array.Empty<global::AbyssChallengeInfo>();
		List<global::AbyssChallengeInfo> list = new List<global::AbyssChallengeInfo>();
		int count = data.SelfPassData.Count;
		for (int i = 0; i < count; i++)
		{
			global::AbyssChallengeInfo abyssChallengeInfo = new global::AbyssChallengeInfo();
			abyssChallengeInfo.Phrase(data.SelfPassData[i]);
			list.Add(abyssChallengeInfo);
			if (abyssChallengeInfo.GetIsSingle())
			{
				this.GetOrAddSinglePassData(abyssChallengeInfo.GetChallengeId()).Add(abyssChallengeInfo);
				this.SetSelfSinglePassData(abyssChallengeInfo, abyssChallengeInfo.GetChallengeId());
			}
			else
			{
				this.GetOrAddMultiPassData(abyssChallengeInfo.GetChallengeId()).Add(abyssChallengeInfo);
				this.SetSelfMultiPassData(abyssChallengeInfo, abyssChallengeInfo.GetChallengeId());
			}
		}
		this.SelfRankInfo = list.ToArray();
		foreach (global::AbyssChallengeInfo abyssChallengeInfo2 in this.SelfRankInfo)
		{
			int challengeId = abyssChallengeInfo2.GetChallengeId();
			bool showName = abyssChallengeInfo2.GetShowName();
			this.ChallengeAnonymousMap[challengeId] = showName;
		}
	}

	// Token: 0x0600C403 RID: 50179 RVA: 0x002C6108 File Offset: 0x002C4308
	public bool GetAnonymousNameMode(int challengeId)
	{
		bool flag;
		return !this.ChallengeAnonymousMap.TryGetValue(challengeId, out flag) || flag;
	}

	// Token: 0x0600C404 RID: 50180 RVA: 0x002C6128 File Offset: 0x002C4328
	private void RemoveAllSelfPassData(Dictionary<int, List<global::AbyssChallengeInfo>> dataMap)
	{
		foreach (KeyValuePair<int, List<global::AbyssChallengeInfo>> keyValuePair in dataMap)
		{
			List<global::AbyssChallengeInfo> value = keyValuePair.Value;
			for (int i = value.Count - 1; i >= 0; i--)
			{
				if (value[i].IsSelf)
				{
					value.RemoveAt(i);
					break;
				}
			}
		}
	}

	// Token: 0x0600C405 RID: 50181 RVA: 0x002C61A4 File Offset: 0x002C43A4
	public void OnChallengeRankInfoUpdate(AbyssRankListResponse data)
	{
		this.AllSinglePassDataMap.Clear();
		this.AllMultiPassDataMap.Clear();
		this.FriendRankList = Array.Empty<global::AbyssChallengeInfo>();
		List<global::AbyssChallengeInfo> list = new List<global::AbyssChallengeInfo>();
		int count = data.FriendPassData.Count;
		for (int i = 0; i < count; i++)
		{
			global::AbyssChallengeInfo abyssChallengeInfo = new global::AbyssChallengeInfo();
			abyssChallengeInfo.Phrase(data.FriendPassData[i]);
			list.Add(abyssChallengeInfo);
			if (abyssChallengeInfo.GetIsSingle())
			{
				this.GetOrAddSinglePassData(abyssChallengeInfo.GetChallengeId()).Add(abyssChallengeInfo);
			}
			else
			{
				this.GetOrAddMultiPassData(abyssChallengeInfo.GetChallengeId()).Add(abyssChallengeInfo);
			}
		}
		this.FriendRankList = list.ToArray();
		this.SelfRankInfo = Array.Empty<global::AbyssChallengeInfo>();
		List<global::AbyssChallengeInfo> list2 = new List<global::AbyssChallengeInfo>();
		int count2 = data.SelfPassData.Count;
		for (int j = 0; j < count2; j++)
		{
			global::AbyssChallengeInfo abyssChallengeInfo2 = new global::AbyssChallengeInfo();
			abyssChallengeInfo2.Phrase(data.SelfPassData[j]);
			list2.Add(abyssChallengeInfo2);
			if (abyssChallengeInfo2.GetIsSingle())
			{
				this.GetOrAddSinglePassData(abyssChallengeInfo2.GetChallengeId()).Add(abyssChallengeInfo2);
				this.SetSelfSinglePassData(abyssChallengeInfo2, abyssChallengeInfo2.GetChallengeId());
			}
			else
			{
				this.GetOrAddMultiPassData(abyssChallengeInfo2.GetChallengeId()).Add(abyssChallengeInfo2);
				this.SetSelfMultiPassData(abyssChallengeInfo2, abyssChallengeInfo2.GetChallengeId());
			}
		}
		this.SelfRankInfo = list2.ToArray();
	}

	// Token: 0x0600C406 RID: 50182 RVA: 0x002C6304 File Offset: 0x002C4504
	public void RefreshAllPassDataRank(int challengeId)
	{
		List<global::AbyssChallengeInfo> orAddSinglePassData = this.GetOrAddSinglePassData(challengeId);
		this.RefreshPassDataRank(challengeId, orAddSinglePassData, this.SinglePassDataList);
		List<global::AbyssChallengeInfo> orAddMultiPassData = this.GetOrAddMultiPassData(challengeId);
		this.RefreshPassDataRank(challengeId, orAddMultiPassData, this.MultiPassDataList);
		this.RefreshOwnPassData(challengeId);
		this.RefreshSelfRankItemDataName(challengeId);
	}

	// Token: 0x0600C407 RID: 50183 RVA: 0x002C634C File Offset: 0x002C454C
	private void RefreshOwnPassData(int challengeId)
	{
		global::AbyssChallengeInfo abyssChallengeInfo;
		if (!this.AllOwnSinglePassDataMap.TryGetValue(challengeId, out abyssChallengeInfo))
		{
			abyssChallengeInfo = this.CreateOwnSinglePassData(challengeId);
		}
		this.OwnSinglePassData = abyssChallengeInfo;
		this.OwnSinglePassData.IsInRank = this.SinglePassDataList.Contains(abyssChallengeInfo);
		global::AbyssChallengeInfo abyssChallengeInfo2;
		if (!this.AllOwnMultiPassData.TryGetValue(challengeId, out abyssChallengeInfo2))
		{
			abyssChallengeInfo2 = this.CreateOwnMultiPassData(challengeId);
		}
		this.OwnMultiPassData = abyssChallengeInfo2;
		this.OwnMultiPassData.IsInRank = this.MultiPassDataList.Contains(abyssChallengeInfo2);
	}

	// Token: 0x0600C408 RID: 50184 RVA: 0x002C63C8 File Offset: 0x002C45C8
	private global::AbyssChallengeInfo CreateOwnSinglePassData(int challengeId)
	{
		global::AbyssChallengeInfo abyssChallengeInfo = new global::AbyssChallengeInfo();
		this.SetSelfSinglePassData(abyssChallengeInfo, challengeId);
		return abyssChallengeInfo;
	}

	// Token: 0x0600C409 RID: 50185 RVA: 0x002C63E4 File Offset: 0x002C45E4
	private global::AbyssChallengeInfo CreateOwnMultiPassData(int challengeId)
	{
		global::AbyssChallengeInfo abyssChallengeInfo = new global::AbyssChallengeInfo();
		this.SetSelfMultiPassData(abyssChallengeInfo, challengeId);
		return abyssChallengeInfo;
	}

	// Token: 0x0600C40A RID: 50186 RVA: 0x002C6400 File Offset: 0x002C4600
	private int SortNormalPassData(global::AbyssChallengeInfo aData, global::AbyssChallengeInfo bData)
	{
		if (aData.GetProgress() == bData.GetProgress())
		{
			return aData.GetPassTime() - bData.GetPassTime();
		}
		return bData.GetProgress() - aData.GetProgress();
	}

	// Token: 0x0600C40B RID: 50187 RVA: 0x002C642C File Offset: 0x002C462C
	private void RefreshPassDataRank(int challengeId, List<global::AbyssChallengeInfo> allDataList, List<global::AbyssChallengeInfo> refDataList)
	{
		refDataList.Clear();
		allDataList.Sort(new Comparison<global::AbyssChallengeInfo>(this.SortNormalPassData));
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < allDataList.Count; i++)
		{
			global::AbyssChallengeInfo abyssChallengeInfo = allDataList[i];
			if (i == 0)
			{
				num++;
				num2 = abyssChallengeInfo.GetPassTime();
				num3 = abyssChallengeInfo.GetProgress();
			}
			else
			{
				bool flag = abyssChallengeInfo.GetPassTime() != num2;
				bool flag2 = abyssChallengeInfo.GetProgress() != num3;
				if (flag || flag2)
				{
					num++;
					num2 = abyssChallengeInfo.GetPassTime();
					num3 = abyssChallengeInfo.GetProgress();
				}
			}
			abyssChallengeInfo.Rank = num;
			refDataList.Add(abyssChallengeInfo);
		}
	}

	// Token: 0x0600C40C RID: 50188 RVA: 0x002C64D0 File Offset: 0x002C46D0
	public void RefreshSelfRankItemDataName(int challengeId)
	{
		List<global::AbyssChallengeInfo> list;
		if (this.AllSinglePassDataMap.TryGetValue(challengeId, out list))
		{
			foreach (global::AbyssChallengeInfo abyssChallengeInfo in list)
			{
				if (abyssChallengeInfo.IsSelfInData)
				{
					bool anonymousNameMode = this.GetAnonymousNameMode(challengeId);
					abyssChallengeInfo.RefreshPlayerName(anonymousNameMode);
				}
			}
		}
		List<global::AbyssChallengeInfo> list2;
		if (this.AllMultiPassDataMap.TryGetValue(challengeId, out list2))
		{
			foreach (global::AbyssChallengeInfo abyssChallengeInfo2 in list2)
			{
				if (abyssChallengeInfo2.IsSelfInData)
				{
					bool anonymousNameMode2 = this.GetAnonymousNameMode(challengeId);
					abyssChallengeInfo2.RefreshPlayerName(anonymousNameMode2);
				}
			}
		}
	}

	// Token: 0x0600C40D RID: 50189 RVA: 0x002C65A4 File Offset: 0x002C47A4
	public global::AbyssChallengeInfo[] GetRankDataListByOnlineType(bool onlineState)
	{
		if (!onlineState)
		{
			return this.SinglePassDataList.ToArray();
		}
		return this.MultiPassDataList.ToArray();
	}

	// Token: 0x0600C40E RID: 50190 RVA: 0x002C65C0 File Offset: 0x002C47C0
	public global::AbyssChallengeInfo GetSelfRankDataByTabType(bool onlineState)
	{
		if (!onlineState)
		{
			return this.OwnSinglePassData;
		}
		return this.OwnMultiPassData;
	}

	// Token: 0x0600C40F RID: 50191 RVA: 0x002C65D4 File Offset: 0x002C47D4
	private List<global::AbyssChallengeInfo> GetOrAddSinglePassData(int challengeId)
	{
		List<global::AbyssChallengeInfo> list;
		if (!this.AllSinglePassDataMap.TryGetValue(challengeId, out list))
		{
			list = new List<global::AbyssChallengeInfo>();
			this.AllSinglePassDataMap[challengeId] = list;
		}
		return list;
	}

	// Token: 0x0600C410 RID: 50192 RVA: 0x002C6605 File Offset: 0x002C4805
	private void SetSelfSinglePassData(global::AbyssChallengeInfo itemData, int challengeId)
	{
		itemData.IsSelf = true;
		this.AllOwnSinglePassDataMap[challengeId] = itemData;
	}

	// Token: 0x0600C411 RID: 50193 RVA: 0x002C661C File Offset: 0x002C481C
	private List<global::AbyssChallengeInfo> GetOrAddMultiPassData(int challengeId)
	{
		List<global::AbyssChallengeInfo> list;
		if (!this.AllMultiPassDataMap.TryGetValue(challengeId, out list))
		{
			list = new List<global::AbyssChallengeInfo>();
			this.AllMultiPassDataMap[challengeId] = list;
		}
		return list;
	}

	// Token: 0x0600C412 RID: 50194 RVA: 0x002C664D File Offset: 0x002C484D
	private void SetSelfMultiPassData(global::AbyssChallengeInfo itemData, int challengeId)
	{
		itemData.IsSelf = true;
		this.AllOwnMultiPassData[challengeId] = itemData;
	}

	// Token: 0x0600C413 RID: 50195 RVA: 0x002C6664 File Offset: 0x002C4864
	public bool IsOwnSingleBestScore(int challengeId)
	{
		bool isEmpty = this.OwnSinglePassData.IsEmpty;
		bool isEmpty2 = this.OwnMultiPassData.IsEmpty;
		if (isEmpty == isEmpty2 && isEmpty)
		{
			return true;
		}
		if (isEmpty != isEmpty2)
		{
			return isEmpty2;
		}
		int passTime = this.OwnSinglePassData.GetPassTime();
		int passTime2 = this.OwnMultiPassData.GetPassTime();
		return passTime <= passTime2;
	}

	// Token: 0x04005A68 RID: 23144
	private readonly Dictionary<int, bool> ChallengeAnonymousMap = new Dictionary<int, bool>();

	// Token: 0x04005A69 RID: 23145
	private readonly Dictionary<int, List<global::AbyssChallengeInfo>> AllMultiPassDataMap = new Dictionary<int, List<global::AbyssChallengeInfo>>();

	// Token: 0x04005A6A RID: 23146
	private readonly Dictionary<int, global::AbyssChallengeInfo> AllOwnSinglePassDataMap = new Dictionary<int, global::AbyssChallengeInfo>();

	// Token: 0x04005A6B RID: 23147
	private readonly Dictionary<int, List<global::AbyssChallengeInfo>> AllSinglePassDataMap = new Dictionary<int, List<global::AbyssChallengeInfo>>();

	// Token: 0x04005A6C RID: 23148
	private readonly Dictionary<int, global::AbyssChallengeInfo> AllOwnMultiPassData = new Dictionary<int, global::AbyssChallengeInfo>();

	// Token: 0x04005A6D RID: 23149
	private readonly List<global::AbyssChallengeInfo> SinglePassDataList = new List<global::AbyssChallengeInfo>();

	// Token: 0x04005A6E RID: 23150
	private readonly List<global::AbyssChallengeInfo> MultiPassDataList = new List<global::AbyssChallengeInfo>();

	// Token: 0x04005A6F RID: 23151
	private global::AbyssChallengeInfo[] FriendRankList = Array.Empty<global::AbyssChallengeInfo>();

	// Token: 0x04005A70 RID: 23152
	private global::AbyssChallengeInfo[] SelfRankInfo = Array.Empty<global::AbyssChallengeInfo>();

	// Token: 0x04005A71 RID: 23153
	private global::AbyssChallengeInfo OwnSinglePassData;

	// Token: 0x04005A72 RID: 23154
	private global::AbyssChallengeInfo OwnMultiPassData;
}

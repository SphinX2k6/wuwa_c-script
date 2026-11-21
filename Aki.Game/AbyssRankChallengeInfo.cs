using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED6 RID: 3798
[NullableContext(1)]
[Nullable(0)]
public class AbyssRankChallengeInfo
{
	// Token: 0x06009811 RID: 38929 RVA: 0x002D0FC8 File Offset: 0x002CF1C8
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

	// Token: 0x06009812 RID: 38930 RVA: 0x002D107C File Offset: 0x002CF27C
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

	// Token: 0x06009813 RID: 38931 RVA: 0x002D118C File Offset: 0x002CF38C
	public bool GetAnonymousNameMode(int challengeId)
	{
		bool flag;
		return !this.ChallengeAnonymousMap.TryGetValue(challengeId, out flag) || flag;
	}

	// Token: 0x06009814 RID: 38932 RVA: 0x002D11AC File Offset: 0x002CF3AC
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

	// Token: 0x06009815 RID: 38933 RVA: 0x002D1228 File Offset: 0x002CF428
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

	// Token: 0x06009816 RID: 38934 RVA: 0x002D1388 File Offset: 0x002CF588
	public void RefreshAllPassDataRank(int challengeId)
	{
		List<global::AbyssChallengeInfo> orAddSinglePassData = this.GetOrAddSinglePassData(challengeId);
		this.RefreshPassDataRank(challengeId, orAddSinglePassData, this.SinglePassDataList);
		List<global::AbyssChallengeInfo> orAddMultiPassData = this.GetOrAddMultiPassData(challengeId);
		this.RefreshPassDataRank(challengeId, orAddMultiPassData, this.MultiPassDataList);
		this.RefreshOwnPassData(challengeId);
		this.RefreshSelfRankItemDataName(challengeId);
	}

	// Token: 0x06009817 RID: 38935 RVA: 0x002D13D0 File Offset: 0x002CF5D0
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

	// Token: 0x06009818 RID: 38936 RVA: 0x002D144C File Offset: 0x002CF64C
	private global::AbyssChallengeInfo CreateOwnSinglePassData(int challengeId)
	{
		global::AbyssChallengeInfo abyssChallengeInfo = new global::AbyssChallengeInfo();
		this.SetSelfSinglePassData(abyssChallengeInfo, challengeId);
		return abyssChallengeInfo;
	}

	// Token: 0x06009819 RID: 38937 RVA: 0x002D1468 File Offset: 0x002CF668
	private global::AbyssChallengeInfo CreateOwnMultiPassData(int challengeId)
	{
		global::AbyssChallengeInfo abyssChallengeInfo = new global::AbyssChallengeInfo();
		this.SetSelfMultiPassData(abyssChallengeInfo, challengeId);
		return abyssChallengeInfo;
	}

	// Token: 0x0600981A RID: 38938 RVA: 0x002D1484 File Offset: 0x002CF684
	private int SortNormalPassData(global::AbyssChallengeInfo aData, global::AbyssChallengeInfo bData)
	{
		if (aData.GetProgress() == bData.GetProgress())
		{
			return aData.GetPassTime() - bData.GetPassTime();
		}
		return bData.GetProgress() - aData.GetProgress();
	}

	// Token: 0x0600981B RID: 38939 RVA: 0x002D14B0 File Offset: 0x002CF6B0
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

	// Token: 0x0600981C RID: 38940 RVA: 0x002D1554 File Offset: 0x002CF754
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

	// Token: 0x0600981D RID: 38941 RVA: 0x002D1628 File Offset: 0x002CF828
	public global::AbyssChallengeInfo[] GetRankDataListByOnlineType(bool onlineState)
	{
		if (!onlineState)
		{
			return this.SinglePassDataList.ToArray();
		}
		return this.MultiPassDataList.ToArray();
	}

	// Token: 0x0600981E RID: 38942 RVA: 0x002D1644 File Offset: 0x002CF844
	public global::AbyssChallengeInfo GetSelfRankDataByTabType(bool onlineState)
	{
		if (!onlineState)
		{
			return this.OwnSinglePassData;
		}
		return this.OwnMultiPassData;
	}

	// Token: 0x0600981F RID: 38943 RVA: 0x002D1658 File Offset: 0x002CF858
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

	// Token: 0x06009820 RID: 38944 RVA: 0x002D1689 File Offset: 0x002CF889
	private void SetSelfSinglePassData(global::AbyssChallengeInfo itemData, int challengeId)
	{
		itemData.IsSelf = true;
		this.AllOwnSinglePassDataMap[challengeId] = itemData;
	}

	// Token: 0x06009821 RID: 38945 RVA: 0x002D16A0 File Offset: 0x002CF8A0
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

	// Token: 0x06009822 RID: 38946 RVA: 0x002D16D1 File Offset: 0x002CF8D1
	private void SetSelfMultiPassData(global::AbyssChallengeInfo itemData, int challengeId)
	{
		itemData.IsSelf = true;
		this.AllOwnMultiPassData[challengeId] = itemData;
	}

	// Token: 0x06009823 RID: 38947 RVA: 0x002D16E8 File Offset: 0x002CF8E8
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

	// Token: 0x04005B37 RID: 23351
	private readonly Dictionary<int, bool> ChallengeAnonymousMap = new Dictionary<int, bool>();

	// Token: 0x04005B38 RID: 23352
	private readonly Dictionary<int, List<global::AbyssChallengeInfo>> AllMultiPassDataMap = new Dictionary<int, List<global::AbyssChallengeInfo>>();

	// Token: 0x04005B39 RID: 23353
	private readonly Dictionary<int, global::AbyssChallengeInfo> AllOwnSinglePassDataMap = new Dictionary<int, global::AbyssChallengeInfo>();

	// Token: 0x04005B3A RID: 23354
	private readonly Dictionary<int, List<global::AbyssChallengeInfo>> AllSinglePassDataMap = new Dictionary<int, List<global::AbyssChallengeInfo>>();

	// Token: 0x04005B3B RID: 23355
	private readonly Dictionary<int, global::AbyssChallengeInfo> AllOwnMultiPassData = new Dictionary<int, global::AbyssChallengeInfo>();

	// Token: 0x04005B3C RID: 23356
	private readonly List<global::AbyssChallengeInfo> SinglePassDataList = new List<global::AbyssChallengeInfo>();

	// Token: 0x04005B3D RID: 23357
	private readonly List<global::AbyssChallengeInfo> MultiPassDataList = new List<global::AbyssChallengeInfo>();

	// Token: 0x04005B3E RID: 23358
	private global::AbyssChallengeInfo[] FriendRankList = Array.Empty<global::AbyssChallengeInfo>();

	// Token: 0x04005B3F RID: 23359
	private global::AbyssChallengeInfo[] SelfRankInfo = Array.Empty<global::AbyssChallengeInfo>();

	// Token: 0x04005B40 RID: 23360
	private global::AbyssChallengeInfo OwnSinglePassData;

	// Token: 0x04005B41 RID: 23361
	private global::AbyssChallengeInfo OwnMultiPassData;
}

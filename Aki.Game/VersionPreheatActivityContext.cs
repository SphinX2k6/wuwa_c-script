using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000A0E RID: 2574
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatActivityContext : ActivityBaseData
{
	// Token: 0x06007063 RID: 28771 RVA: 0x00227908 File Offset: 0x00225B08
	protected override void PhraseEx(ActivityData data)
	{
		PreheatSignActivityInfo preheatSignActivityInfo = data.PreheatSignActivityInfo;
		if (preheatSignActivityInfo == null)
		{
			return;
		}
		this.QuestCacheInternal.Clear();
		foreach (PreheatSignNodeInfo preheatSignNodeInfo in preheatSignActivityInfo.PreheatSignNodeInfos)
		{
			VersionPreheatQuestInfoCache value = new VersionPreheatQuestInfoCache
			{
				Meta = preheatSignNodeInfo,
				Id = preheatSignNodeInfo.PreheatNodeId,
				UnlockTimestamp = preheatSignNodeInfo.UnlockTime,
				Rewarded = preheatSignNodeInfo.Rewarded
			};
			this.QuestCacheInternal[preheatSignNodeInfo.PreheatNodeId] = value;
		}
	}

	// Token: 0x06007064 RID: 28772 RVA: 0x002279A8 File Offset: 0x00225BA8
	public override bool GetExDataRedPointShowState()
	{
		return VersionPreheatModel.Instance.HasNewQuest;
	}

	// Token: 0x06007065 RID: 28773 RVA: 0x002279B4 File Offset: 0x00225BB4
	public void Dispose()
	{
	}

	// Token: 0x06007066 RID: 28774 RVA: 0x002279B6 File Offset: 0x00225BB6
	public void SyncPreheatSignSurveyInfo(int id, PreheatSignSurveyInfo info)
	{
		this.SurveyInfoCache[id] = info;
	}

	// Token: 0x06007067 RID: 28775 RVA: 0x002279C8 File Offset: 0x00225BC8
	public void SyncPreheatRewardedState(int id)
	{
		VersionPreheatQuestInfoCache versionPreheatQuestInfoCache;
		if (this.QuestCacheInternal.TryGetValue(id, out versionPreheatQuestInfoCache))
		{
			versionPreheatQuestInfoCache.Rewarded = true;
		}
	}

	// Token: 0x06007068 RID: 28776 RVA: 0x002279EC File Offset: 0x00225BEC
	public long GetVoteLeftCountById(int id)
	{
		PreheatSignSurveyInfo preheatSignSurveyInfo;
		if (this.SurveyInfoCache.TryGetValue(id, out preheatSignSurveyInfo))
		{
			return preheatSignSurveyInfo.SupportNum;
		}
		return 0L;
	}

	// Token: 0x06007069 RID: 28777 RVA: 0x00227A14 File Offset: 0x00225C14
	public long GetVoteRightCountById(int id)
	{
		PreheatSignSurveyInfo preheatSignSurveyInfo;
		if (this.SurveyInfoCache.TryGetValue(id, out preheatSignSurveyInfo))
		{
			return preheatSignSurveyInfo.OpposeNum;
		}
		return 0L;
	}

	// Token: 0x0600706A RID: 28778 RVA: 0x00227A3C File Offset: 0x00225C3C
	public bool IsRewardedById(int id)
	{
		VersionPreheatQuestInfoCache versionPreheatQuestInfoCache;
		return this.QuestCacheInternal.TryGetValue(id, out versionPreheatQuestInfoCache) && versionPreheatQuestInfoCache.Rewarded;
	}

	// Token: 0x0600706B RID: 28779 RVA: 0x00227A64 File Offset: 0x00225C64
	public bool? IsLeftChosen(int id)
	{
		PreheatSignSurveyInfo preheatSignSurveyInfo;
		if (this.SurveyInfoCache.TryGetValue(id, out preheatSignSurveyInfo))
		{
			return new bool?(preheatSignSurveyInfo.AnswerStatus);
		}
		return null;
	}

	// Token: 0x17000D8A RID: 3466
	// (get) Token: 0x0600706C RID: 28780 RVA: 0x00227A96 File Offset: 0x00225C96
	public Dictionary<int, VersionPreheatQuestInfoCache> QuestCache
	{
		get
		{
			return this.QuestCacheInternal;
		}
	}

	// Token: 0x04004528 RID: 17704
	private readonly Dictionary<int, PreheatSignSurveyInfo> SurveyInfoCache = new Dictionary<int, PreheatSignSurveyInfo>();

	// Token: 0x04004529 RID: 17705
	private readonly Dictionary<int, VersionPreheatQuestInfoCache> QuestCacheInternal = new Dictionary<int, VersionPreheatQuestInfoCache>();
}

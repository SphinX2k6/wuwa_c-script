using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001556 RID: 5462
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatActivityContext : ActivityBaseData
{
	// Token: 0x06009C85 RID: 40069 RVA: 0x0021DB58 File Offset: 0x0021BD58
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

	// Token: 0x06009C86 RID: 40070 RVA: 0x0021DBF8 File Offset: 0x0021BDF8
	public override bool GetExDataRedPointShowState()
	{
		return VersionPreheatModel.Instance.HasNewQuest;
	}

	// Token: 0x06009C87 RID: 40071 RVA: 0x0021DC04 File Offset: 0x0021BE04
	public void Dispose()
	{
	}

	// Token: 0x06009C88 RID: 40072 RVA: 0x0021DC06 File Offset: 0x0021BE06
	public void SyncPreheatSignSurveyInfo(int id, PreheatSignSurveyInfo info)
	{
		this.SurveyInfoCache[id] = info;
	}

	// Token: 0x06009C89 RID: 40073 RVA: 0x0021DC18 File Offset: 0x0021BE18
	public void SyncPreheatRewardedState(int id)
	{
		VersionPreheatQuestInfoCache versionPreheatQuestInfoCache;
		if (this.QuestCacheInternal.TryGetValue(id, out versionPreheatQuestInfoCache))
		{
			versionPreheatQuestInfoCache.Rewarded = true;
		}
	}

	// Token: 0x06009C8A RID: 40074 RVA: 0x0021DC3C File Offset: 0x0021BE3C
	public long GetVoteLeftCountById(int id)
	{
		PreheatSignSurveyInfo preheatSignSurveyInfo;
		if (this.SurveyInfoCache.TryGetValue(id, out preheatSignSurveyInfo))
		{
			return preheatSignSurveyInfo.SupportNum;
		}
		return 0L;
	}

	// Token: 0x06009C8B RID: 40075 RVA: 0x0021DC64 File Offset: 0x0021BE64
	public long GetVoteRightCountById(int id)
	{
		PreheatSignSurveyInfo preheatSignSurveyInfo;
		if (this.SurveyInfoCache.TryGetValue(id, out preheatSignSurveyInfo))
		{
			return preheatSignSurveyInfo.OpposeNum;
		}
		return 0L;
	}

	// Token: 0x06009C8C RID: 40076 RVA: 0x0021DC8C File Offset: 0x0021BE8C
	public bool IsRewardedById(int id)
	{
		VersionPreheatQuestInfoCache versionPreheatQuestInfoCache;
		return this.QuestCacheInternal.TryGetValue(id, out versionPreheatQuestInfoCache) && versionPreheatQuestInfoCache.Rewarded;
	}

	// Token: 0x06009C8D RID: 40077 RVA: 0x0021DCB4 File Offset: 0x0021BEB4
	public bool? IsLeftChosen(int id)
	{
		PreheatSignSurveyInfo preheatSignSurveyInfo;
		if (this.SurveyInfoCache.TryGetValue(id, out preheatSignSurveyInfo))
		{
			return new bool?(preheatSignSurveyInfo.AnswerStatus);
		}
		return null;
	}

	// Token: 0x17000D69 RID: 3433
	// (get) Token: 0x06009C8E RID: 40078 RVA: 0x0021DCE6 File Offset: 0x0021BEE6
	public Dictionary<int, VersionPreheatQuestInfoCache> QuestCache
	{
		get
		{
			return this.QuestCacheInternal;
		}
	}

	// Token: 0x04004482 RID: 17538
	private readonly Dictionary<int, PreheatSignSurveyInfo> SurveyInfoCache = new Dictionary<int, PreheatSignSurveyInfo>();

	// Token: 0x04004483 RID: 17539
	private readonly Dictionary<int, VersionPreheatQuestInfoCache> QuestCacheInternal = new Dictionary<int, VersionPreheatQuestInfoCache>();
}

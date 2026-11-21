using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02001B56 RID: 6998
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewEntryData
{
	// Token: 0x06011723 RID: 71459 RVA: 0x00525EE2 File Offset: 0x005240E2
	public QuestReviewEntryData(QuestReviewEntry config)
	{
	}

	// Token: 0x170019E0 RID: 6624
	// (get) Token: 0x06011724 RID: 71460 RVA: 0x00525EF1 File Offset: 0x005240F1
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019E1 RID: 6625
	// (get) Token: 0x06011725 RID: 71461 RVA: 0x00525EFE File Offset: 0x005240FE
	public IReadOnlyList<int> Tabs
	{
		get
		{
			return this.Config.QuestTabs();
		}
	}

	// Token: 0x170019E2 RID: 6626
	// (get) Token: 0x06011726 RID: 71462 RVA: 0x00525F0B File Offset: 0x0052410B
	public int TargetTab
	{
		get
		{
			return this.Config.TargetTab;
		}
	}

	// Token: 0x170019E3 RID: 6627
	// (get) Token: 0x06011727 RID: 71463 RVA: 0x00525F18 File Offset: 0x00524118
	public IReadOnlyList<int> RelatedQuestId
	{
		get
		{
			return this.Config.RelatedQuest();
		}
	}

	// Token: 0x170019E4 RID: 6628
	// (get) Token: 0x06011728 RID: 71464 RVA: 0x00525F25 File Offset: 0x00524125
	public bool ShouldShow
	{
		get
		{
			return this.ShouldShowInternal;
		}
	}

	// Token: 0x170019E5 RID: 6629
	// (get) Token: 0x06011729 RID: 71465 RVA: 0x00525F2D File Offset: 0x0052412D
	public float TimerDurationMs
	{
		get
		{
			return (float)(this.Config.TimerDuration * TimeUtil.Instance.InverseMillisecond);
		}
	}

	// Token: 0x170019E6 RID: 6630
	// (get) Token: 0x0601172A RID: 71466 RVA: 0x00525F48 File Offset: 0x00524148
	// (set) Token: 0x0601172B RID: 71467 RVA: 0x00525F71 File Offset: 0x00524171
	public bool IsFirstEntry
	{
		get
		{
			return LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.QuestReviewMainViewEntryAnim, null).GetValueOrDefault(true);
		}
		set
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewMainViewEntryAnim, value);
		}
	}

	// Token: 0x0601172C RID: 71468 RVA: 0x00525F7F File Offset: 0x0052417F
	public void UpdateByServerData(QuestReviewEntryInfo data)
	{
		this.ShouldShowInternal = (data.ShowCondition && !data.HideCondition);
	}

	// Token: 0x0400991A RID: 39194
	private bool ShouldShowInternal;

	// Token: 0x0400991B RID: 39195
	private QuestReviewEntry Config = config;
}

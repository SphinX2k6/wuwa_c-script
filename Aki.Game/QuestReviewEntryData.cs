using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x0200266B RID: 9835
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewEntryData
{
	// Token: 0x06014241 RID: 82497 RVA: 0x0051718A File Offset: 0x0051538A
	public QuestReviewEntryData(QuestReviewEntry config)
	{
	}

	// Token: 0x170019A8 RID: 6568
	// (get) Token: 0x06014242 RID: 82498 RVA: 0x00517199 File Offset: 0x00515399
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019A9 RID: 6569
	// (get) Token: 0x06014243 RID: 82499 RVA: 0x005171A6 File Offset: 0x005153A6
	public IReadOnlyList<int> Tabs
	{
		get
		{
			return this.Config.QuestTabs();
		}
	}

	// Token: 0x170019AA RID: 6570
	// (get) Token: 0x06014244 RID: 82500 RVA: 0x005171B3 File Offset: 0x005153B3
	public int TargetTab
	{
		get
		{
			return this.Config.TargetTab;
		}
	}

	// Token: 0x170019AB RID: 6571
	// (get) Token: 0x06014245 RID: 82501 RVA: 0x005171C0 File Offset: 0x005153C0
	public IReadOnlyList<int> RelatedQuestId
	{
		get
		{
			return this.Config.RelatedQuest();
		}
	}

	// Token: 0x170019AC RID: 6572
	// (get) Token: 0x06014246 RID: 82502 RVA: 0x005171CD File Offset: 0x005153CD
	public bool ShouldShow
	{
		get
		{
			return this.ShouldShowInternal;
		}
	}

	// Token: 0x170019AD RID: 6573
	// (get) Token: 0x06014247 RID: 82503 RVA: 0x005171D5 File Offset: 0x005153D5
	public float TimerDurationMs
	{
		get
		{
			return (float)(this.Config.TimerDuration * TimeUtil.Instance.InverseMillisecond);
		}
	}

	// Token: 0x170019AE RID: 6574
	// (get) Token: 0x06014248 RID: 82504 RVA: 0x005171F0 File Offset: 0x005153F0
	// (set) Token: 0x06014249 RID: 82505 RVA: 0x00517219 File Offset: 0x00515419
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

	// Token: 0x0601424A RID: 82506 RVA: 0x00517227 File Offset: 0x00515427
	public void UpdateByServerData(QuestReviewEntryInfo data)
	{
		this.ShouldShowInternal = (data.ShowCondition && !data.HideCondition);
	}

	// Token: 0x040097C2 RID: 38850
	private bool ShouldShowInternal;

	// Token: 0x040097C3 RID: 38851
	private QuestReviewEntry Config = config;
}

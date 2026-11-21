using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02001B5A RID: 7002
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeData
{
	// Token: 0x0601176E RID: 71534 RVA: 0x00526339 File Offset: 0x00524539
	public QuestReviewNodeData(QuestReviewNode config)
	{
	}

	// Token: 0x17001A0C RID: 6668
	// (get) Token: 0x0601176F RID: 71535 RVA: 0x00526348 File Offset: 0x00524548
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001A0D RID: 6669
	// (get) Token: 0x06011770 RID: 71536 RVA: 0x00526364 File Offset: 0x00524564
	public int PosIndex
	{
		get
		{
			return this.Config.PosIndex;
		}
	}

	// Token: 0x17001A0E RID: 6670
	// (get) Token: 0x06011771 RID: 71537 RVA: 0x00526380 File Offset: 0x00524580
	public int QuestLine
	{
		get
		{
			return this.Config.QuestLine;
		}
	}

	// Token: 0x17001A0F RID: 6671
	// (get) Token: 0x06011772 RID: 71538 RVA: 0x0052639C File Offset: 0x0052459C
	public int Successor
	{
		get
		{
			return this.Config.SuccessorNodeId;
		}
	}

	// Token: 0x17001A10 RID: 6672
	// (get) Token: 0x06011773 RID: 71539 RVA: 0x005263B8 File Offset: 0x005245B8
	public string TitleId
	{
		get
		{
			return this.Config.Title;
		}
	}

	// Token: 0x17001A11 RID: 6673
	// (get) Token: 0x06011774 RID: 71540 RVA: 0x005263D4 File Offset: 0x005245D4
	public string Desc
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x17001A12 RID: 6674
	// (get) Token: 0x06011775 RID: 71541 RVA: 0x005263F0 File Offset: 0x005245F0
	public string Brief
	{
		get
		{
			return this.Config.Brief;
		}
	}

	// Token: 0x17001A13 RID: 6675
	// (get) Token: 0x06011776 RID: 71542 RVA: 0x0052640C File Offset: 0x0052460C
	public string ImageSmall
	{
		get
		{
			return this.ImageGetter(this.Config.ImageSmallMale, this.Config.ImageSmallFemale);
		}
	}

	// Token: 0x17001A14 RID: 6676
	// (get) Token: 0x06011777 RID: 71543 RVA: 0x0052643C File Offset: 0x0052463C
	public string ImageLarge
	{
		get
		{
			return this.ImageGetter(this.Config.ImageLargeMale, this.Config.ImageLargeFemale);
		}
	}

	// Token: 0x17001A15 RID: 6677
	// (get) Token: 0x06011778 RID: 71544 RVA: 0x0052646C File Offset: 0x0052466C
	public bool ShowOnceUnlock
	{
		get
		{
			return this.Config.ShowOnceUnlock;
		}
	}

	// Token: 0x17001A16 RID: 6678
	// (get) Token: 0x06011779 RID: 71545 RVA: 0x00526487 File Offset: 0x00524687
	// (set) Token: 0x0601177A RID: 71546 RVA: 0x0052648F File Offset: 0x0052468F
	public EQuestReviewNodeState State { get; private set; }

	// Token: 0x17001A17 RID: 6679
	// (get) Token: 0x0601177B RID: 71547 RVA: 0x00526498 File Offset: 0x00524698
	public EQuestReviewNodeLineType LineType
	{
		get
		{
			return EQuestReviewNodeLineType.Solid;
		}
	}

	// Token: 0x17001A18 RID: 6680
	// (get) Token: 0x0601177C RID: 71548 RVA: 0x0052649C File Offset: 0x0052469C
	public bool IsBranching
	{
		get
		{
			QuestReviewNodeData questReviewNodeDataById = QuestReviewModel.Instance.GetQuestReviewNodeDataById(this.Successor);
			return questReviewNodeDataById != null && this.QuestLine != questReviewNodeDataById.QuestLine;
		}
	}

	// Token: 0x17001A19 RID: 6681
	// (get) Token: 0x0601177D RID: 71549 RVA: 0x005264D0 File Offset: 0x005246D0
	// (set) Token: 0x0601177E RID: 71550 RVA: 0x005264D8 File Offset: 0x005246D8
	public int Predecessor { get; set; }

	// Token: 0x17001A1A RID: 6682
	// (get) Token: 0x0601177F RID: 71551 RVA: 0x005264E4 File Offset: 0x005246E4
	// (set) Token: 0x06011780 RID: 71552 RVA: 0x00526514 File Offset: 0x00524714
	public bool IsFirstTimeShow
	{
		get
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewNodeUnlockAnim, null);
			bool flag;
			return player == null || !player.TryGetValue(this.Id, out flag) || flag;
		}
		set
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewNodeUnlockAnim, null);
			if (dictionary == null)
			{
				dictionary = new Dictionary<int, bool>();
			}
			dictionary[this.Id] = value;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewNodeUnlockAnim, dictionary);
		}
	}

	// Token: 0x17001A1B RID: 6683
	// (get) Token: 0x06011781 RID: 71553 RVA: 0x00526550 File Offset: 0x00524750
	// (set) Token: 0x06011782 RID: 71554 RVA: 0x00526580 File Offset: 0x00524780
	public bool HasRedDot
	{
		get
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewNodeRedDot, null);
			bool flag;
			return player == null || !player.TryGetValue(this.Id, out flag) || flag;
		}
		set
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewNodeRedDot, null);
			if (dictionary == null)
			{
				dictionary = new Dictionary<int, bool>();
			}
			dictionary[this.Id] = value;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewNodeRedDot, dictionary);
		}
	}

	// Token: 0x06011783 RID: 71555 RVA: 0x005265BB File Offset: 0x005247BB
	public void UpdateByServerData(QuestReviewNodeInfo data)
	{
		if (data.FinishCondition)
		{
			this.State = EQuestReviewNodeState.Finished;
			return;
		}
		if (data.InProgressCondition)
		{
			this.State = EQuestReviewNodeState.InProgress;
			return;
		}
		if (data.UnlockCondition)
		{
			this.State = EQuestReviewNodeState.Unlocked;
			return;
		}
		this.State = EQuestReviewNodeState.Locked;
	}

	// Token: 0x06011784 RID: 71556 RVA: 0x005265F4 File Offset: 0x005247F4
	private string ImageGetter(string imageMale, string imageFemale)
	{
		if (string.IsNullOrEmpty(imageMale))
		{
			return imageFemale;
		}
		if (string.IsNullOrEmpty(imageFemale))
		{
			return imageMale;
		}
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (playerGender == EPlayerGender.Male)
		{
			return imageMale;
		}
		if (playerGender == EPlayerGender.Female)
		{
			return imageFemale;
		}
		return string.Empty;
	}

	// Token: 0x0400992A RID: 39210
	private readonly QuestReviewNode Config = config;
}

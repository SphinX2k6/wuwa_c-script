using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x0200266F RID: 9839
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeData
{
	// Token: 0x0601428C RID: 82572 RVA: 0x005175E1 File Offset: 0x005157E1
	public QuestReviewNodeData(QuestReviewNode config)
	{
	}

	// Token: 0x170019D4 RID: 6612
	// (get) Token: 0x0601428D RID: 82573 RVA: 0x005175F0 File Offset: 0x005157F0
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019D5 RID: 6613
	// (get) Token: 0x0601428E RID: 82574 RVA: 0x0051760C File Offset: 0x0051580C
	public int PosIndex
	{
		get
		{
			return this.Config.PosIndex;
		}
	}

	// Token: 0x170019D6 RID: 6614
	// (get) Token: 0x0601428F RID: 82575 RVA: 0x00517628 File Offset: 0x00515828
	public int QuestLine
	{
		get
		{
			return this.Config.QuestLine;
		}
	}

	// Token: 0x170019D7 RID: 6615
	// (get) Token: 0x06014290 RID: 82576 RVA: 0x00517644 File Offset: 0x00515844
	public int Successor
	{
		get
		{
			return this.Config.SuccessorNodeId;
		}
	}

	// Token: 0x170019D8 RID: 6616
	// (get) Token: 0x06014291 RID: 82577 RVA: 0x00517660 File Offset: 0x00515860
	public string TitleId
	{
		get
		{
			return this.Config.Title;
		}
	}

	// Token: 0x170019D9 RID: 6617
	// (get) Token: 0x06014292 RID: 82578 RVA: 0x0051767C File Offset: 0x0051587C
	public string Desc
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x170019DA RID: 6618
	// (get) Token: 0x06014293 RID: 82579 RVA: 0x00517698 File Offset: 0x00515898
	public string Brief
	{
		get
		{
			return this.Config.Brief;
		}
	}

	// Token: 0x170019DB RID: 6619
	// (get) Token: 0x06014294 RID: 82580 RVA: 0x005176B4 File Offset: 0x005158B4
	public string ImageSmall
	{
		get
		{
			return this.ImageGetter(this.Config.ImageSmallMale, this.Config.ImageSmallFemale);
		}
	}

	// Token: 0x170019DC RID: 6620
	// (get) Token: 0x06014295 RID: 82581 RVA: 0x005176E4 File Offset: 0x005158E4
	public string ImageLarge
	{
		get
		{
			return this.ImageGetter(this.Config.ImageLargeMale, this.Config.ImageLargeFemale);
		}
	}

	// Token: 0x170019DD RID: 6621
	// (get) Token: 0x06014296 RID: 82582 RVA: 0x00517714 File Offset: 0x00515914
	public bool ShowOnceUnlock
	{
		get
		{
			return this.Config.ShowOnceUnlock;
		}
	}

	// Token: 0x170019DE RID: 6622
	// (get) Token: 0x06014297 RID: 82583 RVA: 0x0051772F File Offset: 0x0051592F
	// (set) Token: 0x06014298 RID: 82584 RVA: 0x00517737 File Offset: 0x00515937
	public EQuestReviewNodeState State { get; private set; }

	// Token: 0x170019DF RID: 6623
	// (get) Token: 0x06014299 RID: 82585 RVA: 0x00517740 File Offset: 0x00515940
	public EQuestReviewNodeLineType LineType
	{
		get
		{
			return EQuestReviewNodeLineType.Solid;
		}
	}

	// Token: 0x170019E0 RID: 6624
	// (get) Token: 0x0601429A RID: 82586 RVA: 0x00517744 File Offset: 0x00515944
	public bool IsBranching
	{
		get
		{
			QuestReviewNodeData questReviewNodeDataById = QuestReviewModel.Instance.GetQuestReviewNodeDataById(this.Successor);
			return questReviewNodeDataById != null && this.QuestLine != questReviewNodeDataById.QuestLine;
		}
	}

	// Token: 0x170019E1 RID: 6625
	// (get) Token: 0x0601429B RID: 82587 RVA: 0x00517778 File Offset: 0x00515978
	// (set) Token: 0x0601429C RID: 82588 RVA: 0x00517780 File Offset: 0x00515980
	public int Predecessor { get; set; }

	// Token: 0x170019E2 RID: 6626
	// (get) Token: 0x0601429D RID: 82589 RVA: 0x0051778C File Offset: 0x0051598C
	// (set) Token: 0x0601429E RID: 82590 RVA: 0x005177BC File Offset: 0x005159BC
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

	// Token: 0x170019E3 RID: 6627
	// (get) Token: 0x0601429F RID: 82591 RVA: 0x005177F8 File Offset: 0x005159F8
	// (set) Token: 0x060142A0 RID: 82592 RVA: 0x00517828 File Offset: 0x00515A28
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

	// Token: 0x060142A1 RID: 82593 RVA: 0x00517863 File Offset: 0x00515A63
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

	// Token: 0x060142A2 RID: 82594 RVA: 0x0051789C File Offset: 0x00515A9C
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

	// Token: 0x040097D2 RID: 38866
	private readonly QuestReviewNode Config = config;
}

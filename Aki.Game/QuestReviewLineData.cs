using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02001B57 RID: 6999
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewLineData
{
	// Token: 0x0601172D RID: 71469 RVA: 0x00525F9B File Offset: 0x0052419B
	public QuestReviewLineData(QuestReviewLine config)
	{
	}

	// Token: 0x170019E7 RID: 6631
	// (get) Token: 0x0601172E RID: 71470 RVA: 0x00525FB4 File Offset: 0x005241B4
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019E8 RID: 6632
	// (get) Token: 0x0601172F RID: 71471 RVA: 0x00525FD0 File Offset: 0x005241D0
	public int DisplayOrder
	{
		get
		{
			return this.Config.DisplayOrder;
		}
	}

	// Token: 0x170019E9 RID: 6633
	// (get) Token: 0x06011730 RID: 71472 RVA: 0x00525FEC File Offset: 0x005241EC
	public int StartNode
	{
		get
		{
			return this.Config.StartNodeId;
		}
	}

	// Token: 0x170019EA RID: 6634
	// (get) Token: 0x06011731 RID: 71473 RVA: 0x00526008 File Offset: 0x00524208
	public string LineColorHex
	{
		get
		{
			return "#" + this.Config.LineColor;
		}
	}

	// Token: 0x170019EB RID: 6635
	// (get) Token: 0x06011732 RID: 71474 RVA: 0x00526030 File Offset: 0x00524230
	public string StarIcon
	{
		get
		{
			return this.Config.StarIcon;
		}
	}

	// Token: 0x170019EC RID: 6636
	// (get) Token: 0x06011733 RID: 71475 RVA: 0x0052604C File Offset: 0x0052424C
	public string RoundIcon
	{
		get
		{
			return this.Config.RoundIcon;
		}
	}

	// Token: 0x170019ED RID: 6637
	// (get) Token: 0x06011734 RID: 71476 RVA: 0x00526068 File Offset: 0x00524268
	public string ShowSeqName
	{
		get
		{
			return this.Config.ShowSeqName;
		}
	}

	// Token: 0x170019EE RID: 6638
	// (get) Token: 0x06011735 RID: 71477 RVA: 0x00526084 File Offset: 0x00524284
	public string DestroySeqName
	{
		get
		{
			return this.Config.DestroySeqName;
		}
	}

	// Token: 0x170019EF RID: 6639
	// (get) Token: 0x06011736 RID: 71478 RVA: 0x005260A0 File Offset: 0x005242A0
	public string NodeFirstActivateSeqName
	{
		get
		{
			string result;
			switch (this.DisplayOrder)
			{
			case 1:
				result = "FristActivate";
				break;
			case 2:
				result = "FristActivate2";
				break;
			case 3:
				result = "FristActivate3";
				break;
			default:
				result = "FristActivate";
				break;
			}
			return result;
		}
	}

	// Token: 0x170019F0 RID: 6640
	// (get) Token: 0x06011737 RID: 71479 RVA: 0x005260E9 File Offset: 0x005242E9
	// (set) Token: 0x06011738 RID: 71480 RVA: 0x005260F1 File Offset: 0x005242F1
	public EQuestReviewLineState State { get; private set; } = EQuestReviewLineState.Show;

	// Token: 0x170019F1 RID: 6641
	// (get) Token: 0x06011739 RID: 71481 RVA: 0x005260FA File Offset: 0x005242FA
	public bool IsShow
	{
		get
		{
			if (this.Id == 3200)
			{
				return this.HasFused;
			}
			return this.State > EQuestReviewLineState.Hide;
		}
	}

	// Token: 0x170019F2 RID: 6642
	// (get) Token: 0x0601173A RID: 71482 RVA: 0x0052611C File Offset: 0x0052431C
	// (set) Token: 0x0601173B RID: 71483 RVA: 0x0052614C File Offset: 0x0052434C
	public bool IsFirstTimeShow
	{
		get
		{
			bool result = true;
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewLineUnlockAnim, null);
			if (player != null)
			{
				player.TryGetValue(this.Id, out result);
			}
			return result;
		}
		set
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewLineUnlockAnim, null) ?? new Dictionary<int, bool>();
			dictionary[this.Id] = value;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewLineUnlockAnim, dictionary);
		}
	}

	// Token: 0x170019F3 RID: 6643
	// (get) Token: 0x0601173C RID: 71484 RVA: 0x00526187 File Offset: 0x00524387
	public bool IsDestroy
	{
		get
		{
			return this.State == EQuestReviewLineState.Destroy;
		}
	}

	// Token: 0x170019F4 RID: 6644
	// (get) Token: 0x0601173D RID: 71485 RVA: 0x00526194 File Offset: 0x00524394
	// (set) Token: 0x0601173E RID: 71486 RVA: 0x005261C4 File Offset: 0x005243C4
	public bool IsFirstTimeDestroy
	{
		get
		{
			bool result = true;
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewLineDestroyAnim, null);
			if (player != null)
			{
				player.TryGetValue(this.Id, out result);
			}
			return result;
		}
		set
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewLineDestroyAnim, null) ?? new Dictionary<int, bool>();
			dictionary[this.Id] = value;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewLineDestroyAnim, dictionary);
		}
	}

	// Token: 0x170019F5 RID: 6645
	// (get) Token: 0x0601173F RID: 71487 RVA: 0x005261FF File Offset: 0x005243FF
	public bool IsFusionLine
	{
		get
		{
			return this.DestroySeqName == "Change";
		}
	}

	// Token: 0x170019F6 RID: 6646
	// (get) Token: 0x06011740 RID: 71488 RVA: 0x00526211 File Offset: 0x00524411
	// (set) Token: 0x06011741 RID: 71489 RVA: 0x00526219 File Offset: 0x00524419
	public bool IsTempLine { get; set; }

	// Token: 0x170019F7 RID: 6647
	// (get) Token: 0x06011742 RID: 71490 RVA: 0x00526222 File Offset: 0x00524422
	// (set) Token: 0x06011743 RID: 71491 RVA: 0x0052622F File Offset: 0x0052442F
	public bool HasFused
	{
		get
		{
			return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewNewLineHasFused, false);
		}
		set
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewNewLineHasFused, value);
		}
	}

	// Token: 0x06011744 RID: 71492 RVA: 0x0052623D File Offset: 0x0052443D
	public void UpdateByServerData(QuestReviewLineInfo data)
	{
		if (data.DestroyCondition)
		{
			this.State = EQuestReviewLineState.Destroy;
			return;
		}
		if (data.ShowCondition)
		{
			this.State = EQuestReviewLineState.Show;
			return;
		}
		this.State = EQuestReviewLineState.Hide;
	}

	// Token: 0x0400991C RID: 39196
	public bool SkipAnim;

	// Token: 0x0400991D RID: 39197
	private readonly QuestReviewLine Config = config;
}

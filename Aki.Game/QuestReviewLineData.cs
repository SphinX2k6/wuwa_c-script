using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x0200266C RID: 9836
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewLineData
{
	// Token: 0x0601424B RID: 82507 RVA: 0x00517243 File Offset: 0x00515443
	public QuestReviewLineData(QuestReviewLine config)
	{
	}

	// Token: 0x170019AF RID: 6575
	// (get) Token: 0x0601424C RID: 82508 RVA: 0x0051725C File Offset: 0x0051545C
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019B0 RID: 6576
	// (get) Token: 0x0601424D RID: 82509 RVA: 0x00517278 File Offset: 0x00515478
	public int DisplayOrder
	{
		get
		{
			return this.Config.DisplayOrder;
		}
	}

	// Token: 0x170019B1 RID: 6577
	// (get) Token: 0x0601424E RID: 82510 RVA: 0x00517294 File Offset: 0x00515494
	public int StartNode
	{
		get
		{
			return this.Config.StartNodeId;
		}
	}

	// Token: 0x170019B2 RID: 6578
	// (get) Token: 0x0601424F RID: 82511 RVA: 0x005172B0 File Offset: 0x005154B0
	public string LineColorHex
	{
		get
		{
			return "#" + this.Config.LineColor;
		}
	}

	// Token: 0x170019B3 RID: 6579
	// (get) Token: 0x06014250 RID: 82512 RVA: 0x005172D8 File Offset: 0x005154D8
	public string StarIcon
	{
		get
		{
			return this.Config.StarIcon;
		}
	}

	// Token: 0x170019B4 RID: 6580
	// (get) Token: 0x06014251 RID: 82513 RVA: 0x005172F4 File Offset: 0x005154F4
	public string RoundIcon
	{
		get
		{
			return this.Config.RoundIcon;
		}
	}

	// Token: 0x170019B5 RID: 6581
	// (get) Token: 0x06014252 RID: 82514 RVA: 0x00517310 File Offset: 0x00515510
	public string ShowSeqName
	{
		get
		{
			return this.Config.ShowSeqName;
		}
	}

	// Token: 0x170019B6 RID: 6582
	// (get) Token: 0x06014253 RID: 82515 RVA: 0x0051732C File Offset: 0x0051552C
	public string DestroySeqName
	{
		get
		{
			return this.Config.DestroySeqName;
		}
	}

	// Token: 0x170019B7 RID: 6583
	// (get) Token: 0x06014254 RID: 82516 RVA: 0x00517348 File Offset: 0x00515548
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

	// Token: 0x170019B8 RID: 6584
	// (get) Token: 0x06014255 RID: 82517 RVA: 0x00517391 File Offset: 0x00515591
	// (set) Token: 0x06014256 RID: 82518 RVA: 0x00517399 File Offset: 0x00515599
	public EQuestReviewLineState State { get; private set; } = EQuestReviewLineState.Show;

	// Token: 0x170019B9 RID: 6585
	// (get) Token: 0x06014257 RID: 82519 RVA: 0x005173A2 File Offset: 0x005155A2
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

	// Token: 0x170019BA RID: 6586
	// (get) Token: 0x06014258 RID: 82520 RVA: 0x005173C4 File Offset: 0x005155C4
	// (set) Token: 0x06014259 RID: 82521 RVA: 0x005173F4 File Offset: 0x005155F4
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

	// Token: 0x170019BB RID: 6587
	// (get) Token: 0x0601425A RID: 82522 RVA: 0x0051742F File Offset: 0x0051562F
	public bool IsDestroy
	{
		get
		{
			return this.State == EQuestReviewLineState.Destroy;
		}
	}

	// Token: 0x170019BC RID: 6588
	// (get) Token: 0x0601425B RID: 82523 RVA: 0x0051743C File Offset: 0x0051563C
	// (set) Token: 0x0601425C RID: 82524 RVA: 0x0051746C File Offset: 0x0051566C
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

	// Token: 0x170019BD RID: 6589
	// (get) Token: 0x0601425D RID: 82525 RVA: 0x005174A7 File Offset: 0x005156A7
	public bool IsFusionLine
	{
		get
		{
			return this.DestroySeqName == "Change";
		}
	}

	// Token: 0x170019BE RID: 6590
	// (get) Token: 0x0601425E RID: 82526 RVA: 0x005174B9 File Offset: 0x005156B9
	// (set) Token: 0x0601425F RID: 82527 RVA: 0x005174C1 File Offset: 0x005156C1
	public bool IsTempLine { get; set; }

	// Token: 0x170019BF RID: 6591
	// (get) Token: 0x06014260 RID: 82528 RVA: 0x005174CA File Offset: 0x005156CA
	// (set) Token: 0x06014261 RID: 82529 RVA: 0x005174D7 File Offset: 0x005156D7
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

	// Token: 0x06014262 RID: 82530 RVA: 0x005174E5 File Offset: 0x005156E5
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

	// Token: 0x040097C4 RID: 38852
	public bool SkipAnim;

	// Token: 0x040097C5 RID: 38853
	private readonly QuestReviewLine Config = config;
}

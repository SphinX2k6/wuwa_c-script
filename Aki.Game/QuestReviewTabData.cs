using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02001B5B RID: 7003
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewTabData
{
	// Token: 0x06011785 RID: 71557 RVA: 0x00526630 File Offset: 0x00524830
	public QuestReviewTabData(QuestReviewTab config)
	{
	}

	// Token: 0x17001A1C RID: 6684
	// (get) Token: 0x06011786 RID: 71558 RVA: 0x00526640 File Offset: 0x00524840
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001A1D RID: 6685
	// (get) Token: 0x06011787 RID: 71559 RVA: 0x0052665C File Offset: 0x0052485C
	public int QuestTree
	{
		get
		{
			return this.Config.QuestTree;
		}
	}

	// Token: 0x17001A1E RID: 6686
	// (get) Token: 0x06011788 RID: 71560 RVA: 0x00526678 File Offset: 0x00524878
	public string NameId
	{
		get
		{
			return this.Config.TabName;
		}
	}

	// Token: 0x17001A1F RID: 6687
	// (get) Token: 0x06011789 RID: 71561 RVA: 0x00526693 File Offset: 0x00524893
	public bool IsUnlocked
	{
		get
		{
			return this.IsUnlockedInternal;
		}
	}

	// Token: 0x17001A20 RID: 6688
	// (get) Token: 0x0601178A RID: 71562 RVA: 0x0052669B File Offset: 0x0052489B
	// (set) Token: 0x0601178B RID: 71563 RVA: 0x005266A3 File Offset: 0x005248A3
	public bool IsSelected { get; set; }

	// Token: 0x17001A21 RID: 6689
	// (get) Token: 0x0601178C RID: 71564 RVA: 0x005266AC File Offset: 0x005248AC
	// (set) Token: 0x0601178D RID: 71565 RVA: 0x005266DC File Offset: 0x005248DC
	public bool IsFirstTimeShow
	{
		get
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewTabUnlockAnim, null);
			bool flag;
			return player == null || !player.TryGetValue(this.Id, out flag) || flag;
		}
		set
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewTabUnlockAnim, null);
			if (dictionary == null)
			{
				dictionary = new Dictionary<int, bool>();
			}
			dictionary[this.Id] = value;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.QuestReviewTabUnlockAnim, dictionary);
		}
	}

	// Token: 0x0601178E RID: 71566 RVA: 0x00526717 File Offset: 0x00524917
	public void UpdateByServerData(QuestReviewTabInfo data)
	{
		if (data.UnlockCondition)
		{
			this.IsUnlockedInternal = true;
		}
	}

	// Token: 0x0400992D RID: 39213
	private bool IsUnlockedInternal;

	// Token: 0x0400992E RID: 39214
	private readonly QuestReviewTab Config = config;
}

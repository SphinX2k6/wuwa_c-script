using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02002670 RID: 9840
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewTabData
{
	// Token: 0x060142A3 RID: 82595 RVA: 0x005178D8 File Offset: 0x00515AD8
	public QuestReviewTabData(QuestReviewTab config)
	{
	}

	// Token: 0x170019E4 RID: 6628
	// (get) Token: 0x060142A4 RID: 82596 RVA: 0x005178E8 File Offset: 0x00515AE8
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170019E5 RID: 6629
	// (get) Token: 0x060142A5 RID: 82597 RVA: 0x00517904 File Offset: 0x00515B04
	public int QuestTree
	{
		get
		{
			return this.Config.QuestTree;
		}
	}

	// Token: 0x170019E6 RID: 6630
	// (get) Token: 0x060142A6 RID: 82598 RVA: 0x00517920 File Offset: 0x00515B20
	public string NameId
	{
		get
		{
			return this.Config.TabName;
		}
	}

	// Token: 0x170019E7 RID: 6631
	// (get) Token: 0x060142A7 RID: 82599 RVA: 0x0051793B File Offset: 0x00515B3B
	public bool IsUnlocked
	{
		get
		{
			return this.IsUnlockedInternal;
		}
	}

	// Token: 0x170019E8 RID: 6632
	// (get) Token: 0x060142A8 RID: 82600 RVA: 0x00517943 File Offset: 0x00515B43
	// (set) Token: 0x060142A9 RID: 82601 RVA: 0x0051794B File Offset: 0x00515B4B
	public bool IsSelected { get; set; }

	// Token: 0x170019E9 RID: 6633
	// (get) Token: 0x060142AA RID: 82602 RVA: 0x00517954 File Offset: 0x00515B54
	// (set) Token: 0x060142AB RID: 82603 RVA: 0x00517984 File Offset: 0x00515B84
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

	// Token: 0x060142AC RID: 82604 RVA: 0x005179BF File Offset: 0x00515BBF
	public void UpdateByServerData(QuestReviewTabInfo data)
	{
		if (data.UnlockCondition)
		{
			this.IsUnlockedInternal = true;
		}
	}

	// Token: 0x040097D5 RID: 38869
	private bool IsUnlockedInternal;

	// Token: 0x040097D6 RID: 38870
	private readonly QuestReviewTab Config = config;
}

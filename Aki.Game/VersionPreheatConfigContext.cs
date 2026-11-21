using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000A0F RID: 2575
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatConfigContext
{
	// Token: 0x0600706E RID: 28782 RVA: 0x00227ABC File Offset: 0x00225CBC
	public string GetQuestTitleTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().MainTexPath : null) ?? "";
	}

	// Token: 0x0600706F RID: 28783 RVA: 0x00227AF8 File Offset: 0x00225CF8
	public string GetQuestContentTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().QuestContent : null) ?? "";
	}

	// Token: 0x06007070 RID: 28784 RVA: 0x00227B34 File Offset: 0x00225D34
	public string GetQuestBeforeThemeTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().ThemeBefore : null) ?? "";
	}

	// Token: 0x06007071 RID: 28785 RVA: 0x00227B70 File Offset: 0x00225D70
	public string GetQuestAfterThemeTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().ThemeAfter : null) ?? "";
	}

	// Token: 0x06007072 RID: 28786 RVA: 0x00227BAC File Offset: 0x00225DAC
	public string GetQuestPhotoPathById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().DisplayTex : null) ?? "";
	}

	// Token: 0x06007073 RID: 28787 RVA: 0x00227BE8 File Offset: 0x00225DE8
	public string GetQuestSharePhotoPathById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().ShareTex : null) ?? "";
	}

	// Token: 0x06007074 RID: 28788 RVA: 0x00227C24 File Offset: 0x00225E24
	public int GetQuestCrestIndexById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().CrestIndex;
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x00227C54 File Offset: 0x00225E54
	public int GetQuestIdById(int id)
	{
		PreheatSignRe? config = ConfigPreheatSignReById.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().QuestId;
	}

	// Token: 0x06007076 RID: 28790 RVA: 0x00227C84 File Offset: 0x00225E84
	public int GetPreIdById(int id)
	{
		PreheatSignRe? config = ConfigPreheatSignReById.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().PreSignId;
	}

	// Token: 0x06007077 RID: 28791 RVA: 0x00227CB4 File Offset: 0x00225EB4
	public List<TItem> GetQuestRewardItemListById(int id)
	{
		List<TItem> list = new List<TItem>();
		PreheatSignRe? config = ConfigPreheatSignReById.GetConfig(id, true);
		if (config == null)
		{
			return list;
		}
		DropPackage? config2 = ConfigDropPackageById.GetConfig(config.Value.DropId, true);
		if (config2 == null)
		{
			return list;
		}
		for (int i = 0; i < config2.Value.DropPreviewLength; i++)
		{
			DicIntInt? dicIntInt = config2.Value.DropPreview(i);
			int key = dicIntInt.Value.Key;
			int value = dicIntInt.Value.Value;
			list.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value));
		}
		return list;
	}

	// Token: 0x06007078 RID: 28792 RVA: 0x00227D68 File Offset: 0x00225F68
	public string GetVoteTitleTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Title : null) ?? "";
	}

	// Token: 0x06007079 RID: 28793 RVA: 0x00227DA4 File Offset: 0x00225FA4
	public string GetVoteContentTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Content : null) ?? "";
	}

	// Token: 0x0600707A RID: 28794 RVA: 0x00227DE0 File Offset: 0x00225FE0
	public string GetVoteLeftThemeTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().OptionTheme1 : null) ?? "";
	}

	// Token: 0x0600707B RID: 28795 RVA: 0x00227E1C File Offset: 0x0022601C
	public string GetVoteRightThemeTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().OptionTheme2 : null) ?? "";
	}

	// Token: 0x0600707C RID: 28796 RVA: 0x00227E58 File Offset: 0x00226058
	public string GetVoteLeftTipsTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Option1 : null) ?? "";
	}

	// Token: 0x0600707D RID: 28797 RVA: 0x00227E94 File Offset: 0x00226094
	public string GetVoteRightTipsTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Option2 : null) ?? "";
	}

	// Token: 0x0600707E RID: 28798 RVA: 0x00227ED0 File Offset: 0x002260D0
	public string GetNpcContentTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().NpcContent : null) ?? "";
	}

	// Token: 0x0600707F RID: 28799 RVA: 0x00227F0C File Offset: 0x0022610C
	public string GetNpcIconPathById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().NpcIconPath : null) ?? "";
	}

	// Token: 0x06007080 RID: 28800 RVA: 0x00227F48 File Offset: 0x00226148
	public string GetSelfChatContentTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().OptionContent1 : null) ?? "";
	}

	// Token: 0x17000D8B RID: 3467
	// (get) Token: 0x06007081 RID: 28801 RVA: 0x00227F84 File Offset: 0x00226184
	public string BonusPhotoPath
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().Photo : null) ?? "";
		}
	}

	// Token: 0x17000D8C RID: 3468
	// (get) Token: 0x06007082 RID: 28802 RVA: 0x00227FC0 File Offset: 0x002261C0
	public string BonusSharePhotoPath
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().SharePhoto : null) ?? "";
		}
	}

	// Token: 0x17000D8D RID: 3469
	// (get) Token: 0x06007083 RID: 28803 RVA: 0x00227FFC File Offset: 0x002261FC
	public string BonusQuestTitleTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().Title : null) ?? "";
		}
	}

	// Token: 0x17000D8E RID: 3470
	// (get) Token: 0x06007084 RID: 28804 RVA: 0x00228038 File Offset: 0x00226238
	public string BonusQuestContentTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().Content : null) ?? "";
		}
	}

	// Token: 0x17000D8F RID: 3471
	// (get) Token: 0x06007085 RID: 28805 RVA: 0x00228074 File Offset: 0x00226274
	public string BonusNpcIconPath
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().NpcIconPath : null) ?? "";
		}
	}

	// Token: 0x17000D90 RID: 3472
	// (get) Token: 0x06007086 RID: 28806 RVA: 0x002280B0 File Offset: 0x002262B0
	public string BonusNpcContentTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().NpcContent : null) ?? "";
		}
	}

	// Token: 0x17000D91 RID: 3473
	// (get) Token: 0x06007087 RID: 28807 RVA: 0x002280EC File Offset: 0x002262EC
	public string BonusTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().BonusTxt : null) ?? "";
		}
	}

	// Token: 0x17000D92 RID: 3474
	// (get) Token: 0x06007088 RID: 28808 RVA: 0x00228128 File Offset: 0x00226328
	public int BonusCrestIndex
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			if (config == null)
			{
				return 0;
			}
			return config.GetValueOrDefault().CrestIndex;
		}
	}

	// Token: 0x17000D93 RID: 3475
	// (get) Token: 0x06007089 RID: 28809 RVA: 0x00228157 File Offset: 0x00226357
	public IReadOnlyList<PreheatSignRe> AllQuestCfg
	{
		get
		{
			return ConfigPreheatSignReAll.GetConfigList(true) ?? new List<PreheatSignRe>();
		}
	}
}

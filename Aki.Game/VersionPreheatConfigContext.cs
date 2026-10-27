using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001557 RID: 5463
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatConfigContext
{
	// Token: 0x06009C90 RID: 40080 RVA: 0x0021DD0C File Offset: 0x0021BF0C
	public string GetQuestTitleTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().MainTexPath : null) ?? "";
	}

	// Token: 0x06009C91 RID: 40081 RVA: 0x0021DD48 File Offset: 0x0021BF48
	public string GetQuestContentTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().QuestContent : null) ?? "";
	}

	// Token: 0x06009C92 RID: 40082 RVA: 0x0021DD84 File Offset: 0x0021BF84
	public string GetQuestBeforeThemeTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().ThemeBefore : null) ?? "";
	}

	// Token: 0x06009C93 RID: 40083 RVA: 0x0021DDC0 File Offset: 0x0021BFC0
	public string GetQuestAfterThemeTextIdById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().ThemeAfter : null) ?? "";
	}

	// Token: 0x06009C94 RID: 40084 RVA: 0x0021DDFC File Offset: 0x0021BFFC
	public string GetQuestPhotoPathById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().DisplayTex : null) ?? "";
	}

	// Token: 0x06009C95 RID: 40085 RVA: 0x0021DE38 File Offset: 0x0021C038
	public string GetQuestSharePhotoPathById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().ShareTex : null) ?? "";
	}

	// Token: 0x06009C96 RID: 40086 RVA: 0x0021DE74 File Offset: 0x0021C074
	public int GetQuestCrestIndexById(int id)
	{
		PreheatQuestText? config = ConfigPreheatQuestTextById.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().CrestIndex;
	}

	// Token: 0x06009C97 RID: 40087 RVA: 0x0021DEA4 File Offset: 0x0021C0A4
	public int GetQuestIdById(int id)
	{
		PreheatSignRe? config = ConfigPreheatSignReById.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().QuestId;
	}

	// Token: 0x06009C98 RID: 40088 RVA: 0x0021DED4 File Offset: 0x0021C0D4
	public int GetPreIdById(int id)
	{
		PreheatSignRe? config = ConfigPreheatSignReById.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().PreSignId;
	}

	// Token: 0x06009C99 RID: 40089 RVA: 0x0021DF04 File Offset: 0x0021C104
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

	// Token: 0x06009C9A RID: 40090 RVA: 0x0021DFB8 File Offset: 0x0021C1B8
	public string GetVoteTitleTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Title : null) ?? "";
	}

	// Token: 0x06009C9B RID: 40091 RVA: 0x0021DFF4 File Offset: 0x0021C1F4
	public string GetVoteContentTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Content : null) ?? "";
	}

	// Token: 0x06009C9C RID: 40092 RVA: 0x0021E030 File Offset: 0x0021C230
	public string GetVoteLeftThemeTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().OptionTheme1 : null) ?? "";
	}

	// Token: 0x06009C9D RID: 40093 RVA: 0x0021E06C File Offset: 0x0021C26C
	public string GetVoteRightThemeTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().OptionTheme2 : null) ?? "";
	}

	// Token: 0x06009C9E RID: 40094 RVA: 0x0021E0A8 File Offset: 0x0021C2A8
	public string GetVoteLeftTipsTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Option1 : null) ?? "";
	}

	// Token: 0x06009C9F RID: 40095 RVA: 0x0021E0E4 File Offset: 0x0021C2E4
	public string GetVoteRightTipsTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().Option2 : null) ?? "";
	}

	// Token: 0x06009CA0 RID: 40096 RVA: 0x0021E120 File Offset: 0x0021C320
	public string GetNpcContentTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().NpcContent : null) ?? "";
	}

	// Token: 0x06009CA1 RID: 40097 RVA: 0x0021E15C File Offset: 0x0021C35C
	public string GetNpcIconPathById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().NpcIconPath : null) ?? "";
	}

	// Token: 0x06009CA2 RID: 40098 RVA: 0x0021E198 File Offset: 0x0021C398
	public string GetSelfChatContentTextIdById(int id)
	{
		PreheatVote? config = ConfigPreheatVoteById.GetConfig(id, true);
		return ((config != null) ? config.GetValueOrDefault().OptionContent1 : null) ?? "";
	}

	// Token: 0x17000D6A RID: 3434
	// (get) Token: 0x06009CA3 RID: 40099 RVA: 0x0021E1D4 File Offset: 0x0021C3D4
	public string BonusPhotoPath
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().Photo : null) ?? "";
		}
	}

	// Token: 0x17000D6B RID: 3435
	// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x0021E210 File Offset: 0x0021C410
	public string BonusSharePhotoPath
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().SharePhoto : null) ?? "";
		}
	}

	// Token: 0x17000D6C RID: 3436
	// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x0021E24C File Offset: 0x0021C44C
	public string BonusQuestTitleTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().Title : null) ?? "";
		}
	}

	// Token: 0x17000D6D RID: 3437
	// (get) Token: 0x06009CA6 RID: 40102 RVA: 0x0021E288 File Offset: 0x0021C488
	public string BonusQuestContentTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().Content : null) ?? "";
		}
	}

	// Token: 0x17000D6E RID: 3438
	// (get) Token: 0x06009CA7 RID: 40103 RVA: 0x0021E2C4 File Offset: 0x0021C4C4
	public string BonusNpcIconPath
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().NpcIconPath : null) ?? "";
		}
	}

	// Token: 0x17000D6F RID: 3439
	// (get) Token: 0x06009CA8 RID: 40104 RVA: 0x0021E300 File Offset: 0x0021C500
	public string BonusNpcContentTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().NpcContent : null) ?? "";
		}
	}

	// Token: 0x17000D70 RID: 3440
	// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x0021E33C File Offset: 0x0021C53C
	public string BonusTextId
	{
		get
		{
			PreheatBonus? config = ConfigPreheatBonusById.GetConfig(1, true);
			return ((config != null) ? config.GetValueOrDefault().BonusTxt : null) ?? "";
		}
	}

	// Token: 0x17000D71 RID: 3441
	// (get) Token: 0x06009CAA RID: 40106 RVA: 0x0021E378 File Offset: 0x0021C578
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

	// Token: 0x17000D72 RID: 3442
	// (get) Token: 0x06009CAB RID: 40107 RVA: 0x0021E3A7 File Offset: 0x0021C5A7
	public IReadOnlyList<PreheatSignRe> AllQuestCfg
	{
		get
		{
			return ConfigPreheatSignReAll.GetConfigList(true) ?? new List<PreheatSignRe>();
		}
	}
}
